class Program
{
    public static void Main()
    {
        Console.WriteLine(LeftHanded.Side);
    }
}

interface IHanded
{
    static virtual string Side => "Right";
}

class LeftHanded : IHanded
{
    public static string Side => "Left";
}

class RightHanded : IHanded
{ }
