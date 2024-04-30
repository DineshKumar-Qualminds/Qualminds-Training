using System;

namespace GenericClass
{
    public class Pair<T1, T2>
    {
        private T1 first;
        private T2 second;

        public Pair(T1 first, T2 second)
        {
            this.first = first;
            this.second = second;
        }

        public T1 First
        {
            get { return first; }
            set { first = value; }
        }

        public T2 Second
        {
            get { return second; }
            set { second = value; }
        }

        public override string ToString()
        {
            return $"({first}, {second})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pair<int, string> pair = new Pair<int, string>(12, "hello");
            Console.WriteLine(pair);

            Pair<string, double> anotherPair = new Pair<string, double>("pi value", 3.14);
            Console.WriteLine(anotherPair);

            Console.ReadKey();
        }
    }


}
