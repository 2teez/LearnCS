
namespace MainClass
{
    using PracticeDateTime;
    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new() { Name = "Java", BirthYear = 1990 };
            Console.WriteLine(person);
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
            var p = (Person)obj;
            if (p != null)
            {
                return false;
            }
            return this.Name == p?.Name && this.BirthYear == p?.BirthYear;
        }

        public override int GetHashCode() => base.GetHashCode();
        public override string ToString() => $"Person: Name: {Name}, Age: {GetAge()}";
    }
}
