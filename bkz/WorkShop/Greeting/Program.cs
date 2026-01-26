using System;

namespace Greeting
{
    class Program
    {
        public static void Main()
        {
            var name = GetInput("Enter your name: ");
            Console.WriteLine($"{TitleCase(name)}, we would go a long way in C#!.");
            // comparing string
            var first = GetInput();
            string second = first;
            first = null;
            Console.WriteLine($"{first} <> {second}.");
            Console.WriteLine($"first == second: {first == second}.");
            Console.WriteLine($"string.Equals(first,second): {string.Equals(first, second)}.");
        }

        static string GetInput(string msg = "Enter: ")
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
