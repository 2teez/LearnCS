namespace AboutMyEnvironment;

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Environment.CurrentDirectory);
        Console.WriteLine(Environment.OSVersion.VersionString);
    }
}
