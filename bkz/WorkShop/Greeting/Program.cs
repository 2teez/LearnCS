using System;

namespace Greeting
{
    class Program
    {
        public static void Main()
        {
            var name = GetName("Enter your name: ");
            Console.WriteLine($"{TitleCase(name)}, we would go a long way in C#!.");
        }

        static string GetName(string msg = "Enter: ")
        {
            string input;
            do
            {
                Console.Write(msg);
                input = Console.ReadLine()!.Trim();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Can't use empty string.");
                }
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        static string TitleCase(string word) => $"{word[0..1].ToUpper()}{word[1..].ToLower()}";

    }
}
