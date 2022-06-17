using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class patt1100
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 != 0)
                        Console.Write(1);
                    else
                        Console.Write(0);
                }
                Console.WriteLine();
            }
        }
    }
}
