using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class per
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Marks for 5 subjects one by one:");
            int m1 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int m3 = int.Parse(Console.ReadLine());
            int m4 = int.Parse(Console.ReadLine());
            int m5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Total Marks:"+m1+m2+m3+m4+m5);
            Console.WriteLine("Average:"+(m1 + m2 + m3 + m4 + m5)/5);
            float p=((m1 + m2 + m3 + m4 + m5) / 500)*100;
            Console.WriteLine("Percentage:"+p);
        }
        
    }
}
