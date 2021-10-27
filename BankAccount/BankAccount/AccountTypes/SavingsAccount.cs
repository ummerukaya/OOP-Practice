using System;
using System.Collections.Generic;
using System.Text;
using BankAccount.BankOperations;
using BankAccount.BankData;

namespace BankAccount.AccountTypes
{
    class SavingsAccount:Account
    {
        
        public SavingsAccount()
        {
            this.AccountName = "Savings Account";
            this.TaxPay = this.CalculateTax();
        }
        public SavingsAccount(string name,string accountnumber,DateTime date,double balance) : base(name, accountnumber, date, balance)
        {
            this.AccountName = "Savings Account";
            this.TaxPay =this.CalculateTax();
        }

        public override void WithDrawLoan()
        {
            Console.WriteLine("You cannot withdraw loan from savings account");
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
            return (this.TotalBalance * TaxRates.SavingsAccountTaxRate);           
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }

    }
}
