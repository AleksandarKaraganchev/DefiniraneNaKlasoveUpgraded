using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChovekutINegovitePari
{
    internal class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;
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
        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
        public double GetAccountBalance()
        {
            double balance = 0;
            foreach (BankAccount account in Accounts)
            {
                balance += account.Balance;
            }
            return balance;
        }
    }
}
