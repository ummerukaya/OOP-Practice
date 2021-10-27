using System;
using System.Collections.Generic;
using System.Text;
using BankAccount.AccountTypes;
using BankAccount.BankOperations;


namespace BankAccount.BankData
{
    public class ListOfAccounts
    {
        public static List<Account> list = new List<Account>()
        {
              new SalaryAccount("suny", "1001", DateTime.Now, 1000),
              new SavingsAccount("abc", "2001", DateTime.Now, 2000),
              new MembershipAccount("def", "3001", DateTime.Now, 3000)
        };

        public static List<Account> data = new List<Account>();
    }
}
