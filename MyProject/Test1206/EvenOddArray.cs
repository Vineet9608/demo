using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test1206
{
    class EvenOddArray
    {
        static void Main(string[] args)
        {
            int[] a= { 1, 2, 3, 4, 5, 6 };
            int even = 0,odd=0;
            for(int i= 0;i<a.Length;i++)
            {   
                Console.WriteLine(a[i]);
                if (a[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Number of even Numbers:"+even);
            Console.WriteLine("Number of Odd NUmbers:"+odd);
        }
    }
}
