using System;

namespace Detyra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Third number: ");
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Result is {0}", a + b + c);
        }
    }
}
