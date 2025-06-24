using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinaTrackProject
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
           //This ensures that when the form is closed, this method will be called automatically.
            this.FormClosing += RegisterForm_FormClosing;

            //This will ensure that the passwords can not be viewed by third parties while the user is interacting with the interface.
            RegPassBox.PasswordChar = '*';
            RegConfirmPassBox.PasswordChar = '*';
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           //This ensures that when the register form is closed, the user is redirected to the main form where they can log in.
            Form1 mainForm = new Form1(this);
            mainForm.Show();
            this.Hide();
        }
               
        
        private void CreateAccountbtn_Click(object sender, EventArgs e)
        {
            // Should the user create an account, the account details are stored.
            string username = RegUserIDBox.Text.Trim();
            string password = RegPassBox.Text;
            string confirmPassword = RegConfirmPassBox.Text;

            string filePath = Path.Combine(Application.StartupPath, "TextFile1.txt");

            //Throught the use of data validation, the user will be notified if they do not input their details.
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Enter your detials before you move on!!!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //The following code ensures the user enters a valid, matching password.
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Read all lines from the file
                string[] allLines = File.ReadAllLines(filePath);
                bool userExists = false;
                bool passwordMatch = false;

                // Check if the username already exists
                foreach (string line in allLines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        string storedUserID = parts[0].Trim();
                        string storedPassword = parts[1].Trim();

                        // If username matches, check if the password matches as well
                        if (storedUserID == username)
                        {
                            userExists = true;
                            if (storedPassword == password)
                            {
                                passwordMatch = true;
                            }
                            break;
                        }
                    }
                }

                // If the username exists but password doesn't match
                if (userExists && !passwordMatch)
                {
                    MessageBox.Show("The passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // If the user already exists with the same password
                if (userExists && passwordMatch)
                {
                    MessageBox.Show(" This account already exists. Please try again with different details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Append the new details to the file if username doesn't exist
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{username},{password}");
                }

                MessageBox.Show("Account created and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the textboxes after account creation
                RegUserIDBox.Clear();
                RegPassBox.Clear();
                RegConfirmPassBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }     

        //This a log out button, it will take the user back to the Log in form.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dashboard = new Form1(this);
            dashboard.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //This shows the Help form, while remembering which form the user was on
            HelpForm helpForm = new HelpForm(this);
            helpForm.Show();
        }
    }

}
