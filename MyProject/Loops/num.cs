using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int a = int.Parse(Console.ReadLine());
            int b = a * a * a;
            int c = b % 10;
            if(c==a)
            {
                Console.WriteLine("Number is Trimorphic.");
            }
            else
            {
                Console.WriteLine("Number is not Trimorphic.");
            }
        }
    }
}
