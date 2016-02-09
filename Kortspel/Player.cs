using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kortspel
{
    class Player : Spelare
    {
        public Player(Kortbunt k) : base(k) { }

        public override void Spela()
        {
            while (Poäng <21) 
            {
                NyttKort();
               // if (Poäng < 21)
            }
        }
    }
}
