using System;

namespace _7
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = 3;
            var array = new int[n, n];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write((array[i, j] = rnd.Next(1, 11)) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int DiagEl = array[i, i];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write((array[i, j] += DiagEl) + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
