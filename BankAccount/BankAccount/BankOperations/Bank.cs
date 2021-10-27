using System;
using System.Collections.Generic;
using System.Text;
using BankAccount.BankData;
using BankAccount.AccountTypes;


namespace BankAccount.BankOperations
{
    public class Bank
    {
        int  input2, input3;
        public void Transaction<T>(double amount, T sender, T reciever)where T:Account
        {
            if (sender == null && reciever == null)
            {
                throw new InvalidOperationException("No transaction will happen");
            }
            else if(sender!=null && reciever==null)
            {
                sender.Withdraw(amount);
            }
            else if (sender == null && reciever != null)
            {
                reciever.Deposit(amount);
            }
            else if(sender!=null && reciever != null)
            {
                if (sender.GetType().Equals(reciever.GetType()))
                {
                    Console.WriteLine("Cannot be transfered to same account");
                }
                else
                {
                    sender.Withdraw(amount);
                    reciever.Deposit(amount);
                }
            }
        }

        public void Input<T>(T newData,T newData2)where T:Account
        {
            var input = Console.ReadLine();
            Console.WriteLine("Select your account type:\n1.Salary Account\n2.Savings Account\n3.Membership Account");


            if (input == "1" || input == "2" || input == "3" ||input=="5")
            {
                input2 = Convert.ToInt32(Console.ReadLine());
                newData = (T)ListOfAccounts.list[input2 - 1];

                if (input == "1")
                {
                    newData.ShowInfo();
                    ListOfAccounts.data.Add(newData);
                }
                else if (input == "5")
                {
                    newData.WithDrawLoan();
                    ListOfAccounts.data.Add(newData);
                }
                else if (input == "2" || input == "3")
                {
                        Console.Write("Amount= ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        if (input == "2")
                        {
                            Transaction<Account>(amount, newData, null);
                            ListOfAccounts.data.Add(newData);
                        }
                        else if (input == "3")
                        {
                            Transaction<Account>(amount, null, newData);
                            ListOfAccounts.data.Add(newData);
                        }
                }
                
            }
            else if (input == "4")
            {
                Console.Write("Send from account type: ");
                input2 = Convert.ToInt32(Console.ReadLine());
                newData = (T)ListOfAccounts.list[input2 - 1];
                Console.Write("Recieve to account type: ");
                input3 = Convert.ToInt32(Console.ReadLine());
                newData2 = (T)ListOfAccounts.list[input3 - 1];
                Console.Write("Amount= ");
                double amount = Convert.ToDouble(Console.ReadLine());
                Transaction<Account>(amount, newData, newData2);
                ListOfAccounts.data.Add(newData);
                ListOfAccounts.data.Add(newData2);
            }

            else
            {
                throw new Exception("End of operation.");
            }
            
        }
    }
}
