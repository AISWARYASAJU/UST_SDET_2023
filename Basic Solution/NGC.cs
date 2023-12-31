﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Solution
{
    internal class NGC
    {
        public void ArrayListHandling()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
            /* for(int i = 0; i < arrayList.Count; i++)
             {
                 Console.WriteLine(arrayList[i]);
             }*/

            /*foreach (var item in arrayList)
             {
                Console.WriteLine(item); 
             }*/
            //Console.WriteLine(arrayList);

            arrayList.Add("AA");
            arrayList.Add("true");
            arrayList.Add("false");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.RemoveAt(3);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arrayList.Contains(10));


        }


        public void Stackhandling()
        {
            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push("GG");
            st.Push(12.22);
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


        public void ArrayListHandlinsg()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
            /* for(int i = 0; i < arrayList.Count; i++)
             {
                 Console.WriteLine(arrayList[i]);
             }*/

            /*foreach (var item in arrayList)
             {
                Console.WriteLine(item); 
             }*/
            //Console.WriteLine(arrayList);

            arrayList.Add("AA");
            arrayList.Add("true");
            arrayList.Add("false");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.RemoveAt(3);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arrayList.Contains(10));


        }


        public void Queuehandling()
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(22.88);


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

        public void HThandling()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, 10);
            ht.Add(2, 20);
            ht.Add(3, 30);
            ht.Add("3", "AA");
            ht.Add(8, "hhh");

            foreach (var item in ht)
            {
                Console.WriteLine(item);
            }
            ht.Remove(3);
            foreach (var item in ht)
            {
                Console.WriteLine(item);
            }
            ht.ContainsKey("6");

            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in ht.Values)
            {
                Console.WriteLine("count" + ht.Count);
            }
        } 


            public void SLHandling()
            {
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

