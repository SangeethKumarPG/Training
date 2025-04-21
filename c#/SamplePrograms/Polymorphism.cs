using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    internal class Polymorphism
    {
        public void calc()
        {
            Console.WriteLine("Calling the first calc function");
        }

        public void calc(int number)
        {
            Console.WriteLine("Only 1 number passed");
        }

        public bool calc(string number)
        {
            Console.WriteLine("Boolean return type method is called");
            if(Convert.ToInt32(number) > 0)
            {
                return true;
            }
            return false;
        }

        public int calc(int number1, int number2) { 
            return number1 + number2;
        }

    }
}
