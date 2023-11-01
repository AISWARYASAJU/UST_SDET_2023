using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQEx
    {
        public void eg1()
        {
            List<string> courses  = new List<string>();
            courses.Add("C tutorial");
            courses.Add("java tutorial");
            courses.Add("C++ tutorial");
            courses.Add("DBMS");
            courses.Add("C");

            //var result = from c in courses 
            //             where c.Equals("DBMS")
            //             select c;
            //var result = courses.Where(c => c.Equals("DBMS")); 
            var result = courses.Where(c => c.Contains("C"));




            foreach (var r in result)
            {
                Console.WriteLine(result);
            }

            


        }
        public void eg2() {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "AISWARYA", "ECE"));
            students.Add(new Student(2, "PARVATHY", "ECE"));
            students.Add(new Student(3, "ARYA", "MCA"));

            var stud = students.Where(s => s.Id == 3);
            foreach (var s in stud)
            {
                Console.WriteLine(s.Id + " " +s.Name + " "+ s.Dept);
            }

        }
    }
}
