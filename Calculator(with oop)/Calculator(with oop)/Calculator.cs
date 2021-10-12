using System;
using System.Collections.Generic;
using System.Text;


namespace Calculator_with_oop_
{
    public class Calculator : display
    {
        public double OperationID {get; set; }
        public string OperationName { get; set; }

        public string toString()
        {
            return Convert.ToString(OperationID);
        }
        public virtual void DisplayInformation()
        {
            Console.WriteLine(OperationID+" "+OperationName);
        }
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void PrintResult(double ans)
        {
            Console.WriteLine("RESULT = "+ans);
        }

        
    }
}
