namespace Numbers;

class Program
{
    public static void Main(string[] args)
    {
        const int col1 = 7;
        const int col2 = 3;
        const int col3 = 32;
        string line = new('-', col1 + col2 + col3 + col3 + 4);
        // print out the line
        Console.WriteLine(line);
        Console.WriteLine($"{"Type",-col1} {"Byte(s) of Memory",-col3} {"Min",-col3} {"Max",-col3}");
        Console.WriteLine(line);
        Console.WriteLine($"{"sbyte",-col1} {sizeof(sbyte),-col3} {sbyte.MinValue,-col3} {sbyte.MaxValue,-col3}");
        Console.WriteLine($"{"byte",-col1} {sizeof(byte),-col3} {byte.MinValue,-col3} {byte.MaxValue,-col3}");
        Console.WriteLine($"{"ushort",-col1} {sizeof(ushort),-col3} {ushort.MinValue,-col3} {ushort.MaxValue,-col3}");
        Console.WriteLine($"{"short",-col1} {sizeof(short),-col3} {short.MinValue,-col3} {short.MaxValue,-col3}");
        Console.WriteLine($"{"int",-col1} {sizeof(int),-col3} {int.MinValue,-col3} {int.MaxValue,-col3}");
        Console.WriteLine($"{"uint",-col1} {sizeof(uint),-col3} {uint.MinValue,-col3} {uint.MaxValue,-col3}");
        Console.WriteLine($"{"long",-col1} {sizeof(long),-col3} {long.MinValue,-col3} {long.MaxValue,-col3}");
        Console.WriteLine($"{"ulong",-col1} {sizeof(ulong),-col3} {ulong.MinValue,-col3} {ulong.MaxValue,-col3}");
        unsafe
        {
            Console.WriteLine($"{"Int128",-col1} {sizeof(Int128),-col3} {Int128.MinValue,-col3} {Int128.MaxValue,-col3}");
            Console.WriteLine($"{"UInt128",-col1} {sizeof(UInt128),-col3} {UInt128.MinValue,-col3} {UInt128.MaxValue,-col3}");
            Console.WriteLine($"{"Half",-col1} {sizeof(Half),-col3} {Half.MinValue,-col3} {Half.MaxValue,-col3}");

        }
        Console.WriteLine($"{"float",-col1} {sizeof(float),-col3} {float.MinValue,-col3} {float.MaxValue,-col3}");
        Console.WriteLine($"{"double",-col1} {sizeof(double),-col3} {double.MinValue,-col3} {double.MaxValue,-col3}");
        Console.WriteLine($"{"decimal",-col1} {sizeof(decimal),-col3} {decimal.MinValue,-col3} {decimal.MaxValue,-col3}");
        Console.WriteLine(line);
    }
}
