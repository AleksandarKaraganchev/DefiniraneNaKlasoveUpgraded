
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Въведи брой хора: ");
            int n = int.Parse(Console.ReadLine());
            People People = new People();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведи име на човека: ");
                string name = Console.ReadLine();
                Console.Write("Въведи възраст на човека: ");
                int age = int.Parse(Console.ReadLine());
                Person person = new Person(name, age);
                People.MemberAdd(person);
            }
            Console.WriteLine("Хората над 30 години, с техните имена подредени по азбучен ред: ");
            Console.WriteLine("-----------------------------------------------------------------");
            People.Print();
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
