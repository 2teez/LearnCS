
using System;
using static Arith;

public class InOutRef
{
    public static void Main()
    {
        (int value, int remainder) divMod = DivMod(3, 8);
        Console.WriteLine($"{divMod.value}, {divMod.remainder}");
        // OR
        (int value, int remainder) = DivMod(3, 8);
        Console.WriteLine($"{value}, {remainder}");
        int anValue = DivMod(8, 5, out int anRemainder);
        Console.WriteLine($"{anValue}, {anRemainder}");
        Swapper(ref value, ref remainder);
        Console.WriteLine($"After Swap: {value}, {remainder}");
    }
}

internal static class Arith
{
    public static (int, int) DivMod(int num, int deno)
    {
        if (deno == 0)
            throw new ArgumentNullException($"Invalid Denominator: {deno}");
        int remainder = num % deno;
        int value = num / deno;
        return (value, remainder);
    }

    public static int DivMod(int num, int deno, out int remainder)
    {
        if (deno == 0)
            throw new ArgumentNullException($"Invalid Denominator: {deno}");
        remainder = num % deno;
        return num / deno;
    }

    public static void Swapper(ref int firstNumber, ref int secondNumber)
    => (firstNumber, secondNumber) = (secondNumber, firstNumber);

}
