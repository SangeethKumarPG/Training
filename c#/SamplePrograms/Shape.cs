using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    internal abstract class Shape
    {
        protected double result;
        public abstract void area();
        public void showData()
        {
            Console.WriteLine("Show function");
            Console.WriteLine("Area is : "+result);
        }
    }

    class Circles : Shape
    {
        override
        public void area()
        {
            base.result = 3.14 * 5 * 5;
        }
    }

    class Square : Shape
    {
        override
        public void area()
        {
            base.result = 5 * 5;
        }
    }
}
