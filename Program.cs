using System.Runtime.CompilerServices;

namespace Bankomat
{
    internal class Program
    {

        static void AuthenticateUser()
        {
            while (isUser)
            {
                Console.WriteLine("Ange din pinkod för att logga in:"); 
                string input = Console.ReadLine();
                if (input == userPin)
                {
                    isUser = false;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Fel pinkod");

                }
            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("\n###########");
            Console.WriteLine("Bankomaten!");
            Console.WriteLine("###########\n");
            Console.WriteLine("1. Sätt in pengar");
            Console.WriteLine("2. Ta ut pengar");
            Console.WriteLine("3. Visa saldo");
            Console.WriteLine("4. Avsluta");
        }
        static BankAccount account = new BankAccount();

        static void DepositMoney()
        {
            Console.WriteLine("\nAnge belopp att sätta in");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                account.DepositMoney(amount);
                Console.WriteLine($"\nDu har satt in {amount} kr.");
            }
            else
            {
                Console.WriteLine("Ogiltigt belopp");
            }
        }
        static void WithdrawMoney()
        {
            Console.WriteLine("\nAnge belopp för att ta ut:");
            if (decimal.TryParse(Console.ReadLine(), out decimal value))
            {
                account.WithdrawMoney(value);
                Console.WriteLine($"\nDu har tagit ut {value} kr.");
            }
            else Console.WriteLine("Ogiltigt belopp");
        }

        static void ShowBalance()
        {
            Console.WriteLine($"Ditt saldo är: {account.Balance} kr.");
        }
        
        static void Exit()
        {
            Environment.Exit(0);
        }


        const string userPin = "1337";
        static bool isUser = true;

            static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                AuthenticateUser();
                ShowMenu();
                Console.WriteLine("Välj ett alternativ i menyn:");
                string menyChoice = Console.ReadLine();

                switch (menyChoice)
                {
                    case "1":
                        DepositMoney();
                        break;
                    case "2":
                        WithdrawMoney();
                        break;
                    case "3":
                        ShowBalance();
                        break;
                    case "4":
                        Exit();
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }

            }
        }

    }
}
