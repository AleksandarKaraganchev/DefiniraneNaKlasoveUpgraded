using DefiniraneNaKlasChovek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semeistvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Колко членно да е семейството: ");
            Person person = new Person();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведи име на човека: ");
                person.Name = Console.ReadLine();
                Console.Write("Въведи възраст на човека: ");
                person.Age = int.Parse(Console.ReadLine());
                person.IntoroduceYourself();
            }
        }
    }
}
