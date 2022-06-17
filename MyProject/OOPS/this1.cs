using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPS
{

    class result
    {
        int marks;
        String subject;
        void input(int mrks,String sub)
        {
            this.marks = mrks;
            this.subject = sub;
        }
        public void display()
        {
            this.input(80, "Maths");
            Console.WriteLine("Got "+marks+" marks in "+subject);       
        }
        
        
    }
    class this1
    {
        static void Main(string[] args)
        {
            result r = new result();
            r.display();
        }
    }
}
