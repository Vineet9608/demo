using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPS
{
    class arith
    {
        public void calculate(int a, int b)
        {
            Console.WriteLine("The Addition :"+(a+b));
        }
        public void calculate(float a, int b)
        {
            Console.WriteLine("The Substraction: "+(a-b));
        }
        public void calculate(float a, float b)
        {
            Console.WriteLine("The Substraction: "+(a*b));
           
        }
        public void calculate(int a, float b)
        {
            Console.WriteLine("The Division: "+(a/b));
        }
    }
    class arithmatic
    {

        static void Main(string[] args)
        {
            arith a = new arith();
            a.calculate(2, 3);
            a.calculate(2.5f, 3);
            a.calculate(2.2f, 3.3f);
            a.calculate(2, 3.3f);
        }

    }
}
