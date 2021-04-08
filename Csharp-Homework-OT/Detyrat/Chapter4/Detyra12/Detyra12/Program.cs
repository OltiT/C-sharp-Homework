using System;

namespace Detyra12
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num1 = 0;
            ulong num2 = 1;
            ulong sum = 1;
            ulong count = 0;

            Console.WriteLine(num1);

            while (count < 100)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                Console.WriteLine(num2);
                count++;
            }
        }
    }
}
