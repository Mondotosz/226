using System;

namespace SimpleBank
{
    public class Account
    {
        private double _balance;

        public void Deposit(double amount){
            _balance += amount;
        }

        public void Withdraw(double amount){
            _balance -= amount;
        }

        public double Balance {
            get => _balance;
        }
    }
}
