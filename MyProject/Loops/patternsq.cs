using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class patternsq
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=1;j<=5;j++)
                {
                    if(i==1||i==5||j==1||j==5)
                    Console.Write("*");
                    else
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
