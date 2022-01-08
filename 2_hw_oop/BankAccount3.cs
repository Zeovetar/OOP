﻿using System;

namespace Bank3
{
    public enum AccountType { own, bussiness, vip };
    public class BankAccount3
    {
        private int accountNumber;
        private int balance;
        private AccountType type;
        private static int newnumber;

        public BankAccount3(int balance)
        {
            newnumber++;
            accountNumber = newnumber;
            this.balance = balance;
        }

        public BankAccount3(AccountType type)
        {
            newnumber++;
            accountNumber = newnumber;
            this.type = type;
        }

        public BankAccount3(int balance, AccountType type)
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
