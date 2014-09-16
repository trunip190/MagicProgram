using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
    # region Ice Age
    # region Abyssal Specter
    public class AbyssalSpecterIA : MagicCard
    {
        public AbyssalSpecterIA()
        {
            Name = "Abyssal Specter";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "2BB";
            PT = "2/3";
            Type = "Creature - Specter";
            Text = "Flying;^Whenever Abyssal Specter deals damage to a player, that player discards a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Adarkar Sentinel
    public class AdarkarSentinelIA : MagicCard
    {
        public AdarkarSentinelIA()
        {
            Name = "Adarkar Sentinel";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "5";
            PT = "3/3";
            Type = "Artifact Creature - Soldier";
            Text = "%1: Adarkar Sentinel gets +0/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Adarkar Unicorn
    public class AdarkarUnicornIA : MagicCard
    {
        public AdarkarUnicornIA()
        {
            Name = "Adarkar Unicorn";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "1WW";
            PT = "2/2";
            Type = "Creature - Unicorn";
            Text = "%T: Add %U or %1%U to your mana pool. Spend this mana only to pay cumulative upkeep costs.";
            Flavor = "";
        }
    }
    # endregion

    # region Adarkar Wastes
    public class AdarkarWastesIA : MagicCard
    {
        public AdarkarWastesIA()
        {
            Name = "Adarkar Wastes";
            Edition = "IA";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%T: Add %W or %U to your mana pool. Adarkar Wastes deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Aegis of the Meek
    public class AegisoftheMeekIA : MagicCard
    {
        public AegisoftheMeekIA()
        {
            Name = "Aegis of the Meek";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%1, %T: Target 1/1 creature gets +1/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Aggression
    public class AggressionIA : MagicCard
    {
        public AggressionIA()
        {
            Name = "Aggression";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant non-Wall creature;^Enchanted creature has first strike and trample.;^At the beginning of the end step of enchanted creature�s controller, destroy that creature if it didn�t attack this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Altar of Bone
    public class AltarofBoneIA : MagicCard
    {
        public AltarofBoneIA()
        {
            Name = "Altar of Bone";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "GW";
            PT = "";
            Type = "Sorcery";
            Text = "As an additional cost to cast Altar of Bone, sacrifice a creature.;^Search your library for a creature card, reveal that card, and put it into your hand. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Amulet of Quoz
    public class AmuletofQuozIA : MagicCard
    {
        public AmuletofQuozIA()
        {
            Name = "Amulet of Quoz";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "6";
            PT = "";
            Type = "Artifact";
            Text = "Remove Amulet of Quoz from your deck before playing if you�re not playing for ante.;^%T, Sacrifice Amulet of Quoz: Target opponent may add the top card of his or her library to the ante. If he or she doesn�t, you flip a coin. If you win the flip, that player loses the game. If you lose the flip, you lose the game. Activate this ability only during your upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Anarchy
    public class AnarchyIA : MagicCard
    {
        public AnarchyIA()
        {
            Name = "Anarchy";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "2RR";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy all white permanents.";
            Flavor = "";
        }
    }
    # endregion

    # region Arctic Foxes
    public class ArcticFoxesIA : MagicCard
    {
        public ArcticFoxesIA()
        {
            Name = "Arctic Foxes";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "1/1";
            Type = "Creature - Fox";
            Text = "Creatures with power 2 or greater can�t block Arctic Foxes as long as defending player controls a snow land.";
            Flavor = "";
        }
    }
    # endregion

    # region Arcum's Sleigh
    public class ArcumsSleighIA : MagicCard
    {
        public ArcumsSleighIA()
        {
            Name = "Arcum's Sleigh";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T: Target creature gains vigilance until end of turn. Activate this ability only during combat and only if defending player controls a snow land.";
            Flavor = "";
        }
    }
    # endregion

    # region Arcum's Weathervane
    public class ArcumsWeathervaneIA : MagicCard
    {
        public ArcumsWeathervaneIA()
        {
            Name = "Arcum's Weathervane";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T: Target snow land is no longer snow.;^%2, %T: Target nonsnow basic land becomes snow.";
            Flavor = "";
        }
    }
    # endregion

    # region Arcum's Whistle
    public class ArcumsWhistleIA : MagicCard
    {
        public ArcumsWhistleIA()
        {
            Name = "Arcum's Whistle";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T: Choose target non-Wall creature the active player has controlled continuously since the beginning of the turn. That player may pay %X, where X is that creature�s converted mana cost. If he or she doesn�t, the creature attacks this turn if able, and at the beginning of the next end step, destroy it if it didn�t attack. Activate this ability only before attackers are declared.";
            Flavor = "";
        }
    }
    # endregion

    # region Arenson's Aura
    public class ArensonsAuraIA : MagicCard
    {
        public ArensonsAuraIA()
        {
            Name = "Arenson's Aura";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Enchantment";
            Text = "%W, Sacrifice an enchantment: Destroy target enchantment.;^%3%U%U: Counter target enchantment spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Armor of Faith
    public class ArmorofFaithIA : MagicCard
    {
        public ArmorofFaithIA()
        {
            Name = "Armor of Faith";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +1/+1.;^%W: Enchanted creature gets +0/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Arnjlot's Ascent
    public class ArnjlotsAscentIA : MagicCard
    {
        public ArnjlotsAscentIA()
        {
            Name = "Arnjlot's Ascent";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "1UU";
            PT = "";
            Type = "Enchantment";
            Text = "Cumulative upkeep %U @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^%1: Target creature gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Ashen Ghoul
    public class AshenGhoulIA : MagicCard
    {
        public AshenGhoulIA()
        {
            Name = "Ashen Ghoul";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "3/1";
            Type = "Creature - Zombie";
            Text = "Haste;^%B: Return Ashen Ghoul from your graveyard to the battlefield. Activate this ability only during your upkeep and only if three or more creature cards are above Ashen Ghoul.";
            Flavor = "";
        }
    }
    # endregion

    # region Aurochs
    public class AurochsIA : MagicCard
    {
        public AurochsIA()
        {
            Name = "Aurochs";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "2/3";
            Type = "Creature - Aurochs";
            Text = "Trample;^Whenever Aurochs attacks, it gets +1/+0 until end of turn for each other attacking Aurochs.";
            Flavor = "";
        }
    }
    # endregion

    # region Avalanche
    public class AvalancheIA : MagicCard
    {
        public AvalancheIA()
        {
            Name = "Avalanche";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "X2RR";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy X target snow lands.";
            Flavor = "";
        }
    }
    # endregion

    # region Balduvian Barbarians
    public class BalduvianBarbariansIA : MagicCard
    {
        public BalduvianBarbariansIA()
        {
            Name = "Balduvian Barbarians";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "1RR";
            PT = "3/2";
            Type = "Creature - Human Barbarian";
            Text = "";
            Flavor = "�Barbarian raids were a concern to those living in the northwest provinces, but the Skyknights never dealt with the problem in a systematic way. They thought of the Balduvians as an �amusing model� of their forebears� culture.�;^@�Kjeldor: Ice Civilization@";
        }
    }
    # endregion

    # region Balduvian Bears
    public class BalduvianBearsIA : MagicCard
    {
        public BalduvianBearsIA()
        {
            Name = "Balduvian Bears";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "2/2";
            Type = "Creature - Bear";
            Text = "";
            Flavor = "�They�re a hardy bunch, but I�d still bet that they just slept through the worst of the cold times.�;^�Disa the Restless, journal entry";
        }
    }
    # endregion

    # region Balduvian Conjurer
    public class BalduvianConjurerIA : MagicCard
    {
        public BalduvianConjurerIA()
        {
            Name = "Balduvian Conjurer";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "1U";
            PT = "0/2";
            Type = "Creature - Human Wizard";
            Text = "%T: Target snow land becomes a 2/2 creature until end of turn. It�s still a land.";
            Flavor = "";
        }
    }
    # endregion

    # region Balduvian Hydra
    public class BalduvianHydraIA : MagicCard
    {
        public BalduvianHydraIA()
        {
            Name = "Balduvian Hydra";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "XRR";
            PT = "0/1";
            Type = "Creature - Hydra";
            Text = "Balduvian Hydra enters the battlefield with X +1/+0 counters on it.;^Remove a +1/+0 counter from Balduvian Hydra: Prevent the next 1 damage that would be dealt to Balduvian Hydra this turn.;^%R%R%R: Put a +1/+0 counter on Balduvian Hydra. Activate this ability only during your upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Balduvian Shaman
    public class BalduvianShamanIA : MagicCard
    {
        public BalduvianShamanIA()
        {
            Name = "Balduvian Shaman";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "1/1";
            Type = "Creature - Human Cleric Shaman";
            Text = "%T: Change the text of target white enchantment you control that doesn�t have cumulative upkeep by replacing all instances of one color word with another. @(For example, you may change �black creatures can�t attack� to �blue creatures can�t attack.�)@ That enchantment gains �Cumulative upkeep %1.� @(At the beginning of its controller�s upkeep, that player puts an age counter on it, then sacrifices it unless he or she pays its upkeep cost for each age counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Barbarian Guides
    public class BarbarianGuidesIA : MagicCard
    {
        public BarbarianGuidesIA()
        {
            Name = "Barbarian Guides";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "1/2";
            Type = "Creature - Human Barbarian";
            Text = "%2%R, %T: Choose a land type. Target creature you control gains snow landwalk of the chosen type until end of turn. Return that creature to its owner�s hand at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Barbed Sextant
    public class BarbedSextantIA : MagicCard
    {
        public BarbedSextantIA()
        {
            Name = "Barbed Sextant";
            Edition = "IA";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%1, %T, Sacrifice Barbed Sextant: Add one mana of any color to your mana pool. Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Baton of Morale
    public class BatonofMoraleIA : MagicCard
    {
        public BatonofMoraleIA()
        {
            Name = "Baton of Morale";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%2: Target creature gains banding until end of turn. @(Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding a player controls are blocking or being blocked by a creature, that player divides that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by or is blocking.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Battle Cry
    public class BattleCryIA : MagicCard
    {
        public BattleCryIA()
        {
            Name = "Battle Cry";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Instant";
            Text = "Untap all white creatures you control.;^Whenever a creature blocks this turn, it gets +0/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Battle Frenzy
    public class BattleFrenzyIA : MagicCard
    {
        public BattleFrenzyIA()
        {
            Name = "Battle Frenzy";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Instant";
            Text = "Green creatures you control get +1/+1 until end of turn.;^Nongreen creatures you control get +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Binding Grasp
    public class BindingGraspIA : MagicCard
    {
        public BindingGraspIA()
        {
            Name = "Binding Grasp";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^At the beginning of your upkeep, sacrifice Binding Grasp unless you pay %1%U.;^You control enchanted creature.;^Enchanted creature gets +0/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Black Scarab
    public class BlackScarabIA : MagicCard
    {
        public BlackScarabIA()
        {
            Name = "Black Scarab";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature can�t be blocked by black creatures.;^Enchanted creature gets +2/+2 as long as an opponent controls a black permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Blessed Wine
    public class BlessedWineIA : MagicCard
    {
        public BlessedWineIA()
        {
            Name = "Blessed Wine";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "You gain 1 life.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Blinking Spirit
    public class BlinkingSpiritIA : MagicCard
    {
        public BlinkingSpiritIA()
        {
            Name = "Blinking Spirit";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "2/2";
            Type = "Creature - Spirit";
            Text = "%0: Return Blinking Spirit to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Blizzard
    public class BlizzardIA : MagicCard
    {
        public BlizzardIA()
        {
            Name = "Blizzard";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "GG";
            PT = "";
            Type = "Enchantment";
            Text = "Cast Blizzard only if you control a snow land.;^Cumulative upkeep %2 @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^Creatures with flying don�t untap during their controllers� untap steps.";
            Flavor = "";
        }
    }
    # endregion

    # region Blue Scarab
    public class BlueScarabIA : MagicCard
    {
        public BlueScarabIA()
        {
            Name = "Blue Scarab";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature can�t be blocked by blue creatures.;^Enchanted creature gets +2/+2 as long as an opponent controls a blue permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Bone Shaman
    public class BoneShamanIA : MagicCard
    {
        public BoneShamanIA()
        {
            Name = "Bone Shaman";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "2RR";
            PT = "3/3";
            Type = "Creature - Giant Shaman";
            Text = "%B: Until end of turn, Bone Shaman gains �Creatures dealt damage by Bone Shaman this turn can�t be regenerated this turn.�";
            Flavor = "";
        }
    }
    # endregion

    # region Brainstorm
    public class BrainstormIA : MagicCard
    {
        public BrainstormIA()
        {
            Name = "Brainstorm";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Draw three cards, then put two cards from your hand on top of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Brand of Ill Omen
    public class BrandofIllOmenIA : MagicCard
    {
        public BrandofIllOmenIA()
        {
            Name = "Brand of Ill Omen";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Cumulative upkeep %R @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^Enchanted creature�s controller can�t cast creature spells.";
            Flavor = "";
        }
    }
    # endregion

    # region Breath of Dreams
    public class BreathofDreamsIA : MagicCard
    {
        public BreathofDreamsIA()
        {
            Name = "Breath of Dreams";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "2UU";
            PT = "";
            Type = "Enchantment";
            Text = "Cumulative upkeep %U @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^Green creatures have �Cumulative upkeep %1.�";
            Flavor = "";
        }
    }
    # endregion

    # region Brine Shaman
    public class BrineShamanIA : MagicCard
    {
        public BrineShamanIA()
        {
            Name = "Brine Shaman";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "1/1";
            Type = "Creature - Human Cleric Shaman";
            Text = "%T, Sacrifice a creature: Target creature gets +2/+2 until end of turn.;^%1%U%U, Sacrifice a creature: Counter target creature spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Brown Ouphe
    public class BrownOupheIA : MagicCard
    {
        public BrownOupheIA()
        {
            Name = "Brown Ouphe";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Ouphe";
            Text = "%1%G, %T: Counter target activated ability from an artifact source. @(Mana abilities can�t be targeted.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Brushland
    public class BrushlandIA : MagicCard
    {
        public BrushlandIA()
        {
            Name = "Brushland";
            Edition = "IA";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%T: Add %G or %W to your mana pool. Brushland deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Burnt Offering
    public class BurntOfferingIA : MagicCard
    {
        public BurntOfferingIA()
        {
            Name = "Burnt Offering";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "As an additional cost to cast Burnt Offering, sacrifice a creature.;^Add X mana in any combination of %B and/or %R to your mana pool, where X is the sacrificed creature�s converted mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Call to Arms
    public class CalltoArmsIA : MagicCard
    {
        public CalltoArmsIA()
        {
            Name = "Call to Arms";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment";
            Text = "As Call to Arms enters the battlefield, choose a color and an opponent.;^White creatures get +1/+1 as long as the chosen color is the most common color among nontoken permanents the chosen player controls but isn�t tied for most common.;^When the chosen color isn�t the most common color among nontoken permanents the chosen player controls or is tied for most common, sacrifice Call to Arms.";
            Flavor = "";
        }
    }
    # endregion

    # region Caribou Range
    public class CaribouRangeIA : MagicCard
    {
        public CaribouRangeIA()
        {
            Name = "Caribou Range";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "2WW";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land you control;^Enchanted land has �%W%W, %T: Put a 0/1 white Caribou creature token onto the battlefield.�;^Sacrifice a Caribou token: You gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Celestial Sword
    public class CelestialSwordIA : MagicCard
    {
        public CelestialSwordIA()
        {
            Name = "Celestial Sword";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "6";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T: Target creature you control gets +3/+3 until end of turn. Its controller sacrifices it at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Centaur Archer
    public class CentaurArcherIA : MagicCard
    {
        public CentaurArcherIA()
        {
            Name = "Centaur Archer";
            Edition = "IA";
            Rarity = "U";
            Color = "Gld";
            Cost = "1RG";
            PT = "3/2";
            Type = "Creature - Centaur Archer";
            Text = "%T: Centaur Archer deals 1 damage to target creature with flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Chaos Lord
    public class ChaosLordIA : MagicCard
    {
        public ChaosLordIA()
        {
            Name = "Chaos Lord";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "4RRR";
            PT = "7/7";
            Type = "Creature - Human";
            Text = "First strike;^At the beginning of your upkeep, target opponent gains control of Chaos Lord if the number of permanents is even.;^Chaos Lord can attack as though it had haste unless it entered the battlefield this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Chaos Moon
    public class ChaosMoonIA : MagicCard
    {
        public ChaosMoonIA()
        {
            Name = "Chaos Moon";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of each upkeep, count the number of permanents. If the number is odd, until end of turn, red creatures get +1/+1 and whenever a player taps a Mountain for mana, that player adds %R to his or her mana pool @(in addition to the mana the land produces)@. If the number is even, until end of turn, red creatures get -1/-1 and if a player taps a Mountain for mana, that Mountain produces colorless mana instead of any other type.";
            Flavor = "";
        }
    }
    # endregion

    # region Chromatic Armor
    public class ChromaticArmorIA : MagicCard
    {
        public ChromaticArmorIA()
        {
            Name = "Chromatic Armor";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "1WU";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^As Chromatic Armor enters the battlefield, choose a color.;^Chromatic Armor enters the battlefield with a sleight counter on it.;^Prevent all damage that would be dealt to enchanted creature by sources of the last chosen color.;^%X: Put a sleight counter on Chromatic Armor and choose a color. X is the number of sleight counters on Chromatic Armor.";
            Flavor = "";
        }
    }
    # endregion

    # region Chub Toad
    public class ChubToadIA : MagicCard
    {
        public ChubToadIA()
        {
            Name = "Chub Toad";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "1/1";
            Type = "Creature - Frog";
            Text = "Whenever Chub Toad blocks or becomes blocked, it gets +2/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Circle of Protection: Black
    public class CircleofProtectionBlackIA : MagicCard
    {
        public CircleofProtectionBlackIA()
        {
            Name = "Circle of Protection: Black";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment";
            Text = "%1: The next time a black source of your choice would deal damage to you this turn, prevent that damage.";
            Flavor = "";
        }
    }
    # endregion

    # region Circle of Protection: Blue
    public class CircleofProtectionBlueIA : MagicCard
    {
        public CircleofProtectionBlueIA()
        {
            Name = "Circle of Protection: Blue";
            Edition = "IA";
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
    public class CircleofProtectionGreenIA : MagicCard
    {
        public CircleofProtectionGreenIA()
        {
            Name = "Circle of Protection: Green";
            Edition = "IA";
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
    public class CircleofProtectionRedIA : MagicCard
    {
        public CircleofProtectionRedIA()
        {
            Name = "Circle of Protection: Red";
            Edition = "IA";
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
    public class CircleofProtectionWhiteIA : MagicCard
    {
        public CircleofProtectionWhiteIA()
        {
            Name = "Circle of Protection: White";
            Edition = "IA";
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

    # region Clairvoyance
    public class ClairvoyanceIA : MagicCard
    {
        public ClairvoyanceIA()
        {
            Name = "Clairvoyance";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Look at target player�s hand.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Cloak of Confusion
    public class CloakofConfusionIA : MagicCard
    {
        public CloakofConfusionIA()
        {
            Name = "Cloak of Confusion";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature you control;^Whenever enchanted creature attacks and isn�t blocked, you may have it assign no combat damage this turn. If you do, defending player discards a card at random.";
            Flavor = "";
        }
    }
    # endregion

    # region Cold Snap
    public class ColdSnapIA : MagicCard
    {
        public ColdSnapIA()
        {
            Name = "Cold Snap";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Enchantment";
            Text = "Cumulative upkeep %2 @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^At the beginning of each player�s upkeep, Cold Snap deals damage to that player equal to the number of snow lands he or she controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Conquer
    public class ConquerIA : MagicCard
    {
        public ConquerIA()
        {
            Name = "Conquer";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "3RR";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land;^You control enchanted land.";
            Flavor = "";
        }
    }
    # endregion

    # region Cooperation
    public class CooperationIA : MagicCard
    {
        public CooperationIA()
        {
            Name = "Cooperation";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature has banding. @(Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding a player controls are blocking or being blocked by a creature, that player divides that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by or is blocking.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Counterspell
    public class CounterspellIA : MagicCard
    {
        public CounterspellIA()
        {
            Name = "Counterspell";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "UU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Crown of the Ages
    public class CrownoftheAgesIA : MagicCard
    {
        public CrownoftheAgesIA()
        {
            Name = "Crown of the Ages";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%4, %T: Attach target Aura attached to a creature to another creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Curse of Marit Lage
    public class CurseofMaritLageIA : MagicCard
    {
        public CurseofMaritLageIA()
        {
            Name = "Curse of Marit Lage";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "3RR";
            PT = "";
            Type = "Enchantment";
            Text = "When Curse of Marit Lage enters the battlefield, tap all Islands.;^Islands don�t untap during their controllers� untap steps.";
            Flavor = "";
        }
    }
    # endregion

    # region Dance of the Dead
    public class DanceoftheDeadIA : MagicCard
    {
        public DanceoftheDeadIA()
        {
            Name = "Dance of the Dead";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature card in a graveyard;^When Dance of the Dead enters the battlefield, if it�s on the battlefield, it loses �enchant creature card in a graveyard� and gains �enchant creature put onto the battlefield with Dance of the Dead.� Return enchanted creature card to the battlefield tapped under your control and attach Dance of the Dead to it. When Dance of the Dead leaves the battlefield, that creature�s controller sacrifices it.;^Enchanted creature gets +1/+1 and doesn�t untap during its controller�s untap step.;^At the beginning of the upkeep of enchanted creature�s controller, that player may pay %1%B. If he or she does, untap that creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Dark Banishing
    public class DarkBanishingIA : MagicCard
    {
        public DarkBanishingIA()
        {
            Name = "Dark Banishing";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Instant";
            Text = "Destroy target nonblack creature. It can�t be regenerated.";
            Flavor = "";
        }
    }
    # endregion

    # region Dark Ritual
    public class DarkRitualIA : MagicCard
    {
        public DarkRitualIA()
        {
            Name = "Dark Ritual";
            Edition = "IA";
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

    # region Death Ward
    public class DeathWardIA : MagicCard
    {
        public DeathWardIA()
        {
            Name = "Death Ward";
            Edition = "IA";
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

    # region Deflection
    public class DeflectionIA : MagicCard
    {
        public DeflectionIA()
        {
            Name = "Deflection";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Instant";
            Text = "Change the target of target spell with a single target.";
            Flavor = "";
        }
    }
    # endregion

    # region Demonic Consultation
    public class DemonicConsultationIA : MagicCard
    {
        public DemonicConsultationIA()
        {
            Name = "Demonic Consultation";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "Name a card. Exile the top six cards of your library, then reveal cards from the top of your library until you reveal the named card. Put that card into your hand and exile all other cards revealed this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Despotic Scepter
    public class DespoticScepterIA : MagicCard
    {
        public DespoticScepterIA()
        {
            Name = "Despotic Scepter";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%T: Destroy target permanent you own. It can�t be regenerated.";
            Flavor = "";
        }
    }
    # endregion

    # region Diabolic Vision
    public class DiabolicVisionIA : MagicCard
    {
        public DiabolicVisionIA()
        {
            Name = "Diabolic Vision";
            Edition = "IA";
            Rarity = "U";
            Color = "Gld";
            Cost = "UB";
            PT = "";
            Type = "Sorcery";
            Text = "Look at the top five cards of your library. Put one of them into your hand and the rest on top of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Dire Wolves
    public class DireWolvesIA : MagicCard
    {
        public DireWolvesIA()
        {
            Name = "Dire Wolves";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Wolf";
            Text = "Dire Wolves has banding as long as you control a Plains. @(Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding you control are blocking or being blocked by a creature, you divide that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by or is blocking.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Disenchant
    public class DisenchantIA : MagicCard
    {
        public DisenchantIA()
        {
            Name = "Disenchant";
            Edition = "IA";
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

    # region Dread Wight
    public class DreadWightIA : MagicCard
    {
        public DreadWightIA()
        {
            Name = "Dread Wight";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "3BB";
            PT = "3/4";
            Type = "Creature - Zombie";
            Text = "At end of combat, put a paralyzation counter on each creature blocking or blocked by Dread Wight and tap those creatures. Each of those creatures doesn�t untap during its controller�s untap step for as long as it has a paralyzation counter on it. Each of those creatures gains �%4: Remove a paralyzation counter from this creature.�";
            Flavor = "";
        }
    }
    # endregion

    # region Dreams of the Dead
    public class DreamsoftheDeadIA : MagicCard
    {
        public DreamsoftheDeadIA()
        {
            Name = "Dreams of the Dead";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Enchantment";
            Text = "%1%U: Return target white or black creature card from your graveyard to the battlefield. That creature gains �Cumulative upkeep %2.� If the creature would leave the battlefield, exile it instead of putting it anywhere else. @(At the beginning of its controller�s upkeep, that player puts an age counter on it, then sacrifices it unless he or she pays its upkeep cost for each age counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Drift of the Dead
    public class DriftoftheDeadIA : MagicCard
    {
        public DriftoftheDeadIA()
        {
            Name = "Drift of the Dead";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "*/*";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@;^Drift of the Dead�s power and toughness are each equal to the number of snow lands you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Drought
    public class DroughtIA : MagicCard
    {
        public DroughtIA()
        {
            Name = "Drought";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "2WW";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of your upkeep, sacrifice Drought unless you pay %W%W.;^Spells cost an additional �Sacrifice a Swamp� to cast for each black mana symbol in their mana costs.;^Activated abilities cost an additional �Sacrifice a Swamp� to activate for each black mana symbol in their activation costs.";
            Flavor = "";
        }
    }
    # endregion

    # region Dwarven Armory
    public class DwarvenArmoryIA : MagicCard
    {
        public DwarvenArmoryIA()
        {
            Name = "Dwarven Armory";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "2RR";
            PT = "";
            Type = "Enchantment";
            Text = "%2, Sacrifice a land: Put a +2/+2 counter on target creature. Activate this ability only during any upkeep step.";
            Flavor = "";
        }
    }
    # endregion

    # region Earthlink
    public class EarthlinkIA : MagicCard
    {
        public EarthlinkIA()
        {
            Name = "Earthlink";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "3BRG";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of your upkeep, sacrifice Earthlink unless you pay %2.;^Whenever a creature dies, that creature�s controller sacrifices a land.";
            Flavor = "";
        }
    }
    # endregion

    # region Earthlore
    public class EarthloreIA : MagicCard
    {
        public EarthloreIA()
        {
            Name = "Earthlore";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land you control;^Tap enchanted land: Target blocking creature gets +1/+2 until end of turn. Activate this ability only if enchanted land is untapped.";
            Flavor = "";
        }
    }
    # endregion

    # region Elder Druid
    public class ElderDruidIA : MagicCard
    {
        public ElderDruidIA()
        {
            Name = "Elder Druid";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "3G";
            PT = "2/2";
            Type = "Creature - Elf Cleric Druid";
            Text = "%3%G, %T: You may tap or untap target artifact, creature, or land.";
            Flavor = "";
        }
    }
    # endregion

    # region Elemental Augury
    public class ElementalAuguryIA : MagicCard
    {
        public ElementalAuguryIA()
        {
            Name = "Elemental Augury";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "UBR";
            PT = "";
            Type = "Enchantment";
            Text = "%3: Look at the top three cards of target player�s library, then put them back in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Elkin Bottle
    public class ElkinBottleIA : MagicCard
    {
        public ElkinBottleIA()
        {
            Name = "Elkin Bottle";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T: Exile the top card of your library. Until the beginning of your next upkeep, you may play that card.";
            Flavor = "";
        }
    }
    # endregion

    # region Elvish Healer
    public class ElvishHealerIA : MagicCard
    {
        public ElvishHealerIA()
        {
            Name = "Elvish Healer";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "1/2";
            Type = "Creature - Elf Cleric";
            Text = "%T: Prevent the next 1 damage that would be dealt to target creature or player this turn. If that creature is green, prevent the next 2 damage instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Enduring Renewal
    public class EnduringRenewalIA : MagicCard
    {
        public EnduringRenewalIA()
        {
            Name = "Enduring Renewal";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "2WW";
            PT = "";
            Type = "Enchantment";
            Text = "Play with your hand revealed.;^If you would draw a card, reveal the top card of your library instead. If it�s a creature card, put it into your graveyard. Otherwise, draw a card.;^Whenever a creature is put into your graveyard from the battlefield, return it to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Energy Storm
    public class EnergyStormIA : MagicCard
    {
        public EnergyStormIA()
        {
            Name = "Energy Storm";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment";
            Text = "Cumulative upkeep %1 @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^Prevent all damage that would be dealt by instant and sorcery spells.;^Creatures with flying don�t untap during their controllers� untap steps.";
            Flavor = "";
        }
    }
    # endregion

    # region Enervate
    public class EnervateIA : MagicCard
    {
        public EnervateIA()
        {
            Name = "Enervate";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Tap target artifact, creature, or land.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Errant Minion
    public class ErrantMinionIA : MagicCard
    {
        public ErrantMinionIA()
        {
            Name = "Errant Minion";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^At the beginning of the upkeep of enchanted creature�s controller, that player may pay any amount of mana. Errant Minion deals 2 damage to that player. Prevent X of that damage, where X is the amount of mana that player paid this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Errantry
    public class ErrantryIA : MagicCard
    {
        public ErrantryIA()
        {
            Name = "Errantry";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +3/+0 and can only attack alone.";
            Flavor = "";
        }
    }
    # endregion

    # region Essence Filter
    public class EssenceFilterIA : MagicCard
    {
        public EssenceFilterIA()
        {
            Name = "Essence Filter";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "1GG";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy all enchantments or all nonwhite enchantments.";
            Flavor = "";
        }
    }
    # endregion

    # region Essence Flare
    public class EssenceFlareIA : MagicCard
    {
        public EssenceFlareIA()
        {
            Name = "Essence Flare";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +2/+0.;^At the beginning of the upkeep of enchanted creature�s controller, put a -0/-1 counter on that creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Essence Vortex
    public class EssenceVortexIA : MagicCard
    {
        public EssenceVortexIA()
        {
            Name = "Essence Vortex";
            Edition = "IA";
            Rarity = "U";
            Color = "Gld";
            Cost = "1UB";
            PT = "";
            Type = "Instant";
            Text = "Destroy target creature unless its controller pays life equal to its toughness. A creature destroyed this way can�t be regenerated.";
            Flavor = "";
        }
    }
    # endregion

    # region Fanatical Fever
    public class FanaticalFeverIA : MagicCard
    {
        public FanaticalFeverIA()
        {
            Name = "Fanatical Fever";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "2GG";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +3/+0 and gains trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Fear
    public class FearIA : MagicCard
    {
        public FearIA()
        {
            Name = "Fear";
            Edition = "IA";
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

    # region Fiery Justice
    public class FieryJusticeIA : MagicCard
    {
        public FieryJusticeIA()
        {
            Name = "Fiery Justice";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "RGW";
            PT = "";
            Type = "Sorcery";
            Text = "Fiery Justice deals 5 damage divided as you choose among any number of target creatures and/or players. Target opponent gains 5 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Fire Covenant
    public class FireCovenantIA : MagicCard
    {
        public FireCovenantIA()
        {
            Name = "Fire Covenant";
            Edition = "IA";
            Rarity = "U";
            Color = "Gld";
            Cost = "1BR";
            PT = "";
            Type = "Instant";
            Text = "As an additional cost to cast Fire Covenant, pay X life.;^Fire Covenant deals X damage divided as you choose among any number of target creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Flame Spirit
    public class FlameSpiritIA : MagicCard
    {
        public FlameSpiritIA()
        {
            Name = "Flame Spirit";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "4R";
            PT = "2/3";
            Type = "Creature - Elemental Spirit";
            Text = "%R: Flame Spirit gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Flare
    public class FlareIA : MagicCard
    {
        public FlareIA()
        {
            Name = "Flare";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Instant";
            Text = "Flare deals 1 damage to target creature or player.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Flooded Woodlands
    public class FloodedWoodlandsIA : MagicCard
    {
        public FloodedWoodlandsIA()
        {
            Name = "Flooded Woodlands";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "2UB";
            PT = "";
            Type = "Enchantment";
            Text = "Green creatures can�t attack unless their controller sacrifices a land for each green creature he or she controls that�s attacking. @(This cost is paid as attackers are declared.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Flow of Maggots
    public class FlowofMaggotsIA : MagicCard
    {
        public FlowofMaggotsIA()
        {
            Name = "Flow of Maggots";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Insect";
            Text = "Cumulative upkeep %1 @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^Flow of Maggots can�t be blocked by non-Wall creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Folk of the Pines
    public class FolkofthePinesIA : MagicCard
    {
        public FolkofthePinesIA()
        {
            Name = "Folk of the Pines";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "4G";
            PT = "2/5";
            Type = "Creature - Dryad";
            Text = "%1%G: Folk of the Pines gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Forbidden Lore
    public class ForbiddenLoreIA : MagicCard
    {
        public ForbiddenLoreIA()
        {
            Name = "Forbidden Lore";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land;^Enchanted land has �%T: Target creature gets +2/+1 until end of turn.�";
            Flavor = "";
        }
    }
    # endregion

    # region Force Void
    public class ForceVoidIA : MagicCard
    {
        public ForceVoidIA()
        {
            Name = "Force Void";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell unless its controller pays %1.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Forest
    public class ForestIA : MagicCard
    {
        public ForestIA()
        {
            Name = "Forest ";
            Edition = "IA";
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

    # region Forgotten Lore
    public class ForgottenLoreIA : MagicCard
    {
        public ForgottenLoreIA()
        {
            Name = "Forgotten Lore";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Sorcery";
            Text = "Target opponent chooses a card in your graveyard. You may pay %G. If you do, repeat this process except that opponent can�t choose a card already chosen for Forgotten Lore. Then put the last chosen card into your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Formation
    public class FormationIA : MagicCard
    {
        public FormationIA()
        {
            Name = "Formation";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Target creature gains banding until end of turn. @(Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding a player controls are blocking or being blocked by a creature, that player divides that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by or is blocking.)@;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Foul Familiar
    public class FoulFamiliarIA : MagicCard
    {
        public FoulFamiliarIA()
        {
            Name = "Foul Familiar";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "3/1";
            Type = "Creature - Spirit";
            Text = "Foul Familiar can�t block.;^%B, Pay 1 life: Return Foul Familiar to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Foxfire
    public class FoxfireIA : MagicCard
    {
        public FoxfireIA()
        {
            Name = "Foxfire";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Instant";
            Text = "Untap target attacking creature. Prevent all combat damage that would be dealt to and dealt by that creature this turn.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Freyalise Supplicant
    public class FreyaliseSupplicantIA : MagicCard
    {
        public FreyaliseSupplicantIA()
        {
            Name = "Freyalise Supplicant";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "1G";
            PT = "1/1";
            Type = "Creature - Human Cleric";
            Text = "%T, Sacrifice a red or white creature: Freyalise Supplicant deals damage to target creature or player equal to half the sacrificed creature�s power, rounded down.";
            Flavor = "";
        }
    }
    # endregion

    # region Freyalise's Charm
    public class FreyalisesCharmIA : MagicCard
    {
        public FreyalisesCharmIA()
        {
            Name = "Freyalise's Charm";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "GG";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever an opponent casts a black spell, you may pay %G%G. If you do, you draw a card.;^%G%G: Return Freyalise�s Charm to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Freyalise's Winds
    public class FreyalisesWindsIA : MagicCard
    {
        public FreyalisesWindsIA()
        {
            Name = "Freyalise's Winds";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "2GG";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a permanent becomes tapped, put a wind counter on it.;^If a permanent with a wind counter on it would untap during its controller�s untap step, remove all wind counters from it instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Fumarole
    public class FumaroleIA : MagicCard
    {
        public FumaroleIA()
        {
            Name = "Fumarole";
            Edition = "IA";
            Rarity = "U";
            Color = "Gld";
            Cost = "3BR";
            PT = "";
            Type = "Sorcery";
            Text = "As an additional cost to cast Fumarole, pay 3 life.;^Destroy target creature and target land.";
            Flavor = "";
        }
    }
    # endregion

    # region Fylgja
    public class FylgjaIA : MagicCard
    {
        public FylgjaIA()
        {
            Name = "Fylgja";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Fylgja enters the battlefield with four healing counters on it.;^Remove a healing counter from Fylgja: Prevent the next 1 damage that would be dealt to enchanted creature this turn.;^%2%W: Put a healing counter on Fylgja.";
            Flavor = "";
        }
    }
    # endregion

    # region Fyndhorn Bow
    public class FyndhornBowIA : MagicCard
    {
        public FyndhornBowIA()
        {
            Name = "Fyndhorn Bow";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T: Target creature gains first strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Fyndhorn Brownie
    public class FyndhornBrownieIA : MagicCard
    {
        public FyndhornBrownieIA()
        {
            Name = "Fyndhorn Brownie";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "1/1";
            Type = "Creature - Ouphe";
            Text = "%2%G, %T: Untap target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Fyndhorn Elder
    public class FyndhornElderIA : MagicCard
    {
        public FyndhornElderIA()
        {
            Name = "Fyndhorn Elder";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "1/1";
            Type = "Creature - Elf Druid";
            Text = "%T: Add %G%G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Fyndhorn Elves
    public class FyndhornElvesIA : MagicCard
    {
        public FyndhornElvesIA()
        {
            Name = "Fyndhorn Elves";
            Edition = "IA";
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

    # region Fyndhorn Pollen
    public class FyndhornPollenIA : MagicCard
    {
        public FyndhornPollenIA()
        {
            Name = "Fyndhorn Pollen";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Enchantment";
            Text = "Cumulative upkeep %1 @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^All creatures get -1/-0.;^%1%G: All creatures get -1/-0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Game of Chaos
    public class GameofChaosIA : MagicCard
    {
        public GameofChaosIA()
        {
            Name = "Game of Chaos";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "RRR";
            PT = "";
            Type = "Sorcery";
            Text = "Flip a coin. If you win the flip, you gain 1 life and target opponent loses 1 life, and you decide whether to flip again. If you lose the flip, you lose 1 life and that opponent gains 1 life, and that player decides whether to flip again. Double the life stakes with each flip.";
            Flavor = "";
        }
    }
    # endregion

    # region Gangrenous Zombies
    public class GangrenousZombiesIA : MagicCard
    {
        public GangrenousZombiesIA()
        {
            Name = "Gangrenous Zombies";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "1BB";
            PT = "2/2";
            Type = "Creature - Zombie";
            Text = "%T, Sacrifice Gangrenous Zombies: Gangrenous Zombies deals 1 damage to each creature and each player. If you control a snow Swamp, Gangrenous Zombies deals 2 damage to each creature and each player instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Gaze of Pain
    public class GazeofPainIA : MagicCard
    {
        public GazeofPainIA()
        {
            Name = "Gaze of Pain";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Sorcery";
            Text = "Until end of turn, whenever a creature you control attacks and isn�t blocked, you may choose to have it deal damage equal to its power to a target creature. If you do, it assigns no combat damage this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region General Jarkeld
    public class GeneralJarkeldIA : MagicCard
    {
        public GeneralJarkeldIA()
        {
            Name = "General Jarkeld";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "1/2";
            Type = "Legendary Creature - Human Soldier";
            Text = "%T: Switch the blocking creatures of two target attacking creatures. Activate this ability only during the declare blockers step.";
            Flavor = "";
        }
    }
    # endregion

    # region Ghostly Flame
    public class GhostlyFlameIA : MagicCard
    {
        public GhostlyFlameIA()
        {
            Name = "Ghostly Flame";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "BR";
            PT = "";
            Type = "Enchantment";
            Text = "Black and/or red permanents and spells are colorless sources of damage.";
            Flavor = "";
        }
    }
    # endregion

    # region Giant Growth
    public class GiantGrowthIA : MagicCard
    {
        public GiantGrowthIA()
        {
            Name = "Giant Growth";
            Edition = "IA";
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

    # region Giant Trap Door Spider
    public class GiantTrapDoorSpiderIA : MagicCard
    {
        public GiantTrapDoorSpiderIA()
        {
            Name = "Giant Trap Door Spider";
            Edition = "IA";
            Rarity = "U";
            Color = "Gld";
            Cost = "1RG";
            PT = "2/3";
            Type = "Creature - Spider";
            Text = "%1%R%G, %T: Exile Giant Trap Door Spider and target creature without flying that�s attacking you.";
            Flavor = "";
        }
    }
    # endregion

    # region Glacial Chasm
    public class GlacialChasmIA : MagicCard
    {
        public GlacialChasmIA()
        {
            Name = "Glacial Chasm";
            Edition = "IA";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Cumulative upkeep�Pay 2 life. @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^When Glacial Chasm enters the battlefield, sacrifice a land.;^Creatures you control can�t attack.;^Prevent all damage that would be dealt to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Glacial Crevasses
    public class GlacialCrevassesIA : MagicCard
    {
        public GlacialCrevassesIA()
        {
            Name = "Glacial Crevasses";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Enchantment";
            Text = "Sacrifice a snow Mountain: Prevent all combat damage that would be dealt this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Glacial Wall
    public class GlacialWallIA : MagicCard
    {
        public GlacialWallIA()
        {
            Name = "Glacial Wall";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "0/7";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Glaciers
    public class GlaciersIA : MagicCard
    {
        public GlaciersIA()
        {
            Name = "Glaciers";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "2WU";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of your upkeep, sacrifice Glaciers unless you pay %W%U.;^All mountains are plains.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Lyre
    public class GoblinLyreIA : MagicCard
    {
        public GoblinLyreIA()
        {
            Name = "Goblin Lyre";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Sacrifice Goblin Lyre: Flip a coin. If you win the flip, Goblin Lyre deals damage to target opponent equal to the number of creatures you control. If you lose the flip, Goblin Lyre deals damage to you equal to the number of creatures that opponent controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Mutant
    public class GoblinMutantIA : MagicCard
    {
        public GoblinMutantIA()
        {
            Name = "Goblin Mutant";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "2RR";
            PT = "5/3";
            Type = "Creature - Goblin Mutant";
            Text = "Trample;^Goblin Mutant can�t attack if defending player controls an untapped creature with power 3 or greater.;^Goblin Mutant can�t block creatures with power 3 or greater.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Sappers
    public class GoblinSappersIA : MagicCard
    {
        public GoblinSappersIA()
        {
            Name = "Goblin Sappers";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "1/1";
            Type = "Creature - Goblin";
            Text = "%R%R, %T: Target creature you control can�t be blocked this turn. Destroy it and Goblin Sappers at end of combat.;^%R%R%R%R, %T: Target creature you control can�t be blocked this turn. Destroy it at end of combat.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Ski Patrol
    public class GoblinSkiPatrolIA : MagicCard
    {
        public GoblinSkiPatrolIA()
        {
            Name = "Goblin Ski Patrol";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "1/1";
            Type = "Creature - Goblin";
            Text = "%1%R: Goblin Ski Patrol gets +2/+0 and gains flying. Its controller sacrifices it at the beginning of the next end step. Activate this ability only once and only if you control a snow Mountain.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Snowman
    public class GoblinSnowmanIA : MagicCard
    {
        public GoblinSnowmanIA()
        {
            Name = "Goblin Snowman";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "1/1";
            Type = "Creature - Goblin";
            Text = "Whenever Goblin Snowman blocks, prevent all combat damage that would be dealt to and dealt by it this turn.;^%T: Goblin Snowman deals 1 damage to target creature it�s blocking.";
            Flavor = "";
        }
    }
    # endregion

    # region Gorilla Pack
    public class GorillaPackIA : MagicCard
    {
        public GorillaPackIA()
        {
            Name = "Gorilla Pack";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "3/3";
            Type = "Creature - Ape";
            Text = "Gorilla Pack can�t attack unless defending player controls a forest.;^When you control no forests, sacrifice Gorilla Pack.";
            Flavor = "";
        }
    }
    # endregion

    # region Gravebind
    public class GravebindIA : MagicCard
    {
        public GravebindIA()
        {
            Name = "Gravebind";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "Target creature can�t be regenerated this turn.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Green Scarab
    public class GreenScarabIA : MagicCard
    {
        public GreenScarabIA()
        {
            Name = "Green Scarab";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature can�t be blocked by green creatures.;^Enchanted creature gets +2/+2 as long as an opponent controls a green permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Grizzled Wolverine
    public class GrizzledWolverineIA : MagicCard
    {
        public GrizzledWolverineIA()
        {
            Name = "Grizzled Wolverine";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "1RR";
            PT = "2/2";
            Type = "Creature - Wolverine";
            Text = "%R: Grizzled Wolverine gets +2/+0 until end of turn. Activate this ability only during the declare blockers step, only if at least one creature is blocking Grizzled Wolverine, and only once each turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Hallowed Ground
    public class HallowedGroundIA : MagicCard
    {
        public HallowedGroundIA()
        {
            Name = "Hallowed Ground";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment";
            Text = "%W%W: Return target nonsnow land you control to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Halls of Mist
    public class HallsofMistIA : MagicCard
    {
        public HallsofMistIA()
        {
            Name = "Halls of Mist";
            Edition = "IA";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Cumulative upkeep %1 @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^Creatures that attacked during their controller�s last turn can�t attack.";
            Flavor = "";
        }
    }
    # endregion

    # region Heal
    public class HealIA : MagicCard
    {
        public HealIA()
        {
            Name = "Heal";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Prevent the next 1 damage that would be dealt to target creature or player this turn.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Hecatomb
    public class HecatombIA : MagicCard
    {
        public HecatombIA()
        {
            Name = "Hecatomb";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "1BB";
            PT = "";
            Type = "Enchantment";
            Text = "When Hecatomb enters the battlefield, sacrifice Hecatomb unless you sacrifice four creatures.;^Tap an untapped Swamp you control: Hecatomb deals 1 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Hematite Talisman
    public class HematiteTalismanIA : MagicCard
    {
        public HematiteTalismanIA()
        {
            Name = "Hematite Talisman";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a player casts a red spell, you may pay %3. If you do, untap target permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Hipparion
    public class HipparionIA : MagicCard
    {
        public HipparionIA()
        {
            Name = "Hipparion";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "1/3";
            Type = "Creature - Horse";
            Text = "Hipparion can�t block creatures with power 3 or greater unless you pay %1.";
            Flavor = "";
        }
    }
    # endregion

    # region Hoar Shade
    public class HoarShadeIA : MagicCard
    {
        public HoarShadeIA()
        {
            Name = "Hoar Shade";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "1/2";
            Type = "Creature - Shade";
            Text = "%B: Hoar Shade gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Hot Springs
    public class HotSpringsIA : MagicCard
    {
        public HotSpringsIA()
        {
            Name = "Hot Springs";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land you control;^Enchanted land has �%T: Prevent the next 1 damage that would be dealt to target creature or player this turn.�";
            Flavor = "";
        }
    }
    # endregion

    # region Howl from Beyond
    public class HowlfromBeyondIA : MagicCard
    {
        public HowlfromBeyondIA()
        {
            Name = "Howl from Beyond";
            Edition = "IA";
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

    # region Hurricane
    public class HurricaneIA : MagicCard
    {
        public HurricaneIA()
        {
            Name = "Hurricane";
            Edition = "IA";
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

    # region Hyalopterous Lemure
    public class HyalopterousLemureIA : MagicCard
    {
        public HyalopterousLemureIA()
        {
            Name = "Hyalopterous Lemure";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "4B";
            PT = "4/3";
            Type = "Creature - Spirit";
            Text = "%0: Hyalopterous Lemure gets -1/-0 and gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Hydroblast
    public class HydroblastIA : MagicCard
    {
        public HydroblastIA()
        {
            Name = "Hydroblast";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Counter target spell if it�s red; or destroy target permanent if it�s red.";
            Flavor = "";
        }
    }
    # endregion

    # region Hymn of Rebirth
    public class HymnofRebirthIA : MagicCard
    {
        public HymnofRebirthIA()
        {
            Name = "Hymn of Rebirth";
            Edition = "IA";
            Rarity = "U";
            Color = "Gld";
            Cost = "3GW";
            PT = "";
            Type = "Sorcery";
            Text = "Put target creature card from a graveyard onto the battlefield under your control.";
            Flavor = "";
        }
    }
    # endregion

    # region Ice Cauldron
    public class IceCauldronIA : MagicCard
    {
        public IceCauldronIA()
        {
            Name = "Ice Cauldron";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%X, %T: Put a charge counter on Ice Cauldron and exile a nonland card from your hand. You may cast that card for as long as it remains exiled. Note the type and amount of mana spent to pay this activation cost. Activate this ability only if there are no charge counters on Ice Cauldron.;^%T, Remove a charge counter from Ice Cauldron: Add Ice Cauldron�s last noted type and amount of mana to your mana pool. Spend this mana only to cast the last card exiled with Ice Cauldron.";
            Flavor = "";
        }
    }
    # endregion

    # region Ice Floe
    public class IceFloeIA : MagicCard
    {
        public IceFloeIA()
        {
            Name = "Ice Floe";
            Edition = "IA";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "You may choose not to untap Ice Floe during your untap step.;^%T: Tap target creature without flying that�s attacking you. It doesn�t untap during its controller�s untap step for as long as Ice Floe remains tapped.";
            Flavor = "";
        }
    }
    # endregion

    # region Iceberg
    public class IcebergIA : MagicCard
    {
        public IcebergIA()
        {
            Name = "Iceberg";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "XUU";
            PT = "";
            Type = "Enchantment";
            Text = "Iceberg enters the battlefield with X ice counters on it.;^%3: Put an ice counter on Iceberg.;^Remove an ice counter from Iceberg: Add %1 to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Icequake
    public class IcequakeIA : MagicCard
    {
        public IcequakeIA()
        {
            Name = "Icequake";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "1BB";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target land. If that land was a snow land, Icequake deals 1 damage to that land�s controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Icy Manipulator
    public class IcyManipulatorIA : MagicCard
    {
        public IcyManipulatorIA()
        {
            Name = "Icy Manipulator";
            Edition = "IA";
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

    # region Icy Prison
    public class IcyPrisonIA : MagicCard
    {
        public IcyPrisonIA()
        {
            Name = "Icy Prison";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "UU";
            PT = "";
            Type = "Enchantment";
            Text = "When Icy Prison enters the battlefield, exile target creature.;^At the beginning of your upkeep, sacrifice Icy Prison unless any player pays %3.;^When Icy Prison leaves the battlefield, return the exiled card to the battlefield under its owner�s control.";
            Flavor = "";
        }
    }
    # endregion

    # region Illusionary Forces
    public class IllusionaryForcesIA : MagicCard
    {
        public IllusionaryForcesIA()
        {
            Name = "Illusionary Forces";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "3U";
            PT = "4/4";
            Type = "Creature - Illusion";
            Text = "Flying;^Cumulative upkeep %U @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Illusionary Presence
    public class IllusionaryPresenceIA : MagicCard
    {
        public IllusionaryPresenceIA()
        {
            Name = "Illusionary Presence";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "1UU";
            PT = "2/2";
            Type = "Creature - Illusion";
            Text = "Cumulative upkeep %U @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^At the beginning of your upkeep, choose a land type. Illusionary Presence gains landwalk of the chosen type until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Illusionary Terrain
    public class IllusionaryTerrainIA : MagicCard
    {
        public IllusionaryTerrainIA()
        {
            Name = "Illusionary Terrain";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "UU";
            PT = "";
            Type = "Enchantment";
            Text = "Cumulative upkeep %2 @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^As Illusionary Terrain enters the battlefield, choose two basic land types.;^Basic lands of the first chosen type are the second chosen type.";
            Flavor = "";
        }
    }
    # endregion

    # region Illusionary Wall
    public class IllusionaryWallIA : MagicCard
    {
        public IllusionaryWallIA()
        {
            Name = "Illusionary Wall";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "4U";
            PT = "7/4";
            Type = "Creature - Illusion Wall";
            Text = "Defender, flying, first strike;^Cumulative upkeep %U @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Illusions of Grandeur
    public class IllusionsofGrandeurIA : MagicCard
    {
        public IllusionsofGrandeurIA()
        {
            Name = "Illusions of Grandeur";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Enchantment";
            Text = "Cumulative upkeep %2 @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^When Illusions of Grandeur enters the battlefield, you gain 20 life.;^When Illusions of Grandeur leaves the battlefield, you lose 20 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Imposing Visage
    public class ImposingVisageIA : MagicCard
    {
        public ImposingVisageIA()
        {
            Name = "Imposing Visage";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature can�t be blocked except by two or more creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Incinerate
    public class IncinerateIA : MagicCard
    {
        public IncinerateIA()
        {
            Name = "Incinerate";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "Incinerate deals 3 damage to target creature or player. A creature dealt damage this way can�t be regenerated this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Infernal Darkness
    public class InfernalDarknessIA : MagicCard
    {
        public InfernalDarknessIA()
        {
            Name = "Infernal Darkness";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "2BB";
            PT = "";
            Type = "Enchantment";
            Text = "Cumulative upkeep�Pay %B and 1 life. @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^If a land is tapped for mana, it produces %B instead of any other type.";
            Flavor = "";
        }
    }
    # endregion

    # region Infernal Denizen
    public class InfernalDenizenIA : MagicCard
    {
        public InfernalDenizenIA()
        {
            Name = "Infernal Denizen";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "7B";
            PT = "5/7";
            Type = "Creature - Demon";
            Text = "At the beginning of your upkeep, sacrifice two Swamps. If you can�t, tap Infernal Denizen, and an opponent may gain control of a creature you control of his or her choice for as long as Infernal Denizen remains on the battlefield.;^%T: Gain control of target creature for as long as Infernal Denizen remains on the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Infinite Hourglass
    public class InfiniteHourglassIA : MagicCard
    {
        public InfiniteHourglassIA()
        {
            Name = "Infinite Hourglass";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of your upkeep, put a time counter on Infinite Hourglass.;^All creatures get +1/+0 for each time counter on Infinite Hourglass.;^%3: Remove a time counter from Infinite Hourglass. Any player may activate this ability but only during any upkeep step.";
            Flavor = "";
        }
    }
    # endregion

    # region Infuse
    public class InfuseIA : MagicCard
    {
        public InfuseIA()
        {
            Name = "Infuse";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Instant";
            Text = "Untap target artifact, creature, or land.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Island
    public class IslandIA : MagicCard
    {
        public IslandIA()
        {
            Name = "Island ";
            Edition = "IA";
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

    # region Jester's Cap
    public class JestersCapIA : MagicCard
    {
        public JestersCapIA()
        {
            Name = "Jester's Cap";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T, Sacrifice Jester�s Cap: Search target player�s library for three cards and exile them. Then that player shuffles his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Jester's Mask
    public class JestersMaskIA : MagicCard
    {
        public JestersMaskIA()
        {
            Name = "Jester's Mask";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "Jester�s Mask enters the battlefield tapped.;^%1, %T, Sacrifice Jester�s Mask: Target opponent puts the cards from his or her hand on top of his or her library. Search that player�s library for that many cards. That player puts those cards into his or her hand, then shuffles his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Jeweled Amulet
    public class JeweledAmuletIA : MagicCard
    {
        public JeweledAmuletIA()
        {
            Name = "Jeweled Amulet";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "0";
            PT = "";
            Type = "Artifact";
            Text = "%1, %T: Put a charge counter on Jeweled Amulet. Note the type of mana spent to pay this activation cost. Activate this ability only if there are no charge counters on Jeweled Amulet.;^%T, Remove a charge counter from Jeweled Amulet: Add one mana of Jeweled Amulet�s last noted type to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Johtull Wurm
    public class JohtullWurmIA : MagicCard
    {
        public JohtullWurmIA()
        {
            Name = "Johtull Wurm";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "5G";
            PT = "6/6";
            Type = "Creature - Wurm";
            Text = "Whenever Johtull Wurm becomes blocked, it gets -2/-1 until end of turn for each creature blocking it beyond the first.";
            Flavor = "";
        }
    }
    # endregion

    # region Jokulhaups
    public class JokulhaupsIA : MagicCard
    {
        public JokulhaupsIA()
        {
            Name = "Jokulhaups";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "4RR";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy all artifacts, creatures, and lands. They can�t be regenerated.";
            Flavor = "";
        }
    }
    # endregion

    # region Juniper Order Druid
    public class JuniperOrderDruidIA : MagicCard
    {
        public JuniperOrderDruidIA()
        {
            Name = "Juniper Order Druid";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "1/1";
            Type = "Creature - Human Cleric Druid";
            Text = "%T: Untap target land.";
            Flavor = "";
        }
    }
    # endregion

    # region Justice
    public class JusticeIA : MagicCard
    {
        public JusticeIA()
        {
            Name = "Justice";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "2WW";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of your upkeep, sacrifice Justice unless you pay %W%W.;^Whenever a red creature or spell deals damage, Justice deals that much damage to that creature�s or spell�s controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Karplusan Forest
    public class KarplusanForestIA : MagicCard
    {
        public KarplusanForestIA()
        {
            Name = "Karplusan Forest";
            Edition = "IA";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%T: Add %R or %G to your mana pool. Karplusan Forest deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Karplusan Giant
    public class KarplusanGiantIA : MagicCard
    {
        public KarplusanGiantIA()
        {
            Name = "Karplusan Giant";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "6R";
            PT = "3/3";
            Type = "Creature - Giant";
            Text = "Tap an untapped snow land you control: Karplusan Giant gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Karplusan Yeti
    public class KarplusanYetiIA : MagicCard
    {
        public KarplusanYetiIA()
        {
            Name = "Karplusan Yeti";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "3RR";
            PT = "3/3";
            Type = "Creature - Yeti";
            Text = "%T: Karplusan Yeti deals damage equal to its power to target creature. That creature deals damage equal to its power to Karplusan Yeti.";
            Flavor = "";
        }
    }
    # endregion

    # region Kelsinko Ranger
    public class KelsinkoRangerIA : MagicCard
    {
        public KelsinkoRangerIA()
        {
            Name = "Kelsinko Ranger";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Human";
            Text = "%1%W: Target green creature gains first strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Kjeldoran Dead
    public class KjeldoranDeadIA : MagicCard
    {
        public KjeldoranDeadIA()
        {
            Name = "Kjeldoran Dead";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "3/1";
            Type = "Creature - Skeleton";
            Text = "When Kjeldoran Dead enters the battlefield, sacrifice a creature.;^%B: Regenerate Kjeldoran Dead.";
            Flavor = "";
        }
    }
    # endregion

    # region Kjeldoran Elite Guard
    public class KjeldoranEliteGuardIA : MagicCard
    {
        public KjeldoranEliteGuardIA()
        {
            Name = "Kjeldoran Elite Guard";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "2/2";
            Type = "Creature - Human Soldier";
            Text = "%T: Target creature gets +2/+2 until end of turn. When that creature leaves the battlefield this turn, sacrifice Kjeldoran Elite Guard. Activate this ability only during combat.";
            Flavor = "";
        }
    }
    # endregion

    # region Kjeldoran Frostbeast
    public class KjeldoranFrostbeastIA : MagicCard
    {
        public KjeldoranFrostbeastIA()
        {
            Name = "Kjeldoran Frostbeast";
            Edition = "IA";
            Rarity = "U";
            Color = "Gld";
            Cost = "3GW";
            PT = "2/4";
            Type = "Creature - Elemental Beast";
            Text = "At end of combat, destroy all creatures blocking or blocked by Kjeldoran Frostbeast.";
            Flavor = "";
        }
    }
    # endregion

    # region Kjeldoran Guard
    public class KjeldoranGuardIA : MagicCard
    {
        public KjeldoranGuardIA()
        {
            Name = "Kjeldoran Guard";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "1/1";
            Type = "Creature - Human Soldier";
            Text = "%T: Target creature gets +1/+1 until end of turn. When that creature leaves the battlefield this turn, sacrifice Kjeldoran Guard. Activate this ability only during combat and only if defending player controls no snow lands.";
            Flavor = "";
        }
    }
    # endregion

    # region Kjeldoran Knight
    public class KjeldoranKnightIA : MagicCard
    {
        public KjeldoranKnightIA()
        {
            Name = "Kjeldoran Knight";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "WW";
            PT = "1/1";
            Type = "Creature - Human Knight";
            Text = "Banding @(Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding you control are blocking or being blocked by a creature, you divide that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by or is blocking.)@;^%1%W: Kjeldoran Knight gets +1/+0 until end of turn.;^%W%W: Kjeldoran Knight gets +0/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Kjeldoran Phalanx
    public class KjeldoranPhalanxIA : MagicCard
    {
        public KjeldoranPhalanxIA()
        {
            Name = "Kjeldoran Phalanx";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "5W";
            PT = "2/5";
            Type = "Creature - Human Soldier";
            Text = "First strike; banding @(Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding you control are blocking or being blocked by a creature, you divide that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by or is blocking.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Kjeldoran Royal Guard
    public class KjeldoranRoyalGuardIA : MagicCard
    {
        public KjeldoranRoyalGuardIA()
        {
            Name = "Kjeldoran Royal Guard";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "3WW";
            PT = "2/5";
            Type = "Creature - Human Soldier";
            Text = "%T: All combat damage that would be dealt to you by unblocked creatures this turn is dealt to Kjeldoran Royal Guard instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Kjeldoran Skycaptain
    public class KjeldoranSkycaptainIA : MagicCard
    {
        public KjeldoranSkycaptainIA()
        {
            Name = "Kjeldoran Skycaptain";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "4W";
            PT = "2/2";
            Type = "Creature - Human Soldier";
            Text = "Flying; first strike; banding @(Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding you control are blocking or being blocked by a creature, you divide that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by or is blocking.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Kjeldoran Skyknight
    public class KjeldoranSkyknightIA : MagicCard
    {
        public KjeldoranSkyknightIA()
        {
            Name = "Kjeldoran Skyknight";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "1/1";
            Type = "Creature - Human Knight";
            Text = "Flying; first strike; banding @(Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding you control are blocking or being blocked by a creature, you divide that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by or is blocking.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Kjeldoran Warrior
    public class KjeldoranWarriorIA : MagicCard
    {
        public KjeldoranWarriorIA()
        {
            Name = "Kjeldoran Warrior";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Human Warrior";
            Text = "Banding @(Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding you control are blocking or being blocked by a creature, you divide that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by or is blocking.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Knight of Stromgald
    public class KnightofStromgaldIA : MagicCard
    {
        public KnightofStromgaldIA()
        {
            Name = "Knight of Stromgald";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "BB";
            PT = "2/1";
            Type = "Creature - Human Knight";
            Text = "Protection from white;^%B: Knight of Stromgald gains first strike until end of turn.;^%B%B: Knight of Stromgald gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Krovikan Elementalist
    public class KrovikanElementalistIA : MagicCard
    {
        public KrovikanElementalistIA()
        {
            Name = "Krovikan Elementalist";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "BB";
            PT = "1/1";
            Type = "Creature - Human Wizard";
            Text = "%2%R: Target creature gets +1/+0 until end of turn.;^%U%U: Target creature you control gains flying until end of turn. Sacrifice it at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Krovikan Fetish
    public class KrovikanFetishIA : MagicCard
    {
        public KrovikanFetishIA()
        {
            Name = "Krovikan Fetish";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^When Krovikan Fetish enters the battlefield, draw a card at the beginning of the next turn�s upkeep.;^Enchanted creature gets +1/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Krovikan Sorcerer
    public class KrovikanSorcererIA : MagicCard
    {
        public KrovikanSorcererIA()
        {
            Name = "Krovikan Sorcerer";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "1/1";
            Type = "Creature - Human Wizard";
            Text = "%T, Discard a nonblack card: Draw a card.;^%T, Discard a black card: Draw two cards, then discard one of them.";
            Flavor = "";
        }
    }
    # endregion

    # region Krovikan Vampire
    public class KrovikanVampireIA : MagicCard
    {
        public KrovikanVampireIA()
        {
            Name = "Krovikan Vampire";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "3BB";
            PT = "3/3";
            Type = "Creature - Vampire";
            Text = "At the beginning of each end step, if a creature dealt damage by Krovikan Vampire this turn died, put that card onto the battlefield under your control. Sacrifice it when you lose control of Krovikan Vampire.";
            Flavor = "";
        }
    }
    # endregion

    # region Land Cap
    public class LandCapIA : MagicCard
    {
        public LandCapIA()
        {
            Name = "Land Cap";
            Edition = "IA";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Land Cap doesn�t untap during your untap step if it has a depletion counter on it.;^At the beginning of your upkeep, remove a depletion counter from Land Cap.;^%T: Add %W or %U to your mana pool. Put a depletion counter on Land Cap.";
            Flavor = "";
        }
    }
    # endregion

    # region Lapis Lazuli Talisman
    public class LapisLazuliTalismanIA : MagicCard
    {
        public LapisLazuliTalismanIA()
        {
            Name = "Lapis Lazuli Talisman";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a player casts a blue spell, you may pay %3. If you do, untap target permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Lava Burst
    public class LavaBurstIA : MagicCard
    {
        public LavaBurstIA()
        {
            Name = "Lava Burst";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "XR";
            PT = "";
            Type = "Sorcery";
            Text = "Lava Burst deals X damage to target creature or player. If Lava Burst would deal damage to a creature, that damage can�t be prevented or dealt instead to another creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Lava Tubes
    public class LavaTubesIA : MagicCard
    {
        public LavaTubesIA()
        {
            Name = "Lava Tubes";
            Edition = "IA";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Lava Tubes doesn�t untap during your untap step if it has a depletion counter on it.;^At the beginning of your upkeep, remove a depletion counter from Lava Tubes.;^%T: Add %B or %R to your mana pool. Put a depletion counter on Lava Tubes.";
            Flavor = "";
        }
    }
    # endregion

    # region Legions of Lim-Dul
    public class LegionsofLimDulIA : MagicCard
    {
        public LegionsofLimDulIA()
        {
            Name = "Legions of Lim-Dul";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "1BB";
            PT = "2/3";
            Type = "Creature - Zombie";
            Text = "Snow swampwalk";
            Flavor = "";
        }
    }
    # endregion

    # region Leshrac's Rite
    public class LeshracsRiteIA : MagicCard
    {
        public LeshracsRiteIA()
        {
            Name = "Leshrac's Rite";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature has swampwalk.";
            Flavor = "";
        }
    }
    # endregion

    # region Leshrac's Sigil
    public class LeshracsSigilIA : MagicCard
    {
        public LeshracsSigilIA()
        {
            Name = "Leshrac's Sigil";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "BB";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever an opponent casts a green spell, you may pay %B%B. If you do, look at that player�s hand and choose a card from it. The player discards that card.;^%B%B: Return Leshrac�s Sigil to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Lhurgoyf
    public class LhurgoyfIA : MagicCard
    {
        public LhurgoyfIA()
        {
            Name = "Lhurgoyf";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "2GG";
            PT = "*/1+*";
            Type = "Creature - Lhurgoyf";
            Text = "Lhurgoyf�s power is equal to the number of creature cards in all graveyards and its toughness is equal to that number plus 1.";
            Flavor = "";
        }
    }
    # endregion

    # region Lightning Blow
    public class LightningBlowIA : MagicCard
    {
        public LightningBlowIA()
        {
            Name = "Lightning Blow";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Target creature gains first strike until end of turn.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Lim-Dul's Cohort
    public class LimDulsCohortIA : MagicCard
    {
        public LimDulsCohortIA()
        {
            Name = "Lim-Dul's Cohort";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "1BB";
            PT = "2/3";
            Type = "Creature - Zombie";
            Text = "Whenever Lim-Dul�s Cohort blocks or becomes blocked by a creature, that creature can�t be regenerated this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Lim-Dul's Hex
    public class LimDulsHexIA : MagicCard
    {
        public LimDulsHexIA()
        {
            Name = "Lim-Dul's Hex";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of your upkeep, for each player, Lim-Dul�s Hex deals 1 damage to that player unless he or she pays %B or %3.";
            Flavor = "";
        }
    }
    # endregion

    # region Lost Order of Jarkeld
    public class LostOrderofJarkeldIA : MagicCard
    {
        public LostOrderofJarkeldIA()
        {
            Name = "Lost Order of Jarkeld";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "2WW";
            PT = "1+*/1+";
            Type = "Creature - Human Knight";
            Text = "As Lost Order of Jarkeld enters the battlefield, choose an opponent.;^Lost Order of Jarkeld�s power and toughness are each equal to 1 plus the number of creatures the chosen player controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Lure
    public class LureIA : MagicCard
    {
        public LureIA()
        {
            Name = "Lure";
            Edition = "IA";
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

    # region Maddening Wind
    public class MaddeningWindIA : MagicCard
    {
        public MaddeningWindIA()
        {
            Name = "Maddening Wind";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Cumulative upkeep %G @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^At the beginning of the upkeep of enchanted creature�s controller, Maddening Wind deals 2 damage to that player.";
            Flavor = "";
        }
    }
    # endregion

    # region Magus of the Unseen
    public class MagusoftheUnseenIA : MagicCard
    {
        public MagusoftheUnseenIA()
        {
            Name = "Magus of the Unseen";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Human Wizard";
            Text = "%1%U, %T: Untap target artifact an opponent controls and gain control of it until end of turn. It gains haste until end of turn. When you lose control of the artifact, tap it.";
            Flavor = "";
        }
    }
    # endregion

    # region Malachite Talisman
    public class MalachiteTalismanIA : MagicCard
    {
        public MalachiteTalismanIA()
        {
            Name = "Malachite Talisman";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a player casts a green spell, you may pay %3. If you do, untap target permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Marton Stromgald
    public class MartonStromgaldIA : MagicCard
    {
        public MartonStromgaldIA()
        {
            Name = "Marton Stromgald";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "2RR";
            PT = "1/1";
            Type = "Legendary Creature - Human Knight";
            Text = "Whenever Marton Stromgald attacks, other attacking creatures get +1/+1 until end of turn for each attacking creature other than Marton Stromgald.;^Whenever Marton Stromgald blocks, other blocking creatures get +1/+1 until end of turn for each blocking creature other than Marton Stromgald.";
            Flavor = "";
        }
    }
    # endregion

    # region Melee
    public class MeleeIA : MagicCard
    {
        public MeleeIA()
        {
            Name = "Melee";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "4R";
            PT = "";
            Type = "Instant";
            Text = "Cast Melee only during your turn and only during combat before blockers are declared.;^You choose which creatures block this combat and how those creatures block.;^Whenever a creature attacks and isn�t blocked this combat, untap it and remove it from combat.";
            Flavor = "";
        }
    }
    # endregion

    # region Melting
    public class MeltingIA : MagicCard
    {
        public MeltingIA()
        {
            Name = "Melting";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Enchantment";
            Text = "All lands are no longer snow.";
            Flavor = "";
        }
    }
    # endregion

    # region Mercenaries
    public class MercenariesIA : MagicCard
    {
        public MercenariesIA()
        {
            Name = "Mercenaries";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "3/3";
            Type = "Creature - Human Mercenary";
            Text = "%3: The next time Mercenaries would deal damage to you this turn, prevent that damage. Any player may activate this ability.";
            Flavor = "";
        }
    }
    # endregion

    # region Merieke Ri Berit
    public class MeriekeRiBeritIA : MagicCard
    {
        public MeriekeRiBeritIA()
        {
            Name = "Merieke Ri Berit";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "WUB";
            PT = "1/1";
            Type = "Legendary Creature - Human";
            Text = "Merieke Ri Berit doesn�t untap during your untap step.;^%T: Gain control of target creature for as long as you control Merieke Ri Berit. When Merieke Ri Berit leaves the battlefield or becomes untapped, destroy that creature. It can�t be regenerated.";
            Flavor = "";
        }
    }
    # endregion

    # region Mesmeric Trance
    public class MesmericTranceIA : MagicCard
    {
        public MesmericTranceIA()
        {
            Name = "Mesmeric Trance";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "1UU";
            PT = "";
            Type = "Enchantment";
            Text = "Cumulative upkeep %1 @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^%U, Discard a card: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Meteor Shower
    public class MeteorShowerIA : MagicCard
    {
        public MeteorShowerIA()
        {
            Name = "Meteor Shower";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "XXR";
            PT = "";
            Type = "Sorcery";
            Text = "Meteor Shower deals X plus 1 damage divided as you choose among any number of target creatures and/or players.";
            Flavor = "";
        }
    }
    # endregion

    # region Mind Ravel
    public class MindRavelIA : MagicCard
    {
        public MindRavelIA()
        {
            Name = "Mind Ravel";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Sorcery";
            Text = "Target player discards a card.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Mind Warp
    public class MindWarpIA : MagicCard
    {
        public MindWarpIA()
        {
            Name = "Mind Warp";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "X3B";
            PT = "";
            Type = "Sorcery";
            Text = "Look at target player�s hand and choose X cards from it. That player discards those cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Mind Whip
    public class MindWhipIA : MagicCard
    {
        public MindWhipIA()
        {
            Name = "Mind Whip";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "2BB";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^At the beginning of the upkeep of enchanted creature�s controller, that player may pay %3. If he or she doesn�t, Mind Whip deals 2 damage to that player and you tap that creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Minion of Leshrac
    public class MinionofLeshracIA : MagicCard
    {
        public MinionofLeshracIA()
        {
            Name = "Minion of Leshrac";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "4BBB";
            PT = "5/5";
            Type = "Creature - Demon Minion";
            Text = "Protection from black;^At the beginning of your upkeep, Minion of Leshrac deals 5 damage to you unless you sacrifice a creature other than Minion of Leshrac. If Minion of Leshrac deals damage to you this way, tap it.;^%T: Destroy target creature or land.";
            Flavor = "";
        }
    }
    # endregion

    # region Minion of Tevesh Szat
    public class MinionofTeveshSzatIA : MagicCard
    {
        public MinionofTeveshSzatIA()
        {
            Name = "Minion of Tevesh Szat";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "4BBB";
            PT = "4/4";
            Type = "Creature - Demon Minion";
            Text = "At the beginning of your upkeep, Minion of Tevesh Szat deals 2 damage to you unless you pay %B%B.;^%T: Target creature gets +3/-2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Mistfolk
    public class MistfolkIA : MagicCard
    {
        public MistfolkIA()
        {
            Name = "Mistfolk";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "UU";
            PT = "1/2";
            Type = "Creature - Illusion";
            Text = "%U: Counter target spell that targets Mistfolk.";
            Flavor = "";
        }
    }
    # endregion

    # region Mole Worms
    public class MoleWormsIA : MagicCard
    {
        public MoleWormsIA()
        {
            Name = "Mole Worms";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "1/1";
            Type = "Creature - Worm";
            Text = "You may choose not to untap Mole Worms during your untap step.;^%T: Tap target land. It doesn�t untap during its controller�s untap step for as long as Mole Worms remains tapped.";
            Flavor = "";
        }
    }
    # endregion

    # region Monsoon
    public class MonsoonIA : MagicCard
    {
        public MonsoonIA()
        {
            Name = "Monsoon";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "2RG";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of each player�s end step, tap all untapped Islands that player controls and Monsoon deals X damage to the player, where X is the number of Islands tapped this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Moor Fiend
    public class MoorFiendIA : MagicCard
    {
        public MoorFiendIA()
        {
            Name = "Moor Fiend";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "3/3";
            Type = "Creature - Horror";
            Text = "Swampwalk";
            Flavor = "";
        }
    }
    # endregion

    # region Mountain
    public class MountainIA : MagicCard
    {
        public MountainIA()
        {
            Name = "Mountain ";
            Edition = "IA";
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

    # region Mountain Goat
    public class MountainGoatIA : MagicCard
    {
        public MountainGoatIA()
        {
            Name = "Mountain Goat";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Goat";
            Text = "Mountainwalk";
            Flavor = "";
        }
    }
    # endregion

    # region Mountain Titan
    public class MountainTitanIA : MagicCard
    {
        public MountainTitanIA()
        {
            Name = "Mountain Titan";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "2BR";
            PT = "2/2";
            Type = "Creature - Giant";
            Text = "%1%R%R: Until end of turn, whenever you cast a black spell, put a +1/+1 counter on Mountain Titan.";
            Flavor = "";
        }
    }
    # endregion

    # region Mudslide
    public class MudslideIA : MagicCard
    {
        public MudslideIA()
        {
            Name = "Mudslide";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Enchantment";
            Text = "Creatures without flying don�t untap during their controllers� untap steps.;^At the beginning of each player�s upkeep, that player may choose any number of tapped creatures without flying he or she controls and pay %2 for each creature chosen this way. If the player does, untap those creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Musician
    public class MusicianIA : MagicCard
    {
        public MusicianIA()
        {
            Name = "Musician";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "2U";
            PT = "1/3";
            Type = "Creature - Human Wizard";
            Text = "Cumulative upkeep %1 @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^%T: Put a music counter on target creature. If it doesn�t have �At the beginning of your upkeep, destroy this creature unless you pay %1 for each music counter on it,� it gains that ability.";
            Flavor = "";
        }
    }
    # endregion

    # region Mystic Might
    public class MysticMightIA : MagicCard
    {
        public MysticMightIA()
        {
            Name = "Mystic Might";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land you control;^Cumulative upkeep %1%U @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^Enchanted land has �%T: Target creature gets +2/+2 until end of turn.�";
            Flavor = "";
        }
    }
    # endregion

    # region Mystic Remora
    public class MysticRemoraIA : MagicCard
    {
        public MysticRemoraIA()
        {
            Name = "Mystic Remora";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Enchantment";
            Text = "Cumulative upkeep %1 @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^Whenever an opponent casts a noncreature spell, you may draw a card unless that player pays %4.";
            Flavor = "";
        }
    }
    # endregion

    # region Nacre Talisman
    public class NacreTalismanIA : MagicCard
    {
        public NacreTalismanIA()
        {
            Name = "Nacre Talisman";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a player casts a white spell, you may pay %3. If you do, untap target permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Naked Singularity
    public class NakedSingularityIA : MagicCard
    {
        public NakedSingularityIA()
        {
            Name = "Naked Singularity";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "Cumulative upkeep %3 @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^If tapped for mana, Plains produce %R, Islands produce %G, Swamps produce %W, Mountains produce %U, and Forests produce %B instead of any other type.";
            Flavor = "";
        }
    }
    # endregion

    # region Nature's Lore
    public class NaturesLoreIA : MagicCard
    {
        public NaturesLoreIA()
        {
            Name = "Nature's Lore";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Sorcery";
            Text = "Search your library for a Forest card and put that card onto the battlefield. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Necropotence
    public class NecropotenceIA : MagicCard
    {
        public NecropotenceIA()
        {
            Name = "Necropotence";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "BBB";
            PT = "";
            Type = "Enchantment";
            Text = "Skip your draw step.;^Whenever you discard a card, exile that card from your graveyard.;^Pay 1 life: Exile the top card of your library face down. Put that card into your hand at the beginning of your next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Norritt
    public class NorrittIA : MagicCard
    {
        public NorrittIA()
        {
            Name = "Norritt";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "1/1";
            Type = "Creature - Imp";
            Text = "%T: Untap target blue creature.;^%T: Choose target non-Wall creature the active player has controlled continuously since the beginning of the turn. That creature attacks this turn if able. If it doesn�t, destroy it at the beginning of the next end step. Activate this ability only before attackers are declared.";
            Flavor = "";
        }
    }
    # endregion

    # region Oath of Lim-Dul
    public class OathofLimDulIA : MagicCard
    {
        public OathofLimDulIA()
        {
            Name = "Oath of Lim-Dul";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "3B";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever you lose life, for each 1 life you lost, sacrifice a permanent other than Oath of Lim-Dul unless you discard a card. @(Damage dealt to you causes you to lose life.)@;^%B%B: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Onyx Talisman
    public class OnyxTalismanIA : MagicCard
    {
        public OnyxTalismanIA()
        {
            Name = "Onyx Talisman";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a player casts a black spell, you may pay %3. If you do, untap target permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Orcish Cannoneers
    public class OrcishCannoneersIA : MagicCard
    {
        public OrcishCannoneersIA()
        {
            Name = "Orcish Cannoneers";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "1RR";
            PT = "1/3";
            Type = "Creature - Orc Warrior";
            Text = "%T: Orcish Cannoneers deals 2 damage to target creature or player and 3 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Orcish Conscripts
    public class OrcishConscriptsIA : MagicCard
    {
        public OrcishConscriptsIA()
        {
            Name = "Orcish Conscripts";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "2/2";
            Type = "Creature - Orc";
            Text = "Orcish Conscripts can�t attack unless at least two other creatures attack.;^Orcish Conscripts can�t block unless at least two other creatures block.";
            Flavor = "";
        }
    }
    # endregion

    # region Orcish Farmer
    public class OrcishFarmerIA : MagicCard
    {
        public OrcishFarmerIA()
        {
            Name = "Orcish Farmer";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "1RR";
            PT = "2/2";
            Type = "Creature - Orc";
            Text = "%T: Target land becomes a Swamp until its controller�s next untap step.";
            Flavor = "";
        }
    }
    # endregion

    # region Orcish Healer
    public class OrcishHealerIA : MagicCard
    {
        public OrcishHealerIA()
        {
            Name = "Orcish Healer";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "RR";
            PT = "1/1";
            Type = "Creature - Orc Cleric";
            Text = "%R%R, %T: Target creature can�t be regenerated this turn.;^%B%B%R, %T: Regenerate target black or green creature.;^%R%G%G, %T: Regenerate target black or green creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Orcish Librarian
    public class OrcishLibrarianIA : MagicCard
    {
        public OrcishLibrarianIA()
        {
            Name = "Orcish Librarian";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "1R";
            PT = "1/1";
            Type = "Creature - Orc";
            Text = "%R, %T: Look at the top eight cards of your library. Exile four of them at random, then put the rest on top of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Orcish Lumberjack
    public class OrcishLumberjackIA : MagicCard
    {
        public OrcishLumberjackIA()
        {
            Name = "Orcish Lumberjack";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Orc";
            Text = "%T, Sacrifice a Forest: Add three mana in any combination of %R and/or %G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Orcish Squatters
    public class OrcishSquattersIA : MagicCard
    {
        public OrcishSquattersIA()
        {
            Name = "Orcish Squatters";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "4R";
            PT = "2/3";
            Type = "Creature - Orc";
            Text = "Whenever Orcish Squatters attacks and isn�t blocked, you may gain control of target land defending player controls for as long as you control Orcish Squatters. If you do, Orcish Squatters assigns no combat damage this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Order of the Sacred Torch
    public class OrderoftheSacredTorchIA : MagicCard
    {
        public OrderoftheSacredTorchIA()
        {
            Name = "Order of the Sacred Torch";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "1WW";
            PT = "2/2";
            Type = "Creature - Human Knight";
            Text = "%T, Pay 1 life: Counter target black spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Order of the White Shield
    public class OrderoftheWhiteShieldIA : MagicCard
    {
        public OrderoftheWhiteShieldIA()
        {
            Name = "Order of the White Shield";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "WW";
            PT = "2/1";
            Type = "Creature - Human Knight";
            Text = "Protection from black;^%W: Order of the White Shield gains first strike until end of turn.;^%W%W: Order of the White Shield gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Pale Bears
    public class PaleBearsIA : MagicCard
    {
        public PaleBearsIA()
        {
            Name = "Pale Bears";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Bear";
            Text = "Islandwalk";
            Flavor = "";
        }
    }
    # endregion

    # region Panic
    public class PanicIA : MagicCard
    {
        public PanicIA()
        {
            Name = "Panic";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Cast Panic only during combat before blockers are declared.;^Target creature can�t block this turn.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Pentagram of the Ages
    public class PentagramoftheAgesIA : MagicCard
    {
        public PentagramoftheAgesIA()
        {
            Name = "Pentagram of the Ages";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%4, %T: The next time a source of your choice would deal damage to you this turn, prevent that damage.";
            Flavor = "";
        }
    }
    # endregion

    # region Pestilence Rats
    public class PestilenceRatsIA : MagicCard
    {
        public PestilenceRatsIA()
        {
            Name = "Pestilence Rats";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "*/3";
            Type = "Creature - Rat";
            Text = "Pestilence Rats�s power is equal to the number of other Rats on the battlefield. @(For example, as long as there are two other Rats on the battlefield, Pestilence Rats�s power and toughness are 2/3.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Phantasmal Mount
    public class PhantasmalMountIA : MagicCard
    {
        public PhantasmalMountIA()
        {
            Name = "Phantasmal Mount";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Illusion Horse";
            Text = "Flying;^%T: Target creature you control with toughness 2 or less gets +1/+1 and gains flying until end of turn. When Phantasmal Mount leaves the battlefield this turn, sacrifice that creature. When the creature leaves the battlefield this turn, sacrifice Phantasmal Mount.";
            Flavor = "";
        }
    }
    # endregion

    # region Pit Trap
    public class PitTrapIA : MagicCard
    {
        public PitTrapIA()
        {
            Name = "Pit Trap";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T, Sacrifice Pit Trap: Destroy target attacking creature without flying. It can�t be regenerated.";
            Flavor = "";
        }
    }
    # endregion

    # region Plains
    public class PlainsIA : MagicCard
    {
        public PlainsIA()
        {
            Name = "Plains ";
            Edition = "IA";
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

    # region Polar Kraken
    public class PolarKrakenIA : MagicCard
    {
        public PolarKrakenIA()
        {
            Name = "Polar Kraken";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "8UUU";
            PT = "11/11";
            Type = "Creature - Kraken";
            Text = "Trample;^Polar Kraken enters the battlefield tapped.;^Cumulative upkeep�Sacrifice a land. @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Portent
    public class PortentIA : MagicCard
    {
        public PortentIA()
        {
            Name = "Portent";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Sorcery";
            Text = "Look at the top three cards of target player�s library, then put them back in any order. You may have that player shuffle his or her library.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Power Sink
    public class PowerSinkIA : MagicCard
    {
        public PowerSinkIA()
        {
            Name = "Power Sink";
            Edition = "IA";
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

    # region Pox
    public class PoxIA : MagicCard
    {
        public PoxIA()
        {
            Name = "Pox";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "BBB";
            PT = "";
            Type = "Sorcery";
            Text = "Each player loses a third of his or her life, then discards a third of the cards in his or her hand, then sacrifices a third of the creatures he or she controls, then sacrifices a third of the lands he or she controls. Round up each time.";
            Flavor = "";
        }
    }
    # endregion

    # region Prismatic Ward
    public class PrismaticWardIA : MagicCard
    {
        public PrismaticWardIA()
        {
            Name = "Prismatic Ward";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^As Prismatic Ward enters the battlefield, choose a color.;^Prevent all damage that would be dealt to enchanted creature by sources of the chosen color.";
            Flavor = "";
        }
    }
    # endregion

    # region Pygmy Allosaurus
    public class PygmyAllosaurusIA : MagicCard
    {
        public PygmyAllosaurusIA()
        {
            Name = "Pygmy Allosaurus";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Lizard";
            Text = "Swampwalk";
            Flavor = "";
        }
    }
    # endregion

    # region Pyknite
    public class PykniteIA : MagicCard
    {
        public PykniteIA()
        {
            Name = "Pyknite";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "1/1";
            Type = "Creature - Ouphe";
            Text = "When Pyknite enters the battlefield, draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Pyroblast
    public class PyroblastIA : MagicCard
    {
        public PyroblastIA()
        {
            Name = "Pyroblast";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Counter target spell if it�s blue; or destroy target permanent if it�s blue.";
            Flavor = "";
        }
    }
    # endregion

    # region Pyroclasm
    public class PyroclasmIA : MagicCard
    {
        public PyroclasmIA()
        {
            Name = "Pyroclasm";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Sorcery";
            Text = "Pyroclasm deals 2 damage to each creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Rally
    public class RallyIA : MagicCard
    {
        public RallyIA()
        {
            Name = "Rally";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "WW";
            PT = "";
            Type = "Instant";
            Text = "Blocking creatures get +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Ray of Command
    public class RayofCommandIA : MagicCard
    {
        public RayofCommandIA()
        {
            Name = "Ray of Command";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Instant";
            Text = "Untap target creature an opponent controls and gain control of it until end of turn. That creature gains haste until end of turn. When you lose control of the creature, tap it.";
            Flavor = "";
        }
    }
    # endregion

    # region Ray of Erasure
    public class RayofErasureIA : MagicCard
    {
        public RayofErasureIA()
        {
            Name = "Ray of Erasure";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Target player puts the top card of his or her library into his or her graveyard.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Reality Twist
    public class RealityTwistIA : MagicCard
    {
        public RealityTwistIA()
        {
            Name = "Reality Twist";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "UUU";
            PT = "";
            Type = "Enchantment";
            Text = "Cumulative upkeep %1%U%U @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^If tapped for mana, Plains produce %R, Swamps produce %G, Mountains produce %W, and Forests produce %B instead of any other type.";
            Flavor = "";
        }
    }
    # endregion

    # region Reclamation
    public class ReclamationIA : MagicCard
    {
        public ReclamationIA()
        {
            Name = "Reclamation";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "2GW";
            PT = "";
            Type = "Enchantment";
            Text = "Black creatures can�t attack unless their controller sacrifices a land for each black creature he or she controls that�s attacking. @(This cost is paid as attackers are declared.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Red Scarab
    public class RedScarabIA : MagicCard
    {
        public RedScarabIA()
        {
            Name = "Red Scarab";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature can�t be blocked by red creatures.;^Enchanted creature gets +2/+2 as long as an opponent controls a red permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Regeneration
    public class RegenerationIA : MagicCard
    {
        public RegenerationIA()
        {
            Name = "Regeneration";
            Edition = "IA";
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

    # region Rime Dryad
    public class RimeDryadIA : MagicCard
    {
        public RimeDryadIA()
        {
            Name = "Rime Dryad";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/2";
            Type = "Creature - Dryad";
            Text = "Snow forestwalk";
            Flavor = "";
        }
    }
    # endregion

    # region Ritual of Subdual
    public class RitualofSubdualIA : MagicCard
    {
        public RitualofSubdualIA()
        {
            Name = "Ritual of Subdual";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "4GG";
            PT = "";
            Type = "Enchantment";
            Text = "Cumulative upkeep %2 @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^If a land is tapped for mana, it produces colorless mana instead of any other type.";
            Flavor = "";
        }
    }
    # endregion

    # region River Delta
    public class RiverDeltaIA : MagicCard
    {
        public RiverDeltaIA()
        {
            Name = "River Delta";
            Edition = "IA";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "River Delta doesn�t untap during your untap step if it has a depletion counter on it.;^At the beginning of your upkeep, remove a depletion counter from River Delta.;^%T: Add %U or %B to your mana pool. Put a depletion counter on River Delta.";
            Flavor = "";
        }
    }
    # endregion

    # region Runed Arch
    public class RunedArchIA : MagicCard
    {
        public RunedArchIA()
        {
            Name = "Runed Arch";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Runed Arch enters the battlefield tapped.;^%X, %T, Sacrifice Runed Arch: X target creatures with power 2 or less can�t be blocked this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Sabretooth Tiger
    public class SabretoothTigerIA : MagicCard
    {
        public SabretoothTigerIA()
        {
            Name = "Sabretooth Tiger";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "2/1";
            Type = "Creature - Cat";
            Text = "First strike";
            Flavor = "";
        }
    }
    # endregion

    # region Sacred Boon
    public class SacredBoonIA : MagicCard
    {
        public SacredBoonIA()
        {
            Name = "Sacred Boon";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Prevent the next 3 damage that would be dealt to target creature this turn. At the beginning of the next end step, put a +0/+1 counter on that creature for each 1 damage prevented this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Scaled Wurm
    public class ScaledWurmIA : MagicCard
    {
        public ScaledWurmIA()
        {
            Name = "Scaled Wurm";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "7G";
            PT = "7/6";
            Type = "Creature - Wurm";
            Text = "";
            Flavor = "�Flourishing during the Ice Age, these wurms were the bane of all Kjeldorans. Their great size and ferocity made them the subject of countless nightmares�they embodied the worst of the Ice Age.�;^@�Kjeldor: Ice Civilization@";
        }
    }
    # endregion

    # region Sea Spirit
    public class SeaSpiritIA : MagicCard
    {
        public SeaSpiritIA()
        {
            Name = "Sea Spirit";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "4U";
            PT = "2/3";
            Type = "Creature - Elemental Spirit";
            Text = "%U: Sea Spirit gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Seizures
    public class SeizuresIA : MagicCard
    {
        public SeizuresIA()
        {
            Name = "Seizures";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Whenever enchanted creature becomes tapped, Seizures deals 3 damage to that creature�s controller unless that player pays %3.";
            Flavor = "";
        }
    }
    # endregion

    # region Seraph
    public class SeraphIA : MagicCard
    {
        public SeraphIA()
        {
            Name = "Seraph";
            Edition = "IA";
            Rarity = "R";
            Color = "W";
            Cost = "6W";
            PT = "4/4";
            Type = "Creature - Angel";
            Text = "Flying;^Whenever a creature dealt damage by Seraph this turn dies, put that card onto the battlefield under your control at the beginning of the next end step. Sacrifice the creature when you lose control of Seraph.";
            Flavor = "";
        }
    }
    # endregion

    # region Shambling Strider
    public class ShamblingStriderIA : MagicCard
    {
        public ShamblingStriderIA()
        {
            Name = "Shambling Strider";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "4GG";
            PT = "5/5";
            Type = "Creature - Yeti";
            Text = "%R%G: Shambling Strider gets +1/-1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Shatter
    public class ShatterIA : MagicCard
    {
        public ShatterIA()
        {
            Name = "Shatter";
            Edition = "IA";
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

    # region Shield Bearer
    public class ShieldBearerIA : MagicCard
    {
        public ShieldBearerIA()
        {
            Name = "Shield Bearer";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "0/3";
            Type = "Creature - Human Soldier";
            Text = "Banding @(Any creatures with banding, and up to one without, can attack in a band. Bands are blocked as a group. If any creatures with banding you control are blocking or being blocked by a creature, you divide that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by or is blocking.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Shield of the Ages
    public class ShieldoftheAgesIA : MagicCard
    {
        public ShieldoftheAgesIA()
        {
            Name = "Shield of the Ages";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%2: Prevent the next 1 damage that would be dealt to you this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Shyft
    public class ShyftIA : MagicCard
    {
        public ShyftIA()
        {
            Name = "Shyft";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "4U";
            PT = "4/2";
            Type = "Creature - Shapeshifter";
            Text = "At the beginning of your upkeep, you may have Shyft become the color or colors of your choice. @(This effect lasts indefinitely.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Sibilant Spirit
    public class SibilantSpiritIA : MagicCard
    {
        public SibilantSpiritIA()
        {
            Name = "Sibilant Spirit";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "5U";
            PT = "5/6";
            Type = "Creature - Spirit";
            Text = "Flying;^Whenever Sibilant Spirit attacks, defending player may draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Silver Erne
    public class SilverErneIA : MagicCard
    {
        public SilverErneIA()
        {
            Name = "Silver Erne";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "2/2";
            Type = "Creature - Bird";
            Text = "Flying, trample";
            Flavor = "";
        }
    }
    # endregion

    # region Skeleton Ship
    public class SkeletonShipIA : MagicCard
    {
        public SkeletonShipIA()
        {
            Name = "Skeleton Ship";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "3UB";
            PT = "0/3";
            Type = "Legendary Creature - Skeleton";
            Text = "When you control no islands, sacrifice Skeleton Ship.;^%T: Put a -1/-1 counter on target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Skull Catapult
    public class SkullCatapultIA : MagicCard
    {
        public SkullCatapultIA()
        {
            Name = "Skull Catapult";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%1, %T, Sacrifice a creature: Skull Catapult deals 2 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Sleight of Mind
    public class SleightofMindIA : MagicCard
    {
        public SleightofMindIA()
        {
            Name = "Sleight of Mind";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Change the text of target spell or permanent by replacing all instances of one color word with another. @(For example, you may change �target black spell� to �target blue spell.� This effect lasts indefinitely.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Snow Devil
    public class SnowDevilIA : MagicCard
    {
        public SnowDevilIA()
        {
            Name = "Snow Devil";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature has flying.;^Enchanted creature has first strike as long as it�s blocking and you control a snow land.";
            Flavor = "";
        }
    }
    # endregion

    # region Snow Fortress
    public class SnowFortressIA : MagicCard
    {
        public SnowFortressIA()
        {
            Name = "Snow Fortress";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "0/4";
            Type = "Artifact Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@;^%1: Snow Fortress gets +1/+0 until end of turn.;^%1: Snow Fortress gets +0/+1 until end of turn.;^%3: Snow Fortress deals 1 damage to target creature without flying that�s attacking you.";
            Flavor = "";
        }
    }
    # endregion

    # region Snow Hound
    public class SnowHoundIA : MagicCard
    {
        public SnowHoundIA()
        {
            Name = "Snow Hound";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "2W";
            PT = "1/1";
            Type = "Creature - Hound";
            Text = "%1, %T: Return Snow Hound and target green or blue creature you control to their owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Snowblind
    public class SnowblindIA : MagicCard
    {
        public SnowblindIA()
        {
            Name = "Snowblind";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets -X/-Y. If that creature is attacking, X is the number of snow lands defending player controls. Otherwise, X is the number of snow lands its controller controls. Y is equal to X or to enchanted creature�s toughness minus 1, whichever is smaller.";
            Flavor = "";
        }
    }
    # endregion

    # region Snow-Covered Forest
    public class SnowCoveredForestIA : MagicCard
    {
        public SnowCoveredForestIA()
        {
            Name = "Snow-Covered Forest";
            Edition = "IA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Snow Land - Forest";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Snow-Covered Island
    public class SnowCoveredIslandIA : MagicCard
    {
        public SnowCoveredIslandIA()
        {
            Name = "Snow-Covered Island";
            Edition = "IA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Snow Land - Island";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Snow-Covered Mountain
    public class SnowCoveredMountainIA : MagicCard
    {
        public SnowCoveredMountainIA()
        {
            Name = "Snow-Covered Mountain";
            Edition = "IA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Snow Land - Mountain";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Snow-Covered Plains
    public class SnowCoveredPlainsIA : MagicCard
    {
        public SnowCoveredPlainsIA()
        {
            Name = "Snow-Covered Plains";
            Edition = "IA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Snow Land - Plains";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Snow-Covered Swamp
    public class SnowCoveredSwampIA : MagicCard
    {
        public SnowCoveredSwampIA()
        {
            Name = "Snow-Covered Swamp";
            Edition = "IA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Snow Land - Swamp";
            Text = "";
            Flavor = "";
        }
    }
    # endregion

    # region Snowfall
    public class SnowfallIA : MagicCard
    {
        public SnowfallIA()
        {
            Name = "Snowfall";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Enchantment";
            Text = "Cumulative upkeep %U @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^Whenever an Island is tapped for mana, its controller may add %U to his or her mana pool @(in addition to the mana the land produces)@. If that Island is snow, its controller may add %U%U to his or her mana pool instead. Spend this mana only to pay cumulative upkeep costs.";
            Flavor = "";
        }
    }
    # endregion

    # region Soldevi Golem
    public class SoldeviGolemIA : MagicCard
    {
        public SoldeviGolemIA()
        {
            Name = "Soldevi Golem";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "5/3";
            Type = "Artifact Creature - Golem";
            Text = "Soldevi Golem doesn�t untap during your untap step.;^At the beginning of your upkeep, you may untap target tapped creature an opponent controls. If you do, untap Soldevi Golem.";
            Flavor = "";
        }
    }
    # endregion

    # region Soldevi Machinist
    public class SoldeviMachinistIA : MagicCard
    {
        public SoldeviMachinistIA()
        {
            Name = "Soldevi Machinist";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Human Wizard Artificer";
            Text = "%T: Add %2 to your mana pool. Spend this mana only to activate abilities of artifacts.";
            Flavor = "";
        }
    }
    # endregion

    # region Soldevi Simulacrum
    public class SoldeviSimulacrumIA : MagicCard
    {
        public SoldeviSimulacrumIA()
        {
            Name = "Soldevi Simulacrum";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "2/4";
            Type = "Artifact Creature - Soldier";
            Text = "Cumulative upkeep %1 @(At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)@;^%1: Soldevi Simulacrum gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Songs of the Damned
    public class SongsoftheDamnedIA : MagicCard
    {
        public SongsoftheDamnedIA()
        {
            Name = "Songs of the Damned";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "Add %B to your mana pool for each creature card in your graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul Barrier
    public class SoulBarrierIA : MagicCard
    {
        public SoulBarrierIA()
        {
            Name = "Soul Barrier";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever an opponent casts a creature spell, Soul Barrier deals 2 damage to that player unless he or she pays %2.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul Burn
    public class SoulBurnIA : MagicCard
    {
        public SoulBurnIA()
        {
            Name = "Soul Burn";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "X2B";
            PT = "";
            Type = "Sorcery";
            Text = "Spend only black and/or red mana on X.;^Soul Burn deals X damage to target creature or player. You gain life equal to the damage dealt, but not more than the amount of %B spent on X, the player�s life total before Soul Burn dealt damage, or the creature�s toughness.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul Kiss
    public class SoulKissIA : MagicCard
    {
        public SoulKissIA()
        {
            Name = "Soul Kiss";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^%B, Pay 1 life: Enchanted creature gets +2/+2 until end of turn. Activate this ability no more than three times each turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Spectral Shield
    public class SpectralShieldIA : MagicCard
    {
        public SpectralShieldIA()
        {
            Name = "Spectral Shield";
            Edition = "IA";
            Rarity = "U";
            Color = "Gld";
            Cost = "1WU";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +0/+2 and can�t be the target of spells.";
            Flavor = "";
        }
    }
    # endregion

    # region Spoils of Evil
    public class SpoilsofEvilIA : MagicCard
    {
        public SpoilsofEvilIA()
        {
            Name = "Spoils of Evil";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Instant";
            Text = "For each artifact or creature card in target opponent�s graveyard, add %1 to your mana pool and you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Spoils of War
    public class SpoilsofWarIA : MagicCard
    {
        public SpoilsofWarIA()
        {
            Name = "Spoils of War";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "XB";
            PT = "";
            Type = "Sorcery";
            Text = "X is the number of artifact and/or creature cards in an opponent�s graveyard as you cast Spoils of War.;^Distribute X +1/+1 counters among any number of target creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Staff of the Ages
    public class StaffoftheAgesIA : MagicCard
    {
        public StaffoftheAgesIA()
        {
            Name = "Staff of the Ages";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Creatures with landwalk abilities can be blocked as though they didn�t have those abilities.";
            Flavor = "";
        }
    }
    # endregion

    # region Stampede
    public class StampedeIA : MagicCard
    {
        public StampedeIA()
        {
            Name = "Stampede";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "1GG";
            PT = "";
            Type = "Instant";
            Text = "Attacking creatures get +1/+0 and gain trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Stench of Evil
    public class StenchofEvilIA : MagicCard
    {
        public StenchofEvilIA()
        {
            Name = "Stench of Evil";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "2BB";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy all Plains. For each land destroyed this way, Stench of Evil deals 1 damage to that land�s controller unless he or she pays %2.";
            Flavor = "";
        }
    }
    # endregion

    # region Stone Rain
    public class StoneRainIA : MagicCard
    {
        public StoneRainIA()
        {
            Name = "Stone Rain";
            Edition = "IA";
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

    # region Stone Spirit
    public class StoneSpiritIA : MagicCard
    {
        public StoneSpiritIA()
        {
            Name = "Stone Spirit";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "4R";
            PT = "4/3";
            Type = "Creature - Elemental Spirit";
            Text = "Stone Spirit can�t be blocked by creatures with flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Stonehands
    public class StonehandsIA : MagicCard
    {
        public StonehandsIA()
        {
            Name = "Stonehands";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +0/+2.;^%R: Enchanted creature gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Storm Spirit
    public class StormSpiritIA : MagicCard
    {
        public StormSpiritIA()
        {
            Name = "Storm Spirit";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "3GWU";
            PT = "3/3";
            Type = "Creature - Elemental Spirit";
            Text = "Flying;^%T: Storm Spirit deals 2 damage to target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Stormbind
    public class StormbindIA : MagicCard
    {
        public StormbindIA()
        {
            Name = "Stormbind";
            Edition = "IA";
            Rarity = "R";
            Color = "Gld";
            Cost = "1RG";
            PT = "";
            Type = "Enchantment";
            Text = "%2, Discard a card at random: Stormbind deals 2 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Stromgald Cabal
    public class StromgaldCabalIA : MagicCard
    {
        public StromgaldCabalIA()
        {
            Name = "Stromgald Cabal";
            Edition = "IA";
            Rarity = "R";
            Color = "B";
            Cost = "1BB";
            PT = "2/2";
            Type = "Creature - Human Knight";
            Text = "%T, Pay 1 life: Counter target white spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Stunted Growth
    public class StuntedGrowthIA : MagicCard
    {
        public StuntedGrowthIA()
        {
            Name = "Stunted Growth";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "3GG";
            PT = "";
            Type = "Sorcery";
            Text = "Target player chooses three cards from his or her hand and puts them on top of his or her library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Sulfurous Springs
    public class SulfurousSpringsIA : MagicCard
    {
        public SulfurousSpringsIA()
        {
            Name = "Sulfurous Springs";
            Edition = "IA";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%T: Add %B or %R to your mana pool. Sulfurous Springs deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Sunstone
    public class SunstoneIA : MagicCard
    {
        public SunstoneIA()
        {
            Name = "Sunstone";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%2, Sacrifice a snow land: Prevent all combat damage that would be dealt this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Swamp
    public class SwampIA : MagicCard
    {
        public SwampIA()
        {
            Name = "Swamp ";
            Edition = "IA";
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
    public class SwordstoPlowsharesIA : MagicCard
    {
        public SwordstoPlowsharesIA()
        {
            Name = "Swords to Plowshares";
            Edition = "IA";
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

    # region Tarpan
    public class TarpanIA : MagicCard
    {
        public TarpanIA()
        {
            Name = "Tarpan";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Horse";
            Text = "When Tarpan dies, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Thermokarst
    public class ThermokarstIA : MagicCard
    {
        public ThermokarstIA()
        {
            Name = "Thermokarst";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "1GG";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target land. If that land was a snow land, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Thoughtleech
    public class ThoughtleechIA : MagicCard
    {
        public ThoughtleechIA()
        {
            Name = "Thoughtleech";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "GG";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever an Island an opponent controls becomes tapped, you may gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Thunder Wall
    public class ThunderWallIA : MagicCard
    {
        public ThunderWallIA()
        {
            Name = "Thunder Wall";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "1UU";
            PT = "0/2";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@;^Flying;^%U: Thunder Wall gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Timberline Ridge
    public class TimberlineRidgeIA : MagicCard
    {
        public TimberlineRidgeIA()
        {
            Name = "Timberline Ridge";
            Edition = "IA";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Timberline Ridge doesn�t untap during your untap step if it has a depletion counter on it.;^At the beginning of your upkeep, remove a depletion counter from Timberline Ridge.;^%T: Add %R or %G to your mana pool. Put a depletion counter on Timberline Ridge.";
            Flavor = "";
        }
    }
    # endregion

    # region Time Bomb
    public class TimeBombIA : MagicCard
    {
        public TimeBombIA()
        {
            Name = "Time Bomb";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of your upkeep, put a time counter on Time Bomb.;^%1, %T, Sacrifice Time Bomb: Time Bomb deals damage equal to the number of time counters on it to each creature and each player.";
            Flavor = "";
        }
    }
    # endregion

    # region Tinder Wall
    public class TinderWallIA : MagicCard
    {
        public TinderWallIA()
        {
            Name = "Tinder Wall";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "0/3";
            Type = "Creature - Plant Wall";
            Text = "Defender @(This creature can�t attack.)@;^Sacrifice Tinder Wall: Add %R%R to your mana pool.;^%R, Sacrifice Tinder Wall: Tinder Wall deals 2 damage to target creature it�s blocking.";
            Flavor = "";
        }

        public override bool TryActivate(int i)
        {
            if (PArea != null)
            {
                if (i == 0)
                {
                    DoActivate(i);
                }
                else
                {
                    return base.TryActivate(i);
                }
            }
            return false;
        }

        public override void DoActivate(int i)
        {
            # region ability switch
            switch (i)
            {
                case 0:
                    PArea.mana.red += 2;
                    callSacrifice();
                    break;

                case 1:
                    callSacrifice();
                    //Do 2 damage to blocked creature;
                    break;

                default:
                    System.Diagnostics.Debug.WriteLine("index of selected ability was", i);
                    break;
            }
            # endregion
        }
    }
    # endregion

    # region Tor Giant
    public class TorGiantIA : MagicCard
    {
        public TorGiantIA()
        {
            Name = "Tor Giant";
            Edition = "IA";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "3/3";
            Type = "Creature - Giant";
            Text = "";
            Flavor = "�What do you do then? Run. Run very fast. Don�t stop until you see the camp�or a bigger Giant.�;^�Toothlicker Harj, Orcish Captain";
        }
    }
    # endregion

    # region Total War
    public class TotalWarIA : MagicCard
    {
        public TotalWarIA()
        {
            Name = "Total War";
            Edition = "IA";
            Rarity = "R";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a player attacks with one or more creatures, destroy all untapped non-Wall creatures that player controls that didn�t attack, except for creatures the player hasn�t controlled continuously since the beginning of the turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Touch of Death
    public class TouchofDeathIA : MagicCard
    {
        public TouchofDeathIA()
        {
            Name = "Touch of Death";
            Edition = "IA";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Sorcery";
            Text = "Touch of Death deals 1 damage to target player. You gain 1 life.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Touch of Vitae
    public class TouchofVitaeIA : MagicCard
    {
        public TouchofVitaeIA()
        {
            Name = "Touch of Vitae";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Instant";
            Text = "Until end of turn, target creature gains haste and �%0: Untap this creature. Activate this ability only once.�;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Trailblazer
    public class TrailblazerIA : MagicCard
    {
        public TrailblazerIA()
        {
            Name = "Trailblazer";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "2GG";
            PT = "";
            Type = "Instant";
            Text = "Target creature can�t be blocked this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Underground River
    public class UndergroundRiverIA : MagicCard
    {
        public UndergroundRiverIA()
        {
            Name = "Underground River";
            Edition = "IA";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%T: Add %U or %B to your mana pool. Underground River deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Updraft
    public class UpdraftIA : MagicCard
    {
        public UpdraftIA()
        {
            Name = "Updraft";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Target creature gains flying until end of turn.;^Draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Urza's Bauble
    public class UrzasBaubleIA : MagicCard
    {
        public UrzasBaubleIA()
        {
            Name = "Urza's Bauble";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "0";
            PT = "";
            Type = "Artifact";
            Text = "%T, Sacrifice Urza�s Bauble: Look at a card at random in target player�s hand. You draw a card at the beginning of the next turn�s upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Veldt
    public class VeldtIA : MagicCard
    {
        public VeldtIA()
        {
            Name = "Veldt";
            Edition = "IA";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Veldt doesn�t untap during your untap step if it has a depletion counter on it.;^At the beginning of your upkeep, remove a depletion counter from Veldt.;^%T: Add %G or %W to your mana pool. Put a depletion counter on Veldt.";
            Flavor = "";
        }
    }
    # endregion

    # region Venomous Breath
    public class VenomousBreathIA : MagicCard
    {
        public VenomousBreathIA()
        {
            Name = "Venomous Breath";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Instant";
            Text = "Choose target creature. At this turn�s next end of combat, destroy all creatures that blocked or were blocked by it this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Vertigo
    public class VertigoIA : MagicCard
    {
        public VertigoIA()
        {
            Name = "Vertigo";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Vertigo deals 2 damage to target creature with flying. That creature loses flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Vexing Arcanix
    public class VexingArcanixIA : MagicCard
    {
        public VexingArcanixIA()
        {
            Name = "Vexing Arcanix";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T: Target player names a card, then reveals the top card of his or her library. If it�s the named card, the player puts it into his or her hand. Otherwise, the player puts it into his or her graveyard and Vexing Arcanix deals 2 damage to him or her.";
            Flavor = "";
        }
    }
    # endregion

    # region Vibrating Sphere
    public class VibratingSphereIA : MagicCard
    {
        public VibratingSphereIA()
        {
            Name = "Vibrating Sphere";
            Edition = "IA";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "As long as it�s your turn, creatures you control get +2/+0.;^As long as it�s not your turn, creatures you control get -0/-2.";
            Flavor = "";
        }
    }
    # endregion

    # region Walking Wall
    public class WalkingWallIA : MagicCard
    {
        public WalkingWallIA()
        {
            Name = "Walking Wall";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "0/6";
            Type = "Artifact Creature - Wall";
            Text = "Defender;^%3: Walking Wall gets +3/-1 until end of turn and can attack this turn as though it didn�t have defender. Activate this ability only once each turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Lava
    public class WallofLavaIA : MagicCard
    {
        public WallofLavaIA()
        {
            Name = "Wall of Lava";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "1RR";
            PT = "1/3";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@;^%R: Wall of Lava gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Pine Needles
    public class WallofPineNeedlesIA : MagicCard
    {
        public WallofPineNeedlesIA()
        {
            Name = "Wall of Pine Needles";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "3/3";
            Type = "Creature - Plant Wall";
            Text = "Defender @(This creature can�t attack.)@;^%G: Regenerate Wall of Pine Needles.";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Shields
    public class WallofShieldsIA : MagicCard
    {
        public WallofShieldsIA()
        {
            Name = "Wall of Shields";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "0/4";
            Type = "Artifact Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@;^Banding @(If any creatures with banding you control are blocking a creature, you divide that creature�s combat damage, not its controller, among any of the creatures it�s being blocked by.)@";
            Flavor = "";
        }
    }
    # endregion

    # region War Chariot
    public class WarChariotIA : MagicCard
    {
        public WarChariotIA()
        {
            Name = "War Chariot";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T: Target creature gains trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Warning
    public class WarningIA : MagicCard
    {
        public WarningIA()
        {
            Name = "Warning";
            Edition = "IA";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Prevent all combat damage that would be dealt by target attacking creature this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Whalebone Glider
    public class WhaleboneGliderIA : MagicCard
    {
        public WhaleboneGliderIA()
        {
            Name = "Whalebone Glider";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T: Target creature with power 3 or less gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region White Scarab
    public class WhiteScarabIA : MagicCard
    {
        public WhiteScarabIA()
        {
            Name = "White Scarab";
            Edition = "IA";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature can�t be blocked by white creatures.;^Enchanted creature gets +2/+2 as long as an opponent controls a white permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Whiteout
    public class WhiteoutIA : MagicCard
    {
        public WhiteoutIA()
        {
            Name = "Whiteout";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "All creatures lose flying until end of turn.;^Sacrifice a snow land: Return Whiteout from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Wiitigo
    public class WiitigoIA : MagicCard
    {
        public WiitigoIA()
        {
            Name = "Wiitigo";
            Edition = "IA";
            Rarity = "R";
            Color = "G";
            Cost = "3GGG";
            PT = "0/0";
            Type = "Creature - Yeti";
            Text = "Wiitigo enters the battlefield with six +1/+1 counters on it.;^At the beginning of your upkeep, put a +1/+1 counter on Wiitigo if it has blocked or been blocked since your last upkeep. Otherwise, remove a +1/+1 counter from it.";
            Flavor = "";
        }
    }
    # endregion

    # region Wild Growth
    public class WildGrowthIA : MagicCard
    {
        public WildGrowthIA()
        {
            Name = "Wild Growth";
            Edition = "IA";
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

    # region Wind Spirit
    public class WindSpiritIA : MagicCard
    {
        public WindSpiritIA()
        {
            Name = "Wind Spirit";
            Edition = "IA";
            Rarity = "U";
            Color = "U";
            Cost = "4U";
            PT = "3/2";
            Type = "Creature - Elemental Spirit";
            Text = "Flying;^Wind Spirit can�t be blocked except by two or more creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Wings of Aesthir
    public class WingsofAesthirIA : MagicCard
    {
        public WingsofAesthirIA()
        {
            Name = "Wings of Aesthir";
            Edition = "IA";
            Rarity = "U";
            Color = "Gld";
            Cost = "WU";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +1/+0 and has flying and first strike.";
            Flavor = "";
        }
    }
    # endregion

    # region Winter's Chill
    public class WintersChillIA : MagicCard
    {
        public WintersChillIA()
        {
            Name = "Winter's Chill";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "XU";
            PT = "";
            Type = "Instant";
            Text = "Cast Winter�s Chill only during combat before blockers are declared.;^X can�t be greater than the number of snow lands you control.;^Choose X target attacking creatures. For each of those creatures, its controller may pay %1 or %2. If that player doesn�t, destroy that creature at end of combat. If that player pays only %1, prevent all combat damage that would be dealt to and dealt by that creature this combat.";
            Flavor = "";
        }
    }
    # endregion

    # region Withering Wisps
    public class WitheringWispsIA : MagicCard
    {
        public WitheringWispsIA()
        {
            Name = "Withering Wisps";
            Edition = "IA";
            Rarity = "U";
            Color = "B";
            Cost = "1BB";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of the end step, if no creatures are on the battlefield, sacrifice Withering Wisps.;^%B: Withering Wisps deals 1 damage to each creature and each player. Activate this ability no more times each turn than the number of snow Swamps you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Woolly Mammoths
    public class WoollyMammothsIA : MagicCard
    {
        public WoollyMammothsIA()
        {
            Name = "Woolly Mammoths";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "1GG";
            PT = "3/2";
            Type = "Creature - Elephant";
            Text = "Woolly Mammoths has trample as long as you control a snow land.";
            Flavor = "";
        }
    }
    # endregion

    # region Woolly Spider
    public class WoollySpiderIA : MagicCard
    {
        public WoollySpiderIA()
        {
            Name = "Woolly Spider";
            Edition = "IA";
            Rarity = "C";
            Color = "G";
            Cost = "1GG";
            PT = "2/3";
            Type = "Creature - Spider";
            Text = "Reach @(This creature can block creatures with flying.)@;^Whenever Woolly Spider blocks a creature with flying, Woolly Spider gets +0/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Word of Blasting
    public class WordofBlastingIA : MagicCard
    {
        public WordofBlastingIA()
        {
            Name = "Word of Blasting";
            Edition = "IA";
            Rarity = "U";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "Destroy target Wall. It can�t be regenerated. Word of Blasting deals damage equal to that Wall�s converted mana cost to the Wall�s controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Word of Undoing
    public class WordofUndoingIA : MagicCard
    {
        public WordofUndoingIA()
        {
            Name = "Word of Undoing";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Return target creature and all white Auras you own attached to it to their owners� hands.";
            Flavor = "";
        }
    }
    # endregion

    # region Wrath of Marit Lage
    public class WrathofMaritLageIA : MagicCard
    {
        public WrathofMaritLageIA()
        {
            Name = "Wrath of Marit Lage";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "3UU";
            PT = "";
            Type = "Enchantment";
            Text = "When Wrath of Marit Lage enters the battlefield, tap all red creatures.;^Red creatures don�t untap during their controllers� untap steps.";
            Flavor = "";
        }
    }
    # endregion

    # region Yavimaya Gnats
    public class YavimayaGnatsIA : MagicCard
    {
        public YavimayaGnatsIA()
        {
            Name = "Yavimaya Gnats";
            Edition = "IA";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "0/1";
            Type = "Creature - Insect";
            Text = "Flying;^%G: Regenerate Yavimaya Gnats.";
            Flavor = "";
        }
    }
    # endregion

    # region Zuran Enchanter
    public class ZuranEnchanterIA : MagicCard
    {
        public ZuranEnchanterIA()
        {
            Name = "Zuran Enchanter";
            Edition = "IA";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Human Wizard";
            Text = "%2%B, %T: Target player discards a card. Activate this ability only during your turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Zuran Orb
    public class ZuranOrbIA : MagicCard
    {
        public ZuranOrbIA()
        {
            Name = "Zuran Orb";
            Edition = "IA";
            Rarity = "U";
            Color = "Art";
            Cost = "0";
            PT = "";
            Type = "Artifact";
            Text = "Sacrifice a land: You gain 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Zur's Weirding
    public class ZursWeirdingIA : MagicCard
    {
        public ZursWeirdingIA()
        {
            Name = "Zur's Weirding";
            Edition = "IA";
            Rarity = "R";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Enchantment";
            Text = "Players play with their hands revealed.;^If a player would draw a card, he or she reveals it instead. Then any other player may pay 2 life. If a player does, put that card into its owner�s graveyard. Otherwise, that player draws a card.";
            Flavor = "";
        }
    }
    # endregion


    # endregion
}
