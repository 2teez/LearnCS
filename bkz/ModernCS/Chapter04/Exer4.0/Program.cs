namespace Exer4_0;

class Program
{
    public static void Main(string[] args)
    {
        WriteLine(4.IsPrime());
        //List<int> nums = [4, 7, 30, 40, 50];
        //foreach (var num in nums)
        //{
        50.GetPrimeFactors();
        //}
    }
}

static class IntegerExtension
{
    public static bool IsPrime(this int value)
    {
        if (value < 2) return false;
        int limit = (int)Math.Sqrt(value);
        for (int num = 2; num <= limit; num++)
        {
            if (value % num == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static void GetPrimeFactors(this int value)
    {
        int myValue = value;
        int factor = 2;

        while (myValue > 1)
        {
            if (myValue % factor == 0 && factor.IsPrime())
            {
                Write($"{factor}");
                myValue /= factor;
            }
            factor += 1;
        }
        WriteLine();
    }
}
