string input = string.Join(" ", args);
Console.WriteLine($"Input: {input}");
int sum = StringCalculator.CalculateSum(input);
Console.WriteLine($"The sum is: {sum}");
