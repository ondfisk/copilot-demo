public class StringCalculatorTests
{
    [Fact]
    public void CalculateSum_EmptyString_ReturnsZero()
    {
        // Arrange
        string numbers = "";

        // Act
        int result = StringCalculator.CalculateSum(numbers);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void CalculateSum_SingleNumber_ReturnsNumber()
    {
        // Arrange
        string numbers = "5";

        // Act
        int result = StringCalculator.CalculateSum(numbers);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void CalculateSum_MultipleNumbers_ReturnsSum()
    {
        // Arrange
        string numbers = "1 2 3 4 5";

        // Act
        int result = StringCalculator.CalculateSum(numbers);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void CalculateSum_InvalidNumber_ReturnsSumOfValidNumbers()
    {
        // Arrange
        string numbers = "1 2 3 a 5";

        // Act
        int result = StringCalculator.CalculateSum(numbers);

        // Assert
        Assert.Equal(11, result);
    }
}