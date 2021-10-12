using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_with_oop_
{
    class SimpleCalculator:Calculator
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public char Operator { get; set; }

        public double Subtraction()
        {
            return Operand1 - Operand2;
        }
        public double Addition()
        {
            return Operand1 + Operand2;
        }
        public double Multiplication()
        {
            return Operand1 * Operand2;
        }
        public double Division()
        {
            if (Operand2 == 0)
                return 0;
            else
            return Operand1/Operand2;
        }


    }
}
