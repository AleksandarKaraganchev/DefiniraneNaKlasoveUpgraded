using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlasBankAccount
{
    public class BankAccount
    {
        private int id;
        private double balance;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Print()
        {
            Console.WriteLine($"Account with id |{this.Id}|, has balance |{this.Balance}$|");
        }
    }
}
