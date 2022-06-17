using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class spy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number:");
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            int pro = 1;
            while(a>0)
            {
                int r = a % 10;
                sum = sum + r;
                pro = pro * r;
                a = a / 10;
            }
            if(sum==pro)
            {
                Console.WriteLine("Number is spy.");
            }
            else
            {
                Console.WriteLine("Number is Not spy");
            }
        }
    }
}
