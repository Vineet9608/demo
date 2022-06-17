using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class automorphic
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("Enter any Number:");
            int a = int.Parse(Console.ReadLine());
            int t = a;
            int b = a * a;
            while(a>0)
            {
                c++;
                a = a / 10;
            }

            //To Separate Digits i.e.how many digits we've to separate to compare it with original andlast digit
            int power = 1;
            while(c>0)
            {
                power = power * 10;
                c--;
            }
            Console.WriteLine(power);
            a = t;
            int end = b % power;
            if(a==end)
            {
                Console.WriteLine("Automorphic");
            }
            else
            {

                Console.WriteLine("Not Automorphic");
            }
        }
    }
}
