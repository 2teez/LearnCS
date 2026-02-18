
using Packt.Shared;

partial class Program
{
    public static void Main(string[] args)
    {
        ConfigureConsole();
        Person bob = new(); //{ Name = null, Born = new DateTimeOffset(1965, 12, 22, 16, 28, 0, TimeSpan.FromHours(-5)) };
        bob.Name = "Bob Smith";
        bob.Born = new DateTimeOffset(1965, 12, 22, 16, 28, 0, TimeSpan.FromHours(-5));
        WriteLine($"{bob.Name} was born on {bob.Born:D}");
        bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
        //
        WriteLine($"{bob.Name} favorite ancient wonder is {bob.FavoriteAncientWonder}. it Integer is {(int)bob.FavoriteAncientWonder}");
        //
        // using the book.cs file
        Book book = new()
        {
            Isbn = "978-1803237800",
            Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
        };
        WriteLine($"{book.Title} was written by {book.Author}, with {book.PageCount:N0} pages.");
    }
}
