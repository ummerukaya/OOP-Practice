using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using BankAccount.AccountTypes;
using BankAccount.BankData;
using BankAccount.BankOperations;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Bank bank = new Bank();
            Account newData=new Account();
            Account newData2 = new Account();


            MenuItems.ShowMenu();

            while (true)
            {
                bank.Input<Account>(newData, newData2);

                string fileName = "TransactionDetails.json";
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(ListOfAccounts.data, options);
                File.WriteAllText(fileName, jsonString);
                Console.WriteLine("\nChoose another operation:");
            }
            
            //Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}
