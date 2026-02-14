namespace Exer3_0;

class Program
{
    public static void Main(string[] args)
    {
        for (int num = 0; num < 100; num++)
        {
            if (num % 10 == 0)
            {
                WriteLine();
            }
            RunFizzBuzz(num + 1);
        }
        WriteLine();
    }

    static void RunFizzBuzz(int number) => Write(number switch
    {
        var n when GetBoolValue(n, 15) => "FizzBuzz, ",
        var n when n % 3 == 0 => "Fizz, ",
        var n when n % 5 == 0 => "Buzz, ",
        _ => $"{number}, ",
    });

    static bool GetBoolValue(int value, int divisor) => value % divisor == 0;
}
