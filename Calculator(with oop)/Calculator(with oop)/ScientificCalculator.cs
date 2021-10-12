using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_with_oop_
{
    class ScientificCalculator:Calculator
    {
        
        public double Model { get; set; }
        public string Brand { get; set; }

        public override void DisplayInformation()
        {
            Console.WriteLine(Model + " " + Brand);
        }
    }
}
