using System;

namespace Detyra2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number to check if it's divisible by 7 and 5");
            int num = Convert.ToInt32(Console.ReadLine());
            if( num % 7 == 0 && num % 5 == 0)
            {
                Console.WriteLine($"{num} is divisible by 7 and 5");
            }
            else
            {
                Console.WriteLine($"{num} is not divisible by 7 and 5");
            }
        }
    }
}
