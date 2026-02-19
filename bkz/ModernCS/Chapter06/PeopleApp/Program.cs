using Packt.Shared;

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
    }
}
