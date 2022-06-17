using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class pyramid
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int k = i; k <= 5; k++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

        }
    }
}
