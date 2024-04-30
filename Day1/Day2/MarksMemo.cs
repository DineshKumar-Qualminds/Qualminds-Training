using System;

namespace Day2
{
    //Main Program File name is Exam.cs
    
    public class MarksMemo
    {
        private string studentName;
        private string group;
        private float mathsMarks;
        private float physicsMarks;
        private float chemistryMarks;
        private float total;
        private float percentage;

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        public float MathsMarks
        {
            get { return mathsMarks; }
            set { mathsMarks = value; }
        }

        public float PhysicsMarks
        {
            get { return physicsMarks; }
            set { physicsMarks = value; }
        }

        public float ChemistryMarks
        {
            get { return chemistryMarks; }
            set { chemistryMarks = value; }
        }

        public float Total
        {
            get { return total; }
            set { total = value; }
        }

        public float Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }

        public void CalculateTotal(float mathsMarks, float physicsMarks, float chemistryMarks)
        {

            total = mathsMarks + physicsMarks + chemistryMarks;
            CalculatePercentage();
        }

        private void CalculatePercentage()
        {
            float maxMarksPerSubject = 100;
            float totalMarks = mathsMarks + physicsMarks + chemistryMarks;
            percentage = totalMarks /(3* maxMarksPerSubject)*100;
        }
        public void InputMarks()
        {
            Console.Write("Enter Student Name: ");
            studentName = Console.ReadLine();

            Console.Write("Enter Student Group: ");
            group = Console.ReadLine();

            Console.Write("Enter Maths Marks: ");
            mathsMarks = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Physics Marks: ");
            physicsMarks = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Chemistry Marks: ");
            chemistryMarks = Convert.ToSingle(Console.ReadLine());
        }

        public void DisplayMarks()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Student Group: " + group);
            Console.WriteLine("Maths Marks: " + mathsMarks);
            Console.WriteLine("Physics Marks: " + physicsMarks);
            Console.WriteLine("Chemistry Marks: " + chemistryMarks);
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Percentage: " + percentage + "%");
        }
    }

    
}
