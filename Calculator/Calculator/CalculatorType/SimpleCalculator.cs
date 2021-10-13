using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.CalculatorType
{
    class SimpleCalculator:Calculator
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public char Operator { get; set; }
        private double result;

        public SimpleCalculator(double operationID,string operationName,double operand1,double operand2,char operator1):base(operationID,operationName)
        {
            base.OperationID = operationID;
            base.OperationName = operationName;
            this.Operand1 = operand1;
            this.Operand2 = operand2;
            this.Operator = operator1;
            if(Operator=='-')
            {
                this.result = this.Subtraction();
            }
            else if (Operator == '+')
            {
                this.result = this.Addition();
            }
            if (Operator == '*')
            {
                this.result = this.Multiplication();
            }
            if (Operator == '/')
            {
                this.result = this.Division();
            }
        }

        public override void PrintResult()
        {
            base.PrintResult();
            Console.WriteLine("The result is: " + result);
        }

        double Subtraction()
        {
            return Operand1 - Operand2;
        }
        double Addition()
        {
            return Operand1 + Operand2;
        }
        double Multiplication()
        {
            return Operand1 * Operand2;
        }
        double Division()
        {
            return Operand1 / Operand2;
        }
    }
}
