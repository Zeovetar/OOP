using System;
using Bank;

namespace _2_hw_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank.BankAccount bank1 = new(1, 120000, Bank1.AccountType.bussiness);
            Bank.BankAccount bank2 = new(2, 1200000, Bank1.AccountType.vip);
            Console.WriteLine("========================================Example_1========================================");
            bank1.GetInfo();
            bank2.GetInfo();

            Console.WriteLine("========================================Example_2========================================");
            Bank2.BankAccount2 bank3 = new(220000, Bank2.AccountType.bussiness);
            Bank2.BankAccount2 bank4 = new(2200000, Bank2.AccountType.vip);
            Bank2.BankAccount2 bank5 = new(2300000, Bank2.AccountType.own);
            bank3.GetInfo();
            bank4.GetInfo();
            bank5.GetInfo();

            Console.WriteLine("========================================Example_3========================================");
            Bank3.BankAccount3 bank6 = new(220000);
            bank6.GetInfo();
            Bank3.BankAccount3 bank7 = new(Bank3.AccountType.bussiness);
            bank7.GetInfo();
            Bank3.BankAccount3 bank8 = new(2300000, Bank3.AccountType.vip);
            bank8.GetInfo();
        }
    }
}
