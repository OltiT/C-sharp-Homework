using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace File5
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            String path = @"C:\Example.txt";

            File.Delete(path);

        }
    }
}
