using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class Class1
    {
        /*static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%5==0 || i%10==0)
                    Console.WriteLine(i);
            }
        }*/

        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }

        }

    }
}
