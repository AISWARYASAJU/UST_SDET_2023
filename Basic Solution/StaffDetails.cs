using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Basic_Solution
{
    internal class StaffDetails
    {
        public int Staffid { get; set; }
        public string? Name { get; set; }
        public string? Dept { get; set; }
        public void DisplayStaffDetails()
        {
            Console.WriteLine("ID: {0} \n Name: {1} \n" + "Dept: {2} \n", Staffid, Name, Dept);
        }
    }
}
