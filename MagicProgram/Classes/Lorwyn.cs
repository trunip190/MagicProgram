using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicProgram
{
    # region Lorwyn
    # region Adder-Staff Boggart
    public class AdderStaffBoggart : MagicCard
    {
        public AdderStaffBoggart()
        {
            Name = "Adder-Staff Boggart";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "2/1";
            Type = "Creature - Goblin Warrior";
            Text = "When Adder-Staff Boggart enters the battlefield, clash with an opponent. If you win, put a +1/+1 counter on Adder-Staff Boggart. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region AEthersnipe
    public class AEthersnipe : MagicCard
    {
        public AEthersnipe()
        {
            Name = "AEthersnipe";
            Edition = "LRW";
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

    # region Ajani Goldmane
    public class AjaniGoldmane : MagicCard
    {
        public AjaniGoldmane()
        {
            Name = "Ajani Goldmane";
            Edition = "LRW";
            Rarity = "R";
            Color = "W";
            Cost = "2WW";
            PT = "%4/";
            Type = "Planeswalker - Ajani";
            Text = "+1: You gain 2 life.;^-1: Put a +1/+1 counter on each creature you control. Those creatures gain vigilance until end of turn.;^-6: Put a white Avatar creature token onto the battlefield. It has �This creature�s power and toughness are each equal to your life total.�";
            Flavor = "";
        }
    }
    # endregion

    # region Amoeboid Changeling
    public class AmoeboidChangeling : MagicCard
    {
        public AmoeboidChangeling()
        {
            Name = "Amoeboid Changeling";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^%T: Target creature gains all creature types until end of turn.^%T: Target creature loses all creature types until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Ancient Amphitheater
    public class AncientAmphitheater : MagicCard
    {
        public AncientAmphitheater()
        {
            Name = "Ancient Amphitheater";
            Edition = "LRW";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "As Ancient Amphitheater enters the battlefield, you may reveal a Giant card from your hand. If you don�t, Ancient Amphitheater enters the battlefield tapped.;^%T: Add %R or %W to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Aquitect's Will
    public class AquitectsWill : MagicCard
    {
        public AquitectsWill()
        {
            Name = "Aquitect's Will";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Tribal Sorcery - Merfolk";
            Text = "Put a flood counter on target land. That land is an Island in addition to its other types for as long as it has a flood counter on it. If you control a Merfolk, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Arbiter of Knollridge
    public class ArbiterofKnollridge : MagicCard
    {
        public ArbiterofKnollridge()
        {
            Name = "Arbiter of Knollridge";
            Edition = "LRW";
            Rarity = "R";
            Color = "W";
            Cost = "6W";
            PT = "5/5";
            Type = "Creature - Giant Wizard";
            Text = "Vigilance;^When Arbiter of Knollridge enters the battlefield, each player�s life total becomes the highest life total among all players.";
            Flavor = "";
        }
    }
    # endregion

    # region Ashling the Pilgrim
    public class AshlingthePilgrim : MagicCard
    {
        public AshlingthePilgrim()
        {
            Name = "Ashling the Pilgrim";
            Edition = "LRW";
            Rarity = "R";
            Color = "R";
            Cost = "1R";
            PT = "1/1";
            Type = "Legendary Creature - Elemental Shaman";
            Text = "%1%R: Put a +1/+1 counter on Ashling the Pilgrim. If this is the third time this ability has resolved this turn, remove all +1/+1 counters from Ashling the Pilgrim, and it deals that much damage to each creature and each player.";
            Flavor = "";
        }
    }
    # endregion

    # region Ashling's Prerogative
    public class AshlingsPrerogative : MagicCard
    {
        public AshlingsPrerogative()
        {
            Name = "Ashling's Prerogative";
            Edition = "LRW";
            Rarity = "R";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Enchantment";
            Text = "As Ashling�s Prerogative enters the battlefield, choose odd or even. @(Zero is even.)@;^Each creature with converted mana cost of the chosen value has haste.;^Each creature without converted mana cost of the chosen value enters the battlefield tapped.";
            Flavor = "";
        }
    }
    # endregion

    # region Auntie's Hovel
    public class AuntiesHovel : MagicCard
    {
        public AuntiesHovel()
        {
            Name = "Auntie's Hovel";
            Edition = "LRW";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "As Auntie�s Hovel enters the battlefield, you may reveal a Goblin card from your hand. If you don�t, Auntie�s Hovel enters the battlefield tapped.;^%T: Add %B or %R to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Austere Command
    public class AustereCommand : MagicCard
    {
        public AustereCommand()
        {
            Name = "Austere Command";
            Edition = "LRW";
            Rarity = "R";
            Color = "W";
            Cost = "4WW";
            PT = "";
            Type = "Sorcery";
            Text = "Choose two � Destroy all artifacts; or destroy all enchantments; or destroy all creatures with converted mana cost 3 or less; or destroy all creatures with converted mana cost 4 or greater.";
            Flavor = "";
        }
    }
    # endregion

    # region Avian Changeling
    public class AvianChangeling : MagicCard
    {
        public AvianChangeling()
        {
            Name = "Avian Changeling";
            Edition = "LRW";
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

    # region Axegrinder Giant
    public class AxegrinderGiant : MagicCard
    {
        public AxegrinderGiant()
        {
            Name = "Axegrinder Giant";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "4RR";
            PT = "6/4";
            Type = "Creature - Giant Warrior";
            Text = "";
            Flavor = "The angriest of giants are often the most skillful weaponsmiths. Their grudges fuel endless sessions at the forge, all the while growling ferociously to themselves.";
        }
    }
    # endregion

    # region Battle Mastery
    public class BattleMastery : MagicCard
    {
        public BattleMastery()
        {
            Name = "Battle Mastery";
            Edition = "LRW";
            Rarity = "U";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^Enchanted creature has double strike.";
            Flavor = "";
        }
    }
    # endregion

    # region Battlewand Oak
    public class BattlewandOak : MagicCard
    {
        public BattlewandOak()
        {
            Name = "Battlewand Oak";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "1/3";
            Type = "Creature - Treefolk Warrior";
            Text = "Whenever a Forest enters the battlefield under your control, Battlewand Oak gets +2/+2 until end of turn.;^Whenever you cast a Treefolk spell, Battlewand Oak gets +2/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Benthicore
    public class Benthicore : MagicCard
    {
        public Benthicore()
        {
            Name = "Benthicore";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "6U";
            PT = "5/5";
            Type = "Creature - Elemental";
            Text = "When Benthicore enters the battlefield, put two 1/1 blue Merfolk Wizard creature tokens onto the battlefield.;^Tap two untapped Merfolk you control: Untap Benthicore. It gains shroud until end of turn. @(It can�t be the target of spells or abilities.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Black Poplar Shaman
    public class BlackPoplarShaman : MagicCard
    {
        public BlackPoplarShaman()
        {
            Name = "Black Poplar Shaman";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "1/3";
            Type = "Creature - Treefolk Shaman";
            Text = "%2%B: Regenerate target Treefolk.";
            Flavor = "";
        }
    }
    # endregion

    # region Blades of Velis Vel
    public class BladesofVelisVel : MagicCard
    {
        public BladesofVelisVel()
        {
            Name = "Blades of Velis Vel";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Tribal Instant - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^Up to two target creatures each get +2/+0 and gain all creature types until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Blind-Spot Giant
    public class BlindSpotGiant : MagicCard
    {
        public BlindSpotGiant()
        {
            Name = "Blind-Spot Giant";
            Edition = "LRW";
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

    # region Bog Hoodlums
    public class BogHoodlums : MagicCard
    {
        public BogHoodlums()
        {
            Name = "Bog Hoodlums";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "5B";
            PT = "4/1";
            Type = "Creature - Goblin Warrior";
            Text = "Bog Hoodlums can�t block.;^When Bog Hoodlums enters the battlefield, clash with an opponent. If you win, put a +1/+1 counter on Bog Hoodlums. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Boggart Birth Rite
    public class BoggartBirthRite : MagicCard
    {
        public BoggartBirthRite()
        {
            Name = "Boggart Birth Rite";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Tribal Sorcery - Goblin";
            Text = "Return target Goblin card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Boggart Forager
    public class BoggartForager : MagicCard
    {
        public BoggartForager()
        {
            Name = "Boggart Forager";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Goblin Rogue";
            Text = "%R, Sacrifice Boggart Forager: Target player shuffles his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Boggart Harbinger
    public class BoggartHarbinger : MagicCard
    {
        public BoggartHarbinger()
        {
            Name = "Boggart Harbinger";
            Edition = "LRW";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "2/1";
            Type = "Creature - Goblin Shaman";
            Text = "When Boggart Harbinger enters the battlefield, you may search your library for a Goblin card, reveal it, then shuffle your library and put that card on top of it.";
            Flavor = "";
        }
    }
    # endregion

    # region Boggart Loggers
    public class BoggartLoggers : MagicCard
    {
        public BoggartLoggers()
        {
            Name = "Boggart Loggers";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "2/1";
            Type = "Creature - Goblin Rogue";
            Text = "Forestwalk^%2%B, Sacrifice Boggart Loggers: Destroy target Treefolk or Forest.";
            Flavor = "";
        }
    }
    # endregion

    # region Boggart Mob
    public class BoggartMob : MagicCard
    {
        public BoggartMob()
        {
            Name = "Boggart Mob";
            Edition = "LRW";
            Rarity = "R";
            Color = "B";
            Cost = "3B";
            PT = "5/5";
            Type = "Creature - Goblin Warrior";
            Text = "Champion a Goblin @(When this enters the battlefield, sacrifice it unless you exile another Goblin you control. When this leaves the battlefield, that card returns to the battlefield.)@;^Whenever a Goblin you control deals combat damage to a player, you may put a 1/1 black Goblin Rogue creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Boggart Shenanigans
    public class BoggartShenanigans : MagicCard
    {
        public BoggartShenanigans()
        {
            Name = "Boggart Shenanigans";
            Edition = "LRW";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Tribal Enchantment - Goblin";
            Text = "Whenever another Goblin you control is put into a graveyard from the battlefield, you may have Boggart Shenanigans deal 1 damage to target player.";
            Flavor = "";
        }
    }
    # endregion

    # region Boggart Sprite-Chaser
    public class BoggartSpriteChaser : MagicCard
    {
        public BoggartSpriteChaser()
        {
            Name = "Boggart Sprite-Chaser";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "1/2";
            Type = "Creature - Goblin Warrior";
            Text = "As long as you control a Faerie, Boggart Sprite-Chaser gets +1/+1 and has flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Bog-Strider Ash
    public class BogStriderAsh : MagicCard
    {
        public BogStriderAsh()
        {
            Name = "Bog-Strider Ash";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "2/4";
            Type = "Creature - Treefolk Shaman";
            Text = "Swampwalk;^Whenever a player casts a Goblin spell, you may pay %G. If you do, you gain 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Briarhorn
    public class Briarhorn : MagicCard
    {
        public Briarhorn()
        {
            Name = "Briarhorn";
            Edition = "LRW";
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

    # region Brigid, Hero of Kinsbaile
    public class BrigidHeroofKinsbaile : MagicCard
    {
        public BrigidHeroofKinsbaile()
        {
            Name = "Brigid, Hero of Kinsbaile";
            Edition = "LRW";
            Rarity = "R";
            Color = "W";
            Cost = "2WW";
            PT = "2/3";
            Type = "Legendary Creature - Kithkin Archer";
            Text = "First strike^%T: Brigid, Hero of Kinsbaile deals 2 damage to each attacking or blocking creature target player controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Brion Stoutarm
    public class BrionStoutarm : MagicCard
    {
        public BrionStoutarm()
        {
            Name = "Brion Stoutarm";
            Edition = "LRW";
            Rarity = "R";
            Color = "Gld";
            Cost = "2RW";
            PT = "4/4";
            Type = "Legendary Creature - Giant Warrior";
            Text = "Lifelink;^%R, %T, Sacrifice a creature other than Brion Stoutarm: Brion Stoutarm deals damage equal to the sacrificed creature�s power to target player.";
            Flavor = "";
        }
    }
    # endregion

    # region Broken Ambitions
    public class BrokenAmbitions : MagicCard
    {
        public BrokenAmbitions()
        {
            Name = "Broken Ambitions";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "XU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell unless its controller pays %X. Clash with an opponent. If you win, that spell�s controller puts the top four cards of his or her library into his or her graveyard. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Burrenton Forge-Tender
    public class BurrentonForgeTender : MagicCard
    {
        public BurrentonForgeTender()
        {
            Name = "Burrenton Forge-Tender";
            Edition = "LRW";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Kithkin Wizard";
            Text = "Protection from red^Sacrifice Burrenton Forge-Tender: Prevent all damage a red source of your choice would deal this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Cairn Wanderer
    public class CairnWanderer : MagicCard
    {
        public CairnWanderer()
        {
            Name = "Cairn Wanderer";
            Edition = "LRW";
            Rarity = "R";
            Color = "B";
            Cost = "4B";
            PT = "4/4";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^As long as a creature card with flying is in a graveyard, Cairn Wanderer has flying. The same is true for fear, first strike, double strike, deathtouch, haste, landwalk, lifelink, protection, reach, trample, shroud, and vigilance.";
            Flavor = "";
        }
    }
    # endregion

    # region Captivating Glance
    public class CaptivatingGlance : MagicCard
    {
        public CaptivatingGlance()
        {
            Name = "Captivating Glance";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^At the beginning of your end step, clash with an opponent. If you win, gain control of enchanted creature. Otherwise, that player gains control of enchanted creature. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Caterwauling Boggart
    public class CaterwaulingBoggart : MagicCard
    {
        public CaterwaulingBoggart()
        {
            Name = "Caterwauling Boggart";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "2/2";
            Type = "Creature - Goblin Shaman";
            Text = "Each Goblin you control can�t be blocked except by two or more creatures.^Each Elemental you control can�t be blocked except by two or more creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Ceaseless Searblades
    public class CeaselessSearblades : MagicCard
    {
        public CeaselessSearblades()
        {
            Name = "Ceaseless Searblades";
            Edition = "LRW";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "2/4";
            Type = "Creature - Elemental Warrior";
            Text = "Whenever you activate an ability of an Elemental, Ceaseless Searblades gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Cenn's Heir
    public class CennsHeir : MagicCard
    {
        public CennsHeir()
        {
            Name = "Cenn's Heir";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "1/1";
            Type = "Creature - Kithkin Soldier";
            Text = "Whenever Cenn�s Heir attacks, it gets +1/+1 until end of turn for each other attacking Kithkin.";
            Flavor = "";
        }
    }
    # endregion

    # region Chandra Nalaar
    public class ChandraNalaar : MagicCard
    {
        public ChandraNalaar()
        {
            Name = "Chandra Nalaar";
            Edition = "LRW";
            Rarity = "R";
            Color = "R";
            Cost = "3RR";
            PT = "%6/";
            Type = "Planeswalker - Chandra";
            Text = "+1: Chandra Nalaar deals 1 damage to target player.^-X: Chandra Nalaar deals X damage to target creature.^-8: Chandra Nalaar deals 10 damage to target player and each creature he or she controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Changeling Berserker
    public class ChangelingBerserker : MagicCard
    {
        public ChangelingBerserker()
        {
            Name = "Changeling Berserker";
            Edition = "LRW";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "5/3";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@;^Haste;^Champion a creature @(When this enters the battlefield, sacrifice it unless you exile another creature you control. When this leaves the battlefield, that card returns to the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Changeling Hero
    public class ChangelingHero : MagicCard
    {
        public ChangelingHero()
        {
            Name = "Changeling Hero";
            Edition = "LRW";
            Rarity = "U";
            Color = "W";
            Cost = "4W";
            PT = "4/4";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@;^Champion a creature @(When this enters the battlefield, sacrifice it unless you exile another creature you control. When this leaves the battlefield, that card returns to the battlefield.)@;^Lifelink @(Damage dealt by this creature also causes you to gain that much life.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Changeling Titan
    public class ChangelingTitan : MagicCard
    {
        public ChangelingTitan()
        {
            Name = "Changeling Titan";
            Edition = "LRW";
            Rarity = "U";
            Color = "G";
            Cost = "4G";
            PT = "7/7";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@;^Champion a creature @(When this enters the battlefield, sacrifice it unless you exile another creature you control. When this leaves the battlefield, that card returns to the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Cloudcrown Oak
    public class CloudcrownOak : MagicCard
    {
        public CloudcrownOak()
        {
            Name = "Cloudcrown Oak";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "2GG";
            PT = "3/4";
            Type = "Creature - Treefolk Warrior";
            Text = "Reach @(This can block creatures with flying.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Cloudgoat Ranger
    public class CloudgoatRanger : MagicCard
    {
        public CloudgoatRanger()
        {
            Name = "Cloudgoat Ranger";
            Edition = "LRW";
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

    # region Cloudthresher
    public class Cloudthresher : MagicCard
    {
        public Cloudthresher()
        {
            Name = "Cloudthresher";
            Edition = "LRW";
            Rarity = "R";
            Color = "G";
            Cost = "2GGGG";
            PT = "7/7";
            Type = "Creature - Elemental";
            Text = "Flash;^Reach @(This can block creatures with flying.)@;^When Cloudthresher enters the battlefield, it deals 2 damage to each creature with flying and each player.;^Evoke %2%G%G @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Colfenor's Plans
    public class ColfenorsPlans : MagicCard
    {
        public ColfenorsPlans()
        {
            Name = "Colfenor's Plans";
            Edition = "LRW";
            Rarity = "R";
            Color = "B";
            Cost = "2BB";
            PT = "";
            Type = "Enchantment";
            Text = "When Colfenor�s Plans enters the battlefield, exile the top seven cards of your library face down.;^You may look at and play cards exiled with Colfenor�s Plans.;^Skip your draw step.;^You can�t cast more than one spell each turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Colfenor's Urn
    public class ColfenorsUrn : MagicCard
    {
        public ColfenorsUrn()
        {
            Name = "Colfenor's Urn";
            Edition = "LRW";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever a creature with toughness 4 or greater is put into your graveyard from the battlefield, you may exile it.;^At the beginning of the end step, if three or more cards have been exiled with Colfenor�s Urn, sacrifice it. If you do, return those cards to the battlefield under their owner�s control.";
            Flavor = "";
        }
    }
    # endregion

    # region Consuming Bonfire
    public class ConsumingBonfire : MagicCard
    {
        public ConsumingBonfire()
        {
            Name = "Consuming Bonfire";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "3RR";
            PT = "";
            Type = "Tribal Sorcery - Elemental";
            Text = "Choose one � Consuming Bonfire deals 4 damage to target non-Elemental creature; or Consuming Bonfire deals 7 damage to target Treefolk creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Crib Swap
    public class CribSwap : MagicCard
    {
        public CribSwap()
        {
            Name = "Crib Swap";
            Edition = "LRW";
            Rarity = "U";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Tribal Instant - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@;^Exile target creature. Its controller puts a 1/1 colorless Shapeshifter creature token with changeling onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Crush Underfoot
    public class CrushUnderfoot : MagicCard
    {
        public CrushUnderfoot()
        {
            Name = "Crush Underfoot";
            Edition = "LRW";
            Rarity = "U";
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
    public class CrypticCommand : MagicCard
    {
        public CrypticCommand()
        {
            Name = "Cryptic Command";
            Edition = "LRW";
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

    # region Dauntless Dourbark
    public class DauntlessDourbark : MagicCard
    {
        public DauntlessDourbark()
        {
            Name = "Dauntless Dourbark";
            Edition = "LRW";
            Rarity = "R";
            Color = "G";
            Cost = "3G";
            PT = "*/*";
            Type = "Creature - Treefolk Warrior";
            Text = "Dauntless Dourbark�s power and toughness are each equal to the number of Forests you control plus the number of Treefolk you control.^Dauntless Dourbark has trample as long as you control another Treefolk.";
            Flavor = "";
        }
    }
    # endregion

    # region Dawnfluke
    public class Dawnfluke : MagicCard
    {
        public Dawnfluke()
        {
            Name = "Dawnfluke";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "0/3";
            Type = "Creature - Elemental";
            Text = "Flash;^When Dawnfluke enters the battlefield, prevent the next 3 damage that would be dealt to target creature or player this turn.;^Evoke %W @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Deathrender
    public class Deathrender : MagicCard
    {
        public Deathrender()
        {
            Name = "Deathrender";
            Edition = "LRW";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +2/+2.;^Whenever equipped creature dies, you may put a creature card from your hand onto the battlefield and attach Deathrender to it.;^Equip %2";
            Flavor = "";
        }
    }
    # endregion

    # region Deeptread Merrow
    public class DeeptreadMerrow : MagicCard
    {
        public DeeptreadMerrow()
        {
            Name = "Deeptread Merrow";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "2/1";
            Type = "Creature - Merfolk Rogue";
            Text = "%U: Deeptread Merrow gains islandwalk until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Dolmen Gate
    public class DolmenGate : MagicCard
    {
        public DolmenGate()
        {
            Name = "Dolmen Gate";
            Edition = "LRW";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Prevent all combat damage that would be dealt to attacking creatures you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Doran, the Siege Tower
    public class DorantheSiegeTower : MagicCard
    {
        public DorantheSiegeTower()
        {
            Name = "Doran, the Siege Tower";
            Edition = "LRW";
            Rarity = "R";
            Color = "Gld";
            Cost = "BGW";
            PT = "0/5";
            Type = "Legendary Creature - Treefolk Shaman";
            Text = "Each creature assigns combat damage equal to its toughness rather than its power.";
            Flavor = "";
        }
    }
    # endregion

    # region Dread
    public class Dread : MagicCard
    {
        public Dread()
        {
            Name = "Dread";
            Edition = "LRW";
            Rarity = "R";
            Color = "B";
            Cost = "3BBB";
            PT = "6/6";
            Type = "Creature - Elemental Incarnation";
            Text = "Fear @(This creature can�t be blocked except by artifact creatures and/or black creatures.)@;^Whenever a creature deals damage to you, destroy it.;^When Dread is put into a graveyard from anywhere, shuffle it into its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Dreamspoiler Witches
    public class DreamspoilerWitches : MagicCard
    {
        public DreamspoilerWitches()
        {
            Name = "Dreamspoiler Witches";
            Edition = "LRW";
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

    # region Drowner of Secrets
    public class DrownerofSecrets : MagicCard
    {
        public DrownerofSecrets()
        {
            Name = "Drowner of Secrets";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "1/3";
            Type = "Creature - Merfolk Wizard";
            Text = "Tap an untapped Merfolk you control: Target player puts the top card of his or her library into his or her graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Ego Erasure
    public class EgoErasure : MagicCard
    {
        public EgoErasure()
        {
            Name = "Ego Erasure";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Tribal Instant - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^Creatures target player controls get -2/-0 and lose all creature types until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Elvish Branchbender
    public class ElvishBranchbender : MagicCard
    {
        public ElvishBranchbender()
        {
            Name = "Elvish Branchbender";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Elf Druid";
            Text = "%T: Until end of turn, target Forest becomes an X/X Treefolk creature in addition to its other types, where X is the number of Elves you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Elvish Eulogist
    public class ElvishEulogist : MagicCard
    {
        public ElvishEulogist()
        {
            Name = "Elvish Eulogist";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Elf Shaman";
            Text = "Sacrifice Elvish Eulogist: You gain 1 life for each Elf card in your graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Elvish Handservant
    public class ElvishHandservant : MagicCard
    {
        public ElvishHandservant()
        {
            Name = "Elvish Handservant";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Elf Warrior";
            Text = "Whenever a player casts a Giant spell, you may put a +1/+1 counter on Elvish Handservant.";
            Flavor = "";
        }
    }
    # endregion

    # region Elvish Harbinger
    public class ElvishHarbinger : MagicCard
    {
        public ElvishHarbinger()
        {
            Name = "Elvish Harbinger";
            Edition = "LRW";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "1/2";
            Type = "Creature - Elf Druid";
            Text = "When Elvish Harbinger enters the battlefield, you may search your library for an Elf card, reveal it, then shuffle your library and put that card on top of it.;^%T: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Elvish Promenade
    public class ElvishPromenade : MagicCard
    {
        public ElvishPromenade()
        {
            Name = "Elvish Promenade";
            Edition = "LRW";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Tribal Sorcery - Elf";
            Text = "Put a 1/1 green Elf Warrior creature token onto the battlefield for each Elf you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Entangling Trap
    public class EntanglingTrap : MagicCard
    {
        public EntanglingTrap()
        {
            Name = "Entangling Trap";
            Edition = "LRW";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever you clash, tap target creature an opponent controls. If you won, that creature doesn�t untap during its controller�s next untap step. @(This ability triggers after the clash ends.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Epic Proportions
    public class EpicProportions : MagicCard
    {
        public EpicProportions()
        {
            Name = "Epic Proportions";
            Edition = "LRW";
            Rarity = "R";
            Color = "G";
            Cost = "4GG";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Flash^Enchant creature^Enchanted creature gets +5/+5 and has trample.";
            Flavor = "";
        }
    }
    # endregion

    # region Ethereal Whiskergill
    public class EtherealWhiskergill : MagicCard
    {
        public EtherealWhiskergill()
        {
            Name = "Ethereal Whiskergill";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "4/3";
            Type = "Creature - Elemental";
            Text = "Flying^Ethereal Whiskergill can�t attack unless defending player controls an Island.";
            Flavor = "";
        }
    }
    # endregion

    # region Exiled Boggart
    public class ExiledBoggart : MagicCard
    {
        public ExiledBoggart()
        {
            Name = "Exiled Boggart";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "2/2";
            Type = "Creature - Goblin Rogue";
            Text = "When Exiled Boggart dies, discard a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Eyeblight's Ending
    public class EyeblightsEnding : MagicCard
    {
        public EyeblightsEnding()
        {
            Name = "Eyeblight's Ending";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Tribal Instant - Elf";
            Text = "Destroy target non-Elf creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Eyes of the Wisent
    public class EyesoftheWisent : MagicCard
    {
        public EyesoftheWisent()
        {
            Name = "Eyes of the Wisent";
            Edition = "LRW";
            Rarity = "R";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Tribal Enchantment - Elemental";
            Text = "Whenever an opponent casts a blue spell during your turn, you may put a 4/4 green Elemental creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Facevaulter
    public class Facevaulter : MagicCard
    {
        public Facevaulter()
        {
            Name = "Facevaulter";
            Edition = "LRW";
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

    # region Faerie Harbinger
    public class FaerieHarbinger : MagicCard
    {
        public FaerieHarbinger()
        {
            Name = "Faerie Harbinger";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "2/2";
            Type = "Creature - Faerie Wizard";
            Text = "Flash;^Flying;^When Faerie Harbinger enters the battlefield, you may search your library for a Faerie card, reveal it, then shuffle your library and put that card on top of it.";
            Flavor = "";
        }
    }
    # endregion

    # region Faerie Tauntings
    public class FaerieTauntings : MagicCard
    {
        public FaerieTauntings()
        {
            Name = "Faerie Tauntings";
            Edition = "LRW";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Tribal Enchantment - Faerie";
            Text = "Whenever you cast a spell during an opponent�s turn, you may have each opponent lose 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Faerie Trickery
    public class FaerieTrickery : MagicCard
    {
        public FaerieTrickery()
        {
            Name = "Faerie Trickery";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "1UU";
            PT = "";
            Type = "Tribal Instant - Faerie";
            Text = "Counter target non-Faerie spell. If that spell is countered this way, exile it instead of putting it into its owner�s graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Fallowsage
    public class Fallowsage : MagicCard
    {
        public Fallowsage()
        {
            Name = "Fallowsage";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "2/2";
            Type = "Creature - Merfolk Wizard";
            Text = "Whenever Fallowsage becomes tapped, you may draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Familiar's Ruse
    public class FamiliarsRuse : MagicCard
    {
        public FamiliarsRuse()
        {
            Name = "Familiar's Ruse";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "UU";
            PT = "";
            Type = "Instant";
            Text = "As an additional cost to cast Familiar�s Ruse, return a creature you control to its owner�s hand.;^Counter target spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Fathom Trawl
    public class FathomTrawl : MagicCard
    {
        public FathomTrawl()
        {
            Name = "Fathom Trawl";
            Edition = "LRW";
            Rarity = "R";
            Color = "U";
            Cost = "3UU";
            PT = "";
            Type = "Sorcery";
            Text = "Reveal cards from the top of your library until you reveal three nonland cards. Put the nonland cards revealed this way into your hand, then put the rest of the revealed cards on the bottom of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Faultgrinder
    public class Faultgrinder : MagicCard
    {
        public Faultgrinder()
        {
            Name = "Faultgrinder";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "6R";
            PT = "4/4";
            Type = "Creature - Elemental";
            Text = "Trample;^When Faultgrinder enters the battlefield, destroy target land.;^Evoke %4%R @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Favor of the Mighty
    public class FavoroftheMighty : MagicCard
    {
        public FavoroftheMighty()
        {
            Name = "Favor of the Mighty";
            Edition = "LRW";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Tribal Enchantment - Giant";
            Text = "Each creature with the highest converted mana cost has protection from all colors.";
            Flavor = "";
        }
    }
    # endregion

    # region Fertile Ground
    public class FertileGround : MagicCard
    {
        public FertileGround()
        {
            Name = "Fertile Ground";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land;^Whenever enchanted land is tapped for mana, its controller adds one mana of any color to his or her mana pool @(in addition to the mana the land produces)@.";
            Flavor = "";
        }
    }
    # endregion

    # region Final Revels
    public class FinalRevels : MagicCard
    {
        public FinalRevels()
        {
            Name = "Final Revels";
            Edition = "LRW";
            Rarity = "U";
            Color = "B";
            Cost = "4B";
            PT = "";
            Type = "Sorcery";
            Text = "Choose one � All creatures get +2/+0 until end of turn; or all creatures get -0/-2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Fire-Belly Changeling
    public class FireBellyChangeling : MagicCard
    {
        public FireBellyChangeling()
        {
            Name = "Fire-Belly Changeling";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "1/1";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@;^%R: Fire-Belly Changeling gets +1/+0 until end of turn. Activate this ability no more than twice each turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Fistful of Force
    public class FistfulofForce : MagicCard
    {
        public FistfulofForce()
        {
            Name = "Fistful of Force";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +2/+2 until end of turn. Clash with an opponent. If you win, that creature gets an additional +2/+2 and gains trample until end of turn. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Flamekin Bladewhirl
    public class FlamekinBladewhirl : MagicCard
    {
        public FlamekinBladewhirl()
        {
            Name = "Flamekin Bladewhirl";
            Edition = "LRW";
            Rarity = "U";
            Color = "R";
            Cost = "R";
            PT = "2/1";
            Type = "Creature - Elemental Warrior";
            Text = "As an additional cost to cast Flamekin Bladewhirl, reveal an Elemental card from your hand or pay %3.";
            Flavor = "";
        }
    }
    # endregion

    # region Flamekin Brawler
    public class FlamekinBrawler : MagicCard
    {
        public FlamekinBrawler()
        {
            Name = "Flamekin Brawler";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "0/2";
            Type = "Creature - Elemental Warrior";
            Text = "%R: Flamekin Brawler gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Flamekin Harbinger
    public class FlamekinHarbinger : MagicCard
    {
        public FlamekinHarbinger()
        {
            Name = "Flamekin Harbinger";
            Edition = "LRW";
            Rarity = "U";
            Color = "R";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Elemental Shaman";
            Text = "When Flamekin Harbinger enters the battlefield, you may search your library for an Elemental card, reveal it, then shuffle your library and put that card on top of it.";
            Flavor = "";
        }
    }
    # endregion

    # region Flamekin Spitfire
    public class FlamekinSpitfire : MagicCard
    {
        public FlamekinSpitfire()
        {
            Name = "Flamekin Spitfire";
            Edition = "LRW";
            Rarity = "U";
            Color = "R";
            Cost = "1R";
            PT = "1/1";
            Type = "Creature - Elemental Shaman";
            Text = "%3%R: Flamekin Spitfire deals 1 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Fodder Launch
    public class FodderLaunch : MagicCard
    {
        public FodderLaunch()
        {
            Name = "Fodder Launch";
            Edition = "LRW";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "";
            Type = "Tribal Sorcery - Goblin";
            Text = "As an additional cost to cast Fodder Launch, sacrifice a Goblin.;^Target creature gets -5/-5 until end of turn. Fodder Launch deals 5 damage to that creature�s controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Footbottom Feast
    public class FootbottomFeast : MagicCard
    {
        public FootbottomFeast()
        {
            Name = "Footbottom Feast";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Instant";
            Text = "Put any number of target creature cards from your graveyard on top of your library.^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Forced Fruition
    public class ForcedFruition : MagicCard
    {
        public ForcedFruition()
        {
            Name = "Forced Fruition";
            Edition = "LRW";
            Rarity = "R";
            Color = "U";
            Cost = "4UU";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever an opponent casts a spell, that player draws seven cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Forest
    public class ForestLRW : MagicCard
    {
        public ForestLRW()
        {
            Name = "Forest";
            Edition = "LRW";
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

    # region Gaddock Teeg
    public class GaddockTeeg : MagicCard
    {
        public GaddockTeeg()
        {
            Name = "Gaddock Teeg";
            Edition = "LRW";
            Rarity = "R";
            Color = "Gld";
            Cost = "GW";
            PT = "2/2";
            Type = "Legendary Creature - Kithkin Advisor";
            Text = "Noncreature spells with converted mana cost 4 or greater can�t be cast.;^Noncreature spells with %X in their mana costs can�t be cast.";
            Flavor = "";
        }
    }
    # endregion

    # region Galepowder Mage
    public class GalepowderMage : MagicCard
    {
        public GalepowderMage()
        {
            Name = "Galepowder Mage";
            Edition = "LRW";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "3/3";
            Type = "Creature - Kithkin Wizard";
            Text = "Flying;^Whenever Galepowder Mage attacks, exile another target creature. Return that card to the battlefield under its owner�s control at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Garruk Wildspeaker
    public class GarrukWildspeaker : MagicCard
    {
        public GarrukWildspeaker()
        {
            Name = "Garruk Wildspeaker";
            Edition = "LRW";
            Rarity = "R";
            Color = "G";
            Cost = "2GG";
            PT = "%3/";
            Type = "Planeswalker - Garruk";
            Text = "+1: Untap two target lands.;^-1: Put a 3/3 green Beast creature token onto the battlefield.;^-4: Creatures you control get +3/+3 and gain trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Ghostly Changeling
    public class GhostlyChangeling : MagicCard
    {
        public GhostlyChangeling()
        {
            Name = "Ghostly Changeling";
            Edition = "LRW";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^%1%B: Ghostly Changeling gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Giant Harbinger
    public class GiantHarbinger : MagicCard
    {
        public GiantHarbinger()
        {
            Name = "Giant Harbinger";
            Edition = "LRW";
            Rarity = "U";
            Color = "R";
            Cost = "4R";
            PT = "3/4";
            Type = "Creature - Giant Shaman";
            Text = "When Giant Harbinger enters the battlefield, you may search your library for a Giant card, reveal it, then shuffle your library and put that card on top of it.";
            Flavor = "";
        }
    }
    # endregion

    # region Giant's Ire
    public class GiantsIre : MagicCard
    {
        public GiantsIre()
        {
            Name = "Giant's Ire";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Tribal Sorcery - Giant";
            Text = "Giant�s Ire deals 4 damage to target player. If you control a Giant, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Gilt-Leaf Ambush
    public class GiltLeafAmbush : MagicCard
    {
        public GiltLeafAmbush()
        {
            Name = "Gilt-Leaf Ambush";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Tribal Instant - Elf";
            Text = "Put two 1/1 green Elf Warrior creature tokens onto the battlefield. Clash with an opponent. If you win, those creatures gain deathtouch until end of turn. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost. Any amount of damage a creature with deathtouch deals to a creature is enough to destroy it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Gilt-Leaf Palace
    public class GiltLeafPalace : MagicCard
    {
        public GiltLeafPalace()
        {
            Name = "Gilt-Leaf Palace";
            Edition = "LRW";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "As Gilt-Leaf Palace enters the battlefield, you may reveal an Elf card from your hand. If you don�t, Gilt-Leaf Palace enters the battlefield tapped.;^%T: Add %B or %G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Gilt-Leaf Seer
    public class GiltLeafSeer : MagicCard
    {
        public GiltLeafSeer()
        {
            Name = "Gilt-Leaf Seer";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Elf Shaman";
            Text = "%G, %T: Look at the top two cards of your library, then put them back in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Glarewielder
    public class Glarewielder : MagicCard
    {
        public Glarewielder()
        {
            Name = "Glarewielder";
            Edition = "LRW";
            Rarity = "U";
            Color = "R";
            Cost = "4R";
            PT = "3/1";
            Type = "Creature - Elemental Shaman";
            Text = "Haste;^When Glarewielder enters the battlefield, up to two target creatures can�t block this turn.;^Evoke %1%R @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Glen Elendra Pranksters
    public class GlenElendraPranksters : MagicCard
    {
        public GlenElendraPranksters()
        {
            Name = "Glen Elendra Pranksters";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "1/3";
            Type = "Creature - Faerie Wizard";
            Text = "Flying;^Whenever you cast a spell during an opponent�s turn, you may return target creature you control to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Glimmerdust Nap
    public class GlimmerdustNap : MagicCard
    {
        public GlimmerdustNap()
        {
            Name = "Glimmerdust Nap";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant tapped creature^Enchanted creature doesn�t untap during its controller�s untap step.";
            Flavor = "";
        }
    }
    # endregion

    # region Goatnapper
    public class Goatnapper : MagicCard
    {
        public Goatnapper()
        {
            Name = "Goatnapper";
            Edition = "LRW";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Goblin Rogue";
            Text = "When Goatnapper enters the battlefield, untap target Goat and gain control of it until end of turn. It gains haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Goldmeadow Dodger
    public class GoldmeadowDodger : MagicCard
    {
        public GoldmeadowDodger()
        {
            Name = "Goldmeadow Dodger";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Kithkin Rogue";
            Text = "Goldmeadow Dodger can�t be blocked by creatures with power 4 or greater.";
            Flavor = "";
        }
    }
    # endregion

    # region Goldmeadow Harrier
    public class GoldmeadowHarrier : MagicCard
    {
        public GoldmeadowHarrier()
        {
            Name = "Goldmeadow Harrier";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Kithkin Soldier";
            Text = "%W, %T: Tap target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Goldmeadow Stalwart
    public class GoldmeadowStalwart : MagicCard
    {
        public GoldmeadowStalwart()
        {
            Name = "Goldmeadow Stalwart";
            Edition = "LRW";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "2/2";
            Type = "Creature - Kithkin Soldier";
            Text = "As an additional cost to cast Goldmeadow Stalwart, reveal a Kithkin card from your hand or pay %3.";
            Flavor = "";
        }
    }
    # endregion

    # region Guardian of Cloverdell
    public class GuardianofCloverdell : MagicCard
    {
        public GuardianofCloverdell()
        {
            Name = "Guardian of Cloverdell";
            Edition = "LRW";
            Rarity = "U";
            Color = "G";
            Cost = "5GG";
            PT = "4/5";
            Type = "Creature - Treefolk Shaman";
            Text = "When Guardian of Cloverdell enters the battlefield, put three 1/1 white Kithkin Soldier creature tokens onto the battlefield.;^%G, Sacrifice a Kithkin: You gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Guile
    public class Guile : MagicCard
    {
        public Guile()
        {
            Name = "Guile";
            Edition = "LRW";
            Rarity = "R";
            Color = "U";
            Cost = "3UUU";
            PT = "6/6";
            Type = "Creature - Elemental Incarnation";
            Text = "Guile can�t be blocked except by three or more creatures.;^If a spell or ability you control would counter a spell, instead exile that spell and you may play that card without paying its mana cost.;^When Guile is put into a graveyard from anywhere, shuffle it into its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Hamletback Goliath
    public class HamletbackGoliath : MagicCard
    {
        public HamletbackGoliath()
        {
            Name = "Hamletback Goliath";
            Edition = "LRW";
            Rarity = "R";
            Color = "R";
            Cost = "6R";
            PT = "6/6";
            Type = "Creature - Giant Warrior";
            Text = "Whenever another creature enters the battlefield, you may put X +1/+1 counters on Hamletback Goliath, where X is that creature�s power.";
            Flavor = "";
        }
    }
    # endregion

    # region Harpoon Sniper
    public class HarpoonSniper : MagicCard
    {
        public HarpoonSniper()
        {
            Name = "Harpoon Sniper";
            Edition = "LRW";
            Rarity = "U";
            Color = "W";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Merfolk Archer";
            Text = "%W, %T: Harpoon Sniper deals X damage to target attacking or blocking creature, where X is the number of Merfolk you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Heal the Scars
    public class HealtheScars : MagicCard
    {
        public HealtheScars()
        {
            Name = "Heal the Scars";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Instant";
            Text = "Regenerate target creature. You gain life equal to that creature�s toughness.";
            Flavor = "";
        }
    }
    # endregion

    # region Hearthcage Giant
    public class HearthcageGiant : MagicCard
    {
        public HearthcageGiant()
        {
            Name = "Hearthcage Giant";
            Edition = "LRW";
            Rarity = "U";
            Color = "R";
            Cost = "6RR";
            PT = "5/5";
            Type = "Creature - Giant Warrior";
            Text = "When Hearthcage Giant enters the battlefield, put two 3/1 red Elemental Shaman creature tokens onto the battlefield.;^Sacrifice an Elemental: Target Giant creature gets +3/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Heat Shimmer
    public class HeatShimmer : MagicCard
    {
        public HeatShimmer()
        {
            Name = "Heat Shimmer";
            Edition = "LRW";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Sorcery";
            Text = "Put a token that�s a copy of target creature onto the battlefield. That token has haste and �At the beginning of the end step, exile this permanent.�";
            Flavor = "";
        }
    }
    # endregion

    # region Herbal Poultice
    public class HerbalPoultice : MagicCard
    {
        public HerbalPoultice()
        {
            Name = "Herbal Poultice";
            Edition = "LRW";
            Rarity = "C";
            Color = "Art";
            Cost = "0";
            PT = "";
            Type = "Artifact";
            Text = "%3, Sacrifice Herbal Poultice: Regenerate target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Hillcomber Giant
    public class HillcomberGiant : MagicCard
    {
        public HillcomberGiant()
        {
            Name = "Hillcomber Giant";
            Edition = "LRW";
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

    # region Hoarder's Greed
    public class HoardersGreed : MagicCard
    {
        public HoardersGreed()
        {
            Name = "Hoarder's Greed";
            Edition = "LRW";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "";
            Type = "Sorcery";
            Text = "You lose 2 life and draw two cards, then clash with an opponent. If you win, repeat this process. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Hoofprints of the Stag
    public class HoofprintsoftheStag : MagicCard
    {
        public HoofprintsoftheStag()
        {
            Name = "Hoofprints of the Stag";
            Edition = "LRW";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Tribal Enchantment - Elemental";
            Text = "Whenever you draw a card, you may put a hoofprint counter on Hoofprints of the Stag.;^%2%W, Remove four hoofprint counters from Hoofprints of the Stag: Put a 4/4 white Elemental creature token with flying onto the battlefield. Activate this ability only during your turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Horde of Notions
    public class HordeofNotions : MagicCard
    {
        public HordeofNotions()
        {
            Name = "Horde of Notions";
            Edition = "LRW";
            Rarity = "R";
            Color = "Gld";
            Cost = "WUBRG";
            PT = "5/5";
            Type = "Legendary Creature - Elemental";
            Text = "Vigilance, trample, haste^%W%U%B%R%G: You may play target Elemental card from your graveyard without paying its mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Hornet Harasser
    public class HornetHarasser : MagicCard
    {
        public HornetHarasser()
        {
            Name = "Hornet Harasser";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "2BB";
            PT = "2/2";
            Type = "Creature - Goblin Shaman";
            Text = "When Hornet Harasser dies, target creature gets -2/-2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Hostility
    public class Hostility : MagicCard
    {
        public Hostility()
        {
            Name = "Hostility";
            Edition = "LRW";
            Rarity = "R";
            Color = "R";
            Cost = "3RRR";
            PT = "6/6";
            Type = "Creature - Elemental Incarnation";
            Text = "Haste;^If a spell you control would deal damage to an opponent, prevent that damage. Put a 3/1 red Elemental Shaman creature token with haste onto the battlefield for each 1 damage prevented this way.;^When Hostility is put into a graveyard from anywhere, shuffle it into its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Howltooth Hollow
    public class HowltoothHollow : MagicCard
    {
        public HowltoothHollow()
        {
            Name = "Howltooth Hollow";
            Edition = "LRW";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Hideaway @(This land enters the battlefield tapped. When it does, look at the top four cards of your library, exile one face down, then put the rest on the bottom of your library.)@;^%T: Add %B to your mana pool.;^%B, %T: You may play the exiled card without paying its mana cost if each player has no cards in hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Hunt Down
    public class HuntDown : MagicCard
    {
        public HuntDown()
        {
            Name = "Hunt Down";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Sorcery";
            Text = "Target creature blocks target creature this turn if able.";
            Flavor = "";
        }
    }
    # endregion

    # region Hunter of Eyeblights
    public class HunterofEyeblights : MagicCard
    {
        public HunterofEyeblights()
        {
            Name = "Hunter of Eyeblights";
            Edition = "LRW";
            Rarity = "U";
            Color = "B";
            Cost = "3BB";
            PT = "3/3";
            Type = "Creature - Elf Assassin";
            Text = "When Hunter of Eyeblights enters the battlefield, put a +1/+1 counter on target creature you don�t control.;^%2%B, %T: Destroy target creature with a counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Hurly-Burly
    public class HurlyBurly : MagicCard
    {
        public HurlyBurly()
        {
            Name = "Hurly-Burly";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Sorcery";
            Text = "Choose one � Hurly-Burly deals 1 damage to each creature without flying; or Hurly-Burly deals 1 damage to each creature with flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Immaculate Magistrate
    public class ImmaculateMagistrate : MagicCard
    {
        public ImmaculateMagistrate()
        {
            Name = "Immaculate Magistrate";
            Edition = "LRW";
            Rarity = "R";
            Color = "G";
            Cost = "3G";
            PT = "2/2";
            Type = "Creature - Elf Shaman";
            Text = "%T: Put a +1/+1 counter on target creature for each Elf you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Imperious Perfect
    public class ImperiousPerfect : MagicCard
    {
        public ImperiousPerfect()
        {
            Name = "Imperious Perfect";
            Edition = "LRW";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Elf Warrior";
            Text = "Other Elf creatures you control get +1/+1.;^%G, %T: Put a 1/1 green Elf Warrior creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Incandescent Soulstoke
    public class IncandescentSoulstoke : MagicCard
    {
        public IncandescentSoulstoke()
        {
            Name = "Incandescent Soulstoke";
            Edition = "LRW";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Elemental Shaman";
            Text = "Other Elemental creatures you control get +1/+1.;^%1%R, %T: You may put an Elemental creature card from your hand onto the battlefield. That creature gains haste until end of turn. Sacrifice it at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Incendiary Command
    public class IncendiaryCommand : MagicCard
    {
        public IncendiaryCommand()
        {
            Name = "Incendiary Command";
            Edition = "LRW";
            Rarity = "R";
            Color = "R";
            Cost = "3RR";
            PT = "";
            Type = "Sorcery";
            Text = "Choose two � Incendiary Command deals 4 damage to target player; or Incendiary Command deals 2 damage to each creature; or destroy target nonbasic land; or each player discards all the cards in his or her hand, then draws that many cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Incremental Growth
    public class IncrementalGrowth : MagicCard
    {
        public IncrementalGrowth()
        {
            Name = "Incremental Growth";
            Edition = "LRW";
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

    # region Ingot Chewer
    public class IngotChewer : MagicCard
    {
        public IngotChewer()
        {
            Name = "Ingot Chewer";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "4R";
            PT = "3/3";
            Type = "Creature - Elemental";
            Text = "When Ingot Chewer enters the battlefield, destroy target artifact.;^Evoke %R @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Inkfathom Divers
    public class InkfathomDivers : MagicCard
    {
        public InkfathomDivers()
        {
            Name = "Inkfathom Divers";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "3UU";
            PT = "3/3";
            Type = "Creature - Merfolk Soldier";
            Text = "Islandwalk;^When Inkfathom Divers enters the battlefield, look at the top four cards of your library, then put them back in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Inner-Flame Acolyte
    public class InnerFlameAcolyte : MagicCard
    {
        public InnerFlameAcolyte()
        {
            Name = "Inner-Flame Acolyte";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "1RR";
            PT = "2/2";
            Type = "Creature - Elemental Shaman";
            Text = "When Inner-Flame Acolyte enters the battlefield, target creature gets +2/+0 and gains haste until end of turn.;^Evoke %R @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Inner-Flame Igniter
    public class InnerFlameIgniter : MagicCard
    {
        public InnerFlameIgniter()
        {
            Name = "Inner-Flame Igniter";
            Edition = "LRW";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Elemental Warrior";
            Text = "%2%R: Creatures you control get +1/+0 until end of turn. If this is the third time this ability has resolved this turn, creatures you control gain first strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Island
    public class IslandLRW : MagicCard
    {
        public IslandLRW()
        {
            Name = "Island";
            Edition = "LRW";
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

    # region Jace Beleren
    public class JaceBeleren : MagicCard
    {
        public JaceBeleren()
        {
            Name = "Jace Beleren";
            Edition = "LRW";
            Rarity = "R";
            Color = "U";
            Cost = "1UU";
            PT = "%3/";
            Type = "Planeswalker - Jace";
            Text = "+2: Each player draws a card.^-1: Target player draws a card.^-10: Target player puts the top twenty cards of his or her library into his or her graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Jagged-Scar Archers
    public class JaggedScarArchers : MagicCard
    {
        public JaggedScarArchers()
        {
            Name = "Jagged-Scar Archers";
            Edition = "LRW";
            Rarity = "U";
            Color = "G";
            Cost = "1GG";
            PT = "*/*";
            Type = "Creature - Elf Archer";
            Text = "Jagged-Scar Archers�s power and toughness are each equal to the number of Elves you control.^%T: Jagged-Scar Archers deals damage equal to its power to target creature with flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Judge of Currents
    public class JudgeofCurrents : MagicCard
    {
        public JudgeofCurrents()
        {
            Name = "Judge of Currents";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "1/1";
            Type = "Creature - Merfolk Wizard";
            Text = "Whenever a Merfolk you control becomes tapped, you may gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Kinsbaile Balloonist
    public class KinsbaileBalloonist : MagicCard
    {
        public KinsbaileBalloonist()
        {
            Name = "Kinsbaile Balloonist";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "2/2";
            Type = "Creature - Kithkin Soldier";
            Text = "Flying^Whenever Kinsbaile Balloonist attacks, you may have target creature gain flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Kinsbaile Skirmisher
    public class KinsbaileSkirmisher : MagicCard
    {
        public KinsbaileSkirmisher()
        {
            Name = "Kinsbaile Skirmisher";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "2/2";
            Type = "Creature - Kithkin Soldier";
            Text = "When Kinsbaile Skirmisher enters the battlefield, target creature gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Kithkin Daggerdare
    public class KithkinDaggerdare : MagicCard
    {
        public KithkinDaggerdare()
        {
            Name = "Kithkin Daggerdare";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "1/1";
            Type = "Creature - Kithkin Soldier";
            Text = "%G, %T: Target attacking creature gets +2/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Kithkin Greatheart
    public class KithkinGreatheart : MagicCard
    {
        public KithkinGreatheart()
        {
            Name = "Kithkin Greatheart";
            Edition = "LRW";
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

    # region Kithkin Harbinger
    public class KithkinHarbinger : MagicCard
    {
        public KithkinHarbinger()
        {
            Name = "Kithkin Harbinger";
            Edition = "LRW";
            Rarity = "U";
            Color = "W";
            Cost = "2W";
            PT = "1/3";
            Type = "Creature - Kithkin Wizard";
            Text = "When Kithkin Harbinger enters the battlefield, you may search your library for a Kithkin card, reveal it, then shuffle your library and put that card on top of it.";
            Flavor = "";
        }
    }
    # endregion

    # region Kithkin Healer
    public class KithkinHealer : MagicCard
    {
        public KithkinHealer()
        {
            Name = "Kithkin Healer";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Kithkin Cleric";
            Text = "%T: Prevent the next 1 damage that would be dealt to target creature or player this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Kithkin Mourncaller
    public class KithkinMourncaller : MagicCard
    {
        public KithkinMourncaller()
        {
            Name = "Kithkin Mourncaller";
            Edition = "LRW";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Kithkin Scout";
            Text = "Whenever an attacking Kithkin or Elf is put into your graveyard from the battlefield, you may draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Knight of Meadowgrain
    public class KnightofMeadowgrain : MagicCard
    {
        public KnightofMeadowgrain()
        {
            Name = "Knight of Meadowgrain";
            Edition = "LRW";
            Rarity = "U";
            Color = "W";
            Cost = "WW";
            PT = "2/2";
            Type = "Creature - Kithkin Knight";
            Text = "First strike;^Lifelink @(Damage dealt by this creature also causes you to gain that much life.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Knucklebone Witch
    public class KnuckleboneWitch : MagicCard
    {
        public KnuckleboneWitch()
        {
            Name = "Knucklebone Witch";
            Edition = "LRW";
            Rarity = "R";
            Color = "B";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Goblin Shaman";
            Text = "Whenever a Goblin you control is put into a graveyard from the battlefield, you may put a +1/+1 counter on Knucklebone Witch.";
            Flavor = "";
        }
    }
    # endregion

    # region Lace with Moonglove
    public class LacewithMoonglove : MagicCard
    {
        public LacewithMoonglove()
        {
            Name = "Lace with Moonglove";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Instant";
            Text = "Target creature gains deathtouch until end of turn. @(Any amount of damage it deals to a creature is enough to destroy that creature.)@;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Lairwatch Giant
    public class LairwatchGiant : MagicCard
    {
        public LairwatchGiant()
        {
            Name = "Lairwatch Giant";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "5W";
            PT = "5/3";
            Type = "Creature - Giant Warrior";
            Text = "Lairwatch Giant can block an additional creature.^Whenever Lairwatch Giant blocks two or more creatures, it gains first strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Lammastide Weave
    public class LammastideWeave : MagicCard
    {
        public LammastideWeave()
        {
            Name = "Lammastide Weave";
            Edition = "LRW";
            Rarity = "U";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Name a card, then target player puts the top card of his or her library into his or her graveyard. If that card is the named card, you gain life equal to its converted mana cost.^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Lash Out
    public class LashOut : MagicCard
    {
        public LashOut()
        {
            Name = "Lash Out";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "Lash Out deals 3 damage to target creature. Clash with an opponent. If you win, Lash Out deals 3 damage to that creature�s controller. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Leaf Gilder
    public class LeafGilder : MagicCard
    {
        public LeafGilder()
        {
            Name = "Leaf Gilder";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "2/1";
            Type = "Creature - Elf Druid";
            Text = "%T: Add %G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Lignify
    public class Lignify : MagicCard
    {
        public Lignify()
        {
            Name = "Lignify";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Tribal Enchantment - Treefolk Aura";
            Text = "Enchant creature^Enchanted creature is a 0/4 Treefolk with no abilities.";
            Flavor = "";
        }
    }
    # endregion

    # region Liliana Vess
    public class LilianaVess : MagicCard
    {
        public LilianaVess()
        {
            Name = "Liliana Vess";
            Edition = "LRW";
            Rarity = "R";
            Color = "B";
            Cost = "3BB";
            PT = "%5/";
            Type = "Planeswalker - Liliana";
            Text = "+1: Target player discards a card.;^-2: Search your library for a card, then shuffle your library and put that card on top of it.;^-8: Put all creature cards from all graveyards onto the battlefield under your control.";
            Flavor = "";
        }
    }
    # endregion

    # region Lowland Oaf
    public class LowlandOaf : MagicCard
    {
        public LowlandOaf()
        {
            Name = "Lowland Oaf";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "3/3";
            Type = "Creature - Giant Warrior";
            Text = "%T: Target Goblin creature you control gets +1/+0 and gains flying until end of turn. Sacrifice that creature at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Lys Alana Huntmaster
    public class LysAlanaHuntmaster : MagicCard
    {
        public LysAlanaHuntmaster()
        {
            Name = "Lys Alana Huntmaster";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "2GG";
            PT = "3/3";
            Type = "Creature - Elf Warrior";
            Text = "Whenever you cast an Elf spell, you may put a 1/1 green Elf Warrior creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Lys Alana Scarblade
    public class LysAlanaScarblade : MagicCard
    {
        public LysAlanaScarblade()
        {
            Name = "Lys Alana Scarblade";
            Edition = "LRW";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "1/1";
            Type = "Creature - Elf Assassin";
            Text = "%T, Discard an Elf card: Target creature gets -X/-X until end of turn, where X is the number of Elves you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Mad Auntie
    public class MadAuntie : MagicCard
    {
        public MadAuntie()
        {
            Name = "Mad Auntie";
            Edition = "LRW";
            Rarity = "R";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Goblin Shaman";
            Text = "Other Goblin creatures you control get +1/+1.^%T: Regenerate another target Goblin.";
            Flavor = "";
        }
    }
    # endregion

    # region Makeshift Mannequin
    public class MakeshiftMannequin : MagicCard
    {
        public MakeshiftMannequin()
        {
            Name = "Makeshift Mannequin";
            Edition = "LRW";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "";
            Type = "Instant";
            Text = "Return target creature card from your graveyard to the battlefield with a mannequin counter on it. For as long as that creature has a mannequin counter on it, it has �When this creature becomes the target of a spell or ability, sacrifice it.�";
            Flavor = "";
        }
    }
    # endregion

    # region Marsh Flitter
    public class MarshFlitter : MagicCard
    {
        public MarshFlitter()
        {
            Name = "Marsh Flitter";
            Edition = "LRW";
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
    public class MaskedAdmirers : MagicCard
    {
        public MaskedAdmirers()
        {
            Name = "Masked Admirers";
            Edition = "LRW";
            Rarity = "R";
            Color = "G";
            Cost = "2GG";
            PT = "3/2";
            Type = "Creature - Elf Shaman";
            Text = "When Masked Admirers enters the battlefield, draw a card.;^Whenever you cast a creature spell, you may pay %G%G. If you do, return Masked Admirers from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Merrow Commerce
    public class MerrowCommerce : MagicCard
    {
        public MerrowCommerce()
        {
            Name = "Merrow Commerce";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Tribal Enchantment - Merfolk";
            Text = "At the beginning of your end step, untap all Merfolk you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Merrow Harbinger
    public class MerrowHarbinger : MagicCard
    {
        public MerrowHarbinger()
        {
            Name = "Merrow Harbinger";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "2/3";
            Type = "Creature - Merfolk Wizard";
            Text = "Islandwalk;^When Merrow Harbinger enters the battlefield, you may search your library for a Merfolk card, reveal it, then shuffle your library and put that card on top of it.";
            Flavor = "";
        }
    }
    # endregion

    # region Merrow Reejerey
    public class MerrowReejerey : MagicCard
    {
        public MerrowReejerey()
        {
            Name = "Merrow Reejerey";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "2/2";
            Type = "Creature - Merfolk Soldier";
            Text = "Other Merfolk creatures you control get +1/+1.;^Whenever you cast a Merfolk spell, you may tap or untap target permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Militia's Pride
    public class MilitiasPride : MagicCard
    {
        public MilitiasPride()
        {
            Name = "Militia's Pride";
            Edition = "LRW";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Tribal Enchantment - Kithkin";
            Text = "Whenever a nontoken creature you control attacks, you may pay %W. If you do, put a 1/1 white Kithkin Soldier creature token onto the battlefield tapped and attacking.";
            Flavor = "";
        }
    }
    # endregion

    # region Mirror Entity
    public class MirrorEntity : MagicCard
    {
        public MirrorEntity()
        {
            Name = "Mirror Entity";
            Edition = "LRW";
            Rarity = "R";
            Color = "W";
            Cost = "2W";
            PT = "1/1";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^%X: Creatures you control become X/X and gain all creature types until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Mistbind Clique
    public class MistbindClique : MagicCard
    {
        public MistbindClique()
        {
            Name = "Mistbind Clique";
            Edition = "LRW";
            Rarity = "R";
            Color = "U";
            Cost = "3U";
            PT = "4/4";
            Type = "Creature - Faerie Wizard";
            Text = "Flash;^Flying;^Champion a Faerie @(When this enters the battlefield, sacrifice it unless you exile another Faerie you control. When this leaves the battlefield, that card returns to the battlefield.)@;^When a Faerie is championed with Mistbind Clique, tap all lands target player controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Moonglove Extract
    public class MoongloveExtract : MagicCard
    {
        public MoongloveExtract()
        {
            Name = "Moonglove Extract";
            Edition = "LRW";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Sacrifice Moonglove Extract: Moonglove Extract deals 2 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Moonglove Winnower
    public class MoongloveWinnower : MagicCard
    {
        public MoongloveWinnower()
        {
            Name = "Moonglove Winnower";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "2/3";
            Type = "Creature - Elf Rogue";
            Text = "Deathtouch @(Any amount of damage this deals to a creature is enough to destroy it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Mosswort Bridge
    public class MosswortBridge : MagicCard
    {
        public MosswortBridge()
        {
            Name = "Mosswort Bridge";
            Edition = "LRW";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Hideaway @(This land enters the battlefield tapped. When it does, look at the top four cards of your library, exile one face down, then put the rest on the bottom of your library.)@;^%T: Add %G to your mana pool.;^%G, %T: You may play the exiled card without paying its mana cost if creatures you control have total power 10 or greater.";
            Flavor = "";
        }
    }
    # endregion

    # region Mountain
    public class MountainLRW : MagicCard
    {
        public MountainLRW()
        {
            Name = "Mountain";
            Edition = "LRW";
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

    # region Mournwhelk
    public class Mournwhelk : MagicCard
    {
        public Mournwhelk()
        {
            Name = "Mournwhelk";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "6B";
            PT = "3/3";
            Type = "Creature - Elemental";
            Text = "When Mournwhelk enters the battlefield, target player discards two cards.;^Evoke %3%B @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Mudbutton Torchrunner
    public class MudbuttonTorchrunner : MagicCard
    {
        public MudbuttonTorchrunner()
        {
            Name = "Mudbutton Torchrunner";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "1/1";
            Type = "Creature - Goblin Warrior";
            Text = "When Mudbutton Torchrunner dies, it deals 3 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Mulldrifter
    public class Mulldrifter : MagicCard
    {
        public Mulldrifter()
        {
            Name = "Mulldrifter";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "4U";
            PT = "2/2";
            Type = "Creature - Elemental";
            Text = "Flying;^When Mulldrifter enters the battlefield, draw two cards.;^Evoke %2%U @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Nameless Inversion
    public class NamelessInversion : MagicCard
    {
        public NamelessInversion()
        {
            Name = "Nameless Inversion";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Tribal Instant - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^Target creature gets +3/-3 and loses all creature types until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Nath of the Gilt-Leaf
    public class NathoftheGiltLeaf : MagicCard
    {
        public NathoftheGiltLeaf()
        {
            Name = "Nath of the Gilt-Leaf";
            Edition = "LRW";
            Rarity = "R";
            Color = "Gld";
            Cost = "3BG";
            PT = "4/4";
            Type = "Legendary Creature - Elf Warrior";
            Text = "At the beginning of your upkeep, you may have target opponent discard a card at random.;^Whenever an opponent discards a card, you may put a 1/1 green Elf Warrior creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Nath's Buffoon
    public class NathsBuffoon : MagicCard
    {
        public NathsBuffoon()
        {
            Name = "Nath's Buffoon";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "1/1";
            Type = "Creature - Goblin Rogue";
            Text = "Protection from Elves";
            Flavor = "";
        }
    }
    # endregion

    # region Nath's Elite
    public class NathsElite : MagicCard
    {
        public NathsElite()
        {
            Name = "Nath's Elite";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "4G";
            PT = "4/2";
            Type = "Creature - Elf Warrior";
            Text = "All creatures able to block Nath�s Elite do so.;^When Nath�s Elite enters the battlefield, clash with an opponent. If you win, put a +1/+1 counter on Nath�s Elite. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Neck Snap
    public class NeckSnap : MagicCard
    {
        public NeckSnap()
        {
            Name = "Neck Snap";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Instant";
            Text = "Destroy target attacking or blocking creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Nectar Faerie
    public class NectarFaerie : MagicCard
    {
        public NectarFaerie()
        {
            Name = "Nectar Faerie";
            Edition = "LRW";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "1/1";
            Type = "Creature - Faerie Wizard";
            Text = "Flying;^%B, %T: Target Faerie or Elf gains lifelink until end of turn. @(Damage dealt by the creature also causes its controller to gain that much life.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Needle Drop
    public class NeedleDrop : MagicCard
    {
        public NeedleDrop()
        {
            Name = "Needle Drop";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Needle Drop deals 1 damage to target creature or player that was dealt damage this turn.^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Nettlevine Blight
    public class NettlevineBlight : MagicCard
    {
        public NettlevineBlight()
        {
            Name = "Nettlevine Blight";
            Edition = "LRW";
            Rarity = "R";
            Color = "B";
            Cost = "4BB";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature or land;^Enchanted permanent has �At the beginning of your end step, sacrifice this permanent and attach Nettlevine Blight to a creature or land you control.�";
            Flavor = "";
        }
    }
    # endregion

    # region Nightshade Stinger
    public class NightshadeStinger : MagicCard
    {
        public NightshadeStinger()
        {
            Name = "Nightshade Stinger";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Faerie Rogue";
            Text = "Flying^Nightshade Stinger can�t block.";
            Flavor = "";
        }
    }
    # endregion

    # region Nova Chaser
    public class NovaChaser : MagicCard
    {
        public NovaChaser()
        {
            Name = "Nova Chaser";
            Edition = "LRW";
            Rarity = "R";
            Color = "R";
            Cost = "3R";
            PT = "10/2";
            Type = "Creature - Elemental Warrior";
            Text = "Trample;^Champion an Elemental @(When this enters the battlefield, sacrifice it unless you exile another Elemental you control. When this leaves the battlefield, that card returns to the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Oaken Brawler
    public class OakenBrawler : MagicCard
    {
        public OakenBrawler()
        {
            Name = "Oaken Brawler";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "2/4";
            Type = "Creature - Treefolk Warrior";
            Text = "When Oaken Brawler enters the battlefield, clash with an opponent. If you win, put a +1/+1 counter on Oaken Brawler. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Oakgnarl Warrior
    public class OakgnarlWarrior : MagicCard
    {
        public OakgnarlWarrior()
        {
            Name = "Oakgnarl Warrior";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "5GG";
            PT = "5/7";
            Type = "Creature - Treefolk Warrior";
            Text = "Vigilance, trample";
            Flavor = "";
        }
    }
    # endregion

    # region Oblivion Ring
    public class OblivionRing : MagicCard
    {
        public OblivionRing()
        {
            Name = "Oblivion Ring";
            Edition = "LRW";
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

    # region Oona's Prowler
    public class OonasProwler : MagicCard
    {
        public OonasProwler()
        {
            Name = "Oona's Prowler";
            Edition = "LRW";
            Rarity = "R";
            Color = "B";
            Cost = "1B";
            PT = "3/1";
            Type = "Creature - Faerie Rogue";
            Text = "Flying;^Discard a card: Oona�s Prowler gets -2/-0 until end of turn. Any player may activate this ability.";
            Flavor = "";
        }
    }
    # endregion

    # region Paperfin Rascal
    public class PaperfinRascal : MagicCard
    {
        public PaperfinRascal()
        {
            Name = "Paperfin Rascal";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "2/2";
            Type = "Creature - Merfolk Rogue";
            Text = "When Paperfin Rascal enters the battlefield, clash with an opponent. If you win, put a +1/+1 counter on Paperfin Rascal. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Peppersmoke
    public class Peppersmoke : MagicCard
    {
        public Peppersmoke()
        {
            Name = "Peppersmoke";
            Edition = "LRW";
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

    # region Pestermite
    public class Pestermite : MagicCard
    {
        public Pestermite()
        {
            Name = "Pestermite";
            Edition = "LRW";
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

    # region Plains
    public class PlainsLRW : MagicCard
    {
        public PlainsLRW()
        {
            Name = "Plains";
            Edition = "LRW";
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

    # region Plover Knights
    public class PloverKnights : MagicCard
    {
        public PloverKnights()
        {
            Name = "Plover Knights";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "3WW";
            PT = "3/3";
            Type = "Creature - Kithkin Knight";
            Text = "Flying, first strike";
            Flavor = "";
        }
    }
    # endregion

    # region Pollen Lullaby
    public class PollenLullaby : MagicCard
    {
        public PollenLullaby()
        {
            Name = "Pollen Lullaby";
            Edition = "LRW";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Prevent all combat damage that would be dealt this turn. Clash with an opponent. If you win, creatures that player controls don�t untap during the player�s next untap step. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Ponder
    public class Ponder : MagicCard
    {
        public Ponder()
        {
            Name = "Ponder";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Sorcery";
            Text = "Look at the top three cards of your library, then put them back in any order. You may shuffle your library.;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Primal Command
    public class PrimalCommand : MagicCard
    {
        public PrimalCommand()
        {
            Name = "Primal Command";
            Edition = "LRW";
            Rarity = "R";
            Color = "G";
            Cost = "3GG";
            PT = "";
            Type = "Sorcery";
            Text = "Choose two � Target player gains 7 life; or put target noncreature permanent on top of its owner�s library; or target player shuffles his or her graveyard into his or her library; or search your library for a creature card, reveal it, put it into your hand, then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Profane Command
    public class ProfaneCommand : MagicCard
    {
        public ProfaneCommand()
        {
            Name = "Profane Command";
            Edition = "LRW";
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

    # region Protective Bubble
    public class ProtectiveBubble : MagicCard
    {
        public ProtectiveBubble()
        {
            Name = "Protective Bubble";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature can�t be blocked and has shroud. @(It can�t be the target of spells or abilities.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Prowess of the Fair
    public class ProwessoftheFair : MagicCard
    {
        public ProwessoftheFair()
        {
            Name = "Prowess of the Fair";
            Edition = "LRW";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Tribal Enchantment - Elf";
            Text = "Whenever another nontoken Elf is put into your graveyard from the battlefield, you may put a 1/1 green Elf Warrior creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Purity
    public class Purity : MagicCard
    {
        public Purity()
        {
            Name = "Purity";
            Edition = "LRW";
            Rarity = "R";
            Color = "W";
            Cost = "3WWW";
            PT = "6/6";
            Type = "Creature - Elemental Incarnation";
            Text = "Flying;^If noncombat damage would be dealt to you, prevent that damage. You gain life equal to the damage prevented this way.;^When Purity is put into a graveyard from anywhere, shuffle it into its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Quill-Slinger Boggart
    public class QuillSlingerBoggart : MagicCard
    {
        public QuillSlingerBoggart()
        {
            Name = "Quill-Slinger Boggart";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "3/2";
            Type = "Creature - Goblin Warrior";
            Text = "Whenever a player casts a Kithkin spell, you may have target player lose 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Rebellion of the Flamekin
    public class RebellionoftheFlamekin : MagicCard
    {
        public RebellionoftheFlamekin()
        {
            Name = "Rebellion of the Flamekin";
            Edition = "LRW";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Tribal Enchantment - Elemental";
            Text = "Whenever you clash, you may pay %1. If you do, put a 3/1 red Elemental Shaman creature token onto the battlefield. If you won, that token gains haste until end of turn. @(This ability triggers after the clash ends.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Rings of Brighthearth
    public class RingsofBrighthearth : MagicCard
    {
        public RingsofBrighthearth()
        {
            Name = "Rings of Brighthearth";
            Edition = "LRW";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "Whenever you activate an ability, if it isn�t a mana ability, you may pay %2. If you do, copy that ability. You may choose new targets for the copy.";
            Flavor = "";
        }
    }
    # endregion

    # region Ringskipper
    public class Ringskipper : MagicCard
    {
        public Ringskipper()
        {
            Name = "Ringskipper";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Faerie Wizard";
            Text = "Flying;^When Ringskipper dies, clash with an opponent. If you win, return Ringskipper to its owner�s hand. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Rootgrapple
    public class Rootgrapple : MagicCard
    {
        public Rootgrapple()
        {
            Name = "Rootgrapple";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "4G";
            PT = "";
            Type = "Tribal Instant - Treefolk";
            Text = "Destroy target noncreature permanent. If you control a Treefolk, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Runed Stalactite
    public class RunedStalactite : MagicCard
    {
        public RunedStalactite()
        {
            Name = "Runed Stalactite";
            Edition = "LRW";
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

    # region Scarred Vinebreeder
    public class ScarredVinebreeder : MagicCard
    {
        public ScarredVinebreeder()
        {
            Name = "Scarred Vinebreeder";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "1/1";
            Type = "Creature - Elf Shaman";
            Text = "%2%B, Exile an Elf card from your graveyard: Scarred Vinebreeder gets +3/+3 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Scattering Stroke
    public class ScatteringStroke : MagicCard
    {
        public ScatteringStroke()
        {
            Name = "Scattering Stroke";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "2UU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell. Clash with an opponent. If you win, at the beginning of your next main phase, you may add %X to your mana pool, where X is that spell�s converted mana cost. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Scion of Oona
    public class ScionofOona : MagicCard
    {
        public ScionofOona()
        {
            Name = "Scion of Oona";
            Edition = "LRW";
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

    # region Secluded Glen
    public class SecludedGlen : MagicCard
    {
        public SecludedGlen()
        {
            Name = "Secluded Glen";
            Edition = "LRW";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "As Secluded Glen enters the battlefield, you may reveal a Faerie card from your hand. If you don�t, Secluded Glen enters the battlefield tapped.;^%T: Add %U or %B to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Seedguide Ash
    public class SeedguideAsh : MagicCard
    {
        public SeedguideAsh()
        {
            Name = "Seedguide Ash";
            Edition = "LRW";
            Rarity = "U";
            Color = "G";
            Cost = "4G";
            PT = "4/4";
            Type = "Creature - Treefolk Druid";
            Text = "When Seedguide Ash dies, you may search your library for up to three Forest cards and put them onto the battlefield tapped. If you do, shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Sentinels of Glen Elendra
    public class SentinelsofGlenElendra : MagicCard
    {
        public SentinelsofGlenElendra()
        {
            Name = "Sentinels of Glen Elendra";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "3U";
            PT = "2/3";
            Type = "Creature - Faerie Soldier";
            Text = "Flash^Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Sentry Oak
    public class SentryOak : MagicCard
    {
        public SentryOak()
        {
            Name = "Sentry Oak";
            Edition = "LRW";
            Rarity = "U";
            Color = "W";
            Cost = "4W";
            PT = "3/5";
            Type = "Creature - Treefolk Warrior";
            Text = "Defender^At the beginning of combat on your turn, you may clash with an opponent. If you win, Sentry Oak gets +2/+0 and loses defender until end of turn. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Shapesharer
    public class Shapesharer : MagicCard
    {
        public Shapesharer()
        {
            Name = "Shapesharer";
            Edition = "LRW";
            Rarity = "R";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^%2%U: Target Shapeshifter becomes a copy of target creature until your next turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Shelldock Isle
    public class ShelldockIsle : MagicCard
    {
        public ShelldockIsle()
        {
            Name = "Shelldock Isle";
            Edition = "LRW";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Hideaway @(This land enters the battlefield tapped. When it does, look at the top four cards of your library, exile one face down, then put the rest on the bottom of your library.)@;^%T: Add %U to your mana pool.;^%U, %T: You may play the exiled card without paying its mana cost if a library has twenty or fewer cards in it.";
            Flavor = "";
        }
    }
    # endregion

    # region Shields of Velis Vel
    public class ShieldsofVelisVel : MagicCard
    {
        public ShieldsofVelisVel()
        {
            Name = "Shields of Velis Vel";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Tribal Instant - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^Creatures target player controls get +0/+1 and gain all creature types until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Shimmering Grotto
    public class ShimmeringGrottoLRW : MagicCard
    {
        public ShimmeringGrottoLRW()
        {
            Name = "Shimmering Grotto";
            Edition = "LRW";
            Rarity = "C";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.^%1, %T: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Shriekmaw
    public class Shriekmaw : MagicCard
    {
        public Shriekmaw()
        {
            Name = "Shriekmaw";
            Edition = "LRW";
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

    # region Silvergill Adept
    public class SilvergillAdept : MagicCard
    {
        public SilvergillAdept()
        {
            Name = "Silvergill Adept";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "1U";
            PT = "2/1";
            Type = "Creature - Merfolk Wizard";
            Text = "As an additional cost to cast Silvergill Adept, reveal a Merfolk card from your hand or pay %3.;^When Silvergill Adept enters the battlefield, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Silvergill Douser
    public class SilvergillDouser : MagicCard
    {
        public SilvergillDouser()
        {
            Name = "Silvergill Douser";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Merfolk Wizard";
            Text = "%T: Target creature gets -X/-0 until end of turn, where X is the number of Merfolk and/or Faeries you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Skeletal Changeling
    public class SkeletalChangeling : MagicCard
    {
        public SkeletalChangeling()
        {
            Name = "Skeletal Changeling";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "1/1";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^%1%B: Regenerate Skeletal Changeling.";
            Flavor = "";
        }
    }
    # endregion

    # region Smokebraider
    public class Smokebraider : MagicCard
    {
        public Smokebraider()
        {
            Name = "Smokebraider";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "1/1";
            Type = "Creature - Elemental Shaman";
            Text = "%T: Add two mana in any combination of colors to your mana pool. Spend this mana only to cast Elemental spells or activate abilities of Elementals.";
            Flavor = "";
        }
    }
    # endregion

    # region Soaring Hope
    public class SoaringHope : MagicCard
    {
        public SoaringHope()
        {
            Name = "Soaring Hope";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "4W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^When Soaring Hope enters the battlefield, you gain 3 life.;^Enchanted creature has flying.;^%W: Put Soaring Hope on top of its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Soulbright Flamekin
    public class SoulbrightFlamekin : MagicCard
    {
        public SoulbrightFlamekin()
        {
            Name = "Soulbright Flamekin";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "2/1";
            Type = "Creature - Elemental Shaman";
            Text = "%2: Target creature gains trample until end of turn. If this is the third time this ability has resolved this turn, you may add %R%R%R%R%R%R%R%R to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Sower of Temptation
    public class SowerofTemptation : MagicCard
    {
        public SowerofTemptation()
        {
            Name = "Sower of Temptation";
            Edition = "LRW";
            Rarity = "R";
            Color = "U";
            Cost = "2UU";
            PT = "2/2";
            Type = "Creature - Faerie Wizard";
            Text = "Flying;^When Sower of Temptation enters the battlefield, gain control of target creature for as long as Sower of Temptation remains on the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Spellstutter Sprite
    public class SpellstutterSprite : MagicCard
    {
        public SpellstutterSprite()
        {
            Name = "Spellstutter Sprite";
            Edition = "LRW";
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

    # region Spiderwig Boggart
    public class SpiderwigBoggart : MagicCard
    {
        public SpiderwigBoggart()
        {
            Name = "Spiderwig Boggart";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Goblin Shaman";
            Text = "When Spiderwig Boggart enters the battlefield, target creature gains fear until end of turn. @(It can�t be blocked except by artifact creatures and/or black creatures.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Spinerock Knoll
    public class SpinerockKnoll : MagicCard
    {
        public SpinerockKnoll()
        {
            Name = "Spinerock Knoll";
            Edition = "LRW";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Hideaway @(This land enters the battlefield tapped. When it does, look at the top four cards of your library, exile one face down, then put the rest on the bottom of your library.)@;^%T: Add %R to your mana pool.;^%R, %T: You may play the exiled card without paying its mana cost if an opponent was dealt 7 or more damage this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Spring Cleaning
    public class SpringCleaning : MagicCard
    {
        public SpringCleaning()
        {
            Name = "Spring Cleaning";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Destroy target enchantment. Clash with an opponent. If you win, destroy all enchantments your opponents control. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Springjack Knight
    public class SpringjackKnight : MagicCard
    {
        public SpringjackKnight()
        {
            Name = "Springjack Knight";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "2/1";
            Type = "Creature - Kithkin Knight";
            Text = "Whenever Springjack Knight attacks, clash with an opponent. If you win, target creature gains double strike until end of turn. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Springleaf Drum
    public class SpringleafDrumLRW : MagicCard
    {
        public SpringleafDrumLRW()
        {
            Name = "Springleaf Drum";
            Edition = "LRW";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%T, Tap an untapped creature you control: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Squeaking Pie Sneak
    public class SqueakingPieSneak : MagicCard
    {
        public SqueakingPieSneak()
        {
            Name = "Squeaking Pie Sneak";
            Edition = "LRW";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "2/2";
            Type = "Creature - Goblin Rogue";
            Text = "As an additional cost to cast Squeaking Pie Sneak, reveal a Goblin card from your hand or pay %3.;^Fear @(This creature can�t be blocked except by artifact creatures and/or black creatures.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Stinkdrinker Daredevil
    public class StinkdrinkerDaredevil : MagicCard
    {
        public StinkdrinkerDaredevil()
        {
            Name = "Stinkdrinker Daredevil";
            Edition = "LRW";
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

    # region Stonybrook Angler
    public class StonybrookAngler : MagicCard
    {
        public StonybrookAngler()
        {
            Name = "Stonybrook Angler";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "1/2";
            Type = "Creature - Merfolk Wizard";
            Text = "%1%U, %T: You may tap or untap target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Streambed Aquitects
    public class StreambedAquitects : MagicCard
    {
        public StreambedAquitects()
        {
            Name = "Streambed Aquitects";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "1UU";
            PT = "2/3";
            Type = "Creature - Merfolk Scout";
            Text = "%T: Target Merfolk creature gets +1/+1 and gains islandwalk until end of turn.^%T: Target land becomes an Island until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Summon the School
    public class SummontheSchool : MagicCard
    {
        public SummontheSchool()
        {
            Name = "Summon the School";
            Edition = "LRW";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Tribal Sorcery - Merfolk";
            Text = "Put two 1/1 blue Merfolk Wizard creature tokens onto the battlefield.;^Tap four untapped Merfolk you control: Return Summon the School from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Sunrise Sovereign
    public class SunriseSovereign : MagicCard
    {
        public SunriseSovereign()
        {
            Name = "Sunrise Sovereign";
            Edition = "LRW";
            Rarity = "R";
            Color = "R";
            Cost = "5R";
            PT = "5/5";
            Type = "Creature - Giant Warrior";
            Text = "Other Giant creatures you control get +2/+2 and have trample.";
            Flavor = "";
        }
    }
    # endregion

    # region Surge of Thoughtweft
    public class SurgeofThoughtweft : MagicCard
    {
        public SurgeofThoughtweft()
        {
            Name = "Surge of Thoughtweft";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Tribal Instant - Kithkin";
            Text = "Creatures you control get +1/+1 until end of turn. If you control a Kithkin, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Surgespanner
    public class Surgespanner : MagicCard
    {
        public Surgespanner()
        {
            Name = "Surgespanner";
            Edition = "LRW";
            Rarity = "R";
            Color = "U";
            Cost = "2UU";
            PT = "2/2";
            Type = "Creature - Merfolk Wizard";
            Text = "Whenever Surgespanner becomes tapped, you may pay %1%U. If you do, return target permanent to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Swamp
    public class SwampLRW : MagicCard
    {
        public SwampLRW()
        {
            Name = "Swamp";
            Edition = "LRW";
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

    # region Sygg, River Guide
    public class SyggRiverGuide : MagicCard
    {
        public SyggRiverGuide()
        {
            Name = "Sygg, River Guide";
            Edition = "LRW";
            Rarity = "R";
            Color = "Gld";
            Cost = "WU";
            PT = "2/2";
            Type = "Legendary Creature - Merfolk Wizard";
            Text = "Islandwalk^%1%W: Target Merfolk you control gains protection from the color of your choice until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Sylvan Echoes
    public class SylvanEchoes : MagicCard
    {
        public SylvanEchoes()
        {
            Name = "Sylvan Echoes";
            Edition = "LRW";
            Rarity = "U";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever you clash and win, you may draw a card. @(This ability triggers after the clash ends.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Tar Pitcher
    public class TarPitcher : MagicCard
    {
        public TarPitcher()
        {
            Name = "Tar Pitcher";
            Edition = "LRW";
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

    # region Tarfire
    public class Tarfire : MagicCard
    {
        public Tarfire()
        {
            Name = "Tarfire";
            Edition = "LRW";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Tribal Instant - Goblin";
            Text = "Tarfire deals 2 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Thieving Sprite
    public class ThievingSprite : MagicCard
    {
        public ThievingSprite()
        {
            Name = "Thieving Sprite";
            Edition = "LRW";
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

    # region Thorn of Amethyst
    public class ThornofAmethyst : MagicCard
    {
        public ThornofAmethyst()
        {
            Name = "Thorn of Amethyst";
            Edition = "LRW";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "Noncreature spells cost %1 more to cast.";
            Flavor = "";
        }
    }
    # endregion

    # region Thorntooth Witch
    public class ThorntoothWitch : MagicCard
    {
        public ThorntoothWitch()
        {
            Name = "Thorntooth Witch";
            Edition = "LRW";
            Rarity = "U";
            Color = "B";
            Cost = "5B";
            PT = "3/4";
            Type = "Creature - Treefolk Shaman";
            Text = "Whenever you cast a Treefolk spell, you may have target creature get +3/-3 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Thoughtseize
    public class ThoughtseizeLRW : MagicCard
    {
        public ThoughtseizeLRW()
        {
            Name = "Thoughtseize";
            Edition = "LRW";
            Rarity = "R";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Sorcery";
            Text = "Target player reveals his or her hand. You choose a nonland card from it. That player discards that card. You lose 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Thoughtweft Trio
    public class ThoughtweftTrio : MagicCard
    {
        public ThoughtweftTrio()
        {
            Name = "Thoughtweft Trio";
            Edition = "LRW";
            Rarity = "R";
            Color = "W";
            Cost = "2WW";
            PT = "5/5";
            Type = "Creature - Kithkin Soldier";
            Text = "First strike, vigilance;^Champion a Kithkin @(When this enters the battlefield, sacrifice it unless you exile another Kithkin you control. When this leaves the battlefield, that card returns to the battlefield.)@;^Thoughtweft Trio can block any number of creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Thousand-Year Elixir
    public class ThousandYearElixir : MagicCard
    {
        public ThousandYearElixir()
        {
            Name = "Thousand-Year Elixir";
            Edition = "LRW";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact";
            Text = "You may activate abilities of creatures you control as though those creatures had haste.;^%1, %T: Untap target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Thundercloud Shaman
    public class ThundercloudShaman : MagicCard
    {
        public ThundercloudShaman()
        {
            Name = "Thundercloud Shaman";
            Edition = "LRW";
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

    # region Tideshaper Mystic
    public class TideshaperMystic : MagicCard
    {
        public TideshaperMystic()
        {
            Name = "Tideshaper Mystic";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "1/1";
            Type = "Creature - Merfolk Wizard";
            Text = "%T: Target land becomes the basic land type of your choice until end of turn. Activate this ability only during your turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Timber Protector
    public class TimberProtector : MagicCard
    {
        public TimberProtector()
        {
            Name = "Timber Protector";
            Edition = "LRW";
            Rarity = "R";
            Color = "G";
            Cost = "4G";
            PT = "4/6";
            Type = "Creature - Treefolk Warrior";
            Text = "Other Treefolk creatures you control get +1/+1.;^Other Treefolk and Forests you control have indestructible.";
            Flavor = "";
        }
    }
    # endregion

    # region Treefolk Harbinger
    public class TreefolkHarbinger : MagicCard
    {
        public TreefolkHarbinger()
        {
            Name = "Treefolk Harbinger";
            Edition = "LRW";
            Rarity = "U";
            Color = "G";
            Cost = "G";
            PT = "0/3";
            Type = "Creature - Treefolk Druid";
            Text = "When Treefolk Harbinger enters the battlefield, you may search your library for a Treefolk or Forest card, reveal it, then shuffle your library and put that card on top of it.";
            Flavor = "";
        }
    }
    # endregion

    # region Triclopean Sight
    public class TriclopeanSight : MagicCard
    {
        public TriclopeanSight()
        {
            Name = "Triclopean Sight";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Flash;^Enchant creature;^When Triclopean Sight enters the battlefield, untap enchanted creature.;^Enchanted creature gets +1/+1 and has vigilance.";
            Flavor = "";
        }
    }
    # endregion

    # region Turtleshell Changeling
    public class TurtleshellChangeling : MagicCard
    {
        public TurtleshellChangeling()
        {
            Name = "Turtleshell Changeling";
            Edition = "LRW";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "1/4";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^%1%U: Switch Turtleshell Changeling�s power and toughness until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Twinning Glass
    public class TwinningGlass : MagicCard
    {
        public TwinningGlass()
        {
            Name = "Twinning Glass";
            Edition = "LRW";
            Rarity = "R";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%1, %T: You may cast a nonland card from your hand without paying its mana cost if it has the same name as a spell that was cast this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Veteran of the Depths
    public class VeteranoftheDepths : MagicCard
    {
        public VeteranoftheDepths()
        {
            Name = "Veteran of the Depths";
            Edition = "LRW";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "2/2";
            Type = "Creature - Merfolk Soldier";
            Text = "Whenever Veteran of the Depths becomes tapped, you may put a +1/+1 counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Vigor
    public class Vigor : MagicCard
    {
        public Vigor()
        {
            Name = "Vigor";
            Edition = "LRW";
            Rarity = "R";
            Color = "G";
            Cost = "3GGG";
            PT = "6/6";
            Type = "Creature - Elemental Incarnation";
            Text = "Trample^If damage would be dealt to a creature you control other than Vigor, prevent that damage. Put a +1/+1 counter on that creature for each 1 damage prevented this way.^When Vigor is put into a graveyard from anywhere, shuffle it into its owner�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Vivid Crag
    public class VividCrag : MagicCard
    {
        public VividCrag()
        {
            Name = "Vivid Crag";
            Edition = "LRW";
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
    public class VividCreek : MagicCard
    {
        public VividCreek()
        {
            Name = "Vivid Creek";
            Edition = "LRW";
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
    public class VividGrove : MagicCard
    {
        public VividGrove()
        {
            Name = "Vivid Grove";
            Edition = "LRW";
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
    public class VividMarsh : MagicCard
    {
        public VividMarsh()
        {
            Name = "Vivid Marsh";
            Edition = "LRW";
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
    public class VividMeadow : MagicCard
    {
        public VividMeadow()
        {
            Name = "Vivid Meadow";
            Edition = "LRW";
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

    # region Wanderer's Twig
    public class WanderersTwig : MagicCard
    {
        public WanderersTwig()
        {
            Name = "Wanderer's Twig";
            Edition = "LRW";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "";
            Type = "Artifact";
            Text = "%1, Sacrifice Wanderer�s Twig: Search your library for a basic land card, reveal it, and put it into your hand. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Wanderwine Hub
    public class WanderwineHub : MagicCard
    {
        public WanderwineHub()
        {
            Name = "Wanderwine Hub";
            Edition = "LRW";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "As Wanderwine Hub enters the battlefield, you may reveal a Merfolk card from your hand. If you don�t, Wanderwine Hub enters the battlefield tapped.;^%T: Add %W or %U to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Wanderwine Prophets
    public class WanderwineProphets : MagicCard
    {
        public WanderwineProphets()
        {
            Name = "Wanderwine Prophets";
            Edition = "LRW";
            Rarity = "R";
            Color = "U";
            Cost = "4UU";
            PT = "4/4";
            Type = "Creature - Merfolk Wizard";
            Text = "Champion a Merfolk @(When this enters the battlefield, sacrifice it unless you exile another Merfolk you control. When this leaves the battlefield, that card returns to the battlefield.)@;^Whenever Wanderwine Prophets deals combat damage to a player, you may sacrifice a Merfolk. If you do, take an extra turn after this one.";
            Flavor = "";
        }
    }
    # endregion

    # region Warren Pilferers
    public class WarrenPilferers : MagicCard
    {
        public WarrenPilferers()
        {
            Name = "Warren Pilferers";
            Edition = "LRW";
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

    # region Warren-Scourge Elf
    public class WarrenScourgeElf : MagicCard
    {
        public WarrenScourgeElf()
        {
            Name = "Warren-Scourge Elf";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "1/1";
            Type = "Creature - Elf Warrior";
            Text = "Protection from Goblins";
            Flavor = "";
        }
    }
    # endregion

    # region Weed Strangle
    public class WeedStrangle : MagicCard
    {
        public WeedStrangle()
        {
            Name = "Weed Strangle";
            Edition = "LRW";
            Rarity = "C";
            Color = "B";
            Cost = "3BB";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target creature. Clash with an opponent. If you win, you gain life equal to that creature�s toughness. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wellgabber Apothecary
    public class WellgabberApothecary : MagicCard
    {
        public WellgabberApothecary()
        {
            Name = "Wellgabber Apothecary";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "4W";
            PT = "2/3";
            Type = "Creature - Merfolk Cleric";
            Text = "%1%W: Prevent all damage that would be dealt to target tapped Merfolk or Kithkin creature this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Whirlpool Whelm
    public class WhirlpoolWhelm : MagicCard
    {
        public WhirlpoolWhelm()
        {
            Name = "Whirlpool Whelm";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Clash with an opponent, then return target creature to its owner�s hand. If you win, you may put that creature on top of its owner�s library instead. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wild Ricochet
    public class WildRicochetLRW : MagicCard
    {
        public WildRicochetLRW()
        {
            Name = "Wild Ricochet";
            Edition = "LRW";
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

    # region Windbrisk Heights
    public class WindbriskHeights : MagicCard
    {
        public WindbriskHeights()
        {
            Name = "Windbrisk Heights";
            Edition = "LRW";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "Hideaway @(This land enters the battlefield tapped. When it does, look at the top four cards of your library, exile one face down, then put the rest on the bottom of your library.)@;^%T: Add %W to your mana pool.;^%W, %T: You may play the exiled card without paying its mana cost if you attacked with three or more creatures this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Wings of Velis Vel
    public class WingsofVelisVel : MagicCard
    {
        public WingsofVelisVel()
        {
            Name = "Wings of Velis Vel";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Tribal Instant - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^Target creature becomes 4/4, gains all creature types, and gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Wispmare
    public class Wispmare : MagicCard
    {
        public Wispmare()
        {
            Name = "Wispmare";
            Edition = "LRW";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "1/3";
            Type = "Creature - Elemental";
            Text = "Flying;^When Wispmare enters the battlefield, destroy target enchantment.;^Evoke %W @(You may cast this spell for its evoke cost. If you do, it�s sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wizened Cenn
    public class WizenedCenn : MagicCard
    {
        public WizenedCenn()
        {
            Name = "Wizened Cenn";
            Edition = "LRW";
            Rarity = "U";
            Color = "W";
            Cost = "WW";
            PT = "2/2";
            Type = "Creature - Kithkin Cleric";
            Text = "Other Kithkin creatures you control get +1/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Woodland Changeling
    public class WoodlandChangeling : MagicCard
    {
        public WoodlandChangeling()
        {
            Name = "Woodland Changeling";
            Edition = "LRW";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "2/2";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Woodland Guidance
    public class WoodlandGuidance : MagicCard
    {
        public WoodlandGuidance()
        {
            Name = "Woodland Guidance";
            Edition = "LRW";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Sorcery";
            Text = "Return target card from your graveyard to your hand. Clash with an opponent. If you win, untap all Forests you control. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@;^Exile Woodland Guidance.";
            Flavor = "";
        }
    }
    # endregion

    # region Wort, Boggart Auntie
    public class WortBoggartAuntie : MagicCard
    {
        public WortBoggartAuntie()
        {
            Name = "Wort, Boggart Auntie";
            Edition = "LRW";
            Rarity = "R";
            Color = "Gld";
            Cost = "2BR";
            PT = "3/3";
            Type = "Legendary Creature - Goblin Shaman";
            Text = "Fear @(This creature can�t be blocked except by artifact creatures and/or black creatures.)@;^At the beginning of your upkeep, you may return target Goblin card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Wren's Run Packmaster
    public class WrensRunPackmaster : MagicCard
    {
        public WrensRunPackmaster()
        {
            Name = "Wren's Run Packmaster";
            Edition = "LRW";
            Rarity = "R";
            Color = "G";
            Cost = "3G";
            PT = "5/5";
            Type = "Creature - Elf Warrior";
            Text = "Champion an Elf @(When this enters the battlefield, sacrifice it unless you exile another Elf you control. When this leaves the battlefield, that card returns to the battlefield.)@;^%2%G: Put a 2/2 green Wolf creature token onto the battlefield.;^Each Wolf you control has deathtouch. @(Any amount of damage it deals to a creature is enough to destroy that creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wren's Run Vanquisher
    public class WrensRunVanquisher : MagicCard
    {
        public WrensRunVanquisher()
        {
            Name = "Wren's Run Vanquisher";
            Edition = "LRW";
            Rarity = "U";
            Color = "G";
            Cost = "1G";
            PT = "3/3";
            Type = "Creature - Elf Warrior";
            Text = "As an additional cost to cast Wren�s Run Vanquisher, reveal an Elf card from your hand or pay %3.;^Deathtouch @(Any amount of damage this deals to a creature is enough to destroy it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wydwen, the Biting Gale
    public class WydwentheBitingGale : MagicCard
    {
        public WydwentheBitingGale()
        {
            Name = "Wydwen, the Biting Gale";
            Edition = "LRW";
            Rarity = "R";
            Color = "Gld";
            Cost = "2UB";
            PT = "3/3";
            Type = "Legendary Creature - Faerie Wizard";
            Text = "Flash^Flying^%U%B, Pay 1 life: Return Wydwen, the Biting Gale to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Zephyr Net
    public class ZephyrNet : MagicCard
    {
        public ZephyrNet()
        {
            Name = "Zephyr Net";
            Edition = "LRW";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^Enchanted creature has defender and flying.";
            Flavor = "";
        }
    }
    # endregion


    # endregion

    # region Morningtide
    # region Ambassador Oak
    public class AmbassadorOak : MagicCard
    {
        public AmbassadorOak()
        {
            Name = "Ambassador Oak";
            Edition = "MOR";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "3/3";
            Type = "Creature - Treefolk Warrior";
            Text = "When Ambassador Oak enters the battlefield, put a 1/1 green Elf Warrior creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Auntie's Snitch
    public class AuntiesSnitch : MagicCard
    {
        public AuntiesSnitch()
        {
            Name = "Auntie's Snitch";
            Edition = "MOR";
            Rarity = "R";
            Color = "B";
            Cost = "2B";
            PT = "3/1";
            Type = "Creature - Goblin Rogue";
            Text = "Auntie's Snitch can't block.;^Prowl %1%B @(You may cast this for its prowl cost if you dealt combat damage to a player this turn with a Goblin or Rogue.)@;^Whenever a Goblin or Rogue you control deals combat damage to a player, if Auntie's Snitch is in your graveyard, you may return Auntie's Snitch to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Ballyrush Banneret
    public class BallyrushBanneret : MagicCard
    {
        public BallyrushBanneret()
        {
            Name = "Ballyrush Banneret";
            Edition = "MOR";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "2/1";
            Type = "Creature - Kithkin Soldier";
            Text = "Kithkin spells and Soldier spells you cast cost %1 less to cast.";
            Flavor = "";
        }
    }
    # endregion

    # region Battletide Alchemist
    public class BattletideAlchemist : MagicCard
    {
        public BattletideAlchemist()
        {
            Name = "Battletide Alchemist";
            Edition = "MOR";
            Rarity = "R";
            Color = "W";
            Cost = "3WW";
            PT = "3/4";
            Type = "Creature - Kithkin Cleric";
            Text = "If a source would deal damage to a player, you may prevent X of that damage, where X is the number of Clerics you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Bitterblossom
    public class Bitterblossom : MagicCard
    {
        public Bitterblossom()
        {
            Name = "Bitterblossom";
            Edition = "MOR";
            Rarity = "R";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Tribal Enchantment - Faerie";
            Text = "At the beginning of your upkeep, you lose 1 life and put a 1/1 black Faerie Rogue creature token with flying onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Blightsoil Druid
    public class BlightsoilDruid : MagicCard
    {
        public BlightsoilDruid()
        {
            Name = "Blightsoil Druid";
            Edition = "MOR";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "1/2";
            Type = "Creature - Elf Druid";
            Text = "%T, Pay 1 life: Add %G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Boldwyr Heavyweights
    public class BoldwyrHeavyweights : MagicCard
    {
        public BoldwyrHeavyweights()
        {
            Name = "Boldwyr Heavyweights";
            Edition = "MOR";
            Rarity = "R";
            Color = "R";
            Cost = "2RR";
            PT = "8/8";
            Type = "Creature - Giant Warrior";
            Text = "Trample;^When Boldwyr Heavyweights enters the battlefield, each opponent may search his or her library for a creature card and put it onto the battlefield. Then each player who searched his or her library this way shuffles it.";
            Flavor = "";
        }
    }
    # endregion

    # region Boldwyr Intimidator
    public class BoldwyrIntimidator : MagicCard
    {
        public BoldwyrIntimidator()
        {
            Name = "Boldwyr Intimidator";
            Edition = "MOR";
            Rarity = "U";
            Color = "R";
            Cost = "5RR";
            PT = "5/5";
            Type = "Creature - Giant Warrior";
            Text = "Cowards can't block Warriors.;^%R: Target creature becomes a Coward until end of turn.;^%2%R: Target creature becomes a Warrior until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Borderland Behemoth
    public class BorderlandBehemoth : MagicCard
    {
        public BorderlandBehemoth()
        {
            Name = "Borderland Behemoth";
            Edition = "MOR";
            Rarity = "R";
            Color = "R";
            Cost = "5RR";
            PT = "4/4";
            Type = "Creature - Giant Warrior";
            Text = "Trample^Borderland Behemoth gets +4/+4 for each other Giant you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Bosk Banneret
    public class BoskBanneret : MagicCard
    {
        public BoskBanneret()
        {
            Name = "Bosk Banneret";
            Edition = "MOR";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "1/3";
            Type = "Creature - Treefolk Shaman";
            Text = "Treefolk spells and Shaman spells you cast cost %1 less to cast.";
            Flavor = "";
        }
    }
    # endregion

    # region Bramblewood Paragon
    public class BramblewoodParagon : MagicCard
    {
        public BramblewoodParagon()
        {
            Name = "Bramblewood Paragon";
            Edition = "MOR";
            Rarity = "U";
            Color = "G";
            Cost = "1G";
            PT = "2/2";
            Type = "Creature - Elf Warrior";
            Text = "Each other Warrior creature you control enters the battlefield with an additional +1/+1 counter on it.;^Each creature you control with a +1/+1 counter on it has trample.";
            Flavor = "";
        }
    }
    # endregion

    # region Brighthearth Banneret
    public class BrighthearthBanneret : MagicCard
    {
        public BrighthearthBanneret()
        {
            Name = "Brighthearth Banneret";
            Edition = "MOR";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "1/1";
            Type = "Creature - Elemental Warrior";
            Text = "Elemental spells and Warrior spells you cast cost %1 less to cast.;^Reinforce 1'%1%R @(%1%R, Discard this card: Put a +1/+1 counter on target creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Burrenton Bombardier
    public class BurrentonBombardier : MagicCard
    {
        public BurrentonBombardier()
        {
            Name = "Burrenton Bombardier";
            Edition = "MOR";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Kithkin Soldier";
            Text = "Flying;^Reinforce 2'%2%W @(%2%W, Discard this card: Put two +1/+1 counters on target creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Burrenton Shield-Bearers
    public class BurrentonShieldBearers : MagicCard
    {
        public BurrentonShieldBearers()
        {
            Name = "Burrenton Shield-Bearers";
            Edition = "MOR";
            Rarity = "C";
            Color = "W";
            Cost = "4W";
            PT = "3/3";
            Type = "Creature - Kithkin Soldier";
            Text = "Whenever Burrenton Shield-Bearers attacks, target creature gets +0/+3 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Cenn's Tactician
    public class CennsTactician : MagicCard
    {
        public CennsTactician()
        {
            Name = "Cenn's Tactician";
            Edition = "MOR";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Kithkin Soldier";
            Text = "%W, %T: Put a +1/+1 counter on target Soldier creature.;^Each creature you control with a +1/+1 counter on it can block an additional creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Chameleon Colossus
    public class ChameleonColossus : MagicCard
    {
        public ChameleonColossus()
        {
            Name = "Chameleon Colossus";
            Edition = "MOR";
            Rarity = "R";
            Color = "G";
            Cost = "2GG";
            PT = "4/4";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@;^Protection from black;^%2%G%G: Chameleon Colossus gets +X/+X until end of turn, where X is its power.";
            Flavor = "";
        }
    }
    # endregion

    # region Changeling Sentinel
    public class ChangelingSentinel : MagicCard
    {
        public ChangelingSentinel()
        {
            Name = "Changeling Sentinel";
            Edition = "MOR";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "3/2";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^Vigilance";
            Flavor = "";
        }
    }
    # endregion

    # region Cloak and Dagger
    public class CloakandDagger : MagicCard
    {
        public CloakandDagger()
        {
            Name = "Cloak and Dagger";
            Edition = "MOR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Tribal Artifact - Rogue Equipment";
            Text = "Equipped creature gets +2/+0 and has shroud. @(It can't be the target of spells or abilities.)@;^Whenever a Rogue creature enters the battlefield, you may attach Cloak and Dagger to it.;^Equip %3";
            Flavor = "";
        }
    }
    # endregion

    # region Coordinated Barrage
    public class CoordinatedBarrage : MagicCard
    {
        public CoordinatedBarrage()
        {
            Name = "Coordinated Barrage";
            Edition = "MOR";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Choose a creature type. Coordinated Barrage deals damage to target attacking or blocking creature equal to the number of permanents you control of the chosen type.";
            Flavor = "";
        }
    }
    # endregion

    # region Countryside Crusher
    public class CountrysideCrusher : MagicCard
    {
        public CountrysideCrusher()
        {
            Name = "Countryside Crusher";
            Edition = "MOR";
            Rarity = "R";
            Color = "R";
            Cost = "1RR";
            PT = "3/3";
            Type = "Creature - Giant Warrior";
            Text = "At the beginning of your upkeep, reveal the top card of your library. If it's a land card, put it into your graveyard and repeat this process.;^Whenever a land card is put into your graveyard from anywhere, put a +1/+1 counter on Countryside Crusher.";
            Flavor = "";
        }
    }
    # endregion

    # region Cream of the Crop
    public class CreamoftheCrop : MagicCard
    {
        public CreamoftheCrop()
        {
            Name = "Cream of the Crop";
            Edition = "MOR";
            Rarity = "R";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a creature enters the battlefield under your control, you may look at the top X cards of your library, where X is that creature's power. If you do, put one of those cards on top of your library and the rest on the bottom of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Daily Regimen
    public class DailyRegimen : MagicCard
    {
        public DailyRegimen()
        {
            Name = "Daily Regimen";
            Edition = "MOR";
            Rarity = "U";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature^%1%W: Put a +1/+1 counter on enchanted creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Declaration of Naught
    public class DeclarationofNaught : MagicCard
    {
        public DeclarationofNaught()
        {
            Name = "Declaration of Naught";
            Edition = "MOR";
            Rarity = "R";
            Color = "U";
            Cost = "UU";
            PT = "";
            Type = "Enchantment";
            Text = "As Declaration of Naught enters the battlefield, name a card.;^%U: Counter target spell with the chosen name.";
            Flavor = "";
        }
    }
    # endregion

    # region Deglamer
    public class Deglamer : MagicCard
    {
        public Deglamer()
        {
            Name = "Deglamer";
            Edition = "MOR";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Choose target artifact or enchantment. Its owner shuffles it into his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Dewdrop Spy
    public class DewdropSpy : MagicCard
    {
        public DewdropSpy()
        {
            Name = "Dewdrop Spy";
            Edition = "MOR";
            Rarity = "C";
            Color = "U";
            Cost = "1UU";
            PT = "2/2";
            Type = "Creature - Faerie Rogue";
            Text = "Flash;^Flying;^When Dewdrop Spy enters the battlefield, look at the top card of target player's library.";
            Flavor = "";
        }
    }
    # endregion

    # region Disperse
    public class DisperseMOR : MagicCard
    {
        public DisperseMOR()
        {
            Name = "Disperse";
            Edition = "MOR";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Return target nonland permanent to its owner's hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Distant Melody
    public class DistantMelody : MagicCard
    {
        public DistantMelody()
        {
            Name = "Distant Melody";
            Edition = "MOR";
            Rarity = "C";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Sorcery";
            Text = "Choose a creature type. Draw a card for each permanent you control of that type.";
            Flavor = "";
        }
    }
    # endregion

    # region Diviner's Wand
    public class DivinersWand : MagicCard
    {
        public DivinersWand()
        {
            Name = "Diviner's Wand";
            Edition = "MOR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Tribal Artifact - Wizard Equipment";
            Text = "Equipped creature has 'Whenever you draw a card, this creature gets +1/+1 and gains flying until end of turn' and '%4: Draw a card.';^Whenever a Wizard creature enters the battlefield, you may attach Diviner's Wand to it.;^Equip %3";
            Flavor = "";
        }
    }
    # endregion

    # region Door of Destinies
    public class DoorofDestiniesMOR : MagicCard
    {
        public DoorofDestiniesMOR()
        {
            Name = "Door of Destinies";
            Edition = "MOR";
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

    # region Earthbrawn
    public class Earthbrawn : MagicCard
    {
        public Earthbrawn()
        {
            Name = "Earthbrawn";
            Edition = "MOR";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +3/+3 until end of turn.;^Reinforce 1'%1%G @(%1%G, Discard this card: Put a +1/+1 counter on target creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Earwig Squad
    public class EarwigSquad : MagicCard
    {
        public EarwigSquad()
        {
            Name = "Earwig Squad";
            Edition = "MOR";
            Rarity = "R";
            Color = "B";
            Cost = "3BB";
            PT = "5/3";
            Type = "Creature - Goblin Rogue";
            Text = "Prowl %2%B @(You may cast this for its prowl cost if you dealt combat damage to a player this turn with a Goblin or Rogue.)@;^When Earwig Squad enters the battlefield, if its prowl cost was paid, search target opponent's library for three cards and exile them. Then that player shuffles his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Elvish Warrior
    public class ElvishWarrior : MagicCard
    {
        public ElvishWarrior()
        {
            Name = "Elvish Warrior";
            Edition = "MOR";
            Rarity = "C";
            Color = "G";
            Cost = "GG";
            PT = "2/3";
            Type = "Creature - Elf Warrior";
            Text = "";
            Flavor = "As graceful as a deer leaping a stream and as deadly as the wolf waiting in ambush on the other side, elvish warriors are the eyes of the forest as well as its unsheathed claws.";
        }
    }
    # endregion

    # region Everbark Shaman
    public class EverbarkShaman : MagicCard
    {
        public EverbarkShaman()
        {
            Name = "Everbark Shaman";
            Edition = "MOR";
            Rarity = "C";
            Color = "G";
            Cost = "4G";
            PT = "3/5";
            Type = "Creature - Treefolk Shaman";
            Text = "%T, Exile a Treefolk card from your graveyard: Search your library for up to two Forest cards and put them onto the battlefield tapped. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Fencer Clique
    public class FencerClique : MagicCard
    {
        public FencerClique()
        {
            Name = "Fencer Clique";
            Edition = "MOR";
            Rarity = "C";
            Color = "U";
            Cost = "2UU";
            PT = "3/2";
            Type = "Creature - Faerie Soldier";
            Text = "Flying^%U: Put Fencer Clique on top of its owner's library.";
            Flavor = "";
        }
    }
    # endregion

    # region Fendeep Summoner
    public class FendeepSummoner : MagicCard
    {
        public FendeepSummoner()
        {
            Name = "Fendeep Summoner";
            Edition = "MOR";
            Rarity = "R";
            Color = "B";
            Cost = "4B";
            PT = "3/5";
            Type = "Creature - Treefolk Shaman";
            Text = "%T: Up to two target Swamps each become 3/5 Treefolk Warrior creatures in addition to their other types until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Fertilid
    public class Fertilid : MagicCard
    {
        public Fertilid()
        {
            Name = "Fertilid";
            Edition = "MOR";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "0/0";
            Type = "Creature - Elemental";
            Text = "Fertilid enters the battlefield with two +1/+1 counters on it.;^%1%G, Remove a +1/+1 counter from Fertilid: Target player searches his or her library for a basic land card and puts it onto the battlefield tapped. Then that player shuffles his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Festercreep
    public class Festercreep : MagicCard
    {
        public Festercreep()
        {
            Name = "Festercreep";
            Edition = "MOR";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "0/0";
            Type = "Creature - Elemental";
            Text = "Festercreep enters the battlefield with a +1/+1 counter on it.;^%1%B, Remove a +1/+1 counter from Festercreep: All other creatures get -1/-1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Feudkiller's Verdict
    public class FeudkillersVerdict : MagicCard
    {
        public FeudkillersVerdict()
        {
            Name = "Feudkiller's Verdict";
            Edition = "MOR";
            Rarity = "R";
            Color = "W";
            Cost = "4WW";
            PT = "";
            Type = "Tribal Sorcery - Giant";
            Text = "You gain 10 life. Then if you have more life than an opponent, put a 5/5 white Giant Warrior creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Final-Sting Faerie
    public class FinalStingFaerie : MagicCard
    {
        public FinalStingFaerie()
        {
            Name = "Final-Sting Faerie";
            Edition = "MOR";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "2/2";
            Type = "Creature - Faerie Assassin";
            Text = "Flying;^When Final-Sting Faerie enters the battlefield, destroy target creature that was dealt damage this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Fire Juggler
    public class FireJuggler : MagicCard
    {
        public FireJuggler()
        {
            Name = "Fire Juggler";
            Edition = "MOR";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Goblin Shaman";
            Text = "Whenever Fire Juggler becomes blocked, clash with an opponent. If you win, Fire Juggler deals 4 damage to each creature blocking it. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Floodchaser
    public class Floodchaser : MagicCard
    {
        public Floodchaser()
        {
            Name = "Floodchaser";
            Edition = "MOR";
            Rarity = "C";
            Color = "U";
            Cost = "5U";
            PT = "0/0";
            Type = "Creature - Elemental";
            Text = "Floodchaser enters the battlefield with six +1/+1 counters on it.;^Floodchaser can't attack unless defending player controls an Island.;^%U, Remove a +1/+1 counter from Floodchaser: Target land becomes an Island until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Forfend
    public class Forfend : MagicCard
    {
        public Forfend()
        {
            Name = "Forfend";
            Edition = "MOR";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Prevent all damage that would be dealt to creatures this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Frogtosser Banneret
    public class FrogtosserBanneret : MagicCard
    {
        public FrogtosserBanneret()
        {
            Name = "Frogtosser Banneret";
            Edition = "MOR";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "1/1";
            Type = "Creature - Goblin Rogue";
            Text = "Haste;^Goblin spells and Rogue spells you cast cost %1 less to cast.";
            Flavor = "";
        }
    }
    # endregion

    # region Game-Trail Changeling
    public class GameTrailChangeling : MagicCard
    {
        public GameTrailChangeling()
        {
            Name = "Game-Trail Changeling";
            Edition = "MOR";
            Rarity = "C";
            Color = "G";
            Cost = "3GG";
            PT = "4/4";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@^Trample";
            Flavor = "";
        }
    }
    # endregion

    # region Gilt-Leaf Archdruid
    public class GiltLeafArchdruid : MagicCard
    {
        public GiltLeafArchdruid()
        {
            Name = "Gilt-Leaf Archdruid";
            Edition = "MOR";
            Rarity = "R";
            Color = "G";
            Cost = "3GG";
            PT = "3/3";
            Type = "Creature - Elf Druid";
            Text = "Whenever you cast a Druid spell, you may draw a card.;^Tap seven untapped Druids you control: Gain control of all lands target player controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Graceful Reprieve
    public class GracefulReprieve : MagicCard
    {
        public GracefulReprieve()
        {
            Name = "Graceful Reprieve";
            Edition = "MOR";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "When target creature dies this turn, return that card to the battlefield under its owner's control.";
            Flavor = "";
        }
    }
    # endregion

    # region Greatbow Doyen
    public class GreatbowDoyen : MagicCard
    {
        public GreatbowDoyen()
        {
            Name = "Greatbow Doyen";
            Edition = "MOR";
            Rarity = "R";
            Color = "G";
            Cost = "4G";
            PT = "2/4";
            Type = "Creature - Elf Archer";
            Text = "Other Archer creatures you control get +1/+1.;^Whenever an Archer you control deals damage to a creature, that Archer deals that much damage to that creature's controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Grimoire Thief
    public class GrimoireThief : MagicCard
    {
        public GrimoireThief()
        {
            Name = "Grimoire Thief";
            Edition = "MOR";
            Rarity = "R";
            Color = "U";
            Cost = "UU";
            PT = "2/2";
            Type = "Creature - Merfolk Rogue";
            Text = "Whenever Grimoire Thief becomes tapped, exile the top three cards of target opponent's library face down.;^You may look at cards exiled with Grimoire Thief.;^%U, Sacrifice Grimoire Thief: Turn all cards exiled with Grimoire Thief face up. Counter all spells with those names.";
            Flavor = "";
        }
    }
    # endregion

    # region Heritage Druid
    public class HeritageDruid : MagicCard
    {
        public HeritageDruid()
        {
            Name = "Heritage Druid";
            Edition = "MOR";
            Rarity = "U";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Elf Druid";
            Text = "Tap three untapped Elves you control: Add %G%G%G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Hostile Realm
    public class HostileRealm : MagicCard
    {
        public HostileRealm()
        {
            Name = "Hostile Realm";
            Edition = "MOR";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant land^Enchanted land has '%T: Target creature can't block this turn.'";
            Flavor = "";
        }
    }
    # endregion

    # region Hunting Triad
    public class HuntingTriad : MagicCard
    {
        public HuntingTriad()
        {
            Name = "Hunting Triad";
            Edition = "MOR";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Tribal Sorcery - Elf";
            Text = "Put three 1/1 green Elf Warrior creature tokens onto the battlefield.;^Reinforce 3'%3%G @(%3%G, Discard this card: Put three +1/+1 counters on target creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Idyllic Tutor
    public class IdyllicTutor : MagicCard
    {
        public IdyllicTutor()
        {
            Name = "Idyllic Tutor";
            Edition = "MOR";
            Rarity = "R";
            Color = "W";
            Cost = "2W";
            PT = "";
            Type = "Sorcery";
            Text = "Search your library for an enchantment card, reveal it, and put it into your hand. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Indomitable Ancients
    public class IndomitableAncients : MagicCard
    {
        public IndomitableAncients()
        {
            Name = "Indomitable Ancients";
            Edition = "MOR";
            Rarity = "R";
            Color = "W";
            Cost = "2WW";
            PT = "2/10";
            Type = "Creature - Treefolk Warrior";
            Text = "";
            Flavor = "'Odum and Broadbark were the only beings mighty enough to challenge the giant Moran the Destroyer. Their battle lasted a hundred dawns, until Moran became so exhausted that he fell into namesleep. He awoke as Moran the Gardener.';^'@The Tale of Odum and Broadbark@";
        }
    }
    # endregion

    # region Ink Dissolver
    public class InkDissolver : MagicCard
    {
        public InkDissolver()
        {
            Name = "Ink Dissolver";
            Edition = "MOR";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "2/1";
            Type = "Creature - Merfolk Wizard";
            Text = "@Kinship@ ' At the beginning of your upkeep, you may look at the top card of your library. If it shares a creature type with Ink Dissolver, you may reveal it. If you do, each opponent puts the top three cards of his or her library into his or her graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Inspired Sprite
    public class InspiredSprite : MagicCard
    {
        public InspiredSprite()
        {
            Name = "Inspired Sprite";
            Edition = "MOR";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "2/2";
            Type = "Creature - Faerie Wizard";
            Text = "Flash;^Flying;^Whenever you cast a Wizard spell, you may untap Inspired Sprite.;^%T: Draw a card, then discard a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Kindled Fury
    public class KindledFury : MagicCard
    {
        public KindledFury()
        {
            Name = "Kindled Fury";
            Edition = "MOR";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +1/+0 and gains first strike until end of turn. @(It deals combat damage before creatures without first strike.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Kinsbaile Borderguard
    public class KinsbaileBorderguard : MagicCard
    {
        public KinsbaileBorderguard()
        {
            Name = "Kinsbaile Borderguard";
            Edition = "MOR";
            Rarity = "R";
            Color = "W";
            Cost = "1WW";
            PT = "1/1";
            Type = "Creature - Kithkin Soldier";
            Text = "Kinsbaile Borderguard enters the battlefield with a +1/+1 counter on it for each other Kithkin you control.;^When Kinsbaile Borderguard dies, put a 1/1 white Kithkin Soldier creature token onto the battlefield for each counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Kinsbaile Cavalier
    public class KinsbaileCavalier : MagicCard
    {
        public KinsbaileCavalier()
        {
            Name = "Kinsbaile Cavalier";
            Edition = "MOR";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "2/2";
            Type = "Creature - Kithkin Knight";
            Text = "Knight creatures you control have double strike.";
            Flavor = "";
        }
    }
    # endregion

    # region Kithkin Zephyrnaut
    public class KithkinZephyrnaut : MagicCard
    {
        public KithkinZephyrnaut()
        {
            Name = "Kithkin Zephyrnaut";
            Edition = "MOR";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Kithkin Soldier";
            Text = "@Kinship@ ' At the beginning of your upkeep, you may look at the top card of your library. If it shares a creature type with Kithkin Zephyrnaut, you may reveal it. If you do, Kithkin Zephyrnaut gets +2/+2 and gains flying and vigilance until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Knowledge Exploitation
    public class KnowledgeExploitation : MagicCard
    {
        public KnowledgeExploitation()
        {
            Name = "Knowledge Exploitation";
            Edition = "MOR";
            Rarity = "R";
            Color = "U";
            Cost = "5UU";
            PT = "";
            Type = "Tribal Sorcery - Rogue";
            Text = "Prowl %3%U @(You may cast this for its prowl cost if you dealt combat damage to a player this turn with a Rogue.)@;^Search target opponent's library for an instant or sorcery card. You may cast that card without paying its mana cost. Then that player shuffles his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Latchkey Faerie
    public class LatchkeyFaerie : MagicCard
    {
        public LatchkeyFaerie()
        {
            Name = "Latchkey Faerie";
            Edition = "MOR";
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

    # region Leaf-Crowned Elder
    public class LeafCrownedElder : MagicCard
    {
        public LeafCrownedElder()
        {
            Name = "Leaf-Crowned Elder";
            Edition = "MOR";
            Rarity = "R";
            Color = "G";
            Cost = "2GG";
            PT = "3/5";
            Type = "Creature - Treefolk Shaman";
            Text = "@Kinship@ ' At the beginning of your upkeep, you may look at the top card of your library. If it shares a creature type with Leaf-Crowned Elder, you may reveal it. If you do, you may play that card without paying its mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Lightning Crafter
    public class LightningCrafter : MagicCard
    {
        public LightningCrafter()
        {
            Name = "Lightning Crafter";
            Edition = "MOR";
            Rarity = "R";
            Color = "R";
            Cost = "3R";
            PT = "3/3";
            Type = "Creature - Goblin Shaman";
            Text = "Champion a Goblin or Shaman @(When this enters the battlefield, sacrifice it unless you exile another Goblin or Shaman you control. When this leaves the battlefield, that card returns to the battlefield.)@;^%T: Lightning Crafter deals 3 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Luminescent Rain
    public class LuminescentRain : MagicCard
    {
        public LuminescentRain()
        {
            Name = "Luminescent Rain";
            Edition = "MOR";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Instant";
            Text = "Choose a creature type. You gain 2 life for each permanent you control of that type.";
            Flavor = "";
        }
    }
    # endregion

    # region Lunk Errant
    public class LunkErrant : MagicCard
    {
        public LunkErrant()
        {
            Name = "Lunk Errant";
            Edition = "MOR";
            Rarity = "C";
            Color = "R";
            Cost = "5R";
            PT = "4/4";
            Type = "Creature - Giant Warrior";
            Text = "Whenever Lunk Errant attacks alone, it gets +1/+1 and gains trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Lys Alana Bowmaster
    public class LysAlanaBowmaster : MagicCard
    {
        public LysAlanaBowmaster()
        {
            Name = "Lys Alana Bowmaster";
            Edition = "MOR";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Elf Archer";
            Text = "Reach @(This can block creatures with flying.)@;^Whenever you cast an Elf spell, you may have Lys Alana Bowmaster deal 2 damage to target creature with flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Maralen of the Mornsong
    public class MaralenoftheMornsong : MagicCard
    {
        public MaralenoftheMornsong()
        {
            Name = "Maralen of the Mornsong";
            Edition = "MOR";
            Rarity = "R";
            Color = "B";
            Cost = "1BB";
            PT = "2/3";
            Type = "Legendary Creature - Elf Wizard";
            Text = "Players can't draw cards.^At the beginning of each player's draw step, that player loses 3 life, searches his or her library for a card, puts it into his or her hand, then shuffles his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Meadowboon
    public class Meadowboon : MagicCard
    {
        public Meadowboon()
        {
            Name = "Meadowboon";
            Edition = "MOR";
            Rarity = "U";
            Color = "W";
            Cost = "2WW";
            PT = "3/3";
            Type = "Creature - Elemental";
            Text = "When Meadowboon leaves the battlefield, put a +1/+1 counter on each creature target player controls.;^Evoke %3%W @(You may cast this spell for its evoke cost. If you do, it's sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Merrow Witsniper
    public class MerrowWitsniper : MagicCard
    {
        public MerrowWitsniper()
        {
            Name = "Merrow Witsniper";
            Edition = "MOR";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "1/1";
            Type = "Creature - Merfolk Rogue";
            Text = "When Merrow Witsniper enters the battlefield, target player puts the top card of his or her library into his or her graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Mind Shatter
    public class MindShatter : MagicCard
    {
        public MindShatter()
        {
            Name = "Mind Shatter";
            Edition = "MOR";
            Rarity = "R";
            Color = "B";
            Cost = "XBB";
            PT = "";
            Type = "Sorcery";
            Text = "Target player discards X cards at random.";
            Flavor = "";
        }
    }
    # endregion

    # region Mind Spring
    public class MindSpring : MagicCard
    {
        public MindSpring()
        {
            Name = "Mind Spring";
            Edition = "MOR";
            Rarity = "R";
            Color = "U";
            Cost = "XUU";
            PT = "";
            Type = "Sorcery";
            Text = "Draw X cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Moonglove Changeling
    public class MoongloveChangeling : MagicCard
    {
        public MoongloveChangeling()
        {
            Name = "Moonglove Changeling";
            Edition = "MOR";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@;^%B: Moonglove Changeling gains deathtouch until end of turn. @(Any amount of damage it deals to a creature is enough to destroy that creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Morsel Theft
    public class MorselTheft : MagicCard
    {
        public MorselTheft()
        {
            Name = "Morsel Theft";
            Edition = "MOR";
            Rarity = "C";
            Color = "B";
            Cost = "2BB";
            PT = "";
            Type = "Tribal Sorcery - Rogue";
            Text = "Prowl %1%B @(You may cast this for its prowl cost if you dealt combat damage to a player this turn with a Rogue.)@;^Target player loses 3 life and you gain 3 life. If Morsel Theft's prowl cost was paid, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Mosquito Guard
    public class MosquitoGuard : MagicCard
    {
        public MosquitoGuard()
        {
            Name = "Mosquito Guard";
            Edition = "MOR";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Kithkin Soldier";
            Text = "First strike;^Reinforce 1'%1%W @(%1%W, Discard this card: Put a +1/+1 counter on target creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Mothdust Changeling
    public class MothdustChangeling : MagicCard
    {
        public MothdustChangeling()
        {
            Name = "Mothdust Changeling";
            Edition = "MOR";
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

    # region Mudbutton Clanger
    public class MudbuttonClanger : MagicCard
    {
        public MudbuttonClanger()
        {
            Name = "Mudbutton Clanger";
            Edition = "MOR";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Goblin Warrior";
            Text = "@Kinship@ ' At the beginning of your upkeep, you may look at the top card of your library. If it shares a creature type with Mudbutton Clanger, you may reveal it. If you do, Mudbutton Clanger gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Murmuring Bosk
    public class MurmuringBosk : MagicCard
    {
        public MurmuringBosk()
        {
            Name = "Murmuring Bosk";
            Edition = "MOR";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Forest";
            Text = "@(%T: Add %G to your mana pool.)@;^As Murmuring Bosk enters the battlefield, you may reveal a Treefolk card from your hand. If you don't, Murmuring Bosk enters the battlefield tapped.;^%T: Add %W or %B to your mana pool. Murmuring Bosk deals 1 damage to you.";
            Flavor = "";
        }
    }
    # endregion

    # region Mutavault
    public class MutavaultMOR : MagicCard
    {
        public MutavaultMOR()
        {
            Name = "Mutavault";
            Edition = "MOR";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.^%1: Mutavault becomes a 2/2 creature with all creature types until end of turn. It's still a land.";
            Flavor = "";
        }
    }
    # endregion

    # region Negate
    public class NegateMOR : MagicCard
    {
        public NegateMOR()
        {
            Name = "Negate";
            Edition = "MOR";
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

    # region Nevermaker
    public class Nevermaker : MagicCard
    {
        public Nevermaker()
        {
            Name = "Nevermaker";
            Edition = "MOR";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "2/3";
            Type = "Creature - Elemental";
            Text = "Flying;^When Nevermaker leaves the battlefield, put target nonland permanent on top of its owner's library.;^Evoke %3%U @(You may cast this spell for its evoke cost. If you do, it's sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Nightshade Schemers
    public class NightshadeSchemers : MagicCard
    {
        public NightshadeSchemers()
        {
            Name = "Nightshade Schemers";
            Edition = "MOR";
            Rarity = "U";
            Color = "B";
            Cost = "4B";
            PT = "3/2";
            Type = "Creature - Faerie Wizard";
            Text = "Flying^@Kinship@ ' At the beginning of your upkeep, you may look at the top card of your library. If it shares a creature type with Nightshade Schemers, you may reveal it. If you do, each opponent loses 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Noggin Whack
    public class NogginWhack : MagicCard
    {
        public NogginWhack()
        {
            Name = "Noggin Whack";
            Edition = "MOR";
            Rarity = "U";
            Color = "B";
            Cost = "2BB";
            PT = "";
            Type = "Tribal Sorcery - Rogue";
            Text = "Prowl %1%B @(You may cast this for its prowl cost if you dealt combat damage to a player this turn with a Rogue.)@;^Target player reveals three cards from his or her hand. You choose two of them. That player discards those cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Notorious Throng
    public class NotoriousThrong : MagicCard
    {
        public NotoriousThrong()
        {
            Name = "Notorious Throng";
            Edition = "MOR";
            Rarity = "R";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Tribal Sorcery - Rogue";
            Text = "Prowl %5%U @(You may cast this for its prowl cost if you dealt combat damage to a player this turn with a Rogue.)@;^Put X 1/1 black Faerie Rogue creature tokens with flying onto the battlefield, where X is the damage dealt to your opponents this turn. If Notorious Throng's prowl cost was paid, take an extra turn after this one.";
            Flavor = "";
        }
    }
    # endregion

    # region Obsidian Battle-Axe
    public class ObsidianBattleAxe : MagicCard
    {
        public ObsidianBattleAxe()
        {
            Name = "Obsidian Battle-Axe";
            Edition = "MOR";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Tribal Artifact - Warrior Equipment";
            Text = "Equipped creature gets +2/+1 and has haste.;^Whenever a Warrior creature enters the battlefield, you may attach Obsidian Battle-Axe to it.;^Equip %3";
            Flavor = "";
        }
    }
    # endregion

    # region Offalsnout
    public class Offalsnout : MagicCard
    {
        public Offalsnout()
        {
            Name = "Offalsnout";
            Edition = "MOR";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "2/2";
            Type = "Creature - Elemental";
            Text = "Flash;^When Offalsnout leaves the battlefield, exile target card from a graveyard.;^Evoke %B @(You may cast this spell for its evoke cost. If you do, it's sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Oona's Blackguard
    public class OonasBlackguard : MagicCard
    {
        public OonasBlackguard()
        {
            Name = "Oona's Blackguard";
            Edition = "MOR";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "1/1";
            Type = "Creature - Faerie Rogue";
            Text = "Flying;^Each other Rogue creature you control enters the battlefield with an additional +1/+1 counter on it.;^Whenever a creature you control with a +1/+1 counter on it deals combat damage to a player, that player discards a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Orchard Warden
    public class OrchardWarden : MagicCard
    {
        public OrchardWarden()
        {
            Name = "Orchard Warden";
            Edition = "MOR";
            Rarity = "U";
            Color = "G";
            Cost = "4GG";
            PT = "4/6";
            Type = "Creature - Treefolk Shaman";
            Text = "Whenever another Treefolk creature enters the battlefield under your control, you may gain life equal to that creature's toughness.";
            Flavor = "";
        }
    }
    # endregion

    # region Order of the Golden Cricket
    public class OrderoftheGoldenCricket : MagicCard
    {
        public OrderoftheGoldenCricket()
        {
            Name = "Order of the Golden Cricket";
            Edition = "MOR";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "2/2";
            Type = "Creature - Kithkin Knight";
            Text = "Whenever Order of the Golden Cricket attacks, you may pay %W. If you do, it gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Pack's Disdain
    public class PacksDisdain : MagicCard
    {
        public PacksDisdain()
        {
            Name = "Pack's Disdain";
            Edition = "MOR";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Instant";
            Text = "Choose a creature type. Target creature gets -1/-1 until end of turn for each permanent of the chosen type you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Preeminent Captain
    public class PreeminentCaptain : MagicCard
    {
        public PreeminentCaptain()
        {
            Name = "Preeminent Captain";
            Edition = "MOR";
            Rarity = "R";
            Color = "W";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Kithkin Soldier";
            Text = "First strike;^Whenever Preeminent Captain attacks, you may put a Soldier creature card from your hand onto the battlefield tapped and attacking.";
            Flavor = "";
        }
    }
    # endregion

    # region Prickly Boggart
    public class PricklyBoggart : MagicCard
    {
        public PricklyBoggart()
        {
            Name = "Prickly Boggart";
            Edition = "MOR";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Goblin Rogue";
            Text = "Fear @(This creature can't be blocked except by artifact creatures and/or black creatures.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Primal Beyond
    public class PrimalBeyond : MagicCard
    {
        public PrimalBeyond()
        {
            Name = "Primal Beyond";
            Edition = "MOR";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "As Primal Beyond enters the battlefield, you may reveal an Elemental card from your hand. If you don't, Primal Beyond enters the battlefield tapped.;^%T: Add %1 to your mana pool.;^%T: Add one mana of any color to your mana pool. Spend this mana only to cast an Elemental spell or activate an ability of an Elemental.";
            Flavor = "";
        }
    }
    # endregion

    # region Pulling Teeth
    public class PullingTeeth : MagicCard
    {
        public PullingTeeth()
        {
            Name = "Pulling Teeth";
            Edition = "MOR";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Sorcery";
            Text = "Clash with an opponent. If you win, target player discards two cards. Otherwise, that player discards a card. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Pyroclast Consul
    public class PyroclastConsul : MagicCard
    {
        public PyroclastConsul()
        {
            Name = "Pyroclast Consul";
            Edition = "MOR";
            Rarity = "U";
            Color = "R";
            Cost = "3RR";
            PT = "3/3";
            Type = "Creature - Elemental Shaman";
            Text = "@Kinship@ ' At the beginning of your upkeep, you may look at the top card of your library. If it shares a creature type with Pyroclast Consul, you may reveal it. If you do, Pyroclast Consul deals 2 damage to each creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Rage Forger
    public class RageForger : MagicCard
    {
        public RageForger()
        {
            Name = "Rage Forger";
            Edition = "MOR";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Elemental Shaman";
            Text = "When Rage Forger enters the battlefield, put a +1/+1 counter on each other Shaman creature you control.;^Whenever a creature you control with a +1/+1 counter on it attacks, you may have that creature deal 1 damage to target player.";
            Flavor = "";
        }
    }
    # endregion

    # region Reach of Branches
    public class ReachofBranches : MagicCard
    {
        public ReachofBranches()
        {
            Name = "Reach of Branches";
            Edition = "MOR";
            Rarity = "R";
            Color = "G";
            Cost = "4G";
            PT = "";
            Type = "Tribal Instant - Treefolk";
            Text = "Put a 2/5 green Treefolk Shaman creature token onto the battlefield.;^Whenever a Forest enters the battlefield under your control, you may return Reach of Branches from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Recross the Paths
    public class RecrossthePaths : MagicCard
    {
        public RecrossthePaths()
        {
            Name = "Recross the Paths";
            Edition = "MOR";
            Rarity = "U";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Sorcery";
            Text = "Reveal cards from the top of your library until you reveal a land card. Put that card onto the battlefield and the rest on the bottom of your library in any order. Clash with an opponent. If you win, return Recross the Paths to its owner's hand. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Redeem the Lost
    public class RedeemtheLost : MagicCard
    {
        public RedeemtheLost()
        {
            Name = "Redeem the Lost";
            Edition = "MOR";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Target creature you control gains protection from the color of your choice until end of turn. Clash with an opponent. If you win, return Redeem the Lost to its owner's hand. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Reins of the Vinesteed
    public class ReinsoftheVinesteed : MagicCard
    {
        public ReinsoftheVinesteed()
        {
            Name = "Reins of the Vinesteed";
            Edition = "MOR";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +2/+2.;^When enchanted creature dies, you may return Reins of the Vinesteed from your graveyard to the battlefield attached to a creature that shares a creature type with that creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Release the Ants
    public class ReleasetheAnts : MagicCard
    {
        public ReleasetheAnts()
        {
            Name = "Release the Ants";
            Edition = "MOR";
            Rarity = "U";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "Release the Ants deals 1 damage to target creature or player. Clash with an opponent. If you win, return Release the Ants to its owner's hand. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Research the Deep
    public class ResearchtheDeep : MagicCard
    {
        public ResearchtheDeep()
        {
            Name = "Research the Deep";
            Edition = "MOR";
            Rarity = "U";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Sorcery";
            Text = "Draw a card. Clash with an opponent. If you win, return Research the Deep to its owner's hand. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Reveillark
    public class Reveillark : MagicCard
    {
        public Reveillark()
        {
            Name = "Reveillark";
            Edition = "MOR";
            Rarity = "R";
            Color = "W";
            Cost = "4W";
            PT = "4/3";
            Type = "Creature - Elemental";
            Text = "Flying;^When Reveillark leaves the battlefield, return up to two target creature cards with power 2 or less from your graveyard to the battlefield.;^Evoke %5%W @(You may cast this spell for its evoke cost. If you do, it's sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Revive the Fallen
    public class RevivetheFallen : MagicCard
    {
        public RevivetheFallen()
        {
            Name = "Revive the Fallen";
            Edition = "MOR";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Sorcery";
            Text = "Return target creature card from a graveyard to its owner's hand. Clash with an opponent. If you win, return Revive the Fallen to its owner's hand. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Rhys the Exiled
    public class RhystheExiled : MagicCard
    {
        public RhystheExiled()
        {
            Name = "Rhys the Exiled";
            Edition = "MOR";
            Rarity = "R";
            Color = "G";
            Cost = "2G";
            PT = "3/2";
            Type = "Legendary Creature - Elf Warrior";
            Text = "Whenever Rhys the Exiled attacks, you gain 1 life for each Elf you control.^%B, Sacrifice an Elf: Regenerate Rhys the Exiled.";
            Flavor = "";
        }
    }
    # endregion

    # region Rivals' Duel
    public class RivalsDuel : MagicCard
    {
        public RivalsDuel()
        {
            Name = "Rivals' Duel";
            Edition = "MOR";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Sorcery";
            Text = "Choose two target creatures that share no creature types. Those creatures fight each other. @(Each deals damage equal to its power to the other.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Roar of the Crowd
    public class RoaroftheCrowd : MagicCard
    {
        public RoaroftheCrowd()
        {
            Name = "Roar of the Crowd";
            Edition = "MOR";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Sorcery";
            Text = "Choose a creature type. Roar of the Crowd deals damage to target creature or player equal to the number of permanents you control of the chosen type.";
            Flavor = "";
        }
    }
    # endregion

    # region Rustic Clachan
    public class RusticClachan : MagicCard
    {
        public RusticClachan()
        {
            Name = "Rustic Clachan";
            Edition = "MOR";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "As Rustic Clachan enters the battlefield, you may reveal a Kithkin card from your hand. If you don't, Rustic Clachan enters the battlefield tapped.;^%T: Add %W to your mana pool.;^Reinforce 1'%1%W @(%1%W, Discard this card: Put a +1/+1 counter on target creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Sage of Fables
    public class SageofFables : MagicCard
    {
        public SageofFables()
        {
            Name = "Sage of Fables";
            Edition = "MOR";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "2/2";
            Type = "Creature - Merfolk Wizard";
            Text = "Each other Wizard creature you control enters the battlefield with an additional +1/+1 counter on it.;^%2, Remove a +1/+1 counter from a creature you control: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Sage's Dousing
    public class SagesDousing : MagicCard
    {
        public SagesDousing()
        {
            Name = "Sage's Dousing";
            Edition = "MOR";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Tribal Instant - Wizard";
            Text = "Counter target spell unless its controller pays %3. If you control a Wizard, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Scapeshift
    public class Scapeshift : MagicCard
    {
        public Scapeshift()
        {
            Name = "Scapeshift";
            Edition = "MOR";
            Rarity = "R";
            Color = "G";
            Cost = "2GG";
            PT = "";
            Type = "Sorcery";
            Text = "Sacrifice any number of lands. Search your library for that many land cards, put them onto the battlefield tapped, then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Scarblade Elite
    public class ScarbladeElite : MagicCard
    {
        public ScarbladeElite()
        {
            Name = "Scarblade Elite";
            Edition = "MOR";
            Rarity = "R";
            Color = "B";
            Cost = "BB";
            PT = "2/2";
            Type = "Creature - Elf Assassin";
            Text = "%T, Exile an Assassin card from your graveyard: Destroy target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Seething Pathblazer
    public class SeethingPathblazer : MagicCard
    {
        public SeethingPathblazer()
        {
            Name = "Seething Pathblazer";
            Edition = "MOR";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Elemental Warrior";
            Text = "Sacrifice an Elemental: Seething Pathblazer gets +2/+0 and gains first strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Sensation Gorger
    public class SensationGorger : MagicCard
    {
        public SensationGorger()
        {
            Name = "Sensation Gorger";
            Edition = "MOR";
            Rarity = "R";
            Color = "R";
            Cost = "1RR";
            PT = "2/2";
            Type = "Creature - Goblin Shaman";
            Text = "@Kinship@ ' At the beginning of your upkeep, you may look at the top card of your library. If it shares a creature type with Sensation Gorger, you may reveal it. If you do, each player discards his or her hand and draws four cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Shard Volley
    public class ShardVolley : MagicCard
    {
        public ShardVolley()
        {
            Name = "Shard Volley";
            Edition = "MOR";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "As an additional cost to cast Shard Volley, sacrifice a land.;^Shard Volley deals 3 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Shared Animosity
    public class SharedAnimosity : MagicCard
    {
        public SharedAnimosity()
        {
            Name = "Shared Animosity";
            Edition = "MOR";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a creature you control attacks, it gets +1/+0 until end of turn for each other attacking creature that shares a creature type with it.";
            Flavor = "";
        }
    }
    # endregion

    # region Shinewend
    public class Shinewend : MagicCard
    {
        public Shinewend()
        {
            Name = "Shinewend";
            Edition = "MOR";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "0/0";
            Type = "Creature - Elemental";
            Text = "Flying;^Shinewend enters the battlefield with a +1/+1 counter on it.;^%1%W, Remove a +1/+1 counter from Shinewend: Destroy target enchantment.";
            Flavor = "";
        }
    }
    # endregion

    # region Sigil Tracer
    public class SigilTracer : MagicCard
    {
        public SigilTracer()
        {
            Name = "Sigil Tracer";
            Edition = "MOR";
            Rarity = "R";
            Color = "U";
            Cost = "1UU";
            PT = "2/2";
            Type = "Creature - Merfolk Wizard";
            Text = "%1%U, Tap two untapped Wizards you control: Copy target instant or sorcery spell. You may choose new targets for the copy.";
            Flavor = "";
        }
    }
    # endregion

    # region Slithermuse
    public class Slithermuse : MagicCard
    {
        public Slithermuse()
        {
            Name = "Slithermuse";
            Edition = "MOR";
            Rarity = "R";
            Color = "U";
            Cost = "2UU";
            PT = "3/3";
            Type = "Creature - Elemental";
            Text = "When Slithermuse leaves the battlefield, choose an opponent. If that player has more cards in hand than you, draw cards equal to the difference.;^Evoke %3%U @(You may cast this spell for its evoke cost. If you do, it's sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Spitebellows
    public class Spitebellows : MagicCard
    {
        public Spitebellows()
        {
            Name = "Spitebellows";
            Edition = "MOR";
            Rarity = "U";
            Color = "R";
            Cost = "5R";
            PT = "6/1";
            Type = "Creature - Elemental";
            Text = "When Spitebellows leaves the battlefield, it deals 6 damage to target creature.;^Evoke %1%R%R @(You may cast this spell for its evoke cost. If you do, it's sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Squeaking Pie Grubfellows
    public class SqueakingPieGrubfellows : MagicCard
    {
        public SqueakingPieGrubfellows()
        {
            Name = "Squeaking Pie Grubfellows";
            Edition = "MOR";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "3/2";
            Type = "Creature - Goblin Shaman";
            Text = "@Kinship@ ' At the beginning of your upkeep, you may look at the top card of your library. If it shares a creature type with Squeaking Pie Grubfellows, you may reveal it. If you do, each opponent discards a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Stenchskipper
    public class Stenchskipper : MagicCard
    {
        public Stenchskipper()
        {
            Name = "Stenchskipper";
            Edition = "MOR";
            Rarity = "R";
            Color = "B";
            Cost = "3B";
            PT = "6/5";
            Type = "Creature - Elemental";
            Text = "Flying;^At the beginning of the end step, if you control no Goblins, sacrifice Stenchskipper.";
            Flavor = "";
        }
    }
    # endregion

    # region Stingmoggie
    public class Stingmoggie : MagicCard
    {
        public Stingmoggie()
        {
            Name = "Stingmoggie";
            Edition = "MOR";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "0/0";
            Type = "Creature - Elemental";
            Text = "Stingmoggie enters the battlefield with two +1/+1 counters on it.;^%3%R, Remove a +1/+1 counter from Stingmoggie: Destroy target artifact or land.";
            Flavor = "";
        }
    }
    # endregion

    # region Stinkdrinker Bandit
    public class StinkdrinkerBandit : MagicCard
    {
        public StinkdrinkerBandit()
        {
            Name = "Stinkdrinker Bandit";
            Edition = "MOR";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "2/1";
            Type = "Creature - Goblin Rogue";
            Text = "Prowl %1%B @(You may cast this for its prowl cost if you dealt combat damage to a player this turn with a Goblin or Rogue.)@;^Whenever a Rogue you control attacks and isn't blocked, it gets +2/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Stomping Slabs
    public class StompingSlabs : MagicCard
    {
        public StompingSlabs()
        {
            Name = "Stomping Slabs";
            Edition = "MOR";
            Rarity = "U";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Sorcery";
            Text = "Reveal the top seven cards of your library, then put those cards on the bottom of your library in any order. If a card named Stomping Slabs was revealed this way, Stomping Slabs deals 7 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Stonehewer Giant
    public class StonehewerGiant : MagicCard
    {
        public StonehewerGiant()
        {
            Name = "Stonehewer Giant";
            Edition = "MOR";
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

    # region Stonybrook Banneret
    public class StonybrookBanneret : MagicCard
    {
        public StonybrookBanneret()
        {
            Name = "Stonybrook Banneret";
            Edition = "MOR";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Merfolk Wizard";
            Text = "Islandwalk;^Merfolk spells and Wizard spells you cast cost %1 less to cast.";
            Flavor = "";
        }
    }
    # endregion

    # region Stonybrook Schoolmaster
    public class StonybrookSchoolmaster : MagicCard
    {
        public StonybrookSchoolmaster()
        {
            Name = "Stonybrook Schoolmaster";
            Edition = "MOR";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "1/2";
            Type = "Creature - Merfolk Wizard";
            Text = "Whenever Stonybrook Schoolmaster becomes tapped, you may put a 1/1 blue Merfolk Wizard creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Stream of Unconsciousness
    public class StreamofUnconsciousness : MagicCard
    {
        public StreamofUnconsciousness()
        {
            Name = "Stream of Unconsciousness";
            Edition = "MOR";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Tribal Instant - Wizard";
            Text = "Target creature gets -4/-0 until end of turn. If you control a Wizard, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Sunflare Shaman
    public class SunflareShaman : MagicCard
    {
        public SunflareShaman()
        {
            Name = "Sunflare Shaman";
            Edition = "MOR";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "2/1";
            Type = "Creature - Elemental Shaman";
            Text = "%1%R, %T: Sunflare Shaman deals X damage to target creature or player and X damage to itself, where X is the number of Elemental cards in your graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Supreme Exemplar
    public class SupremeExemplar : MagicCard
    {
        public SupremeExemplar()
        {
            Name = "Supreme Exemplar";
            Edition = "MOR";
            Rarity = "R";
            Color = "U";
            Cost = "6U";
            PT = "10/10";
            Type = "Creature - Elemental";
            Text = "Flying;^Champion an Elemental @(When this enters the battlefield, sacrifice it unless you exile another Elemental you control. When this leaves the battlefield, that card returns to the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Swell of Courage
    public class SwellofCourage : MagicCard
    {
        public SwellofCourage()
        {
            Name = "Swell of Courage";
            Edition = "MOR";
            Rarity = "U";
            Color = "W";
            Cost = "3WW";
            PT = "";
            Type = "Instant";
            Text = "Creatures you control get +2/+2 until end of turn.;^Reinforce X'%X%W%W @(%X%W%W, Discard this card: Put X +1/+1 counters on target creature.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Taurean Mauler
    public class TaureanMauler : MagicCard
    {
        public TaureanMauler()
        {
            Name = "Taurean Mauler";
            Edition = "MOR";
            Rarity = "R";
            Color = "R";
            Cost = "2R";
            PT = "2/2";
            Type = "Creature - Shapeshifter";
            Text = "Changeling @(This card is every creature type at all times.)@;^Whenever an opponent casts a spell, you may put a +1/+1 counter on Taurean Mauler.";
            Flavor = "";
        }
    }
    # endregion

    # region Thieves' Fortune
    public class ThievesFortune : MagicCard
    {
        public ThievesFortune()
        {
            Name = "Thieves' Fortune";
            Edition = "MOR";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Tribal Instant - Rogue";
            Text = "Prowl %U @(You may cast this for its prowl cost if you dealt combat damage to a player this turn with a Rogue.)@;^Look at the top four cards of your library. Put one of them into your hand and the rest on the bottom of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Thornbite Staff
    public class ThornbiteStaff : MagicCard
    {
        public ThornbiteStaff()
        {
            Name = "Thornbite Staff";
            Edition = "MOR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Tribal Artifact - Shaman Equipment";
            Text = "Equipped creature has '%2, %T: This creature deals 1 damage to target creature or player' and 'Whenever a creature dies, untap this creature.';^Whenever a Shaman creature enters the battlefield, you may attach Thornbite Staff to it.;^Equip %4";
            Flavor = "";
        }
    }
    # endregion

    # region Titan's Revenge
    public class TitansRevenge : MagicCard
    {
        public TitansRevenge()
        {
            Name = "Titan's Revenge";
            Edition = "MOR";
            Rarity = "R";
            Color = "R";
            Cost = "XRR";
            PT = "";
            Type = "Sorcery";
            Text = "Titan's Revenge deals X damage to target creature or player. Clash with an opponent. If you win, return Titan's Revenge to its owner's hand. @(Each clashing player reveals the top card of his or her library, then puts that card on the top or bottom. A player wins if his or her card had a higher converted mana cost.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Unstoppable Ash
    public class UnstoppableAsh : MagicCard
    {
        public UnstoppableAsh()
        {
            Name = "Unstoppable Ash";
            Edition = "MOR";
            Rarity = "R";
            Color = "G";
            Cost = "3G";
            PT = "5/5";
            Type = "Creature - Treefolk Warrior";
            Text = "Trample;^Champion a Treefolk or Warrior @(When this enters the battlefield, sacrifice it unless you exile another Treefolk or Warrior you control. When this leaves the battlefield, that card returns to the battlefield.)@;^Whenever a creature you control becomes blocked, it gets +0/+5 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Vendilion Clique
    public class VendilionClique : MagicCard
    {
        public VendilionClique()
        {
            Name = "Vendilion Clique";
            Edition = "MOR";
            Rarity = "R";
            Color = "U";
            Cost = "1UU";
            PT = "3/1";
            Type = "Legendary Creature - Faerie Wizard";
            Text = "Flash;^Flying;^When Vendilion Clique enters the battlefield, look at target player's hand. You may choose a nonland card from it. If you do, that player reveals the chosen card, puts it on the bottom of his or her library, then draws a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Vengeful Firebrand
    public class VengefulFirebrand : MagicCard
    {
        public VengefulFirebrand()
        {
            Name = "Vengeful Firebrand";
            Edition = "MOR";
            Rarity = "R";
            Color = "R";
            Cost = "3R";
            PT = "5/2";
            Type = "Creature - Elemental Warrior";
            Text = "Vengeful Firebrand has haste as long as a Warrior card is in your graveyard.^%R: Vengeful Firebrand gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Veteran's Armaments
    public class VeteransArmaments : MagicCard
    {
        public VeteransArmaments()
        {
            Name = "Veteran's Armaments";
            Edition = "MOR";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Tribal Artifact - Soldier Equipment";
            Text = "Equipped creature has 'Whenever this creature attacks or blocks, it gets +1/+1 until end of turn for each attacking creature.';^Whenever a Soldier creature enters the battlefield, you may attach Veteran's Armaments to it.;^Equip %2";
            Flavor = "";
        }
    }
    # endregion

    # region Violet Pall
    public class VioletPall : MagicCard
    {
        public VioletPall()
        {
            Name = "Violet Pall";
            Edition = "MOR";
            Rarity = "C";
            Color = "B";
            Cost = "4B";
            PT = "";
            Type = "Tribal Instant - Faerie";
            Text = "Destroy target nonblack creature. Put a 1/1 black Faerie Rogue creature token with flying onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Walker of the Grove
    public class WalkeroftheGrove : MagicCard
    {
        public WalkeroftheGrove()
        {
            Name = "Walker of the Grove";
            Edition = "MOR";
            Rarity = "U";
            Color = "G";
            Cost = "6GG";
            PT = "7/7";
            Type = "Creature - Elemental";
            Text = "When Walker of the Grove leaves the battlefield, put a 4/4 green Elemental creature token onto the battlefield.;^Evoke %4%G @(You may cast this spell for its evoke cost. If you do, it's sacrificed when it enters the battlefield.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wandering Graybeard
    public class WanderingGraybeard : MagicCard
    {
        public WanderingGraybeard()
        {
            Name = "Wandering Graybeard";
            Edition = "MOR";
            Rarity = "U";
            Color = "W";
            Cost = "3WW";
            PT = "4/4";
            Type = "Creature - Giant Wizard";
            Text = "@Kinship@ ' At the beginning of your upkeep, you may look at the top card of your library. If it shares a creature type with Wandering Graybeard, you may reveal it. If you do, you gain 4 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Warren Weirding
    public class WarrenWeirding : MagicCard
    {
        public WarrenWeirding()
        {
            Name = "Warren Weirding";
            Edition = "MOR";
            Rarity = "U";
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
    public class WarSpikeChangeling : MagicCard
    {
        public WarSpikeChangeling()
        {
            Name = "War-Spike Changeling";
            Edition = "MOR";
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

    # region Waterspout Weavers
    public class WaterspoutWeavers : MagicCard
    {
        public WaterspoutWeavers()
        {
            Name = "Waterspout Weavers";
            Edition = "MOR";
            Rarity = "U";
            Color = "U";
            Cost = "3UU";
            PT = "3/3";
            Type = "Creature - Merfolk Wizard";
            Text = "@Kinship@ ' At the beginning of your upkeep, you may look at the top card of your library. If it shares a creature type with Waterspout Weavers, you may reveal it. If you do, each creature you control gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Weed-Pruner Poplar
    public class WeedPrunerPoplar : MagicCard
    {
        public WeedPrunerPoplar()
        {
            Name = "Weed-Pruner Poplar";
            Edition = "MOR";
            Rarity = "C";
            Color = "B";
            Cost = "4B";
            PT = "3/3";
            Type = "Creature - Treefolk Assassin";
            Text = "At the beginning of your upkeep, target creature other than Weed-Pruner Poplar gets -1/-1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Weight of Conscience
    public class WeightofConscience : MagicCard
    {
        public WeightofConscience()
        {
            Name = "Weight of Conscience";
            Edition = "MOR";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature can't attack.;^Tap two untapped creatures you control that share a creature type: Exile enchanted creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Weirding Shaman
    public class WeirdingShaman : MagicCard
    {
        public WeirdingShaman()
        {
            Name = "Weirding Shaman";
            Edition = "MOR";
            Rarity = "R";
            Color = "B";
            Cost = "1B";
            PT = "2/1";
            Type = "Creature - Goblin Shaman";
            Text = "%3%B, Sacrifice a Goblin: Put two 1/1 black Goblin Rogue creature tokens onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Winnower Patrol
    public class WinnowerPatrol : MagicCard
    {
        public WinnowerPatrol()
        {
            Name = "Winnower Patrol";
            Edition = "MOR";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "3/2";
            Type = "Creature - Elf Warrior";
            Text = "@Kinship@ ' At the beginning of your upkeep, you may look at the top card of your library. If it shares a creature type with Winnower Patrol, you may reveal it. If you do, put a +1/+1 counter on Winnower Patrol.";
            Flavor = "";
        }
    }
    # endregion

    # region Wolf-Skull Shaman
    public class WolfSkullShaman : MagicCard
    {
        public WolfSkullShaman()
        {
            Name = "Wolf-Skull Shaman";
            Edition = "MOR";
            Rarity = "U";
            Color = "G";
            Cost = "1G";
            PT = "2/2";
            Type = "Creature - Elf Shaman";
            Text = "@Kinship@ ' At the beginning of your upkeep, you may look at the top card of your library. If it shares a creature type with Wolf-Skull Shaman, you may reveal it. If you do, put a 2/2 green Wolf creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion


    # endregion

    # region Shadowmoor
    # region Advice from the Fae
    public class AdvicefromtheFae : MagicCard
    {
        public AdvicefromtheFae()
        {
            Name = "Advice from the Fae";
            Edition = "SHM";
            Rarity = "U";
            Color = "U";
            Cost = "%F%F%F";
            PT = "";
            Type = "Sorcery";
            Text = "@(%F can be paid with any two mana or with %U. This card�s converted mana cost is 6.)@;^Look at the top five cards of your library. If you control more creatures than each other player, put two of those cards into your hand. Otherwise, put one of them into your hand. Then put the rest on the bottom of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region AEthertow
    public class AEthertow : MagicCard
    {
        public AEthertow()
        {
            Name = "AEthertow";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "3%D";
            PT = "";
            Type = "Instant";
            Text = "Put target attacking or blocking creature on top of its owner�s library.;^Conspire @(As you cast this spell, you may tap two untapped creatures you control that share a color with it. When you do, copy it and you may choose a new target for the copy.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Aphotic Wisps
    public class AphoticWisps : MagicCard
    {
        public AphoticWisps()
        {
            Name = "Aphotic Wisps";
            Edition = "SHM";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Instant";
            Text = "Target creature becomes black and gains fear until end of turn. @(It can�t be blocked except by artifact creatures and/or black creatures.)@;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Apothecary Initiate
    public class ApothecaryInitiate : MagicCard
    {
        public ApothecaryInitiate()
        {
            Name = "Apothecary Initiate";
            Edition = "SHM";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "1/1";
            Type = "Creature - Kithkin Cleric";
            Text = "Whenever a player casts a white spell, you may pay %1. If you do, you gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Armored Ascension
    public class ArmoredAscension : MagicCard
    {
        public ArmoredAscension()
        {
            Name = "Armored Ascension";
            Edition = "SHM";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature gets +1/+1 for each Plains you control and has flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Ashenmoor Cohort
    public class AshenmoorCohort : MagicCard
    {
        public AshenmoorCohort()
        {
            Name = "Ashenmoor Cohort";
            Edition = "SHM";
            Rarity = "C";
            Color = "B";
            Cost = "5B";
            PT = "4/3";
            Type = "Creature - Elemental Warrior";
            Text = "Ashenmoor Cohort gets +1/+1 as long as you control another black creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Ashenmoor Gouger
    public class AshenmoorGouger : MagicCard
    {
        public AshenmoorGouger()
        {
            Name = "Ashenmoor Gouger";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "%K%K%K";
            PT = "4/4";
            Type = "Creature - Elemental Warrior";
            Text = "Ashenmoor Gouger can�t block.";
            Flavor = "";
        }
    }
    # endregion

    # region Ashenmoor Liege
    public class AshenmoorLiege : MagicCard
    {
        public AshenmoorLiege()
        {
            Name = "Ashenmoor Liege";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "1%K%K%K";
            PT = "4/1";
            Type = "Creature - Elemental Knight";
            Text = "Other black creatures you control get +1/+1.;^Other red creatures you control get +1/+1.;^Whenever Ashenmoor Liege becomes target of a spell or ability an opponent controls, that player loses 4 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Augury Adept
    public class AuguryAdept : MagicCard
    {
        public AuguryAdept()
        {
            Name = "Augury Adept";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "1%D%D";
            PT = "2/2";
            Type = "Creature - Kithkin Wizard";
            Text = "Whenever Augury Adept deals combat damage to a player, reveal the top card of your library and put that card into your hand. You gain life equal to its converted mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Ballynock Cohort
    public class BallynockCohort : MagicCard
    {
        public BallynockCohort()
        {
            Name = "Ballynock Cohort";
            Edition = "SHM";
            Rarity = "C";
            Color = "W";
            Cost = "2W";
            PT = "2/2";
            Type = "Creature - Kithkin Soldier";
            Text = "First strike;^Ballynock Cohort gets +1/+1 as long as you control another white creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Barkshell Blessing
    public class BarkshellBlessing : MagicCard
    {
        public BarkshellBlessing()
        {
            Name = "Barkshell Blessing";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "%A";
            PT = "";
            Type = "Instant";
            Text = "Target creature gets +2/+2 until end of turn.;^Conspire @(As you cast this spell, you may tap two untapped creatures you control that share a color with it. When you do, copy it and you may choose a new target for the copy.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Barrenton Cragtreads
    public class BarrentonCragtreads : MagicCard
    {
        public BarrentonCragtreads()
        {
            Name = "Barrenton Cragtreads";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%D%D";
            PT = "3/3";
            Type = "Creature - Kithkin Scout";
            Text = "Barrenton Cragtreads can�t be blocked by red creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Barrenton Medic
    public class BarrentonMedic : MagicCard
    {
        public BarrentonMedic()
        {
            Name = "Barrenton Medic";
            Edition = "SHM";
            Rarity = "C";
            Color = "W";
            Cost = "4W";
            PT = "0/4";
            Type = "Creature - Kithkin Cleric";
            Text = "%T: Prevent the next 1 damage that would be dealt to target creature or player this turn.;^Put a -1/-1 counter on Barrenton Medic: Untap Barrenton Medic.";
            Flavor = "";
        }
    }
    # endregion

    # region Beseech the Queen
    public class BeseechtheQueen : MagicCard
    {
        public BeseechtheQueen()
        {
            Name = "Beseech the Queen";
            Edition = "SHM";
            Rarity = "U";
            Color = "B";
            Cost = "%H%H%H";
            PT = "";
            Type = "Sorcery";
            Text = "@(%H can be paid with any two mana or with %B. This card�s converted mana cost is 6.)@;^Search your library for a card with converted mana cost less than or equal to the number of lands you control, reveal it, and put it into your hand. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Biting Tether
    public class BitingTether : MagicCard
    {
        public BitingTether()
        {
            Name = "Biting Tether";
            Edition = "SHM";
            Rarity = "U";
            Color = "U";
            Cost = "4U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^You control enchanted creature.;^At the beginning of you upkeep, put a -1/-1 counter on enchanted creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Blazethorn Scarecrow
    public class BlazethornScarecrow : MagicCard
    {
        public BlazethornScarecrow()
        {
            Name = "Blazethorn Scarecrow";
            Edition = "SHM";
            Rarity = "C";
            Color = "Art";
            Cost = "5";
            PT = "3/3";
            Type = "Artifact Creature - Scarecrow";
            Text = "Blazethorn Scarecrow has haste as long as you control a red creature.;^Blazethorn Scarecrow has wither as long as you control a green creature. @(It deals damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Blight Sickle
    public class BlightSickle : MagicCard
    {
        public BlightSickle()
        {
            Name = "Blight Sickle";
            Edition = "SHM";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature gets +1/+0 and has wither. @(It deals damage to creatures in the form of -1/-1 counters.)@;^Equip %2";
            Flavor = "";
        }
    }
    # endregion

    # region Blistering Dieflyn
    public class BlisteringDieflyn : MagicCard
    {
        public BlisteringDieflyn()
        {
            Name = "Blistering Dieflyn";
            Edition = "SHM";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "0/1";
            Type = "Creature - Imp";
            Text = "Flying;^%K: Blistering Dieflyn gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Bloodmark Mentor
    public class BloodmarkMentor : MagicCard
    {
        public BloodmarkMentor()
        {
            Name = "Bloodmark Mentor";
            Edition = "SHM";
            Rarity = "U";
            Color = "R";
            Cost = "1R";
            PT = "1/1";
            Type = "Creature - Goblin Warrior";
            Text = "Red creatures you control have first strike.";
            Flavor = "";
        }
    }
    # endregion

    # region Bloodshed Fever
    public class BloodshedFever : MagicCard
    {
        public BloodshedFever()
        {
            Name = "Bloodshed Fever";
            Edition = "SHM";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature attacks each turn if able.";
            Flavor = "";
        }
    }
    # endregion

    # region Blowfly Infestation
    public class BlowflyInfestation : MagicCard
    {
        public BlowflyInfestation()
        {
            Name = "Blowfly Infestation";
            Edition = "SHM";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a creature dies, if it had a -1/-1 counter on it, put a -1/-1 counter on target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Boartusk Liege
    public class BoartuskLiege : MagicCard
    {
        public BoartuskLiege()
        {
            Name = "Boartusk Liege";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "1%L%L%L";
            PT = "3/4";
            Type = "Creature - Goblin Knight";
            Text = "Trample;^Other red creatures you control get +1/+1.;^Other green creatures you control get +1/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Boggart Arsonists
    public class BoggartArsonists : MagicCard
    {
        public BoggartArsonists()
        {
            Name = "Boggart Arsonists";
            Edition = "SHM";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "2/1";
            Type = "Creature - Goblin Rogue";
            Text = "Plainswalk;^%2%R, Sacrifice Boggart Arsonists: Destroy target Scarecrow or Plains.";
            Flavor = "";
        }
    }
    # endregion

    # region Boggart Ram-Gang
    public class BoggartRamGang : MagicCard
    {
        public BoggartRamGang()
        {
            Name = "Boggart Ram-Gang";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "%L%L%L";
            PT = "3/3";
            Type = "Creature - Goblin Warrior";
            Text = "Haste;^Wither @(This deals damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Boon Reflection
    public class BoonReflection : MagicCard
    {
        public BoonReflection()
        {
            Name = "Boon Reflection";
            Edition = "SHM";
            Rarity = "R";
            Color = "W";
            Cost = "4W";
            PT = "";
            Type = "Enchantment";
            Text = "If you would gain life, you gain twice that much life instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Briarberry Cohort
    public class BriarberryCohort : MagicCard
    {
        public BriarberryCohort()
        {
            Name = "Briarberry Cohort";
            Edition = "SHM";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Faerie Soldier";
            Text = "Flying;^Briarberry Cohort gets +1/+1 as long as you control another blue creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Burn Trail
    public class BurnTrail : MagicCard
    {
        public BurnTrail()
        {
            Name = "Burn Trail";
            Edition = "SHM";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Sorcery";
            Text = "Burn Trail deals 3 damage to target creature or player.;^Conspire @(As you cast this spell, you may tap two untapped creatures you control that share a color with it. When you do, copy it and you may choose a new target for the copy.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Cauldron of Souls
    public class CauldronofSouls : MagicCard
    {
        public CauldronofSouls()
        {
            Name = "Cauldron of Souls";
            Edition = "SHM";
            Rarity = "R";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "%T: Choose any number of target creatures. Each of those creatures gains persist until end of turn. @(When it dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Cemetery Puca
    public class CemeteryPuca : MagicCard
    {
        public CemeteryPuca()
        {
            Name = "Cemetery Puca";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "1%V%V";
            PT = "1/2";
            Type = "Creature - Shapeshifter";
            Text = "Whenever a creature dies, you may pay %1. If you do, Cemetery Puca becomes a copy of that creature and gains this ability.";
            Flavor = "";
        }
    }
    # endregion

    # region Cerulean Wisps
    public class CeruleanWisps : MagicCard
    {
        public CeruleanWisps()
        {
            Name = "Cerulean Wisps";
            Edition = "SHM";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Target creature becomes blue until end of turn. Untap that creature.;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Chainbreaker
    public class Chainbreaker : MagicCard
    {
        public Chainbreaker()
        {
            Name = "Chainbreaker";
            Edition = "SHM";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "3/3";
            Type = "Artifact Creature - Scarecrow";
            Text = "Chainbreaker enters the battlefield with two -1/-1 counters on it.;^%3, %T: Remove a -1/-1 counter from target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Cinderbones
    public class Cinderbones : MagicCard
    {
        public Cinderbones()
        {
            Name = "Cinderbones";
            Edition = "SHM";
            Rarity = "C";
            Color = "B";
            Cost = "2B";
            PT = "1/1";
            Type = "Creature - Elemental Skeleton";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^%1%B: Regenerate Cinderbones";
            Flavor = "";
        }
    }
    # endregion

    # region Cinderhaze Wretch
    public class CinderhazeWretch : MagicCard
    {
        public CinderhazeWretch()
        {
            Name = "Cinderhaze Wretch";
            Edition = "SHM";
            Rarity = "C";
            Color = "B";
            Cost = "4B";
            PT = "3/2";
            Type = "Creature - Elemental Shaman";
            Text = "%T: Target player discards a card. Activate this ability only during your turn.;^Put a -1/-1 counter on Cinderhaze Wretch: Untap Cinderhaze Wretch.";
            Flavor = "";
        }
    }
    # endregion

    # region Consign to Dream
    public class ConsigntoDream : MagicCard
    {
        public ConsigntoDream()
        {
            Name = "Consign to Dream";
            Edition = "SHM";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Instant";
            Text = "Return target permanent to its owner�s hand. If that permanent is red or green, put it on top of its owner�s library instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Corrosive Mentor
    public class CorrosiveMentor : MagicCard
    {
        public CorrosiveMentor()
        {
            Name = "Corrosive Mentor";
            Edition = "SHM";
            Rarity = "U";
            Color = "B";
            Cost = "2B";
            PT = "1/3";
            Type = "Creature - Elemental Rogue";
            Text = "Black creatures you control have wither. @(They deal damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Corrupt
    public class CorruptSHM : MagicCard
    {
        public CorruptSHM()
        {
            Name = "Corrupt";
            Edition = "SHM";
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

    # region Counterbore
    public class Counterbore : MagicCard
    {
        public Counterbore()
        {
            Name = "Counterbore";
            Edition = "SHM";
            Rarity = "R";
            Color = "U";
            Cost = "3UU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell. Search its controller�s graveyard, hand, and library for all cards with the same name as that spell and exile them. Then that player shuffles his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Crabapple Cohort
    public class CrabappleCohort : MagicCard
    {
        public CrabappleCohort()
        {
            Name = "Crabapple Cohort";
            Edition = "SHM";
            Rarity = "C";
            Color = "G";
            Cost = "4G";
            PT = "4/4";
            Type = "Creature - Treefolk Warrior";
            Text = "Crabapple Cohort gets +1/+1 as long as you control another green creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Cragganwick Cremator
    public class CragganwickCremator : MagicCard
    {
        public CragganwickCremator()
        {
            Name = "Cragganwick Cremator";
            Edition = "SHM";
            Rarity = "R";
            Color = "R";
            Cost = "2RR";
            PT = "5/4";
            Type = "Creature - Giant Shaman";
            Text = "When Cragganwick Cremator enters the battlefield, discard a card at random. If you discard a creature card this way, Cragganwick Cremator deals damage equal to that card�s power to target player.";
            Flavor = "";
        }
    }
    # endregion

    # region Crimson Wisps
    public class CrimsonWisps : MagicCard
    {
        public CrimsonWisps()
        {
            Name = "Crimson Wisps";
            Edition = "SHM";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Instant";
            Text = "Target creature becomes red and gains haste until end of turn.;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Crowd of Cinders
    public class CrowdofCinders : MagicCard
    {
        public CrowdofCinders()
        {
            Name = "Crowd of Cinders";
            Edition = "SHM";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "*/*";
            Type = "Creature - Elemental";
            Text = "Fear @(This creature can�t be blocked except by artifact creatures and/or black creatures.)@;^Crowd of Cinders�s power and toughness are each equal to the number of black permanents you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Cultbrand Cinder
    public class CultbrandCinder : MagicCard
    {
        public CultbrandCinder()
        {
            Name = "Cultbrand Cinder";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "4%K";
            PT = "3/3";
            Type = "Creature - Elemental Shaman";
            Text = "When Cultbrand Cinder enters the battlefield, put a -1/-1 counter on target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Curse of Chains
    public class CurseofChains : MagicCard
    {
        public CurseofChains()
        {
            Name = "Curse of Chains";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%D";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^At the beginning of each upkeep, tap enchanted creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Cursecatcher
    public class Cursecatcher : MagicCard
    {
        public Cursecatcher()
        {
            Name = "Cursecatcher";
            Edition = "SHM";
            Rarity = "U";
            Color = "U";
            Cost = "U";
            PT = "1/1";
            Type = "Creature - Merfolk Wizard";
            Text = "Sacrifice Cursecatcher: Counter target instant or sorcery spell unless its controller pays %1.";
            Flavor = "";
        }
    }
    # endregion

    # region Dawnglow Infusion
    public class DawnglowInfusion : MagicCard
    {
        public DawnglowInfusion()
        {
            Name = "Dawnglow Infusion";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "X%A";
            PT = "";
            Type = "Sorcery";
            Text = "You gain X life if %G was spent to cast Dawnglow Infusion and X life if %W was spent to cast it. @(Do both if %G%W was spent.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Deepchannel Mentor
    public class DeepchannelMentor : MagicCard
    {
        public DeepchannelMentor()
        {
            Name = "Deepchannel Mentor";
            Edition = "SHM";
            Rarity = "U";
            Color = "U";
            Cost = "5U";
            PT = "2/2";
            Type = "Creature - Merfolk Rogue";
            Text = "Blue creatures you control can�t be blocked.";
            Flavor = "";
        }
    }
    # endregion

    # region Deep-Slumber Titan
    public class DeepSlumberTitan : MagicCard
    {
        public DeepSlumberTitan()
        {
            Name = "Deep-Slumber Titan";
            Edition = "SHM";
            Rarity = "R";
            Color = "R";
            Cost = "2RR";
            PT = "7/7";
            Type = "Creature - Giant Warrior";
            Text = "Deep-Slumber Titan enters the battlefield tapped.;^Deep-Slumber Titan doesn�t untap during your untap step.;^Whenever Deep-Slumber Titan is dealt damage, untap it.";
            Flavor = "";
        }
    }
    # endregion

    # region Demigod of Revenge
    public class DemigodofRevenge : MagicCard
    {
        public DemigodofRevenge()
        {
            Name = "Demigod of Revenge";
            Edition = "SHM";
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

    # region Deus of Calamity
    public class DeusofCalamity : MagicCard
    {
        public DeusofCalamity()
        {
            Name = "Deus of Calamity";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "%L%L%L%L%L";
            PT = "6/6";
            Type = "Creature - Spirit Avatar";
            Text = "Trample;^Whenever Deus of Calamity deals 6 or more damage to an opponent, destroy target land that player controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Devoted Druid
    public class DevotedDruid : MagicCard
    {
        public DevotedDruid()
        {
            Name = "Devoted Druid";
            Edition = "SHM";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "0/2";
            Type = "Creature - Elf Druid";
            Text = "%T: Add %G to your mana pool.;^Put a -1/-1 counter on Devoted Druid: Untap Devoted Druid.";
            Flavor = "";
        }
    }
    # endregion

    # region Din of the Fireherd
    public class DinoftheFireherd : MagicCard
    {
        public DinoftheFireherd()
        {
            Name = "Din of the Fireherd";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "5%K%K%K";
            PT = "";
            Type = "Sorcery";
            Text = "Put a 5/5 black and red Elemental creature token onto the battlefield. Target opponent sacrifices a creature for each black creature you control, then sacrifices a land for each red creature you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Dire Undercurrents
    public class DireUndercurrents : MagicCard
    {
        public DireUndercurrents()
        {
            Name = "Dire Undercurrents";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "3%V%V";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a blue creature enters the battlefield under your control, you may have target player draw a card.;^Whenever a black creature enters the battlefield under your control, you may have target player discard a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Disturbing Plot
    public class DisturbingPlot : MagicCard
    {
        public DisturbingPlot()
        {
            Name = "Disturbing Plot";
            Edition = "SHM";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Sorcery";
            Text = "Return target creature card from a graveyard to its owner�s hand.;^Conspire @(As you cast this spell, you may tap two untapped creatures you control that share a color with it. When you do, copy it and you may choose a new target for the copy.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Dramatic Entrance
    public class DramaticEntrance : MagicCard
    {
        public DramaticEntrance()
        {
            Name = "Dramatic Entrance";
            Edition = "SHM";
            Rarity = "R";
            Color = "G";
            Cost = "3GG";
            PT = "";
            Type = "Instant";
            Text = "You may put a green creature card from your hand onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Dream Salvage
    public class DreamSalvage : MagicCard
    {
        public DreamSalvage()
        {
            Name = "Dream Salvage";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "%V";
            PT = "";
            Type = "Instant";
            Text = "Draw cards equal to the number of cards target opponent discarded this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Drove of Elves
    public class DroveofElves : MagicCard
    {
        public DroveofElves()
        {
            Name = "Drove of Elves";
            Edition = "SHM";
            Rarity = "U";
            Color = "G";
            Cost = "3G";
            PT = "*/*";
            Type = "Creature - Elf";
            Text = "Hexproof @(This creature can�t be the target of spells or abilities your opponents control.)@;^Drove of Elves�s power and toughness are each equal to the number of green permanents you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Drowner Initiate
    public class DrownerInitiate : MagicCard
    {
        public DrownerInitiate()
        {
            Name = "Drowner Initiate";
            Edition = "SHM";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "1/1";
            Type = "Creature - Merfolk Wizard";
            Text = "Whenever a player casts a blue spell, you may pay %1. If you do, target player puts the top two cards of his or her library into his or her graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Dusk Urchins
    public class DuskUrchins : MagicCard
    {
        public DuskUrchins()
        {
            Name = "Dusk Urchins";
            Edition = "SHM";
            Rarity = "R";
            Color = "B";
            Cost = "2B";
            PT = "4/3";
            Type = "Creature - Ouphe";
            Text = "Whenever Dusk Urchins attacks or blocks, put a -1/-1 counter on it.;^When Dusk Urchins dies, draw a card for each -1/-1 counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Elemental Mastery
    public class ElementalMastery : MagicCard
    {
        public ElementalMastery()
        {
            Name = "Elemental Mastery";
            Edition = "SHM";
            Rarity = "R";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature has �%T: Put X 1/1 red Elemental creature tokens with haste onto the battlefield, where X is this creature�s power. Exile them at the beginning of the next end step.�";
            Flavor = "";
        }
    }
    # endregion

    # region Elsewhere Flask
    public class ElsewhereFlask : MagicCard
    {
        public ElsewhereFlask()
        {
            Name = "Elsewhere Flask";
            Edition = "SHM";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "When Elsewhere Flask enters the battlefield, draw a card.;^Sacrifice Elsewhere Flask: Choose a basic land type. Each land you control becomes that type until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Elvish Hexhunter
    public class ElvishHexhunter : MagicCard
    {
        public ElvishHexhunter()
        {
            Name = "Elvish Hexhunter";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "%A";
            PT = "1/1";
            Type = "Creature - Elf Shaman";
            Text = "%A, %T, Sacrifice Elvish Hexhunter: Destroy target enchantment.";
            Flavor = "";
        }
    }
    # endregion

    # region Ember Gale
    public class EmberGale : MagicCard
    {
        public EmberGale()
        {
            Name = "Ember Gale";
            Edition = "SHM";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Sorcery";
            Text = "Creatures target player controls can�t block this turn. Ember Gale deals 1 damage to each white and/or blue creature that player controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Emberstrike Duo
    public class EmberstrikeDuo : MagicCard
    {
        public EmberstrikeDuo()
        {
            Name = "Emberstrike Duo";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%K";
            PT = "1/1";
            Type = "Creature - Elemental Warrior Shaman";
            Text = "Whenever you cast a black spell, Emberstrike Duo gets +1/+1 until end of turn.;^Whenever you cast a red spell, Emberstrike Duo gains first strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Enchanted Evening
    public class EnchantedEvening : MagicCard
    {
        public EnchantedEvening()
        {
            Name = "Enchanted Evening";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "3%D%D";
            PT = "";
            Type = "Enchantment";
            Text = "All permanents are enchantments in addition to their other types.";
            Flavor = "";
        }
    }
    # endregion

    # region Everlasting Torment
    public class EverlastingTorment : MagicCard
    {
        public EverlastingTorment()
        {
            Name = "Everlasting Torment";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "2%K";
            PT = "";
            Type = "Enchantment";
            Text = "Players can�t gain life.;^Damage can�t be prevented.;^All damage is dealt as though its source had wither. @(A source with wither deals damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Faerie Macabre
    public class FaerieMacabre : MagicCard
    {
        public FaerieMacabre()
        {
            Name = "Faerie Macabre";
            Edition = "SHM";
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

    # region Faerie Swarm
    public class FaerieSwarm : MagicCard
    {
        public FaerieSwarm()
        {
            Name = "Faerie Swarm";
            Edition = "SHM";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "*/*";
            Type = "Creature - Faerie";
            Text = "Flying;^Faerie Swarm�s power and toughness are each equal to the number of blue permanents you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Farhaven Elf
    public class FarhavenElf : MagicCard
    {
        public FarhavenElf()
        {
            Name = "Farhaven Elf";
            Edition = "SHM";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "1/1";
            Type = "Creature - Elf Druid";
            Text = "When Farhaven Elf enters the battlefield, you may search your library for a basic land card and put it onto the battlefield tapped. If you do, shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Fate Transfer
    public class FateTransfer : MagicCard
    {
        public FateTransfer()
        {
            Name = "Fate Transfer";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%V";
            PT = "";
            Type = "Instant";
            Text = "Move all counters from target creature onto another target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Fire-Lit Thicket
    public class FireLitThicket : MagicCard
    {
        public FireLitThicket()
        {
            Name = "Fire-Lit Thicket";
            Edition = "SHM";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%L, %T: Add %R%R, %R%G, or %G%G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Firespout
    public class Firespout : MagicCard
    {
        public Firespout()
        {
            Name = "Firespout";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%L";
            PT = "";
            Type = "Sorcery";
            Text = "Firespout deals 3 damage to each creature without flying if %R was spent to cast Firespout and 3 damage to each creature with flying if %G was spent to cast it. @(Do both if %R%G was spent.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Fists of the Demigod
    public class FistsoftheDemigod : MagicCard
    {
        public FistsoftheDemigod()
        {
            Name = "Fists of the Demigod";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%K";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^As long as enchanted creature is black, it gets +1/+1 and has wither. @(It deals damage to creatures in the form of -1/-1 counters.)@;^As long as enchanted creature is red, it gets +1/+1 and has first strike.";
            Flavor = "";
        }
    }
    # endregion

    # region Flame Javelin
    public class FlameJavelin : MagicCard
    {
        public FlameJavelin()
        {
            Name = "Flame Javelin";
            Edition = "SHM";
            Rarity = "U";
            Color = "R";
            Cost = "%J%J%J";
            PT = "";
            Type = "Instant";
            Text = "@(%J can be paid with any two mana or with %R. This card�s converted mana cost is 6.)@;^Flame Javelin deals 4 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Flourishing Defenses
    public class FlourishingDefenses : MagicCard
    {
        public FlourishingDefenses()
        {
            Name = "Flourishing Defenses";
            Edition = "SHM";
            Rarity = "U";
            Color = "G";
            Cost = "4G";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a -1/-1 counter is placed on a creature, you may put a 1/1 green Elf Warrior creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Flow of Ideas
    public class FlowofIdeas : MagicCard
    {
        public FlowofIdeas()
        {
            Name = "Flow of Ideas";
            Edition = "SHM";
            Rarity = "U";
            Color = "U";
            Cost = "5U";
            PT = "";
            Type = "Sorcery";
            Text = "Draw a card for each Island you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Forest
    public class ForestSHM : MagicCard
    {
        public ForestSHM()
        {
            Name = "Forest";
            Edition = "SHM";
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

    # region Fossil Find
    public class FossilFind : MagicCard
    {
        public FossilFind()
        {
            Name = "Fossil Find";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "%L";
            PT = "";
            Type = "Sorcery";
            Text = "Return a card at random from your graveyard to your hand, then reorder your graveyard as you choose.";
            Flavor = "";
        }
    }
    # endregion

    # region Foxfire Oak
    public class FoxfireOak : MagicCard
    {
        public FoxfireOak()
        {
            Name = "Foxfire Oak";
            Edition = "SHM";
            Rarity = "C";
            Color = "G";
            Cost = "5G";
            PT = "3/6";
            Type = "Creature - Treefolk Shaman";
            Text = "%L%L%L: Foxfire Oak gets +3/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Fracturing Gust
    public class FracturingGust : MagicCard
    {
        public FracturingGust()
        {
            Name = "Fracturing Gust";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "2%A%A%A";
            PT = "";
            Type = "Instant";
            Text = "Destroy all artifacts and enchantments. You gain 2 life for each permanent destroyed this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Fulminator Mage
    public class FulminatorMage : MagicCard
    {
        public FulminatorMage()
        {
            Name = "Fulminator Mage";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "1%K%K";
            PT = "2/2";
            Type = "Creature - Elemental Shaman";
            Text = "Sacrifice Fulminator Mage: Destroy target nonbasic land.";
            Flavor = "";
        }
    }
    # endregion

    # region Furystoke Giant
    public class FurystokeGiant : MagicCard
    {
        public FurystokeGiant()
        {
            Name = "Furystoke Giant";
            Edition = "SHM";
            Rarity = "R";
            Color = "R";
            Cost = "3RR";
            PT = "3/3";
            Type = "Creature - Giant Warrior";
            Text = "When Furystoke Giant enters the battlefield, other creatures you control gain �%T: This creature deals 2 damage to target creature or player� until end of turn.;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Ghastlord of Fugue
    public class GhastlordofFugue : MagicCard
    {
        public GhastlordofFugue()
        {
            Name = "Ghastlord of Fugue";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "%V%V%V%V%V";
            PT = "4/4";
            Type = "Creature - Spirit Avatar";
            Text = "Ghastlord of Fugue can�t be blocked.;^Whenever Ghastlord of Fugue deals combat damage to a player, that player reveals his or her hand. You choose a card from it. That player exiles that card.";
            Flavor = "";
        }
    }
    # endregion

    # region Ghastly Discovery
    public class GhastlyDiscovery : MagicCard
    {
        public GhastlyDiscovery()
        {
            Name = "Ghastly Discovery";
            Edition = "SHM";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Sorcery";
            Text = "Draw two cards, then discard a card.;^Conspire @(As you cast this spell, you may tap two untapped creatures you control that share a color with it. When you do, copy it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Giantbaiting
    public class Giantbaiting : MagicCard
    {
        public Giantbaiting()
        {
            Name = "Giantbaiting";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%L";
            PT = "";
            Type = "Sorcery";
            Text = "Put a 4/4 red and green Giant Warrior creature token with haste onto the battlefield. Exile it at the beginning of the next end step.;^Conspire @(As you cast this spell, you may tap two untapped creatures you control that share a color with it. When you do, copy it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Glamer Spinners
    public class GlamerSpinners : MagicCard
    {
        public GlamerSpinners()
        {
            Name = "Glamer Spinners";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "4%D";
            PT = "2/4";
            Type = "Creature - Faerie Wizard";
            Text = "Flash;^Flying;^When Glamer Spinners enters the battlefield, attach all Auras enchanting target permanent to another permanent with the same controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Gleeful Sabotage
    public class GleefulSabotage : MagicCard
    {
        public GleefulSabotage()
        {
            Name = "Gleeful Sabotage";
            Edition = "SHM";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target artifact or enchantment.;^Conspire @(As you cast this spell, you may tap two untapped creatures you control that share a color with it. When you do, copy it and you may choose a new target for the copy.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Glen Elendra Liege
    public class GlenElendraLiege : MagicCard
    {
        public GlenElendraLiege()
        {
            Name = "Glen Elendra Liege";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "1%V%V%V";
            PT = "2/3";
            Type = "Creature - Faerie Knight";
            Text = "Flying;^Other blue creatures you control get +1/+1.;^Other black creatures you control get +1/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Gloomlance
    public class Gloomlance : MagicCard
    {
        public Gloomlance()
        {
            Name = "Gloomlance";
            Edition = "SHM";
            Rarity = "C";
            Color = "B";
            Cost = "3BB";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target creature. If that creature was green or white, its controller discards a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Gloomwidow
    public class Gloomwidow : MagicCard
    {
        public Gloomwidow()
        {
            Name = "Gloomwidow";
            Edition = "SHM";
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

    # region Gloomwidow's Feast
    public class GloomwidowsFeast : MagicCard
    {
        public GloomwidowsFeast()
        {
            Name = "Gloomwidow's Feast";
            Edition = "SHM";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Instant";
            Text = "Destroy target creature with flying. If that creature was blue or black, put a 1/2 green Spider creature token with reach onto the battlefield. @(It can block creatures with flying.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Gnarled Effigy
    public class GnarledEffigy : MagicCard
    {
        public GnarledEffigy()
        {
            Name = "Gnarled Effigy";
            Edition = "SHM";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "";
            Type = "Artifact";
            Text = "%4, %T: Put a -1/-1 counter on target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Godhead of Awe
    public class GodheadofAwe : MagicCard
    {
        public GodheadofAwe()
        {
            Name = "Godhead of Awe";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "%D%D%D%D%D";
            PT = "4/4";
            Type = "Creature - Spirit Avatar";
            Text = "Flying;^Other creatures are 1/1.";
            Flavor = "";
        }
    }
    # endregion

    # region Goldenglow Moth
    public class GoldenglowMoth : MagicCard
    {
        public GoldenglowMoth()
        {
            Name = "Goldenglow Moth";
            Edition = "SHM";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "0/1";
            Type = "Creature - Insect";
            Text = "Flying;^Whenever Goldenglow Moth blocks, you may gain 4 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Gravelgill Axeshark
    public class GravelgillAxeshark : MagicCard
    {
        public GravelgillAxeshark()
        {
            Name = "Gravelgill Axeshark";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "4%V";
            PT = "3/3";
            Type = "Creature - Merfolk Soldier";
            Text = "Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Gravelgill Duo
    public class GravelgillDuo : MagicCard
    {
        public GravelgillDuo()
        {
            Name = "Gravelgill Duo";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%V";
            PT = "2/1";
            Type = "Creature - Merfolk Rogue Warrior";
            Text = "Whenever you cast a blue spell, Gravelgill Duo gets +1/+1 until end of turn.;^Whenever you cast a black spell, Gravelgill Duo gains fear until end of turn. @(It can�t be blocked except by artifact creatures and/or black creatures.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Graven Cairns
    public class GravenCairns : MagicCard
    {
        public GravenCairns()
        {
            Name = "Graven Cairns";
            Edition = "SHM";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%K, %T: Add %B%B, %B%R, or %R%R to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Greater Auramancy
    public class GreaterAuramancy : MagicCard
    {
        public GreaterAuramancy()
        {
            Name = "Greater Auramancy";
            Edition = "SHM";
            Rarity = "R";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Enchantment";
            Text = "Other enchantments you control have shroud.;^Enchanted creatures you control have shroud.";
            Flavor = "";
        }
    }
    # endregion

    # region Grief Tyrant
    public class GriefTyrant : MagicCard
    {
        public GriefTyrant()
        {
            Name = "Grief Tyrant";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "5%K";
            PT = "8/8";
            Type = "Creature - Horror";
            Text = "Grief Tyrant enters the battlefield with four -1/-1 counters on it.;^When Grief Tyrant dies, put a -1/-1 counter on target creature for each -1/-1 counter on Grief Tyrant.";
            Flavor = "";
        }
    }
    # endregion

    # region Grim Poppet
    public class GrimPoppet : MagicCard
    {
        public GrimPoppet()
        {
            Name = "Grim Poppet";
            Edition = "SHM";
            Rarity = "R";
            Color = "Art";
            Cost = "7";
            PT = "4/4";
            Type = "Artifact Creature - Scarecrow";
            Text = "Grim Poppet enters the battlefield with three -1/-1 counters on it.;^Remove a -1/-1 counter from Grim Poppet: Put a -1/-1 counter on another target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Guttural Response
    public class GutturalResponse : MagicCard
    {
        public GutturalResponse()
        {
            Name = "Guttural Response";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "%L";
            PT = "";
            Type = "Instant";
            Text = "Counter target blue instant spell.";
            Flavor = "";
        }
    }
    # endregion

    # region Heap Doll
    public class HeapDoll : MagicCard
    {
        public HeapDoll()
        {
            Name = "Heap Doll";
            Edition = "SHM";
            Rarity = "U";
            Color = "Art";
            Cost = "1";
            PT = "1/1";
            Type = "Artifact Creature - Scarecrow";
            Text = "Sacrifice Heap Doll: Exile target card from a graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Heartmender
    public class Heartmender : MagicCard
    {
        public Heartmender()
        {
            Name = "Heartmender";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "2%A%A";
            PT = "2/2";
            Type = "Creature - Elemental";
            Text = "At the beginning of your upkeep, remove a -1/-1 counter from each creature you control.;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Helm of the Ghastlord
    public class HelmoftheGhastlord : MagicCard
    {
        public HelmoftheGhastlord()
        {
            Name = "Helm of the Ghastlord";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "3%V";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^As long as enchanted creature is blue, it gets +1/+1 and has �Whenever this creature deals damage to an opponent, draw a card.�;^As long as enchanted creature is black, it gets +1/+1 and has �Whenver this creature deals damage to an opponent, that player discards a card.�";
            Flavor = "";
        }
    }
    # endregion

    # region Hollowborn Barghest
    public class HollowbornBarghest : MagicCard
    {
        public HollowbornBarghest()
        {
            Name = "Hollowborn Barghest";
            Edition = "SHM";
            Rarity = "R";
            Color = "B";
            Cost = "5BB";
            PT = "7/6";
            Type = "Creature - Demon Hound";
            Text = "At the beginning of your upkeep, if you have no cards in hand, each opponent loses 2 life.;^At the beginning of each opponent�s upkeep, if that player has no cards in hand, he or she loses 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Hollowsage
    public class Hollowsage : MagicCard
    {
        public Hollowsage()
        {
            Name = "Hollowsage";
            Edition = "SHM";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "2/2";
            Type = "Creature - Merfolk Wizard";
            Text = "Whenever Hollowsage becomes untapped, you may have target player discard a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Horde of Boggarts
    public class HordeofBoggarts : MagicCard
    {
        public HordeofBoggarts()
        {
            Name = "Horde of Boggarts";
            Edition = "SHM";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "*/*";
            Type = "Creature - Goblin";
            Text = "Horde of Boggart�s power and toughness are each equal to the number of red permanents you control.;^Horde of Boggarts can�t be blocked except by two or more creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Howl of the Night Pack
    public class HowloftheNightPackSHM : MagicCard
    {
        public HowloftheNightPackSHM()
        {
            Name = "Howl of the Night Pack";
            Edition = "SHM";
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

    # region Hungry Spriggan
    public class HungrySpriggan : MagicCard
    {
        public HungrySpriggan()
        {
            Name = "Hungry Spriggan";
            Edition = "SHM";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "1/1";
            Type = "Creature - Goblin Warrior";
            Text = "Trample;^Whenever Hungry Spriggan attacks, it gets +3/+3 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Illuminated Folio
    public class IlluminatedFolio : MagicCard
    {
        public IlluminatedFolio()
        {
            Name = "Illuminated Folio";
            Edition = "SHM";
            Rarity = "U";
            Color = "Art";
            Cost = "5";
            PT = "";
            Type = "Artifact";
            Text = "%1, %T, Reveal two cards from your hand that share a color: Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Impromptu Raid
    public class ImpromptuRaid : MagicCard
    {
        public ImpromptuRaid()
        {
            Name = "Impromptu Raid";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "3%L";
            PT = "";
            Type = "Enchantment";
            Text = "%2%L: Reveal the top card of your library. If it isn�t a creature card, put it into your graveyard. Otherwise, put that card onto the battlefield. That creature gains haste. Sacrifice it at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Incremental Blight
    public class IncrementalBlight : MagicCard
    {
        public IncrementalBlight()
        {
            Name = "Incremental Blight";
            Edition = "SHM";
            Rarity = "U";
            Color = "B";
            Cost = "3BB";
            PT = "";
            Type = "Sorcery";
            Text = "Put a -1/-1 counter on target creature, two -1/-1 counters on another target creature, and three -1/-1 counters on a third target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Inescapable Brute
    public class InescapableBrute : MagicCard
    {
        public InescapableBrute()
        {
            Name = "Inescapable Brute";
            Edition = "SHM";
            Rarity = "C";
            Color = "R";
            Cost = "5R";
            PT = "3/3";
            Type = "Creature - Giant Warrior";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^Inescapable Brute must be blocked if able.";
            Flavor = "";
        }
    }
    # endregion

    # region Inkfathom Infiltrator
    public class InkfathomInfiltrator : MagicCard
    {
        public InkfathomInfiltrator()
        {
            Name = "Inkfathom Infiltrator";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "%V%V";
            PT = "2/1";
            Type = "Creature - Merfolk Rogue";
            Text = "Inkfathom Infiltrator can�t block and can�t be blocked.";
            Flavor = "";
        }
    }
    # endregion

    # region Inkfathom Witch
    public class InkfathomWitch : MagicCard
    {
        public InkfathomWitch()
        {
            Name = "Inkfathom Witch";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "1%V";
            PT = "1/1";
            Type = "Creature - Merfolk Wizard";
            Text = "Fear @(This creature can�t be blocked except by artifact creatures and/or black creatures.)@;^%2%U%B: Each unblocked creature becomes 4/1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Inquisitor's Snare
    public class InquisitorsSnare : MagicCard
    {
        public InquisitorsSnare()
        {
            Name = "Inquisitor's Snare";
            Edition = "SHM";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Prevent all damage target attacking or blocking creature would deal this turn. If that creature is black or red, destroy it.";
            Flavor = "";
        }
    }
    # endregion

    # region Intimidator Initiate
    public class IntimidatorInitiate : MagicCard
    {
        public IntimidatorInitiate()
        {
            Name = "Intimidator Initiate";
            Edition = "SHM";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "1/1";
            Type = "Creature - Goblin Shaman";
            Text = "Whenever a player casts a red spell, you may pay %1. If you do, target creature can�t block this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Island
    public class IslandSHM : MagicCard
    {
        public IslandSHM()
        {
            Name = "Island";
            Edition = "SHM";
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

    # region Isleback Spawn
    public class IslebackSpawn : MagicCard
    {
        public IslebackSpawn()
        {
            Name = "Isleback Spawn";
            Edition = "SHM";
            Rarity = "R";
            Color = "U";
            Cost = "5UU";
            PT = "4/8";
            Type = "Creature - Kraken";
            Text = "Shroud;^Isleback Spawn gets +4/+8 as long as a library has twenty or fewer cards in it.";
            Flavor = "";
        }
    }
    # endregion

    # region Jaws of Stone
    public class JawsofStone : MagicCard
    {
        public JawsofStone()
        {
            Name = "Jaws of Stone";
            Edition = "SHM";
            Rarity = "U";
            Color = "R";
            Cost = "5R";
            PT = "";
            Type = "Sorcery";
            Text = "Jaws of Stone deals X damage divided as you choose among any number of target creatures and/or players, where X is the number of Mountains you control as you cast Jaws of Stone.";
            Flavor = "";
        }
    }
    # endregion

    # region Juvenile Gloomwidow
    public class JuvenileGloomwidow : MagicCard
    {
        public JuvenileGloomwidow()
        {
            Name = "Juvenile Gloomwidow";
            Edition = "SHM";
            Rarity = "C";
            Color = "G";
            Cost = "GG";
            PT = "1/3";
            Type = "Creature - Spider";
            Text = "Reach @(This can block creatures with flying.)@;^Wither @(This deals damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Kinscaer Harpoonist
    public class KinscaerHarpoonist : MagicCard
    {
        public KinscaerHarpoonist()
        {
            Name = "Kinscaer Harpoonist";
            Edition = "SHM";
            Rarity = "C";
            Color = "U";
            Cost = "3U";
            PT = "2/2";
            Type = "Creature - Kithkin Soldier";
            Text = "Flying;^Whenever Kinscaer Harpoonist attacks, you may have target creature lose flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Kitchen Finks
    public class KitchenFinks : MagicCard
    {
        public KitchenFinks()
        {
            Name = "Kitchen Finks";
            Edition = "SHM";
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

    # region Kithkin Rabble
    public class KithkinRabble : MagicCard
    {
        public KithkinRabble()
        {
            Name = "Kithkin Rabble";
            Edition = "SHM";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "*/*";
            Type = "Creature - Kithkin";
            Text = "Vigilance;^Kithkin Rabble�s power and toughness are each equal to the number of white permanents you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Kithkin Shielddare
    public class KithkinShielddare : MagicCard
    {
        public KithkinShielddare()
        {
            Name = "Kithkin Shielddare";
            Edition = "SHM";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "1/1";
            Type = "Creature - Kithkin Soldier";
            Text = "%W, %T: Target blocking creature gets +2/+2 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Knacksaw Clique
    public class KnacksawClique : MagicCard
    {
        public KnacksawClique()
        {
            Name = "Knacksaw Clique";
            Edition = "SHM";
            Rarity = "R";
            Color = "U";
            Cost = "3U";
            PT = "1/4";
            Type = "Creature - Faerie Rogue";
            Text = "Flying;^%1%U, %C: Target opponent exiles the top card of his or her library. Until end of turn, you may play that card. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Knollspine Dragon
    public class KnollspineDragon : MagicCard
    {
        public KnollspineDragon()
        {
            Name = "Knollspine Dragon";
            Edition = "SHM";
            Rarity = "R";
            Color = "R";
            Cost = "5RR";
            PT = "7/5";
            Type = "Creature - Dragon";
            Text = "Flying;^When Knollspine Dragon enters the battlefield, you may discard your hand and draw cards equal to the damage dealt to target opponent this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Knollspine Invocation
    public class KnollspineInvocation : MagicCard
    {
        public KnollspineInvocation()
        {
            Name = "Knollspine Invocation";
            Edition = "SHM";
            Rarity = "R";
            Color = "R";
            Cost = "1RR";
            PT = "";
            Type = "Enchantment";
            Text = "%X, Discard a card with converted mana cost X: Knollspine Invocation deals X damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Kulrath Knight
    public class KulrathKnight : MagicCard
    {
        public KulrathKnight()
        {
            Name = "Kulrath Knight";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "3%K%K";
            PT = "3/3";
            Type = "Creature - Elemental Knight";
            Text = "Flying;^Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^Creatures your opponents control with counters on them can�t attack or block.";
            Flavor = "";
        }
    }
    # endregion

    # region Last Breath
    public class LastBreathSHM : MagicCard
    {
        public LastBreathSHM()
        {
            Name = "Last Breath";
            Edition = "SHM";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Instant";
            Text = "Exile target creature with power 2 or less. Its controller gains 4 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Leech Bonder
    public class LeechBonder : MagicCard
    {
        public LeechBonder()
        {
            Name = "Leech Bonder";
            Edition = "SHM";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "3/3";
            Type = "Creature - Merfolk Soldier";
            Text = "Leech Bonder enters the battlefield with two -1/-1 counters on it.;^%U, %C: Move a counter from target creature onto another target creature. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Leechridden Swamp
    public class LeechriddenSwamp : MagicCard
    {
        public LeechriddenSwamp()
        {
            Name = "Leechridden Swamp";
            Edition = "SHM";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Swamp";
            Text = "@(%T: Add %B to your mana pool.)@;^Leechridden Swamp enters the battlefield tapped.;^%B, %T: Each opponent loses 1 life. Activate this ability only if you control two or more black permanents.";
            Flavor = "";
        }
    }
    # endregion

    # region Loamdragger Giant
    public class LoamdraggerGiant : MagicCard
    {
        public LoamdraggerGiant()
        {
            Name = "Loamdragger Giant";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "4%L%L%L";
            PT = "7/6";
            Type = "Creature - Giant Warrior";
            Text = "";
            Flavor = "Giants sleep soundly and long, sometimes for long enough that a crust of earth and moss grows over them. But inevitably something disturbs their slumber, and they wake unhappy.";
        }
    }
    # endregion

    # region Loch Korrigan
    public class LochKorrigan : MagicCard
    {
        public LochKorrigan()
        {
            Name = "Loch Korrigan";
            Edition = "SHM";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "1/1";
            Type = "Creature - Spirit";
            Text = "%V: Loch Korrigan gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Lockjaw Snapper
    public class LockjawSnapper : MagicCard
    {
        public LockjawSnapper()
        {
            Name = "Lockjaw Snapper";
            Edition = "SHM";
            Rarity = "U";
            Color = "Art";
            Cost = "4";
            PT = "2/2";
            Type = "Artifact Creature - Scarecrow";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^When Lockjaw Snapper dies, put a -1/-1 counter on each creature with a -1/-1 counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Lurebound Scarecrow
    public class LureboundScarecrow : MagicCard
    {
        public LureboundScarecrow()
        {
            Name = "Lurebound Scarecrow";
            Edition = "SHM";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "4/4";
            Type = "Artifact Creature - Scarecrow";
            Text = "As Lurebound Scarecrow enters the battlefield, choose a color.;^When you control no permanents of the chosen color, sacrifice Lurebound Scarecrow.";
            Flavor = "";
        }
    }
    # endregion

    # region Madblind Mountain
    public class MadblindMountain : MagicCard
    {
        public MadblindMountain()
        {
            Name = "Madblind Mountain";
            Edition = "SHM";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Mountain";
            Text = "@(%T: Add %R to your mana pool.)@;^Madblind Mountain enters the battlefield tapped.;^%R, %T: Shuffle your library. Activate this ability only if you control two or more red permanents.";
            Flavor = "";
        }
    }
    # endregion

    # region Mana Reflection
    public class ManaReflection : MagicCard
    {
        public ManaReflection()
        {
            Name = "Mana Reflection";
            Edition = "SHM";
            Rarity = "R";
            Color = "G";
            Cost = "4GG";
            PT = "";
            Type = "Enchantment";
            Text = "If you tap a permanent for mana, it produces twice as much of that mana instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Manaforge Cinder
    public class ManaforgeCinder : MagicCard
    {
        public ManaforgeCinder()
        {
            Name = "Manaforge Cinder";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "%K";
            PT = "1/1";
            Type = "Creature - Elemental Shaman";
            Text = "%1: Add %B or %R to your mana pool. Activate this ability no more than three times each turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Manamorphose
    public class Manamorphose : MagicCard
    {
        public Manamorphose()
        {
            Name = "Manamorphose";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%L";
            PT = "";
            Type = "Instant";
            Text = "Add two mana in any combination of colors to your mana pool.;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Mass Calcify
    public class MassCalcify : MagicCard
    {
        public MassCalcify()
        {
            Name = "Mass Calcify";
            Edition = "SHM";
            Rarity = "R";
            Color = "W";
            Cost = "5WW";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy all nonwhite creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Medicine Runner
    public class MedicineRunner : MagicCard
    {
        public MedicineRunner()
        {
            Name = "Medicine Runner";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%A";
            PT = "2/1";
            Type = "Creature - Elf Cleric";
            Text = "When Medicine Runner enters the battlefield, you may remove a counter from target permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Memory Plunder
    public class MemoryPlunder : MagicCard
    {
        public MemoryPlunder()
        {
            Name = "Memory Plunder";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "%V%V%V%V";
            PT = "";
            Type = "Instant";
            Text = "You may cast target instant or sorcery card from an opponent�s graveyard without paying its mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Memory Sluice
    public class MemorySluice : MagicCard
    {
        public MemorySluice()
        {
            Name = "Memory Sluice";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "%V";
            PT = "";
            Type = "Sorcery";
            Text = "Target player puts the top four cards of his or her library into his or her graveyard.;^Conspire @(As you cast this spell, you may tap two untapped creatures you control that share a color with it. When you do, copy it and you may choose a new target for the copy.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Mercy Killing
    public class MercyKilling : MagicCard
    {
        public MercyKilling()
        {
            Name = "Mercy Killing";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%A";
            PT = "";
            Type = "Instant";
            Text = "Target creature�s controller sacrifices it, then puts X 1/1 green and white Elf Warrior creature tokens onto the battlefield, where X is that creature�s power.";
            Flavor = "";
        }
    }
    # endregion

    # region Merrow Grimeblotter
    public class MerrowGrimeblotter : MagicCard
    {
        public MerrowGrimeblotter()
        {
            Name = "Merrow Grimeblotter";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "3%V";
            PT = "2/2";
            Type = "Creature - Merfolk Wizard";
            Text = "%1%V, %C: Target creature gets -2/-0 until end of turn. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Merrow Wavebreakers
    public class MerrowWavebreakers : MagicCard
    {
        public MerrowWavebreakers()
        {
            Name = "Merrow Wavebreakers";
            Edition = "SHM";
            Rarity = "C";
            Color = "U";
            Cost = "4U";
            PT = "3/3";
            Type = "Creature - Merfolk Soldier";
            Text = "%1%U, %C: Merrow Wavebreakers gains flying until end of turn. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Midnight Banshee
    public class MidnightBanshee : MagicCard
    {
        public MidnightBanshee()
        {
            Name = "Midnight Banshee";
            Edition = "SHM";
            Rarity = "R";
            Color = "B";
            Cost = "3BBB";
            PT = "5/5";
            Type = "Creature - Spirit";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^At the beginning of your upkeep, put a -1/-1 counter on each nonblack creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Mine Excavation
    public class MineExcavation : MagicCard
    {
        public MineExcavation()
        {
            Name = "Mine Excavation";
            Edition = "SHM";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "";
            Type = "Sorcery";
            Text = "Return target artifact or enchantment card from a graveyard to its owner�s hand.;^Conspire @(As you cast this spell, you may tap two untapped creatures you control that share a color with it. When you do, copy it and you may choose a new target for the copy.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Mirrorweave
    public class Mirrorweave : MagicCard
    {
        public Mirrorweave()
        {
            Name = "Mirrorweave";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "2%D%D";
            PT = "";
            Type = "Instant";
            Text = "Each other creature becomes a copy of target nonlegendary creature until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Mistmeadow Skulk
    public class MistmeadowSkulk : MagicCard
    {
        public MistmeadowSkulk()
        {
            Name = "Mistmeadow Skulk";
            Edition = "SHM";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "1/1";
            Type = "Creature - Kithkin Rogue";
            Text = "Lifelink, protection from converted mana cost 3 or greater";
            Flavor = "";
        }
    }
    # endregion

    # region Mistmeadow Witch
    public class MistmeadowWitch : MagicCard
    {
        public MistmeadowWitch()
        {
            Name = "Mistmeadow Witch";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "1%D";
            PT = "1/1";
            Type = "Creature - Kithkin Wizard";
            Text = "%2%W%U: Exile target creature. Return that card to the battlefield under its owner�s control at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Mistveil Plains
    public class MistveilPlains : MagicCard
    {
        public MistveilPlains()
        {
            Name = "Mistveil Plains";
            Edition = "SHM";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Plains";
            Text = "@(%T: Add %W to your mana pool.)@;^Mistveil Plains enters the battlefield tapped.;^%W, %T: Put target card from your graveyard on the bottom of your library. Activate this ability only if you control two or more white permanents.";
            Flavor = "";
        }
    }
    # endregion

    # region Moonring Island
    public class MoonringIsland : MagicCard
    {
        public MoonringIsland()
        {
            Name = "Moonring Island";
            Edition = "SHM";
            Rarity = "U";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land - Island";
            Text = "@(%T: Add %U to your mana pool.)@;^Moonring Island enters the battlefield tapped.;^%U, %T: Look at the top card of target player�s library. Activate this ability only if you control two or more blue permanents.";
            Flavor = "";
        }
    }
    # endregion

    # region Morselhoarder
    public class Morselhoarder : MagicCard
    {
        public Morselhoarder()
        {
            Name = "Morselhoarder";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "4%L%L";
            PT = "6/4";
            Type = "Creature - Elemental";
            Text = "Morselhoarder enters the battlefield with two -1/-1 counters on it.;^Remove a -1/-1 counter from Morselhoarder: Add one mana of any color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Mossbridge Troll
    public class MossbridgeTroll : MagicCard
    {
        public MossbridgeTroll()
        {
            Name = "Mossbridge Troll";
            Edition = "SHM";
            Rarity = "R";
            Color = "G";
            Cost = "5GG";
            PT = "5/5";
            Type = "Creature - Troll";
            Text = "If Mossbridge Troll would be destroyed, regenerate it.;^Tap any number of untapped creatures you control other than Mossbridge Troll with total power 10 or greater: Mossbridge Troll gets +20/+20 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Mountain
    public class MountainSHM : MagicCard
    {
        public MountainSHM()
        {
            Name = "Mountain";
            Edition = "SHM";
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

    # region Mudbrawler Cohort
    public class MudbrawlerCohort : MagicCard
    {
        public MudbrawlerCohort()
        {
            Name = "Mudbrawler Cohort";
            Edition = "SHM";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "1/1";
            Type = "Creature - Goblin Warrior";
            Text = "Haste;^Mudbrawler Cohort gets +1/+1 as long as you control another red creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Mudbrawler Raiders
    public class MudbrawlerRaiders : MagicCard
    {
        public MudbrawlerRaiders()
        {
            Name = "Mudbrawler Raiders";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%L%L";
            PT = "3/3";
            Type = "Creature - Goblin Warrior";
            Text = "Mudbrawler Raiders can�t be blocked by blue creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Murderous Redcap
    public class MurderousRedcap : MagicCard
    {
        public MurderousRedcap()
        {
            Name = "Murderous Redcap";
            Edition = "SHM";
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

    # region Mystic Gate
    public class MysticGate : MagicCard
    {
        public MysticGate()
        {
            Name = "Mystic Gate";
            Edition = "SHM";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%D, %T: Add %W%W, %W%U, or %U%U to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Niveous Wisps
    public class NiveousWisps : MagicCard
    {
        public NiveousWisps()
        {
            Name = "Niveous Wisps";
            Edition = "SHM";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Target creature becomes white until end of turn. Tap that creature.;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Nurturer Initiate
    public class NurturerInitiate : MagicCard
    {
        public NurturerInitiate()
        {
            Name = "Nurturer Initiate";
            Edition = "SHM";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Elf Shaman";
            Text = "Whenever a player casts a green spell, you may pay %1. If you do, target creature gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Old Ghastbark
    public class OldGhastbark : MagicCard
    {
        public OldGhastbark()
        {
            Name = "Old Ghastbark";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "3%A%A";
            PT = "3/6";
            Type = "Creature - Treefolk Warrior";
            Text = "";
            Flavor = "�Beware of trees that talk. Their words are threats. And mind the ones that sway and creak. They too threaten us, but in a foreign tongue.�;^�@The Book of Other Folk@";
        }
    }
    # endregion

    # region Oona, Queen of the Fae
    public class OonaQueenoftheFae : MagicCard
    {
        public OonaQueenoftheFae()
        {
            Name = "Oona, Queen of the Fae";
            Edition = "SHM";
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

    # region Oona's Gatewarden
    public class OonasGatewarden : MagicCard
    {
        public OonasGatewarden()
        {
            Name = "Oona's Gatewarden";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "%V";
            PT = "2/1";
            Type = "Creature - Faerie Soldier";
            Text = "Defender, flying;^Wither @(This deals damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Oracle of Nectars
    public class OracleofNectars : MagicCard
    {
        public OracleofNectars()
        {
            Name = "Oracle of Nectars";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "2%A";
            PT = "2/2";
            Type = "Creature - Elf Cleric";
            Text = "%X, %T: You gain X life.";
            Flavor = "";
        }
    }
    # endregion

    # region Order of Whiteclay
    public class OrderofWhiteclay : MagicCard
    {
        public OrderofWhiteclay()
        {
            Name = "Order of Whiteclay";
            Edition = "SHM";
            Rarity = "R";
            Color = "W";
            Cost = "1WW";
            PT = "1/4";
            Type = "Creature - Kithkin Cleric";
            Text = "%1%W%W, %C: Return target creature card with converted mana cost 3 or less from your graveyard to the battlefield. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Oversoul of Dusk
    public class OversoulofDusk : MagicCard
    {
        public OversoulofDusk()
        {
            Name = "Oversoul of Dusk";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "%A%A%A%A%A";
            PT = "5/5";
            Type = "Creature - Spirit Avatar";
            Text = "Protection from blue, from black, and from red";
            Flavor = "";
        }
    }
    # endregion

    # region Painter's Servant
    public class PaintersServant : MagicCard
    {
        public PaintersServant()
        {
            Name = "Painter's Servant";
            Edition = "SHM";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "1/3";
            Type = "Artifact Creature - Scarecrow";
            Text = "As Painter�s Servant enters the battlefield, choose a color.;^All cards that aren�t on the battlefield, spells, and permanents are the chosen color in addition to their other colors.";
            Flavor = "";
        }
    }
    # endregion

    # region Pale Wayfarer
    public class PaleWayfarer : MagicCard
    {
        public PaleWayfarer()
        {
            Name = "Pale Wayfarer";
            Edition = "SHM";
            Rarity = "U";
            Color = "W";
            Cost = "5WW";
            PT = "4/4";
            Type = "Creature - Spirit Giant";
            Text = "%2%W%W, %C: Target creature gains protection from the color of its controller�s choice until end of turn. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Parapet Watchers
    public class ParapetWatchers : MagicCard
    {
        public ParapetWatchers()
        {
            Name = "Parapet Watchers";
            Edition = "SHM";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "2/2";
            Type = "Creature - Kithkin Soldier";
            Text = "%D: Parapet Watchers gets +0/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Pili-Pala
    public class PiliPala : MagicCard
    {
        public PiliPala()
        {
            Name = "Pili-Pala";
            Edition = "SHM";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "1/1";
            Type = "Artifact Creature - Scarecrow";
            Text = "Flying;^%2, %C: Add one mana of any color to your mana pool. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Plague of Vermin
    public class PlagueofVermin : MagicCard
    {
        public PlagueofVermin()
        {
            Name = "Plague of Vermin";
            Edition = "SHM";
            Rarity = "R";
            Color = "B";
            Cost = "6B";
            PT = "";
            Type = "Sorcery";
            Text = "Starting with you, each player may pay any amount of life. Repeat this process until no one pays life. Each player puts a 1/1 black Rat creature token onto the battlefield for each 1 life he or she paid this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Plains
    public class PlainsSHM : MagicCard
    {
        public PlainsSHM()
        {
            Name = "Plains";
            Edition = "SHM";
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

    # region Plumeveil
    public class Plumeveil : MagicCard
    {
        public Plumeveil()
        {
            Name = "Plumeveil";
            Edition = "SHM";
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

    # region Poison the Well
    public class PoisontheWell : MagicCard
    {
        public PoisontheWell()
        {
            Name = "Poison the Well";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%K%K";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target land. Poison the Well deals 2 damage to that land�s controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Polluted Bonds
    public class PollutedBonds : MagicCard
    {
        public PollutedBonds()
        {
            Name = "Polluted Bonds";
            Edition = "SHM";
            Rarity = "R";
            Color = "B";
            Cost = "3BB";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a land enters the battlefield under an opponent�s control, that player loses 2 life and you gain 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Power of Fire
    public class PowerofFire : MagicCard
    {
        public PowerofFire()
        {
            Name = "Power of Fire";
            Edition = "SHM";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature has �%T: This creature deals 1 damage to target creature or player.�";
            Flavor = "";
        }
    }
    # endregion

    # region Presence of Gond
    public class PresenceofGond : MagicCard
    {
        public PresenceofGond()
        {
            Name = "Presence of Gond";
            Edition = "SHM";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature has �%T: Put a 1/1 green Elf Warrior creature token onto the battlefield.�";
            Flavor = "";
        }
    }
    # endregion

    # region Prismatic Omen
    public class PrismaticOmen : MagicCard
    {
        public PrismaticOmen()
        {
            Name = "Prismatic Omen";
            Edition = "SHM";
            Rarity = "R";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Enchantment";
            Text = "Lands you control are every basic land type in addition to their other types.";
            Flavor = "";
        }
    }
    # endregion

    # region Prismwake Merrow
    public class PrismwakeMerrow : MagicCard
    {
        public PrismwakeMerrow()
        {
            Name = "Prismwake Merrow";
            Edition = "SHM";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "2/1";
            Type = "Creature - Merfolk Wizard";
            Text = "Flash;^When Prismwake Merrow enters the battlefield, target permanent becomes the color or colors of your choice until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Prison Term
    public class PrisonTerm : MagicCard
    {
        public PrisonTerm()
        {
            Name = "Prison Term";
            Edition = "SHM";
            Rarity = "U";
            Color = "W";
            Cost = "1WW";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature can�t attack or block, and its activated abilities can�t be activated.;^Whenever a creature enters the battlefield under an opponent�s control, you may attach Prison Term to that creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Puca's Mischief
    public class PucasMischief : MagicCard
    {
        public PucasMischief()
        {
            Name = "Puca's Mischief";
            Edition = "SHM";
            Rarity = "R";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of your upkeep, you may exchange control of target nonland permanent you control and target nonland permanent an opponent controls with an equal or lesser converted mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Puncture Bolt
    public class PunctureBolt : MagicCard
    {
        public PunctureBolt()
        {
            Name = "Puncture Bolt";
            Edition = "SHM";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "Puncture Bolt deals 1 damage to target creature. Put a -1/-1 counter on that creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Puppeteer Clique
    public class PuppeteerClique : MagicCard
    {
        public PuppeteerClique()
        {
            Name = "Puppeteer Clique";
            Edition = "SHM";
            Rarity = "R";
            Color = "B";
            Cost = "3BB";
            PT = "3/2";
            Type = "Creature - Faerie Wizard";
            Text = "Flying;^When Puppeteer Clique enters the battlefield, put target creature card from an opponent�s graveyard onto the battlefield under your control. It gains haste. At the beginning of your next end step, exile it.;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Puresight Merrow
    public class PuresightMerrow : MagicCard
    {
        public PuresightMerrow()
        {
            Name = "Puresight Merrow";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "%D%D";
            PT = "2/2";
            Type = "Creature - Merfolk Wizard";
            Text = "%D, %C: Look at the top card of your library. You may exile that card. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Put Away
    public class PutAway : MagicCard
    {
        public PutAway()
        {
            Name = "Put Away";
            Edition = "SHM";
            Rarity = "C";
            Color = "U";
            Cost = "2UU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell. You may shuffle up to one target card from your graveyard into your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Pyre Charger
    public class PyreCharger : MagicCard
    {
        public PyreCharger()
        {
            Name = "Pyre Charger";
            Edition = "SHM";
            Rarity = "U";
            Color = "R";
            Cost = "RR";
            PT = "1/1";
            Type = "Creature - Elemental Warrior";
            Text = "Haste;^%R: Pyre Charger gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Rage Reflection
    public class RageReflection : MagicCard
    {
        public RageReflection()
        {
            Name = "Rage Reflection";
            Edition = "SHM";
            Rarity = "R";
            Color = "R";
            Cost = "4RR";
            PT = "";
            Type = "Enchantment";
            Text = "Creatures you control have double strike.";
            Flavor = "";
        }
    }
    # endregion

    # region Raking Canopy
    public class RakingCanopy : MagicCard
    {
        public RakingCanopy()
        {
            Name = "Raking Canopy";
            Edition = "SHM";
            Rarity = "U";
            Color = "G";
            Cost = "1GG";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever a creature with flying attacks you, Raking Canopy deals 4 damage to it.";
            Flavor = "";
        }
    }
    # endregion

    # region Rattleblaze Scarecrow
    public class RattleblazeScarecrow : MagicCard
    {
        public RattleblazeScarecrow()
        {
            Name = "Rattleblaze Scarecrow";
            Edition = "SHM";
            Rarity = "C";
            Color = "Art";
            Cost = "6";
            PT = "5/3";
            Type = "Artifact Creature - Scarecrow";
            Text = "Rattleblaze Scarecrow has persist as long as you control a black creature. @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@;^Rattleblaze Scarecrow has haste as long as you control a red creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Raven's Run Dragoon
    public class RavensRunDragoon : MagicCard
    {
        public RavensRunDragoon()
        {
            Name = "Raven's Run Dragoon";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%A%A";
            PT = "3/3";
            Type = "Creature - Elf Knight";
            Text = "Raven�s Run Dragoon can�t be blocked by black creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Reaper King
    public class ReaperKing : MagicCard
    {
        public ReaperKing()
        {
            Name = "Reaper King";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "%E%F%H%J%M";
            PT = "6/6";
            Type = "Legendary Artifact Creature - Scarecrow";
            Text = "@(%E can be paid with any two mana or with %W. This card�s converted mana cost is 10.)@;^Other Scarecrow creatures you control get +1/+1.;^Whenever another Scarecrow enters the battlefield under your control, destroy target permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Reflecting Pool
    public class ReflectingPool : MagicCard
    {
        public ReflectingPool()
        {
            Name = "Reflecting Pool";
            Edition = "SHM";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add to your mana pool one mana of any type that a land you control could produce.";
            Flavor = "";
        }
    }
    # endregion

    # region Reknit
    public class Reknit : MagicCard
    {
        public Reknit()
        {
            Name = "Reknit";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "1%A";
            PT = "";
            Type = "Instant";
            Text = "Regenerate target permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Repel Intruders
    public class RepelIntruders : MagicCard
    {
        public RepelIntruders()
        {
            Name = "Repel Intruders";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "3%D";
            PT = "";
            Type = "Instant";
            Text = "Put two 1/1 white Kithkin Soldier creature tokens onto the battlefield if %W was spent to cast Repel Intruders. Counter up to one target creature spell if %U was spent to cast Repel Intruders. @(Do both if %W%U was spent.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Resplendent Mentor
    public class ResplendentMentor : MagicCard
    {
        public ResplendentMentor()
        {
            Name = "Resplendent Mentor";
            Edition = "SHM";
            Rarity = "U";
            Color = "W";
            Cost = "4W";
            PT = "2/2";
            Type = "Creature - Kithkin Cleric";
            Text = "White creatures you control have �%T: You gain 1 life.�";
            Flavor = "";
        }
    }
    # endregion

    # region Revelsong Horn
    public class RevelsongHorn : MagicCard
    {
        public RevelsongHorn()
        {
            Name = "Revelsong Horn";
            Edition = "SHM";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%1, %T, Tap an untapped creature you control: Target creature gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Rhys the Redeemed
    public class RhystheRedeemed : MagicCard
    {
        public RhystheRedeemed()
        {
            Name = "Rhys the Redeemed";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "%A";
            PT = "1/1";
            Type = "Legendary Creature - Elf Warrior";
            Text = "%2%A, %T: Put a 1/1 green and white Elf Warrior creature token onto the battlefield.;^%4%A%A, %T: For each creature token you control, put a token that�s a copy of that creature onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Rite of Consumption
    public class RiteofConsumption : MagicCard
    {
        public RiteofConsumption()
        {
            Name = "Rite of Consumption";
            Edition = "SHM";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Sorcery";
            Text = "As an additional cost to cast Rite of Consumption, sacrifice a creature.;^Rite of Consumption deals damage equal to the sacrificed creature�s power to target player. You gain life equal to the damage dealt this way.";
            Flavor = "";
        }
    }
    # endregion

    # region River Kelpie
    public class RiverKelpie : MagicCard
    {
        public RiverKelpie()
        {
            Name = "River Kelpie";
            Edition = "SHM";
            Rarity = "R";
            Color = "U";
            Cost = "3UU";
            PT = "3/3";
            Type = "Creature - Beast";
            Text = "Whenever River Kelpie or another permanent enters the battlefield from a graveyard, draw a card.;^Whenever a player casts a spell from a graveyard, draw a card.;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region River's Grasp
    public class RiversGrasp : MagicCard
    {
        public RiversGrasp()
        {
            Name = "River's Grasp";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "3%V";
            PT = "";
            Type = "Sorcery";
            Text = "If %U was spent to cast River�s Grasp, return up to one target creature to its owner�s hand. If %B was spent to cast River�s Grasp, target player reveals his or her hand, you choose a nonland card from it, then that player discards that card. @(Do both if %U%B was spent.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Rosheen Meanderer
    public class RosheenMeanderer : MagicCard
    {
        public RosheenMeanderer()
        {
            Name = "Rosheen Meanderer";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "3%L";
            PT = "4/4";
            Type = "Legendary Creature - Giant Shaman";
            Text = "%T: Add %4 to your mana pool. Spend this mana only on costs that contain %X.";
            Flavor = "";
        }
    }
    # endregion

    # region Roughshod Mentor
    public class RoughshodMentor : MagicCard
    {
        public RoughshodMentor()
        {
            Name = "Roughshod Mentor";
            Edition = "SHM";
            Rarity = "U";
            Color = "G";
            Cost = "5G";
            PT = "5/4";
            Type = "Creature - Giant Warrior";
            Text = "Green creatures you control have trample.";
            Flavor = "";
        }
    }
    # endregion

    # region Rune-Cervin Rider
    public class RuneCervinRider : MagicCard
    {
        public RuneCervinRider()
        {
            Name = "Rune-Cervin Rider";
            Edition = "SHM";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "2/2";
            Type = "Creature - Elf Knight";
            Text = "Flying;^%A%A: Rune-Cervin Rider gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Runed Halo
    public class RunedHalo : MagicCard
    {
        public RunedHalo()
        {
            Name = "Runed Halo";
            Edition = "SHM";
            Rarity = "R";
            Color = "W";
            Cost = "WW";
            PT = "";
            Type = "Enchantment";
            Text = "As Runed Halo enters the battlefield, name a card.;^You have protection from the chosen name. @(You can�t be targeted, dealt damage, or enchanted by anything with that name.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Runes of the Deus
    public class RunesoftheDeus : MagicCard
    {
        public RunesoftheDeus()
        {
            Name = "Runes of the Deus";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "4%L";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^As long as enchanted creature is red, it gets +1/+1 and has double strike. @(It deals both first-strike and regular combat damage.)@;^As long as enchanted creature is green, it gets +1/+1 and has trample.";
            Flavor = "";
        }
    }
    # endregion

    # region Rustrazor Butcher
    public class RustrazorButcher : MagicCard
    {
        public RustrazorButcher()
        {
            Name = "Rustrazor Butcher";
            Edition = "SHM";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "1/2";
            Type = "Creature - Goblin Warrior";
            Text = "First strike;^Wither @(This deals damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Safehold Duo
    public class SafeholdDuo : MagicCard
    {
        public SafeholdDuo()
        {
            Name = "Safehold Duo";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "3%A";
            PT = "2/4";
            Type = "Creature - Elf Warrior Shaman";
            Text = "Whenever you cast a green spell, Safehold Duo gets +1/+1 until end of turn.;^Whenever you cast a white spell, Safehold Duo gains vigilance until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Safehold Elite
    public class SafeholdElite : MagicCard
    {
        public SafeholdElite()
        {
            Name = "Safehold Elite";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%A";
            PT = "2/2";
            Type = "Creature - Elf Scout";
            Text = "Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Safehold Sentry
    public class SafeholdSentry : MagicCard
    {
        public SafeholdSentry()
        {
            Name = "Safehold Sentry";
            Edition = "SHM";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "2/2";
            Type = "Creature - Elf Warrior";
            Text = "%2%W, %C: Safehold Sentry gets +0/+2 until end of turn. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Safewright Quest
    public class SafewrightQuest : MagicCard
    {
        public SafewrightQuest()
        {
            Name = "Safewright Quest";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "%A";
            PT = "";
            Type = "Sorcery";
            Text = "Search your library for a Forest or Plains card, reveal it, and put it into your hand. Then shuffle your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Sapseep Forest
    public class SapseepForest : MagicCard
    {
        public SapseepForest()
        {
            Name = "Sapseep Forest";
            Edition = "SHM";
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

    # region Savor the Moment
    public class SavortheMoment : MagicCard
    {
        public SavortheMoment()
        {
            Name = "Savor the Moment";
            Edition = "SHM";
            Rarity = "R";
            Color = "U";
            Cost = "1UU";
            PT = "";
            Type = "Sorcery";
            Text = "Take an extra turn after this one. Skip the untap step of that turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Scar
    public class Scar : MagicCard
    {
        public Scar()
        {
            Name = "Scar";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "%K";
            PT = "";
            Type = "Instant";
            Text = "Put a -1/-1 counter on target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Scarscale Ritual
    public class ScarscaleRitual : MagicCard
    {
        public ScarscaleRitual()
        {
            Name = "Scarscale Ritual";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%V";
            PT = "";
            Type = "Sorcery";
            Text = "As an additional cost to cast Scarscale Ritual, put a -1/-1 counter on a creature you control.;^Draw two cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Scrapbasket
    public class Scrapbasket : MagicCard
    {
        public Scrapbasket()
        {
            Name = "Scrapbasket";
            Edition = "SHM";
            Rarity = "C";
            Color = "Art";
            Cost = "4";
            PT = "3/2";
            Type = "Artifact Creature - Scarecrow";
            Text = "%1: Scrapbasket becomes all colors until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Scuttlemutt
    public class Scuttlemutt : MagicCard
    {
        public Scuttlemutt()
        {
            Name = "Scuttlemutt";
            Edition = "SHM";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "2/2";
            Type = "Artifact Creature - Scarecrow";
            Text = "%T: Add one mana of any color to your mana pool.;^%T: Target creature becomes the color or the colors of your choice until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Scuzzback Marauders
    public class ScuzzbackMarauders : MagicCard
    {
        public ScuzzbackMarauders()
        {
            Name = "Scuzzback Marauders";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "4%L";
            PT = "5/2";
            Type = "Creature - Goblin Warrior";
            Text = "Trample;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Scuzzback Scrapper
    public class ScuzzbackScrapper : MagicCard
    {
        public ScuzzbackScrapper()
        {
            Name = "Scuzzback Scrapper";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "%L";
            PT = "1/1";
            Type = "Creature - Goblin Warrior";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Seedcradle Witch
    public class SeedcradleWitch : MagicCard
    {
        public SeedcradleWitch()
        {
            Name = "Seedcradle Witch";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "%A";
            PT = "1/1";
            Type = "Creature - Elf Shaman";
            Text = "%2%G%W: Target creature gets +3/+3 until end of turn. Untap that creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Shield of the Oversoul
    public class ShieldoftheOversoul : MagicCard
    {
        public ShieldoftheOversoul()
        {
            Name = "Shield of the Oversoul";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%A";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^As long as enchanted creature is green, it gets +1/+1 and has indestructible. @(Damage and effects that say �destroy� don�t destroy it. If its toughness is 0 or less, it�s still put into its owner�s graveyard.)@;^As long as enchanted creature is white, it gets +1/+1 and has flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Sickle Ripper
    public class SickleRipper : MagicCard
    {
        public SickleRipper()
        {
            Name = "Sickle Ripper";
            Edition = "SHM";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "2/1";
            Type = "Creature - Elemental Warrior";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Silkbind Faerie
    public class SilkbindFaerie : MagicCard
    {
        public SilkbindFaerie()
        {
            Name = "Silkbind Faerie";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%D";
            PT = "1/3";
            Type = "Creature - Faerie Rogue";
            Text = "Flying;^%1%D, %C: Tap target creature. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Sinking Feeling
    public class SinkingFeeling : MagicCard
    {
        public SinkingFeeling()
        {
            Name = "Sinking Feeling";
            Edition = "SHM";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^Enchanted creature doesn�t untap during its controller�s untap step.;^Enchanted creature has �%1, Put a -1/-1 counter on this creature: Untap this creature.�";
            Flavor = "";
        }
    }
    # endregion

    # region Slinking Giant
    public class SlinkingGiant : MagicCard
    {
        public SlinkingGiant()
        {
            Name = "Slinking Giant";
            Edition = "SHM";
            Rarity = "U";
            Color = "R";
            Cost = "2RR";
            PT = "4/4";
            Type = "Creature - Giant Rogue";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^Whenever Slinking Giant blocks or becomes blocked, it gets -3/-0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Smash to Smithereens
    public class SmashtoSmithereens : MagicCard
    {
        public SmashtoSmithereens()
        {
            Name = "Smash to Smithereens";
            Edition = "SHM";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Instant";
            Text = "Destroy target artifact. Smash to Smithereens deals 3 damage to that artifact�s controller.";
            Flavor = "";
        }
    }
    # endregion

    # region Smolder Initiate
    public class SmolderInitiate : MagicCard
    {
        public SmolderInitiate()
        {
            Name = "Smolder Initiate";
            Edition = "SHM";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Elemental Shaman";
            Text = "Whenever a player casts a black spell, you may pay %1. If you do, target player loses 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Somnomancer
    public class Somnomancer : MagicCard
    {
        public Somnomancer()
        {
            Name = "Somnomancer";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%D";
            PT = "2/1";
            Type = "Creature - Kithkin Wizard";
            Text = "When Somnomancer enters the battlefield, you may tap target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Sootstoke Kindler
    public class SootstokeKindler : MagicCard
    {
        public SootstokeKindler()
        {
            Name = "Sootstoke Kindler";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%K";
            PT = "1/1";
            Type = "Creature - Elemental Shaman";
            Text = "Haste;^%T: Target black or red creature gains haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Sootwalkers
    public class Sootwalkers : MagicCard
    {
        public Sootwalkers()
        {
            Name = "Sootwalkers";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%K%K";
            PT = "3/3";
            Type = "Creature - Elemental Rogue";
            Text = "Sootwalkers can�t be blocked by white creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Spawnwrithe
    public class Spawnwrithe : MagicCard
    {
        public Spawnwrithe()
        {
            Name = "Spawnwrithe";
            Edition = "SHM";
            Rarity = "R";
            Color = "G";
            Cost = "2G";
            PT = "2/2";
            Type = "Creature - Elemental";
            Text = "Trample;^Whenever Spawnwrithe deals combat damage to a player, put a token that�s a copy of Spawnwrithe onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Spectral Procession
    public class SpectralProcession : MagicCard
    {
        public SpectralProcession()
        {
            Name = "Spectral Procession";
            Edition = "SHM";
            Rarity = "U";
            Color = "W";
            Cost = "%E%E%E";
            PT = "";
            Type = "Sorcery";
            Text = "@(%E can be paid with any two mana or with %W. This card�s converted mana cost is 6.)@;^Put three 1/1 white Spirit creature tokens with flying onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Spell Syphon
    public class SpellSyphon : MagicCard
    {
        public SpellSyphon()
        {
            Name = "Spell Syphon";
            Edition = "SHM";
            Rarity = "C";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell unless its controller pays %1 for each blue permanent you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Spiteflame Witch
    public class SpiteflameWitch : MagicCard
    {
        public SpiteflameWitch()
        {
            Name = "Spiteflame Witch";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "1%K";
            PT = "2/1";
            Type = "Creature - Elemental Shaman";
            Text = "%B%R: Each player loses 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Spiteful Visions
    public class SpitefulVisions : MagicCard
    {
        public SpitefulVisions()
        {
            Name = "Spiteful Visions";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "2%K%K";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of each player�s draw step, that player draws an additional card.;^Whenever a player draws a card, Spiteful Visions deals 1 damage to that player.";
            Flavor = "";
        }
    }
    # endregion

    # region Splitting Headache
    public class SplittingHeadache : MagicCard
    {
        public SplittingHeadache()
        {
            Name = "Splitting Headache";
            Edition = "SHM";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "";
            Type = "Sorcery";
            Text = "Choose one � Target player discards two cards; or target player reveals his or her hand, you choose a card from it, then that player discards that card.";
            Flavor = "";
        }
    }
    # endregion

    # region Steel of the Godhead
    public class SteeloftheGodhead : MagicCard
    {
        public SteeloftheGodhead()
        {
            Name = "Steel of the Godhead";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%D";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^As long as enchanted creature is white, it gets +1/+1 and has lifelink. @(Damage dealt by the creature also causes its controller to gain that much life.)@;^As long as enchanted creature is blue, it gets +1/+1 and can�t be blocked.";
            Flavor = "";
        }
    }
    # endregion

    # region Strip Bare
    public class StripBare : MagicCard
    {
        public StripBare()
        {
            Name = "Strip Bare";
            Edition = "SHM";
            Rarity = "C";
            Color = "W";
            Cost = "W";
            PT = "";
            Type = "Instant";
            Text = "Destroy all Auras and Equipment attached to target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Sunken Ruins
    public class SunkenRuins : MagicCard
    {
        public SunkenRuins()
        {
            Name = "Sunken Ruins";
            Edition = "SHM";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%V, %T: Add %U%U, %U%B, or %B%B to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Swamp
    public class SwampSHM : MagicCard
    {
        public SwampSHM()
        {
            Name = "Swamp";
            Edition = "SHM";
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

    # region Swans of Bryn Argoll
    public class SwansofBrynArgoll : MagicCard
    {
        public SwansofBrynArgoll()
        {
            Name = "Swans of Bryn Argoll";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "2%D%D";
            PT = "4/3";
            Type = "Creature - Bird Spirit";
            Text = "Flying;^If a source would deal damage to Swans of Bryn Argoll, prevent that damage. The source�s controller draws cards equal to the damage prevented this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Sygg, River Cutthroat
    public class SyggRiverCutthroat : MagicCard
    {
        public SyggRiverCutthroat()
        {
            Name = "Sygg, River Cutthroat";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "%V%V";
            PT = "1/3";
            Type = "Legendary Creature - Merfolk Rogue";
            Text = "At the beginning of each end step, if an opponent lost 3 or more life this turn, you may draw a card. @(Damage causes loss of life.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Tatterkite
    public class Tatterkite : MagicCard
    {
        public Tatterkite()
        {
            Name = "Tatterkite";
            Edition = "SHM";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "2/1";
            Type = "Artifact Creature - Scarecrow";
            Text = "Flying;^Tatterkite can�t have counters placed on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Tattermunge Duo
    public class TattermungeDuo : MagicCard
    {
        public TattermungeDuo()
        {
            Name = "Tattermunge Duo";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%L";
            PT = "2/3";
            Type = "Creature - Goblin Warrior Shaman";
            Text = "Whenever you cast a red spell, Tattermunge Duo gets +1/+1 until end of turn.;^Whenever you cast a green spell, Tattermunge Duo gains forestwalk until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Tattermunge Maniac
    public class TattermungeManiac : MagicCard
    {
        public TattermungeManiac()
        {
            Name = "Tattermunge Maniac";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "%L";
            PT = "2/1";
            Type = "Creature - Goblin Warrior";
            Text = "Tattermunge Maniac attacks each turn if able.";
            Flavor = "";
        }
    }
    # endregion

    # region Tattermunge Witch
    public class TattermungeWitch : MagicCard
    {
        public TattermungeWitch()
        {
            Name = "Tattermunge Witch";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "1%L";
            PT = "2/1";
            Type = "Creature - Goblin Shaman";
            Text = "%R%G: Each blocked creature gets +1/+0 and gains trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Thistledown Duo
    public class ThistledownDuo : MagicCard
    {
        public ThistledownDuo()
        {
            Name = "Thistledown Duo";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%D";
            PT = "2/2";
            Type = "Creature - Kithkin Soldier Wizard";
            Text = "Whenever you cast a white spell, Thistledown Duo gets +1/+1 until end of turn.;^Whenever you cast a blue spell, Thistledown Duo gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Thistledown Liege
    public class ThistledownLiege : MagicCard
    {
        public ThistledownLiege()
        {
            Name = "Thistledown Liege";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "1%D%D%D";
            PT = "1/3";
            Type = "Creature - Kithkin Knight";
            Text = "Flash;^Other white creatures you control get +1/+1.;^Other blue creatures you control get +1/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Thornwatch Scarecrow
    public class ThornwatchScarecrow : MagicCard
    {
        public ThornwatchScarecrow()
        {
            Name = "Thornwatch Scarecrow";
            Edition = "SHM";
            Rarity = "C";
            Color = "Art";
            Cost = "6";
            PT = "4/4";
            Type = "Artifact Creature - Scarecrow";
            Text = "Thornwatch Scarecrow has wither as long as you control a green creature. @(It deals damage to creatures in the form of -1/-1 counters.)@;^Thornwatch Scarecrow has vigilance as long as you control a white creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Thought Reflection
    public class ThoughtReflection : MagicCard
    {
        public ThoughtReflection()
        {
            Name = "Thought Reflection";
            Edition = "SHM";
            Rarity = "R";
            Color = "U";
            Cost = "4UUU";
            PT = "";
            Type = "Enchantment";
            Text = "If you would draw a card, draw two cards instead.";
            Flavor = "";
        }
    }
    # endregion

    # region Thoughtweft Gambit
    public class ThoughtweftGambit : MagicCard
    {
        public ThoughtweftGambit()
        {
            Name = "Thoughtweft Gambit";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "4%D%D";
            PT = "";
            Type = "Instant";
            Text = "Tap all creatures your opponents control and untap all creatures you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Toil to Renown
    public class ToiltoRenown : MagicCard
    {
        public ToiltoRenown()
        {
            Name = "Toil to Renown";
            Edition = "SHM";
            Rarity = "C";
            Color = "G";
            Cost = "1G";
            PT = "";
            Type = "Sorcery";
            Text = "You gain 1 life for each tapped artifact, creature, and land you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Torpor Dust
    public class TorporDust : MagicCard
    {
        public TorporDust()
        {
            Name = "Torpor Dust";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%V";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Flash;^Enchant creature;^Enchanted creature gets -3/-0.";
            Flavor = "";
        }
    }
    # endregion

    # region Torrent of Souls
    public class TorrentofSouls : MagicCard
    {
        public TorrentofSouls()
        {
            Name = "Torrent of Souls";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "4%K";
            PT = "";
            Type = "Sorcery";
            Text = "Return up to one target creature card from your graveyard to the battlefield if %B was spent to cast Torrent of Souls. Creatures target player controls get +2/+0 and gain haste until end of turn if %R was spent to cast Torrent of Souls. @(Do both if %B%R was spent.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Torture
    public class Torture : MagicCard
    {
        public Torture()
        {
            Name = "Torture";
            Edition = "SHM";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^%1%B: Put a -1/-1 counter on enchanted creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Tower Above
    public class TowerAbove : MagicCard
    {
        public TowerAbove()
        {
            Name = "Tower Above";
            Edition = "SHM";
            Rarity = "U";
            Color = "G";
            Cost = "%M%M%M";
            PT = "";
            Type = "Sorcery";
            Text = "@(%M can be paid with any two mana or with %G. This card�s converted mana cost is 6.)@;^Until end of turn, target creature gets +4/+4 and gains trample, wither, and �When this creature attacks, target creature blocks it this turn if able.� @(It deals damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Traitor's Roar
    public class TraitorsRoar : MagicCard
    {
        public TraitorsRoar()
        {
            Name = "Traitor's Roar";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "4%K";
            PT = "";
            Type = "Sorcery";
            Text = "Tap target untapped creature. It deals damage equal to its power to its controller.;^Conspire @(As you cast this spell, you may tap two untapped creatures you control that share a color with it. When you do, copy it and you may choose a new target for the copy.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Trip Noose
    public class TripNoose : MagicCard
    {
        public TripNoose()
        {
            Name = "Trip Noose";
            Edition = "SHM";
            Rarity = "U";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact";
            Text = "%2, %T: Tap target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Turn to Mist
    public class TurntoMist : MagicCard
    {
        public TurntoMist()
        {
            Name = "Turn to Mist";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%D";
            PT = "";
            Type = "Instant";
            Text = "Exile target creature. Return that card to the battlefield under its owner�s control at the beginning of the next end step.";
            Flavor = "";
        }
    }
    # endregion

    # region Twilight Shepherd
    public class TwilightShepherd : MagicCard
    {
        public TwilightShepherd()
        {
            Name = "Twilight Shepherd";
            Edition = "SHM";
            Rarity = "R";
            Color = "W";
            Cost = "3WWW";
            PT = "5/5";
            Type = "Creature - Angel";
            Text = "Flying, vigilance;^When Twilight Shepherd enters the battlefield, return to your hand all cards in your graveyard that were put there from the battlefield this turn.;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Tyrannize
    public class Tyrannize : MagicCard
    {
        public Tyrannize()
        {
            Name = "Tyrannize";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "3%K%K";
            PT = "";
            Type = "Sorcery";
            Text = "Target player discards his or her hand unless he or she pays 7 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Umbral Mantle
    public class UmbralMantle : MagicCard
    {
        public UmbralMantle()
        {
            Name = "Umbral Mantle";
            Edition = "SHM";
            Rarity = "U";
            Color = "Art";
            Cost = "3";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Equipped creature has �%3, %C: This creature gets +2/+2 until end of turn.� @(%C is the untap symbol.)@;^Equip %0";
            Flavor = "";
        }
    }
    # endregion

    # region Valleymaker
    public class Valleymaker : MagicCard
    {
        public Valleymaker()
        {
            Name = "Valleymaker";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "5%L";
            PT = "5/5";
            Type = "Creature - Giant Shaman";
            Text = "%T, Sacrifice a Mountain: Valleymaker deals 3 damage to target creature.;^%T, Sacrifice a Forest: Choose a player. That player adds %G%G%G to his or her mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Vexing Shusher
    public class VexingShusher : MagicCard
    {
        public VexingShusher()
        {
            Name = "Vexing Shusher";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "%L%L";
            PT = "2/2";
            Type = "Creature - Goblin Shaman";
            Text = "Vexing Shusher can�t be countered.;^%L: Target spell can�t be countered by spells or abilities.";
            Flavor = "";
        }
    }
    # endregion

    # region Viridescent Wisps
    public class ViridescentWisps : MagicCard
    {
        public ViridescentWisps()
        {
            Name = "Viridescent Wisps";
            Edition = "SHM";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Instant";
            Text = "Target creature becomes green and gets +1/+0 until end of turn.;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Wanderbrine Rootcutters
    public class WanderbrineRootcutters : MagicCard
    {
        public WanderbrineRootcutters()
        {
            Name = "Wanderbrine Rootcutters";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%V%V";
            PT = "3/3";
            Type = "Creature - Merfolk Rogue";
            Text = "Wanderbrine Rootcutters can�t be blocked by green creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Wasp Lancer
    public class WaspLancer : MagicCard
    {
        public WaspLancer()
        {
            Name = "Wasp Lancer";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "%V%V%V";
            PT = "3/2";
            Type = "Creature - Faerie Soldier";
            Text = "Flying";
            Flavor = "";
        }
    }
    # endregion

    # region Watchwing Scarecrow
    public class WatchwingScarecrow : MagicCard
    {
        public WatchwingScarecrow()
        {
            Name = "Watchwing Scarecrow";
            Edition = "SHM";
            Rarity = "C";
            Color = "Art";
            Cost = "4";
            PT = "2/4";
            Type = "Artifact Creature - Scarecrow";
            Text = "Watchwing Scarecrow has vigilance as long as you control a white creature.;^Watchwing Scarecrow has flying as long as you control a blue creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Wheel of Sun and Moon
    public class WheelofSunandMoon : MagicCard
    {
        public WheelofSunandMoon()
        {
            Name = "Wheel of Sun and Moon";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "%A%A";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant player;^If a card would be put into enchanted player�s graveyard from anywhere, instead that card is revealed and put on the bottom of that player�s library.";
            Flavor = "";
        }
    }
    # endregion

    # region Whimwader
    public class Whimwader : MagicCard
    {
        public Whimwader()
        {
            Name = "Whimwader";
            Edition = "SHM";
            Rarity = "C";
            Color = "U";
            Cost = "4U";
            PT = "6/4";
            Type = "Creature - Elemental";
            Text = "Whimwader can�t attack unless defending player controls a blue permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Wicker Warcrawler
    public class WickerWarcrawler : MagicCard
    {
        public WickerWarcrawler()
        {
            Name = "Wicker Warcrawler";
            Edition = "SHM";
            Rarity = "U";
            Color = "Art";
            Cost = "5";
            PT = "6/6";
            Type = "Artifact Creature - Scarecrow";
            Text = "Whenever Wicker Warcrawler attacks or blocks, put a -1/-1 counter on it at end of combat.";
            Flavor = "";
        }
    }
    # endregion

    # region Wild Swing
    public class WildSwing : MagicCard
    {
        public WildSwing()
        {
            Name = "Wild Swing";
            Edition = "SHM";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "";
            Type = "Sorcery";
            Text = "Choose three target nonenchantment permanents. Destroy one of them at random.";
            Flavor = "";
        }
    }
    # endregion

    # region Wildslayer Elves
    public class WildslayerElves : MagicCard
    {
        public WildslayerElves()
        {
            Name = "Wildslayer Elves";
            Edition = "SHM";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "3/3";
            Type = "Creature - Elf Warrior";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wilt-Leaf Cavaliers
    public class WiltLeafCavaliers : MagicCard
    {
        public WiltLeafCavaliers()
        {
            Name = "Wilt-Leaf Cavaliers";
            Edition = "SHM";
            Rarity = "U";
            Color = "Gld";
            Cost = "%A%A%A";
            PT = "3/4";
            Type = "Creature - Elf Knight";
            Text = "Vigilance";
            Flavor = "";
        }
    }
    # endregion

    # region Wilt-Leaf Liege
    public class WiltLeafLiege : MagicCard
    {
        public WiltLeafLiege()
        {
            Name = "Wilt-Leaf Liege";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "1%A%A%A";
            PT = "4/4";
            Type = "Creature - Elf Knight";
            Text = "Other green creatures you control get +1/+1.;^Other white creatures you control get +1/+1.;^If a spell or ability an opponent controls causes you to discard Wilt-Leaf Liege, put it onto the battlefield instead of putting it into your graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Windbrisk Raptor
    public class WindbriskRaptor : MagicCard
    {
        public WindbriskRaptor()
        {
            Name = "Windbrisk Raptor";
            Edition = "SHM";
            Rarity = "R";
            Color = "W";
            Cost = "5WW";
            PT = "5/7";
            Type = "Creature - Bird";
            Text = "Flying;^Attacking creatures you control have lifelink.";
            Flavor = "";
        }
    }
    # endregion

    # region Wingrattle Scarecrow
    public class WingrattleScarecrow : MagicCard
    {
        public WingrattleScarecrow()
        {
            Name = "Wingrattle Scarecrow";
            Edition = "SHM";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "2/2";
            Type = "Artifact Creature - Scarecrow";
            Text = "Wingrattle Scarecrow has flying as long as you control a blue creature.;^Wingrattle Scarecrow has persist as long as you control a black creature. @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Witherscale Wurm
    public class WitherscaleWurm : MagicCard
    {
        public WitherscaleWurm()
        {
            Name = "Witherscale Wurm";
            Edition = "SHM";
            Rarity = "R";
            Color = "G";
            Cost = "4GG";
            PT = "9/9";
            Type = "Creature - Wurm";
            Text = "Whenever Witherscale Wurm blocks or becomes blocked by a creature, that creature gains wither until end of turn. @(It deals damage to creatures in the form of -1/-1 counters.)@;^Whenever Witherscale Wurm deals damage to an opponent, remove all -1/-1 counters from it.";
            Flavor = "";
        }
    }
    # endregion

    # region Woeleecher
    public class Woeleecher : MagicCard
    {
        public Woeleecher()
        {
            Name = "Woeleecher";
            Edition = "SHM";
            Rarity = "C";
            Color = "W";
            Cost = "5W";
            PT = "3/5";
            Type = "Creature - Elemental";
            Text = "%W, %T: Remove a -1/-1 counter from target creature. If you do, you gain 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Wooded Bastion
    public class WoodedBastion : MagicCard
    {
        public WoodedBastion()
        {
            Name = "Wooded Bastion";
            Edition = "SHM";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%A, %T: Add %G%G, %G%W, or %W%W to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Woodfall Primus
    public class WoodfallPrimus : MagicCard
    {
        public WoodfallPrimus()
        {
            Name = "Woodfall Primus";
            Edition = "SHM";
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

    # region Worldpurge
    public class Worldpurge : MagicCard
    {
        public Worldpurge()
        {
            Name = "Worldpurge";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "4%D%D%D%D";
            PT = "";
            Type = "Sorcery";
            Text = "Return all permanents to their owners� hands. Each player chooses up to seven cards in his or her hand, then shuffles the rest into his or her library. Empty all mana pools.";
            Flavor = "";
        }
    }
    # endregion

    # region Wort, the Raidmother
    public class WorttheRaidmother : MagicCard
    {
        public WorttheRaidmother()
        {
            Name = "Wort, the Raidmother";
            Edition = "SHM";
            Rarity = "R";
            Color = "Gld";
            Cost = "4%L%L";
            PT = "3/3";
            Type = "Legendary Creature - Goblin Shaman";
            Text = "When Wort, the Raidmother enters the battlefield, put two 1/1 red and green Goblin Warrior creature tokens onto the battlefield.;^Each red or green instant or sorcery spell you cast has conspire. @(As you cast the spell, you may tap two untapped creatures you control that share a color with it. When you do, copy it and you may choose new targets for the copy.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wound Reflection
    public class WoundReflection : MagicCard
    {
        public WoundReflection()
        {
            Name = "Wound Reflection";
            Edition = "SHM";
            Rarity = "R";
            Color = "B";
            Cost = "5B";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of each end step, each opponent loses life equal to the life he or she lost this turn. @(Damage causes loss of life.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Zealous Guardian
    public class ZealousGuardian : MagicCard
    {
        public ZealousGuardian()
        {
            Name = "Zealous Guardian";
            Edition = "SHM";
            Rarity = "C";
            Color = "Gld";
            Cost = "%D";
            PT = "1/1";
            Type = "Creature - Kithkin Soldier";
            Text = "Flash";
            Flavor = "";
        }
    }
    # endregion


    # endregion

    # region Eventide
    # region Aerie Ouphes
    public class AerieOuphes : MagicCard
    {
        public AerieOuphes()
        {
            Name = "Aerie Ouphes";
            Edition = "EVE";
            Rarity = "C";
            Color = "G";
            Cost = "4G";
            PT = "3/3";
            Type = "Creature - Ouphe";
            Text = "Sacrifice Aerie Ouphes: Aerie Ouphes deals damage equal to its power to target creature with flying.;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Altar Golem
    public class AltarGolem : MagicCard
    {
        public AltarGolem()
        {
            Name = "Altar Golem";
            Edition = "EVE";
            Rarity = "R";
            Color = "Art";
            Cost = "7";
            PT = "*/*";
            Type = "Artifact Creature - Golem";
            Text = "Trample;^Altar Golem�s power and toughness are each equal to the number of creatures on the battlefield.;^Altar Golem doesn�t untap during your untap step.;^Tap five untapped creatures you control: Untap Altar Golem.";
            Flavor = "";
        }
    }
    # endregion

    # region Antler Skulkin
    public class AntlerSkulkin : MagicCard
    {
        public AntlerSkulkin()
        {
            Name = "Antler Skulkin";
            Edition = "EVE";
            Rarity = "C";
            Color = "Art";
            Cost = "5";
            PT = "3/3";
            Type = "Artifact Creature - Scarecrow";
            Text = "%2: Target white creature gains persist until end of turn. @(When it dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Archon of Justice
    public class ArchonofJustice : MagicCard
    {
        public ArchonofJustice()
        {
            Name = "Archon of Justice";
            Edition = "EVE";
            Rarity = "R";
            Color = "W";
            Cost = "3WW";
            PT = "4/4";
            Type = "Creature - Archon";
            Text = "Flying;^When Archon of Justice dies, exile target permanent.";
            Flavor = "";
        }
    }
    # endregion

    # region Ashling, the Extinguisher
    public class AshlingtheExtinguisher : MagicCard
    {
        public AshlingtheExtinguisher()
        {
            Name = "Ashling, the Extinguisher";
            Edition = "EVE";
            Rarity = "R";
            Color = "B";
            Cost = "2BB";
            PT = "4/4";
            Type = "Legendary Creature - Elemental Shaman";
            Text = "Whenever Ashling, the Extinguisher deals combat damage to a player, choose target creature that player controls. He or she sacrifices that creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Balefire Liege
    public class BalefireLiege : MagicCard
    {
        public BalefireLiege()
        {
            Name = "Balefire Liege";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "2%P%P%P";
            PT = "2/4";
            Type = "Creature - Spirit Horror";
            Text = "Other red creatures you control get +1/+1.;^Other white creatures you control get +1/+1.;^Whenever you cast a red spell, Balefire Liege deals 3 damage to target player.;^Whenever you cast a white spell, you gain 3 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Ballynock Trapper
    public class BallynockTrapper : MagicCard
    {
        public BallynockTrapper()
        {
            Name = "Ballynock Trapper";
            Edition = "EVE";
            Rarity = "C";
            Color = "W";
            Cost = "3W";
            PT = "2/2";
            Type = "Creature - Kithkin Soldier";
            Text = "%T: Tap target creature.;^Whenever you cast a white spell, you may untap Ballynock Trapper.";
            Flavor = "";
        }
    }
    # endregion

    # region Banishing Knack
    public class BanishingKnack : MagicCard
    {
        public BanishingKnack()
        {
            Name = "Banishing Knack";
            Edition = "EVE";
            Rarity = "C";
            Color = "U";
            Cost = "U";
            PT = "";
            Type = "Instant";
            Text = "Until end of turn, target creature gains �%T: Return target nonland permanent to its owner�s hand.�";
            Flavor = "";
        }
    }
    # endregion

    # region Battlegate Mimic
    public class BattlegateMimic : MagicCard
    {
        public BattlegateMimic()
        {
            Name = "Battlegate Mimic";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%P";
            PT = "2/1";
            Type = "Creature - Shapeshifter";
            Text = "Whenever you cast a spell that�s both red and white, Battlegate Mimic becomes 4/2 and gains first strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Batwing Brume
    public class BatwingBrume : MagicCard
    {
        public BatwingBrume()
        {
            Name = "Batwing Brume";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "1%O";
            PT = "";
            Type = "Instant";
            Text = "Prevent all combat damage that would be dealt this turn if %W was spent to cast Batwing Brume. Each player loses 1 life for each attacking creature he or she controls if %B was spent to cast Batwing Brume. @(Do both if %W%B was spent.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Beckon Apparition
    public class BeckonApparitionEVE : MagicCard
    {
        public BeckonApparitionEVE()
        {
            Name = "Beckon Apparition";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "%O";
            PT = "";
            Type = "Instant";
            Text = "Exile target card from a graveyard. Put a 1/1 white and black Spirit creature token with flying onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Belligerent Hatchling
    public class BelligerentHatchling : MagicCard
    {
        public BelligerentHatchling()
        {
            Name = "Belligerent Hatchling";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "3%P";
            PT = "6/6";
            Type = "Creature - Elemental";
            Text = "First strike;^Belligerent Hatchling enters the battlefield with four -1/-1 counters on it.;^Whenever you cast a red spell, remove a -1/-1 counter from Belligerent Hatchling.;^Whenever you cast a white spell, remove a -1/-1 counter from Belligerent Hatchling.";
            Flavor = "";
        }
    }
    # endregion

    # region Bloodied Ghost
    public class BloodiedGhost : MagicCard
    {
        public BloodiedGhost()
        {
            Name = "Bloodied Ghost";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "1%O%O";
            PT = "3/3";
            Type = "Creature - Spirit";
            Text = "Flying;^Bloodied Ghost enters the battlefield with a -1/-1 counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Bloom Tender
    public class BloomTender : MagicCard
    {
        public BloomTender()
        {
            Name = "Bloom Tender";
            Edition = "EVE";
            Rarity = "R";
            Color = "G";
            Cost = "1G";
            PT = "1/1";
            Type = "Creature - Elf Druid";
            Text = "%T: For each color among permanents you control, add one mana of that color to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Cache Raiders
    public class CacheRaiders : MagicCard
    {
        public CacheRaiders()
        {
            Name = "Cache Raiders";
            Edition = "EVE";
            Rarity = "U";
            Color = "U";
            Cost = "3UU";
            PT = "4/4";
            Type = "Creature - Merfolk Rogue";
            Text = "At the beginning of your upkeep, return a permanent you control to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Call the Skybreaker
    public class CalltheSkybreaker : MagicCard
    {
        public CalltheSkybreaker()
        {
            Name = "Call the Skybreaker";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "5%I%I";
            PT = "";
            Type = "Sorcery";
            Text = "Put a 5/5 blue and red Elemental creature token with flying onto the battlefield.;^Retrace @(You may cast this card from your graveyard by discarding a land card in addition to paying its other costs.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Canker Abomination
    public class CankerAbomination : MagicCard
    {
        public CankerAbomination()
        {
            Name = "Canker Abomination";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%Q%Q";
            PT = "6/6";
            Type = "Creature - Treefolk Horror";
            Text = "As Canker Abomination enters the battlefield, choose an opponent. Canker Abomination enters the battlefield with a -1/-1 counter on it for each creature that player controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Cankerous Thirst
    public class CankerousThirst : MagicCard
    {
        public CankerousThirst()
        {
            Name = "Cankerous Thirst";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "3%Q";
            PT = "";
            Type = "Instant";
            Text = "If %B was spent to cast Cankerous Thirst, you may have target creature get -3/-3 until end of turn. If %G was spent to cast Cankerous Thirst, you may have target creature get +3/+3 until end of turn. @(Do both if %B%G was spent.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Cascade Bluffs
    public class CascadeBluffs : MagicCard
    {
        public CascadeBluffs()
        {
            Name = "Cascade Bluffs";
            Edition = "EVE";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%I, %T: Add %U%U, %U%R, or %R%R to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Cauldron Haze
    public class CauldronHaze : MagicCard
    {
        public CauldronHaze()
        {
            Name = "Cauldron Haze";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "1%O";
            PT = "";
            Type = "Instant";
            Text = "Choose any number of target creatures. Each of those creatures gains persist until end of turn. @(When it dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Cenn's Enlistment
    public class CennsEnlistment : MagicCard
    {
        public CennsEnlistment()
        {
            Name = "Cenn's Enlistment";
            Edition = "EVE";
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

    # region Chaotic Backlash
    public class ChaoticBacklash : MagicCard
    {
        public ChaoticBacklash()
        {
            Name = "Chaotic Backlash";
            Edition = "EVE";
            Rarity = "U";
            Color = "R";
            Cost = "4R";
            PT = "";
            Type = "Instant";
            Text = "Chaotic Backlash deals damage to target player equal to twice the number of white and/or blue permanents he or she controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Cinder Pyromancer
    public class CinderPyromancer : MagicCard
    {
        public CinderPyromancer()
        {
            Name = "Cinder Pyromancer";
            Edition = "EVE";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "0/1";
            Type = "Creature - Elemental Shaman";
            Text = "%T: Cinder Pyromancer deals 1 damage to target player.;^Whenever you cast a red spell, you may untap Cinder Pyromancer.";
            Flavor = "";
        }
    }
    # endregion

    # region Clout of the Dominus
    public class CloutoftheDominus : MagicCard
    {
        public CloutoftheDominus()
        {
            Name = "Clout of the Dominus";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "%I";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^As long as enchanted creature is blue, it gets +1/+1 and has shroud. @(It can�t be the target of spells or abilities.)@;^As long as enchanted creature is red, it gets +1/+1 and has haste.";
            Flavor = "";
        }
    }
    # endregion

    # region Cold-Eyed Selkie
    public class ColdEyedSelkie : MagicCard
    {
        public ColdEyedSelkie()
        {
            Name = "Cold-Eyed Selkie";
            Edition = "EVE";
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

    # region Crackleburr
    public class Crackleburr : MagicCard
    {
        public Crackleburr()
        {
            Name = "Crackleburr";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "1%I%I";
            PT = "2/2";
            Type = "Creature - Elemental";
            Text = "%I%I, %T, Tap two untapped red creatures you control: Crackleburr deals 3 damage to target creature or player.;^%I%I, %C, Untap two tapped blue creatures you control: Return target creature to its owner�s hand. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Crag Puca
    public class CragPuca : MagicCard
    {
        public CragPuca()
        {
            Name = "Crag Puca";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "%I%I%I";
            PT = "2/4";
            Type = "Creature - Shapeshifter";
            Text = "%I: Switch Crag Puca�s power and toughness until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Creakwood Ghoul
    public class CreakwoodGhoul : MagicCard
    {
        public CreakwoodGhoul()
        {
            Name = "Creakwood Ghoul";
            Edition = "EVE";
            Rarity = "U";
            Color = "B";
            Cost = "4B";
            PT = "3/3";
            Type = "Creature - Plant Zombie";
            Text = "%Q%Q: Exile target card from a graveyard. You gain 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Creakwood Liege
    public class CreakwoodLiege : MagicCard
    {
        public CreakwoodLiege()
        {
            Name = "Creakwood Liege";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "1%Q%Q%Q";
            PT = "2/2";
            Type = "Creature - Horror";
            Text = "Other black creatures you control get +1/+1.;^Other green creatures you control get +1/+1.;^At the beginning of your upkeep, you may put a 1/1 black and green Worm creature token onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Crumbling Ashes
    public class CrumblingAshes : MagicCard
    {
        public CrumblingAshes()
        {
            Name = "Crumbling Ashes";
            Edition = "EVE";
            Rarity = "U";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Enchantment";
            Text = "At the beginning of your upkeep, destroy target creature with a -1/-1 counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Deathbringer Liege
    public class DeathbringerLiege : MagicCard
    {
        public DeathbringerLiege()
        {
            Name = "Deathbringer Liege";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "2%O%O%O";
            PT = "3/4";
            Type = "Creature - Horror";
            Text = "Other white creatures you control get +1/+1.;^Other black creatures you control get +1/+1.;^Whenever you cast a white spell, you may tap target creature.;^Whenever you cast a black spell, you may destroy target creature if it�s tapped.";
            Flavor = "";
        }
    }
    # endregion

    # region Deity of Scars
    public class DeityofScars : MagicCard
    {
        public DeityofScars()
        {
            Name = "Deity of Scars";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "%Q%Q%Q%Q%Q";
            PT = "7/7";
            Type = "Creature - Spirit Avatar";
            Text = "Trample;^Deity of Scars enters the battlefield with two -1/-1 counters on it.;^%Q, Remove a -1/-1 counter from Deity of Scars: Regenerate Deity of Scars.";
            Flavor = "";
        }
    }
    # endregion

    # region Desecrator Hag
    public class DesecratorHag : MagicCard
    {
        public DesecratorHag()
        {
            Name = "Desecrator Hag";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%Q%Q";
            PT = "2/2";
            Type = "Creature - Hag";
            Text = "When Desecrator Hag enters the battlefield, return to your hand the creature card in your graveyard with the greatest power. If two or more cards are tied for greatest power, you choose one of them.";
            Flavor = "";
        }
    }
    # endregion

    # region Divinity of Pride
    public class DivinityofPride : MagicCard
    {
        public DivinityofPride()
        {
            Name = "Divinity of Pride";
            Edition = "EVE";
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

    # region Dominus of Fealty
    public class DominusofFealty : MagicCard
    {
        public DominusofFealty()
        {
            Name = "Dominus of Fealty";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "%I%I%I%I%I";
            PT = "4/4";
            Type = "Creature - Spirit Avatar";
            Text = "Flying;^At the beginning of your upkeep, you may gain control of target permanent until end of turn. If you do, untap it and it gains haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Doomgape
    public class Doomgape : MagicCard
    {
        public Doomgape()
        {
            Name = "Doomgape";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "4%Q%Q%Q";
            PT = "10/10";
            Type = "Creature - Elemental";
            Text = "Trample;^At the beginning of your upkeep, sacrifice a creature. You gain life equal to that creature�s toughness.";
            Flavor = "";
        }
    }
    # endregion

    # region Double Cleave
    public class DoubleCleave : MagicCard
    {
        public DoubleCleave()
        {
            Name = "Double Cleave";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%P";
            PT = "";
            Type = "Instant";
            Text = "Target creature gains double strike until end of turn. @(It deals both first-strike and regular combat damage.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Drain the Well
    public class DraintheWell : MagicCard
    {
        public DraintheWell()
        {
            Name = "Drain the Well";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%Q%Q";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target land. You gain 2 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Dream Fracture
    public class DreamFracture : MagicCard
    {
        public DreamFracture()
        {
            Name = "Dream Fracture";
            Edition = "EVE";
            Rarity = "U";
            Color = "U";
            Cost = "1UU";
            PT = "";
            Type = "Instant";
            Text = "Counter target spell. Its controller draws a card.;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Dream Thief
    public class DreamThief : MagicCard
    {
        public DreamThief()
        {
            Name = "Dream Thief";
            Edition = "EVE";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "2/1";
            Type = "Creature - Faerie Rogue";
            Text = "Flying;^When Dream Thief enters the battlefield, draw a card if you�ve cast another blue spell this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Duergar Assailant
    public class DuergarAssailant : MagicCard
    {
        public DuergarAssailant()
        {
            Name = "Duergar Assailant";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "%P";
            PT = "1/1";
            Type = "Creature - Dwarf Soldier";
            Text = "Sacrifice Duergar Assailant: Duergar Assailant deals 1 damage to target attacking or blocking creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Duergar Cave-Guard
    public class DuergarCaveGuard : MagicCard
    {
        public DuergarCaveGuard()
        {
            Name = "Duergar Cave-Guard";
            Edition = "EVE";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "1/3";
            Type = "Creature - Dwarf Warrior";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^%P: Duergar Cave-Guard gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Duergar Hedge-Mage
    public class DuergarHedgeMage : MagicCard
    {
        public DuergarHedgeMage()
        {
            Name = "Duergar Hedge-Mage";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%P";
            PT = "2/2";
            Type = "Creature - Dwarf Shaman";
            Text = "When Duergar Hedge-Mage enters the battlefield, if you control two or more Mountains, you may destroy target artifact.;^When Duergar Hedge-Mage enters the battlefield, if you control two or more Plains, you may destroy target enchantment.";
            Flavor = "";
        }
    }
    # endregion

    # region Duergar Mine-Captain
    public class DuergarMineCaptain : MagicCard
    {
        public DuergarMineCaptain()
        {
            Name = "Duergar Mine-Captain";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%P";
            PT = "2/1";
            Type = "Creature - Dwarf Soldier";
            Text = "%1%P, %C: Attacking creatures get +1/+0 until end of turn. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Duskdale Wurm
    public class DuskdaleWurm : MagicCard
    {
        public DuskdaleWurm()
        {
            Name = "Duskdale Wurm";
            Edition = "EVE";
            Rarity = "U";
            Color = "G";
            Cost = "5GG";
            PT = "7/7";
            Type = "Creature - Wurm";
            Text = "Trample @(If this creature would assign enough damage to its blockers to destroy them, you may have it assign the rest of its damage to defending player or planeswalker.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Edge of the Divinity
    public class EdgeoftheDivinity : MagicCard
    {
        public EdgeoftheDivinity()
        {
            Name = "Edge of the Divinity";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "%O";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^As long as enchanted creature is white, it gets +1/+2.;^As long as enchanted creature is black, it gets +2/+1.";
            Flavor = "";
        }
    }
    # endregion

    # region Endless Horizons
    public class EndlessHorizons : MagicCard
    {
        public EndlessHorizons()
        {
            Name = "Endless Horizons";
            Edition = "EVE";
            Rarity = "R";
            Color = "W";
            Cost = "3W";
            PT = "";
            Type = "Enchantment";
            Text = "When Endless Horizons enters the battlefield, search your library for any number of Plains cards and exile them. Then shuffle your library.;^At the beginning of your upkeep, you may put a card you own exiled with Endless Horizons into your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Endure
    public class Endure : MagicCard
    {
        public Endure()
        {
            Name = "Endure";
            Edition = "EVE";
            Rarity = "U";
            Color = "W";
            Cost = "3WW";
            PT = "";
            Type = "Instant";
            Text = "Prevent all damage that would be dealt to you and permanents you control this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Evershrike
    public class Evershrike : MagicCard
    {
        public Evershrike()
        {
            Name = "Evershrike";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "3%O%O";
            PT = "2/2";
            Type = "Creature - Elemental Spirit";
            Text = "Flying;^Evershrike gets +2/+2 for each Aura attached to it.;^%X%O%O: Return Evershrike from your graveyard to the battlefield. You may put an Aura card with converted mana cost X or less from your hand onto the battlefield attached to it. If you don�t, exile Evershrike.";
            Flavor = "";
        }
    }
    # endregion

    # region Fable of Wolf and Owl
    public class FableofWolfandOwl : MagicCard
    {
        public FableofWolfandOwl()
        {
            Name = "Fable of Wolf and Owl";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "3%S%S%S";
            PT = "";
            Type = "Enchantment";
            Text = "Whenever you cast a green spell, you may put a 2/2 green Wolf creature token onto the battlefield.;^Whenever you cast a blue spell, you may put a 1/1 blue Bird creature token with flying onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Fang Skulkin
    public class FangSkulkin : MagicCard
    {
        public FangSkulkin()
        {
            Name = "Fang Skulkin";
            Edition = "EVE";
            Rarity = "C";
            Color = "Art";
            Cost = "2";
            PT = "2/1";
            Type = "Artifact Creature - Scarecrow";
            Text = "%2: Target black creature gains wither until end of turn. @(It deals damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Favor of the Overbeing
    public class FavoroftheOverbeing : MagicCard
    {
        public FavoroftheOverbeing()
        {
            Name = "Favor of the Overbeing";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%S";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^As long as enchanted creature is green, it gets +1/+1 and has vigilance.;^As long as enchanted creature is blue, it gets +1/+1 and has flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Fetid Heath
    public class FetidHeath : MagicCard
    {
        public FetidHeath()
        {
            Name = "Fetid Heath";
            Edition = "EVE";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%O, %T: Add %W%W, %W%B, or %B%B to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Fiery Bombardment
    public class FieryBombardment : MagicCard
    {
        public FieryBombardment()
        {
            Name = "Fiery Bombardment";
            Edition = "EVE";
            Rarity = "R";
            Color = "R";
            Cost = "1R";
            PT = "";
            Type = "Enchantment";
            Text = "@Chroma@ � %2, Sacrifice a creature: Fiery Bombardment deals damage to target creature or player equal to the number of red mana symbols in the sacrificed creature�s mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Figure of Destiny
    public class FigureofDestiny : MagicCard
    {
        public FigureofDestiny()
        {
            Name = "Figure of Destiny";
            Edition = "EVE";
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

    # region Fire at Will
    public class FireatWill : MagicCard
    {
        public FireatWill()
        {
            Name = "Fire at Will";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "%P%P%P";
            PT = "";
            Type = "Instant";
            Text = "Fire at Will deals 3 damage divided as you choose among one, two, or three target attacking or blocking creatures.";
            Flavor = "";
        }
    }
    # endregion

    # region Flame Jab
    public class FlameJab : MagicCard
    {
        public FlameJab()
        {
            Name = "Flame Jab";
            Edition = "EVE";
            Rarity = "C";
            Color = "R";
            Cost = "R";
            PT = "";
            Type = "Sorcery";
            Text = "Flame Jab deals 1 damage to target creature or player.;^Retrace @(You may cast this card from your graveyard by discarding a land card in addition to paying its other costs.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Flickerwisp
    public class Flickerwisp : MagicCard
    {
        public Flickerwisp()
        {
            Name = "Flickerwisp";
            Edition = "EVE";
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

    # region Flooded Grove
    public class FloodedGrove : MagicCard
    {
        public FloodedGrove()
        {
            Name = "Flooded Grove";
            Edition = "EVE";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%S, %T: Add %G%G, %G%U, or %U%U to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Gift of the Deity
    public class GiftoftheDeity : MagicCard
    {
        public GiftoftheDeity()
        {
            Name = "Gift of the Deity";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "4%Q";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^As long as enchanted creature is black, it gets +1/+1 and has deathtouch. @(Any amount of damage it deals to a creature is enough to destroy that creature.)@;^As long as enchanted creature is green, it gets +1/+1 and all creatures able to block it do so.";
            Flavor = "";
        }
    }
    # endregion

    # region Gilder Bairn
    public class GilderBairn : MagicCard
    {
        public GilderBairn()
        {
            Name = "Gilder Bairn";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "1%S%S";
            PT = "1/3";
            Type = "Creature - Ouphe";
            Text = "%2%S, %C: For each counter on target permanent, put another of those counters on that permanent. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Glamerdye
    public class Glamerdye : MagicCard
    {
        public Glamerdye()
        {
            Name = "Glamerdye";
            Edition = "EVE";
            Rarity = "R";
            Color = "U";
            Cost = "1U";
            PT = "";
            Type = "Instant";
            Text = "Change the text of target spell or permanent by replacing all instances of one color word with another.;^Retrace @(You may cast this card from your graveyard by discarding a land card in addition to paying its other costs.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Glen Elendra Archmage
    public class GlenElendraArchmage : MagicCard
    {
        public GlenElendraArchmage()
        {
            Name = "Glen Elendra Archmage";
            Edition = "EVE";
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

    # region Grazing Kelpie
    public class GrazingKelpie : MagicCard
    {
        public GrazingKelpie()
        {
            Name = "Grazing Kelpie";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "3%S";
            PT = "2/3";
            Type = "Creature - Beast";
            Text = "%S, Sacrifice Grazing Kelpie: Put target card from a graveyard on the bottom of its owner�s library.;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Groundling Pouncer
    public class GroundlingPouncer : MagicCard
    {
        public GroundlingPouncer()
        {
            Name = "Groundling Pouncer";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "1%S";
            PT = "2/1";
            Type = "Creature - Faerie";
            Text = "%S: Groundling Pouncer gets +1/+3 and gains flying until end of turn. Activate this ability only once each turn and only if an opponent controls a creature with flying.";
            Flavor = "";
        }
    }
    # endregion

    # region Gwyllion Hedge-Mage
    public class GwyllionHedgeMage : MagicCard
    {
        public GwyllionHedgeMage()
        {
            Name = "Gwyllion Hedge-Mage";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%O";
            PT = "2/2";
            Type = "Creature - Hag Wizard";
            Text = "When Gwyllion Hedge-Mage enters the battlefield, if you control two or more Plains, you may put a 1/1 white Kithkin Soldier creature token onto the battlefield.;^When Gwyllion Hedge-Mage enters the battlefield, if you control two or more Swamps, you may put a -1/-1 counter on target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Hag Hedge-Mage
    public class HagHedgeMage : MagicCard
    {
        public HagHedgeMage()
        {
            Name = "Hag Hedge-Mage";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%Q";
            PT = "2/2";
            Type = "Creature - Hag Shaman";
            Text = "When Hag Hedge-Mage enters the battlefield, if you control two or more Swamps, you may have target player discard a card.;^When Hag Hedge-Mage enters the battlefield, if you control two or more Forests, you may put target card from your graveyard on top of your library.";
            Flavor = "";
        }
    }
    # endregion

    # region Hallowed Burial
    public class HallowedBurial : MagicCard
    {
        public HallowedBurial()
        {
            Name = "Hallowed Burial";
            Edition = "EVE";
            Rarity = "R";
            Color = "W";
            Cost = "3WW";
            PT = "";
            Type = "Sorcery";
            Text = "Put all creatures on the bottom of their owners� libraries.";
            Flavor = "";
        }
    }
    # endregion

    # region Harvest Gwyllion
    public class HarvestGwyllion : MagicCard
    {
        public HarvestGwyllion()
        {
            Name = "Harvest Gwyllion";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%O%O";
            PT = "2/4";
            Type = "Creature - Hag";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Hatchet Bully
    public class HatchetBully : MagicCard
    {
        public HatchetBully()
        {
            Name = "Hatchet Bully";
            Edition = "EVE";
            Rarity = "U";
            Color = "R";
            Cost = "3R";
            PT = "3/3";
            Type = "Creature - Goblin Warrior";
            Text = "%2%R, %T, Put a -1/-1 counter on a creature you control: Hatchet Bully deals 2 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Hateflayer
    public class Hateflayer : MagicCard
    {
        public Hateflayer()
        {
            Name = "Hateflayer";
            Edition = "EVE";
            Rarity = "R";
            Color = "R";
            Cost = "5RR";
            PT = "5/5";
            Type = "Creature - Elemental";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^%2%R, %C: Hateflayer deals damage equal to its power to target creature or player. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Hearthfire Hobgoblin
    public class HearthfireHobgoblin : MagicCard
    {
        public HearthfireHobgoblin()
        {
            Name = "Hearthfire Hobgoblin";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "%P%P%P";
            PT = "2/2";
            Type = "Creature - Goblin Soldier";
            Text = "Double strike";
            Flavor = "";
        }
    }
    # endregion

    # region Heartlash Cinder
    public class HeartlashCinder : MagicCard
    {
        public HeartlashCinder()
        {
            Name = "Heartlash Cinder";
            Edition = "EVE";
            Rarity = "C";
            Color = "R";
            Cost = "1R";
            PT = "1/1";
            Type = "Creature - Elemental Warrior";
            Text = "Haste;^@Chroma@ � When Heartlash Cinder enters the battlefield, it gets +X/+0 until end of turn, where X is the number of red mana symbols in the mana costs of permanents you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Helix Pinnacle
    public class HelixPinnacle : MagicCard
    {
        public HelixPinnacle()
        {
            Name = "Helix Pinnacle";
            Edition = "EVE";
            Rarity = "R";
            Color = "G";
            Cost = "G";
            PT = "";
            Type = "Enchantment";
            Text = "Shroud;^%X: Put X tower counters on Helix Pinnacle.;^At the beginning of your upkeep, if there are 100 or more tower counters on Helix Pinnacle, you win the game.";
            Flavor = "";
        }
    }
    # endregion

    # region Hobgoblin Dragoon
    public class HobgoblinDragoon : MagicCard
    {
        public HobgoblinDragoon()
        {
            Name = "Hobgoblin Dragoon";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%P";
            PT = "1/2";
            Type = "Creature - Goblin Knight";
            Text = "Flying, first strike";
            Flavor = "";
        }
    }
    # endregion

    # region Hoof Skulkin
    public class HoofSkulkin : MagicCard
    {
        public HoofSkulkin()
        {
            Name = "Hoof Skulkin";
            Edition = "EVE";
            Rarity = "C";
            Color = "Art";
            Cost = "3";
            PT = "2/2";
            Type = "Artifact Creature - Scarecrow";
            Text = "%3: Target green creature gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Hotheaded Giant
    public class HotheadedGiant : MagicCard
    {
        public HotheadedGiant()
        {
            Name = "Hotheaded Giant";
            Edition = "EVE";
            Rarity = "C";
            Color = "R";
            Cost = "3R";
            PT = "4/4";
            Type = "Creature - Giant Warrior";
            Text = "Haste;^Hotheaded Giant enters the battlefield with two -1/-1 counters on it unless you�ve cast another red spell this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Idle Thoughts
    public class IdleThoughts : MagicCard
    {
        public IdleThoughts()
        {
            Name = "Idle Thoughts";
            Edition = "EVE";
            Rarity = "U";
            Color = "U";
            Cost = "3U";
            PT = "";
            Type = "Enchantment";
            Text = "%2: Draw a card if you have no cards in hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Impelled Giant
    public class ImpelledGiant : MagicCard
    {
        public ImpelledGiant()
        {
            Name = "Impelled Giant";
            Edition = "EVE";
            Rarity = "U";
            Color = "R";
            Cost = "4RR";
            PT = "3/3";
            Type = "Creature - Giant Warrior";
            Text = "Trample;^Tap an untapped red creature you control other than Impelled Giant: Impelled Giant gets +X/+0 until end of turn, where X is the power of the creature tapped this way.";
            Flavor = "";
        }
    }
    # endregion

    # region Indigo Faerie
    public class IndigoFaerie : MagicCard
    {
        public IndigoFaerie()
        {
            Name = "Indigo Faerie";
            Edition = "EVE";
            Rarity = "U";
            Color = "U";
            Cost = "1U";
            PT = "1/1";
            Type = "Creature - Faerie Wizard";
            Text = "Flying;^%U: Target permanent becomes blue in addition to its other colors until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Inside Out
    public class InsideOut : MagicCard
    {
        public InsideOut()
        {
            Name = "Inside Out";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%I";
            PT = "";
            Type = "Instant";
            Text = "Switch target creature�s power and toughness until end of turn.;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Inundate
    public class Inundate : MagicCard
    {
        public Inundate()
        {
            Name = "Inundate";
            Edition = "EVE";
            Rarity = "R";
            Color = "U";
            Cost = "3UUU";
            PT = "";
            Type = "Sorcery";
            Text = "Return all nonblue creatures to their owners� hands.";
            Flavor = "";
        }
    }
    # endregion

    # region Invert the Skies
    public class InverttheSkies : MagicCard
    {
        public InverttheSkies()
        {
            Name = "Invert the Skies";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "3%S";
            PT = "";
            Type = "Instant";
            Text = "Creatures your opponents control lose flying until end of turn if %G was spent to cast Invert the Skies, and creatures you control gain flying until end of turn if %U was spent to cast it. @(Do both if %G%U was spent.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Jawbone Skulkin
    public class JawboneSkulkin : MagicCard
    {
        public JawboneSkulkin()
        {
            Name = "Jawbone Skulkin";
            Edition = "EVE";
            Rarity = "C";
            Color = "Art";
            Cost = "1";
            PT = "1/1";
            Type = "Artifact Creature - Scarecrow";
            Text = "%2: Target red creature gains haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Kithkin Spellduster
    public class KithkinSpellduster : MagicCard
    {
        public KithkinSpellduster()
        {
            Name = "Kithkin Spellduster";
            Edition = "EVE";
            Rarity = "C";
            Color = "W";
            Cost = "4W";
            PT = "2/3";
            Type = "Creature - Kithkin Wizard";
            Text = "Flying;^%1%W, Sacrifice Kithkin Spellduster: Destroy target enchantment.;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Kithkin Zealot
    public class KithkinZealot : MagicCard
    {
        public KithkinZealot()
        {
            Name = "Kithkin Zealot";
            Edition = "EVE";
            Rarity = "C";
            Color = "W";
            Cost = "1W";
            PT = "1/3";
            Type = "Creature - Kithkin Cleric";
            Text = "When Kithkin Zealot enters the battlefield, you gain 1 life for each black and/or red permanent target opponent controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Leering Emblem
    public class LeeringEmblem : MagicCard
    {
        public LeeringEmblem()
        {
            Name = "Leering Emblem";
            Edition = "EVE";
            Rarity = "R";
            Color = "Art";
            Cost = "2";
            PT = "";
            Type = "Artifact - Equipment";
            Text = "Whenever you cast a spell, equipped creature gets +2/+2 until end of turn.;^Equip %2";
            Flavor = "";
        }
    }
    # endregion

    # region Light from Within
    public class LightfromWithin : MagicCard
    {
        public LightfromWithin()
        {
            Name = "Light from Within";
            Edition = "EVE";
            Rarity = "R";
            Color = "W";
            Cost = "2WW";
            PT = "";
            Type = "Enchantment";
            Text = "@Chroma@ � Each creature you control gets +1/+1 for each white mana symbol in its mana cost.";
            Flavor = "";
        }
    }
    # endregion

    # region Lingering Tormentor
    public class LingeringTormentor : MagicCard
    {
        public LingeringTormentor()
        {
            Name = "Lingering Tormentor";
            Edition = "EVE";
            Rarity = "U";
            Color = "B";
            Cost = "3B";
            PT = "2/2";
            Type = "Creature - Spirit";
            Text = "Fear @(This creature can�t be blocked except by artifact creatures and/or black creatures.)@;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Loyal Gyrfalcon
    public class LoyalGyrfalcon : MagicCard
    {
        public LoyalGyrfalcon()
        {
            Name = "Loyal Gyrfalcon";
            Edition = "EVE";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "3/3";
            Type = "Creature - Bird";
            Text = "Defender, flying;^Whenever you cast a white spell, Loyal Gyrfalcon loses defender until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Marshdrinker Giant
    public class MarshdrinkerGiant : MagicCard
    {
        public MarshdrinkerGiant()
        {
            Name = "Marshdrinker Giant";
            Edition = "EVE";
            Rarity = "U";
            Color = "G";
            Cost = "3GG";
            PT = "4/3";
            Type = "Creature - Giant Warrior";
            Text = "When Marshdrinker Giant enters the battlefield, destroy target Island or Swamp an opponent controls.";
            Flavor = "";
        }
    }
    # endregion

    # region Merrow Bonegnawer
    public class MerrowBonegnawer : MagicCard
    {
        public MerrowBonegnawer()
        {
            Name = "Merrow Bonegnawer";
            Edition = "EVE";
            Rarity = "C";
            Color = "B";
            Cost = "B";
            PT = "1/1";
            Type = "Creature - Merfolk Rogue";
            Text = "%T: Target player exiles a card from his or her graveyard.;^Whenever you cast a black spell, you may untap Merrow Bonegnawer.";
            Flavor = "";
        }
    }
    # endregion

    # region Merrow Levitator
    public class MerrowLevitator : MagicCard
    {
        public MerrowLevitator()
        {
            Name = "Merrow Levitator";
            Edition = "EVE";
            Rarity = "C";
            Color = "U";
            Cost = "3U";
            PT = "2/3";
            Type = "Creature - Merfolk Wizard";
            Text = "%T: Target creature gains flying until end of turn.;^Whenever you cast a blue spell, you may untap Merrow Levitator.";
            Flavor = "";
        }
    }
    # endregion

    # region Mindwrack Liege
    public class MindwrackLiege : MagicCard
    {
        public MindwrackLiege()
        {
            Name = "Mindwrack Liege";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "3%I%I%I";
            PT = "4/4";
            Type = "Creature - Horror";
            Text = "Other blue creatures you control get +1/+1.;^Other red creatures you control get +1/+1.;^%I%I%I%I: You may put a blue or red creature card from your hand onto the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Mirror Sheen
    public class MirrorSheen : MagicCard
    {
        public MirrorSheen()
        {
            Name = "Mirror Sheen";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "1%I%I";
            PT = "";
            Type = "Enchantment";
            Text = "%1%I%I: Copy target instant or sorcery spell that targets you. You may choose new targets for the copy.";
            Flavor = "";
        }
    }
    # endregion

    # region Monstrify
    public class Monstrify : MagicCard
    {
        public Monstrify()
        {
            Name = "Monstrify";
            Edition = "EVE";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "";
            Type = "Sorcery";
            Text = "Target creature gets +4/+4 until end of turn.;^Retrace @(You may cast this card from your graveyard by discarding a land card in addition to paying its other costs.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Moonhold
    public class Moonhold : MagicCard
    {
        public Moonhold()
        {
            Name = "Moonhold";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%P";
            PT = "";
            Type = "Instant";
            Text = "Target player can�t play land cards this turn if %R was spent to cast Moonhold and can�t play creature cards this turn if %W was spent to cast it. @(Do both if %R%W was spent.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Murkfiend Liege
    public class MurkfiendLiege : MagicCard
    {
        public MurkfiendLiege()
        {
            Name = "Murkfiend Liege";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "2%S%S%S";
            PT = "4/4";
            Type = "Creature - Horror";
            Text = "Other green creatures you control get +1/+1.;^Other blue creatures you control get +1/+1.;^Untap all green and/or blue creatures you control during each other player�s untap step.";
            Flavor = "";
        }
    }
    # endregion

    # region Necroskitter
    public class Necroskitter : MagicCard
    {
        public Necroskitter()
        {
            Name = "Necroskitter";
            Edition = "EVE";
            Rarity = "R";
            Color = "B";
            Cost = "1BB";
            PT = "1/4";
            Type = "Creature - Elemental";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^Whenever a creature an opponent controls with a -1/-1 counter on it dies, you may return that card to the battlefield under your control.";
            Flavor = "";
        }
    }
    # endregion

    # region Needle Specter
    public class NeedleSpecter : MagicCard
    {
        public NeedleSpecter()
        {
            Name = "Needle Specter";
            Edition = "EVE";
            Rarity = "R";
            Color = "B";
            Cost = "1BB";
            PT = "1/1";
            Type = "Creature - Specter";
            Text = "Flying;^Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^Whenever Needle Specter deals combat damage to a player, that player discards that many cards.";
            Flavor = "";
        }
    }
    # endregion

    # region Nettle Sentinel
    public class NettleSentinel : MagicCard
    {
        public NettleSentinel()
        {
            Name = "Nettle Sentinel";
            Edition = "EVE";
            Rarity = "C";
            Color = "G";
            Cost = "G";
            PT = "2/2";
            Type = "Creature - Elf Warrior";
            Text = "Nettle Sentinel doesn�t untap during your untap step.;^Whenever you cast a green spell, you may untap Nettle Sentinel.";
            Flavor = "";
        }
    }
    # endregion

    # region Nightmare Incursion
    public class NightmareIncursion : MagicCard
    {
        public NightmareIncursion()
        {
            Name = "Nightmare Incursion";
            Edition = "EVE";
            Rarity = "R";
            Color = "B";
            Cost = "5B";
            PT = "";
            Type = "Sorcery";
            Text = "Search target player�s library for up to X cards, where X is the number of Swamps you control, and exile them. Then that player shuffles his or her library.";
            Flavor = "";
        }
    }
    # endregion

    # region Nightsky Mimic
    public class NightskyMimic : MagicCard
    {
        public NightskyMimic()
        {
            Name = "Nightsky Mimic";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%O";
            PT = "2/1";
            Type = "Creature - Shapeshifter";
            Text = "Whenever you cast a spell that�s both white and black, Nightsky Mimic becomes 4/4 and gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Nip Gwyllion
    public class NipGwyllion : MagicCard
    {
        public NipGwyllion()
        {
            Name = "Nip Gwyllion";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "%O";
            PT = "1/1";
            Type = "Creature - Hag";
            Text = "Lifelink @(Damage dealt by this creature also causes you to gain that much life.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Nobilis of War
    public class NobilisofWar : MagicCard
    {
        public NobilisofWar()
        {
            Name = "Nobilis of War";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "%P%P%P%P%P";
            PT = "3/4";
            Type = "Creature - Spirit Avatar";
            Text = "Flying;^Attacking creatures you control get +2/+0.";
            Flavor = "";
        }
    }
    # endregion

    # region Noggle Bandit
    public class NoggleBandit : MagicCard
    {
        public NoggleBandit()
        {
            Name = "Noggle Bandit";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%I%I";
            PT = "2/2";
            Type = "Creature - Noggle Rogue";
            Text = "Noggle Bandit can�t be blocked except by creatures with defender.";
            Flavor = "";
        }
    }
    # endregion

    # region Noggle Bridgebreaker
    public class NoggleBridgebreaker : MagicCard
    {
        public NoggleBridgebreaker()
        {
            Name = "Noggle Bridgebreaker";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%I%I";
            PT = "4/3";
            Type = "Creature - Noggle Rogue";
            Text = "When Noggle Bridgebreaker enters the battlefield, return a land you control to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Noggle Hedge-Mage
    public class NoggleHedgeMage : MagicCard
    {
        public NoggleHedgeMage()
        {
            Name = "Noggle Hedge-Mage";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%I";
            PT = "2/2";
            Type = "Creature - Noggle Wizard";
            Text = "When Noggle Hedge-Mage enters the battlefield, if you control two or more Islands, you may tap two target permanents.;^When Noggle Hedge-Mage enters the battlefield, if you control two or more Mountains, you may have Noggle Hedge-Mage deal 2 damage to target player.";
            Flavor = "";
        }
    }
    # endregion

    # region Noggle Ransacker
    public class NoggleRansacker : MagicCard
    {
        public NoggleRansacker()
        {
            Name = "Noggle Ransacker";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%I";
            PT = "2/1";
            Type = "Creature - Noggle Rogue";
            Text = "When Noggle Ransacker enters the battlefield, each player draws two cards, then discards a card at random.";
            Flavor = "";
        }
    }
    # endregion

    # region Noxious Hatchling
    public class NoxiousHatchling : MagicCard
    {
        public NoxiousHatchling()
        {
            Name = "Noxious Hatchling";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "3%Q";
            PT = "6/6";
            Type = "Creature - Elemental";
            Text = "Noxious Hatchling enters the battlefield with four -1/-1 counters on it.;^Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^Whenever you cast a black spell, remove a -1/-1 counter from Noxious Hatchling.;^Whenever you cast a green spell, remove a -1/-1 counter from Noxious Hatchling.";
            Flavor = "";
        }
    }
    # endregion

    # region Nucklavee
    public class Nucklavee : MagicCard
    {
        public Nucklavee()
        {
            Name = "Nucklavee";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "4%I%I";
            PT = "4/4";
            Type = "Creature - Beast";
            Text = "When Nucklavee enters the battlefield, you may return target red sorcery card from your graveyard to your hand.;^When Nucklavee enters the battlefield, you may return target blue instant card from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Odious Trow
    public class OdiousTrow : MagicCard
    {
        public OdiousTrow()
        {
            Name = "Odious Trow";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "%Q";
            PT = "1/1";
            Type = "Creature - Troll";
            Text = "%1%Q: Regenerate Odious Trow.";
            Flavor = "";
        }
    }
    # endregion

    # region Oona's Grace
    public class OonasGrace : MagicCard
    {
        public OonasGrace()
        {
            Name = "Oona's Grace";
            Edition = "EVE";
            Rarity = "C";
            Color = "U";
            Cost = "2U";
            PT = "";
            Type = "Instant";
            Text = "Target player draws a card.;^Retrace @(You may cast this card from your graveyard by discarding a land card in addition to paying its other costs.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Outrage Shaman
    public class OutrageShaman : MagicCard
    {
        public OutrageShaman()
        {
            Name = "Outrage Shaman";
            Edition = "EVE";
            Rarity = "U";
            Color = "R";
            Cost = "3RR";
            PT = "2/2";
            Type = "Creature - Goblin Shaman";
            Text = "@Chroma@ � When Outrage Shaman enters the battlefield, it deals damage to target creature equal to the number of red mana symbols in the mana costs of permanents you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Overbeing of Myth
    public class OverbeingofMyth : MagicCard
    {
        public OverbeingofMyth()
        {
            Name = "Overbeing of Myth";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "%S%S%S%S%S";
            PT = "*/*";
            Type = "Creature - Spirit Avatar";
            Text = "Overbeing of Myth�s power and toughness are each equal to the number of cards in your hand.;^At the beginning of your draw step, draw an additional card.";
            Flavor = "";
        }
    }
    # endregion

    # region Patrol Signaler
    public class PatrolSignaler : MagicCard
    {
        public PatrolSignaler()
        {
            Name = "Patrol Signaler";
            Edition = "EVE";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "1/1";
            Type = "Creature - Kithkin Soldier";
            Text = "%1%W, %C: Put a 1/1 white Kithkin Soldier creature token onto the battlefield. @(%C is the untap symbol.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Phosphorescent Feast
    public class PhosphorescentFeast : MagicCard
    {
        public PhosphorescentFeast()
        {
            Name = "Phosphorescent Feast";
            Edition = "EVE";
            Rarity = "U";
            Color = "G";
            Cost = "2GGG";
            PT = "";
            Type = "Sorcery";
            Text = "@Chroma@ � Reveal any number of cards in your hand. You gain 2 life for each green mana symbol in those cards� mana costs.";
            Flavor = "";
        }
    }
    # endregion

    # region Primalcrux
    public class Primalcrux : MagicCard
    {
        public Primalcrux()
        {
            Name = "Primalcrux";
            Edition = "EVE";
            Rarity = "R";
            Color = "G";
            Cost = "GGGGGG";
            PT = "*/*";
            Type = "Creature - Elemental";
            Text = "Trample;^@Chroma@ � Primalcrux�s power and toughness are each equal to the number of green mana symbols in the mana costs of permanents you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Puncture Blast
    public class PunctureBlast : MagicCard
    {
        public PunctureBlast()
        {
            Name = "Puncture Blast";
            Edition = "EVE";
            Rarity = "C";
            Color = "R";
            Cost = "2R";
            PT = "";
            Type = "Instant";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^Puncture Blast deals 3 damage to target creature or player.";
            Flavor = "";
        }
    }
    # endregion

    # region Pyrrhic Revival
    public class PyrrhicRevival : MagicCard
    {
        public PyrrhicRevival()
        {
            Name = "Pyrrhic Revival";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "3%O%O%O";
            PT = "";
            Type = "Sorcery";
            Text = "Each player returns each creature card from his or her graveyard to the battlefield with an additional -1/-1 counter on it.";
            Flavor = "";
        }
    }
    # endregion

    # region Quillspike
    public class Quillspike : MagicCard
    {
        public Quillspike()
        {
            Name = "Quillspike";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%Q";
            PT = "1/1";
            Type = "Creature - Beast";
            Text = "%Q, Remove a -1/-1 counter from a creature you control: Quillspike gets +3/+3 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Raven's Crime
    public class RavensCrime : MagicCard
    {
        public RavensCrime()
        {
            Name = "Raven's Crime";
            Edition = "EVE";
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

    # region Razorfin Abolisher
    public class RazorfinAbolisher : MagicCard
    {
        public RazorfinAbolisher()
        {
            Name = "Razorfin Abolisher";
            Edition = "EVE";
            Rarity = "U";
            Color = "U";
            Cost = "2U";
            PT = "2/2";
            Type = "Creature - Merfolk Wizard";
            Text = "%1%U, %T: Return target creature with a counter on it to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Recumbent Bliss
    public class RecumbentBliss : MagicCard
    {
        public RecumbentBliss()
        {
            Name = "Recumbent Bliss";
            Edition = "EVE";
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

    # region Regal Force
    public class RegalForce : MagicCard
    {
        public RegalForce()
        {
            Name = "Regal Force";
            Edition = "EVE";
            Rarity = "R";
            Color = "G";
            Cost = "4GGG";
            PT = "5/5";
            Type = "Creature - Elemental";
            Text = "When Regal Force enters the battlefield, draw a card for each green creature you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Rekindled Flame
    public class RekindledFlame : MagicCard
    {
        public RekindledFlame()
        {
            Name = "Rekindled Flame";
            Edition = "EVE";
            Rarity = "R";
            Color = "R";
            Cost = "2RR";
            PT = "";
            Type = "Sorcery";
            Text = "Rekindled Flame deals 4 damage to target creature or player.;^At the beginning of your upkeep, if an opponent has no cards in hand, you may return Rekindled Flame from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Rendclaw Trow
    public class RendclawTrow : MagicCard
    {
        public RendclawTrow()
        {
            Name = "Rendclaw Trow";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%Q";
            PT = "2/2";
            Type = "Creature - Troll";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Restless Apparition
    public class RestlessApparition : MagicCard
    {
        public RestlessApparition()
        {
            Name = "Restless Apparition";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "%O%O%O";
            PT = "2/2";
            Type = "Creature - Spirit";
            Text = "%O%O%O: Restless Apparition gets +3/+3 until end of turn.;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Rise of the Hobgoblins
    public class RiseoftheHobgoblins : MagicCard
    {
        public RiseoftheHobgoblins()
        {
            Name = "Rise of the Hobgoblins";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "%P%P";
            PT = "";
            Type = "Enchantment";
            Text = "When Rise of the Hobgoblins enters the battlefield, you may pay %X. If you do, put X 1/1 red and white Goblin Soldier creature tokens onto the battlefield.;^%P: Red creatures and white creatures you control gain first strike until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Riverfall Mimic
    public class RiverfallMimic : MagicCard
    {
        public RiverfallMimic()
        {
            Name = "Riverfall Mimic";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%I";
            PT = "2/1";
            Type = "Creature - Shapeshifter";
            Text = "Whenever you cast a spell that�s both blue and red, Riverfall Mimic becomes 3/3 until end of turn and can�t be blocked this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Rugged Prairie
    public class RuggedPrairie : MagicCard
    {
        public RuggedPrairie()
        {
            Name = "Rugged Prairie";
            Edition = "EVE";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%P, %T: Add %R%R, %R%W, or %W%W to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Sanity Grinding
    public class SanityGrinding : MagicCard
    {
        public SanityGrinding()
        {
            Name = "Sanity Grinding";
            Edition = "EVE";
            Rarity = "R";
            Color = "U";
            Cost = "UUU";
            PT = "";
            Type = "Sorcery";
            Text = "@Chroma@ � Reveal the top ten cards of your library. For each blue mana symbol in the mana costs of the revealed cards, target opponent puts the top card of his or her library into his or her graveyard. Then put the cards you revealed this way on the bottom of your library in any order.";
            Flavor = "";
        }
    }
    # endregion

    # region Sapling of Colfenor
    public class SaplingofColfenor : MagicCard
    {
        public SaplingofColfenor()
        {
            Name = "Sapling of Colfenor";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "3%Q%Q";
            PT = "2/5";
            Type = "Legendary Creature - Treefolk Shaman";
            Text = "Indestructible;^Whenever Sapling of Colfenor attacks, reveal the top card of your library. If it�s a creature card, you gain life equal to that card�s toughness, lose life equal to its power, then put it into your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Savage Conception
    public class SavageConception : MagicCard
    {
        public SavageConception()
        {
            Name = "Savage Conception";
            Edition = "EVE";
            Rarity = "U";
            Color = "G";
            Cost = "3GG";
            PT = "";
            Type = "Sorcery";
            Text = "Put a 3/3 green Beast creature token onto the battlefield.;^Retrace @(You may cast this card from your graveyard by discarding a land card in addition to paying its other costs.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Scarecrone
    public class Scarecrone : MagicCard
    {
        public Scarecrone()
        {
            Name = "Scarecrone";
            Edition = "EVE";
            Rarity = "R";
            Color = "Art";
            Cost = "3";
            PT = "1/2";
            Type = "Artifact Creature - Scarecrow";
            Text = "%1, Sacrifice a Scarecrow: Draw a card.;^%4, %T: Return target artifact creature card from your graveyard to the battlefield.";
            Flavor = "";
        }
    }
    # endregion

    # region Scourge of the Nobilis
    public class ScourgeoftheNobilis : MagicCard
    {
        public ScourgeoftheNobilis()
        {
            Name = "Scourge of the Nobilis";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%P";
            PT = "";
            Type = "Enchantment - Aura";
            Text = "Enchant creature;^As long as enchanted creature is red, it gets +1/+1 and has �%P: This creature gets +1/+0 until end of turn.�;^As long as enchanted creature is white, it gets +1/+1 and has lifelink. @(Damage dealt by the creature also causes its controller to gain that much life.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Selkie Hedge-Mage
    public class SelkieHedgeMage : MagicCard
    {
        public SelkieHedgeMage()
        {
            Name = "Selkie Hedge-Mage";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%S";
            PT = "2/2";
            Type = "Creature - Merfolk Wizard";
            Text = "When Selkie Hedge-Mage enters the battlefield, if you control two or more Forests, you may gain 3 life.;^When Selkie Hedge-Mage enters the battlefield, if you control two or more Islands, you may return target tapped creature to its owner�s hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Shell Skulkin
    public class ShellSkulkin : MagicCard
    {
        public ShellSkulkin()
        {
            Name = "Shell Skulkin";
            Edition = "EVE";
            Rarity = "C";
            Color = "Art";
            Cost = "4";
            PT = "3/2";
            Type = "Artifact Creature - Scarecrow";
            Text = "%3: Target blue creature gains shroud until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Shorecrasher Mimic
    public class ShorecrasherMimic : MagicCard
    {
        public ShorecrasherMimic()
        {
            Name = "Shorecrasher Mimic";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%S";
            PT = "2/1";
            Type = "Creature - Shapeshifter";
            Text = "Whenever you cast a spell that�s both green and blue, Shorecrasher Mimic becomes 5/3 and gains trample until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Shrewd Hatchling
    public class ShrewdHatchling : MagicCard
    {
        public ShrewdHatchling()
        {
            Name = "Shrewd Hatchling";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "3%I";
            PT = "6/6";
            Type = "Creature - Elemental";
            Text = "Shrewd Hatchling enters the battlefield with four -1/-1 counters on it.;^%I: Target creature can�t block Shrewd Hatchling this turn.;^Whenever you cast a blue spell, remove a -1/-1 counter from Shrewd Hatchling.;^Whenever you cast a red spell, remove a -1/-1 counter from Shrewd Hatchling.";
            Flavor = "";
        }
    }
    # endregion

    # region Slippery Bogle
    public class SlipperyBogle : MagicCard
    {
        public SlipperyBogle()
        {
            Name = "Slippery Bogle";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "%S";
            PT = "1/1";
            Type = "Creature - Beast";
            Text = "Hexproof @(This creature can�t be the target of spells or abilities your opponents control.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Smoldering Butcher
    public class SmolderingButcher : MagicCard
    {
        public SmolderingButcher()
        {
            Name = "Smoldering Butcher";
            Edition = "EVE";
            Rarity = "C";
            Color = "B";
            Cost = "3B";
            PT = "4/2";
            Type = "Creature - Elemental Warrior";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Snakeform
    public class Snakeform : MagicCard
    {
        public Snakeform()
        {
            Name = "Snakeform";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "2%S";
            PT = "";
            Type = "Instant";
            Text = "Target creature loses all abilities and becomes a 1/1 green Snake until end of turn.;^Draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Soot Imp
    public class SootImp : MagicCard
    {
        public SootImp()
        {
            Name = "Soot Imp";
            Edition = "EVE";
            Rarity = "U";
            Color = "B";
            Cost = "1BB";
            PT = "1/2";
            Type = "Creature - Imp";
            Text = "Flying;^Whenever a player casts a nonblack spell, that player loses 1 life.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul Reap
    public class SoulReap : MagicCard
    {
        public SoulReap()
        {
            Name = "Soul Reap";
            Edition = "EVE";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Sorcery";
            Text = "Destroy target nongreen creature. Its controller loses 3 life if you�ve cast another black spell this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Soul Snuffers
    public class SoulSnuffers : MagicCard
    {
        public SoulSnuffers()
        {
            Name = "Soul Snuffers";
            Edition = "EVE";
            Rarity = "U";
            Color = "B";
            Cost = "2BB";
            PT = "3/3";
            Type = "Creature - Elemental Shaman";
            Text = "When Soul Snuffers enters the battlefield, put a -1/-1 counter on each creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Spirit of the Hearth
    public class SpiritoftheHearth : MagicCard
    {
        public SpiritoftheHearth()
        {
            Name = "Spirit of the Hearth";
            Edition = "EVE";
            Rarity = "R";
            Color = "W";
            Cost = "4WW";
            PT = "4/5";
            Type = "Creature - Cat Spirit";
            Text = "Flying;^You have hexproof. @(You can�t be the target of spells or abilities your opponents control.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Spitemare
    public class Spitemare : MagicCard
    {
        public Spitemare()
        {
            Name = "Spitemare";
            Edition = "EVE";
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

    # region Spitting Image
    public class SpittingImage : MagicCard
    {
        public SpittingImage()
        {
            Name = "Spitting Image";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "4%S%S";
            PT = "";
            Type = "Sorcery";
            Text = "Put a token that�s a copy of target creature onto the battlefield.;^Retrace @(You may cast this card from your graveyard by discarding a land card in addition to paying its other costs.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Springjack Pasture
    public class SpringjackPasture : MagicCard
    {
        public SpringjackPasture()
        {
            Name = "Springjack Pasture";
            Edition = "EVE";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%4, %T: Put a 0/1 white Goat creature token onto the battlefield.;^%T, Sacrifice X Goats: Add X mana of any one color to your mana pool. You gain X life.";
            Flavor = "";
        }
    }
    # endregion

    # region Springjack Shepherd
    public class SpringjackShepherd : MagicCard
    {
        public SpringjackShepherd()
        {
            Name = "Springjack Shepherd";
            Edition = "EVE";
            Rarity = "U";
            Color = "W";
            Cost = "3W";
            PT = "1/2";
            Type = "Creature - Kithkin Wizard";
            Text = "@Chroma@ � When Springjack Shepherd enters the battlefield, put a 0/1 white Goat creature token onto the battlefield for each white mana symbol in the mana costs of permanents you control.";
            Flavor = "";
        }
    }
    # endregion

    # region Stalker Hag
    public class StalkerHag : MagicCard
    {
        public StalkerHag()
        {
            Name = "Stalker Hag";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "%Q%Q%Q";
            PT = "3/2";
            Type = "Creature - Hag";
            Text = "Swampwalk, forestwalk";
            Flavor = "";
        }
    }
    # endregion

    # region Stigma Lasher
    public class StigmaLasher : MagicCard
    {
        public StigmaLasher()
        {
            Name = "Stigma Lasher";
            Edition = "EVE";
            Rarity = "R";
            Color = "R";
            Cost = "RR";
            PT = "2/2";
            Type = "Creature - Elemental Shaman";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^Whenever Stigma Lasher deals damage to a player, that player can�t gain life for the rest of the game.";
            Flavor = "";
        }
    }
    # endregion

    # region Stillmoon Cavalier
    public class StillmoonCavalier : MagicCard
    {
        public StillmoonCavalier()
        {
            Name = "Stillmoon Cavalier";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "1%O%O";
            PT = "2/1";
            Type = "Creature - Zombie Knight";
            Text = "Protection from white and from black;^%O: Stillmoon Cavalier gains flying until end of turn.;^%O: Stillmoon Cavalier gains first strike until end of turn.;^%O%O: Stillmoon Cavalier gets +1/+0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Stream Hopper
    public class StreamHopper : MagicCard
    {
        public StreamHopper()
        {
            Name = "Stream Hopper";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "%I";
            PT = "1/1";
            Type = "Creature - Goblin";
            Text = "%I: Stream Hopper gains flying until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Sturdy Hatchling
    public class SturdyHatchling : MagicCard
    {
        public SturdyHatchling()
        {
            Name = "Sturdy Hatchling";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "3%S";
            PT = "6/6";
            Type = "Creature - Elemental";
            Text = "Sturdy Hatchling enters the battlefield with four -1/-1 counters on it.;^%S: Sturdy Hatchling gains shroud until end of turn.;^Whenever you cast a green spell, remove a -1/-1 counter from Sturdy Hatchling.;^Whenever you cast a blue spell, remove a -1/-1 counter from Sturdy Hatchling.";
            Flavor = "";
        }
    }
    # endregion

    # region Suture Spirit
    public class SutureSpirit : MagicCard
    {
        public SutureSpirit()
        {
            Name = "Suture Spirit";
            Edition = "EVE";
            Rarity = "U";
            Color = "W";
            Cost = "1W";
            PT = "1/1";
            Type = "Creature - Spirit";
            Text = "Flying;^%O%O%O: Regenerate target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Swirling Spriggan
    public class SwirlingSpriggan : MagicCard
    {
        public SwirlingSpriggan()
        {
            Name = "Swirling Spriggan";
            Edition = "EVE";
            Rarity = "U";
            Color = "G";
            Cost = "2GG";
            PT = "3/3";
            Type = "Creature - Goblin Shaman";
            Text = "%S%S: Target creature you control becomes the color or colors of your choice until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Syphon Life
    public class SyphonLife : MagicCard
    {
        public SyphonLife()
        {
            Name = "Syphon Life";
            Edition = "EVE";
            Rarity = "U";
            Color = "B";
            Cost = "1BB";
            PT = "";
            Type = "Sorcery";
            Text = "Target player loses 2 life and you gain 2 life.;^Retrace @(You may cast this card from your graveyard by discarding a land card in addition to paying its other costs.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Talara's Bane
    public class TalarasBane : MagicCard
    {
        public TalarasBane()
        {
            Name = "Talara's Bane";
            Edition = "EVE";
            Rarity = "C";
            Color = "B";
            Cost = "1B";
            PT = "";
            Type = "Sorcery";
            Text = "Target opponent reveals his or her hand. You choose a green or white creature card from it. You gain life equal that creature card�s toughness, then that player discards that card.";
            Flavor = "";
        }
    }
    # endregion

    # region Talara's Battalion
    public class TalarasBattalion : MagicCard
    {
        public TalarasBattalion()
        {
            Name = "Talara's Battalion";
            Edition = "EVE";
            Rarity = "R";
            Color = "G";
            Cost = "1G";
            PT = "4/3";
            Type = "Creature - Elf Warrior";
            Text = "Trample;^Cast Talara�s Battalion only if you�ve cast another green spell this turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Talonrend
    public class Talonrend : MagicCard
    {
        public Talonrend()
        {
            Name = "Talonrend";
            Edition = "EVE";
            Rarity = "U";
            Color = "U";
            Cost = "4U";
            PT = "0/5";
            Type = "Creature - Elemental";
            Text = "Flying;^%I: Talonrend gets +1/-1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Thunderblust
    public class Thunderblust : MagicCard
    {
        public Thunderblust()
        {
            Name = "Thunderblust";
            Edition = "EVE";
            Rarity = "R";
            Color = "R";
            Cost = "2RRR";
            PT = "7/2";
            Type = "Creature - Elemental";
            Text = "Haste;^Thunderblust has trample as long as it has a -1/-1 counter on it.;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Tilling Treefolk
    public class TillingTreefolk : MagicCard
    {
        public TillingTreefolk()
        {
            Name = "Tilling Treefolk";
            Edition = "EVE";
            Rarity = "C";
            Color = "G";
            Cost = "2G";
            PT = "1/3";
            Type = "Creature - Treefolk Druid";
            Text = "When Tilling Treefolk enters the battlefield, you may return up to two target land cards from your graveyard to your hand.";
            Flavor = "";
        }
    }
    # endregion

    # region Trapjaw Kelpie
    public class TrapjawKelpie : MagicCard
    {
        public TrapjawKelpie()
        {
            Name = "Trapjaw Kelpie";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "4%S%S";
            PT = "3/3";
            Type = "Creature - Beast";
            Text = "Flash;^Persist @(When this creature dies, if it had no -1/-1 counters on it, return it to the battlefield under its owner�s control with a -1/-1 counter on it.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Twilight Mire
    public class TwilightMire : MagicCard
    {
        public TwilightMire()
        {
            Name = "Twilight Mire";
            Edition = "EVE";
            Rarity = "R";
            Color = "Lnd";
            Cost = "";
            PT = "";
            Type = "Land";
            Text = "%T: Add %1 to your mana pool.;^%Q, %T: Add %B%B, %B%G, or %G%G to your mana pool.";
            Flavor = "";
        }
    }
    # endregion

    # region Twinblade Slasher
    public class TwinbladeSlasher : MagicCard
    {
        public TwinbladeSlasher()
        {
            Name = "Twinblade Slasher";
            Edition = "EVE";
            Rarity = "U";
            Color = "G";
            Cost = "G";
            PT = "1/1";
            Type = "Creature - Elf Warrior";
            Text = "Wither @(This deals damage to creatures in the form of -1/-1 counters.)@;^%1%G: Twinblade Slasher gets +2/+2 until end of turn. Activate this ability only once each turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Umbra Stalker
    public class UmbraStalker : MagicCard
    {
        public UmbraStalker()
        {
            Name = "Umbra Stalker";
            Edition = "EVE";
            Rarity = "R";
            Color = "B";
            Cost = "4BBB";
            PT = "*/*";
            Type = "Creature - Elemental";
            Text = "@Chroma@ � Umbra Stalker�s power and toughness are each equal to the number of black mana symbols in the mana costs of cards in your graveyard.";
            Flavor = "";
        }
    }
    # endregion

    # region Unmake
    public class Unmake : MagicCard
    {
        public Unmake()
        {
            Name = "Unmake";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "%O%O%O";
            PT = "";
            Type = "Instant";
            Text = "Exile target creature.";
            Flavor = "";
        }
    }
    # endregion

    # region Unnerving Assault
    public class UnnervingAssault : MagicCard
    {
        public UnnervingAssault()
        {
            Name = "Unnerving Assault";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "2%I";
            PT = "";
            Type = "Instant";
            Text = "Creatures your opponents control get -1/-0 until end of turn if %U was spent to cast Unnerving Assault, and creatures you control get +1/+0 until end of turn if %R was spent to cast it. @(Do both if %U%R was spent.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Unwilling Recruit
    public class UnwillingRecruit : MagicCard
    {
        public UnwillingRecruit()
        {
            Name = "Unwilling Recruit";
            Edition = "EVE";
            Rarity = "U";
            Color = "R";
            Cost = "XRRR";
            PT = "";
            Type = "Sorcery";
            Text = "Gain control of target creature until end of turn. Untap that creature. It gets +X/+0 and gains haste until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Voracious Hatchling
    public class VoraciousHatchling : MagicCard
    {
        public VoraciousHatchling()
        {
            Name = "Voracious Hatchling";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "3%O";
            PT = "6/6";
            Type = "Creature - Elemental";
            Text = "Lifelink;^Voracious Hatchling enters the battlefield with four -1/-1 counters on it.;^Whenever you cast a white spell, remove a -1/-1 counter from Voracious Hatchling.;^Whenever you cast a black spell, remove a -1/-1 counter from Voracious Hatchling.";
            Flavor = "";
        }
    }
    # endregion

    # region Wake Thrasher
    public class WakeThrasher : MagicCard
    {
        public WakeThrasher()
        {
            Name = "Wake Thrasher";
            Edition = "EVE";
            Rarity = "R";
            Color = "U";
            Cost = "2U";
            PT = "1/1";
            Type = "Creature - Merfolk Soldier";
            Text = "Whenever a permanent you control becomes untapped, Wake Thrasher gets +1/+1 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Ward of Bones
    public class WardofBones : MagicCard
    {
        public WardofBones()
        {
            Name = "Ward of Bones";
            Edition = "EVE";
            Rarity = "R";
            Color = "Art";
            Cost = "6";
            PT = "";
            Type = "Artifact";
            Text = "Each opponent who controls more creatures than you can�t play creature cards. The same is true for artifacts, enchantments, and lands.";
            Flavor = "";
        }
    }
    # endregion

    # region Waves of Aggression
    public class WavesofAggression : MagicCard
    {
        public WavesofAggression()
        {
            Name = "Waves of Aggression";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "3%P%P";
            PT = "";
            Type = "Sorcery";
            Text = "Untap all creatures that attacked this turn. After this main phase, there is an additional combat phase followed by an additional main phase.;^Retrace @(You may cast this card from your graveyard by discarding a land card in addition to paying its other costs.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Wickerbough Elder
    public class WickerboughElder : MagicCard
    {
        public WickerboughElder()
        {
            Name = "Wickerbough Elder";
            Edition = "EVE";
            Rarity = "C";
            Color = "G";
            Cost = "3G";
            PT = "4/4";
            Type = "Creature - Treefolk Shaman";
            Text = "Wickerbough Elder enters the battlefield with a -1/-1 counter on it.;^%G, Remove a -1/-1 counter from Wickerbough Elder: Destroy target artifact or enchantment.";
            Flavor = "";
        }
    }
    # endregion

    # region Wilderness Hypnotist
    public class WildernessHypnotist : MagicCard
    {
        public WildernessHypnotist()
        {
            Name = "Wilderness Hypnotist";
            Edition = "EVE";
            Rarity = "C";
            Color = "U";
            Cost = "2UU";
            PT = "1/3";
            Type = "Creature - Merfolk Wizard";
            Text = "%T: Target red or green creature gets -2/-0 until end of turn.";
            Flavor = "";
        }
    }
    # endregion

    # region Wistful Selkie
    public class WistfulSelkie : MagicCard
    {
        public WistfulSelkie()
        {
            Name = "Wistful Selkie";
            Edition = "EVE";
            Rarity = "U";
            Color = "Gld";
            Cost = "%S%S%S";
            PT = "2/2";
            Type = "Creature - Merfolk Wizard";
            Text = "When Wistful Selkie enters the battlefield, draw a card.";
            Flavor = "";
        }
    }
    # endregion

    # region Woodlurker Mimic
    public class WoodlurkerMimic : MagicCard
    {
        public WoodlurkerMimic()
        {
            Name = "Woodlurker Mimic";
            Edition = "EVE";
            Rarity = "C";
            Color = "Gld";
            Cost = "1%Q";
            PT = "2/1";
            Type = "Creature - Shapeshifter";
            Text = "Whenever you cast a spell that�s both black and green, Woodlurker Mimic becomes 4/5 and gains wither until end of turn. @(It deals damage to creatures in the form of -1/-1 counters.)@";
            Flavor = "";
        }
    }
    # endregion

    # region Worm Harvest
    public class WormHarvest : MagicCard
    {
        public WormHarvest()
        {
            Name = "Worm Harvest";
            Edition = "EVE";
            Rarity = "R";
            Color = "Gld";
            Cost = "2%Q%Q%Q";
            PT = "";
            Type = "Sorcery";
            Text = "Put a 1/1 black and green Worm creature token onto the battlefield for each land card in your graveyard.;^Retrace @(You may cast this card from your graveyard by discarding a land card in addition to paying its other costs.)@";
            Flavor = "";
        }
    }
    # endregion
    # endregion
}
