using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
    class Fungus : MagicCard
    {
        public int Spores = 0;

        public override void UpkeepCard()
        {
            base.UpkeepCard();
            Spores++;
        }

        public override bool TryActivate(int i)
        {
            bool result = false;

            result = base.TryActivate(i);

            return result;
        }
    }
}
