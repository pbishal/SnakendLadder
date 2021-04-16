﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class GamePlay
    {
        const int START_POSITION = 0;
        const int NO_PLAY = 0;
        const int LADDER = 1;
        const int SNAKE = 2;
        public void Play()
        {
            Random random = new Random();
            int option = random.Next(0, 3);
            int dieValue = random.Next(1, 7);
            int player = 0;
            switch (option)
            {
                case NO_PLAY:
                    Console.WriteLine("No Play, Pass the chance");
                    break;
                case LADDER:
                    player += dieValue;
                    Console.WriteLine("You got Ladder and the  player position is: " + player);
                    break;
                case SNAKE:
                    player -= dieValue;
                    Console.WriteLine("You gotSnake and the player position is: " + player);
                    break;
            }
        }
    }
}