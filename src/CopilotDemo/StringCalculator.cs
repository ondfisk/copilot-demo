namespace CopilotDemo;

public class StringCalculator
{

    public static int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        var delimiters = new List<string> { ",", "\n" };

        if (numbers.StartsWith("//"))
        {
            var customDelimiter = numbers.Substring(2, numbers.IndexOf("\n") - 2);
            delimiters.Add(customDelimiter);
            numbers = numbers.Substring(numbers.IndexOf("\n") + 1);
        }

        var numberArray = numbers.Split(delimiters.ToArray(), StringSplitOptions.None);

        var sum = 0;
        var negativeNumbers = new List<int>();

        foreach (var number in numberArray)
        {
            if (int.TryParse(number, out var num))
            {
                if (num < 0)
                {
                    negativeNumbers.Add(num);
                }
                else if (num <= 1000)
                {
                    sum += num;
                }
            }
        }

        if (negativeNumbers.Any())
        {
            throw new ArgumentException($"Negatives not allowed: {string.Join(", ", negativeNumbers)}");
        }

        return sum;
    }
}
