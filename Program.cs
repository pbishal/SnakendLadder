﻿using System;

namespace SnakeLadder
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder game");
            GamePlay gamePlay = new GamePlay();
            gamePlay.Play();
        }
    }
}
