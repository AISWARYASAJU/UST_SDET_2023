using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Solution
{
    internal class StudentGrade: StudentMarks
    {
        public string Grade { get; set; } = string.Empty;
        public string Name { get; set; } public string CalculateGrade()
        {
            if (Average >= 90) Grade = "A";
            else if (Average >= 69) Grade = "B";
            else if (Average >= 40) Grade = "C";
            else Grade = "D";
            return Grade;
        }
    }
}
