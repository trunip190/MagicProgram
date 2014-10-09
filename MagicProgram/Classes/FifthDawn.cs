using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
    # region Abuna's Chant
    public class AbunasChantFD : MagicCard
    {
        public AbunasChantFD()
        {
            Name = "Abuna's Chant";
            Edition = "FD";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Instant";
            Text = "Choose one � You gain 5 life; or prevent the next 5 damage that would be dealt to target creature this turn.;^Entwine %2 @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Acquire
    public class AcquireFD : MagicCard
    {
        public AcquireFD()
        {
            Name = "Acquire";
            Edition = "FD";
            Rarity = "R";
            Color = "U";
            Cost = "3UU";
            PT = "";
            Type = "Sorcery";
            Text = "Search target opponent�s library for an artifact card and put that card onto the battlefield under your control. Then that player shuffles his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Advanced Hoverguard
    public class AdvancedHoverguardFD : MagicCard
    {
        public AdvancedHoverguardFD()
        {
            Name = "Advanced Hoverguard";
            Edition = "FD";
            Rarity = "C";
            Color = "U";
            Cost = "3U";
            PT = "2/2";
            Type = "Creature - Drone";
            Text = "Flying;^%U: Advanced Hoverguard gains shroud until end of turn. @(It can�t be the target of spells or abilities.)@";
            Flavor = "";
        }
    }
    # endregion

    # region All Suns' Dawn
    public class AllSunsDawnFD : MagicCard
    {
        public AllSunsDawnFD()
        {
            Name = "All Suns' Dawn";
            Edition = "FD";
            Rarity = "R";
            Color = "G";
            Cost = "4G";
            PT = "";
            Type = "Sorcery";
            Text = "For each color, return up to one target card of that color from your graveyard to your hand. Exile All Suns� Dawn.";
            Flavor = "";
        }
    }
    # endregion

    # region Anodet Lurker
    public class AnodetLurkerFD : MagicCard
    {
        public AnodetLurkerFD()
        {
            Name = "Anodet Lurker";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "5";
            PT = "3/3";
            Type = "Artifact Creature - Construct";
            Text = "When Anodet Lurker dies, you gain 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Arachnoid
    public class ArachnoidFD : MagicCard
    {
        public ArachnoidFD()
        {
            Name = "Arachnoid";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "6";
            PT = "2/6";
            Type = "Artifact Creature - Spider";
            Text = "Reach @(This creature can block creatures with flying.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Arcbound Wanderer
    public class ArcboundWandererFD : MagicCard
    {
        public ArcboundWandererFD()
        {
            Name = "Arcbound Wanderer";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "6";
            PT = "0/0";
            Type = "Artifact Creature - Golem";
            Text = "Modular�Sunburst @(This enters the battlefield with a +1/+1 counter on it for each color of mana spent to cast it. When it dies, you may put its +1/+1 counters on target artifact creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Armed Response
    public class ArmedResponseFD : MagicCard
    {
        public ArmedResponseFD()
        {
            Name = "Armed Response";
            Edition = "FD";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Instant";
            Text = "Armed Response deals damage to target attacking creature equal to the number of Equipment you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Artificer's Intuition
    public class ArtificersIntuitionFD : MagicCard
    {
        public ArtificersIntuitionFD()
        {
            Name = "Artificer's Intuition";
            Edition = "FD";
            Rarity = "R";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Enchantment";
            Text = "%U, Discard an artifact card: Search your library for an artifact card with converted mana cost 1 or less, reveal that card, and put it into your hand. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Auriok Champion
    public class AuriokChampionFD : MagicCard
    {
        public AuriokChampionFD()
        {
            Name = "Auriok Champion";
            Edition = "FD";
            Rarity = "R";
            Color = "W";
            Cost = "WW";
            PT = "1/1";
            Type = "Creature - Human Cleric";
            Text = "Protection from black and from red;^Whenever another creature enters the battlefield, you may gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Auriok Salvagers
    public class AuriokSalvagersFD : MagicCard
    {
        public AuriokSalvagersFD()
        {
            Name = "Auriok Salvagers";
            Edition = "FD";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "2/4";
            Type = "Creature - Human Soldier";
            Text = "%1%W: Return target artifact card with converted mana cost 1 or less from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Auriok Windwalker
    public class AuriokWindwalkerFD : MagicCard
    {
        public AuriokWindwalkerFD()
        {
            Name = "Auriok Windwalker";
            Edition = "FD";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "2/3";
            Type = "Creature - Human Wizard";
            Text = "Flying;^%T: Attach target Equipment you control to target creature you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Avarice Totem
    public class AvariceTotemFD : MagicCard
    {
        public AvariceTotemFD()
        {
            Name = "Avarice Totem";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%5: Exchange control of Avarice Totem and target nonland permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Baton of Courage
    public class BatonofCourageFD : MagicCard
    {
        public BatonofCourageFD()
        {
            Name = "Baton of Courage";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Flash;^Sunburst @(This enters the battlefield with a charge counter on it for each color of mana spent to cast it.)@;^Remove a charge counter from Baton of Courage: Target creature gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Battered Golem
    public class BatteredGolemFD : MagicCard
    {
        public BatteredGolemFD()
        {
            Name = "Battered Golem";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "3/2";
            Type = "Artifact Creature - Golem";
            Text = "Battered Golem doesn�t untap during your untap step.;^Whenever an artifact enters the battlefield, you may untap Battered Golem.";
            Flavor = "";
        }
    }
    # endregion

    # region Beacon of Creation
    public class BeaconofCreationFD : MagicCard
    {
        public BeaconofCreationFD()
        {
            Name = "Beacon of Creation";
            Edition = "FD";
            Rarity = "R";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Sorcery";
            Text = "Put a 1/1 green Insect creature token onto the battlefield for each Forest you control. Shuffle Beacon of Creation into its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Beacon of Destruction
    public class BeaconofDestructionFD : MagicCard
    {
        public BeaconofDestructionFD()
        {
            Name = "Beacon of Destruction";
            Edition = "FD";
            Rarity = "R";
            Color = "R";
            Cost = "3RR";
            PT = "";
            Type = "Instant";
            Text = "Beacon of Destruction deals 5 damage to target creature or player. Shuffle Beacon of Destruction into its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Beacon of Immortality
    public class BeaconofImmortalityFD : MagicCard
    {
        public BeaconofImmortalityFD()
        {
            Name = "Beacon of Immortality";
            Edition = "FD";
            Rarity = "R";
            Color = "W";
            Cost = "5W";
            PT = "";
            Type = "Instant";
            Text = "Double target player�s life total. Shuffle Beacon of Immortality into its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Beacon of Tomorrows
    public class BeaconofTomorrowsFD : MagicCard
    {
        public BeaconofTomorrowsFD()
        {
            Name = "Beacon of Tomorrows";
            Edition = "FD";
            Rarity = "R";
            Color = "U";
            Cost = "6UU";
            PT = "";
            Type = "Sorcery";
            Text = "Target player takes an extra turn after this one. Shuffle Beacon of Tomorrows into its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Beacon of Unrest
    public class BeaconofUnrestFD : MagicCard
    {
        public BeaconofUnrestFD()
        {
            Name = "Beacon of Unrest";
            Edition = "FD";
            Rarity = "R";
            Color = "B";
            Cost = "3BB";
            PT = "";
            Type = "Sorcery";
            Text = "Put target artifact or creature card from a graveyard onto the battlefield under your control. Shuffle Beacon of Unrest into its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Blasting Station
    public class BlastingStationFD : MagicCard
    {
        public BlastingStationFD()
        {
            Name = "Blasting Station";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%T, Sacrifice a creature: Blasting Station deals 1 damage to target creature or player.;^Whenever a creature enters the battlefield, you may untap Blasting Station.";
            Flavor = "";
        }
    }
    # endregion

    # region Blind Creeper
    public class BlindCreeperFD : MagicCard
    {
        public BlindCreeperFD()
        {
            Name = "Blind Creeper";
            Edition = "FD";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "3/3";
            Type = "Creature - Zombie Beast";
            Text = "Whenever a player casts a spell, Blind Creeper gets -1/-1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Blinkmoth Infusion
    public class BlinkmothInfusionFD : MagicCard
    {
        public BlinkmothInfusionFD()
        {
            Name = "Blinkmoth Infusion";
            Edition = "FD";
            Rarity = "R";
            Color = "U";
            Cost = "12UU";
            PT = "";
            Type = "Instant";
            Text = "Affinity for artifacts @(This spell costs %1 less to cast for each artifact you control.)@;^Untap all artifacts.";
            Flavor = "";
        }
    }
    # endregion

    # region Bringer of the Black Dawn
    public class BringeroftheBlackDawnFD : MagicCard
    {
        public BringeroftheBlackDawnFD()
        {
            Name = "Bringer of the Black Dawn";
            Edition = "FD";
            Rarity = "R";
            Color = "B";
            Cost = "7BB";
            PT = "5/5";
            Type = "Creature - Bringer";
            Text = "You may pay %W%U%B%R%G rather than pay Bringer of the Black Dawn�s mana cost.;^Trample;^At the beginning of your upkeep, you may pay 2 life. If you do, search your library for a card, then shuffle your library and put that card on top of it.";
            Flavor = "";
        }
    }
    # endregion

    # region Bringer of the Blue Dawn
    public class BringeroftheBlueDawnFD : MagicCard
    {
        public BringeroftheBlueDawnFD()
        {
            Name = "Bringer of the Blue Dawn";
            Edition = "FD";
            Rarity = "R";
            Color = "U";
            Cost = "7UU";
            PT = "5/5";
            Type = "Creature - Bringer";
            Text = "You may pay %W%U%B%R%G rather than pay Bringer of the Blue Dawn�s mana cost.;^Trample;^At the beginning of your upkeep, you may draw two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Bringer of the Green Dawn
    public class BringeroftheGreenDawnFD : MagicCard
    {
        public BringeroftheGreenDawnFD()
        {
            Name = "Bringer of the Green Dawn";
            Edition = "FD";
            Rarity = "R";
            Color = "G";
            Cost = "7GG";
            PT = "5/5";
            Type = "Creature - Bringer";
            Text = "You may pay %W%U%B%R%G rather than pay Bringer of the Green Dawn�s mana cost.;^Trample;^At the beginning of your upkeep, you may put a 3/3 green Beast creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Bringer of the Red Dawn
    public class BringeroftheRedDawnFD : MagicCard
    {
        public BringeroftheRedDawnFD()
        {
            Name = "Bringer of the Red Dawn";
            Edition = "FD";
            Rarity = "R";
            Color = "R";
            Cost = "7RR";
            PT = "5/5";
            Type = "Creature - Bringer";
            Text = "You may pay %W%U%B%R%G rather than pay Bringer of the Red Dawn�s mana cost.;^Trample;^At the beginning of your upkeep, you may untap target creature and gain control of it until end of turn. That creature gains haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Bringer of the White Dawn
    public class BringeroftheWhiteDawnFD : MagicCard
    {
        public BringeroftheWhiteDawnFD()
        {
            Name = "Bringer of the White Dawn";
            Edition = "FD";
            Rarity = "R";
            Color = "W";
            Cost = "7WW";
            PT = "5/5";
            Type = "Creature - Bringer";
            Text = "You may pay %W%U%B%R%G rather than pay Bringer of the White Dawn�s mana cost.;^Trample;^At the beginning of your upkeep, you may return target artifact card from your graveyard to the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Cackling Imp
    public class CacklingImpFD : MagicCard
    {
        public CacklingImpFD()
        {
            Name = "Cackling Imp";
            Edition = "FD";
            Rarity = "C";
            Color = "B";
            Cost = "2BB";
            PT = "2/2";
            Type = "Creature - Imp";
            Text = "Flying;^%T: Target player loses 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Channel the Suns
    public class ChanneltheSunsFD : MagicCard
    {
        public ChanneltheSunsFD()
        {
            Name = "Channel the Suns";
            Edition = "FD";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Sorcery";
            Text = "Add %W%U%B%R%G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Chimeric Coils
    public class ChimericCoilsFD : MagicCard
    {
        public ChimericCoilsFD()
        {
            Name = "Chimeric Coils";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%X%1: Chimeric Coils becomes an X/X Construct artifact creature. Sacrifice it at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Circle of Protection: Artifacts
    public class CircleofProtectionArtifactsFD : MagicCard
    {
        public CircleofProtectionArtifactsFD()
        {
            Name = "Circle of Protection: Artifacts";
            Edition = "FD";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment";
            Text = "%2: The next time an artifact source of your choice would deal damage to you this turn, prevent that damage.";
            Flavor = "";
        }
    }
    # endregion

    # region Clearwater Goblet
    public class ClearwaterGobletFD : MagicCard
    {
        public ClearwaterGobletFD()
        {
            Name = "Clearwater Goblet";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "Sunburst @(This enters the battlefield with a charge counter on it for each color of mana spent to cast it.)@;^At the beginning of your upkeep, you may gain life equal to the number of charge counters on Clearwater Goblet.";
            Flavor = "";
        }
    }
    # endregion

    # region Clock of Omens
    public class ClockofOmensFD : MagicCard
    {
        public ClockofOmensFD()
        {
            Name = "Clock of Omens";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "Tap two untapped artifacts you control: Untap target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Composite Golem
    public class CompositeGolemFD : MagicCard
    {
        public CompositeGolemFD()
        {
            Name = "Composite Golem";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "6";
            PT = "4/4";
            Type = "Artifact Creature - Golem";
            Text = "Sacrifice Composite Golem: Add %W%U%B%R%G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Condescend
    public class CondescendFD : MagicCard
    {
        public CondescendFD()
        {
            Name = "Condescend";
            Edition = "FD";
            Rarity = "C";
            Color = "U";
            Cost = "XU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell unless its controller pays %X.;^Scry 2. @(To scry 2, look at the top two cards of your library, then put any number of them on the bottom of your library and the rest on top in any order.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Conjurer's Bauble
    public class ConjurersBaubleFD : MagicCard
    {
        public ConjurersBaubleFD()
        {
            Name = "Conjurer's Bauble";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%T, Sacrifice Conjurer�s Bauble: Put up to one target card from your graveyard on the bottom of your library. Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Cosmic Larva
    public class CosmicLarvaFD : MagicCard
    {
        public CosmicLarvaFD()
        {
            Name = "Cosmic Larva";
            Edition = "FD";
            Rarity = "R";
            Color = "R";
            Cost = "1RR";
            PT = "7/6";
            Type = "Creature - Beast";
            Text = "Trample;^At the beginning of your upkeep, sacrifice Cosmic Larva unless you sacrifice two lands.";
            Flavor = "";
        }
    }
    # endregion

    # region Cranial Plating
    public class CranialPlatingFD : MagicCard
    {
        public CranialPlatingFD()
        {
            Name = "Cranial Plating";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +1/+0 for each artifact you control.;^%B%B: Attach Cranial Plating to target creature you control.;^Equip %1 @(%1: Attach to target creature you control. Equip only as a sorcery.)@";
            Flavor = "";
        }

        public override List<string> getStats()
        {
            List<string> result = new List<string>();

            int i = 0;

            foreach (MagicCard mc in PArea._play.cards)
            {
                if (mc.Type.Contains("Artifact"))
                {
                    i++;
                }
            }
            foreach (MagicCard mc in PArea._artEnch.cards)
            {
                if (mc.Type.Contains("Artifact"))
                {
                    i++;
                }
            }
            foreach (MagicCard mc in PArea._lands.cards)
            {
                if (mc.Type.Contains("Artifact"))
                {
                    i++;
                }
            }

            result.Add("Power#" + i.ToString());

            return result;
        }
    }
    # endregion

    # region Crucible of Worlds
    public class CrucibleofWorldsFD : MagicCard
    {
        public CrucibleofWorldsFD()
        {
            Name = "Crucible of Worlds";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "You may play land cards from your graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Dawn's Reflection
    public class DawnsReflectionFD : MagicCard
    {
        public DawnsReflectionFD()
        {
            Name = "Dawn's Reflection";
            Edition = "FD";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land;^Whenever enchanted land is tapped for mana, its controller adds two mana in any combination of colors to his or her mana pool @(in addition to the mana the land produces)@.";
            Flavor = "";
        }
    }
    # endregion

    # region Desecration Elemental
    public class DesecrationElementalFD : MagicCard
    {
        public DesecrationElementalFD()
        {
            Name = "Desecration Elemental";
            Edition = "FD";
            Rarity = "R";
            Color = "B";
            Cost = "3B";
            PT = "8/8";
            Type = "Creature - Elemental";
            Text = "Fear @(This creature can�t be blocked except by artifact creatures and/or black creatures.)@;^Whenever a player casts a spell, sacrifice a creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Devour in Shadow
    public class DevourinShadowFD : MagicCard
    {
        public DevourinShadowFD()
        {
            Name = "Devour in Shadow";
            Edition = "FD";
            Rarity = "U";
            Color = "B";
            Cost = "BB";
            PT = "";
            Type = "Instant";
            Text = "Destroy target creature. It can�t be regenerated. You lose life equal to that creature�s toughness.";
            Flavor = "";
        }
    }
    # endregion

    # region Disruption Aura
    public class DisruptionAuraFD : MagicCard
    {
        public DisruptionAuraFD()
        {
            Name = "Disruption Aura";
            Edition = "FD";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant artifact;^Enchanted artifact has �At the beginning of your upkeep, sacrifice this artifact unless you pay its mana cost.�";
            Flavor = "";
        }
    }
    # endregion

    # region Door to Nothingness
    public class DoortoNothingnessFD : MagicCard
    {
        public DoortoNothingnessFD()
        {
            Name = "Door to Nothingness";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "Door to Nothingness enters the battlefield tapped.;^%W%W%U%U%B%B%R%R%G%G, %T, Sacrifice Door to Nothingness: Target player loses the game.";
            Flavor = "";
        }
    }
    # endregion

    # region Doubling Cube
    public class DoublingCubeFD : MagicCard
    {
        public DoublingCubeFD()
        {
            Name = "Doubling Cube";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T: Double the amount of each type of mana in your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Dross Crocodile
    public class DrossCrocodileFD : MagicCard
    {
        public DrossCrocodileFD()
        {
            Name = "Dross Crocodile";
            Edition = "FD";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "5/1";
            Type = "Creature - Zombie Crocodile";
            Text = "";
            Flavor = "The necrogen may have taken its sight, but it can still taste the fear of its prey.";
        }
    }
    # endregion

    # region Early Frost
    public class EarlyFrostFD : MagicCard
    {
        public EarlyFrostFD()
        {
            Name = "Early Frost";
            Edition = "FD";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Tap up to three target lands.";
            Flavor = "";
        }
    }
    # endregion

    # region Ebon Drake
    public class EbonDrakeFD : MagicCard
    {
        public EbonDrakeFD()
        {
            Name = "Ebon Drake";
            Edition = "FD";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "3/3";
            Type = "Creature - Drake";
            Text = "Flying;^Whenever a player casts a spell, you lose 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Endless Whispers
    public class EndlessWhispersFD : MagicCard
    {
        public EndlessWhispersFD()
        {
            Name = "Endless Whispers";
            Edition = "FD";
            Rarity = "R";
            Color = "B";
            Cost = "2BB";
            PT = "";
            Type = "Enchantment";
            Text = "Each creature has �When this creature dies, choose target opponent. That player puts this card from its owner�s graveyard onto the battlefield under his or her control at the beginning of the next end step.�";
            Flavor = "";
        }
    }
    # endregion

    # region Energy Chamber
    public class EnergyChamberFD : MagicCard
    {
        public EnergyChamberFD()
        {
            Name = "Energy Chamber";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of your upkeep, choose one � Put a +1/+1 counter on target artifact creature; or put a charge counter on target noncreature artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Engineered Explosives
    public class EngineeredExplosivesFD : MagicCard
    {
        public EngineeredExplosivesFD()
        {
            Name = "Engineered Explosives";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "X";
            PT = "";
            Type = "Artifact";
            Text = "Sunburst @(This enters the battlefield with a charge counter on it for each color of mana spent to cast it.)@;^%2, Sacrifice Engineered Explosives: Destroy each nonland permanent with converted mana cost equal to the number of charge counters on Engineered Explosives.";
            Flavor = "";
        }
    }
    # endregion

    # region Ensouled Scimitar
    public class EnsouledScimitarFD : MagicCard
    {
        public EnsouledScimitarFD()
        {
            Name = "Ensouled Scimitar";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "%3: Ensouled Scimitar becomes a 1/5 Spirit artifact creature with flying until end of turn. @(Equipment that�s a creature can�t equip a creature.)@;^Equipped creature gets +1/+5.;^Equip %2 @(%2: Attach to target creature you control. Equip only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Eon Hub
    public class EonHubFD : MagicCard
    {
        public EonHubFD()
        {
            Name = "Eon Hub";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "Players skip their upkeep steps.";
            Flavor = "";
        }
    }
    # endregion

    # region Etched Oracle
    public class EtchedOracleFD : MagicCard
    {
        public EtchedOracleFD()
        {
            Name = "Etched Oracle";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "0/0";
            Type = "Artifact Creature - Wizard";
            Text = "Sunburst @(This enters the battlefield with a +1/+1 counter on it for each color of mana spent to cast it.)@;^%1, Remove four +1/+1 counters from Etched Oracle: Target player draws three cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Eternal Witness
    public class EternalWitnessFD : MagicCard
    {
        public EternalWitnessFD()
        {
            Name = "Eternal Witness";
            Edition = "FD";
            Rarity = "U";
            Color = "G";
            Cost = "1GG";
            PT = "2/1";
            Type = "Creature - Human Shaman";
            Text = "When Eternal Witness enters the battlefield, you may return target card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Eyes of the Watcher
    public class EyesoftheWatcherFD : MagicCard
    {
        public EyesoftheWatcherFD()
        {
            Name = "Eyes of the Watcher";
            Edition = "FD";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever you cast an instant or sorcery spell, you may pay %1. If you do, scry 2. @(To scry 2, look at the top two cards of your library, then put any number of them on the bottom of your library and the rest on top in any order.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Fangren Pathcutter
    public class FangrenPathcutterFD : MagicCard
    {
        public FangrenPathcutterFD()
        {
            Name = "Fangren Pathcutter";
            Edition = "FD";
            Rarity = "U";
            Color = "G";
            Cost = "4GG";
            PT = "4/6";
            Type = "Creature - Beast";
            Text = "Whenever Fangren Pathcutter attacks, attacking creatures gain trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Feedback Bolt
    public class FeedbackBoltFD : MagicCard
    {
        public FeedbackBoltFD()
        {
            Name = "Feedback Bolt";
            Edition = "FD";
            Rarity = "U";
            Color = "R";
            Cost = "4R";
            PT = "";
            Type = "Instant";
            Text = "Feedback Bolt deals damage to target player equal to the number of artifacts you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Ferocious Charge
    public class FerociousChargeFD : MagicCard
    {
        public FerociousChargeFD()
        {
            Name = "Ferocious Charge";
            Edition = "FD";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +4/+4 until end of turn.;^Scry 2. @(To scry 2, look at the top two cards of your library, then put any number of them on the bottom of your library and the rest on top in any order.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Ferropede
    public class FerropedeFD : MagicCard
    {
        public FerropedeFD()
        {
            Name = "Ferropede";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "1/1";
            Type = "Artifact Creature - Insect";
            Text = "Ferropede can�t be blocked.;^Whenever Ferropede deals combat damage to a player, you may remove a counter from target permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Fill with Fright
    public class FillwithFrightFD : MagicCard
    {
        public FillwithFrightFD()
        {
            Name = "Fill with Fright";
            Edition = "FD";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "";
            Type = "Sorcery";
            Text = "Target player discards two cards.;^Scry 2. @(To scry 2, look at the top two cards of your library, then put any number of them on the bottom of your library and the rest on top in any order.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Fist of Suns
    public class FistofSunsFD : MagicCard
    {
        public FistofSunsFD()
        {
            Name = "Fist of Suns";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "You may pay %W%U%B%R%G rather than pay the mana cost for spells that you cast.";
            Flavor = "";
        }
    }
    # endregion

    # region Fleshgrafter
    public class FleshgrafterFD : MagicCard
    {
        public FleshgrafterFD()
        {
            Name = "Fleshgrafter";
            Edition = "FD";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Human Warrior";
            Text = "Discard an artifact card: Fleshgrafter gets +2/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Fold into AEther
    public class FoldintoAEtherFD : MagicCard
    {
        public FoldintoAEtherFD()
        {
            Name = "Fold into AEther";
            Edition = "FD";
            Rarity = "U";
            Color = "U";
            Cost = "2UU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell. If that spell is countered this way, its controller may put a creature card from his or her hand onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Furnace Whelp
    public class FurnaceWhelpFD : MagicCard
    {
        public FurnaceWhelpFD()
        {
            Name = "Furnace Whelp";
            Edition = "FD";
            Rarity = "U";
            Color = "R";
            Cost = "2RR";
            PT = "2/2";
            Type = "Creature - Dragon";
            Text = "Flying;^%R: Furnace Whelp gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Gemstone Array
    public class GemstoneArrayFD : MagicCard
    {
        public GemstoneArrayFD()
        {
            Name = "Gemstone Array";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%2: Put a charge counter on Gemstone Array.;^Remove a charge counter from Gemstone Array: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Brawler
    public class GoblinBrawlerFD : MagicCard
    {
        public GoblinBrawlerFD()
        {
            Name = "Goblin Brawler";
            Edition = "FD";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Goblin Warrior";
            Text = "First strike;^Goblin Brawler can�t be equipped.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Cannon
    public class GoblinCannonFD : MagicCard
    {
        public GoblinCannonFD()
        {
            Name = "Goblin Cannon";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%2: Goblin Cannon deals 1 damage to target creature or player. Sacrifice Goblin Cannon.";
            Flavor = "";
        }
    }
    # endregion

    # region Grafted Wargear
    public class GraftedWargearFD : MagicCard
    {
        public GraftedWargearFD()
        {
            Name = "Grafted Wargear";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +3/+2.;^Whenever Grafted Wargear becomes unattached from a permanent, sacrifice that permanent.;^Equip %0 @(%0: Attach to target creature you control. Equip only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Granulate
    public class GranulateFD : MagicCard
    {
        public GranulateFD()
        {
            Name = "Granulate";
            Edition = "FD";
            Rarity = "R";
            Color = "R";
            Cost = "2RR";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy each nonland artifact with converted mana cost 4 or less.";
            Flavor = "";
        }
    }
    # endregion

    # region Grinding Station
    public class GrindingStationFD : MagicCard
    {
        public GrindingStationFD()
        {
            Name = "Grinding Station";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%T, Sacrifice an artifact: Target player puts the top three cards of his or her library into his or her graveyard.;^Whenever an artifact enters the battlefield, you may untap Grinding Station.";
            Flavor = "";
        }
    }
    # endregion

    # region Guardian Idol
    public class GuardianIdolFD : MagicCard
    {
        public GuardianIdolFD()
        {
            Name = "Guardian Idol";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Guardian Idol enters the battlefield tapped.;^%T: Add %1 to your mana pool.;^%2: Guardian Idol becomes a 2/2 Golem artifact creature until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Healer's Headdress
    public class HealersHeaddressFD : MagicCard
    {
        public HealersHeaddressFD()
        {
            Name = "Healer's Headdress";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +0/+2 and has �%T: Prevent the next 1 damage that would be dealt to target creature or player this turn.�;^%W%W: Attach Healer�s Headdress to target creature you control.;^Equip %1 @(%1: Attach to target creature you control. Equip only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Heliophial
    public class HeliophialFD : MagicCard
    {
        public HeliophialFD()
        {
            Name = "Heliophial";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "Sunburst @(This enters the battlefield with a charge counter on it for each color of mana spent to cast it.)@;^%2, Sacrifice Heliophial: Heliophial deals damage equal to the number of charge counters on it to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Helm of Kaldra
    public class HelmofKaldraFD : MagicCard
    {
        public HelmofKaldraFD()
        {
            Name = "Helm of Kaldra";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Legendary Artifact - Equipment";
            Text = "Equipped creature has first strike, trample, and haste.;^%1: If you control Equipment named Helm of Kaldra, Sword of Kaldra, and Shield of Kaldra, put a legendary 4/4 colorless Avatar creature token named Kaldra onto the battlefield and attach those Equipment to it.;^Equip %2";
            Flavor = "";
        }
    }
    # endregion

    # region Horned Helm
    public class HornedHelmFD : MagicCard
    {
        public HornedHelmFD()
        {
            Name = "Horned Helm";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +1/+1 and has trample.;^%G%G: Attach Horned Helm to target creature you control.;^Equip %1 @(%1: Attach to target creature you control. Equip only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Hoverguard Sweepers
    public class HoverguardSweepersFD : MagicCard
    {
        public HoverguardSweepersFD()
        {
            Name = "Hoverguard Sweepers";
            Edition = "FD";
            Rarity = "R";
            Color = "U";
            Cost = "6UU";
            PT = "5/6";
            Type = "Creature - Drone";
            Text = "Flying;^When Hoverguard Sweepers enters the battlefield, you may return up to two target creatures to their owners� hands.";
            Flavor = "";
        }
    }
    # endregion

    # region Infused Arrows
    public class InfusedArrowsFD : MagicCard
    {
        public InfusedArrowsFD()
        {
            Name = "Infused Arrows";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "Sunburst @(This enters the battlefield with a charge counter on it for each color of mana spent to cast it.)@;^%T, Remove X charge counters from Infused Arrows: Target creature gets -X/-X until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Into Thin Air
    public class IntoThinAirFD : MagicCard
    {
        public IntoThinAirFD()
        {
            Name = "Into Thin Air";
            Edition = "FD";
            Rarity = "C";
            Color = "U";
            Cost = "5U";
            PT = "";
            Type = "Instant";
            Text = "Affinity for artifacts @(This spell costs %1 less to cast for each artifact you control.)@;^Return target artifact to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Ion Storm
    public class IonStormFD : MagicCard
    {
        public IonStormFD()
        {
            Name = "Ion Storm";
            Edition = "FD";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Enchantment";
            Text = "%1%R, Remove a +1/+1 counter or a charge counter from a permanent you control: Ion Storm deals 2 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Iron-Barb Hellion
    public class IronBarbHellionFD : MagicCard
    {
        public IronBarbHellionFD()
        {
            Name = "Iron-Barb Hellion";
            Edition = "FD";
            Rarity = "U";
            Color = "R";
            Cost = "5R";
            PT = "5/4";
            Type = "Creature - Hellion Beast";
            Text = "Haste;^Iron-Barb Hellion can�t block.";
            Flavor = "";
        }
    }
    # endregion

    # region Joiner Adept
    public class JoinerAdeptFD : MagicCard
    {
        public JoinerAdeptFD()
        {
            Name = "Joiner Adept";
            Edition = "FD";
            Rarity = "R";
            Color = "G";
            Cost = "1G";
            PT = "2/1";
            Type = "Creature - Elf Druid";
            Text = "Lands you control have �%T: Add one mana of any color to your mana pool.�";
            Flavor = "";
        }
    }
    # endregion

    # region Krark-Clan Engineers
    public class KrarkClanEngineersFD : MagicCard
    {
        public KrarkClanEngineersFD()
        {
            Name = "Krark-Clan Engineers";
            Edition = "FD";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "2/2";
            Type = "Creature - Goblin Artificer";
            Text = "%R, Sacrifice two artifacts: Destroy target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Krark-Clan Ironworks
    public class KrarkClanIronworksFD : MagicCard
    {
        public KrarkClanIronworksFD()
        {
            Name = "Krark-Clan Ironworks";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "Sacrifice an artifact: Add %2 to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Krark-Clan Ogre
    public class KrarkClanOgreFD : MagicCard
    {
        public KrarkClanOgreFD()
        {
            Name = "Krark-Clan Ogre";
            Edition = "FD";
            Rarity = "C";
            Color = "R";
            Cost = "3RR";
            PT = "3/3";
            Type = "Creature - Ogre";
            Text = "%R, Sacrifice an artifact: Target creature can�t block this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Lantern of Insight
    public class LanternofInsightFD : MagicCard
    {
        public LanternofInsightFD()
        {
            Name = "Lantern of Insight";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "Players play with the top card of their libraries revealed.;^%T, Sacrifice Lantern of Insight: Target player shuffles his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Leonin Squire
    public class LeoninSquireFD : MagicCard
    {
        public LeoninSquireFD()
        {
            Name = "Leonin Squire";
            Edition = "FD";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "2/2";
            Type = "Creature - Cat Soldier";
            Text = "When Leonin Squire enters the battlefield, return target artifact card with converted mana cost 1 or less from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Lose Hope
    public class LoseHopeFD : MagicCard
    {
        public LoseHopeFD()
        {
            Name = "Lose Hope";
            Edition = "FD";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets -1/-1 until end of turn.;^Scry 2. @(To scry 2, look at the top two cards of your library, then put any number of them on the bottom of your library and the rest on top in any order.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Loxodon Anchorite
    public class LoxodonAnchoriteFD : MagicCard
    {
        public LoxodonAnchoriteFD()
        {
            Name = "Loxodon Anchorite";
            Edition = "FD";
            Rarity = "C";
            Color = "W";
            Cost = "2WW";
            PT = "2/3";
            Type = "Creature - Elephant Cleric";
            Text = "%T: Prevent the next 2 damage that would be dealt to target creature or player this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Loxodon Stalwart
    public class LoxodonStalwartFD : MagicCard
    {
        public LoxodonStalwartFD()
        {
            Name = "Loxodon Stalwart";
            Edition = "FD";
            Rarity = "U";
            Color = "W";
            Cost = "3WW";
            PT = "3/3";
            Type = "Creature - Elephant Soldier";
            Text = "Vigilance;^%W: Loxodon Stalwart gets +0/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Lunar Avenger
    public class LunarAvengerFD : MagicCard
    {
        public LunarAvengerFD()
        {
            Name = "Lunar Avenger";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "7";
            PT = "2/2";
            Type = "Artifact Creature - Golem";
            Text = "Sunburst @(This enters the battlefield with a +1/+1 counter on it for each color of mana spent to cast it.)@;^Remove a +1/+1 counter from Lunar Avenger: Lunar Avenger gains your choice of flying, first strike, or haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Magma Giant
    public class MagmaGiantFD : MagicCard
    {
        public MagmaGiantFD()
        {
            Name = "Magma Giant";
            Edition = "FD";
            Rarity = "R";
            Color = "R";
            Cost = "5RR";
            PT = "5/5";
            Type = "Creature - Giant";
            Text = "When Magma Giant enters the battlefield, it deals 2 damage to each creature and each player.";
            Flavor = "";
        }
    }
    # endregion

    # region Magma Jet
    public class MagmaJetFD : MagicCard
    {
        public MagmaJetFD()
        {
            Name = "Magma Jet";
            Edition = "FD";
            Rarity = "U";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "Magma Jet deals 2 damage to target creature or player.;^Scry 2. @(To scry 2, look at the top two cards of your library, then put any number of them on the bottom of your library and the rest on top in any order.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Magnetic Theft
    public class MagneticTheftFD : MagicCard
    {
        public MagneticTheftFD()
        {
            Name = "Magnetic Theft";
            Edition = "FD";
            Rarity = "U";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Attach target Equipment to target creature. @(Control of the Equipment doesn�t change.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Mana Geyser
    public class ManaGeyserFD : MagicCard
    {
        public ManaGeyserFD()
        {
            Name = "Mana Geyser";
            Edition = "FD";
            Rarity = "C";
            Color = "R";
            Cost = "3RR";
            PT = "";
            Type = "Sorcery";
            Text = "Add %R to your mana pool for each tapped land your opponents control.";
            Flavor = "";
        }
    }
    # endregion

    # region Mephidross Vampire
    public class MephidrossVampireFD : MagicCard
    {
        public MephidrossVampireFD()
        {
            Name = "Mephidross Vampire";
            Edition = "FD";
            Rarity = "R";
            Color = "B";
            Cost = "4BB";
            PT = "3/4";
            Type = "Creature - Vampire";
            Text = "Flying;^Each creature you control is a Vampire in addition to its other creature types and has �Whenever this creature deals damage to a creature, put a +1/+1 counter on this creature.�";
            Flavor = "";
        }
    }
    # endregion

    # region Moriok Rigger
    public class MoriokRiggerFD : MagicCard
    {
        public MoriokRiggerFD()
        {
            Name = "Moriok Rigger";
            Edition = "FD";
            Rarity = "R";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Human Rogue Rigger";
            Text = "Whenever an artifact is put into a graveyard from the battlefield, you may put a +1/+1 counter on Moriok Rigger.";
            Flavor = "";
        }
    }
    # endregion

    # region Mycosynth Golem
    public class MycosynthGolemFD : MagicCard
    {
        public MycosynthGolemFD()
        {
            Name = "Mycosynth Golem";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "11";
            PT = "4/5";
            Type = "Artifact Creature - Golem";
            Text = "Affinity for artifacts @(This spell costs %1 less to cast for each artifact you control.)@;^Artifact creature spells you cast have affinity for artifacts. @(They cost %1 less to cast for each artifact you control.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Myr Quadropod
    public class MyrQuadropodFD : MagicCard
    {
        public MyrQuadropodFD()
        {
            Name = "Myr Quadropod";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "4";
            PT = "1/4";
            Type = "Artifact Creature - Myr";
            Text = "%3: Switch Myr Quadropod�s power and toughness until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Myr Servitor
    public class MyrServitorFD : MagicCard
    {
        public MyrServitorFD()
        {
            Name = "Myr Servitor";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "1/1";
            Type = "Artifact Creature - Myr";
            Text = "At the beginning of your upkeep, if Myr Servitor is on the battlefield, each player returns all cards named Myr Servitor from his or her graveyard to the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Neurok Stealthsuit
    public class NeurokStealthsuitFD : MagicCard
    {
        public NeurokStealthsuitFD()
        {
            Name = "Neurok Stealthsuit";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature has shroud. @(It can�t be the target of spells or abilities.)@;^%U%U: Attach Neurok Stealthsuit to target creature you control.;^Equip %1 @(%1: Attach to target creature you control. Equip only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Night's Whisper
    public class NightsWhisperFD : MagicCard
    {
        public NightsWhisperFD()
        {
            Name = "Night's Whisper";
            Edition = "FD";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Sorcery";
            Text = "You draw two cards and you lose 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Nim Grotesque
    public class NimGrotesqueFD : MagicCard
    {
        public NimGrotesqueFD()
        {
            Name = "Nim Grotesque";
            Edition = "FD";
            Rarity = "U";
            Color = "B";
            Cost = "6B";
            PT = "3/6";
            Type = "Creature - Zombie";
            Text = "Nim Grotesque gets +1/+0 for each artifact you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Opaline Bracers
    public class OpalineBracersFD : MagicCard
    {
        public OpalineBracersFD()
        {
            Name = "Opaline Bracers";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Sunburst @(This enters the battlefield with a charge counter on it for each color of mana spent to cast it.)@;^Equipped creature gets +X/+X, where X is the number of charge counters on Opaline Bracers.;^Equip %2 @(%2: Attach to target creature you control. Equip only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Ouphe Vandals
    public class OupheVandalsFD : MagicCard
    {
        public OupheVandalsFD()
        {
            Name = "Ouphe Vandals";
            Edition = "FD";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Ouphe Rogue";
            Text = "%G, Sacrifice Ouphe Vandals: Counter target activated ability from an artifact source and destroy that artifact if it�s on the battlefield. @(Mana abilities can�t be targeted.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Paradise Mantle
    public class ParadiseMantleFD : MagicCard
    {
        public ParadiseMantleFD()
        {
            Name = "Paradise Mantle";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "0";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature has �%T: Add one mana of any color to your mana pool.�;^Equip %1";
            Flavor = "";
        }
    }
    # endregion

    # region Pentad Prism
    public class PentadPrismFD : MagicCard
    {
        public PentadPrismFD()
        {
            Name = "Pentad Prism";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Sunburst @(This enters the battlefield with a charge counter on it for each color of mana spent to cast it.)@;^Remove a charge counter from Pentad Prism: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Plasma Elemental
    public class PlasmaElementalFD : MagicCard
    {
        public PlasmaElementalFD()
        {
            Name = "Plasma Elemental";
            Edition = "FD";
            Rarity = "U";
            Color = "U";
            Cost = "5U";
            PT = "4/1";
            Type = "Creature - Elemental";
            Text = "Plasma Elemental can�t be blocked.";
            Flavor = "";
        }
    }
    # endregion

    # region Plunge into Darkness
    public class PlungeintoDarknessFD : MagicCard
    {
        public PlungeintoDarknessFD()
        {
            Name = "Plunge into Darkness";
            Edition = "FD";
            Rarity = "R";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Sacrifice any number of creatures, then you gain 3 life for each sacrificed creature; or pay X life, then look at the top X cards of your library, put one of those cards into your hand, and exile the rest.;^Entwine %B @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Possessed Portal
    public class PossessedPortalFD : MagicCard
    {
        public PossessedPortalFD()
        {
            Name = "Possessed Portal";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "8";
            PT = "";
            Type = "Artifact";
            Text = "If a player would draw a card, that player skips that draw instead.;^At the beginning of each end step, each player sacrifices a permanent unless he or she discards a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Qumulox
    public class QumuloxFD : MagicCard
    {
        public QumuloxFD()
        {
            Name = "Qumulox";
            Edition = "FD";
            Rarity = "U";
            Color = "U";
            Cost = "6UU";
            PT = "5/4";
            Type = "Creature - Beast";
            Text = "Affinity for artifacts @(This spell costs %1 less to cast for each artifact you control.)@;^Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Rain of Rust
    public class RainofRustFD : MagicCard
    {
        public RainofRustFD()
        {
            Name = "Rain of Rust";
            Edition = "FD";
            Rarity = "C";
            Color = "R";
            Cost = "3RR";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Destroy target artifact; or destroy target land.;^Entwine %3%R @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Raksha Golden Cub
    public class RakshaGoldenCubFD : MagicCard
    {
        public RakshaGoldenCubFD()
        {
            Name = "Raksha Golden Cub";
            Edition = "FD";
            Rarity = "R";
            Color = "W";
            Cost = "5WW";
            PT = "3/4";
            Type = "Legendary Creature - Cat Soldier";
            Text = "Vigilance;^As long as Raksha Golden Cub is equipped, Cat creatures you control get +2/+2 and have double strike.";
            Flavor = "";
        }
    }
    # endregion

    # region Razorgrass Screen
    public class RazorgrassScreenFD : MagicCard
    {
        public RazorgrassScreenFD()
        {
            Name = "Razorgrass Screen";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "2/1";
            Type = "Artifact Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@;^Razorgrass Screen blocks each turn if able.";
            Flavor = "";
        }
    }
    # endregion

    # region Razormane Masticore
    public class RazormaneMasticoreFD : MagicCard
    {
        public RazormaneMasticoreFD()
        {
            Name = "Razormane Masticore";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "5/5";
            Type = "Artifact Creature - Masticore";
            Text = "First strike @(This creature deals combat damage before creatures without first strike.)@;^At the beginning of your upkeep, sacrifice Razormane Masticore unless you discard a card.;^At the beginning of your draw step, you may have Razormane Masticore deal 3 damage to target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Relentless Rats
    public class RelentlessRatsFD : MagicCard
    {
        public RelentlessRatsFD()
        {
            Name = "Relentless Rats";
            Edition = "FD";
            Rarity = "U";
            Color = "B";
            Cost = "1BB";
            PT = "2/2";
            Type = "Creature - Rat";
            Text = "Relentless Rats gets +1/+1 for each other creature on the battlefield named Relentless Rats.;^A deck can have any number of cards named Relentless Rats.";
            Flavor = "";
        }
    }
    # endregion

    # region Relic Barrier
    public class RelicBarrierFD : MagicCard
    {
        public RelicBarrierFD()
        {
            Name = "Relic Barrier";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%T: Tap target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Retaliate
    public class RetaliateFD : MagicCard
    {
        public RetaliateFD()
        {
            Name = "Retaliate";
            Edition = "FD";
            Rarity = "R";
            Color = "W";
            Cost = "2WW";
            PT = "";
            Type = "Instant";
            Text = "Destroy all creatures that dealt damage to you this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Reversal of Fortune
    public class ReversalofFortuneFD : MagicCard
    {
        public ReversalofFortuneFD()
        {
            Name = "Reversal of Fortune";
            Edition = "FD";
            Rarity = "R";
            Color = "R";
            Cost = "4RR";
            PT = "";
            Type = "Sorcery";
            Text = "Target opponent reveals his or her hand. You may copy an instant or sorcery card in it. If you do, you may cast the copy without paying its mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Rite of Passage
    public class RiteofPassageFD : MagicCard
    {
        public RiteofPassageFD()
        {
            Name = "Rite of Passage";
            Edition = "FD";
            Rarity = "R";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a creature you control is dealt damage, put a +1/+1 counter on it. @(The damage is dealt before the counter is put on.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Roar of Reclamation
    public class RoarofReclamationFD : MagicCard
    {
        public RoarofReclamationFD()
        {
            Name = "Roar of Reclamation";
            Edition = "FD";
            Rarity = "R";
            Color = "W";
            Cost = "5WW";
            PT = "";
            Type = "Sorcery";
            Text = "Each player returns all artifact cards from his or her graveyard to the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Rude Awakening
    public class RudeAwakeningFD : MagicCard
    {
        public RudeAwakeningFD()
        {
            Name = "Rude Awakening";
            Edition = "FD";
            Rarity = "R";
            Color = "G";
            Cost = "4G";
            PT = "";
            Type = "Sorcery";
            Text = "Choose one � Untap all lands you control; or until end of turn, lands you control become 2/2 creatures that are still lands.;^Entwine %2%G @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Salvaging Station
    public class SalvagingStationFD : MagicCard
    {
        public SalvagingStationFD()
        {
            Name = "Salvaging Station";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "6";
            PT = "";
            Type = "Artifact";
            Text = "%T: Return target noncreature artifact card with converted mana cost 1 or less from your graveyard to the battlefield.;^Whenever a creature dies, you may untap Salvaging Station.";
            Flavor = "";
        }
    }
    # endregion

    # region Sawtooth Thresher
    public class SawtoothThresherFD : MagicCard
    {
        public SawtoothThresherFD()
        {
            Name = "Sawtooth Thresher";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "6";
            PT = "1/1";
            Type = "Artifact Creature - Construct";
            Text = "Sunburst @(This enters the battlefield with a +1/+1 counter on it for each color of mana spent to cast it.)@;^Remove two +1/+1 counters from Sawtooth Thresher: Sawtooth Thresher gets +4/+4 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Screaming Fury
    public class ScreamingFuryFD : MagicCard
    {
        public ScreamingFuryFD()
        {
            Name = "Screaming Fury";
            Edition = "FD";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Sorcery";
            Text = "Target creature gets +5/+0 and gains haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Serum Visions
    public class SerumVisionsFD : MagicCard
    {
        public SerumVisionsFD()
        {
            Name = "Serum Visions";
            Edition = "FD";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Sorcery";
            Text = "Draw a card.;^Scry 2. @(To scry 2, look at the top two cards of your library, then put any number of them on the bottom of your library and the rest on top in any order.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Shattered Dreams
    public class ShatteredDreamsFD : MagicCard
    {
        public ShatteredDreamsFD()
        {
            Name = "Shattered Dreams";
            Edition = "FD";
            Rarity = "U";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Sorcery";
            Text = "Target opponent reveals his or her hand. You choose an artifact card from it. That player discards that card.";
            Flavor = "";
        }
    }
    # endregion

    # region Silent Arbiter
    public class SilentArbiterFD : MagicCard
    {
        public SilentArbiterFD()
        {
            Name = "Silent Arbiter";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "1/5";
            Type = "Artifact Creature - Construct";
            Text = "No more than one creature can attack each combat.;^No more than one creature can block each combat.";
            Flavor = "";
        }
    }
    # endregion

    # region Skullcage
    public class SkullcageFD : MagicCard
    {
        public SkullcageFD()
        {
            Name = "Skullcage";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of each opponent�s upkeep, Skullcage deals 2 damage to that player unless he or she has exactly three or exactly four cards in hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Skyhunter Prowler
    public class SkyhunterProwlerFD : MagicCard
    {
        public SkyhunterProwlerFD()
        {
            Name = "Skyhunter Prowler";
            Edition = "FD";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "1/3";
            Type = "Creature - Cat Knight";
            Text = "Flying, vigilance @(This creature can�t be blocked except by creatures with flying or reach, and attacking doesn�t cause this creature to tap.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Skyhunter Skirmisher
    public class SkyhunterSkirmisherFD : MagicCard
    {
        public SkyhunterSkirmisherFD()
        {
            Name = "Skyhunter Skirmisher";
            Edition = "FD";
            Rarity = "U";
            Color = "W";
            Cost = "1WW";
            PT = "1/1";
            Type = "Creature - Cat Knight";
            Text = "Flying, double strike @(This creature can�t be blocked except by creatures with flying or reach, and it deals both first-strike and regular combat damage.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Skyreach Manta
    public class SkyreachMantaFD : MagicCard
    {
        public SkyreachMantaFD()
        {
            Name = "Skyreach Manta";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "5";
            PT = "0/0";
            Type = "Artifact Creature - Fish";
            Text = "Sunburst @(This enters the battlefield with a +1/+1 counter on it for each color of mana spent to cast it.)@;^Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Solarion
    public class SolarionFD : MagicCard
    {
        public SolarionFD()
        {
            Name = "Solarion";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "7";
            PT = "0/0";
            Type = "Artifact Creature - Construct";
            Text = "Sunburst @(This enters the battlefield with a +1/+1 counter on it for each color of mana spent to cast it.)@;^%T: Double the number of +1/+1 counters on Solarion.";
            Flavor = "";
        }
    }
    # endregion

    # region Spark Elemental
    public class SparkElementalFD : MagicCard
    {
        public SparkElementalFD()
        {
            Name = "Spark Elemental";
            Edition = "FD";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "3/1";
            Type = "Creature - Elemental";
            Text = "Trample, haste @(If this creature would assign enough damage to its blockers to destroy them, you may have it assign the rest of its damage to defending player or planeswalker. This creature can attack and %T as soon as it comes under your control.)@;^At the beginning of the end step, sacrifice Spark Elemental.";
            Flavor = "";
        }
    }
    # endregion

    # region Sparring Collar
    public class SparringCollarFD : MagicCard
    {
        public SparringCollarFD()
        {
            Name = "Sparring Collar";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature has first strike.;^%R%R: Attach Sparring Collar to target creature you control.;^Equip %1 @(%1: Attach to target creature you control. Equip only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Spectral Shift
    public class SpectralShiftFD : MagicCard
    {
        public SpectralShiftFD()
        {
            Name = "Spectral Shift";
            Edition = "FD";
            Rarity = "R";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Change the text of target spell or permanent by replacing all instances of one basic land type with another; or change the text of target spell or permanent by replacing all instances of one color word with another. @(These effects last indefinitely.)@;^Entwine %2 @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Spinal Parasite
    public class SpinalParasiteFD : MagicCard
    {
        public SpinalParasiteFD()
        {
            Name = "Spinal Parasite";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "5";
            PT = "-1/-1";
            Type = "Artifact Creature - Insect";
            Text = "Sunburst @(This enters the battlefield with a +1/+1 counter on it for each color of mana spent to cast it.)@;^Remove two +1/+1 counters from Spinal Parasite: Remove a counter from target permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Staff of Domination
    public class StaffofDominationFD : MagicCard
    {
        public StaffofDominationFD()
        {
            Name = "Staff of Domination";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%1: Untap Staff of Domination.;^%2, %T: You gain 1 life.;^%3, %T: Untap target creature.;^%4, %T: Tap target creature.;^%5, %T: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Stand Firm
    public class StandFirmFD : MagicCard
    {
        public StandFirmFD()
        {
            Name = "Stand Firm";
            Edition = "FD";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +1/+1 until end of turn.;^Scry 2. @(To scry 2, look at the top two cards of your library, then put any number of them on the bottom of your library and the rest on top in any order.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Stasis Cocoon
    public class StasisCocoonFD : MagicCard
    {
        public StasisCocoonFD()
        {
            Name = "Stasis Cocoon";
            Edition = "FD";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant artifact;^Enchanted artifact�s activated abilities can�t be activated. If enchanted artifact is a creature, it can�t attack or block.";
            Flavor = "";
        }
    }
    # endregion

    # region Steelshaper's Gift
    public class SteelshapersGiftFD : MagicCard
    {
        public SteelshapersGiftFD()
        {
            Name = "Steelshaper's Gift";
            Edition = "FD";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Sorcery";
            Text = "Search your library for an Equipment card, reveal that card, and put it into your hand. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Summoner's Egg
    public class SummonersEggFD : MagicCard
    {
        public SummonersEggFD()
        {
            Name = "Summoner's Egg";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "0/4";
            Type = "Artifact Creature - Construct";
            Text = "@Imprint@ � When Summoner�s Egg enters the battlefield, you may exile a card from your hand face down.;^When Summoner�s Egg dies, turn the exiled card face up. If it�s a creature card, put it onto the battlefield under your control.";
            Flavor = "";
        }
    }
    # endregion

    # region Summoning Station
    public class SummoningStationFD : MagicCard
    {
        public SummoningStationFD()
        {
            Name = "Summoning Station";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "7";
            PT = "";
            Type = "Artifact";
            Text = "%T: Put a 2/2 colorless Pincher creature token onto the battlefield.;^Whenever an artifact is put into a graveyard from the battlefield, you may untap Summoning Station.";
            Flavor = "";
        }
    }
    # endregion

    # region Suncrusher
    public class SuncrusherFD : MagicCard
    {
        public SuncrusherFD()
        {
            Name = "Suncrusher";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "9";
            PT = "3/3";
            Type = "Artifact Creature - Construct";
            Text = "Sunburst @(This enters the battlefield with a +1/+1 counter on it for each color of mana spent to cast it.)@;^%4, %T, Remove a +1/+1 counter from Suncrusher: Destroy target creature.;^%2, Remove a +1/+1 counter from Suncrusher: Return Suncrusher to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Suntouched Myr
    public class SuntouchedMyrFD : MagicCard
    {
        public SuntouchedMyrFD()
        {
            Name = "Suntouched Myr";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "0/0";
            Type = "Artifact Creature - Myr";
            Text = "Sunburst @(This enters the battlefield with a +1/+1 counter on it for each color of mana spent to cast it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Sylvok Explorer
    public class SylvokExplorerFD : MagicCard
    {
        public SylvokExplorerFD()
        {
            Name = "Sylvok Explorer";
            Edition = "FD";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "1/1";
            Type = "Creature - Human Druid";
            Text = "%T: Add to your mana pool one mana of any color that a land an opponent controls could produce.";
            Flavor = "";
        }
    }
    # endregion

    # region Synod Centurion
    public class SynodCenturionFD : MagicCard
    {
        public SynodCenturionFD()
        {
            Name = "Synod Centurion";
            Edition = "FD";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "4/4";
            Type = "Artifact Creature - Construct";
            Text = "When you control no other artifacts, sacrifice Synod Centurion.";
            Flavor = "";
        }
    }
    # endregion

    # region Tangle Asp
    public class TangleAspFD : MagicCard
    {
        public TangleAspFD()
        {
            Name = "Tangle Asp";
            Edition = "FD";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "1/2";
            Type = "Creature - Snake";
            Text = "Whenever Tangle Asp blocks or becomes blocked by a creature, destroy that creature at end of combat.";
            Flavor = "";
        }
    }
    # endregion

    # region Tel-Jilad Justice
    public class TelJiladJusticeFD : MagicCard
    {
        public TelJiladJusticeFD()
        {
            Name = "Tel-Jilad Justice";
            Edition = "FD";
            Rarity = "U";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Destroy target artifact.;^Scry 2. @(To scry 2, look at the top two cards of your library, then put any number of them on the bottom of your library and the rest on top in any order.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Tel-Jilad Lifebreather
    public class TelJiladLifebreatherFD : MagicCard
    {
        public TelJiladLifebreatherFD()
        {
            Name = "Tel-Jilad Lifebreather";
            Edition = "FD";
            Rarity = "C";
            Color = "G";
            Cost = "4G";
            PT = "3/2";
            Type = "Creature - Troll Shaman";
            Text = "%G, %T, Sacrifice a Forest: Regenerate target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Thermal Navigator
    public class ThermalNavigatorFD : MagicCard
    {
        public ThermalNavigatorFD()
        {
            Name = "Thermal Navigator";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "2/2";
            Type = "Artifact Creature - Construct";
            Text = "Sacrifice an artifact: Thermal Navigator gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Thought Courier
    public class ThoughtCourierFD : MagicCard
    {
        public ThoughtCourierFD()
        {
            Name = "Thought Courier";
            Edition = "FD";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Human Wizard";
            Text = "%T: Draw a card, then discard a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Tornado Elemental
    public class TornadoElementalFD : MagicCard
    {
        public TornadoElementalFD()
        {
            Name = "Tornado Elemental";
            Edition = "FD";
            Rarity = "R";
            Color = "G";
            Cost = "5GG";
            PT = "6/6";
            Type = "Creature - Elemental";
            Text = "When Tornado Elemental enters the battlefield, it deals 6 damage to each creature with flying.;^You may have Tornado Elemental assign its combat damage as though it weren�t blocked.";
            Flavor = "";
        }
    }
    # endregion

    # region Trinket Mage
    public class TrinketMageFD : MagicCard
    {
        public TrinketMageFD()
        {
            Name = "Trinket Mage";
            Edition = "FD";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "2/2";
            Type = "Creature - Human Wizard";
            Text = "When Trinket Mage enters the battlefield, you may search your library for an artifact card with converted mana cost 1 or less, reveal that card, and put it into your hand. If you do, shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Tyrranax
    public class TyrranaxFD : MagicCard
    {
        public TyrranaxFD()
        {
            Name = "Tyrranax";
            Edition = "FD";
            Rarity = "C";
            Color = "G";
            Cost = "4GG";
            PT = "5/4";
            Type = "Creature - Beast";
            Text = "%1%G: Tyrranax gets -1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Vanquish
    public class VanquishFD : MagicCard
    {
        public VanquishFD()
        {
            Name = "Vanquish";
            Edition = "FD";
            Rarity = "U";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Instant";
            Text = "Destroy target blocking creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Vedalken Mastermind
    public class VedalkenMastermindFD : MagicCard
    {
        public VedalkenMastermindFD()
        {
            Name = "Vedalken Mastermind";
            Edition = "FD";
            Rarity = "U";
            Color = "U";
            Cost = "UU";
            PT = "1/2";
            Type = "Creature - Vedalken Wizard";
            Text = "%U, %T: Return target permanent you control to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Vedalken Orrery
    public class VedalkenOrreryFD : MagicCard
    {
        public VedalkenOrreryFD()
        {
            Name = "Vedalken Orrery";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "You may cast nonland cards as though they had flash.";
            Flavor = "";
        }
    }
    # endregion

    # region Vedalken Shackles
    public class VedalkenShacklesFD : MagicCard
    {
        public VedalkenShacklesFD()
        {
            Name = "Vedalken Shackles";
            Edition = "FD";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "You may choose not to untap Vedalken Shackles during your untap step.;^%2, %T: Gain control of target creature with power less than or equal to the number of Islands you control for as long as Vedalken Shackles remains tapped.";
            Flavor = "";
        }
    }
    # endregion

    # region Vicious Betrayal
    public class ViciousBetrayalFD : MagicCard
    {
        public ViciousBetrayalFD()
        {
            Name = "Vicious Betrayal";
            Edition = "FD";
            Rarity = "C";
            Color = "B";
            Cost = "3BB";
            PT = "";
            Type = "Sorcery";
            Text = "As an additional cost to cast Vicious Betrayal, sacrifice any number of creatures.;^Target creature gets +2/+2 until end of turn for each creature sacrificed this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Viridian Lorebearers
    public class ViridianLorebearersFD : MagicCard
    {
        public ViridianLorebearersFD()
        {
            Name = "Viridian Lorebearers";
            Edition = "FD";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "3/3";
            Type = "Creature - Elf Shaman";
            Text = "%3%G, %T: Target creature gets +X/+X until end of turn, where X is the number of artifacts your opponents control.";
            Flavor = "";
        }
    }
    # endregion

    # region Viridian Scout
    public class ViridianScoutFD : MagicCard
    {
        public ViridianScoutFD()
        {
            Name = "Viridian Scout";
            Edition = "FD";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "1/2";
            Type = "Creature - Elf Warrior Scout";
            Text = "%2%G, Sacrifice Viridian Scout: Viridian Scout deals 2 damage to target creature with flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Vulshok Sorcerer
    public class VulshokSorcererFD : MagicCard
    {
        public VulshokSorcererFD()
        {
            Name = "Vulshok Sorcerer";
            Edition = "FD";
            Rarity = "C";
            Color = "R";
            Cost = "1RR";
            PT = "1/1";
            Type = "Creature - Human Shaman";
            Text = "Haste;^%T: Vulshok Sorcerer deals 1 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Wayfarer's Bauble
    public class WayfarersBaubleFD : MagicCard
    {
        public WayfarersBaubleFD()
        {
            Name = "Wayfarer's Bauble";
            Edition = "FD";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T, Sacrifice Wayfarer�s Bauble: Search your library for a basic land card and put that card onto the battlefield tapped. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion


}
