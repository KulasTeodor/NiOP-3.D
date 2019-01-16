﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderKulasTeodor
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Učenik\Desktop\Teodor Kulas,3.D\StreamReaderKulasTeodor\Tekst");
            
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            
            sr.Close();
            Console.ReadKey();
        }
    }
}
