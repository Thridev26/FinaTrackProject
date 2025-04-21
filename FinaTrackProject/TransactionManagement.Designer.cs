
namespace FinaTrackProject
{
    partial class TransactionManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.TransactionTypecbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Balancelbl = new System.Windows.Forms.Label();
            this.Incomelbl = new System.Windows.Forms.Label();
            this.Expenselbl = new System.Windows.Forms.Label();
            this.TransactionsListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.Accountlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO TRANSACTION MANAGEMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transaction Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(332, 119);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(377, 26);
            this.AmountBox.TabIndex = 3;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(332, 191);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(377, 26);
            this.DescriptionBox.TabIndex = 4;
            // 
            // TransactionTypecbx
            // 
            this.TransactionTypecbx.FormattingEnabled = true;
            this.TransactionTypecbx.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.TransactionTypecbx.Location = new System.Drawing.Point(332, 255);
            this.TransactionTypecbx.Name = "TransactionTypecbx";
            this.TransactionTypecbx.Size = new System.Drawing.Size(377, 28);
            this.TransactionTypecbx.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Transaction Type:";
            // 
            // Balancelbl
            // 
            this.Balancelbl.AutoSize = true;
            this.Balancelbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelbl.Location = new System.Drawing.Point(858, 116);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(157, 28);
            this.Balancelbl.TabIndex = 7;
            this.Balancelbl.Text = "Balance : R0.00";
            // 
            // Incomelbl
            // 
            this.Incomelbl.AutoSize = true;
            this.Incomelbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incomelbl.Location = new System.Drawing.Point(858, 194);
            this.Incomelbl.Name = "Incomelbl";
            this.Incomelbl.Size = new System.Drawing.Size(152, 28);
            this.Incomelbl.TabIndex = 8;
            this.Incomelbl.Text = "Income : R0.00";
            // 
            // Expenselbl
            // 
            this.Expenselbl.AutoSize = true;
            this.Expenselbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenselbl.Location = new System.Drawing.Point(858, 255);
            this.Expenselbl.Name = "Expenselbl";
            this.Expenselbl.Size = new System.Drawing.Size(160, 28);
            this.Expenselbl.TabIndex = 9;
            this.Expenselbl.Text = "Expense : R0.00";
            // 
            // TransactionsListBox
            // 
            this.TransactionsListBox.FormattingEnabled = true;
            this.TransactionsListBox.ItemHeight = 20;
            this.TransactionsListBox.Location = new System.Drawing.Point(67, 361);
            this.TransactionsListBox.Name = "TransactionsListBox";
            this.TransactionsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.TransactionsListBox.Size = new System.Drawing.Size(937, 144);
            this.TransactionsListBox.TabIndex = 10;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Location = new System.Drawing.Point(67, 297);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(151, 39);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add Transaction";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.Black;
            this.LogOutButton.Location = new System.Drawing.Point(67, 528);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(132, 39);
            this.LogOutButton.TabIndex = 12;
            this.LogOutButton.Text = "LOG OUT";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // Accountlbl
            // 
            this.Accountlbl.BackColor = System.Drawing.Color.RoyalBlue;
            this.Accountlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Accountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accountlbl.Location = new System.Drawing.Point(63, 29);
            this.Accountlbl.Name = "Accountlbl";
            this.Accountlbl.Size = new System.Drawing.Size(183, 32);
            this.Accountlbl.TabIndex = 13;
            this.Accountlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransactionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinaTrackProject.Properties.Resources.FanTrack_Background;
            this.ClientSize = new System.Drawing.Size(1026, 579);
            this.Controls.Add(this.Accountlbl);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TransactionsListBox);
            this.Controls.Add(this.Expenselbl);
            this.Controls.Add(this.Incomelbl);
            this.Controls.Add(this.Balancelbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TransactionTypecbx);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TransactionManagement";
            this.Text = "Finance Tracker Transaction Management Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.ComboBox TransactionTypecbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Balancelbl;
        private System.Windows.Forms.Label Incomelbl;
        private System.Windows.Forms.Label Expenselbl;
        private System.Windows.Forms.ListBox TransactionsListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label Accountlbl;
    }
}