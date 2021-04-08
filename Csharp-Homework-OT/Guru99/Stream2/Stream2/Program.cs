using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Stream2
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            String path = @"C:\Example.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Guru99 - ASP.Net");
                sr.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}
