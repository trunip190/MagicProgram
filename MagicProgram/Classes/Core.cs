using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
    # region Alpha
    # region Air Elemental
    public class AirElementalA : MagicCard
    {
        public AirElementalA()
        {
            Name = "Air Elemental";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "3UU";
            PT = "4/4";
            Type = "Creature - Elemental";
            Text = "Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Ancestral Recall
    public class AncestralRecallA : MagicCard
    {
        public AncestralRecallA()
        {
            Name = "Ancestral Recall";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Target player draws three cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Animate Artifact
    public class AnimateArtifactA : MagicCard
    {
        public AnimateArtifactA()
        {
            Name = "Animate Artifact";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant artifact;^As long as enchanted artifact isn�t a creature, it�s an artifact creature with power and toughness each equal to its converted mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Animate Dead
    public class AnimateDeadA : MagicCard
    {
        public AnimateDeadA()
        {
            Name = "Animate Dead";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature card in a graveyard;^When Animate Dead enters the battlefield, if it�s on the battlefield, it loses �enchant creature card in a graveyard� and gains �enchant creature put onto the battlefield with Animate Dead.� Return enchanted creature card to the battlefield under your control and attach Animate Dead to it. When Animate Dead leaves the battlefield, that creature�s controller sacrifices it.;^Enchanted creature gets -1/-0.";
            Flavor = "";
        }
    }
    # endregion

    # region Animate Wall
    public class AnimateWallA : MagicCard
    {
        public AnimateWallA()
        {
            Name = "Animate Wall";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant Wall;^Enchanted Wall can attack as though it didn�t have defender.";
            Flavor = "";
        }
    }
    # endregion

    # region Ankh of Mishra
    public class AnkhofMishraA : MagicCard
    {
        public AnkhofMishraA()
        {
            Name = "Ankh of Mishra";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a land enters the battlefield, Ankh of Mishra deals 2 damage to that land�s controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Armageddon
    public class ArmageddonA : MagicCard
    {
        public ArmageddonA()
        {
            Name = "Armageddon";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy all lands.";
            Flavor = "";
        }
    }
    # endregion

    # region Aspect of Wolf
    public class AspectofWolfA : MagicCard
    {
        public AspectofWolfA()
        {
            Name = "Aspect of Wolf";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +X/+Y, where X is half the number of Forests you control, rounded down, and Y is half the number of Forests you control, rounded up.";
            Flavor = "";
        }
    }
    # endregion

    # region Bad Moon
    public class BadMoonA : MagicCard
    {
        public BadMoonA()
        {
            Name = "Bad Moon";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Enchantment";
            Text = "Black creatures get +1/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Badlands
    public class BadlandsA : MagicCard
    {
        public BadlandsA()
        {
            Name = "Badlands";
            Edition = "A";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Swamp Mountain";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Balance
    public class BalanceA : MagicCard
    {
        public BalanceA()
        {
            Name = "Balance";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Sorcery";
            Text = "Each player chooses a number of lands he or she controls equal to the number of lands controlled by the player who controls the fewest, then sacrifices the rest. Players discard cards and sacrifice creatures the same way.";
            Flavor = "";
        }
    }
    # endregion

    # region Basalt Monolith
    public class BasaltMonolithA : MagicCard
    {
        public BasaltMonolithA()
        {
            Name = "Basalt Monolith";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Basalt Monolith doesn�t untap during your untap step.;^%T: Add %3 to your mana pool.;^%3: Untap Basalt Monolith.";
            Flavor = "";
        }
    }
    # endregion

    # region Bayou
    public class BayouA : MagicCard
    {
        public BayouA()
        {
            Name = "Bayou";
            Edition = "A";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Swamp Forest";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Benalish Hero
    public class BenalishHeroA : MagicCard
    {
        public BenalishHeroA()
        {
            Name = "Benalish Hero";
            Edition = "A";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Human Soldier";
            Text = "Banding @(Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding you control are blocking or being blocked by a creature, you divide that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by or is blocking.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Berserk
    public class BerserkA : MagicCard
    {
        public BerserkA()
        {
            Name = "Berserk";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Cast Berserk only before the combat damage step.;^Target creature gains trample and gets +X/+0 until end of turn, where X is its power. At the beginning of the next end step, destroy that creature if it attacked this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Birds of Paradise
    public class BirdsofParadiseA : MagicCard
    {
        public BirdsofParadiseA()
        {
            Name = "Birds of Paradise";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "G";
            PT = "0/1";
            Type = "Creature - Bird";
            Text = "Flying;^%T: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Black Knight
    public class BlackKnightA : MagicCard
    {
        public BlackKnightA()
        {
            Name = "Black Knight";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "BB";
            PT = "2/2";
            Type = "Creature - Human Knight";
            Text = "First strike @(This creature deals combat damage before creatures without first strike.)@;^Protection from white @(This creature can�t be blocked, targeted, dealt damage, or enchanted by anything white.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Black Lotus
    public class BlackLotusA : MagicCard
    {
        public BlackLotusA()
        {
            Name = "Black Lotus";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "0";
            PT = "";
            Type = "Artifact";
            Text = "%T, Sacrifice Black Lotus: Add three mana of any one color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Black Vise
    public class BlackViseA : MagicCard
    {
        public BlackViseA()
        {
            Name = "Black Vise";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "As Black Vise enters the battlefield, choose an opponent.;^At the beginning of the chosen player�s upkeep, Black Vise deals X damage to that player, where X is the number of cards in his or her hand minus 4.";
            Flavor = "";
        }
    }
    # endregion

    # region Black Ward
    public class BlackWardA : MagicCard
    {
        public BlackWardA()
        {
            Name = "Black Ward";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature has protection from black. This effect doesn�t remove Black Ward.";
            Flavor = "";
        }
    }
    # endregion

    # region Blaze of Glory
    public class BlazeofGloryA : MagicCard
    {
        public BlazeofGloryA()
        {
            Name = "Blaze of Glory";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Cast Blaze of Glory only during combat before blockers are declared.;^Target creature defending player controls can block any number of creatures this turn. It blocks each attacking creature this turn if able.";
            Flavor = "";
        }
    }
    # endregion

    # region Blessing
    public class BlessingA : MagicCard
    {
        public BlessingA()
        {
            Name = "Blessing";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "WW";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^%W: Enchanted creature gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Blue Elemental Blast
    public class BlueElementalBlastA : MagicCard
    {
        public BlueElementalBlastA()
        {
            Name = "Blue Elemental Blast";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Counter target red spell; or destroy target red permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Blue Ward
    public class BlueWardA : MagicCard
    {
        public BlueWardA()
        {
            Name = "Blue Ward";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature has protection from blue. This effect doesn�t remove Blue Ward.";
            Flavor = "";
        }
    }
    # endregion

    # region Bog Wraith
    public class BogWraithA : MagicCard
    {
        public BogWraithA()
        {
            Name = "Bog Wraith";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "3/3";
            Type = "Creature - Wraith";
            Text = "Swampwalk @(This creature can�t be blocked as long as defending player controls a Swamp.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Braingeyser
    public class BraingeyserA : MagicCard
    {
        public BraingeyserA()
        {
            Name = "Braingeyser";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "XUU";
            PT = "";
            Type = "Sorcery";
            Text = "Target player draws X cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Burrowing
    public class BurrowingA : MagicCard
    {
        public BurrowingA()
        {
            Name = "Burrowing";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature has mountainwalk.";
            Flavor = "";
        }
    }
    # endregion

    # region Camouflage
    public class CamouflageA : MagicCard
    {
        public CamouflageA()
        {
            Name = "Camouflage";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Cast Camouflage only during your declare attackers step.;^This turn, instead of declaring blockers, each defending player chooses any number of creatures he or she controls and divides them into a number of piles equal to the number of attacking creatures for whom that player is the defending player. Creatures he or she controls that can block additional creatures may likewise be put into additional piles. Assign each pile to a different one of those attacking creatures at random. Each creature in a pile that can block the creature that pile is assigned to does so. @(Piles can be empty.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Castle
    public class CastleA : MagicCard
    {
        public CastleA()
        {
            Name = "Castle";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Enchantment";
            Text = "Untapped creatures you control get +0/+2.";
            Flavor = "";
        }
    }
    # endregion

    # region Celestial Prism
    public class CelestialPrismA : MagicCard
    {
        public CelestialPrismA()
        {
            Name = "Celestial Prism";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Channel
    public class ChannelA : MagicCard
    {
        public ChannelA()
        {
            Name = "Channel";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "GG";
            PT = "";
            Type = "Sorcery";
            Text = "Until end of turn, any time you could activate a mana ability, you may pay 1 life. If you do, add %1 to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Chaos Orb
    public class ChaosOrbA : MagicCard
    {
        public ChaosOrbA()
        {
            Name = "Chaos Orb";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%1, %T: If Chaos Orb is on the battlefield, flip Chaos Orb onto the battlefield from a height of at least one foot. If Chaos Orb turns over completely at least once during the flip, destroy all nontoken permanents it touches. Then destroy Chaos Orb.";
            Flavor = "";
        }
    }
    # endregion

    # region Chaoslace
    public class ChaoslaceA : MagicCard
    {
        public ChaoslaceA()
        {
            Name = "Chaoslace";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Target spell or permanent becomes red. @(Its mana symbols remain unchanged.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Circle of Protection: Blue
    public class CircleofProtectionBlueA : MagicCard
    {
        public CircleofProtectionBlueA()
        {
            Name = "Circle of Protection: Blue";
            Edition = "A";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment";
            Text = "%1: The next time a blue source of your choice would deal damage to you this turn, prevent that damage.";
            Flavor = "";
        }
    }
    # endregion

    # region Circle of Protection: Green
    public class CircleofProtectionGreenA : MagicCard
    {
        public CircleofProtectionGreenA()
        {
            Name = "Circle of Protection: Green";
            Edition = "A";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment";
            Text = "%1: The next time a green source of your choice would deal damage to you this turn, prevent that damage.";
            Flavor = "";
        }
    }
    # endregion

    # region Circle of Protection: Red
    public class CircleofProtectionRedA : MagicCard
    {
        public CircleofProtectionRedA()
        {
            Name = "Circle of Protection: Red";
            Edition = "A";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment";
            Text = "%1: The next time a red source of your choice would deal damage to you this turn, prevent that damage.";
            Flavor = "";
        }
    }
    # endregion

    # region Circle of Protection: White
    public class CircleofProtectionWhiteA : MagicCard
    {
        public CircleofProtectionWhiteA()
        {
            Name = "Circle of Protection: White";
            Edition = "A";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment";
            Text = "%1: The next time a white source of your choice would deal damage to you this turn, prevent that damage.";
            Flavor = "";
        }
    }
    # endregion

    # region Clockwork Beast
    public class ClockworkBeastA : MagicCard
    {
        public ClockworkBeastA()
        {
            Name = "Clockwork Beast";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "6";
            PT = "0/4";
            Type = "Artifact Creature - Beast";
            Text = "Clockwork Beast enters the battlefield with seven +1/+0 counters on it.;^At end of combat, if Clockwork Beast attacked or blocked this combat, remove a +1/+0 counter from it.;^%X, %T: Put up to X +1/+0 counters on Clockwork Beast. This ability can�t cause the total number of +1/+0 counters on Clockwork Beast to be greater than seven. Activate this ability only during your upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Clone
    public class CloneA : MagicCard
    {
        public CloneA()
        {
            Name = "Clone";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "0/0";
            Type = "Creature - Shapeshifter";
            Text = "You may have Clone enter the battlefield as a copy of any creature on the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Cockatrice
    public class CockatriceA : MagicCard
    {
        public CockatriceA()
        {
            Name = "Cockatrice";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "3GG";
            PT = "2/4";
            Type = "Creature - Cockatrice";
            Text = "Flying;^Whenever Cockatrice blocks or becomes blocked by a non-Wall creature, destroy that creature at end of combat.";
            Flavor = "";
        }
    }
    # endregion

    # region Consecrate Land
    public class ConsecrateLandA : MagicCard
    {
        public ConsecrateLandA()
        {
            Name = "Consecrate Land";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land;^Enchanted land has indestructible and can�t be enchanted by other Auras.";
            Flavor = "";
        }
    }
    # endregion

    # region Conservator
    public class ConservatorA : MagicCard
    {
        public ConservatorA()
        {
            Name = "Conservator";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T: Prevent the next 2 damage that would be dealt to you this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Contract from Below
    public class ContractfromBelowA : MagicCard
    {
        public ContractfromBelowA()
        {
            Name = "Contract from Below";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Sorcery";
            Text = "Remove Contract from Below from your deck before playing if you�re not playing for ante.;^Discard your hand, add the top card of your library to the ante, then draw seven cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Control Magic
    public class ControlMagicA : MagicCard
    {
        public ControlMagicA()
        {
            Name = "Control Magic";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "2UU";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^You control enchanted creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Conversion
    public class ConversionA : MagicCard
    {
        public ConversionA()
        {
            Name = "Conversion";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "2WW";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of your upkeep, sacrifice Conversion unless you pay %W%W.;^All Mountains are Plains.";
            Flavor = "";
        }
    }
    # endregion

    # region Copper Tablet
    public class CopperTabletA : MagicCard
    {
        public CopperTabletA()
        {
            Name = "Copper Tablet";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of each player�s upkeep, Copper Tablet deals 1 damage to that player.";
            Flavor = "";
        }
    }
    # endregion

    # region Copy Artifact
    public class CopyArtifactA : MagicCard
    {
        public CopyArtifactA()
        {
            Name = "Copy Artifact";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Enchantment";
            Text = "You may have Copy Artifact enter the battlefield as a copy of any artifact on the battlefield, except it�s an enchantment in addition to its other types.";
            Flavor = "";
        }
    }
    # endregion

    # region Counterspell
    public class CounterspellA : MagicCard
    {
        public CounterspellA()
        {
            Name = "Counterspell";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "UU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Craw Wurm
    public class CrawWurmA : MagicCard
    {
        public CrawWurmA()
        {
            Name = "Craw Wurm";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "4GG";
            PT = "6/4";
            Type = "Creature - Wurm";
            Text = "";
            Flavor = "The most terrifying thing about the Craw Wurm is probably the horrible crashing sound it makes as it speeds through the forest. This noise is so loud it echoes through the trees and seems to come from all directions at once.";
        }
    }
    # endregion

    # region Creature Bond
    public class CreatureBondA : MagicCard
    {
        public CreatureBondA()
        {
            Name = "Creature Bond";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^When enchanted creature dies, Creature Bond deals damage equal to that creature�s toughness to the creature�s controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Crusade
    public class CrusadeA : MagicCard
    {
        public CrusadeA()
        {
            Name = "Crusade";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "WW";
            PT = "";
            Type = "Enchantment";
            Text = "White creatures get +1/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Crystal Rod
    public class CrystalRodA : MagicCard
    {
        public CrystalRodA()
        {
            Name = "Crystal Rod";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a player casts a blue spell, you may pay %1. If you do, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Cursed Land
    public class CursedLandA : MagicCard
    {
        public CursedLandA()
        {
            Name = "Cursed Land";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "2BB";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land;^At the beginning of the upkeep of enchanted land�s controller, Cursed Land deals 1 damage to that player.";
            Flavor = "";
        }
    }
    # endregion

    # region Cyclopean Tomb
    public class CyclopeanTombA : MagicCard
    {
        public CyclopeanTombA()
        {
            Name = "Cyclopean Tomb";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T: Put a mire counter on target non-Swamp land. That land is a Swamp for as long as it has a mire counter on it. Activate this ability only during your upkeep.;^When Cyclopean Tomb is put into a graveyard from the battlefield, at the beginning of each of your upkeeps for the rest of the game, remove all mire counters from a land that a mire counter was put onto with Cyclopean Tomb but that a mire counter has not been removed from with Cyclopean Tomb.";
            Flavor = "";
        }
    }
    # endregion

    # region Dark Ritual
    public class DarkRitualA : MagicCard
    {
        public DarkRitualA()
        {
            Name = "Dark Ritual";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "Add %B%B%B to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Darkpact
    public class DarkpactA : MagicCard
    {
        public DarkpactA()
        {
            Name = "Darkpact";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "BBB";
            PT = "";
            Type = "Sorcery";
            Text = "Remove Darkpact from your deck before playing if you�re not playing for ante.;^You own target card in the ante. Exchange that card with the top of your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Death Ward
    public class DeathWardA : MagicCard
    {
        public DeathWardA()
        {
            Name = "Death Ward";
            Edition = "A";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Regenerate target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Deathgrip
    public class DeathgripA : MagicCard
    {
        public DeathgripA()
        {
            Name = "Deathgrip";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "BB";
            PT = "";
            Type = "Enchantment";
            Text = "%B%B: Counter target green spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Deathlace
    public class DeathlaceA : MagicCard
    {
        public DeathlaceA()
        {
            Name = "Deathlace";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "Target spell or permanent becomes black. @(Mana symbols on that permanent remain unchanged.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Demonic Attorney
    public class DemonicAttorneyA : MagicCard
    {
        public DemonicAttorneyA()
        {
            Name = "Demonic Attorney";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "1BB";
            PT = "";
            Type = "Sorcery";
            Text = "Remove Demonic Attorney from your deck before playing if you�re not playing for ante.;^Each player antes the top card of his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Demonic Hordes
    public class DemonicHordesA : MagicCard
    {
        public DemonicHordesA()
        {
            Name = "Demonic Hordes";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "3BBB";
            PT = "5/5";
            Type = "Creature - Demon";
            Text = "%T: Destroy target land.;^At the beginning of your upkeep, unless you pay %B%B%B, tap Demonic Hordes and sacrifice a land of an opponent�s choice.";
            Flavor = "";
        }
    }
    # endregion

    # region Demonic Tutor
    public class DemonicTutorA : MagicCard
    {
        public DemonicTutorA()
        {
            Name = "Demonic Tutor";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Sorcery";
            Text = "Search your library for a card and put that card into your hand. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Dingus Egg
    public class DingusEggA : MagicCard
    {
        public DingusEggA()
        {
            Name = "Dingus Egg";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a land is put into a graveyard from the battlefield, Dingus Egg deals 2 damage to that land�s controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Disenchant
    public class DisenchantA : MagicCard
    {
        public DisenchantA()
        {
            Name = "Disenchant";
            Edition = "A";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Destroy target artifact or enchantment.";
            Flavor = "";
        }
    }
    # endregion

    # region Disintegrate
    public class DisintegrateA : MagicCard
    {
        public DisintegrateA()
        {
            Name = "Disintegrate";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "XR";
            PT = "";
            Type = "Sorcery";
            Text = "Disintegrate deals X damage to target creature or player. That creature can�t be regenerated this turn. If the creature would die this turn, exile it instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Disrupting Scepter
    public class DisruptingScepterA : MagicCard
    {
        public DisruptingScepterA()
        {
            Name = "Disrupting Scepter";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T: Target player discards a card. Activate this ability only during your turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Dragon Whelp
    public class DragonWhelpA : MagicCard
    {
        public DragonWhelpA()
        {
            Name = "Dragon Whelp";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "2RR";
            PT = "2/3";
            Type = "Creature - Dragon";
            Text = "Flying;^%R: Dragon Whelp gets +1/+0 until end of turn. If this ability has been activated four or more times this turn, sacrifice Dragon Whelp at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Drain Life
    public class DrainLifeA : MagicCard
    {
        public DrainLifeA()
        {
            Name = "Drain Life";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "X1B";
            PT = "";
            Type = "Sorcery";
            Text = "Spend only black mana on X.;^Drain Life deals X damage to target creature or player. You gain life equal to the damage dealt, but not more life than the player�s life total before Drain Life dealt damage or the creature�s toughness.";
            Flavor = "";
        }
    }
    # endregion

    # region Drain Power
    public class DrainPowerA : MagicCard
    {
        public DrainPowerA()
        {
            Name = "Drain Power";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "UU";
            PT = "";
            Type = "Sorcery";
            Text = "Target player activates a mana ability of each land he or she controls. Then put all mana from that player�s mana pool into yours.";
            Flavor = "";
        }
    }
    # endregion

    # region Drudge Skeletons
    public class DrudgeSkeletonsA : MagicCard
    {
        public DrudgeSkeletonsA()
        {
            Name = "Drudge Skeletons";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "1/1";
            Type = "Creature - Skeleton";
            Text = "%B: Regenerate Drudge Skeletons. @(The next time this creature would be destroyed this turn, it isn�t. Instead tap it, remove all damage from it, and remove it from combat.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Dwarven Demolition Team
    public class DwarvenDemolitionTeamA : MagicCard
    {
        public DwarvenDemolitionTeamA()
        {
            Name = "Dwarven Demolition Team";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "1/1";
            Type = "Creature - Dwarf";
            Text = "%T: Destroy target Wall.";
            Flavor = "";
        }
    }
    # endregion

    # region Dwarven Warriors
    public class DwarvenWarriorsA : MagicCard
    {
        public DwarvenWarriorsA()
        {
            Name = "Dwarven Warriors";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "1/1";
            Type = "Creature - Dwarf Warrior";
            Text = "%T: Target creature with power 2 or less can�t be blocked this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Earth Elemental
    public class EarthElementalA : MagicCard
    {
        public EarthElementalA()
        {
            Name = "Earth Elemental";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "3RR";
            PT = "4/5";
            Type = "Creature - Elemental";
            Text = "";
            Flavor = "Earth Elementals have the eternal strength of stone and the endurance of mountains. Primordially connected to the land they inhabit, they take a long-term view of things, scorning the impetuous haste of short-lived mortal creatures.";
        }
    }
    # endregion

    # region Earthbind
    public class EarthbindA : MagicCard
    {
        public EarthbindA()
        {
            Name = "Earthbind";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^When Earthbind enters the battlefield, if enchanted creature has flying, Earthbind deals 2 damage to that creature and Earthbind gains �Enchanted creature loses flying.�";
            Flavor = "";
        }
    }
    # endregion

    # region Earthquake
    public class EarthquakeA : MagicCard
    {
        public EarthquakeA()
        {
            Name = "Earthquake";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "XR";
            PT = "";
            Type = "Sorcery";
            Text = "Earthquake deals X damage to each creature without flying and each player.";
            Flavor = "";
        }
    }
    # endregion

    # region Elvish Archers
    public class ElvishArchersA : MagicCard
    {
        public ElvishArchersA()
        {
            Name = "Elvish Archers";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "1G";
            PT = "2/1";
            Type = "Creature - Elf Archer";
            Text = "First strike";
            Flavor = "";
        }
    }
    # endregion

    # region Evil Presence
    public class EvilPresenceA : MagicCard
    {
        public EvilPresenceA()
        {
            Name = "Evil Presence";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land;^Enchanted land is a Swamp.";
            Flavor = "";
        }
    }
    # endregion

    # region False Orders
    public class FalseOrdersA : MagicCard
    {
        public FalseOrdersA()
        {
            Name = "False Orders";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Cast False Orders only during the declare blockers step.;^Remove target creature defending player controls from combat. Creatures it was blocking that had become blocked by only that creature this combat become unblocked. You may have it block an attacking creature of your choice.";
            Flavor = "";
        }
    }
    # endregion

    # region Farmstead
    public class FarmsteadA : MagicCard
    {
        public FarmsteadA()
        {
            Name = "Farmstead";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "WWW";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land;^Enchanted land has �At the beginning of your upkeep, you may pay %W%W. If you do, you gain 1 life.�";
            Flavor = "";
        }
    }
    # endregion

    # region Fastbond
    public class FastbondA : MagicCard
    {
        public FastbondA()
        {
            Name = "Fastbond";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Enchantment";
            Text = "You may play any number of additional lands on each of your turns.;^Whenever you play a land, if it wasn�t the first land you played this turn, Fastbond deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Fear
    public class FearA : MagicCard
    {
        public FearA()
        {
            Name = "Fear";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "BB";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature @(Target a creature as you cast this. This card enters the battlefield attached to that creature.)@;^Enchanted creature has fear. @(It can�t be blocked except by artifact creatures and/or black creatures.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Feedback
    public class FeedbackA : MagicCard
    {
        public FeedbackA()
        {
            Name = "Feedback";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant enchantment;^At the beginning of the upkeep of enchanted enchantment�s controller, Feedback deals 1 damage to that player.";
            Flavor = "";
        }
    }
    # endregion

    # region Fire Elemental
    public class FireElementalA : MagicCard
    {
        public FireElementalA()
        {
            Name = "Fire Elemental";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "3RR";
            PT = "5/4";
            Type = "Creature - Elemental";
            Text = "";
            Flavor = "Fire Elementals are ruthless infernos, annihilating and consuming their foes in a frenzied holocaust. Crackling and blazing, they sear swift, terrible paths, leaving the land charred and scorched in their wake.";
        }
    }
    # endregion

    # region Fireball
    public class FireballA : MagicCard
    {
        public FireballA()
        {
            Name = "Fireball";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "XR";
            PT = "";
            Type = "Sorcery";
            Text = "Fireball deals X damage divided evenly, rounded down, among any number of target creatures and/or players.;^Fireball costs %1 more to cast for each target beyond the first.";
            Flavor = "";
        }
    }
    # endregion

    # region Firebreathing
    public class FirebreathingA : MagicCard
    {
        public FirebreathingA()
        {
            Name = "Firebreathing";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^%R: Enchanted creature gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Flashfires
    public class FlashfiresA : MagicCard
    {
        public FlashfiresA()
        {
            Name = "Flashfires";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy all plains.";
            Flavor = "";
        }
    }
    # endregion

    # region Flight
    public class FlightA : MagicCard
    {
        public FlightA()
        {
            Name = "Flight";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature has flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Fog
    public class FogA : MagicCard
    {
        public FogA()
        {
            Name = "Fog";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Prevent all combat damage that would be dealt this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Force of Nature
    public class ForceofNatureA : MagicCard
    {
        public ForceofNatureA()
        {
            Name = "Force of Nature";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "2GGGG";
            PT = "8/8";
            Type = "Creature - Elemental";
            Text = "Trample @(If this creature would assign enough damage to its blockers to destroy them, you may have it assign the rest of its damage to defending player or planeswalker.)@;^At the beginning of your upkeep, Force of Nature deals 8 damage to you unless you pay %G%G%G%G.";
            Flavor = "";
        }
    }
    # endregion

    # region Forcefield
    public class ForcefieldA : MagicCard
    {
        public ForcefieldA()
        {
            Name = "Forcefield";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%1: The next time an unblocked creature of your choice would deal combat damage to you this turn, prevent all but 1 of that damage.";
            Flavor = "";
        }
    }
    # endregion

    # region Forest
    public class ForestAA : MagicCard
    {
        public ForestAA()
        {
            Name = "Forest";
            Edition = "A";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Forest";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Fork
    public class ForkA : MagicCard
    {
        public ForkA()
        {
            Name = "Fork";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "RR";
            PT = "";
            Type = "Instant";
            Text = "Copy target instant or sorcery spell, except that the copy is red. You may choose new targets for the copy.";
            Flavor = "";
        }
    }
    # endregion

    # region Frozen Shade
    public class FrozenShadeA : MagicCard
    {
        public FrozenShadeA()
        {
            Name = "Frozen Shade";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "0/1";
            Type = "Creature - Shade";
            Text = "%B: Frozen Shade gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Fungusaur
    public class FungusaurA : MagicCard
    {
        public FungusaurA()
        {
            Name = "Fungusaur";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "3G";
            PT = "2/2";
            Type = "Creature - Fungus Lizard";
            Text = "Whenever Fungusaur is dealt damage, put a +1/+1 counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Gaea's Liege
    public class GaeasLiegeA : MagicCard
    {
        public GaeasLiegeA()
        {
            Name = "Gaea's Liege";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "3GGG";
            PT = "*/*";
            Type = "Creature - Avatar";
            Text = "As long as Gaea�s Liege isn�t attacking, its power and toughness are each equal to the number of Forests you control. As long as Gaea�s Liege is attacking, its power and toughness are each equal to the number of Forests defending player controls.;^%T: Target land becomes a Forest until Gaea�s Liege leaves the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Gauntlet of Might
    public class GauntletofMightA : MagicCard
    {
        public GauntletofMightA()
        {
            Name = "Gauntlet of Might";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "Red creatures get +1/+1.;^Whenever a Mountain is tapped for mana, its controller adds %R to his or her mana pool @(in addition to the mana the land produces)@.";
            Flavor = "";
        }
    }
    # endregion

    # region Giant Growth
    public class GiantGrowthGPA : MagicCard
    {
        public GiantGrowthGPA()
        {
            Name = "Giant Growth";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +3/+3 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Giant Spider
    public class GiantSpiderA : MagicCard
    {
        public GiantSpiderA()
        {
            Name = "Giant Spider";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "2/4";
            Type = "Creature - Spider";
            Text = "Reach @(This creature can block creatures with flying.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Glasses of Urza
    public class GlassesofUrzaA : MagicCard
    {
        public GlassesofUrzaA()
        {
            Name = "Glasses of Urza";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%T: Look at target player�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Gloom
    public class GloomA : MagicCard
    {
        public GloomA()
        {
            Name = "Gloom";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Enchantment";
            Text = "White spells cost %3 more to cast.;^Activated abilities of white enchantments cost %3 more to activate.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Balloon Brigade
    public class GoblinBalloonBrigadeA : MagicCard
    {
        public GoblinBalloonBrigadeA()
        {
            Name = "Goblin Balloon Brigade";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Goblin Warrior";
            Text = "%R: Goblin Balloon Brigade gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin King
    public class GoblinKingA : MagicCard
    {
        public GoblinKingA()
        {
            Name = "Goblin King";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "1RR";
            PT = "2/2";
            Type = "Creature - Goblin";
            Text = "Other Goblin creatures get +1/+1 and have mountainwalk. @(They can�t be blocked as long as defending player controls a Mountain.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Granite Gargoyle
    public class GraniteGargoyleA : MagicCard
    {
        public GraniteGargoyleA()
        {
            Name = "Granite Gargoyle";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Gargoyle";
            Text = "Flying;^%R: Granite Gargoyle gets +0/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Gray Ogre
    public class GrayOgreA : MagicCard
    {
        public GrayOgreA()
        {
            Name = "Gray Ogre";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Ogre";
            Text = "";
            Flavor = "The Ogre philosopher Gnerdel believed the purpose of life was to live as high on the food chain as possible. She refused to eat vegetarians, and preferred to live entirely on creatures that preyed on sentient beings.";
        }
    }
    # endregion

    # region Green Ward
    public class GreenWardA : MagicCard
    {
        public GreenWardA()
        {
            Name = "Green Ward";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature has protection from green. This effect doesn�t remove Green Ward.";
            Flavor = "";
        }
    }
    # endregion

    # region Grizzly Bears
    public class GrizzlyBearsA : MagicCard
    {
        public GrizzlyBearsA()
        {
            Name = "Grizzly Bears";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "2/2";
            Type = "Creature - Bear";
            Text = "";
            Flavor = "Don�t try to outrun one of Dominia�s Grizzlies; it�ll catch you, knock you down, and eat you. Of course, you could run up a tree.� In that case you�ll get a nice view before it knocks the tree down and eats you.";
        }
    }
    # endregion

    # region Guardian Angel
    public class GuardianAngelA : MagicCard
    {
        public GuardianAngelA()
        {
            Name = "Guardian Angel";
            Edition = "A";
            Rarity = "C";
            Color = "W";
            Cost = "XW";
            PT = "";
            Type = "Instant";
            Text = "Prevent the next X damage that would be dealt to target creature or player this turn. Until end of turn, you may pay %1 any time you could cast an instant. If you do, prevent the next 1 damage that would be dealt to that creature or player this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Healing Salve
    public class HealingSalveA : MagicCard
    {
        public HealingSalveA()
        {
            Name = "Healing Salve";
            Edition = "A";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Target player gains 3 life; or prevent the next 3 damage that would be dealt to target creature or player this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Helm of Chatzuk
    public class HelmofChatzukA : MagicCard
    {
        public HelmofChatzukA()
        {
            Name = "Helm of Chatzuk";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%1, %T: Target creature gains banding until end of turn. @(Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding a player controls are blocking or being blocked by a creature, that player divides that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by or is blocking.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Hill Giant
    public class HillGiantA : MagicCard
    {
        public HillGiantA()
        {
            Name = "Hill Giant";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "3/3";
            Type = "Creature - Giant";
            Text = "";
            Flavor = "Fortunately, Hill Giants have large blind spots in which a human can easily hide. Unfortunately, these blind spots are beneath�the bottoms of their feet.";
        }
    }
    # endregion

    # region Holy Armor
    public class HolyArmorA : MagicCard
    {
        public HolyArmorA()
        {
            Name = "Holy Armor";
            Edition = "A";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +0/+2.;^%W: Enchanted creature gets +0/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Holy Strength
    public class HolyStrengthA : MagicCard
    {
        public HolyStrengthA()
        {
            Name = "Holy Strength";
            Edition = "A";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +1/+2.";
            Flavor = "";
        }
    }
    # endregion

    # region Howl from Beyond
    public class HowlfromBeyondA : MagicCard
    {
        public HowlfromBeyondA()
        {
            Name = "Howl from Beyond";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "XB";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +X/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Howling Mine
    public class HowlingMineA : MagicCard
    {
        public HowlingMineA()
        {
            Name = "Howling Mine";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of each player�s draw step, if Howling Mine is untapped, that player draws an additional card.";
            Flavor = "";
        }
    }
    # endregion

    # region Hurloon Minotaur
    public class HurloonMinotaurA : MagicCard
    {
        public HurloonMinotaurA()
        {
            Name = "Hurloon Minotaur";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "1RR";
            PT = "2/3";
            Type = "Creature - Minotaur";
            Text = "";
            Flavor = "The Minotaurs of the Hurloon Mountains are known for their love of battle. They are also known for their hymns to the dead, sung for friend and foe alike. These hymns can last for days, filling the mountain valleys with their low, haunting sounds.";
        }
    }
    # endregion

    # region Hurricane
    public class HurricaneA : MagicCard
    {
        public HurricaneA()
        {
            Name = "Hurricane";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "XG";
            PT = "";
            Type = "Sorcery";
            Text = "Hurricane deals X damage to each creature with flying and each player.";
            Flavor = "";
        }
    }
    # endregion

    # region Hypnotic Specter
    public class HypnoticSpecterA : MagicCard
    {
        public HypnoticSpecterA()
        {
            Name = "Hypnotic Specter";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "1BB";
            PT = "2/2";
            Type = "Creature - Specter";
            Text = "Flying;^Whenever Hypnotic Specter deals damage to an opponent, that player discards a card at random.";
            Flavor = "";
        }
    }
    # endregion

    # region Ice Storm
    public class IceStormA : MagicCard
    {
        public IceStormA()
        {
            Name = "Ice Storm";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target land.";
            Flavor = "";
        }
    }
    # endregion

    # region Icy Manipulator
    public class IcyManipulatorA : MagicCard
    {
        public IcyManipulatorA()
        {
            Name = "Icy Manipulator";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%1, %T: Tap target artifact, creature, or land.";
            Flavor = "";
        }
    }
    # endregion

    # region Illusionary Mask
    public class IllusionaryMaskA : MagicCard
    {
        public IllusionaryMaskA()
        {
            Name = "Illusionary Mask";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%X: You may choose a creature card in your hand whose mana cost could be paid by some amount of, or all of, the mana you spent on %X. If you do, you may cast that card face down as a 2/2 creature spell without paying its mana cost. If the creature that spell becomes as it resolves has not been turned face up and would assign or deal damage, be dealt damage, or become tapped, instead it�s turned face up and assigns or deals damage, is dealt damage, or becomes tapped. Activate this ability only any time you could cast a sorcery.";
            Flavor = "";
        }
    }
    # endregion

    # region Instill Energy
    public class InstillEnergyA : MagicCard
    {
        public InstillEnergyA()
        {
            Name = "Instill Energy";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature can attack as though it had haste.;^%0: Untap enchanted creature. Activate this ability only during your turn and only once each turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Invisibility
    public class InvisibilityA : MagicCard
    {
        public InvisibilityA()
        {
            Name = "Invisibility";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "UU";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature can�t be blocked except by Walls.";
            Flavor = "";
        }
    }
    # endregion

    # region Iron Star
    public class IronStarA : MagicCard
    {
        public IronStarA()
        {
            Name = "Iron Star";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a player casts a red spell, you may pay %1. If you do, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Ironclaw Orcs
    public class IronclawOrcsA : MagicCard
    {
        public IronclawOrcsA()
        {
            Name = "Ironclaw Orcs";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "2/2";
            Type = "Creature - Orc";
            Text = "Ironclaw Orcs can�t block creatures with power 2 or greater.";
            Flavor = "";
        }
    }
    # endregion

    # region Ironroot Treefolk
    public class IronrootTreefolkA : MagicCard
    {
        public IronrootTreefolkA()
        {
            Name = "Ironroot Treefolk";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "4G";
            PT = "3/5";
            Type = "Creature - Treefolk";
            Text = "";
            Flavor = "The mating habits of Treefolk, particularly the stalwart Ironroot Treefolk, are truly absurd. Molasses comes to mind. It�s amazing the species can survive at all given such protracted periods of mate selection, conjugation, and gestation.";
        }
    }
    # endregion

    # region Island A
    public class IslandAA : MagicCard
    {
        public IslandAA()
        {
            Name = "Island";
            Edition = "A";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Island";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Island Sanctuary
    public class IslandSanctuaryA : MagicCard
    {
        public IslandSanctuaryA()
        {
            Name = "Island Sanctuary";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment";
            Text = "If you would draw a card during your draw step, instead you may skip that draw. If you do, until your next turn, you can�t be attacked except by creatures with flying and/or islandwalk.";
            Flavor = "";
        }
    }
    # endregion

    # region Ivory Cup
    public class IvoryCupA : MagicCard
    {
        public IvoryCupA()
        {
            Name = "Ivory Cup";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a player casts a white spell, you may pay %1. If you do, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Jade Monolith
    public class JadeMonolithA : MagicCard
    {
        public JadeMonolithA()
        {
            Name = "Jade Monolith";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%1: The next time a source of your choice would deal damage to target creature this turn, that source deals that damage to you instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Jade Statue
    public class JadeStatueA : MagicCard
    {
        public JadeStatueA()
        {
            Name = "Jade Statue";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%2: Jade Statue becomes a 3/6 Golem artifact creature until end of combat. Activate this ability only during combat.";
            Flavor = "";
        }
    }
    # endregion

    # region Jayemdae Tome
    public class JayemdaeTomeA : MagicCard
    {
        public JayemdaeTomeA()
        {
            Name = "Jayemdae Tome";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%4, %T: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Juggernaut
    public class JuggernautA : MagicCard
    {
        public JuggernautA()
        {
            Name = "Juggernaut";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "5/3";
            Type = "Artifact Creature - Juggernaut";
            Text = "Juggernaut attacks each turn if able.;^Juggernaut can�t be blocked by Walls.";
            Flavor = "";
        }
    }
    # endregion

    # region Jump
    public class JumpA : MagicCard
    {
        public JumpA()
        {
            Name = "Jump";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Target creature gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Karma
    public class KarmaA : MagicCard
    {
        public KarmaA()
        {
            Name = "Karma";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "2WW";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of each player�s upkeep, Karma deals damage to that player equal to the number of Swamps he or she controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Keldon Warlord
    public class KeldonWarlordA : MagicCard
    {
        public KeldonWarlordA()
        {
            Name = "Keldon Warlord";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "2RR";
            PT = "*/*";
            Type = "Creature - Human Barbarian";
            Text = "Keldon Warlord�s power and toughness are each equal to the number of non-Wall creatures you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Kormus Bell
    public class KormusBellA : MagicCard
    {
        public KormusBellA()
        {
            Name = "Kormus Bell";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "All Swamps are 1/1 black creatures that are still lands.";
            Flavor = "";
        }
    }
    # endregion

    # region Kudzu
    public class KudzuA : MagicCard
    {
        public KudzuA()
        {
            Name = "Kudzu";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "1GG";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land;^When enchanted land becomes tapped, destroy it. That land�s controller attaches Kudzu to a land of his or her choice.";
            Flavor = "";
        }
    }
    # endregion

    # region Lance
    public class LanceA : MagicCard
    {
        public LanceA()
        {
            Name = "Lance";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature has first strike.";
            Flavor = "";
        }
    }
    # endregion

    # region Ley Druid
    public class LeyDruidA : MagicCard
    {
        public LeyDruidA()
        {
            Name = "Ley Druid";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "1/1";
            Type = "Creature - Human Druid";
            Text = "%T: Untap target land.";
            Flavor = "";
        }
    }
    # endregion

    # region Library of Leng
    public class LibraryofLengA : MagicCard
    {
        public LibraryofLengA()
        {
            Name = "Library of Leng";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "You have no maximum hand size.;^If an effect causes you to discard a card, discard it, but you may put it on top of your library instead of into your graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Lich
    public class LichA : MagicCard
    {
        public LichA()
        {
            Name = "Lich";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "BBBB";
            PT = "";
            Type = "Enchantment";
            Text = "As Lich enters the battlefield, you lose life equal to your life total.;^You don�t lose the game for having 0 or less life.;^If you would gain life, draw that many cards instead.;^Whenever you�re dealt damage, sacrifice that many nontoken permanents. If you can�t, you lose the game.;^When Lich is put into a graveyard from the battlefield, you lose the game.";
            Flavor = "";
        }
    }
    # endregion

    # region Lifeforce
    public class LifeforceA : MagicCard
    {
        public LifeforceA()
        {
            Name = "Lifeforce";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "GG";
            PT = "";
            Type = "Enchantment";
            Text = "%G%G: Counter target black spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Lifelace
    public class LifelaceA : MagicCard
    {
        public LifelaceA()
        {
            Name = "Lifelace";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Target spell or permanent becomes green. @(Mana symbols on that permanent remain unchanged.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Lifetap
    public class LifetapA : MagicCard
    {
        public LifetapA()
        {
            Name = "Lifetap";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "UU";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a Forest an opponent controls becomes tapped, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Lightning Bolt
    public class LightningBoltA : MagicCard
    {
        public LightningBoltA()
        {
            Name = "Lightning Bolt";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Lightning Bolt deals 3 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Living Artifact
    public class LivingArtifactA : MagicCard
    {
        public LivingArtifactA()
        {
            Name = "Living Artifact";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant artifact;^Whenever you�re dealt damage, put that many vitality counters on Living Artifact.;^At the beginning of your upkeep, you may remove a vitality counter from Living Artifact. If you do, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Living Lands
    public class LivingLandsA : MagicCard
    {
        public LivingLandsA()
        {
            Name = "Living Lands";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Enchantment";
            Text = "All forests are 1/1 creatures that are still lands.";
            Flavor = "";
        }
    }
    # endregion

    # region Living Wall
    public class LivingWallA : MagicCard
    {
        public LivingWallA()
        {
            Name = "Living Wall";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "0/6";
            Type = "Artifact Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@;^%1: Regenerate Living Wall.";
            Flavor = "";
        }
    }
    # endregion

    # region Llanowar Elves
    public class LlanowarElvesA : MagicCard
    {
        public LlanowarElvesA()
        {
            Name = "Llanowar Elves";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Elf Druid";
            Text = "%T: Add %G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Lord of Atlantis
    public class LordofAtlantisA : MagicCard
    {
        public LordofAtlantisA()
        {
            Name = "Lord of Atlantis";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "UU";
            PT = "2/2";
            Type = "Creature - Merfolk";
            Text = "Other Merfolk creatures get +1/+1 and have islandwalk.";
            Flavor = "";
        }
    }
    # endregion

    # region Lord of the Pit
    public class LordofthePitA : MagicCard
    {
        public LordofthePitA()
        {
            Name = "Lord of the Pit";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "4BBB";
            PT = "7/7";
            Type = "Creature - Demon";
            Text = "Flying, trample;^At the beginning of your upkeep, sacrifice a creature other than Lord of the Pit. If you can�t, Lord of the Pit deals 7 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Lure
    public class LureA : MagicCard
    {
        public LureA()
        {
            Name = "Lure";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "1GG";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^All creatures able to block enchanted creature do so.";
            Flavor = "";
        }
    }
    # endregion

    # region Magical Hack
    public class MagicalHackA : MagicCard
    {
        public MagicalHackA()
        {
            Name = "Magical Hack";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Change the text of target spell or permanent by replacing all instances of one basic land type with another. @(For example, you may change �swampwalk� to �plainswalk.� This effect lasts indefinitely.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Mahamoti Djinn
    public class MahamotiDjinnA : MagicCard
    {
        public MahamotiDjinnA()
        {
            Name = "Mahamoti Djinn";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "4UU";
            PT = "5/6";
            Type = "Creature - Djinn";
            Text = "Flying @(This creature can�t be blocked except by creatures with flying or reach.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Mana Flare
    public class ManaFlareA : MagicCard
    {
        public ManaFlareA()
        {
            Name = "Mana Flare";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a player taps a land for mana, that player adds one mana to his or her mana pool of any type that land produced.";
            Flavor = "";
        }
    }
    # endregion

    # region Mana Short
    public class ManaShortA : MagicCard
    {
        public ManaShortA()
        {
            Name = "Mana Short";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Instant";
            Text = "Tap all lands target player controls and empty his or her mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Mana Vault
    public class ManaVaultA : MagicCard
    {
        public ManaVaultA()
        {
            Name = "Mana Vault";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "Mana Vault doesn�t untap during your untap step.;^At the beginning of your upkeep, you may pay %4. If you do, untap Mana Vault.;^At the beginning of your draw step, if Mana Vault is tapped, it deals 1 damage to you.;^%T: Add %3 to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Manabarbs
    public class ManabarbsA : MagicCard
    {
        public ManabarbsA()
        {
            Name = "Manabarbs";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a player taps a land for mana, Manabarbs deals 1 damage to that player.";
            Flavor = "";
        }
    }
    # endregion

    # region Meekstone
    public class MeekstoneA : MagicCard
    {
        public MeekstoneA()
        {
            Name = "Meekstone";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "Creatures with power 3 or greater don�t untap during their controllers� untap steps.";
            Flavor = "";
        }
    }
    # endregion

    # region Merfolk of the Pearl Trident
    public class MerfolkofthePearlTridentA : MagicCard
    {
        public MerfolkofthePearlTridentA()
        {
            Name = "Merfolk of the Pearl Trident";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "1/1";
            Type = "Creature - Merfolk";
            Text = "";
            Flavor = "Most human scholars believe that Merfolk are the survivors of sunken Atlantis, humans adapted to the water. Merfolk, however, believe that humans sprang forth from Merfolk who adapted themselves in order to explore their last frontier.";
        }
    }
    # endregion

    # region Mesa Pegasus
    public class MesaPegasusA : MagicCard
    {
        public MesaPegasusA()
        {
            Name = "Mesa Pegasus";
            Edition = "A";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "1/1";
            Type = "Creature - Pegasus";
            Text = "Flying; banding @(Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding you control are blocking or being blocked by a creature, you divide that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by or is blocking.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Mind Twist
    public class MindTwistA : MagicCard
    {
        public MindTwistA()
        {
            Name = "Mind Twist";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "XB";
            PT = "";
            Type = "Sorcery";
            Text = "Target player discards X cards at random.";
            Flavor = "";
        }
    }
    # endregion

    # region Mons's Goblin Raiders
    public class MonssGoblinRaidersA : MagicCard
    {
        public MonssGoblinRaidersA()
        {
            Name = "Mons's Goblin Raiders";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Goblin";
            Text = "";
            Flavor = "The intricate dynamics of Rundvelt Goblin affairs are often confused with anarchy. The chaos, however, is the chaos of a thundercloud, and direction will sporadically and violently appear. Pashalik Mons and his raiders are the thunderhead that leads in the storm.";
        }
    }
    # endregion

    # region Mountain A
    public class MountainAA : MagicCard
    {
        public MountainAA()
        {
            Name = "Mountain";
            Edition = "A";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Mountain";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Mox Emerald
    public class MoxEmeraldA : MagicCard
    {
        public MoxEmeraldA()
        {
            Name = "Mox Emerald";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "0";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Mox Jet
    public class MoxJetA : MagicCard
    {
        public MoxJetA()
        {
            Name = "Mox Jet";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "0";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %B to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Mox Pearl
    public class MoxPearlA : MagicCard
    {
        public MoxPearlA()
        {
            Name = "Mox Pearl";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "0";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %W to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Mox Ruby
    public class MoxRubyA : MagicCard
    {
        public MoxRubyA()
        {
            Name = "Mox Ruby";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "0";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %R to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Mox Sapphire
    public class MoxSapphireA : MagicCard
    {
        public MoxSapphireA()
        {
            Name = "Mox Sapphire";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "0";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %U to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Natural Selection
    public class NaturalSelectionA : MagicCard
    {
        public NaturalSelectionA()
        {
            Name = "Natural Selection";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Look at the top three cards of target player�s library, then put them back in any order. You may have that player shuffle his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Nether Shadow
    public class NetherShadowA : MagicCard
    {
        public NetherShadowA()
        {
            Name = "Nether Shadow";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "BB";
            PT = "1/1";
            Type = "Creature - Spirit";
            Text = "Haste;^At the beginning of your upkeep, if Nether Shadow is in your graveyard with three or more creature cards above it, you may put Nether Shadow onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Nettling Imp
    public class NettlingImpA : MagicCard
    {
        public NettlingImpA()
        {
            Name = "Nettling Imp";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "1/1";
            Type = "Creature - Imp";
            Text = "%T: Choose target non-Wall creature the active player has controlled continuously since the beginning of the turn. That creature attacks this turn if able. If it doesn�t, destroy it at the beginning of the next end step. Activate this ability only during an opponent�s turn, before attackers are declared.";
            Flavor = "";
        }
    }
    # endregion

    # region Nevinyrral's Disk
    public class NevinyrralsDiskA : MagicCard
    {
        public NevinyrralsDiskA()
        {
            Name = "Nevinyrral's Disk";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "Nevinyrral�s Disk enters the battlefield tapped.;^%1, %T: Destroy all artifacts, creatures, and enchantments.";
            Flavor = "";
        }
    }
    # endregion

    # region Nightmare
    public class NightmareA : MagicCard
    {
        public NightmareA()
        {
            Name = "Nightmare";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "5B";
            PT = "*/*";
            Type = "Creature - Nightmare Horse";
            Text = "Flying;^Nightmare�s power and toughness are each equal to the number of Swamps you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Northern Paladin
    public class NorthernPaladinA : MagicCard
    {
        public NorthernPaladinA()
        {
            Name = "Northern Paladin";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "2WW";
            PT = "3/3";
            Type = "Creature - Human Knight";
            Text = "%W%W, %T: Destroy target black permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Obsianus Golem
    public class ObsianusGolemA : MagicCard
    {
        public ObsianusGolemA()
        {
            Name = "Obsianus Golem";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "6";
            PT = "4/6";
            Type = "Artifact Creature - Golem";
            Text = "";
            Flavor = "�The foot stone is connected to the ankle stone, the ankle stone is connected to the leg stone...�;^�Song of the Artificer";
        }
    }
    # endregion

    # region Orcish Artillery
    public class OrcishArtilleryA : MagicCard
    {
        public OrcishArtilleryA()
        {
            Name = "Orcish Artillery";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "1RR";
            PT = "1/3";
            Type = "Creature - Orc Warrior";
            Text = "%T: Orcish Artillery deals 2 damage to target creature or player and 3 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Orcish Oriflamme
    public class OrcishOriflammeA : MagicCard
    {
        public OrcishOriflammeA()
        {
            Name = "Orcish Oriflamme";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Enchantment";
            Text = "Attacking creatures you control get +1/+0.";
            Flavor = "";
        }
    }
    # endregion

    # region Paralyze
    public class ParalyzeA : MagicCard
    {
        public ParalyzeA()
        {
            Name = "Paralyze";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^When Paralyze enters the battlefield, tap enchanted creature.;^Enchanted creature doesn�t untap during its controller�s untap step.;^At the beginning of the upkeep of enchanted creature�s controller, that player may pay %4. If he or she does, untap the creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Pearled Unicorn
    public class PearledUnicornA : MagicCard
    {
        public PearledUnicornA()
        {
            Name = "Pearled Unicorn";
            Edition = "A";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Unicorn";
            Text = "";
            Flavor = "� �Do you know, I always thought Unicorns were fabulous monsters, too? I never saw one alive before!� �Well, now that we have seen each other,� said the Unicorn, �if you�ll believe in me, I�ll believe in you.� �;^�Lewis Carroll";
        }
    }
    # endregion

    # region Personal Incarnation
    public class PersonalIncarnationA : MagicCard
    {
        public PersonalIncarnationA()
        {
            Name = "Personal Incarnation";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "3WWW";
            PT = "6/6";
            Type = "Creature - Avatar Incarnation";
            Text = "%0: The next 1 damage that would be dealt to Personal Incarnation this turn is dealt to its owner instead. Any player may activate this ability, but only if he or she owns Personal Incarnation.;^When Personal Incarnation dies, its owner loses half his or her life, rounded up.";
            Flavor = "";
        }
    }
    # endregion

    # region Pestilence
    public class PestilenceA : MagicCard
    {
        public PestilenceA()
        {
            Name = "Pestilence";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "2BB";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of the end step, if no creatures are on the battlefield, sacrifice Pestilence.;^%B: Pestilence deals 1 damage to each creature and each player.";
            Flavor = "";
        }
    }
    # endregion

    # region Phantasmal Forces
    public class PhantasmalForcesA : MagicCard
    {
        public PhantasmalForcesA()
        {
            Name = "Phantasmal Forces";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "4/1";
            Type = "Creature - Illusion";
            Text = "Flying;^At the beginning of your upkeep, sacrifice Phantasmal Forces unless you pay %U.";
            Flavor = "";
        }
    }
    # endregion

    # region Phantasmal Terrain
    public class PhantasmalTerrainA : MagicCard
    {
        public PhantasmalTerrainA()
        {
            Name = "Phantasmal Terrain";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "UU";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land;^As Phantasmal Terrain enters the battlefield, choose a basic land type.;^Enchanted land is the chosen type.";
            Flavor = "";
        }
    }
    # endregion

    # region Phantom Monster
    public class PhantomMonsterA : MagicCard
    {
        public PhantomMonsterA()
        {
            Name = "Phantom Monster";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "3/3";
            Type = "Creature - Illusion";
            Text = "Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Pirate Ship
    public class PirateShipA : MagicCard
    {
        public PirateShipA()
        {
            Name = "Pirate Ship";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "4U";
            PT = "4/3";
            Type = "Creature - Human Pirate";
            Text = "Pirate Ship can�t attack unless defending player controls an Island.;^%T: Pirate Ship deals 1 damage to target creature or player.;^When you control no Islands, sacrifice Pirate Ship.";
            Flavor = "";
        }
    }
    # endregion

    # region Plague Rats
    public class PlagueRatsA : MagicCard
    {
        public PlagueRatsA()
        {
            Name = "Plague Rats";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "*/*";
            Type = "Creature - Rat";
            Text = "Plague Rats�s power and toughness are each equal to the number of creatures named Plague Rats on the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Plains A
    public class PlainsAA : MagicCard
    {
        public PlainsAA()
        {
            Name = "Plains";
            Edition = "A";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Plains";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Plateau
    public class PlateauA : MagicCard
    {
        public PlateauA()
        {
            Name = "Plateau";
            Edition = "A";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Mountain Plains";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Power Leak
    public class PowerLeakA : MagicCard
    {
        public PowerLeakA()
        {
            Name = "Power Leak";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant enchantment;^At the beginning of the upkeep of enchanted enchantment�s controller, that player may pay any amount of mana. Power Leak deals 2 damage to that player. Prevent X of that damage, where X is the amount of mana that player paid this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Power Sink
    public class PowerSinkA : MagicCard
    {
        public PowerSinkA()
        {
            Name = "Power Sink";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "XU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell unless its controller pays %X. If he or she doesn�t, that player taps all lands with mana abilities he or she controls and empties his or her mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Power Surge
    public class PowerSurgeA : MagicCard
    {
        public PowerSurgeA()
        {
            Name = "Power Surge";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "RR";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of each player�s upkeep, Power Surge deals X damage to that player, where X is the number of untapped lands he or she controlled at the beginning of this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Prodigal Sorcerer
    public class ProdigalSorcererA : MagicCard
    {
        public ProdigalSorcererA()
        {
            Name = "Prodigal Sorcerer";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "1/1";
            Type = "Creature - Human Wizard";
            Text = "%T: Prodigal Sorcerer deals 1 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Psionic Blast
    public class PsionicBlastA : MagicCard
    {
        public PsionicBlastA()
        {
            Name = "Psionic Blast";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Instant";
            Text = "Psionic Blast deals 4 damage to target creature or player and 2 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Psychic Venom
    public class PsychicVenomA : MagicCard
    {
        public PsychicVenomA()
        {
            Name = "Psychic Venom";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land;^Whenever enchanted land becomes tapped, Psychic Venom deals 2 damage to that land�s controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Purelace
    public class PurelaceA : MagicCard
    {
        public PurelaceA()
        {
            Name = "Purelace";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Target spell or permanent becomes white. @(Mana symbols on that permanent remain unchanged.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Raging River
    public class RagingRiverA : MagicCard
    {
        public RagingRiverA()
        {
            Name = "Raging River";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "RR";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever one or more creatures you control attack, each defending player divides all creatures without flying he or she controls into a �left� pile and a �right� pile. Then, for each attacking creature you control, choose �left� or �right.� That creature can�t be blocked this combat except by creatures with flying and creatures in a pile with the chosen label.";
            Flavor = "";
        }
    }
    # endregion

    # region Raise Dead
    public class RaiseDeadA : MagicCard
    {
        public RaiseDeadA()
        {
            Name = "Raise Dead";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Sorcery";
            Text = "Return target creature card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Red Elemental Blast
    public class RedElementalBlastA : MagicCard
    {
        public RedElementalBlastA()
        {
            Name = "Red Elemental Blast";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Counter target blue spell; or destroy target blue permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Red Ward
    public class RedWardA : MagicCard
    {
        public RedWardA()
        {
            Name = "Red Ward";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature has protection from red. This effect doesn�t remove Red Ward.";
            Flavor = "";
        }
    }
    # endregion

    # region Regeneration
    public class RegenerationA : MagicCard
    {
        public RegenerationA()
        {
            Name = "Regeneration";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature @(Target a creature as you cast this. This card enters the battlefield attached to that creature.)@;^%G: Regenerate enchanted creature. @(The next time that creature would be destroyed this turn, it isn�t. Instead tap it, remove all damage from it, and remove it from combat.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Regrowth
    public class RegrowthA : MagicCard
    {
        public RegrowthA()
        {
            Name = "Regrowth";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Sorcery";
            Text = "Return target card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Resurrection
    public class ResurrectionA : MagicCard
    {
        public ResurrectionA()
        {
            Name = "Resurrection";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "2WW";
            PT = "";
            Type = "Sorcery";
            Text = "Return target creature card from your graveyard to the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Reverse Damage
    public class ReverseDamageA : MagicCard
    {
        public ReverseDamageA()
        {
            Name = "Reverse Damage";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "1WW";
            PT = "";
            Type = "Instant";
            Text = "The next time a source of your choice would deal damage to you this turn, prevent that damage. You gain life equal to the damage prevented this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Righteousness
    public class RighteousnessA : MagicCard
    {
        public RighteousnessA()
        {
            Name = "Righteousness";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Target blocking creature gets +7/+7 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Roc of Kher Ridges
    public class RocofKherRidgesA : MagicCard
    {
        public RocofKherRidgesA()
        {
            Name = "Roc of Kher Ridges";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "3R";
            PT = "3/3";
            Type = "Creature - Bird";
            Text = "Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Rock Hydra
    public class RockHydraA : MagicCard
    {
        public RockHydraA()
        {
            Name = "Rock Hydra";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "XRR";
            PT = "0/0";
            Type = "Creature - Hydra";
            Text = "Rock Hydra enters the battlefield with X +1/+1 counters on it.;^For each 1 damage that would be dealt to Rock Hydra, if it has a +1/+1 counter on it, remove a +1/+1 counter from it and prevent that 1 damage.;^%R: Prevent the next 1 damage that would be dealt to Rock Hydra this turn.;^%R%R%R: Put a +1/+1 counter on Rock Hydra. Activate this ability only during your upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Rod of Ruin
    public class RodofRuinA : MagicCard
    {
        public RodofRuinA()
        {
            Name = "Rod of Ruin";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T: Rod of Ruin deals 1 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Royal Assassin
    public class RoyalAssassinA : MagicCard
    {
        public RoyalAssassinA()
        {
            Name = "Royal Assassin";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "1BB";
            PT = "1/1";
            Type = "Creature - Human Assassin";
            Text = "%T: Destroy target tapped creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Sacrifice
    public class SacrificeA : MagicCard
    {
        public SacrificeA()
        {
            Name = "Sacrifice";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "As an additional cost to cast Sacrifice, sacrifice a creature.;^Add to your mana pool an amount of %B equal to the sacrificed creature�s converted mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Samite Healer
    public class SamiteHealerA : MagicCard
    {
        public SamiteHealerA()
        {
            Name = "Samite Healer";
            Edition = "A";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "1/1";
            Type = "Creature - Human Cleric";
            Text = "%T: Prevent the next 1 damage that would be dealt to target creature or player this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Savannah
    public class SavannahA : MagicCard
    {
        public SavannahA()
        {
            Name = "Savannah";
            Edition = "A";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Forest Plains";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Savannah Lions
    public class SavannahLionsA : MagicCard
    {
        public SavannahLionsA()
        {
            Name = "Savannah Lions";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "W";
            PT = "2/1";
            Type = "Creature - Cat";
            Text = "";
            Flavor = "The traditional kings of the jungle command a healthy respect in other climates as well. Relying mainly on their stealth and speed, Savannah Lions can take a victim by surprise, even in the endless, flat plains of their homeland.";
        }
    }
    # endregion

    # region Scathe Zombies
    public class ScatheZombiesA : MagicCard
    {
        public ScatheZombiesA()
        {
            Name = "Scathe Zombies";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Zombie";
            Text = "";
            Flavor = "�They groaned, they stirred, they all uprose,/ Nor spake, nor moved their eyes;/ It had been strange, even in a dream,/ To have seen those dead men rise.�/ �Samuel Coleridge, �The Rime of the Ancient Mariner�";
        }
    }
    # endregion

    # region Scavenging Ghoul
    public class ScavengingGhoulA : MagicCard
    {
        public ScavengingGhoulA()
        {
            Name = "Scavenging Ghoul";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "2/2";
            Type = "Creature - Zombie";
            Text = "At the beginning of each end step, put a corpse counter on Scavenging Ghoul for each creature that died this turn.;^Remove a corpse counter from Scavenging Ghoul: Regenerate Scavenging Ghoul.";
            Flavor = "";
        }
    }
    # endregion

    # region Scrubland
    public class ScrublandA : MagicCard
    {
        public ScrublandA()
        {
            Name = "Scrubland";
            Edition = "A";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Plains Swamp";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Scryb Sprites
    public class ScrybSpritesA : MagicCard
    {
        public ScrybSpritesA()
        {
            Name = "Scryb Sprites";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Faerie";
            Text = "Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Sea Serpent
    public class SeaSerpentA : MagicCard
    {
        public SeaSerpentA()
        {
            Name = "Sea Serpent";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "5U";
            PT = "5/5";
            Type = "Creature - Serpent";
            Text = "Sea Serpent can�t attack unless defending player controls an island.;^When you control no islands, sacrifice Sea Serpent.";
            Flavor = "";
        }
    }
    # endregion

    # region Sedge Troll
    public class SedgeTrollA : MagicCard
    {
        public SedgeTrollA()
        {
            Name = "Sedge Troll";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Troll";
            Text = "Sedge Troll gets +1/+1 as long as you control a swamp.;^%B: Regenerate Sedge Troll.";
            Flavor = "";
        }
    }
    # endregion

    # region Sengir Vampire
    public class SengirVampireA : MagicCard
    {
        public SengirVampireA()
        {
            Name = "Sengir Vampire";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "3BB";
            PT = "4/4";
            Type = "Creature - Vampire";
            Text = "Flying;^Whenever a creature dealt damage by Sengir Vampire this turn dies, put a +1/+1 counter on Sengir Vampire.";
            Flavor = "";
        }
    }
    # endregion

    # region Serra Angel
    public class SerraAngelA : MagicCard
    {
        public SerraAngelA()
        {
            Name = "Serra Angel";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "3WW";
            PT = "4/4";
            Type = "Creature - Angel";
            Text = "Flying;^Vigilance @(Attacking doesn�t cause this creature to tap.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Shanodin Dryads
    public class ShanodinDryadsA : MagicCard
    {
        public ShanodinDryadsA()
        {
            Name = "Shanodin Dryads";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Dryad";
            Text = "Forestwalk";
            Flavor = "";
        }
    }
    # endregion

    # region Shatter
    public class ShatterA : MagicCard
    {
        public ShatterA()
        {
            Name = "Shatter";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "Destroy target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Shivan Dragon
    public class ShivanDragonA : MagicCard
    {
        public ShivanDragonA()
        {
            Name = "Shivan Dragon";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "4RR";
            PT = "5/5";
            Type = "Creature - Dragon";
            Text = "Flying;^%R: Shivan Dragon gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Simulacrum
    public class SimulacrumA : MagicCard
    {
        public SimulacrumA()
        {
            Name = "Simulacrum";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Instant";
            Text = "You gain life equal to the damage dealt to you this turn. Simulacrum deals damage to target creature you control equal to the damage dealt to you this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Sinkhole
    public class SinkholeA : MagicCard
    {
        public SinkholeA()
        {
            Name = "Sinkhole";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "BB";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target land.";
            Flavor = "";
        }
    }
    # endregion

    # region Siren's Call
    public class SirensCallA : MagicCard
    {
        public SirensCallA()
        {
            Name = "Siren's Call";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Cast Siren�s Call only during an opponent�s turn, before attackers are declared.;^Creatures the active player controls attack this turn if able.;^At the beginning of the next end step, destroy all non-Wall creatures that player controls that didn�t attack this turn. Ignore this effect for each creature the player didn�t control continuously since the beginning of the turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Sleight of Mind
    public class SleightofMindA : MagicCard
    {
        public SleightofMindA()
        {
            Name = "Sleight of Mind";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Change the text of target spell or permanent by replacing all instances of one color word with another. @(For example, you may change �target black spell� to �target blue spell.� This effect lasts indefinitely.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Smoke
    public class SmokeA : MagicCard
    {
        public SmokeA()
        {
            Name = "Smoke";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "RR";
            PT = "";
            Type = "Enchantment";
            Text = "Players can�t untap more than one creature during their untap steps.";
            Flavor = "";
        }
    }
    # endregion

    # region Sol Ring
    public class SolRingA : MagicCard
    {
        public SolRingA()
        {
            Name = "Sol Ring";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %2 to your mana pool.";
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

    # region Soul Net
    public class SoulNetA : MagicCard
    {
        public SoulNetA()
        {
            Name = "Soul Net";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a creature dies, you may pay %1. If you do, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Spell Blast
    public class SpellBlastA : MagicCard
    {
        public SpellBlastA()
        {
            Name = "Spell Blast";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "XU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell with converted mana cost X. @(For example, if that spell�s mana cost is %3%U%U, X is 5.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Stasis
    public class StasisA : MagicCard
    {
        public StasisA()
        {
            Name = "Stasis";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Enchantment";
            Text = "Players skip their untap steps.;^At the beginning of your upkeep, sacrifice Stasis unless you pay %U.";
            Flavor = "";
        }
    }
    # endregion

    # region Steal Artifact
    public class StealArtifactA : MagicCard
    {
        public StealArtifactA()
        {
            Name = "Steal Artifact";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "2UU";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant artifact;^You control enchanted artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Stone Giant
    public class StoneGiantA : MagicCard
    {
        public StoneGiantA()
        {
            Name = "Stone Giant";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "2RR";
            PT = "3/4";
            Type = "Creature - Giant";
            Text = "%T: Target creature you control with toughness less than Stone Giant�s power gains flying until end of turn. Destroy that creature at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Stone Rain
    public class StoneRainA : MagicCard
    {
        public StoneRainA()
        {
            Name = "Stone Rain";
            Edition = "A";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target land.";
            Flavor = "";
        }
    }
    # endregion

    # region Stream of Life
    public class StreamofLifeA : MagicCard
    {
        public StreamofLifeA()
        {
            Name = "Stream of Life";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "XG";
            PT = "";
            Type = "Sorcery";
            Text = "Target player gains X life.";
            Flavor = "";
        }
    }
    # endregion

    # region Sunglasses of Urza
    public class SunglassesofUrzaA : MagicCard
    {
        public SunglassesofUrzaA()
        {
            Name = "Sunglasses of Urza";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "You may spend white mana as though it were red mana.";
            Flavor = "";
        }
    }
    # endregion

    # region Swamp A
    public class SwampAA : MagicCard
    {
        public SwampAA()
        {
            Name = "Swamp";
            Edition = "A";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Swamp";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Swords to Plowshares
    public class SwordstoPlowsharesA : MagicCard
    {
        public SwordstoPlowsharesA()
        {
            Name = "Swords to Plowshares";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Exile target creature. Its controller gains life equal to its power.";
            Flavor = "";
        }
    }
    # endregion

    # region Taiga
    public class TaigaA : MagicCard
    {
        public TaigaA()
        {
            Name = "Taiga";
            Edition = "A";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Mountain Forest";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Terror
    public class TerrorA : MagicCard
    {
        public TerrorA()
        {
            Name = "Terror";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Instant";
            Text = "Destroy target nonartifact, nonblack creature. It can�t be regenerated.";
            Flavor = "";
        }
    }
    # endregion

    # region The Hive
    public class TheHiveA : MagicCard
    {
        public TheHiveA()
        {
            Name = "The Hive";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "%5, %T: Put a 1/1 colorless Insect artifact creature token with flying named Wasp onto the battlefield. @(It can�t be blocked except by creatures with flying or reach.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Thicket Basilisk
    public class ThicketBasiliskA : MagicCard
    {
        public ThicketBasiliskA()
        {
            Name = "Thicket Basilisk";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "3GG";
            PT = "2/4";
            Type = "Creature - Basilisk";
            Text = "Whenever Thicket Basilisk blocks or becomes blocked by a non-Wall creature, destroy that creature at end of combat.";
            Flavor = "";
        }
    }
    # endregion

    # region Thoughtlace
    public class ThoughtlaceA : MagicCard
    {
        public ThoughtlaceA()
        {
            Name = "Thoughtlace";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Target spell or permanent becomes blue. @(Mana symbols on that permanent remain unchanged.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Throne of Bone
    public class ThroneofBoneA : MagicCard
    {
        public ThroneofBoneA()
        {
            Name = "Throne of Bone";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a player casts a black spell, you may pay %1. If you do, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Timber Wolves
    public class TimberWolvesA : MagicCard
    {
        public TimberWolvesA()
        {
            Name = "Timber Wolves";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Wolf";
            Text = "Banding @(Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding you control are blocking or being blocked by a creature, you divide that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by or is blocking.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Time Vault
    public class TimeVaultA : MagicCard
    {
        public TimeVaultA()
        {
            Name = "Time Vault";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Time Vault enters the battlefield tapped.;^Time Vault doesn�t untap during your untap step.;^If you would begin your turn while Time Vault is tapped, you may skip that turn instead. If you do, untap Time Vault.;^%T: Take an extra turn after this one.";
            Flavor = "";
        }
    }
    # endregion

    # region Time Walk
    public class TimeWalkA : MagicCard
    {
        public TimeWalkA()
        {
            Name = "Time Walk";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Sorcery";
            Text = "Take an extra turn after this one.";
            Flavor = "";
        }
    }
    # endregion

    # region Timetwister
    public class TimetwisterA : MagicCard
    {
        public TimetwisterA()
        {
            Name = "Timetwister";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Sorcery";
            Text = "Each player shuffles his or her hand and graveyard into his or her library, then draws seven cards. @(Then put Timetwister into its owner�s graveyard.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Tranquility
    public class TranquilityA : MagicCard
    {
        public TranquilityA()
        {
            Name = "Tranquility";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy all enchantments.";
            Flavor = "";
        }
    }
    # endregion

    # region Tropical Island
    public class TropicalIslandA : MagicCard
    {
        public TropicalIslandA()
        {
            Name = "Tropical Island";
            Edition = "A";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Forest Island";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Tsunami
    public class TsunamiA : MagicCard
    {
        public TsunamiA()
        {
            Name = "Tsunami";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy all islands.";
            Flavor = "";
        }
    }
    # endregion

    # region Tundra
    public class TundraA : MagicCard
    {
        public TundraA()
        {
            Name = "Tundra";
            Edition = "A";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Plains Island";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Tunnel
    public class TunnelA : MagicCard
    {
        public TunnelA()
        {
            Name = "Tunnel";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Destroy target Wall. It can�t be regenerated.";
            Flavor = "";
        }
    }
    # endregion

    # region Twiddle
    public class TwiddleA : MagicCard
    {
        public TwiddleA()
        {
            Name = "Twiddle";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "You may tap or untap target artifact, creature, or land.";
            Flavor = "";
        }
    }
    # endregion

    # region Two-Headed Giant of Foriys
    public class TwoHeadedGiantofForiysA : MagicCard
    {
        public TwoHeadedGiantofForiysA()
        {
            Name = "Two-Headed Giant of Foriys";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "4R";
            PT = "4/4";
            Type = "Creature - Giant";
            Text = "Trample;^Two-Headed Giant of Foriys can block an additional creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Underground Sea
    public class UndergroundSeaA : MagicCard
    {
        public UndergroundSeaA()
        {
            Name = "Underground Sea";
            Edition = "A";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Island Swamp";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Unholy Strength
    public class UnholyStrengthA : MagicCard
    {
        public UnholyStrengthA()
        {
            Name = "Unholy Strength";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +2/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Unsummon
    public class UnsummonA : MagicCard
    {
        public UnsummonA()
        {
            Name = "Unsummon";
            Edition = "A";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Return target creature to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Uthden Troll
    public class UthdenTrollA : MagicCard
    {
        public UthdenTrollA()
        {
            Name = "Uthden Troll";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Troll";
            Text = "%R: Regenerate Uthden Troll.";
            Flavor = "";
        }
    }
    # endregion

    # region Verduran Enchantress
    public class VerduranEnchantressA : MagicCard
    {
        public VerduranEnchantressA()
        {
            Name = "Verduran Enchantress";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "1GG";
            PT = "0/2";
            Type = "Creature - Human Druid";
            Text = "Whenever you cast an enchantment spell, you may draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Vesuvan Doppelganger
    public class VesuvanDoppelgangerA : MagicCard
    {
        public VesuvanDoppelgangerA()
        {
            Name = "Vesuvan Doppelganger";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "3UU";
            PT = "0/0";
            Type = "Creature - Shapeshifter";
            Text = "You may have Vesuvan Doppelganger enter the battlefield as a copy of any creature on the battlefield except it doesn�t copy that creature�s color and it gains �At the beginning of your upkeep, you may have this creature become a copy of target creature except it doesn�t copy that creature�s color. If you do, this creature gains this ability.�";
            Flavor = "";
        }
    }
    # endregion

    # region Veteran Bodyguard
    public class VeteranBodyguardA : MagicCard
    {
        public VeteranBodyguardA()
        {
            Name = "Veteran Bodyguard";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "3WW";
            PT = "2/5";
            Type = "Creature - Human";
            Text = "As long as Veteran Bodyguard is untapped, all damage that would be dealt to you by unblocked creatures is dealt to Veteran Bodyguard instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Volcanic Eruption
    public class VolcanicEruptionA : MagicCard
    {
        public VolcanicEruptionA()
        {
            Name = "Volcanic Eruption";
            Edition = "A";
            Rarity = "R";
            Color = "U";
            Cost = "XUUU";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy X target Mountains. Volcanic Eruption deals damage to each creature and each player equal to the number of Mountains put into a graveyard this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Air
    public class WallofAirA : MagicCard
    {
        public WallofAirA()
        {
            Name = "Wall of Air";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "1UU";
            PT = "1/5";
            Type = "Creature - Wall";
            Text = "Defender, flying @(This creature can�t attack, and it can block creatures with flying.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Bone
    public class WallofBoneA : MagicCard
    {
        public WallofBoneA()
        {
            Name = "Wall of Bone";
            Edition = "A";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "1/4";
            Type = "Creature - Skeleton Wall";
            Text = "Defender @(This creature can�t attack.)@;^%B: Regenerate Wall of Bone. @(The next time this creature would be destroyed this turn, it isn�t. Instead tap it, remove all damage from it, and remove it from combat.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Brambles
    public class WallofBramblesA : MagicCard
    {
        public WallofBramblesA()
        {
            Name = "Wall of Brambles";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "2/3";
            Type = "Creature - Plant Wall";
            Text = "Defender @(This creature can�t attack.)@;^%G: Regenerate Wall of Brambles.";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Fire
    public class WallofFireA : MagicCard
    {
        public WallofFireA()
        {
            Name = "Wall of Fire";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "1RR";
            PT = "0/5";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@;^%R: Wall of Fire gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Ice
    public class WallofIceA : MagicCard
    {
        public WallofIceA()
        {
            Name = "Wall of Ice";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "0/7";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Stone
    public class WallofStoneA : MagicCard
    {
        public WallofStoneA()
        {
            Name = "Wall of Stone";
            Edition = "A";
            Rarity = "U";
            Color = "R";
            Cost = "1RR";
            PT = "0/8";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Swords
    public class WallofSwordsA : MagicCard
    {
        public WallofSwordsA()
        {
            Name = "Wall of Swords";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "3/5";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack)@;^Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Water
    public class WallofWaterA : MagicCard
    {
        public WallofWaterA()
        {
            Name = "Wall of Water";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "1UU";
            PT = "0/5";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@;^%U: Wall of Water gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Wood
    public class WallofWoodA : MagicCard
    {
        public WallofWoodA()
        {
            Name = "Wall of Wood";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "0/3";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wanderlust
    public class WanderlustA : MagicCard
    {
        public WanderlustA()
        {
            Name = "Wanderlust";
            Edition = "A";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^At the beginning of the upkeep of enchanted creature�s controller, Wanderlust deals 1 damage to that player.";
            Flavor = "";
        }
    }
    # endregion

    # region War Mammoth
    public class WarMammothA : MagicCard
    {
        public WarMammothA()
        {
            Name = "War Mammoth";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "3/3";
            Type = "Creature - Elephant";
            Text = "Trample";
            Flavor = "";
        }
    }
    # endregion

    # region Warp Artifact
    public class WarpArtifactA : MagicCard
    {
        public WarpArtifactA()
        {
            Name = "Warp Artifact";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "BB";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant artifact;^At the beginning of the upkeep of enchanted artifact�s controller, Warp Artifact deals 1 damage to that player.";
            Flavor = "";
        }
    }
    # endregion

    # region Water Elemental
    public class WaterElementalA : MagicCard
    {
        public WaterElementalA()
        {
            Name = "Water Elemental";
            Edition = "A";
            Rarity = "U";
            Color = "U";
            Cost = "3UU";
            PT = "5/4";
            Type = "Creature - Elemental";
            Text = "";
            Flavor = "Unpredictable as the sea itself, Water Elementals shift without warning from tranquility to tempest. Capricious and fickle, they flow restlessly from one shape to another, expressing their moods with their physical forms.";
        }
    }
    # endregion

    # region Weakness
    public class WeaknessA : MagicCard
    {
        public WeaknessA()
        {
            Name = "Weakness";
            Edition = "A";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets -2/-1.";
            Flavor = "";
        }
    }
    # endregion

    # region Web
    public class WebA : MagicCard
    {
        public WebA()
        {
            Name = "Web";
            Edition = "A";
            Rarity = "R";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature @(Target a creature as you cast this. This card enters the battlefield attached to that creature.)@;^Enchanted creature gets +0/+2 and has reach. @(It can block creatures with flying.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wheel of Fortune
    public class WheelofFortuneA : MagicCard
    {
        public WheelofFortuneA()
        {
            Name = "Wheel of Fortune";
            Edition = "A";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Sorcery";
            Text = "Each player discards his or her hand and draws seven cards.";
            Flavor = "";
        }
    }
    # endregion

    # region White Knight
    public class WhiteKnightA : MagicCard
    {
        public WhiteKnightA()
        {
            Name = "White Knight";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "WW";
            PT = "2/2";
            Type = "Creature - Human Knight";
            Text = "First strike @(This creature deals combat damage before creatures without first strike.)@;^Protection from black @(This creature can�t be blocked, targeted, dealt damage, or enchanted by anything black.)@";
            Flavor = "";
        }
    }
    # endregion

    # region White Ward
    public class WhiteWardA : MagicCard
    {
        public WhiteWardA()
        {
            Name = "White Ward";
            Edition = "A";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature has protection from white. This effect doesn�t remove White Ward.";
            Flavor = "";
        }
    }
    # endregion

    # region Wild Growth
    public class WildGrowthA : MagicCard
    {
        public WildGrowthA()
        {
            Name = "Wild Growth";
            Edition = "A";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land;^Whenever enchanted land is tapped for mana, its controller adds %G to his or her mana pool @(in addition to the mana the land produces)@.";
            Flavor = "";
        }
    }
    # endregion

    # region Will-o'-the-Wisp
    public class WillotheWispA : MagicCard
    {
        public WillotheWispA()
        {
            Name = "Will-o'-the-Wisp";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "B";
            PT = "0/1";
            Type = "Creature - Spirit";
            Text = "Flying @(This creature can�t be blocked except by creatures with flying or reach.)@;^%B: Regenerate Will-o�-the-Wisp. @(The next time this creature would be destroyed this turn, it isn�t. Instead tap it, remove all damage from it, and remove it from combat.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Winter Orb
    public class WinterOrbA : MagicCard
    {
        public WinterOrbA()
        {
            Name = "Winter Orb";
            Edition = "A";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Players can�t untap more than one land during their untap steps.";
            Flavor = "";
        }
    }
    # endregion

    # region Wooden Sphere
    public class WoodenSphereA : MagicCard
    {
        public WoodenSphereA()
        {
            Name = "Wooden Sphere";
            Edition = "A";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a player casts a green spell, you may pay %1. If you do, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Word of Command
    public class WordofCommandA : MagicCard
    {
        public WordofCommandA()
        {
            Name = "Word of Command";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "BB";
            PT = "";
            Type = "Instant";
            Text = "Look at target opponent�s hand and choose a card from it. You control that player until Word of Command finishes resolving. The player plays that card if able. While doing so, the player can activate mana abilities only if they�re from lands he or she controls and only if mana they produce is spent to activate other mana abilities of lands he or she controls and/or play that card. If the chosen card is cast as a spell, you control the player while that spell is resolving.";
            Flavor = "";
        }
    }
    # endregion

    # region Wrath of God
    public class WrathofGodA : MagicCard
    {
        public WrathofGodA()
        {
            Name = "Wrath of God";
            Edition = "A";
            Rarity = "R";
            Color = "W";
            Cost = "2WW";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy all creatures. They can�t be regenerated.";
            Flavor = "";
        }
    }
    # endregion

    # region Zombie Master
    public class ZombieMasterA : MagicCard
    {
        public ZombieMasterA()
        {
            Name = "Zombie Master";
            Edition = "A";
            Rarity = "R";
            Color = "B";
            Cost = "1BB";
            PT = "2/3";
            Type = "Creature - Zombie";
            Text = "Other Zombie creatures have swampwalk.;^Other Zombies have �%B: Regenerate this permanent.�";
            Flavor = "";
        }
    }
    # endregion
    # endregion

    # region 4th Edition

    # endregion

    # region 5th Edition

    # endregion

    # region Magic 2014
    # region Academy Raider
    public class AcademyRaider : MagicCard
    {
        public AcademyRaider()
        {
            Name = "Academy Raider";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "1/1";
            Type = "Creature - Human Warrior";
            Text = "Intimidate @(This creature can�t be blocked except by artifact creatures and/or creatures that share a color with it.)@;^Whenever Academy Raider deals combat damage to a player, you may discard a card. If you do, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Accorder's Shield
    public class AccordersShield : MagicCard
    {
        public AccordersShield()
        {
            Name = "Accorder's Shield";
            Edition = "M14";
            Rarity = "U";
            Color = "Art";
            Cost = "0";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +0/+3 and has vigilance. @(Attacking doesn�t cause it to tap.)@;^Equip %3 @(%3: Attach to target creature you control. Equip only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Accursed Spirit
    public class AccursedSpirit : MagicCard
    {
        public AccursedSpirit()
        {
            Name = "Accursed Spirit";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "3/2";
            Type = "Creature - Spirit";
            Text = "Intimidate @(This creature can�t be blocked except by artifact creatures and/or creatures that share a color with it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Act of Treason
    public class ActofTreasonM14 : MagicCard
    {
        public ActofTreasonM14()
        {
            Name = "Act of Treason";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Sorcery";
            Text = "Gain control of target creature until end of turn. Untap that creature. It gains haste until end of turn. @(It can attack and %T this turn.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Advocate of the Beast
    public class AdvocateoftheBeast : MagicCard
    {
        public AdvocateoftheBeast()
        {
            Name = "Advocate of the Beast";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "2/3";
            Type = "Creature - Elf Shaman";
            Text = "At the beginning of your end step, put a +1/+1 counter on target Beast creature you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Air Servant
    public class AirServant : MagicCard
    {
        public AirServant()
        {
            Name = "Air Servant";
            Edition = "M14";
            Rarity = "U";
            Color = "U";
            Cost = "4U";
            PT = "4/3";
            Type = "Creature - Elemental";
            Text = "Flying;^%2%U: Tap target creature with flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Ajani, Caller of the Pride
    public class AjaniCallerofthePride : MagicCard
    {
        public AjaniCallerofthePride()
        {
            Name = "Ajani, Caller of the Pride";
            Edition = "M14";
            Rarity = "M";
            Color = "W";
            Cost = "1WW";
            PT = "%4/";
            Type = "Planeswalker - Ajani";
            Text = "+1: Put a +1/+1 counter on up to one target creature.;^-3: Target creature gains flying and double strike until end of turn.;^-8: Put X 2/2 white Cat creature tokens onto the battlefield, where X is your life total.";
            Flavor = "";
        }
    }
    # endregion

    # region Ajani's Chosen
    public class AjanisChosen : MagicCard
    {
        public AjanisChosen()
        {
            Name = "Ajani's Chosen";
            Edition = "M14";
            Rarity = "R";
            Color = "W";
            Cost = "2WW";
            PT = "3/3";
            Type = "Creature - Cat Soldier";
            Text = "Whenever an enchantment enters the battlefield under your control, put a 2/2 white Cat creature token onto the battlefield. If that enchantment is an Aura, you may attach it to the token.";
            Flavor = "";
        }
    }
    # endregion

    # region Altar's Reap
    public class AltarsReap : MagicCard
    {
        public AltarsReap()
        {
            Name = "Altar's Reap";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Instant";
            Text = "As an additional cost to cast Altar�s Reap, sacrifice a creature.;^Draw two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Angelic Accord
    public class AngelicAccord : MagicCard
    {
        public AngelicAccord()
        {
            Name = "Angelic Accord";
            Edition = "M14";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of each end step, if you gained 4 or more life this turn, put a 4/4 white Angel creature token with flying onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Angelic Wall
    public class AngelicWall : MagicCard
    {
        public AngelicWall()
        {
            Name = "Angelic Wall";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "0/4";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@;^Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Archaeomancer
    public class Archaeomancer : MagicCard
    {
        public Archaeomancer()
        {
            Name = "Archaeomancer";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "2UU";
            PT = "1/2";
            Type = "Creature - Human Wizard";
            Text = "When Archaeomancer enters the battlefield, return target instant or sorcery card from your graveyard to your hand.";
            Flavor = "";
        }

        public override void Resolve()
        {
            List<MagicCard> cards = PArea._graveyard.cards.Where(o => o.Type.Contains("Instant") || o.Type.Contains("Sorcery")).ToList();
            PArea.callPickCards(cards);
        }
    }
    # endregion

    # region Archangel of Thune
    public class ArchangelofThune : MagicCard
    {
        public ArchangelofThune()
        {
            Name = "Archangel of Thune";
            Edition = "M14";
            Rarity = "M";
            Color = "W";
            Cost = "3WW";
            PT = "3/4";
            Type = "Creature - Angel";
            Text = "Flying;^Lifelink @(Damage dealt by this creature also causes you to gain that much life.)@;^Whenever you gain life, put a +1/+1 counter on each creature you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Armored Cancrix
    public class ArmoredCancrix : MagicCard
    {
        public ArmoredCancrix()
        {
            Name = "Armored Cancrix";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "4U";
            PT = "2/5";
            Type = "Creature - Crab";
            Text = "";
            Flavor = "Creatures displaced from time still turn up every year, stranded by the temporal disaster that once swept across Dominaria.";
        }
    }
    # endregion

    # region Artificer's Hex
    public class ArtificersHex : MagicCard
    {
        public ArtificersHex()
        {
            Name = "Artificer's Hex";
            Edition = "M14";
            Rarity = "U";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant Equipment;^At the beginning of your upkeep, if enchanted Equipment is attached to a creature, destroy that creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Auramancer
    public class Auramancer : MagicCard
    {
        public Auramancer()
        {
            Name = "Auramancer";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Human Wizard";
            Text = "When Auramancer enters the battlefield, you may return target enchantment card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Awaken the Ancient
    public class AwakentheAncient : MagicCard
    {
        public AwakentheAncient()
        {
            Name = "Awaken the Ancient";
            Edition = "M14";
            Rarity = "R";
            Color = "R";
            Cost = "1RRR";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant Mountain;^Enchanted Mountain is a 7/7 red Giant creature with haste. It�s still a land.";
            Flavor = "";
        }
    }
    # endregion

    # region Banisher Priest
    public class BanisherPriest : MagicCard
    {
        public BanisherPriest()
        {
            Name = "Banisher Priest";
            Edition = "M14";
            Rarity = "U";
            Color = "W";
            Cost = "1WW";
            PT = "2/2";
            Type = "Creature - Human Cleric";
            Text = "When Banisher Priest enters the battlefield, exile target creature an opponent controls until Banisher Priest leaves the battlefield. @(That creature returns under its owner�s control.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Barrage of Expendables
    public class BarrageofExpendables : MagicCard
    {
        public BarrageofExpendables()
        {
            Name = "Barrage of Expendables";
            Edition = "M14";
            Rarity = "U";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Enchantment";
            Text = "%R, Sacrifice a creature: Barrage of Expendables deals 1 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Battle Sliver
    public class BattleSliver : MagicCard
    {
        public BattleSliver()
        {
            Name = "Battle Sliver";
            Edition = "M14";
            Rarity = "U";
            Color = "R";
            Cost = "4R";
            PT = "3/3";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control get +2/+0.";
            Flavor = "";
        }
    }
    # endregion

    # region Blessing
    public class BlessingM14 : MagicCard
    {
        public BlessingM14()
        {
            Name = "Blessing";
            Edition = "M14";
            Rarity = "U";
            Color = "W";
            Cost = "WW";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^%W: Enchanted creature gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Blightcaster
    public class Blightcaster : MagicCard
    {
        public Blightcaster()
        {
            Name = "Blightcaster";
            Edition = "M14";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "2/3";
            Type = "Creature - Human Wizard";
            Text = "Whenever you cast an enchantment spell, you may have target creature get -2/-2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Blood Bairn
    public class BloodBairn : MagicCard
    {
        public BloodBairn()
        {
            Name = "Blood Bairn";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Vampire";
            Text = "Sacrifice another creature: Blood Bairn gets +2/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Blur Sliver
    public class BlurSliver : MagicCard
    {
        public BlurSliver()
        {
            Name = "Blur Sliver";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control have haste. @(They can attack and %T as soon as they come under your control.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Bogbrew Witch
    public class BogbrewWitch : MagicCard
    {
        public BogbrewWitch()
        {
            Name = "Bogbrew Witch";
            Edition = "M14";
            Rarity = "R";
            Color = "B";
            Cost = "3B";
            PT = "1/3";
            Type = "Creature - Human Wizard";
            Text = "%2, %T: Search your library for a card named Festering Newt or Bubbling Cauldron, put it onto the battlefield tapped, then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Bonescythe Sliver
    public class BonescytheSliver : MagicCard
    {
        public BonescytheSliver()
        {
            Name = "Bonescythe Sliver";
            Edition = "M14";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "2/2";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control have double strike. @(They deal both first-strike and regular combat damage.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Bramblecrush
    public class Bramblecrush : MagicCard
    {
        public Bramblecrush()
        {
            Name = "Bramblecrush";
            Edition = "M14";
            Rarity = "U";
            Color = "G";
            Cost = "2GG";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target noncreature permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Brave the Elements
    public class BravetheElements : MagicCard
    {
        public BravetheElements()
        {
            Name = "Brave the Elements";
            Edition = "M14";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Choose a color. White creatures you control gain protection from the chosen color until end of turn. @(They can�t be blocked, targeted, dealt damage, or enchanted by anything of that color.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Briarpack Alpha
    public class BriarpackAlpha : MagicCard
    {
        public BriarpackAlpha()
        {
            Name = "Briarpack Alpha";
            Edition = "M14";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "3/3";
            Type = "Creature - Wolf";
            Text = "Flash @(You may cast this spell any time you could cast an instant.)@;^When Briarpack Alpha enters the battlefield, target creature gets +2/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Brindle Boar
    public class BrindleBoar : MagicCard
    {
        public BrindleBoar()
        {
            Name = "Brindle Boar";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Boar";
            Text = "Sacrifice Brindle Boar: You gain 4 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Bubbling Cauldron
    public class BubblingCauldron : MagicCard
    {
        public BubblingCauldron()
        {
            Name = "Bubbling Cauldron";
            Edition = "M14";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%1, %T, Sacrifice a creature: You gain 4 life.;^%1, %T, Sacrifice a creature named Festering Newt: Each opponent loses 4 life. You gain life equal to the life lost this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Burning Earth
    public class BurningEarth : MagicCard
    {
        public BurningEarth()
        {
            Name = "Burning Earth";
            Edition = "M14";
            Rarity = "R";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a player taps a nonbasic land for mana, Burning Earth deals 1 damage to that player.";
            Flavor = "";
        }
    }
    # endregion

    # region Cancel
    public class CancelM14 : MagicCard
    {
        public CancelM14()
        {
            Name = "Cancel";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "1UU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Canyon Minotaur
    public class CanyonMinotaur : MagicCard
    {
        public CanyonMinotaur()
        {
            Name = "Canyon Minotaur";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "3/3";
            Type = "Creature - Minotaur Warrior";
            Text = "";
            Flavor = "�We�ll scale these cliffs, traverse Brittle Bridge, and then fight our way down the volcanic slopes on the other side.�;^�Isn�t the shortest route through the canyon?�;^�Yes.�;^�So shouldn�t we��;^�No.�";
        }
    }
    # endregion

    # region Capashen Knight
    public class CapashenKnight : MagicCard
    {
        public CapashenKnight()
        {
            Name = "Capashen Knight";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "1/1";
            Type = "Creature - Human Knight";
            Text = "First strike @(This creature deals combat damage before creatures without first strike.)@;^%1%W: Capashen Knight gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Celestial Flare
    public class CelestialFlare : MagicCard
    {
        public CelestialFlare()
        {
            Name = "Celestial Flare";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "WW";
            PT = "";
            Type = "Instant";
            Text = "Target player sacrifices an attacking or blocking creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Chandra, Pyromaster
    public class ChandraPyromaster : MagicCard
    {
        public ChandraPyromaster()
        {
            Name = "Chandra, Pyromaster";
            Edition = "M14";
            Rarity = "M";
            Color = "R";
            Cost = "2RR";
            PT = "%4/";
            Type = "Planeswalker - Chandra";
            Text = "+1: Chandra, Pyromaster deals 1 damage to target player and 1 damage to up to one target creature that player controls. That creature can�t block this turn.;^0: Exile the top card of your library. You may play it this turn.;^-7: Exile the top ten cards of your library. Choose an instant or sorcery card exiled this way and copy it three times. You may cast the copies without paying their mana costs.";
            Flavor = "";
        }
    }
    # endregion

    # region Chandra's Outrage
    public class ChandrasOutrage : MagicCard
    {
        public ChandrasOutrage()
        {
            Name = "Chandra's Outrage";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "2RR";
            PT = "";
            Type = "Instant";
            Text = "Chandra�s Outrage deals 4 damage to target creature and 2 damage to that creature�s controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Chandra's Phoenix
    public class ChandrasPhoenix : MagicCard
    {
        public ChandrasPhoenix()
        {
            Name = "Chandra's Phoenix";
            Edition = "M14";
            Rarity = "R";
            Color = "R";
            Cost = "1RR";
            PT = "2/2";
            Type = "Creature - Phoenix";
            Text = "Flying;^Haste @(This creature can attack and %T as soon as it comes under your control.)@;^Whenever an opponent is dealt damage by a red instant or sorcery spell you control or by a red planeswalker you control, return Chandra�s Phoenix from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Charging Griffin
    public class ChargingGriffin : MagicCard
    {
        public ChargingGriffin()
        {
            Name = "Charging Griffin";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "2/2";
            Type = "Creature - Griffin";
            Text = "Flying;^Whenever Charging Griffin attacks, it gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Child of Night
    public class ChildofNight : MagicCard
    {
        public ChildofNight()
        {
            Name = "Child of Night";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "2/1";
            Type = "Creature - Vampire";
            Text = "Lifelink @(Damage dealt by this creature also causes you to gain that much life.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Claustrophobia
    public class Claustrophobia : MagicCard
    {
        public Claustrophobia()
        {
            Name = "Claustrophobia";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "1UU";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^When Claustrophobia enters the battlefield, tap enchanted creature.;^Enchanted creature doesn�t untap during its controller�s untap step.";
            Flavor = "";
        }
    }
    # endregion

    # region Clone
    public class CloneM14 : MagicCard
    {
        public CloneM14()
        {
            Name = "Clone";
            Edition = "M14";
            Rarity = "R";
            Color = "U";
            Cost = "3U";
            PT = "0/0";
            Type = "Creature - Shapeshifter";
            Text = "You may have Clone enter the battlefield as a copy of any creature on the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Colossal Whale
    public class ColossalWhale : MagicCard
    {
        public ColossalWhale()
        {
            Name = "Colossal Whale";
            Edition = "M14";
            Rarity = "R";
            Color = "U";
            Cost = "5UU";
            PT = "5/5";
            Type = "Creature - Whale";
            Text = "Islandwalk @(This creature can�t be blocked as long as defending player controls an Island.)@;^Whenever Colossal Whale attacks, you may exile target creature defending player controls until Colossal Whale leaves the battlefield. @(That creature returns under its owner�s control.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Congregate
    public class Congregate : MagicCard
    {
        public Congregate()
        {
            Name = "Congregate";
            Edition = "M14";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Instant";
            Text = "Target player gains 2 life for each creature on the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Coral Merfolk
    public class CoralMerfolk : MagicCard
    {
        public CoralMerfolk()
        {
            Name = "Coral Merfolk";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "2/1";
            Type = "Creature - Merfolk";
            Text = "";
            Flavor = "Early sailors thought they were tricks of the mind or perhaps manatees. As more and more ships were public classified as lost to �manatee attacks,� the truth began to dawn.";
        }
    }
    # endregion

    # region Corpse Hauler
    public class CorpseHauler : MagicCard
    {
        public CorpseHauler()
        {
            Name = "Corpse Hauler";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "2/1";
            Type = "Creature - Human Rogue";
            Text = "%2%B, Sacrifice Corpse Hauler: Return another target creature card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Corrupt
    public class Corrupt : MagicCard
    {
        public Corrupt()
        {
            Name = "Corrupt";
            Edition = "M14";
            Rarity = "U";
            Color = "B";
            Cost = "5B";
            PT = "";
            Type = "Sorcery";
            Text = "Corrupt deals damage equal to the number of Swamps you control to target creature or player. You gain life equal to the damage dealt this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Cyclops Tyrant
    public class CyclopsTyrant : MagicCard
    {
        public CyclopsTyrant()
        {
            Name = "Cyclops Tyrant";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "5R";
            PT = "3/4";
            Type = "Creature - Cyclops";
            Text = "Intimidate @(This creature can�t be blocked except by artifact creatures and/or creatures that share a color with it.)@;^Cyclops Tyrant can�t block creatures with power 2 or less.";
            Flavor = "";
        }
    }
    # endregion

    # region Dark Favor
    public class DarkFavor : MagicCard
    {
        public DarkFavor()
        {
            Name = "Dark Favor";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^When Dark Favor enters the battlefield, you lose 1 life.;^Enchanted creature gets +3/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Dark Prophecy
    public class DarkProphecy : MagicCard
    {
        public DarkProphecy()
        {
            Name = "Dark Prophecy";
            Edition = "M14";
            Rarity = "R";
            Color = "B";
            Cost = "BBB";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a creature you control dies, you draw a card and lose 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Darksteel Forge
    public class DarksteelForge : MagicCard
    {
        public DarksteelForge()
        {
            Name = "Darksteel Forge";
            Edition = "M14";
            Rarity = "M";
            Color = "Art";
            Cost = "9";
            PT = "";
            Type = "Artifact";
            Text = "Artifacts you control have indestructible. @(Effects that say �destroy� don�t destroy them. Artifact creatures with indestructible can�t be destroyed by damage.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Darksteel Ingot
    public class DarksteelIngot : MagicCard
    {
        public DarksteelIngot()
        {
            Name = "Darksteel Ingot";
            Edition = "M14";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Indestructible @(Effects that say �destroy� don�t destroy this artifact.)@;^%T: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Dawnstrike Paladin
    public class DawnstrikePaladin : MagicCard
    {
        public DawnstrikePaladin()
        {
            Name = "Dawnstrike Paladin";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "3WW";
            PT = "2/4";
            Type = "Creature - Human Knight";
            Text = "Vigilance @(Attacking doesn�t cause this creature to tap.)@;^Lifelink @(Damage dealt by this creature also causes you to gain that much life.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Deadly Recluse
    public class DeadlyRecluse : MagicCard
    {
        public DeadlyRecluse()
        {
            Name = "Deadly Recluse";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "1/2";
            Type = "Creature - Spider";
            Text = "Reach @(This creature can block creatures with flying.)@;^Deathtouch @(Any amount of damage this deals to a creature is enough to destroy it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Deathgaze Cockatrice
    public class DeathgazeCockatrice : MagicCard
    {
        public DeathgazeCockatrice()
        {
            Name = "Deathgaze Cockatrice";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "2BB";
            PT = "2/2";
            Type = "Creature - Cockatrice";
            Text = "Flying;^Deathtouch @(Any amount of damage this deals to a creature is enough to destroy it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Demolish
    public class DemolishM14 : MagicCard
    {
        public DemolishM14()
        {
            Name = "Demolish";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target artifact or land.";
            Flavor = "";
        }
    }
    # endregion

    # region Devout Invocation
    public class DevoutInvocation : MagicCard
    {
        public DevoutInvocation()
        {
            Name = "Devout Invocation";
            Edition = "M14";
            Rarity = "M";
            Color = "W";
            Cost = "6W";
            PT = "";
            Type = "Sorcery";
            Text = "Tap any number of untapped creatures you control. Put a 4/4 white Angel creature token with flying onto the battlefield for each creature tapped this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Diabolic Tutor
    public class DiabolicTutor : MagicCard
    {
        public DiabolicTutor()
        {
            Name = "Diabolic Tutor";
            Edition = "M14";
            Rarity = "U";
            Color = "B";
            Cost = "2BB";
            PT = "";
            Type = "Sorcery";
            Text = "Search your library for a card and put that card into your hand. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Dismiss into Dream
    public class DismissintoDream : MagicCard
    {
        public DismissintoDream()
        {
            Name = "Dismiss into Dream";
            Edition = "M14";
            Rarity = "R";
            Color = "U";
            Cost = "6U";
            PT = "";
            Type = "Enchantment";
            Text = "Each creature your opponents control is an Illusion in addition to its other types and has �When this creature becomes the target of a spell or ability, sacrifice it.�";
            Flavor = "";
        }
    }
    # endregion

    # region Disperse
    public class Disperse : MagicCard
    {
        public Disperse()
        {
            Name = "Disperse";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Return target nonland permanent to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Divination
    public class DivinationM14 : MagicCard
    {
        public DivinationM14()
        {
            Name = "Divination";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Sorcery";
            Text = "Draw two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Divine Favor
    public class DivineFavor : MagicCard
    {
        public DivineFavor()
        {
            Name = "Divine Favor";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^When Divine Favor enters the battlefield, you gain 3 life.;^Enchanted creature gets +1/+3.";
            Flavor = "";
        }
    }
    # endregion

    # region Domestication
    public class Domestication : MagicCard
    {
        public Domestication()
        {
            Name = "Domestication";
            Edition = "M14";
            Rarity = "R";
            Color = "U";
            Cost = "2UU";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^You control enchanted creature.;^At the beginning of your end step, if enchanted creature�s power is 4 or greater, sacrifice Domestication.";
            Flavor = "";
        }
    }
    # endregion

    # region Doom Blade
    public class DoomBlade : MagicCard
    {
        public DoomBlade()
        {
            Name = "Doom Blade";
            Edition = "M14";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Instant";
            Text = "Destroy target nonblack creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Door of Destinies
    public class DoorofDestinies : MagicCard
    {
        public DoorofDestinies()
        {
            Name = "Door of Destinies";
            Edition = "M14";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "As Door of Destinies enters the battlefield, choose a creature type.;^Whenever you cast a spell of the chosen type, put a charge counter on Door of Destinies.;^Creatures you control of the chosen type get +1/+1 for each charge counter on Door of Destinies.";
            Flavor = "";
        }
    }
    # endregion

    # region Dragon Egg
    public class DragonEgg : MagicCard
    {
        public DragonEgg()
        {
            Name = "Dragon Egg";
            Edition = "M14";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "0/2";
            Type = "Creature - Dragon";
            Text = "Defender @(This creature can�t attack.)@;^When Dragon Egg dies, put a 2/2 red Dragon creature token with flying onto the battlefield. It has �%R: This creature gets +1/+0 until end of turn.�";
            Flavor = "";
        }
    }
    # endregion

    # region Dragon Hatchling
    public class DragonHatchling : MagicCard
    {
        public DragonHatchling()
        {
            Name = "Dragon Hatchling";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "0/1";
            Type = "Creature - Dragon";
            Text = "Flying;^%R: Dragon Hatchling gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Duress
    public class Duress : MagicCard
    {
        public Duress()
        {
            Name = "Duress";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Sorcery";
            Text = "Target opponent reveals his or her hand. You choose a noncreature, nonland card from it. That player discards that card.";
            Flavor = "";
        }
    }
    # endregion

    # region Elite Arcanist
    public class EliteArcanist : MagicCard
    {
        public EliteArcanist()
        {
            Name = "Elite Arcanist";
            Edition = "M14";
            Rarity = "R";
            Color = "U";
            Cost = "3U";
            PT = "1/1";
            Type = "Creature - Human Wizard";
            Text = "When Elite Arcanist enters the battlefield, you may exile an instant card from your hand.;^%X, %T: Copy the exiled card. You may cast the copy without paying its mana cost. X is the converted mana cost of the exiled card.";
            Flavor = "";
        }
    }
    # endregion

    # region Elixir of Immortality
    public class ElixirofImmortality : MagicCard
    {
        public ElixirofImmortality()
        {
            Name = "Elixir of Immortality";
            Edition = "M14";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T: You gain 5 life. Shuffle Elixir of Immortality and your graveyard into their owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Elvish Mystic
    public class ElvishMystic : MagicCard
    {
        public ElvishMystic()
        {
            Name = "Elvish Mystic";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Elf Druid";
            Text = "%T: Add %G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Encroaching Wastes
    public class EncroachingWastes : MagicCard
    {
        public EncroachingWastes()
        {
            Name = "Encroaching Wastes";
            Edition = "M14";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%4, %T, Sacrifice Encroaching Wastes: Destroy target nonbasic land.";
            Flavor = "";
        }
    }
    # endregion

    # region Enlarge
    public class Enlarge : MagicCard
    {
        public Enlarge()
        {
            Name = "Enlarge";
            Edition = "M14";
            Rarity = "U";
            Color = "G";
            Cost = "3GG";
            PT = "";
            Type = "Sorcery";
            Text = "Target creature gets +7/+7 and gains trample until end of turn. It must be blocked this turn if able. @(If a creature with trample would assign enough damage to its blockers to destroy them, you may have it assign the rest of its damage to defending player or planeswalker.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Essence Scatter
    public class EssenceScatter : MagicCard
    {
        public EssenceScatter()
        {
            Name = "Essence Scatter";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Counter target creature spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Festering Newt
    public class FesteringNewt : MagicCard
    {
        public FesteringNewt()
        {
            Name = "Festering Newt";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Salamander";
            Text = "When Festering Newt dies, target creature an opponent controls gets -1/-1 until end of turn. That creature gets -4/-4 instead if you control a creature named Bogbrew Witch.";
            Flavor = "";
        }
    }
    # endregion

    # region Fiendslayer Paladin
    public class FiendslayerPaladin : MagicCard
    {
        public FiendslayerPaladin()
        {
            Name = "Fiendslayer Paladin";
            Edition = "M14";
            Rarity = "R";
            Color = "W";
            Cost = "1WW";
            PT = "2/2";
            Type = "Creature - Human Knight";
            Text = "First strike @(This creature deals combat damage before creatures without first strike.)@;^Lifelink @(Damage dealt by this creature also causes you to gain that much life.)@;^Fiendslayer Paladin can�t be the target of black or red spells your opponents control.";
            Flavor = "";
        }
    }
    # endregion

    # region Fireshrieker
    public class Fireshrieker : MagicCard
    {
        public Fireshrieker()
        {
            Name = "Fireshrieker";
            Edition = "M14";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature has double strike. @(It deals both first-strike and regular combat damage.)@;^Equip %2 @(%2: Attach to target creature you control. Equip only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Flames of the Firebrand
    public class FlamesoftheFirebrand : MagicCard
    {
        public FlamesoftheFirebrand()
        {
            Name = "Flames of the Firebrand";
            Edition = "M14";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Sorcery";
            Text = "Flames of the Firebrand deals 3 damage divided as you choose among one, two, or three target creatures and/or players.";
            Flavor = "";
        }
    }
    # endregion

    # region Fleshpulper Giant
    public class FleshpulperGiant : MagicCard
    {
        public FleshpulperGiant()
        {
            Name = "Fleshpulper Giant";
            Edition = "M14";
            Rarity = "U";
            Color = "R";
            Cost = "5RR";
            PT = "4/4";
            Type = "Creature - Giant";
            Text = "When Fleshpulper Giant enters the battlefield, you may destroy target creature with toughness 2 or less.";
            Flavor = "";
        }
    }
    # endregion

    # region Fog
    public class FogM14 : MagicCard
    {
        public FogM14()
        {
            Name = "Fog";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Prevent all combat damage that would be dealt this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Forest
    public class ForestRTR : MagicCard
    {
        public ForestRTR()
        {
            Name = "Forest";
            Edition = "M14";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Forest";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Fortify
    public class Fortify : MagicCard
    {
        public Fortify()
        {
            Name = "Fortify";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Creatures you control get +2/+0 until end of turn; or creatures you control get +0/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Frost Breath
    public class FrostBreath : MagicCard
    {
        public FrostBreath()
        {
            Name = "Frost Breath";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Instant";
            Text = "Tap up to two target creatures. Those creatures don�t untap during their controller�s next untap step.";
            Flavor = "";
        }
    }
    # endregion

    # region Galerider Sliver
    public class GaleriderSliver : MagicCard
    {
        public GaleriderSliver()
        {
            Name = "Galerider Sliver";
            Edition = "M14";
            Rarity = "R";
            Color = "U";
            Cost = "U";
            PT = "1/1";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control have flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Garruk, Caller of Beasts
    public class GarrukCallerofBeasts : MagicCard
    {
        public GarrukCallerofBeasts()
        {
            Name = "Garruk, Caller of Beasts";
            Edition = "M14";
            Rarity = "M";
            Color = "G";
            Cost = "4GG";
            PT = "%4/";
            Type = "Planeswalker - Garruk";
            Text = "+1: Reveal the top five cards of your library. Put all creature cards revealed this way into your hand and the rest on the bottom of your library in any order.;^-3: You may put a green creature card from your hand onto the battlefield.;^-7: You get an emblem with �Whenever you cast a creature spell, you may search your library for a creature card, put it onto the battlefield, then shuffle your library.�";
            Flavor = "";
        }
    }
    # endregion

    # region Garruk's Horde
    public class GarruksHorde : MagicCard
    {
        public GarruksHorde()
        {
            Name = "Garruk's Horde";
            Edition = "M14";
            Rarity = "R";
            Color = "G";
            Cost = "5GG";
            PT = "7/7";
            Type = "Creature - Beast";
            Text = "Trample ;^Play with the top card of your library revealed.;^You may cast the top card of your library if it�s a creature card. @(Do this only any time you could cast that creature card. You still pay the spell�s costs.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Giant Growth
    public class GiantGrowthRTR : MagicCard
    {
        public GiantGrowthRTR()
        {
            Name = "Giant Growth";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +3/+3 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Giant Spider
    public class GiantSpiderM14 : MagicCard
    {
        public GiantSpiderM14()
        {
            Name = "Giant Spider";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "2/4";
            Type = "Creature - Spider";
            Text = "Reach @(This creature can block creatures with flying.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Gladecover Scout
    public class GladecoverScout : MagicCard
    {
        public GladecoverScout()
        {
            Name = "Gladecover Scout";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Elf Scout";
            Text = "Hexproof @(This creature can�t be the target of spells or abilities your opponents control.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Glimpse the Future
    public class GlimpsetheFuture : MagicCard
    {
        public GlimpsetheFuture()
        {
            Name = "Glimpse the Future";
            Edition = "M14";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Sorcery";
            Text = "Look at the top three cards of your library. Put one of them into your hand and the rest into your graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Gnawing Zombie
    public class GnawingZombie : MagicCard
    {
        public GnawingZombie()
        {
            Name = "Gnawing Zombie";
            Edition = "M14";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "1/3";
            Type = "Creature - Zombie";
            Text = "%1%B, Sacrifice a creature: Target player loses 1 life and you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Diplomats
    public class GoblinDiplomats : MagicCard
    {
        public GoblinDiplomats()
        {
            Name = "Goblin Diplomats";
            Edition = "M14";
            Rarity = "R";
            Color = "R";
            Cost = "1R";
            PT = "2/1";
            Type = "Creature - Goblin";
            Text = "%T: Each creature attacks this turn if able.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Shortcutter
    public class GoblinShortcutter : MagicCard
    {
        public GoblinShortcutter()
        {
            Name = "Goblin Shortcutter";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "2/1";
            Type = "Creature - Goblin Scout";
            Text = "When Goblin Shortcutter enters the battlefield, target creature can�t block this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Griffin Sentinel
    public class GriffinSentinel : MagicCard
    {
        public GriffinSentinel()
        {
            Name = "Griffin Sentinel";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "1/3";
            Type = "Creature - Griffin";
            Text = "Flying;^Vigilance @(Attacking doesn�t cause this creature to tap.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Grim Return
    public class GrimReturn : MagicCard
    {
        public GrimReturn()
        {
            Name = "Grim Return";
            Edition = "M14";
            Rarity = "R";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Instant";
            Text = "Choose target creature card in a graveyard that was put there from the battlefield this turn. Put that card onto the battlefield under your control.";
            Flavor = "";
        }
    }
    # endregion

    # region Groundshaker Sliver
    public class GroundshakerSliver : MagicCard
    {
        public GroundshakerSliver()
        {
            Name = "Groundshaker Sliver";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "6G";
            PT = "5/5";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control have trample. @(If a Sliver you control would assign enough damage to its blockers to destroy them, you may have it assign the rest of its damage to defending player or planeswalker.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Guardian of the Ages
    public class GuardianoftheAges : MagicCard
    {
        public GuardianoftheAges()
        {
            Name = "Guardian of the Ages";
            Edition = "M14";
            Rarity = "R";
            Color = "Art";
            Cost = "7";
            PT = "7/7";
            Type = "Artifact Creature - Golem";
            Text = "Defender @(This creature can�t attack.)@;^When a creature attacks you or a planeswalker you control, if Guardian of the Ages has defender, it loses defender and gains trample.";
            Flavor = "";
        }
    }
    # endregion

    # region Haunted Plate Mail
    public class HauntedPlateMail : MagicCard
    {
        public HauntedPlateMail()
        {
            Name = "Haunted Plate Mail";
            Edition = "M14";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +4/+4.;^%0: Until end of turn, Haunted Plate Mail becomes a 4/4 Spirit artifact creature that�s no longer an Equipment. Activate this ability only if you control no creatures.;^Equip %4 @(%4: Attach to target creature you control. Equip only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Hive Stirrings
    public class HiveStirrings : MagicCard
    {
        public HiveStirrings()
        {
            Name = "Hive Stirrings";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Sorcery";
            Text = "Put two 1/1 colorless Sliver creature tokens onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Howl of the Night Pack
    public class HowloftheNightPack : MagicCard
    {
        public HowloftheNightPack()
        {
            Name = "Howl of the Night Pack";
            Edition = "M14";
            Rarity = "U";
            Color = "G";
            Cost = "6G";
            PT = "";
            Type = "Sorcery";
            Text = "Put a 2/2 green Wolf creature token onto the battlefield for each Forest you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Hunt the Weak
    public class HunttheWeak : MagicCard
    {
        public HunttheWeak()
        {
            Name = "Hunt the Weak";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Sorcery";
            Text = "Put a +1/+1 counter on target creature you control. Then that creature fights target creature you don�t control. @(Each deals damage equal to its power to the other.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Illusionary Armor
    public class IllusionaryArmor : MagicCard
    {
        public IllusionaryArmor()
        {
            Name = "Illusionary Armor";
            Edition = "M14";
            Rarity = "U";
            Color = "U";
            Cost = "4U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +4/+4.;^When enchanted creature becomes the target of a spell or ability, sacrifice Illusionary Armor.";
            Flavor = "";
        }
    }
    # endregion

    # region Imposing Sovereign
    public class ImposingSovereign : MagicCard
    {
        public ImposingSovereign()
        {
            Name = "Imposing Sovereign";
            Edition = "M14";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "2/1";
            Type = "Creature - Human";
            Text = "Creatures your opponents control enter the battlefield tapped.";
            Flavor = "";
        }
    }
    # endregion

    # region Indestructibility
    public class Indestructibility : MagicCard
    {
        public Indestructibility()
        {
            Name = "Indestructibility";
            Edition = "M14";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant permanent;^Enchanted permanent has indestructible. @(Effects that say �destroy� don�t destroy that permanent. A creature with indestructible can�t be destroyed by damage.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Into the Wilds
    public class IntotheWilds : MagicCard
    {
        public IntotheWilds()
        {
            Name = "Into the Wilds";
            Edition = "M14";
            Rarity = "R";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of your upkeep, look at the top card of your library. If it�s a land card, you may put it onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Island
    public class IslandRTR : MagicCard
    {
        public IslandRTR()
        {
            Name = "Island";
            Edition = "M14";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Island";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Jace, Memory Adept
    public class JaceMemoryAdept : MagicCard
    {
        public JaceMemoryAdept()
        {
            Name = "Jace, Memory Adept";
            Edition = "M14";
            Rarity = "M";
            Color = "U";
            Cost = "3UU";
            PT = "%4/";
            Type = "Planeswalker - Jace";
            Text = "+1: Draw a card. Target player puts the top card of his or her library into his or her graveyard.;^0: Target player puts the top ten cards of his or her library into his or her graveyard.;^-7: Any number of target players each draw twenty cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Jace's Mindseeker
    public class JacesMindseeker : MagicCard
    {
        public JacesMindseeker()
        {
            Name = "Jace's Mindseeker";
            Edition = "M14";
            Rarity = "R";
            Color = "U";
            Cost = "4UU";
            PT = "4/4";
            Type = "Creature - Fish Illusion";
            Text = "Flying;^When Jace�s Mindseeker enters the battlefield, target opponent puts the top five cards of his or her library into his or her graveyard. You may cast an instant or sorcery card from among them without paying its mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Kalonian Hydra
    public class KalonianHydra : MagicCard
    {
        public KalonianHydra()
        {
            Name = "Kalonian Hydra";
            Edition = "M14";
            Rarity = "M";
            Color = "G";
            Cost = "3GG";
            PT = "0/0";
            Type = "Creature - Hydra";
            Text = "Trample;^Kalonian Hydra enters the battlefield with four +1/+1 counters on it.;^Whenever Kalonian Hydra attacks, double the number of +1/+1 counters on each creature you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Kalonian Tusker
    public class KalonianTusker : MagicCard
    {
        public KalonianTusker()
        {
            Name = "Kalonian Tusker";
            Edition = "M14";
            Rarity = "U";
            Color = "G";
            Cost = "GG";
            PT = "3/3";
            Type = "Creature - Beast";
            Text = "";
            Flavor = "�And all this time I thought we were tracking it.�;^�Juruk, Kalonian tracker";
        }
    }
    # endregion

    # region Lava Axe
    public class LavaAxe : MagicCard
    {
        public LavaAxe()
        {
            Name = "Lava Axe";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "4R";
            PT = "";
            Type = "Sorcery";
            Text = "Lava Axe deals 5 damage to target player.";
            Flavor = "";
        }
    }
    # endregion

    # region Lay of the Land
    public class LayoftheLand : MagicCard
    {
        public LayoftheLand()
        {
            Name = "Lay of the Land";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Sorcery";
            Text = "Search your library for a basic land card, reveal it, put it into your hand, then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Lifebane Zombie
    public class LifebaneZombie : MagicCard
    {
        public LifebaneZombie()
        {
            Name = "Lifebane Zombie";
            Edition = "M14";
            Rarity = "R";
            Color = "B";
            Cost = "1BB";
            PT = "3/1";
            Type = "Creature - Zombie Warrior";
            Text = "Intimidate @(This creature can�t be blocked except by artifact creatures and/or creatures that share a color with it.)@;^When Lifebane Zombie enters the battlefield, target opponent reveals his or her hand. You choose a green or white creature card from it and exile that card.";
            Flavor = "";
        }
    }
    # endregion

    # region Lightning Talons
    public class LightningTalons : MagicCard
    {
        public LightningTalons()
        {
            Name = "Lightning Talons";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +3/+0 and has first strike. @(It deals combat damage before creatures without first strike.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Liliana of the Dark Realms
    public class LilianaoftheDarkRealms : MagicCard
    {
        public LilianaoftheDarkRealms()
        {
            Name = "Liliana of the Dark Realms";
            Edition = "M14";
            Rarity = "M";
            Color = "B";
            Cost = "2BB";
            PT = "%3/";
            Type = "Planeswalker - Liliana";
            Text = "+1: Search your library for a Swamp card, reveal it, and put it into your hand. Then shuffle your library.;^-3: Target creature gets +X/+X or -X/-X until end of turn, where X is the number of Swamps you control.;^-6: You get an emblem with �Swamps you control have �%T: Add %B%B%B%B to your mana pool.��";
            Flavor = "";
        }
    }
    # endregion

    # region Liliana's Reaver
    public class LilianasReaver : MagicCard
    {
        public LilianasReaver()
        {
            Name = "Liliana's Reaver";
            Edition = "M14";
            Rarity = "R";
            Color = "B";
            Cost = "2BB";
            PT = "4/3";
            Type = "Creature - Zombie";
            Text = "Deathtouch @(Any amount of damage this deals to a creature is enough to destroy it.)@;^Whenever Liliana�s Reaver deals combat damage to a player, that player discards a card and you put a 2/2 black Zombie creature token onto the battlefield tapped.";
            Flavor = "";
        }
    }
    # endregion

    # region Liturgy of Blood
    public class LiturgyofBlood : MagicCard
    {
        public LiturgyofBlood()
        {
            Name = "Liturgy of Blood";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "3BB";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target creature. Add %B%B%B to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Manaweft Sliver
    public class ManaweftSliver : MagicCard
    {
        public ManaweftSliver()
        {
            Name = "Manaweft Sliver";
            Edition = "M14";
            Rarity = "U";
            Color = "G";
            Cost = "1G";
            PT = "1/1";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control have �%T: Add one mana of any color to your mana pool.�";
            Flavor = "";
        }

        public override bool TryActivate(int i)
        {
            if (Tapped)
            {
                return false;
            }

            Tap(true, false);
            DoActivate(i);
            return true;
        }

        public override void DoActivate(int i)
        {
            PArea.mw.ShowWheel("BGURW");
        }
    }
    # endregion

    # region Marauding Maulhorn
    public class MaraudingMaulhorn : MagicCard
    {
        public MaraudingMaulhorn()
        {
            Name = "Marauding Maulhorn";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "2RR";
            PT = "5/3";
            Type = "Creature - Beast";
            Text = "Marauding Maulhorn attacks each combat if able unless you control a creature named Advocate of the Beast.";
            Flavor = "";
        }
    }
    # endregion

    # region Mark of the Vampire
    public class MarkoftheVampire : MagicCard
    {
        public MarkoftheVampire()
        {
            Name = "Mark of the Vampire";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +2/+2 and has lifelink. @(Damage dealt by the creature also causes its controller to gain that much life.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Master of Diversion
    public class MasterofDiversion : MagicCard
    {
        public MasterofDiversion()
        {
            Name = "Master of Diversion";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Human Scout";
            Text = "Whenever Master of Diversion attacks, tap target creature defending player controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Megantic Sliver
    public class MeganticSliver : MagicCard
    {
        public MeganticSliver()
        {
            Name = "Megantic Sliver";
            Edition = "M14";
            Rarity = "R";
            Color = "G";
            Cost = "5G";
            PT = "3/3";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control get +3/+3.";
            Flavor = "";
        }
    }
    # endregion

    # region Merfolk Spy
    public class MerfolkSpy : MagicCard
    {
        public MerfolkSpy()
        {
            Name = "Merfolk Spy";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "1/1";
            Type = "Creature - Merfolk Rogue";
            Text = "Islandwalk @(This creature can�t be blocked as long as defending player controls an Island.)@;^Whenever Merfolk Spy deals combat damage to a player, that player reveals a card at random from his or her hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Messenger Drake
    public class MessengerDrake : MagicCard
    {
        public MessengerDrake()
        {
            Name = "Messenger Drake";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "3UU";
            PT = "3/3";
            Type = "Creature - Drake";
            Text = "Flying;^When Messenger Drake dies, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Millstone
    public class Millstone : MagicCard
    {
        public Millstone()
        {
            Name = "Millstone";
            Edition = "M14";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T: Target player puts the top two cards of his or her library into his or her graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Mind Rot
    public class MindRotM14 : MagicCard
    {
        public MindRotM14()
        {
            Name = "Mind Rot";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Sorcery";
            Text = "Target player discards two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Mindsparker
    public class Mindsparker : MagicCard
    {
        public Mindsparker()
        {
            Name = "Mindsparker";
            Edition = "M14";
            Rarity = "R";
            Color = "R";
            Cost = "1RR";
            PT = "3/2";
            Type = "Creature - Elemental";
            Text = "First strike @(This creature deals combat damage before creatures without first strike.)@;^Whenever an opponent casts a white or blue instant or sorcery spell, Mindsparker deals 2 damage to that player.";
            Flavor = "";
        }
    }
    # endregion

    # region Minotaur Abomination
    public class MinotaurAbomination : MagicCard
    {
        public MinotaurAbomination()
        {
            Name = "Minotaur Abomination";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "4BB";
            PT = "4/6";
            Type = "Creature - Zombie Minotaur";
            Text = "";
            Flavor = "�Look at that. Shuffling, wobbling, entrails placed haphazardly. It�s shameful. Who would let that kind of work flap about for all to see?�;^�Lestin, necromancer";
        }
    }
    # endregion

    # region Molten Birth
    public class MoltenBirth : MagicCard
    {
        public MoltenBirth()
        {
            Name = "Molten Birth";
            Edition = "M14";
            Rarity = "U";
            Color = "R";
            Cost = "1RR";
            PT = "";
            Type = "Sorcery";
            Text = "Put two 1/1 red Elemental creature tokens onto the battlefield. Then flip a coin. If you win the flip, return Molten Birth to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Mountain
    public class MountainRTR : MagicCard
    {
        public MountainRTR()
        {
            Name = "Mountain";
            Edition = "M14";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Mountain";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Mutavault
    public class Mutavault : MagicCard
    {
        public Mutavault()
        {
            Name = "Mutavault";
            Edition = "M14";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.^%1: Mutavault becomes a 2/2 creature with all creature types until end of turn. It�s still a land.";
            Flavor = "";
        }
    }
    # endregion

    # region Naturalize
    public class NaturalizeM14 : MagicCard
    {
        public NaturalizeM14()
        {
            Name = "Naturalize";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Destroy target artifact or enchantment.";
            Flavor = "";
        }
    }
    # endregion

    # region Negate
    public class Negate : MagicCard
    {
        public Negate()
        {
            Name = "Negate";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Counter target noncreature spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Nephalia Seakite
    public class NephaliaSeakite : MagicCard
    {
        public NephaliaSeakite()
        {
            Name = "Nephalia Seakite";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "3U";
            PT = "2/3";
            Type = "Creature - Bird";
            Text = "Flash @(You may cast this spell any time you could cast an instant.)@;^Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Nightmare
    public class NightmareM14 : MagicCard
    {
        public NightmareM14()
        {
            Name = "Nightmare";
            Edition = "M14";
            Rarity = "R";
            Color = "B";
            Cost = "5B";
            PT = "*/*";
            Type = "Creature - Nightmare Horse";
            Text = "Flying;^Nightmare�s power and toughness are each equal to the number of Swamps you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Nightwing Shade
    public class NightwingShade : MagicCard
    {
        public NightwingShade()
        {
            Name = "Nightwing Shade";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "4B";
            PT = "2/2";
            Type = "Creature - Shade";
            Text = "Flying;^%1%B: Nightwing Shade gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Oath of the Ancient Wood
    public class OathoftheAncientWood : MagicCard
    {
        public OathoftheAncientWood()
        {
            Name = "Oath of the Ancient Wood";
            Edition = "M14";
            Rarity = "R";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever Oath of the Ancient Wood or another enchantment enters the battlefield under your control, you may put a +1/+1 counter on target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Ogre Battledriver
    public class OgreBattledriver : MagicCard
    {
        public OgreBattledriver()
        {
            Name = "Ogre Battledriver";
            Edition = "M14";
            Rarity = "R";
            Color = "R";
            Cost = "2RR";
            PT = "3/3";
            Type = "Creature - Ogre Warrior";
            Text = "Whenever another creature enters the battlefield under your control, that creature gets +2/+0 and gains haste until end of turn. @(It can attack and %T this turn.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Opportunity
    public class Opportunity : MagicCard
    {
        public Opportunity()
        {
            Name = "Opportunity";
            Edition = "M14";
            Rarity = "U";
            Color = "U";
            Cost = "4UU";
            PT = "";
            Type = "Instant";
            Text = "Target player draws four cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Pacifism
    public class Pacifism : MagicCard
    {
        public Pacifism()
        {
            Name = "Pacifism";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature can�t attack or block.";
            Flavor = "";
        }
    }
    # endregion

    # region Path of Bravery
    public class PathofBravery : MagicCard
    {
        public PathofBravery()
        {
            Name = "Path of Bravery";
            Edition = "M14";
            Rarity = "R";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Enchantment";
            Text = "As long your life total is greater than or equal to your starting life total, creatures you control get +1/+1.Whenever one or more creatures you control attack, you gain life equal to the number of attacking creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Pay No Heed
    public class PayNoHeed : MagicCard
    {
        public PayNoHeed()
        {
            Name = "Pay No Heed";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Prevent all damage a source of your choice would deal this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Phantom Warrior
    public class PhantomWarrior : MagicCard
    {
        public PhantomWarrior()
        {
            Name = "Phantom Warrior";
            Edition = "M14";
            Rarity = "U";
            Color = "U";
            Cost = "1UU";
            PT = "2/2";
            Type = "Creature - Illusion Warrior";
            Text = "Phantom Warrior can�t be blocked.";
            Flavor = "";
        }
    }
    # endregion

    # region Pillarfield Ox
    public class PillarfieldOx : MagicCard
    {
        public PillarfieldOx()
        {
            Name = "Pillarfield Ox";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "2/4";
            Type = "Creature - Ox";
            Text = "";
            Flavor = "�You old, immobile clod! If I could stuff your doltish head with knowledge, I�d do it just so someone else could fully comprehend what your stubbornness has cost me!�;^�Bruse Tarl, Goma Fada nomad";
        }
    }
    # endregion

    # region Pitchburn Devils
    public class PitchburnDevils : MagicCard
    {
        public PitchburnDevils()
        {
            Name = "Pitchburn Devils";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "4R";
            PT = "3/3";
            Type = "Creature - Devil";
            Text = "When Pitchburn Devils dies, it deals 3 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Plains
    public class PlainsRTR : MagicCard
    {
        public PlainsRTR()
        {
            Name = "Plains";
            Edition = "M14";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Plains";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Planar Cleansing
    public class PlanarCleansing : MagicCard
    {
        public PlanarCleansing()
        {
            Name = "Planar Cleansing";
            Edition = "M14";
            Rarity = "R";
            Color = "W";
            Cost = "3WWW";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy all nonland permanents.";
            Flavor = "";
        }
    }
    # endregion

    # region Plummet
    public class Plummet : MagicCard
    {
        public Plummet()
        {
            Name = "Plummet";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Destroy target creature with flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Predatory Sliver
    public class PredatorySliver : MagicCard
    {
        public PredatorySliver()
        {
            Name = "Predatory Sliver";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "1/1";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control get +1/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Primeval Bounty
    public class PrimevalBounty : MagicCard
    {
        public PrimevalBounty()
        {
            Name = "Primeval Bounty";
            Edition = "M14";
            Rarity = "M";
            Color = "G";
            Cost = "5G";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever you cast a creature spell, put a 3/3 green Beast creature token onto the battlefield.;^Whenever you cast a noncreature spell, put three +1/+1 counters on target creature you control.;^Whenever a land enters the battlefield under your control, you gain 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Pyromancer's Gauntlet
    public class PyromancersGauntlet : MagicCard
    {
        public PyromancersGauntlet()
        {
            Name = "Pyromancer's Gauntlet";
            Edition = "M14";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "If a red instant or sorcery spell you control or a red planeswalker you control would deal damage to a permanent or player, it deals that much damage plus 2 to that permanent or player instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Quag Sickness
    public class QuagSickness : MagicCard
    {
        public QuagSickness()
        {
            Name = "Quag Sickness";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets -1/-1 for each Swamp you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Quicken
    public class Quicken : MagicCard
    {
        public Quicken()
        {
            Name = "Quicken";
            Edition = "M14";
            Rarity = "R";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "The next sorcery card you cast this turn can be cast as though it had flash. @(It can be cast any time you could cast an instant.)@;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Ranger's Guile
    public class RangersGuile : MagicCard
    {
        public RangersGuile()
        {
            Name = "Ranger's Guile";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Target creature you control gets +1/+1 and gains hexproof until end of turn. @(It can�t be the target of spells or abilities your opponents control.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Ratchet Bomb
    public class RatchetBomb : MagicCard
    {
        public RatchetBomb()
        {
            Name = "Ratchet Bomb";
            Edition = "M14";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%T: Put a charge counter on Ratchet Bomb.;^%T, Sacrifice Ratchet Bomb: Destroy each nonland permanent with converted mana cost equal to the number of charge counters on Ratchet Bomb.";
            Flavor = "";
        }
    }
    # endregion

    # region Regathan Firecat
    public class RegathanFirecat : MagicCard
    {
        public RegathanFirecat()
        {
            Name = "Regathan Firecat";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "4/1";
            Type = "Creature - Elemental Cat";
            Text = "";
            Flavor = "It stalks the Regathan highlands, leaving behind melted snow, scorched earth, and the charred corpses of would-be temple robbers.";
        }
    }
    # endregion

    # region Ring of Three Wishes
    public class RingofThreeWishes : MagicCard
    {
        public RingofThreeWishes()
        {
            Name = "Ring of Three Wishes";
            Edition = "M14";
            Rarity = "M";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "Ring of Three Wishes enters the battlefield with three wish counters on it.;^%5, %T, Remove a wish counter from Ring of Three Wishes: Search your library for a card and put that card into your hand. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Rise of the Dark Realms
    public class RiseoftheDarkRealms : MagicCard
    {
        public RiseoftheDarkRealms()
        {
            Name = "Rise of the Dark Realms";
            Edition = "M14";
            Rarity = "M";
            Color = "B";
            Cost = "7BB";
            PT = "";
            Type = "Sorcery";
            Text = "Put all creature cards from all graveyards onto the battlefield under your control.";
            Flavor = "";
        }
    }
    # endregion

    # region Rod of Ruin
    public class RodofRuinM14 : MagicCard
    {
        public RodofRuinM14()
        {
            Name = "Rod of Ruin";
            Edition = "M14";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T: Rod of Ruin deals 1 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Rootwalla
    public class Rootwalla : MagicCard
    {
        public Rootwalla()
        {
            Name = "Rootwalla";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Lizard";
            Text = "%1%G: Rootwalla gets +2/+2 until end of turn. Activate this ability only once each turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Rumbling Baloth
    public class RumblingBaloth : MagicCard
    {
        public RumblingBaloth()
        {
            Name = "Rumbling Baloth";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "2GG";
            PT = "4/4";
            Type = "Creature - Beast";
            Text = "";
            Flavor = "In the dim light beneath the vast trees of Deepglade, baloths prowl in search of prey. Their guttural calls are more felt than heard, but their attack scream carries for miles.";
        }
    }
    # endregion

    # region Sanguine Bond
    public class SanguineBond : MagicCard
    {
        public SanguineBond()
        {
            Name = "Sanguine Bond";
            Edition = "M14";
            Rarity = "R";
            Color = "B";
            Cost = "3BB";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever you gain life, target opponent loses that much life.";
            Flavor = "";
        }
    }
    # endregion

    # region Savage Summoning
    public class SavageSummoning : MagicCard
    {
        public SavageSummoning()
        {
            Name = "Savage Summoning";
            Edition = "M14";
            Rarity = "R";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Savage Summoning can�t be countered.;^The next creature card you cast this turn can be cast as though it had flash. That spell can�t be countered. That creature enters the battlefield with an additional +1/+1 counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Scavenging Ooze
    public class ScavengingOoze : MagicCard
    {
        public ScavengingOoze()
        {
            Name = "Scavenging Ooze";
            Edition = "M14";
            Rarity = "R";
            Color = "G";
            Cost = "1G";
            PT = "2/2";
            Type = "Creature - Ooze";
            Text = "%G: Exile target card from a graveyard. If it was a creature card, put a +1/+1 counter on Scavenging Ooze and you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Scourge of Valkas
    public class ScourgeofValkas : MagicCard
    {
        public ScourgeofValkas()
        {
            Name = "Scourge of Valkas";
            Edition = "M14";
            Rarity = "M";
            Color = "R";
            Cost = "2RRR";
            PT = "4/4";
            Type = "Creature - Dragon";
            Text = "Flying;^Whenever Scourge of Valkas or another Dragon enters the battlefield under your control, it deals X damage to target creature or player, where X is the number of Dragons you control.;^%R: Scourge of Valkas gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Scroll Thief
    public class ScrollThief : MagicCard
    {
        public ScrollThief()
        {
            Name = "Scroll Thief";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "1/3";
            Type = "Creature - Merfolk Rogue";
            Text = "Whenever Scroll Thief deals combat damage to a player, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Seacoast Drake
    public class SeacoastDrake : MagicCard
    {
        public SeacoastDrake()
        {
            Name = "Seacoast Drake";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "1/3";
            Type = "Creature - Drake";
            Text = "Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Seismic Stomp
    public class SeismicStomp : MagicCard
    {
        public SeismicStomp()
        {
            Name = "Seismic Stomp";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Sorcery";
            Text = "Creatures without flying can�t block this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Sengir Vampire
    public class SengirVampireM14 : MagicCard
    {
        public SengirVampireM14()
        {
            Name = "Sengir Vampire";
            Edition = "M14";
            Rarity = "U";
            Color = "B";
            Cost = "3BB";
            PT = "4/4";
            Type = "Creature - Vampire";
            Text = "Flying;^Whenever a creature dealt damage by Sengir Vampire this turn dies, put a +1/+1 counter on Sengir Vampire.";
            Flavor = "";
        }
    }
    # endregion

    # region Sensory Deprivation
    public class SensoryDeprivation : MagicCard
    {
        public SensoryDeprivation()
        {
            Name = "Sensory Deprivation";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets -3/-0.";
            Flavor = "";
        }
    }
    # endregion

    # region Sentinel Sliver
    public class SentinelSliver : MagicCard
    {
        public SentinelSliver()
        {
            Name = "Sentinel Sliver";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "2/2";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control have vigilance. @(Attacking doesn�t cause them to tap.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Seraph of the Sword
    public class SeraphoftheSword : MagicCard
    {
        public SeraphoftheSword()
        {
            Name = "Seraph of the Sword";
            Edition = "M14";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "3/3";
            Type = "Creature - Angel";
            Text = "Flying;^Prevent all combat damage that would be dealt to Seraph of the Sword.";
            Flavor = "";
        }
    }
    # endregion

    # region Serra Angel
    public class SerraAngelM14 : MagicCard
    {
        public SerraAngelM14()
        {
            Name = "Serra Angel";
            Edition = "M14";
            Rarity = "U";
            Color = "W";
            Cost = "3WW";
            PT = "4/4";
            Type = "Creature - Angel";
            Text = "Flying;^Vigilance @(Attacking doesn�t cause this creature to tap.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Shadowborn Apostle
    public class ShadowbornApostle : MagicCard
    {
        public ShadowbornApostle()
        {
            Name = "Shadowborn Apostle";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Human Cleric";
            Text = "A deck can have any number of cards named Shadowborn Apostle.;^%B, Sacrifice six creatures named Shadowborn Apostle: Search your library for a Demon creature card and put it onto the battlefield. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Shadowborn Demon
    public class ShadowbornDemon : MagicCard
    {
        public ShadowbornDemon()
        {
            Name = "Shadowborn Demon";
            Edition = "M14";
            Rarity = "M";
            Color = "B";
            Cost = "3BB";
            PT = "5/6";
            Type = "Creature - Demon";
            Text = "Flying;^When Shadowborn Demon enters the battlefield, destroy target non-Demon creature.;^At the beginning of your upkeep, if there are fewer than six creature cards in your graveyard, sacrifice a creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Shimmering Grotto
    public class ShimmeringGrotto : MagicCard
    {
        public ShimmeringGrotto()
        {
            Name = "Shimmering Grotto";
            Edition = "M14";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.^%1, %T: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Shivan Dragon
    public class ShivanDragonM14 : MagicCard
    {
        public ShivanDragonM14()
        {
            Name = "Shivan Dragon";
            Edition = "M14";
            Rarity = "R";
            Color = "R";
            Cost = "4RR";
            PT = "5/5";
            Type = "Creature - Dragon";
            Text = "Flying;^%R: Shivan Dragon gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Shiv's Embrace
    public class ShivsEmbrace : MagicCard
    {
        public ShivsEmbrace()
        {
            Name = "Shiv's Embrace";
            Edition = "M14";
            Rarity = "U";
            Color = "R";
            Cost = "2RR";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +2/+2 and has flying.;^%R: Enchanted creature gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Shock
    public class Shock : MagicCard
    {
        public Shock()
        {
            Name = "Shock";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Shock deals 2 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Show of Valor
    public class ShowofValor : MagicCard
    {
        public ShowofValor()
        {
            Name = "Show of Valor";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +2/+4 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Shrivel
    public class Shrivel : MagicCard
    {
        public Shrivel()
        {
            Name = "Shrivel";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Sorcery";
            Text = "All creatures get -1/-1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Siege Mastodon
    public class SiegeMastodon : MagicCard
    {
        public SiegeMastodon()
        {
            Name = "Siege Mastodon";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "4W";
            PT = "3/5";
            Type = "Creature - Elephant";
            Text = "";
            Flavor = "�The walls of the wicked will fall before us. Ready the siege engines. We proceed to war!�;^�General Avitora";
        }
    }
    # endregion

    # region Silence
    public class Silence : MagicCard
    {
        public Silence()
        {
            Name = "Silence";
            Edition = "M14";
            Rarity = "R";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Your opponents can�t cast spells this turn. @(Spells cast before this resolves are unaffected.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Sliver Construct
    public class SliverConstruct : MagicCard
    {
        public SliverConstruct()
        {
            Name = "Sliver Construct";
            Edition = "M14";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "2/2";
            Type = "Artifact Creature - Sliver Construct";
            Text = "";
            Flavor = "Slivers destroy those who come close to the Skep, the central hive. Shards of torn metal litter the ground as a warning to any artificers inquisitive about the hive�s inner workings.";
        }
    }
    # endregion

    # region Smelt
    public class Smelt : MagicCard
    {
        public Smelt()
        {
            Name = "Smelt";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Destroy target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Solemn Offering
    public class SolemnOffering : MagicCard
    {
        public SolemnOffering()
        {
            Name = "Solemn Offering";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target artifact or enchantment. You gain 4 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Soulmender
    public class Soulmender : MagicCard
    {
        public Soulmender()
        {
            Name = "Soulmender";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Human Cleric";
            Text = "%T: You gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Spell Blast
    public class SpellBlastM14 : MagicCard
    {
        public SpellBlastM14()
        {
            Name = "Spell Blast";
            Edition = "M14";
            Rarity = "U";
            Color = "U";
            Cost = "XU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell with converted mana cost X. @(For example, if that spell�s mana cost is %3%U%U, X is 5.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Sporemound
    public class Sporemound : MagicCard
    {
        public Sporemound()
        {
            Name = "Sporemound";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "3GG";
            PT = "3/3";
            Type = "Creature - Fungus";
            Text = "Whenever a land enters the battlefield under your control, put a 1/1 green Saproling creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Staff of the Death Magus
    public class StaffoftheDeathMagus : MagicCard
    {
        public StaffoftheDeathMagus()
        {
            Name = "Staff of the Death Magus";
            Edition = "M14";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever you cast a black spell or a Swamp enters the battlefield under your control, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Staff of the Flame Magus
    public class StaffoftheFlameMagus : MagicCard
    {
        public StaffoftheFlameMagus()
        {
            Name = "Staff of the Flame Magus";
            Edition = "M14";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever you cast a red spell or a Mountain enters the battlefield under your control, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Staff of the Mind Magus
    public class StaffoftheMindMagus : MagicCard
    {
        public StaffoftheMindMagus()
        {
            Name = "Staff of the Mind Magus";
            Edition = "M14";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever you cast a blue spell or an Island enters the battlefield under your control, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Staff of the Sun Magus
    public class StaffoftheSunMagus : MagicCard
    {
        public StaffoftheSunMagus()
        {
            Name = "Staff of the Sun Magus";
            Edition = "M14";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever you cast a white spell or a Plains enters the battlefield under your control, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Staff of the Wild Magus
    public class StaffoftheWildMagus : MagicCard
    {
        public StaffoftheWildMagus()
        {
            Name = "Staff of the Wild Magus";
            Edition = "M14";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever you cast a green spell or a Forest enters the battlefield under your control, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Steelform Sliver
    public class SteelformSliver : MagicCard
    {
        public SteelformSliver()
        {
            Name = "Steelform Sliver";
            Edition = "M14";
            Rarity = "U";
            Color = "W";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control get +0/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Stonehorn Chanter
    public class StonehornChanter : MagicCard
    {
        public StonehornChanter()
        {
            Name = "Stonehorn Chanter";
            Edition = "M14";
            Rarity = "U";
            Color = "W";
            Cost = "5W";
            PT = "4/4";
            Type = "Creature - Rhino Cleric";
            Text = "%5%W: Stonehorn Chanter gains vigilance and lifelink until end of turn. @(Attacking doesn�t cause it to tap. Damage dealt by it also causes you to gain that much life.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Striking Sliver
    public class StrikingSliver : MagicCard
    {
        public StrikingSliver()
        {
            Name = "Striking Sliver";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control have first strike. @(They deal combat damage before creatures without first strike.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Strionic Resonator
    public class StrionicResonator : MagicCard
    {
        public StrionicResonator()
        {
            Name = "Strionic Resonator";
            Edition = "M14";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T: Copy target triggered ability you control. You may choose new targets for the copy. @(A triggered ability uses the words �when,� �whenever,� or �at.�)@";
            Flavor = "";
        }
    }
    # endregion

    # region Suntail Hawk
    public class SuntailHawk : MagicCard
    {
        public SuntailHawk()
        {
            Name = "Suntail Hawk";
            Edition = "M14";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Bird";
            Text = "Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Swamp
    public class SwampRTR : MagicCard
    {
        public SwampRTR()
        {
            Name = "Swamp";
            Edition = "M14";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Swamp";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Syphon Sliver
    public class SyphonSliver : MagicCard
    {
        public SyphonSliver()
        {
            Name = "Syphon Sliver";
            Edition = "M14";
            Rarity = "R";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control have lifelink. @(Damage dealt by a Sliver creature you control also causes you to gain that much life.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Tenacious Dead
    public class TenaciousDead : MagicCard
    {
        public TenaciousDead()
        {
            Name = "Tenacious Dead";
            Edition = "M14";
            Rarity = "U";
            Color = "B";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Skeleton Warrior";
            Text = "When Tenacious Dead dies, you may pay %1%B. If you do, return it to the battlefield tapped under its owner�s control.";
            Flavor = "";
        }
    }
    # endregion

    # region Thorncaster Sliver
    public class ThorncasterSliver : MagicCard
    {
        public ThorncasterSliver()
        {
            Name = "Thorncaster Sliver";
            Edition = "M14";
            Rarity = "R";
            Color = "R";
            Cost = "4R";
            PT = "2/2";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control have �Whenever this creature attacks, it deals 1 damage to target creature or player.�";
            Flavor = "";
        }
    }
    # endregion

    # region Thunder Strike
    public class ThunderStrike : MagicCard
    {
        public ThunderStrike()
        {
            Name = "Thunder Strike";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +2/+0 and gains first strike until end of turn. @(It deals combat damage before creatures without first strike.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Tidebinder Mage
    public class TidebinderMage : MagicCard
    {
        public TidebinderMage()
        {
            Name = "Tidebinder Mage";
            Edition = "M14";
            Rarity = "R";
            Color = "U";
            Cost = "UU";
            PT = "2/2";
            Type = "Creature - Merfolk Wizard";
            Text = "When Tidebinder Mage enters the battlefield, tap target red or green creature an opponent controls. That creature doesn�t untap during its controller�s untap step for as long as you control Tidebinder Mage.";
            Flavor = "";
        }
    }
    # endregion

    # region Time Ebb
    public class TimeEbb : MagicCard
    {
        public TimeEbb()
        {
            Name = "Time Ebb";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Sorcery";
            Text = "Put target creature on top of its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Tome Scour
    public class TomeScour : MagicCard
    {
        public TomeScour()
        {
            Name = "Tome Scour";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Sorcery";
            Text = "Target player puts the top five cards of his or her library into his or her graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Trading Post
    public class TradingPost : MagicCard
    {
        public TradingPost()
        {
            Name = "Trading Post";
            Edition = "M14";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%1, %T, Discard a card: You gain 4 life.;^%1, %T, Pay 1 life: Put a 0/1 white Goat creature token onto the battlefield.;^%1, %T, Sacrifice a creature: Return target artifact card from your graveyard to your hand.;^%1, %T, Sacrifice an artifact: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Trained Condor
    public class TrainedCondor : MagicCard
    {
        public TrainedCondor()
        {
            Name = "Trained Condor";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "2/1";
            Type = "Creature - Bird";
            Text = "Flying;^Whenever Trained Condor attacks, another target creature you control gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Traumatize
    public class Traumatize : MagicCard
    {
        public Traumatize()
        {
            Name = "Traumatize";
            Edition = "M14";
            Rarity = "R";
            Color = "U";
            Cost = "3UU";
            PT = "";
            Type = "Sorcery";
            Text = "Target player puts the top half of his or her library, rounded down, into his or her graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Trollhide
    public class Trollhide : MagicCard
    {
        public Trollhide()
        {
            Name = "Trollhide";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +2/+2 and has �%1%G: Regenerate this creature.� @(The next time the creature would be destroyed this turn, it isn�t. Instead tap it, remove all damage from it, and remove it from combat.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Undead Minotaur
    public class UndeadMinotaur : MagicCard
    {
        public UndeadMinotaur()
        {
            Name = "Undead Minotaur";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "2/3";
            Type = "Creature - Zombie Minotaur";
            Text = "";
            Flavor = "�The work that went into creating this magnificent specimen. Horrific, deadly, well-balanced. Not all necromancers do elegant work like this.�;^�Lestin, necromancer";
        }
    }
    # endregion

    # region Vampire Warlord
    public class VampireWarlord : MagicCard
    {
        public VampireWarlord()
        {
            Name = "Vampire Warlord";
            Edition = "M14";
            Rarity = "U";
            Color = "B";
            Cost = "4B";
            PT = "4/2";
            Type = "Creature - Vampire Warrior";
            Text = "Sacrifice another creature: Regenerate Vampire Warlord. @(The next time this creature would be destroyed this turn, it isn�t. Instead tap it, remove all damage from it, and remove it from combat.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Vastwood Hydra
    public class VastwoodHydra : MagicCard
    {
        public VastwoodHydra()
        {
            Name = "Vastwood Hydra";
            Edition = "M14";
            Rarity = "R";
            Color = "G";
            Cost = "XGG";
            PT = "0/0";
            Type = "Creature - Hydra";
            Text = "Vastwood Hydra enters the battlefield with X +1/+1 counters on it.;^When Vastwood Hydra dies, you may distribute a number of +1/+1 counters equal to the number of +1/+1 counters on Vastwood Hydra among any number of creatures you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Verdant Haven
    public class VerdantHavenM14 : MagicCard
    {
        public VerdantHavenM14()
        {
            Name = "Verdant Haven";
            Edition = "M14";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land;^When Verdant Haven enters the battlefield, you gain 2 life.;^Whenever enchanted land is tapped for mana, its controller adds one mana of any color to his or her mana pool @(in addition to the mana the land produces)@.";
            Flavor = "";
        }
    }
    # endregion

    # region Vial of Poison
    public class VialofPoison : MagicCard
    {
        public VialofPoison()
        {
            Name = "Vial of Poison";
            Edition = "M14";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%1, Sacrifice Vial of Poison: Target creature gains deathtouch until end of turn. @(Any amount of damage it deals to a creature is enough to destroy it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Vile Rebirth
    public class VileRebirth : MagicCard
    {
        public VileRebirth()
        {
            Name = "Vile Rebirth";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "Exile target creature card from a graveyard. Put a 2/2 black Zombie creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Volcanic Geyser
    public class VolcanicGeyser : MagicCard
    {
        public VolcanicGeyser()
        {
            Name = "Volcanic Geyser";
            Edition = "M14";
            Rarity = "U";
            Color = "R";
            Cost = "XRR";
            PT = "";
            Type = "Instant";
            Text = "Volcanic Geyser deals X damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Voracious Wurm
    public class VoraciousWurm : MagicCard
    {
        public VoraciousWurm()
        {
            Name = "Voracious Wurm";
            Edition = "M14";
            Rarity = "U";
            Color = "G";
            Cost = "1G";
            PT = "2/2";
            Type = "Creature - Wurm";
            Text = "Voracious Wurm enters the battlefield with X +1/+1 counters on it, where X is the amount of life you�ve gained this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Frost
    public class WallofFrost : MagicCard
    {
        public WallofFrost()
        {
            Name = "Wall of Frost";
            Edition = "M14";
            Rarity = "U";
            Color = "U";
            Cost = "1UU";
            PT = "0/7";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@;^Whenever Wall of Frost blocks a creature, that creature doesn�t untap during its controller�s next untap step.";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Swords
    public class WallofSwordsM14 : MagicCard
    {
        public WallofSwordsM14()
        {
            Name = "Wall of Swords";
            Edition = "M14";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "3/5";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack)@;^Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Warden of Evos Isle
    public class WardenofEvosIsle : MagicCard
    {
        public WardenofEvosIsle()
        {
            Name = "Warden of Evos Isle";
            Edition = "M14";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "2/2";
            Type = "Creature - Bird Wizard";
            Text = "Flying;^Creature spells with flying you cast cost %1 less to cast.";
            Flavor = "";
        }
    }
    # endregion

    # region Water Servant
    public class WaterServant : MagicCard
    {
        public WaterServant()
        {
            Name = "Water Servant";
            Edition = "M14";
            Rarity = "U";
            Color = "U";
            Cost = "2UU";
            PT = "3/4";
            Type = "Creature - Elemental";
            Text = "%U: Water Servant gets +1/-1 until end of turn.;^%U: Water Servant gets -1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Wild Guess
    public class WildGuess : MagicCard
    {
        public WildGuess()
        {
            Name = "Wild Guess";
            Edition = "M14";
            Rarity = "C";
            Color = "R";
            Cost = "RR";
            PT = "";
            Type = "Sorcery";
            Text = "As an additional cost to cast Wild Guess, discard a card.;^Draw two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Wild Ricochet
    public class WildRicochet : MagicCard
    {
        public WildRicochet()
        {
            Name = "Wild Ricochet";
            Edition = "M14";
            Rarity = "R";
            Color = "R";
            Cost = "2RR";
            PT = "";
            Type = "Instant";
            Text = "You may choose new targets for target instant or sorcery spell. Then copy that spell. You may choose new targets for the copy.";
            Flavor = "";
        }
    }
    # endregion

    # region Windreader Sphinx
    public class WindreaderSphinx : MagicCard
    {
        public WindreaderSphinx()
        {
            Name = "Windreader Sphinx";
            Edition = "M14";
            Rarity = "M";
            Color = "U";
            Cost = "5UU";
            PT = "3/7";
            Type = "Creature - Sphinx";
            Text = "Flying;^Whenever a creature with flying attacks, you may draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Windstorm
    public class Windstorm : MagicCard
    {
        public Windstorm()
        {
            Name = "Windstorm";
            Edition = "M14";
            Rarity = "U";
            Color = "G";
            Cost = "XG";
            PT = "";
            Type = "Instant";
            Text = "Windstorm deals X damage to each creature with flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Witchstalker
    public class Witchstalker : MagicCard
    {
        public Witchstalker()
        {
            Name = "Witchstalker";
            Edition = "M14";
            Rarity = "R";
            Color = "G";
            Cost = "1GG";
            PT = "3/3";
            Type = "Creature - Wolf";
            Text = "Hexproof @(This creature can�t be the target of spells or abilities your opponents control.)@;^Whenever an opponent casts a blue or black spell during your turn, put a +1/+1 counter on Witchstalker.";
            Flavor = "";
        }
    }
    # endregion

    # region Woodborn Behemoth
    public class WoodbornBehemoth : MagicCard
    {
        public WoodbornBehemoth()
        {
            Name = "Woodborn Behemoth";
            Edition = "M14";
            Rarity = "U";
            Color = "G";
            Cost = "3GG";
            PT = "4/4";
            Type = "Creature - Elemental";
            Text = "As long as you control eight or more lands, Woodborn Behemoth gets +4/+4 and has trample. @(If this creature would assign enough damage to its blockers to destroy them, you may have it assign the rest of its damage to defending player or planeswalker.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wring Flesh
    public class WringFlesh : MagicCard
    {
        public WringFlesh()
        {
            Name = "Wring Flesh";
            Edition = "M14";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets -3/-1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Xathrid Necromancer
    public class XathridNecromancer : MagicCard
    {
        public XathridNecromancer()
        {
            Name = "Xathrid Necromancer";
            Edition = "M14";
            Rarity = "R";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Human Wizard";
            Text = "Whenever Xathrid Necromancer or another Human creature you control dies, put a 2/2 black Zombie creature token onto the battlefield tapped.";
            Flavor = "";
        }
    }
    # endregion

    # region Young Pyromancer
    public class YoungPyromancer : MagicCard
    {
        public YoungPyromancer()
        {
            Name = "Young Pyromancer";
            Edition = "M14";
            Rarity = "U";
            Color = "R";
            Cost = "1R";
            PT = "2/1";
            Type = "Creature - Human Shaman";
            Text = "Whenever you cast an instant or sorcery spell, put a 1/1 red Elemental creature token onto the battlefield.";
            Flavor = "";
        }

        public override void SpellResolved(MagicCard mc)
        {
            if (mc.Type.Contains("Instant") || mc.Type.Contains("Sorcery"))
            {
                # region Create Elemental
                MagicCard mct = new MagicCard
                {
                    Token = true,
                    Name = "Elemental",
                    Type = "Creature - Elemental",
                    Color = "Red",
                    PT = "1/1",
                };
                # endregion
                PArea.PlayToken(mct);
            }
        }
    }
    # endregion

    # region Zephyr Charge
    public class ZephyrCharge : MagicCard
    {
        public ZephyrCharge()
        {
            Name = "Zephyr Charge";
            Edition = "M14";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Enchantment";
            Text = "%1%U: Target creature gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion







    # endregion

    # region Magic 2015
    # region Accursed Spirit
    public class AccursedSpiritM15 : MagicCard
    {
        public AccursedSpiritM15()
        {
            Name = "Accursed Spirit";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3B";
            PT = "3/2";
            Type = "Creature - Spirit";
            Text = "Intimidate";
            Flavor = "";
        }
    }
    # endregion

    # region Act on Impulse
    public class ActonImpulse15 : MagicCard
    {
        public ActonImpulse15()
        {
            Name = "Act on Impulse";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2R";
            PT = "";
            Type = "Sorcery";
            Text = "Exile the top three cards of your library. Until end of turn, you may play cards exiled this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Aegis Angel
    public class AegisAngel15 : MagicCard
    {
        public AegisAngel15()
        {
            Name = "Aegis Angel";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4WW";
            PT = "5/5";
            Type = "Creature - Angel";
            Text = "Flying^When Aegis Angel enters the battlefield, another target creature gains indestructible for as long as you control Aegis Angel.";
            Flavor = "";
        }
    }
    # endregion

    # region Aeronaut Tinkerer
    public class AeronautTinkerer15 : MagicCard
    {
        public AeronautTinkerer15()
        {
            Name = "Aeronaut Tinkerer";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2U";
            PT = "2/3";
            Type = "Creature - Human Artificer";
            Text = "Aeronaut Tinkerer has flying as long as you control an artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region AEtherspouts
    public class AEtherspouts15 : MagicCard
    {
        public AEtherspouts15()
        {
            Name = "AEtherspouts";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3UU";
            PT = "";
            Type = "Instant";
            Text = "For each attacking creature, its owner puts it on the top or bottom of his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Aggressive Mining
    public class AggressiveMining15 : MagicCard
    {
        public AggressiveMining15()
        {
            Name = "Aggressive Mining";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3R";
            PT = "";
            Type = "Enchantment";
            Text = "You can't play lands.^Sacrifice a land: Draw two cards. Activate this ability only once each turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Ajani Steadfast
    public class AjaniSteadfast15 : MagicCard
    {
        public AjaniSteadfast15()
        {
            Name = "Ajani Steadfast";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3W";
            PT = "4";
            Type = "Planeswalker - Ajani";
            Text = "+1: Until end of turn, up to one target creature gets +1/+1 and gains first strike, vigilance, and lifelink.^-2: Put a +1/+1 counter on each creature you control and a loyalty counter on each other planeswalker you control.^-7: You get an emblem with 'If a source would deal damage to you or a planeswalker you control, prevent all but 1 of that damage.'";
            Flavor = "";
        }
    }
    # endregion

    # region Ajani's Pridemate
    public class AjanisPridemate15 : MagicCard
    {
        public AjanisPridemate15()
        {
            Name = "Ajani's Pridemate";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1W";
            PT = "2/2";
            Type = "Creature - Cat Soldier";
            Text = "Whenever you gain life, you may put a +1/+1 counter on Ajani's Pridemate. (For example, if an effect causes you to gain 3 life, you may put one +1/+1 counter on this creature.)";
            Flavor = "";
        }
    }
    # endregion

    # region Altac Bloodseeker
    public class AltacBloodseeker15 : MagicCard
    {
        public AltacBloodseeker15()
        {
            Name = "Altac Bloodseeker";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1R";
            PT = "2/1";
            Type = "Creature - Human Berserker";
            Text = "Whenever a creature an opponent controls dies, Altac Bloodseeker gets +2/+0 and gains first strike and haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Amphin Pathmage
    public class AmphinPathmage15 : MagicCard
    {
        public AmphinPathmage15()
        {
            Name = "Amphin Pathmage";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3U";
            PT = "3/2";
            Type = "Creature - Salamander Wizard";
            Text = "2U: Target creature can't be blocked this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Ancient Silverback
    public class AncientSilverback15 : MagicCard
    {
        public AncientSilverback15()
        {
            Name = "Ancient Silverback";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4GG";
            PT = "6/5";
            Type = "Creature - Ape";
            Text = "G: Regenerate Ancient Silverback.";
            Flavor = "";
        }
    }
    # endregion

    # region Avacyn, Guardian Angel
    public class AvacynGuardianAngel15 : MagicCard
    {
        public AvacynGuardianAngel15()
        {
            Name = "Avacyn, Guardian Angel";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2WWW";
            PT = "5/4";
            Type = "Legendary Creature - Angel";
            Text = "Flying, vigilance^1W: Prevent all damage that would be dealt to another target creature this turn by sources of the color of your choice.^5WW: Prevent all damage that would be dealt to target player this turn by sources of the color of your choice.";
            Flavor = "";
        }
    }
    # endregion

    # region Avarice Amulet
    public class AvariceAmulet15 : MagicCard
    {
        public AvariceAmulet15()
        {
            Name = "Avarice Amulet";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +2/+0 and has vigilance and 'At the beginning of your upkeep, draw a card.'^When equipped creature dies, target opponent gains control of Avarice Amulet.^Equip 2";
            Flavor = "";
        }
    }
    # endregion

    # region Back to Nature
    public class BacktoNature15 : MagicCard
    {
        public BacktoNature15()
        {
            Name = "Back to Nature";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Destroy all enchantments.";
            Flavor = "";
        }
    }
    # endregion

    # region Battle Mastery
    public class BattleMastery15 : MagicCard
    {
        public BattleMastery15()
        {
            Name = "Battle Mastery";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^Enchanted creature has double strike.";
            Flavor = "";
        }
    }
    # endregion

    # region Battlefield Forge
    public class BattlefieldForge15 : MagicCard
    {
        public BattlefieldForge15()
        {
            Name = "Battlefield Forge";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "T: Add 1 to your mana pool.^T: Add R or W to your mana pool. Battlefield Forge deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Belligerent Sliver
    public class BelligerentSliver15 : MagicCard
    {
        public BelligerentSliver15()
        {
            Name = "Belligerent Sliver";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control have 'This creature can't be blocked except by two or more creatures.'";
            Flavor = "";
        }
    }
    # endregion

    # region Black Cat
    public class BlackCat15 : MagicCard
    {
        public BlackCat15()
        {
            Name = "Black Cat";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1B";
            PT = "1/1";
            Type = "Creature - Zombie Cat";
            Text = "When Black Cat dies, target opponent discards a card at random.";
            Flavor = "";
        }
    }
    # endregion

    # region Blastfire Bolt
    public class BlastfireBolt15 : MagicCard
    {
        public BlastfireBolt15()
        {
            Name = "Blastfire Bolt";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5R";
            PT = "";
            Type = "Instant";
            Text = "Blastfire Bolt deals 5 damage to target creature. Destroy all Equipment attached to that creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Blood Host
    public class BloodHost15 : MagicCard
    {
        public BloodHost15()
        {
            Name = "Blood Host";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3BB";
            PT = "3/3";
            Type = "Creature - Vampire";
            Text = "1B, Sacrifice another creature: Put a +1/+1 counter on Blood Host and you gain 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Boonweaver Giant
    public class BoonweaverGiant15 : MagicCard
    {
        public BoonweaverGiant15()
        {
            Name = "Boonweaver Giant";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "6W";
            PT = "4/4";
            Type = "Creature - Giant Monk";
            Text = "When Boonweaver Giant enters the battlefield, you may search your graveyard, hand, and/or library for an Aura card and put it onto the battlefield attached to Boonweaver Giant. If you search your library this way, shuffle it.";
            Flavor = "";
        }
    }
    # endregion

    # region Borderland Marauder
    public class BorderlandMarauder15 : MagicCard
    {
        public BorderlandMarauder15()
        {
            Name = "Borderland Marauder";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1R";
            PT = "1/2";
            Type = "Creature - Human Warrior";
            Text = "Whenever Borderland Marauder attacks, it gets +2/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Brawler's Plate
    public class BrawlersPlate15 : MagicCard
    {
        public BrawlersPlate15()
        {
            Name = "Brawler's Plate";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +2/+2 and has trample.^Equip 4";
            Flavor = "";
        }
    }
    # endregion

    # region Bronze Sable
    public class BronzeSableM15 : MagicCard
    {
        public BronzeSableM15()
        {
            Name = "Bronze Sable";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2";
            PT = "2/1";
            Type = "Artifact Creature - Sable";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Brood Keeper
    public class BroodKeeper15 : MagicCard
    {
        public BroodKeeper15()
        {
            Name = "Brood Keeper";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3R";
            PT = "2/3";
            Type = "Creature - Human Shaman";
            Text = "Whenever an Aura becomes attached to Brood Keeper, put a 2/2 red Dragon creature token with flying onto the battlefield. It has 'R: This creature gets +1/+0 until end of turn.'";
            Flavor = "";
        }
    }
    # endregion

    # region Burning Anger
    public class BurningAnger15 : MagicCard
    {
        public BurningAnger15()
        {
            Name = "Burning Anger";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^Enchanted creature has 'T: This creature deals damage equal to its power to target creature or player.'";
            Flavor = "";
        }
    }
    # endregion

    # region Cancel
    public class Cancel15 : MagicCard
    {
        public Cancel15()
        {
            Name = "Cancel";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1UU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Carnivorous Moss-Beast
    public class CarnivorousMossBeast15 : MagicCard
    {
        public CarnivorousMossBeast15()
        {
            Name = "Carnivorous Moss-Beast";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4GG";
            PT = "4/5";
            Type = "Creature - Plant Elemental Beast";
            Text = "5GG: Put a +1/+1 counter on Carnivorous Moss-Beast.";
            Flavor = "";
        }
    }
    # endregion

    # region Carrion Crow
    public class CarrionCrow15 : MagicCard
    {
        public CarrionCrow15()
        {
            Name = "Carrion Crow";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Zombie Bird";
            Text = "Flying^Carrion Crow enters the battlefield tapped.";
            Flavor = "";
        }
    }
    # endregion

    # region Caustic Tar
    public class CausticTar15 : MagicCard
    {
        public CausticTar15()
        {
            Name = "Caustic Tar";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4BB";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land^Enchanted land has 'T: Target player loses 3 life.'";
            Flavor = "";
        }
    }
    # endregion

    # region Caves of Koilos
    public class CavesofKoilos15 : MagicCard
    {
        public CavesofKoilos15()
        {
            Name = "Caves of Koilos";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "T: Add 1 to your mana pool.^T: Add W or B to your mana pool. Caves of Koilos deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Centaur Courser
    public class CentaurCourser15 : MagicCard
    {
        public CentaurCourser15()
        {
            Name = "Centaur Courser";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2G";
            PT = "3/3";
            Type = "Creature - Centaur Warrior";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Chandra, Pyromaster
    public class ChandraPyromasterM15 : MagicCard
    {
        public ChandraPyromasterM15()
        {
            Name = "Chandra, Pyromaster";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2RR";
            PT = "/4";
            Type = "Planeswalker - Chandra";
            Text = "+1: Chandra, Pyromaster deals 1 damage to target player and 1 damage to up to one target creature that player controls. That creature can't block this turn.^0: Exile the top card of your library. You may play it this turn.^-7: Exile the top ten cards of your library. Choose an instant or sorcery card exiled this way and copy it three times. You may cast the copies without paying their Costs.";
            Flavor = "";
        }
    }
    # endregion

    # region Charging Rhino
    public class ChargingRhino15 : MagicCard
    {
        public ChargingRhino15()
        {
            Name = "Charging Rhino";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3GG";
            PT = "4/4";
            Type = "Creature - Rhino";
            Text = "Charging Rhino can't be blocked by more than one creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Chasm Skulker
    public class ChasmSkulker15 : MagicCard
    {
        public ChasmSkulker15()
        {
            Name = "Chasm Skulker";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2U";
            PT = "1/1";
            Type = "Creature - Squid Horror";
            Text = "Whenever you draw a card, put a +1/+1 counter on Chasm Skulker.^When Chasm Skulker dies, put X 1/1 blue Squid creature tokens with islandwalk onto the battlefield, where X is the number of +1/+1 counters on Chasm Skulker.";
            Flavor = "";
        }
    }
    # endregion

    # region Chief Engineer
    public class ChiefEngineer15 : MagicCard
    {
        public ChiefEngineer15()
        {
            Name = "Chief Engineer";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1U";
            PT = "1/3";
            Type = "Creature - Vedalken Artificer";
            Text = "Artifact spells you cast have convoke.";
            Flavor = "";
        }
    }
    # endregion

    # region Child of Night
    public class ChildofNightM15 : MagicCard
    {
        public ChildofNightM15()
        {
            Name = "Child of Night";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1B";
            PT = "2/1";
            Type = "Creature - Vampire";
            Text = "Lifelink";
            Flavor = "";
        }
    }
    # endregion

    # region Chord of Calling
    public class ChordofCalling15 : MagicCard
    {
        public ChordofCalling15()
        {
            Name = "Chord of Calling";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "XGGG";
            PT = "";
            Type = "Instant";
            Text = "Convoke^Search your library for a creature card with converted Cost X or less and put it onto the battlefield. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Chronostutter
    public class Chronostutter15 : MagicCard
    {
        public Chronostutter15()
        {
            Name = "Chronostutter";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5U";
            PT = "";
            Type = "Instant";
            Text = "Put target creature into its owner's library second from the top.";
            Flavor = "";
        }
    }
    # endregion

    # region Circle of Flame
    public class CircleofFlame15 : MagicCard
    {
        public CircleofFlame15()
        {
            Name = "Circle of Flame";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1R";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a creature without flying attacks you or a planeswalker you control, Circle of Flame deals 1 damage to that creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Clear a Path
    public class ClearaPath15 : MagicCard
    {
        public ClearaPath15()
        {
            Name = "Clear a Path";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "R";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target creature with defender.";
            Flavor = "";
        }
    }
    # endregion

    # region Cone of Flame
    public class ConeofFlame15 : MagicCard
    {
        public ConeofFlame15()
        {
            Name = "Cone of Flame";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3RR";
            PT = "";
            Type = "Sorcery";
            Text = "Cone of Flame deals 1 damage to target creature or player, 2 damage to another target creature or player, and 3 damage to a third target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Congregate
    public class CongregateM15 : MagicCard
    {
        public CongregateM15()
        {
            Name = "Congregate";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3W";
            PT = "";
            Type = "Instant";
            Text = "Target player gains 2 life for each creature on the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Constricting Sliver
    public class ConstrictingSliver15 : MagicCard
    {
        public ConstrictingSliver15()
        {
            Name = "Constricting Sliver";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5W";
            PT = "3/3";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control have 'When this creature enters the battlefield, you may exile target creature an opponent controls until this creature leaves the battlefield.'";
            Flavor = "";
        }
    }
    # endregion

    # region Coral Barrier
    public class CoralBarrier15 : MagicCard
    {
        public CoralBarrier15()
        {
            Name = "Coral Barrier";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2U";
            PT = "1/3";
            Type = "Creature - Wall";
            Text = "Defender^When Coral Barrier enters the battlefield, put a 1/1 blue Squid creature token with islandwalk onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Covenant of Blood
    public class CovenantofBlood15 : MagicCard
    {
        public CovenantofBlood15()
        {
            Name = "Covenant of Blood";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "6B";
            PT = "";
            Type = "Sorcery";
            Text = "Convoke^Covenant of Blood deals 4 damage to target creature or player and you gain 4 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Crippling Blight
    public class CripplingBlight15 : MagicCard
    {
        public CripplingBlight15()
        {
            Name = "Crippling Blight";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^Enchanted creature gets -1/-1 and can't block.";
            Flavor = "";
        }
    }
    # endregion

    # region Crowd's Favor
    public class CrowdsFavor15 : MagicCard
    {
        public CrowdsFavor15()
        {
            Name = "Crowd's Favor";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Convoke^Target creature gets +1/+0 and gains first strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Crucible of Fire
    public class CrucibleofFire15 : MagicCard
    {
        public CrucibleofFire15()
        {
            Name = "Crucible of Fire";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3R";
            PT = "";
            Type = "Enchantment";
            Text = "Dragon creatures you control get +3/+3.";
            Flavor = "";
        }
    }
    # endregion

    # region Cruel Sadist
    public class CruelSadist15 : MagicCard
    {
        public CruelSadist15()
        {
            Name = "Cruel Sadist";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Human Assassin";
            Text = "B, T, Pay 1 life: Put a +1/+1 counter on Cruel Sadist.^2B, T, Remove X +1/+1 counters from Cruel Sadist: Cruel Sadist deals X damage to target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Darksteel Citadel
    public class DarksteelCitadel15 : MagicCard
    {
        public DarksteelCitadel15()
        {
            Name = "Darksteel Citadel";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Artifact Land";
            Text = "Indestructible^T: Add 1 to your mana pool.";
            Flavor = "";
        }

        public override void DoActivate(int i)
        {
            PArea.mana.grey += 1;
            Tap(true, false);
        }
    }
    # endregion

    # region Dauntless River Marshal
    public class DauntlessRiverMarshal15 : MagicCard
    {
        public DauntlessRiverMarshal15()
        {
            Name = "Dauntless River Marshal";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1W";
            PT = "2/1";
            Type = "Creature - Human Soldier";
            Text = "Dauntless River Marshal gets +1/+1 as long as you control an Island.^3U: Tap target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Devouring Light
    public class DevouringLight15 : MagicCard
    {
        public DevouringLight15()
        {
            Name = "Devouring Light";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1WW";
            PT = "";
            Type = "Instant";
            Text = "Convoke^Exile target attack or blocking creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Diffusion Sliver
    public class DiffusionSliver15 : MagicCard
    {
        public DiffusionSliver15()
        {
            Name = "Diffusion Sliver";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Sliver";
            Text = "Whenever a Sliver creature you control becomes the target of a spell or ability an opponent controls, counter that spell or ability unless its controller pays 2.";
            Flavor = "";
        }
    }
    # endregion

    # region Dissipate
    public class Dissipate15 : MagicCard
    {
        public Dissipate15()
        {
            Name = "Dissipate";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1UU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell. If that spell is countered this way, exile it instead of putting it into its owner's graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Divination
    public class Divination15 : MagicCard
    {
        public Divination15()
        {
            Name = "Divination";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2U";
            PT = "";
            Type = "Sorcery";
            Text = "Draw two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Divine Favor
    public class DivineFavor15 : MagicCard
    {
        public DivineFavor15()
        {
            Name = "Divine Favor";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^When Divine Favor enters the battlefield, you gain 3 life.^Enchanted creature gets +1/+3.";
            Flavor = "";
        }
    }
    # endregion

    # region Divine Verdict
    public class DivineVerdict15 : MagicCard
    {
        public DivineVerdict15()
        {
            Name = "Divine Verdict";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3W";
            PT = "";
            Type = "Instant";
            Text = "Destroy target attacking or blocking creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Elvish Mystic
    public class ElvishMystic15 : MagicCard
    {
        public ElvishMystic15()
        {
            Name = "Elvish Mystic";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Elf Druid";
            Text = "T: Add G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Encrust
    public class Encrust15 : MagicCard
    {
        public Encrust15()
        {
            Name = "Encrust";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1UU";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant artifact or creature^Enchanted permanent doesn't untap during its controller's untap step and its activated abilities can't be activated.";
            Flavor = "";
        }
    }
    # endregion

    # region Endless Obedience
    public class EndlessObedience15 : MagicCard
    {
        public EndlessObedience15()
        {
            Name = "Endless Obedience";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4BB";
            PT = "";
            Type = "Sorcery";
            Text = "Convoke^Put target creature card from a graveyard onto the battlefield under your control.";
            Flavor = "";
        }
    }
    # endregion

    # region Ensoul Artifact
    public class EnsoulArtifact15 : MagicCard
    {
        public EnsoulArtifact15()
        {
            Name = "Ensoul Artifact";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant artifact^Enchanted artifact is a creature with base power and toughness 5/5 in addition to its other types.";
            Flavor = "";
        }
    }
    # endregion

    # region Ephemeral Shields
    public class EphemeralShields15 : MagicCard
    {
        public EphemeralShields15()
        {
            Name = "Ephemeral Shields";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Convoke^Target creature gains indestructible until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Eternal Thirst
    public class EternalThirst15 : MagicCard
    {
        public EternalThirst15()
        {
            Name = "Eternal Thirst";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^Enchanted creature has lifelink and 'Whenever a creature an opponent controls dies, put a +1/+1 counter on this creature.'";
            Flavor = "";
        }
    }
    # endregion

    # region Evolving Wilds
    public class EvolvingWilds15 : MagicCard
    {
        public EvolvingWilds15()
        {
            Name = "Evolving Wilds";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "T, Sacrifice Evolving Wilds: Search your library for a basic land card and put it onto the battlefield tapped. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Feast on the Fallen
    public class FeastontheFallen15 : MagicCard
    {
        public FeastontheFallen15()
        {
            Name = "Feast on the Fallen";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2B";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of each upkeep, if an opponent lost life this turn, put a +1/+1 counter on each creature you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Feral Incarnation
    public class FeralIncarnation15 : MagicCard
    {
        public FeralIncarnation15()
        {
            Name = "Feral Incarnation";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "8G";
            PT = "";
            Type = "Sorcery";
            Text = "Convoke^Put three 3/3 green Beast creature tokens onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Festergloom
    public class Festergloom15 : MagicCard
    {
        public Festergloom15()
        {
            Name = "Festergloom";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2B";
            PT = "";
            Type = "Sorcery";
            Text = "Nonblack creatures get -1/-1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region First Response
    public class FirstResponse15 : MagicCard
    {
        public FirstResponse15()
        {
            Name = "First Response";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3W";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of each upkeep, if you lost life last turn, put a 1/1 white Soldier creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Flesh to Dust
    public class FleshtoDust15 : MagicCard
    {
        public FleshtoDust15()
        {
            Name = "Flesh to Dust";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3BB";
            PT = "";
            Type = "Instant";
            Text = "Destroy target creature. It can't be regenerated.";
            Flavor = "";
        }
    }
    # endregion

    # region Forest
    public class Forest15 : MagicCard
    {
        public Forest15()
        {
            Name = "Forest";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Basic Land - Forest";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Forge Devil
    public class ForgeDevil15 : MagicCard
    {
        public ForgeDevil15()
        {
            Name = "Forge Devil";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Devil";
            Text = "When Forge Devil enters the battlefield, it deals 1 damage to target creature and 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Foundry Street Denizen
    public class FoundryStreetDenizen15 : MagicCard
    {
        public FoundryStreetDenizen15()
        {
            Name = "Foundry Street Denizen";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Goblin Warrior";
            Text = "Whenever another red creature enters the battlefield under your control, Foundry Street Denizen gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Frenzied Goblin
    public class FrenziedGoblin15 : MagicCard
    {
        public FrenziedGoblin15()
        {
            Name = "Frenzied Goblin";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Goblin Berserker";
            Text = "Whenever Frenzied Goblin attacks, you may pay R. If you do, target creature can't block this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Frost Lynx
    public class FrostLynx15 : MagicCard
    {
        public FrostLynx15()
        {
            Name = "Frost Lynx";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2U";
            PT = "2/2";
            Type = "Creature - Elemental Cat";
            Text = "When Frost Lynx enters the battlefield, tap target creature an opponent controls. It doesn't untap during its controller's next untap step.";
            Flavor = "";
        }
    }
    # endregion

    # region Fugitive Wizard
    public class FugitiveWizard15 : MagicCard
    {
        public FugitiveWizard15()
        {
            Name = "Fugitive Wizard";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "U";
            PT = "1/1";
            Type = "Creature - Human Wizard";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Furnace Whelp
    public class FurnaceWhelp15 : MagicCard
    {
        public FurnaceWhelp15()
        {
            Name = "Furnace Whelp";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2RR";
            PT = "2/2";
            Type = "Creature - Dragon";
            Text = "Flying^R: Furnace Whelp gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Gargoyle Sentinel
    public class GargoyleSentinel15 : MagicCard
    {
        public GargoyleSentinel15()
        {
            Name = "Gargoyle Sentinel";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3";
            PT = "3/3";
            Type = "Artifact Creature - Gargoyle";
            Text = "Defender^3: Until end of turn, Gargoyle Sentinel loses defender and gains flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Garruk, Apex Predator
    public class GarrukApexPredator15 : MagicCard
    {
        public GarrukApexPredator15()
        {
            Name = "Garruk, Apex Predator";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5BG";
            PT = "/5";
            Type = "Planeswalker - Garruk";
            Text = "+1: Destroy another target planeswalker.^+1: Put a 3/3 black Beast creature token with deathtouch onto the battlefield.^-3: Destroy target creature. You gain life equal to its toughness.^-8: Target opponent gets an emblem with 'Whenever a creature attacks you, it gets +5/+5 and gains trample until end of turn.'";
            Flavor = "";
        }
    }
    # endregion

    # region Garruk's Packleader
    public class GarruksPackleader15 : MagicCard
    {
        public GarruksPackleader15()
        {
            Name = "Garruk's Packleader";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4G";
            PT = "4/4";
            Type = "Creature - Beast";
            Text = "Whenever another creature with power 3 or greater enters the battlefield under your control, you may draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Gather Courage
    public class GatherCourage15 : MagicCard
    {
        public GatherCourage15()
        {
            Name = "Gather Courage";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Convoke^Target creature gets +2/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Geist of the Moors
    public class GeistoftheMoors15 : MagicCard
    {
        public GeistoftheMoors15()
        {
            Name = "Geist of the Moors";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1WW";
            PT = "3/1";
            Type = "Creature - Spirit";
            Text = "Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Generator Servant
    public class GeneratorServant15 : MagicCard
    {
        public GeneratorServant15()
        {
            Name = "Generator Servant";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1R";
            PT = "2/1";
            Type = "Creature - Elemental";
            Text = "T, Sacrifice Generator Servant: Add 2 to your mana pool. If that mana is spent on a creature spell, it gains haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Genesis Hydra
    public class GenesisHydra15 : MagicCard
    {
        public GenesisHydra15()
        {
            Name = "Genesis Hydra";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "XGG";
            PT = "0/0";
            Type = "Creature - Plant Hydra";
            Text = "When you cast Genesis Hydra, reveal the top X cards of your library. You may put a nonland permanent card with converted Cost X or less from among them onto the battlefield. Then shuffle the rest into your library.^Genesis Hydra enters the battlefield with X +1/+1 counters on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Glacial Crasher
    public class GlacialCrasher15 : MagicCard
    {
        public GlacialCrasher15()
        {
            Name = "Glacial Crasher";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4UU";
            PT = "5/5";
            Type = "Creature - Elemental";
            Text = "Trample^Glacial Crasher can't attack unless there is a Mountain on the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Kaboomist
    public class GoblinKaboomist15 : MagicCard
    {
        public GoblinKaboomist15()
        {
            Name = "Goblin Kaboomist";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1R";
            PT = "1/2";
            Type = "Creature - Goblin Warrior";
            Text = "At the beginning of your upkeep, put a colorless artifact token named Land Mine onto the battlefield with 'R, Sacrifice this artifact: This artifact deals 2 damage to target attacking creature without flying.' Then flip a coin. If you lose the flip, Goblin Kaboomist deals 2 damage to itself.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Rabblemaster
    public class GoblinRabblemaster15 : MagicCard
    {
        public GoblinRabblemaster15()
        {
            Name = "Goblin Rabblemaster";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Goblin Warrior";
            Text = "Other Goblin creatures you control attack each turn if able.^At the beginning of combat on your turn, put a 1/1 red Goblin creature token with haste onto the battlefield.^When Goblin Rabblemaster attacks, it gets +1/+0 until end of turn for each other attacking Goblin.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Roughrider
    public class GoblinRoughrider15 : MagicCard
    {
        public GoblinRoughrider15()
        {
            Name = "Goblin Roughrider";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2R";
            PT = "3/2";
            Type = "Creature - Goblin Knight";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Gravedigger
    public class Gravedigger15 : MagicCard
    {
        public Gravedigger15()
        {
            Name = "Gravedigger";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3B";
            PT = "2/2";
            Type = "Creature - Zombie";
            Text = "When Gravedigger enters the battlefield, you may return target creature card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Grindclock
    public class Grindclock15 : MagicCard
    {
        public Grindclock15()
        {
            Name = "Grindclock";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "T: Put a charge counter on Grindclock.^T: Target player puts the top X cards of his or her library into his or her graveyard, where X is the number of charge counters on Grindclock.";
            Flavor = "";
        }
    }
    # endregion

    # region Hammerhand
    public class Hammerhand15 : MagicCard
    {
        public Hammerhand15()
        {
            Name = "Hammerhand";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^When Hammerhand enters the battlefield, target creature can't block this turn.^Enchanted creature gets +1/+1 and has haste.";
            Flavor = "";
        }
    }
    # endregion

    # region Haunted Plate Mail
    public class HauntedPlateMail15 : MagicCard
    {
        public HauntedPlateMail15()
        {
            Name = "Haunted Plate Mail";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +4/+4.^0: Until end of turn, Haunted Plate Mail becomes a 4/4 Spirit artifact creature that's no longer an Equipment. Activate this ability only if you control no creatures.^Equip 4";
            Flavor = "";
        }
    }
    # endregion

    # region Heat Ray
    public class HeatRay15 : MagicCard
    {
        public HeatRay15()
        {
            Name = "Heat Ray";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "XR";
            PT = "";
            Type = "Instant";
            Text = "Heat Ray deals X damage to target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Heliod's Pilgrim
    public class HeliodsPilgrim15 : MagicCard
    {
        public HeliodsPilgrim15()
        {
            Name = "Heliod's Pilgrim";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2W";
            PT = "1/2";
            Type = "Creature - Human Cleric";
            Text = "When Heliod's Pilgrim enters the battlefield, you may search your library for an Aura card, reveal it, put it into your hand, then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Hoarding Dragon
    public class HoardingDragon15 : MagicCard
    {
        public HoardingDragon15()
        {
            Name = "Hoarding Dragon";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3RR";
            PT = "4/4";
            Type = "Creature - Dragon";
            Text = "Flying^When Hoarding Dragon enters the battlefield, you may search your library for an artifact card, exile it, then shuffle your library.^When Hoarding Dragon dies, you may put the exiled card into its owner's hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Hornet Nest
    public class HornetNest15 : MagicCard
    {
        public HornetNest15()
        {
            Name = "Hornet Nest";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2G";
            PT = "0/2";
            Type = "Creature - Insect";
            Text = "Defender^Whenever Hornet Nest is dealt damage, put that many 1/1 green Insect creature tokens with flying and deathtouch onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Hornet Queen
    public class HornetQueen15 : MagicCard
    {
        public HornetQueen15()
        {
            Name = "Hornet Queen";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4GGG";
            PT = "2/2";
            Type = "Creature - Insect";
            Text = "Flying, deathtouch^When Hornet Queen enters the battlefield, put four 1/1 green Insect creature tokens with flying and deathtouch onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Hot Soup
    public class HotSoup15 : MagicCard
    {
        public HotSoup15()
        {
            Name = "Hot Soup";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature can't be blocked.^Whenever equipped creature is dealt damage, destroy it.^Equip 3";
            Flavor = "";
        }
    }
    # endregion

    # region Hunt the Weak
    public class HunttheWeak15 : MagicCard
    {
        public HunttheWeak15()
        {
            Name = "Hunt the Weak";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3G";
            PT = "";
            Type = "Sorcery";
            Text = "Put a +1/+1 counter on target creature you control. Then that creature fights target creature you don't control.";
            Flavor = "";
        }
    }
    # endregion

    # region Hunter's Ambush
    public class HuntersAmbush15 : MagicCard
    {
        public HuntersAmbush15()
        {
            Name = "Hunter's Ambush";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2G";
            PT = "";
            Type = "Instant";
            Text = "Prevent all combat damage that would be dealt by nongreen creatures this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Hushwing Gryff
    public class HushwingGryff15 : MagicCard
    {
        public HushwingGryff15()
        {
            Name = "Hushwing Gryff";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2W";
            PT = "2/1";
            Type = "Creature - Hippogriff";
            Text = "Flash^Flying^Creatures entering the battlefield don't cause abilities to trigger.";
            Flavor = "";
        }
    }
    # endregion

    # region Hydrosurge
    public class Hydrosurge15 : MagicCard
    {
        public Hydrosurge15()
        {
            Name = "Hydrosurge";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets -5/-0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Illusory Angel
    public class IllusoryAngel15 : MagicCard
    {
        public IllusoryAngel15()
        {
            Name = "Illusory Angel";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2U";
            PT = "4/4";
            Type = "Creature - Angel Illusion";
            Text = "Flying^Cast Illusory Angel only if you've cast another spell this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region In Garruk's Wake
    public class InGarruksWake15 : MagicCard
    {
        public InGarruksWake15()
        {
            Name = "In Garruk's Wake";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "7BB";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy all creatures you don't control and all planeswalkers you don't control.";
            Flavor = "";
        }
    }
    # endregion

    # region Indulgent Tormentor
    public class IndulgentTormentor15 : MagicCard
    {
        public IndulgentTormentor15()
        {
            Name = "Indulgent Tormentor";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3BB";
            PT = "5/3";
            Type = "Creature - Demon";
            Text = "Flying^At the beginning of your upkeep, draw a card unless target opponent sacrifices a creature or pays 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Inferno Fist
    public class InfernoFist15 : MagicCard
    {
        public InfernoFist15()
        {
            Name = "Inferno Fist";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature you control^Enchanted creature gets +2/+0.^R, Sacrifice Inferno Fist: Inferno Fist deals 2 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Inspired Charge
    public class InspiredCharge15 : MagicCard
    {
        public InspiredCharge15()
        {
            Name = "Inspired Charge";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2WW";
            PT = "";
            Type = "Instant";
            Text = "Creatures you control get +2/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Into the Void
    public class IntotheVoid15 : MagicCard
    {
        public IntotheVoid15()
        {
            Name = "Into the Void";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3U";
            PT = "";
            Type = "Sorcery";
            Text = "Return up to two target creatures to their owners' hands.";
            Flavor = "";
        }
    }
    # endregion

    # region Invasive Species
    public class InvasiveSpecies15 : MagicCard
    {
        public InvasiveSpecies15()
        {
            Name = "Invasive Species";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2G";
            PT = "3/3";
            Type = "Creature - Insect";
            Text = "When Invasive Species enters the battlefield, return another permanent you control to its owner's hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Invisibility
    public class Invisibility15 : MagicCard
    {
        public Invisibility15()
        {
            Name = "Invisibility";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "UU";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^Enchanted creature can't be blocked except by Walls.";
            Flavor = "";
        }
    }
    # endregion

    # region Island
    public class Island15 : MagicCard
    {
        public Island15()
        {
            Name = "Island";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Basic Land - Island";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Jace, the Living Guildpact
    public class JacetheLivingGuildpact15 : MagicCard
    {
        public JacetheLivingGuildpact15()
        {
            Name = "Jace, the Living Guildpact";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2UU";
            PT = "/5";
            Type = "Planeswalker - Jace";
            Text = "+1: Look at the top two cards of your library. Put one of them into your graveyard.^-3: Return another target nonland permanent to its owner's hand.^-8: Each player shuffles his or her hand and graveyard into his or her library. You draw seven cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Jace's Ingenuity
    public class JacesIngenuity15 : MagicCard
    {
        public JacesIngenuity15()
        {
            Name = "Jace's Ingenuity";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3UU";
            PT = "";
            Type = "Instant";
            Text = "Draw three cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Jalira, Master Polymorphist
    public class JaliraMasterPolymorphist15 : MagicCard
    {
        public JaliraMasterPolymorphist15()
        {
            Name = "Jalira, Master Polymorphist";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3U";
            PT = "2/2";
            Type = "Legendary Creature - Human Wizard";
            Text = "2U, T, Sacrifice another creature: Reveal cards from the top of your library until you reveal a nonlegendary creature card. Put that card onto the battlefield and the rest on the bottom of your library in a random order.";
            Flavor = "";
        }
    }
    # endregion

    # region Jorubai Murk Lurker
    public class JorubaiMurkLurker15 : MagicCard
    {
        public JorubaiMurkLurker15()
        {
            Name = "Jorubai Murk Lurker";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2U";
            PT = "1/3";
            Type = "Creature - Leech";
            Text = "Jorubai Murk Lurker gets +1/+1 as long as you control a Swamp.^1B: Target creature gains lifelink until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Juggernaut
    public class Juggernaut15 : MagicCard
    {
        public Juggernaut15()
        {
            Name = "Juggernaut";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4";
            PT = "5/3";
            Type = "Artifact Creature - Juggernaut";
            Text = "Juggernaut attacks each turn if able.^Juggernaut can't be blocked by Walls.";
            Flavor = "";
        }
    }
    # endregion

    # region Kalonian Twingrove
    public class KalonianTwingrove15 : MagicCard
    {
        public KalonianTwingrove15()
        {
            Name = "Kalonian Twingrove";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5G";
            PT = "*/*";
            Type = "Creature - Treefolk Warrior";
            Text = "Kalonian Twingrove's power and toughness are each equal to the number of Forests you control.^When Kalonian Twingrove enters the battlefield, put a green Treefolk Warrior creature token onto the battlefield with 'This creature's power and toughness are each equal to the number of Forests you control.'";
            Flavor = "";
        }
    }
    # endregion

    # region Kapsho Kitefins
    public class KapshoKitefins15 : MagicCard
    {
        public KapshoKitefins15()
        {
            Name = "Kapsho Kitefins";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4UU";
            PT = "3/3";
            Type = "Creature - Fish";
            Text = "Flying^Whenever Kapsho Kitefins or another creature enters the battlefield under your control, tap target creature an opponent controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Kinsbaile Skirmisher
    public class KinsbaileSkirmisher15 : MagicCard
    {
        public KinsbaileSkirmisher15()
        {
            Name = "Kinsbaile Skirmisher";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1W";
            PT = "2/2";
            Type = "Creature - Kithkin Soldier";
            Text = "When Kinsbaile Skirmisher enters the battlefield, target creature gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Kird Chieftain
    public class KirdChieftain15 : MagicCard
    {
        public KirdChieftain15()
        {
            Name = "Kird Chieftain";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3R";
            PT = "3/3";
            Type = "Creature - Ape";
            Text = "Kird Chieftain gets +1/+1 as long as you control a Forest.^4G: Target creature gets +2/+2 and gains trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Krenko's Enforcer
    public class KrenkosEnforcer15 : MagicCard
    {
        public KrenkosEnforcer15()
        {
            Name = "Krenko's Enforcer";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1RR";
            PT = "2/2";
            Type = "Creature - Goblin Warrior";
            Text = "Intimidate";
            Flavor = "";
        }
    }
    # endregion

    # region Kurkesh, Onakke Ancient
    public class KurkeshOnakkeAncient15 : MagicCard
    {
        public KurkeshOnakkeAncient15()
        {
            Name = "Kurkesh, Onakke Ancient";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2RR";
            PT = "4/3";
            Type = "Legendary Creature - Ogre Spirit";
            Text = "Whenever you activate an ability of an artifact, if it isn't a mana ability, you may pay R. If you do, copy that ability. You may choose new targets for the copy.";
            Flavor = "";
        }
    }
    # endregion

    # region Lava Axe
    public class LavaAxe15 : MagicCard
    {
        public LavaAxe15()
        {
            Name = "Lava Axe";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4R";
            PT = "";
            Type = "Sorcery";
            Text = "Lava Axe deals 5 damage to target player.";
            Flavor = "";
        }
    }
    # endregion

    # region Leeching Sliver
    public class LeechingSliver15 : MagicCard
    {
        public LeechingSliver15()
        {
            Name = "Leeching Sliver";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1B";
            PT = "1/1";
            Type = "Creature - Sliver";
            Text = "Whenever a Sliver you control attacks, defending player loses 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Life's Legacy
    public class LifesLegacy15 : MagicCard
    {
        public LifesLegacy15()
        {
            Name = "Life's Legacy";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1G";
            PT = "";
            Type = "Sorcery";
            Text = "As an additional cost to cast Life's Legacy, sacrifice a creature.^Draw cards equal to the sacrificed creature's power.";
            Flavor = "";
        }
    }
    # endregion

    # region Lightning Strike
    public class LightningStrike15 : MagicCard
    {
        public LightningStrike15()
        {
            Name = "Lightning Strike";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "Lightning Strike deals 3 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Liliana Vess
    public class LilianaVess15 : MagicCard
    {
        public LilianaVess15()
        {
            Name = "Liliana Vess";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3BB";
            PT = "/5";
            Type = "Planeswalker - Liliana";
            Text = "+1: Target player discards a card.^-2: Search your library for a card, then shuffle your library and put that card on top of it.^-8: Put all creature cards from all graveyards onto the battlefield under your control.";
            Flavor = "";
        }
    }
    # endregion

    # region Living Totem
    public class LivingTotem15 : MagicCard
    {
        public LivingTotem15()
        {
            Name = "Living Totem";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3G";
            PT = "2/3";
            Type = "Creature - Plant Elemental";
            Text = "Convoke^When Living Totem enters the battlefield, you may put a +1/+1 counter on another target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Llanowar Wastes
    public class LlanowarWastes15 : MagicCard
    {
        public LlanowarWastes15()
        {
            Name = "Llanowar Wastes";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "T: Add 1 to your mana pool.^T: Add B or G to your mana pool. Llanowar Wastes deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Mahamoti Djinn
    public class MahamotiDjinn15 : MagicCard
    {
        public MahamotiDjinn15()
        {
            Name = "Mahamoti Djinn";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4UU";
            PT = "5/6";
            Type = "Creature - Djinn";
            Text = "Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Marked by Honor
    public class MarkedbyHonor15 : MagicCard
    {
        public MarkedbyHonor15()
        {
            Name = "Marked by Honor";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^Enchanted creature gets +2/+2 and has vigilance.";
            Flavor = "";
        }
    }
    # endregion

    # region Mass Calcify
    public class MassCalcify15 : MagicCard
    {
        public MassCalcify15()
        {
            Name = "Mass Calcify";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5WW";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy all nonwhite creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Master of Predicaments
    public class MasterofPredicaments15 : MagicCard
    {
        public MasterofPredicaments15()
        {
            Name = "Master of Predicaments";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3UU";
            PT = "4/4";
            Type = "Creature - Sphinx";
            Text = "Flying^Whenever Master of Predicaments deals combat damage to a player, choose a card in your hand. That player guesses whether the card's converted Cost is greater than 4. If the player guessed wrong, you may cast the card without paying its Cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Meditation Puzzle
    public class MeditationPuzzle15 : MagicCard
    {
        public MeditationPuzzle15()
        {
            Name = "Meditation Puzzle";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3WW";
            PT = "";
            Type = "Instant";
            Text = "Convoke^You gain 8 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Mercurial Pretender
    public class MercurialPretender15 : MagicCard
    {
        public MercurialPretender15()
        {
            Name = "Mercurial Pretender";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4U";
            PT = "0/0";
            Type = "Creature - Shapeshifter";
            Text = "You may have Mercurial Pretender enter the battlefield as a copy of any creature you control except it gains '2UU: Return this creature to its owner's hand.'";
            Flavor = "";
        }
    }
    # endregion

    # region Meteorite
    public class Meteorite15 : MagicCard
    {
        public Meteorite15()
        {
            Name = "Meteorite";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "When Meteorite enters the battlefield, it deals 2 damage to target creature or player.^T: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Midnight Guard
    public class MidnightGuard15 : MagicCard
    {
        public MidnightGuard15()
        {
            Name = "Midnight Guard";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2W";
            PT = "2/3";
            Type = "Creature - Human Soldier";
            Text = "Whenever another creature enters the battlefield, untap Midnight Guard.";
            Flavor = "";
        }
    }
    # endregion

    # region Might Makes Right
    public class MightMakesRight15 : MagicCard
    {
        public MightMakesRight15()
        {
            Name = "Might Makes Right";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5R";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of combat on your turn, if you control each creature on the battlefield with the greatest power, gain control of target creature an opponent controls until end of turn. Untap that creature. It gains haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Military Intelligence
    public class MilitaryIntelligence15 : MagicCard
    {
        public MilitaryIntelligence15()
        {
            Name = "Military Intelligence";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1U";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever you attack with two or more creatures, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Mind Rot
    public class MindRot15 : MagicCard
    {
        public MindRot15()
        {
            Name = "Mind Rot";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2B";
            PT = "";
            Type = "Sorcery";
            Text = "Target player discards two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Mind Sculpt
    public class MindSculpt15 : MagicCard
    {
        public MindSculpt15()
        {
            Name = "Mind Sculpt";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1U";
            PT = "";
            Type = "Sorcery";
            Text = "Target opponent puts the top seven cards of his or her library into his or her graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Miner's Bane
    public class MinersBane15 : MagicCard
    {
        public MinersBane15()
        {
            Name = "Miner's Bane";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4RR";
            PT = "6/3";
            Type = "Creature - Elemental";
            Text = "2R: Miner's Bane gets +1/+0 and gains trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Mountain
    public class Mountain15 : MagicCard
    {
        public Mountain15()
        {
            Name = "Mountain";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Basic Land - Mountain";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Naturalize
    public class Naturalize15 : MagicCard
    {
        public Naturalize15()
        {
            Name = "Naturalize";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Destroy target artifact or enchantment.";
            Flavor = "";
        }
    }
    # endregion

    # region Necrobite
    public class Necrobite15 : MagicCard
    {
        public Necrobite15()
        {
            Name = "Necrobite";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2B";
            PT = "";
            Type = "Instant";
            Text = "Target creature gains deathtouch until end of turn. Regenerate it.";
            Flavor = "";
        }
    }
    # endregion

    # region Necrogen Scudder
    public class NecrogenScudder15 : MagicCard
    {
        public NecrogenScudder15()
        {
            Name = "Necrogen Scudder";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2B";
            PT = "3/3";
            Type = "Creature - Horror";
            Text = "Flying^When Necrogen Scudder enters the battlefield, you lose 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Necromancer's Assistant
    public class NecromancersAssistant15 : MagicCard
    {
        public NecromancersAssistant15()
        {
            Name = "Necromancer's Assistant";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2B";
            PT = "3/1";
            Type = "Creature - Zombie";
            Text = "When Necromancer's Assistant enters the battlefield, put the top three cards of your library into your graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Necromancer's Stockpile
    public class NecromancersStockpile15 : MagicCard
    {
        public NecromancersStockpile15()
        {
            Name = "Necromancer's Stockpile";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1B";
            PT = "";
            Type = "Enchantment";
            Text = "1B, Discard a creature card: Draw a card. If the discarded card was a Zombie card, put a 2/2 black Zombie creature token onto the battlefield tapped.";
            Flavor = "";
        }
    }
    # endregion

    # region Negate
    public class Negate15 : MagicCard
    {
        public Negate15()
        {
            Name = "Negate";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Counter target noncreature spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Netcaster Spider
    public class NetcasterSpider15 : MagicCard
    {
        public NetcasterSpider15()
        {
            Name = "Netcaster Spider";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2G";
            PT = "2/3";
            Type = "Creature - Spider";
            Text = "Reach^Whenever Netcaster Spider blocks a creature with flying, Netcaster Spider gets +2/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Nightfire Giant
    public class NightfireGiant15 : MagicCard
    {
        public NightfireGiant15()
        {
            Name = "Nightfire Giant";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4B";
            PT = "4/3";
            Type = "Creature - Zombie Giant";
            Text = "Nightfire Giant gets +1/+1 as long as you control a Mountain.^4R: Nightfire Giant deals 2 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Nightmare
    public class Nightmare15 : MagicCard
    {
        public Nightmare15()
        {
            Name = "Nightmare";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5B";
            PT = "*/*";
            Type = "Creature - Nightmare Horse";
            Text = "Flying^Nightmare's power and toughness are each equal to the number of Swamps you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Nimbus of the Isles
    public class NimbusoftheIsles15 : MagicCard
    {
        public NimbusoftheIsles15()
        {
            Name = "Nimbus of the Isles";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4U";
            PT = "3/3";
            Type = "Creature - Elemental";
            Text = "Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Nissa, Worldwaker
    public class NissaWorldwaker15 : MagicCard
    {
        public NissaWorldwaker15()
        {
            Name = "Nissa, Worldwaker";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3GG";
            PT = "/3";
            Type = "Planeswalker - Nissa";
            Text = "+1: Target land you control becomes a 4/4 Elemental creature with trample. It's still a land.^+1: Untap up to four target Forests.^-7: Search your library for any number of basic land cards, put them onto the battlefield, then shuffle your library. Those lands become 4/4 Elemental creatures with trample. They're still lands.";
            Flavor = "";
        }
    }
    # endregion

    # region Nissa's Expedition
    public class NissasExpedition15 : MagicCard
    {
        public NissasExpedition15()
        {
            Name = "Nissa's Expedition";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4G";
            PT = "";
            Type = "Sorcery";
            Text = "Convoke^Search your library for up to two basic land cards, put them onto the battlefield tapped, then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Ob Nixilis, Unshackled
    public class ObNixilisUnshackled15 : MagicCard
    {
        public ObNixilisUnshackled15()
        {
            Name = "Ob Nixilis, Unshackled";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4BB";
            PT = "4/4";
            Type = "Legendary Creature - Demon";
            Text = "Flying, trample^Whenever an opponent searches his or her library, that player sacrifices a creature and loses 10 life.^Whenever another creature dies, put at +1/+1 counter on Ob Nixilis, Unshackled.";
            Flavor = "";
        }
    }
    # endregion

    # region Obelisk of Urd
    public class ObeliskofUrd15 : MagicCard
    {
        public ObeliskofUrd15()
        {
            Name = "Obelisk of Urd";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "6";
            PT = "";
            Type = "Artifact";
            Text = "Convoke^As Obelisk of Urd enters the battlefield, choose a creature type.^Creatures you control of the chosen type get +2/+2.";
            Flavor = "";
        }
    }
    # endregion

    # region Oppressive Rays
    public class OppressiveRays15 : MagicCard
    {
        public OppressiveRays15()
        {
            Name = "Oppressive Rays";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^Enchanted creature can't attack or block unless its controller pays 3.^Activated abilities of enchanted creature cost 3 more to activate.";
            Flavor = "";
        }
    }
    # endregion

    # region Oreskos Swiftclaw
    public class OreskosSwiftclaw15 : MagicCard
    {
        public OreskosSwiftclaw15()
        {
            Name = "Oreskos Swiftclaw";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1W";
            PT = "3/1";
            Type = "Creature - Cat Warrior";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Ornithopter
    public class Ornithopter15 : MagicCard
    {
        public Ornithopter15()
        {
            Name = "Ornithopter";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "0";
            PT = "0/2";
            Type = "Artifact Creature - Thopter";
            Text = "Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Overwhelm
    public class Overwhelm15 : MagicCard
    {
        public Overwhelm15()
        {
            Name = "Overwhelm";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5GG";
            PT = "";
            Type = "Sorcery";
            Text = "Convoke^Creatures you control get +3/+3 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Paragon of Eternal Wilds
    public class ParagonofEternalWilds15 : MagicCard
    {
        public ParagonofEternalWilds15()
        {
            Name = "Paragon of Eternal Wilds";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3G";
            PT = "2/2";
            Type = "Creature - Human Druid";
            Text = "Other green creatures you control get +1/+1.^G, t: Another target green creature you control gains trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Paragon of Fierce Defiance
    public class ParagonofFierceDefiance15 : MagicCard
    {
        public ParagonofFierceDefiance15()
        {
            Name = "Paragon of Fierce Defiance";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3R";
            PT = "2/2";
            Type = "Creature - Human Warrior";
            Text = "Other red creatures you control get +1/+1.^R, T: Another target red creature you control gains haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Paragon of Gathering Mists
    public class ParagonofGatheringMists15 : MagicCard
    {
        public ParagonofGatheringMists15()
        {
            Name = "Paragon of Gathering Mists";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3U";
            PT = "2/2";
            Type = "Creature - Human Wizard";
            Text = "Other blue creatures you control get +1/+1.^U, T: Another target blue creature you control gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Paragon of New Dawns
    public class ParagonofNewDawns15 : MagicCard
    {
        public ParagonofNewDawns15()
        {
            Name = "Paragon of New Dawns";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3W";
            PT = "2/2";
            Type = "Creature - Human Soldier";
            Text = "Other white creatures you control get +1/+1.^W, T: Another target white creature you control gains vigilance until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Paragon of Open Graves
    public class ParagonofOpenGraves15 : MagicCard
    {
        public ParagonofOpenGraves15()
        {
            Name = "Paragon of Open Graves";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3B";
            PT = "2/2";
            Type = "Creature - Skeleton Warrior";
            Text = "Other black creatures you control get +1/+1.^2B, T: Another target black creature you control gains deathtouch until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Peel from Reality
    public class PeelfromReality15 : MagicCard
    {
        public PeelfromReality15()
        {
            Name = "Peel from Reality";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Return target creature you control and target creature you don't control to their owners' hands.";
            Flavor = "";
        }
    }
    # endregion

    # region Perilous Vault
    public class PerilousVault15 : MagicCard
    {
        public PerilousVault15()
        {
            Name = "Perilous Vault";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "5, T, Exile Perilous Vault: Exile all nonland permanents.";
            Flavor = "";
        }
    }
    # endregion

    # region Phyrexian Revoker
    public class PhyrexianRevoker15 : MagicCard
    {
        public PhyrexianRevoker15()
        {
            Name = "Phyrexian Revoker";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2";
            PT = "2/1";
            Type = "Artifact Creature - Horror";
            Text = "As Phyrexian Revoker enters the battlefield, name a nonland card.^Activated abilities of sources with the chosen name can't be activated.";
            Flavor = "";
        }
    }
    # endregion

    # region Phytotitan
    public class Phytotitan15 : MagicCard
    {
        public Phytotitan15()
        {
            Name = "Phytotitan";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4GG";
            PT = "7/2";
            Type = "Creature - Plant Elemental";
            Text = "When Phytotitan dies, return it to the battlefield tapped under its owner's control at the beginning of his or her next upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Pillar of Light
    public class PillarofLight15 : MagicCard
    {
        public PillarofLight15()
        {
            Name = "Pillar of Light";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2W";
            PT = "";
            Type = "Instant";
            Text = "Exile target creature with toughness 4 or greater.";
            Flavor = "";
        }
    }
    # endregion

    # region Plains
    public class Plains15 : MagicCard
    {
        public Plains15()
        {
            Name = "Plains";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Basic Land - Plains";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Plummet
    public class Plummet15 : MagicCard
    {
        public Plummet15()
        {
            Name = "Plummet";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Destroy target creature with flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Polymorphist's Jest
    public class PolymorphistsJest15 : MagicCard
    {
        public PolymorphistsJest15()
        {
            Name = "Polymorphist's Jest";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1UU";
            PT = "";
            Type = "Instant";
            Text = "Until end of turn, each creature target player controls loses all abilities and becomes a blue Frog with base power and toughness 1/1.";
            Flavor = "";
        }
    }
    # endregion

    # region Preeminent Captain
    public class PreeminentCaptain15 : MagicCard
    {
        public PreeminentCaptain15()
        {
            Name = "Preeminent Captain";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Kithkin Soldier";
            Text = "FIrst strike^Whenever Preeminent Captain attacks, you may put a Soldier creature card from your hand onto the battlefield tapped and attacking.";
            Flavor = "";
        }
    }
    # endregion

    # region Profane Memento
    public class ProfaneMemento15 : MagicCard
    {
        public ProfaneMemento15()
        {
            Name = "Profane Memento";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a creature card is put into an opponent's graveyard from anywhere, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Quickling
    public class Quickling15 : MagicCard
    {
        public Quickling15()
        {
            Name = "Quickling";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1U";
            PT = "2/2";
            Type = "Creature - Faerie Rogue";
            Text = "Flying^Flash^When Quickling enters the battlefield, sacrifice it unless you return another creature you control to its owner's hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Radiant Fountain
    public class RadiantFountain15 : MagicCard
    {
        public RadiantFountain15()
        {
            Name = "Radiant Fountain";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "When Radiant Fountain enters the battlefield, you gain 2 life.^T: Add 1 to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Raise the Alarm
    public class RaisetheAlarm15 : MagicCard
    {
        public RaisetheAlarm15()
        {
            Name = "Raise the Alarm";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Put two 1/1 white Soldier creature tokens onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Ranger's Guile
    public class RangersGuile15 : MagicCard
    {
        public RangersGuile15()
        {
            Name = "Ranger's Guile";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Target creature you control gets +1/+1 and gains hexproof until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Razorfoot Griffin
    public class RazorfootGriffin15 : MagicCard
    {
        public RazorfootGriffin15()
        {
            Name = "Razorfoot Griffin";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3W";
            PT = "2/2";
            Type = "Creature - Griffin";
            Text = "Flying^First strike";
            Flavor = "";
        }
    }
    # endregion

    # region Reclamation Sage
    public class ReclamationSage15 : MagicCard
    {
        public ReclamationSage15()
        {
            Name = "Reclamation Sage";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2G";
            PT = "2/1";
            Type = "Creature - Elf Shaman";
            Text = "When Reclamation Sage enters the battlefield, you may destroy target artifact or enchantment.";
            Flavor = "";
        }
    }
    # endregion

    # region Research Assistant
    public class ResearchAssistant15 : MagicCard
    {
        public ResearchAssistant15()
        {
            Name = "Research Assistant";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1U";
            PT = "1/3";
            Type = "Creature - Human Wizard";
            Text = "3U, T: Draw a card, then discard a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Resolute Archangel
    public class ResoluteArchangel15 : MagicCard
    {
        public ResoluteArchangel15()
        {
            Name = "Resolute Archangel";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5WW";
            PT = "4/4";
            Type = "Creature - Angel";
            Text = "Flying^When Resolute Angel enters the battlefield, if your life total is lower than your starting life total, it becomes equal to your starting life total.";
            Flavor = "";
        }
    }
    # endregion

    # region Restock
    public class Restock15 : MagicCard
    {
        public Restock15()
        {
            Name = "Restock";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3GG";
            PT = "";
            Type = "Sorcery";
            Text = "Return two target cards from your graveyard to your hand. Exile Restock.";
            Flavor = "";
        }
    }
    # endregion

    # region Return to the Ranks
    public class ReturntotheRanks15 : MagicCard
    {
        public ReturntotheRanks15()
        {
            Name = "Return to the Ranks";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "XWW";
            PT = "";
            Type = "Sorcery";
            Text = "Convoke^Return X target creature cards with converted Cost 2 or less from your graveyard to the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Roaring Primadox
    public class RoaringPrimadox15 : MagicCard
    {
        public RoaringPrimadox15()
        {
            Name = "Roaring Primadox";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3G";
            PT = "4/4";
            Type = "Creature - Beast";
            Text = "At the beginning of your upkeep, return a creature you control to its owner's hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Rogue's Gloves
    public class RoguesGloves15 : MagicCard
    {
        public RoguesGloves15()
        {
            Name = "Rogue's Gloves";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Whenever equipped creature deals combat damage to a player, you may draw a card.^Equip 2";
            Flavor = "";
        }
    }
    # endregion

    # region Rotfeaster Maggot
    public class RotfeasterMaggot15 : MagicCard
    {
        public RotfeasterMaggot15()
        {
            Name = "Rotfeaster Maggot";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4B";
            PT = "3/5";
            Type = "Creature - Insect";
            Text = "When Rotfeaster Maggot enters the battlefield, exile target creature card from a graveyard. You gain life equal to that card's toughness.";
            Flavor = "";
        }
    }
    # endregion

    # region Rummaging Goblin
    public class RummagingGoblin15 : MagicCard
    {
        public RummagingGoblin15()
        {
            Name = "Rummaging Goblin";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2R";
            PT = "1/1";
            Type = "Creature - Goblin Rogue";
            Text = "T, Discard a card: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Runeclaw Bear
    public class RuneclawBear15 : MagicCard
    {
        public RuneclawBear15()
        {
            Name = "Runeclaw Bear";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1G";
            PT = "2/2";
            Type = "Creature - Bear";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Sacred Armory
    public class SacredArmory15 : MagicCard
    {
        public SacredArmory15()
        {
            Name = "Sacred Armory";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "2: Target creature gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Sanctified Charge
    public class SanctifiedCharge15 : MagicCard
    {
        public SanctifiedCharge15()
        {
            Name = "Sanctified Charge";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4W";
            PT = "";
            Type = "Instant";
            Text = "Creatures you control get +2/+1 until end of turn. White creatures you control also gain first strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Satyr Wayfinder
    public class SatyrWayfinder15 : MagicCard
    {
        public SatyrWayfinder15()
        {
            Name = "Satyr Wayfinder";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1G";
            PT = "1/1";
            Type = "Creature - Satyr";
            Text = "When Satyr Wayfinder enters the battlefield, reveal the top four cards of your library. You may put a land card from among them into your hand. Put the rest into your graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Scrapyard Mongrel
    public class ScrapyardMongrel15 : MagicCard
    {
        public ScrapyardMongrel15()
        {
            Name = "Scrapyard Mongrel";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3R";
            PT = "3/3";
            Type = "Creature - Hound";
            Text = "As long as you control an artifact, Scrapyard Mongrel gets +2/+0 and has trample.";
            Flavor = "";
        }
    }
    # endregion

    # region Scuttling Doom Engine
    public class ScuttlingDoomEngine15 : MagicCard
    {
        public ScuttlingDoomEngine15()
        {
            Name = "Scuttling Doom Engine";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "6";
            PT = "6/6";
            Type = "Artifact Creature - Construct";
            Text = "Scuttling Doom Engine can't be blocked by creatures with power 2 or less.^When Scuttling Doom Engine dies, it deals 6 damage to target opponnent.";
            Flavor = "";
        }
    }
    # endregion

    # region Seismic Strike
    public class SeismicStrike15 : MagicCard
    {
        public SeismicStrike15()
        {
            Name = "Seismic Strike";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2R";
            PT = "";
            Type = "Instant";
            Text = "Seismic Strike deals damage to target creature equal to the number of Mountains you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Selfless Cathar
    public class SelflessCathar15 : MagicCard
    {
        public SelflessCathar15()
        {
            Name = "Selfless Cathar";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Human Cleric";
            Text = "1W, Sacrifice Selfless Cathar: Creatures you control get +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Sengir Vampire
    public class SengirVampire15 : MagicCard
    {
        public SengirVampire15()
        {
            Name = "Sengir Vampire";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3BB";
            PT = "4/4";
            Type = "Creature - Vampire";
            Text = "Flying^Whenever a creature dealt damage by Sengir Vampire this turn dies, put a +1/+1 counter on Sengir Vampire.";
            Flavor = "";
        }
    }
    # endregion

    # region Seraph of the Masses
    public class SeraphoftheMasses15 : MagicCard
    {
        public SeraphoftheMasses15()
        {
            Name = "Seraph of the Masses";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5WW";
            PT = "*/*";
            Type = "Creature - Angel";
            Text = "Convoke^Flying^Seraph of the Masses's power and toughness are each equal to the number of creatures you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Serra Angel
    public class SerraAngel15 : MagicCard
    {
        public SerraAngel15()
        {
            Name = "Serra Angel";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3WW";
            PT = "4/4";
            Type = "Creature - Angel";
            Text = "Flying^Vigilance";
            Flavor = "";
        }
    }
    # endregion

    # region Shadowcloak Vampire
    public class ShadowcloakVampire15 : MagicCard
    {
        public ShadowcloakVampire15()
        {
            Name = "Shadowcloak Vampire";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4B";
            PT = "4/3";
            Type = "Creature - Vampire";
            Text = "Pay 2 life: Shadowcloak Vampire gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Shaman of Spring
    public class ShamanofSpring15 : MagicCard
    {
        public ShamanofSpring15()
        {
            Name = "Shaman of Spring";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3G";
            PT = "2/2";
            Type = "Creature - Elf Shaman";
            Text = "When Shaman of Spring enters the battlefield, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Shield of the Avatar
    public class ShieldoftheAvatar15 : MagicCard
    {
        public ShieldoftheAvatar15()
        {
            Name = "Shield of the Avatar";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "If a source would deal damage to equipped creature, prevent X of that damage, where X is the number of creatures you control.^Equip 2";
            Flavor = "";
        }
    }
    # endregion

    # region Shivan Dragon
    public class ShivanDragon15 : MagicCard
    {
        public ShivanDragon15()
        {
            Name = "Shivan Dragon";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4RR";
            PT = "5/5";
            Type = "Creature - Dragon";
            Text = "Flying^R: Shivan Dragon gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Shivan Reef
    public class ShivanReef15 : MagicCard
    {
        public ShivanReef15()
        {
            Name = "Shivan Reef";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "T: Add 1 to your mana pool.^T: Add U or R to your mana pool. Shivan Reef deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Shrapnel Blast
    public class ShrapnelBlast15 : MagicCard
    {
        public ShrapnelBlast15()
        {
            Name = "Shrapnel Blast";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "As an additional cost to cast Shrapnel Blast, sacrifice an artifact.^Shrapnel Blast deals 5 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Siege Dragon
    public class SiegeDragon15 : MagicCard
    {
        public SiegeDragon15()
        {
            Name = "Siege Dragon";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5RR";
            PT = "5/5";
            Type = "Creature - Dragon";
            Text = "Flying^When Siege Dragon enters the battlefield, destroy all Walls your opponents control.^Whenever Siege Dragon attacks, if defending player controls no Walls, it deals 2 damage to each creature without flying that player controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Siege Wurm
    public class SiegeWurm15 : MagicCard
    {
        public SiegeWurm15()
        {
            Name = "Siege Wurm";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5GG";
            PT = "5/5";
            Type = "Creature - Wurm";
            Text = "Convoke^Trample";
            Flavor = "";
        }
    }
    # endregion

    # region Sign in Blood
    public class SigninBlood15 : MagicCard
    {
        public SigninBlood15()
        {
            Name = "Sign in Blood";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "BB";
            PT = "";
            Type = "Sorcery";
            Text = "Target player draws two cards and loses 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Sliver Hive
    public class SliverHive15 : MagicCard
    {
        public SliverHive15()
        {
            Name = "Sliver Hive";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "T: Add 1 to your mana pool.^T: Add one mana of any color to your mana pool. Spend this mana only to cast a Sliver spell.^5, T: Put a 1/1 colorless Sliver creature token onto the battlefield. Activate this ability only if you control a Sliver.";
            Flavor = "";
        }

        public override bool TryActivate(int i)
        {
            if (Tapped)
            {
                return false;
            }

            Tap(true, false);
            DoActivate(i);
            return true;
        }

        public override void DoActivate(int i)
        {
            if (i == 0)
            {
                PArea.mana.grey += 1;
            }
            if (i == 1)
            {
                PArea.mw.ShowWheel("BGURW");
            }
        }
    }
    # endregion

    # region Sliver Hivelord
    public class SliverHivelord15 : MagicCard
    {
        public SliverHivelord15()
        {
            Name = "Sliver Hivelord";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "WUBRG";
            PT = "5/5";
            Type = "Legendary Creature - Sliver";
            Text = "Sliver creatures you control have indestructible.";
            Flavor = "";
        }
    }
    # endregion

    # region Solemn Offering
    public class SolemnOffering15 : MagicCard
    {
        public SolemnOffering15()
        {
            Name = "Solemn Offering";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2W";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target artifact or enchantment. You gain 4 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul of Innistrad
    public class SoulofInnistrad15 : MagicCard
    {
        public SoulofInnistrad15()
        {
            Name = "Soul of Innistrad";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4BB";
            PT = "6/6";
            Type = "Creature - Avatar";
            Text = "Deathtouch^3BB: Return up to three target creature cards from your graveyard to your hand.^3BB, Exile Soul of Innistrad from your graveyard: Return up to three target creature cards from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul of New Phyrexia
    public class SoulofNewPhyrexia15 : MagicCard
    {
        public SoulofNewPhyrexia15()
        {
            Name = "Soul of New Phyrexia";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "6";
            PT = "6/6";
            Type = "Artifact Creature - Avatar";
            Text = "Trample^5: Permanents you control gain indestructible until end of turn.^5, Exile Soul of New Phyrexia from your graveyard: Permanents you control gain indestructible until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul of Ravnica
    public class SoulofRavnica15 : MagicCard
    {
        public SoulofRavnica15()
        {
            Name = "Soul of Ravnica";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4UU";
            PT = "6/6";
            Type = "Creature - Avatar";
            Text = "Flying^5UU: Draw a card for each color among permanents you control.^5UU, Exile Soul of Ravnica from your graveyard: Draw a card for each color among permanents you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul of Shandalar
    public class SoulofShandalar15 : MagicCard
    {
        public SoulofShandalar15()
        {
            Name = "Soul of Shandalar";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4RR";
            PT = "6/6";
            Type = "Creature - Avatar";
            Text = "First strike^3RR: Soul of Shandalar deals 3 damage to target player and 3 damage to up to one target creature that player controls.^3RR, Exile Soul of Shandalar from your graveyard: Soul of Shandalar deals 3 damage to target player and 3 damage to up to one target creature that player controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul of Theros
    public class SoulofTheros15 : MagicCard
    {
        public SoulofTheros15()
        {
            Name = "Soul of Theros";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4WW";
            PT = "6/6";
            Type = "Creature - Avatar";
            Text = "Vigilance^4WW: Creatures you control get +2/+2 and gain first strike and lifelink until end of turn.^4WW, Exile Soul of Theros from your graveyard: Creatures you control get +2/+2 and gain first strike and lifelink until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul of Zendikar
    public class SoulofZendikar15 : MagicCard
    {
        public SoulofZendikar15()
        {
            Name = "Soul of Zendikar";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4GG";
            PT = "6/6";
            Type = "Creature - Avatar";
            Text = "Reach^3GG: Put a 3/3 green Beast creature token onto the battlefield.^3GG, Exile Soul of Zendikar from your graveyard: Put a 3/3 green Beast creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Soulmender
    public class Soulmender15 : MagicCard
    {
        public Soulmender15()
        {
            Name = "Soulmender";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Human Cleric";
            Text = "T: You gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Spectra Ward
    public class SpectraWard15 : MagicCard
    {
        public SpectraWard15()
        {
            Name = "Spectra Ward";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3WW";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^Enchanted creature gets +2/+2 and has protection from all colors. This effect doesn't remove auras.";
            Flavor = "";
        }
    }
    # endregion

    # region Spirit Bonds
    public class SpiritBonds15 : MagicCard
    {
        public SpiritBonds15()
        {
            Name = "Spirit Bonds";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1W";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a nontoken creature enters the battlefield under your control, you may pay W. If you do, but a 1/1 white Spirit creature token with flying into play.^1W, Sacrifice a Spirit: Target non-Spirit creature you control gains indestructible until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Stab Wound
    public class StabWound15 : MagicCard
    {
        public StabWound15()
        {
            Name = "Stab Wound";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^Enchanted creature gets -2/-2.^At the beginning of the upkeep of enchanted creature's controller, that player loses 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Staff of the Death Magus
    public class StaffoftheDeathMagus15 : MagicCard
    {
        public StaffoftheDeathMagus15()
        {
            Name = "Staff of the Death Magus";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever you cast a black spell or a Swamp enters the battlefield under your control, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Staff of the Flame Magus
    public class StaffoftheFlameMagus15 : MagicCard
    {
        public StaffoftheFlameMagus15()
        {
            Name = "Staff of the Flame Magus";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever you cast a red spell or a Mountain enters the battlefield under your control, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Staff of the Mind Magus
    public class StaffoftheMindMagus15 : MagicCard
    {
        public StaffoftheMindMagus15()
        {
            Name = "Staff of the Mind Magus";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever you cast a blue spell or an Island enters the battlefield under your control, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Staff of the Sun Magus
    public class StaffoftheSunMagus15 : MagicCard
    {
        public StaffoftheSunMagus15()
        {
            Name = "Staff of the Sun Magus";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever you cast a white spell or a Plains enters the battlefield under your control, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Staff of the Wild Magus
    public class StaffoftheWildMagus15 : MagicCard
    {
        public StaffoftheWildMagus15()
        {
            Name = "Staff of the Wild Magus";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever you cast a green spell or a Forest enters the battlefield under your control, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Stain the Mind
    public class StaintheMind15 : MagicCard
    {
        public StaintheMind15()
        {
            Name = "Stain the Mind";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4B";
            PT = "";
            Type = "Sorcery";
            Text = "Convoke^Name a nonland card. Search target player's graveyard, hand, and library for any number of card's with that name and exile them. Then that player shuffles his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Statute of Denial
    public class StatuteofDenial15 : MagicCard
    {
        public StatuteofDenial15()
        {
            Name = "Statute of Denial";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2UU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell. If you control a blue creature, draw a card, then discard a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Stoke the Flames
    public class StoketheFlames15 : MagicCard
    {
        public StoketheFlames15()
        {
            Name = "Stoke the Flames";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2RR";
            PT = "";
            Type = "Instant";
            Text = "Convoke^Stoke the Flames deals 4 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Stormtide Leviathan
    public class StormtideLeviathan15 : MagicCard
    {
        public StormtideLeviathan15()
        {
            Name = "Stormtide Leviathan";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "5UUU";
            PT = "8/8";
            Type = "Creature - Leviathan";
            Text = "Islandwalk^All lands are Islands in addition to their other types.^Creatures without flying or islandwalk can't attack.";
            Flavor = "";
        }
    }
    # endregion

    # region Sunblade Elf
    public class SunbladeElf15 : MagicCard
    {
        public SunbladeElf15()
        {
            Name = "Sunblade Elf";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Elf Warrior";
            Text = "Sunblade Elf gets +1/+1 as long as you control a Plains.^4W: Creatures you control get +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Sungrace Pegasus
    public class SungracePegasus15 : MagicCard
    {
        public SungracePegasus15()
        {
            Name = "Sungrace Pegasus";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1W";
            PT = "1/2";
            Type = "Creature - Pegasus";
            Text = "Flying^Lifelink";
            Flavor = "";
        }
    }
    # endregion

    # region Swamp
    public class Swamp15 : MagicCard
    {
        public Swamp15()
        {
            Name = "Swamp";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Basic Land - Swamp";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Terra Stomper
    public class TerraStomper15 : MagicCard
    {
        public TerraStomper15()
        {
            Name = "Terra Stomper";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3GGG";
            PT = "8/8";
            Type = "Creature - Beast";
            Text = "Terra Stomper can't be countered.^Trample";
            Flavor = "";
        }
    }
    # endregion

    # region The Chain Veil
    public class TheChainVeil15 : MagicCard
    {
        public TheChainVeil15()
        {
            Name = "The Chain Veil";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4";
            PT = "";
            Type = "Legendary Artifact";
            Text = "At the beginning of your end step, if you didn't activate a loyalty ability of a planeswalker this turn, you lose 2 life.^4, T: For each planeswalker you control, you may activate one of its loyalty abilities once this turn as though none of its loyalty abilities had been activated this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Thundering Giant
    public class ThunderingGiant15 : MagicCard
    {
        public ThunderingGiant15()
        {
            Name = "Thundering Giant";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3RR";
            PT = "4/3";
            Type = "Creature - Giant";
            Text = "Haste";
            Flavor = "";
        }
    }
    # endregion

    # region Tireless Missionaries
    public class TirelessMissionaries15 : MagicCard
    {
        public TirelessMissionaries15()
        {
            Name = "Tireless Missionaries";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4W";
            PT = "2/3";
            Type = "Creature - Human Cleric";
            Text = "When Tireless Missionaries enters the battlefield, you gain 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Titanic Growth
    public class TitanicGrowth15 : MagicCard
    {
        public TitanicGrowth15()
        {
            Name = "Titanic Growth";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +4/+4 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Torch Fiend
    public class TorchFiend15 : MagicCard
    {
        public TorchFiend15()
        {
            Name = "Torch Fiend";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1R";
            PT = "2/1";
            Type = "Creature - Devil";
            Text = "R, Sacrifice Torch Fiend: Destroy target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Tormod's Crypt
    public class TormodsCrypt15 : MagicCard
    {
        public TormodsCrypt15()
        {
            Name = "Tormod's Crypt";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "0";
            PT = "";
            Type = "Artifact";
            Text = "T, Sacrifice Tormod's Crypt: Exile all cards from target player's graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Triplicate Spirits
    public class TriplicateSpirits15 : MagicCard
    {
        public TriplicateSpirits15()
        {
            Name = "Triplicate Spirits";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4WW";
            PT = "";
            Type = "Sorcery";
            Text = "Convoke^Put three 1/1 white Spirit creature tokens with flying onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Turn to Frog
    public class TurntoFrog15 : MagicCard
    {
        public TurntoFrog15()
        {
            Name = "Turn to Frog";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Until end of turn, target creature loses all abilities and becomes a blue Frog with base power and toughness 1/1.";
            Flavor = "";
        }
    }
    # endregion

    # region Typhoid Rats
    public class TyphoidRats15 : MagicCard
    {
        public TyphoidRats15()
        {
            Name = "Typhoid Rats";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Rat";
            Text = "Deathtouch";
            Flavor = "";
        }
    }
    # endregion

    # region Tyrant's Machine
    public class TyrantsMachine15 : MagicCard
    {
        public TyrantsMachine15()
        {
            Name = "Tyrant's Machine";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "4, T: Tap target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Ulcerate
    public class Ulcerate15 : MagicCard
    {
        public Ulcerate15()
        {
            Name = "Ulcerate";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets -3/-3 until end of turn. You lose 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Undergrowth Scavenger
    public class UndergrowthScavenger15 : MagicCard
    {
        public UndergrowthScavenger15()
        {
            Name = "Undergrowth Scavenger";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3G";
            PT = "0/0";
            Type = "Creature - Fungus Horror";
            Text = "Undergrowth Scavenger enters the battlefield with a number of +1/+1 counters on it equal to the number of creature cards in all graveyards.";
            Flavor = "";
        }
    }
    # endregion

    # region Unmake the Graves
    public class UnmaketheGraves15 : MagicCard
    {
        public UnmaketheGraves15()
        {
            Name = "Unmake the Graves";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "4B";
            PT = "";
            Type = "Instant";
            Text = "Convoke^Return up to two target creature cards from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Urborg, Tomb of Yawgmoth
    public class UrborgTombofYawgmoth15 : MagicCard
    {
        public UrborgTombofYawgmoth15()
        {
            Name = "Urborg, Tomb of Yawgmoth";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Legendary Land";
            Text = "Each land is a Swamp in addition to its other land types.";
            Flavor = "";
        }
    }
    # endregion

    # region Venom Sliver
    public class VenomSliver15 : MagicCard
    {
        public VenomSliver15()
        {
            Name = "Venom Sliver";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1G";
            PT = "1/1";
            Type = "Creature - Sliver";
            Text = "Sliver creatures you control have deathtouch.";
            Flavor = "";
        }
    }
    # endregion

    # region Verdant Haven
    public class VerdantHaven15 : MagicCard
    {
        public VerdantHaven15()
        {
            Name = "Verdant Haven";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land^When Verdant Haven enters the battlefield, you gain 2 life.^Whenever enchanted land is tapped for mana, its controller adds one mana of any color to his or her mana pool (in addition to the mana the land produces).";
            Flavor = "";
        }
    }
    # endregion

    # region Vineweft
    public class Vineweft15 : MagicCard
    {
        public Vineweft15()
        {
            Name = "Vineweft";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^Enchanted creature gets +1/+1.^4G: Return Vineweft from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Void Snare
    public class VoidSnare15 : MagicCard
    {
        public VoidSnare15()
        {
            Name = "Void Snare";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "U";
            PT = "";
            Type = "Sorcery";
            Text = "Return target nonland permanent to its owner's hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Walking Corpse
    public class WalkingCorpse15 : MagicCard
    {
        public WalkingCorpse15()
        {
            Name = "Walking Corpse";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1B";
            PT = "2/2";
            Type = "Creature - Zombie";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Essence
    public class WallofEssence15 : MagicCard
    {
        public WallofEssence15()
        {
            Name = "Wall of Essence";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1W";
            PT = "0/4";
            Type = "Creature - Wall";
            Text = "Defender^Whenever Wall of Essence is dealt combat damage, you gain that much life.";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Fire
    public class WallofFire15 : MagicCard
    {
        public WallofFire15()
        {
            Name = "Wall of Fire";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1RR";
            PT = "0/5";
            Type = "Creature - Wall";
            Text = "Defender^R: Wall of Fire gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Frost
    public class WallofFrost15 : MagicCard
    {
        public WallofFrost15()
        {
            Name = "Wall of Frost";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1UU";
            PT = "0/7";
            Type = "Creature - Wall";
            Text = "Defender^Whenever Wall of Frost blocks a creature, that creature doesn't untap during its controller's next untap step.";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Limbs
    public class WallofLimbs15 : MagicCard
    {
        public WallofLimbs15()
        {
            Name = "Wall of Limbs";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2B";
            PT = "0/3";
            Type = "Creature - Zombie Wall";
            Text = "Defender^Whenever you gain life, put a +1/+1 counter on Wall of Limbs.^5BB, Sacrifice Wall of Limbs: Target player loses X life, where X is Wall of Limbs's power.";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Mulch
    public class WallofMulch15 : MagicCard
    {
        public WallofMulch15()
        {
            Name = "Wall of Mulch";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1G";
            PT = "0/4";
            Type = "Creature - Wall";
            Text = "Defender^G, Sacrifice a Wall: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Warden of the Beyond
    public class WardenoftheBeyond15 : MagicCard
    {
        public WardenoftheBeyond15()
        {
            Name = "Warden of the Beyond";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Human Wizard";
            Text = "Vigilance^Warden of the Beyond gets +2/+2 as long as an opponent owns a card in exile.";
            Flavor = "";
        }
    }
    # endregion

    # region Waste Not
    public class WasteNot15 : MagicCard
    {
        public WasteNot15()
        {
            Name = "Waste Not";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1B";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever an opponent discards a creature card, put a 2/2 black Zombie creature token onto the battlefield.^Whenever an opponent discards a land card, add BB to your mana pool.^Whenever an opponent discards a noncreature, nonland card, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Welkin Tern
    public class WelkinTern15 : MagicCard
    {
        public WelkinTern15()
        {
            Name = "Welkin Tern";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "1U";
            PT = "2/1";
            Type = "Creature - Bird";
            Text = "Flying^Welkin Tern can block only creatures with flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Will-Forged Golem
    public class WillForgedGolem15 : MagicCard
    {
        public WillForgedGolem15()
        {
            Name = "Will-Forged Golem";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "6";
            PT = "4/4";
            Type = "Artifact Creature - Golem";
            Text = "Convoke";
            Flavor = "";
        }
    }
    # endregion

    # region Witch's Familiar
    public class WitchsFamiliar15 : MagicCard
    {
        public WitchsFamiliar15()
        {
            Name = "Witch's Familiar";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2B";
            PT = "2/3";
            Type = "Creature - Frog";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Xathrid Slyblade
    public class XathridSlyblade15 : MagicCard
    {
        public XathridSlyblade15()
        {
            Name = "Xathrid Slyblade";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2B";
            PT = "2/1";
            Type = "Creature - Human Assassin";
            Text = "Hexproof^3B: Until end of turn, Xathrid Slyblade loses hexproof and gains first strike and deathtouch.";
            Flavor = "";
        }
    }
    # endregion

    # region Yavimaya Coast
    public class YavimayaCoast15 : MagicCard
    {
        public YavimayaCoast15()
        {
            Name = "Yavimaya Coast";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "T: Add 1 to your mana pool.^T: Add G or U to your mana pool. Yavimaya Coast deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Yisan, the Wanderer Bard
    public class YisantheWandererBard15 : MagicCard
    {
        public YisantheWandererBard15()
        {
            Name = "Yisan, the Wanderer Bard";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "2G";
            PT = "2/3";
            Type = "Legendary Creature - Human Rogue";
            Text = "2G, T, Put a verse counter on Yisan, the Wanderer Bard: Search your library for a creature card with converted Cost equal to the number of verse counters on Yisan, put it onto the battlefield, then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Zof Shade
    public class ZofShade15 : MagicCard
    {
        public ZofShade15()
        {
            Name = "Zof Shade";
            Edition = "M15";
            Rarity = "C";
            Color = "";
            Cost = "3B";
            PT = "2/2";
            Type = "Creature - Shade";
            Text = "2B: Zof Shade gets +2/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion


    # endregion
}
