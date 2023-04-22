using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChovekutINegovitePari
{
    internal class BankAccount
    {
        private string accnumber;
        private double balance;
        public string AccNumber
        {
            get { return accnumber; }
            set { accnumber = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }      
    }
}
