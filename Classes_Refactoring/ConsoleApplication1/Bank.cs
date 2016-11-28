using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Bank : Structures
    {
        private double AmountOfMoney { get; set; }

        public Bank ()
        {
            this.AmountOfMoney = 0;
        }

        public double DepositeMoney(double AmountOfMoney, double balance)
        {
            return balance + AmountOfMoney;
        }

        public double WithdrawMoney(double AmountOfMoney, double balance)
        {
            return balance - AmountOfMoney;
        }
    }
}
