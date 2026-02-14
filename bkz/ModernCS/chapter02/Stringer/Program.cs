namespace Stringer;

class Program
{
    public static void Main(string[] args)
    {
        var person = new { FirstName = "Gosling", LastName = "Java", Age = 40 };
        var javaJson = $$"""
            {
                "firstname": {{person.FirstName}},
                "lastname" : {{person.LastName}},
                "age": {{person.Age}},
            }
        """;

        Console.WriteLine(javaJson);
    }
}

readonly record struct Person(string FirstName, string LastName, int Age);
