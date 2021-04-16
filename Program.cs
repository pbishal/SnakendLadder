using System;

namespace SnakeLadder
{
    class Program
    {
        //int noPlay = 0;
        static void rollDie()
        {
            Random rand = new Random();
            int diceValue = rand.Next(1, 7);
            Console.WriteLine("the dice value is:" + diceValue);
        }
        static void checkOption()
        {
            Random rand = new Random();
            int play = rand.Next(1, 4);
            Console.WriteLine("the dice value is:" + play);
            if(play==1)
            {
                Console.WriteLine("No Play:the player stays in the same position");
            }
            else if(play==2)
            {
                Console.WriteLine("ladder");
            }
            else
            {
                Console.WriteLine("snake");
            }
        }
        static void Main(string[] args)
        {
            
            int INITIAL_POSITION = 0;
            int NUMBER_OF_PLAYERS = 1;
            Console.WriteLine("Welcome to snake and ladder game");
            Console.WriteLine("initial position is:" + INITIAL_POSITION);
            rollDie();

            checkOption();
            Console.ReadLine();


        }
    }
}
