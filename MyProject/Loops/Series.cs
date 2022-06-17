using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class Series
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n < 100)
            {
                if (n % 2 != 0)
                {
                    int b = n * n;
                    Console.WriteLine(b);
                }
                n++;
                Console.WriteLine(n);
            }
        }
    }
}
