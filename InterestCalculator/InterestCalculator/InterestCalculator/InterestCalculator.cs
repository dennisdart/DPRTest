using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    public class InterestCalculator:iInterestCalculator
    {

        public decimal TotalInterest(decimal amountEntered)
        {
            decimal interestPercentage = 0;
            if (amountEntered < 1000)
            {
                interestPercentage = 1.0M;
            }
            else if ((amountEntered >= 1000) && (amountEntered < 5000))
            {
                interestPercentage = 1.5M;
            }
            else if ((amountEntered >= 5000) && (amountEntered < 10000))
            {
                interestPercentage = 2M;
            }
            else if ((amountEntered >= 10000) && (amountEntered < 50000))
            {
                interestPercentage = 2.5M;
            }
            else if (amountEntered >= 50000)
            {
                interestPercentage = 3M;
            }

            return decimal.Round((amountEntered / 100) * interestPercentage, 2);
        }
    }
}
