using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW2Task_2
{
    public class Money
    {
        public int Amount { get; }
        public int Currency { get; }

        public Money(int amount, int currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override string ToString() {
            return $"{this.Amount}";
        }
    }
}
