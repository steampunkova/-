using System;

namespace елисей_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double math = 1, sum = 1;
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите n:");
            double n = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                math *= 1 / (x + i);
                sum += math;
            }
            Console.WriteLine("Ответ:" + sum);
            Console.ReadLine();
        }
    }
    }

