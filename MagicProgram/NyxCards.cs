using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
    class NyxCards
    {

    }

    class Nourish : MagicCard
    {
        public void Resolve()
        {
            PArea.HP += 6;
        }
    }
}
