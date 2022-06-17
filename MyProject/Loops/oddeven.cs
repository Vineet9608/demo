using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class oddeven
    {
        static void Main(string[] args)
        {
            for(int i = 25;i <= 45;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class countodd
    {
        static void Main(string[] args)
        {
            int c = 0;
            for(int i=1;i<=20;i++)
            {
                if(i%2!=0)
                {
                    c++;
                }
            }
            Console.WriteLine("Numberof Odd Numbers="+c);
        }
    }

    class factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class factoradd
    {
        static void Main(string[] args)
        {
            int b = 0;
            Console.WriteLine("Enter Number:");
            int a = int.Parse(Console.ReadLine());
            for(int i=1; i<=a;i++)
            {
                if(a % i == 0)
                {
                    b = b + i;
                }
            }
            Console.WriteLine("Sum Of Factors:"+b);

        }
    }

    
}
