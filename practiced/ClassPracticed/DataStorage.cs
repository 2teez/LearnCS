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
        Console.WriteLine("Employee Data Written.");
    }

    public static Employee Load(string firstName, string lastName)
    {
        // get file to load
        var file = new FileStream(firstName + lastName + ".dat", FileMode.Open);
        var reader = new StreamReader(file);
        Employee employee = new() { FirstName = "" };
        employee.FirstName = reader.ReadLine() ??
               throw new InvalidOperationException("FirstName not provided.");
        employee.LastName = reader.ReadLine() ??
                      throw new InvalidOperationException("LastName not provided.");
        var salary = reader.ReadLine() ??
                      throw new InvalidOperationException("LastName not provided.");
        if (decimal.TryParse(salary, out decimal newSalary))
        {
            employee.Salary = newSalary;
        }
        else
        {
            employee.Salary = 0.00M;
        }
        reader.Dispose();
        return employee;
    }
}
