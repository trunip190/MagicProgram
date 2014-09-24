using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
    class MysticMonastery : MagicCard
    {
        public MysticMonastery()
        {
            Name = "Mystic Monastery";
            Edition = "KTK";
            Rarity = "U";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Mystic Monastery enters the battlefield tapped.	Tap: Add Blue, Red, or White to your mana pool.";
            Flavor = "";
            _Tapped = true;
        }

        public override bool TryActivate(int i)
        {
            if (!Tapped)
            {
                DoActivate(i);
                Tap(true, false);
                return true;
            }

            return false;
        }

        public override void DoActivate(int i)
        {
            PArea.mw.ShowWheel("URW");
        }
    }
}
