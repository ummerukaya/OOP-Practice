using System;
using Calculator.CalculatorType;
using Calculator.ScientificCalculatorOperations;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1.Simple Calculation (+,-,*,/)\n2.Calculate Factorial\n3.Calculate Power");
                Console.Write("\nEnter the Operation ID: ");
                double ID = Convert.ToDouble(Console.ReadLine());
                if (ID == 1)
                {
                    Console.WriteLine("Enter the Operation name, First number, Second number, Operator");
                    string operationName =Console.ReadLine();
                    double firstNumber = Convert.ToDouble(Console.ReadLine());
                    double secondNumber = Convert.ToDouble(Console.ReadLine());
                    char operator1 = Convert.ToChar(Console.ReadLine());

                    Calculator mathOperations = new SimpleCalculator(ID,operationName, firstNumber, secondNumber,operator1);
                    mathOperations.PrintResult();
                }
                else if (ID == 2)
                {
                    Console.WriteLine("Enter the Operation name, Model, Brand, Number");
                    string operationName = Console.ReadLine();
                    double model = Convert.ToDouble(Console.ReadLine());
                    string brand = Console.ReadLine();
                    int number = Convert.ToInt32(Console.ReadLine());
                    
                    Calculator calculateFactorial = new CalculateFactorial(ID, operationName,model,brand,number);
                    calculateFactorial.PrintResult();
                }
                else if (ID == 3)
                {
                    Console.WriteLine("Enter the Operation name, Model, Brand, Number,Power");
                    string operationName = Console.ReadLine();
                    double model = Convert.ToDouble(Console.ReadLine());
                    string brand = Console.ReadLine();
                    int number = Convert.ToInt32(Console.ReadLine());
                    int power = Convert.ToInt32(Console.ReadLine());

                    Calculator calculatePower = new CalculatePower(ID, operationName,model,brand,number,power);
                    calculatePower.PrintResult();
                }
                Console.WriteLine();
            }

        }
    }
}
