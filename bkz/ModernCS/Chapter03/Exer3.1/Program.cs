namespace Exer3_1;

using static System.Console;

class Program
{
    public static void Main(string[] args)
    {
        (var okNum, var numerator) =
        GetUserInput("Enter a number between 0 and 255: ").Checked().CheckRange();
        (var okDeno, var deno) =
        GetUserInput("Enter a number between 0 and 255: ").Checked().CheckRange();
        if (okNum && okDeno)
        {
            WriteLine($"{numerator} divided by {deno} = {numerator / deno}");
        }
    }

    public static string GetUserInput(string str = "Enter: ")
    {
        string input;
        do
        {
            Write(str);
            input = ReadLine() ?? ""; // get input from user
        } while (string.IsNullOrEmpty(input));
        return input;
    }
}

static class ConvertToInt
{
    public static int Checked(this string value)
    {
        int intValue = 0;
        try
        {
            intValue = int.Parse(value);
        }
        catch (Exception ex)
        {
            WriteLine($"{ex.GetType().Name}: {ex.Message}");
        }
        return intValue;
    }
}

static class Checking
{
    public static (bool, int) CheckRange(this int value, int lower = 0, int upper = 255)
    {
        if (lower <= value && upper >= value)
        {
            return (true, value);
        }
        throw new ArgumentOutOfRangeException(nameof(value));
    }
}
