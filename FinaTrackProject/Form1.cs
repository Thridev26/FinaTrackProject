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

        /*
         * This is the sign in button.
         * It checks whether the user inputs values in the textboxes, if not, an error message is displayed.
         * Using a for loop, the data from the listboxes on the Register form is read, and matched against the users input.
         * If the user inputs valid details, the Transaction Management form is displayed.
         */
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

                // Ensure registerFormRef and listboxes are not null
                if (registerFormRef == null)
                {
                    MessageBox.Show("There are no records of this account." + Environment.NewLine + "Click Register! to create your account!", "Heads Up!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (registerFormRef.listBox1 == null || registerFormRef.listBox2 == null)
                {
                    MessageBox.Show("You do not exist in our records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                

                // Loop through the items to check for matching credentials
                for (int i = 0; i < registerFormRef.listBox1.Items.Count; i++)
                {
                    string storedUserID = registerFormRef.listBox1.Items[i].ToString();
                    string storedPassword = registerFormRef.listBox2.Items[i].ToString();

                    // Trim any extra spaces before comparison
                    if (userID.Equals(storedUserID.Trim()) && password.Equals(storedPassword.Trim()))
                    {
                        foundMatch = true;
                        break; 
                    }
                }

                
                if (foundMatch)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Passing the username to the next form
                    string userName = UserIDBox.Text;
                    TransactionManagement tmForm = new TransactionManagement(this.registerFormRef);
                    tmForm.SetUserName(userName); // Assuming you have a method to set the user name in TransactionManagement
                    tmForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException ex)
            {
                // Specifically handle null reference exceptions
                MessageBox.Show("An error occurred due to a null reference: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Catch all other exceptions
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                  

        //This button closes the entire program.
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
