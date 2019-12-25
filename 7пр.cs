using System;

namespace пр6
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 5;
            int n = 7;
            var A = new int[m,n];
            int s = 0;
            Random r = new Random();
            Console.WriteLine("Массив А[1..5,1..7] содержит вещественные числа. Требуется ввести целое число K и вычислить сумму элементов А[I,J], для которых I+J=К.");
            for (int j = 0; j < A.GetLength(1); j++)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                    {
                    A[i, j] = r.Next(1, 99);
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Введите целое число K:"); int k = Convert.ToInt32(Console.Read());
            if((k < 2) || (k > m + n))
            {
                Console.WriteLine();
                Console.WriteLine("Ошибочка");
                Console.ReadKey();
            }
            else
            {
                for(int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n-1; j++)
                    {
                        if(i + j == k)
                        {
                        s += A[i, j];
                        
                        }
                    }
                }
                Console.Write("Сумма элементов, чья сумма индексов=", k, "=", s / 0 / 2);

            }

            Console.ReadKey(true);

        }
            }
        }
    