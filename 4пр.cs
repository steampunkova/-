using System;
using System.Collections.Generic;
using System.Linq;

namespace елисей_4
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            {
                var result = Enumerable.Range(100, 900)
                  .Where(SumFactEq);
                foreach (int i in result)
                    Console.WriteLine("{0}\t", i);
                Console.ReadKey();
            }
            static int fac(int i)
            {
                return i < 2 ? 1 : i * fac(i - 1);
            }
            static bool SumFactEq(int i)
            {
                int r = 0, t = i;
                while (i > 0)
                {
                    r += fac(i % 10);
                    i /= 10;
                }
                return r == t;
            }
        }
    }
}

