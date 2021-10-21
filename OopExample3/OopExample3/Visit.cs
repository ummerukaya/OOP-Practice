using System;
using System.Collections.Generic;
using System.Text;

namespace OopExample3
{
    class Visit
    {
        private Customer customer;
        private DateTime date;
        private double serviceExpense;
        private double productExpense;
        
        public Visit(string name,DateTime date)
        {
            customer = new Customer(name);
           
            this.date = date;
        }
        
        public string getName()
        {
            return customer.getName();
        }
        public double getServiceExpense()
        {
            return this.serviceExpense;
        }
        public void setServiceExpense(double ex)
        {
            this.serviceExpense = ex;
        }
        public double getProductExpense()
        {
            return this.productExpense;
        }
        public void setProductExpense(double ex)
        {
            this.productExpense = ex;
        }
        public double getTotalExpense()
        {
            string memberType="";
            if (customer.isMember())
            {
                string cus = Console.ReadLine();
                customer.setMemberType(cus);
                memberType = customer.getMemberType();
            }
            else
            {
                customer.setMember(true);
            }

            Console.Write(this.getName()+" "+memberType+" ");
            double calculate = (this.serviceExpense + this.productExpense);
            Console.WriteLine(calculate);
            double discount = (this.serviceExpense * DiscountRate.getServiceDiscountRate(memberType)) + (this.productExpense * DiscountRate.getProductDiscountRate(memberType));
            Console.WriteLine(discount);
            return (calculate-discount);
        }
    }
}
