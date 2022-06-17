using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test1206
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 0, 7, 0, 8, 0, 3 };
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    a[c] = a[i];
                    c++;
                }
            }
            while (c < a.Length)
            {
                a[c] = 0;
                c++;
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }
    }
}
