using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
    # region Sol Ring
    class SolRingC13 : MagicCard
    {
        public SolRingC13()
        {
            Name = "Sol Ring";
            Edition = "C13";
            Rarity = "R";
            Color = "";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add {2} to your mana pool.";
            Flavor = "";
        }

        public override bool TryActivate(int i)
        {
            if (!Tapped)
            {
                DoActivate(i);
                return true;
            }

            return false;
        }

        public override void DoActivate(int i)
        {
            PArea.mana.grey += 2;
            Tap(true, false);
        }
    }
    # endregion
}
