using System;
using System.Collections.Generic;
using System.Text;
using Calculator.CalculatorType;

namespace Calculator.ScientificCalculatorOperations
{
    class CalculateFactorial:ScientificCalculator
    {
        public int n
        {
            get; set;
        }
        public double result
        {
            get; set;
        } 

        public CalculateFactorial(double operationID, string operationName,double model,string brand, int number) : base(operationID, operationName,model,brand)
        {
            this.n = number;
            this.result = this.Factorial();
        }

        public override void PrintResult()
        {
            base.PrintResult();
            Console.WriteLine("The result is: " + result);
        }

        double Factorial()
        {
            int answer = 1;
            if (n == 0)
                return 1;
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    answer *= i;
                }
            }

            return Convert.ToDouble(answer);
        }
    }
}
