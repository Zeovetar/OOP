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
            Numbers num2 = new(3, 8);
            if (num == num2)
            {
                Console.WriteLine($"{num.Numerator}/{num.Denumerator} == { num2.Numerator}/{num2.Denumerator}");
            }
            else
            {
                Console.WriteLine($"{num.Numerator}/{num.Denumerator} != { num2.Numerator}/{num2.Denumerator}");
            }
            if (num.Equals(num2))
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("not Equals");
            }
            //====================================================================================================
            Numbers sum = new(0, 1);
            sum = num + num2;
            Console.WriteLine($"Summa: {sum.Numerator} {sum.Denumerator}");
            //====================================================================================================
            num++;
            num2--;
            Console.WriteLine($"++: {num.Numerator}/{num.Denumerator}");
            Console.WriteLine($"--: {num2.Numerator}/{num2.Denumerator}");
            //====================================================================================================
            Console.WriteLine($"<?: {num < num2}");
            Console.WriteLine($"Ю?: {num > num2}");
            //====================================================================================================
            Numbers num3 = new(1, 2);
            Numbers num4 = new(2, 4);
            Console.WriteLine($"<=?: {num3 < num4}");
            Console.WriteLine($">=?: {num3 > num4}");
        }
    }
}
