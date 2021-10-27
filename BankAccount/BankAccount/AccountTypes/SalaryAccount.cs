using System;
using System.Collections.Generic;
using System.Text;
using BankAccount.BankOperations;
using BankAccount.BankData;

namespace BankAccount.AccountTypes
{
    class SalaryAccount : Account
    {
        public SalaryAccount()
        {
            this.AccountName = "Salary Account";
            this.TaxPay = this.CalculateTax();
        }
        public SalaryAccount(string name, string accountnumber, DateTime date, double balance) :base(name,accountnumber,date,balance)
        {
            this.AccountName = "Salary Account";
            this.TaxPay = this.CalculateTax();
        }

        public override void WithDrawLoan()
        {
            Console.WriteLine("You cannot withdraw loan from salary account");
        }
        public override void Deposit(double amount)
        {
            base.Deposit(amount);
        }
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
        }

        public override double CalculateTax()
        {
            return (this.TotalBalance * TaxRates.SalaryAccountTaxRate);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
