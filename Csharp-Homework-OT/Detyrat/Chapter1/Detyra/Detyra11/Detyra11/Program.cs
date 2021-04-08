using System;

namespace Detyra11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your age:");
            int myAge = Convert.ToInt32(Console.ReadLine());

            int meIn10Years = myAge + 10;

            Console.WriteLine($"Your age in 10 years will be {meIn10Years}");

            Console.ReadKey();
        }
    }
}
