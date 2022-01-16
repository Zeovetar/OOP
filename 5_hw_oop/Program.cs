using System;
using RationalNumbers;

namespace _5_hw_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Numbers num = new(1, 2);
            Numbers num2 = new(4, 8);
            if (num == num2)
            {
                Console.WriteLine($"{num.Numerator}/{num.Denumerator} == { num2.Numerator}/{num2.Denumerator}");
            }
            else
            {
                Console.WriteLine($"{num.Numerator}/{num.Denumerator} != { num2.Numerator}/{num2.Denumerator}");
            }
/*            bool i = true;
            Console.WriteLine($"I= {i = (num == num2)}");
            Console.WriteLine($"Numerator: {num.Numerator} Denumerator: {num.Denumerator}");
            Console.WriteLine($"Numerator: {num2.Numerator} Denumerator: {num2.Denumerator}");*/
        }
    }
}
