
namespace customer_app
{
    partial class frmTransfer
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
            this.lblTransferTitle = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.comboFromAccount = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.comboToAccount = new System.Windows.Forms.ComboBox();
            this.btnMakeTransfer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSelectedCustomer = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblFromBalance = new System.Windows.Forms.Label();
            this.lblToBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransferTitle
            // 
            this.lblTransferTitle.AutoSize = true;
            this.lblTransferTitle.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTransferTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTransferTitle.Location = new System.Drawing.Point(12, 25);
            this.lblTransferTitle.Name = "lblTransferTitle";
            this.lblTransferTitle.Size = new System.Drawing.Size(367, 60);
            this.lblTransferTitle.TabIndex = 2;
            this.lblTransferTitle.Text = "Make a transfer";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFrom.Location = new System.Drawing.Point(78, 160);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(228, 30);
            this.lblFrom.TabIndex = 21;
            this.lblFrom.Text = "Select \"from\" account:";
            // 
            // comboFromAccount
            // 
            this.comboFromAccount.FormattingEnabled = true;
            this.comboFromAccount.Location = new System.Drawing.Point(78, 204);
            this.comboFromAccount.Name = "comboFromAccount";
            this.comboFromAccount.Size = new System.Drawing.Size(182, 33);
            this.comboFromAccount.TabIndex = 20;
            this.comboFromAccount.SelectedIndexChanged += new System.EventHandler(this.comboFromAccount_SelectedIndexChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTo.Location = new System.Drawing.Point(742, 160);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(201, 30);
            this.lblTo.TabIndex = 23;
            this.lblTo.Text = "Select \"to\" account:";
            // 
            // comboToAccount
            // 
            this.comboToAccount.FormattingEnabled = true;
            this.comboToAccount.Location = new System.Drawing.Point(742, 204);
            this.comboToAccount.Name = "comboToAccount";
            this.comboToAccount.Size = new System.Drawing.Size(182, 33);
            this.comboToAccount.TabIndex = 22;
            this.comboToAccount.SelectedIndexChanged += new System.EventHandler(this.comboToAccount_SelectedIndexChanged);
            // 
            // btnMakeTransfer
            // 
            this.btnMakeTransfer.BackColor = System.Drawing.Color.Navy;
            this.btnMakeTransfer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMakeTransfer.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnMakeTransfer.Location = new System.Drawing.Point(693, 343);
            this.btnMakeTransfer.Name = "btnMakeTransfer";
            this.btnMakeTransfer.Size = new System.Drawing.Size(250, 75);
            this.btnMakeTransfer.TabIndex = 25;
            this.btnMakeTransfer.Text = "Make transfer";
            this.btnMakeTransfer.UseVisualStyleBackColor = false;
            this.btnMakeTransfer.Click += new System.EventHandler(this.btnMakeTransfer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Navy;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCancel.Location = new System.Drawing.Point(78, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(250, 75);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSelectedCustomer
            // 
            this.lblSelectedCustomer.AutoSize = true;
            this.lblSelectedCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedCustomer.Location = new System.Drawing.Point(78, 104);
            this.lblSelectedCustomer.Name = "lblSelectedCustomer";
            this.lblSelectedCustomer.Size = new System.Drawing.Size(203, 30);
            this.lblSelectedCustomer.TabIndex = 26;
            this.lblSelectedCustomer.Text = "Selected customer: ";
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Location = new System.Drawing.Point(431, 227);
            this.numAmount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(180, 31);
            this.numAmount.TabIndex = 28;
            this.numAmount.Tag = "";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(429, 185);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(175, 30);
            this.lblAmount.TabIndex = 27;
            this.lblAmount.Text = "Transfer amount:";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.Location = new System.Drawing.Point(95, 282);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(848, 56);
            this.lblError.TabIndex = 29;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFromBalance
            // 
            this.lblFromBalance.AutoSize = true;
            this.lblFromBalance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFromBalance.Location = new System.Drawing.Point(78, 252);
            this.lblFromBalance.Name = "lblFromBalance";
            this.lblFromBalance.Size = new System.Drawing.Size(98, 30);
            this.lblFromBalance.TabIndex = 30;
            this.lblFromBalance.Text = "Balance: ";
            // 
            // lblToBalance
            // 
            this.lblToBalance.AutoSize = true;
            this.lblToBalance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToBalance.Location = new System.Drawing.Point(742, 252);
            this.lblToBalance.Name = "lblToBalance";
            this.lblToBalance.Size = new System.Drawing.Size(98, 30);
            this.lblToBalance.TabIndex = 31;
            this.lblToBalance.Text = "Balance: ";
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.lblToBalance);
            this.Controls.Add(this.lblFromBalance);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblSelectedCustomer);
            this.Controls.Add(this.btnMakeTransfer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.comboToAccount);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.comboFromAccount);
            this.Controls.Add(this.lblTransferTitle);
            this.Name = "frmTransfer";
            this.Text = "Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransferTitle;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox comboFromAccount;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox comboToAccount;
        private System.Windows.Forms.Button btnMakeTransfer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSelectedCustomer;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblFromBalance;
        private System.Windows.Forms.Label lblToBalance;
    }
}