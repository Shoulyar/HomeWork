using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Task_2
{
    public class Account
    {
        public Money Balance { get; private set; }
        public double InterestRate { get; private set; }
        public List<Transaction> TransactionHistory { get; }

        public Account(Money balance, double interestRate)
        {
            Balance = balance;
            InterestRate = interestRate;
            TransactionHistory = new List<Transaction>();
        }

        public void Deposit(Money amount)
        {
            Balance = new Money(Balance.Amount + amount.Amount, Balance.Currency);
            TransactionHistory.Add(new Transaction(TransactionType.Deposit, amount));
        }

        public void Withdraw(Money amount)
        {
            Balance = new Money(Balance.Amount - amount.Amount, Balance.Currency);
            TransactionHistory.Add(new Transaction(TransactionType.Withdrawal, amount));
        }

        public void Transfer(Account destinationAccount, Money amount)
        {
            Withdraw(amount);
            destinationAccount.Deposit(amount);
            TransactionHistory.Add(new Transaction(TransactionType.Transfer, amount));
        }

        public void ChangeInterestRate(double newInterestRate)
        {
            InterestRate = newInterestRate;
        }
    }
}
