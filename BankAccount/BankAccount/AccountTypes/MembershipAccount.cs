using System;
using System.Collections.Generic;
using System.Text;
using BankAccount.BankOperations;
using BankAccount.BankData;

namespace BankAccount.AccountTypes
{
    class MembershipAccount:Account
    {
        public MembershipAccount()
        {
            this.AccountName = "Membership Account";
            this.TaxPay = this.CalculateTax();
        }
        public MembershipAccount(string name, string accountnumber, DateTime date, double balance) : base(name, accountnumber, date, balance)
        {
            this.AccountName = "Membership Account";
            this.TaxPay = this.CalculateTax();
        }
        public override void WithDrawLoan()
        {
            Console.WriteLine("How much loan do you want to withdraw?");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount<=2000 && amount<=this.TotalBalance)
            {
                base.WithDrawLoan();
                this.TotalBalance -= amount;
                Console.WriteLine("Withdrawn loan " + amount + "BDT");
            }
            else
            {
                Console.WriteLine("Loan withdrawn failed!");
            }
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
            return (this.TotalBalance * TaxRates.MembershipAccountTaxRate);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }

    }
}
