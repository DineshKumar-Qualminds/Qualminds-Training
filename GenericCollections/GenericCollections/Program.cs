using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main()
        {
            // List<T> example
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);

            Console.WriteLine("List<int> example:");
            foreach (int item in intList)
            {
                Console.WriteLine(item);
            }

            // Dictionary<TKey, TValue> example
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("one", 1);
            dict.Add("two", 2);
            dict.Add("three", 3);

            Console.WriteLine("\nDictionary<string, int> example:");
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            // Stack<T> example
            Stack<string> stack = new Stack<string>();
            stack.Push("first");
            stack.Push("second");
            stack.Push("third");

            Console.WriteLine("\nStack<string> example:");
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }

            // Queue<T> example
            Queue<double> queue = new Queue<double>();
            queue.Enqueue(1.1);
            queue.Enqueue(2.2);
            queue.Enqueue(3.3);

            Console.WriteLine("\nQueue<double> example:");
            foreach (double item in queue)
            {
                Console.WriteLine(item);
            }

            // LinkedList<T> example
            LinkedList<char> linkedList = new LinkedList<char>();
            linkedList.AddLast('A');
            linkedList.AddLast('B');
            linkedList.AddLast('C');

            Console.WriteLine("\nLinkedList<char> example:");
            foreach (char item in linkedList)
            {
                Console.WriteLine(item);
            }

            // HashSet<T> example
            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("apple");
            hashSet.Add("banana");
            hashSet.Add("cherry");

            Console.WriteLine("\nHashSet<string> example:");
            foreach (string item in hashSet)
            {
                Console.WriteLine(item);
            }

            // SortedSet<T> example
            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(3);
            sortedSet.Add(1);
            sortedSet.Add(2);

            Console.WriteLine("\nSortedSet<int> example:");
            foreach (int item in sortedSet)
            {
                Console.WriteLine(item);
            }

            // Using LinkedList<T> as a deque
            LinkedList<int> deque = new LinkedList<int>();

            // Push elements to the front (like a stack)
            deque.AddFirst(1);
            deque.AddFirst(2);
            deque.AddFirst(3);

            // Push elements to the back (like a queue)
            deque.AddLast(4);
            deque.AddLast(5);
            deque.AddLast(6);

            Console.WriteLine("Deque elements:");
            foreach (int item in deque)
            {
                Console.WriteLine(item);
            }

            // Pop from the front
            int frontElement = deque.First.Value;
            deque.RemoveFirst();
            Console.WriteLine("\nRemoved front element: " + frontElement);

            // Pop from the back
            int backElement = deque.Last.Value;
            deque.RemoveLast();
            Console.WriteLine("Removed back element: " + backElement);

            Console.WriteLine("\nDeque elements after pop operations:");
            foreach (int item in deque)
            {
                Console.WriteLine(item);
            }

            // Other methods
            Console.WriteLine("\nOther methods:");
            Console.WriteLine("Is the deque empty? " + (deque.Count == 0));
            Console.WriteLine("Front element: " + deque.First.Value);
            Console.WriteLine("Back element: " + deque.Last.Value);

            // Clear the deque
            deque.Clear();
            Console.WriteLine("Is the deque empty after clearing? " + (deque.Count == 0));

        }
    }
}
