
namespace FinaTrackProject
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.RegUserIDlbl = new System.Windows.Forms.Label();
            this.RegPasswordlbl = new System.Windows.Forms.Label();
            this.RegConfirmPasslbl = new System.Windows.Forms.Label();
            this.RegUserIDBox = new System.Windows.Forms.TextBox();
            this.RegPassBox = new System.Windows.Forms.TextBox();
            this.RegConfirmPassBox = new System.Windows.Forms.TextBox();
            this.CreateAccountbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegUserIDlbl
            // 
            this.RegUserIDlbl.AutoSize = true;
            this.RegUserIDlbl.BackColor = System.Drawing.Color.GhostWhite;
            this.RegUserIDlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegUserIDlbl.Location = new System.Drawing.Point(281, 133);
            this.RegUserIDlbl.Name = "RegUserIDlbl";
            this.RegUserIDlbl.Size = new System.Drawing.Size(74, 28);
            this.RegUserIDlbl.TabIndex = 4;
            this.RegUserIDlbl.Text = "UserID:";
            // 
            // RegPasswordlbl
            // 
            this.RegPasswordlbl.AutoSize = true;
            this.RegPasswordlbl.BackColor = System.Drawing.Color.GhostWhite;
            this.RegPasswordlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPasswordlbl.Location = new System.Drawing.Point(281, 227);
            this.RegPasswordlbl.Name = "RegPasswordlbl";
            this.RegPasswordlbl.Size = new System.Drawing.Size(97, 28);
            this.RegPasswordlbl.TabIndex = 5;
            this.RegPasswordlbl.Text = "Password:";
            // 
            // RegConfirmPasslbl
            // 
            this.RegConfirmPasslbl.AutoSize = true;
            this.RegConfirmPasslbl.BackColor = System.Drawing.Color.GhostWhite;
            this.RegConfirmPasslbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegConfirmPasslbl.Location = new System.Drawing.Point(281, 325);
            this.RegConfirmPasslbl.Name = "RegConfirmPasslbl";
            this.RegConfirmPasslbl.Size = new System.Drawing.Size(172, 28);
            this.RegConfirmPasslbl.TabIndex = 6;
            this.RegConfirmPasslbl.Text = "Confirm Password:";
            // 
            // RegUserIDBox
            // 
            this.RegUserIDBox.Location = new System.Drawing.Point(474, 137);
            this.RegUserIDBox.Name = "RegUserIDBox";
            this.RegUserIDBox.Size = new System.Drawing.Size(328, 26);
            this.RegUserIDBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.RegUserIDBox, "Enter your userID");
            // 
            // RegPassBox
            // 
            this.RegPassBox.Location = new System.Drawing.Point(474, 227);
            this.RegPassBox.Name = "RegPassBox";
            this.RegPassBox.Size = new System.Drawing.Size(328, 26);
            this.RegPassBox.TabIndex = 8;
            this.toolTip2.SetToolTip(this.RegPassBox, "Enter your password.");
            // 
            // RegConfirmPassBox
            // 
            this.RegConfirmPassBox.Location = new System.Drawing.Point(474, 329);
            this.RegConfirmPassBox.Name = "RegConfirmPassBox";
            this.RegConfirmPassBox.Size = new System.Drawing.Size(328, 26);
            this.RegConfirmPassBox.TabIndex = 9;
            this.toolTip3.SetToolTip(this.RegConfirmPassBox, "Confirm your password.");
            // 
            // CreateAccountbtn
            // 
            this.CreateAccountbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountbtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CreateAccountbtn.Location = new System.Drawing.Point(286, 389);
            this.CreateAccountbtn.Name = "CreateAccountbtn";
            this.CreateAccountbtn.Size = new System.Drawing.Size(284, 53);
            this.CreateAccountbtn.TabIndex = 10;
            this.CreateAccountbtn.Text = "Create Account";
            this.CreateAccountbtn.UseVisualStyleBackColor = true;
            this.CreateAccountbtn.Click += new System.EventHandler(this.CreateAccountbtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(576, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.toolTip4.SetToolTip(this.button1, "Go back to the Log in form.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(398, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Create Your Account!";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(695, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 51);
            this.button2.TabIndex = 16;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinaTrackProject.Properties.Resources.FanTrack_Background;
            this.ClientSize = new System.Drawing.Size(1026, 579);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreateAccountbtn);
            this.Controls.Add(this.RegConfirmPassBox);
            this.Controls.Add(this.RegPassBox);
            this.Controls.Add(this.RegUserIDBox);
            this.Controls.Add(this.RegConfirmPasslbl);
            this.Controls.Add(this.RegPasswordlbl);
            this.Controls.Add(this.RegUserIDlbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "LumiaX Account Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegUserIDlbl;
        private System.Windows.Forms.Label RegPasswordlbl;
        private System.Windows.Forms.Label RegConfirmPasslbl;
        private System.Windows.Forms.TextBox RegUserIDBox;
        private System.Windows.Forms.TextBox RegPassBox;
        private System.Windows.Forms.TextBox RegConfirmPassBox;
        private System.Windows.Forms.Button CreateAccountbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}