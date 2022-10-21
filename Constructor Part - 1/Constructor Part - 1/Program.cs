using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Part___1
{
    class Program
    {
       static int a;
        static string str;
        static bool b;

        // Default Constructor
        public Program()
        {
            // Initializing the values
            a = 1;
            str = null;
            b= false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(a);
            Console.WriteLine(str);
            Console.WriteLine(b);

            Console.ReadLine();

        }
    }
}
