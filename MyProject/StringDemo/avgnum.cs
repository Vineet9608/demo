using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.StringDemo
{
    class avgnum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter String:");
            string s = Console.ReadLine();
            double sum = 0,c=0;
            for(int i=0;i<s.Length;i++)
            {

                if(s[i]>='0' && s[i]<='9')
                {
                    double x = char.GetNumericValue(s[i]);
                    sum = sum + x;
                }
                c++;
            }
            Console.WriteLine("Avg of Number:"+(sum/c));
        }
    }
}
