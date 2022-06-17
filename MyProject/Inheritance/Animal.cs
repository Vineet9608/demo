using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritance
{
    public class Animal
    {
        public virtual void show()
        {
            Console.WriteLine("Class is Parent_animal");
        }
    }

    class Dog:Animal
    {
        protected int legs = 2;
        public sealed override void show()
        {
            Console.WriteLine("Run");
        }
    }    
    class Kangaroo:Animal
    {
        public void show(int x)
        {
            Console.WriteLine("Jump with "+x+" legs");
        }
        
    }
    class Animal1
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.show();
            Kangaroo k = new Kangaroo();
            k.show(2);
        }
    }
}
