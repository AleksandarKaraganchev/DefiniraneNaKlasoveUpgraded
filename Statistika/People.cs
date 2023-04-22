using DefiniraneNaKlasChovek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistika
{
    internal class People
    {
        public List<Person> Familymembers = new List<Person>();
        public void MemberAdd(Person person)
        {
            if (person.Age >= 30)
            {
                Familymembers.Add(person);
            }
        }
        public void Print()
        {
            Familymembers.Sort((person1, person2) => string.Compare(person1.Name, person2.Name)); //=> - ламбда оператор. Tой служи за дефиниране на ламбда изрази, които са кратки функции без име.
            foreach (Person Familymember in Familymembers)
            {
                Console.WriteLine($"{Familymember.Name} {Familymember.Age}");
            }
        }
    }
}
