using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
    # region Shards of Alara
    # region Ad Nauseam
    public class AdNauseamALA : MagicCard
    {
        public AdNauseamALA()
        {
            Name = "Ad Nauseam";
            Edition = "ALA";
            Rarity = "R";
            Color = "B";
            Cost = "3BB";
            PT = "";
            Type = "Instant";
            Text = "Reveal the top card of your library and put that card into your hand. You lose life equal to its converted mana cost. You may repeat this process any number of times.";
            Flavor = "";
        }
    }
    # endregion

    # region Agony Warp
    public class AgonyWarpALA : MagicCard
    {
        public AgonyWarpALA()
        {
            Name = "Agony Warp";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "UB";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets -3/-0 until end of turn.;^Target creature gets -0/-3 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Ajani Vengeant
    public class AjaniVengeantALA : MagicCard
    {
        public AjaniVengeantALA()
        {
            Name = "Ajani Vengeant";
            Edition = "ALA";
            Rarity = "M";
            Color = "Gld";
            Cost = "2RW";
            PT = "%3/";
            Type = "Planeswalker - Ajani";
            Text = "+1: Target permanent doesn�t untap during its controller�s next untap step.;^-2: Ajani Vengeant deals 3 damage to target creature or player and you gain 3 life.;^-7: Destroy all lands target player controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Akrasan Squire
    public class AkrasanSquireALA : MagicCard
    {
        public AkrasanSquireALA()
        {
            Name = "Akrasan Squire";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Human Soldier";
            Text = "Exalted @(Whenever a creature you control attacks alone, that creature gets +1/+1 until end of turn.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Algae Gharial
    public class AlgaeGharialALA : MagicCard
    {
        public AlgaeGharialALA()
        {
            Name = "Algae Gharial";
            Edition = "ALA";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "1/1";
            Type = "Creature - Crocodile";
            Text = "Shroud;^Whenever another creature dies, you may put a +1/+1 counter on Algae Gharial.";
            Flavor = "";
        }
    }
    # endregion

    # region Angelic Benediction
    public class AngelicBenedictionALA : MagicCard
    {
        public AngelicBenedictionALA()
        {
            Name = "Angelic Benediction";
            Edition = "ALA";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Enchantment";
            Text = "Exalted @(Whenever a creature you control attacks alone, that creature gets +1/+1 until end of turn.)@;^Whenever a creature you control attacks alone, you may tap target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Angel's Herald
    public class AngelsHeraldALA : MagicCard
    {
        public AngelsHeraldALA()
        {
            Name = "Angel's Herald";
            Edition = "ALA";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Human Cleric";
            Text = "%2%W, %T, Sacrifice a green creature, a white creature, and a blue creature: Search your library for a card named Empyrial Archangel and put it onto the battlefield. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Angelsong
    public class AngelsongALA : MagicCard
    {
        public AngelsongALA()
        {
            Name = "Angelsong";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Prevent all combat damage that would be dealt this turn.;^Cycling %2 @(%2, Discard this card: Draw a card.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Arcane Sanctum
    public class ArcaneSanctumALA : MagicCard
    {
        public ArcaneSanctumALA()
        {
            Name = "Arcane Sanctum";
            Edition = "ALA";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Arcane Sanctum enters the battlefield tapped.;^%T: Add %W, %U, or %B to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Archdemon of Unx
    public class ArchdemonofUnxALA : MagicCard
    {
        public ArchdemonofUnxALA()
        {
            Name = "Archdemon of Unx";
            Edition = "ALA";
            Rarity = "R";
            Color = "B";
            Cost = "5BB";
            PT = "6/6";
            Type = "Creature - Demon";
            Text = "Flying, trample;^At the beginning of your upkeep, sacrifice a non-Zombie creature, then put a 2/2 black Zombie creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Banewasp Affliction
    public class BanewaspAfflictionALA : MagicCard
    {
        public BanewaspAfflictionALA()
        {
            Name = "Banewasp Affliction";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^When enchanted creature dies, that creature�s controller loses life equal to its toughness.";
            Flavor = "";
        }
    }
    # endregion

    # region Bant Battlemage
    public class BantBattlemageALA : MagicCard
    {
        public BantBattlemageALA()
        {
            Name = "Bant Battlemage";
            Edition = "ALA";
            Rarity = "U";
            Color = "W";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Human Wizard";
            Text = "%G, %T: Target creature gains trample until end of turn.;^%U, %T: Target creature gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Bant Charm
    public class BantCharmALA : MagicCard
    {
        public BantCharmALA()
        {
            Name = "Bant Charm";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "GWU";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Destroy target artifact; or put target creature on the bottom of its owner�s library; or counter target instant spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Bant Panorama
    public class BantPanoramaALA : MagicCard
    {
        public BantPanoramaALA()
        {
            Name = "Bant Panorama";
            Edition = "ALA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%1, %T, Sacrifice Bant Panorama: Search your library for a basic Forest, Plains, or Island card and put it onto the battlefield tapped. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Battlegrace Angel
    public class BattlegraceAngelALA : MagicCard
    {
        public BattlegraceAngelALA()
        {
            Name = "Battlegrace Angel";
            Edition = "ALA";
            Rarity = "R";
            Color = "W";
            Cost = "3WW";
            PT = "4/4";
            Type = "Creature - Angel";
            Text = "Flying;^Exalted @(Whenever a creature you control attacks alone, that creature gets +1/+1 until end of turn.)@;^Whenever a creature you control attacks alone, it gains lifelink until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Behemoth's Herald
    public class BehemothsHeraldALA : MagicCard
    {
        public BehemothsHeraldALA()
        {
            Name = "Behemoth's Herald";
            Edition = "ALA";
            Rarity = "U";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Elf Shaman";
            Text = "%2%G, %T, Sacrifice a red creature, a green creature, and a white creature: Search your library for a card named Godsire and put it onto the battlefield. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Blightning
    public class BlightningALA : MagicCard
    {
        public BlightningALA()
        {
            Name = "Blightning";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "1BR";
            PT = "";
            Type = "Sorcery";
            Text = "Blightning deals 3 damage to target player. That player discards two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Blister Beetle
    public class BlisterBeetleALA : MagicCard
    {
        public BlisterBeetleALA()
        {
            Name = "Blister Beetle";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "1/1";
            Type = "Creature - Insect";
            Text = "When Blister Beetle enters the battlefield, target creature gets -1/-1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Blood Cultist
    public class BloodCultistALA : MagicCard
    {
        public BloodCultistALA()
        {
            Name = "Blood Cultist";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "1BR";
            PT = "1/1";
            Type = "Creature - Human Wizard";
            Text = "%T: Blood Cultist deals 1 damage to target creature.;^Whenever a creature dealt damage by Blood Cultist this turn dies, put a +1/+1 counter on Blood Cultist.";
            Flavor = "";
        }
    }
    # endregion

    # region Bloodpyre Elemental
    public class BloodpyreElementalALA : MagicCard
    {
        public BloodpyreElementalALA()
        {
            Name = "Bloodpyre Elemental";
            Edition = "ALA";
            Rarity = "C";
            Color = "R";
            Cost = "4R";
            PT = "4/1";
            Type = "Creature - Elemental";
            Text = "Sacrifice Bloodpyre Elemental: Bloodpyre Elemental deals 4 damage to target creature. Activate this ability only any time you could cast a sorcery.";
            Flavor = "";
        }
    }
    # endregion

    # region Bloodthorn Taunter
    public class BloodthornTaunterALA : MagicCard
    {
        public BloodthornTaunterALA()
        {
            Name = "Bloodthorn Taunter";
            Edition = "ALA";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "1/1";
            Type = "Creature - Human Scout";
            Text = "Haste;^%T: Target creature with power 5 or greater gains haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Bone Splinters
    public class BoneSplintersALA : MagicCard
    {
        public BoneSplintersALA()
        {
            Name = "Bone Splinters";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Sorcery";
            Text = "As an additional cost to cast Bone Splinters, sacrifice a creature.;^Destroy target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Branching Bolt
    public class BranchingBoltALA : MagicCard
    {
        public BranchingBoltALA()
        {
            Name = "Branching Bolt";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "1RG";
            PT = "";
            Type = "Instant";
            Text = "Choose one or both � Branching Bolt deals 3 damage to target creature with flying; and/or Branching Bolt deals 3 damage to target creature without flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Brilliant Ultimatum
    public class BrilliantUltimatumALA : MagicCard
    {
        public BrilliantUltimatumALA()
        {
            Name = "Brilliant Ultimatum";
            Edition = "ALA";
            Rarity = "R";
            Color = "Gld";
            Cost = "WWUUUBB";
            PT = "";
            Type = "Sorcery";
            Text = "Exile the top five cards of your library. An opponent separates those cards into two piles. You may play any number of cards from one of those piles without paying their mana costs.";
            Flavor = "";
        }
    }
    # endregion

    # region Broodmate Dragon
    public class BroodmateDragonALA : MagicCard
    {
        public BroodmateDragonALA()
        {
            Name = "Broodmate Dragon";
            Edition = "ALA";
            Rarity = "R";
            Color = "Gld";
            Cost = "3BRG";
            PT = "4/4";
            Type = "Creature - Dragon";
            Text = "Flying;^When Broodmate Dragon enters the battlefield, put a 4/4 red Dragon creature token with flying onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Bull Cerodon
    public class BullCerodonALA : MagicCard
    {
        public BullCerodonALA()
        {
            Name = "Bull Cerodon";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "4RW";
            PT = "5/5";
            Type = "Creature - Beast";
            Text = "Vigilance, haste";
            Flavor = "";
        }
    }
    # endregion

    # region Caldera Hellion
    public class CalderaHellionALA : MagicCard
    {
        public CalderaHellionALA()
        {
            Name = "Caldera Hellion";
            Edition = "ALA";
            Rarity = "R";
            Color = "R";
            Cost = "3RR";
            PT = "3/3";
            Type = "Creature - Hellion";
            Text = "Devour 1 @(As this enters the battlefield, you may sacrifice any number of creatures. This creature enters the battlefield with that many +1/+1 counters on it.)@;^When Caldera Hellion enters the battlefield, it deals 3 damage to each creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Call to Heel
    public class CalltoHeelALA : MagicCard
    {
        public CalltoHeelALA()
        {
            Name = "Call to Heel";
            Edition = "ALA";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Return target creature to its owner�s hand. Its controller draws a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Cancel
    public class CancelALA : MagicCard
    {
        public CancelALA()
        {
            Name = "Cancel";
            Edition = "ALA";
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

    # region Carrion Thrash
    public class CarrionThrashALA : MagicCard
    {
        public CarrionThrashALA()
        {
            Name = "Carrion Thrash";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "2BRG";
            PT = "4/4";
            Type = "Creature - Viashino Warrior";
            Text = "When Carrion Thrash dies, you may pay %2. If you do, return another target creature card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Cathartic Adept
    public class CatharticAdeptALA : MagicCard
    {
        public CatharticAdeptALA()
        {
            Name = "Cathartic Adept";
            Edition = "ALA";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "1/1";
            Type = "Creature - Human Wizard";
            Text = "%T: Target player puts the top card of his or her library into his or her graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Cavern Thoctar
    public class CavernThoctarALA : MagicCard
    {
        public CavernThoctarALA()
        {
            Name = "Cavern Thoctar";
            Edition = "ALA";
            Rarity = "C";
            Color = "G";
            Cost = "5G";
            PT = "5/5";
            Type = "Creature - Beast";
            Text = "%1%R: Cavern Thoctar gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Clarion Ultimatum
    public class ClarionUltimatumALA : MagicCard
    {
        public ClarionUltimatumALA()
        {
            Name = "Clarion Ultimatum";
            Edition = "ALA";
            Rarity = "R";
            Color = "Gld";
            Cost = "GGWWWUU";
            PT = "";
            Type = "Sorcery";
            Text = "Choose five permanents you control. For each of those permanents, you may search your library for a card with the same name as that permanent. Put those cards onto the battlefield tapped, then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Cloudheath Drake
    public class CloudheathDrakeALA : MagicCard
    {
        public CloudheathDrakeALA()
        {
            Name = "Cloudheath Drake";
            Edition = "ALA";
            Rarity = "C";
            Color = "U";
            Cost = "4U";
            PT = "3/3";
            Type = "Artifact Creature - Drake";
            Text = "Flying;^%1%W: Cloudheath Drake gains vigilance until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Coma Veil
    public class ComaVeilALA : MagicCard
    {
        public ComaVeilALA()
        {
            Name = "Coma Veil";
            Edition = "ALA";
            Rarity = "C";
            Color = "U";
            Cost = "4U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant artifact or creature;^Enchanted permanent doesn�t untap during its controller�s untap step.";
            Flavor = "";
        }
    }
    # endregion

    # region Corpse Connoisseur
    public class CorpseConnoisseurALA : MagicCard
    {
        public CorpseConnoisseurALA()
        {
            Name = "Corpse Connoisseur";
            Edition = "ALA";
            Rarity = "U";
            Color = "B";
            Cost = "4B";
            PT = "3/3";
            Type = "Creature - Zombie Wizard";
            Text = "When Corpse Connoisseur enters the battlefield, you may search your library for a creature card and put that card into your graveyard. If you do, shuffle your library.;^Unearth %3%B @(%3%B: Return this card from your graveyard to the battlefield. It gains haste. Exile it at the beginning of the next end step or if it would leave the battlefield. Unearth only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Courier's Capsule
    public class CouriersCapsuleALA : MagicCard
    {
        public CouriersCapsuleALA()
        {
            Name = "Courier's Capsule";
            Edition = "ALA";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Artifact";
            Text = "%1%U, %T, Sacrifice Courier�s Capsule: Draw two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Court Archers
    public class CourtArchersALA : MagicCard
    {
        public CourtArchersALA()
        {
            Name = "Court Archers";
            Edition = "ALA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "1/3";
            Type = "Creature - Human Archer";
            Text = "Reach @(This can block creatures with flying.)@;^Exalted @(Whenever a creature you control attacks alone, that creature gets +1/+1 until end of turn.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Covenant of Minds
    public class CovenantofMindsALA : MagicCard
    {
        public CovenantofMindsALA()
        {
            Name = "Covenant of Minds";
            Edition = "ALA";
            Rarity = "R";
            Color = "U";
            Cost = "4U";
            PT = "";
            Type = "Sorcery";
            Text = "Reveal the top three cards of your library. Target opponent may choose to put those cards into your hand. If he or she doesn�t, put those cards into your graveyard and draw five cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Cradle of Vitality
    public class CradleofVitalityALA : MagicCard
    {
        public CradleofVitalityALA()
        {
            Name = "Cradle of Vitality";
            Edition = "ALA";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever you gain life, you may pay %1%W. If you do, put a +1/+1 counter on target creature for each 1 life you gained.";
            Flavor = "";
        }
    }
    # endregion

    # region Crucible of Fire
    public class CrucibleofFireALA : MagicCard
    {
        public CrucibleofFireALA()
        {
            Name = "Crucible of Fire";
            Edition = "ALA";
            Rarity = "R";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Enchantment";
            Text = "Dragon creatures you control get +3/+3.";
            Flavor = "";
        }
    }
    # endregion

    # region Cruel Ultimatum
    public class CruelUltimatumALA : MagicCard
    {
        public CruelUltimatumALA()
        {
            Name = "Cruel Ultimatum";
            Edition = "ALA";
            Rarity = "R";
            Color = "Gld";
            Cost = "UUBBBRR";
            PT = "";
            Type = "Sorcery";
            Text = "Target opponent sacrifices a creature, discards three cards, then loses 5 life. You return a creature card from your graveyard to your hand, draw three cards, then gain 5 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Crumbling Necropolis
    public class CrumblingNecropolisALA : MagicCard
    {
        public CrumblingNecropolisALA()
        {
            Name = "Crumbling Necropolis";
            Edition = "ALA";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Crumbling Necropolis enters the battlefield tapped.;^%T: Add %U, %B, or %R to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Cunning Lethemancer
    public class CunningLethemancerALA : MagicCard
    {
        public CunningLethemancerALA()
        {
            Name = "Cunning Lethemancer";
            Edition = "ALA";
            Rarity = "R";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Human Wizard";
            Text = "At the beginning of your upkeep, each player discards a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Cylian Elf
    public class CylianElfALA : MagicCard
    {
        public CylianElfALA()
        {
            Name = "Cylian Elf";
            Edition = "ALA";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "2/2";
            Type = "Creature - Elf Scout";
            Text = "";
            Flavor = "From her sunsail tent high above the forest floor, an elf harkener can hear the footfalls of a single creature through the cacophony of Naya�s jungle sounds.";
        }
    }
    # endregion

    # region Dawnray Archer
    public class DawnrayArcherALA : MagicCard
    {
        public DawnrayArcherALA()
        {
            Name = "Dawnray Archer";
            Edition = "ALA";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "1/1";
            Type = "Creature - Human Archer";
            Text = "Exalted @(Whenever a creature you control attacks alone, that creature gets +1/+1 until end of turn.)@;^%W, %T: Dawnray Archer deals 1 damage to target attacking or blocking creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Death Baron
    public class DeathBaronALA : MagicCard
    {
        public DeathBaronALA()
        {
            Name = "Death Baron";
            Edition = "ALA";
            Rarity = "R";
            Color = "B";
            Cost = "1BB";
            PT = "2/2";
            Type = "Creature - Zombie Wizard";
            Text = "Skeleton creatures you control and other Zombie creatures you control get +1/+1 and have deathtouch.";
            Flavor = "";
        }
    }
    # endregion

    # region Deathgreeter
    public class DeathgreeterALA : MagicCard
    {
        public DeathgreeterALA()
        {
            Name = "Deathgreeter";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Human Shaman";
            Text = "Whenever another creature dies, you may gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Deft Duelist
    public class DeftDuelistALA : MagicCard
    {
        public DeftDuelistALA()
        {
            Name = "Deft Duelist";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "WU";
            PT = "2/1";
            Type = "Creature - Human Rogue";
            Text = "First strike;^Shroud @(This creature can�t be the target of spells or abilities.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Demon's Herald
    public class DemonsHeraldALA : MagicCard
    {
        public DemonsHeraldALA()
        {
            Name = "Demon's Herald";
            Edition = "ALA";
            Rarity = "U";
            Color = "B";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Human Wizard";
            Text = "%2%B, %T, Sacrifice a blue creature, a black creature, and a red creature: Search your library for a card named Prince of Thralls and put it onto the battlefield. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Dispeller's Capsule
    public class DispellersCapsuleALA : MagicCard
    {
        public DispellersCapsuleALA()
        {
            Name = "Dispeller's Capsule";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Artifact";
            Text = "%2%W, %T, Sacrifice Dispeller�s Capsule: Destroy target artifact or enchantment.";
            Flavor = "";
        }
    }
    # endregion

    # region Dragon Fodder
    public class DragonFodderALA : MagicCard
    {
        public DragonFodderALA()
        {
            Name = "Dragon Fodder";
            Edition = "ALA";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Sorcery";
            Text = "Put two 1/1 red Goblin creature tokens onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Dragon's Herald
    public class DragonsHeraldALA : MagicCard
    {
        public DragonsHeraldALA()
        {
            Name = "Dragon's Herald";
            Edition = "ALA";
            Rarity = "U";
            Color = "R";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Goblin Shaman";
            Text = "%2%R, %T, Sacrifice a black creature, a red creature, and a green creature: Search your library for a card named Hellkite Overlord and put it onto the battlefield. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Dreg Reaver
    public class DregReaverALA : MagicCard
    {
        public DregReaverALA()
        {
            Name = "Dreg Reaver";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "4B";
            PT = "4/3";
            Type = "Creature - Zombie Beast";
            Text = "";
            Flavor = "�On our thirty-fourth day of digging, we unearthed a chamber that contained the intact remains of several species long extinct from Grixis. One in particular should make a fine siege engine . . . .�;^�Last notes of Shungus Nod, fleshcrafter";
        }
    }
    # endregion

    # region Dregscape Zombie
    public class DregscapeZombieALA : MagicCard
    {
        public DregscapeZombieALA()
        {
            Name = "Dregscape Zombie";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "2/1";
            Type = "Creature - Zombie";
            Text = "Unearth %B @(%B: Return this card from your graveyard to the battlefield. It gains haste. Exile it at the beginning of the next end step or if it would leave the battlefield. Unearth only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Druid of the Anima
    public class DruidoftheAnimaALA : MagicCard
    {
        public DruidoftheAnimaALA()
        {
            Name = "Druid of the Anima";
            Edition = "ALA";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "1/1";
            Type = "Creature - Elf Druid";
            Text = "%T: Add %R, %G, or %W to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Drumhunter
    public class DrumhunterALA : MagicCard
    {
        public DrumhunterALA()
        {
            Name = "Drumhunter";
            Edition = "ALA";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "2/2";
            Type = "Creature - Human Druid Warrior";
            Text = "At the beginning of your end step, if you control a creature with power 5 or greater, you may draw a card.;^%T: Add %1 to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Elspeth, Knight-Errant
    public class ElspethKnightErrantALA : MagicCard
    {
        public ElspethKnightErrantALA()
        {
            Name = "Elspeth, Knight-Errant";
            Edition = "ALA";
            Rarity = "M";
            Color = "W";
            Cost = "2WW";
            PT = "%4/";
            Type = "Planeswalker - Elspeth";
            Text = "+1: Put a 1/1 white Soldier creature token onto the battlefield.;^+1: Target creature gets +3/+3 and gains flying until end of turn.;^-8: You get an emblem with �Artifacts, creatures, enchantments, and lands you control have indestructible.�";
            Flavor = "";
        }
    }
    # endregion

    # region Elvish Visionary
    public class ElvishVisionaryALA : MagicCard
    {
        public ElvishVisionaryALA()
        {
            Name = "Elvish Visionary";
            Edition = "ALA";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "1/1";
            Type = "Creature - Elf Shaman";
            Text = "When Elvish Visionary enters the battlefield, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Empyrial Archangel
    public class EmpyrialArchangelALA : MagicCard
    {
        public EmpyrialArchangelALA()
        {
            Name = "Empyrial Archangel";
            Edition = "ALA";
            Rarity = "M";
            Color = "Gld";
            Cost = "4GWWU";
            PT = "5/8";
            Type = "Creature - Angel";
            Text = "Flying, shroud;^All damage that would be dealt to you is dealt to Empyrial Archangel instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Esper Battlemage
    public class EsperBattlemageALA : MagicCard
    {
        public EsperBattlemageALA()
        {
            Name = "Esper Battlemage";
            Edition = "ALA";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "2/2";
            Type = "Artifact Creature - Human Wizard";
            Text = "%W, %T: Prevent the next 2 damage that would be dealt to you this turn.;^%B, %T: Target creature gets -1/-1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Esper Charm
    public class EsperCharmALA : MagicCard
    {
        public EsperCharmALA()
        {
            Name = "Esper Charm";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "WUB";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Destroy target enchantment; or draw two cards; or target player discards two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Esper Panorama
    public class EsperPanoramaALA : MagicCard
    {
        public EsperPanoramaALA()
        {
            Name = "Esper Panorama";
            Edition = "ALA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%1, %T, Sacrifice Esper Panorama: Search your library for a basic Plains, Island, or Swamp card and put it onto the battlefield tapped. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Etherium Astrolabe
    public class EtheriumAstrolabeALA : MagicCard
    {
        public EtheriumAstrolabeALA()
        {
            Name = "Etherium Astrolabe";
            Edition = "ALA";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Artifact";
            Text = "Flash;^%B, %T, Sacrifice an artifact: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Etherium Sculptor
    public class EtheriumSculptorALA : MagicCard
    {
        public EtheriumSculptorALA()
        {
            Name = "Etherium Sculptor";
            Edition = "ALA";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "1/2";
            Type = "Artifact Creature - Vedalken Artificer";
            Text = "Artifact spells you cast cost %1 less to cast.";
            Flavor = "";
        }
    }
    # endregion

    # region Ethersworn Canonist
    public class EtherswornCanonistALA : MagicCard
    {
        public EtherswornCanonistALA()
        {
            Name = "Ethersworn Canonist";
            Edition = "ALA";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "2/2";
            Type = "Artifact Creature - Human Cleric";
            Text = "Each player who has cast a nonartifact spell this turn can�t cast additional nonartifact spells.";
            Flavor = "";
        }
    }
    # endregion

    # region Excommunicate
    public class ExcommunicateALA : MagicCard
    {
        public ExcommunicateALA()
        {
            Name = "Excommunicate";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Sorcery";
            Text = "Put target creature on top of its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Executioner's Capsule
    public class ExecutionersCapsuleALA : MagicCard
    {
        public ExecutionersCapsuleALA()
        {
            Name = "Executioner's Capsule";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Artifact";
            Text = "%1%B, %T, Sacrifice Executioner�s Capsule: Destroy target nonblack creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Exuberant Firestoker
    public class ExuberantFirestokerALA : MagicCard
    {
        public ExuberantFirestokerALA()
        {
            Name = "Exuberant Firestoker";
            Edition = "ALA";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "1/1";
            Type = "Creature - Human Druid Shaman";
            Text = "At the beginning of your end step, if you control a creature with power 5 or greater, you may have Exuberant Firestoker deal 2 damage to target player.;^%T: Add %1 to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Fatestitcher
    public class FatestitcherALA : MagicCard
    {
        public FatestitcherALA()
        {
            Name = "Fatestitcher";
            Edition = "ALA";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "1/2";
            Type = "Creature - Zombie Wizard";
            Text = "%T: You may tap or untap another target permanent.;^Unearth %U @(%U: Return this card from your graveyard to the battlefield. It gains haste. Exile it at the beginning of the next end step or if it would leave the battlefield. Unearth only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Feral Hydra
    public class FeralHydraALA : MagicCard
    {
        public FeralHydraALA()
        {
            Name = "Feral Hydra";
            Edition = "ALA";
            Rarity = "R";
            Color = "G";
            Cost = "XG";
            PT = "0/0";
            Type = "Creature - Hydra Beast";
            Text = "Feral Hydra enters the battlefield with X +1/+1 counters on it.;^%3: Put a +1/+1 counter on Feral Hydra. Any player may activate this ability.";
            Flavor = "";
        }
    }
    # endregion

    # region Filigree Sages
    public class FiligreeSagesALA : MagicCard
    {
        public FiligreeSagesALA()
        {
            Name = "Filigree Sages";
            Edition = "ALA";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "2/3";
            Type = "Artifact Creature - Vedalken Wizard";
            Text = "%2%U: Untap target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Fire-Field Ogre
    public class FireFieldOgreALA : MagicCard
    {
        public FireFieldOgreALA()
        {
            Name = "Fire-Field Ogre";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "1UBR";
            PT = "4/2";
            Type = "Creature - Ogre Mutant";
            Text = "First strike;^Unearth %U%B%R @(%U%B%R: Return this card from your graveyard to the battlefield. It gains haste. Exile it at the beginning of the next end step or if it would leave the battlefield. Unearth only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Flameblast Dragon
    public class FlameblastDragonALA : MagicCard
    {
        public FlameblastDragonALA()
        {
            Name = "Flameblast Dragon";
            Edition = "ALA";
            Rarity = "R";
            Color = "R";
            Cost = "4RR";
            PT = "5/5";
            Type = "Creature - Dragon";
            Text = "Flying;^Whenever Flameblast Dragon attacks, you may pay %X%R. If you do, Flameblast Dragon deals X damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Fleshbag Marauder
    public class FleshbagMarauderALA : MagicCard
    {
        public FleshbagMarauderALA()
        {
            Name = "Fleshbag Marauder";
            Edition = "ALA";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "3/1";
            Type = "Creature - Zombie Warrior";
            Text = "When Fleshbag Marauder enters the battlefield, each player sacrifices a creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Forest
    public class ForestALA : MagicCard
    {
        public ForestALA()
        {
            Name = "Forest ";
            Edition = "ALA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Forest";
            Text = "";
            Flavor = "�";
        }
    }
    # endregion

    # region Gather Specimens
    public class GatherSpecimensALA : MagicCard
    {
        public GatherSpecimensALA()
        {
            Name = "Gather Specimens";
            Edition = "ALA";
            Rarity = "R";
            Color = "U";
            Cost = "3UUU";
            PT = "";
            Type = "Instant";
            Text = "If a creature would enter the battlefield under an opponent�s control this turn, it enters the battlefield under your control instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Gift of the Gargantuan
    public class GiftoftheGargantuanALA : MagicCard
    {
        public GiftoftheGargantuanALA()
        {
            Name = "Gift of the Gargantuan";
            Edition = "ALA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Sorcery";
            Text = "Look at the top four cards of your library. You may reveal a creature card and/or a land card from among them and put the revealed cards into your hand. Put the rest on the bottom of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Glaze Fiend
    public class GlazeFiendALA : MagicCard
    {
        public GlazeFiendALA()
        {
            Name = "Glaze Fiend";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "0/1";
            Type = "Artifact Creature - Illusion";
            Text = "Flying;^Whenever another artifact enters the battlefield under your control, Glaze Fiend gets +2/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Assault
    public class GoblinAssaultALA : MagicCard
    {
        public GoblinAssaultALA()
        {
            Name = "Goblin Assault";
            Edition = "ALA";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of your upkeep, put a 1/1 red Goblin creature token with haste onto the battlefield.;^Goblin creatures attack each turn if able.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Deathraiders
    public class GoblinDeathraidersALA : MagicCard
    {
        public GoblinDeathraidersALA()
        {
            Name = "Goblin Deathraiders";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "BR";
            PT = "3/1";
            Type = "Creature - Goblin Warrior";
            Text = "Trample";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Mountaineer
    public class GoblinMountaineerALA : MagicCard
    {
        public GoblinMountaineerALA()
        {
            Name = "Goblin Mountaineer";
            Edition = "ALA";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Goblin Scout";
            Text = "Mountainwalk";
            Flavor = "";
        }
    }
    # endregion

    # region Godsire
    public class GodsireALA : MagicCard
    {
        public GodsireALA()
        {
            Name = "Godsire";
            Edition = "ALA";
            Rarity = "M";
            Color = "Gld";
            Cost = "4RGGW";
            PT = "8/8";
            Type = "Creature - Beast";
            Text = "Vigilance;^%T: Put an 8/8 Beast creature token that�s red, green, and white onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Godtoucher
    public class GodtoucherALA : MagicCard
    {
        public GodtoucherALA()
        {
            Name = "Godtoucher";
            Edition = "ALA";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "2/2";
            Type = "Creature - Elf Cleric";
            Text = "%1%W, %T: Prevent all damage that would be dealt to target creature with power 5 or greater this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Grixis Battlemage
    public class GrixisBattlemageALA : MagicCard
    {
        public GrixisBattlemageALA()
        {
            Name = "Grixis Battlemage";
            Edition = "ALA";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Human Wizard";
            Text = "%U, %T: Draw a card, then discard a card.;^%R, %T: Target creature can�t block this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Grixis Charm
    public class GrixisCharmALA : MagicCard
    {
        public GrixisCharmALA()
        {
            Name = "Grixis Charm";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "UBR";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Return target permanent to its owner�s hand; or target creature gets -4/-4 until end of turn; or creatures you control get +2/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Grixis Panorama
    public class GrixisPanoramaALA : MagicCard
    {
        public GrixisPanoramaALA()
        {
            Name = "Grixis Panorama";
            Edition = "ALA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%1, %T, Sacrifice Grixis Panorama: Search your library for a basic Island, Swamp, or Mountain card and put it onto the battlefield tapped. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Guardians of Akrasa
    public class GuardiansofAkrasaALA : MagicCard
    {
        public GuardiansofAkrasaALA()
        {
            Name = "Guardians of Akrasa";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "0/4";
            Type = "Creature - Human Soldier";
            Text = "Defender @(This creature can�t attack.)@;^Exalted @(Whenever a creature you control attacks alone, that creature gets +1/+1 until end of turn.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Gustrider Exuberant
    public class GustriderExuberantALA : MagicCard
    {
        public GustriderExuberantALA()
        {
            Name = "Gustrider Exuberant";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "1/2";
            Type = "Creature - Human Wizard";
            Text = "Flying;^Sacrifice Gustrider Exuberant: Creatures you control with power 5 or greater gain flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Hellkite Overlord
    public class HellkiteOverlordALA : MagicCard
    {
        public HellkiteOverlordALA()
        {
            Name = "Hellkite Overlord";
            Edition = "ALA";
            Rarity = "M";
            Color = "Gld";
            Cost = "4BRRG";
            PT = "8/8";
            Type = "Creature - Dragon";
            Text = "Flying, trample, haste;^%R: Hellkite Overlord gets +1/+0 until end of turn.;^%B%G: Regenerate Hellkite Overlord.";
            Flavor = "";
        }
    }
    # endregion

    # region Hell's Thunder
    public class HellsThunderALA : MagicCard
    {
        public HellsThunderALA()
        {
            Name = "Hell's Thunder";
            Edition = "ALA";
            Rarity = "R";
            Color = "R";
            Cost = "1RR";
            PT = "4/4";
            Type = "Creature - Elemental";
            Text = "Flying, haste;^At the beginning of the end step, sacrifice Hell�s Thunder.;^Unearth %4%R @(%4%R: Return this card from your graveyard to the battlefield. It gains haste. Exile it at the beginning of the next end step or if it would leave the battlefield. Unearth only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Hindering Light
    public class HinderingLightALA : MagicCard
    {
        public HinderingLightALA()
        {
            Name = "Hindering Light";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "WU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell that targets you or a permanent you control.;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Hissing Iguanar
    public class HissingIguanarALA : MagicCard
    {
        public HissingIguanarALA()
        {
            Name = "Hissing Iguanar";
            Edition = "ALA";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "3/1";
            Type = "Creature - Lizard";
            Text = "Whenever another creature dies, you may have Hissing Iguanar deal 1 damage to target player.";
            Flavor = "";
        }
    }
    # endregion

    # region Immortal Coil
    public class ImmortalCoilALA : MagicCard
    {
        public ImmortalCoilALA()
        {
            Name = "Immortal Coil";
            Edition = "ALA";
            Rarity = "R";
            Color = "B";
            Cost = "2BB";
            PT = "";
            Type = "Artifact";
            Text = "%T, Exile two cards from your graveyard: Draw a card.;^If damage would be dealt to you, prevent that damage. Exile a card from your graveyard for each 1 damage prevented this way.;^When there are no cards in your graveyard, you lose the game.";
            Flavor = "";
        }
    }
    # endregion

    # region Incurable Ogre
    public class IncurableOgreALA : MagicCard
    {
        public IncurableOgreALA()
        {
            Name = "Incurable Ogre";
            Edition = "ALA";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "5/1";
            Type = "Creature - Ogre Mutant";
            Text = "";
            Flavor = "Each mutation causes the incurables to look vastly different from one another. They are left with only one thing in common: their insatiable lust for the slaughter.";
        }
    }
    # endregion

    # region Infest
    public class InfestALA : MagicCard
    {
        public InfestALA()
        {
            Name = "Infest";
            Edition = "ALA";
            Rarity = "U";
            Color = "B";
            Cost = "1BB";
            PT = "";
            Type = "Sorcery";
            Text = "All creatures get -2/-2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Invincible Hymn
    public class InvincibleHymnALA : MagicCard
    {
        public InvincibleHymnALA()
        {
            Name = "Invincible Hymn";
            Edition = "ALA";
            Rarity = "R";
            Color = "W";
            Cost = "6WW";
            PT = "";
            Type = "Sorcery";
            Text = "Count the number of cards in your library. Your life total becomes that number.";
            Flavor = "";
        }
    }
    # endregion

    # region Island
    public class IslandALA : MagicCard
    {
        public IslandALA()
        {
            Name = "Island ";
            Edition = "ALA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Island";
            Text = "";
            Flavor = "�";
        }
    }
    # endregion

    # region Jhessian Infiltrator
    public class JhessianInfiltratorALA : MagicCard
    {
        public JhessianInfiltratorALA()
        {
            Name = "Jhessian Infiltrator";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "GU";
            PT = "2/2";
            Type = "Creature - Human Rogue";
            Text = "Jhessian Infiltrator can�t be blocked.";
            Flavor = "";
        }
    }
    # endregion

    # region Jhessian Lookout
    public class JhessianLookoutALA : MagicCard
    {
        public JhessianLookoutALA()
        {
            Name = "Jhessian Lookout";
            Edition = "ALA";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "2/1";
            Type = "Creature - Human Scout";
            Text = "";
            Flavor = "She stands ready, always watchful, knowing that weeks of peace and serenity can be overturned by a single distant sail.";
        }
    }
    # endregion

    # region Jund Battlemage
    public class JundBattlemageALA : MagicCard
    {
        public JundBattlemageALA()
        {
            Name = "Jund Battlemage";
            Edition = "ALA";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Human Shaman";
            Text = "%B, %T: Target player loses 1 life.;^%G, %T: Put a 1/1 green Saproling creature token onto the battlefield.";
            Flavor = "";
        }

        public override bool TryActivate(int i)
        {
            bool result = base.TryActivate(i);

            if (result)
            {
                DoActivate(i);
                Tap(true, false);
            }

            return result;
        }

        public override void DoActivate(int i)
        {
            if (i == 0)
            {
                OppArea.HP--;
            }
            if (i == 1)
            {
                MagicCard mc = new Saproling();
                mc.PArea = PArea;
                mc.OppArea = OppArea;
                PArea.PlayToken(mc);
            }
        }
    }
    # endregion

    # region Jund Charm
    public class JundCharmALA : MagicCard
    {
        public JundCharmALA()
        {
            Name = "Jund Charm";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "BRG";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Exile all cards from target player�s graveyard; or Jund Charm deals 2 damage to each creature; or put two +1/+1 counters on target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Jund Panorama
    public class JundPanoramaALA : MagicCard
    {
        public JundPanoramaALA()
        {
            Name = "Jund Panorama";
            Edition = "ALA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%1, %T, Sacrifice Jund Panorama: Search your library for a basic Swamp, Mountain, or Forest card and put it onto the battlefield tapped. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Jungle Shrine
    public class JungleShrineALA : MagicCard
    {
        public JungleShrineALA()
        {
            Name = "Jungle Shrine";
            Edition = "ALA";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Jungle Shrine enters the battlefield tapped.;^%T: Add %R, %G, or %W to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Jungle Weaver
    public class JungleWeaverALA : MagicCard
    {
        public JungleWeaverALA()
        {
            Name = "Jungle Weaver";
            Edition = "ALA";
            Rarity = "C";
            Color = "G";
            Cost = "5GG";
            PT = "5/6";
            Type = "Creature - Spider";
            Text = "Reach @(This can block creatures with flying.)@;^Cycling %2 @(%2, Discard this card: Draw a card.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Kathari Screecher
    public class KathariScreecherALA : MagicCard
    {
        public KathariScreecherALA()
        {
            Name = "Kathari Screecher";
            Edition = "ALA";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "2/2";
            Type = "Creature - Bird Soldier";
            Text = "Flying;^Unearth %2%U @(%2%U: Return this card from your graveyard to the battlefield. It gains haste. Exile it at the beginning of the next end step or if it would leave the battlefield. Unearth only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Kederekt Creeper
    public class KederektCreeperALA : MagicCard
    {
        public KederektCreeperALA()
        {
            Name = "Kederekt Creeper";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "UBR";
            PT = "2/3";
            Type = "Creature - Horror";
            Text = "Deathtouch @(Any amount of damage this deals to a creature is enough to destroy it.)@;^Kederekt Creeper can�t be blocked except by two or more creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Kederekt Leviathan
    public class KederektLeviathanALA : MagicCard
    {
        public KederektLeviathanALA()
        {
            Name = "Kederekt Leviathan";
            Edition = "ALA";
            Rarity = "R";
            Color = "U";
            Cost = "6UU";
            PT = "5/5";
            Type = "Creature - Leviathan";
            Text = "When Kederekt Leviathan enters the battlefield, return all other nonland permanents to their owners� hands.;^Unearth %6%U @(%6%U: Return this card from your graveyard to the battlefield. It gains haste. Exile it at the beginning of the next end step or if it would leave the battlefield. Unearth only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Keeper of Progenitus
    public class KeeperofProgenitusALA : MagicCard
    {
        public KeeperofProgenitusALA()
        {
            Name = "Keeper of Progenitus";
            Edition = "ALA";
            Rarity = "R";
            Color = "G";
            Cost = "3G";
            PT = "1/3";
            Type = "Creature - Elf Druid";
            Text = "Whenever a player taps a Mountain, Forest, or Plains for mana, that player adds one mana to his or her mana pool of any type that land produced.";
            Flavor = "";
        }
    }
    # endregion

    # region Kiss of the Amesha
    public class KissoftheAmeshaALA : MagicCard
    {
        public KissoftheAmeshaALA()
        {
            Name = "Kiss of the Amesha";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "4WU";
            PT = "";
            Type = "Sorcery";
            Text = "Target player gains 7 life and draws two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Knight of the Skyward Eye
    public class KnightoftheSkywardEyeALA : MagicCard
    {
        public KnightoftheSkywardEyeALA()
        {
            Name = "Knight of the Skyward Eye";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "2/2";
            Type = "Creature - Human Knight";
            Text = "%3%G: Knight of the Skyward Eye gets +3/+3 until end of turn. Activate this ability only once each turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Knight of the White Orchid
    public class KnightoftheWhiteOrchidALA : MagicCard
    {
        public KnightoftheWhiteOrchidALA()
        {
            Name = "Knight of the White Orchid";
            Edition = "ALA";
            Rarity = "R";
            Color = "W";
            Cost = "WW";
            PT = "2/2";
            Type = "Creature - Human Knight";
            Text = "First strike;^When Knight of the White Orchid enters the battlefield, if an opponent controls more lands than you, you may search your library for a Plains card, put it onto the battlefield, then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Knight-Captain of Eos
    public class KnightCaptainofEosALA : MagicCard
    {
        public KnightCaptainofEosALA()
        {
            Name = "Knight-Captain of Eos";
            Edition = "ALA";
            Rarity = "R";
            Color = "W";
            Cost = "4W";
            PT = "2/2";
            Type = "Creature - Human Knight";
            Text = "When Knight-Captain of Eos enters the battlefield, put two 1/1 white Soldier creature tokens onto the battlefield.;^%W, Sacrifice a Soldier: Prevent all combat damage that would be dealt this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Kresh the Bloodbraided
    public class KreshtheBloodbraidedALA : MagicCard
    {
        public KreshtheBloodbraidedALA()
        {
            Name = "Kresh the Bloodbraided";
            Edition = "ALA";
            Rarity = "M";
            Color = "Gld";
            Cost = "2BRG";
            PT = "3/3";
            Type = "Legendary Creature - Human Warrior";
            Text = "Whenever another creature dies, you may put X +1/+1 counters on Kresh the Bloodbraided, where X is that creature�s power.";
            Flavor = "";
        }
    }
    # endregion

    # region Lich's Mirror
    public class LichsMirrorALA : MagicCard
    {
        public LichsMirrorALA()
        {
            Name = "Lich's Mirror";
            Edition = "ALA";
            Rarity = "M";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "If you would lose the game, instead shuffle your hand, your graveyard, and all permanents you own into your library, then draw seven cards and your life total becomes 20.";
            Flavor = "";
        }
    }
    # endregion

    # region Lightning Talons
    public class LightningTalonsALA : MagicCard
    {
        public LightningTalonsALA()
        {
            Name = "Lightning Talons";
            Edition = "ALA";
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

    # region Lush Growth
    public class LushGrowthALA : MagicCard
    {
        public LushGrowthALA()
        {
            Name = "Lush Growth";
            Edition = "ALA";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land;^Enchanted land is a Mountain, Forest, and Plains.";
            Flavor = "";
        }
    }
    # endregion

    # region Magma Spray
    public class MagmaSprayALA : MagicCard
    {
        public MagmaSprayALA()
        {
            Name = "Magma Spray";
            Edition = "ALA";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Magma Spray deals 2 damage to target creature. If that creature would die this turn, exile it instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Manaplasm
    public class ManaplasmALA : MagicCard
    {
        public ManaplasmALA()
        {
            Name = "Manaplasm";
            Edition = "ALA";
            Rarity = "R";
            Color = "G";
            Cost = "2G";
            PT = "1/1";
            Type = "Creature - Ooze";
            Text = "Whenever you cast a spell, Manaplasm gets +X/+X until end of turn, where X is that spell�s converted mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Marble Chalice
    public class MarbleChaliceALA : MagicCard
    {
        public MarbleChaliceALA()
        {
            Name = "Marble Chalice";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Artifact";
            Text = "%T: You gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Master of Etherium
    public class MasterofEtheriumALA : MagicCard
    {
        public MasterofEtheriumALA()
        {
            Name = "Master of Etherium";
            Edition = "ALA";
            Rarity = "R";
            Color = "U";
            Cost = "2U";
            PT = "*/*";
            Type = "Artifact Creature - Vedalken Wizard";
            Text = "Master of Etherium�s power and toughness are each equal to the number of artifacts you control.;^Other artifact creatures you control get +1/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Mayael the Anima
    public class MayaeltheAnimaALA : MagicCard
    {
        public MayaeltheAnimaALA()
        {
            Name = "Mayael the Anima";
            Edition = "ALA";
            Rarity = "M";
            Color = "Gld";
            Cost = "RGW";
            PT = "2/3";
            Type = "Legendary Creature - Elf Shaman";
            Text = "%3%R%G%W, %T: Look at the top five cards of your library. You may put a creature card with power 5 or greater from among them onto the battlefield. Put the rest on the bottom of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Memory Erosion
    public class MemoryErosionALA : MagicCard
    {
        public MemoryErosionALA()
        {
            Name = "Memory Erosion";
            Edition = "ALA";
            Rarity = "R";
            Color = "U";
            Cost = "1UU";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever an opponent casts a spell, that player puts the top two cards of his or her library into his or her graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Metallurgeon
    public class MetallurgeonALA : MagicCard
    {
        public MetallurgeonALA()
        {
            Name = "Metallurgeon";
            Edition = "ALA";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "1/2";
            Type = "Artifact Creature - Human Artificer";
            Text = "%W, %T: Regenerate target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Mighty Emergence
    public class MightyEmergenceALA : MagicCard
    {
        public MightyEmergenceALA()
        {
            Name = "Mighty Emergence";
            Edition = "ALA";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a creature with power 5 or greater enters the battlefield under your control, you may put two +1/+1 counters on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Mindlock Orb
    public class MindlockOrbALA : MagicCard
    {
        public MindlockOrbALA()
        {
            Name = "Mindlock Orb";
            Edition = "ALA";
            Rarity = "R";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Artifact";
            Text = "Players can�t search libraries.";
            Flavor = "";
        }
    }
    # endregion

    # region Minion Reflector
    public class MinionReflectorALA : MagicCard
    {
        public MinionReflectorALA()
        {
            Name = "Minion Reflector";
            Edition = "ALA";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a nontoken creature enters the battlefield under your control, you may pay %2. If you do, put a token that�s a copy of that creature onto the battlefield. That token has haste and �At the beginning of the end step, sacrifice this permanent.�";
            Flavor = "";
        }
    }
    # endregion

    # region Mosstodon
    public class MosstodonALA : MagicCard
    {
        public MosstodonALA()
        {
            Name = "Mosstodon";
            Edition = "ALA";
            Rarity = "C";
            Color = "G";
            Cost = "4G";
            PT = "5/3";
            Type = "Creature - Plant Elephant";
            Text = "%1: Target creature with power 5 or greater gains trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Mountain
    public class MountainALA : MagicCard
    {
        public MountainALA()
        {
            Name = "Mountain ";
            Edition = "ALA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Mountain";
            Text = "";
            Flavor = "�";
        }
    }
    # endregion

    # region Mycoloth
    public class MycolothALA : MagicCard
    {
        public MycolothALA()
        {
            Name = "Mycoloth";
            Edition = "ALA";
            Rarity = "R";
            Color = "G";
            Cost = "3GG";
            PT = "4/4";
            Type = "Creature - Fungus";
            Text = "Devour 2 @(As this enters the battlefield, you may sacrifice any number of creatures. This creature enters the battlefield with twice that many +1/+1 counters on it.)@;^At the beginning of your upkeep, put a 1/1 green Saproling creature token onto the battlefield for each +1/+1 counter on Mycoloth.";
            Flavor = "";
        }
    }
    # endregion

    # region Naturalize
    public class NaturalizeALA : MagicCard
    {
        public NaturalizeALA()
        {
            Name = "Naturalize";
            Edition = "ALA";
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

    # region Naya Battlemage
    public class NayaBattlemageALA : MagicCard
    {
        public NayaBattlemageALA()
        {
            Name = "Naya Battlemage";
            Edition = "ALA";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Human Shaman";
            Text = "%R, %T: Target creature gets +2/+0 until end of turn.;^%W, %T: Tap target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Naya Charm
    public class NayaCharmALA : MagicCard
    {
        public NayaCharmALA()
        {
            Name = "Naya Charm";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "RGW";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Naya Charm deals 3 damage to target creature; or return target card from a graveyard to its owner�s hand; or tap all creatures target player controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Naya Panorama
    public class NayaPanoramaALA : MagicCard
    {
        public NayaPanoramaALA()
        {
            Name = "Naya Panorama";
            Edition = "ALA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%1, %T, Sacrifice Naya Panorama: Search your library for a basic Mountain, Forest, or Plains card and put it onto the battlefield tapped. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Necrogenesis
    public class NecrogenesisALA : MagicCard
    {
        public NecrogenesisALA()
        {
            Name = "Necrogenesis";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "BG";
            PT = "";
            Type = "Enchantment";
            Text = "%2: Exile target creature card from a graveyard. Put a 1/1 green Saproling creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Obelisk of Bant
    public class ObeliskofBantALA : MagicCard
    {
        public ObeliskofBantALA()
        {
            Name = "Obelisk of Bant";
            Edition = "ALA";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %G, %W, or %U to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Obelisk of Esper
    public class ObeliskofEsperALA : MagicCard
    {
        public ObeliskofEsperALA()
        {
            Name = "Obelisk of Esper";
            Edition = "ALA";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %W, %U, or %B to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Obelisk of Grixis
    public class ObeliskofGrixisALA : MagicCard
    {
        public ObeliskofGrixisALA()
        {
            Name = "Obelisk of Grixis";
            Edition = "ALA";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %U, %B, or %R to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Obelisk of Jund
    public class ObeliskofJundALA : MagicCard
    {
        public ObeliskofJundALA()
        {
            Name = "Obelisk of Jund";
            Edition = "ALA";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %B, %R, or %G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Obelisk of Naya
    public class ObeliskofNayaALA : MagicCard
    {
        public ObeliskofNayaALA()
        {
            Name = "Obelisk of Naya";
            Edition = "ALA";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %R, %G, or %W to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Oblivion Ring
    public class OblivionRingALA : MagicCard
    {
        public OblivionRingALA()
        {
            Name = "Oblivion Ring";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Enchantment";
            Text = "When Oblivion Ring enters the battlefield, exile another target nonland permanent.;^When Oblivion Ring leaves the battlefield, return the exiled card to the battlefield under its owner�s control.";
            Flavor = "";
        }
    }
    # endregion

    # region Onyx Goblet
    public class OnyxGobletALA : MagicCard
    {
        public OnyxGobletALA()
        {
            Name = "Onyx Goblet";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Artifact";
            Text = "%T: Target player loses 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Ooze Garden
    public class OozeGardenALA : MagicCard
    {
        public OozeGardenALA()
        {
            Name = "Ooze Garden";
            Edition = "ALA";
            Rarity = "R";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Enchantment";
            Text = "%1%G, Sacrifice a non-Ooze creature: Put an X/X green Ooze creature token onto the battlefield, where X is the sacrificed creature�s power. Activate this ability only any time you could cast a sorcery.";
            Flavor = "";
        }
    }
    # endregion

    # region Outrider of Jhess
    public class OutriderofJhessALA : MagicCard
    {
        public OutriderofJhessALA()
        {
            Name = "Outrider of Jhess";
            Edition = "ALA";
            Rarity = "C";
            Color = "U";
            Cost = "3U";
            PT = "2/2";
            Type = "Creature - Human Knight";
            Text = "Exalted @(Whenever a creature you control attacks alone, that creature gets +1/+1 until end of turn.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Plains
    public class PlainsALA : MagicCard
    {
        public PlainsALA()
        {
            Name = "Plains ";
            Edition = "ALA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Plains";
            Text = "";
            Flavor = "�";
        }
    }
    # endregion

    # region Predator Dragon
    public class PredatorDragonALA : MagicCard
    {
        public PredatorDragonALA()
        {
            Name = "Predator Dragon";
            Edition = "ALA";
            Rarity = "R";
            Color = "R";
            Cost = "3RRR";
            PT = "4/4";
            Type = "Creature - Dragon";
            Text = "Flying, haste;^Devour 2 @(As this enters the battlefield, you may sacrifice any number of creatures. This creature enters the battlefield with twice that many +1/+1 counters on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Prince of Thralls
    public class PrinceofThrallsALA : MagicCard
    {
        public PrinceofThrallsALA()
        {
            Name = "Prince of Thralls";
            Edition = "ALA";
            Rarity = "M";
            Color = "Gld";
            Cost = "4UBBR";
            PT = "7/7";
            Type = "Creature - Demon";
            Text = "Whenever a permanent an opponent controls is put into a graveyard, put that card onto the battlefield under your control unless that opponent pays 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Protomatter Powder
    public class ProtomatterPowderALA : MagicCard
    {
        public ProtomatterPowderALA()
        {
            Name = "Protomatter Powder";
            Edition = "ALA";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Artifact";
            Text = "%4%W, %T, Sacrifice Protomatter Powder: Return target artifact card from your graveyard to the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Punish Ignorance
    public class PunishIgnoranceALA : MagicCard
    {
        public PunishIgnoranceALA()
        {
            Name = "Punish Ignorance";
            Edition = "ALA";
            Rarity = "R";
            Color = "Gld";
            Cost = "WUUB";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell. Its controller loses 3 life and you gain 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Puppet Conjurer
    public class PuppetConjurerALA : MagicCard
    {
        public PuppetConjurerALA()
        {
            Name = "Puppet Conjurer";
            Edition = "ALA";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "1/2";
            Type = "Artifact Creature - Human Wizard";
            Text = "%U, %T: Put a 0/1 blue Homunculus artifact creature token onto the battlefield.;^At the beginning of your upkeep, sacrifice a Homunculus.";
            Flavor = "";
        }
    }
    # endregion

    # region Qasali Ambusher
    public class QasaliAmbusherALA : MagicCard
    {
        public QasaliAmbusherALA()
        {
            Name = "Qasali Ambusher";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "1GW";
            PT = "2/3";
            Type = "Creature - Cat Warrior";
            Text = "Reach;^If a creature is attacking you and you control a Forest and a Plains, you may cast Qasali Ambusher without paying its mana cost and as though it had flash.";
            Flavor = "";
        }
    }
    # endregion

    # region Quietus Spike
    public class QuietusSpikeALA : MagicCard
    {
        public QuietusSpikeALA()
        {
            Name = "Quietus Spike";
            Edition = "ALA";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature has deathtouch.;^Whenever equipped creature deals combat damage to a player, that player loses half his or her life, rounded up.;^Equip %3";
            Flavor = "";
        }
    }
    # endregion

    # region Rafiq of the Many
    public class RafiqoftheManyALA : MagicCard
    {
        public RafiqoftheManyALA()
        {
            Name = "Rafiq of the Many";
            Edition = "ALA";
            Rarity = "M";
            Color = "Gld";
            Cost = "1GWU";
            PT = "3/3";
            Type = "Legendary Creature - Human Knight";
            Text = "Exalted @(Whenever a creature you control attacks alone, that creature gets +1/+1 until end of turn.)@;^Whenever a creature you control attacks alone, it gains double strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Rakeclaw Gargantuan
    public class RakeclawGargantuanALA : MagicCard
    {
        public RakeclawGargantuanALA()
        {
            Name = "Rakeclaw Gargantuan";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "2RGW";
            PT = "5/3";
            Type = "Creature - Beast";
            Text = "%1: Target creature with power 5 or greater gains first strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Ranger of Eos
    public class RangerofEosALA : MagicCard
    {
        public RangerofEosALA()
        {
            Name = "Ranger of Eos";
            Edition = "ALA";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "3/2";
            Type = "Creature - Human Soldier";
            Text = "When Ranger of Eos enters the battlefield, you may search your library for up to two creature cards with converted mana cost 1 or less, reveal them, and put them into your hand. If you do, shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Realm Razer
    public class RealmRazerALA : MagicCard
    {
        public RealmRazerALA()
        {
            Name = "Realm Razer";
            Edition = "ALA";
            Rarity = "R";
            Color = "Gld";
            Cost = "3RGW";
            PT = "4/2";
            Type = "Creature - Beast";
            Text = "When Realm Razer enters the battlefield, exile all lands.;^When Realm Razer leaves the battlefield, return the exiled cards to the battlefield tapped under their owners� control.";
            Flavor = "";
        }
    }
    # endregion

    # region Relic of Progenitus
    public class RelicofProgenitusALA : MagicCard
    {
        public RelicofProgenitusALA()
        {
            Name = "Relic of Progenitus";
            Edition = "ALA";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%T: Target player exiles a card from his or her graveyard.;^%1, Exile Relic of Progenitus: Exile all cards from all graveyards. Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Resounding Roar
    public class ResoundingRoarALA : MagicCard
    {
        public ResoundingRoarALA()
        {
            Name = "Resounding Roar";
            Edition = "ALA";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +3/+3 until end of turn.;^Cycling %5%R%G%W @(%5%R%G%W, Discard this card: Draw a card.)@;^When you cycle Resounding Roar, target creature gets +6/+6 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Resounding Scream
    public class ResoundingScreamALA : MagicCard
    {
        public ResoundingScreamALA()
        {
            Name = "Resounding Scream";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Sorcery";
            Text = "Target player discards a card at random.;^Cycling %5%U%B%R @(%5%U%B%R, Discard this card: Draw a card.)@;^When you cycle Resounding Scream, target player discards two cards at random.";
            Flavor = "";
        }
    }
    # endregion

    # region Resounding Silence
    public class ResoundingSilenceALA : MagicCard
    {
        public ResoundingSilenceALA()
        {
            Name = "Resounding Silence";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Instant";
            Text = "Exile target attacking creature.;^Cycling %5%G%W%U @(%5%G%W%U, Discard this card: Draw a card.)@;^When you cycle Resounding Silence, exile up to two target attacking creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Resounding Thunder
    public class ResoundingThunderALA : MagicCard
    {
        public ResoundingThunderALA()
        {
            Name = "Resounding Thunder";
            Edition = "ALA";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Instant";
            Text = "Resounding Thunder deals 3 damage to target creature or player.;^Cycling %5%B%R%G @(%5%B%R%G, Discard this card: Draw a card.)@;^When you cycle Resounding Thunder, it deals 6 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Resounding Wave
    public class ResoundingWaveALA : MagicCard
    {
        public ResoundingWaveALA()
        {
            Name = "Resounding Wave";
            Edition = "ALA";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Instant";
            Text = "Return target permanent to its owner�s hand.;^Cycling %5%W%U%B @(%5%W%U%B, Discard this card: Draw a card.)@;^When you cycle Resounding Wave, return two target permanents to their owners� hands.";
            Flavor = "";
        }
    }
    # endregion

    # region Rhox Charger
    public class RhoxChargerALA : MagicCard
    {
        public RhoxChargerALA()
        {
            Name = "Rhox Charger";
            Edition = "ALA";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "3/3";
            Type = "Creature - Rhino Soldier";
            Text = "Trample;^Exalted @(Whenever a creature you control attacks alone, that creature gets +1/+1 until end of turn.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Rhox War Monk
    public class RhoxWarMonkALA : MagicCard
    {
        public RhoxWarMonkALA()
        {
            Name = "Rhox War Monk";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "GWU";
            PT = "3/4";
            Type = "Creature - Rhino Monk";
            Text = "Lifelink";
            Flavor = "";
        }
    }
    # endregion

    # region Ridge Rannet
    public class RidgeRannetALA : MagicCard
    {
        public RidgeRannetALA()
        {
            Name = "Ridge Rannet";
            Edition = "ALA";
            Rarity = "C";
            Color = "R";
            Cost = "5RR";
            PT = "6/4";
            Type = "Creature - Beast";
            Text = "Cycling %2 @(%2, Discard this card: Draw a card.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Rip-Clan Crasher
    public class RipClanCrasherALA : MagicCard
    {
        public RipClanCrasherALA()
        {
            Name = "Rip-Clan Crasher";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "RG";
            PT = "2/2";
            Type = "Creature - Human Warrior";
            Text = "Haste";
            Flavor = "";
        }
    }
    # endregion

    # region Rockcaster Platoon
    public class RockcasterPlatoonALA : MagicCard
    {
        public RockcasterPlatoonALA()
        {
            Name = "Rockcaster Platoon";
            Edition = "ALA";
            Rarity = "U";
            Color = "W";
            Cost = "5WW";
            PT = "5/7";
            Type = "Creature - Rhino Soldier";
            Text = "%4%G: Rockcaster Platoon deals 2 damage to each creature with flying and each player.";
            Flavor = "";
        }
    }
    # endregion

    # region Rockslide Elemental
    public class RockslideElementalALA : MagicCard
    {
        public RockslideElementalALA()
        {
            Name = "Rockslide Elemental";
            Edition = "ALA";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "1/1";
            Type = "Creature - Elemental";
            Text = "First strike;^Whenever another creature dies, you may put a +1/+1 counter on Rockslide Elemental.";
            Flavor = "";
        }
    }
    # endregion

    # region Sacellum Godspeaker
    public class SacellumGodspeakerALA : MagicCard
    {
        public SacellumGodspeakerALA()
        {
            Name = "Sacellum Godspeaker";
            Edition = "ALA";
            Rarity = "R";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Elf Druid";
            Text = "%T: Reveal any number of creature cards with power 5 or greater from your hand. Add %G to your mana pool for each card revealed this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Salvage Titan
    public class SalvageTitanALA : MagicCard
    {
        public SalvageTitanALA()
        {
            Name = "Salvage Titan";
            Edition = "ALA";
            Rarity = "R";
            Color = "B";
            Cost = "4BB";
            PT = "6/4";
            Type = "Artifact Creature - Golem";
            Text = "You may sacrifice three artifacts rather than pay Salvage Titan�s mana cost.;^Exile three artifact cards from your graveyard: Return Salvage Titan from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Sanctum Gargoyle
    public class SanctumGargoyleALA : MagicCard
    {
        public SanctumGargoyleALA()
        {
            Name = "Sanctum Gargoyle";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "2/3";
            Type = "Artifact Creature - Gargoyle";
            Text = "Flying;^When Sanctum Gargoyle enters the battlefield, you may return target artifact card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Sangrite Surge
    public class SangriteSurgeALA : MagicCard
    {
        public SangriteSurgeALA()
        {
            Name = "Sangrite Surge";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "4RG";
            PT = "";
            Type = "Sorcery";
            Text = "Target creature gets +3/+3 and gains double strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Sarkhan Vol
    public class SarkhanVolALA : MagicCard
    {
        public SarkhanVolALA()
        {
            Name = "Sarkhan Vol";
            Edition = "ALA";
            Rarity = "M";
            Color = "Gld";
            Cost = "2RG";
            PT = "%4/";
            Type = "Planeswalker - Sarkhan";
            Text = "+1: Creatures you control get +1/+1 and gain haste until end of turn.;^-2: Gain control of target creature until end of turn. Untap that creature. It gains haste until end of turn.;^-6: Put five 4/4 red Dragon creature tokens with flying onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Savage Hunger
    public class SavageHungerALA : MagicCard
    {
        public SavageHungerALA()
        {
            Name = "Savage Hunger";
            Edition = "ALA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +1/+0 and has trample.;^Cycling %2 @(%2, Discard this card: Draw a card.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Savage Lands
    public class SavageLandsALA : MagicCard
    {
        public SavageLandsALA()
        {
            Name = "Savage Lands";
            Edition = "ALA";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Savage Lands enters the battlefield tapped.;^%T: Add %B, %R, or %G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Scavenger Drake
    public class ScavengerDrakeALA : MagicCard
    {
        public ScavengerDrakeALA()
        {
            Name = "Scavenger Drake";
            Edition = "ALA";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "1/1";
            Type = "Creature - Drake";
            Text = "Flying;^Whenever another creature dies, you may put a +1/+1 counter on Scavenger Drake.";
            Flavor = "";
        }
    }
    # endregion

    # region Scourge Devil
    public class ScourgeDevilALA : MagicCard
    {
        public ScourgeDevilALA()
        {
            Name = "Scourge Devil";
            Edition = "ALA";
            Rarity = "U";
            Color = "R";
            Cost = "4R";
            PT = "3/3";
            Type = "Creature - Devil";
            Text = "When Scourge Devil enters the battlefield, creatures you control get +1/+0 until end of turn.;^Unearth %2%R @(%2%R: Return this card from your graveyard to the battlefield. It gains haste. Exile it at the beginning of the next end step or if it would leave the battlefield. Unearth only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Scourglass
    public class ScourglassALA : MagicCard
    {
        public ScourglassALA()
        {
            Name = "Scourglass";
            Edition = "ALA";
            Rarity = "R";
            Color = "W";
            Cost = "3WW";
            PT = "";
            Type = "Artifact";
            Text = "%T, Sacrifice Scourglass: Destroy all permanents except for artifacts and lands. Activate this ability only during your upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Seaside Citadel
    public class SeasideCitadelALA : MagicCard
    {
        public SeasideCitadelALA()
        {
            Name = "Seaside Citadel";
            Edition = "ALA";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Seaside Citadel enters the battlefield tapped.;^%T: Add %G, %W, or %U to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Sedraxis Specter
    public class SedraxisSpecterALA : MagicCard
    {
        public SedraxisSpecterALA()
        {
            Name = "Sedraxis Specter";
            Edition = "ALA";
            Rarity = "R";
            Color = "Gld";
            Cost = "UBR";
            PT = "3/2";
            Type = "Creature - Specter";
            Text = "Flying;^Whenever Sedraxis Specter deals combat damage to a player, that player discards a card.;^Unearth %1%B @(%1%B: Return this card from your graveyard to the battlefield. It gains haste. Exile it at the beginning of the next end step or if it would leave the battlefield. Unearth only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Sedris, the Traitor King
    public class SedristheTraitorKingALA : MagicCard
    {
        public SedristheTraitorKingALA()
        {
            Name = "Sedris, the Traitor King";
            Edition = "ALA";
            Rarity = "M";
            Color = "Gld";
            Cost = "3UBR";
            PT = "5/5";
            Type = "Legendary Creature - Zombie Warrior";
            Text = "Each creature card in your graveyard has unearth %2%B. @(%2%B: Return the card to the battlefield. The creature gains haste. Exile it at the beginning of the next end step or if it would leave the battlefield. Unearth only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Shadowfeed
    public class ShadowfeedALA : MagicCard
    {
        public ShadowfeedALA()
        {
            Name = "Shadowfeed";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "Exile target card from a graveyard. You gain 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Sharding Sphinx
    public class ShardingSphinxALA : MagicCard
    {
        public ShardingSphinxALA()
        {
            Name = "Sharding Sphinx";
            Edition = "ALA";
            Rarity = "R";
            Color = "U";
            Cost = "4UU";
            PT = "4/4";
            Type = "Artifact Creature - Sphinx";
            Text = "Flying;^Whenever an artifact creature you control deals combat damage to a player, you may put a 1/1 blue Thopter artifact creature token with flying onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Sharuum the Hegemon
    public class SharuumtheHegemonALA : MagicCard
    {
        public SharuumtheHegemonALA()
        {
            Name = "Sharuum the Hegemon";
            Edition = "ALA";
            Rarity = "M";
            Color = "Gld";
            Cost = "3WUB";
            PT = "5/5";
            Type = "Legendary Artifact Creature - Sphinx";
            Text = "Flying;^When Sharuum the Hegemon enters the battlefield, you may return target artifact card from your graveyard to the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Shore Snapper
    public class ShoreSnapperALA : MagicCard
    {
        public ShoreSnapperALA()
        {
            Name = "Shore Snapper";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Beast";
            Text = "%U: Shore Snapper gains islandwalk until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Sighted-Caste Sorcerer
    public class SightedCasteSorcererALA : MagicCard
    {
        public SightedCasteSorcererALA()
        {
            Name = "Sighted-Caste Sorcerer";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "1/1";
            Type = "Creature - Human Wizard";
            Text = "Exalted @(Whenever a creature you control attacks alone, that creature gets +1/+1 until end of turn.)@;^%U: Sighted-Caste Sorcerer gains shroud until end of turn. @(It can�t be the target of spells or abilities.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Sigil Blessing
    public class SigilBlessingALA : MagicCard
    {
        public SigilBlessingALA()
        {
            Name = "Sigil Blessing";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "GW";
            PT = "";
            Type = "Instant";
            Text = "Until end of turn, target creature you control gets +3/+3 and other creatures you control get +1/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Sigil of Distinction
    public class SigilofDistinctionALA : MagicCard
    {
        public SigilofDistinctionALA()
        {
            Name = "Sigil of Distinction";
            Edition = "ALA";
            Rarity = "R";
            Color = "Art";
            Cost = "X";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Sigil of Distinction enters the battlefield with X charge counters on it.;^Equipped creature gets +1/+1 for each charge counter on Sigil of Distinction.;^Equip�Remove a charge counter from Sigil of Distinction.";
            Flavor = "";
        }
    }
    # endregion

    # region Sigiled Paladin
    public class SigiledPaladinALA : MagicCard
    {
        public SigiledPaladinALA()
        {
            Name = "Sigiled Paladin";
            Edition = "ALA";
            Rarity = "U";
            Color = "W";
            Cost = "WW";
            PT = "2/2";
            Type = "Creature - Human Knight";
            Text = "First strike;^Exalted @(Whenever a creature you control attacks alone, that creature gets +1/+1 until end of turn.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Skeletal Kathari
    public class SkeletalKathariALA : MagicCard
    {
        public SkeletalKathariALA()
        {
            Name = "Skeletal Kathari";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "4B";
            PT = "3/2";
            Type = "Creature - Bird Skeleton";
            Text = "Flying;^%B, Sacrifice a creature: Regenerate Skeletal Kathari.";
            Flavor = "";
        }
    }
    # endregion

    # region Skeletonize
    public class SkeletonizeALA : MagicCard
    {
        public SkeletonizeALA()
        {
            Name = "Skeletonize";
            Edition = "ALA";
            Rarity = "U";
            Color = "R";
            Cost = "4R";
            PT = "";
            Type = "Instant";
            Text = "Skeletonize deals 3 damage to target creature. When a creature dealt damage this way dies this turn, put a 1/1 black Skeleton creature token onto the battlefield with �%B: Regenerate this creature.�";
            Flavor = "";
        }
    }
    # endregion

    # region Skill Borrower
    public class SkillBorrowerALA : MagicCard
    {
        public SkillBorrowerALA()
        {
            Name = "Skill Borrower";
            Edition = "ALA";
            Rarity = "R";
            Color = "U";
            Cost = "2U";
            PT = "1/3";
            Type = "Artifact Creature - Human Wizard";
            Text = "Play with the top card of your library revealed.;^As long as the top card of your library is an artifact or creature card, Skill Borrower has all activated abilities of that card. @(If any of the abilities use that card�s name, use this creature�s name instead.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Skullmulcher
    public class SkullmulcherALA : MagicCard
    {
        public SkullmulcherALA()
        {
            Name = "Skullmulcher";
            Edition = "ALA";
            Rarity = "R";
            Color = "G";
            Cost = "4G";
            PT = "3/3";
            Type = "Creature - Elemental";
            Text = "Devour 1 @(As this enters the battlefield, you may sacrifice any number of creatures. This creature enters the battlefield with that many +1/+1 counters on it.)@;^When Skullmulcher enters the battlefield, draw a card for each creature it devoured.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul's Fire
    public class SoulsFireALA : MagicCard
    {
        public SoulsFireALA()
        {
            Name = "Soul's Fire";
            Edition = "ALA";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Instant";
            Text = "Target creature you control on the battlefield deals damage equal to its power to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul's Grace
    public class SoulsGraceALA : MagicCard
    {
        public SoulsGraceALA()
        {
            Name = "Soul's Grace";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "You gain life equal to target creature�s power.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul's Might
    public class SoulsMightALA : MagicCard
    {
        public SoulsMightALA()
        {
            Name = "Soul's Might";
            Edition = "ALA";
            Rarity = "C";
            Color = "G";
            Cost = "4G";
            PT = "";
            Type = "Sorcery";
            Text = "Put X +1/+1 counters on target creature, where X is that creature�s power.";
            Flavor = "";
        }
    }
    # endregion

    # region Spearbreaker Behemoth
    public class SpearbreakerBehemothALA : MagicCard
    {
        public SpearbreakerBehemothALA()
        {
            Name = "Spearbreaker Behemoth";
            Edition = "ALA";
            Rarity = "R";
            Color = "G";
            Cost = "5GG";
            PT = "5/5";
            Type = "Creature - Beast";
            Text = "Indestructible;^%1: Target creature with power 5 or greater gains indestructible until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Spell Snip
    public class SpellSnipALA : MagicCard
    {
        public SpellSnipALA()
        {
            Name = "Spell Snip";
            Edition = "ALA";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell unless its controller pays %1.;^Cycling %2 @(%2, Discard this card: Draw a card.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Sphinx Sovereign
    public class SphinxSovereignALA : MagicCard
    {
        public SphinxSovereignALA()
        {
            Name = "Sphinx Sovereign";
            Edition = "ALA";
            Rarity = "M";
            Color = "Gld";
            Cost = "4WUUB";
            PT = "6/6";
            Type = "Artifact Creature - Sphinx";
            Text = "Flying;^At the beginning of your end step, you gain 3 life if Sphinx Sovereign is untapped. Otherwise, each opponent loses 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Sphinx's Herald
    public class SphinxsHeraldALA : MagicCard
    {
        public SphinxsHeraldALA()
        {
            Name = "Sphinx's Herald";
            Edition = "ALA";
            Rarity = "U";
            Color = "U";
            Cost = "U";
            PT = "1/1";
            Type = "Artifact Creature - Vedalken Wizard";
            Text = "%2%U, %T, Sacrifice a white creature, a blue creature, and a black creature: Search your library for a card named Sphinx Sovereign and put it onto the battlefield. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Sprouting Thrinax
    public class SproutingThrinaxALA : MagicCard
    {
        public SproutingThrinaxALA()
        {
            Name = "Sprouting Thrinax";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "BRG";
            PT = "3/3";
            Type = "Creature - Lizard";
            Text = "When Sprouting Thrinax dies, put three 1/1 green Saproling creature tokens onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Steelclad Serpent
    public class SteelcladSerpentALA : MagicCard
    {
        public SteelcladSerpentALA()
        {
            Name = "Steelclad Serpent";
            Edition = "ALA";
            Rarity = "C";
            Color = "U";
            Cost = "5U";
            PT = "4/5";
            Type = "Artifact Creature - Serpent";
            Text = "Steelclad Serpent can�t attack unless you control another artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Steward of Valeron
    public class StewardofValeronALA : MagicCard
    {
        public StewardofValeronALA()
        {
            Name = "Steward of Valeron";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "GW";
            PT = "2/2";
            Type = "Creature - Human Druid Knight";
            Text = "Vigilance;^%T: Add %G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Stoic Angel
    public class StoicAngelALA : MagicCard
    {
        public StoicAngelALA()
        {
            Name = "Stoic Angel";
            Edition = "ALA";
            Rarity = "R";
            Color = "Gld";
            Cost = "1GWU";
            PT = "3/4";
            Type = "Creature - Angel";
            Text = "Flying, vigilance;^Players can�t untap more than one creature during their untap steps.";
            Flavor = "";
        }
    }
    # endregion

    # region Sunseed Nurturer
    public class SunseedNurturerALA : MagicCard
    {
        public SunseedNurturerALA()
        {
            Name = "Sunseed Nurturer";
            Edition = "ALA";
            Rarity = "U";
            Color = "W";
            Cost = "2W";
            PT = "1/1";
            Type = "Creature - Human Druid Wizard";
            Text = "At the beginning of your end step, if you control a creature with power 5 or greater, you may gain 2 life.;^%T: Add %1 to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Swamp
    public class SwampALA : MagicCard
    {
        public SwampALA()
        {
            Name = "Swamp ";
            Edition = "ALA";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Basic Land - Swamp";
            Text = "";
            Flavor = "�";
        }
    }
    # endregion

    # region Swerve
    public class SwerveALA : MagicCard
    {
        public SwerveALA()
        {
            Name = "Swerve";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "UR";
            PT = "";
            Type = "Instant";
            Text = "Change the target of target spell with a single target.";
            Flavor = "";
        }
    }
    # endregion

    # region Tar Fiend
    public class TarFiendALA : MagicCard
    {
        public TarFiendALA()
        {
            Name = "Tar Fiend";
            Edition = "ALA";
            Rarity = "R";
            Color = "B";
            Cost = "5B";
            PT = "4/4";
            Type = "Creature - Elemental";
            Text = "Devour 2 @(As this enters the battlefield, you may sacrifice any number of creatures. This creature enters the battlefield with twice that many +1/+1 counters on it.)@;^When Tar Fiend enters the battlefield, target player discards a card for each creature it devoured.";
            Flavor = "";
        }
    }
    # endregion

    # region Tezzeret the Seeker
    public class TezzerettheSeekerALA : MagicCard
    {
        public TezzerettheSeekerALA()
        {
            Name = "Tezzeret the Seeker";
            Edition = "ALA";
            Rarity = "M";
            Color = "U";
            Cost = "3UU";
            PT = "%4/";
            Type = "Planeswalker - Tezzeret";
            Text = "+1: Untap up to two target artifacts.;^-X: Search your library for an artifact card with converted mana cost X or less and put it onto the battlefield. Then shuffle your library.;^-5: Artifacts you control become 5/5 artifact creatures until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Thorn-Thrash Viashino
    public class ThornThrashViashinoALA : MagicCard
    {
        public ThornThrashViashinoALA()
        {
            Name = "Thorn-Thrash Viashino";
            Edition = "ALA";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "2/2";
            Type = "Creature - Viashino Warrior";
            Text = "Devour 2 @(As this enters the battlefield, you may sacrifice any number of creatures. This creature enters the battlefield with twice that many +1/+1 counters on it.)@;^%G: Thorn-Thrash Viashino gains trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Thoughtcutter Agent
    public class ThoughtcutterAgentALA : MagicCard
    {
        public ThoughtcutterAgentALA()
        {
            Name = "Thoughtcutter Agent";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "UB";
            PT = "1/1";
            Type = "Artifact Creature - Human Rogue";
            Text = "%U%B, %T: Target player loses 1 life and reveals his or her hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Thunder-Thrash Elder
    public class ThunderThrashElderALA : MagicCard
    {
        public ThunderThrashElderALA()
        {
            Name = "Thunder-Thrash Elder";
            Edition = "ALA";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "1/1";
            Type = "Creature - Viashino Warrior";
            Text = "Devour 3 @(As this enters the battlefield, you may sacrifice any number of creatures. This creature enters the battlefield with three times that many +1/+1 counters on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Tidehollow Sculler
    public class TidehollowScullerALA : MagicCard
    {
        public TidehollowScullerALA()
        {
            Name = "Tidehollow Sculler";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "WB";
            PT = "2/2";
            Type = "Artifact Creature - Zombie";
            Text = "When Tidehollow Sculler enters the battlefield, target opponent reveals his or her hand and you choose a nonland card from it. Exile that card.;^When Tidehollow Sculler leaves the battlefield, return the exiled card to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Tidehollow Strix
    public class TidehollowStrixALA : MagicCard
    {
        public TidehollowStrixALA()
        {
            Name = "Tidehollow Strix";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "UB";
            PT = "2/1";
            Type = "Artifact Creature - Bird";
            Text = "Flying;^Deathtouch @(Any amount of damage this deals to a creature is enough to destroy it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Titanic Ultimatum
    public class TitanicUltimatumALA : MagicCard
    {
        public TitanicUltimatumALA()
        {
            Name = "Titanic Ultimatum";
            Edition = "ALA";
            Rarity = "R";
            Color = "Gld";
            Cost = "RRGGGWW";
            PT = "";
            Type = "Sorcery";
            Text = "Until end of turn, creatures you control get +5/+5 and gain first strike, lifelink, and trample.";
            Flavor = "";
        }
    }
    # endregion

    # region Topan Ascetic
    public class TopanAsceticALA : MagicCard
    {
        public TopanAsceticALA()
        {
            Name = "Topan Ascetic";
            Edition = "ALA";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Human Monk";
            Text = "Tap an untapped creature you control: Topan Ascetic gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Tortoise Formation
    public class TortoiseFormationALA : MagicCard
    {
        public TortoiseFormationALA()
        {
            Name = "Tortoise Formation";
            Edition = "ALA";
            Rarity = "C";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Instant";
            Text = "Creatures you control gain shroud until end of turn. @(They can�t be the targets of spells or abilities.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Tower Gargoyle
    public class TowerGargoyleALA : MagicCard
    {
        public TowerGargoyleALA()
        {
            Name = "Tower Gargoyle";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "1WUB";
            PT = "4/4";
            Type = "Artifact Creature - Gargoyle";
            Text = "Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Undead Leotau
    public class UndeadLeotauALA : MagicCard
    {
        public UndeadLeotauALA()
        {
            Name = "Undead Leotau";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "5B";
            PT = "3/4";
            Type = "Creature - Zombie Cat";
            Text = "%R: Undead Leotau gets +1/-1 until end of turn.;^Unearth %2%B @(%2%B: Return this card from your graveyard to the battlefield. It gains haste. Exile it at the beginning of the next end step or if it would leave the battlefield. Unearth only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Vectis Silencers
    public class VectisSilencersALA : MagicCard
    {
        public VectisSilencersALA()
        {
            Name = "Vectis Silencers";
            Edition = "ALA";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "1/2";
            Type = "Artifact Creature - Human Rogue";
            Text = "%2%B: Vectis Silencers gains deathtouch until end of turn. @(Any amount of damage it deals to a creature is enough to destroy that creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Vein Drinker
    public class VeinDrinkerALA : MagicCard
    {
        public VeinDrinkerALA()
        {
            Name = "Vein Drinker";
            Edition = "ALA";
            Rarity = "R";
            Color = "B";
            Cost = "4BB";
            PT = "4/4";
            Type = "Creature - Vampire";
            Text = "Flying;^%R, %T: Vein Drinker deals damage equal to its power to target creature. That creature deals damage equal to its power to Vein Drinker.;^Whenever a creature dealt damage by Vein Drinker this turn dies, put a +1/+1 counter on Vein Drinker.";
            Flavor = "";
        }
    }
    # endregion

    # region Viashino Skeleton
    public class ViashinoSkeletonALA : MagicCard
    {
        public ViashinoSkeletonALA()
        {
            Name = "Viashino Skeleton";
            Edition = "ALA";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "2/1";
            Type = "Creature - Viashino Skeleton";
            Text = "%1%B, Discard a card: Regenerate Viashino Skeleton.";
            Flavor = "";
        }
    }
    # endregion

    # region Vicious Shadows
    public class ViciousShadowsALA : MagicCard
    {
        public ViciousShadowsALA()
        {
            Name = "Vicious Shadows";
            Edition = "ALA";
            Rarity = "R";
            Color = "R";
            Cost = "6R";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a creature dies, you may have Vicious Shadows deal damage to target player equal to the number of cards in that player�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Violent Ultimatum
    public class ViolentUltimatumALA : MagicCard
    {
        public ViolentUltimatumALA()
        {
            Name = "Violent Ultimatum";
            Edition = "ALA";
            Rarity = "R";
            Color = "Gld";
            Cost = "BBRRRGG";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy three target permanents.";
            Flavor = "";
        }
    }
    # endregion

    # region Viscera Dragger
    public class VisceraDraggerALA : MagicCard
    {
        public VisceraDraggerALA()
        {
            Name = "Viscera Dragger";
            Edition = "ALA";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "3/3";
            Type = "Creature - Zombie Ogre Warrior";
            Text = "Cycling %2 @(%2, Discard this card: Draw a card.)@;^Unearth %1%B @(%1%B: Return this card from your graveyard to the battlefield. It gains haste. Exile it at the beginning of the next end step or if it would leave the battlefield. Unearth only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Vithian Stinger
    public class VithianStingerALA : MagicCard
    {
        public VithianStingerALA()
        {
            Name = "Vithian Stinger";
            Edition = "ALA";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "0/1";
            Type = "Creature - Human Shaman";
            Text = "%T: Vithian Stinger deals 1 damage to target creature or player.;^Unearth %1%R @(%1%R: Return this card from your graveyard to the battlefield. It gains haste. Exile it at the beginning of the next end step or if it would leave the battlefield. Unearth only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Volcanic Submersion
    public class VolcanicSubmersionALA : MagicCard
    {
        public VolcanicSubmersionALA()
        {
            Name = "Volcanic Submersion";
            Edition = "ALA";
            Rarity = "C";
            Color = "R";
            Cost = "4R";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target artifact or land.;^Cycling %2 @(%2, Discard this card: Draw a card.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Waveskimmer Aven
    public class WaveskimmerAvenALA : MagicCard
    {
        public WaveskimmerAvenALA()
        {
            Name = "Waveskimmer Aven";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "2GWU";
            PT = "2/4";
            Type = "Creature - Bird Soldier";
            Text = "Flying;^Exalted @(Whenever a creature you control attacks alone, that creature gets +1/+1 until end of turn.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Welkin Guide
    public class WelkinGuideALA : MagicCard
    {
        public WelkinGuideALA()
        {
            Name = "Welkin Guide";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "4W";
            PT = "2/2";
            Type = "Creature - Bird Cleric";
            Text = "Flying;^When Welkin Guide enters the battlefield, target creature gets +2/+2 and gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Where Ancients Tread
    public class WhereAncientsTreadALA : MagicCard
    {
        public WhereAncientsTreadALA()
        {
            Name = "Where Ancients Tread";
            Edition = "ALA";
            Rarity = "R";
            Color = "R";
            Cost = "4R";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a creature with power 5 or greater enters the battlefield under your control, you may have Where Ancients Tread deal 5 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Wild Nacatl
    public class WildNacatlALA : MagicCard
    {
        public WildNacatlALA()
        {
            Name = "Wild Nacatl";
            Edition = "ALA";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Cat Warrior";
            Text = "Wild Nacatl gets +1/+1 as long as you control a Mountain.;^Wild Nacatl gets +1/+1 as long as you control a Plains.";
            Flavor = "";
        }
    }
    # endregion

    # region Windwright Mage
    public class WindwrightMageALA : MagicCard
    {
        public WindwrightMageALA()
        {
            Name = "Windwright Mage";
            Edition = "ALA";
            Rarity = "C";
            Color = "Gld";
            Cost = "WUB";
            PT = "2/2";
            Type = "Artifact Creature - Human Wizard";
            Text = "Lifelink @(Damage dealt by this creature also causes you to gain that much life.)@;^Windwright Mage has flying as long as an artifact card is in your graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Woolly Thoctar
    public class WoollyThoctarALA : MagicCard
    {
        public WoollyThoctarALA()
        {
            Name = "Woolly Thoctar";
            Edition = "ALA";
            Rarity = "U";
            Color = "Gld";
            Cost = "RGW";
            PT = "5/4";
            Type = "Creature - Beast";
            Text = "";
            Flavor = "One of the most ferocious and deadly gargantuans, the thoctar never sees its worshippers, but it often awakens surrounded by gifts and sacrifices.";
        }
    }
    # endregion

    # region Yoked Plowbeast
    public class YokedPlowbeastALA : MagicCard
    {
        public YokedPlowbeastALA()
        {
            Name = "Yoked Plowbeast";
            Edition = "ALA";
            Rarity = "C";
            Color = "W";
            Cost = "5WW";
            PT = "5/5";
            Type = "Creature - Beast";
            Text = "Cycling %2 @(%2, Discard this card: Draw a card.)@";
            Flavor = "";
        }
    }
    # endregion


    # endregion
}
