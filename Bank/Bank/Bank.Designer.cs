namespace Bank
{
    partial class Bank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bank));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Welcome = new System.Windows.Forms.TabPage();
            this.CreateAccount = new System.Windows.Forms.TabPage();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.tbxInitBalance = new System.Windows.Forms.TextBox();
            this.tbxCreateAccount = new System.Windows.Forms.TextBox();
            this.lblInitBalance = new System.Windows.Forms.Label();
            this.lblAcctName = new System.Windows.Forms.Label();
            this.Deposit = new System.Windows.Forms.TabPage();
            this.cbxDeposit = new System.Windows.Forms.ComboBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.tbxDeposit = new System.Windows.Forms.TextBox();
            this.Withdraw = new System.Windows.Forms.TabPage();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.tbxWithdraw = new System.Windows.Forms.TextBox();
            this.cbxWithdraw = new System.Windows.Forms.ComboBox();
            this.Query = new System.Windows.Forms.TabPage();
            this.cbxQuery = new System.Windows.Forms.ComboBox();
            this.lblQuery = new System.Windows.Forms.Label();
            this.CloseAccount = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbxClose = new System.Windows.Forms.ComboBox();
            this.Exit = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.lblQueryAccounts = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Welcome.SuspendLayout();
            this.CreateAccount.SuspendLayout();
            this.Deposit.SuspendLayout();
            this.Withdraw.SuspendLayout();
            this.Query.SuspendLayout();
            this.CloseAccount.SuspendLayout();
            this.Exit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Welcome);
            this.tabControl1.Controls.Add(this.CreateAccount);
            this.tabControl1.Controls.Add(this.Deposit);
            this.tabControl1.Controls.Add(this.Withdraw);
            this.tabControl1.Controls.Add(this.Query);
            this.tabControl1.Controls.Add(this.CloseAccount);
            this.tabControl1.Controls.Add(this.Exit);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 258);
            this.tabControl1.TabIndex = 0;
            // 
            // Welcome
            // 
            this.Welcome.Controls.Add(this.label1);
            this.Welcome.Location = new System.Drawing.Point(4, 22);
            this.Welcome.Name = "Welcome";
            this.Welcome.Padding = new System.Windows.Forms.Padding(3);
            this.Welcome.Size = new System.Drawing.Size(412, 232);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome";
            this.Welcome.UseVisualStyleBackColor = true;
            // 
            // CreateAccount
            // 
            this.CreateAccount.Controls.Add(this.btnCreateAccount);
            this.CreateAccount.Controls.Add(this.tbxInitBalance);
            this.CreateAccount.Controls.Add(this.tbxCreateAccount);
            this.CreateAccount.Controls.Add(this.lblInitBalance);
            this.CreateAccount.Controls.Add(this.lblAcctName);
            this.CreateAccount.Location = new System.Drawing.Point(4, 22);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Padding = new System.Windows.Forms.Padding(3);
            this.CreateAccount.Size = new System.Drawing.Size(412, 232);
            this.CreateAccount.TabIndex = 1;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.UseVisualStyleBackColor = true;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(146, 143);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(100, 23);
            this.btnCreateAccount.TabIndex = 4;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // tbxInitBalance
            // 
            this.tbxInitBalance.Location = new System.Drawing.Point(247, 74);
            this.tbxInitBalance.Name = "tbxInitBalance";
            this.tbxInitBalance.Size = new System.Drawing.Size(100, 20);
            this.tbxInitBalance.TabIndex = 3;
            this.tbxInitBalance.Text = "0.00";
            // 
            // tbxCreateAccount
            // 
            this.tbxCreateAccount.Location = new System.Drawing.Point(247, 48);
            this.tbxCreateAccount.Name = "tbxCreateAccount";
            this.tbxCreateAccount.Size = new System.Drawing.Size(100, 20);
            this.tbxCreateAccount.TabIndex = 2;
            // 
            // lblInitBalance
            // 
            this.lblInitBalance.AutoSize = true;
            this.lblInitBalance.Location = new System.Drawing.Point(51, 77);
            this.lblInitBalance.Name = "lblInitBalance";
            this.lblInitBalance.Size = new System.Drawing.Size(101, 13);
            this.lblInitBalance.TabIndex = 1;
            this.lblInitBalance.Text = "Enter Initial Balance";
            // 
            // lblAcctName
            // 
            this.lblAcctName.AutoSize = true;
            this.lblAcctName.Location = new System.Drawing.Point(51, 51);
            this.lblAcctName.Name = "lblAcctName";
            this.lblAcctName.Size = new System.Drawing.Size(106, 13);
            this.lblAcctName.TabIndex = 0;
            this.lblAcctName.Text = "Enter Account Name";
            // 
            // Deposit
            // 
            this.Deposit.Controls.Add(this.lblDeposit);
            this.Deposit.Controls.Add(this.cbxDeposit);
            this.Deposit.Controls.Add(this.btnDeposit);
            this.Deposit.Controls.Add(this.tbxDeposit);
            this.Deposit.Location = new System.Drawing.Point(4, 22);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(412, 232);
            this.Deposit.TabIndex = 2;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            // 
            // cbxDeposit
            // 
            this.cbxDeposit.FormattingEnabled = true;
            this.cbxDeposit.Location = new System.Drawing.Point(50, 60);
            this.cbxDeposit.Name = "cbxDeposit";
            this.cbxDeposit.Size = new System.Drawing.Size(121, 21);
            this.cbxDeposit.TabIndex = 3;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(247, 143);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // tbxDeposit
            // 
            this.tbxDeposit.Location = new System.Drawing.Point(247, 61);
            this.tbxDeposit.Name = "tbxDeposit";
            this.tbxDeposit.Size = new System.Drawing.Size(100, 20);
            this.tbxDeposit.TabIndex = 1;
            this.tbxDeposit.Text = "0.00";
            // 
            // Withdraw
            // 
            this.Withdraw.Controls.Add(this.lblWithdraw);
            this.Withdraw.Controls.Add(this.btnWithdraw);
            this.Withdraw.Controls.Add(this.tbxWithdraw);
            this.Withdraw.Controls.Add(this.cbxWithdraw);
            this.Withdraw.Location = new System.Drawing.Point(4, 22);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(412, 232);
            this.Withdraw.TabIndex = 3;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(247, 143);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // tbxWithdraw
            // 
            this.tbxWithdraw.Location = new System.Drawing.Point(247, 61);
            this.tbxWithdraw.Name = "tbxWithdraw";
            this.tbxWithdraw.Size = new System.Drawing.Size(100, 20);
            this.tbxWithdraw.TabIndex = 1;
            this.tbxWithdraw.Text = "0.00";
            // 
            // cbxWithdraw
            // 
            this.cbxWithdraw.FormattingEnabled = true;
            this.cbxWithdraw.Location = new System.Drawing.Point(50, 60);
            this.cbxWithdraw.Name = "cbxWithdraw";
            this.cbxWithdraw.Size = new System.Drawing.Size(121, 21);
            this.cbxWithdraw.TabIndex = 0;
            // 
            // Query
            // 
            this.Query.Controls.Add(this.lblQueryAccounts);
            this.Query.Controls.Add(this.cbxQuery);
            this.Query.Controls.Add(this.lblQuery);
            this.Query.Location = new System.Drawing.Point(4, 22);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(412, 232);
            this.Query.TabIndex = 4;
            this.Query.Text = "Query";
            this.Query.UseVisualStyleBackColor = true;
            // 
            // cbxQuery
            // 
            this.cbxQuery.FormattingEnabled = true;
            this.cbxQuery.Location = new System.Drawing.Point(141, 59);
            this.cbxQuery.Name = "cbxQuery";
            this.cbxQuery.Size = new System.Drawing.Size(121, 21);
            this.cbxQuery.TabIndex = 2;
            this.cbxQuery.SelectedIndexChanged += new System.EventHandler(this.cbxQuery_SelectedIndexChanged);
            // 
            // lblQuery
            // 
            this.lblQuery.Location = new System.Drawing.Point(3, 83);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(406, 149);
            this.lblQuery.TabIndex = 1;
            this.lblQuery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseAccount
            // 
            this.CloseAccount.Controls.Add(this.lblClose);
            this.CloseAccount.Controls.Add(this.btnClose);
            this.CloseAccount.Controls.Add(this.cbxClose);
            this.CloseAccount.Location = new System.Drawing.Point(4, 22);
            this.CloseAccount.Name = "CloseAccount";
            this.CloseAccount.Size = new System.Drawing.Size(412, 232);
            this.CloseAccount.TabIndex = 6;
            this.CloseAccount.Text = "Close Account";
            this.CloseAccount.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(164, 152);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close Account";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbxClose
            // 
            this.cbxClose.FormattingEnabled = true;
            this.cbxClose.Location = new System.Drawing.Point(141, 59);
            this.cbxClose.Name = "cbxClose";
            this.cbxClose.Size = new System.Drawing.Size(121, 21);
            this.cbxClose.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Controls.Add(this.btnExit);
            this.Exit.Location = new System.Drawing.Point(4, 22);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(412, 232);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(152, 100);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Save and Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(83, 44);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(52, 13);
            this.lblDeposit.TabIndex = 4;
            this.lblDeposit.Text = "Accounts";
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(83, 44);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(52, 13);
            this.lblWithdraw.TabIndex = 3;
            this.lblWithdraw.Text = "Accounts";
            // 
            // lblQueryAccounts
            // 
            this.lblQueryAccounts.AutoSize = true;
            this.lblQueryAccounts.Location = new System.Drawing.Point(180, 43);
            this.lblQueryAccounts.Name = "lblQueryAccounts";
            this.lblQueryAccounts.Size = new System.Drawing.Size(45, 13);
            this.lblQueryAccounts.TabIndex = 3;
            this.lblQueryAccounts.Text = "Get Info";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(176, 43);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(52, 13);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "Accounts";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 226);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 283);
            this.Controls.Add(this.tabControl1);
            this.Name = "Bank";
            this.Text = "McLaughlin and Sons Bank";
            this.Load += new System.EventHandler(this.Bank_Load);
            this.tabControl1.ResumeLayout(false);
            this.Welcome.ResumeLayout(false);
            this.CreateAccount.ResumeLayout(false);
            this.CreateAccount.PerformLayout();
            this.Deposit.ResumeLayout(false);
            this.Deposit.PerformLayout();
            this.Withdraw.ResumeLayout(false);
            this.Withdraw.PerformLayout();
            this.Query.ResumeLayout(false);
            this.Query.PerformLayout();
            this.CloseAccount.ResumeLayout(false);
            this.CloseAccount.PerformLayout();
            this.Exit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Welcome;
        private System.Windows.Forms.TabPage CreateAccount;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox tbxInitBalance;
        private System.Windows.Forms.TextBox tbxCreateAccount;
        private System.Windows.Forms.Label lblInitBalance;
        private System.Windows.Forms.Label lblAcctName;
        private System.Windows.Forms.TabPage Deposit;
        private System.Windows.Forms.TabPage Withdraw;
        private System.Windows.Forms.TabPage Query;
        private System.Windows.Forms.TabPage Exit;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox tbxDeposit;
        private System.Windows.Forms.ComboBox cbxDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox tbxWithdraw;
        private System.Windows.Forms.ComboBox cbxWithdraw;
        private System.Windows.Forms.ComboBox cbxQuery;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabPage CloseAccount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbxClose;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Label lblQueryAccounts;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
    }
}

