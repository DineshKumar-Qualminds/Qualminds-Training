using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Multiplication<T>
    {
        private T firstNumber;

        public T FirstNumber
        {
            get { return firstNumber; }
            set { firstNumber = value; }
        }
        private T secondNumber;

        public T SecondNumber
        {
            get { return secondNumber; }
            set { secondNumber = value; }
        }
    }


    class Test
    {
        static void Main(string[] args)
        {
            Multiplication<decimal> multiplication = new Multiplication<decimal>();
            multiplication.FirstNumber = 10.95m;
            multiplication.SecondNumber = 16.88m;

            decimal firstNO = multiplication.FirstNumber;
            decimal secondNO = multiplication.SecondNumber;
            decimal result = firstNO * secondNO;
            Console.WriteLine(result);



            Console.ReadKey();
        }
    }
}
