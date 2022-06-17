using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int a = int.Parse(Console.ReadLine());
            
            int sum = 0;
            while(a>0)
            {
                int r = a % 10;
                sum = sum + (r * r * r);
                a = a / 10;
            }
            if(sum==a)
            {
                Console.WriteLine("Number is Armstrong.");
            }
            else
            {
                Console.WriteLine("Number is not Armstrong.");
            }
            
        }
    }

}
