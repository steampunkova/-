using System;

namespace _1_practicheskaya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите M(X)");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите M(Y)");
            double y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите O(X)");
            double ox = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите O(Y)");
            double oy = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите R");
            double r = int.Parse(Console.ReadLine());

            double d = Math.Sqrt(Math.Pow(ox - x, 2) + Math.Pow(oy - y, 2));
            if (d <= r)
                Console.WriteLine("Точка М лежит в круге.");
            else
                Console.WriteLine("Точка М лежит вне круга.");
            Console.ReadKey();
        }
    }
}
