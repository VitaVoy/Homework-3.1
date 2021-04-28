using System;

namespace Homework_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double y1;
            double x2;
            double y2;
            double r;
            Console.WriteLine("Введите x1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            y2 = Convert.ToDouble(Console.ReadLine());

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(r);
        }
    }
}
