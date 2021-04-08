using System;

namespace Detyra8
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";
            object obj = word1 + " " + word2;
            string final = obj.ToString();

            Console.WriteLine(final);
        }
    }
}
