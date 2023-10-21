using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Solution
{
    internal class Doctor :  IDoctor, IAppointment
    {
        public int Did { get; set; }
        public  string? DName { get; set; }

        public void AddNewDoctor(int did, string? dname)
        {
            Did = 1234; DName = "AA";
        }

       public void ModifyDoctor(int did, string? dname)
        {
            Did = 9876; DName = "BB";
        }
        public void DisplayDoctorDetails(int did, string? dname) 
        {
            Console.WriteLine("Did: {0} \t Name:{1}", Did, DName);
        }

        public void BookApp(int did, string pname)
        {
           Console.WriteLine(" Booked app for {0} with Doctor {1}", pname, did);
        }

        public void DelApp(string pname)
        {
            Console.WriteLine(" Cancelled  app for {0}" , pname);
        }
    }
}
