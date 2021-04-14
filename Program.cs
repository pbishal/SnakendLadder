using System;

namespace SnakeLadder
{
    class Program
    {
        static void rollDie()
        {
            Random rand = new Random();
            int diceValue = rand.Next(1, 6);
            Console.WriteLine("the dice value is:" + diceValue);

        }
        static void Main(string[] args)
        {
            
            int INITIAL_POSITION = 0;
            int NUMBER_OF_PLAYERS = 1;
            Console.WriteLine("Welcome to snake and ladder game");

            rollDie();
            Console.ReadLine();


        }
    }
}
