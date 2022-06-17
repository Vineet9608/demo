using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class SimpleInter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principle Balance:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Interest Rate:");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Time:");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Simple Interest:" + p * t * r);

        }
    }
}
