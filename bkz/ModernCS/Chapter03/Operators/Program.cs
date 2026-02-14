namespace Operators;

class Program
{
    public static void Main(string[] args)
    {
        WriteLine("Operators:...");
        object o = "3";
        if (o is int i)
        {
            WriteLine($"int gotten: {i} = {i * 5}");
        }
        else
        {
            WriteLine("o is not an integer...");
        }
        // using a random number
        var rand = Random.Shared.Next(minValue: 2, maxValue: 78);
        WriteLine(TellRandomNumber(rand));
        //
        // using random generator
        byte[] bytes = new byte[5];
        Random.Shared.NextBytes(bytes);
        for (var num = 0; num < bytes.Length; num++)
        {
            Write($"{bytes[num]:X2}");
        }
        WriteLine();
        WriteLine(ToBase64String(bytes));
    }

    static string TellRandomNumber(int number) => number switch
    {
        1 => "One",
        2 => "Two",
        _ => $"Number: {number}"
    };

}
