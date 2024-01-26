public class StringCalculator
{
    public static int CalculateSum(string numbers)
    {
        var num = numbers.Split(" ");

        int sum = 0;
        foreach (var n in num)
        {
            if (int.TryParse(n, out int result))
            {
                sum += result;
            }
        }

        return sum;
    }
}
