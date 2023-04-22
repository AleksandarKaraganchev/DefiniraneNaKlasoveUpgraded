using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlasChovek
{
    public class Person
    {
        private int age;
        private string name;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void IntoroduceYourself()
        {
            Console.WriteLine($"{Name} is {Age} years old");
        }     
    }
}
