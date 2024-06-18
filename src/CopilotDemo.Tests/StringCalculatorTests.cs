using Xunit;

namespace CopilotDemo.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            // Arrange
            string numbers = "";

            // Act
            int result = StringCalculator.Add(numbers);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_SingleNumber_ReturnsNumber()
        {
            // Arrange
            string numbers = "5";

            // Act
            int result = StringCalculator.Add(numbers);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            string numbers = "2,3";

            // Act
            int result = StringCalculator.Add(numbers);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_MultipleNumbers_ReturnsSum()
        {
            // Arrange
            string numbers = "1,2,3,4,5";

            // Act
            int result = StringCalculator.Add(numbers);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Add_NumbersWithNewLineDelimiter_ReturnsSum()
        {
            // Arrange
            string numbers = "1\n2,3";

            // Act
            int result = StringCalculator.Add(numbers);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Add_NumbersWithCustomDelimiter_ReturnsSum()
        {
            // Arrange
            string numbers = "//;\n1;2;3";

            // Act
            int result = StringCalculator.Add(numbers);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Add_NumbersWithNegativeNumbers_ThrowsArgumentException()
        {
            // Arrange
            string numbers = "1,-2,3,-4,5";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => StringCalculator.Add(numbers));
        }

        [Fact]
        public void Add_NumbersGreaterThan1000_IgnoresNumbers()
        {
            // Arrange
            string numbers = "1,1000,2000,3000";

            // Act
            int result = StringCalculator.Add(numbers);

            // Assert
            Assert.Equal(1001, result);
        }
    }
}