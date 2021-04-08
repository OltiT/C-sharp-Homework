using System;

namespace Detyra6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S={0}, P={1}", a * b, (a + b) * 2);
        }
    }
}
