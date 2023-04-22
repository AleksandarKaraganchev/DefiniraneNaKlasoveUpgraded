using DefiniraneNaKlasChovek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            BankAccountUpdated account = new BankAccountUpdated();         
            Console.Write("Enter account id: ");
            account.Id = int.Parse(Console.ReadLine());
            account.Deposit(15);
            account.Withdraw(5);
            Console.WriteLine(account.ToString());
        }
    }
}
