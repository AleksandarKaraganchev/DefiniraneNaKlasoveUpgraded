using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlasBankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            BankAccount acc = new BankAccount();          
            Console.Write("Enter number of bank accounts: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter account id: ");
                acc.Id = int.Parse(Console.ReadLine());
                Console.Write("Enter account balance: ");
                acc.Balance = double.Parse(Console.ReadLine());
                acc.Print();
            }
            Console.WriteLine();
        }
    }
}
