using Xunit;

namespace CalculateInterestRate.Tests
{
    public class CalculateTests
    {
        [Theory]
        [InlineData(0.01, 100, 5, 105.1d)]
        [InlineData(0.01, 350, 12, 394.38d)]
        [InlineData(0.01, 499.90, 24, 634.74d)]
        public void CalculateValuesTest(decimal juros, decimal vlrInicial, int tempo, double expected)
        {
            // Act
            double actual = Helper.CalculationHelper.CalculateCompoundInterest(juros, vlrInicial, tempo);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
