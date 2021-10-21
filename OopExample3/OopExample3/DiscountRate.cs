using System;
using System.Collections.Generic;
using System.Text;

namespace OopExample3
{
    class DiscountRate
    {
        private static double serviceDiscountPremium = 0.2;
        private static double serviceDiscountGold = 0.15;
        private static double serviceDiscountSilver = 0.1;
        private static double productDiscountPremium = 0.1;
        private static double productDiscountGold = 0.1;
        private static double productDiscountSilver = 0.1;

        public static double getServiceDiscountRate(string type)
        {
            if (type == "Premium")
            {
                return serviceDiscountPremium;
            }
            else if (type == "Gold")
            {
                return serviceDiscountGold;
            }
            else if (type == "Silver")
                return serviceDiscountSilver;
            else
                return 0;
        }
        public static double getProductDiscountRate(string type)
        {
            if (type == "Premium")
            {
                return productDiscountPremium;
            }
            else if (type == "Gold")
            {
                return productDiscountGold;
            }
            else if (type == "Silver")
                return productDiscountSilver;
            else
                return 0;
        }
    }
}
