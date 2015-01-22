using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
    # region Duel Decks: Ajani vs. Nicol Bolas
    # region Ageless Entity
    public class AgelessEntityDDH : MagicCard
    {
        public AgelessEntityDDH()
        {
            Name = "Ageless Entity";
            Edition = "DDH";
            Rarity = "R";
            Color = "G";
            Cost = "3GG";
            PT = "4/4";
            Type = "Creature - Elemental";
            Text = "Whenever you gain life, put that many +1/+1 counters on Ageless Entity.";
            Flavor = "";
        }
    }
    # endregion

    # region Agonizing Demise
    public class AgonizingDemiseDDH : MagicCard
    {
        public AgonizingDemiseDDH()
        {
            Name = "Agonizing Demise";
            Edition = "DDH";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "";
            Type = "Instant";
            Text = "Kicker %1%R @(You may pay an additional %1%R as you cast this spell.)@;^Destroy target nonblack creature. It can�t be regenerated. If Agonizing Demise was kicked, it deals damage equal to that creature�s power to the creature�s controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Ajani Vengeant
    public class AjaniVengeantDDH : MagicCard
    {
        public AjaniVengeantDDH()
        {
            Name = "Ajani Vengeant";
            Edition = "DDH";
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

    # region Ajani's Mantra
    public class AjanisMantraDDH : MagicCard
    {
        public AjanisMantraDDH()
        {
            Name = "Ajani's Mantra";
            Edition = "DDH";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of your upkeep, you may gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Ajani's Pridemate
    public class AjanisPridemateDDH : MagicCard
    {
        public AjanisPridemateDDH()
        {
            Name = "Ajani's Pridemate";
            Edition = "DDH";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "2/2";
            Type = "Creature - Cat Soldier";
            Text = "Whenever you gain life, you may put a +1/+1 counter on Ajani�s Pridemate. @(For example, if an effect causes you to gain 3 life, you may put one +1/+1 counter on this creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Behemoth Sledge
    public class BehemothSledgeDDH : MagicCard
    {
        public BehemothSledgeDDH()
        {
            Name = "Behemoth Sledge";
            Edition = "DDH";
            Rarity = "U";
            Color = "Gld";
            Cost = "1GW";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +2/+2 and has lifelink and trample.;^Equip %3";
            Flavor = "";
        }
    }
    # endregion

    # region Blazing Specter
    public class BlazingSpecterDDH : MagicCard
    {
        public BlazingSpecterDDH()
        {
            Name = "Blazing Specter";
            Edition = "DDH";
            Rarity = "R";
            Color = "Gld";
            Cost = "2BR";
            PT = "2/2";
            Type = "Creature - Specter";
            Text = "Flying, haste;^Whenever Blazing Specter deals combat damage to a player, that player discards a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Brackwater Elemental
    public class BrackwaterElementalDDH : MagicCard
    {
        public BrackwaterElementalDDH()
        {
            Name = "Brackwater Elemental";
            Edition = "DDH";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "4/4";
            Type = "Creature - Elemental";
            Text = "When Brackwater Elemental attacks or blocks, sacrifice it at the beginning of the next end step.;^Unearth %2%U @(%2%U: Return this card from your graveyard to the battlefield. It gains haste. Exile it at the beginning of the next end step or if it would leave the battlefield. Unearth only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Briarhorn
    public class BriarhornDDH : MagicCard
    {
        public BriarhornDDH()
        {
            Name = "Briarhorn";
            Edition = "DDH";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "3/3";
            Type = "Creature - Elemental";
            Text = "Flash;^When Briarhorn enters the battlefield, target creature gets +3/+3 until end of turn.;^Evoke %1%G @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Canyon Wildcat
    public class CanyonWildcatDDH : MagicCard
    {
        public CanyonWildcatDDH()
        {
            Name = "Canyon Wildcat";
            Edition = "DDH";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "2/1";
            Type = "Creature - Cat";
            Text = "Mountainwalk";
            Flavor = "";
        }
    }
    # endregion

    # region Countersquall
    public class CountersquallDDH : MagicCard
    {
        public CountersquallDDH()
        {
            Name = "Countersquall";
            Edition = "DDH";
            Rarity = "U";
            Color = "Gld";
            Cost = "UB";
            PT = "";
            Type = "Instant";
            Text = "Counter target noncreature spell. Its controller loses 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Cruel Ultimatum
    public class CruelUltimatumDDH : MagicCard
    {
        public CruelUltimatumDDH()
        {
            Name = "Cruel Ultimatum";
            Edition = "DDH";
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
    public class CrumblingNecropolisDDH : MagicCard
    {
        public CrumblingNecropolisDDH()
        {
            Name = "Crumbling Necropolis";
            Edition = "DDH";
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

    # region Deep Analysis
    public class DeepAnalysisDDH : MagicCard
    {
        public DeepAnalysisDDH()
        {
            Name = "Deep Analysis";
            Edition = "DDH";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Sorcery";
            Text = "Target player draws two cards.;^Flashback�%1%U, Pay 3 life. @(You may cast this card from your graveyard for its flashback cost. Then exile it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Dimir Cutpurse
    public class DimirCutpurseDDH : MagicCard
    {
        public DimirCutpurseDDH()
        {
            Name = "Dimir Cutpurse";
            Edition = "DDH";
            Rarity = "R";
            Color = "Gld";
            Cost = "1UB";
            PT = "2/2";
            Type = "Creature - Spirit";
            Text = "Whenever Dimir Cutpurse deals combat damage to a player, that player discards a card and you draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Elder Mastery
    public class ElderMasteryDDH : MagicCard
    {
        public ElderMasteryDDH()
        {
            Name = "Elder Mastery";
            Edition = "DDH";
            Rarity = "U";
            Color = "Gld";
            Cost = "3UBR";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +3/+3 and has flying.;^Whenever enchanted creature deals damage to a player, that player discards two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Essence Warden
    public class EssenceWardenDDH : MagicCard
    {
        public EssenceWardenDDH()
        {
            Name = "Essence Warden";
            Edition = "DDH";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Elf Shaman";
            Text = "Whenever another creature enters the battlefield, you gain 1 life.";
            Flavor = "";
        }

        public override void CreatureEnteredPlay(MagicCard mc)
        {
            PArea.HP++;
        }
    }
    # endregion

    # region Evolving Wilds
    public class EvolvingWildsDDH : EvolvingWildsDKA
    {
        public EvolvingWildsDDH()
        {
            Name = "Evolving Wilds";
            Edition = "DDH";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T, Sacrifice Evolving Wilds: Search your library for a basic land card and put it onto the battlefield tapped. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Fire-Field Ogre
    public class FireFieldOgreDDH : MagicCard
    {
        public FireFieldOgreDDH()
        {
            Name = "Fire-Field Ogre";
            Edition = "DDH";
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

    # region Firemane Angel
    public class FiremaneAngelDDH : MagicCard
    {
        public FiremaneAngelDDH()
        {
            Name = "Firemane Angel";
            Edition = "DDH";
            Rarity = "R";
            Color = "Gld";
            Cost = "3RWW";
            PT = "4/3";
            Type = "Creature - Angel";
            Text = "Flying, first strike;^At the beginning of your upkeep, if Firemane Angel is in your graveyard or on the battlefield, you may gain 1 life.;^%6%R%R%W%W: Return Firemane Angel from your graveyard to the battlefield. Activate this ability only during your upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Fleetfoot Panther
    public class FleetfootPantherDDH : MagicCard
    {
        public FleetfootPantherDDH()
        {
            Name = "Fleetfoot Panther";
            Edition = "DDH";
            Rarity = "U";
            Color = "Gld";
            Cost = "1GW";
            PT = "3/4";
            Type = "Creature - Cat";
            Text = "Flash;^When Fleetfoot Panther enters the battlefield, return a green or white creature you control to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Forest
    public class ForestDDH : MagicCard
    {
        public ForestDDH()
        {
            Name = "Forest";
            Edition = "DDH";
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

    # region Graypelt Refuge
    public class GraypeltRefugeDDH : MagicCard
    {
        public GraypeltRefugeDDH()
        {
            Name = "Graypelt Refuge";
            Edition = "DDH";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Graypelt Refuge enters the battlefield tapped.;^When Graypelt Refuge enters the battlefield, you gain 1 life.;^%T: Add %G or %W to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Grazing Gladehart
    public class GrazingGladehartDDH : MagicCard
    {
        public GrazingGladehartDDH()
        {
            Name = "Grazing Gladehart";
            Edition = "DDH";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Antelope";
            Text = "@Landfall@ � Whenever a land enters the battlefield under your control, you may gain 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Griffin Guide
    public class GriffinGuideDDH : MagicCard
    {
        public GriffinGuideDDH()
        {
            Name = "Griffin Guide";
            Edition = "DDH";
            Rarity = "U";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +2/+2 and has flying.;^When enchanted creature dies, put a 2/2 white Griffin creature token with flying onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Grixis Charm
    public class GrixisCharmDDH : MagicCard
    {
        public GrixisCharmDDH()
        {
            Name = "Grixis Charm";
            Edition = "DDH";
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

    # region Hellfire Mongrel
    public class HellfireMongrelDDH : MagicCard
    {
        public HellfireMongrelDDH()
        {
            Name = "Hellfire Mongrel";
            Edition = "DDH";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Elemental Hound";
            Text = "At the beginning of each opponent�s upkeep, if that player has two or fewer cards in hand, Hellfire Mongrel deals 2 damage to him or her.";
            Flavor = "";
        }
    }
    # endregion

    # region Icy Manipulator
    public class IcyManipulatorDDH : MagicCard
    {
        public IcyManipulatorDDH()
        {
            Name = "Icy Manipulator";
            Edition = "DDH";
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

    # region Igneous Pouncer
    public class IgneousPouncerDDH : MagicCard
    {
        public IgneousPouncerDDH()
        {
            Name = "Igneous Pouncer";
            Edition = "DDH";
            Rarity = "C";
            Color = "Gld";
            Cost = "4BR";
            PT = "5/1";
            Type = "Creature - Elemental";
            Text = "Haste;^Swampcycling %2, mountaincycling %2 @(%2, Discard this card: Search your library for a Swamp or Mountain card, reveal it, and put it into your hand. Then shuffle your library.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Island
    public class IslandDDH : MagicCard
    {
        public IslandDDH()
        {
            Name = "Island";
            Edition = "DDH";
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

    # region Jade Mage
    public class JadeMageDDH : MagicCard
    {
        public JadeMageDDH()
        {
            Name = "Jade Mage";
            Edition = "DDH";
            Rarity = "U";
            Color = "G";
            Cost = "1G";
            PT = "2/1";
            Type = "Creature - Human Shaman";
            Text = "%2%G: Put a 1/1 green Saproling creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Jhessian Zombies
    public class JhessianZombiesDDH : MagicCard
    {
        public JhessianZombiesDDH()
        {
            Name = "Jhessian Zombies";
            Edition = "DDH";
            Rarity = "C";
            Color = "Gld";
            Cost = "4UB";
            PT = "2/4";
            Type = "Creature - Zombie";
            Text = "Fear @(This creature can�t be blocked except by artifact creatures and/or black creatures.)@;^Islandcycling %2, swampcycling %2 @(%2, Discard this card: Search your library for an Island or Swamp card, reveal it, and put it into your hand. Then shuffle your library.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Jungle Shrine
    public class JungleShrineDDH : MagicCard
    {
        public JungleShrineDDH()
        {
            Name = "Jungle Shrine";
            Edition = "DDH";
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

    # region Kazandu Refuge
    public class KazanduRefugeDDH : MagicCard
    {
        public KazanduRefugeDDH()
        {
            Name = "Kazandu Refuge";
            Edition = "DDH";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Kazandu Refuge enters the battlefield tapped.;^When Kazandu Refuge enters the battlefield, you gain 1 life.;^%T: Add %R or %G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Kird Ape
    public class KirdApeDDH : MagicCard
    {
        public KirdApeDDH()
        {
            Name = "Kird Ape";
            Edition = "DDH";
            Rarity = "U";
            Color = "R";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Ape";
            Text = "Kird Ape gets +1/+2 as long as you control a Forest.";
            Flavor = "";
        }
    }
    # endregion

    # region Lead the Stampede
    public class LeadtheStampedeDDH : MagicCard
    {
        public LeadtheStampedeDDH()
        {
            Name = "Lead the Stampede";
            Edition = "DDH";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Sorcery";
            Text = "Look at the top five cards of your library. You may reveal any number of creature cards from among them and put the revealed cards into your hand. Put the rest on the bottom of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Lightning Helix
    public class LightningHelixDDH : MagicCard
    {
        public LightningHelixDDH()
        {
            Name = "Lightning Helix";
            Edition = "DDH";
            Rarity = "U";
            Color = "Gld";
            Cost = "RW";
            PT = "";
            Type = "Instant";
            Text = "Lightning Helix deals 3 damage to target creature or player and you gain 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Loam Lion
    public class LoamLionDDH : MagicCard
    {
        public LoamLionDDH()
        {
            Name = "Loam Lion";
            Edition = "DDH";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Cat";
            Text = "Loam Lion gets +1/+2 as long as you control a Forest.";
            Flavor = "";
        }
    }
    # endregion

    # region Loxodon Hierarch
    public class LoxodonHierarchDDH : MagicCard
    {
        public LoxodonHierarchDDH()
        {
            Name = "Loxodon Hierarch";
            Edition = "DDH";
            Rarity = "R";
            Color = "Gld";
            Cost = "2GW";
            PT = "4/4";
            Type = "Creature - Elephant Cleric";
            Text = "When Loxodon Hierarch enters the battlefield, you gain 4 life.;^%G%W, Sacrifice Loxodon Hierarch: Regenerate each creature you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Marisi's Twinclaws
    public class MarisisTwinclawsDDH : MagicCard
    {
        public MarisisTwinclawsDDH()
        {
            Name = "Marisi's Twinclaws";
            Edition = "DDH";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%PG";
            PT = "2/4";
            Type = "Creature - Cat Warrior";
            Text = "Double strike";
            Flavor = "";
        }
    }
    # endregion

    # region Morgue Toad
    public class MorgueToadDDH : MagicCard
    {
        public MorgueToadDDH()
        {
            Name = "Morgue Toad";
            Edition = "DDH";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Frog";
            Text = "Sacrifice Morgue Toad: Add %U%R to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Moroii
    public class MoroiiDDH : MagicCard
    {
        public MoroiiDDH()
        {
            Name = "Moroii";
            Edition = "DDH";
            Rarity = "U";
            Color = "Gld";
            Cost = "2UB";
            PT = "4/4";
            Type = "Creature - Vampire";
            Text = "Flying;^At the beginning of your upkeep, you lose 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Mountain
    public class MountainDDH : MagicCard
    {
        public MountainDDH()
        {
            Name = "Mountain";
            Edition = "DDH";
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

    # region Nacatl Hunt-Pride
    public class NacatlHuntPrideDDH : MagicCard
    {
        public NacatlHuntPrideDDH()
        {
            Name = "Nacatl Hunt-Pride";
            Edition = "DDH";
            Rarity = "U";
            Color = "W";
            Cost = "5W";
            PT = "5/4";
            Type = "Creature - Cat Warrior";
            Text = "Vigilance;^%R, %T: Target creature can�t block this turn.;^%G, %T: Target creature blocks this turn if able.";
            Flavor = "";
        }
    }
    # endregion

    # region Naya Charm
    public class NayaCharmDDH : MagicCard
    {
        public NayaCharmDDH()
        {
            Name = "Naya Charm";
            Edition = "DDH";
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

    # region Nicol Bolas, Planeswalker
    public class NicolBolasPlaneswalkerDDH : MagicCard
    {
        public NicolBolasPlaneswalkerDDH()
        {
            Name = "Nicol Bolas, Planeswalker";
            Edition = "DDH";
            Rarity = "M";
            Color = "Gld";
            Cost = "4UBBR";
            PT = "%5/";
            Type = "Planeswalker - Bolas";
            Text = "+3: Destroy target noncreature permanent.;^-2: Gain control of target creature.;^-9: Nicol Bolas, Planeswalker deals 7 damage to target player. That player discards seven cards, then sacrifices seven permanents.";
            Flavor = "";
        }
    }
    # endregion

    # region Nightscape Familiar
    public class NightscapeFamiliarDDH : MagicCard
    {
        public NightscapeFamiliarDDH()
        {
            Name = "Nightscape Familiar";
            Edition = "DDH";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "1/1";
            Type = "Creature - Zombie";
            Text = "Blue spells and red spells you cast cost %1 less to cast.;^%1%B: Regenerate Nightscape Familiar.";
            Flavor = "";
        }
    }
    # endregion

    # region Obelisk of Grixis
    public class ObeliskofGrixisDDH : MagicCard
    {
        public ObeliskofGrixisDDH()
        {
            Name = "Obelisk of Grixis";
            Edition = "DDH";
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

    # region Ogre Savant
    public class OgreSavantDDH : MagicCard
    {
        public OgreSavantDDH()
        {
            Name = "Ogre Savant";
            Edition = "DDH";
            Rarity = "C";
            Color = "R";
            Cost = "4R";
            PT = "3/2";
            Type = "Creature - Ogre Wizard";
            Text = "When Ogre Savant enters the battlefield, if %U was spent to cast Ogre Savant, return target creature to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Pain/Suffering
    public class PainSufferingDDH : MagicCard
    {
        public PainSufferingDDH()
        {
            Name = "Pain/Suffering";
            Edition = "DDH";
            Rarity = "U";
            Color = "Gld";
            Cost = "B/3R";
            PT = "";
            Type = "Sorcery/Sorcery";
            Text = "Target player discards a card.;^//;^Destroy target land.";
            Flavor = "";
        }
    }
    # endregion

    # region Plains
    public class PlainsDDH : MagicCard
    {
        public PlainsDDH()
        {
            Name = "Plains";
            Edition = "DDH";
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

    # region Pride of Lions
    public class PrideofLionsDDH : MagicCard
    {
        public PrideofLionsDDH()
        {
            Name = "Pride of Lions";
            Edition = "DDH";
            Rarity = "U";
            Color = "G";
            Cost = "3GG";
            PT = "4/4";
            Type = "Creature - Cat";
            Text = "You may have Pride of Lions assign its combat damage as though it weren�t blocked.";
            Flavor = "";
        }
    }
    # endregion

    # region Profane Command
    public class ProfaneCommandDDH : MagicCard
    {
        public ProfaneCommandDDH()
        {
            Name = "Profane Command";
            Edition = "DDH";
            Rarity = "R";
            Color = "B";
            Cost = "XBB";
            PT = "";
            Type = "Sorcery";
            Text = "Choose two � Target player loses X life; or return target creature card with converted mana cost X or less from your graveyard to the battlefield; or target creature gets -X/-X until end of turn; or up to X target creatures gain fear until end of turn. @(They can�t be blocked except by artifact creatures and/or black creatures.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Qasali Pridemage
    public class QasaliPridemageDDH : MagicCard
    {
        public QasaliPridemageDDH()
        {
            Name = "Qasali Pridemage";
            Edition = "DDH";
            Rarity = "C";
            Color = "Gld";
            Cost = "GW";
            PT = "2/2";
            Type = "Creature - Cat Wizard";
            Text = "Exalted @(Whenever a creature you control attacks alone, that creature gets +1/+1 until end of turn.)@;^%1, Sacrifice Qasali Pridemage: Destroy target artifact or enchantment.";
            Flavor = "";
        }
    }
    # endregion

    # region Recoil
    public class RecoilDDH : MagicCard
    {
        public RecoilDDH()
        {
            Name = "Recoil";
            Edition = "DDH";
            Rarity = "C";
            Color = "Gld";
            Cost = "1UB";
            PT = "";
            Type = "Instant";
            Text = "Return target permanent to its owner�s hand. Then that player discards a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Recumbent Bliss
    public class RecumbentBlissDDH : MagicCard
    {
        public RecumbentBlissDDH()
        {
            Name = "Recumbent Bliss";
            Edition = "DDH";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature can�t attack or block.;^At the beginning of your upkeep, you may gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Rise/Fall
    public class RiseFallDDH : MagicCard
    {
        public RiseFallDDH()
        {
            Name = "Rise/Fall";
            Edition = "DDH";
            Rarity = "U";
            Color = "Gld";
            Cost = "UB/BR";
            PT = "";
            Type = "Sorcery/Sorcery";
            Text = "Return target creature card from a graveyard and target creature on the battlefield to their owners� hands.;^//;^Target player reveals two cards at random from his or her hand, then discards each nonland card revealed this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Rupture Spire
    public class RuptureSpireDDH : MagicCard
    {
        public RuptureSpireDDH()
        {
            Name = "Rupture Spire";
            Edition = "DDH";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Rupture Spire enters the battlefield tapped.;^When Rupture Spire enters the battlefield, sacrifice it unless you pay %1.;^%T: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Sapseep Forest
    public class SapseepForestDDH : MagicCard
    {
        public SapseepForestDDH()
        {
            Name = "Sapseep Forest";
            Edition = "DDH";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Forest";
            Text = "@(%T: Add %G to your mana pool.)@;^Sapseep Forest enters the battlefield tapped.;^%G, %T: You gain 1 life. Activate this ability only if you control two or more green permanents.";
            Flavor = "";
        }
    }
    # endregion

    # region Searing Meditation
    public class SearingMeditationDDH : MagicCard
    {
        public SearingMeditationDDH()
        {
            Name = "Searing Meditation";
            Edition = "DDH";
            Rarity = "R";
            Color = "Gld";
            Cost = "1RW";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever you gain life, you may pay %2. If you do, Searing Meditation deals 2 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Shriekmaw
    public class ShriekmawDDH : MagicCard
    {
        public ShriekmawDDH()
        {
            Name = "Shriekmaw";
            Edition = "DDH";
            Rarity = "U";
            Color = "B";
            Cost = "4B";
            PT = "3/2";
            Type = "Creature - Elemental";
            Text = "Fear @(This creature can�t be blocked except by artifact creatures and/or black creatures.)@;^When Shriekmaw enters the battlefield, destroy target nonartifact, nonblack creature.;^Evoke %1%B @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Slave of Bolas
    public class SlaveofBolasDDH : MagicCard
    {
        public SlaveofBolasDDH()
        {
            Name = "Slave of Bolas";
            Edition = "DDH";
            Rarity = "U";
            Color = "Gld";
            Cost = "3%IB";
            PT = "";
            Type = "Sorcery";
            Text = "Gain control of target creature. Untap that creature. It gains haste until end of turn. Sacrifice it at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Slavering Nulls
    public class SlaveringNullsDDH : MagicCard
    {
        public SlaveringNullsDDH()
        {
            Name = "Slavering Nulls";
            Edition = "DDH";
            Rarity = "U";
            Color = "R";
            Cost = "1R";
            PT = "2/1";
            Type = "Creature - Goblin Zombie";
            Text = "Whenever Slavering Nulls deals combat damage to a player, if you control a Swamp, you may have that player discard a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Spite/Malice
    public class SpiteMaliceDDH : MagicCard
    {
        public SpiteMaliceDDH()
        {
            Name = "Spite/Malice";
            Edition = "DDH";
            Rarity = "U";
            Color = "Gld";
            Cost = "3U/3B";
            PT = "";
            Type = "Instant/Instant";
            Text = "Counter target noncreature spell.;^//;^Destroy target nonblack creature. It can�t be regenerated.";
            Flavor = "";
        }
    }
    # endregion

    # region Spitemare
    public class SpitemareDDH : MagicCard
    {
        public SpitemareDDH()
        {
            Name = "Spitemare";
            Edition = "DDH";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%P%P";
            PT = "3/3";
            Type = "Creature - Elemental";
            Text = "Whenever Spitemare is dealt damage, it deals that much damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Steamcore Weird
    public class SteamcoreWeirdDDH : MagicCard
    {
        public SteamcoreWeirdDDH()
        {
            Name = "Steamcore Weird";
            Edition = "DDH";
            Rarity = "C";
            Color = "U";
            Cost = "3U";
            PT = "1/3";
            Type = "Creature - Weird";
            Text = "When Steamcore Weird enters the battlefield, if %R was spent to cast Steamcore Weird, it deals 2 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Surveilling Sprite
    public class SurveillingSpriteDDH : MagicCard
    {
        public SurveillingSpriteDDH()
        {
            Name = "Surveilling Sprite";
            Edition = "DDH";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Faerie Rogue";
            Text = "Flying;^When Surveilling Sprite dies, you may draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Swamp
    public class SwampDDH : MagicCard
    {
        public SwampDDH()
        {
            Name = "Swamp";
            Edition = "DDH";
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

    # region Sylvan Bounty
    public class SylvanBountyDDH : MagicCard
    {
        public SylvanBountyDDH()
        {
            Name = "Sylvan Bounty";
            Edition = "DDH";
            Rarity = "C";
            Color = "G";
            Cost = "5G";
            PT = "";
            Type = "Instant";
            Text = "Target player gains 8 life.;^Basic landcycling %1%G @(%1%G, Discard this card: Search your library for a basic land card, reveal it, and put it into your hand. Then shuffle your library.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Sylvan Ranger
    public class SylvanRangerDDH : MagicCard
    {
        public SylvanRangerDDH()
        {
            Name = "Sylvan Ranger";
            Edition = "DDH";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "1/1";
            Type = "Creature - Elf Scout";
            Text = "When Sylvan Ranger enters the battlefield, you may search your library for a basic land card, reveal it, put it into your hand, then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Terramorphic Expanse
    public class TerramorphicExpanseDDH : MagicCard
    {
        public TerramorphicExpanseDDH()
        {
            Name = "Terramorphic Expanse";
            Edition = "DDH";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T, Sacrifice Terramorphic Expanse: Search your library for a basic land card and put it onto the battlefield tapped. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Titanic Ultimatum
    public class TitanicUltimatumDDH : MagicCard
    {
        public TitanicUltimatumDDH()
        {
            Name = "Titanic Ultimatum";
            Edition = "DDH";
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

    # region Undermine
    public class UndermineDDH : MagicCard
    {
        public UndermineDDH()
        {
            Name = "Undermine";
            Edition = "DDH";
            Rarity = "R";
            Color = "Gld";
            Cost = "UUB";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell. Its controller loses 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Vapor Snag
    public class VaporSnagDDH : MagicCard
    {
        public VaporSnagDDH()
        {
            Name = "Vapor Snag";
            Edition = "DDH";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Return target creature to its owner�s hand. Its controller loses 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Vitu-Ghazi, the City-Tree
    public class VituGhazitheCityTreeDDH : MagicCard
    {
        public VituGhazitheCityTreeDDH()
        {
            Name = "Vitu-Ghazi, the City-Tree";
            Edition = "DDH";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%2%G%W, %T: Put a 1/1 green Saproling creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Wild Nacatl
    public class WildNacatlDDH : MagicCard
    {
        public WildNacatlDDH()
        {
            Name = "Wild Nacatl";
            Edition = "DDH";
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

    # region Woolly Thoctar
    public class WoollyThoctarDDH : MagicCard
    {
        public WoollyThoctarDDH()
        {
            Name = "Woolly Thoctar";
            Edition = "DDH";
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

    # endregion
}
