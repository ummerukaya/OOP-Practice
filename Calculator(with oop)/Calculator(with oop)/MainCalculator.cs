using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_with_oop_
{
    class MainCalculator
    {
        static void Main(string[] agrs)
        {
            Calculator obj = new Calculator();
            Console.Write("Enter the operation id: ");
            obj.OperationID = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the operation name: ");
            obj.OperationName = Console.ReadLine();
            obj.DisplayInformation();
            
            if (obj.OperationName == "Calculate factorial")
            {
                CalculateFactorial obj2 = new CalculateFactorial();
                Console.Write("Enter the Model: ");
                obj2.Model = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Brand: ");
                obj2.Brand = Console.ReadLine();
                obj2.DisplayInformation();
                Console.Write("Enter the Number: ");
                obj2.n= Convert.ToInt32(Console.ReadLine());
                obj.PrintResult(Convert.ToDouble(obj2.Factorial()));
            }

            else
            {
                SimpleCalculator obj1 = new SimpleCalculator();
                Console.Write("Enter the First Number: ");
                obj1.Operand1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Second Number: ");
                obj1.Operand2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Operator: ");
                obj1.Operator = Convert.ToChar(Console.ReadLine());
                if (obj1.Operator == '-')
                    obj.PrintResult(obj1.Subtraction());
                else if (obj1.Operator == '+')
                    obj.PrintResult(obj1.Addition());
                else if (obj1.Operator == '*')
                    obj.PrintResult(obj1.Multiplication());
                else if (obj1.Operator == '/')
                    obj.PrintResult(obj1.Division());

            }
        }
    }
}
