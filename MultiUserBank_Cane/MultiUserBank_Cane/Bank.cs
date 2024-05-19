using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MultiBank
{
    public class Bank
    {
        //all instance data should be private
        private decimal BankBalance;
        public string name { get; }
        private List<Account> BankAccounts = new List<Account>();
        public Bank(string name, decimal InitialBalance)
        {
            BankBalance = InitialBalance;
            this.name = name;
            InitialBalance = (10000M);

            
        }
        public Account GetAccount(int username)
        {
            Account account = BankAccounts.Where(x => x.owner == username).FirstOrDefault();

            if (account == null)
            {
                throw new ApplicationException("No account exists with that username...");
            }

            return account;
        public decimal Withdrawal(decimal Amount)
        {
            if (Amount > 500M) { Amount = 500M; }
            if (Amount > BankBalance) { Amount = BankBalance; }
            BankBalance -= Amount;
            return BankBalance;
        }
        public decimal Deposit(decimal Amount)
        {
            BankBalance += Amount;
            return BankBalance;
        }

        public decimal Balance
        {
            get { return BankBalance; }
        }


    }
}
