using System;

namespace Detyra4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine("The third bit of {0} is {1}", number, (number >> 3) & 1);
        }
    }
}
