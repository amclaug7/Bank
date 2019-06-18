using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bank
{
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }

        private void Bank_Load(object sender, EventArgs e)
        {
            cbxQuery.Items.Add("All Accounts");
            cbxQuery.Items.Add("Total Balances");

            ReadFile(accounts);

            foreach (var account in accounts)
            {
                if (account.GetStatus() == "Open")
                {
                    cbxDeposit.Items.Add(account.GetName());
                    cbxWithdraw.Items.Add(account.GetName());
                    cbxClose.Items.Add(account.GetName());
                    cbxQuery.Items.Add(account.GetName());
                }
                else
                {

                }
            }           
        }        

        List<Account> accounts = new List<Account>();
        
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            decimal balance;

            if (Decimal.TryParse(tbxInitBalance.Text, out balance))
            {
                if (balance >= 0)
                {
                    if (tbxCreateAccount.Text == "")
                    {
                        MessageBox.Show("Please Enter Account Name", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        var account = new Account(tbxCreateAccount.Text, accounts.Count, "Open", Math.Round(balance, 2));
                        accounts.Add(account);

                        cbxDeposit.Items.Add(account.GetName());
                        cbxWithdraw.Items.Add(account.GetName());
                        cbxClose.Items.Add(account.GetName());
                        cbxQuery.Items.Add(account.GetName());

                        MessageBox.Show("Account Created", "Account Created", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tbxCreateAccount.Text = "";
                        tbxInitBalance.Text = "0.00";
                    }
                }
                else
                {

                    MessageBox.Show("Account Balance Must Be Positive", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Balance Must Be Number", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal deposit;

            if (Decimal.TryParse(tbxDeposit.Text, out deposit))
            {
                foreach (var account in accounts)
                {
                    if (cbxDeposit.Text == account.GetName())
                    {
                        account.Deposit(deposit);

                        MessageBox.Show("Deposit Made", "Deposit",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cbxDeposit.Text = "";
                        tbxDeposit.Text = "0.00";
                    }
                    else { }
                }
            }
            else
            {
                MessageBox.Show("Deposit Must Be Number", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal withdraw;

            if (Decimal.TryParse(tbxWithdraw.Text, out withdraw))
            {
                foreach (var account in accounts)
                {
                    if (cbxWithdraw.Text == account.GetName())
                    {
                        account.Withdraw(withdraw);

                        MessageBox.Show("Withdraw Made", "Withdraw",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cbxWithdraw.Text = "";
                        tbxWithdraw.Text = "0.00";
                    }
                    else { }
                }
            }
            else
            {
                MessageBox.Show("Deposit Must Be Number", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }            
        }

        private void cbxQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblQuery.Text = "";

            if (cbxQuery.Text == "All Accounts")
            {

                foreach (var account in accounts)
                    if (account.GetStatus() == "Open")
                    {                
                        lblQuery.Text += $"{account.GetName()} has a balance of ${account.GetBalance()}. ";
                    }
            }
            else if (cbxQuery.Text == "Total Balances")
            {
                decimal totalDeposits = 0;

                foreach (var account in accounts)
                    if (account.GetStatus() == "Open")
                    {
                        totalDeposits += account.GetBalance();
                        lblQuery.Text = $"The Bank is managing ${totalDeposits} in total assets.";
                    }
            }
            else
            {
                foreach (var account in accounts)
                {
                    if (cbxQuery.Text == account.GetName())
                    {
                        lblQuery.Text = $"The account {account.GetName()} has a balance of ${account.GetBalance()}.";
                    }
                    else { }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            foreach (var account in accounts)
            {
                if(cbxClose.Text == account.GetName())
                {
                    cbxDeposit.Items.Remove(account.GetName());
                    cbxWithdraw.Items.Remove(account.GetName());
                    cbxClose.Items.Remove(account.GetName());
                    cbxQuery.Items.Remove(account.GetName());

                    account.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            WriteFile(accounts);
            this.Close();
        }

        static void ReadFile(List<Account> accounts)
        {
            try
            {
                string dataFile = "..\\..\\..\\..\\Bank\\Bank\\bin\\Debug\\accounts.txt";
                StreamReader inputFile = File.OpenText(dataFile);

                while (!inputFile.EndOfStream)
                {
                    // Read a line from the file
                    string record = inputFile.ReadLine();

                    // Split the record with comma delimiter 
                    string[] tokens = record.Split(',');

                    // Add the record to the list
                    accounts.Add(new Account(tokens[0], int.Parse(tokens[1]), tokens[2], decimal.Parse(tokens[3])));
                }
                inputFile?.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void WriteFile(List<Account> accounts)
        {
            StreamWriter outputFile = File.CreateText("accounts.txt");
            string record;
            foreach (var account in accounts)
            {
                record = $"{account.GetName()},{account.GetNumber()},{account.GetStatus()},{account.GetBalance()}";            
                Console.WriteLine($"Writing record: {record}");
                outputFile.WriteLine(record);
            }
            outputFile.Close();
        }
    }
}
