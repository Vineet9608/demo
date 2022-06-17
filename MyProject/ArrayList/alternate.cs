using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayList
{
    class alternate
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 5, 8, 5, 3, 2, 5, 7, 9, 65, 5, 45, 43, 36, 8, 69, 9 };

            Console.WriteLine("Array Before Operarion:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("After Operation:");
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}
