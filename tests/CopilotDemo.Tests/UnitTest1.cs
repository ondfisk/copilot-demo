namespace CopilotDemo.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_EmptyString_ReturnsZero()
    {
        var calculator = new CopilotDemo.StringCalculator();
        var result = calculator.Add("");
        result.Should().Be(0);
    }

    [Fact]
    public void Add_SingleNumber_ReturnsThatNumber()
    {
        var calculator = new CopilotDemo.StringCalculator();
        var result = calculator.Add("1");
        result.Should().Be(1);
    }

    [Fact]
    public void Add_TwoNumbers_ReturnsTheirSum()
    {
        var calculator = new CopilotDemo.StringCalculator();
        var result = calculator.Add("1,2");
        result.Should().Be(3);
    }

    [Fact]
    public void Add_NewLineDelimiter_ReturnsSum()
    {
        var calculator = new CopilotDemo.StringCalculator();
        var result = calculator.Add("1\n2,3");
        result.Should().Be(6);
    }

    [Fact]
    public void Add_CustomDelimiter_ReturnsSum()
    {
        var calculator = new CopilotDemo.StringCalculator();
        var result = calculator.Add("//;\n1;2");
        result.Should().Be(3);
    }
}