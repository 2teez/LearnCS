namespace HelloCS;

using static System.Console;
using static System.Environment;

internal class Program
{
    public static void Main(string[] args)
    {
        WriteLine(
            $"Namespace name is {typeof(Program).Namespace ?? "<null>"}");
        WriteLine(CurrentDirectory);
        WriteLine(Version);
    }
}
