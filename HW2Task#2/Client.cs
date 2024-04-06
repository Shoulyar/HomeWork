using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Task_2
{
    public class Client
    {
        public string FirstName { get; }
        public string LastName { get; }
        public List<Account> Accounts { get; }

        public Client(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public Money GetTotalBalance()
        {
            Money totalBalance = new Money(0, 0);
            foreach (var account in Accounts)
            {
                totalBalance = new Money(totalBalance.Amount + account.Balance.Amount, totalBalance.Currency);
            }
            return totalBalance;
        }
    }
}
