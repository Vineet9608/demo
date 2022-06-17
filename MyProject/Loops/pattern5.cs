using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class pattern5
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
