using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlasChovek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Person person = new Person();
            Console.Write("Въведете брой хора: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведи име: ");
                person.Name = Console.ReadLine();
                Console.Write("Въведи възраст: ");
                person.Age = int.Parse(Console.ReadLine());
                person.IntoroduceYourself();
            }
            Console.WriteLine();
        }
    }
}
