
namespace FinaTrackProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Titlelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Newlbl = new System.Windows.Forms.Label();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.FinTrackPicbx = new System.Windows.Forms.PictureBox();
            this.Welcomelbl = new System.Windows.Forms.Label();
            this.UserIDlbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.UserIDBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.ShowPassCbx = new System.Windows.Forms.CheckBox();
            this.SignInbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinTrackPicbx)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlelbl
            // 
            this.Titlelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Titlelbl.BackColor = System.Drawing.Color.Honeydew;
            this.Titlelbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(466, 38);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Titlelbl.Size = new System.Drawing.Size(414, 70);
            this.Titlelbl.TabIndex = 0;
            this.Titlelbl.Text = "Finance Tracker";
            this.Titlelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.Newlbl);
            this.panel1.Controls.Add(this.Registerbtn);
            this.panel1.Controls.Add(this.FinTrackPicbx);
            this.panel1.Controls.Add(this.Welcomelbl);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 583);
            this.panel1.TabIndex = 2;
            // 
            // Newlbl
            // 
            this.Newlbl.AutoSize = true;
            this.Newlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newlbl.Location = new System.Drawing.Point(45, 451);
            this.Newlbl.Name = "Newlbl";
            this.Newlbl.Size = new System.Drawing.Size(205, 32);
            this.Newlbl.TabIndex = 3;
            this.Newlbl.Text = "New to the App?";
            // 
            // Registerbtn
            // 
            this.Registerbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.Registerbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbtn.Location = new System.Drawing.Point(85, 508);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(117, 45);
            this.Registerbtn.TabIndex = 2;
            this.Registerbtn.Text = "Register!!";
            this.toolTip4.SetToolTip(this.Registerbtn, "Register your own account!");
            this.Registerbtn.UseVisualStyleBackColor = false;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // FinTrackPicbx
            // 
            this.FinTrackPicbx.Image = ((System.Drawing.Image)(resources.GetObject("FinTrackPicbx.Image")));
            this.FinTrackPicbx.Location = new System.Drawing.Point(85, 32);
            this.FinTrackPicbx.Name = "FinTrackPicbx";
            this.FinTrackPicbx.Size = new System.Drawing.Size(117, 118);
            this.FinTrackPicbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FinTrackPicbx.TabIndex = 1;
            this.FinTrackPicbx.TabStop = false;
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelbl.Location = new System.Drawing.Point(44, 153);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(231, 115);
            this.Welcomelbl.TabIndex = 0;
            this.Welcomelbl.Text = "Welcome to \r\nYour Personal \r\nFinance Tracker\r\n";
            // 
            // UserIDlbl
            // 
            this.UserIDlbl.AutoSize = true;
            this.UserIDlbl.BackColor = System.Drawing.Color.GhostWhite;
            this.UserIDlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDlbl.Location = new System.Drawing.Point(461, 211);
            this.UserIDlbl.Name = "UserIDlbl";
            this.UserIDlbl.Size = new System.Drawing.Size(74, 28);
            this.UserIDlbl.TabIndex = 3;
            this.UserIDlbl.Text = "UserID:";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.BackColor = System.Drawing.Color.GhostWhite;
            this.Passwordlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlbl.Location = new System.Drawing.Point(461, 267);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(97, 28);
            this.Passwordlbl.TabIndex = 4;
            this.Passwordlbl.Text = "Password:";
            // 
            // UserIDBox
            // 
            this.UserIDBox.Location = new System.Drawing.Point(630, 209);
            this.UserIDBox.Name = "UserIDBox";
            this.UserIDBox.Size = new System.Drawing.Size(250, 26);
            this.UserIDBox.TabIndex = 5;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(630, 267);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(250, 26);
            this.PasswordBox.TabIndex = 6;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // ShowPassCbx
            // 
            this.ShowPassCbx.AutoSize = true;
            this.ShowPassCbx.BackColor = System.Drawing.Color.GhostWhite;
            this.ShowPassCbx.Location = new System.Drawing.Point(681, 313);
            this.ShowPassCbx.Name = "ShowPassCbx";
            this.ShowPassCbx.Size = new System.Drawing.Size(148, 24);
            this.ShowPassCbx.TabIndex = 7;
            this.ShowPassCbx.Text = "Show Password";
            this.toolTip1.SetToolTip(this.ShowPassCbx, "Unhide your password.");
            this.ShowPassCbx.UseVisualStyleBackColor = false;
            this.ShowPassCbx.CheckedChanged += new System.EventHandler(this.ShowPassCbx_CheckedChanged);
            // 
            // SignInbtn
            // 
            this.SignInbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.SignInbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInbtn.Location = new System.Drawing.Point(474, 424);
            this.SignInbtn.Name = "SignInbtn";
            this.SignInbtn.Size = new System.Drawing.Size(145, 61);
            this.SignInbtn.TabIndex = 8;
            this.SignInbtn.Text = "Sign In";
            this.toolTip3.SetToolTip(this.SignInbtn, "Sign into your profile!");
            this.SignInbtn.UseVisualStyleBackColor = false;
            this.SignInbtn.Click += new System.EventHandler(this.SignInbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(777, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.toolTip2.SetToolTip(this.button1, "Close the entire application.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1026, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SignInbtn);
            this.Controls.Add(this.ShowPassCbx);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserIDBox);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.UserIDlbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Titlelbl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Finance Tracker Login Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinTrackPicbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Newlbl;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.PictureBox FinTrackPicbx;
        private System.Windows.Forms.Label Welcomelbl;
        private System.Windows.Forms.Label UserIDlbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.TextBox UserIDBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.CheckBox ShowPassCbx;
        private System.Windows.Forms.Button SignInbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

