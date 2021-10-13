using System;
using System.Collections.Generic;
using System.Text;
using Calculator.CalculatorType;

namespace Calculator.ScientificCalculatorOperations
{
    class CalculatePower:ScientificCalculator
    {
        public double number { get; set; }
        public int p { get; set; }
        double result;

        public CalculatePower(double operationID, string operationName, double model, string brand, double num,int power) : base(operationID, operationName, model, brand)
        {
            this.number = num;
            this.p = power;
            this.result = this.Power();
        }

        public override void PrintResult()
        {
            base.PrintResult();
            Console.WriteLine("The result is: " + result);
        }

        double Power()
        {
            double answer = 1;
            for (int i = 1; i <= p; i++)
            {
                    answer *= number;
            }
            return answer;
        }
    }
}
