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
            //num.Equals(num2);
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
            } else 
            { 
                Console.WriteLine("not Equals"); 
            }
        }
    }
}
