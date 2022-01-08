using System;
using Bank1;

namespace _2_hw_oop
{
    public class Car
    {
        private string model; // модель
        private int year;    // год

        public void GetInfo()
        {
            Console.WriteLine($"Модель: {model}  Год: {year}");
        }

        /*        public Car(string model, int year)
                {
                    this.model = model;
                    this.year = year;
                    Console.WriteLine($"Object {this.model} was created at {this.year}.");
                }*/

        public Car() { model = "Lifan"; year = 1992; }

        public Car(string carModel) : this(carModel, 1993) { }

        public Car(string model, int year) { this.model = model; this.year = year; }

        public string Model
        {
            get 
            {
                return this.model;
            }

            set 
            {
                this.model = value;
            }
            
        }
        public int Year
        {
            get
            {
                return this.year;
            }

            set
            {
                this.year = value;
            }

        }
    }
    //public enum AccountType { own, bussiness, vip };

    class Program
    {
        static void Main(string[] args)
        {
            AccountType accountType = AccountType.own;
            Console.WriteLine(accountType);
            Bank1.BankAccount1 bank = new (1, 120_000, AccountType.bussiness);
            bank.GetInfo();
            Console.WriteLine(bank.AccountNumber);
            Console.WriteLine(bank.Balance);
            Console.WriteLine(bank.Type);
            //Console.WriteLine(bank);
            /*            Car lada = new Car("Lada", 2002);
                        Car yac = new("Yac", 1881);
                        Car lifan = new("lifan");
                        Car cherry = new();
                        cherry.GetInfo();
                        lifan.GetInfo();
                        lada.GetInfo();
                        lada.Model = "Priora";
                        lada.Year = 1987;
                        lada.GetInfo();  // Модель: Samara Год: 1990
                        yac.GetInfo();
                        Console.ReadKey();*/
        }
    }
}
