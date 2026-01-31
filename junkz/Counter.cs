
using System;

class Counter
{
    public static void Main()
    {
        NumberGenerator counter = new();
        var counter2 = new NumberGenerator(5);
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine($"{counter}: {counter.GetNextValue}");
            Console.WriteLine($"{counter2}: {counter2.GetNextValue}");
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
