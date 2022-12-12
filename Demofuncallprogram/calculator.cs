using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demofuncallprogram
{
    internal class calculator
    {
        public void Addition()
        {
            int firstnumber = 0, secondnumber = 0;

            Console.WriteLine("Plz enter the 1st number");
            firstnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Plz enter the 2nd number");
            secondnumber = Convert.ToInt32(Console.ReadLine());

            int result = firstnumber + secondnumber;
            Console.WriteLine("sum of two number" + result);
        }
    }
}
