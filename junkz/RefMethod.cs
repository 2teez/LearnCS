using System;

class RefMethod
{
    public static void Main()
    {
        string first = "GoodBye";
        string second = "Welcome";
        Console.WriteLine($"Before Swap: {first} <> {second}");
        Swap(ref first, ref second);
        Console.WriteLine($"After  Swap: {first} <> {second}");
    }

    static void Swap(ref string first, ref string second)
    {
        var temp = first;
        first = second;
        second = temp;
    }
}
