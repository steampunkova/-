using System;

namespace ел_и_сей
{
    class Program
    {
        static void Main(string[] args)
        {
            double e = Convert.ToDouble(Console.ReadLine());
            double b = 1;
            double s = 0;
            int i = 0;
            while (b >= e)
            {
                i++;
                b = (1.0 / (i * i));
                s += b;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}