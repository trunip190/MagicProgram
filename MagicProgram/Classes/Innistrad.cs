using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
# region Avacyn Restored
    # region Abundant Growth
class AbundantGrowthAVR : MagicCard
{
	public AbundantGrowthAVR()
	{
		 Name = "Abundant Growth";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "G";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant land;^When Abundant Growth enters the battlefield, draw a card.;^Enchanted land has �%T: Add one mana of any color to your mana pool.�";
		 Flavor = "";
	}
}
# endregion

# region Aggravate
class AggravateAVR : MagicCard
{
	public AggravateAVR()
	{
		 Name = "Aggravate";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "R";
		 Cost = "3RR";
		 PT = "";
		 Type = "Instant";
		 Text = "Aggravate deals 1 damage to each creature target player controls. Each creature dealt damage this way attacks this turn if able.";
		 Flavor = "";
	}
}
# endregion

# region Alchemist's Apprentice
class AlchemistsApprenticeAVR : MagicCard
{
	public AlchemistsApprenticeAVR()
	{
		 Name = "Alchemist's Apprentice";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "1U";
		 PT = "1/1";
		 Type = "Creature - Human Wizard";
		 Text = "Sacrifice Alchemist�s Apprentice: Draw a card.";
		 Flavor = "";
	}
}
# endregion

# region Alchemist's Refuge
class AlchemistsRefugeAVR : MagicCard
{
	public AlchemistsRefugeAVR()
	{
		 Name = "Alchemist's Refuge";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "Lnd";
		 Cost = "";
		 PT = "";
		 Type = "Land";
		 Text = "%T: Add %1 to your mana pool.;^%G%U, %T: You may cast nonland cards this turn as though they had flash.";
		 Flavor = "";
	}
}
# endregion

# region Amass the Components
class AmasstheComponentsAVR : MagicCard
{
	public AmasstheComponentsAVR()
	{
		 Name = "Amass the Components";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "3U";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Draw three cards, then put a card from your hand on the bottom of your library.";
		 Flavor = "";
	}
}
# endregion

# region Angel of Glory's Rise
class AngelofGlorysRiseAVR : MagicCard
{
	public AngelofGlorysRiseAVR()
	{
		 Name = "Angel of Glory's Rise";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "W";
		 Cost = "5WW";
		 PT = "4/6";
		 Type = "Creature - Angel";
		 Text = "Flying;^When Angel of Glory�s Rise enters the battlefield, exile all Zombies, then return all Human creature cards from your graveyard to the battlefield.";
		 Flavor = "";
	}
}
# endregion

# region Angel of Jubilation
class AngelofJubilationAVR : MagicCard
{
	public AngelofJubilationAVR()
	{
		 Name = "Angel of Jubilation";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "W";
		 Cost = "1WWW";
		 PT = "3/3";
		 Type = "Creature - Angel";
		 Text = "Flying;^Other nonblack creatures you control get +1/+1.;^Players can�t pay life or sacrifice creatures to cast spells or activate abilities.";
		 Flavor = "";
	}
}
# endregion

# region Angelic Armaments
class AngelicArmamentsAVR : MagicCard
{
	public AngelicArmamentsAVR()
	{
		 Name = "Angelic Armaments";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "Art";
		 Cost = "3";
		 PT = "";
		 Type = "Artifact - Equipment";
		 Text = "Equipped creature gets +2/+2, has flying, and is a white Angel in addition to its other colors and types.;^Equip %4";
		 Flavor = "";
	}
}
# endregion

# region Angelic Wall
class AngelicWallAVR : MagicCard
{
	public AngelicWallAVR()
	{
		 Name = "Angelic Wall";
		 Edition = "AVR";
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

# region Angel's Mercy
class AngelsMercyAVR : MagicCard
{
	public AngelsMercyAVR()
	{
		 Name = "Angel's Mercy";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "2WW";
		 PT = "";
		 Type = "Instant";
		 Text = "You gain 7 life.";
		 Flavor = "";
	}
}
# endregion

# region Angel's Tomb
class AngelsTombAVR : MagicCard
{
	public AngelsTombAVR()
	{
		 Name = "Angel's Tomb";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "Art";
		 Cost = "3";
		 PT = "";
		 Type = "Artifact";
		 Text = "Whenever a creature enters the battlefield under your control, you may have Angel�s Tomb become a 3/3 white Angel artifact creature with flying until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Appetite for Brains
class AppetiteforBrainsAVR : MagicCard
{
	public AppetiteforBrainsAVR()
	{
		 Name = "Appetite for Brains";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "B";
		 Cost = "B";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Target opponent reveals his or her hand. You choose a card from it with converted mana cost 4 or greater and exile that card.";
		 Flavor = "";
	}
}
# endregion

# region Arcane Melee
class ArcaneMeleeAVR : MagicCard
{
	public ArcaneMeleeAVR()
	{
		 Name = "Arcane Melee";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "U";
		 Cost = "4U";
		 PT = "";
		 Type = "Enchantment";
		 Text = "Instant and sorcery spells cost %2 less to cast.";
		 Flavor = "";
	}
}
# endregion

# region Archangel
class ArchangelAVR : MagicCard
{
	public ArchangelAVR()
	{
		 Name = "Archangel";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "W";
		 Cost = "5WW";
		 PT = "5/5";
		 Type = "Creature - Angel";
		 Text = "Flying, vigilance";
		 Flavor = "";
	}
}
# endregion

# region Archwing Dragon
class ArchwingDragonAVR : MagicCard
{
	public ArchwingDragonAVR()
	{
		 Name = "Archwing Dragon";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "R";
		 Cost = "2RR";
		 PT = "4/4";
		 Type = "Creature - Dragon";
		 Text = "Flying, haste;^At the beginning of the end step, return Archwing Dragon to its owner�s hand.";
		 Flavor = "";
	}
}
# endregion

# region Avacyn, Angel of Hope
class AvacynAngelofHopeAVR : MagicCard
{
	public AvacynAngelofHopeAVR()
	{
		 Name = "Avacyn, Angel of Hope";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "W";
		 Cost = "5WWW";
		 PT = "8/8";
		 Type = "Legendary Creature - Angel";
		 Text = "Flying, vigilance, indestructible;^Other permanents you control have indestructible.";
		 Flavor = "";
	}
}
# endregion

# region Banishing Stroke
class BanishingStrokeAVR : MagicCard
{
	public BanishingStrokeAVR()
	{
		 Name = "Banishing Stroke";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "W";
		 Cost = "5W";
		 PT = "";
		 Type = "Instant";
		 Text = "Put target artifact, creature, or enchantment on the bottom of its owner�s library.;^Miracle %W @(You may cast this card for its miracle cost when you draw it if it�s the first card you drew this turn.)@";
		 Flavor = "";
	}
}
# endregion

# region Banners Raised
class BannersRaisedAVR : MagicCard
{
	public BannersRaisedAVR()
	{
		 Name = "Banners Raised";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "R";
		 PT = "";
		 Type = "Instant";
		 Text = "Creatures you control get +1/+0 until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Barter in Blood
class BarterinBloodAVR : MagicCard
{
	public BarterinBloodAVR()
	{
		 Name = "Barter in Blood";
		 Edition = "AVR";
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

# region Battle Hymn
class BattleHymnAVR : MagicCard
{
	public BattleHymnAVR()
	{
		 Name = "Battle Hymn";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "1R";
		 PT = "";
		 Type = "Instant";
		 Text = "Add %R to your mana pool for each creature you control.";
		 Flavor = "";
	}
}
# endregion

# region Bladed Bracers
class BladedBracersAVR : MagicCard
{
	public BladedBracersAVR()
	{
		 Name = "Bladed Bracers";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "Art";
		 Cost = "1";
		 PT = "";
		 Type = "Artifact - Equipment";
		 Text = "Equipped creature gets +1/+1.;^As long as equipped creature is a Human or an Angel, it has vigilance.;^Equip %2 @(%2: Attach to target creature you control. Equip only as a sorcery.)@";
		 Flavor = "";
	}
}
# endregion

# region Blessings of Nature
class BlessingsofNatureAVR : MagicCard
{
	public BlessingsofNatureAVR()
	{
		 Name = "Blessings of Nature";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "G";
		 Cost = "4G";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Distribute four +1/+1 counters among any number of target creatures.;^Miracle %G @(You may cast this card for its miracle cost when you draw it if it�s the first card you drew this turn.)@";
		 Flavor = "";
	}
}
# endregion

# region Blood Artist
class BloodArtistAVR : MagicCard
{
	public BloodArtistAVR()
	{
		 Name = "Blood Artist";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "B";
		 Cost = "1B";
		 PT = "0/1";
		 Type = "Creature - Vampire";
		 Text = "Whenever Blood Artist or another creature dies, target player loses 1 life and you gain 1 life.";
		 Flavor = "";
	}
}
# endregion

# region Bloodflow Connoisseur
class BloodflowConnoisseurAVR : MagicCard
{
	public BloodflowConnoisseurAVR()
	{
		 Name = "Bloodflow Connoisseur";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "2B";
		 PT = "1/1";
		 Type = "Creature - Vampire";
		 Text = "Sacrifice a creature: Put a +1/+1 counter on Bloodflow Connoisseur.";
		 Flavor = "";
	}
}
# endregion

# region Bone Splinters
class BoneSplintersAVR : MagicCard
{
	public BoneSplintersAVR()
	{
		 Name = "Bone Splinters";
		 Edition = "AVR";
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

# region Bonfire of the Damned
class BonfireoftheDamnedAVR : MagicCard
{
	public BonfireoftheDamnedAVR()
	{
		 Name = "Bonfire of the Damned";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "R";
		 Cost = "XXR";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Bonfire of the Damned deals X damage to target player and each creature he or she controls.;^Miracle %X%R @(You may cast this card for its miracle cost when you draw it if it�s the first card you drew this turn.)@";
		 Flavor = "";
	}
}
# endregion

# region Borderland Ranger
class BorderlandRangerAVR : MagicCard
{
	public BorderlandRangerAVR()
	{
		 Name = "Borderland Ranger";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "2G";
		 PT = "2/2";
		 Type = "Creature - Human Scout";
		 Text = "When Borderland Ranger enters the battlefield, you may search your library for a basic land card, reveal it, and put it into your hand. If you do, shuffle your library.";
		 Flavor = "";
	}
}
# endregion

# region Bower Passage
class BowerPassageAVR : MagicCard
{
	public BowerPassageAVR()
	{
		 Name = "Bower Passage";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "G";
		 Cost = "1G";
		 PT = "";
		 Type = "Enchantment";
		 Text = "Creatures with flying can�t block creatures you control.";
		 Flavor = "";
	}
}
# endregion

# region Bruna, Light of Alabaster
class BrunaLightofAlabasterAVR : MagicCard
{
	public BrunaLightofAlabasterAVR()
	{
		 Name = "Bruna, Light of Alabaster";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "Gld";
		 Cost = "3WWU";
		 PT = "5/5";
		 Type = "Legendary Creature - Angel";
		 Text = "Flying, vigilance;^Whenever Bruna, Light of Alabaster attacks or blocks, you may attach to it any number of Auras on the battlefield and you may put onto the battlefield attached to it any number of Aura cards that could enchant it from your graveyard and/or hand.";
		 Flavor = "";
	}
}
# endregion

# region Builder's Blessing
class BuildersBlessingAVR : MagicCard
{
	public BuildersBlessingAVR()
	{
		 Name = "Builder's Blessing";
		 Edition = "AVR";
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

# region Burn at the Stake
class BurnattheStakeAVR : MagicCard
{
	public BurnattheStakeAVR()
	{
		 Name = "Burn at the Stake";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "R";
		 Cost = "2RRR";
		 PT = "";
		 Type = "Sorcery";
		 Text = "As an additional cost to cast Burn at the Stake, tap any number of untapped creatures you control.;^Burn at the Stake deals damage to target creature or player equal to three times the number of creatures tapped this way.";
		 Flavor = "";
	}
}
# endregion

# region Butcher Ghoul
class ButcherGhoulAVR : MagicCard
{
	public ButcherGhoulAVR()
	{
		 Name = "Butcher Ghoul";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "1B";
		 PT = "1/1";
		 Type = "Creature - Zombie";
		 Text = "Undying @(When this creature dies, if it had no +1/+1 counters on it, return it to the battlefield under its owner�s control with a +1/+1 counter on it.)@";
		 Flavor = "";
	}
}
# endregion

# region Call to Serve
class CalltoServeAVR : MagicCard
{
	public CalltoServeAVR()
	{
		 Name = "Call to Serve";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "1W";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant nonblack creature;^Enchanted creature gets +1/+2, has flying, and is an Angel in addition to its other types.";
		 Flavor = "";
	}
}
# endregion

# region Captain of the Mists
class CaptainoftheMistsAVR : MagicCard
{
	public CaptainoftheMistsAVR()
	{
		 Name = "Captain of the Mists";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "U";
		 Cost = "2U";
		 PT = "2/3";
		 Type = "Creature - Human Wizard";
		 Text = "Whenever another Human enters the battlefield under your control, untap Captain of the Mists.;^%1%U, %T: You may tap or untap target permanent.";
		 Flavor = "";
	}
}
# endregion

# region Cathars' Crusade
class CatharsCrusadeAVR : MagicCard
{
	public CatharsCrusadeAVR()
	{
		 Name = "Cathars' Crusade";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "W";
		 Cost = "3WW";
		 PT = "";
		 Type = "Enchantment";
		 Text = "Whenever a creature enters the battlefield under your control, put a +1/+1 counter on each creature you control.";
		 Flavor = "";
	}
}
# endregion

# region Cathedral Sanctifier
class CathedralSanctifierAVR : MagicCard
{
	public CathedralSanctifierAVR()
	{
		 Name = "Cathedral Sanctifier";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "W";
		 PT = "1/1";
		 Type = "Creature - Human Cleric";
		 Text = "When Cathedral Sanctifier enters the battlefield, you gain 3 life.";
		 Flavor = "";
	}
}
# endregion

# region Cavern of Souls
class CavernofSoulsAVR : MagicCard
{
	public CavernofSoulsAVR()
	{
		 Name = "Cavern of Souls";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "Lnd";
		 Cost = "";
		 PT = "";
		 Type = "Land";
		 Text = "As Cavern of Souls enters the battlefield, choose a creature type.;^%T: Add %1 to your mana pool.;^%T: Add one mana of any color to your mana pool. Spend this mana only to cast a creature spell of the chosen type, and that spell can�t be countered.";
		 Flavor = "";
	}
}
# endregion

# region Champion of Lambholt
class ChampionofLambholtAVR : MagicCard
{
	public ChampionofLambholtAVR()
	{
		 Name = "Champion of Lambholt";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "G";
		 Cost = "1GG";
		 PT = "1/1";
		 Type = "Creature - Human Warrior";
		 Text = "Creatures with power less than Champion of Lambholt�s power can�t block creatures you control.;^Whenever another creature enters the battlefield under your control, put a +1/+1 counter on Champion of Lambholt.";
		 Flavor = "";
	}
}
# endregion

# region Cloudshift
class CloudshiftAVR : MagicCard
{
	public CloudshiftAVR()
	{
		 Name = "Cloudshift";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "W";
		 PT = "";
		 Type = "Instant";
		 Text = "Exile target creature you control, then return that card to the battlefield under your control.";
		 Flavor = "";
	}
}
# endregion

# region Commander's Authority
class CommandersAuthorityAVR : MagicCard
{
	public CommandersAuthorityAVR()
	{
		 Name = "Commander's Authority";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "W";
		 Cost = "4W";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant creature;^Enchanted creature has �At the beginning of your upkeep, put a 1/1 white Human creature token onto the battlefield.�";
		 Flavor = "";
	}
}
# endregion

# region Conjurer's Closet
class ConjurersClosetAVR : MagicCard
{
	public ConjurersClosetAVR()
	{
		 Name = "Conjurer's Closet";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "Art";
		 Cost = "5";
		 PT = "";
		 Type = "Artifact";
		 Text = "At the beginning of your end step, you may exile target creature you control, then return that card to the battlefield under your control.";
		 Flavor = "";
	}
}
# endregion

# region Corpse Traders
class CorpseTradersAVR : MagicCard
{
	public CorpseTradersAVR()
	{
		 Name = "Corpse Traders";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "B";
		 Cost = "3B";
		 PT = "3/3";
		 Type = "Creature - Human Rogue";
		 Text = "%2%B, Sacrifice a creature: Target opponent reveals his or her hand. You choose a card from it. That player discards that card. Activate this ability only any time you could cast a sorcery.";
		 Flavor = "";
	}
}
# endregion

# region Craterhoof Behemoth
class CraterhoofBehemothAVR : MagicCard
{
	public CraterhoofBehemothAVR()
	{
		 Name = "Craterhoof Behemoth";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "G";
		 Cost = "5GGG";
		 PT = "5/5";
		 Type = "Creature - Beast";
		 Text = "Haste;^When Craterhoof Behemoth enters the battlefield, creatures you control gain trample and get +X/+X until end of turn, where X is the number of creatures you control.";
		 Flavor = "";
	}
}
# endregion

# region Crippling Chill
class CripplingChillAVR : MagicCard
{
	public CripplingChillAVR()
	{
		 Name = "Crippling Chill";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "2U";
		 PT = "";
		 Type = "Instant";
		 Text = "Tap target creature. It doesn�t untap during its controller�s next untap step.;^Draw a card.";
		 Flavor = "";
	}
}
# endregion

# region Crypt Creeper
class CryptCreeperAVR : MagicCard
{
	public CryptCreeperAVR()
	{
		 Name = "Crypt Creeper";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "1B";
		 PT = "2/1";
		 Type = "Creature - Zombie";
		 Text = "Sacrifice Crypt Creeper: Exile target card from a graveyard.";
		 Flavor = "";
	}
}
# endregion

# region Cursebreak
class CursebreakAVR : MagicCard
{
	public CursebreakAVR()
	{
		 Name = "Cursebreak";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "1W";
		 PT = "";
		 Type = "Instant";
		 Text = "Destroy target enchantment. You gain 2 life.";
		 Flavor = "";
	}
}
# endregion

# region Dangerous Wager
class DangerousWagerAVR : MagicCard
{
	public DangerousWagerAVR()
	{
		 Name = "Dangerous Wager";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "1R";
		 PT = "";
		 Type = "Instant";
		 Text = "Discard your hand, then draw two cards.";
		 Flavor = "";
	}
}
# endregion

# region Dark Impostor
class DarkImpostorAVR : MagicCard
{
	public DarkImpostorAVR()
	{
		 Name = "Dark Impostor";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "B";
		 Cost = "2B";
		 PT = "2/2";
		 Type = "Creature - Vampire Assassin";
		 Text = "%4%B%B: Exile target creature and put a +1/+1 counter on Dark Impostor.;^Dark Impostor has all activated abilities of all creature cards exiled with it.";
		 Flavor = "";
	}
}
# endregion

# region Deadeye Navigator
class DeadeyeNavigatorAVR : MagicCard
{
	public DeadeyeNavigatorAVR()
	{
		 Name = "Deadeye Navigator";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "U";
		 Cost = "4UU";
		 PT = "5/5";
		 Type = "Creature - Spirit";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Deadeye Navigator is paired with another creature, each of those creatures has �%1%U: Exile this creature, then return it to the battlefield under your control.�";
		 Flavor = "";
	}
}
# endregion

# region Death Wind
class DeathWindAVR : MagicCard
{
	public DeathWindAVR()
	{
		 Name = "Death Wind";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "XB";
		 PT = "";
		 Type = "Instant";
		 Text = "Target creature gets -X/-X until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Defang
class DefangAVR : MagicCard
{
	public DefangAVR()
	{
		 Name = "Defang";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "1W";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant creature;^Prevent all damage that would be dealt by enchanted creature.";
		 Flavor = "";
	}
}
# endregion

# region Defy Death
class DefyDeathAVR : MagicCard
{
	public DefyDeathAVR()
	{
		 Name = "Defy Death";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "W";
		 Cost = "3WW";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Return target creature card from your graveyard to the battlefield. If it�s an Angel, put two +1/+1 counters on it.";
		 Flavor = "";
	}
}
# endregion

# region Demolish
class DemolishAVR : MagicCard
{
	public DemolishAVR()
	{
		 Name = "Demolish";
		 Edition = "AVR";
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

# region Demonic Rising
class DemonicRisingAVR : MagicCard
{
	public DemonicRisingAVR()
	{
		 Name = "Demonic Rising";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "B";
		 Cost = "3BB";
		 PT = "";
		 Type = "Enchantment";
		 Text = "At the beginning of your end step, if you control exactly one creature, put a 5/5 black Demon creature token with flying onto the battlefield.";
		 Flavor = "";
	}
}
# endregion

# region Demonic Taskmaster
class DemonicTaskmasterAVR : MagicCard
{
	public DemonicTaskmasterAVR()
	{
		 Name = "Demonic Taskmaster";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "B";
		 Cost = "2B";
		 PT = "4/3";
		 Type = "Creature - Demon";
		 Text = "Flying;^At the beginning of your upkeep, sacrifice a creature other than Demonic Taskmaster.";
		 Flavor = "";
	}
}
# endregion

# region Demonlord of Ashmouth
class DemonlordofAshmouthAVR : MagicCard
{
	public DemonlordofAshmouthAVR()
	{
		 Name = "Demonlord of Ashmouth";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "B";
		 Cost = "2BB";
		 PT = "5/4";
		 Type = "Creature - Demon";
		 Text = "Flying;^When Demonlord of Ashmouth enters the battlefield, exile it unless you sacrifice another creature.;^Undying @(When this creature dies, if it had no +1/+1 counters on it, return it to the battlefield under its owner�s control with a +1/+1 counter on it.)@";
		 Flavor = "";
	}
}
# endregion

# region Descendants' Path
class DescendantsPathAVR : MagicCard
{
	public DescendantsPathAVR()
	{
		 Name = "Descendants' Path";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "G";
		 Cost = "2G";
		 PT = "";
		 Type = "Enchantment";
		 Text = "At the beginning of your upkeep, reveal the top card of your library. If it�s a creature card that shares a creature type with a creature you control, you may cast that card without paying its mana cost. Otherwise, put that card on the bottom of your library.";
		 Flavor = "";
	}
}
# endregion

# region Descent into Madness
class DescentintoMadnessAVR : MagicCard
{
	public DescentintoMadnessAVR()
	{
		 Name = "Descent into Madness";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "B";
		 Cost = "3BB";
		 PT = "";
		 Type = "Enchantment";
		 Text = "At the beginning of your upkeep, put a despair counter on Descent into Madness, then each player exiles X permanents he or she controls and/or cards from his or her hand, where X is the number of despair counters on Descent into Madness.";
		 Flavor = "";
	}
}
# endregion

# region Desolate Lighthouse
class DesolateLighthouseAVR : MagicCard
{
	public DesolateLighthouseAVR()
	{
		 Name = "Desolate Lighthouse";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "Lnd";
		 Cost = "";
		 PT = "";
		 Type = "Land";
		 Text = "%T: Add %1 to your mana pool.;^%1%U%R, %T: Draw a card, then discard a card.";
		 Flavor = "";
	}
}
# endregion

# region Devastation Tide
class DevastationTideAVR : MagicCard
{
	public DevastationTideAVR()
	{
		 Name = "Devastation Tide";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "U";
		 Cost = "3UU";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Return all nonland permanents to their owners� hands.;^Miracle %1%U @(You may cast this card for its miracle cost when you draw it if it�s the first card you drew this turn.)@";
		 Flavor = "";
	}
}
# endregion

# region Devout Chaplain
class DevoutChaplainAVR : MagicCard
{
	public DevoutChaplainAVR()
	{
		 Name = "Devout Chaplain";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "W";
		 Cost = "2W";
		 PT = "2/2";
		 Type = "Creature - Human Cleric";
		 Text = "%T, Tap two untapped Humans you control: Exile target artifact or enchantment.";
		 Flavor = "";
	}
}
# endregion

# region Diregraf Escort
class DiregrafEscortAVR : MagicCard
{
	public DiregrafEscortAVR()
	{
		 Name = "Diregraf Escort";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "G";
		 PT = "1/1";
		 Type = "Creature - Human Cleric";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Diregraf Escort is paired with another creature, both creatures have protection from Zombies.";
		 Flavor = "";
	}
}
# endregion

# region Divine Deflection
class DivineDeflectionAVR : MagicCard
{
	public DivineDeflectionAVR()
	{
		 Name = "Divine Deflection";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "W";
		 Cost = "XW";
		 PT = "";
		 Type = "Instant";
		 Text = "Prevent the next X damage that would be dealt to you and/or permanents you control this turn. If damage is prevented this way, Divine Deflection deals that much damage to target creature or player.";
		 Flavor = "";
	}
}
# endregion

# region Dread Slaver
class DreadSlaverAVR : MagicCard
{
	public DreadSlaverAVR()
	{
		 Name = "Dread Slaver";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "B";
		 Cost = "3BB";
		 PT = "3/5";
		 Type = "Creature - Zombie Horror";
		 Text = "Whenever a creature dealt damage by Dread Slaver this turn dies, return it to the battlefield under your control. That creature is a black Zombie in addition to its other colors and types.";
		 Flavor = "";
	}
}
# endregion

# region Dreadwaters
class DreadwatersAVR : MagicCard
{
	public DreadwatersAVR()
	{
		 Name = "Dreadwaters";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "3U";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Target player puts the top X cards of his or her library into his or her graveyard, where X is the number of lands you control.";
		 Flavor = "";
	}
}
# endregion

# region Driver of the Dead
class DriveroftheDeadAVR : MagicCard
{
	public DriveroftheDeadAVR()
	{
		 Name = "Driver of the Dead";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "3B";
		 PT = "3/2";
		 Type = "Creature - Vampire";
		 Text = "When Driver of the Dead dies, return target creature card with converted mana cost 2 or less from your graveyard to the battlefield.";
		 Flavor = "";
	}
}
# endregion

# region Druid's Familiar
class DruidsFamiliarAVR : MagicCard
{
	public DruidsFamiliarAVR()
	{
		 Name = "Druid's Familiar";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "G";
		 Cost = "3G";
		 PT = "2/2";
		 Type = "Creature - Bear";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Druid�s Familiar is paired with another creature, each of those creatures gets +2/+2.";
		 Flavor = "";
	}
}
# endregion

# region Druids' Repository
class DruidsRepositoryAVR : MagicCard
{
	public DruidsRepositoryAVR()
	{
		 Name = "Druids' Repository";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "G";
		 Cost = "1GG";
		 PT = "";
		 Type = "Enchantment";
		 Text = "Whenever a creature you control attacks, put a charge counter on Druids� Repository.;^Remove a charge counter from Druids� Repository: Add one mana of any color to your mana pool.";
		 Flavor = "";
	}
}
# endregion

# region Dual Casting
class DualCastingAVR : MagicCard
{
	public DualCastingAVR()
	{
		 Name = "Dual Casting";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "R";
		 Cost = "1R";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant creature;^Enchanted creature has �%R, %T: Copy target instant or sorcery spell you control. You may choose new targets for the copy.�";
		 Flavor = "";
	}
}
# endregion

# region Eaten by Spiders
class EatenbySpidersAVR : MagicCard
{
	public EatenbySpidersAVR()
	{
		 Name = "Eaten by Spiders";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "G";
		 Cost = "2G";
		 PT = "";
		 Type = "Instant";
		 Text = "Destroy target creature with flying and all Equipment attached to that creature.";
		 Flavor = "";
	}
}
# endregion

# region Elgaud Shieldmate
class ElgaudShieldmateAVR : MagicCard
{
	public ElgaudShieldmateAVR()
	{
		 Name = "Elgaud Shieldmate";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "3U";
		 PT = "2/3";
		 Type = "Creature - Human Soldier";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Elgaud Shieldmate is paired with another creature, both creatures have hexproof. @(They can�t be the targets of spells or abilities your opponents control.)@";
		 Flavor = "";
	}
}
# endregion

# region Emancipation Angel
class EmancipationAngelAVR : MagicCard
{
	public EmancipationAngelAVR()
	{
		 Name = "Emancipation Angel";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "W";
		 Cost = "1WW";
		 PT = "3/3";
		 Type = "Creature - Angel";
		 Text = "Flying;^When Emancipation Angel enters the battlefield, return a permanent you control to its owner�s hand.";
		 Flavor = "";
	}
}
# endregion

# region Entreat the Angels
class EntreattheAngelsAVR : MagicCard
{
	public EntreattheAngelsAVR()
	{
		 Name = "Entreat the Angels";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "W";
		 Cost = "XXWWW";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Put X 4/4 white Angel creature tokens with flying onto the battlefield.;^Miracle %X%W%W @(You may cast this card for its miracle cost when you draw it if it�s the first card you drew this turn.)@";
		 Flavor = "";
	}
}
# endregion

# region Essence Harvest
class EssenceHarvestAVR : MagicCard
{
	public EssenceHarvestAVR()
	{
		 Name = "Essence Harvest";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "2B";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Target player loses X life and you gain X life, where X is the greatest power among creatures you control.";
		 Flavor = "";
	}
}
# endregion

# region Evernight Shade
class EvernightShadeAVR : MagicCard
{
	public EvernightShadeAVR()
	{
		 Name = "Evernight Shade";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "B";
		 Cost = "3B";
		 PT = "1/1";
		 Type = "Creature - Shade";
		 Text = "%B: Evernight Shade gets +1/+1 until end of turn.;^Undying @(When this creature dies, if it had no +1/+1 counters on it, return it to the battlefield under its owner�s control with a +1/+1 counter on it.)@";
		 Flavor = "";
	}
}
# endregion

# region Exquisite Blood
class ExquisiteBloodAVR : MagicCard
{
	public ExquisiteBloodAVR()
	{
		 Name = "Exquisite Blood";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "B";
		 Cost = "4B";
		 PT = "";
		 Type = "Enchantment";
		 Text = "Whenever an opponent loses life, you gain that much life.";
		 Flavor = "";
	}
}
# endregion

# region Falkenrath Exterminator
class FalkenrathExterminatorAVR : MagicCard
{
	public FalkenrathExterminatorAVR()
	{
		 Name = "Falkenrath Exterminator";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "R";
		 Cost = "1R";
		 PT = "1/1";
		 Type = "Creature - Vampire Archer";
		 Text = "Whenever Falkenrath Exterminator deals combat damage to a player, put a +1/+1 counter on it.;^%2%R: Falkenrath Exterminator deals damage to target creature equal to the number of +1/+1 counters on Falkenrath Exterminator.";
		 Flavor = "";
	}
}
# endregion

# region Farbog Explorer
class FarbogExplorerAVR : MagicCard
{
	public FarbogExplorerAVR()
	{
		 Name = "Farbog Explorer";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "2W";
		 PT = "2/3";
		 Type = "Creature - Human Scout";
		 Text = "Swampwalk @(This creature can�t be blocked as long as defending player controls a Swamp.)@";
		 Flavor = "";
	}
}
# endregion

# region Favorable Winds
class FavorableWindsAVR : MagicCard
{
	public FavorableWindsAVR()
	{
		 Name = "Favorable Winds";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "U";
		 Cost = "1U";
		 PT = "";
		 Type = "Enchantment";
		 Text = "Creatures you control with flying get +1/+1.";
		 Flavor = "";
	}
}
# endregion

# region Fervent Cathar
class FerventCatharAVR : MagicCard
{
	public FerventCatharAVR()
	{
		 Name = "Fervent Cathar";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "2R";
		 PT = "2/1";
		 Type = "Creature - Human Knight";
		 Text = "Haste;^When Fervent Cathar enters the battlefield, target creature can�t block this turn.";
		 Flavor = "";
	}
}
# endregion

# region Fettergeist
class FettergeistAVR : MagicCard
{
	public FettergeistAVR()
	{
		 Name = "Fettergeist";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "U";
		 Cost = "2U";
		 PT = "3/4";
		 Type = "Creature - Spirit";
		 Text = "Flying;^At the beginning of your upkeep, sacrifice Fettergeist unless you pay %1 for each other creature you control.";
		 Flavor = "";
	}
}
# endregion

# region Fleeting Distraction
class FleetingDistractionAVR : MagicCard
{
	public FleetingDistractionAVR()
	{
		 Name = "Fleeting Distraction";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "U";
		 PT = "";
		 Type = "Instant";
		 Text = "Target creature gets -1/-0 until end of turn.;^Draw a card.";
		 Flavor = "";
	}
}
# endregion

# region Flowering Lumberknot
class FloweringLumberknotAVR : MagicCard
{
	public FloweringLumberknotAVR()
	{
		 Name = "Flowering Lumberknot";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "3G";
		 PT = "5/5";
		 Type = "Creature - Treefolk";
		 Text = "Flowering Lumberknot can�t attack or block unless it�s paired with a creature with soulbond.";
		 Flavor = "";
	}
}
# endregion

# region Forest
class ForestAVR : MagicCard
{
	public ForestAVR()
	{
		 Name = "Forest";
		 Edition = "AVR";
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

# region Gallows at Willow Hill
class GallowsatWillowHillAVR : MagicCard
{
	public GallowsatWillowHillAVR()
	{
		 Name = "Gallows at Willow Hill";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "Art";
		 Cost = "3";
		 PT = "";
		 Type = "Artifact";
		 Text = "%3, %T, Tap three untapped Humans you control: Destroy target creature. Its controller puts a 1/1 white Spirit creature token with flying onto the battlefield.";
		 Flavor = "";
	}
}
# endregion

# region Galvanic Alchemist
class GalvanicAlchemistAVR : MagicCard
{
	public GalvanicAlchemistAVR()
	{
		 Name = "Galvanic Alchemist";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "2U";
		 PT = "1/4";
		 Type = "Creature - Human Wizard";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Galvanic Alchemist is paired with another creature, each of those creatures has �%2%U: Untap this creature.�";
		 Flavor = "";
	}
}
# endregion

# region Gang of Devils
class GangofDevilsAVR : MagicCard
{
	public GangofDevilsAVR()
	{
		 Name = "Gang of Devils";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "R";
		 Cost = "5R";
		 PT = "3/3";
		 Type = "Creature - Devil";
		 Text = "When Gang of Devils dies, it deals 3 damage divided as you choose among one, two, or three target creatures and/or players.";
		 Flavor = "";
	}
}
# endregion

# region Geist Snatch
class GeistSnatchAVR : MagicCard
{
	public GeistSnatchAVR()
	{
		 Name = "Geist Snatch";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "2UU";
		 PT = "";
		 Type = "Instant";
		 Text = "Counter target creature spell. Put a 1/1 blue Spirit creature token with flying onto the battlefield.";
		 Flavor = "";
	}
}
# endregion

# region Geist Trappers
class GeistTrappersAVR : MagicCard
{
	public GeistTrappersAVR()
	{
		 Name = "Geist Trappers";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "4G";
		 PT = "3/5";
		 Type = "Creature - Human Warrior";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Geist Trappers is paired with another creature, both creatures have reach.";
		 Flavor = "";
	}
}
# endregion

# region Ghostform
class GhostformAVR : MagicCard
{
	public GhostformAVR()
	{
		 Name = "Ghostform";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "1U";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Up to two target creatures can�t be blocked this turn.";
		 Flavor = "";
	}
}
# endregion

# region Ghostly Flicker
class GhostlyFlickerAVR : MagicCard
{
	public GhostlyFlickerAVR()
	{
		 Name = "Ghostly Flicker";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "2U";
		 PT = "";
		 Type = "Instant";
		 Text = "Exile two target artifacts, creatures, and/or lands you control, then return those cards to the battlefield under your control.";
		 Flavor = "";
	}
}
# endregion

# region Ghostly Touch
class GhostlyTouchAVR : MagicCard
{
	public GhostlyTouchAVR()
	{
		 Name = "Ghostly Touch";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "U";
		 Cost = "1U";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant creature;^Enchanted creature has �Whenever this creature attacks, you may tap or untap target permanent.�";
		 Flavor = "";
	}
}
# endregion

# region Ghoulflesh
class GhoulfleshAVR : MagicCard
{
	public GhoulfleshAVR()
	{
		 Name = "Ghoulflesh";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "B";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant creature;^Enchanted creature gets -1/-1 and is a black Zombie in addition to its other colors and types.";
		 Flavor = "";
	}
}
# endregion

# region Gisela, Blade of Goldnight
class GiselaBladeofGoldnightAVR : MagicCard
{
	public GiselaBladeofGoldnightAVR()
	{
		 Name = "Gisela, Blade of Goldnight";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "Gld";
		 Cost = "4RWW";
		 PT = "5/5";
		 Type = "Legendary Creature - Angel";
		 Text = "Flying, first strike;^If a source would deal damage to an opponent or a permanent an opponent controls, that source deals double that damage to that player or permanent instead.;^If a source would deal damage to you or a permanent you control, prevent half that damage, rounded up.";
		 Flavor = "";
	}
}
# endregion

# region Gloom Surgeon
class GloomSurgeonAVR : MagicCard
{
	public GloomSurgeonAVR()
	{
		 Name = "Gloom Surgeon";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "B";
		 Cost = "1B";
		 PT = "2/1";
		 Type = "Creature - Spirit";
		 Text = "If combat damage would be dealt to Gloom Surgeon, prevent that damage and exile that many cards from the top of your library.";
		 Flavor = "";
	}
}
# endregion

# region Gloomwidow
class GloomwidowAVR : MagicCard
{
	public GloomwidowAVR()
	{
		 Name = "Gloomwidow";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "G";
		 Cost = "2G";
		 PT = "3/3";
		 Type = "Creature - Spider";
		 Text = "Reach;^Gloomwidow can block only creatures with flying.";
		 Flavor = "";
	}
}
# endregion

# region Goldnight Commander
class GoldnightCommanderAVR : MagicCard
{
	public GoldnightCommanderAVR()
	{
		 Name = "Goldnight Commander";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "W";
		 Cost = "3W";
		 PT = "2/2";
		 Type = "Creature - Human Cleric Soldier";
		 Text = "Whenever another creature enters the battlefield under your control, creatures you control get +1/+1 until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Goldnight Redeemer
class GoldnightRedeemerAVR : MagicCard
{
	public GoldnightRedeemerAVR()
	{
		 Name = "Goldnight Redeemer";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "W";
		 Cost = "4WW";
		 PT = "4/4";
		 Type = "Creature - Angel";
		 Text = "Flying;^When Goldnight Redeemer enters the battlefield, you gain 2 life for each other creature you control.";
		 Flavor = "";
	}
}
# endregion

# region Grave Exchange
class GraveExchangeAVR : MagicCard
{
	public GraveExchangeAVR()
	{
		 Name = "Grave Exchange";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "4BB";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Return target creature card from your graveyard to your hand. Target player sacrifices a creature.";
		 Flavor = "";
	}
}
# endregion

# region Griselbrand
class GriselbrandAVR : MagicCard
{
	public GriselbrandAVR()
	{
		 Name = "Griselbrand";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "B";
		 Cost = "4BBBB";
		 PT = "7/7";
		 Type = "Legendary Creature - Demon";
		 Text = "Flying, lifelink;^Pay 7 life: Draw seven cards.";
		 Flavor = "";
	}
}
# endregion

# region Grounded
class GroundedAVR : MagicCard
{
	public GroundedAVR()
	{
		 Name = "Grounded";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "1G";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant creature;^Enchanted creature loses flying.";
		 Flavor = "";
	}
}
# endregion

# region Gryff Vanguard
class GryffVanguardAVR : MagicCard
{
	public GryffVanguardAVR()
	{
		 Name = "Gryff Vanguard";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "4U";
		 PT = "3/2";
		 Type = "Creature - Human Knight";
		 Text = "Flying;^When Gryff Vanguard enters the battlefield, draw a card.";
		 Flavor = "";
	}
}
# endregion

# region Guise of Fire
class GuiseofFireAVR : MagicCard
{
	public GuiseofFireAVR()
	{
		 Name = "Guise of Fire";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "R";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant creature;^Enchanted creature gets +1/-1 and attacks each turn if able.";
		 Flavor = "";
	}
}
# endregion

# region Hanweir Lancer
class HanweirLancerAVR : MagicCard
{
	public HanweirLancerAVR()
	{
		 Name = "Hanweir Lancer";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "2R";
		 PT = "2/2";
		 Type = "Creature - Human Knight";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Hanweir Lancer is paired with another creature, both creatures have first strike.";
		 Flavor = "";
	}
}
# endregion

# region Harvester of Souls
class HarvesterofSoulsAVR : MagicCard
{
	public HarvesterofSoulsAVR()
	{
		 Name = "Harvester of Souls";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "B";
		 Cost = "4BB";
		 PT = "5/5";
		 Type = "Creature - Demon";
		 Text = "Deathtouch;^Whenever another nontoken creature dies, you may draw a card.";
		 Flavor = "";
	}
}
# endregion

# region Haunted Guardian
class HauntedGuardianAVR : MagicCard
{
	public HauntedGuardianAVR()
	{
		 Name = "Haunted Guardian";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "Art";
		 Cost = "2";
		 PT = "2/1";
		 Type = "Artifact Creature - Construct";
		 Text = "Defender, first strike";
		 Flavor = "";
	}
}
# endregion

# region Havengul Skaab
class HavengulSkaabAVR : MagicCard
{
	public HavengulSkaabAVR()
	{
		 Name = "Havengul Skaab";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "5U";
		 PT = "4/5";
		 Type = "Creature - Zombie Horror";
		 Text = "Whenever Havengul Skaab attacks, return another creature you control to its owner�s hand.";
		 Flavor = "";
	}
}
# endregion

# region Havengul Vampire
class HavengulVampireAVR : MagicCard
{
	public HavengulVampireAVR()
	{
		 Name = "Havengul Vampire";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "R";
		 Cost = "3R";
		 PT = "2/2";
		 Type = "Creature - Vampire";
		 Text = "Whenever Havengul Vampire deals combat damage to a player, put a +1/+1 counter on it.;^Whenever another creature dies, put a +1/+1 counter on Havengul Vampire.";
		 Flavor = "";
	}
}
# endregion

# region Heirs of Stromkirk
class HeirsofStromkirkAVR : MagicCard
{
	public HeirsofStromkirkAVR()
	{
		 Name = "Heirs of Stromkirk";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "2RR";
		 PT = "2/2";
		 Type = "Creature - Vampire";
		 Text = "Intimidate @(This creature can�t be blocked except by artifact creatures and/or creatures that share a color with it.)@;^Whenever Heirs of Stromkirk deals combat damage to a player, put a +1/+1 counter on it.";
		 Flavor = "";
	}
}
# endregion

# region Herald of War
class HeraldofWarAVR : MagicCard
{
	public HeraldofWarAVR()
	{
		 Name = "Herald of War";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "W";
		 Cost = "3WW";
		 PT = "3/3";
		 Type = "Creature - Angel";
		 Text = "Flying;^Whenever Herald of War attacks, put a +1/+1 counter on it. ;^Angel spells and Human spells you cast cost %1 less to cast for each +1/+1 counter on Herald of War.";
		 Flavor = "";
	}
}
# endregion

# region Holy Justiciar
class HolyJusticiarAVR : MagicCard
{
	public HolyJusticiarAVR()
	{
		 Name = "Holy Justiciar";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "W";
		 Cost = "3W";
		 PT = "2/1";
		 Type = "Creature - Human Cleric";
		 Text = "%2%W, %T: Tap target creature. If that creature is a Zombie, exile it.";
		 Flavor = "";
	}
}
# endregion

# region Homicidal Seclusion
class HomicidalSeclusionAVR : MagicCard
{
	public HomicidalSeclusionAVR()
	{
		 Name = "Homicidal Seclusion";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "B";
		 Cost = "4B";
		 PT = "";
		 Type = "Enchantment";
		 Text = "As long as you control exactly one creature, that creature gets +3/+1 and has lifelink.";
		 Flavor = "";
	}
}
# endregion

# region Hound of Griselbrand
class HoundofGriselbrandAVR : MagicCard
{
	public HoundofGriselbrandAVR()
	{
		 Name = "Hound of Griselbrand";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "R";
		 Cost = "2RR";
		 PT = "2/2";
		 Type = "Creature - Elemental Hound";
		 Text = "Double strike;^Undying @(When this creature dies, if it had no +1/+1 counters on it, return it to the battlefield under its owner�s control with a +1/+1 counter on it.)@";
		 Flavor = "";
	}
}
# endregion

# region Howlgeist
class HowlgeistAVR : MagicCard
{
	public HowlgeistAVR()
	{
		 Name = "Howlgeist";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "G";
		 Cost = "5G";
		 PT = "4/2";
		 Type = "Creature - Spirit Wolf";
		 Text = "Creatures with power less than Howlgeist�s power can�t block it.;^Undying @(When this creature dies, if it had no +1/+1 counters on it, return it to the battlefield under its owner�s control with a +1/+1 counter on it.)@";
		 Flavor = "";
	}
}
# endregion

# region Human Frailty
class HumanFrailtyAVR : MagicCard
{
	public HumanFrailtyAVR()
	{
		 Name = "Human Frailty";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "B";
		 Cost = "B";
		 PT = "";
		 Type = "Instant";
		 Text = "Destroy target Human creature.";
		 Flavor = "";
	}
}
# endregion

# region Hunted Ghoul
class HuntedGhoulAVR : MagicCard
{
	public HuntedGhoulAVR()
	{
		 Name = "Hunted Ghoul";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "B";
		 PT = "1/2";
		 Type = "Creature - Zombie";
		 Text = "Hunted Ghoul can�t block Humans.";
		 Flavor = "";
	}
}
# endregion

# region Infinite Reflection
class InfiniteReflectionAVR : MagicCard
{
	public InfiniteReflectionAVR()
	{
		 Name = "Infinite Reflection";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "U";
		 Cost = "5U";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant creature;^When Infinite Reflection enters the battlefield attached to a creature, each other nontoken creature you control becomes a copy of that creature.;^Nontoken creatures you control enter the battlefield as a copy of enchanted creature.";
		 Flavor = "";
	}
}
# endregion

# region Into the Void
class IntotheVoidAVR : MagicCard
{
	public IntotheVoidAVR()
	{
		 Name = "Into the Void";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "U";
		 Cost = "3U";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Return up to two target creatures to their owners� hands.";
		 Flavor = "";
	}
}
# endregion

# region Island 
class IslandAVR : MagicCard
{
	public IslandAVR()
	{
		 Name = "Island";
		 Edition = "AVR";
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

# region Joint Assault
class JointAssaultAVR : MagicCard
{
	public JointAssaultAVR()
	{
		 Name = "Joint Assault";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "G";
		 PT = "";
		 Type = "Instant";
		 Text = "Target creature gets +2/+2 until end of turn. If it�s paired with a creature, that creature also gets +2/+2 until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Kessig Malcontents
class KessigMalcontentsAVR : MagicCard
{
	public KessigMalcontentsAVR()
	{
		 Name = "Kessig Malcontents";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "R";
		 Cost = "2R";
		 PT = "3/1";
		 Type = "Creature - Human Warrior";
		 Text = "When Kessig Malcontents enters the battlefield, it deals damage to target player equal to the number of Humans you control.";
		 Flavor = "";
	}
}
# endregion

# region Killing Wave
class KillingWaveAVR : MagicCard
{
	public KillingWaveAVR()
	{
		 Name = "Killing Wave";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "B";
		 Cost = "XB";
		 PT = "";
		 Type = "Sorcery";
		 Text = "For each creature, its controller sacrifices it unless he or she pays X life.";
		 Flavor = "";
	}
}
# endregion

# region Kruin Striker
class KruinStrikerAVR : MagicCard
{
	public KruinStrikerAVR()
	{
		 Name = "Kruin Striker";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "1R";
		 PT = "2/1";
		 Type = "Creature - Human Warrior";
		 Text = "Whenever another creature enters the battlefield under your control, Kruin Striker gets +1/+0 and gains trample until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Lair Delve
class LairDelveAVR : MagicCard
{
	public LairDelveAVR()
	{
		 Name = "Lair Delve";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "2G";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Reveal the top two cards of your library. Put all creature and land cards revealed this way into your hand and the rest on the bottom of your library in any order.";
		 Flavor = "";
	}
}
# endregion

# region Latch Seeker
class LatchSeekerAVR : MagicCard
{
	public LatchSeekerAVR()
	{
		 Name = "Latch Seeker";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "U";
		 Cost = "1UU";
		 PT = "3/1";
		 Type = "Creature - Spirit";
		 Text = "Latch Seeker can�t be blocked.";
		 Flavor = "";
	}
}
# endregion

# region Leap of Faith
class LeapofFaithAVR : MagicCard
{
	public LeapofFaithAVR()
	{
		 Name = "Leap of Faith";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "2W";
		 PT = "";
		 Type = "Instant";
		 Text = "Target creature gains flying until end of turn. Prevent all damage that would be dealt to that creature this turn.";
		 Flavor = "";
	}
}
# endregion

# region Lightning Mauler
class LightningMaulerAVR : MagicCard
{
	public LightningMaulerAVR()
	{
		 Name = "Lightning Mauler";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "R";
		 Cost = "1R";
		 PT = "2/1";
		 Type = "Creature - Human Berserker";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Lightning Mauler is paired with another creature, both creatures have haste.";
		 Flavor = "";
	}
}
# endregion

# region Lightning Prowess
class LightningProwessAVR : MagicCard
{
	public LightningProwessAVR()
	{
		 Name = "Lightning Prowess";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "R";
		 Cost = "2R";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant creature;^Enchanted creature has haste and �%T: This creature deals 1 damage to target creature or player.�";
		 Flavor = "";
	}
}
# endregion

# region Lone Revenant
class LoneRevenantAVR : MagicCard
{
	public LoneRevenantAVR()
	{
		 Name = "Lone Revenant";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "U";
		 Cost = "3UU";
		 PT = "4/4";
		 Type = "Creature - Spirit";
		 Text = "Hexproof @(This creature can�t be the target of spells or abilities your opponents control.)@;^Whenever Lone Revenant deals combat damage to a player, if you control no other creatures, look at the top four cards of your library. Put one of them into your hand and the rest on the bottom of your library in any order.";
		 Flavor = "";
	}
}
# endregion

# region Lunar Mystic
class LunarMysticAVR : MagicCard
{
	public LunarMysticAVR()
	{
		 Name = "Lunar Mystic";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "U";
		 Cost = "2UU";
		 PT = "2/2";
		 Type = "Creature - Human Wizard";
		 Text = "Whenever you cast an instant spell, you may pay %1. If you do, draw a card.";
		 Flavor = "";
	}
}
# endregion

# region Maalfeld Twins
class MaalfeldTwinsAVR : MagicCard
{
	public MaalfeldTwinsAVR()
	{
		 Name = "Maalfeld Twins";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "B";
		 Cost = "5B";
		 PT = "4/4";
		 Type = "Creature - Zombie";
		 Text = "When Maalfeld Twins dies, put two 2/2 black Zombie creature tokens onto the battlefield.";
		 Flavor = "";
	}
}
# endregion

# region Mad Prophet
class MadProphetAVR : MagicCard
{
	public MadProphetAVR()
	{
		 Name = "Mad Prophet";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "3R";
		 PT = "2/2";
		 Type = "Creature - Human Shaman";
		 Text = "Haste;^%T, Discard a card: Draw a card.";
		 Flavor = "";
	}
}
# endregion

# region Malicious Intent
class MaliciousIntentAVR : MagicCard
{
	public MaliciousIntentAVR()
	{
		 Name = "Malicious Intent";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "1R";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant creature;^Enchanted creature has �%T: Target creature can�t block this turn.�";
		 Flavor = "";
	}
}
# endregion

# region Malignus
class MalignusAVR : MagicCard
{
	public MalignusAVR()
	{
		 Name = "Malignus";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "R";
		 Cost = "3RR";
		 PT = "*/*";
		 Type = "Creature - Elemental Spirit";
		 Text = "Malignus�s power and toughness are each equal to half the highest life total among your opponents, rounded up.;^Damage that would be dealt by Malignus can�t be prevented.";
		 Flavor = "";
	}
}
# endregion

# region Marrow Bats
class MarrowBatsAVR : MagicCard
{
	public MarrowBatsAVR()
	{
		 Name = "Marrow Bats";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "B";
		 Cost = "4B";
		 PT = "4/1";
		 Type = "Creature - Bat Skeleton";
		 Text = "Flying;^Pay 4 life: Regenerate Marrow Bats.";
		 Flavor = "";
	}
}
# endregion

# region Mass Appeal
class MassAppealAVR : MagicCard
{
	public MassAppealAVR()
	{
		 Name = "Mass Appeal";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "U";
		 Cost = "2U";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Draw a card for each Human you control.";
		 Flavor = "";
	}
}
# endregion

# region Mental Agony
class MentalAgonyAVR : MagicCard
{
	public MentalAgonyAVR()
	{
		 Name = "Mental Agony";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "3B";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Target player discards two cards and loses 2 life.";
		 Flavor = "";
	}
}
# endregion

# region Midnight Duelist
class MidnightDuelistAVR : MagicCard
{
	public MidnightDuelistAVR()
	{
		 Name = "Midnight Duelist";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "W";
		 PT = "1/2";
		 Type = "Creature - Human Soldier";
		 Text = "Protection from Vampires";
		 Flavor = "";
	}
}
# endregion

# region Midvast Protector
class MidvastProtectorAVR : MagicCard
{
	public MidvastProtectorAVR()
	{
		 Name = "Midvast Protector";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "3W";
		 PT = "2/3";
		 Type = "Creature - Human Wizard";
		 Text = "When Midvast Protector enters the battlefield, target creature you control gains protection from the color of your choice until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Mist Raven
class MistRavenAVR : MagicCard
{
	public MistRavenAVR()
	{
		 Name = "Mist Raven";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "2UU";
		 PT = "2/2";
		 Type = "Creature - Bird";
		 Text = "Flying;^When Mist Raven enters the battlefield, return target creature to its owner�s hand.";
		 Flavor = "";
	}
}
# endregion

# region Misthollow Griffin
class MisthollowGriffinAVR : MagicCard
{
	public MisthollowGriffinAVR()
	{
		 Name = "Misthollow Griffin";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "U";
		 Cost = "2UU";
		 PT = "3/3";
		 Type = "Creature - Griffin";
		 Text = "Flying;^You may cast Misthollow Griffin from exile.";
		 Flavor = "";
	}
}
# endregion

# region Moonlight Geist
class MoonlightGeistAVR : MagicCard
{
	public MoonlightGeistAVR()
	{
		 Name = "Moonlight Geist";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "2W";
		 PT = "2/1";
		 Type = "Creature - Spirit";
		 Text = "Flying;^%3%W: Prevent all combat damage that would be dealt to and dealt by Moonlight Geist this turn.";
		 Flavor = "";
	}
}
# endregion

# region Moonsilver Spear
class MoonsilverSpearAVR : MagicCard
{
	public MoonsilverSpearAVR()
	{
		 Name = "Moonsilver Spear";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "Art";
		 Cost = "4";
		 PT = "";
		 Type = "Artifact - Equipment";
		 Text = "Equipped creature has first strike.;^Whenever equipped creature attacks, put a 4/4 white Angel creature token with flying onto the battlefield.;^Equip %4";
		 Flavor = "";
	}
}
# endregion

# region Moorland Inquisitor
class MoorlandInquisitorAVR : MagicCard
{
	public MoorlandInquisitorAVR()
	{
		 Name = "Moorland Inquisitor";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "1W";
		 PT = "2/2";
		 Type = "Creature - Human Soldier";
		 Text = "%2%W: Moorland Inquisitor gains first strike until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Mountain 
class MountainAVR : MagicCard
{
	public MountainAVR()
	{
		 Name = "Mountain";
		 Edition = "AVR";
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

# region Narstad Scrapper
class NarstadScrapperAVR : MagicCard
{
	public NarstadScrapperAVR()
	{
		 Name = "Narstad Scrapper";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "Art";
		 Cost = "5";
		 PT = "3/3";
		 Type = "Artifact Creature - Construct";
		 Text = "%2: Narstad Scrapper gets +1/+0 until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Natural End
class NaturalEndAVR : MagicCard
{
	public NaturalEndAVR()
	{
		 Name = "Natural End";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "2G";
		 PT = "";
		 Type = "Instant";
		 Text = "Destroy target artifact or enchantment. You gain 3 life.";
		 Flavor = "";
	}
}
# endregion

# region Nearheath Pilgrim
class NearheathPilgrimAVR : MagicCard
{
	public NearheathPilgrimAVR()
	{
		 Name = "Nearheath Pilgrim";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "W";
		 Cost = "1W";
		 PT = "2/1";
		 Type = "Creature - Human Cleric";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Nearheath Pilgrim is paired with another creature, both creatures have lifelink.";
		 Flavor = "";
	}
}
# endregion

# region Necrobite
class NecrobiteAVR : MagicCard
{
	public NecrobiteAVR()
	{
		 Name = "Necrobite";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "2B";
		 PT = "";
		 Type = "Instant";
		 Text = "Target creature gains deathtouch until end of turn. Regenerate it.";
		 Flavor = "";
	}
}
# endregion

# region Nephalia Smuggler
class NephaliaSmugglerAVR : MagicCard
{
	public NephaliaSmugglerAVR()
	{
		 Name = "Nephalia Smuggler";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "U";
		 Cost = "U";
		 PT = "1/1";
		 Type = "Creature - Human Rogue";
		 Text = "%3%U, %T: Exile another target creature you control, then return that card to the battlefield under your control.";
		 Flavor = "";
	}
}
# endregion

# region Nettle Swine
class NettleSwineAVR : MagicCard
{
	public NettleSwineAVR()
	{
		 Name = "Nettle Swine";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "3G";
		 PT = "4/3";
		 Type = "Creature - Boar";
		 Text = "";
		 Flavor = "�I killed one and found bricks and bones in its belly. It had eaten a whole cottage, thatch and all.�;^�Paulin, Somberwald trapper";
	}
}
# endregion

# region Nightshade Peddler
class NightshadePeddlerAVR : MagicCard
{
	public NightshadePeddlerAVR()
	{
		 Name = "Nightshade Peddler";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "1G";
		 PT = "1/1";
		 Type = "Creature - Human Druid";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Nightshade Peddler is paired with another creature, both creatures have deathtouch.";
		 Flavor = "";
	}
}
# endregion

# region Otherworld Atlas
class OtherworldAtlasAVR : MagicCard
{
	public OtherworldAtlasAVR()
	{
		 Name = "Otherworld Atlas";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "Art";
		 Cost = "4";
		 PT = "";
		 Type = "Artifact";
		 Text = "%T: Put a charge counter on Otherworld Atlas.;^%T: Each player draws a card for each charge counter on Otherworld Atlas.";
		 Flavor = "";
	}
}
# endregion

# region Outwit
class OutwitAVR : MagicCard
{
	public OutwitAVR()
	{
		 Name = "Outwit";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "U";
		 PT = "";
		 Type = "Instant";
		 Text = "Counter target spell that targets a player.";
		 Flavor = "";
	}
}
# endregion

# region Pathbreaker Wurm
class PathbreakerWurmAVR : MagicCard
{
	public PathbreakerWurmAVR()
	{
		 Name = "Pathbreaker Wurm";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "4GG";
		 PT = "6/4";
		 Type = "Creature - Wurm";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Pathbreaker Wurm is paired with another creature, both creatures have trample.";
		 Flavor = "";
	}
}
# endregion

# region Peel from Reality
class PeelfromRealityAVR : MagicCard
{
	public PeelfromRealityAVR()
	{
		 Name = "Peel from Reality";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "1U";
		 PT = "";
		 Type = "Instant";
		 Text = "Return target creature you control and target creature you don�t control to their owners� hands.";
		 Flavor = "";
	}
}
# endregion

# region Pillar of Flame
class PillarofFlameAVR : MagicCard
{
	public PillarofFlameAVR()
	{
		 Name = "Pillar of Flame";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "R";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Pillar of Flame deals 2 damage to target creature or player. If a creature dealt damage this way would die this turn, exile it instead.";
		 Flavor = "";
	}
}
# endregion

# region Plains 
class PlainsAVR : MagicCard
{
	public PlainsAVR()
	{
		 Name = "Plains";
		 Edition = "AVR";
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

# region Polluted Dead
class PollutedDeadAVR : MagicCard
{
	public PollutedDeadAVR()
	{
		 Name = "Polluted Dead";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "4B";
		 PT = "3/3";
		 Type = "Creature - Zombie";
		 Text = "When Polluted Dead dies, destroy target land.";
		 Flavor = "";
	}
}
# endregion

# region Predator's Gambit
class PredatorsGambitAVR : MagicCard
{
	public PredatorsGambitAVR()
	{
		 Name = "Predator's Gambit";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "B";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant creature;^Enchanted creature gets +2/+1.;^Enchanted creature has intimidate as long as its controller controls no other creatures. @(It can�t be blocked except by artifact creatures and/or creatures that share a color with it.)@";
		 Flavor = "";
	}
}
# endregion

# region Primal Surge
class PrimalSurgeAVR : MagicCard
{
	public PrimalSurgeAVR()
	{
		 Name = "Primal Surge";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "G";
		 Cost = "8GG";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Exile the top card of your library. If it�s a permanent card, you may put it onto the battlefield. If you do, repeat this process.";
		 Flavor = "";
	}
}
# endregion

# region Raging Poltergeist
class RagingPoltergeistAVR : MagicCard
{
	public RagingPoltergeistAVR()
	{
		 Name = "Raging Poltergeist";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "4R";
		 PT = "6/1";
		 Type = "Creature - Spirit";
		 Text = "";
		 Flavor = "Some tried cremating their dead to stop the ghoulcallers. But the dead returned, furious about their fate.";
	}
}
# endregion

# region Rain of Thorns
class RainofThornsAVR : MagicCard
{
	public RainofThornsAVR()
	{
		 Name = "Rain of Thorns";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "G";
		 Cost = "4GG";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Choose one or more � Destroy target artifact; destroy target enchantment; and/or destroy target land.";
		 Flavor = "";
	}
}
# endregion

# region Reforge the Soul
class ReforgetheSoulAVR : MagicCard
{
	public ReforgetheSoulAVR()
	{
		 Name = "Reforge the Soul";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "R";
		 Cost = "3RR";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Each player discards his or her hand and draws seven cards.;^Miracle %1%R @(You may cast this card for its miracle cost when you draw it if it�s the first card you drew this turn.)@";
		 Flavor = "";
	}
}
# endregion

# region Renegade Demon
class RenegadeDemonAVR : MagicCard
{
	public RenegadeDemonAVR()
	{
		 Name = "Renegade Demon";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "3BB";
		 PT = "5/3";
		 Type = "Creature - Demon";
		 Text = "";
		 Flavor = "�Have you ever cornered a wounded vampire? That�s a walk in the cathedral garden in comparison.�;^�Tristen, Cathar Marshal";
	}
}
# endregion

# region Restoration Angel
class RestorationAngelAVR : MagicCard
{
	public RestorationAngelAVR()
	{
		 Name = "Restoration Angel";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "W";
		 Cost = "3W";
		 PT = "3/4";
		 Type = "Creature - Angel";
		 Text = "Flash;^Flying;^When Restoration Angel enters the battlefield, you may exile target non-Angel creature you control, then return that card to the battlefield under your control.";
		 Flavor = "";
	}
}
# endregion

# region Revenge of the Hunted
class RevengeoftheHuntedAVR : MagicCard
{
	public RevengeoftheHuntedAVR()
	{
		 Name = "Revenge of the Hunted";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "G";
		 Cost = "4GG";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Until end of turn, target creature gets +6/+6 and gains trample, and all creatures able to block it this turn do so.;^Miracle %G @(You may cast this card for its miracle cost when you draw it if it�s the first card you drew this turn.)@";
		 Flavor = "";
	}
}
# endregion

# region Riders of Gavony
class RidersofGavonyAVR : MagicCard
{
	public RidersofGavonyAVR()
	{
		 Name = "Riders of Gavony";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "W";
		 Cost = "2WW";
		 PT = "3/3";
		 Type = "Creature - Human Knight";
		 Text = "Vigilance;^As Riders of Gavony enters the battlefield, choose a creature type.;^Human creatures you control have protection from creatures of the chosen type.";
		 Flavor = "";
	}
}
# endregion

# region Righteous Blow
class RighteousBlowAVR : MagicCard
{
	public RighteousBlowAVR()
	{
		 Name = "Righteous Blow";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "W";
		 PT = "";
		 Type = "Instant";
		 Text = "Righteous Blow deals 2 damage to target attacking or blocking creature.";
		 Flavor = "";
	}
}
# endregion

# region Riot Ringleader
class RiotRingleaderAVR : MagicCard
{
	public RiotRingleaderAVR()
	{
		 Name = "Riot Ringleader";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "2R";
		 PT = "2/2";
		 Type = "Creature - Human Warrior";
		 Text = "Whenever Riot Ringleader attacks, Human creatures you control get +1/+0 until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Rite of Ruin
class RiteofRuinAVR : MagicCard
{
	public RiteofRuinAVR()
	{
		 Name = "Rite of Ruin";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "R";
		 Cost = "5RR";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Choose an order for artifacts, creatures, and lands. Each player sacrifices one permanent of the first type, sacrifices two of the second type, then sacrifices three of the third type.";
		 Flavor = "";
	}
}
# endregion

# region Rotcrown Ghoul
class RotcrownGhoulAVR : MagicCard
{
	public RotcrownGhoulAVR()
	{
		 Name = "Rotcrown Ghoul";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "4U";
		 PT = "3/3";
		 Type = "Creature - Zombie";
		 Text = "When Rotcrown Ghoul dies, target player puts the top five cards of his or her library into his or her graveyard.";
		 Flavor = "";
	}
}
# endregion

# region Rush of Blood
class RushofBloodAVR : MagicCard
{
	public RushofBloodAVR()
	{
		 Name = "Rush of Blood";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "R";
		 Cost = "2R";
		 PT = "";
		 Type = "Instant";
		 Text = "Target creature gets +X/+0 until end of turn, where X is its power.";
		 Flavor = "";
	}
}
# endregion

# region Scalding Devil
class ScaldingDevilAVR : MagicCard
{
	public ScaldingDevilAVR()
	{
		 Name = "Scalding Devil";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "1R";
		 PT = "1/1";
		 Type = "Creature - Devil";
		 Text = "%2%R: Scalding Devil deals 1 damage to target player.";
		 Flavor = "";
	}
}
# endregion

# region Scrapskin Drake
class ScrapskinDrakeAVR : MagicCard
{
	public ScrapskinDrakeAVR()
	{
		 Name = "Scrapskin Drake";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "2U";
		 PT = "2/3";
		 Type = "Creature - Zombie Drake";
		 Text = "Flying;^Scrapskin Drake can block only creatures with flying.";
		 Flavor = "";
	}
}
# endregion

# region Scroll of Avacyn
class ScrollofAvacynAVR : MagicCard
{
	public ScrollofAvacynAVR()
	{
		 Name = "Scroll of Avacyn";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "Art";
		 Cost = "1";
		 PT = "";
		 Type = "Artifact";
		 Text = "%1, Sacrifice Scroll of Avacyn: Draw a card. If you control an Angel, you gain 5 life.";
		 Flavor = "";
	}
}
# endregion

# region Scroll of Griselbrand
class ScrollofGriselbrandAVR : MagicCard
{
	public ScrollofGriselbrandAVR()
	{
		 Name = "Scroll of Griselbrand";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "Art";
		 Cost = "1";
		 PT = "";
		 Type = "Artifact";
		 Text = "%1, Sacrifice Scroll of Griselbrand: Target opponent discards a card. If you control a Demon, that player loses 3 life.";
		 Flavor = "";
	}
}
# endregion

# region Searchlight Geist
class SearchlightGeistAVR : MagicCard
{
	public SearchlightGeistAVR()
	{
		 Name = "Searchlight Geist";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "2B";
		 PT = "2/1";
		 Type = "Creature - Spirit";
		 Text = "Flying;^%3%B: Searchlight Geist gains deathtouch until end of turn. @(Any amount of damage it deals to a creature is enough to destroy it.)@";
		 Flavor = "";
	}
}
# endregion

# region Second Guess
class SecondGuessAVR : MagicCard
{
	public SecondGuessAVR()
	{
		 Name = "Second Guess";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "U";
		 Cost = "1U";
		 PT = "";
		 Type = "Instant";
		 Text = "Counter target spell that�s the second spell cast this turn.";
		 Flavor = "";
	}
}
# endregion

# region Seraph of Dawn
class SeraphofDawnAVR : MagicCard
{
	public SeraphofDawnAVR()
	{
		 Name = "Seraph of Dawn";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "2WW";
		 PT = "2/4";
		 Type = "Creature - Angel";
		 Text = "Flying;^Lifelink @(Damage dealt by this creature also causes you to gain that much life.)@";
		 Flavor = "";
	}
}
# endregion

# region Seraph Sanctuary
class SeraphSanctuaryAVR : MagicCard
{
	public SeraphSanctuaryAVR()
	{
		 Name = "Seraph Sanctuary";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "Lnd";
		 Cost = "";
		 PT = "";
		 Type = "Land";
		 Text = "When Seraph Sanctuary enters the battlefield, you gain 1 life.;^Whenever an Angel enters the battlefield under your control, you gain 1 life.;^%T: Add %1 to your mana pool.";
		 Flavor = "";
	}
}
# endregion

# region Sheltering Word
class ShelteringWordAVR : MagicCard
{
	public ShelteringWordAVR()
	{
		 Name = "Sheltering Word";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "1G";
		 PT = "";
		 Type = "Instant";
		 Text = "Target creature you control gains hexproof until end of turn. You gain life equal to that creature�s toughness. @(A creature with hexproof can�t be the target of spells or abilities opponents control.)@";
		 Flavor = "";
	}
}
# endregion

# region Sigarda, Host of Herons
class SigardaHostofHeronsAVR : MagicCard
{
	public SigardaHostofHeronsAVR()
	{
		 Name = "Sigarda, Host of Herons";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "Gld";
		 Cost = "2GWW";
		 PT = "5/5";
		 Type = "Legendary Creature - Angel";
		 Text = "Flying, hexproof;^Spells and abilities your opponents control can�t cause you to sacrifice permanents.";
		 Flavor = "";
	}
}
# endregion

# region Silverblade Paladin
class SilverbladePaladinAVR : MagicCard
{
	public SilverbladePaladinAVR()
	{
		 Name = "Silverblade Paladin";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "W";
		 Cost = "1WW";
		 PT = "2/2";
		 Type = "Creature - Human Knight";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Silverblade Paladin is paired with another creature, both creatures have double strike.";
		 Flavor = "";
	}
}
# endregion

# region Slayers' Stronghold
class SlayersStrongholdAVR : MagicCard
{
	public SlayersStrongholdAVR()
	{
		 Name = "Slayers' Stronghold";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "Lnd";
		 Cost = "";
		 PT = "";
		 Type = "Land";
		 Text = "%T: Add %1 to your mana pool.;^%R%W, %T: Target creature gets +2/+0 and gains vigilance and haste until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Snare the Skies
class SnaretheSkiesAVR : MagicCard
{
	public SnaretheSkiesAVR()
	{
		 Name = "Snare the Skies";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "G";
		 PT = "";
		 Type = "Instant";
		 Text = "Target creature gets +1/+1 and gains reach until end of turn. @(It can block creatures with flying.)@";
		 Flavor = "";
	}
}
# endregion

# region Somberwald Sage
class SomberwaldSageAVR : MagicCard
{
	public SomberwaldSageAVR()
	{
		 Name = "Somberwald Sage";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "G";
		 Cost = "2G";
		 PT = "0/1";
		 Type = "Creature - Human Druid";
		 Text = "%T: Add three mana of any one color to your mana pool. Spend this mana only to cast creature spells.";
		 Flavor = "";
	}
}
# endregion

# region Somberwald Vigilante
class SomberwaldVigilanteAVR : MagicCard
{
	public SomberwaldVigilanteAVR()
	{
		 Name = "Somberwald Vigilante";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "R";
		 PT = "1/1";
		 Type = "Creature - Human Warrior";
		 Text = "Whenever Somberwald Vigilante becomes blocked by a creature, Somberwald Vigilante deals 1 damage to that creature.";
		 Flavor = "";
	}
}
# endregion

# region Soul of the Harvest
class SouloftheHarvestAVR : MagicCard
{
	public SouloftheHarvestAVR()
	{
		 Name = "Soul of the Harvest";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "G";
		 Cost = "4GG";
		 PT = "6/6";
		 Type = "Creature - Elemental";
		 Text = "Trample;^Whenever another nontoken creature enters the battlefield under your control, you may draw a card.";
		 Flavor = "";
	}
}
# endregion

# region Soulcage Fiend
class SoulcageFiendAVR : MagicCard
{
	public SoulcageFiendAVR()
	{
		 Name = "Soulcage Fiend";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "1BB";
		 PT = "3/2";
		 Type = "Creature - Demon";
		 Text = "When Soulcage Fiend dies, each player loses 3 life.";
		 Flavor = "";
	}
}
# endregion

# region Spectral Gateguards
class SpectralGateguardsAVR : MagicCard
{
	public SpectralGateguardsAVR()
	{
		 Name = "Spectral Gateguards";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "4W";
		 PT = "2/5";
		 Type = "Creature - Spirit Soldier";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Spectral Gateguards is paired with another creature, both creatures have vigilance.";
		 Flavor = "";
	}
}
# endregion

# region Spectral Prison
class SpectralPrisonAVR : MagicCard
{
	public SpectralPrisonAVR()
	{
		 Name = "Spectral Prison";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "1U";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant creature;^Enchanted creature doesn�t untap during its controller�s untap step.;^When enchanted creature becomes the target of a spell, sacrifice Spectral Prison.";
		 Flavor = "";
	}
}
# endregion

# region Spirit Away
class SpiritAwayAVR : MagicCard
{
	public SpiritAwayAVR()
	{
		 Name = "Spirit Away";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "U";
		 Cost = "5UU";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant creature;^You control enchanted creature.;^Enchanted creature gets +2/+2 and has flying.";
		 Flavor = "";
	}
}
# endregion

# region Stern Mentor
class SternMentorAVR : MagicCard
{
	public SternMentorAVR()
	{
		 Name = "Stern Mentor";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "U";
		 Cost = "3U";
		 PT = "2/2";
		 Type = "Creature - Human Wizard";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Stern Mentor is paired with another creature, each of those creatures has �%T: Target player puts the top two cards of his or her library into his or her graveyard.�";
		 Flavor = "";
	}
}
# endregion

# region Stolen Goods
class StolenGoodsAVR : MagicCard
{
	public StolenGoodsAVR()
	{
		 Name = "Stolen Goods";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "U";
		 Cost = "3U";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Target opponent exiles cards from the top of his or her library until he or she exiles a nonland card. Until end of turn, you may cast that card without paying its mana cost.";
		 Flavor = "";
	}
}
# endregion

# region Stonewright
class StonewrightAVR : MagicCard
{
	public StonewrightAVR()
	{
		 Name = "Stonewright";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "R";
		 Cost = "R";
		 PT = "1/1";
		 Type = "Creature - Human Shaman";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Stonewright is paired with another creature, each of those creatures has �%R: This creature gets +1/+0 until end of turn.�";
		 Flavor = "";
	}
}
# endregion

# region Swamp 
class SwampAVR : MagicCard
{
	public SwampAVR()
	{
		 Name = "Swamp";
		 Edition = "AVR";
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

# region Tamiyo, the Moon Sage
class TamiyotheMoonSageAVR : MagicCard
{
	public TamiyotheMoonSageAVR()
	{
		 Name = "Tamiyo, the Moon Sage";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "U";
		 Cost = "3UU";
		 PT = "%4/";
		 Type = "Planeswalker - Tamiyo";
		 Text = "+1: Tap target permanent. It doesn�t untap during its controller�s next untap step.;^-2: Draw a card for each tapped creature target player controls.;^-8: You get an emblem with �You have no maximum hand size� and �Whenever a card is put into your graveyard from anywhere, you may return it to your hand.�";
		 Flavor = "";
	}
}
# endregion

# region Tandem Lookout
class TandemLookoutAVR : MagicCard
{
	public TandemLookoutAVR()
	{
		 Name = "Tandem Lookout";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "U";
		 Cost = "2U";
		 PT = "2/1";
		 Type = "Creature - Human Scout";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Tandem Lookout is paired with another creature, each of those creatures has �Whenever this creature deals damage to an opponent, draw a card.�";
		 Flavor = "";
	}
}
# endregion

# region Temporal Mastery
class TemporalMasteryAVR : MagicCard
{
	public TemporalMasteryAVR()
	{
		 Name = "Temporal Mastery";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "U";
		 Cost = "5UU";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Take an extra turn after this one. Exile Temporal Mastery.;^Miracle %1%U @(You may cast this card for its miracle cost when you draw it if it�s the first card you drew this turn.)@";
		 Flavor = "";
	}
}
# endregion

# region Terminus
class TerminusAVR : MagicCard
{
	public TerminusAVR()
	{
		 Name = "Terminus";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "W";
		 Cost = "4WW";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Put all creatures on the bottom of their owners� libraries.;^Miracle %W @(You may cast this card for its miracle cost when you draw it if it�s the first card you drew this turn.)@";
		 Flavor = "";
	}
}
# endregion

# region Terrifying Presence
class TerrifyingPresenceAVR : MagicCard
{
	public TerrifyingPresenceAVR()
	{
		 Name = "Terrifying Presence";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "1G";
		 PT = "";
		 Type = "Instant";
		 Text = "Prevent all combat damage that would be dealt by creatures other than target creature this turn.";
		 Flavor = "";
	}
}
# endregion

# region Thatcher Revolt
class ThatcherRevoltAVR : MagicCard
{
	public ThatcherRevoltAVR()
	{
		 Name = "Thatcher Revolt";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "2R";
		 PT = "";
		 Type = "Sorcery";
		 Text = "Put three 1/1 red Human creature tokens with haste onto the battlefield. Sacrifice those tokens at the beginning of the next end step.";
		 Flavor = "";
	}
}
# endregion

# region Thraben Valiant
class ThrabenValiantAVR : MagicCard
{
	public ThrabenValiantAVR()
	{
		 Name = "Thraben Valiant";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "1W";
		 PT = "2/1";
		 Type = "Creature - Human Soldier";
		 Text = "Vigilance";
		 Flavor = "";
	}
}
# endregion

# region Thunderbolt
class ThunderboltAVR : MagicCard
{
	public ThunderboltAVR()
	{
		 Name = "Thunderbolt";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "1R";
		 PT = "";
		 Type = "Instant";
		 Text = "Choose one � Thunderbolt deals 3 damage to target player; or Thunderbolt deals 4 damage to target creature with flying.";
		 Flavor = "";
	}
}
# endregion

# region Thunderous Wrath
class ThunderousWrathAVR : MagicCard
{
	public ThunderousWrathAVR()
	{
		 Name = "Thunderous Wrath";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "R";
		 Cost = "4RR";
		 PT = "";
		 Type = "Instant";
		 Text = "Thunderous Wrath deals 5 damage to target creature or player.;^Miracle %R @(You may cast this card for its miracle cost when you draw it if it�s the first card you drew this turn.)@";
		 Flavor = "";
	}
}
# endregion

# region Tibalt, the Fiend-Blooded
class TibalttheFiendBloodedAVR : MagicCard
{
	public TibalttheFiendBloodedAVR()
	{
		 Name = "Tibalt, the Fiend-Blooded";
		 Edition = "AVR";
		 Rarity = "M";
		 Color = "R";
		 Cost = "RR";
		 PT = "%2/";
		 Type = "Planeswalker - Tibalt";
		 Text = "+1: Draw a card, then discard a card at random.;^-4: Tibalt, the Fiend-Blooded deals damage equal to the number of cards in target player�s hand to that player.;^-6: Gain control of all creatures until end of turn. Untap them. They gain haste until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Timberland Guide
class TimberlandGuideAVR : MagicCard
{
	public TimberlandGuideAVR()
	{
		 Name = "Timberland Guide";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "1G";
		 PT = "1/1";
		 Type = "Creature - Human Scout";
		 Text = "When Timberland Guide enters the battlefield, put a +1/+1 counter on target creature.";
		 Flavor = "";
	}
}
# endregion

# region Tormentor's Trident
class TormentorsTridentAVR : MagicCard
{
	public TormentorsTridentAVR()
	{
		 Name = "Tormentor's Trident";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "Art";
		 Cost = "2";
		 PT = "";
		 Type = "Artifact - Equipment";
		 Text = "Equipped creature gets +3/+0 and attacks each turn if able.;^Equip %3";
		 Flavor = "";
	}
}
# endregion

# region Treacherous Pit-Dweller
class TreacherousPitDwellerAVR : MagicCard
{
	public TreacherousPitDwellerAVR()
	{
		 Name = "Treacherous Pit-Dweller";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "B";
		 Cost = "BB";
		 PT = "4/3";
		 Type = "Creature - Demon";
		 Text = "When Treacherous Pit-Dweller enters the battlefield from a graveyard, target opponent gains control of it.;^Undying @(When this creature dies, if it had no +1/+1 counters on it, return it to the battlefield under its owner�s control with a +1/+1 counter on it.)@";
		 Flavor = "";
	}
}
# endregion

# region Triumph of Cruelty
class TriumphofCrueltyAVR : MagicCard
{
	public TriumphofCrueltyAVR()
	{
		 Name = "Triumph of Cruelty";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "B";
		 Cost = "2B";
		 PT = "";
		 Type = "Enchantment";
		 Text = "At the beginning of your upkeep, target opponent discards a card if you control the creature with the greatest power or tied for the greatest power.";
		 Flavor = "";
	}
}
# endregion

# region Triumph of Ferocity
class TriumphofFerocityAVR : MagicCard
{
	public TriumphofFerocityAVR()
	{
		 Name = "Triumph of Ferocity";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "G";
		 Cost = "2G";
		 PT = "";
		 Type = "Enchantment";
		 Text = "At the beginning of your upkeep, draw a card if you control the creature with the greatest power or tied for the greatest power.";
		 Flavor = "";
	}
}
# endregion

# region Trusted Forcemage
class TrustedForcemageAVR : MagicCard
{
	public TrustedForcemageAVR()
	{
		 Name = "Trusted Forcemage";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "2G";
		 PT = "2/2";
		 Type = "Creature - Human Shaman";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Trusted Forcemage is paired with another creature, each of those creatures gets +1/+1.";
		 Flavor = "";
	}
}
# endregion

# region Tyrant of Discord
class TyrantofDiscordAVR : MagicCard
{
	public TyrantofDiscordAVR()
	{
		 Name = "Tyrant of Discord";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "R";
		 Cost = "4RRR";
		 PT = "7/7";
		 Type = "Creature - Elemental";
		 Text = "When Tyrant of Discord enters the battlefield, target opponent chooses a permanent he or she controls at random and sacrifices it. If a nonland permanent is sacrificed this way, repeat this process.";
		 Flavor = "";
	}
}
# endregion

# region Ulvenwald Tracker
class UlvenwaldTrackerAVR : MagicCard
{
	public UlvenwaldTrackerAVR()
	{
		 Name = "Ulvenwald Tracker";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "G";
		 Cost = "G";
		 PT = "1/1";
		 Type = "Creature - Human Shaman";
		 Text = "%1%G, %T: Target creature you control fights another target creature. @(Each deals damage equal to its power to the other.)@";
		 Flavor = "";
	}
}
# endregion

# region Uncanny Speed
class UncannySpeedAVR : MagicCard
{
	public UncannySpeedAVR()
	{
		 Name = "Uncanny Speed";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "R";
		 Cost = "1R";
		 PT = "";
		 Type = "Instant";
		 Text = "Target creature gets +3/+0 and gains haste until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Undead Executioner
class UndeadExecutionerAVR : MagicCard
{
	public UndeadExecutionerAVR()
	{
		 Name = "Undead Executioner";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "3B";
		 PT = "2/2";
		 Type = "Creature - Zombie";
		 Text = "When Undead Executioner dies, you may have target creature get -2/-2 until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Unhallowed Pact
class UnhallowedPactAVR : MagicCard
{
	public UnhallowedPactAVR()
	{
		 Name = "Unhallowed Pact";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "B";
		 Cost = "2B";
		 PT = "";
		 Type = "Enchantment - Aura";
		 Text = "Enchant creature;^When enchanted creature dies, return that card to the battlefield under your control.";
		 Flavor = "";
	}
}
# endregion

# region Vanguard's Shield
class VanguardsShieldAVR : MagicCard
{
	public VanguardsShieldAVR()
	{
		 Name = "Vanguard's Shield";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "Art";
		 Cost = "2";
		 PT = "";
		 Type = "Artifact - Equipment";
		 Text = "Equipped creature gets +0/+3 and can block an additional creature.;^Equip %3 @(%3: Attach to target creature you control. Equip only as a sorcery.)@";
		 Flavor = "";
	}
}
# endregion

# region Vanishment
class VanishmentAVR : MagicCard
{
	public VanishmentAVR()
	{
		 Name = "Vanishment";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "U";
		 Cost = "4U";
		 PT = "";
		 Type = "Instant";
		 Text = "Put target nonland permanent on top of its owner�s library.;^Miracle %U @(You may cast this card for its miracle cost when you draw it if it�s the first card you drew this turn.)@";
		 Flavor = "";
	}
}
# endregion

# region Vessel of Endless Rest
class VesselofEndlessRestAVR : MagicCard
{
	public VesselofEndlessRestAVR()
	{
		 Name = "Vessel of Endless Rest";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "Art";
		 Cost = "3";
		 PT = "";
		 Type = "Artifact";
		 Text = "When Vessel of Endless Rest enters the battlefield, put target card from a graveyard on the bottom of its owner�s library.;^%T: Add one mana of any color to your mana pool.";
		 Flavor = "";
	}
}
# endregion

# region Vexing Devil
class VexingDevilAVR : MagicCard
{
	public VexingDevilAVR()
	{
		 Name = "Vexing Devil";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "R";
		 Cost = "R";
		 PT = "4/3";
		 Type = "Creature - Devil";
		 Text = "When Vexing Devil enters the battlefield, any opponent may have it deal 4 damage to him or her. If a player does, sacrifice Vexing Devil.";
		 Flavor = "";
	}
}
# endregion

# region Vigilante Justice
class VigilanteJusticeAVR : MagicCard
{
	public VigilanteJusticeAVR()
	{
		 Name = "Vigilante Justice";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "R";
		 Cost = "3R";
		 PT = "";
		 Type = "Enchantment";
		 Text = "Whenever a Human enters the battlefield under your control, Vigilante Justice deals 1 damage to target creature or player.";
		 Flavor = "";
	}
}
# endregion

# region Voice of the Provinces
class VoiceoftheProvincesAVR : MagicCard
{
	public VoiceoftheProvincesAVR()
	{
		 Name = "Voice of the Provinces";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "4WW";
		 PT = "3/3";
		 Type = "Creature - Angel";
		 Text = "Flying;^When Voice of the Provinces enters the battlefield, put a 1/1 white Human creature token onto the battlefield.";
		 Flavor = "";
	}
}
# endregion

# region Vorstclaw
class VorstclawAVR : MagicCard
{
	public VorstclawAVR()
	{
		 Name = "Vorstclaw";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "G";
		 Cost = "4GG";
		 PT = "7/7";
		 Type = "Creature - Elemental Horror";
		 Text = "";
		 Flavor = "�Where�d the werewolves go? Maybe that got hungry.�;^�Halana of Ulvenwald";
	}
}
# endregion

# region Wandering Wolf
class WanderingWolfAVR : MagicCard
{
	public WanderingWolfAVR()
	{
		 Name = "Wandering Wolf";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "1G";
		 PT = "2/1";
		 Type = "Creature - Wolf";
		 Text = "Creatures with power less than Wandering Wolf�s power can�t block it.";
		 Flavor = "";
	}
}
# endregion

# region Wild Defiance
class WildDefianceAVR : MagicCard
{
	public WildDefianceAVR()
	{
		 Name = "Wild Defiance";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "G";
		 Cost = "2G";
		 PT = "";
		 Type = "Enchantment";
		 Text = "Whenever a creature you control becomes the target of an instant or sorcery spell, that creature gets +3/+3 until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Wildwood Geist
class WildwoodGeistAVR : MagicCard
{
	public WildwoodGeistAVR()
	{
		 Name = "Wildwood Geist";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "G";
		 Cost = "4G";
		 PT = "3/3";
		 Type = "Creature - Spirit";
		 Text = "Wildwood Geist gets +2/+2 as long as it�s your turn.";
		 Flavor = "";
	}
}
# endregion

# region Wingcrafter
class WingcrafterAVR : MagicCard
{
	public WingcrafterAVR()
	{
		 Name = "Wingcrafter";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "U";
		 Cost = "U";
		 PT = "1/1";
		 Type = "Creature - Human Wizard";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Wingcrafter is paired with another creature, both creatures have flying.";
		 Flavor = "";
	}
}
# endregion

# region Wolfir Avenger
class WolfirAvengerAVR : MagicCard
{
	public WolfirAvengerAVR()
	{
		 Name = "Wolfir Avenger";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "G";
		 Cost = "1GG";
		 PT = "3/3";
		 Type = "Creature - Wolf Warrior";
		 Text = "Flash @(You may cast this spell any time you could cast an instant.)@;^%1%G: Regenerate Wolfir Avenger.";
		 Flavor = "";
	}
}
# endregion

# region Wolfir Silverheart
class WolfirSilverheartAVR : MagicCard
{
	public WolfirSilverheartAVR()
	{
		 Name = "Wolfir Silverheart";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "G";
		 Cost = "3GG";
		 PT = "4/4";
		 Type = "Creature - Wolf Warrior";
		 Text = "Soulbond @(You may pair this creature with another unpaired creature when either enters the battlefield. They remain paired for as long as you control both of them.)@;^As long as Wolfir Silverheart is paired with another creature, each of those creatures gets +4/+4.";
		 Flavor = "";
	}
}
# endregion

# region Yew Spirit
class YewSpiritAVR : MagicCard
{
	public YewSpiritAVR()
	{
		 Name = "Yew Spirit";
		 Edition = "AVR";
		 Rarity = "U";
		 Color = "G";
		 Cost = "4G";
		 PT = "3/3";
		 Type = "Creature - Spirit Treefolk";
		 Text = "%2%G%G: Yew Spirit gets +X/+X until end of turn, where X is its power.";
		 Flavor = "";
	}
}
# endregion

# region Zealous Conscripts
class ZealousConscriptsAVR : MagicCard
{
	public ZealousConscriptsAVR()
	{
		 Name = "Zealous Conscripts";
		 Edition = "AVR";
		 Rarity = "R";
		 Color = "R";
		 Cost = "4R";
		 PT = "3/3";
		 Type = "Creature - Human Warrior";
		 Text = "Haste;^When Zealous Conscripts enters the battlefield, gain control of target permanent until end of turn. Untap that permanent. It gains haste until end of turn.";
		 Flavor = "";
	}
}
# endregion

# region Zealous Strike
class ZealousStrikeAVR : MagicCard
{
	public ZealousStrikeAVR()
	{
		 Name = "Zealous Strike";
		 Edition = "AVR";
		 Rarity = "C";
		 Color = "W";
		 Cost = "1W";
		 PT = "";
		 Type = "Instant";
		 Text = "Target creature gets +2/+2 and gains first strike until end of turn.";
		 Flavor = "";
	}
}
# endregion
# endregion

}
