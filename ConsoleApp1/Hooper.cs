using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KingOfTheCourt
{
    class Hooper
    {
        public string name;
        public int accuracy = 5;
        public bool isTurn = true;
        public int score = 0;
        public int attempts = 0;
        public List<int> shootingPercentage = new List<int>();



        public Hooper(string playerName)
        {
            name = playerName;
        }
        public Hooper(string playerName, int playerAcc)
        {
            name = playerName;
            accuracy = playerAcc;
        }
        public bool Shoot()
        {
            System.Random random = new System.Random();

            if (random.Next(10) < accuracy)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
        public void madeShot()
        {
            score++;
            attempts++;
            shootingPercentage.Add(1);
        }

        public void missedShot()
        {
            attempts++;
            shootingPercentage.Add(0);
            isTurn = false;
        }
    }
}
