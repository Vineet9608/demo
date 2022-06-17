using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class disarium
    {
        static void Main(string[] args)
        {
            int sum = 0, c=0;
            Console.WriteLine("Enter Number:");
            int a = int.Parse(Console.ReadLine());
            int t = a;
            while(a>0)
            {
                int b = a % 10;
                c++;
                a = a / 10;
                
            }


            int t1 = t;
            while (c != 0)
            {
                int r = t % 10;
                sum = sum + (int)Math.Pow(r, c);
                t = t / 10;
                c--;
            }

            if(sum==t1)
                Console.WriteLine("Number is disuarium");
            else
                Console.WriteLine("Number is not disarium");

        }
    }
}
