namespace Averages;

using static AverageCalculator;

public class Program
{
    public static void Main(string[] args)
    {
        var nums = new string[] { "4.3", "2.15", "0.95" };
        Console.WriteLine(ArithmeticMean(nums));
    }
}
