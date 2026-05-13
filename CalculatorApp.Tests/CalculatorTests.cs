using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnSum_WhenTwoNumbersAreAdded()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(5, 3);

            // Assert
            Assert.Equal(8, result);
        }
    }
}