
using System;

class Counter
{
    public static void Main()
    {
        NumberGenerator counter = new();
        var counter2 = new NumberGenerator(5);
        var counter3 = NumberGeneratorWithPrivateConstructor.GetInstance(10);
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine($"{counter}: {counter.GetNextValue}");
            Console.WriteLine($"{counter2}: {counter2.GetNextValue}");
            Console.WriteLine($"{counter3}: {counter3.GetNextValue}");
        }
    }
}

class NumberGenerator
{
    public NumberGenerator(int startNumber = default)
    {
        _count = startNumber;
    }
    NumberGenerator() { }
    private int _count;
    public int GetNextValue
    {
        get
        {
            _count += 1;
            return _count;
        }
        private set
        {
            _count = 0;
        }
    }
}

class NumberGeneratorWithPrivateConstructor
{
    private NumberGeneratorWithPrivateConstructor(int startNumber = default)
    {
        _count = startNumber;
    }
    internal static NumberGeneratorWithPrivateConstructor GetInstance(int number = default)
    {
        return new NumberGeneratorWithPrivateConstructor(number);
    }
    private int _count;
    public int GetNextValue
    {
        get
        {
            _count += 1;
            return _count;
        }
    }
}
