namespace MultiBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank obj = new Bank();
            //main interface
            while (true)
            {
                Console.WriteLine("-----Welcome to Gringotts-----\n");
                Console.WriteLine("1. Log In \n");
                Console.WriteLine("2. Bank Balance \n");
                Console.WriteLine("3. Quit \n");
                Console.WriteLine("\n");
                Console.WriteLine("What would you like to do?\n");
                string option = Console.ReadLine();

                Console.WriteLine("Accessing....\n");

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Accessing...\n");
                        LogInMenu();
                        break;

                    case 2:
                        Console.WriteLine("Bank Balance is $" + Bank.BankBalance +"\n");                        
                        break;

                    case 3:
                        Console.WriteLine("Exiting...\n");
                        break;

                    default:
                        Console.WriteLine("Invalid option, please try again.\n");
                        break;
                }
            }

        }
    }
}
