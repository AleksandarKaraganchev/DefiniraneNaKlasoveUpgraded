using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChovekutINegovitePari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Person person = new Person();
            Console.Write("Въведи име на човек: ");
            person.Name = Console.ReadLine();
            Console.Write("Въведи възраст на човек: ");
            person.Age = int.Parse(Console.ReadLine());
            person.Accounts = new List<BankAccount>();
            Console.Write("Въведи брой банкови акаунти: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                BankAccount account = new BankAccount();
                Console.Write($"Въведи номер на акаунт {i + 1}: ");
                account.AccNumber = Console.ReadLine();
                Console.Write($"Въведи налични пари в акаунт {i + 1}: ");
                account.Balance = double.Parse(Console.ReadLine());
                person.Accounts.Add(account);
            }        
            Console.WriteLine($"Тотално наличие: {person.Name} --> {person.GetAccountBalance()}");
        }
    }
}
