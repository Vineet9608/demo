using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayList
{
    class _2D_Columnsum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 3, 4, 5 }, { 2, 6, 3 }, { 7, 1, 9 } };
            for (int i = 0; i < a.GetLength(0) ; i++)
            {
                int sum = 0;
                for(int j=0;j<a.GetLength(1);j++)
                {
                    sum = sum + a[j,i];
                    Console.Write(a[i,j]+" ");
                }

                Console.Write("   =   "+sum);
                Console.WriteLine();
            }
                

        }
        
            
    }
}
