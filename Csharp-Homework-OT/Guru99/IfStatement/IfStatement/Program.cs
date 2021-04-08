using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 value = 11;

            if (value < 10)
            {
                Console.WriteLine("Value is less than 10");
            }
            else
            {
                Console.WriteLine("Value is greater than 10");
            }
            Console.ReadKey();
        }
    }
}
