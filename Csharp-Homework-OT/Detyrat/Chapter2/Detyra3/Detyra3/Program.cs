using System;

namespace Detyra3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number1 = 10.000001m;
            decimal number2 = 10.00000m;

            Console.WriteLine(number1.Equals(number2));

            
        }
    }
}
