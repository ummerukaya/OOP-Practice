using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_with_oop_
{
    class CalculateFactorial:ScientificCalculator
    {
        public int n { get; set; }
        public int Factorial()
        {
            if (n == 0)
                return 1;
            else
            {
                int ans = 1;
                for (int i=1;i<=n;i++)
                {
                    ans *= i;
                }
                return ans;
            }
        }
    }
}
