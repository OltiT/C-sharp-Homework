using System;

namespace Detyra3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number to check if its 3rd digit from right to left is 7");
            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = num / 100;
            if( num2 % 10 == 7 ){
                Console.WriteLine("The 3rd digit from right to left is 7");
            }
            else
            {
                Console.WriteLine("The 3rd digit from right to left is not 7");
            }
        }
    }
}
