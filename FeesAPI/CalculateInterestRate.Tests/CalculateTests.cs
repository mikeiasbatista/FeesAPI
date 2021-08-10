using Xunit;

namespace CalculateInterestRate.Tests
{
    public class CalculateTests
    {
        [Fact]
        public void CalculateValuesTest()
        {
            // Arrange
            double expected = 105.1d;

            // Act
            double actual = Helper.CalculationHelper.CalculateCompoundInterest(0.01m, 100m, 5);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
