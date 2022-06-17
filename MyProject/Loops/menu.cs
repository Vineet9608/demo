using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class menu
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("1.Area Of Circle\n2.Area Of Rectangle\n3.Area Of Square\n4.Area OF Triangle");
                Console.WriteLine("Enter Your Choice:");
                int cc = int.Parse(Console.ReadLine());
                switch (cc)
                {
                    case 1:
                        Console.WriteLine("Enter Radius:");
                        int r = int.Parse(Console.ReadLine());
                        float a = 3.14f * r * r;
                        Console.WriteLine("Area Of Circle:" + a);
                        break;
                    case 2:
                        Console.WriteLine("Enter Length and WidthOf Rectangle:");
                        int l = int.Parse(Console.ReadLine());
                        int w = int.Parse(Console.ReadLine());
                        int ar = l * w;
                        Console.WriteLine("Area OF Rectangle:" + ar);
                        break;
                    case 3:
                        Console.WriteLine("Enter Sides:");
                        int s = int.Parse(Console.ReadLine());
                        int aa = s * s;
                        Console.WriteLine("Circumference OF Circle:" + aa);
                        break;
                    case 4:
                        Console.WriteLine("Enter height and base:");
                        int h = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        float at = (1 / 2) * (b * h);
                        Console.WriteLine("Parameter OF Square:" + at);
                        break;
                        
                }
                Console.WriteLine("Do you want to continue");
                ch = Console.ReadLine()[0];

            } while (ch == 'y' || ch == 'Y');
        }
    }
}
