using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
    public class Saproling : MagicCard
    {
        public Saproling()
        {
            Name = "Saproling";
            Type = "Creature - Saproling";
            PT = "1/1";
            Color = "G";
            Token = true;            
        }
    }
}
