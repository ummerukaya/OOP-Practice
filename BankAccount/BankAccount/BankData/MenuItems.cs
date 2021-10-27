using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.BankData
{
    public class MenuItems
    {
        public enum Menu
        {
            ShowDetails = 1,
            Withdraw,
            Deposit,
            Transfer,
            WithdrawLoan
        }

        public static void ShowMenu()
        {
            string[] menuoption = Enum.GetNames(typeof(Menu));
            Console.WriteLine("Operations:");
            for (int i = 0; i < menuoption.Length; i++)
            {
                Console.WriteLine("Choose " + (i + 1) + " to " + menuoption[i]);
            }
        }
}
}
