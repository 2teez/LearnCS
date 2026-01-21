using System;

class Palindrome
{
    public static void Main()
    {
        string palinString = getUserInput("Enter a string: ");
    }

    static string getUserInput(string msg)
    {
        string input;
        do
        {
            Console.Write(msg);
            input = Console.ReadLine();
            input = input.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Can't use empty string.");
            }
        } while(string.IsNullOrWhiteSpace(input));
        return input;
    }
}
