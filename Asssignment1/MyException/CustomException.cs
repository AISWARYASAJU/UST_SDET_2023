using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment1.MyException
{
    internal class CustomException
    {
        public static Dictionary<int, string> exceptionmessage = new Dictionary<int, string>()
        {
            {0,"Age Should be between 0 and 120" },
            {1,"Patient name cannot be null" },
            {2,"Diagnosis cannot be null" },
            {3, "Treatment cost should be positive" },
            {4, " Patient name and Diagnosis should not be positive" }

        };
    }

    internal class MyExceptions : Exception
    {
        public MyExceptions(string message) : base(message)
        {
        }
    }
    internal class InvalidPatientDataException : Exception
    {
        public InvalidPatientDataException(string message) : base(message)
        {
        }
    }
    internal class InvalidMedicalRecordException : Exception
    {
        public InvalidMedicalRecordException(string message) : base(message)
        {
        }
    }

}
