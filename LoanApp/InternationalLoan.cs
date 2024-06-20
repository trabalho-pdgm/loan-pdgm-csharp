using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    public class InternationalLoan : Loan
    {
      
        public double ExchangeRate { get; }
        public double TransactionFee { get; }

        public InternationalLoan(string customer, double value, int installments,
           double interestRate, double exchangeRate,
           double transactionFee) : base(customer, value, installments, interestRate)
        {
            ExchangeRate = exchangeRate;
            TransactionFee = transactionFee;
        }

        public override double GetTotalLoan()
        {
            double localValue = Value * (ExchangeRate / 100);
            double interest = localValue * (InterestRate / 100);
            double transaction = localValue * (TransactionFee / 100);

            return localValue + interest + transaction;
        }
    }
}
