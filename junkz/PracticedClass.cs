using System;
using PersonDefClass;

class PracticedClass
{
    public static void Main()
    {
        PersonDefClass.Person p = new Person() { Age = 24 };
        p.FirstName = "Java";
        p.LastName = "Gosling";
        Console.WriteLine(p);
    }
}

namespace PersonDefClass
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; } = 0;

        public override string ToString() =>
            $"Person: firstname = {FirstName}, lastname = {LastName}, age = {Age}.";
    }
}
