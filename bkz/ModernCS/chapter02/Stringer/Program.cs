namespace Stringer;

class Program
{
    public static void Main(string[] args)
    {
        Person person = new("Gosling", "Java", 40);
        var javaJson = $$"""
            {
                "firstname": {{person.FirstName}},
                "lastname" : {{person.LastName}},
                "age": {{person.Age}},
            }
        """;

        Console.WriteLine(javaJson);
        person.LastName = "Clojure";
        #region changing the lastname of the object
        var clojureJson = $$"""
             {
                 "firstname": {{person.FirstName}},
                 "lastname" : {{person.LastName}},
                 "age": {{person.Age}},
             }
         """;
        #endregion
        Console.WriteLine(clojureJson);
    }
}

record struct Person(string FirstName, string LastName, int Age);
