using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        public static void Main()
        {
            foreach (var number in 1..1000)
            {
                Console.WriteLine(Fac(45_000));
            }
        }

        internal static BigInteger Fac(BigInteger number)
        {
            if (number <= 1)
            {
                return (BigInteger)1;
            }
            return number * Fac(number - 1);
        }
    }
}
