
using System;

class Fac
{
    public static void Main()
    {
        for(int i = 0; i < 45; i++)
        {
            Console.WriteLine($"Factorial of {i}! = {factorial(number: i)}");
        }
    }

    static ulong factorial(int number = 0)
    {
        if (number <= 0)
        {
            return 1;
        }
        else
        {
            return (ulong)number * (ulong)factorial(number-1);
        }
    }
}
