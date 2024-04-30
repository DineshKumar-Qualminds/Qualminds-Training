using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Exam
    {
        static void Main()
        {
            MarksMemo student1 = new MarksMemo();
            student1.InputMarks();
            student1.CalculateTotal(student1.MathsMarks, student1.PhysicsMarks, student1.ChemistryMarks);
            student1.DisplayMarks();

            Console.WriteLine("\n\n");

            MarksMemo student2 = new MarksMemo();
            student2.InputMarks();
            student2.CalculateTotal(student2.MathsMarks, student2.PhysicsMarks, student2.ChemistryMarks);
            student2.DisplayMarks();

        }
    }
}
