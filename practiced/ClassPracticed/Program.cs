using System;

class Program
{
    public static void Main()
    {
        Employee employee = new() { FirstName = "Elixir" };
        Console.WriteLine(employee);
        employee.SetName("Java", "Gosling");
        Console.WriteLine(employee);
    }
}
