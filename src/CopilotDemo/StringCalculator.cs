/// <summary>
/// Represents a calculator that performs calculations on a string of numbers.
/// </summary>
public class StringCalculator
{
    /// <summary>
    /// Calculates the sum of numbers in a string.
    /// </summary>
    /// <param name="numbers">The string containing numbers separated by spaces.</param>
    /// <returns>The sum of the numbers.</returns>
    public static int CalculateSum(string numbers)
    {
        string[] numberArray = numbers.Split(' ');
        int sum = 0;

        foreach (string number in numberArray)
        {
            sum += int.Parse(number);
        }

        return sum;
    }
}
