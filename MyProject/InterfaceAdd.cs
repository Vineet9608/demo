using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{

    interface Inum
    {
        void getnum();
        static int a;
    }
    abstract class Addition
    {
       public abstract void getnum1();
       public static int b;
        public abstract void res();
    }
    class perform:Addition,Inum
    {
        public void getnum()
        {
            Inum.a = 10;
        }
        public override void getnum1()
        {
            Addition.b = 20;  
        }
        public override void res()
        {
            int c = Inum.a + Addition.b;
            Console.WriteLine("Addition:"+c);
        }
    }
    class InterfaceAdd
    {
        static void Main(string[] args)
        {
            perform p = new perform();
            p.getnum();
            p.getnum1();
            p.res();
        }
    }
}
