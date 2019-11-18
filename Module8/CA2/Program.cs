using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** CA2 **********");

            string s = Console.ReadLine();
            while (s != null)
            {
                Console.WriteLine(s);
                s = Console.ReadLine();
            }
        }
    }
}
