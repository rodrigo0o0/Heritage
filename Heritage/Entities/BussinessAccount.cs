using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage.Entities
{
    internal class BussinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public BussinessAccount()
        {
        }

        public BussinessAccount(int number, string holder, double balance,double loanlimit) : base(number, holder, balance)
        {
            LoanLimit = loanlimit;
        }

        public void Loan (double amount)
        {
            if(LoanLimit >= amount)
            {
                Balance += amount;
            }
        }

    }
}
