using System;

namespace Detyra1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 23;
            if(number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number");
            }
        }
    }
}
