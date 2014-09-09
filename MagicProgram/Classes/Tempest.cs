using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
    # region Tempest

    # endregion

    # region Stronghold
    # region Sliver Queen
    public class SliverQueenSH : MagicCard
    {
        public SliverQueenSH()
        {
            Name = "Sliver Queen";
            Edition = "SH";
            Rarity = "R";
            Color = "Gld";
            Cost = "WUBRG";
            PT = "7/7";
            Type = "Legendary Creature - Sliver";
            Text = "%2: Put a 1/1 colorless Sliver creature token onto the battlefield.";
            Flavor = "";
        }

        public override void DoActivate(int i)
        {
            MagicCard mct = new MagicCard
            {
                Token = true,
                Name = "Sliver",
                Type = "Creature - Sliver",
                PT = "1/1",
                Color = "Colourless",
            };
            PArea.PlayToken(mct);
        }
    }
    # endregion
    # endregion

    # region Exodus

    # endregion
}
