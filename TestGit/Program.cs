﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello git");
            string date = GetDate();
            Console.WriteLine(date);
            Console.ReadKey();
        }

        static string GetDate()
        {
            string date = "";
            date = DateTime.Now.ToString();
            return date;
        }
    }
}
