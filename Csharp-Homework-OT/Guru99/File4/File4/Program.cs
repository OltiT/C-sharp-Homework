using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace File4
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            String path = @"C:\Example.txt";

            String copypath = @"C:\ExampleNew.txt";

            File.Copy(path, copypath);

        }
    }
}