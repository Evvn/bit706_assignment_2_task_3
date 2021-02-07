
namespace customer_app
{
    partial class frmManageAccounts
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
            this.comboCustomers = new System.Windows.Forms.ComboBox();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnAddNewAccount = new System.Windows.Forms.Button();
            this.btnMakeTransfer = new System.Windows.Forms.Button();
            this.btnAddInterest = new System.Windows.Forms.Button();
            this.lblSelectAccount = new System.Windows.Forms.Label();
            this.comboAccounts = new System.Windows.Forms.ComboBox();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboCustomers
            // 
            this.comboCustomers.FormattingEnabled = true;
            this.comboCustomers.Location = new System.Drawing.Point(69, 150);
            this.comboCustomers.Name = "comboCustomers";
            this.comboCustomers.Size = new System.Drawing.Size(182, 33);
            this.comboCustomers.TabIndex = 0;
            this.comboCustomers.SelectedIndexChanged += new System.EventHandler(this.comboCustomers_SelectedIndexChanged);
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAppTitle.Location = new System.Drawing.Point(29, 33);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(715, 60);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "Customer account management";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(69, 106);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(172, 30);
            this.lblFirstName.TabIndex = 14;
            this.lblFirstName.Text = "Select customer:";
            // 
            // btnAddNewAccount
            // 
            this.btnAddNewAccount.BackColor = System.Drawing.Color.Navy;
            this.btnAddNewAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewAccount.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAddNewAccount.Location = new System.Drawing.Point(352, 117);
            this.btnAddNewAccount.Name = "btnAddNewAccount";
            this.btnAddNewAccount.Size = new System.Drawing.Size(250, 75);
            this.btnAddNewAccount.TabIndex = 15;
            this.btnAddNewAccount.Text = "Add new account";
            this.btnAddNewAccount.UseVisualStyleBackColor = false;
            // 
            // btnMakeTransfer
            // 
            this.btnMakeTransfer.BackColor = System.Drawing.Color.Navy;
            this.btnMakeTransfer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMakeTransfer.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnMakeTransfer.Location = new System.Drawing.Point(352, 218);
            this.btnMakeTransfer.Name = "btnMakeTransfer";
            this.btnMakeTransfer.Size = new System.Drawing.Size(250, 75);
            this.btnMakeTransfer.TabIndex = 16;
            this.btnMakeTransfer.Text = "Make transfer";
            this.btnMakeTransfer.UseVisualStyleBackColor = false;
            // 
            // btnAddInterest
            // 
            this.btnAddInterest.BackColor = System.Drawing.Color.Navy;
            this.btnAddInterest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddInterest.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAddInterest.Location = new System.Drawing.Point(700, 117);
            this.btnAddInterest.Name = "btnAddInterest";
            this.btnAddInterest.Size = new System.Drawing.Size(250, 75);
            this.btnAddInterest.TabIndex = 17;
            this.btnAddInterest.Text = "Add interest";
            this.btnAddInterest.UseVisualStyleBackColor = false;
            this.btnAddInterest.Click += new System.EventHandler(this.btnAddInterest_Click);
            // 
            // lblSelectAccount
            // 
            this.lblSelectAccount.AutoSize = true;
            this.lblSelectAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectAccount.Location = new System.Drawing.Point(69, 197);
            this.lblSelectAccount.Name = "lblSelectAccount";
            this.lblSelectAccount.Size = new System.Drawing.Size(157, 30);
            this.lblSelectAccount.TabIndex = 19;
            this.lblSelectAccount.Text = "Select account:";
            // 
            // comboAccounts
            // 
            this.comboAccounts.FormattingEnabled = true;
            this.comboAccounts.Location = new System.Drawing.Point(69, 241);
            this.comboAccounts.Name = "comboAccounts";
            this.comboAccounts.Size = new System.Drawing.Size(182, 33);
            this.comboAccounts.TabIndex = 18;
            this.comboAccounts.SelectedIndexChanged += new System.EventHandler(this.comboAccounts_SelectedIndexChanged);
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentBalance.Location = new System.Drawing.Point(69, 335);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(171, 30);
            this.lblCurrentBalance.TabIndex = 20;
            this.lblCurrentBalance.Text = "Current balance:";
            // 
            // frmManageAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1175, 450);
            this.Controls.Add(this.lblCurrentBalance);
            this.Controls.Add(this.lblSelectAccount);
            this.Controls.Add(this.comboAccounts);
            this.Controls.Add(this.btnAddInterest);
            this.Controls.Add(this.btnMakeTransfer);
            this.Controls.Add(this.btnAddNewAccount);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.comboCustomers);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Name = "frmManageAccounts";
            this.Text = "Current balance:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCustomers;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnAddNewAccount;
        private System.Windows.Forms.Button btnMakeTransfer;
        private System.Windows.Forms.Button btnAddInterest;
        private System.Windows.Forms.Label lblSelectAccount;
        private System.Windows.Forms.ComboBox comboAccounts;
        private System.Windows.Forms.Label lblCurrentBalance;
    }
}