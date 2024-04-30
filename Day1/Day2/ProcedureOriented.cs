using System;
namespace Day2
{
    class ProcedureOriented
    {
        static void Greet(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }
        static void Main(string[] args)
        {
            string name = "Dinesh";
            Greet(name);
        }
    }
}
