using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayList
{
    class evenarray
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 1, 8, 5, 6, 2, 5, 7, 9, 65, 5, 45, 43, 36, 4, 69, 9 };
            for (int i = 0; i<a.Length;i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
        
    }
}
