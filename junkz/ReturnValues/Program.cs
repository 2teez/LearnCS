namespace ReturnValues;

using static System.Console;

using MyFruit = (string fruit, int number);

public class Program
{
    public static void Main(string[] args)
    {
        Fruity myFruit = new() { Fruit = "Easy-Peeler" };
        var (fruit, number) = myFruit.GetFruit();
        WriteLine($"{fruit}, {number}");
        (fruit, number) = myFruit.GetFruit("apple", 6);
        WriteLine($"{fruit}, {number}");
        // using the alias
        Fruity mango = new() { Fruit = "Mango" };
        MyFruit mangoFruit = mango.GetFruit(); // here
        WriteLine($"{mangoFruit.number}, {mangoFruit.fruit}");

        #region calling internal/inner function
        WriteLine(Factorial(5));
        #endregion calling internal/inner function
    }

    // using internal function
    public static int Factorial(int number)
    {
        if (number < 0)
            throw new ArgumentException("Wrong parameter..");
        return innerFactorial(number);

        static int innerFactorial(int number)
        {
            if (number == 0) return 1;
            return number * innerFactorial(number - 1);
        }
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
