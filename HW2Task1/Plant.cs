using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Task1
{
    public class Plant
    {
        public string Name { get; set; }
        public int Weight { get; private set; }

        public Plant(string name, int weight)
        {
            Name = name;
            if (weight <= 0)
            {
                throw new ArgumentException("Weight should be more than 0:");
            }
            else
            {
                Weight = weight;
            }
        }
        public void ChangeWeight(int weight)
        {
            Weight -= weight;
        }
    }
}
