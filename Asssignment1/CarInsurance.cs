using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment1
{
    internal class CarInsurance : InsurancePolicy1
    {
       
        public CarInsurance(int policyId, string policyName, double premiumAmount, string? cartype) : base(policyId, policyName, premiumAmount)
        {
        }

        public string? CarType { get; set; }

        public override double CalculatePremium()
        {
            if (CarType == "petrol")
            {
                return PremiumAmount * 0.5 + PremiumAmount;

            }
            else if (CarType == "non electrical")
            {
                return PremiumAmount * 0.7 + PremiumAmount;

            }
            else if (CarType == "electrical")
            {
                return PremiumAmount * 0.8 + PremiumAmount;
            }
            else { return PremiumAmount * 0.68 + PremiumAmount; }
        }
    }
}