using System;

class PracticedClass
{
    public static void Main()
    {
        // using a default constructor in cs
        PersonDefClass.Person p = new PersonDefClass.Person() { Age = 24 };
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

namespace PersonClassWithCons
{
    class Person(string firstName, string lastName, int age = 0)
    {
        // using c#12 merged the class and it seprate constructor
        /*public Person(string firstName, string lastName, int age = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            }*/
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public int? Age { get; } = age;

        public override string ToString() =>
            $"Person: firstname = {FirstName}, lastname = {LastName}, age = {Age}.";
    }
}
