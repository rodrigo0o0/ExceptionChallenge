using ExceptionChallenge.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionChallenge.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if(balance < 0)
            {
                throw new DomainException("The Initial Balance must be positive.");
            }
            if(withdrawLimit < 0)
            {
                throw new DomainException("The Withdraw Limit must be positive.");
            }
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if(amount > 0)
            {
                Balance += amount;
            }
            else
            {
                throw new DomainException("ERROR! This value must be positive.");
            }
        }
        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainException("ERROR! The value to Withdraw must be below of the Withdraw Limit : " + WithdrawLimit.ToString("F2",CultureInfo.InvariantCulture));
            }else if(amount > Balance)
            {
                throw new DomainException("ERROR! Insufficient Funds.");
            }
        }

    }
}
