namespace HW2Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Character> characters = new Stack<Character>();
            Plant plant;
            bool isNext = true;
            bool isPlantPullOut = false;
            Console.WriteLine("Let's create characters from weak to strong:s");
            while (isNext)
            {
                Character character = CreatingCharacter(out isNext);
                characters.Push(character);
            }
            Console.WriteLine("Let's create plant");
            Console.WriteLine("Enter plant's name:");
            string plantName = Console.ReadLine();
            Console.WriteLine("Enter plant's weight");
            string temp = Console.ReadLine();
            int weight = Int32.Parse(temp);
            plant = new Plant(plantName, weight);
            Character currentCharacter = characters.Pop();
            do
            {
                Console.WriteLine($"{currentCharacter.Name} pull {plant.Name}. {plant.Name} is {plant.Weight}");
                currentCharacter.Pull(plant);
                Console.WriteLine($"{plant.Name} is {plant.Weight}");
                if (plant.Weight > 0 && characters.Count > 0)
                {
                    Character nextCharacter = currentCharacter.CallCharacter(characters.Pop());
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
        static Character CreatingCharacter(out bool isNext)
        {
            Console.WriteLine("Enter character's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter character's power:");
            string temp = Console.ReadLine();
            int power = Int32.Parse(temp);
            Console.WriteLine("Do you want to create one more character? Y/N");
            string answer = Console.ReadLine();
            switch (answer.ToLower().Equals("y"))
            {
                case false:
                    isNext = false;
                    break;
                case true:
                    isNext = true;
                    break;

            }
            return new Character(name, power);
        }
    }
}
