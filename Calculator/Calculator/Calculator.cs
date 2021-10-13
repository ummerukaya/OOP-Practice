using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    abstract class Calculator : IDisplay
    {
        public double OperationID { get; set; }
        public string OperationName { get; set; }

        public Calculator(double operationID,string operationName)
        {
            this.OperationID = operationID;
            this.OperationName = operationName;
        }
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public virtual void PrintResult()
        {
            Console.WriteLine("Operation ID: " + OperationID + "\nOperation Name: " + OperationName);
        }
    }
}
