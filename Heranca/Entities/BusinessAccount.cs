using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProg.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public double Debt { get; set; }
        public BusinessAccount() 
        {
            Balance = 10;
        }
        public BusinessAccount(int number, string holder, double balance,double loanLimit) : base(number,holder,balance)
        {
            LoanLimit = loanLimit;
        }
        public void Loan(double amount) 
        {
            if (amount <= LoanLimit) 
            {
                Balance += amount;
                Debt += amount;
            }
        }
    }
}
