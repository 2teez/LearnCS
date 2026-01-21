using System;

class Palindrome
{
    public static void Main()
    {
        string str = getUserInput("Enter a string: ");
        var plainString = str.Replace(" ", "").ToLower();
        var reversedString = plainString.ToCharArray();
        Array.Reverse(reversedString);
        if (plainString == new string(reversedString))
        {
            Console.WriteLine($"\'{str}\' is a Palindrome string.");
        }
        else
        {
             Console.WriteLine($"\'{str}\' is NOT a Palindrome string.");
        }
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
