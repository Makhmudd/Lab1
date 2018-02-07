using System;

namespace PrimeNumbers
{
    public static bool IsPrime (int n)
    {
        for (int i = 0; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= args.Length; i++)
            {
                if (IsPrime(int.Parse(args[i])))
                    Console.WriteLine(args[i]);

            }
        }

        Console.ReadKey();
    }
}
