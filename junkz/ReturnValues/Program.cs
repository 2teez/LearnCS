namespace ReturnValues;

using MyFruit = (string fruit, int number);

internal class Program
{
    public static void Main(string[] args)
    {
        Fruity myFruit = new() { Fruit = "Easy-Peeler" };
        var (fruit, number) = myFruit.GetFruit();
        Console.WriteLine($"{fruit}, {number}");
        (fruit, number) = myFruit.GetFruit("apple", 6);
        Console.WriteLine($"{fruit}, {number}");
        // using the alias
        Fruity mango = new() { Fruit = "Mango" };
        MyFruit mangoFruit = mango.GetFruit(); // here
        Console.WriteLine($"{mangoFruit.number}, {mangoFruit.fruit}");
    }
}

class Fruity
{
    public required string Fruit;
    public int number;
    public (string, int) GetFruit(string fruit, int number)
    {
        Fruit = fruit;
        this.number = number;
        return (fruit, number);
    }
    public (string fruit, int number) GetFruit()
    {
        return (fruit: Fruit, number: this.number);
    }
}
