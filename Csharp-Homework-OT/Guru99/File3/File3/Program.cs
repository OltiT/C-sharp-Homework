using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace File3
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            String path = @"C:\Example.txt";

            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

        }
    }
}
