
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
            this.RegUserIDlbl = new System.Windows.Forms.Label();
            this.RegPasswordlbl = new System.Windows.Forms.Label();
            this.RegConfirmPasslbl = new System.Windows.Forms.Label();
            this.RegUserIDBox = new System.Windows.Forms.TextBox();
            this.RegPassBox = new System.Windows.Forms.TextBox();
            this.RegConfirmPassBox = new System.Windows.Forms.TextBox();
            this.CreateAccountbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
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
            this.RegUserIDBox.Location = new System.Drawing.Point(474, 133);
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
            this.CreateAccountbtn.Location = new System.Drawing.Point(322, 389);
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
            this.button1.Location = new System.Drawing.Point(621, 389);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(894, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 264);
            this.listBox1.TabIndex = 13;
            this.listBox1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(894, 303);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 264);
            this.listBox2.TabIndex = 14;
            this.listBox2.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinaTrackProject.Properties.Resources.FanTrack_Background;
            this.ClientSize = new System.Drawing.Size(1026, 579);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreateAccountbtn);
            this.Controls.Add(this.RegConfirmPassBox);
            this.Controls.Add(this.RegPassBox);
            this.Controls.Add(this.RegUserIDBox);
            this.Controls.Add(this.RegConfirmPasslbl);
            this.Controls.Add(this.RegPasswordlbl);
            this.Controls.Add(this.RegUserIDlbl);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "Finance Tracker Register Form";
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
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}