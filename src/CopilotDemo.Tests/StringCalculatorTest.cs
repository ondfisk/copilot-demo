using Xunit;

namespace CopilotDemo.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void CalculateSum_WithEmptyString_ReturnsZero()
        {
            // Arrange
            string numbers = "";

            // Act
            int result = StringCalculator.CalculateSum(numbers);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculateSum_WithSingleNumber_ReturnsNumber()
        {
            // Arrange
            string numbers = "5";

            // Act
            int result = StringCalculator.CalculateSum(numbers);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void CalculateSum_WithMultipleNumbers_ReturnsSum()
        {
            // Arrange
            string numbers = "1 2 3 4 5";

            // Act
            int result = StringCalculator.CalculateSum(numbers);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void CalculateSum_WithInvalidNumbers_IgnoresInvalidNumbers()
        {
            // Arrange
            string numbers = "1 2 abc 4 5";

            // Act
            int result = StringCalculator.CalculateSum(numbers);

            // Assert
            Assert.Equal(12, result);
        }
    }
}