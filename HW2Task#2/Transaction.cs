using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Task_2
{
    public class Transaction
    {
        public TransactionType Type { get; }
        public Money Amount { get; }
        public DateTime Timestamp { get; }

        public Transaction(TransactionType type, Money amount)
        {
            Type = type;
            Amount = amount;
            Timestamp = DateTime.Now;
        }
    }
}
