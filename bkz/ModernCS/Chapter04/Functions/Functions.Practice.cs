
using System;

partial class Program
{
    static string CardinalToOrdinal(uint number)
    {
        uint lastTwoDigit = number % 100;
        switch (lastTwoDigit)
        {
            case 11:
            case 12:
            case 13:
                return $"{number}th";
            default:
                uint lastDigit = number % 10;
                var suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th",
                };
                return $"{number:N0}{suffix}";
        }
    }

    static void RunCardinalToOrdinal(uint limit = 100)
    {
        for (uint i = 1; i <= limit; i++)
        {
            Write($"{CardinalToOrdinal(i)} ");
        }
        WriteLine();
    }
}
