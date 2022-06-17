using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Static1
{
    class Arith
    {
        int a = 10;
        static int b = 20;
        public void add()
        {
            //Arith.b = b;
            Console.WriteLine("Addition:"+(a+b));
        }
        public static void  Division()
        {
            Arith a2 = new Arith();
            Console.WriteLine("Division: "+(b/a2.a));
            a2.add();
        }
    }
    class Adddiv
    {
        static void Main(string[] args)
        {
            Arith.Division();
        }
    }
}
