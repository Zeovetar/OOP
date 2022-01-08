using System;

namespace Bank2
{
    public enum AccountType { own, bussiness, vip };
    public class BankAccount2
    {
        private int accountNumber;
        private int balance;
        private AccountType type;
        private static int newnumber;

        public BankAccount2(int balance, AccountType type)
        {
            newnumber++;
            accountNumber = newnumber;
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
