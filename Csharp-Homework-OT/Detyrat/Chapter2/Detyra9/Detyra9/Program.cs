using System;

namespace Detyra9
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "The \"use\" of quotations causes difficulties";
            string str2 = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties";

            Console.WriteLine(str1);
            Console.WriteLine(str2);

        }
    }
}
