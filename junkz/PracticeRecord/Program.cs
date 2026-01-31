namespace PracticeRecord;

class Program
{
    public static void Main()
    {
        var java = new Person(Name: "Java", Age: 42);
        ShowPerson(java);
        var elixir = new Person(Age: 12, Name: "Elixir");
        ShowPerson(elixir);
    }

    internal static void ShowPerson(Person p)
    {
        Console.WriteLine(p);
    }
}

public record Person(string Name, int Age);
