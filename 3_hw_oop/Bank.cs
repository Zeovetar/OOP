using System;

namespace Bank
{
    public enum AccountType { own, bussiness, vip };
    public class BankAccount
    {
        private int accountNumber;
        private int balance;
        private AccountType type;
        private static int newnumber;

        public int inc(ref int num)
        {
            return ++num;
        }

        public BankAccount(int balance)
        {
            accountNumber = inc(ref newnumber);//newnumber;
            this.balance = balance;
        }

        public BankAccount(AccountType type)
        {
            accountNumber = inc(ref newnumber);//newnumber;
            this.type = type;
        }

        public BankAccount(int balance, AccountType type)
        {
            accountNumber = inc(ref newnumber);//newnumber;
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
        }

        public void GetInfo()
        {
            Console.WriteLine($"Номер счета: {this.accountNumber}  Баланс: {this.balance} Тип счета: {type}");
        }
    }

}
