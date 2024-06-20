using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    public abstract class Loan
    {
        public String Customer { get; }
        public double Value { get; }  
        public int Installments { get; }
        public double InterestRate { get; }

        public Loan(string customer, double value, int installments, double interestRate)
        {
            Customer = customer;
            Value = value;
            Installments = installments;
            InterestRate = interestRate;
        }

        public abstract double GetTotalLoan();
    }
}
