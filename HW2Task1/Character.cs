using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Task1
{
    public class Character
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public Character(string name, int power)
        {
            Name = name;
            if (power <= 0)
            {
                throw new ArgumentException("Power should be more than 0: ");
            }
            else
            {
                Power = power;
            }
        }

        public Character CallCharacter(Character character)
        {
            return character;
        }
        public void Pull(Plant plant)
        {
            plant.ChangeWeight(this.Power);
        }
    }
}
