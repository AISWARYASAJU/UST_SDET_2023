using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment1
{
    internal class CallRecord
    {
        public int CallId { get; set; }

        public long PhoneNumber { get; set; }
        public long CallTime { get; set; }

        public static List<CallRecord> Call = new List<CallRecord>()
        {
            new CallRecord() { CallId = 542,PhoneNumber=6238260161,CallTime=9},
            new CallRecord() {CallId=321,PhoneNumber=987654321,CallTime=4},
            new CallRecord(){CallId=456,PhoneNumber=22333333,CallTime=1}

        };
        public static void CallHistory(long phonenumber)
        {
            var data = Call.FindAll(x => x.PhoneNumber == phonenumber);
            if (data.Count() > 0)
                foreach (var x in data)
                {
                    Console.WriteLine("CallId:" + x.CallId);
                    Console.WriteLine("CallTime:" + x.CallTime);
                }
            else
            {
                Console.WriteLine("No Record Found");
            }

        }
    }
}
