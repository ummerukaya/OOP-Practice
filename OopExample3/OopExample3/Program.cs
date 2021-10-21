using System;

namespace OopExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            double productCost = double.Parse(Console.ReadLine());
            double serviceCost = double.Parse(Console.ReadLine());
            
            Visit visitedCustomer = new Visit(name, DateTime.Today);
            visitedCustomer.setServiceExpense(serviceCost);
            visitedCustomer.setProductExpense(productCost);
            Console.WriteLine(visitedCustomer.getTotalExpense());
        }
    }
}
