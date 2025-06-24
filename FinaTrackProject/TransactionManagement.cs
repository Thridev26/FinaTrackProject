using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FinaTrackProject
{
    public partial class TransactionManagement : Form
    {
        // Stores the user's running financial totals: income, expenses, and the resulting balance
        private decimal totalIncome = 0;
        private decimal totalExpense = 0;
        private decimal currentBalance = 0;

        // Store a reference to the Register form to interact with it if needed
        private RegisterForm registerFormref;
        
        
        public TransactionManagement(RegisterForm form)
        {
            InitializeComponent();
            this.registerFormref = form;
        }

        //When the user signs in, their user name will show up in the top left corner.
        public void SetUserName(string userName)
        {
            Accountlbl.Text = "Profile:" + userName;
        }

        private void TransactionManagement_Load(object sender, EventArgs e)
        {
            // Updates the labels to show the latest info
            UpdateLabels();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Store input from the relevant textboxes, while trimming extra spaces
            string amountText = AmountBox.Text.Trim();
            string description = DescriptionBox.Text.Trim();

            //Check that a transaction type is selected
            if (TransactionTypecbx.SelectedItem == null)
            {
                MessageBox.Show("Please select a transaction type.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Store the option selected by the user
            string transactionType = TransactionTypecbx.SelectedItem.ToString();

           //Ensure the user does not proceed with an empty textbox
            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Description cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Ensure the user does not leave the Amount box empty
            if (!decimal.TryParse(amountText, out decimal amount))
            {
                MessageBox.Show("Please enter a valid numeric amount." + Environment.NewLine + "Note: Do not add a currency symbol.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CultureInfo saCulture = new CultureInfo("en-ZA");
            string transactionDetails = $"{transactionType}: {amount.ToString("C", saCulture)} - {description}";
            TransactionsListBox.Items.Add(transactionDetails);

            // Based on what the user picked (Income, Expense, or neither), update totals.
            // If nothing is selected, treat it like a starting balance.
            if (transactionType == "Income")
            {
                totalIncome += amount;
                currentBalance = totalIncome - totalExpense;
            }
            else if (transactionType == "Expense")
            {
                totalExpense += amount;
                currentBalance = totalIncome - totalExpense;
            }
            else if (transactionType == "Balance")
            {
                currentBalance = amount;
                currentBalance = currentBalance - totalExpense + totalIncome;
            }

           //Update the labels and clear the textboxes
            UpdateLabels();

            AmountBox.Clear();
            DescriptionBox.Clear();
            TransactionTypecbx.SelectedIndex = -1;
        }

        private void UpdateLabels()
        {

           //The following code displays the totals in the labels as the user updates the transactions
            var southAfricanCulture = new CultureInfo("en-ZA");

            Balancelbl.Text = $"Balance: {currentBalance.ToString("C2", southAfricanCulture)}";
            Incomelbl.Text = $"Income: {totalIncome.ToString("C2", southAfricanCulture)}";
            Expenselbl.Text = $"Expense: {totalExpense.ToString("C2", southAfricanCulture)}";

            //The following will change the colour of the balance labels should the user reach a negative balance.
            if (currentBalance < 0)
            {
                Balancelbl.ForeColor = Color.Red;
            }
            else
            {
                Balancelbl.ForeColor = Color.Black; 
            }
        }

        // Hide this form and reopen the login screen so the user can sign in again or close the app
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(registerFormref);   
            form1.Show();                 
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            /*
             * This allows the user to save the transaction list to a file
             * Should the user want to print their transaction for Proof of payment/Bank statement
             */
            if (TransactionsListBox.Items.Count == 0)
            {
                MessageBox.Show("There are no transactions to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            saveFileDialog1.Title = "Save Transactions";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = "Transactions Statement.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                    {
                        foreach (var item in TransactionsListBox.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }

                    MessageBox.Show("Transactions saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This shows the Help form, while remembering which form the user was on
            HelpForm helpForm = new HelpForm(this);
                       
            helpForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if a transaction is selected
            if (TransactionsListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a transaction to remove.");
                return;
            }

            // Get the selected transaction from the listbox
            string selectedTransaction = TransactionsListBox.SelectedItem.ToString();

            // Determine if the transaction is an income or an expense            
            decimal transactionAmount = 0;
            string transactionType = string.Empty;

            // Extracting the type and the amount from the selected transaction 
            if (selectedTransaction.StartsWith("Income"))
            {
                transactionType = "Income";
                transactionAmount = ExtractAmountFromTransaction(selectedTransaction);
            }
            else if (selectedTransaction.StartsWith("Expense"))
            {
                transactionType = "Expense";
                transactionAmount = ExtractAmountFromTransaction(selectedTransaction);
            }

            // Reverse the transaction by updating the corresponding label values
            if (transactionType == "Income")
            {
                // Reverse the income
                currentBalance -= transactionAmount;
                totalIncome -= transactionAmount;
            }
            else if (transactionType == "Expense")
            {
                // Reverse the expense 
                currentBalance += transactionAmount;
                totalExpense -= transactionAmount;
            }

            // Remove the selected transaction from the ListBox
            TransactionsListBox.Items.Remove(TransactionsListBox.SelectedItem);

            // Update the labels to reflect the new totals after the removal
            UpdateLabels();
        }

        private decimal ExtractAmountFromTransaction(string transaction)
        {
            // This method extracts the amount from the transaction             

            string[] transactionParts = transaction.Split('-');
            string amountString = transactionParts[0].Split(':')[1].Trim();

            // Remove the currency symbol and parse the numeric value
            amountString = amountString.Replace("R", "").Trim();

            // Try parsing the amount string into a decimal
            decimal amount = 0;
            decimal.TryParse(amountString, out amount);

            return amount;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TransactionsListBox.Items.Clear();

            // Reset all tracking variables
            totalIncome = 0;
            totalExpense = 0;
            currentBalance = 0;

            // Update the labels to reflect the reset values
            UpdateLabels();
        }
    }
}
