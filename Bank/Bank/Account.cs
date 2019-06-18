using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    class Account
    {
        private readonly string name;
        private readonly int number;
        private string status;
        private decimal balance;

        public Account(string acctName, int acctNumber, string acctStatus, decimal acctBalance = 0)
        {
            name = acctName;
            number = acctNumber;
            status = acctStatus;
            balance = acctBalance;
        }

        public string GetName()
        {
            return name;
        }

        public int GetNumber()
        {
            return number;
        }

        public string GetStatus()
        {
            return status;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        private void SetBalance(decimal amt)
        {
            balance = Math.Round(amt, 2);
        }

        private void SetStatus(string newStatus)
        {
            status = newStatus;
        }

        public void Deposit(decimal amt)
        {
            if(amt >= 0)
            {
                SetBalance(GetBalance() + Math.Round(amt, 2));
            }
            else
            {
                MessageBox.Show("Cannot Deposit Negative Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Withdraw(decimal amt)
        {
            if(amt >= 0)
            {
                if ((GetBalance() - amt) < 0)
                {
                    MessageBox.Show("Overdraw Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SetBalance(GetBalance() - Math.Round(amt, 2));
                }
            }
            else
            {
                MessageBox.Show("Cannot Withdraw Negative Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close()
        {
            balance = 0;
            SetStatus("Closed");

            MessageBox.Show("Account Closed", "Account Closed", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
