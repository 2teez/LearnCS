using System;

class Division
{
    public static void Main()
    {
        var firstValue = getIntInput(Console.ReadLine());
        var secondValue = getIntInput(Console.ReadLine());

        Console.WriteLine($"{getDivMod(firstValue,secondValue)}");
    }

    static (int? Div, int? Mod) getDivMod(int numerator, int denominator)
    {
        int? div = null;
        if (denominator != 0)
        {
            div = numerator / denominator;
        }
        else
        {
            div = 0;
        }
        int mod = numerator % denominator;
        return (div, mod);
    }

    static int getIntInput(string input)
    {
        int value;
        do
        {
            Console.WriteLine("Enter valid input");
            input = Console.ReadLine().Trim();
        } while(!int.TryParse(input, out value));
        return value;
    }
}
