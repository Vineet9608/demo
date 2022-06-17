using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPS
{
    class details1
    {
        int a, m1, m2, m3, mrk;
        String nm;
        float per;
        public void accept()
        {
            Console.WriteLine("Enter Student Id: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name of the student: ");
            nm = Console.ReadLine();
            Console.WriteLine("Enter Marks for 3 Subjects: ");
            m1 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
            m3 = int.Parse(Console.ReadLine());
            this.percentage();
        }
        public void percentage()
        {
            mrk = m1 + m2 + m3;
            per = (mrk / 300.0f) * 100;
            this.show();
        }
        public void show()
        {
            Console.WriteLine("\n\nID: "+a+"\nName: "+nm);
            Console.WriteLine("Marks for Subject 1: " + m1 + "\nMarks for Subject 2: " + m2 + "\nMarks for Subject 3: " + m3);
            Console.WriteLine("Total Marks Obtained : "+mrk+"\nPercentage Obtained: "+per);

        }
    }
    class student1
    {
        static void Main(string[] args)
        {
            details1 d1 = new details1();
            d1.accept();
        }
    }
}
