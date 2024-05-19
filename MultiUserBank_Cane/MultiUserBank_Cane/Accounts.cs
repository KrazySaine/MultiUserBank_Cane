using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MultiBank
{
    public class Account
    {
        private decimal Balance;
        public int ID;
        public string Username;
        public string Password;
        


        //create login interface to take username and password with a for loop
        public Account(decimal balance, int id, string username, string password)
        {

            Username = username;
            Password = password;
            Balance = balance;
            
            
        }
        public void Username(string username, string password, decimal balance)
        {
            a1 = jlennon, johnny, 1250M;
            a2 = pmccartney, pauly, 2500M;
            a3= gharrison, georgy, 3000M;
            a4= rstarr, ringoy, 1001M;
        }
        public void LogInMenu(string username, string password)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Username");
                string Username = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string Password = Console.ReadLine();

                if (username == "valid" || password == "valid")
                    AccountMenu();
                else
                    break;

            }

            if (Balance < 0)
            {
                throw new ArgumentException("Balance cannot be negative.");
            }

            this.Balance = Balance;
        }
        public void AccountMenu()
        {
            while (true)
            {
                Console.WriteLine("-----Welcome to Gringotts-----\n");
                Console.WriteLine("---------Admin Access---------\n");
                Console.WriteLine(Username);
                Console.WriteLine("1. Withdraw \n");
                Console.WriteLine("2. Deposit \n");
                Console.WriteLine("3. Check Balance \n");
                Console.WriteLine("4. Log Out \n");
                Console.WriteLine("\n");
                Console.WriteLine("What would you like to do?\n");
                int option = Console.Read();

                Console.WriteLine("Accessing....\n");

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Amount to withdraw:\n");
                        decimal amount = Console.Read();
                        Console.WriteLine("New Balance is: $" + GetBalance);
                        break;

                    case 2:
                        Console.WriteLine("Amount to deposit:\n");
                        decimal mount = Console.Read();
                        Console.WriteLine("New Balance is: $" + GetBalance);
                        break;

                    case 3:
                        Console.WriteLine("Balance is: $" + GetBalance);
                        break;

                    case 4:
                        Console.WriteLine("Returning to Main Menu...\n");
                        break;

                    default:
                        Console.WriteLine("Invalid option, please try again.\n");
                        break;
                }
            }
        }
        public void Withdrawal(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Credit amount cannot be negative.");
            }

            Balance += amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Debit amount cannot be negative.");
            }

            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            Balance -= amount;
        }

        public decimal GetBalance()
        {
            return Balance;
        }
        
    }
}


