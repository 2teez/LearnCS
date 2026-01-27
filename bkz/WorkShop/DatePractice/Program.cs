using System;

namespace MainClass
{
    using PracticeDateTime;
    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new() { Name = "Java", BirthYear = 1990 };
            Person person2 = new() { Name = "Elixir", BirthYear = 1980 };
            Console.WriteLine($"{person}, {person2}");
            Console.WriteLine(person.Equals(person));
        }
    }
}

namespace PracticeDateTime
{
    class Person
    {
        public required string Name
        {
            get; set;
        }

        public required int BirthYear { get; set; }

        public int GetAge() => DateTime.UtcNow.Year - BirthYear;

        public override bool Equals(object? obj)
        {
            if (obj is not Person p)
            {
                return false;
            }
            return this.Name == p.Name && this.BirthYear == p.BirthYear;
        }

        public override int GetHashCode() => HashCode.Combine(Name, BirthYear);
        public override string ToString() => $"Person: Name: {Name}, Age: {GetAge()}";
    }
}
