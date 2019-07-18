using System;

namespace Lab4_diceRolling
{
    class Program
    {

        static void Main(string[] args)
        {
            Greeting();
            string rollAgain = "";
            int userInput = int.Parse(Console.ReadLine());
            
            do
            {
                int roll1 = GenerateRandom(userInput);
                int roll2 = GenerateRandom(userInput);
                // Console.WriteLine($"roll #1: {GenerateRandom(userInput)}");
                // Console.WriteLine($"roll #2: {GenerateRandom(userInput)}");
                Console.WriteLine($"roll #1: {roll1}");
                Console.WriteLine($"roll #2: {roll2}");

                    if(roll1 == 1 && roll2 == 1)
                    {
                        Console.WriteLine("Snake Eyes!");
                    }
                    else if (roll1 == 6 && roll2 == 6)
                    {
                        Console.WriteLine("Boxcars!");
                    }
                    else if (roll1 + roll2 == 2 || roll1 + roll2 ==3 || roll1 + roll2 ==12)
                    {
                        Console.WriteLine("Craps!");
                    }
                Console.WriteLine("\nRoll again? [y] or [n]");
                rollAgain = Console.ReadLine().ToLower();
            } while (rollAgain == "y");
        }

        public static void Greeting()
        {
            Console.WriteLine("Yo! Let's roll some dice! ");
            Console.WriteLine("How many sides are there? \n");
        }

        public static int GenerateRandom(int diceSides)
        {
            Random number = new Random();
            int roll = number.Next(1, diceSides + 1);
            return roll;
        }
    }
}
