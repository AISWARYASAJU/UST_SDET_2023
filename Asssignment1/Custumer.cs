using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment1
{
    internal class Custumer
    {
        int CustumerId;
        string? CustumerName;
        int PhoneNumber;
        double balance;

       /* public Custumer(int custumerId, string? custumerName, int phoneNumber, double balance)
        {
            CustumerId = custumerId;
            CustumerName = custumerName;
            PhoneNumber = phoneNumber;
            Balance = balance;
        } */

      /*  public Custumer()
        {
        }*/

        public int CustumerId1 { get => CustumerId; set => CustumerId = value; }
        public string? CustumerName1 { get => CustumerName; set => CustumerName = value; }
        public int PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public double Balance { get => balance; set => balance = value; }

        public static List<Custumer> c1 = new List<Custumer>()
        {
            new Custumer() { CustumerId = 1, CustumerName = "aiswarya", PhoneNumber = 623678, Balance = 10.0 },
            new Custumer() { CustumerId = 2, CustumerName = "parvathy", PhoneNumber = 1234, Balance = 90.0 },
             new Custumer() { CustumerId = 3, CustumerName = "arya", PhoneNumber = 62316, Balance = 90.10 }

        };

        public  void custumerDetails(long phonenum)
        {
            var found= c1.Find(x=>x.PhoneNumber == phonenum);
            if(found!=null)
            {
                Console.WriteLine(found.CustumerName);
                Console.WriteLine(found.Balance);
            }
            else
            {
                Console.WriteLine("customer not found");
            }
           
        }
        public void custumerAllDetails()
        {

            foreach (var customer in c1)
            {
                Console.WriteLine($"customer id: {customer.CustumerId}\n Customer_Nmae:{customer.CustumerName}\nPhone_Number:{customer.PhoneNumber}\n balance:{customer.Balance}");
            }
        }












    }
}


