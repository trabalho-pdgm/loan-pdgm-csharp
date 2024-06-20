using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    public class LocalLoan : Loan
    {

        public double InflationRate { get; }

        public LocalLoan(string customer, double value, int installments, double interestRate, double inflationRate) : base(customer, value, installments, interestRate)
        {
            InflationRate = inflationRate;
        }

        public override double GetTotalLoan()
        {
            return Value + (Value * (InterestRate / 100)) + (Value * (InflationRate / 100));
        }
    }
}
