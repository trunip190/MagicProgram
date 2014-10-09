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

    # region Fists of Ironwood
    class FistsofIronwoodC11 : MagicCard
    {
        public FistsofIronwoodC11()
        {
            Name = "Fists of Ironwood";
            Edition = "C11";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant Creature\r\nWhen Fists of Ironwood enters the battlefield, put two 1/1 green Saproling creature tokens onto the battlefield.\r\nEnchanted creature has trample.";
            Flavor = "Saprolings add the three and the four to the 'one-two punch.'";
        }

        public override void Resolve()
        {
            for (int i = 0; i < 2; i++)
            {
                MagicCard mcn = new MagicCard
                {
                    Name = "Saproling",
                    Type = "Creature - Saproling",
                    Color = "G",
                    PT = "1/1",
                    Token = true,
                };
                PArea.PlayToken(mcn);
            }
        }

        public override List<string> getStats()
        {
            List<string> results = new List<string>();

            results.Add("Ability#Trample");

            return results;
        }
    }
    # endregion
}
