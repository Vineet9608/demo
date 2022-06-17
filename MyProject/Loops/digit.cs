using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int a = int.Parse(Console.ReadLine());
            int count = 0;
            while(a>0)
            {
                int r = a % 10;
                count++;
                a = a / 10;

            }
            Console.WriteLine("Total DIgits:"+count);
        }
    }
}
