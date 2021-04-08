using System;

namespace Detyra2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            int r = Int32.Parse(Console.ReadLine());
            Console.WriteLine("P is {0} and S is {1}", 2 * Math.PI * r, Math.PI * r * r);
        }
    }
}
