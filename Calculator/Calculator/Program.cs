using System;
using Calculator.CalculatorType;
using Calculator.ScientificCalculatorOperations;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Calculator mathOperations = new SimpleCalculator(1,"Addition",23,2,'+');
            mathOperations.PrintResult();
            Console.WriteLine();
            Calculator calculateFactorial = new CalculateFactorial(2, "Factorial", 4, "ABC", 3);
            calculateFactorial.PrintResult();
            Console.WriteLine();
            Calculator calculatePower = new CalculatePower(2, "Power", 4, "ABC", 3,2);
            calculatePower.PrintResult();
            Console.WriteLine();

        }
    }
}
