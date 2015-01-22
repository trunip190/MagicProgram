using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
    # region Modern Masters
    # region Absorb Vis
    public class AbsorbVisMMA : MagicCard
    {
        public AbsorbVisMMA()
        {
            Name = "Absorb Vis";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "6B";
            PT = "";
            Type = "Sorcery";
            Text = "Target player loses 4 life and you gain 4 life.;^Basic landcycling %1%B @(%1%B, Discard this card: Search your library for a basic land card, reveal it, and put it into your hand. Then shuffle your library.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Academy Ruins
    public class AcademyRuinsMMA : MagicCard
    {
        public AcademyRuinsMMA()
        {
            Name = "Academy Ruins";
            Edition = "MMA";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Legendary Land";
            Text = "%T: Add %1 to your mana pool.;^%1%U, %T: Put target artifact card from your graveyard on top of your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Adarkar Valkyrie
    public class AdarkarValkyrieMMA : MagicCard
    {
        public AdarkarValkyrieMMA()
        {
            Name = "Adarkar Valkyrie";
            Edition = "MMA";
            Rarity = "R";
            Color = "W";
            Cost = "4WW";
            PT = "4/5";
            Type = "Snow Creature - Angel";
            Text = "Flying, vigilance;^%T: When target creature other than Adarkar Valkyrie dies this turn, return that card to the battlefield under your control.";
            Flavor = "";
        }
    }
    # endregion

    # region AEther Spellbomb
    public class AEtherSpellbombMMA : MagicCard
    {
        public AEtherSpellbombMMA()
        {
            Name = "AEther Spellbomb";
            Edition = "MMA";
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

    # region AEther Vial
    public class AEtherVialMMA : MagicCard
    {
        public AEtherVialMMA()
        {
            Name = "AEther Vial";
            Edition = "MMA";
            Rarity = "R";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "At the beginning of your upkeep, you may put a charge counter on AEther Vial.;^%T: You may put a creature card with converted mana cost equal to the number of charge counters on AEther Vial from your hand onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region AEthersnipe
    public class AEthersnipeMMA : MagicCard
    {
        public AEthersnipeMMA()
        {
            Name = "AEthersnipe";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "5U";
            PT = "4/4";
            Type = "Creature - Elemental";
            Text = "When AEthersnipe enters the battlefield, return target nonland permanent to its owner�s hand.;^Evoke %1%U%U @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Amrou Scout
    public class AmrouScoutMMA : MagicCard
    {
        public AmrouScoutMMA()
        {
            Name = "Amrou Scout";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "2/1";
            Type = "Creature - Kithkin Rebel Scout";
            Text = "%4, %T: Search your library for a Rebel permanent card with converted mana cost 3 or less and put it onto the battlefield. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Amrou Seekers
    public class AmrouSeekersMMA : MagicCard
    {
        public AmrouSeekersMMA()
        {
            Name = "Amrou Seekers";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Kithkin Rebel";
            Text = "Amrou Seekers can�t be blocked except by artifact creatures and/or white creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Angel's Grace
    public class AngelsGraceMMA : MagicCard
    {
        public AngelsGraceMMA()
        {
            Name = "Angel's Grace";
            Edition = "MMA";
            Rarity = "R";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Split second @(As long as this spell is on the stack, players can�t cast spells or activate abilities that aren�t mana abilities.)@;^You can�t lose the game this turn and your opponents can�t win the game this turn. Until end of turn, damage that would reduce your life total to less than 1 reduces it to 1 instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Arcbound Ravager
    public class ArcboundRavagerMMA : MagicCard
    {
        public ArcboundRavagerMMA()
        {
            Name = "Arcbound Ravager";
            Edition = "MMA";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "0/0";
            Type = "Artifact Creature - Beast";
            Text = "Sacrifice an artifact: Put a +1/+1 counter on Arcbound Ravager.;^Modular 1 @(This enters the battlefield with a +1/+1 counter on it. When it dies, you may put its +1/+1 counters on target artifact creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Arcbound Stinger
    public class ArcboundStingerMMA : MagicCard
    {
        public ArcboundStingerMMA()
        {
            Name = "Arcbound Stinger";
            Edition = "MMA";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "0/0";
            Type = "Artifact Creature - Insect";
            Text = "Flying;^Modular 1 @(This enters the battlefield with a +1/+1 counter on it. When it dies, you may put its +1/+1 counters on target artifact creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Arcbound Wanderer
    public class ArcboundWandererMMA : MagicCard
    {
        public ArcboundWandererMMA()
        {
            Name = "Arcbound Wanderer";
            Edition = "MMA";
            Rarity = "C";
            Color = "Art";
            Cost = "6";
            PT = "0/0";
            Type = "Artifact Creature - Golem";
            Text = "Modular�Sunburst @(This enters the battlefield with a +1/+1 counter on it for each color of mana spent to cast it. When it dies, you may put its +1/+1 counters on target artifact creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Arcbound Worker
    public class ArcboundWorkerMMA : MagicCard
    {
        public ArcboundWorkerMMA()
        {
            Name = "Arcbound Worker";
            Edition = "MMA";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "0/0";
            Type = "Artifact Creature - Construct";
            Text = "Modular 1 @(This enters the battlefield with a +1/+1 counter on it. When it dies, you may put its +1/+1 counters on target artifact creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Auntie's Snitch
    public class AuntiesSnitchMMA : MagicCard
    {
        public AuntiesSnitchMMA()
        {
            Name = "Auntie's Snitch";
            Edition = "MMA";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "3/1";
            Type = "Creature - Goblin Rogue";
            Text = "Auntie�s Snitch can�t block.;^Prowl %1%B @(You may cast this for its prowl cost if you dealt combat damage to a player this turn with a Goblin or Rogue.)@;^Whenever a Goblin or Rogue you control deals combat damage to a player, if Auntie�s Snitch is in your graveyard, you may return Auntie�s Snitch to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Auriok Salvagers
    public class AuriokSalvagersMMA : MagicCard
    {
        public AuriokSalvagersMMA()
        {
            Name = "Auriok Salvagers";
            Edition = "MMA";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "2/4";
            Type = "Creature - Human Soldier";
            Text = "%1%W: Return target artifact card with converted mana cost 1 or less from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Avian Changeling
    public class AvianChangelingMMA : MagicCard
    {
        public AvianChangelingMMA()
        {
            Name = "Avian Changeling";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Blightspeaker
    public class BlightspeakerMMA : MagicCard
    {
        public BlightspeakerMMA()
        {
            Name = "Blightspeaker";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "1/1";
            Type = "Creature - Human Rebel Cleric";
            Text = "%T: Target player loses 1 life.;^%4, %T: Search your library for a Rebel permanent card with converted mana cost 3 or less and put it onto the battlefield. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Blinding Beam
    public class BlindingBeamMMA : MagicCard
    {
        public BlindingBeamMMA()
        {
            Name = "Blinding Beam";
            Edition = "MMA";
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

    # region Blind-Spot Giant
    public class BlindSpotGiantMMA : MagicCard
    {
        public BlindSpotGiantMMA()
        {
            Name = "Blind-Spot Giant";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "4/3";
            Type = "Creature - Giant Warrior";
            Text = "Blind-Spot Giant can�t attack or block unless you control another Giant.";
            Flavor = "";
        }
    }
    # endregion

    # region Blinkmoth Nexus
    public class BlinkmothNexusMMA : MagicCard
    {
        public BlinkmothNexusMMA()
        {
            Name = "Blinkmoth Nexus";
            Edition = "MMA";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%1: Blinkmoth Nexus becomes a 1/1 Blinkmoth artifact creature with flying until end of turn. It�s still a land.;^%1, %T: Target Blinkmoth creature gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Blood Moon
    public class BloodMoonMMA : MagicCard
    {
        public BloodMoonMMA()
        {
            Name = "Blood Moon";
            Edition = "MMA";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Enchantment";
            Text = "Nonbasic lands are mountains.";
            Flavor = "";
        }
    }
    # endregion

    # region Bonesplitter
    public class BonesplitterMMA : MagicCard
    {
        public BonesplitterMMA()
        {
            Name = "Bonesplitter";
            Edition = "MMA";
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

    # region Bound in Silence
    public class BoundinSilenceMMA : MagicCard
    {
        public BoundinSilenceMMA()
        {
            Name = "Bound in Silence";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Tribal Enchantment - Rebel Aura";
            Text = "Enchant creature;^Enchanted creature can�t attack or block.";
            Flavor = "";
        }
    }
    # endregion

    # region Bridge from Below
    public class BridgefromBelowMMA : MagicCard
    {
        public BridgefromBelowMMA()
        {
            Name = "Bridge from Below";
            Edition = "MMA";
            Rarity = "R";
            Color = "B";
            Cost = "BBB";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a nontoken creature is put into your graveyard from the battlefield, if Bridge from Below is in your graveyard, put a 2/2 black Zombie creature token onto the battlefield.;^When a creature is put into an opponent�s graveyard from the battlefield, if Bridge from Below is in your graveyard, exile Bridge from Below.";
            Flavor = "";
        }
    }
    # endregion

    # region Brute Force
    public class BruteForceMMA : MagicCard
    {
        public BruteForceMMA()
        {
            Name = "Brute Force";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +3/+3 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Careful Consideration
    public class CarefulConsiderationMMA : MagicCard
    {
        public CarefulConsiderationMMA()
        {
            Name = "Careful Consideration";
            Edition = "MMA";
            Rarity = "U";
            Color = "U";
            Cost = "2UU";
            PT = "";
            Type = "Instant";
            Text = "Target player draws four cards, then discards three cards. If you cast this spell during your main phase, instead that player draws four cards, then discards two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Cenn's Enlistment
    public class CennsEnlistmentMMA : MagicCard
    {
        public CennsEnlistmentMMA()
        {
            Name = "Cenn's Enlistment";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Sorcery";
            Text = "Put two 1/1 white Kithkin Soldier creature tokens onto the battlefield.;^Retrace @(You may cast this card from your graveyard by discarding a land card in addition to paying its other costs.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Chalice of the Void
    public class ChaliceoftheVoidMMA : MagicCard
    {
        public ChaliceoftheVoidMMA()
        {
            Name = "Chalice of the Void";
            Edition = "MMA";
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

    # region Citanul Woodreaders
    public class CitanulWoodreadersMMA : MagicCard
    {
        public CitanulWoodreadersMMA()
        {
            Name = "Citanul Woodreaders";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "1/4";
            Type = "Creature - Human Druid";
            Text = "Kicker %2%G @(You may pay an additional %2%G as you cast this spell.)@;^When Citanul Woodreaders enters the battlefield, if it was kicked, draw two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region City of Brass
    public class CityofBrassMMA : MagicCard
    {
        public CityofBrassMMA()
        {
            Name = "City of Brass";
            Edition = "MMA";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Whenever City of Brass becomes tapped, it deals 1 damage to you.;^%T: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Cloudgoat Ranger
    public class CloudgoatRangerMMA : MagicCard
    {
        public CloudgoatRangerMMA()
        {
            Name = "Cloudgoat Ranger";
            Edition = "MMA";
            Rarity = "U";
            Color = "W";
            Cost = "3WW";
            PT = "3/3";
            Type = "Creature - Giant Warrior";
            Text = "When Cloudgoat Ranger enters the battlefield, put three 1/1 white Kithkin Soldier creature tokens onto the battlefield.;^Tap three untapped Kithkin you control: Cloudgoat Ranger gets +2/+0 and gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Cold-Eyed Selkie
    public class ColdEyedSelkieMMA : MagicCard
    {
        public ColdEyedSelkieMMA()
        {
            Name = "Cold-Eyed Selkie";
            Edition = "MMA";
            Rarity = "R";
            Color = "Gld";
            Cost = "1%S%S";
            PT = "1/1";
            Type = "Creature - Merfolk Rogue";
            Text = "Islandwalk;^Whenever Cold-Eyed Selkie deals combat damage to a player, you may draw that many cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Countryside Crusher
    public class CountrysideCrusherMMA : MagicCard
    {
        public CountrysideCrusherMMA()
        {
            Name = "Countryside Crusher";
            Edition = "MMA";
            Rarity = "R";
            Color = "R";
            Cost = "1RR";
            PT = "3/3";
            Type = "Creature - Giant Warrior";
            Text = "At the beginning of your upkeep, reveal the top card of your library. If it�s a land card, put it into your graveyard and repeat this process.;^Whenever a land card is put into your graveyard from anywhere, put a +1/+1 counter on Countryside Crusher.";
            Flavor = "";
        }
    }
    # endregion

    # region Court Homunculus
    public class CourtHomunculusMMA : MagicCard
    {
        public CourtHomunculusMMA()
        {
            Name = "Court Homunculus";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Artifact Creature - Homunculus";
            Text = "Court Homunculus gets +1/+1 as long as you control another artifact.";
            Flavor = "";
        }
    }
    # endregion

    # region Crush Underfoot
    public class CrushUnderfootMMA : MagicCard
    {
        public CrushUnderfootMMA()
        {
            Name = "Crush Underfoot";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Tribal Instant - Giant";
            Text = "Choose a Giant creature you control. It deals damage equal to its power to target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Cryptic Command
    public class CrypticCommandMMA : MagicCard
    {
        public CrypticCommandMMA()
        {
            Name = "Cryptic Command";
            Edition = "MMA";
            Rarity = "R";
            Color = "U";
            Cost = "1UUU";
            PT = "";
            Type = "Instant";
            Text = "Choose two � Counter target spell; or return target permanent to its owner�s hand; or tap all creatures your opponents control; or draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Dakmor Salvage
    public class DakmorSalvageMMA : MagicCard
    {
        public DakmorSalvageMMA()
        {
            Name = "Dakmor Salvage";
            Edition = "MMA";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Dakmor Salvage enters the battlefield tapped.;^%T: Add %B to your mana pool.;^Dredge 2 @(If you would draw a card, instead you may put exactly two cards from the top of your library into your graveyard. If you do, return this card from your graveyard to your hand. Otherwise, draw a card.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Dampen Thought
    public class DampenThoughtMMA : MagicCard
    {
        public DampenThoughtMMA()
        {
            Name = "Dampen Thought";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant - Arcane";
            Text = "Target player puts the top four cards of his or her library into his or her graveyard.;^Splice onto Arcane %1%U @(As you cast an Arcane spell, you may reveal this card from your hand and pay its splice cost. If you do, add this card�s effects to that spell.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Dark Confidant
    public class DarkConfidantMMA : MagicCard
    {
        public DarkConfidantMMA()
        {
            Name = "Dark Confidant";
            Edition = "MMA";
            Rarity = "M";
            Color = "B";
            Cost = "1B";
            PT = "2/1";
            Type = "Creature - Human Wizard";
            Text = "At the beginning of your upkeep, reveal the top card of your library and put that card into your hand. You lose life equal to its converted mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Death Cloud
    public class DeathCloudMMA : MagicCard
    {
        public DeathCloudMMA()
        {
            Name = "Death Cloud";
            Edition = "MMA";
            Rarity = "R";
            Color = "B";
            Cost = "XBBB";
            PT = "";
            Type = "Sorcery";
            Text = "Each player loses X life, discards X cards, sacrifices X creatures, then sacrifices X lands.";
            Flavor = "";
        }
    }
    # endregion

    # region Death Denied
    public class DeathDeniedMMA : MagicCard
    {
        public DeathDeniedMMA()
        {
            Name = "Death Denied";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "XBB";
            PT = "";
            Type = "Instant - Arcane";
            Text = "Return X target creature cards from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Death Rattle
    public class DeathRattleMMA : MagicCard
    {
        public DeathRattleMMA()
        {
            Name = "Death Rattle";
            Edition = "MMA";
            Rarity = "U";
            Color = "B";
            Cost = "5B";
            PT = "";
            Type = "Instant";
            Text = "Delve @(Each card you exile from your graveyard while casting this spell pays for %1.)@;^Destroy target nongreen creature. It can�t be regenerated.";
            Flavor = "";
        }
    }
    # endregion

    # region Deepcavern Imp
    public class DeepcavernImpMMA : MagicCard
    {
        public DeepcavernImpMMA()
        {
            Name = "Deepcavern Imp";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Imp Rebel";
            Text = "Flying, haste;^Echo�Discard a card. @(At the beginning of your upkeep, if this came under your control since the beginning of your last upkeep, sacrifice it unless you pay its echo cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Demigod of Revenge
    public class DemigodofRevengeMMA : MagicCard
    {
        public DemigodofRevengeMMA()
        {
            Name = "Demigod of Revenge";
            Edition = "MMA";
            Rarity = "R";
            Color = "Gld";
            Cost = "%K%K%K%K%K";
            PT = "5/4";
            Type = "Creature - Spirit Avatar";
            Text = "Flying, haste;^When you cast Demigod of Revenge, return all cards named Demigod of Revenge from your graveyard to the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Desperate Ritual
    public class DesperateRitualMMA : MagicCard
    {
        public DesperateRitualMMA()
        {
            Name = "Desperate Ritual";
            Edition = "MMA";
            Rarity = "U";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant - Arcane";
            Text = "Add %R%R%R to your mana pool.;^Splice onto Arcane %1%R @(As you cast an Arcane spell, you may reveal this card from your hand and pay its splice cost. If you do, add this card�s effects to that spell.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Dispeller's Capsule
    public class DispellersCapsuleMMA : MagicCard
    {
        public DispellersCapsuleMMA()
        {
            Name = "Dispeller's Capsule";
            Edition = "MMA";
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

    # region Divinity of Pride
    public class DivinityofPrideMMA : MagicCard
    {
        public DivinityofPrideMMA()
        {
            Name = "Divinity of Pride";
            Edition = "MMA";
            Rarity = "R";
            Color = "Gld";
            Cost = "%O%O%O%O%O";
            PT = "4/4";
            Type = "Creature - Spirit Avatar";
            Text = "Flying, lifelink;^Divinity of Pride gets +4/+4 as long as you have 25 or more life.";
            Flavor = "";
        }
    }
    # endregion

    # region Doubling Season
    public class DoublingSeasonMMA : MagicCard
    {
        public DoublingSeasonMMA()
        {
            Name = "Doubling Season";
            Edition = "MMA";
            Rarity = "R";
            Color = "G";
            Cost = "4G";
            PT = "";
            Type = "Enchantment";
            Text = "If an effect would put one or more tokens onto the battlefield under your control, it puts twice that many of those tokens onto the battlefield instead.;^If an effect would place one or more counters on a permanent you control, it places twice that many of those counters on that permanent instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Drag Down
    public class DragDownMMA : MagicCard
    {
        public DragDownMMA()
        {
            Name = "Drag Down";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Instant";
            Text = "@Domain@ � Target creature gets -1/-1 until end of turn for each basic land type among lands you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Dragonstorm
    public class DragonstormMMA : MagicCard
    {
        public DragonstormMMA()
        {
            Name = "Dragonstorm";
            Edition = "MMA";
            Rarity = "R";
            Color = "R";
            Cost = "8R";
            PT = "";
            Type = "Sorcery";
            Text = "Search your library for a Dragon permanent card and put it onto the battlefield. Then shuffle your library.;^Storm @(When you cast this spell, copy it for each spell cast before it this turn.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Dreamspoiler Witches
    public class DreamspoilerWitchesMMA : MagicCard
    {
        public DreamspoilerWitchesMMA()
        {
            Name = "Dreamspoiler Witches";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "2/2";
            Type = "Creature - Faerie Wizard";
            Text = "Flying;^Whenever you cast a spell during an opponent�s turn, you may have target creature get -1/-1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Durkwood Baloth
    public class DurkwoodBalothMMA : MagicCard
    {
        public DurkwoodBalothMMA()
        {
            Name = "Durkwood Baloth";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "4GG";
            PT = "5/5";
            Type = "Creature - Beast";
            Text = "Suspend 5�%G @(Rather than cast this card from your hand, you may pay %G and exile it with five time counters on it. At the beginning of your upkeep, remove a time counter. When the last is removed, cast it without paying its mana cost. It has haste.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Earwig Squad
    public class EarwigSquadMMA : MagicCard
    {
        public EarwigSquadMMA()
        {
            Name = "Earwig Squad";
            Edition = "MMA";
            Rarity = "R";
            Color = "B";
            Cost = "3BB";
            PT = "5/3";
            Type = "Creature - Goblin Rogue";
            Text = "Prowl %2%B @(You may cast this for its prowl cost if you dealt combat damage to a player this turn with a Goblin or Rogue.)@;^When Earwig Squad enters the battlefield, if its prowl cost was paid, search target opponent�s library for three cards and exile them. Then that player shuffles his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Echoing Courage
    public class EchoingCourageMMA : MagicCard
    {
        public EchoingCourageMMA()
        {
            Name = "Echoing Courage";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Target creature and all other creatures with the same name as that creature get +2/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Echoing Truth
    public class EchoingTruthMMA : MagicCard
    {
        public EchoingTruthMMA()
        {
            Name = "Echoing Truth";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Return target nonland permanent and all other permanents with the same name as that permanent to their owners� hands.";
            Flavor = "";
        }
    }
    # endregion

    # region Electrolyze
    public class ElectrolyzeMMA : MagicCard
    {
        public ElectrolyzeMMA()
        {
            Name = "Electrolyze";
            Edition = "MMA";
            Rarity = "U";
            Color = "Gld";
            Cost = "1UR";
            PT = "";
            Type = "Instant";
            Text = "Electrolyze deals 2 damage divided as you choose among one or two target creatures and/or players.;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Elspeth, Knight-Errant
    public class ElspethKnightErrantMMA : MagicCard
    {
        public ElspethKnightErrantMMA()
        {
            Name = "Elspeth, Knight-Errant";
            Edition = "MMA";
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

    # region Empty the Warrens
    public class EmptytheWarrensMMA : MagicCard
    {
        public EmptytheWarrensMMA()
        {
            Name = "Empty the Warrens";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Sorcery";
            Text = "Put two 1/1 red Goblin creature tokens onto the battlefield.;^Storm @(When you cast this spell, copy it for each spell cast before it this turn.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Engineered Explosives
    public class EngineeredExplosivesMMA : MagicCard
    {
        public EngineeredExplosivesMMA()
        {
            Name = "Engineered Explosives";
            Edition = "MMA";
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

    # region Epochrasite
    public class EpochrasiteMMA : MagicCard
    {
        public EpochrasiteMMA()
        {
            Name = "Epochrasite";
            Edition = "MMA";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "1/1";
            Type = "Artifact Creature - Construct";
            Text = "Epochrasite enters the battlefield with three +1/+1 counters on it if you didn�t cast it from your hand.;^When Epochrasite dies, exile it with three time counters on it and it gains suspend. @(At the beginning of your upkeep, remove a time counter. When the last is removed, cast this card without paying its mana cost. It has haste.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Errant Ephemeron
    public class ErrantEphemeronMMA : MagicCard
    {
        public ErrantEphemeronMMA()
        {
            Name = "Errant Ephemeron";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "6U";
            PT = "4/4";
            Type = "Creature - Illusion";
            Text = "Flying;^Suspend 4 �%1%U @(Rather than cast this card from your hand, you may pay %1%U and exile it with four time counters on it. At the beginning of your upkeep, remove a time counter. When the last is removed, cast it without paying its mana cost. It has haste.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Erratic Mutation
    public class ErraticMutationMMA : MagicCard
    {
        public ErraticMutationMMA()
        {
            Name = "Erratic Mutation";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Instant";
            Text = "Choose target creature. Reveal cards from the top of your library until you reveal a nonland card. That creature gets +X/-X until end of turn, where X is that card�s converted mana cost. Put all cards revealed this way on the bottom of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Esperzoa
    public class EsperzoaMMA : MagicCard
    {
        public EsperzoaMMA()
        {
            Name = "Esperzoa";
            Edition = "MMA";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "4/3";
            Type = "Artifact Creature - Jellyfish";
            Text = "Flying;^At the beginning of your upkeep, return an artifact you control to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Etched Oracle
    public class EtchedOracleMMA : MagicCard
    {
        public EtchedOracleMMA()
        {
            Name = "Etched Oracle";
            Edition = "MMA";
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
    public class EternalWitnessMMA : MagicCard
    {
        public EternalWitnessMMA()
        {
            Name = "Eternal Witness";
            Edition = "MMA";
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

    # region Etherium Sculptor
    public class EtheriumSculptorMMA : MagicCard
    {
        public EtheriumSculptorMMA()
        {
            Name = "Etherium Sculptor";
            Edition = "MMA";
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
    public class EtherswornCanonistMMA : MagicCard
    {
        public EtherswornCanonistMMA()
        {
            Name = "Ethersworn Canonist";
            Edition = "MMA";
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

    # region Executioner's Capsule
    public class ExecutionersCapsuleMMA : MagicCard
    {
        public ExecutionersCapsuleMMA()
        {
            Name = "Executioner's Capsule";
            Edition = "MMA";
            Rarity = "U";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Artifact";
            Text = "%1%B, %T, Sacrifice Executioner�s Capsule: Destroy target nonblack creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Extirpate
    public class ExtirpateMMA : MagicCard
    {
        public ExtirpateMMA()
        {
            Name = "Extirpate";
            Edition = "MMA";
            Rarity = "R";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "Split second @(As long as this spell is on the stack, players can�t cast spells or activate abilities that aren�t mana abilities.)@;^Choose target card in a graveyard other than a basic land card. Search its owner�s graveyard, hand, and library for all cards with the same name as that card and exile them. Then that player shuffles his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Facevaulter
    public class FacevaulterMMA : MagicCard
    {
        public FacevaulterMMA()
        {
            Name = "Facevaulter";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Goblin Warrior";
            Text = "%B, Sacrifice a Goblin: Facevaulter gets +2/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Faerie Macabre
    public class FaerieMacabreMMA : MagicCard
    {
        public FaerieMacabreMMA()
        {
            Name = "Faerie Macabre";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "1BB";
            PT = "2/2";
            Type = "Creature - Faerie Rogue";
            Text = "Flying;^Discard Faerie Macabre: Exile up to two target cards from graveyards.";
            Flavor = "";
        }
    }
    # endregion

    # region Faerie Mechanist
    public class FaerieMechanistMMA : MagicCard
    {
        public FaerieMechanistMMA()
        {
            Name = "Faerie Mechanist";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "3U";
            PT = "2/2";
            Type = "Artifact Creature - Faerie Artificer";
            Text = "Flying;^When Faerie Mechanist enters the battlefield, look at the top three cards of your library. You may reveal an artifact card from among them and put it into your hand. Put the rest on the bottom of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Festering Goblin
    public class FesteringGoblinMMA : MagicCard
    {
        public FesteringGoblinMMA()
        {
            Name = "Festering Goblin";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Zombie Goblin";
            Text = "When Festering Goblin dies, target creature gets -1/-1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Feudkiller's Verdict
    public class FeudkillersVerdictMMA : MagicCard
    {
        public FeudkillersVerdictMMA()
        {
            Name = "Feudkiller's Verdict";
            Edition = "MMA";
            Rarity = "U";
            Color = "W";
            Cost = "4WW";
            PT = "";
            Type = "Tribal Sorcery - Giant";
            Text = "You gain 10 life. Then if you have more life than an opponent, put a 5/5 white Giant Warrior creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Fiery Fall
    public class FieryFallMMA : MagicCard
    {
        public FieryFallMMA()
        {
            Name = "Fiery Fall";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "5R";
            PT = "";
            Type = "Instant";
            Text = "Fiery Fall deals 5 damage to target creature.;^Basic landcycling %1%R @(%1%R, Discard this card: Search your library for a basic land card, reveal it, and put it into your hand. Then shuffle your library.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Figure of Destiny
    public class FigureofDestinyMMA : MagicCard
    {
        public FigureofDestinyMMA()
        {
            Name = "Figure of Destiny";
            Edition = "MMA";
            Rarity = "R";
            Color = "Gld";
            Cost = "%P";
            PT = "1/1";
            Type = "Creature - Kithkin";
            Text = "%P: Figure of Destiny becomes a 2/2 Kithkin Spirit.;^%P%P%P: If Figure of Destiny is a Spirit, it becomes a 4/4 Kithkin Spirit Warrior.;^%P%P%P%P%P%P: If Figure of Destiny is a Warrior, it becomes an 8/8 Kithkin Spirit Warrior Avatar with flying and first strike.";
            Flavor = "";
        }
    }
    # endregion

    # region Flickerwisp
    public class FlickerwispMMA : MagicCard
    {
        public FlickerwispMMA()
        {
            Name = "Flickerwisp";
            Edition = "MMA";
            Rarity = "U";
            Color = "W";
            Cost = "1WW";
            PT = "3/1";
            Type = "Creature - Elemental";
            Text = "Flying;^When Flickerwisp enters the battlefield, exile another target permanent. Return that card to the battlefield under its owner�s control at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Frogmite
    public class FrogmiteMMA : MagicCard
    {
        public FrogmiteMMA()
        {
            Name = "Frogmite";
            Edition = "MMA";
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

    # region Fury Charm
    public class FuryCharmMMA : MagicCard
    {
        public FuryCharmMMA()
        {
            Name = "Fury Charm";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Destroy target artifact; or target creature gets +1/+1 and gains trample until end of turn; or remove two time counters from target permanent or suspended card.";
            Flavor = "";
        }
    }
    # endregion

    # region Giant Dustwasp
    public class GiantDustwaspMMA : MagicCard
    {
        public GiantDustwaspMMA()
        {
            Name = "Giant Dustwasp";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "3GG";
            PT = "3/3";
            Type = "Creature - Insect";
            Text = "Flying;^Suspend 4�%1%G @(Rather than cast this card from your hand, you may pay %1%G and exile it with four time counters on it. At the beginning of your upkeep, remove a time counter. When the last is removed, cast it without paying its mana cost. It has haste.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Gifts Ungiven
    public class GiftsUngivenMMA : MagicCard
    {
        public GiftsUngivenMMA()
        {
            Name = "Gifts Ungiven";
            Edition = "MMA";
            Rarity = "R";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Instant";
            Text = "Search your library for up to four cards with different names and reveal them. Target opponent chooses two of those cards. Put the chosen cards into your graveyard and the rest into your hand. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Glacial Ray
    public class GlacialRayMMA : MagicCard
    {
        public GlacialRayMMA()
        {
            Name = "Glacial Ray";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant - Arcane";
            Text = "Glacial Ray deals 2 damage to target creature or player.;^Splice onto Arcane %1%R @(As you cast an Arcane spell, you may reveal this card from your hand and pay its splice cost. If you do, add this card�s effects to that spell.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Gleam of Resistance
    public class GleamofResistanceMMA : MagicCard
    {
        public GleamofResistanceMMA()
        {
            Name = "Gleam of Resistance";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "4W";
            PT = "";
            Type = "Instant";
            Text = "Creatures you control get +1/+2 until end of turn. Untap those creatures.;^Basic landcycling %1%W @(%1%W, Discard this card: Search your library for a basic land card, reveal it, and put it into your hand. Then shuffle your library.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Glen Elendra Archmage
    public class GlenElendraArchmageMMA : MagicCard
    {
        public GlenElendraArchmageMMA()
        {
            Name = "Glen Elendra Archmage";
            Edition = "MMA";
            Rarity = "R";
            Color = "U";
            Cost = "3U";
            PT = "2/2";
            Type = "Creature - Faerie Wizard";
            Text = "Flying;^%U, Sacrifice Glen Elendra Archmage: Counter target noncreature spell.;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Glimmervoid
    public class GlimmervoidMMA : MagicCard
    {
        public GlimmervoidMMA()
        {
            Name = "Glimmervoid";
            Edition = "MMA";
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

    # region Grand Arbiter Augustin IV
    public class GrandArbiterAugustinIVMMA : MagicCard
    {
        public GrandArbiterAugustinIVMMA()
        {
            Name = "Grand Arbiter Augustin IV";
            Edition = "MMA";
            Rarity = "R";
            Color = "Gld";
            Cost = "2WU";
            PT = "2/3";
            Type = "Legendary Creature - Human Advisor";
            Text = "White spells you cast cost %1 less to cast.;^Blue spells you cast cost %1 less to cast.;^Spells your opponents cast cost %1 more to cast.";
            Flavor = "";
        }
    }
    # endregion

    # region Grapeshot
    public class GrapeshotMMA : MagicCard
    {
        public GrapeshotMMA()
        {
            Name = "Grapeshot";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Sorcery";
            Text = "Grapeshot deals 1 damage to target creature or player.;^Storm @(When you cast this spell, copy it for each spell cast before it this turn. You may choose new targets for the copies.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Greater Gargadon
    public class GreaterGargadonMMA : MagicCard
    {
        public GreaterGargadonMMA()
        {
            Name = "Greater Gargadon";
            Edition = "MMA";
            Rarity = "R";
            Color = "R";
            Cost = "9R";
            PT = "9/7";
            Type = "Creature - Beast";
            Text = "Suspend 10�%R;^Sacrifice an artifact, creature, or land: Remove a time counter from Greater Gargadon. Activate this ability only if Greater Gargadon is suspended.";
            Flavor = "";
        }
    }
    # endregion

    # region Greater Mossdog
    public class GreaterMossdogMMA : MagicCard
    {
        public GreaterMossdogMMA()
        {
            Name = "Greater Mossdog";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "3/3";
            Type = "Creature - Plant Hound";
            Text = "Dredge 3 @(If you would draw a card, instead you may put exactly three cards from the top of your library into your graveyard. If you do, return this card from your graveyard to your hand. Otherwise, draw a card.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Grinning Ignus
    public class GrinningIgnusMMA : MagicCard
    {
        public GrinningIgnusMMA()
        {
            Name = "Grinning Ignus";
            Edition = "MMA";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Elemental";
            Text = "%R, Return Grinning Ignus to its owner�s hand: Add %2%R to your mana pool. Activate this ability only any time you could cast a sorcery.";
            Flavor = "";
        }
    }
    # endregion

    # region Hammerheim Deadeye
    public class HammerheimDeadeyeMMA : MagicCard
    {
        public HammerheimDeadeyeMMA()
        {
            Name = "Hammerheim Deadeye";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "3/3";
            Type = "Creature - Giant Warrior";
            Text = "Echo %5%R @(At the beginning of your upkeep, if this came under your control since the beginning of your last upkeep, sacrifice it unless you pay its echo cost.)@;^When Hammerheim Deadeye enters the battlefield, destroy target creature with flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Hana Kami
    public class HanaKamiMMA : MagicCard
    {
        public HanaKamiMMA()
        {
            Name = "Hana Kami";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Spirit";
            Text = "%1%G, Sacrifice Hana Kami: Return target Arcane card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Hillcomber Giant
    public class HillcomberGiantMMA : MagicCard
    {
        public HillcomberGiantMMA()
        {
            Name = "Hillcomber Giant";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "2WW";
            PT = "3/3";
            Type = "Creature - Giant Scout";
            Text = "Mountainwalk";
            Flavor = "";
        }
    }
    # endregion

    # region Horobi's Whisper
    public class HorobisWhisperMMA : MagicCard
    {
        public HorobisWhisperMMA()
        {
            Name = "Horobi's Whisper";
            Edition = "MMA";
            Rarity = "U";
            Color = "B";
            Cost = "1BB";
            PT = "";
            Type = "Instant - Arcane";
            Text = "If you control a Swamp, destroy target nonblack creature.;^Splice onto Arcane�Exile four cards from your graveyard. @(As you cast an Arcane spell, you may reveal this card from your hand and pay its splice cost. If you do, add this card�s effects to that spell.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Imperiosaur
    public class ImperiosaurMMA : MagicCard
    {
        public ImperiosaurMMA()
        {
            Name = "Imperiosaur";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "2GG";
            PT = "5/5";
            Type = "Creature - Lizard";
            Text = "Spend only mana produced by basic lands to cast Imperiosaur.";
            Flavor = "";
        }
    }
    # endregion

    # region Incremental Growth
    public class IncrementalGrowthMMA : MagicCard
    {
        public IncrementalGrowthMMA()
        {
            Name = "Incremental Growth";
            Edition = "MMA";
            Rarity = "U";
            Color = "G";
            Cost = "3GG";
            PT = "";
            Type = "Sorcery";
            Text = "Put a +1/+1 counter on target creature, two +1/+1 counters on another target creature, and three +1/+1 counters on a third target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Ivory Giant
    public class IvoryGiantMMA : MagicCard
    {
        public IvoryGiantMMA()
        {
            Name = "Ivory Giant";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "5WW";
            PT = "3/4";
            Type = "Creature - Giant";
            Text = "When Ivory Giant enters the battlefield, tap all nonwhite creatures.;^Suspend 5�%W @(Rather than cast this card from your hand, you may pay %W and exile it with five time counters on it. At the beginning of your upkeep, remove a time counter. When the last is removed, cast it without paying its mana cost. It has haste.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Jhoira of the Ghitu
    public class JhoiraoftheGhituMMA : MagicCard
    {
        public JhoiraoftheGhituMMA()
        {
            Name = "Jhoira of the Ghitu";
            Edition = "MMA";
            Rarity = "R";
            Color = "Gld";
            Cost = "1UR";
            PT = "2/2";
            Type = "Legendary Creature - Human Wizard";
            Text = "%2, Exile a nonland card from your hand: Put four time counters on the exiled card. If it doesn�t have suspend, it gains suspend. @(At the beginning of your upkeep, remove a time counter from that card. When the last is removed, cast it without paying its mana cost. If it�s a creature, it has haste.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Jugan, the Rising Star
    public class JugantheRisingStarMMA : MagicCard
    {
        public JugantheRisingStarMMA()
        {
            Name = "Jugan, the Rising Star";
            Edition = "MMA";
            Rarity = "M";
            Color = "G";
            Cost = "3GGG";
            PT = "5/5";
            Type = "Legendary Creature - Dragon Spirit";
            Text = "Flying;^When Jugan, the Rising Star dies, you may distribute five +1/+1 counters among any number of target creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Kataki, War's Wage
    public class KatakiWarsWageMMA : MagicCard
    {
        public KatakiWarsWageMMA()
        {
            Name = "Kataki, War's Wage";
            Edition = "MMA";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "2/1";
            Type = "Legendary Creature - Spirit";
            Text = "All artifacts have �At the beginning of your upkeep, sacrifice this artifact unless you pay %1.�";
            Flavor = "";
        }
    }
    # endregion

    # region Keiga, the Tide Star
    public class KeigatheTideStarMMA : MagicCard
    {
        public KeigatheTideStarMMA()
        {
            Name = "Keiga, the Tide Star";
            Edition = "MMA";
            Rarity = "M";
            Color = "U";
            Cost = "5U";
            PT = "5/5";
            Type = "Legendary Creature - Dragon Spirit";
            Text = "Flying;^When Keiga, the Tide Star dies, gain control of target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Kiki-Jiki, Mirror Breaker
    public class KikiJikiMirrorBreakerMMA : MagicCard
    {
        public KikiJikiMirrorBreakerMMA()
        {
            Name = "Kiki-Jiki, Mirror Breaker";
            Edition = "MMA";
            Rarity = "M";
            Color = "R";
            Cost = "2RRR";
            PT = "2/2";
            Type = "Legendary Creature - Goblin Shaman";
            Text = "Haste;^%T: Put a token that�s a copy of target nonlegendary creature you control onto the battlefield. That token has haste. Sacrifice it at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Kira, Great Glass-Spinner
    public class KiraGreatGlassSpinnerMMA : MagicCard
    {
        public KiraGreatGlassSpinnerMMA()
        {
            Name = "Kira, Great Glass-Spinner";
            Edition = "MMA";
            Rarity = "R";
            Color = "U";
            Cost = "1UU";
            PT = "2/2";
            Type = "Legendary Creature - Spirit";
            Text = "Flying;^Creatures you control have �Whenever this creature becomes the target of a spell or ability for the first time in a turn, counter that spell or ability.�";
            Flavor = "";
        }
    }
    # endregion

    # region Kitchen Finks
    public class KitchenFinksMMA : MagicCard
    {
        public KitchenFinksMMA()
        {
            Name = "Kitchen Finks";
            Edition = "MMA";
            Rarity = "U";
            Color = "Gld";
            Cost = "1%A%A";
            PT = "3/2";
            Type = "Creature - Ouphe";
            Text = "When Kitchen Finks enters the battlefield, you gain 2 life.;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Kithkin Greatheart
    public class KithkinGreatheartMMA : MagicCard
    {
        public KithkinGreatheartMMA()
        {
            Name = "Kithkin Greatheart";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "2/1";
            Type = "Creature - Kithkin Soldier";
            Text = "As long as you control a Giant, Kithkin Greatheart gets +1/+1 and has first strike.";
            Flavor = "";
        }
    }
    # endregion

    # region Knight of the Reliquary
    public class KnightoftheReliquaryMMA : MagicCard
    {
        public KnightoftheReliquaryMMA()
        {
            Name = "Knight of the Reliquary";
            Edition = "MMA";
            Rarity = "R";
            Color = "Gld";
            Cost = "1GW";
            PT = "2/2";
            Type = "Creature - Human Knight";
            Text = "Knight of the Reliquary gets +1/+1 for each land card in your graveyard.;^%T, Sacrifice a Forest or Plains: Search your library for a land card, put it onto the battlefield, then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Kodama's Reach
    public class KodamasReachMMA : MagicCard
    {
        public KodamasReachMMA()
        {
            Name = "Kodama's Reach";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Sorcery - Arcane";
            Text = "Search your library for up to two basic land cards, reveal those cards, and put one onto the battlefield tapped and the other into your hand. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Kokusho, the Evening Star
    public class KokushotheEveningStarMMA : MagicCard
    {
        public KokushotheEveningStarMMA()
        {
            Name = "Kokusho, the Evening Star";
            Edition = "MMA";
            Rarity = "M";
            Color = "B";
            Cost = "4BB";
            PT = "5/5";
            Type = "Legendary Creature - Dragon Spirit";
            Text = "Flying;^When Kokusho, the Evening Star dies, each opponent loses 5 life. You gain life equal to the life lost this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Krosan Grip
    public class KrosanGripMMA : MagicCard
    {
        public KrosanGripMMA()
        {
            Name = "Krosan Grip";
            Edition = "MMA";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Instant";
            Text = "Split second @(As long as this spell is on the stack, players can�t cast spells or activate abilities that aren�t mana abilities.)@;^Destroy target artifact or enchantment.";
            Flavor = "";
        }
    }
    # endregion

    # region Latchkey Faerie
    public class LatchkeyFaerieMMA : MagicCard
    {
        public LatchkeyFaerieMMA()
        {
            Name = "Latchkey Faerie";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "3U";
            PT = "3/1";
            Type = "Creature - Faerie Rogue";
            Text = "Flying;^Prowl %2%U @(You may cast this for its prowl cost if you dealt combat damage to a player this turn with a Faerie or Rogue.)@;^When Latchkey Faerie enters the battlefield, if its prowl cost was paid, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Lava Spike
    public class LavaSpikeMMA : MagicCard
    {
        public LavaSpikeMMA()
        {
            Name = "Lava Spike";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Sorcery - Arcane";
            Text = "Lava Spike deals 3 damage to target player.";
            Flavor = "";
        }
    }
    # endregion

    # region Life from the Loam
    public class LifefromtheLoamMMA : MagicCard
    {
        public LifefromtheLoamMMA()
        {
            Name = "Life from the Loam";
            Edition = "MMA";
            Rarity = "R";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Sorcery";
            Text = "Return up to three target land cards from your graveyard to your hand.;^Dredge 3 @(If you would draw a card, instead you may put exactly three cards from the top of your library into your graveyard. If you do, return this card from your graveyard to your hand. Otherwise, draw a card.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Lightning Helix
    public class LightningHelixMMA : MagicCard
    {
        public LightningHelixMMA()
        {
            Name = "Lightning Helix";
            Edition = "MMA";
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

    # region Logic Knot
    public class LogicKnotMMA : MagicCard
    {
        public LogicKnotMMA()
        {
            Name = "Logic Knot";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "XUU";
            PT = "";
            Type = "Instant";
            Text = "Delve @(Each card you exile from your graveyard while casting this spell pays for %1.)@;^Counter target spell unless its controller pays %X.";
            Flavor = "";
        }
    }
    # endregion

    # region Lotus Bloom
    public class LotusBloomMMA : MagicCard
    {
        public LotusBloomMMA()
        {
            Name = "Lotus Bloom";
            Edition = "MMA";
            Rarity = "R";
            Color = "Art";
            Cost = "";
            PT = "";
            Type = "Artifact";
            Text = "Suspend 3�%0 @(Rather than cast this card from your hand, pay %0 and exile it with three time counters on it. At the beginning of your upkeep, remove a time counter. When the last is removed, cast it without paying its mana cost.)@;^%T, Sacrifice Lotus Bloom: Add three mana of any one color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Mad Auntie
    public class MadAuntieMMA : MagicCard
    {
        public MadAuntieMMA()
        {
            Name = "Mad Auntie";
            Edition = "MMA";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Goblin Shaman";
            Text = "Other Goblin creatures you control get +1/+1.^%T: Regenerate another target Goblin.";
            Flavor = "";
        }
    }
    # endregion

    # region Maelstrom Pulse
    public class MaelstromPulseMMA : MagicCard
    {
        public MaelstromPulseMMA()
        {
            Name = "Maelstrom Pulse";
            Edition = "MMA";
            Rarity = "R";
            Color = "Gld";
            Cost = "1BG";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target nonland permanent and all other permanents with the same name as that permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Manamorphose
    public class ManamorphoseMMA : MagicCard
    {
        public ManamorphoseMMA()
        {
            Name = "Manamorphose";
            Edition = "MMA";
            Rarity = "U";
            Color = "Gld";
            Cost = "1%L";
            PT = "";
            Type = "Instant";
            Text = "Add two mana in any combination of colors to your mana pool.;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Marsh Flitter
    public class MarshFlitterMMA : MagicCard
    {
        public MarshFlitterMMA()
        {
            Name = "Marsh Flitter";
            Edition = "MMA";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "1/1";
            Type = "Creature - Faerie Rogue";
            Text = "Flying;^When Marsh Flitter enters the battlefield, put two 1/1 black Goblin Rogue creature tokens onto the battlefield.;^Sacrifice a Goblin: Marsh Flitter becomes 3/3 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Masked Admirers
    public class MaskedAdmirersMMA : MagicCard
    {
        public MaskedAdmirersMMA()
        {
            Name = "Masked Admirers";
            Edition = "MMA";
            Rarity = "U";
            Color = "G";
            Cost = "2GG";
            PT = "3/2";
            Type = "Creature - Elf Shaman";
            Text = "When Masked Admirers enters the battlefield, draw a card.;^Whenever you cast a creature spell, you may pay %G%G. If you do, return Masked Admirers from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Meadowboon
    public class MeadowboonMMA : MagicCard
    {
        public MeadowboonMMA()
        {
            Name = "Meadowboon";
            Edition = "MMA";
            Rarity = "U";
            Color = "W";
            Cost = "2WW";
            PT = "3/3";
            Type = "Creature - Elemental";
            Text = "When Meadowboon leaves the battlefield, put a +1/+1 counter on each creature target player controls.;^Evoke %3%W @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Meloku the Clouded Mirror
    public class MelokutheCloudedMirrorMMA : MagicCard
    {
        public MelokutheCloudedMirrorMMA()
        {
            Name = "Meloku the Clouded Mirror";
            Edition = "MMA";
            Rarity = "R";
            Color = "U";
            Cost = "4U";
            PT = "2/4";
            Type = "Legendary Creature - Moonfolk Wizard";
            Text = "Flying;^%1, Return a land you control to its owner�s hand: Put a 1/1 blue Illusion creature token with flying onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Mind Funeral
    public class MindFuneralMMA : MagicCard
    {
        public MindFuneralMMA()
        {
            Name = "Mind Funeral";
            Edition = "MMA";
            Rarity = "U";
            Color = "Gld";
            Cost = "1UB";
            PT = "";
            Type = "Sorcery";
            Text = "Target opponent reveals cards from the top of his or her library until four land cards are revealed. That player puts all cards revealed this way into his or her graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Mogg War Marshal
    public class MoggWarMarshalMMA : MagicCard
    {
        public MoggWarMarshalMMA()
        {
            Name = "Mogg War Marshal";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "1/1";
            Type = "Creature - Goblin Warrior";
            Text = "Echo %1%R @(At the beginning of your upkeep, if this came under your control since the beginning of your last upkeep, sacrifice it unless you pay its echo cost.)@;^When Mogg War Marshal enters the battlefield or dies, put a 1/1 red Goblin creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Moldervine Cloak
    public class MoldervineCloakMMA : MagicCard
    {
        public MoldervineCloakMMA()
        {
            Name = "Moldervine Cloak";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +3/+3.;^Dredge 2 @(If you would draw a card, instead you may put exactly two cards from the top of your library into your graveyard. If you do, return this card from your graveyard to your hand. Otherwise, draw a card.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Molten Disaster
    public class MoltenDisasterMMA : MagicCard
    {
        public MoltenDisasterMMA()
        {
            Name = "Molten Disaster";
            Edition = "MMA";
            Rarity = "R";
            Color = "R";
            Cost = "XRR";
            PT = "";
            Type = "Sorcery";
            Text = "Kicker %R @(You may pay an additional %R as you cast this spell.)@;^If Molten Disaster was kicked, it has split second. @(As long as this spell is on the stack, players can�t cast spells or activate abilities that aren�t mana abilities.)@;^Molten Disaster deals X damage to each creature without flying and each player.";
            Flavor = "";
        }
    }
    # endregion

    # region Mothdust Changeling
    public class MothdustChangelingMMA : MagicCard
    {
        public MothdustChangelingMMA()
        {
            Name = "Mothdust Changeling";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "1/1";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^Tap an untapped creature you control: Mothdust Changeling gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Mulldrifter
    public class MulldrifterMMA : MagicCard
    {
        public MulldrifterMMA()
        {
            Name = "Mulldrifter";
            Edition = "MMA";
            Rarity = "U";
            Color = "U";
            Cost = "4U";
            PT = "2/2";
            Type = "Creature - Elemental";
            Text = "Flying;^When Mulldrifter enters the battlefield, draw two cards.;^Evoke %2%U @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Murderous Redcap
    public class MurderousRedcapMMA : MagicCard
    {
        public MurderousRedcapMMA()
        {
            Name = "Murderous Redcap";
            Edition = "MMA";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%K%K";
            PT = "2/2";
            Type = "Creature - Goblin Assassin";
            Text = "When Murderous Redcap enters the battlefield, it deals damage equal to its power to target creature or player.;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Myr Enforcer
    public class MyrEnforcerMMA : MagicCard
    {
        public MyrEnforcerMMA()
        {
            Name = "Myr Enforcer";
            Edition = "MMA";
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

    # region Myr Retriever
    public class MyrRetrieverMMA : MagicCard
    {
        public MyrRetrieverMMA()
        {
            Name = "Myr Retriever";
            Edition = "MMA";
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

    # region Nantuko Shaman
    public class NantukoShamanMMA : MagicCard
    {
        public NantukoShamanMMA()
        {
            Name = "Nantuko Shaman";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "3/2";
            Type = "Creature - Insect Shaman";
            Text = "When Nantuko Shaman enters the battlefield, if you control no tapped lands, draw a card.;^Suspend 1�%2%G%G @(Rather than cast this card from your hand, you may pay %2%G%G and exile it with a time counter on it. At the beginning of your upkeep, remove a time counter. When the last is removed, cast it without paying its mana cost. It has haste.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Narcomoeba
    public class NarcomoebaMMA : MagicCard
    {
        public NarcomoebaMMA()
        {
            Name = "Narcomoeba";
            Edition = "MMA";
            Rarity = "U";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Illusion";
            Text = "Flying;^When Narcomoeba is put into your graveyard from your library, you may put it onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Oona, Queen of the Fae
    public class OonaQueenoftheFaeMMA : MagicCard
    {
        public OonaQueenoftheFaeMMA()
        {
            Name = "Oona, Queen of the Fae";
            Edition = "MMA";
            Rarity = "R";
            Color = "Gld";
            Cost = "3%V%V%V";
            PT = "5/5";
            Type = "Legendary Creature - Faerie Wizard";
            Text = "Flying;^%X%V: Choose a color. Target opponent exiles the top X cards of his or her library. For each card of the chosen color exiled this way, put a 1/1 blue and black Faerie Rogue creature token with flying onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Otherworldly Journey
    public class OtherworldlyJourneyMMA : MagicCard
    {
        public OtherworldlyJourneyMMA()
        {
            Name = "Otherworldly Journey";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant - Arcane";
            Text = "Exile target creature. At the beginning of the next end step, return that card to the battlefield under its owner�s control with a +1/+1 counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Pact of Negation
    public class PactofNegationMMA : MagicCard
    {
        public PactofNegationMMA()
        {
            Name = "Pact of Negation";
            Edition = "MMA";
            Rarity = "R";
            Color = "U";
            Cost = "0";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell.;^At the beginning of your next upkeep, pay %3%U%U. If you don�t, you lose the game.";
            Flavor = "";
        }
    }
    # endregion

    # region Pallid Mycoderm
    public class PallidMycodermMMA : MagicCard
    {
        public PallidMycodermMMA()
        {
            Name = "Pallid Mycoderm";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "2/4";
            Type = "Creature - Fungus";
            Text = "At the beginning of your upkeep, put a spore counter on Pallid Mycoderm.;^Remove three spore counters from Pallid Mycoderm: Put a 1/1 green Saproling creature token onto the battlefield.;^Sacrifice a Saproling: Each creature you control that�s a Fungus or a Saproling gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Paradise Mantle
    public class ParadiseMantleMMA : MagicCard
    {
        public ParadiseMantleMMA()
        {
            Name = "Paradise Mantle";
            Edition = "MMA";
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

    # region Pardic Dragon
    public class PardicDragonMMA : MagicCard
    {
        public PardicDragonMMA()
        {
            Name = "Pardic Dragon";
            Edition = "MMA";
            Rarity = "U";
            Color = "R";
            Cost = "4RR";
            PT = "4/4";
            Type = "Creature - Dragon";
            Text = "Flying;^%R: Pardic Dragon gets +1/+0 until end of turn.;^Suspend 2�%R%R;^Whenever an opponent casts a spell, if Pardic Dragon is suspended, that player may put a time counter on Pardic Dragon.";
            Flavor = "";
        }
    }
    # endregion

    # region Path to Exile
    public class PathtoExileMMA : MagicCard
    {
        public PathtoExileMMA()
        {
            Name = "Path to Exile";
            Edition = "MMA";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Exile target creature. Its controller may search his or her library for a basic land card, put that card onto the battlefield tapped, then shuffle his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Peer Through Depths
    public class PeerThroughDepthsMMA : MagicCard
    {
        public PeerThroughDepthsMMA()
        {
            Name = "Peer Through Depths";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant - Arcane";
            Text = "Look at the top five cards of your library. You may reveal an instant or sorcery card from among them and put it into your hand. Put the rest on the bottom of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Penumbra Spider
    public class PenumbraSpiderMMA : MagicCard
    {
        public PenumbraSpiderMMA()
        {
            Name = "Penumbra Spider";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "2GG";
            PT = "2/4";
            Type = "Creature - Spider";
            Text = "Reach;^When Penumbra Spider dies, put a 2/4 black Spider creature token with reach onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Peppersmoke
    public class PeppersmokeMMA : MagicCard
    {
        public PeppersmokeMMA()
        {
            Name = "Peppersmoke";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Tribal Instant - Faerie";
            Text = "Target creature gets -1/-1 until end of turn. If you control a Faerie, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Perilous Research
    public class PerilousResearchMMA : MagicCard
    {
        public PerilousResearchMMA()
        {
            Name = "Perilous Research";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Draw two cards, then sacrifice a permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Pestermite
    public class PestermiteMMA : MagicCard
    {
        public PestermiteMMA()
        {
            Name = "Pestermite";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "2/1";
            Type = "Creature - Faerie Rogue";
            Text = "Flash;^Flying;^When Pestermite enters the battlefield, you may tap or untap target permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Petals of Insight
    public class PetalsofInsightMMA : MagicCard
    {
        public PetalsofInsightMMA()
        {
            Name = "Petals of Insight";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "4U";
            PT = "";
            Type = "Sorcery - Arcane";
            Text = "Look at the top three cards of your library. You may put those cards on the bottom of your library in any order. If you do, return Petals of Insight to its owner�s hand. Otherwise, draw three cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Phthisis
    public class PhthisisMMA : MagicCard
    {
        public PhthisisMMA()
        {
            Name = "Phthisis";
            Edition = "MMA";
            Rarity = "U";
            Color = "B";
            Cost = "3BBBB";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target creature. Its controller loses life equal to its power plus its toughness.;^Suspend 5�%1%B @(Rather than cast this card from your hand, you may pay %1%B and exile it with five time counters on it. At the beginning of your upkeep, remove a time counter. When the last is removed, cast it without paying its mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Plumeveil
    public class PlumeveilMMA : MagicCard
    {
        public PlumeveilMMA()
        {
            Name = "Plumeveil";
            Edition = "MMA";
            Rarity = "U";
            Color = "Gld";
            Cost = "%D%D%D";
            PT = "4/4";
            Type = "Creature - Elemental";
            Text = "Flash;^Defender, flying";
            Flavor = "";
        }
    }
    # endregion

    # region Progenitus
    public class ProgenitusMMA : MagicCard
    {
        public ProgenitusMMA()
        {
            Name = "Progenitus";
            Edition = "MMA";
            Rarity = "M";
            Color = "Gld";
            Cost = "WWUUBBRRGG";
            PT = "10/10";
            Type = "Legendary Creature - Hydra Avatar";
            Text = "Protection from everything;^If Progenitus would be put into a graveyard from anywhere, reveal Progenitus and shuffle it into its owner�s library instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Pyrite Spellbomb
    public class PyriteSpellbombMMA : MagicCard
    {
        public PyriteSpellbombMMA()
        {
            Name = "Pyrite Spellbomb";
            Edition = "MMA";
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

    # region Pyromancer's Swath
    public class PyromancersSwathMMA : MagicCard
    {
        public PyromancersSwathMMA()
        {
            Name = "Pyromancer's Swath";
            Edition = "MMA";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Enchantment";
            Text = "If an instant or sorcery source you control would deal damage to a creature or player, it deals that much damage plus 2 to that creature or player instead.;^At the beginning of each end step, discard your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Rathi Trapper
    public class RathiTrapperMMA : MagicCard
    {
        public RathiTrapperMMA()
        {
            Name = "Rathi Trapper";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "1/2";
            Type = "Creature - Human Rebel Rogue";
            Text = "%B, %T: Tap target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Raven's Crime
    public class RavensCrimeMMA : MagicCard
    {
        public RavensCrimeMMA()
        {
            Name = "Raven's Crime";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Sorcery";
            Text = "Target player discards a card.;^Retrace @(You may cast this card from your graveyard by discarding a land card in addition to paying its other costs.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Reach of Branches
    public class ReachofBranchesMMA : MagicCard
    {
        public ReachofBranchesMMA()
        {
            Name = "Reach of Branches";
            Edition = "MMA";
            Rarity = "U";
            Color = "G";
            Cost = "4G";
            PT = "";
            Type = "Tribal Instant - Treefolk";
            Text = "Put a 2/5 green Treefolk Shaman creature token onto the battlefield.;^Whenever a Forest enters the battlefield under your control, you may return Reach of Branches from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Reach Through Mists
    public class ReachThroughMistsMMA : MagicCard
    {
        public ReachThroughMistsMMA()
        {
            Name = "Reach Through Mists";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant - Arcane";
            Text = "Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Relic of Progenitus
    public class RelicofProgenitusMMA : MagicCard
    {
        public RelicofProgenitusMMA()
        {
            Name = "Relic of Progenitus";
            Edition = "MMA";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%T: Target player exiles a card from his or her graveyard.;^%1, Exile Relic of Progenitus: Exile all cards from all graveyards. Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Reveillark
    public class ReveillarkMMA : MagicCard
    {
        public ReveillarkMMA()
        {
            Name = "Reveillark";
            Edition = "MMA";
            Rarity = "R";
            Color = "W";
            Cost = "4W";
            PT = "4/3";
            Type = "Creature - Elemental";
            Text = "Flying;^When Reveillark leaves the battlefield, return up to two target creature cards with power 2 or less from your graveyard to the battlefield.;^Evoke %5%W @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Rift Bolt
    public class RiftBoltMMA : MagicCard
    {
        public RiftBoltMMA()
        {
            Name = "Rift Bolt";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Sorcery";
            Text = "Rift Bolt deals 3 damage to target creature or player.;^Suspend 1�%R @(Rather than cast this card from your hand, you may pay %R and exile it with a time counter on it. At the beginning of your upkeep, remove a time counter. When the last is removed, cast it without paying its mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Rift Elemental
    public class RiftElementalMMA : MagicCard
    {
        public RiftElementalMMA()
        {
            Name = "Rift Elemental";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Elemental";
            Text = "%1%R, Remove a time counter from a permanent you control or suspended card you own: Rift Elemental gets +2/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Riftsweeper
    public class RiftsweeperMMA : MagicCard
    {
        public RiftsweeperMMA()
        {
            Name = "Riftsweeper";
            Edition = "MMA";
            Rarity = "U";
            Color = "G";
            Cost = "1G";
            PT = "2/2";
            Type = "Creature - Elf Shaman";
            Text = "When Riftsweeper enters the battlefield, choose target face-up exiled card. Its owner shuffles it into his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Riftwing Cloudskate
    public class RiftwingCloudskateMMA : MagicCard
    {
        public RiftwingCloudskateMMA()
        {
            Name = "Riftwing Cloudskate";
            Edition = "MMA";
            Rarity = "U";
            Color = "U";
            Cost = "3UU";
            PT = "2/2";
            Type = "Creature - Illusion";
            Text = "Flying;^When Riftwing Cloudskate enters the battlefield, return target permanent to its owner�s hand.;^Suspend 3�%1%U @(Rather than cast this card from your hand, you may pay %1%U and exile it with three time counters on it. At the beginning of your upkeep, remove a time counter. When the last is removed, cast it without paying its mana cost. It has haste.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Rude Awakening
    public class RudeAwakeningMMA : MagicCard
    {
        public RudeAwakeningMMA()
        {
            Name = "Rude Awakening";
            Edition = "MMA";
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

    # region Runed Stalactite
    public class RunedStalactiteMMA : MagicCard
    {
        public RunedStalactiteMMA()
        {
            Name = "Runed Stalactite";
            Edition = "MMA";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +1/+1 and is every creature type.^Equip %2";
            Flavor = "";
        }
    }
    # endregion

    # region Ryusei, the Falling Star
    public class RyuseitheFallingStarMMA : MagicCard
    {
        public RyuseitheFallingStarMMA()
        {
            Name = "Ryusei, the Falling Star";
            Edition = "MMA";
            Rarity = "M";
            Color = "R";
            Cost = "5R";
            PT = "5/5";
            Type = "Legendary Creature - Dragon Spirit";
            Text = "Flying;^When Ryusei, the Falling Star dies, it deals 5 damage to each creature without flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Saltfield Recluse
    public class SaltfieldRecluseMMA : MagicCard
    {
        public SaltfieldRecluseMMA()
        {
            Name = "Saltfield Recluse";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "1/2";
            Type = "Creature - Human Rebel Cleric";
            Text = "%T: Target creature gets -2/-0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Sanctum Gargoyle
    public class SanctumGargoyleMMA : MagicCard
    {
        public SanctumGargoyleMMA()
        {
            Name = "Sanctum Gargoyle";
            Edition = "MMA";
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

    # region Sandsower
    public class SandsowerMMA : MagicCard
    {
        public SandsowerMMA()
        {
            Name = "Sandsower";
            Edition = "MMA";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "1/3";
            Type = "Creature - Spirit";
            Text = "Tap three untapped creatures you control: Tap target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Sarkhan Vol
    public class SarkhanVolMMA : MagicCard
    {
        public SarkhanVolMMA()
        {
            Name = "Sarkhan Vol";
            Edition = "MMA";
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

    # region Scion of Oona
    public class ScionofOonaMMA : MagicCard
    {
        public ScionofOonaMMA()
        {
            Name = "Scion of Oona";
            Edition = "MMA";
            Rarity = "R";
            Color = "U";
            Cost = "2U";
            PT = "1/1";
            Type = "Creature - Faerie Soldier";
            Text = "Flash;^Flying;^Other Faerie creatures you control get +1/+1.;^Other Faeries you control have shroud.";
            Flavor = "";
        }
    }
    # endregion

    # region Search for Tomorrow
    public class SearchforTomorrowMMA : MagicCard
    {
        public SearchforTomorrowMMA()
        {
            Name = "Search for Tomorrow";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Sorcery";
            Text = "Search your library for a basic land card and put it onto the battlefield. Then shuffle your library.;^Suspend 2�%G @(Rather than cast this card from your hand, you may pay %G and exile it with two time counters on it. At the beginning of your upkeep, remove a time counter. When the last is removed, cast it without paying its mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Shrapnel Blast
    public class ShrapnelBlastMMA : MagicCard
    {
        public ShrapnelBlastMMA()
        {
            Name = "Shrapnel Blast";
            Edition = "MMA";
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

    # region Skeletal Vampire
    public class SkeletalVampireMMA : MagicCard
    {
        public SkeletalVampireMMA()
        {
            Name = "Skeletal Vampire";
            Edition = "MMA";
            Rarity = "R";
            Color = "B";
            Cost = "4BB";
            PT = "3/3";
            Type = "Creature - Vampire Skeleton";
            Text = "Flying;^When Skeletal Vampire enters the battlefield, put two 1/1 black Bat creature tokens with flying onto the battlefield.;^%3%B%B, Sacrifice a Bat: Put two 1/1 black Bat creature tokens with flying onto the battlefield.;^Sacrifice a Bat: Regenerate Skeletal Vampire.";
            Flavor = "";
        }
    }
    # endregion

    # region Skyreach Manta
    public class SkyreachMantaMMA : MagicCard
    {
        public SkyreachMantaMMA()
        {
            Name = "Skyreach Manta";
            Edition = "MMA";
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

    # region Slaughter Pact
    public class SlaughterPactMMA : MagicCard
    {
        public SlaughterPactMMA()
        {
            Name = "Slaughter Pact";
            Edition = "MMA";
            Rarity = "R";
            Color = "B";
            Cost = "0";
            PT = "";
            Type = "Instant";
            Text = "Destroy target nonblack creature.;^At the beginning of your next upkeep, pay %2%B. If you don�t, you lose the game.";
            Flavor = "";
        }
    }
    # endregion

    # region Spell Snare
    public class SpellSnareMMA : MagicCard
    {
        public SpellSnareMMA()
        {
            Name = "Spell Snare";
            Edition = "MMA";
            Rarity = "U";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell with converted mana cost 2.";
            Flavor = "";
        }
    }
    # endregion

    # region Spellstutter Sprite
    public class SpellstutterSpriteMMA : MagicCard
    {
        public SpellstutterSpriteMMA()
        {
            Name = "Spellstutter Sprite";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Faerie Wizard";
            Text = "Flash;^Flying;^When Spellstutter Sprite enters the battlefield, counter target spell with converted mana cost X or less, where X is the number of Faeries you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Sporesower Thallid
    public class SporesowerThallidMMA : MagicCard
    {
        public SporesowerThallidMMA()
        {
            Name = "Sporesower Thallid";
            Edition = "MMA";
            Rarity = "U";
            Color = "G";
            Cost = "2GG";
            PT = "4/4";
            Type = "Creature - Fungus";
            Text = "At the beginning of your upkeep, put a spore counter on each Fungus you control.;^Remove three spore counters from Sporesower Thallid: Put a 1/1 green Saproling creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Sporoloth Ancient
    public class SporolothAncientMMA : MagicCard
    {
        public SporolothAncientMMA()
        {
            Name = "Sporoloth Ancient";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "3GG";
            PT = "4/4";
            Type = "Creature - Fungus";
            Text = "At the beginning of your upkeep, put a spore counter on Sporoloth Ancient.;^Creatures you control have �Remove two spore counters from this creature: Put a 1/1 green Saproling creature token onto the battlefield.�";
            Flavor = "";
        }
    }
    # endregion

    # region Squee, Goblin Nabob
    public class SqueeGoblinNabobMMA : MagicCard
    {
        public SqueeGoblinNabobMMA()
        {
            Name = "Squee, Goblin Nabob";
            Edition = "MMA";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "1/1";
            Type = "Legendary Creature - Goblin";
            Text = "At the beginning of your upkeep, you may return Squee, Goblin Nabob from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Stingscourger
    public class StingscourgerMMA : MagicCard
    {
        public StingscourgerMMA()
        {
            Name = "Stingscourger";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "2/2";
            Type = "Creature - Goblin Warrior";
            Text = "Echo %3%R @(At the beginning of your upkeep, if this came under your control since the beginning of your last upkeep, sacrifice it unless you pay its echo cost.)@;^When Stingscourger enters the battlefield, return target creature an opponent controls to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Stinkdrinker Daredevil
    public class StinkdrinkerDaredevilMMA : MagicCard
    {
        public StinkdrinkerDaredevilMMA()
        {
            Name = "Stinkdrinker Daredevil";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "1/3";
            Type = "Creature - Goblin Rogue";
            Text = "Giant spells you cast cost %2 less to cast.";
            Flavor = "";
        }
    }
    # endregion

    # region Stinkweed Imp
    public class StinkweedImpMMA : MagicCard
    {
        public StinkweedImpMMA()
        {
            Name = "Stinkweed Imp";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "1/2";
            Type = "Creature - Imp";
            Text = "Flying;^Whenever Stinkweed Imp deals combat damage to a creature, destroy that creature.;^Dredge 5 @(If you would draw a card, instead you may put exactly five cards from the top of your library into your graveyard. If you do, return this card from your graveyard to your hand. Otherwise, draw a card.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Stir the Pride
    public class StirthePrideMMA : MagicCard
    {
        public StirthePrideMMA()
        {
            Name = "Stir the Pride";
            Edition = "MMA";
            Rarity = "U";
            Color = "W";
            Cost = "4W";
            PT = "";
            Type = "Instant";
            Text = "Choose one � Creatures you control get +2/+2 until end of turn; or until end of turn, creatures you control gain �Whenever this creature deals damage, you gain that much life.�;^Entwine %1%W @(Choose both if you pay the entwine cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Stonehewer Giant
    public class StonehewerGiantMMA : MagicCard
    {
        public StonehewerGiantMMA()
        {
            Name = "Stonehewer Giant";
            Edition = "MMA";
            Rarity = "R";
            Color = "W";
            Cost = "3WW";
            PT = "4/4";
            Type = "Creature - Giant Warrior";
            Text = "Vigilance;^%1%W, %T: Search your library for an Equipment card and put it onto the battlefield. Attach it to a creature you control. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Street Wraith
    public class StreetWraithMMA : MagicCard
    {
        public StreetWraithMMA()
        {
            Name = "Street Wraith";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "3BB";
            PT = "3/4";
            Type = "Creature - Wraith";
            Text = "Swampwalk;^Cycling�Pay 2 life. @(Pay 2 life, Discard this card: Draw a card.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Sudden Shock
    public class SuddenShockMMA : MagicCard
    {
        public SuddenShockMMA()
        {
            Name = "Sudden Shock";
            Edition = "MMA";
            Rarity = "U";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "Split second @(As long as this spell is on the stack, players can�t cast spells or activate abilities that aren�t mana abilities.)@;^Sudden Shock deals 2 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Summoner's Pact
    public class SummonersPactMMA : MagicCard
    {
        public SummonersPactMMA()
        {
            Name = "Summoner's Pact";
            Edition = "MMA";
            Rarity = "R";
            Color = "G";
            Cost = "0";
            PT = "";
            Type = "Instant";
            Text = "Search your library for a green creature card, reveal it, and put it into your hand. Then shuffle your library.;^At the beginning of your next upkeep, pay %2%G%G. If you don�t, you lose the game.";
            Flavor = "";
        }
    }
    # endregion

    # region Sword of Fire and Ice
    public class SwordofFireandIceMMA : MagicCard
    {
        public SwordofFireandIceMMA()
        {
            Name = "Sword of Fire and Ice";
            Edition = "MMA";
            Rarity = "M";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +2/+2 and has protection from red and from blue.;^Whenever equipped creature deals combat damage to a player, Sword of Fire and Ice deals 2 damage to target creature or player and you draw a card.;^Equip %2";
            Flavor = "";
        }
    }
    # endregion

    # region Sword of Light and Shadow
    public class SwordofLightandShadowMMA : MagicCard
    {
        public SwordofLightandShadowMMA()
        {
            Name = "Sword of Light and Shadow";
            Edition = "MMA";
            Rarity = "M";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +2/+2 and has protection from white and from black.;^Whenever equipped creature deals combat damage to a player, you gain 3 life and you may return up to one target creature card from your graveyard to your hand.;^Equip %2";
            Flavor = "";
        }
    }
    # endregion

    # region Sylvan Bounty
    public class SylvanBountyMMA : MagicCard
    {
        public SylvanBountyMMA()
        {
            Name = "Sylvan Bounty";
            Edition = "MMA";
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

    # region Syphon Life
    public class SyphonLifeMMA : MagicCard
    {
        public SyphonLifeMMA()
        {
            Name = "Syphon Life";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "1BB";
            PT = "";
            Type = "Sorcery";
            Text = "Target player loses 2 life and you gain 2 life.;^Retrace @(You may cast this card from your graveyard by discarding a land card in addition to paying its other costs.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Take Possession
    public class TakePossessionMMA : MagicCard
    {
        public TakePossessionMMA()
        {
            Name = "Take Possession";
            Edition = "MMA";
            Rarity = "U";
            Color = "U";
            Cost = "5UU";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Split second @(As long as this spell is on the stack, players can�t cast spells or activate abilities that aren�t mana abilities.)@;^Enchant permanent;^You control enchanted permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Tar Pitcher
    public class TarPitcherMMA : MagicCard
    {
        public TarPitcherMMA()
        {
            Name = "Tar Pitcher";
            Edition = "MMA";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "2/2";
            Type = "Creature - Goblin Shaman";
            Text = "%T, Sacrifice a Goblin: Tar Pitcher deals 2 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Tarmogoyf
    public class TarmogoyfMMA : MagicCard
    {
        public TarmogoyfMMA()
        {
            Name = "Tarmogoyf";
            Edition = "MMA";
            Rarity = "M";
            Color = "G";
            Cost = "1G";
            PT = "*/1+*";
            Type = "Creature - Lhurgoyf";
            Text = "Tarmogoyf�s power is equal to the number of card types among cards in all graveyards and its toughness is equal to that number plus 1.";
            Flavor = "";
        }
    }
    # endregion

    # region Terashi's Grasp
    public class TerashisGraspMMA : MagicCard
    {
        public TerashisGraspMMA()
        {
            Name = "Terashi's Grasp";
            Edition = "MMA";
            Rarity = "U";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Sorcery - Arcane";
            Text = "Destroy target artifact or enchantment. You gain life equal to its converted mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Terramorphic Expanse
    public class TerramorphicExpanseMMA : TerramorphicExpanseDDH
    {
        public TerramorphicExpanseMMA()
        {
            Name = "Terramorphic Expanse";
            Edition = "MMA";
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

    # region Test of Faith
    public class TestofFaithMMA : MagicCard
    {
        public TestofFaithMMA()
        {
            Name = "Test of Faith";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Prevent the next 3 damage that would be dealt to target creature this turn, and put a +1/+1 counter on that creature for each 1 damage prevented this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Thallid
    public class ThallidMMA : MagicCard
    {
        int spores = 0;

        public ThallidMMA()
        {
            Name = "Thallid";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Fungus";
            Text = "At the beginning of your upkeep, put a spore counter on Thallid.;^Remove three spore counters from Thallid: Put a 1/1 green Saproling creature token onto the battlefield.";
            Flavor = "";
        }

        public override void UpkeepCard()
        {
            spores++;
            base.UpkeepCard();
        }

        public override bool TryActivate(int i)
        {
            if (spores > 2)
            {
                spores -= 3;
                callActivating(i);
                //DoActivate(i);      //TODO work out why the call doesn't naturally go through
                return true;
            }

            return false;
        }

        public override void DoActivate(int i)
        {
            if (i == 0)
            {
                MagicCard mcn = new Saproling();
                mcn.PArea = PArea;
                mcn.OppArea = OppArea;

                PArea.PlayToken(mcn);
            }
        }
    }
    # endregion

    # region Thallid Germinator
    public class ThallidGerminatorMMA : MagicCard
    {
        public ThallidGerminatorMMA()
        {
            Name = "Thallid Germinator";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Fungus";
            Text = "At the beginning of your upkeep, put a spore counter on Thallid Germinator.;^Remove three spore counters from Thallid Germinator: Put a 1/1 green Saproling creature token onto the battlefield.;^Sacrifice a Saproling: Target creature gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Thallid Shell-Dweller
    public class ThallidShellDwellerMMA : MagicCard
    {
        public ThallidShellDwellerMMA()
        {
            Name = "Thallid Shell-Dweller";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "0/5";
            Type = "Creature - Fungus";
            Text = "Defender;^At the beginning of your upkeep, put a spore counter on Thallid Shell-Dweller.;^Remove three spore counters from Thallid Shell-Dweller: Put a 1/1 green Saproling creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Thieving Sprite
    public class ThievingSpriteMMA : MagicCard
    {
        public ThievingSpriteMMA()
        {
            Name = "Thieving Sprite";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "1/1";
            Type = "Creature - Faerie Rogue";
            Text = "Flying;^When Thieving Sprite enters the battlefield, target player reveals X cards from his or her hand, where X is the number of Faeries you control. You choose one of those cards. That player discards that card.";
            Flavor = "";
        }
    }
    # endregion

    # region Thirst for Knowledge
    public class ThirstforKnowledgeMMA : MagicCard
    {
        public ThirstforKnowledgeMMA()
        {
            Name = "Thirst for Knowledge";
            Edition = "MMA";
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

    # region Thundercloud Shaman
    public class ThundercloudShamanMMA : MagicCard
    {
        public ThundercloudShamanMMA()
        {
            Name = "Thundercloud Shaman";
            Edition = "MMA";
            Rarity = "U";
            Color = "R";
            Cost = "3RR";
            PT = "4/4";
            Type = "Creature - Giant Shaman";
            Text = "When Thundercloud Shaman enters the battlefield, it deals damage equal to the number of Giants you control to each non-Giant creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Thundering Giant
    public class ThunderingGiantMMA : MagicCard
    {
        public ThunderingGiantMMA()
        {
            Name = "Thundering Giant";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "3RR";
            PT = "4/3";
            Type = "Creature - Giant";
            Text = "Haste";
            Flavor = "";
        }
    }
    # endregion

    # region Tidehollow Sculler
    public class TidehollowScullerMMA : MagicCard
    {
        public TidehollowScullerMMA()
        {
            Name = "Tidehollow Sculler";
            Edition = "MMA";
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

    # region Tombstalker
    public class TombstalkerMMA : MagicCard
    {
        public TombstalkerMMA()
        {
            Name = "Tombstalker";
            Edition = "MMA";
            Rarity = "R";
            Color = "B";
            Cost = "6BB";
            PT = "5/5";
            Type = "Creature - Demon";
            Text = "Flying;^Delve @(Each card you exile from your graveyard while casting this spell pays for %1.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Tooth and Nail
    public class ToothandNailMMA : MagicCard
    {
        public ToothandNailMMA()
        {
            Name = "Tooth and Nail";
            Edition = "MMA";
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

    # region Torrent of Stone
    public class TorrentofStoneMMA : MagicCard
    {
        public TorrentofStoneMMA()
        {
            Name = "Torrent of Stone";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Instant - Arcane";
            Text = "Torrent of Stone deals 4 damage to target creature.;^Splice onto Arcane�Sacrifice two Mountains. @(As you cast an Arcane spell, you may reveal this card from your hand and pay its splice cost. If you do, add this card�s effects to that spell.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Traumatic Visions
    public class TraumaticVisionsMMA : MagicCard
    {
        public TraumaticVisionsMMA()
        {
            Name = "Traumatic Visions";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "3UU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell.;^Basic landcycling %1%U @(%1%U, Discard this card: Search your library for a basic land card, reveal it, and put it into your hand. Then shuffle your library.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Tribal Flames
    public class TribalFlamesMMA : MagicCard
    {
        public TribalFlamesMMA()
        {
            Name = "Tribal Flames";
            Edition = "MMA";
            Rarity = "U";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Sorcery";
            Text = "@Domain@ � Tribal Flames deals X damage to target creature or player, where X is the number of basic land types among lands you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Tromp the Domains
    public class TromptheDomainsMMA : MagicCard
    {
        public TromptheDomainsMMA()
        {
            Name = "Tromp the Domains";
            Edition = "MMA";
            Rarity = "U";
            Color = "G";
            Cost = "5G";
            PT = "";
            Type = "Sorcery";
            Text = "@Domain@ � Until end of turn, creatures you control gain trample and get +1/+1 for each basic land type among lands you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Trygon Predator
    public class TrygonPredatorMMA : MagicCard
    {
        public TrygonPredatorMMA()
        {
            Name = "Trygon Predator";
            Edition = "MMA";
            Rarity = "U";
            Color = "Gld";
            Cost = "1GU";
            PT = "2/3";
            Type = "Creature - Beast";
            Text = "Flying;^Whenever Trygon Predator deals combat damage to a player, you may destroy target artifact or enchantment that player controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Vedalken Dismisser
    public class VedalkenDismisserMMA : MagicCard
    {
        public VedalkenDismisserMMA()
        {
            Name = "Vedalken Dismisser";
            Edition = "MMA";
            Rarity = "C";
            Color = "U";
            Cost = "5U";
            PT = "2/2";
            Type = "Creature - Vedalken Wizard";
            Text = "When Vedalken Dismisser enters the battlefield, put target creature on top of its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Vedalken Shackles
    public class VedalkenShacklesMMA : MagicCard
    {
        public VedalkenShacklesMMA()
        {
            Name = "Vedalken Shackles";
            Edition = "MMA";
            Rarity = "M";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "You may choose not to untap Vedalken Shackles during your untap step.;^%2, %T: Gain control of target creature with power less than or equal to the number of Islands you control for as long as Vedalken Shackles remains tapped.";
            Flavor = "";
        }
    }
    # endregion

    # region Vendilion Clique
    public class VendilionCliqueMMA : MagicCard
    {
        public VendilionCliqueMMA()
        {
            Name = "Vendilion Clique";
            Edition = "MMA";
            Rarity = "M";
            Color = "U";
            Cost = "1UU";
            PT = "3/1";
            Type = "Legendary Creature - Faerie Wizard";
            Text = "Flash;^Flying;^When Vendilion Clique enters the battlefield, look at target player�s hand. You may choose a nonland card from it. If you do, that player reveals the chosen card, puts it on the bottom of his or her library, then draws a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Verdeloth the Ancient
    public class VerdeloththeAncientMMA : MagicCard
    {
        public VerdeloththeAncientMMA()
        {
            Name = "Verdeloth the Ancient";
            Edition = "MMA";
            Rarity = "R";
            Color = "G";
            Cost = "4GG";
            PT = "4/7";
            Type = "Legendary Creature - Treefolk";
            Text = "Kicker %X @(You may pay an additional %X as you cast this spell.)@;^Saproling creatures and other Treefolk creatures get +1/+1.;^When Verdeloth the Ancient enters the battlefield, if it was kicked, put X 1/1 green Saproling creature tokens onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Veteran Armorer
    public class VeteranArmorerMMA : MagicCard
    {
        public VeteranArmorerMMA()
        {
            Name = "Veteran Armorer";
            Edition = "MMA";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "2/2";
            Type = "Creature - Human Soldier";
            Text = "Other creatures you control get +0/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Vivid Crag
    public class VividCragMMA : MagicCard
    {
        public VividCragMMA()
        {
            Name = "Vivid Crag";
            Edition = "MMA";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Vivid Crag enters the battlefield tapped with two charge counters on it.;^%T: Add %R to your mana pool.;^%T, Remove a charge counter from Vivid Crag: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Vivid Creek
    public class VividCreekMMA : MagicCard
    {
        public VividCreekMMA()
        {
            Name = "Vivid Creek";
            Edition = "MMA";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Vivid Creek enters the battlefield tapped with two charge counters on it.;^%T: Add %U to your mana pool.;^%T, Remove a charge counter from Vivid Creek: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Vivid Grove
    public class VividGroveMMA : MagicCard
    {
        public VividGroveMMA()
        {
            Name = "Vivid Grove";
            Edition = "MMA";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Vivid Grove enters the battlefield tapped with two charge counters on it.;^%T: Add %G to your mana pool.;^%T, Remove a charge counter from Vivid Grove: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Vivid Marsh
    public class VividMarshMMA : MagicCard
    {
        public VividMarshMMA()
        {
            Name = "Vivid Marsh";
            Edition = "MMA";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Vivid Marsh enters the battlefield tapped with two charge counters on it.;^%T: Add %B to your mana pool.;^%T, Remove a charge counter from Vivid Marsh: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Vivid Meadow
    public class VividMeadowMMA : MagicCard
    {
        public VividMeadowMMA()
        {
            Name = "Vivid Meadow";
            Edition = "MMA";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Vivid Meadow enters the battlefield tapped with two charge counters on it.;^%T: Add %W to your mana pool.;^%T, Remove a charge counter from Vivid Meadow: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Walker of the Grove
    public class WalkeroftheGroveMMA : MagicCard
    {
        public WalkeroftheGroveMMA()
        {
            Name = "Walker of the Grove";
            Edition = "MMA";
            Rarity = "C";
            Color = "G";
            Cost = "6GG";
            PT = "7/7";
            Type = "Creature - Elemental";
            Text = "When Walker of the Grove leaves the battlefield, put a 4/4 green Elemental creature token onto the battlefield.;^Evoke %4%G @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Warren Pilferers
    public class WarrenPilferersMMA : MagicCard
    {
        public WarrenPilferersMMA()
        {
            Name = "Warren Pilferers";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "4B";
            PT = "3/3";
            Type = "Creature - Goblin Rogue";
            Text = "When Warren Pilferers enters the battlefield, return target creature card from your graveyard to your hand. If that card is a Goblin card, Warren Pilferers gains haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Warren Weirding
    public class WarrenWeirdingMMA : MagicCard
    {
        public WarrenWeirdingMMA()
        {
            Name = "Warren Weirding";
            Edition = "MMA";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Tribal Sorcery - Goblin";
            Text = "Target player sacrifices a creature. If a Goblin is sacrificed this way, that player puts two 1/1 black Goblin Rogue creature tokens onto the battlefield, and those tokens gain haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region War-Spike Changeling
    public class WarSpikeChangelingMMA : MagicCard
    {
        public WarSpikeChangelingMMA()
        {
            Name = "War-Spike Changeling";
            Edition = "MMA";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "3/3";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^%R: War-Spike Changeling gains first strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Woodfall Primus
    public class WoodfallPrimusMMA : MagicCard
    {
        public WoodfallPrimusMMA()
        {
            Name = "Woodfall Primus";
            Edition = "MMA";
            Rarity = "R";
            Color = "G";
            Cost = "5GGG";
            PT = "6/6";
            Type = "Creature - Treefolk Shaman";
            Text = "Trample;^When Woodfall Primus enters the battlefield, destroy target noncreature permanent.;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Worm Harvest
    public class WormHarvestMMA : MagicCard
    {
        public WormHarvestMMA()
        {
            Name = "Worm Harvest";
            Edition = "MMA";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%Q%Q%Q";
            PT = "";
            Type = "Sorcery";
            Text = "Put a 1/1 black and green Worm creature token onto the battlefield for each land card in your graveyard.;^Retrace @(You may cast this card from your graveyard by discarding a land card in addition to paying its other costs.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Yosei, the Morning Star
    public class YoseitheMorningStarMMA : MagicCard
    {
        public YoseitheMorningStarMMA()
        {
            Name = "Yosei, the Morning Star";
            Edition = "MMA";
            Rarity = "M";
            Color = "W";
            Cost = "4WW";
            PT = "5/5";
            Type = "Legendary Creature - Dragon Spirit";
            Text = "Flying;^When Yosei, the Morning Star dies, target player skips his or her next untap step. Tap up to five target permanents that player controls.";
            Flavor = "";
        }
    }
    # endregion
    # endregion
}
