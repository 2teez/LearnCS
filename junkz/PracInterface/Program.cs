class Program
{
    public static void Main()
    {
        Console.WriteLine(LeftHanded.Side);
        ShowHandedness<RightHanded>();
        ShowHandedness<LeftHanded>();
    }

    public static void ShowHandedness<T>() where T : IHanded
    {
        Console.WriteLine(T.Side);
    }
}

public interface IHanded
{
    static virtual string Side => "Right";
}

public class LeftHanded : IHanded
{
    public static string Side => "Left";
}

public class RightHanded : IHanded
{ }
