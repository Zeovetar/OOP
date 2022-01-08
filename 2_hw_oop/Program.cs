using System;
using Bank1;
using Bank2;

namespace _2_hw_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank1.AccountType accountType = Bank1.AccountType.own;
            Console.WriteLine(accountType);
            Bank1.BankAccount1 bank1 = new (1, 120000, Bank1.AccountType.bussiness);
            Bank1.BankAccount1 bank2 = new(2, 1200000, Bank1.AccountType.vip);
            bank1.GetInfo();
            bank2.GetInfo();

            //Bank2.AccountType accountType2 = Bank2.AccountType.own;
            Bank2.BankAccount2 bank3 = new(220000, Bank2.AccountType.bussiness);
            Bank2.BankAccount2 bank4 = new(2200000, Bank2.AccountType.vip);
            Bank2.BankAccount2 bank5 = new(2300000, Bank2.AccountType.own);
            bank3.GetInfo();
            bank4.GetInfo();
            bank5.GetInfo();
        }
    }
}
