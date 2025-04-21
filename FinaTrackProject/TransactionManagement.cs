using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinaTrackProject
{
    public partial class TransactionManagement : Form
    {
        private double totalIncome = 0;
        private double totalExpense = 0;
        private double currentBalance = 0;
        private RegisterForm registerFormref;
        public TransactionManagement(RegisterForm form)
        {
            InitializeComponent();
            this.registerFormref = form;
        }

        //When the user signs in, their user name will show up in the top left corner.
        public void SetUserName(string userName)
        {
            Accountlbl.Text = "Profile: " + userName; 
        }



        private void TransactionManagement_Load(object sender, EventArgs e)
        {
            
            UpdateLabels();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string amountText = AmountBox.Text.Trim();
            string description = DescriptionBox.Text.Trim();

            if (TransactionTypecbx.SelectedItem == null)
            {
                MessageBox.Show("Please select a transaction type.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string transactionType = TransactionTypecbx.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(description) || description.All(char.IsDigit))
            {
                MessageBox.Show("Description cannot be empty or contain only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(amountText, out double amount))
            {
                MessageBox.Show("Please enter a valid numeric amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CultureInfo saCulture = new CultureInfo("en-ZA"); 
            string transactionDetails = $"{transactionType}: {amount.ToString("C", saCulture)} - {description}";
            TransactionsListBox.Items.Add(transactionDetails);

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

            UpdateLabels();

            AmountBox.Clear();
            DescriptionBox.Clear();
            TransactionTypecbx.SelectedIndex = -1;
        }

        private void UpdateLabels()
        {

            var southAfricanCulture = new CultureInfo("en-ZA");

            Balancelbl.Text = $"Balance: {currentBalance.ToString("C2", southAfricanCulture)}";
            Incomelbl.Text = $"Income: {totalIncome.ToString("C2", southAfricanCulture)}";
            Expenselbl.Text = $"Expense: {totalExpense.ToString("C2", southAfricanCulture)}";
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(registerFormref);   
            form1.Show();                 
            this.Hide();
        }
    }
}
