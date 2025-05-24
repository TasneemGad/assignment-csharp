using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_1
{
    internal class BankAccount
    {
        public long  AccountNumber  { get; set; }
        public string AccountHolderName { get; set; }

        public int Balance { get; set; }

        public  BankAccount(long accountNumber) {
            this.AccountNumber = accountNumber;
        }

        public void Deposit(int amount)
        {
            Balance = Balance + amount;
        }
        public void Withdraw(int amount)
        {
            Balance =  Balance - amount;
        }

    }
}
