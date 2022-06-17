using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class pattern6
    {
        static void Main(string[] args)
        {
            int a = 1;
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i; j++)
                {
                    Console.Write(a);
                    ++a;
                }
                Console.WriteLine();
            }
        }
    }
}
