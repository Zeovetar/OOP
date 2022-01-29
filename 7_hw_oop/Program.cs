using System;
using Coder;

namespace _7_hw_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Внимание! К вводу допускаются только прописные русские буквы");
            ACoder exmpl1 = new();
            string ans = exmpl1.Encode("абв"); //только прописные русские буквы
            Console.WriteLine(ans);
            ans = exmpl1.Decode(ans);
            Console.WriteLine(ans);
            Console.WriteLine("=============================");
            BCoder exmpl2 = new();
            ans = exmpl2.Encode("абв"); //только прописные русские буквы
            Console.WriteLine(ans);
            ans = exmpl2.Decode(ans);
            Console.WriteLine(ans);
        }
    }
}
