using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demofuncallprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Everyone");
            calculator c = new calculator();
            c.Addition();
            Console.ReadLine();
        }
    }
}
