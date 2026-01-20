using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter FirstName: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter LastName: ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"My name is {lastName}, {firstName}.");
        // using static function
        string lang = getUserInput("Enter favourite language: ");
        Console.WriteLine($"My favourite language is {lang}");
        //
        // display in hex
        for(int i = 16; i <= 32; i++)
        {
            Console.Write("{0}", i);
            Console.WriteLine($"- 0x{i:X}, 0b{i:b}");
        }
    }

    static string getUserInput(string msg) {
        Console.Write(msg);
        string input = Console.ReadLine();
        return input;
    }
}
