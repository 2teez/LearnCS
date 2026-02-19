namespace Packt.Shared;

public class Person
{
    public string? Name { get; set; }
    public DateTimeOffset Born { get; set; }
    public List<Person> Children { get; set; } = new();
    public List<Person> Spouses { get; set; } = new();

    public void WriteToConsole()
    {
        WriteLine($"{Name} Born on {Born:dddd}");
    }

    public void WriteChildenToConsole()
    {
        string term = Children.Count == 1 ? "Child" : "Children";
        WriteLine($"{Name} has  {Children.Count} {term}");
    }

    public bool IsMarried => Spouses.Count > 0;

    public static void Marry(Person p1, Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        if (p1.Spouses.Contains(p2) || p2.Spouses.Contains(p1))
        {
            throw new ArgumentException($"{p1.Name} already marries {p2.Name}");
        }
        p1.Spouses.Add(p2);
        p2.Spouses.Add(p1);
    }

    public void Marry(Person partner)
    {
        Marry(this, partner);
    }

    public void OutputSpouses()
    {
        if (IsMarried)
        {
            string term = Spouses.Count == 1 ? "person" : "people";
            WriteLine($"{Name} is married to {Spouses.Count} {term}");

            foreach (var spouse in Spouses)
            {
                WriteLine($"  {spouse.Name}");
            }
        }
        else
        {
            WriteLine($" {Name} is a singleton.");
        }
    }
    /// <summary>
    /// Static method to "multiply" aka procreate and habe a child together.
    /// </summary>
    /// <param name= "p1"> Parent 1 </param>
    /// <param name= "p2"> Parent 2 </param>
    /// <returns> A Person object that is the child of Parent 1 and Parent 2. </returns>
    /// <expection cref="ArgumentNullException">If p1 or p2 are null. </exception>
    /// <expection cref="ArgumentException">If p1 or p2 are not married. </exception>
    public static Person Procreate(Person p1, Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        if (!p1.Spouses.Contains(p2) || !p2.Spouses.Contains(p1))
        {
            throw new ArgumentException($"{p1.Name} is not married to {p2.Name} to procreate.");
        }
        var baby = new Person()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}",
            Born = DateTimeOffset.Now
        };
        p1.Children.Add(baby);
        p2.Children.Add(baby);

        return baby;
    }

    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }

    // operator overload for Person class
    public static bool operator +(Person p1, Person p2)
    {
        Marry(p1, p2);
        return p1.IsMarried && p2.IsMarried;
    }

    public static Person operator *(Person p1, Person p2)
    {
        return Procreate(p1, p2);
    }
}
