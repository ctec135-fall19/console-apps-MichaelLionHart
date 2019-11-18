using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("There once was a guy named Mike");
            //Console.WriteLine("And he liked a girl");
            //Console.WriteLine("This girl lived 3000 miles away");
            //Console.WriteLine("But he liked her anyway, cuz he's an idiot");
            //Console.WriteLine("He made the girl mad, and now she won't talk to him");
            //Console.WriteLine("Several months later and he still likes her");
            //Console.WriteLine("Cuz he's an idiot");
            string[] lines = File.ReadAllLines(args[0]);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
