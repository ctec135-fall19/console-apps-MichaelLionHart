using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("********** CA2 **********");
            //while (args.Length != 0)
            //{
            //    string x = Console.ReadLine();
            //    Console.WriteLine(x);
            //}

            //foreach (string s in args)
            //{
            //    Console.WriteLine(s);
            //}

            if (args.Length == 0)
                Console.WriteLine("No args");
            else
                foreach (string s in args)
                {
                    Console.WriteLine(s);
                }
        }
    }
}
