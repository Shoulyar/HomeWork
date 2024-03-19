using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Task1
{
    public static class Version2
    {
        public static void Run() {
            Queue<Character> characters = new Queue<Character>();
            Plant plant;
            characters.Enqueue(new Character("Grandfather", 32));
            characters.Enqueue(new Character("Grandmother", 16));
            characters.Enqueue(new Character("Granddaughter", 8));
            characters.Enqueue(new Character("Dog", 4));
            characters.Enqueue(new Character("Cat", 2));
            characters.Enqueue(new Character("Mouse", 1));
            bool isPlantPullOut = false;
            Console.WriteLine("Grandfather is planting a turnip");
            Console.WriteLine("Enter plant's weight");
            string temp = Console.ReadLine();
            int weight = Int32.Parse(temp);
            plant = new Plant("turnip", weight);
            Character currentCharacter = characters.Dequeue();
            do
            {
                Console.WriteLine($"{currentCharacter.Name} pull {plant.Name}. {plant.Name} is {plant.Weight}");
                currentCharacter.Pull(plant);
                Console.WriteLine($"Current {plant.Name}'s weight is {plant.Weight}");
                if (plant.Weight > 0 && characters.Count > 0)
                {
                    Character nextCharacter = currentCharacter.CallCharacter(characters.Dequeue());
                    Console.WriteLine($"{currentCharacter.Name} call {nextCharacter.Name}");
                    currentCharacter = nextCharacter;
                    isPlantPullOut = false;
                }
                else if (plant.Weight > 0 && characters.Count == 0)
                {
                    Console.WriteLine($"Game over. Plant's weight is {plant.Weight} and nobody to pool");
                    isPlantPullOut = true;
                }
                else
                {
                    Console.WriteLine($"You won the game");
                    isPlantPullOut = true;
                }

            } while (!isPlantPullOut);

        }
    }
}
