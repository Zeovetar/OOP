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

        public void GetMoney(BankAccount bank, int sum)
        {
            if (bank.balance - sum > 0)
            {
                bank.balance = bank.balance - sum;
                this.balance += sum;
            }
            else
            {
                Console.WriteLine("Недостаточно средств!");
            }
        }

        public int inc(ref int num)
        {
            return ++num;
        }

        public BankAccount(int accountNumber, int balance)
        {
            this.accountNumber = accountNumber;
            //accountNumber = inc(ref newnumber);//newnumber;
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

        public static bool operator ==(BankAccount acc1, BankAccount acc2)
        {
            if (acc1.AccountNumber == acc2.AccountNumber)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(BankAccount acc1, BankAccount acc2)
        {
            if (acc1.AccountNumber == acc2.AccountNumber)
            {
                return false;
            }
            return true;
        }

        public bool Equals(BankAccount acc2)
        {
            if (this.AccountNumber == acc2.AccountNumber)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return accountNumber * balance;
        }

        public override string ToString()
        {
            string outString = $"Account: {this.AccountNumber} with credit: {this.Balance}";
            return outString;
        }

    }

}