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
            Console.WriteLine("Hello git from asus");
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
    }
}
