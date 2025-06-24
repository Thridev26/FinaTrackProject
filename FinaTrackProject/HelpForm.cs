using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinaTrackProject
{
    public partial class HelpForm : Form
    {
        //This stores the previous form the user was on, so that can be redirected to the same form upon clicking the back button.
        private Form previousForm;

        public HelpForm(Form previousForm)
        {
            InitializeComponent();

            this.previousForm = previousForm;

            helpListBox.SelectedIndexChanged += HelpListBox_SelectedIndexChanged;          
                       
                        
        }

        // Event handler for when the user selects an item in the ListBox
        private void HelpListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (helpListBox.SelectedItem != null)
            {
                //Read what the user has selected
                string selectedItem = helpListBox.SelectedItem.ToString(); 

                // Change the TextBox content based on the selected item
                if (selectedItem == "Log In Help")
                {
                    helpTextBox.Text = "To Log in: " + Environment.NewLine + "1. Enter your User ID and Password. " + Environment.NewLine + "2. Click 'Sign In'." + Environment.NewLine + "3. If you don't have an account, click 'Register'.";
                }
                else if (selectedItem == "Register Account Help")
                {
                    helpTextBox.Text = "To  Register: " + Environment.NewLine + "1. Enter a unique User ID and Password." + Environment.NewLine + "2. Ensure the password matches in both fields.";
                }
                else if (selectedItem == "Transaction Management Help")
                {
                    helpTextBox.Text = "In Transaction Management:" + Environment.NewLine + "1. You can Add and Manage and Remove your transactions." + Environment.NewLine + "2. You can also view your live account balance" + Environment.NewLine + "3. You can save them to print your statement";
                }
                else if(selectedItem == "Privacy Policy")
                {
                    helpTextBox.Text = @"
Privacy Policy

Effective Date: [06 May 2025]

Your Personal Finance Tracker respects your privacy and is committed to protecting the personal information you share with us. This Privacy Policy explains how we collect, use, disclose, and safeguard your information when you use the App.

By using our App, you consent to the practices described in this Privacy Policy. Please read this policy carefully to understand our views and practices regarding your personal data and how we will treat it.

1. Information We Collect
We do not collect any personally identifiable information unless you voluntarily provide it to us. The information collected may include:
-User Information: Only the user ID and password you provide during account creation are stored, and this is saved locally on your device in a plain text file.
-Usage Data: LumiaX does not collect IP addresses, browser types, operating systems, or any other system usage data, as it operates fully offline.

LumiaX does not collect or store:
-IP addresses
-Device IDs
-Browser or system data
-Location data
-Background analytics

2. How We Use Your Information
We use the information we collect for the following purposes:
- To provide and improve the functionality of the App.
- To personalize your experience.
- To communicate with you regarding updates, notifications, or other important information about the App.
- To respond to your inquiries or customer service requests.

3. Data Security
We take appropriate measures to protect your personal information from unauthorized access, alteration, disclosure, or destruction. However, please note that no method of transmission over the Internet or method of electronic storage is 100% secure.

4. Sharing Your Information
We do not sell, rent, or share your personal information with third parties, except in the following cases:
- With your consent.
- To comply with legal obligations, such as responding to legal requests or protecting our rights and safety.
- To service providers or vendors who assist us in providing the App (e.g., cloud hosting services), but only to the extent necessary to perform their services.

5. Third-Party Services
LumiaX currently does not use any third-party services, APIs, or cloud integrations. All features work entirely offline. If future updates introduce such features, this policy will be updated accordingly.
However, the App may contain links to external websites or services that are not operated by us. We are not responsible for the privacy practices of these third-party services. We encourage you to review their privacy policies when you visit them.

6. Cookies
Since LumiaX is a desktop-based offline application, cookies and web trackers are not used.

7. Children’s Privacy
The App is not intended for use by children under the age of 13. We do not knowingly collect personal information from children under the age of 13. If you believe we have collected information from a child under 13, please contact us immediately, and we will take steps to delete such information.

8. Your Rights and Choices
You have the right to:
- Access, update, or delete your personal information.
- Opt-out of marketing communications by following the instructions provided in those communications.
- Request to restrict or object to the processing of your personal information.

To exercise any of these rights, please contact us at +27 64 689 4586 or LumiaX@customersupport.mail

9. Changes to This Privacy Policy
We may update this Privacy Policy from time to time. Any changes will be posted on this page, and the updated date will be reflected at the top of the policy. We encourage you to review this policy periodically for any updates.

10. Contact Us
If you have any questions or concerns about this Privacy Policy or our data practices, please contact us at:

LumiaX  
Contact us at LumiaX@customersupport.mail

By using the App, you acknowledge that you have read and understood this Privacy Policy.
";
                }
                else
                {
                    helpTextBox.Text = "Select a help topic from the list to see details.";
                }
            }
            else
            {
                // If no item is selected, revert to the following text
                helpTextBox.Text = "Please select a help topic from the list.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Redirect user to previous form
            this.Close();            
            previousForm.Show();
        }
    }
}

