using System;

namespace Detyra7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight of a man: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("This person will weight {0}kg on the Moon.", weight * 0.17);
        }
    }
}
