using System;
using Building;

namespace _4_hw_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================_1_====================");
            BuildingInfo b1 = new(30,9,128,4);
            b1.GetInfo();
            Console.WriteLine("====================_2_====================");
            BuildingInfo b2 = new(38, 16, 200, 6);
            b2.GetInfo();
        }
    }
}
