using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPS
{
    class details
    {
        int a, mrk;
        String nm;
        public void accept()
        {
            Console.WriteLine("Enter Student Id: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name of the student: ");
            nm = Console.ReadLine();
            Console.WriteLine("ENter Marks");
            mrk = int.Parse(Console.ReadLine());
            this.show();
        }
        public void show()
        {
            Console.WriteLine("\nStudent ID: "+a+"\nStudent Name: "+nm+"\nMarks: "+mrk+"\n\n");
        }
    }

    class Student
    {
        static void Main(string[] args)
        {
            details d = new details();
            for(int i=0;i<=2;i++)
            {
                d.accept();
            }

        }
    }
}
