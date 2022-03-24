using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number : ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder : ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance : ");
            double initialBalance = double.Parse(Console.ReadLine());

        }
    }
}
