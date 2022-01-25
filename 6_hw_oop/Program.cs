using System;
using Bank;

namespace _6_hw_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            BankAccount acc1 = new(1,300_000);
            BankAccount acc2 = new(1,400_000);
            if (acc1 == acc2)
            {
                Console.WriteLine("==");
            }
            else
            {
                Console.WriteLine("!=");
            }
            if (acc1.Equals(acc2))
            {
                Console.WriteLine("Equals");
            }
            else 
            {
                Console.WriteLine("notEquals");
            }
            Console.WriteLine($"HashCode: {acc1.GetHashCode()}");
            string test = acc1.ToString();
            Console.WriteLine(test);
        }
    }
}
