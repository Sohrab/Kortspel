using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kortspel
{
    class Computer : Spelare
    {
        Spelare motspelare;

        public Computer(Kortbunt k, Spelare mot) : base(k)
    {
        motspelare = mot;

    }


        public override void Spela()
        {

                   
        }
    }
}
