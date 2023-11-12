using System.Globalization;
using csharp_exercise_exceptiom.Entities;
using csharp_exercise_exceptiom.Entities.Exceptions;

namespace csharp_exercise_exceptiom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.WriteLine("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Holder: ");
                string holder = Console.ReadLine();
                Console.WriteLine("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.WriteLine("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);
                Console.WriteLine(account.ToString());
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}   

