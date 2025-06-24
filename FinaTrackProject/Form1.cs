using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinaTrackProject
{
    public partial class Form1 : Form
    {
        RegisterForm registerFormRef;
        public Form1(RegisterForm form)
        {
            InitializeComponent();
            this.registerFormRef = form;
        }

        public Form1()
        {
            InitializeComponent();
        }

        //This button hides the Log in form and displays the Register form.
        private void Registerbtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        //This handles the Show password checkbox.
        private void ShowPassCbx_CheckedChanged(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = !ShowPassCbx.Checked;
        }
        
        //The following checks whether the user inputs values in the textboxes, if not, an error message is displayed.
        private void SignInbtn_Click(object sender, EventArgs e)
        {
            string userID = UserIDBox.Text.Trim();
            string password = PasswordBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(userID) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both User ID and Password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool foundMatch = false;

                // Read all lines from the text file with the account details
                string[] allLines = File.ReadAllLines("TextFile1.txt");

                foreach (string line in allLines)
                {
                    string[] parts = line.Split(','); 

                    if (parts.Length == 2)
                    {
                        string storedUserID = parts[0].Trim().ToLower();
                        string storedPassword = parts[1].Trim();

                        if (userID.Trim().ToLower() == storedUserID && password == storedPassword)
                        {
                            foundMatch = true;
                            break;
                        }
                    }
                }
                //If a match is found, the user sees a message saying they have successfully signed in
                if (foundMatch)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string userName = UserIDBox.Text;
                    TransactionManagement tmForm = new TransactionManagement(registerFormRef);
                    tmForm.SetUserName(userName);
                    tmForm.Show();
                    this.Hide();
                }
                else
                {
                    //Should the account not exist or if the input was invalid, the user sees an error message
                    MessageBox.Show("This account does not exist. Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
               //If there are any unexpected exceptions, the user will see this message
                MessageBox.Show("An error has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


            //This button closes the entire program.
            private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This shows the Help form, while remembering which form the user was on
            HelpForm helpForm = new HelpForm(this);
            helpForm.Show();
        }
    }
}
