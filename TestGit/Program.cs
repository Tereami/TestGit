using System;
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
            Console.WriteLine("Hello git from asus and msi!");
            string date = GetDate();
            Console.WriteLine(date);
            Console.ReadKey();
        }

        static string GetDate()
        {
            string date = "";
            date = DateTime.Now.ToLongDateString();
            return date;
        }

        static string GetTime()
        {
            string time = "";
            time = DateTime.Now.ToLongTimeString();
            return time;
        }

        static string GetDateAndTime()
        {
            string datetime = DateTime.Now.ToString();
            return datetime;
        }
    }
}
