using System;

public class Employee
{
    public required string FirstName;
    public string? LastName;
    public decimal Salary = 0.00M;

    public string FullName() => $"{LastName ?? ""}, {FirstName}";

    public void SetName(string firstName, string lastName = "")
    {
        var formalFirstName = FirstName;
        var formalLastName = LastName;
        FirstName = firstName;
        this.LastName = lastName; // the `this` is not important
        Console.WriteLine(
            $"NOTE: {formalFirstName} is changed to {firstName}, and {formalLastName}, changed to {lastName}.");
    }

    public override string ToString() => $"Employee({FirstName}, {LastName}. Salary: {Salary})";

    public void Save()
    {
        DataStorage.Store(this);
    }
}
