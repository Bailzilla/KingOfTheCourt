using System;
using System.Collections.Generic;
using System.Text;

namespace KingOfTheCourt
{
    class Shooter : Hooper
    {
   

        public override int accuracy { get; set; } = 7;

        public Shooter(string playerName)
        {
            name = playerName;
        }




    }
}
