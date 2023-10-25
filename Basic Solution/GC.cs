using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Solution
{
    internal class GC
    {
        public void Listhandling()
        {
            List<int> numbers = new List<int>();
            numbers.Add(100);
           numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(8);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Reverse();
           
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.RemoveAt(3);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Sort();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Clear();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
           Console.WriteLine(numbers.Contains(1234));
           Console.WriteLine(numbers.IndexOf(20));

        }
        public void Stackhandling()
        {
            Stack<int> st = new Stack<int>();
            
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push(1);
            st.Push(12);
            st.Push(66);
            st.Push(99);

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("peek " + st.Pop());
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            // last in 1st output forstack
            Console.WriteLine("Peek" + st.Peek());
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            // show top most element but wont remove the element
            Console.WriteLine("count" + st.Count);

        }

        public void Queuehandling()
        {
            Queue<int> q = new Queue<int>();
            //Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(22);


            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("pop " + q.Dequeue());
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            // last in 1st output forstack
            Console.WriteLine("Peek" + q.Peek());
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            // show top most element but wont remove the element
            Console.WriteLine("count" + q.Count);


        }
        public void Dicthandling()
        {
            
            Dictionary <int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "10");
            dict.Add(2, "20");
            dict.Add(3, "3-");
            dict.Add(3, "AA");
            dict.Add(8, "hhh");

            foreach (int item in dict.Keys)
            {
                Console.WriteLine(dict.ElementAt(item));
            }
            dict.Remove(3);
            foreach (int item in dict.Keys)
            {
                Console.WriteLine(item);
            }
           Console.WriteLine(dict.ContainsKey(6));

            foreach (int item in dict.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dict.Values)
            {
                Console.WriteLine("count" + dict.Count);
            }


        }
        public void SLHandling()  // list, stack , queue are imp
        {
            //SortedDictionary 
            SortedList sl = new SortedList();
            sl.Add(1, 10);
            sl.Add(2, 20);
            sl.Add(3, 30);
            sl.Add(4, "AA");
            foreach (var item in sl)
            {
                Console.WriteLine(item);
            }

        }

    }
}
