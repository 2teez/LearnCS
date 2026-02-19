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
}
