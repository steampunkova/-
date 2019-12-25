using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class пр7
    {
        static Random rand = new Random();
        private static readonly int i;
        private static readonly int j;
        public static void Main()
        {
            Console.WriteLine("Введите длину массива:");
            int n = 5, m = 7;
            int k = Convert.ToInt32(Console.ReadLine());
            var array = new int[n, m];
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write((array[i, j] = rand.Next(1, 11)) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int sum = 0, mus = 0;
            int secondArray = array[i, j];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int str = 0, stb = 0;
                    if (i + j == k)
                    {
                        str = i;
                        stb = j;
                    }
                    if (i + j == k)
                    {

                        for (i = 0; i <= str; i++)
                        {
                            for (j = 0; j < array.GetLength(1); j++)
                            {
                                sum += array[i, j];
                            }
                            mus += sum;

                            if (i == str)
                            {
                                for (j = 0; j <= stb; j++)
                                {
                                    mus += array[i, j];
                                }
                                break;
                            }
                        }
                        break;
                    }
                    if ((k < 2) || (k > m + n))
                    {
                        Console.WriteLine("Ошибочка");
                    }
                    Console.Write(sum);
                }
            }
            Console.ReadKey(true);
        }
    }
}