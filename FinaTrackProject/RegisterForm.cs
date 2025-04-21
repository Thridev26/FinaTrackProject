using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinaTrackProject
{
    public partial class RegisterForm : Form
    {        
        public ListBox listbox1 => listBox1;
        public ListBox listbox2 => listBox2; 

        
        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 mainForm = new Form1(this);
            mainForm.Show();
            this.Hide();
        }
        public RegisterForm()
        {
            InitializeComponent();
            this.FormClosing += RegisterForm_FormClosing;

            RegPassBox.PasswordChar = '*';
            RegConfirmPassBox.PasswordChar = '*'; 
        }
        
         //Should the user create an account, the values are stored.
        private void CreateAccountbtn_Click(object sender, EventArgs e)
        {
            string username = RegUserIDBox.Text.Trim();
            string password = RegPassBox.Text;
            string confirmPassword = RegConfirmPassBox.Text;           


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Enter your detials before you move on!!!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }      
            
            listBox1.Items.Add(RegUserIDBox.Text);
            listBox2.Items.Add(RegPassBox.Text);            

            RegUserIDBox.Clear();
            RegPassBox.Clear();
            RegConfirmPassBox.Clear();

            this.Close();         

        }

        //This a log out button, it will take the user back to the Log in form.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dashboard = new Form1(this);
            dashboard.Show();
        }
    }

}
