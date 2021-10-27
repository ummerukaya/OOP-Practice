using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BankAccount.BankOperations
{
    public class Account
    {
        //[JsonIgnore]
        public string AccountName { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public DateTime Date { get; set; }
        public double TotalBalance { get; set; }
        public double TaxPay { get; set; }
        
        public Account()
        {
            this.TaxPay = this.CalculateTax();
        }
        public Account(string name,string accountnumber, DateTime date, double balance)
        {
            this.Name = name;
            this.AccountNumber = accountnumber;
            this.Date = date;
            this.TotalBalance = balance;
            this.TaxPay = this.CalculateTax();
        }
        public virtual void WithDrawLoan()
        {
            Console.WriteLine("Loan withdrawn successfully!");
        }
        public virtual void Deposit(double amount)
        {
            this.TotalBalance += amount;
            Console.WriteLine("Deposit successful!");
        }
        public virtual void Withdraw(double amount)
        {
            this.TotalBalance -= amount;
            Console.WriteLine("Withdrawn successful!");
        }
        //public virtual void Transfer(double amount, Account sender, Account reciever)
        //{
        //    sender.TotalBalance -= amount;
        //    reciever.TotalBalance += amount;
        //    Console.WriteLine("Transfer successful!");
        //}

        public virtual double CalculateTax()
        { 
            return this.TaxPay;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Person name " + this.Name);
            Console.WriteLine("Account Number " + this.AccountNumber);
            Console.WriteLine("Date " + this.Date);
            Console.WriteLine("Current Balance " + this.TotalBalance);
            Console.WriteLine("Tax paid " + this.TaxPay + "BDT");
        }

    }
}
