using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace File2
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            String path = @"C:\Example.txt";

            String[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

        }
    }
}
