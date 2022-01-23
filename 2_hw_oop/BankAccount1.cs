using System;

namespace Bank1
{
    public enum AccountType { own, bussiness, vip };
    public class BankAccount1
    {
        private int accountNumber;
        private int balance;
        private AccountType type;
        public BankAccount1(int accountNumber, int balance, AccountType type)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.type = type;
        }
        public int AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.accountNumber = value;
            }

        }

        public int Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }

        }

        public AccountType Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }//{ get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"Номер счета: {this.accountNumber}  Баланс: {this.balance} Тип счета: {type}");
        }
    }

}