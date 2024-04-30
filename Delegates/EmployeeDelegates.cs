using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Employee(string skill1, string skill2);

    public class Departments
    {
        public void Frontend(string skill1, string skill2)
        {
            Console.WriteLine($"person knows {skill1} that person become a frontend developer person knows {skill1} and {skill2} become fullstack-Developer");
        }

        public void Backend(string skill1, string skill2)
        {
            Console.WriteLine($"person knows {skill2} that person become a backend developer");
        }
    }


    class EmployeeDelegates
    {
        static void Main()
        {

            Departments departments = new Departments();
            Employee frontendObj, backendObj;

            frontendObj = new Employee(departments.Frontend);
            backendObj = new Employee(departments.Backend);


            frontendObj("Vue","java");
            backendObj("React", "Dotnet");


        }


    }
}
