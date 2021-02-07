
namespace customer_app
{
    partial class frmAddAccount
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
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblOpeningBalance = new System.Windows.Forms.Label();
            this.numOpeningBalance = new System.Windows.Forms.NumericUpDown();
            this.numOverdraftLimit = new System.Windows.Forms.NumericUpDown();
            this.lblOverdraftLimit = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblErrorSelectAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOpeningBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOverdraftLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAppTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAppTitle.Location = new System.Drawing.Point(23, 29);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(450, 60);
            this.lblAppTitle.TabIndex = 2;
            this.lblAppTitle.Text = "Create new account";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(36, 198);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(145, 30);
            this.lblFirstName.TabIndex = 16;
            this.lblFirstName.Text = "Account type:";
            // 
            // comboAccountType
            // 
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(36, 242);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(182, 33);
            this.comboAccountType.TabIndex = 15;
            this.comboAccountType.SelectedIndexChanged += new System.EventHandler(this.comboAccountType_SelectedIndexChanged);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.BackColor = System.Drawing.Color.Navy;
            this.btnCancelAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelAdd.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCancelAdd.Location = new System.Drawing.Point(34, 613);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(250, 75);
            this.btnCancelAdd.TabIndex = 17;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = false;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.Navy;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCreateAccount.Location = new System.Drawing.Point(341, 613);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(250, 75);
            this.btnCreateAccount.TabIndex = 18;
            this.btnCreateAccount.Text = "Create account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblOpeningBalance
            // 
            this.lblOpeningBalance.AutoSize = true;
            this.lblOpeningBalance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOpeningBalance.Location = new System.Drawing.Point(36, 333);
            this.lblOpeningBalance.Name = "lblOpeningBalance";
            this.lblOpeningBalance.Size = new System.Drawing.Size(182, 30);
            this.lblOpeningBalance.TabIndex = 19;
            this.lblOpeningBalance.Text = "Opening balance:";
            // 
            // numOpeningBalance
            // 
            this.numOpeningBalance.DecimalPlaces = 2;
            this.numOpeningBalance.Location = new System.Drawing.Point(38, 375);
            this.numOpeningBalance.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numOpeningBalance.Name = "numOpeningBalance";
            this.numOpeningBalance.Size = new System.Drawing.Size(180, 31);
            this.numOpeningBalance.TabIndex = 20;
            this.numOpeningBalance.Tag = "";
            // 
            // numOverdraftLimit
            // 
            this.numOverdraftLimit.DecimalPlaces = 2;
            this.numOverdraftLimit.Location = new System.Drawing.Point(36, 516);
            this.numOverdraftLimit.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numOverdraftLimit.Name = "numOverdraftLimit";
            this.numOverdraftLimit.Size = new System.Drawing.Size(180, 31);
            this.numOverdraftLimit.TabIndex = 22;
            this.numOverdraftLimit.Tag = "";
            // 
            // lblOverdraftLimit
            // 
            this.lblOverdraftLimit.AutoSize = true;
            this.lblOverdraftLimit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOverdraftLimit.Location = new System.Drawing.Point(34, 474);
            this.lblOverdraftLimit.Name = "lblOverdraftLimit";
            this.lblOverdraftLimit.Size = new System.Drawing.Size(159, 30);
            this.lblOverdraftLimit.TabIndex = 21;
            this.lblOverdraftLimit.Text = "Overdraft limit:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerName.Location = new System.Drawing.Point(34, 132);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(118, 30);
            this.lblCustomerName.TabIndex = 23;
            this.lblCustomerName.Text = "Customer: ";
            // 
            // lblErrorSelectAccount
            // 
            this.lblErrorSelectAccount.AutoSize = true;
            this.lblErrorSelectAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorSelectAccount.Location = new System.Drawing.Point(236, 242);
            this.lblErrorSelectAccount.Name = "lblErrorSelectAccount";
            this.lblErrorSelectAccount.Size = new System.Drawing.Size(0, 30);
            this.lblErrorSelectAccount.TabIndex = 24;
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(633, 718);
            this.Controls.Add(this.lblErrorSelectAccount);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.numOverdraftLimit);
            this.Controls.Add(this.lblOverdraftLimit);
            this.Controls.Add(this.numOpeningBalance);
            this.Controls.Add(this.lblOpeningBalance);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.comboAccountType);
            this.Controls.Add(this.lblAppTitle);
            this.Name = "frmAddAccount";
            this.Text = "frmAddAccount";
            ((System.ComponentModel.ISupportInitialize)(this.numOpeningBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOverdraftLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblOpeningBalance;
        private System.Windows.Forms.NumericUpDown numOpeningBalance;
        private System.Windows.Forms.NumericUpDown numOverdraftLimit;
        private System.Windows.Forms.Label lblOverdraftLimit;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblErrorSelectAccount;
    }
}