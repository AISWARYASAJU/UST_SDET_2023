using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Solution
{

    internal class ArraysEx
    {
        readonly int[] numbers = new int[5];  // = { 10, 20, 30 };
        int[,] nums;//= new int[2, 2];
        public void Onedim()
        {


            numbers[0] = 100;
            numbers[1] = 200;
            numbers[2] = 300;

            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
                Console.WriteLine("2nd");

                numbers[1] = 123;
                // Array.Clear(numbers); it will clear all numbers
                Array.Sort(numbers);
                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }
                Array.Clear(numbers);
                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }
            }
        }

            public void Twodim()
            {
                /*nums[0, 0] = 100;
                nums[0, 1] = 200;
                nums[1, 0] = 300;
                nums[1, 1] = 400; */
                int[,] nums={ { 1, 2 },{3,4} };
                foreach (var num in nums)
                {
                    Console.WriteLine(num);
                }
            }
        public void Ja()
        {
            int[][,] arr = new int[][,]
            {
                new int[,] {{1,2}, {3,4 }},
                new int[,] { { 100,200},
                    {300,400 }, {1000,2000 } }
            };
            /*foreach (var item in arr)
            {
                Console.WriteLine(item[1, 2]);
            } */
            foreach (var item in arr)
            {
                Console.WriteLine(item[1, 1]);

               
            }


        }
}

    }

