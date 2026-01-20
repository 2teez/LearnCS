using System;

class ArraysDemo
{
    public static void Main()
    {
        Console.WriteLine("Arrays Demonstrations: ");
        var langs = new string[]{
            "C#", "Zig", "Rust", "Java", "Crystal", "Go", "Odin",
        };

        Console.WriteLine(
            $@"Languages stated:{Environment.NewLine}{string.Join(", ", langs)}.
            {Environment.NewLine}With {langs.Length} number of Computer Programming Languages.");
        //
        string[] scriptedLangs = {"Perl", "Python", "JavaScript", "TypeScript"};
        Console.WriteLine($"{string.Join(", ", scriptedLangs[..])}");
        //
        Array.Sort(scriptedLangs);
        Console.WriteLine(string.Join(", ", scriptedLangs));

        // get the index of the Java
        var searchedIndex = Array.BinarySearch(langs, "Java");
        println($"The index of Java in {string.Join(",", langs)} is {searchedIndex+1}.");
    }

    static void println(string str)
    {
        Console.WriteLine(str);
    }
}
