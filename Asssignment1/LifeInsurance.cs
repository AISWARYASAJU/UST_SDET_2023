using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment1
{
    internal class LifeInsurance : InsurancePolicy1
    {
        public LifeInsurance(int policyId, string policyName, double premiumAmount, int age) : base(policyId, policyName, premiumAmount)
        {
            this.age = age;
        }

        public int age { get; set; }

        public override double CalculatePremium()
        {

            if (age <= 19)
            {
                return PremiumAmount * 0.12 + PremiumAmount;

            }
            else if (age <= 18)

            {
                return PremiumAmount * 0.2 + PremiumAmount;

            }
            else if (age <= 69)
            {
                return PremiumAmount * 0.31 + PremiumAmount;
            }
            else
            {
                return PremiumAmount * 0.14 + PremiumAmount;
            }

        }

    }
}