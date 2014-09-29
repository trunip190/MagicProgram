using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
    # region Mirrodin
    # region AEther Spellbomb
    public class AEtherSpellbombMR : MagicCard
    {
        public AEtherSpellbombMR()
        {
            Name = "AEther Spellbomb";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%U, Sacrifice AEther Spellbomb: Return target creature to its owner�s hand.;^%1, Sacrifice AEther Spellbomb: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Alpha Myr
    public class AlphaMyrMR : MagicCard
    {
        public AlphaMyrMR()
        {
            Name = "Alpha Myr";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "2/1";
            Type = "Artifact Creature - Myr";
            Text = "";
            Flavor = "First to charge, first to fight.";
        }
    }
    # endregion

    # region Altar of Shadows
    public class AltarofShadowsMR : MagicCard
    {
        public AltarofShadowsMR()
        {
            Name = "Altar of Shadows";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "7";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of your precombat main phase, add %B to your mana pool for each charge counter on Altar of Shadows.;^%7, %T: Destroy target creature. Then put a charge counter on Altar of Shadows.";
            Flavor = "";
        }
    }
    # endregion

    # region Altar's Light
    public class AltarsLightMR : MagicCard
    {
        public AltarsLightMR()
        {
            Name = "Altar's Light";
            Edition = "MR";
            Rarity = "U";
            Color = "W";
            Cost = "2WW";
            PT = "";
            Type = "Instant";
            Text = "Exile target artifact or enchantment.";
            Flavor = "";
        }
    }
    # endregion

    # region Ancient Den
    public class AncientDenMR : MagicCard
    {
        public AncientDenMR()
        {
            Name = "Ancient Den";
            Edition = "MR";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Artifact Land";
            Text = "@(Ancient Den isn�t a spell.)@;^%T: Add %W to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Annul
    public class AnnulMR : MagicCard
    {
        public AnnulMR()
        {
            Name = "Annul";
            Edition = "MR";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Counter target artifact or enchantment spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Arc-Slogger
    public class ArcSloggerMR : MagicCard
    {
        public ArcSloggerMR()
        {
            Name = "Arc-Slogger";
            Edition = "MR";
            Rarity = "R";
            Color = "R";
            Cost = "3RR";
            PT = "4/5";
            Type = "Creature - Beast";
            Text = "%R, Exile the top ten cards of your library: Arc-Slogger deals 2 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Arrest
    public class ArrestMR : MagicCard
    {
        public ArrestMR()
        {
            Name = "Arrest";
            Edition = "MR";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature can�t attack or block, and its activated abilities can�t be activated.";
            Flavor = "";
        }
    }
    # endregion

    # region Assert Authority
    public class AssertAuthorityMR : MagicCard
    {
        public AssertAuthorityMR()
        {
            Name = "Assert Authority";
            Edition = "MR";
            Rarity = "U";
            Color = "U";
            Cost = "5UU";
            PT = "";
            Type = "Instant";
            Text = "Affinity for artifacts @(This spell costs %1 less to cast for each artifact you control.)@;^Counter target spell. If that spell is countered this way, exile it instead of putting it into its owner�s graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Atog
    public class AtogMR : MagicCard
    {
        public AtogMR()
        {
            Name = "Atog";
            Edition = "MR";
            Rarity = "U";
            Color = "R";
            Cost = "1R";
            PT = "1/2";
            Type = "Creature - Atog";
            Text = "Sacrifice an artifact: Atog gets +2/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Auriok Bladewarden
    public class AuriokBladewardenMR : MagicCard
    {
        public AuriokBladewardenMR()
        {
            Name = "Auriok Bladewarden";
            Edition = "MR";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "1/1";
            Type = "Creature - Human Soldier";
            Text = "%T: Target creature gets +X/+X until end of turn, where X is Auriok Bladewarden�s power.";
            Flavor = "";
        }
    }
    # endregion

    # region Auriok Steelshaper
    public class AuriokSteelshaperMR : MagicCard
    {
        public AuriokSteelshaperMR()
        {
            Name = "Auriok Steelshaper";
            Edition = "MR";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "1/1";
            Type = "Creature - Human Soldier";
            Text = "Equip costs you pay cost %1 less.;^As long as Auriok Steelshaper is equipped, each creature you control that�s a Soldier or a Knight gets +1/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Auriok Transfixer
    public class AuriokTransfixerMR : MagicCard
    {
        public AuriokTransfixerMR()
        {
            Name = "Auriok Transfixer";
            Edition = "MR";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Human Scout";
            Text = "%W, %T: Tap target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Awe Strike
    public class AweStrikeMR : MagicCard
    {
        public AweStrikeMR()
        {
            Name = "Awe Strike";
            Edition = "MR";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "The next time target creature would deal damage this turn, prevent that damage. You gain life equal to the damage prevented this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Banshee's Blade
    public class BansheesBladeMR : MagicCard
    {
        public BansheesBladeMR()
        {
            Name = "Banshee's Blade";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +1/+1 for each charge counter on Banshee�s Blade.;^Whenever equipped creature deals combat damage, put a charge counter on Banshee�s Blade.;^Equip %2 @(%2: Attach to target creature you control. Equip only as a sorcery. This card enters the battlefield unattached and stays on the battlefield if the creature leaves.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Barter in Blood
    public class BarterinBloodMR : MagicCard
    {
        public BarterinBloodMR()
        {
            Name = "Barter in Blood";
            Edition = "MR";
            Rarity = "U";
            Color = "B";
            Cost = "2BB";
            PT = "";
            Type = "Sorcery";
            Text = "Each player sacrifices two creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Battlegrowth
    public class BattlegrowthMR : MagicCard
    {
        public BattlegrowthMR()
        {
            Name = "Battlegrowth";
            Edition = "MR";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Put a +1/+1 counter on target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Betrayal of Flesh
    public class BetrayalofFleshMR : MagicCard
    {
        public BetrayalofFleshMR()
        {
            Name = "Betrayal of Flesh";
            Edition = "MR";
            Rarity = "U";
            Color = "B";
            Cost = "5B";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Destroy target creature; or return target creature card from your graveyard to the battlefield.;^Entwine�Sacrifice three lands. @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Blinding Beam
    public class BlindingBeamMR : MagicCard
    {
        public BlindingBeamMR()
        {
            Name = "Blinding Beam";
            Edition = "MR";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Tap two target creatures; or creatures don�t untap during target player�s next untap step.;^Entwine %1 @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Blinkmoth Urn
    public class BlinkmothUrnMR : MagicCard
    {
        public BlinkmothUrnMR()
        {
            Name = "Blinkmoth Urn";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of each player�s precombat main phase, if Blinkmoth Urn is untapped, that player adds %1 to his or her mana pool for each artifact he or she controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Blinkmoth Well
    public class BlinkmothWellMR : MagicCard
    {
        public BlinkmothWellMR()
        {
            Name = "Blinkmoth Well";
            Edition = "MR";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%2, %T: Tap target noncreature artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Bloodscent
    public class BloodscentMR : MagicCard
    {
        public BloodscentMR()
        {
            Name = "Bloodscent";
            Edition = "MR";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Instant";
            Text = "All creatures able to block target creature this turn do so.";
            Flavor = "";
        }
    }
    # endregion

    # region Bonesplitter
    public class BonesplitterMR : MagicCard
    {
        public BonesplitterMR()
        {
            Name = "Bonesplitter";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +2/+0.;^Equip %1";
            Flavor = "";
        }
    }
    # endregion

    # region Bosh, Iron Golem
    public class BoshIronGolemMR : MagicCard
    {
        public BoshIronGolemMR()
        {
            Name = "Bosh, Iron Golem";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "8";
            PT = "6/7";
            Type = "Legendary Artifact Creature - Golem";
            Text = "Trample;^%3%R, Sacrifice an artifact: Bosh, Iron Golem deals damage equal to the sacrificed artifact�s converted mana cost to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Bottle Gnomes
    public class BottleGnomesMR : MagicCard
    {
        public BottleGnomesMR()
        {
            Name = "Bottle Gnomes";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "1/3";
            Type = "Artifact Creature - Gnome";
            Text = "Sacrifice Bottle Gnomes: You gain 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Broodstar
    public class BroodstarMR : MagicCard
    {
        public BroodstarMR()
        {
            Name = "Broodstar";
            Edition = "MR";
            Rarity = "R";
            Color = "U";
            Cost = "8UU";
            PT = "*/*";
            Type = "Creature - Beast";
            Text = "Affinity for artifacts @(This spell costs %1 less to cast for each artifact you control.)@;^Flying;^Broodstar�s power and toughness are each equal to the number of artifacts you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Brown Ouphe
    public class BrownOupheMR : MagicCard
    {
        public BrownOupheMR()
        {
            Name = "Brown Ouphe";
            Edition = "MR";
            Rarity = "U";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Ouphe";
            Text = "%1%G, %T: Counter target activated ability from an artifact source. @(Mana abilities can�t be targeted.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Cathodion
    public class CathodionMR : MagicCard
    {
        public CathodionMR()
        {
            Name = "Cathodion";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "3/3";
            Type = "Artifact Creature - Construct";
            Text = "When Cathodion dies, add %3 to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Chalice of the Void
    public class ChaliceoftheVoidMR : MagicCard
    {
        public ChaliceoftheVoidMR()
        {
            Name = "Chalice of the Void";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "XX";
            PT = "";
            Type = "Artifact";
            Text = "Chalice of the Void enters the battlefield with X charge counters on it.;^Whenever a player casts a spell with converted mana cost equal to the number of charge counters on Chalice of the Void, counter that spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Chimney Imp
    public class ChimneyImpMR : MagicCard
    {
        public ChimneyImpMR()
        {
            Name = "Chimney Imp";
            Edition = "MR";
            Rarity = "C";
            Color = "B";
            Cost = "4B";
            PT = "1/2";
            Type = "Creature - Imp";
            Text = "Flying;^When Chimney Imp dies, target opponent puts a card from his or her hand on top of his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Chromatic Sphere
    public class ChromaticSphereMR : MagicCard
    {
        public ChromaticSphereMR()
        {
            Name = "Chromatic Sphere";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%1, %T, Sacrifice Chromatic Sphere: Add one mana of any color to your mana pool. Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Chrome Mox
    public class ChromeMoxMR : MagicCard
    {
        public ChromeMoxMR()
        {
            Name = "Chrome Mox";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "0";
            PT = "";
            Type = "Artifact";
            Text = "@Imprint@ � When Chrome Mox enters the battlefield, you may exile a nonartifact, nonland card from your hand.;^%T: Add one mana of any of the exiled card�s colors to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Clockwork Beetle
    public class ClockworkBeetleMR : MagicCard
    {
        public ClockworkBeetleMR()
        {
            Name = "Clockwork Beetle";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "0/0";
            Type = "Artifact Creature - Insect";
            Text = "Clockwork Beetle enters the battlefield with two +1/+1 counters on it.;^Whenever Clockwork Beetle attacks or blocks, remove a +1/+1 counter from it at end of combat.";
            Flavor = "";
        }
    }
    # endregion

    # region Clockwork Condor
    public class ClockworkCondorMR : MagicCard
    {
        public ClockworkCondorMR()
        {
            Name = "Clockwork Condor";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "4";
            PT = "0/0";
            Type = "Artifact Creature - Bird";
            Text = "Flying;^Clockwork Condor enters the battlefield with three +1/+1 counters on it.;^Whenever Clockwork Condor attacks or blocks, remove a +1/+1 counter from it at end of combat.";
            Flavor = "";
        }
    }
    # endregion

    # region Clockwork Dragon
    public class ClockworkDragonMR : MagicCard
    {
        public ClockworkDragonMR()
        {
            Name = "Clockwork Dragon";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "7";
            PT = "0/0";
            Type = "Artifact Creature - Dragon";
            Text = "Flying;^Clockwork Dragon enters the battlefield with six +1/+1 counters on it.;^Whenever Clockwork Dragon attacks or blocks, remove a +1/+1 counter from it at end of combat.;^%3: Put a +1/+1 counter on Clockwork Dragon.";
            Flavor = "";
        }
    }
    # endregion

    # region Clockwork Vorrac
    public class ClockworkVorracMR : MagicCard
    {
        public ClockworkVorracMR()
        {
            Name = "Clockwork Vorrac";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "5";
            PT = "0/0";
            Type = "Artifact Creature - Boar Beast";
            Text = "Trample;^Clockwork Vorrac enters the battlefield with four +1/+1 counters on it.;^Whenever Clockwork Vorrac attacks or blocks, remove a +1/+1 counter from it at end of combat.;^%T: Put a +1/+1 counter on Clockwork Vorrac.";
            Flavor = "";
        }
    }
    # endregion

    # region Cloudpost
    public class CloudpostMR : MagicCard
    {
        public CloudpostMR()
        {
            Name = "Cloudpost";
            Edition = "MR";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Locus";
            Text = "Cloudpost enters the battlefield tapped.;^%T: Add %1 to your mana pool for each Locus on the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Cobalt Golem
    public class CobaltGolemMR : MagicCard
    {
        public CobaltGolemMR()
        {
            Name = "Cobalt Golem";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "4";
            PT = "2/3";
            Type = "Artifact Creature - Golem";
            Text = "%1%U: Cobalt Golem gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Confusion in the Ranks
    public class ConfusionintheRanksMR : MagicCard
    {
        public ConfusionintheRanksMR()
        {
            Name = "Confusion in the Ranks";
            Edition = "MR";
            Rarity = "R";
            Color = "R";
            Cost = "3RR";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever an artifact, creature, or enchantment enters the battlefield, its controller chooses target permanent another player controls that shares a card type with it. Exchange control of those permanents.";
            Flavor = "";
        }
    }
    # endregion

    # region Consume Spirit
    public class ConsumeSpiritMR : MagicCard
    {
        public ConsumeSpiritMR()
        {
            Name = "Consume Spirit";
            Edition = "MR";
            Rarity = "C";
            Color = "B";
            Cost = "X1B";
            PT = "";
            Type = "Sorcery";
            Text = "Spend only black mana on X.;^Consume Spirit deals X damage to target creature or player and you gain X life.";
            Flavor = "";
        }
    }
    # endregion

    # region Contaminated Bond
    public class ContaminatedBondMR : MagicCard
    {
        public ContaminatedBondMR()
        {
            Name = "Contaminated Bond";
            Edition = "MR";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature @(Target a creature as you cast this. This card enters the battlefield attached to that creature.)@;^Whenever enchanted creature attacks or blocks, its controller loses 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Copper Myr
    public class CopperMyrMR : MagicCard
    {
        public CopperMyrMR()
        {
            Name = "Copper Myr";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "1/1";
            Type = "Artifact Creature - Myr";
            Text = "%T: Add %G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Copperhoof Vorrac
    public class CopperhoofVorracMR : MagicCard
    {
        public CopperhoofVorracMR()
        {
            Name = "Copperhoof Vorrac";
            Edition = "MR";
            Rarity = "R";
            Color = "G";
            Cost = "3GG";
            PT = "2/2";
            Type = "Creature - Boar Beast";
            Text = "Copperhoof Vorrac gets +1/+1 for each untapped permanent your opponents control.";
            Flavor = "";
        }
    }
    # endregion

    # region Creeping Mold
    public class CreepingMoldMR : MagicCard
    {
        public CreepingMoldMR()
        {
            Name = "Creeping Mold";
            Edition = "MR";
            Rarity = "U";
            Color = "G";
            Cost = "2GG";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target artifact, enchantment, or land.";
            Flavor = "";
        }
    }
    # endregion

    # region Crystal Shard
    public class CrystalShardMR : MagicCard
    {
        public CrystalShardMR()
        {
            Name = "Crystal Shard";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T or %U, %T: Return target creature to its owner�s hand unless its controller pays %1.";
            Flavor = "";
        }
    }
    # endregion

    # region Culling Scales
    public class CullingScalesMR : MagicCard
    {
        public CullingScalesMR()
        {
            Name = "Culling Scales";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of your upkeep, destroy target nonland permanent with the lowest converted mana cost. @(If two or more permanents are tied for lowest cost, target any one of them.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Damping Matrix
    public class DampingMatrixMR : MagicCard
    {
        public DampingMatrixMR()
        {
            Name = "Damping Matrix";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Activated abilities of artifacts and creatures can�t be activated unless they�re mana abilities.";
            Flavor = "";
        }
    }
    # endregion

    # region Dead-Iron Sledge
    public class DeadIronSledgeMR : MagicCard
    {
        public DeadIronSledgeMR()
        {
            Name = "Dead-Iron Sledge";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Whenever equipped creature blocks or becomes blocked by a creature, destroy both creatures.;^Equip %2 @(%2: Attach to target creature you control. Equip only as a sorcery. This card enters the battlefield unattached and stays on the battlefield if the creature leaves.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Deconstruct
    public class DeconstructMR : MagicCard
    {
        public DeconstructMR()
        {
            Name = "Deconstruct";
            Edition = "MR";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target artifact. Add %G%G%G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Detonate
    public class DetonateMR : MagicCard
    {
        public DetonateMR()
        {
            Name = "Detonate";
            Edition = "MR";
            Rarity = "U";
            Color = "R";
            Cost = "XR";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target artifact with converted mana cost X. It can�t be regenerated. Detonate deals X damage to that artifact�s controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Disarm
    public class DisarmMR : MagicCard
    {
        public DisarmMR()
        {
            Name = "Disarm";
            Edition = "MR";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Unattach all Equipment from target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Disciple of the Vault
    public class DiscipleoftheVaultMR : MagicCard
    {
        public DiscipleoftheVaultMR()
        {
            Name = "Disciple of the Vault";
            Edition = "MR";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Human Cleric";
            Text = "Whenever an artifact is put into a graveyard from the battlefield, you may have target opponent lose 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Domineer
    public class DomineerMR : MagicCard
    {
        public DomineerMR()
        {
            Name = "Domineer";
            Edition = "MR";
            Rarity = "U";
            Color = "U";
            Cost = "1UU";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant artifact creature;^You control enchanted artifact creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Dragon Blood
    public class DragonBloodMR : MagicCard
    {
        public DragonBloodMR()
        {
            Name = "Dragon Blood";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T: Put a +1/+1 counter on target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Dream's Grip
    public class DreamsGripMR : MagicCard
    {
        public DreamsGripMR()
        {
            Name = "Dream's Grip";
            Edition = "MR";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Tap target permanent; or untap target permanent.;^Entwine %1 @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Dross Harvester
    public class DrossHarvesterMR : MagicCard
    {
        public DrossHarvesterMR()
        {
            Name = "Dross Harvester";
            Edition = "MR";
            Rarity = "R";
            Color = "B";
            Cost = "1BB";
            PT = "4/4";
            Type = "Creature - Horror";
            Text = "Protection from white;^At the beginning of your end step, you lose 4 life.;^Whenever a creature dies, you gain 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Dross Prowler
    public class DrossProwlerMR : MagicCard
    {
        public DrossProwlerMR()
        {
            Name = "Dross Prowler";
            Edition = "MR";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "2/1";
            Type = "Creature - Zombie";
            Text = "Fear @(This creature can�t be blocked except by artifact creatures and/or black creatures.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Dross Scorpion
    public class DrossScorpionMR : MagicCard
    {
        public DrossScorpionMR()
        {
            Name = "Dross Scorpion";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "4";
            PT = "3/1";
            Type = "Artifact Creature - Scorpion";
            Text = "Whenever Dross Scorpion or another artifact creature dies, you may untap target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Duplicant
    public class DuplicantMR : MagicCard
    {
        public DuplicantMR()
        {
            Name = "Duplicant";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "6";
            PT = "2/4";
            Type = "Artifact Creature - Shapeshifter";
            Text = "@Imprint@ � When Duplicant enters the battlefield, you may exile target nontoken creature.;^As long as a card exiled with Duplicant is a creature card, Duplicant has the power, toughness, and creature types of the last creature card exiled with Duplicant. It�s still a Shapeshifter.";
            Flavor = "";
        }
    }
    # endregion

    # region Duskworker
    public class DuskworkerMR : MagicCard
    {
        public DuskworkerMR()
        {
            Name = "Duskworker";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "2/2";
            Type = "Artifact Creature - Construct";
            Text = "Whenever Duskworker becomes blocked, regenerate it.;^%3: Duskworker gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Electrostatic Bolt
    public class ElectrostaticBoltMR : MagicCard
    {
        public ElectrostaticBoltMR()
        {
            Name = "Electrostatic Bolt";
            Edition = "MR";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Electrostatic Bolt deals 2 damage to target creature. If it�s an artifact creature, Electrostatic Bolt deals 4 damage to it instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Elf Replica
    public class ElfReplicaMR : MagicCard
    {
        public ElfReplicaMR()
        {
            Name = "Elf Replica";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "2/2";
            Type = "Artifact Creature - Elf";
            Text = "%1%G, Sacrifice Elf Replica: Destroy target enchantment.";
            Flavor = "";
        }
    }
    # endregion

    # region Empyrial Plate
    public class EmpyrialPlateMR : MagicCard
    {
        public EmpyrialPlateMR()
        {
            Name = "Empyrial Plate";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +1/+1 for each card in your hand.;^Equip %2 @(%2: Attach to target creature you control. Equip only as a sorcery. This card enters the battlefield unattached and stays on the battlefield if the creature leaves.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Extraplanar Lens
    public class ExtraplanarLensMR : MagicCard
    {
        public ExtraplanarLensMR()
        {
            Name = "Extraplanar Lens";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "@Imprint@ � When Extraplanar Lens enters the battlefield, you may exile target land you control.;^Whenever a land with the same name as the exiled card is tapped for mana, its controller adds one mana to his or her mana pool of any type that land produced.";
            Flavor = "";
        }
    }
    # endregion

    # region Fabricate
    public class FabricateMR : MagicCard
    {
        public FabricateMR()
        {
            Name = "Fabricate";
            Edition = "MR";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Sorcery";
            Text = "Search your library for an artifact card, reveal it, and put it into your hand. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Fangren Hunter
    public class FangrenHunterMR : MagicCard
    {
        public FangrenHunterMR()
        {
            Name = "Fangren Hunter";
            Edition = "MR";
            Rarity = "C";
            Color = "G";
            Cost = "3GG";
            PT = "4/4";
            Type = "Creature - Beast";
            Text = "Trample";
            Flavor = "";
        }
    }
    # endregion

    # region Farsight Mask
    public class FarsightMaskMR : MagicCard
    {
        public FarsightMaskMR()
        {
            Name = "Farsight Mask";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a source an opponent controls deals damage to you, if Farsight Mask is untapped, you may draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Fatespinner
    public class FatespinnerMR : MagicCard
    {
        public FatespinnerMR()
        {
            Name = "Fatespinner";
            Edition = "MR";
            Rarity = "R";
            Color = "U";
            Cost = "1UU";
            PT = "1/2";
            Type = "Creature - Human Wizard";
            Text = "At the beginning of each opponent�s upkeep, that player chooses draw step, main phase, or combat phase. The player skips each instance of the chosen step or phase this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Fiery Gambit
    public class FieryGambitMR : MagicCard
    {
        public FieryGambitMR()
        {
            Name = "Fiery Gambit";
            Edition = "MR";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Sorcery";
            Text = "Flip a coin until you lose a flip or choose to stop flipping. If you lose a flip, Fiery Gambit has no effect. If you win one or more flips, Fiery Gambit deals 3 damage to target creature. If you win two or more flips, Fiery Gambit deals 6 damage to each opponent. If you win three or more flips, draw nine cards and untap all lands you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Fireshrieker
    public class FireshriekerMR : MagicCard
    {
        public FireshriekerMR()
        {
            Name = "Fireshrieker";
            Edition = "MR";
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

    # region Fists of the Anvil
    public class FistsoftheAnvilMR : MagicCard
    {
        public FistsoftheAnvilMR()
        {
            Name = "Fists of the Anvil";
            Edition = "MR";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +4/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Flayed Nim
    public class FlayedNimMR : MagicCard
    {
        public FlayedNimMR()
        {
            Name = "Flayed Nim";
            Edition = "MR";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "2/2";
            Type = "Creature - Skeleton";
            Text = "Whenever Flayed Nim deals combat damage to a creature, that creature�s controller loses that much life.;^%2%B: Regenerate Flayed Nim.";
            Flavor = "";
        }
    }
    # endregion

    //# region Forest (1)
    //public class Forest(1)MR : MagicCard
    //{
    //    public Forest(1)MR()
    //    {
    //         Name = "Forest (1)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Forest";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Forest (2)
    //public class Forest(2)MR : MagicCard
    //{
    //    public Forest(2)MR()
    //    {
    //         Name = "Forest (2)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Forest";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Forest (3)
    //public class Forest(3)MR : MagicCard
    //{
    //    public Forest(3)MR()
    //    {
    //         Name = "Forest (3)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Forest";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Forest (4)
    //public class Forest(4)MR : MagicCard
    //{
    //    public Forest(4)MR()
    //    {
    //         Name = "Forest (4)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Forest";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    # region Forge Armor
    public class ForgeArmorMR : MagicCard
    {
        public ForgeArmorMR()
        {
            Name = "Forge Armor";
            Edition = "MR";
            Rarity = "U";
            Color = "R";
            Cost = "4R";
            PT = "";
            Type = "Instant";
            Text = "As an additional cost to cast Forge Armor, sacrifice an artifact.;^Put X +1/+1 counters on target creature, where X is the sacrificed artifact�s converted mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Fractured Loyalty
    public class FracturedLoyaltyMR : MagicCard
    {
        public FracturedLoyaltyMR()
        {
            Name = "Fractured Loyalty";
            Edition = "MR";
            Rarity = "U";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Whenever enchanted creature becomes the target of a spell or ability, that spell or ability�s controller gains control of that creature. @(This effect lasts indefinitely.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Frogmite
    public class FrogmiteMR : MagicCard
    {
        public FrogmiteMR()
        {
            Name = "Frogmite";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "4";
            PT = "2/2";
            Type = "Artifact Creature - Frog";
            Text = "Affinity for artifacts @(This spell costs %1 less to cast for each artifact you control.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Galvanic Key
    public class GalvanicKeyMR : MagicCard
    {
        public GalvanicKeyMR()
        {
            Name = "Galvanic Key";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Flash;^%3, %T: Untap target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Gate to the AEther
    public class GatetotheAEtherMR : MagicCard
    {
        public GatetotheAEtherMR()
        {
            Name = "Gate to the AEther";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "6";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of each player�s upkeep, that player reveals the top card of his or her library. If it�s an artifact, creature, enchantment, or land card, the player may put it onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Gilded Lotus
    public class GildedLotusMR : MagicCard
    {
        public GildedLotusMR()
        {
            Name = "Gilded Lotus";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add three mana of any one color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Glimmervoid
    public class GlimmervoidMR : MagicCard
    {
        public GlimmervoidMR()
        {
            Name = "Glimmervoid";
            Edition = "MR";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "At the beginning of the end step, if you control no artifacts, sacrifice Glimmervoid.;^%T: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Glissa Sunseeker
    public class GlissaSunseekerMR : MagicCard
    {
        public GlissaSunseekerMR()
        {
            Name = "Glissa Sunseeker";
            Edition = "MR";
            Rarity = "R";
            Color = "G";
            Cost = "2GG";
            PT = "3/2";
            Type = "Legendary Creature - Elf";
            Text = "First Strike;^%T: Destroy target artifact if its converted mana cost is equal to the amount of mana in your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Charbelcher
    public class GoblinCharbelcherMR : MagicCard
    {
        public GoblinCharbelcherMR()
        {
            Name = "Goblin Charbelcher";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T: Reveal cards from the top of your library until you reveal a land card. Goblin Charbelcher deals damage equal to the number of nonland cards revealed this way to target creature or player. If the revealed land card was a Mountain, Goblin Charbelcher deals double that damage instead. Put the revealed cards on the bottom of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Dirigible
    public class GoblinDirigibleMR : MagicCard
    {
        public GoblinDirigibleMR()
        {
            Name = "Goblin Dirigible";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "6";
            PT = "4/4";
            Type = "Artifact Creature - Construct";
            Text = "Flying;^Goblin Dirigible doesn�t untap during your untap step.;^At the beginning of your upkeep, you may pay %4. If you do, untap Goblin Dirigible.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Replica
    public class GoblinReplicaMR : MagicCard
    {
        public GoblinReplicaMR()
        {
            Name = "Goblin Replica";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "2/2";
            Type = "Artifact Creature - Goblin";
            Text = "%3%R, Sacrifice Goblin Replica: Destroy target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin Striker
    public class GoblinStrikerMR : MagicCard
    {
        public GoblinStrikerMR()
        {
            Name = "Goblin Striker";
            Edition = "MR";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "1/1";
            Type = "Creature - Goblin Berserker";
            Text = "First strike, haste";
            Flavor = "";
        }
    }
    # endregion

    # region Goblin War Wagon
    public class GoblinWarWagonMR : MagicCard
    {
        public GoblinWarWagonMR()
        {
            Name = "Goblin War Wagon";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "4";
            PT = "3/3";
            Type = "Artifact Creature - Juggernaut";
            Text = "Goblin War Wagon Doesn�t untap during your untap step.;^At the beginning of your upkeep, you may pay %2. If you do, untap Goblin War Wagon.";
            Flavor = "";
        }
    }
    # endregion

    # region Gold Myr
    public class GoldMyrMR : MagicCard
    {
        public GoldMyrMR()
        {
            Name = "Gold Myr";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "1/1";
            Type = "Artifact Creature - Myr";
            Text = "%T: Add %W to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Golem-Skin Gauntlets
    public class GolemSkinGauntletsMR : MagicCard
    {
        public GolemSkinGauntletsMR()
        {
            Name = "Golem-Skin Gauntlets";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +1/+0 for each Equipment attached to it.;^Equip %2 @(%2: Attach to target creature you control. Equip only as a sorcery. This card enters the battlefield unattached and stays on the battlefield if the creature leaves.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Grab the Reins
    public class GrabtheReinsMR : MagicCard
    {
        public GrabtheReinsMR()
        {
            Name = "Grab the Reins";
            Edition = "MR";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Until end of turn, you gain control of target creature and it gains haste; or sacrifice a creature, then Grab the Reins deals damage equal to that creature�s power to target creature or player.;^Entwine %2%R @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Granite Shard
    public class GraniteShardMR : MagicCard
    {
        public GraniteShardMR()
        {
            Name = "Granite Shard";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T or %R, %T: Granite Shard deals 1 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Great Furnace
    public class GreatFurnaceMR : MagicCard
    {
        public GreatFurnaceMR()
        {
            Name = "Great Furnace";
            Edition = "MR";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Artifact Land";
            Text = "@(Great Furnace isn�t a spell.)@;^%T: Add %R to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Grid Monitor
    public class GridMonitorMR : MagicCard
    {
        public GridMonitorMR()
        {
            Name = "Grid Monitor";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "4/6";
            Type = "Artifact Creature - Construct";
            Text = "You can�t cast creature spells.";
            Flavor = "";
        }
    }
    # endregion

    # region Grim Reminder
    public class GrimReminderMR : MagicCard
    {
        public GrimReminderMR()
        {
            Name = "Grim Reminder";
            Edition = "MR";
            Rarity = "R";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Instant";
            Text = "Search your library for a nonland card and reveal it. Each opponent who cast a card this turn with the same name as that card loses 6 life. Then shuffle your library.;^%B%B: Return Grim Reminder from your graveyard to your hand. Activate this ability only during your upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Groffskithur
    public class GroffskithurMR : MagicCard
    {
        public GroffskithurMR()
        {
            Name = "Groffskithur";
            Edition = "MR";
            Rarity = "C";
            Color = "G";
            Cost = "5G";
            PT = "3/3";
            Type = "Creature - Beast";
            Text = "Whenever Groffskithur becomes blocked, you may return target card named Groffskithur from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Heartwood Shard
    public class HeartwoodShardMR : MagicCard
    {
        public HeartwoodShardMR()
        {
            Name = "Heartwood Shard";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T or %G, %T: Target creature gains trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Hematite Golem
    public class HematiteGolemMR : MagicCard
    {
        public HematiteGolemMR()
        {
            Name = "Hematite Golem";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "4";
            PT = "1/4";
            Type = "Artifact Creature - Golem";
            Text = "%1%R: Hematite Golem gets +2/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Hum of the Radix
    public class HumoftheRadixMR : MagicCard
    {
        public HumoftheRadixMR()
        {
            Name = "Hum of the Radix";
            Edition = "MR";
            Rarity = "R";
            Color = "G";
            Cost = "2GG";
            PT = "";
            Type = "Enchantment";
            Text = "Each artifact spell costs %1 more to cast for each artifact its controller controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Icy Manipulator
    public class IcyManipulatorMR : MagicCard
    {
        public IcyManipulatorMR()
        {
            Name = "Icy Manipulator";
            Edition = "MR";
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

    # region Incite War
    public class InciteWarMR : MagicCard
    {
        public InciteWarMR()
        {
            Name = "Incite War";
            Edition = "MR";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Creatures target player controls attack this turn if able; or creatures you control gain first strike until end of turn.;^Entwine %2 @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Inertia Bubble
    public class InertiaBubbleMR : MagicCard
    {
        public InertiaBubbleMR()
        {
            Name = "Inertia Bubble";
            Edition = "MR";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant artifact;^Enchanted artifact doesn�t untap during its controller�s untap step.";
            Flavor = "";
        }
    }
    # endregion

    # region Iron Myr
    public class IronMyrMR : MagicCard
    {
        public IronMyrMR()
        {
            Name = "Iron Myr";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "1/1";
            Type = "Artifact Creature - Myr";
            Text = "%T: Add %R to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Irradiate
    public class IrradiateMR : MagicCard
    {
        public IrradiateMR()
        {
            Name = "Irradiate";
            Edition = "MR";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets -1/-1 until end of turn for each artifact you control.";
            Flavor = "";
        }
    }
    # endregion

    //# region Island (1)
    //public class Island(1)MR : MagicCard
    //{
    //    public Island(1)MR()
    //    {
    //         Name = "Island (1)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Island";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Island (2)
    //public class Island(2)MR : MagicCard
    //{
    //    public Island(2)MR()
    //    {
    //         Name = "Island (2)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Island";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Island (3)
    //public class Island(3)MR : MagicCard
    //{
    //    public Island(3)MR()
    //    {
    //         Name = "Island (3)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Island";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Island (4)
    //public class Island(4)MR : MagicCard
    //{
    //    public Island(4)MR()
    //    {
    //         Name = "Island (4)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Island";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    # region Isochron Scepter
    public class IsochronScepterMR : MagicCard
    {
        public IsochronScepterMR()
        {
            Name = "Isochron Scepter";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "@Imprint@ � When Isochron Scepter enters the battlefield, you may exile an instant card with converted mana cost 2 or less from your hand.;^%2, %T: You may copy the exiled card. If you do, you may cast the copy without paying its mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Jinxed Choker
    public class JinxedChokerMR : MagicCard
    {
        public JinxedChokerMR()
        {
            Name = "Jinxed Choker";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of your end step, target opponent gains control of Jinxed Choker and puts a charge counter on it.;^At the beginning of your upkeep, Jinxed Choker deals damage to you equal to the number of charge counters on it.;^%3: Put a charge counter on Jinxed Choker or remove one from it.";
            Flavor = "";
        }
    }
    # endregion

    # region Journey of Discovery
    public class JourneyofDiscoveryMR : MagicCard
    {
        public JourneyofDiscoveryMR()
        {
            Name = "Journey of Discovery";
            Edition = "MR";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Sorcery";
            Text = "Choose one � Search your library for up to two basic land cards, reveal them, put them into your hand, then shuffle your library; or you may play up to two additional lands this turn.;^Entwine %2%G @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Krark-Clan Grunt
    public class KrarkClanGruntMR : MagicCard
    {
        public KrarkClanGruntMR()
        {
            Name = "Krark-Clan Grunt";
            Edition = "MR";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Goblin Warrior";
            Text = "Sacrifice an artifact: Krark-Clan Grunt gets +1/+0 and gains first strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Krark-Clan Shaman
    public class KrarkClanShamanMR : MagicCard
    {
        public KrarkClanShamanMR()
        {
            Name = "Krark-Clan Shaman";
            Edition = "MR";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Goblin Shaman";
            Text = "Sacrifice an artifact: Krark-Clan Shaman deals 1 damage to each creature without flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Krark's Thumb
    public class KrarksThumbMR : MagicCard
    {
        public KrarksThumbMR()
        {
            Name = "Krark's Thumb";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Legendary Artifact";
            Text = "If you would flip a coin, instead flip two coins and ignore one.";
            Flavor = "";
        }
    }
    # endregion

    # region Leaden Myr
    public class LeadenMyrMR : MagicCard
    {
        public LeadenMyrMR()
        {
            Name = "Leaden Myr";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "1/1";
            Type = "Artifact Creature - Myr";
            Text = "%T: Add %B to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Leonin Abunas
    public class LeoninAbunasMR : MagicCard
    {
        public LeoninAbunasMR()
        {
            Name = "Leonin Abunas";
            Edition = "MR";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "2/5";
            Type = "Creature - Cat Cleric";
            Text = "Artifacts you control have hexproof. @(They can�t be the targets of spells or abilities your opponents control.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Leonin Bladetrap
    public class LeoninBladetrapMR : MagicCard
    {
        public LeoninBladetrapMR()
        {
            Name = "Leonin Bladetrap";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Flash;^%2, Sacrifice Leonin Bladetrap: Leonin Bladetrap deals 2 damage to each attacking creature without flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Leonin Den-Guard
    public class LeoninDenGuardMR : MagicCard
    {
        public LeoninDenGuardMR()
        {
            Name = "Leonin Den-Guard";
            Edition = "MR";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "1/3";
            Type = "Creature - Cat Soldier";
            Text = "As long as Leonin Den-Guard is equipped, it gets +1/+1 and has vigilance.";
            Flavor = "";
        }
    }
    # endregion

    # region Leonin Elder
    public class LeoninElderMR : MagicCard
    {
        public LeoninElderMR()
        {
            Name = "Leonin Elder";
            Edition = "MR";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Cat Cleric";
            Text = "Whenever an artifact enters the battlefield, you may gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Leonin Scimitar
    public class LeoninScimitarMR : MagicCard
    {
        public LeoninScimitarMR()
        {
            Name = "Leonin Scimitar";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +1/+1.;^Equip %1 @(%1: Attach to target creature you control. Equip only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Leonin Skyhunter
    public class LeoninSkyhunterMR : MagicCard
    {
        public LeoninSkyhunterMR()
        {
            Name = "Leonin Skyhunter";
            Edition = "MR";
            Rarity = "U";
            Color = "W";
            Cost = "WW";
            PT = "2/2";
            Type = "Creature - Cat Knight";
            Text = "Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Leonin Sun Standard
    public class LeoninSunStandardMR : MagicCard
    {
        public LeoninSunStandardMR()
        {
            Name = "Leonin Sun Standard";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%1%W: Creatures you control get +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Leveler
    public class LevelerMR : MagicCard
    {
        public LevelerMR()
        {
            Name = "Leveler";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "10/10";
            Type = "Artifact Creature - Juggernaut";
            Text = "When Leveler enters the battlefield, exile all cards from your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Liar's Pendulum
    public class LiarsPendulumMR : MagicCard
    {
        public LiarsPendulumMR()
        {
            Name = "Liar's Pendulum";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T: Name a card. Target opponent guesses whether a card with that name is in your hand. You may reveal your hand. If you do and your opponent guessed wrong, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Lifespark Spellbomb
    public class LifesparkSpellbombMR : MagicCard
    {
        public LifesparkSpellbombMR()
        {
            Name = "Lifespark Spellbomb";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%G, Sacrifice Lifespark Spellbomb: Until end of turn, target land becomes a 3/3 creature that�s still a land.;^%1, Sacrifice Lifespark Spellbomb: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Lightning Coils
    public class LightningCoilsMR : MagicCard
    {
        public LightningCoilsMR()
        {
            Name = "Lightning Coils";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a nontoken creature you control dies, put a charge counter on Lightning Coils.;^At the beginning of your upkeep, if Lightning Coils has five or more charge counters on it, remove all of them from it and put that many 3/1 red Elemental creature tokens with haste onto the battlefield. Exile them at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Lightning Greaves
    public class LightningGreavesMR : MagicCard
    {
        public LightningGreavesMR()
        {
            Name = "Lightning Greaves";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature has haste and shroud. @(It can�t be the target of spells or abilities.)@;^Equip %0";
            Flavor = "";
        }
    }
    # endregion

    # region Living Hive
    public class LivingHiveMR : MagicCard
    {
        public LivingHiveMR()
        {
            Name = "Living Hive";
            Edition = "MR";
            Rarity = "R";
            Color = "G";
            Cost = "6GG";
            PT = "6/6";
            Type = "Creature - Elemental Insect";
            Text = "Trample;^Whenever Living Hive deals combat damage to a player, put that many 1/1 green Insect creature tokens onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Lodestone Myr
    public class LodestoneMyrMR : MagicCard
    {
        public LodestoneMyrMR()
        {
            Name = "Lodestone Myr";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "2/2";
            Type = "Artifact Creature - Myr";
            Text = "Trample;^Tap an untapped artifact you control: Lodestone Myr gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Looming Hoverguard
    public class LoomingHoverguardMR : MagicCard
    {
        public LoomingHoverguardMR()
        {
            Name = "Looming Hoverguard";
            Edition = "MR";
            Rarity = "U";
            Color = "U";
            Cost = "4UU";
            PT = "3/3";
            Type = "Creature - Drone";
            Text = "Flying;^When Looming Hoverguard enters the battlefield, put target artifact on top of its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Loxodon Mender
    public class LoxodonMenderMR : MagicCard
    {
        public LoxodonMenderMR()
        {
            Name = "Loxodon Mender";
            Edition = "MR";
            Rarity = "C";
            Color = "W";
            Cost = "5W";
            PT = "3/3";
            Type = "Creature - Elephant Cleric";
            Text = "%W, %T: Regenerate target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Loxodon Peacekeeper
    public class LoxodonPeacekeeperMR : MagicCard
    {
        public LoxodonPeacekeeperMR()
        {
            Name = "Loxodon Peacekeeper";
            Edition = "MR";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "4/4";
            Type = "Creature - Elephant Soldier";
            Text = "At the beginning of your upkeep, the player with the lowest life total gains control of Loxodon Peacekeeper. If two or more players are tied for lowest life total, you choose one of them, and that player gains control of Loxodon Peacekeeper.";
            Flavor = "";
        }
    }
    # endregion

    # region Loxodon Punisher
    public class LoxodonPunisherMR : MagicCard
    {
        public LoxodonPunisherMR()
        {
            Name = "Loxodon Punisher";
            Edition = "MR";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "2/2";
            Type = "Creature - Elephant Soldier";
            Text = "Loxodon Punisher gets +2/+2 for each equipment attached to it.";
            Flavor = "";
        }
    }
    # endregion

    # region Loxodon Warhammer
    public class LoxodonWarhammerMR : MagicCard
    {
        public LoxodonWarhammerMR()
        {
            Name = "Loxodon Warhammer";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +3/+0 and has trample and lifelink. @(If the creature would assign enough damage to its blockers to destroy them, you may have it assign the rest of its damage to defending player or planeswalker. Damage dealt by the creature also causes its controller to gain that much life.)@;^Equip %3 @(%3: Attach to target creature you control. Equip only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Lumengrid Augur
    public class LumengridAugurMR : MagicCard
    {
        public LumengridAugurMR()
        {
            Name = "Lumengrid Augur";
            Edition = "MR";
            Rarity = "R";
            Color = "U";
            Cost = "3U";
            PT = "2/2";
            Type = "Creature - Vedalken Wizard";
            Text = "%1, %T: Target player draws a card, then discards a card. If that player discards an artifact card this way, untap Lumengrid Augur.";
            Flavor = "";
        }
    }
    # endregion

    # region Lumengrid Sentinel
    public class LumengridSentinelMR : MagicCard
    {
        public LumengridSentinelMR()
        {
            Name = "Lumengrid Sentinel";
            Edition = "MR";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "1/2";
            Type = "Creature - Human Wizard";
            Text = "Flying;^Whenever an artifact enters the battlefield under your control, you may tap target permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Lumengrid Warden
    public class LumengridWardenMR : MagicCard
    {
        public LumengridWardenMR()
        {
            Name = "Lumengrid Warden";
            Edition = "MR";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "1/3";
            Type = "Creature - Human Wizard";
            Text = "";
            Flavor = "The Neurok, like the vedalken, are on a constant quest for knowledge. It is their currency, their trade, their life.";
        }
    }
    # endregion

    # region Luminous Angel
    public class LuminousAngelMR : MagicCard
    {
        public LuminousAngelMR()
        {
            Name = "Luminous Angel";
            Edition = "MR";
            Rarity = "R";
            Color = "W";
            Cost = "4WWW";
            PT = "4/4";
            Type = "Creature - Angel";
            Text = "Flying;^At the beginning of your upkeep, you may put a 1/1 white Spirit creature token with flying onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Malachite Golem
    public class MalachiteGolemMR : MagicCard
    {
        public MalachiteGolemMR()
        {
            Name = "Malachite Golem";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "6";
            PT = "5/3";
            Type = "Artifact Creature - Golem";
            Text = "%1%G: Malachite Golem gains trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region March of the Machines
    public class MarchoftheMachinesMR : MagicCard
    {
        public MarchoftheMachinesMR()
        {
            Name = "March of the Machines";
            Edition = "MR";
            Rarity = "R";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Enchantment";
            Text = "Each noncreature artifact is an artifact creature with power and toughness each equal to its converted mana cost. @(Equipment that�s a creature can�t equip a creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Mask of Memory
    public class MaskofMemoryMR : MagicCard
    {
        public MaskofMemoryMR()
        {
            Name = "Mask of Memory";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Whenever equipped creature deals combat damage to a player, you may draw two cards. If you do, discard a card.;^Equip %1 @(%1: Attach to target creature you control. Equip only as a sorcery. This card enters the battlefield unattached and stays on the battlefield if the creature leaves.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Mass Hysteria
    public class MassHysteriaMR : MagicCard
    {
        public MassHysteriaMR()
        {
            Name = "Mass Hysteria";
            Edition = "MR";
            Rarity = "R";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Enchantment";
            Text = "All creatures have haste.";
            Flavor = "";
        }
    }
    # endregion

    # region Megatog
    public class MegatogMR : MagicCard
    {
        public MegatogMR()
        {
            Name = "Megatog";
            Edition = "MR";
            Rarity = "R";
            Color = "R";
            Cost = "4RR";
            PT = "3/4";
            Type = "Creature - Atog";
            Text = "Sacrifice an artifact: Megatog gets +3/+3 and gains trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Mesmeric Orb
    public class MesmericOrbMR : MagicCard
    {
        public MesmericOrbMR()
        {
            Name = "Mesmeric Orb";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a permanent becomes untapped, that permanent�s controller puts the top card of his or her library into his or her graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Mind's Eye
    public class MindsEyeMR : MagicCard
    {
        public MindsEyeMR()
        {
            Name = "Mind's Eye";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "Whenever an opponent draws a card, you may pay %1. If you do, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Mindslaver
    public class MindslaverMR : MagicCard
    {
        public MindslaverMR()
        {
            Name = "Mindslaver";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "6";
            PT = "";
            Type = "Legendary Artifact";
            Text = "%4, %T, Sacrifice Mindslaver: You control target player during that player�s next turn. @(You see all cards that player could see and make all decisions for the player.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Mindstorm Crown
    public class MindstormCrownMR : MagicCard
    {
        public MindstormCrownMR()
        {
            Name = "Mindstorm Crown";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of your upkeep, draw a card if you had no cards in hand at the beginning of this turn. If you had a card in hand, Mindstorm Crown deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Mirror Golem
    public class MirrorGolemMR : MagicCard
    {
        public MirrorGolemMR()
        {
            Name = "Mirror Golem";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "6";
            PT = "3/4";
            Type = "Artifact Creature - Golem";
            Text = "@Imprint@ � When Mirror Golem enters the battlefield, you may exile target card from a graveyard.;^Mirror Golem has protection from each of the exiled card�s card types. @(Artifact, creature, enchantment, instant, land, planeswalker, sorcery, and tribal are card types.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Molder Slug
    public class MolderSlugMR : MagicCard
    {
        public MolderSlugMR()
        {
            Name = "Molder Slug";
            Edition = "MR";
            Rarity = "R";
            Color = "G";
            Cost = "3GG";
            PT = "4/6";
            Type = "Creature - Slug Beast";
            Text = "At the beginning of each player�s upkeep, that player sacrifices an artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Molten Rain
    public class MoltenRainMR : MagicCard
    {
        public MoltenRainMR()
        {
            Name = "Molten Rain";
            Edition = "MR";
            Rarity = "C";
            Color = "R";
            Cost = "1RR";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target land. If that land was nonbasic, Molten Rain deals 2 damage to the land�s controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Moriok Scavenger
    public class MoriokScavengerMR : MagicCard
    {
        public MoriokScavengerMR()
        {
            Name = "Moriok Scavenger";
            Edition = "MR";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "2/3";
            Type = "Creature - Human Rogue";
            Text = "When Moriok Scavenger enters the battlefield, you may return target artifact creature card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    //# region Mountain (1)
    //public class Mountain(1)MR : MagicCard
    //{
    //    public Mountain(1)MR()
    //    {
    //         Name = "Mountain (1)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Mountain";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Mountain (2)
    //public class Mountain(2)MR : MagicCard
    //{
    //    public Mountain(2)MR()
    //    {
    //         Name = "Mountain (2)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Mountain";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Mountain (3)
    //public class Mountain(3)MR : MagicCard
    //{
    //    public Mountain(3)MR()
    //    {
    //         Name = "Mountain (3)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Mountain";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Mountain (4)
    //public class Mountain(4)MR : MagicCard
    //{
    //    public Mountain(4)MR()
    //    {
    //         Name = "Mountain (4)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Mountain";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    # region Mourner's Shield
    public class MournersShieldMR : MagicCard
    {
        public MournersShieldMR()
        {
            Name = "Mourner's Shield";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "@Imprint@ � When Mourner�s Shield enters the battlefield, you may exile target card from a graveyard.;^%2, %T: Prevent all damage that would be dealt this turn by a source of your choice that shares a color with the exiled card.";
            Flavor = "";
        }
    }
    # endregion

    # region Myr Adapter
    public class MyrAdapterMR : MagicCard
    {
        public MyrAdapterMR()
        {
            Name = "Myr Adapter";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "1/1";
            Type = "Artifact Creature - Myr";
            Text = "Myr Adapter gets +1/+1 for each Equipment attached to it.";
            Flavor = "";
        }
    }
    # endregion

    # region Myr Enforcer
    public class MyrEnforcerMR : MagicCard
    {
        public MyrEnforcerMR()
        {
            Name = "Myr Enforcer";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "7";
            PT = "4/4";
            Type = "Artifact Creature - Myr";
            Text = "Affinity for artifacts @(This spell costs %1 less to cast for each artifact you control.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Myr Incubator
    public class MyrIncubatorMR : MagicCard
    {
        public MyrIncubatorMR()
        {
            Name = "Myr Incubator";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "6";
            PT = "";
            Type = "Artifact";
            Text = "%6, %T, Sacrifice Myr Incubator: Search your library for any number of artifact cards, exile them, then put that many 1/1 colorless Myr artifact creature tokens onto the battlefield. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Myr Mindservant
    public class MyrMindservantMR : MagicCard
    {
        public MyrMindservantMR()
        {
            Name = "Myr Mindservant";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "1/1";
            Type = "Artifact Creature - Myr";
            Text = "%2, %T: Shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Myr Prototype
    public class MyrPrototypeMR : MagicCard
    {
        public MyrPrototypeMR()
        {
            Name = "Myr Prototype";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "5";
            PT = "2/2";
            Type = "Artifact Creature - Myr";
            Text = "At the beginning of your upkeep, put a +1/+1 counter on Myr Prototype.;^Myr Prototype can�t attack or block unless you pay %1 for each +1/+1 counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Myr Retriever
    public class MyrRetrieverMR : MagicCard
    {
        public MyrRetrieverMR()
        {
            Name = "Myr Retriever";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "1/1";
            Type = "Artifact Creature - Myr";
            Text = "When Myr Retriever dies, return another target artifact card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Necrogen Mists
    public class NecrogenMistsMR : MagicCard
    {
        public NecrogenMistsMR()
        {
            Name = "Necrogen Mists";
            Edition = "MR";
            Rarity = "R";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of each player�s upkeep, that player discards a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Necrogen Spellbomb
    public class NecrogenSpellbombMR : MagicCard
    {
        public NecrogenSpellbombMR()
        {
            Name = "Necrogen Spellbomb";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%B, Sacrifice Necrogen Spellbomb: Target player discards a card.;^%1, Sacrifice Necrogen Spellbomb: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Needlebug
    public class NeedlebugMR : MagicCard
    {
        public NeedlebugMR()
        {
            Name = "Needlebug";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "2/2";
            Type = "Artifact Creature - Insect";
            Text = "Flash;^Protection from artifacts";
            Flavor = "";
        }
    }
    # endregion

    # region Neurok Familiar
    public class NeurokFamiliarMR : MagicCard
    {
        public NeurokFamiliarMR()
        {
            Name = "Neurok Familiar";
            Edition = "MR";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Bird";
            Text = "Flying;^When Neurok Familiar enters the battlefield, reveal the top card of your library. If it�s an artifact card, put it into your hand. Otherwise, put it into your graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Neurok Hoversail
    public class NeurokHoversailMR : MagicCard
    {
        public NeurokHoversailMR()
        {
            Name = "Neurok Hoversail";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature has flying.;^Equip %2 @(%2: Attach to target creature you control. Equip only as a sorcery. This card enters the battlefield unattached and stays on the battlefield if the creature leaves.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Neurok Spy
    public class NeurokSpyMR : MagicCard
    {
        public NeurokSpyMR()
        {
            Name = "Neurok Spy";
            Edition = "MR";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "2/2";
            Type = "Creature - Human Rogue";
            Text = "Neurok Spy can�t be blocked as long as defending player controls an artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Nightmare Lash
    public class NightmareLashMR : MagicCard
    {
        public NightmareLashMR()
        {
            Name = "Nightmare Lash";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +1/+1 for each Swamp you control.;^Equip�Pay 3 life. @(Pay 3 life: Attach to target creature you control. Equip only as a sorcery. This card enters the battlefield unattached and stays on the battlefield if the creature leaves.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Nim Devourer
    public class NimDevourerMR : MagicCard
    {
        public NimDevourerMR()
        {
            Name = "Nim Devourer";
            Edition = "MR";
            Rarity = "R";
            Color = "B";
            Cost = "3BB";
            PT = "4/1";
            Type = "Creature - Zombie";
            Text = "Nim Devourer gets +1/+0 for each artifact you control.;^%B%B: Return Nim Devourer from your graveyard to the battlefield, then sacrifice a creature. Activate this ability only during your upkeep.";
            Flavor = "";
        }
    }
    # endregion

    # region Nim Lasher
    public class NimLasherMR : MagicCard
    {
        public NimLasherMR()
        {
            Name = "Nim Lasher";
            Edition = "MR";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "1/1";
            Type = "Creature - Zombie";
            Text = "Nim Lasher gets +1/+0 for each artifact you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Nim Replica
    public class NimReplicaMR : MagicCard
    {
        public NimReplicaMR()
        {
            Name = "Nim Replica";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "3/1";
            Type = "Artifact Creature - Zombie";
            Text = "%2%B, Sacrifice Nim Replica: Target creature gets -1/-1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Nim Shambler
    public class NimShamblerMR : MagicCard
    {
        public NimShamblerMR()
        {
            Name = "Nim Shambler";
            Edition = "MR";
            Rarity = "U";
            Color = "B";
            Cost = "2BB";
            PT = "2/1";
            Type = "Creature - Zombie";
            Text = "Nim Shambler gets +1/+0 for each artifact you control.;^Sacrifice a creature: Regenerate Nim Shambler.";
            Flavor = "";
        }
    }
    # endregion

    # region Nim Shrieker
    public class NimShriekerMR : MagicCard
    {
        public NimShriekerMR()
        {
            Name = "Nim Shrieker";
            Edition = "MR";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "0/1";
            Type = "Creature - Zombie";
            Text = "Flying;^Nim Shrieker gets +1/+0 for each artifact you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Nuisance Engine
    public class NuisanceEngineMR : MagicCard
    {
        public NuisanceEngineMR()
        {
            Name = "Nuisance Engine";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T: Put a 0/1 colorless Pest artifact creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Oblivion Stone
    public class OblivionStoneMR : MagicCard
    {
        public OblivionStoneMR()
        {
            Name = "Oblivion Stone";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%4, %T: Put a fate counter on target permanent.;^%5, %T, Sacrifice Oblivion Stone: destroy each nonland permanent without a fate counter on it, then remove all fate counters from all permanents.";
            Flavor = "";
        }
    }
    # endregion

    # region Ogre Leadfoot
    public class OgreLeadfootMR : MagicCard
    {
        public OgreLeadfootMR()
        {
            Name = "Ogre Leadfoot";
            Edition = "MR";
            Rarity = "C";
            Color = "R";
            Cost = "4R";
            PT = "3/3";
            Type = "Creature - Ogre";
            Text = "Whenever Ogre Leadfoot becomes blocked by an artifact creature, destroy that creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Omega Myr
    public class OmegaMyrMR : MagicCard
    {
        public OmegaMyrMR()
        {
            Name = "Omega Myr";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "1/2";
            Type = "Artifact Creature - Myr";
            Text = "";
            Flavor = "Last to charge, last to fall.";
        }
    }
    # endregion

    # region One Dozen Eyes
    public class OneDozenEyesMR : MagicCard
    {
        public OneDozenEyesMR()
        {
            Name = "One Dozen Eyes";
            Edition = "MR";
            Rarity = "U";
            Color = "G";
            Cost = "5G";
            PT = "";
            Type = "Sorcery";
            Text = "Choose one � Put a 5/5 green Beast creature token onto the battlefield; or put five 1/1 green Insect creature tokens onto the battlefield.;^Entwine %G%G%G @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Ornithopter
    public class OrnithopterMR : MagicCard
    {
        public OrnithopterMR()
        {
            Name = "Ornithopter";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "0";
            PT = "0/2";
            Type = "Artifact Creature - Thopter";
            Text = "Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Override
    public class OverrideMR : MagicCard
    {
        public OverrideMR()
        {
            Name = "Override";
            Edition = "MR";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell unless its controller pays %1 for each artifact you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Pearl Shard
    public class PearlShardMR : MagicCard
    {
        public PearlShardMR()
        {
            Name = "Pearl Shard";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T or %W, %T: Prevent the next 2 damage that would be dealt to target creature or player this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Pentavus
    public class PentavusMR : MagicCard
    {
        public PentavusMR()
        {
            Name = "Pentavus";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "7";
            PT = "0/0";
            Type = "Artifact Creature - Construct";
            Text = "Pentavus enters the battlefield with five +1/+1 counters on it.;^%1, Remove a +1/+1 counter from Pentavus: Put a 1/1 colorless Pentavite artifact creature token with flying onto the battlefield.;^%1, Sacrifice a Pentavite: Put a +1/+1 counter on Pentavus.";
            Flavor = "";
        }
    }
    # endregion

    # region Pewter Golem
    public class PewterGolemMR : MagicCard
    {
        public PewterGolemMR()
        {
            Name = "Pewter Golem";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "5";
            PT = "4/2";
            Type = "Artifact Creature - Golem";
            Text = "%1%B: Regenerate Pewter Golem.";
            Flavor = "";
        }
    }
    # endregion

    //# region Plains (1)
    //public class Plains(1)MR : MagicCard
    //{
    //    public Plains(1)MR()
    //    {
    //         Name = "Plains (1)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Plains";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Plains (2)
    //public class Plains(2)MR : MagicCard
    //{
    //    public Plains(2)MR()
    //    {
    //         Name = "Plains (2)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Plains";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Plains (3)
    //public class Plains(3)MR : MagicCard
    //{
    //    public Plains(3)MR()
    //    {
    //         Name = "Plains (3)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Plains";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Plains (4)
    //public class Plains(4)MR : MagicCard
    //{
    //    public Plains(4)MR()
    //    {
    //         Name = "Plains (4)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Plains";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    # region Plated Slagwurm
    public class PlatedSlagwurmMR : MagicCard
    {
        public PlatedSlagwurmMR()
        {
            Name = "Plated Slagwurm";
            Edition = "MR";
            Rarity = "R";
            Color = "G";
            Cost = "4GGG";
            PT = "8/8";
            Type = "Creature - Wurm";
            Text = "Hexproof @(This creature can�t be the target of spells or abilities your opponents control.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Platinum Angel
    public class PlatinumAngelMR : MagicCard
    {
        public PlatinumAngelMR()
        {
            Name = "Platinum Angel";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "7";
            PT = "4/4";
            Type = "Artifact Creature - Angel";
            Text = "Flying;^You can�t lose the game and your opponents can�t win the game.";
            Flavor = "";
        }
    }
    # endregion

    # region Power Conduit
    public class PowerConduitMR : MagicCard
    {
        public PowerConduitMR()
        {
            Name = "Power Conduit";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%T, Remove a counter from a permanent you control: Choose one � Put a charge counter on target artifact; or put a +1/+1 counter on target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Predator's Strike
    public class PredatorsStrikeMR : MagicCard
    {
        public PredatorsStrikeMR()
        {
            Name = "Predator's Strike";
            Edition = "MR";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +3/+3 and gains trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Promise of Power
    public class PromiseofPowerMR : MagicCard
    {
        public PromiseofPowerMR()
        {
            Name = "Promise of Power";
            Edition = "MR";
            Rarity = "R";
            Color = "B";
            Cost = "2BBB";
            PT = "";
            Type = "Sorcery";
            Text = "Choose one � You draw five cards and you lose 5 life; or put an X/X black Demon creature token with flying onto the battlefield, where X is the number of cards in your hand as the token enters the battlefield.;^Entwine %4 @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Proteus Staff
    public class ProteusStaffMR : MagicCard
    {
        public ProteusStaffMR()
        {
            Name = "Proteus Staff";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%2%U, %T: Put target creature on the bottom of its owner�s library. That creature�s controller reveals cards from the top of his or her library until he or she reveals a creature card. The player puts that card onto the battlefield and the rest on the bottom of his or her library in any order. Activate this ability only any time you could cast a sorcery.";
            Flavor = "";
        }
    }
    # endregion

    # region Psychic Membrane
    public class PsychicMembraneMR : MagicCard
    {
        public PsychicMembraneMR()
        {
            Name = "Psychic Membrane";
            Edition = "MR";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "0/3";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@;^Whenever Psychic Membrane blocks, you may draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Psychogenic Probe
    public class PsychogenicProbeMR : MagicCard
    {
        public PsychogenicProbeMR()
        {
            Name = "Psychogenic Probe";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a spell or ability causes a player to shuffle his or her library, Psychogenic Probe deals 2 damage to him or her.";
            Flavor = "";
        }
    }
    # endregion

    # region Pyrite Spellbomb
    public class PyriteSpellbombMR : MagicCard
    {
        public PyriteSpellbombMR()
        {
            Name = "Pyrite Spellbomb";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%R, Sacrifice Pyrite Spellbomb: Pyrite Spellbomb deals 2 damage to target creature or player.;^%1, Sacrifice Pyrite Spellbomb: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Quicksilver Elemental
    public class QuicksilverElementalMR : MagicCard
    {
        public QuicksilverElementalMR()
        {
            Name = "Quicksilver Elemental";
            Edition = "MR";
            Rarity = "R";
            Color = "U";
            Cost = "3UU";
            PT = "3/4";
            Type = "Creature - Elemental";
            Text = "%U: Quicksilver Elemental gains all activated abilities of target creature until end of turn. @(If any of the abilities use that creature�s name, use this creature�s name instead.)@;^You may spend blue mana as though it were mana of any color to pay the activation costs of Quicksilver Elemental�s abilities.";
            Flavor = "";
        }
    }
    # endregion

    # region Quicksilver Fountain
    public class QuicksilverFountainMR : MagicCard
    {
        public QuicksilverFountainMR()
        {
            Name = "Quicksilver Fountain";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of each player�s upkeep, that player puts a flood counter on target non-Island land he or she controls of his or her choice. That land is an Island for as long as it has a flood counter on it.;^At the beginning of each end step, if all lands on the battlefield are Islands, remove all flood counters from them.";
            Flavor = "";
        }
    }
    # endregion

    # region Raise the Alarm
    public class RaisetheAlarmMR : MagicCard
    {
        public RaisetheAlarmMR()
        {
            Name = "Raise the Alarm";
            Edition = "MR";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Put two 1/1 white Soldier creature tokens onto the battlefield.";
            Flavor = "";
        }
        
        public override void Resolve()
        {
            base.Resolve();

            for (int i = 0; i < 2; i++)
            {
                MagicCard mc = new MagicCard
                {
                    Name = "Soldier",
                    Type = "Creature - Soldier",
                    PT = "1/1",
                    Token = true,
                };
                PArea.PlayToken(mc);
            }
        }
    }
    # endregion

    # region Razor Barrier
    public class RazorBarrierMR : MagicCard
    {
        public RazorBarrierMR()
        {
            Name = "Razor Barrier";
            Edition = "MR";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Target permanent you control gains protection from artifacts or from the color of your choice until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Regress
    public class RegressMR : MagicCard
    {
        public RegressMR()
        {
            Name = "Regress";
            Edition = "MR";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Instant";
            Text = "Return target permanent to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Reiver Demon
    public class ReiverDemonMR : MagicCard
    {
        public ReiverDemonMR()
        {
            Name = "Reiver Demon";
            Edition = "MR";
            Rarity = "R";
            Color = "B";
            Cost = "4BBBB";
            PT = "6/6";
            Type = "Creature - Demon";
            Text = "Flying;^When Reiver Demon enters the battlefield, if you cast it from your hand, destroy all nonartifact, nonblack creatures. They can�t be regenerated.";
            Flavor = "";
        }
    }
    # endregion

    # region Relic Bane
    public class RelicBaneMR : MagicCard
    {
        public RelicBaneMR()
        {
            Name = "Relic Bane";
            Edition = "MR";
            Rarity = "U";
            Color = "B";
            Cost = "1BB";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant artifact;^Enchanted artifact has �At the beginning of your upkeep, you lose 2 life.�";
            Flavor = "";
        }
    }
    # endregion

    # region Roar of the Kha
    public class RoaroftheKhaMR : MagicCard
    {
        public RoaroftheKhaMR()
        {
            Name = "Roar of the Kha";
            Edition = "MR";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Creatures you control get +1/+1 until end of turn; or untap all creatures you control.;^Entwine %1%W @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Rule of Law
    public class RuleofLawMR : MagicCard
    {
        public RuleofLawMR()
        {
            Name = "Rule of Law";
            Edition = "MR";
            Rarity = "R";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Enchantment";
            Text = "Each player can�t cast more than one spell each turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Rust Elemental
    public class RustElementalMR : MagicCard
    {
        public RustElementalMR()
        {
            Name = "Rust Elemental";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "4/4";
            Type = "Artifact Creature - Elemental";
            Text = "Flying;^At the beginning of your upkeep, sacrifice an artifact other than Rust Elemental. If you can�t, tap Rust Elemental and you lose 4 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Rustmouth Ogre
    public class RustmouthOgreMR : MagicCard
    {
        public RustmouthOgreMR()
        {
            Name = "Rustmouth Ogre";
            Edition = "MR";
            Rarity = "U";
            Color = "R";
            Cost = "4RR";
            PT = "5/4";
            Type = "Creature - Ogre";
            Text = "Whenever Rustmouth Ogre deals combat damage to a player, you may destroy target artifact that player controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Rustspore Ram
    public class RustsporeRamMR : MagicCard
    {
        public RustsporeRamMR()
        {
            Name = "Rustspore Ram";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "1/3";
            Type = "Artifact Creature - Sheep";
            Text = "When Rustspore Ram enters the battlefield, destroy target Equipment.";
            Flavor = "";
        }
    }
    # endregion

    # region Scale of Chiss-Goria
    public class ScaleofChissGoriaMR : MagicCard
    {
        public ScaleofChissGoriaMR()
        {
            Name = "Scale of Chiss-Goria";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Flash;^Affinity for artifacts @(This spell costs %1 less to cast for each artifact you control.)@;^%T: Target creature gets +0/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Scrabbling Claws
    public class ScrabblingClawsMR : MagicCard
    {
        public ScrabblingClawsMR()
        {
            Name = "Scrabbling Claws";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%T: Target player exiles a card from his or her graveyard.;^%1, Sacrifice Scrabbling Claws: Exile target card from a graveyard. Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Sculpting Steel
    public class SculptingSteelMR : MagicCard
    {
        public SculptingSteelMR()
        {
            Name = "Sculpting Steel";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "You may have Sculpting Steel enter the battlefield as a copy of any artifact on the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Scythe of the Wretched
    public class ScytheoftheWretchedMR : MagicCard
    {
        public ScytheoftheWretchedMR()
        {
            Name = "Scythe of the Wretched";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +2/+2.;^Whenever a creature dealt damage by equipped creature this turn dies, return that card to the battlefield under your control. Attach Scythe of the Wretched to that creature.;^Equip %4";
            Flavor = "";
        }
    }
    # endregion

    # region Seat of the Synod
    public class SeatoftheSynodMR : MagicCard
    {
        public SeatoftheSynodMR()
        {
            Name = "Seat of the Synod";
            Edition = "MR";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Artifact Land";
            Text = "@(Seat of the Synod isn�t a spell.)@;^%T: Add %U to your mana pool.";
            Flavor = "";
        }

        public override void DoActivate(int i)
        {
            PArea.mana.blue++;
        }
    }
    # endregion

    # region Second Sunrise
    public class SecondSunriseMR : MagicCard
    {
        public SecondSunriseMR()
        {
            Name = "Second Sunrise";
            Edition = "MR";
            Rarity = "R";
            Color = "W";
            Cost = "1WW";
            PT = "";
            Type = "Instant";
            Text = "Each player returns to the battlefield all artifact, creature, enchantment, and land cards in his or her graveyard that were put there from the battlefield this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Seething Song
    public class SeethingSongMR : MagicCard
    {
        public SeethingSongMR()
        {
            Name = "Seething Song";
            Edition = "MR";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Instant";
            Text = "Add %R%R%R%R%R to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Serum Tank
    public class SerumTankMR : MagicCard
    {
        public SerumTankMR()
        {
            Name = "Serum Tank";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever Serum Tank or another artifact enters the battlefield, put a charge counter on Serum Tank.;^%3, %T, Remove a charge counter from Serum Tank: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Shared Fate
    public class SharedFateMR : MagicCard
    {
        public SharedFateMR()
        {
            Name = "Shared Fate";
            Edition = "MR";
            Rarity = "R";
            Color = "U";
            Cost = "4U";
            PT = "";
            Type = "Enchantment";
            Text = "If a player would draw a card, that player exiles the top card of an opponent�s library face down instead.;^Each player may look at and play cards he or she exiled with Shared Fate.";
            Flavor = "";
        }
    }
    # endregion

    # region Shatter
    public class ShatterMR : MagicCard
    {
        public ShatterMR()
        {
            Name = "Shatter";
            Edition = "MR";
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

    # region Shrapnel Blast
    public class ShrapnelBlastMR : MagicCard
    {
        public ShrapnelBlastMR()
        {
            Name = "Shrapnel Blast";
            Edition = "MR";
            Rarity = "U";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "As an additional cost to cast Shrapnel Blast, sacrifice an artifact.;^Shrapnel Blast deals 5 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Silver Myr
    public class SilverMyrMR : MagicCard
    {
        public SilverMyrMR()
        {
            Name = "Silver Myr";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "1/1";
            Type = "Artifact Creature - Myr";
            Text = "%T: Add %U to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Skeleton Shard
    public class SkeletonShardMR : MagicCard
    {
        public SkeletonShardMR()
        {
            Name = "Skeleton Shard";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "%3, %T or %B, %T: Return target artifact creature card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Skyhunter Cub
    public class SkyhunterCubMR : MagicCard
    {
        public SkyhunterCubMR()
        {
            Name = "Skyhunter Cub";
            Edition = "MR";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Cat Knight";
            Text = "As long as Skyhunter Cub is equipped, it gets +1/+1 and has flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Skyhunter Patrol
    public class SkyhunterPatrolMR : MagicCard
    {
        public SkyhunterPatrolMR()
        {
            Name = "Skyhunter Patrol";
            Edition = "MR";
            Rarity = "C";
            Color = "W";
            Cost = "2WW";
            PT = "2/3";
            Type = "Creature - Cat Knight";
            Text = "Flying, first strike @(This creature can�t be blocked except by creatures with flying or reach, and it deals combat damage before creatures without first strike.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Slagwurm Armor
    public class SlagwurmArmorMR : MagicCard
    {
        public SlagwurmArmorMR()
        {
            Name = "Slagwurm Armor";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +0/+6.;^Equip %3 @(%3: Attach to target creature you control. Equip only as a sorcery. This card enters the battlefield unattached and stays on the battlefield if the creature leaves.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Slith Ascendant
    public class SlithAscendantMR : MagicCard
    {
        public SlithAscendantMR()
        {
            Name = "Slith Ascendant";
            Edition = "MR";
            Rarity = "U";
            Color = "W";
            Cost = "1WW";
            PT = "1/1";
            Type = "Creature - Slith";
            Text = "Flying;^Whenever Slith Ascendant deals combat damage to a player, put a +1/+1 counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Slith Bloodletter
    public class SlithBloodletterMR : MagicCard
    {
        public SlithBloodletterMR()
        {
            Name = "Slith Bloodletter";
            Edition = "MR";
            Rarity = "U";
            Color = "B";
            Cost = "BB";
            PT = "1/1";
            Type = "Creature - Slith";
            Text = "Whenever Slith Bloodletter deals combat damage to a player, put a +1/+1 counter on it.;^%1%B: Regenerate Slith Bloodletter.";
            Flavor = "";
        }
    }
    # endregion

    # region Slith Firewalker
    public class SlithFirewalkerMR : MagicCard
    {
        public SlithFirewalkerMR()
        {
            Name = "Slith Firewalker";
            Edition = "MR";
            Rarity = "U";
            Color = "R";
            Cost = "RR";
            PT = "1/1";
            Type = "Creature - Slith";
            Text = "Haste;^Whenever Slith Firewalker deals combat damage to a player, put a +1/+1 counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Slith Predator
    public class SlithPredatorMR : MagicCard
    {
        public SlithPredatorMR()
        {
            Name = "Slith Predator";
            Edition = "MR";
            Rarity = "U";
            Color = "G";
            Cost = "GG";
            PT = "1/1";
            Type = "Creature - Slith";
            Text = "Trample;^Whenever Slith Predator deals combat damage to a player, put a +1/+1 counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Slith Strider
    public class SlithStriderMR : MagicCard
    {
        public SlithStriderMR()
        {
            Name = "Slith Strider";
            Edition = "MR";
            Rarity = "U";
            Color = "U";
            Cost = "1UU";
            PT = "1/1";
            Type = "Creature - Slith";
            Text = "Whenever Slith Strider becomes blocked, draw a card.;^Whenever Slith Strider deals combat damage to a player, put a +1/+1 counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Solar Tide
    public class SolarTideMR : MagicCard
    {
        public SolarTideMR()
        {
            Name = "Solar Tide";
            Edition = "MR";
            Rarity = "R";
            Color = "W";
            Cost = "4WW";
            PT = "";
            Type = "Sorcery";
            Text = "Choose one � Destroy all creatures with power 2 or less; or destroy all creatures with power 3 or greater.;^Entwine�Sacrifice two lands. @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Soldier Replica
    public class SoldierReplicaMR : MagicCard
    {
        public SoldierReplicaMR()
        {
            Name = "Soldier Replica";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "1/3";
            Type = "Artifact Creature - Soldier";
            Text = "%1%W, Sacrifice Soldier Replica: Soldier Replica deals 3 damage to target attacking or blocking creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Solemn Simulacrum
    public class SolemnSimulacrumMR : MagicCard
    {
        public SolemnSimulacrumMR()
        {
            Name = "Solemn Simulacrum";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "2/2";
            Type = "Artifact Creature - Golem";
            Text = "When Solemn Simulacrum enters the battlefield, you may search your library for a basic land card, put that card onto the battlefield tapped, then shuffle your library.;^When Solemn Simulacrum dies, you may draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Somber Hoverguard
    public class SomberHoverguardMR : MagicCard
    {
        public SomberHoverguardMR()
        {
            Name = "Somber Hoverguard";
            Edition = "MR";
            Rarity = "C";
            Color = "U";
            Cost = "5U";
            PT = "3/2";
            Type = "Creature - Drone";
            Text = "Affinity for artifacts @(This spell costs %1 less to cast for each artifact you control.)@;^Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Soul Foundry
    public class SoulFoundryMR : MagicCard
    {
        public SoulFoundryMR()
        {
            Name = "Soul Foundry";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "@Imprint@ � When Soul Foundry enters the battlefield, you may exile a creature card from your hand.;^%X, %T: Put a token that�s a copy of the exiled card onto the battlefield. X is the converted mana cost of that card.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul Nova
    public class SoulNovaMR : MagicCard
    {
        public SoulNovaMR()
        {
            Name = "Soul Nova";
            Edition = "MR";
            Rarity = "U";
            Color = "W";
            Cost = "3WW";
            PT = "";
            Type = "Instant";
            Text = "Exile target attacking creature and all Equipment attached to it.";
            Flavor = "";
        }
    }
    # endregion

    # region Spellweaver Helix
    public class SpellweaverHelixMR : MagicCard
    {
        public SpellweaverHelixMR()
        {
            Name = "Spellweaver Helix";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "@Imprint@ � When Spellweaver Helix enters the battlefield, you may exile two target sorcery cards from a single graveyard.;^Whenever a player casts a card, if it has the same name as one of the cards exiled with Spellweaver Helix, you may copy the other. If you do, you may cast the copy without paying its mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Sphere of Purity
    public class SphereofPurityMR : MagicCard
    {
        public SphereofPurityMR()
        {
            Name = "Sphere of Purity";
            Edition = "MR";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Enchantment";
            Text = "If an artifact would deal damage to you, prevent 1 of that damage.";
            Flavor = "";
        }
    }
    # endregion

    # region Spikeshot Goblin
    public class SpikeshotGoblinMR : MagicCard
    {
        public SpikeshotGoblinMR()
        {
            Name = "Spikeshot Goblin";
            Edition = "MR";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "1/2";
            Type = "Creature - Goblin Shaman";
            Text = "%R, %T: Spikeshot Goblin deals damage equal to its power to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Spoils of the Vault
    public class SpoilsoftheVaultMR : MagicCard
    {
        public SpoilsoftheVaultMR()
        {
            Name = "Spoils of the Vault";
            Edition = "MR";
            Rarity = "R";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "Name a card. Reveal cards from the top of your library until you reveal the named card, then put that card into your hand. Exile all other cards revealed this way, and you lose 1 life for each of the exiled cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Stalking Stones
    public class StalkingStonesMR : MagicCard
    {
        public StalkingStonesMR()
        {
            Name = "Stalking Stones";
            Edition = "MR";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%6: Stalking Stones becomes a 3/3 Elemental artifact creature that�s still a land. @(This effect lasts indefinitely.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Steel Wall
    public class SteelWallMR : MagicCard
    {
        public SteelWallMR()
        {
            Name = "Steel Wall";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "0/4";
            Type = "Artifact Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Sun Droplet
    public class SunDropletMR : MagicCard
    {
        public SunDropletMR()
        {
            Name = "Sun Droplet";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Whenever you�re dealt damage, put that many charge counters on Sun Droplet.;^At the beginning of each upkeep, you may remove a charge counter from Sun Droplet. If you do, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Sunbeam Spellbomb
    public class SunbeamSpellbombMR : MagicCard
    {
        public SunbeamSpellbombMR()
        {
            Name = "Sunbeam Spellbomb";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%W, Sacrifice Sunbeam Spellbomb: You gain 5 life.;^%1, Sacrifice Sunbeam Spellbomb: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    //# region Swamp (1)
    //public class Swamp(1)MR : MagicCard
    //{
    //    public Swamp(1)MR()
    //    {
    //         Name = "Swamp (1)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Swamp";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Swamp (2)
    //public class Swamp(2)MR : MagicCard
    //{
    //    public Swamp(2)MR()
    //    {
    //         Name = "Swamp (2)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Swamp";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Swamp (3)
    //public class Swamp(3)MR : MagicCard
    //{
    //    public Swamp(3)MR()
    //    {
    //         Name = "Swamp (3)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Swamp";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    //# region Swamp (4)
    //public class Swamp(4)MR : MagicCard
    //{
    //    public Swamp(4)MR()
    //    {
    //         Name = "Swamp (4)";
    //         Edition = "MR";
    //         Rarity = "C";
    //         Color = "Lnd";
    //         Cost = "";
    //         PT = "";
    //         Type = "Basic Land - Swamp";
    //         Text = "";
    //         Flavor = "";
    //    }
    //}
    //# endregion

    # region Sword of Kaldra
    public class SwordofKaldraMR : MagicCard
    {
        public SwordofKaldraMR()
        {
            Name = "Sword of Kaldra";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Legendary Artifact - Equipment";
            Text = "Equipped creature gets +5/+5.;^Whenever equipped creature deals damage to a creature, exile that creature.;^Equip %4 @(%4: Attach to target creature you control. Equip only as a sorcery. This card enters the battlefield unattached and stays on the battlefield if the creature leaves.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Sylvan Scrying
    public class SylvanScryingMR : MagicCard
    {
        public SylvanScryingMR()
        {
            Name = "Sylvan Scrying";
            Edition = "MR";
            Rarity = "U";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Sorcery";
            Text = "Search your library for a land card, reveal it, and put it into your hand. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Synod Sanctum
    public class SynodSanctumMR : MagicCard
    {
        public SynodSanctumMR()
        {
            Name = "Synod Sanctum";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T: Exile target permanent you control.;^%2, Sacrifice Synod Sanctum: Return all cards exiled with Synod Sanctum to the battlefield under your control.";
            Flavor = "";
        }
    }
    # endregion

    # region Taj-Nar Swordsmith
    public class TajNarSwordsmithMR : MagicCard
    {
        public TajNarSwordsmithMR()
        {
            Name = "Taj-Nar Swordsmith";
            Edition = "MR";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "2/3";
            Type = "Creature - Cat Soldier";
            Text = "When Taj-Nar Swordsmith enters the battlefield, you may pay %X. If you do, search your library for an Equipment card with converted mana cost X or less and put that card onto the battlefield. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Talisman of Dominance
    public class TalismanofDominanceMR : MagicCard
    {
        public TalismanofDominanceMR()
        {
            Name = "Talisman of Dominance";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %1 to your mana pool.;^%T: Add %U or %B to your mana pool. Talisman of Dominance deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Talisman of Impulse
    public class TalismanofImpulseMR : MagicCard
    {
        public TalismanofImpulseMR()
        {
            Name = "Talisman of Impulse";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %1 to your mana pool.;^%T: Add %R or %G to your mana pool. Talisman of Impulse deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Talisman of Indulgence
    public class TalismanofIndulgenceMR : MagicCard
    {
        public TalismanofIndulgenceMR()
        {
            Name = "Talisman of Indulgence";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %1 to your mana pool.;^%T: Add %B or %R to your mana pool. Talisman of Indulgence deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Talisman of Progress
    public class TalismanofProgressMR : MagicCard
    {
        public TalismanofProgressMR()
        {
            Name = "Talisman of Progress";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %1 to your mana pool.;^%T: Add %W or %U to your mana pool. Talisman of Progress deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Talisman of Unity
    public class TalismanofUnityMR : MagicCard
    {
        public TalismanofUnityMR()
        {
            Name = "Talisman of Unity";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%T: Add %1 to your mana pool.;^%T: Add %G or %W to your mana pool. Talisman of Unity deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Tanglebloom
    public class TanglebloomMR : MagicCard
    {
        public TanglebloomMR()
        {
            Name = "Tanglebloom";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%1, %T: You gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Tangleroot
    public class TanglerootMR : MagicCard
    {
        public TanglerootMR()
        {
            Name = "Tangleroot";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a player casts a creature spell, that player adds %G to his or her mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Tel-Jilad Archers
    public class TelJiladArchersMR : MagicCard
    {
        public TelJiladArchersMR()
        {
            Name = "Tel-Jilad Archers";
            Edition = "MR";
            Rarity = "C";
            Color = "G";
            Cost = "4G";
            PT = "2/4";
            Type = "Creature - Elf Archer";
            Text = "Protection from artifacts; reach @(This creature can block creatures with flying.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Tel-Jilad Chosen
    public class TelJiladChosenMR : MagicCard
    {
        public TelJiladChosenMR()
        {
            Name = "Tel-Jilad Chosen";
            Edition = "MR";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "2/1";
            Type = "Creature - Elf Warrior";
            Text = "Protection from artifacts";
            Flavor = "";
        }
    }
    # endregion

    # region Tel-Jilad Exile
    public class TelJiladExileMR : MagicCard
    {
        public TelJiladExileMR()
        {
            Name = "Tel-Jilad Exile";
            Edition = "MR";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "2/3";
            Type = "Creature - Troll Warrior";
            Text = "%1%G: Regenerate Tel-Jilad Exile.";
            Flavor = "";
        }
    }
    # endregion

    # region Tel-Jilad Stylus
    public class TelJiladStylusMR : MagicCard
    {
        public TelJiladStylusMR()
        {
            Name = "Tel-Jilad Stylus";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%T: Put target permanent you own on the bottom of your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Tempest of Light
    public class TempestofLightMR : MagicCard
    {
        public TempestofLightMR()
        {
            Name = "Tempest of Light";
            Edition = "MR";
            Rarity = "U";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Instant";
            Text = "Destroy all enchantments.";
            Flavor = "";
        }
    }
    # endregion

    # region Temporal Cascade
    public class TemporalCascadeMR : MagicCard
    {
        public TemporalCascadeMR()
        {
            Name = "Temporal Cascade";
            Edition = "MR";
            Rarity = "R";
            Color = "U";
            Cost = "5UU";
            PT = "";
            Type = "Sorcery";
            Text = "Choose one � Each player shuffles his or her hand and graveyard into his or her library; or each player draws seven cards.;^Entwine %2 @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Terror
    public class TerrorMR : MagicCard
    {
        public TerrorMR()
        {
            Name = "Terror";
            Edition = "MR";
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

    # region Thirst for Knowledge
    public class ThirstforKnowledgeMR : MagicCard
    {
        public ThirstforKnowledgeMR()
        {
            Name = "Thirst for Knowledge";
            Edition = "MR";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Instant";
            Text = "Draw three cards. Then discard two cards unless you discard an artifact card.";
            Flavor = "";
        }
    }
    # endregion

    # region Thought Prison
    public class ThoughtPrisonMR : MagicCard
    {
        public ThoughtPrisonMR()
        {
            Name = "Thought Prison";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "@Imprint@ � When Thought Prison enters the battlefield, you may have target player reveal his or her hand. If you do, choose a nonland card from it and exile that card.;^Whenever a player casts a spell that shares a color or converted mana cost with the exiled card, Thought Prison deals 2 damage to that player.";
            Flavor = "";
        }
    }
    # endregion

    # region Thoughtcast
    public class ThoughtcastMR : MagicCard
    {
        public ThoughtcastMR()
        {
            Name = "Thoughtcast";
            Edition = "MR";
            Rarity = "C";
            Color = "U";
            Cost = "4U";
            PT = "";
            Type = "Sorcery";
            Text = "Affinity for artifacts @(This spell costs %1 less to cast for each artifact you control.)@;^Draw two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Timesifter
    public class TimesifterMR : MagicCard
    {
        public TimesifterMR()
        {
            Name = "Timesifter";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of each upkeep, each player exiles the top card of his or her library. The player who exiled the card with the highest converted mana cost takes an extra turn after this one. If two or more players� cards are tied for highest cost, the tied players repeat this process until the tie is broken.";
            Flavor = "";
        }
    }
    # endregion

    # region Titanium Golem
    public class TitaniumGolemMR : MagicCard
    {
        public TitaniumGolemMR()
        {
            Name = "Titanium Golem";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "5";
            PT = "3/3";
            Type = "Artifact Creature - Golem";
            Text = "%1%W: Titanium Golem gains first strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Tooth and Nail
    public class ToothandNailMR : MagicCard
    {
        public ToothandNailMR()
        {
            Name = "Tooth and Nail";
            Edition = "MR";
            Rarity = "R";
            Color = "G";
            Cost = "5GG";
            PT = "";
            Type = "Sorcery";
            Text = "Choose one � Search your library for up to two creature cards, reveal them, put them into your hand, then shuffle your library; or put up to two creature cards from your hand onto the battlefield.;^Entwine %2 @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Tooth of Chiss-Goria
    public class ToothofChissGoriaMR : MagicCard
    {
        public ToothofChissGoriaMR()
        {
            Name = "Tooth of Chiss-Goria";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Flash;^Affinity for artifacts @(This spell costs %1 less to cast for each artifact you control.)@;^%T: Target creature gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Tower of Champions
    public class TowerofChampionsMR : MagicCard
    {
        public TowerofChampionsMR()
        {
            Name = "Tower of Champions";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%8, %T: Target creature gets +6/+6 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Tower of Eons
    public class TowerofEonsMR : MagicCard
    {
        public TowerofEonsMR()
        {
            Name = "Tower of Eons";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%8, %T: You gain 10 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Tower of Fortunes
    public class TowerofFortunesMR : MagicCard
    {
        public TowerofFortunesMR()
        {
            Name = "Tower of Fortunes";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%8, %T: Draw four cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Tower of Murmurs
    public class TowerofMurmursMR : MagicCard
    {
        public TowerofMurmursMR()
        {
            Name = "Tower of Murmurs";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%8, %T: Target player puts the top eight cards of his or her library into his or her graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Trash for Treasure
    public class TrashforTreasureMR : MagicCard
    {
        public TrashforTreasureMR()
        {
            Name = "Trash for Treasure";
            Edition = "MR";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Sorcery";
            Text = "As an additional cost to cast Trash for Treasure, sacrifice an artifact.;^Return target artifact card from your graveyard to the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Tree of Tales
    public class TreeofTalesMR : MagicCard
    {
        public TreeofTalesMR()
        {
            Name = "Tree of Tales";
            Edition = "MR";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Artifact Land";
            Text = "@(Tree of Tales isn�t a spell.)@;^%T: Add %G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Triskelion
    public class TriskelionMR : MagicCard
    {
        public TriskelionMR()
        {
            Name = "Triskelion";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "6";
            PT = "1/1";
            Type = "Artifact Creature - Construct";
            Text = "Triskelion enters the battlefield with three +1/+1 counters on it.;^Remove a +1/+1 counter from Triskelion: Triskelion deals 1 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Troll Ascetic
    public class TrollAsceticMR : MagicCard
    {
        public TrollAsceticMR()
        {
            Name = "Troll Ascetic";
            Edition = "MR";
            Rarity = "R";
            Color = "G";
            Cost = "1GG";
            PT = "3/2";
            Type = "Creature - Troll Shaman";
            Text = "Hexproof @(This creature can�t be the target of spells or abilities your opponents control.)@;^%1%G: Regenerate Troll Ascetic.";
            Flavor = "";
        }
    }
    # endregion

    # region Trolls of Tel-Jilad
    public class TrollsofTelJiladMR : MagicCard
    {
        public TrollsofTelJiladMR()
        {
            Name = "Trolls of Tel-Jilad";
            Edition = "MR";
            Rarity = "U";
            Color = "G";
            Cost = "5GG";
            PT = "5/6";
            Type = "Creature - Troll Shaman";
            Text = "%1%G: Regenerate target green creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Turn to Dust
    public class TurntoDustMR : MagicCard
    {
        public TurntoDustMR()
        {
            Name = "Turn to Dust";
            Edition = "MR";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Destroy target Equipment. Add %G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Vault of Whispers
    public class VaultofWhispersMR : MagicCard
    {
        public VaultofWhispersMR()
        {
            Name = "Vault of Whispers";
            Edition = "MR";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Artifact Land";
            Text = "@(Vault of Whispers isn�t a spell.)@;^%T: Add %B to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Vedalken Archmage
    public class VedalkenArchmageMR : MagicCard
    {
        public VedalkenArchmageMR()
        {
            Name = "Vedalken Archmage";
            Edition = "MR";
            Rarity = "R";
            Color = "U";
            Cost = "2UU";
            PT = "0/2";
            Type = "Creature - Vedalken Wizard";
            Text = "Whenever you cast an artifact spell, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Vermiculos
    public class VermiculosMR : MagicCard
    {
        public VermiculosMR()
        {
            Name = "Vermiculos";
            Edition = "MR";
            Rarity = "R";
            Color = "B";
            Cost = "4B";
            PT = "1/1";
            Type = "Creature - Horror";
            Text = "Whenever an artifact enters the battlefield, Vermiculos gets +4/+4 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Viridian Joiner
    public class ViridianJoinerMR : MagicCard
    {
        public ViridianJoinerMR()
        {
            Name = "Viridian Joiner";
            Edition = "MR";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "1/2";
            Type = "Creature - Elf Druid";
            Text = "%T: Add to your mana pool an amount of %G equal to Viridian Joiner�s power.";
            Flavor = "";
        }
    }
    # endregion

    # region Viridian Longbow
    public class ViridianLongbowMR : MagicCard
    {
        public ViridianLongbowMR()
        {
            Name = "Viridian Longbow";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature has �%T: This creature deals 1 damage to target creature or player.�;^Equip %3 @(%3: Attach to target creature you control. Equip only as a sorcery. This card enters the battlefield unattached and stays on the battlefield if the creature leaves.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Viridian Shaman
    public class ViridianShamanMR : MagicCard
    {
        public ViridianShamanMR()
        {
            Name = "Viridian Shaman";
            Edition = "MR";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Elf Shaman";
            Text = "When Viridian Shaman enters the battlefield, destroy target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Vorrac Battlehorns
    public class VorracBattlehornsMR : MagicCard
    {
        public VorracBattlehornsMR()
        {
            Name = "Vorrac Battlehorns";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature has trample and can�t be blocked by more than one creature.;^Equip %1 @(%1: Attach to target creature you control. Equip only as a sorcery. This card enters the battlefield unattached and stays on the battlefield if the creature leaves.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Vulshok Battlegear
    public class VulshokBattlegearMR : MagicCard
    {
        public VulshokBattlegearMR()
        {
            Name = "Vulshok Battlegear";
            Edition = "MR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +3/+3.;^Equip %3 @(%3: Attach to target creature you control. Equip only as a sorcery. This card enters the battlefield unattached and stays on the battlefield if the creature leaves.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Vulshok Battlemaster
    public class VulshokBattlemasterMR : MagicCard
    {
        public VulshokBattlemasterMR()
        {
            Name = "Vulshok Battlemaster";
            Edition = "MR";
            Rarity = "R";
            Color = "R";
            Cost = "4R";
            PT = "2/2";
            Type = "Creature - Human Warrior";
            Text = "Haste;^When Vulshok Battlemaster enters the battlefield, attach all Equipment on the battlefield to it. @(Control of the Equipment doesn�t change.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Vulshok Berserker
    public class VulshokBerserkerMR : MagicCard
    {
        public VulshokBerserkerMR()
        {
            Name = "Vulshok Berserker";
            Edition = "MR";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "3/2";
            Type = "Creature - Human Berserker";
            Text = "Haste @(This creature can attack and %T as soon as it comes under your control.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Vulshok Gauntlets
    public class VulshokGauntletsMR : MagicCard
    {
        public VulshokGauntletsMR()
        {
            Name = "Vulshok Gauntlets";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +4/+2 and doesn�t untap during its controller�s untap step.;^Equip %3 @(%3: Attach to target creature you control. Equip only as a sorcery. This card enters the battlefield unattached and stays on the battlefield if the creature leaves.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wail of the Nim
    public class WailoftheNimMR : MagicCard
    {
        public WailoftheNimMR()
        {
            Name = "Wail of the Nim";
            Edition = "MR";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Regenerate each creature you control; or Wail of the Nim deals 1 damage to each creature and each player.;^Entwine %B @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wall of Blood
    public class WallofBloodMR : MagicCard
    {
        public WallofBloodMR()
        {
            Name = "Wall of Blood";
            Edition = "MR";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "0/2";
            Type = "Creature - Wall";
            Text = "Defender @(This creature can�t attack.)@;^Pay 1 life: Wall of Blood gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Wanderguard Sentry
    public class WanderguardSentryMR : MagicCard
    {
        public WanderguardSentryMR()
        {
            Name = "Wanderguard Sentry";
            Edition = "MR";
            Rarity = "C";
            Color = "U";
            Cost = "4U";
            PT = "3/3";
            Type = "Creature - Drone";
            Text = "When Wanderguard Sentry enters the battlefield, look at target opponent�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region War Elemental
    public class WarElementalMR : MagicCard
    {
        public WarElementalMR()
        {
            Name = "War Elemental";
            Edition = "MR";
            Rarity = "R";
            Color = "R";
            Cost = "RRR";
            PT = "1/1";
            Type = "Creature - Elemental";
            Text = "When War Elemental enters the battlefield, sacrifice it unless an opponent was dealt damage this turn.;^Whenever an opponent is dealt damage, put that many +1/+1 counters on War Elemental.";
            Flavor = "";
        }
    }
    # endregion

    # region Welding Jar
    public class WeldingJarMR : MagicCard
    {
        public WeldingJarMR()
        {
            Name = "Welding Jar";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "0";
            PT = "";
            Type = "Artifact";
            Text = "Sacrifice Welding Jar: Regenerate target artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Wizard Replica
    public class WizardReplicaMR : MagicCard
    {
        public WizardReplicaMR()
        {
            Name = "Wizard Replica";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "1/3";
            Type = "Artifact Creature - Wizard";
            Text = "Flying;^%U, Sacrifice Wizard Replica: Counter target spell unless its controller pays %2.";
            Flavor = "";
        }
    }
    # endregion

    # region Woebearer
    public class WoebearerMR : MagicCard
    {
        public WoebearerMR()
        {
            Name = "Woebearer";
            Edition = "MR";
            Rarity = "U";
            Color = "B";
            Cost = "4B";
            PT = "2/3";
            Type = "Creature - Zombie";
            Text = "Fear @(This creature can�t be blocked except by artifact creatures and/or black creatures.)@;^Whenever Woebearer deals combat damage to a player, you may return target creature card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Worldslayer
    public class WorldslayerMR : MagicCard
    {
        public WorldslayerMR()
        {
            Name = "Worldslayer";
            Edition = "MR";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Whenever equipped creature deals combat damage to a player, destroy all permanents other than Worldslayer.;^Equip %5 @(%5: Attach to target creature you control. Equip only as a sorcery.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wrench Mind
    public class WrenchMindMR : MagicCard
    {
        public WrenchMindMR()
        {
            Name = "Wrench Mind";
            Edition = "MR";
            Rarity = "C";
            Color = "B";
            Cost = "BB";
            PT = "";
            Type = "Sorcery";
            Text = "Target player discards two cards unless he or she discards an artifact card.";
            Flavor = "";
        }
    }
    # endregion

    # region Wurmskin Forger
    public class WurmskinForgerMR : MagicCard
    {
        public WurmskinForgerMR()
        {
            Name = "Wurmskin Forger";
            Edition = "MR";
            Rarity = "C";
            Color = "G";
            Cost = "5GG";
            PT = "2/2";
            Type = "Creature - Elf Warrior";
            Text = "When Wurmskin Forger enters the battlefield, distribute three +1/+1 counters among one, two, or three target creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Yotian Soldier
    public class YotianSoldierMR : MagicCard
    {
        public YotianSoldierMR()
        {
            Name = "Yotian Soldier";
            Edition = "MR";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "1/4";
            Type = "Artifact Creature - Soldier";
            Text = "Vigilance";
            Flavor = "";
        }
    }
    # endregion

    # endregion
}
