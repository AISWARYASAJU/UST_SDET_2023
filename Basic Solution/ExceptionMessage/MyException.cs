using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Solution.ExceptionMessage
{
    internal class MyException
    {
        /* public static  List<string> exmesslist = new List<string>()
           {
               "Dont give 0 for Denom",
               "Index is out of Range",
               "Unknown exception "
           }; */

        /*  public static Dictionary<int, string> exmesslist = new Dictionary<int, string>()
          {
              { 1, "Dont give 0 for Denom"},
              { 2,   "Index is out of Range" },
              { 3, "Unknown exception "}

          }; */
       Dictionary<string, string> exmesslist = new Dictionary<string, string>();
        
           // { 1, "Dont give 0 for Denom"},
            //{ 2,   "Index is out of Range" },
            //{ 3, "Unknown exception "} 
        public MyException()
        {
            exmesslist.Add("IOR", " index is out of range");
            exmesslist.Add("DIV 0", " Dont give 0 for Denom");
            exmesslist.Add(" UE", " Unknown exception");

        }
    }
}



