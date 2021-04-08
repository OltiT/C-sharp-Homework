using System;

namespace Detyra9
{
    class Program
    {
        static void Main(string[] args)
        {
            double d, x1, x2;
            Console.Write("Enter a (a != 0): ");
            double a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = Int32.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;

            if (d < 0) Console.WriteLine("D={0}, There are no real roots.", d);
            else if (d == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("X={0}", x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("X1={0}, X2={1}", x1, x2);
            }
        }
    }
}
