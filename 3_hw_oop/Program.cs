using System;
using Bank;
using StringWorks;

namespace _2_hw_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================Example_1========================================");
            Bank.BankAccount bank = new(100, Bank.AccountType.vip);
            bank.GetInfo();
            Bank.BankAccount bank2 = new(1000, Bank.AccountType.vip);
            bank2.GetInfo();
            bank.GetMoney(bank2, 200);
            bank.GetInfo();
            bank2.GetInfo();

            Console.WriteLine("========================================Example_2========================================");
            string testString = "От топота копыт пыль по полю летит!";
            Strings str = new();
            Console.WriteLine($"Оригинальная строка: {testString}");
            Console.WriteLine($"Результирующая строка: {str.ConvertString(testString)}");

            Console.WriteLine("========================================Example_2_test========================================");
            Strings firstTest = new();
            Tests test = new();
            var x = (firstTest.ConvertString((test.str1)) == test.str2) ? "Well done!" : "Does not work!";
            Console.WriteLine(x);

        }
    }
}
