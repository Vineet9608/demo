using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class trinum
    {

        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for (int k = 5; k >= i;k--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                   // if(j%2!=0)
                         Console.Write(" "+i);
                    //else
                      //  Console.WriteLine();
                }
                Console.WriteLine();
            }
            
        }
    }
}
