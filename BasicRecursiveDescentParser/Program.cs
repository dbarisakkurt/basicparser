using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRecursiveDescentParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser p = new Parser("abcd");
            p.Parse();

            Console.WriteLine("Parse complete");
            Console.ReadLine();
        }
    }
}
