using System;

namespace Delegates
{
    //Creating Delegate 
    public delegate void ArthameticOperations(int firstValue, int secondValue);

    //Create Operation class
    public class Operations
    {

        public void Multiplication (int firstValue, int secondValue) 
        {
            Console.WriteLine("Multiplication of {0} and {1} is {2}", firstValue, secondValue, firstValue * secondValue);
        }

        public void Divison(int firstValue, int secondValue)
        {
            Console.WriteLine("Remainder of {0} and {1} is {2}", firstValue, secondValue, firstValue % secondValue);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();
            ArthameticOperations multipleObj, divisionObj, combinedObject;

            multipleObj = new ArthameticOperations(operations.Multiplication);
            divisionObj = new ArthameticOperations(operations.Divison);

            combinedObject = multipleObj + divisionObj;

            //single delegate for multiplication operation
            multipleObj(6,2);

            //single delegate for division operation
            divisionObj(10, 5);

            //Multicasting a delegate
            combinedObject(15, 3);
            
            Console.ReadKey();  

        }
    }
}
