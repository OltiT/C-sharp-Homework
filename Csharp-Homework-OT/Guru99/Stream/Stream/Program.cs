﻿using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Stream
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            String path = @"C:\Example.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
