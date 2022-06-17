using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Static1
{
    class OverLoad
    {
        int x=10;
        public static void get()
        {
            OverLoad o = new OverLoad();
            Console.WriteLine(o.x);
        }
        public static void get(int y)
        {
            Console.WriteLine(y);
        }
        
    }
    class MethodOver
    {
        static void Main(string[] args)
        {
            OverLoad.get();
            OverLoad.get(20);
        }
    }
}
