
using System;

public class InOutRef
{
    public static void Main()
    {
        Console.WriteLine("Start Here!");
    }
}

internal static class Arith
{
    static (int, int) DivMod(int num, int deno)
    {
        if (deno == 0) throw new ArugmentNullOperation($"Invalid Denominator: {deno}");
        int remainder = num % deno;
        int value = num / deno;
        return (value, remainder);
    }
}
