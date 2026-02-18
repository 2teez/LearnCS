using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Person p = new() { Name = "Java" };
        p.AddKid(new Kid("Clojure", new DateTime(2010, 10, 2)));
        p.AddKid(new Kid("Scala", new DateTime(2005, 1, 5)));
        p.AddKid(new Kid("Groovy", new DateTime(2019, 3, 21)));
        p.AddKid(new Kid("Kotlin", new DateTime(2021, 8, 21)));
        WriteLine(p);
        WriteLine(p[3]);
        var p2 = new Person() { Name = "C#" };
        WriteLine(p2);
    }
}

record Kid(string Name, DateTimeOffset DateOfBirth, bool Alive = true);

class Person
{
    public required string Name;
    private List<Kid> children = new();

    public Kid this[int ind]
    {
        get
        {
            return children[ind];
        }
        set
        {
            children[ind] = value;
        }
    }

    public Kid? this[string name]
    {
        get
        {
            return children.Find(p => p.Name == name);
        }

    }
    public void AddKid(Kid person)
    {
        children.Add(person);
    }
    public override string ToString() =>
        $"Person[Name={Name}, Children={string.Join(",", children)}]";
}
