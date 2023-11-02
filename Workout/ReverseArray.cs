using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout
{
    internal class ReverseArray
    {
        int [] a= { 1, 2, 3, 4, 5 };
          
        public void Display()
        {
            for(int i = 0; i < a.Length; i++)
            {
               Console.WriteLine(  a[i]);
            }
            Console.WriteLine("1st set");

            for (int i = 4; i >=0; i--)
            {
                Console.WriteLine(a[i]);
            }




        }
        
        
    }

  
}
