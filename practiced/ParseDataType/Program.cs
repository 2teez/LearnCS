// See https://aka.ms/new-console-template for more information
#nullable disable
Console.WriteLine("Try Parse Number from Input");

string input = getUserInput("Enter your age: ");
// 1. using Parse function
int age = int.Parse(input);
Console.WriteLine($"Using \"int.Parse\" function.{Environment.NewLine}I am {age} years Old.");

// 2. using System.Convert function
input = getUserInput("Enter another age: ");
age = Convert.ToInt32(input);
Console.WriteLine($"Using \"Convert.ToInt\" function.{Environment.NewLine}I am {age} years Old.");

// 3. using TryParse function
input = getUserInput("Enter another age: ");
//age = Convert.ToInt32(input);
if (int.TryParse(input, out int n_age))
{
    Console.WriteLine(
        $"Using \"Convert.ToInt\" function.{Environment.NewLine}I am {n_age} years Old.");
}
else
{
    Console.WriteLine(
        $"Invalid {input} value.");
}


// static functions
static string getUserInput(string msg)
{
    Console.Write(msg);
    string input = Console.ReadLine();
    while(!isEmpty(input))
    {
        Console.WriteLine("Empty string can't be used.");
        Console.Write(msg);
        input = Console.ReadLine();
    }
    return input;
}

static bool isEmpty(string str)
{
    if (str.Length == 0)
    {
        return false;
    }
    return true;
}
