using ExceptionChallenge.Entities;
using ExceptionChallenge.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number : ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder : ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance : ");
                double initialBalance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit : ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                Account account = new Account(number, holder, initialBalance, withdrawLimit);
                Console.Write("Enter the amount for withdraw : ");
                double withdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(withdrawAmount);
                Console.WriteLine("New Balance : " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadKey();
            }catch (DomainException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }


        }
    }
}
