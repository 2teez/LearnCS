using System;
using PracticeRecord;

class Record
{
    public static void Main()
    {
        var java = new Person(Name: "Java", Age: 42);
        ShowPerson(java);
    }

    internal static void ShowPerson(Person p)
    {
        Console.WriteLine(p);
    }
}

namespace PracticeRecord
{
    public record Person(string Name, int Age);
}
