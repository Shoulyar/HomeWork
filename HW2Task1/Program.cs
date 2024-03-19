namespace HW2Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of version to run game:\r\n1\r\n2");
            string temp = Console.ReadLine();
            int version = Int32.Parse(temp);
            switch(version)
            {
                case 1:
                    Version1.Run();
                    break;
                case 2:
                    Version2.Run();
                    break;
                
            }
                 
        }
    }
}
