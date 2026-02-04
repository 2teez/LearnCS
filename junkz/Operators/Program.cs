namespace Operations
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var p = new Person("gosling", "jvm");
            Console.WriteLine(p.GetFullName);
            p += new[] { "clojure", "kotlin" };
            Console.WriteLine(p.GetFullName);
        }
    }

    class Person(string firstName, string lastName)
    {
        private string FirstName { get; set; } = firstName;
        private string LastName { get; init; } = lastName;
        public string GetFullName => $"{FirstName}, {LastName}";
        // Wanted to use operator overload to change person
        // fullname by adding other names the person instance
        // may have
        public static Person operator +(Person p, string[] names)
        {
            if (names is null || names.Length == 0)
                return p;
            var firstname = p.FirstName;
            foreach (var name in names)
            {
                firstname += $" {name}";
            }

            return new Person(firstname, p.LastName);
        }

        public void Deconstruct(out string firstname, out string lastname)
        {
            firstname = FirstName;
            lastname = LastName;
        }
    }
}
