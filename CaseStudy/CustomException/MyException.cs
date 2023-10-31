using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.CustomException
{
    internal class MyException : Exception
    {
        public static Dictionary<int, string> Errors { get; set; } = new Dictionary<int, string>()
        {
            { 1,"ProductId is not null!!!" },
            { 2,"Quantity not zero"},
            {3, "Product Cost is greater than zero" },
            {4,"ProductName Not Null" },
            {5,"Weight must be greater than 0" }



        };

        internal class UserException : Exception
        {
            public UserException(string message) : base(message)
            {

            }
        }

    }

}