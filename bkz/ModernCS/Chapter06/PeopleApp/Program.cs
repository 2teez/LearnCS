using Packt.Shared;

namespace PeopleApp;

public class Program
{
    public static void Main(string[] args)
    {
        Person harry = new()
        {
            Name = "Harry",
            Born = new(year: 2001, month: 3, day: 25,
        hour: 0, minute: 0, second: 0,
        offset: TimeSpan.Zero)
        };
        harry.WriteToConsole();
        //
        Person lamech = new() { Name = "Lamech" };
        Person adah = new() { Name = "Adah" };
        Person zillah = new() { Name = "Zillah" };
        // Call the instance method to marry Lamech and Adah.
        lamech.Marry(adah);
        // Call the static method to marry Lamech and Zillah.
        Person.Marry(lamech, zillah);
        lamech.OutputSpouses();
        adah.OutputSpouses();
        zillah.OutputSpouses();
        // instance of baby
        Person baby1 = lamech.ProcreateWith(adah);
        baby1.Name = "Jabal";
        WriteLine($"{baby1.Name} was born on {baby1.Born}");

        // using the static method
        Person baby2 = Person.Procreate(zillah, lamech);
        baby2.Name = "Tubalcain";

        adah.WriteChildenToConsole();
        zillah.WriteChildenToConsole();
        lamech.WriteChildenToConsole();
        //
        for (int i = 0; i < lamech.Children.Count; i++)
        {
            WriteLine($" {lamech.Name}'s child #{i + 1} is named \"{lamech.Children[i].Name}\".");
        }
    }
}
