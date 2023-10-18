using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Solution
{
    class Electricity

    {
     public int consumernumber, prevreading, currentreading;
    public string? consumername;

        public Electricity(int consumernumber, int prevreading, int currentreading, string? consumername)
        {
            this.consumernumber = consumernumber;
            this.prevreading = prevreading;
            this.currentreading = currentreading;
            this.consumername = consumername;
        }

        /* public Electricity()
     {
         consumernumber = 12345
         prevreading = 9000;
         currentreading = 9300;
         consumername = String.Empty;
     } */


        public double CalculateBill()
        {
            double billamount = 0;
            int reading = currentreading - prevreading;
            if (reading <= 100)
            {
                billamount = reading * 2.00;
            }
            else if (reading <= 200 && reading >= 101)
            {
                billamount = (100 * 2) + ((reading - 100) * 2.5);
            }
            else if (reading <= 401 && reading >= 201)
            {
                billamount = (100 * 2) + (100 * 2.5) + ((reading - 200) * 3.5);
            }
            else
            {
                billamount = (100 * 2) + (100 * 2.5) + (200 * 3.5) + ((reading - 400) * 3.5);

            }
            return billamount;
        }
    }
}


