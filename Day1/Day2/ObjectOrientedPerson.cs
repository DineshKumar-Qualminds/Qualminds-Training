using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class ObjectOrientedPerson
    {
 
            private string name;

            public ObjectOrientedPerson(string name)
            {
                this.name = name;
            }
            public void Greet()
            {
                Console.WriteLine("Hello "+ name +"!");
            }
        }
    

    class Program
    {
        static void Main(string[] args) 
        {
            ObjectOrientedPerson person = new ObjectOrientedPerson("Dinesh");
            person.Greet();

        }
    }
}
