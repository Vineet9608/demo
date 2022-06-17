using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loops
{
    class Palindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ente Number:");
            int a = int.Parse(Console.ReadLine());
            int rev = 0;
            while (a > 0)
            {
                int r = a % 10;
                rev = rev * 10 + r;
                a = a / 10;
            }
            if (rev == a)
            {
                Console.WriteLine("Number is Palindrome.");
            }
            else
            {
                Console.WriteLine("Number is not Palindrome.");
            }
        }
    }
}
