using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class ConstructorClass
    {
        private string name;
        private int age;
        private char Gender;

        public ConstructorClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public ConstructorClass()
        {
            Console.WriteLine("Default Constructor");

        }
        public ConstructorClass(char gender)
        {
            this.Gender = gender;   
        }

        static void Main(string[] args) 
        {
            ConstructorClass p1= new ConstructorClass("Harish", 33);
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);
            ConstructorClass p2 = new ConstructorClass();
            ConstructorClass p3 = new ConstructorClass('M');
            Console.WriteLine(p3.Gender);


        }
    }
}
