using System;

namespace елисей_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите два действительных числа:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            
            if (x < 0 && y < 0)
            {
                x = Math.Abs(x);
                y = Math.Abs(y);
            }
            else if ((x<0 && y>0) || (x>0 && y < 0))
            {
                x += 0.5;
                y += 0.5;
            }
            else if (((0.5 <= x) && (x <= 2)) || ((0.5 <= y) && (y <= 2)))
            {
                x /= 10;
                y /= 10;
            }

            Console.WriteLine("Ваш ответ  " + x  +  y );
            Console.ReadKey();

            

            




            
           
        }

    }
}

