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

            Console.WriteLine("========================================Example_2_tests========================================");
            Strings firstTest = new();
            Tests test1 = new("Пушка", "акшуП");
            var x = (firstTest.ConvertString((test1.str1)) == test1.str2) ? "Well done!" : "Does not work!";
            Console.WriteLine(x);  //Well done!

            Tests test2 = new("Пушка", "акшуп");
            x = (firstTest.ConvertString((test2.str1)) == test2.str2) ? "Well done!" : "Does not work!";
            Console.WriteLine(x);  //Does not work!

        }
    }
}
