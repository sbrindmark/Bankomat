using System.Runtime.CompilerServices;

namespace Bankomat
{
    internal class Program
    {
        // Metod för att autentisera användaren med pinkod, max 3 försök
        static void AuthenticateUser()
        {
            int wrongPin = 0;
            while (wrongPin < 3)
            {
                Console.WriteLine("Ange din pinkod för att logga in:"); 
                string input = Console.ReadLine();
                if (input == userPin)
                {
                    isUser = false;
                    Console.Clear();
                    return; // Avsluta metoden om pinkoden är korrekt
                }
                else 
                {
                    wrongPin++;
                    Console.WriteLine($"Fel pinkod. DU har {3 - wrongPin} försök kvar.");
                }
            }
            // Om användaren misslyckas tre gånger, avsluta programmet
            Console.WriteLine("Du har slagit fel pinkod tre gånger. Programmet avslutas.");
            Exit();
        }

        // Visar huvudmenyn för bankomaten
        static void ShowMenu()
        {
            Console.WriteLine("\n╔══════════════════════╗");
            Console.WriteLine("║      BANKOMATEN      ║");
            Console.WriteLine("╚══════════════════════╝");
            Console.WriteLine("1. Sätt in pengar");
            Console.WriteLine("2. Ta ut pengar");
            Console.WriteLine("3. Visa saldo");
            Console.WriteLine("4. Avsluta");
        }

        // Skapar ett nytt bankkonto
        static BankAccount account = new BankAccount();

        // Metod för att sätta in pengar på kontot
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

        // Metod för att ta ut pengar från kontot
        static void WithdrawMoney()
        {
            Console.WriteLine("\nAnge belopp för att ta ut:");
            if (decimal.TryParse(Console.ReadLine(), out decimal value))
            {
                if (account.WithdrawMoney(value))
                {
                    Console.WriteLine($"\nDu har tagit ut {value} kr.");
                }
                else
                {
                    Console.WriteLine("\nDu har inte tillräckligt med pengar på kontot.");
                }
            }
            else Console.WriteLine("Ogiltigt belopp");
        }

        // Visar nuvarande saldo på kontot
        static void ShowBalance()
        {
            Console.WriteLine($"Ditt saldo är: {account.Balance} kr.");
        }

        // Pausar och rensar konsolen
        static void PauseAndClear()
        {
            Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            Console.Clear();
        }

        // Avslutar programmet
        static void Exit()
        {
            Environment.Exit(0);
        }

        // Pinkod för användaren
        const string userPin = "1337";
        // Flagga för om användaren är inloggad
        static bool isUser = true;

        // Huvudmetod som kör programmet
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                AuthenticateUser(); // Autentisera användaren
                Console.Clear();
                ShowMenu(); // Visa menyn
                Console.WriteLine("Välj ett alternativ i menyn:");
                string menyChoice = Console.ReadLine();

                switch (menyChoice)
                {
                    case "1":
                        DepositMoney();
                        PauseAndClear();
                        break;
                    case "2":
                        WithdrawMoney();
                        PauseAndClear();
                        break;
                    case "3":
                        ShowBalance();
                        PauseAndClear();
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
