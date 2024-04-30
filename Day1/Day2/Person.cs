using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Person
    {
        //private fields to store person's information
        private string name; //field
        private int age;     
        private char gender;  
        private float height;  
        private string qualification; 


        //properties to access and set the private fields
        public string Name   //property
        {
            get { return name; }
            set { name = value; }
        }

        public int Age //property
        {
            get { return age; }
            set { age = value; }
        }

        public char Gender //property
        {
            get { return gender; }
            set { gender = value; }
        }

        public float Height //property
        {
            get { return height; }
            set { height = value; }
        }

        public string Qualification //property
        {
            get { return qualification; }
            set { qualification = value; }
        }

        //Method to fill the person information
        public void Fillinformation(string name, int age, char gender, float height, string qualification) //Method
        {
            Name = name; //properties

            Age = age;  
            Gender = gender;
            Height = height; 
            Qualification = qualification;
        }

        //Method to display person details
        public string ShowPersonDetails()
        {
            StringBuilder sb = new StringBuilder(); // StringBuilder for better string  concatenation

            sb.AppendFormat("Name = {0}{1}", name, Environment.NewLine);
            sb.AppendFormat("Age = {0}{1}", age, Environment.NewLine);
            sb.AppendFormat("Gender = {0}{1}", gender, Environment.NewLine);
            sb.AppendFormat("Height = {0}{1}", height, Environment.NewLine);
            sb.AppendFormat("Qualification = {0}{1}", qualification, Environment.NewLine);
            return sb.ToString();
        }

    }

    class PersonTest
    {
        static void Main()
        {
            //Create a new instance of Person
            Person person1 = new Person();
            person1.Name = "jhon";
            person1.Age = 32;
            person1.Gender = 'M';
            person1.Height = 5.6f;
            person1.Qualification = "B.tech";
            Console.WriteLine("{0} {1} {2} {3}", person1.Name, person1.Age, person1.Gender, person1.Height, person1.Qualification);

            Person person2 = new Person();
            person2.Fillinformation("Harsha", 36, 'M', 5.5f, "MBA");
            Console.WriteLine(person2.ShowPersonDetails());

            Person person3 = new Person();
            person3.Fillinformation("Ramya", 25, 'F', 5.4f, "MBBS");
            Console.WriteLine(person3.ShowPersonDetails());
        }
    }

}
