﻿using Game.Library.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game.Library
{
    public class GameField
    {
        public int _number { get; set; }
        private static object lockObj = new object();
        public BasePlayer[] AllPlayers = new BasePlayer[5];
        public static bool IsFinished = false;
        public HashSet<int> GuessedNumbers = new HashSet<int>();

        public GameField(int number)
        {
            _number = number;
            BasePlayer ordinary = new Ordinary();
            BasePlayer note = new Note();
            BasePlayer cheater = new Cheater();
            BasePlayer uber = new Uber();
            BasePlayer ubercheater = new UberCheater();
            AllPlayers[0] = ordinary;
            AllPlayers[1] = note;
            AllPlayers[2] = cheater;
            AllPlayers[3] = uber;
            AllPlayers[4] = ubercheater;
            Start();
        }

        public void Start()
        {
            List<Thread> threads = new List<Thread>();

            foreach (var player in AllPlayers)
            {
                threads.Add(new Thread(() => player.Go(GuessedNumbers)));
            }
            foreach (var thread in threads)
            {
                thread.Start();
            }

        }

    }
}
