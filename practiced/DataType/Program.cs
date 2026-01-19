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
    }

    static string getUserInput(string msg) {
        Console.Write(msg);
        string input = Console.ReadLine();
        return input;
    }
}
