namespace CopilotDemo
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = new List<string> { ",", "\n" };
            if (numbers.StartsWith("//"))
            {
                var delimiterEndIndex = numbers.IndexOf('\n');
                var customDelimiter = numbers.Substring(2, delimiterEndIndex - 2);
                delimiters.Add(customDelimiter);
                numbers = numbers.Substring(delimiterEndIndex + 1);
            }

            var numberArray = numbers.Split(delimiters.ToArray(), StringSplitOptions.None);
            var sum = 0;
            foreach (var number in numberArray)
            {
                if (int.TryParse(number, out int result))
                {
                    sum += result;
                }
            }
            return sum;
        }
    }
}