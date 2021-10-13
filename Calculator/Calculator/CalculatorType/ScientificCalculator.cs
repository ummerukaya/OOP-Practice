using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.CalculatorType
{
    class ScientificCalculator:Calculator
    {
        public double Model { get; set; }
        public string Brand { get; set; }

        public ScientificCalculator(double operationID, string operationName, double model, string brand) : base(operationID, operationName)
        {
            this.Model = model;
            this.Brand = brand;
        }
        string DisplayInformation()
        {
            return Brand;
        }
    }
}
