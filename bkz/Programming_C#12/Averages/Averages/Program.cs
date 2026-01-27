namespace Averages;

using static AverageCalculator;

internal class Program
{
    public static void Main(string[] args)
    {
        var nums = new string[] { "4.3", "2.15", "0.95" };
        Console.WriteLine(ArithmeticMean(nums));
        try
        {
            Console.WriteLine(ArithmeticAverage(args));
        }
        catch (InvalidOperationException ioe)
        {
            Console.WriteLine("No args from the cli");
        }
    }
}
