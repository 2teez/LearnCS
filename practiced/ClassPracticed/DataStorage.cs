using System;
using System.IO;

class DataStorage
{
    public static void Store(Employee employee)
    {
        var file = new FileStream(employee.FirstName + employee.LastName + ".dat", FileMode.Create);
        var writer = new StreamWriter(file);
        writer.WriteLine(employee.FirstName);
        writer.WriteLine(employee.LastName);
        writer.WriteLine(employee.Salary);
        //
        writer.Dispose();
    }

    public static void Load(string firstName, string? lastName)
    {

    }
}
