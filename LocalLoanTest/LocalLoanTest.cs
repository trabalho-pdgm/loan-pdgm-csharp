using LoanApp;

namespace LocalLoanTest
{
    public class LocalLoanTest
    {
        [Fact(DisplayName = "Calculates the final local loan value")]
        public void GivenLocalLoanInfo_WhenGetTotalLoan_ThenReturnsValueCorrectly()
        {
            var loan = new LocalLoan(
                "José Pedro",
                2000,
                2,
                5,
                10);

            var resultExpected = 2300;

            var resultActual = loan.GetTotalLoan();

            Assert.Equal(resultExpected, resultActual);
        }

        [Fact(DisplayName = "Verifies if the constructor intialize correctly")]
        public void GivenConstructorParameters_WhenCreatingLocalLoan_thenSetsAttributesCorrectly()
        {
            var loan = new LocalLoan(
                "José Pedro",
                2000,
                2,
                5,
                10);

            Assert.Equal("José Pedro", loan.Customer);
            Assert.Equal(2000, loan.Value);
            Assert.Equal(2, loan.Installments);
            Assert.Equal(5, loan.InterestRate);
            Assert.Equal(10, loan.InflationRate);
        }
    }
}