using System;

namespace Detyra6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("a is greater than b");
            }
            else
            {
                Console.WriteLine("b is greater than a");
            }
        }
    }
}
