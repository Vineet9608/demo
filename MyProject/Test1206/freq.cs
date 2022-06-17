using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test1206
{
    class freq
    {
        static void Main(string[] args)
        {
            int[] a = { 'a', 'b', 'b', 'c', 'c', 'b' };

            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c = 1;
                if (a[i] != '\0')
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            c++;
                            a[j] = '\0';
                        }
                    }
                }
                
                Console.WriteLine(a[i]+"-"+c);
            }
            //Console.WriteLine(c);
        }
    }
}
