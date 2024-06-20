using LoanApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalLoanTest
{
    public class InternationalLoanTest
    {
        [Fact(DisplayName = "Calculates the final international loan value")]
        public void GivenInternationalLoanInfo_WhenGetTotallLoan_ThenReturnsFinalValue()
        {
            var loan = new InternationalLoan(
                "José Pedro",
                2000,
                2,
                5,
                3,
                4);

            var resultExpected = 65.4;

            var resultActual = loan.GetTotalLoan();

            Assert.Equal(resultExpected, resultActual); 
        }

        [Fact(DisplayName = "Verifies if the constructor intialize correctly")]
        public void GivenConstructorParameters_WhenCreatingInternationalLoan_thenSetsAttributesCorrectly()
        {
            var loan = new InternationalLoan(
                "José Pedro",
                2000,
                2,
                5,
                3,
                4);

            Assert.Equal("José Pedro", loan.Customer);
            Assert.Equal(2000, loan.Value);
            Assert.Equal(2, loan.Installments);
            Assert.Equal(5, loan.InterestRate);
            Assert.Equal(3, loan.ExchangeRate);
            Assert.Equal(4, loan.TransactionFee);
        }
    }
}
