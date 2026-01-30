using System;
using System.Numerics;
using System.Linq;

namespace UseBigInteger
{
    class Factorial
    {
        public static void Main()
        {
            foreach (var number in Enumerable.Range(1, 45_000))
            {
                Console.WriteLine(Fac(number));
            }
        }

        internal static BigInteger Fac(BigInteger number)
        {
            if (number <= 1)
            {
                return BigInteger.One;
            }
            return number * Fac(number - 1);
        }
    }
}
