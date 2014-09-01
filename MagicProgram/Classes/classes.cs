using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace MagicProgram
{
    public class ImageLibrary
    {
        public Dictionary<string, string> image = new Dictionary<string, string>();
    }

    [System.Xml.Serialization.XmlRoot("Collection")]
    public class CardCollection
    {
        [System.Xml.Serialization.XmlElement("Card")]
        public List<MagicCard> cards = new List<MagicCard>();
        private Dictionary<string, int> link = new Dictionary<string, int>();

        [XmlIgnore]
        public string Filename = "";

        # region cards changed
        public event PassiveEvent CardAdded;
        protected void callCardAdded(MagicCard mc)
        {
            PassiveEvent handler = CardAdded;
            if (handler != null)
            {
                handler(mc);
            }
        }

        public event PassiveEvent CardRemoved;
        protected void callCardRemoved(MagicCard mc)
        {
            PassiveEvent handler = CardRemoved;
            if (handler != null)
            {
                handler(mc);
            }
        }
        # endregion

        public int getIndex(string s)
        {
            int result = -1;

            if (link.ContainsKey(s.ToUpper()))
            {
                result = link[s.ToUpper()];
            }

            return result;
        }

        public MagicCard getCard(string s)
        {
            if (link.ContainsKey(s.ToUpper()))
            {
                int j = link[s.ToUpper()];
                return cards[j];
            }
            else
            {
                return new MagicCard { Name = "Blank" };
            }
        }

        public void index()
        {
            link.Clear();
            string st;

            for (int i = 0; i < cards.Count; i++)
            {
                st = cards[i].Name.ToUpper().Trim();

                if (!link.ContainsKey(st))
                {
                    link.Add(st, i);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">0 Name, 1 Quantity, 2 Edition, 3 Rarity, 4 Colour, 5 CMC, 6 PT, 7 Type, 8 Text, 9 Flavour</param>
        /// <param name="order"></param>
        public void Sort(int type, SortOrder order)
        {
            # region switch (type)
            switch (type)
            {
                case 0:
                    cards = cards.OrderBy(o => o.Name).ToList();
                    break;

                case 1:
                    cards = cards.OrderBy(o => o.quantity).ToList();
                    break;

                case 2:
                    cards = cards.OrderBy(o => o.Edition).ToList();
                    break;

                case 3:
                    cards = cards.OrderBy(o => o.Rarity).ToList();
                    break;

                case 4:
                    cards = cards.OrderBy(o => o.Color).ToList();
                    break;

                case 5:
                    cards = cards.OrderBy(o => o.CMC).ToList();
                    break;

                case 6:
                    cards = cards.OrderBy(o => o.PT).ToList();
                    break;

                case 7:
                    cards = cards.OrderBy(o => o.Type).ToList();
                    break;

                case 8:
                    cards = cards.OrderBy(o => o.Text).ToList();
                    break;

                case 9:
                    cards = cards.OrderBy(o => o.Flavor).ToList();
                    break;
            }
            # endregion

            if (order == SortOrder.Descending)
            {
                cards.Reverse();
            }
        }

        public bool Add(MagicCard card)
        {
            bool result = false; //False means not in cards

            string st = card.Name.ToUpper().Trim();
            index();

            if (link.ContainsKey(st))
            {
                int i = link[st];
                int x = cards[i].quantity;
                int y = card.quantity;

                if (cards[i].attachedCards.Count > 0)
                {
                    cards.Add(card);
                }
                else
                {
                    //cards[i].attachedCards.Add(card);
                    cards[i].quantity += card.quantity;

                    result = true;
                }
            }
            else
            {
                link.Add(st, cards.Count);
                cards.Add(card);
            }

            callCardAdded(card);
            index();

            return result;
        }

        /// <summary>
        /// Remove a card from the collection
        /// </summary>
        /// <param name="card">The card to remove if it's in the collection</param>
        /// <returns>Whether card was in collection</returns>
        public int Remove(MagicCard card)
        {
            int result = cards.FindIndex(o => o == card);

            if (result > -1)
            {
                cards.Remove(card);
                callCardRemoved(card);
            }

            return result;
        }

        public void Clear()
        {
            cards.Clear();
            link.Clear();
        }
    }

    //need to add ALL of the classes that are being used
    # region included derivatives
    # region RTR
    [XmlInclude(typeof(AbruptDecay))]
    [XmlInclude(typeof(AerialPredation))]
    [XmlInclude(typeof(AngelofSerenity))]
    [XmlInclude(typeof(AnnihilatingFire))]
    [XmlInclude(typeof(AquusSteed))]
    [XmlInclude(typeof(ArchonoftheTriumvirate))]
    [XmlInclude(typeof(Archweaver))]
    [XmlInclude(typeof(ArmadaWurm))]
    [XmlInclude(typeof(ArmoryGuard))]
    [XmlInclude(typeof(Arrest))]
    [XmlInclude(typeof(AshZealot))]
    [XmlInclude(typeof(AssassinsStrike))]
    [XmlInclude(typeof(AugerSpree))]
    [XmlInclude(typeof(AvengingArrow))]
    [XmlInclude(typeof(AxebaneGuardian))]
    [XmlInclude(typeof(AxebaneStag))]
    [XmlInclude(typeof(AzoriusArrester))]
    [XmlInclude(typeof(AzoriusCharm))]
    [XmlInclude(typeof(AzoriusGuildgate))]
    [XmlInclude(typeof(AzoriusJusticiar))]
    [XmlInclude(typeof(AzoriusKeyrune))]
    [XmlInclude(typeof(AzorsElocutors))]
    [XmlInclude(typeof(Batterhorn))]
    [XmlInclude(typeof(BazaarKrovod))]
    [XmlInclude(typeof(BellowsLizard))]
    [XmlInclude(typeof(BlistercoilWeird))]
    [XmlInclude(typeof(BloodCrypt))]
    [XmlInclude(typeof(BloodfrayGiant))]
    [XmlInclude(typeof(Blustersquall))]
    [XmlInclude(typeof(Brushstrider))]
    [XmlInclude(typeof(CalloftheConclave))]
    [XmlInclude(typeof(Cancel))]
    [XmlInclude(typeof(CarnivalHellsteed))]
    [XmlInclude(typeof(CatacombSlug))]
    [XmlInclude(typeof(CentaurHealer))]
    [XmlInclude(typeof(CentaursHerald))]
    [XmlInclude(typeof(ChaosImps))]
    [XmlInclude(typeof(ChemistersTrick))]
    [XmlInclude(typeof(ChorusofMight))]
    [XmlInclude(typeof(ChromaticLantern))]
    [XmlInclude(typeof(ChronicFlooding))]
    [XmlInclude(typeof(CivicSaber))]
    [XmlInclude(typeof(Cobblebrute))]
    [XmlInclude(typeof(CodexShredder))]
    [XmlInclude(typeof(CollectiveBlessing))]
    [XmlInclude(typeof(CommonBond))]
    [XmlInclude(typeof(ConcordiaPegasus))]
    [XmlInclude(typeof(ConjuredCurrency))]
    [XmlInclude(typeof(CorpsejackMenace))]
    [XmlInclude(typeof(Counterflux))]
    [XmlInclude(typeof(CoursersAccord))]
    [XmlInclude(typeof(Cremate))]
    [XmlInclude(typeof(CrosstownCourier))]
    [XmlInclude(typeof(CryptbornHorror))]
    [XmlInclude(typeof(CyclonicRift))]
    [XmlInclude(typeof(DaggerdromeImp))]
    [XmlInclude(typeof(DarkRevenant))]
    [XmlInclude(typeof(DeadReveler))]
    [XmlInclude(typeof(DeadbridgeGoliath))]
    [XmlInclude(typeof(DeathriteShaman))]
    [XmlInclude(typeof(DeathsPresence))]
    [XmlInclude(typeof(DesecrationDemon))]
    [XmlInclude(typeof(DestroytheEvidence))]
    [XmlInclude(typeof(DetentionSphere))]
    [XmlInclude(typeof(DeviantGlee))]
    [XmlInclude(typeof(Dispel))]
    [XmlInclude(typeof(Doorkeeper))]
    [XmlInclude(typeof(Downsize))]
    [XmlInclude(typeof(DrainpipeVermin))]
    [XmlInclude(typeof(DramaticRescue))]
    [XmlInclude(typeof(Dreadbore))]
    [XmlInclude(typeof(DregMangler))]
    [XmlInclude(typeof(DrudgeBeetle))]
    [XmlInclude(typeof(DruidsDeliverance))]
    [XmlInclude(typeof(DryadMilitant))]
    [XmlInclude(typeof(Dynacharge))]
    [XmlInclude(typeof(Electrickery))]
    [XmlInclude(typeof(EpicExperiment))]
    [XmlInclude(typeof(EssenceBacklash))]
    [XmlInclude(typeof(EtherealArmor))]
    [XmlInclude(typeof(ExplosiveImpact))]
    [XmlInclude(typeof(EyesintheSkies))]
    [XmlInclude(typeof(FaerieImpostor))]
    [XmlInclude(typeof(FalloftheGavel))]
    [XmlInclude(typeof(FencingAce))]
    [XmlInclude(typeof(FiremindsForesight))]
    [XmlInclude(typeof(Forest))]
    [XmlInclude(typeof(FrostburnWeird))]
    [XmlInclude(typeof(GatecreeperVine))]
    [XmlInclude(typeof(GiantGrowth))]
    [XmlInclude(typeof(GobblingOoze))]
    [XmlInclude(typeof(GoblinElectromancer))]
    [XmlInclude(typeof(GoblinRally))]
    [XmlInclude(typeof(GolgariCharm))]
    [XmlInclude(typeof(GolgariDecoy))]
    [XmlInclude(typeof(GolgariGuildgate))]
    [XmlInclude(typeof(GolgariKeyrune))]
    [XmlInclude(typeof(GolgariLonglegs))]
    [XmlInclude(typeof(GoreHouseChainwalker))]
    [XmlInclude(typeof(GraveBetrayal))]
    [XmlInclude(typeof(GrimRoustabout))]
    [XmlInclude(typeof(GrislySalvage))]
    [XmlInclude(typeof(GroveoftheGuardian))]
    [XmlInclude(typeof(GrowingRanks))]
    [XmlInclude(typeof(GuildFeud))]
    [XmlInclude(typeof(Guttersnipe))]
    [XmlInclude(typeof(HallowedFountain))]
    [XmlInclude(typeof(HavocFestival))]
    [XmlInclude(typeof(HellholeFlailer))]
    [XmlInclude(typeof(HeroesReunion))]
    [XmlInclude(typeof(HorncallersChant))]
    [XmlInclude(typeof(HoverBarrier))]
    [XmlInclude(typeof(HussarPatrol))]
    [XmlInclude(typeof(HypersonicDragon))]
    [XmlInclude(typeof(InactionInjunction))]
    [XmlInclude(typeof(Inspiration))]
    [XmlInclude(typeof(Island))]
    [XmlInclude(typeof(IsperiaSupremeJudge))]
    [XmlInclude(typeof(IsperiasSkywatch))]
    [XmlInclude(typeof(IzzetCharm))]
    [XmlInclude(typeof(IzzetGuildgate))]
    [XmlInclude(typeof(IzzetKeyrune))]
    [XmlInclude(typeof(IzzetStaticaster))]
    [XmlInclude(typeof(JaceArchitectofThought))]
    [XmlInclude(typeof(JaradGolgariLichLord))]
    [XmlInclude(typeof(JaradsOrders))]
    [XmlInclude(typeof(JudgesFamiliar))]
    [XmlInclude(typeof(KeeningApparition))]
    [XmlInclude(typeof(KnightlyValor))]
    [XmlInclude(typeof(KorozdaGuildmage))]
    [XmlInclude(typeof(KorozdaMonitor))]
    [XmlInclude(typeof(LaunchParty))]
    [XmlInclude(typeof(LobberCrew))]
    [XmlInclude(typeof(LotlethTroll))]
    [XmlInclude(typeof(LoxodonSmiter))]
    [XmlInclude(typeof(LyevSkyknight))]
    [XmlInclude(typeof(ManaBloom))]
    [XmlInclude(typeof(MartialLaw))]
    [XmlInclude(typeof(MercurialChemister))]
    [XmlInclude(typeof(MindRot))]
    [XmlInclude(typeof(MinotaurAggressor))]
    [XmlInclude(typeof(MizziumMortars))]
    [XmlInclude(typeof(MizziumSkin))]
    [XmlInclude(typeof(Mountain))]
    [XmlInclude(typeof(NecropolisRegent))]
    [XmlInclude(typeof(NewPrahvGuildmage))]
    [XmlInclude(typeof(NivixGuildmage))]
    [XmlInclude(typeof(NivmagusElemental))]
    [XmlInclude(typeof(NivMizzetDracogenius))]
    [XmlInclude(typeof(OakStreetInnkeeper))]
    [XmlInclude(typeof(OgreJailbreaker))]
    [XmlInclude(typeof(OvergrownTomb))]
    [XmlInclude(typeof(PackRat))]
    [XmlInclude(typeof(PalisadeGiant))]
    [XmlInclude(typeof(ParalyzingGrasp))]
    [XmlInclude(typeof(PerilousShadow))]
    [XmlInclude(typeof(PhantomGeneral))]
    [XmlInclude(typeof(PithingNeedle))]
    [XmlInclude(typeof(Plains))]
    [XmlInclude(typeof(PrecinctCaptain))]
    [XmlInclude(typeof(PsychicSpiral))]
    [XmlInclude(typeof(PursuitofFlight))]
    [XmlInclude(typeof(Pyroconvergence))]
    [XmlInclude(typeof(RacecourseFury))]
    [XmlInclude(typeof(RakdosCackler))]
    [XmlInclude(typeof(RakdosCharm))]
    [XmlInclude(typeof(RakdosGuildgate))]
    [XmlInclude(typeof(RakdosKeyrune))]
    [XmlInclude(typeof(RakdosRagemutt))]
    [XmlInclude(typeof(RakdosRingleader))]
    [XmlInclude(typeof(RakdosShredFreak))]
    [XmlInclude(typeof(RakdosLordofRiots))]
    [XmlInclude(typeof(RakdossReturn))]
    [XmlInclude(typeof(RestinPeace))]
    [XmlInclude(typeof(RighteousAuthority))]
    [XmlInclude(typeof(RisenSanctuary))]
    [XmlInclude(typeof(RitesofReaping))]
    [XmlInclude(typeof(RixMaadiGuildmage))]
    [XmlInclude(typeof(RoguesPassage))]
    [XmlInclude(typeof(RootbornDefenses))]
    [XmlInclude(typeof(RubblebackRhino))]
    [XmlInclude(typeof(Runewing))]
    [XmlInclude(typeof(SavageSurge))]
    [XmlInclude(typeof(SearchtheCity))]
    [XmlInclude(typeof(SearchWarrant))]
    [XmlInclude(typeof(SecurityBlockade))]
    [XmlInclude(typeof(SeektheHorizon))]
    [XmlInclude(typeof(SelesnyaCharm))]
    [XmlInclude(typeof(SelesnyaGuildgate))]
    [XmlInclude(typeof(SelesnyaKeyrune))]
    [XmlInclude(typeof(SelesnyaSentry))]
    [XmlInclude(typeof(SellerofSongbirds))]
    [XmlInclude(typeof(SewerShambler))]
    [XmlInclude(typeof(ShriekingAffliction))]
    [XmlInclude(typeof(SkullRend))]
    [XmlInclude(typeof(SkylinePredator))]
    [XmlInclude(typeof(SkymarkRoc))]
    [XmlInclude(typeof(SlaughterGames))]
    [XmlInclude(typeof(SlimeMolding))]
    [XmlInclude(typeof(Slitherhead))]
    [XmlInclude(typeof(SluicewayScorpion))]
    [XmlInclude(typeof(SlumReaper))]
    [XmlInclude(typeof(SoulTithe))]
    [XmlInclude(typeof(SoulswornSpirit))]
    [XmlInclude(typeof(SpawnofRixMaadi))]
    [XmlInclude(typeof(SphereofSafety))]
    [XmlInclude(typeof(SphinxoftheChimes))]
    [XmlInclude(typeof(SphinxsRevelation))]
    [XmlInclude(typeof(SplatterThug))]
    [XmlInclude(typeof(StabWound))]
    [XmlInclude(typeof(StealerofSecrets))]
    [XmlInclude(typeof(SteamVents))]
    [XmlInclude(typeof(StonefareCrocodile))]
    [XmlInclude(typeof(StreetSpasm))]
    [XmlInclude(typeof(StreetSweeper))]
    [XmlInclude(typeof(SunderingGrowth))]
    [XmlInclude(typeof(SunspireGriffin))]
    [XmlInclude(typeof(SupremeVerdict))]
    [XmlInclude(typeof(SurveytheWreckage))]
    [XmlInclude(typeof(Swamp))]
    [XmlInclude(typeof(SwiftJustice))]
    [XmlInclude(typeof(Syncopate))]
    [XmlInclude(typeof(TabletoftheGuilds))]
    [XmlInclude(typeof(TavernSwindler))]
    [XmlInclude(typeof(Teleportal))]
    [XmlInclude(typeof(TempleGarden))]
    [XmlInclude(typeof(TenementCrasher))]
    [XmlInclude(typeof(TerrusWurm))]
    [XmlInclude(typeof(Thoughtflare))]
    [XmlInclude(typeof(ThrillKillAssassin))]
    [XmlInclude(typeof(TowerDrake))]
    [XmlInclude(typeof(ToweringIndrik))]
    [XmlInclude(typeof(TrainedCaracal))]
    [XmlInclude(typeof(TraitorousInstinct))]
    [XmlInclude(typeof(TransguildPromenade))]
    [XmlInclude(typeof(TreasuredFind))]
    [XmlInclude(typeof(TrestleTroll))]
    [XmlInclude(typeof(TrostaniSelesnyasVoice))]
    [XmlInclude(typeof(TrostanisJudgment))]
    [XmlInclude(typeof(UltimatePrice))]
    [XmlInclude(typeof(UnderworldConnections))]
    [XmlInclude(typeof(UrbanBurgeoning))]
    [XmlInclude(typeof(UtvaraHellkite))]
    [XmlInclude(typeof(Vandalblast))]
    [XmlInclude(typeof(VassalSoul))]
    [XmlInclude(typeof(ViashinoRacketeer))]
    [XmlInclude(typeof(VituGhaziGuildmage))]
    [XmlInclude(typeof(Voidwielder))]
    [XmlInclude(typeof(VolatileRig))]
    [XmlInclude(typeof(VraskatheUnseen))]
    [XmlInclude(typeof(WayfaringTemple))]
    [XmlInclude(typeof(WildBeastmaster))]
    [XmlInclude(typeof(WorldspineWurm))]
    [XmlInclude(typeof(ZanikevLocust))]
    # endregion
    # region GTC
    [XmlInclude(typeof(ActofTreason))]
    [XmlInclude(typeof(AdaptiveSnapjaw))]
    [XmlInclude(typeof(AerialManeuver))]
    [XmlInclude(typeof(AEtherize))]
    [XmlInclude(typeof(Agoraphobia))]
    [XmlInclude(typeof(AlmsBeast))]
    [XmlInclude(typeof(AlphaAuthority))]
    [XmlInclude(typeof(AngelicEdict))]
    [XmlInclude(typeof(AngelicSkirmisher))]
    [XmlInclude(typeof(ArmoredTransport))]
    [XmlInclude(typeof(ArrowsofJustice))]
    [XmlInclude(typeof(AssaultGriffin))]
    [XmlInclude(typeof(AssembletheLegion))]
    [XmlInclude(typeof(AureliatheWarleader))]
    [XmlInclude(typeof(AureliasFury))]
    [XmlInclude(typeof(BalustradeSpy))]
    [XmlInclude(typeof(BaneAlleyBroker))]
    [XmlInclude(typeof(BasilicaGuards))]
    [XmlInclude(typeof(BasilicaScreecher))]
    [XmlInclude(typeof(BeckonApparition))]
    [XmlInclude(typeof(BiomassMutation))]
    [XmlInclude(typeof(Bioshift))]
    [XmlInclude(typeof(Biovisionary))]
    [XmlInclude(typeof(BlindObedience))]
    [XmlInclude(typeof(BomberCorps))]
    [XmlInclude(typeof(BorborygmosEnraged))]
    [XmlInclude(typeof(BorosCharm))]
    [XmlInclude(typeof(BorosElite))]
    [XmlInclude(typeof(BorosGuildgate))]
    [XmlInclude(typeof(BorosKeyrune))]
    [XmlInclude(typeof(BorosReckoner))]
    [XmlInclude(typeof(BreedingPool))]
    [XmlInclude(typeof(BurningTreeEmissary))]
    [XmlInclude(typeof(BurstofStrength))]
    [XmlInclude(typeof(CalloftheNightwing))]
    [XmlInclude(typeof(CartelAristocrat))]
    [XmlInclude(typeof(CinderElemental))]
    [XmlInclude(typeof(ClanDefiance))]
    [XmlInclude(typeof(ClingingAnemones))]
    [XmlInclude(typeof(CloudfinRaptor))]
    [XmlInclude(typeof(CoercedConfession))]
    [XmlInclude(typeof(ConsumingAberration))]
    [XmlInclude(typeof(ContaminatedGround))]
    [XmlInclude(typeof(CorpseBlockade))]
    [XmlInclude(typeof(CourtStreetDenizen))]
    [XmlInclude(typeof(CracklingPerimeter))]
    [XmlInclude(typeof(Crocanura))]
    [XmlInclude(typeof(CrownedCeratok))]
    [XmlInclude(typeof(CryptGhast))]
    [XmlInclude(typeof(DaringSkyjek))]
    [XmlInclude(typeof(DeathcultRogue))]
    [XmlInclude(typeof(DeathpactAngel))]
    [XmlInclude(typeof(DeathsApproach))]
    [XmlInclude(typeof(DebtorsPulpit))]
    [XmlInclude(typeof(DevourFlesh))]
    [XmlInclude(typeof(DiluvianPrimordial))]
    [XmlInclude(typeof(DimirCharm))]
    [XmlInclude(typeof(DimirGuildgate))]
    [XmlInclude(typeof(DimirKeyrune))]
    [XmlInclude(typeof(DinrovaHorror))]
    [XmlInclude(typeof(DinrovaHorror))]
    [XmlInclude(typeof(DiscipleoftheOldWays))]
    [XmlInclude(typeof(DomriRade))]
    [XmlInclude(typeof(DrakewingKrasis))]
    [XmlInclude(typeof(DuskmantleGuildmage))]
    [XmlInclude(typeof(DuskmantleSeer))]
    [XmlInclude(typeof(DutifulThrull))]
    [XmlInclude(typeof(DyingWish))]
    [XmlInclude(typeof(ElusiveKrasis))]
    [XmlInclude(typeof(EmberBeast))]
    [XmlInclude(typeof(EntertheInfinite))]
    [XmlInclude(typeof(ExecutionersSwing))]
    [XmlInclude(typeof(ExperimentOne))]
    [XmlInclude(typeof(FathomMage))]
    [XmlInclude(typeof(FirefistStriker))]
    [XmlInclude(typeof(FiremaneAvenger))]
    [XmlInclude(typeof(FiveAlarmFire))]
    [XmlInclude(typeof(ForcedAdaptation))]
    [XmlInclude(typeof(FortressCyclops))]
    [XmlInclude(typeof(FoundryChampion))]
    [XmlInclude(typeof(FoundryStreetDenizen))]
    [XmlInclude(typeof(FrenziedTilling))]
    [XmlInclude(typeof(FrilledOculus))]
    [XmlInclude(typeof(FrontlineMedic))]
    [XmlInclude(typeof(FuriousResistance))]
    [XmlInclude(typeof(GatewayShade))]
    [XmlInclude(typeof(GhorClanRampager))]
    [XmlInclude(typeof(GiantAdephage))]
    [XmlInclude(typeof(GideonChampionofJustice))]
    [XmlInclude(typeof(GiftofOrzhova))]
    [XmlInclude(typeof(GlaringSpotlight))]
    [XmlInclude(typeof(GodlessShrine))]
    [XmlInclude(typeof(GreensideWatcher))]
    [XmlInclude(typeof(Gridlock))]
    [XmlInclude(typeof(GrislySpectacle))]
    [XmlInclude(typeof(GroundAssault))]
    [XmlInclude(typeof(GruulCharm))]
    [XmlInclude(typeof(GruulGuildgate))]
    [XmlInclude(typeof(GruulKeyrune))]
    [XmlInclude(typeof(GruulRagebeast))]
    [XmlInclude(typeof(GuardianoftheGateless))]
    [XmlInclude(typeof(GuildscornWard))]
    [XmlInclude(typeof(GutterSkulk))]
    [XmlInclude(typeof(GyreSage))]
    [XmlInclude(typeof(HandsofBinding))]
    [XmlInclude(typeof(HellkiteTyrant))]
    [XmlInclude(typeof(HellraiserGoblin))]
    [XmlInclude(typeof(HighPriestofPenance))]
    [XmlInclude(typeof(Hindervines))]
    [XmlInclude(typeof(HoldtheGates))]
    [XmlInclude(typeof(HolyMantle))]
    [XmlInclude(typeof(HomingLightning))]
    [XmlInclude(typeof(HorroroftheDim))]
    [XmlInclude(typeof(Hydroform))]
    [XmlInclude(typeof(IllnessintheRanks))]
    [XmlInclude(typeof(IllusionistsBracers))]
    [XmlInclude(typeof(ImmortalServitude))]
    [XmlInclude(typeof(IncursionSpecialist))]
    [XmlInclude(typeof(IvyLaneDenizen))]
    [XmlInclude(typeof(KeymasterRogue))]
    [XmlInclude(typeof(KillingGlare))]
    [XmlInclude(typeof(KingpinsPet))]
    [XmlInclude(typeof(KnightofObligation))]
    [XmlInclude(typeof(KnightWatch))]
    [XmlInclude(typeof(LastThoughts))]
    [XmlInclude(typeof(LazavDimirMastermind))]
    [XmlInclude(typeof(LegionLoyalist))]
    [XmlInclude(typeof(LeylinePhantom))]
    [XmlInclude(typeof(LordoftheVoid))]
    [XmlInclude(typeof(LuminatePrimordial))]
    [XmlInclude(typeof(MadcapSkills))]
    [XmlInclude(typeof(MarkforDeath))]
    [XmlInclude(typeof(MartialGlory))]
    [XmlInclude(typeof(MassiveRaid))]
    [XmlInclude(typeof(MasterBiomancer))]
    [XmlInclude(typeof(MentalVapors))]
    [XmlInclude(typeof(MercilessEviction))]
    [XmlInclude(typeof(MerfolkoftheDepths))]
    [XmlInclude(typeof(MetropolisSprite))]
    [XmlInclude(typeof(MidnightRecovery))]
    [XmlInclude(typeof(MillennialGargoyle))]
    [XmlInclude(typeof(MimingSlime))]
    [XmlInclude(typeof(MindGrind))]
    [XmlInclude(typeof(MindeyeDrake))]
    [XmlInclude(typeof(MoltenPrimordial))]
    [XmlInclude(typeof(MortusStrider))]
    [XmlInclude(typeof(Mugging))]
    [XmlInclude(typeof(MurderInvestigation))]
    [XmlInclude(typeof(MysticGenesis))]
    [XmlInclude(typeof(Naturalize))]
    [XmlInclude(typeof(NavSquadCommandos))]
    [XmlInclude(typeof(NightveilSpecter))]
    [XmlInclude(typeof(NimbusSwimmer))]
    [XmlInclude(typeof(ObzedatGhostCouncil))]
    [XmlInclude(typeof(OgreSlumlord))]
    [XmlInclude(typeof(OneThousandLashes))]
    [XmlInclude(typeof(OozeFlux))]
    [XmlInclude(typeof(OrdruunVeteran))]
    [XmlInclude(typeof(OrzhovCharm))]
    [XmlInclude(typeof(OrzhovGuildgate))]
    [XmlInclude(typeof(OrzhovKeyrune))]
    [XmlInclude(typeof(ParanoidDelusions))]
    [XmlInclude(typeof(PitFight))]
    [XmlInclude(typeof(PredatorsRapport))]
    [XmlInclude(typeof(PrimalVisitation))]
    [XmlInclude(typeof(PrimeSpeakerZegana))]
    [XmlInclude(typeof(PropheticPrism))]
    [XmlInclude(typeof(PsychicStrike))]
    [XmlInclude(typeof(PurgetheProfane))]
    [XmlInclude(typeof(RapidHybridization))]
    [XmlInclude(typeof(RazortipWhip))]
    [XmlInclude(typeof(Realmwright))]
    [XmlInclude(typeof(RighteousCharge))]
    [XmlInclude(typeof(RiotGear))]
    [XmlInclude(typeof(RipscalePredator))]
    [XmlInclude(typeof(RubblebeltRaiders))]
    [XmlInclude(typeof(Rubblehulk))]
    [XmlInclude(typeof(RuinationWurm))]
    [XmlInclude(typeof(RuinationWurm))]
    [XmlInclude(typeof(RustScarab))]
    [XmlInclude(typeof(SacredFoundry))]
    [XmlInclude(typeof(SagesRowDenizen))]
    [XmlInclude(typeof(SapphireDrake))]
    [XmlInclude(typeof(ScabClanCharger))]
    [XmlInclude(typeof(ScatterArc))]
    [XmlInclude(typeof(Scorchwalker))]
    [XmlInclude(typeof(SepulchralPrimordial))]
    [XmlInclude(typeof(SereneRemembrance))]
    [XmlInclude(typeof(ShadowAlleyDenizen))]
    [XmlInclude(typeof(ShadowSlice))]
    [XmlInclude(typeof(Shambleshark))]
    [XmlInclude(typeof(ShatteringBlow))]
    [XmlInclude(typeof(ShieldedPassage))]
    [XmlInclude(typeof(SignaltheClans))]
    [XmlInclude(typeof(SimicCharm))]
    [XmlInclude(typeof(SimicFluxmage))]
    [XmlInclude(typeof(SimicGuildgate))]
    [XmlInclude(typeof(SimicKeyrune))]
    [XmlInclude(typeof(SimicManipulator))]
    [XmlInclude(typeof(SkarrgGoliath))]
    [XmlInclude(typeof(SkarrgGuildmage))]
    [XmlInclude(typeof(SkinbrandGoblin))]
    [XmlInclude(typeof(Skullcrack))]
    [XmlInclude(typeof(SkyblinderStaff))]
    [XmlInclude(typeof(Skygames))]
    [XmlInclude(typeof(SkyknightLegionnaire))]
    [XmlInclude(typeof(SlateStreetRuffian))]
    [XmlInclude(typeof(Slaughterhorn))]
    [XmlInclude(typeof(Smite))]
    [XmlInclude(typeof(SmogElemental))]
    [XmlInclude(typeof(SoulRansom))]
    [XmlInclude(typeof(SparkTrooper))]
    [XmlInclude(typeof(SpellRupture))]
    [XmlInclude(typeof(SpireTracer))]
    [XmlInclude(typeof(StolenIdentity))]
    [XmlInclude(typeof(StompingGround))]
    [XmlInclude(typeof(StructuralCollapse))]
    [XmlInclude(typeof(SunhomeGuildmage))]
    [XmlInclude(typeof(SylvanPrimordial))]
    [XmlInclude(typeof(SyndicofTithes))]
    [XmlInclude(typeof(SyndicateEnforcer))]
    [XmlInclude(typeof(ThespiansStage))]
    [XmlInclude(typeof(ThrullParasite))]
    [XmlInclude(typeof(TinStreetMarket))]
    [XmlInclude(typeof(TotallyLost))]
    [XmlInclude(typeof(TowerDefense))]
    [XmlInclude(typeof(ToweringThunderfist))]
    [XmlInclude(typeof(TreasuryThrull))]
    [XmlInclude(typeof(TruefirePaladin))]
    [XmlInclude(typeof(UndercityInformer))]
    [XmlInclude(typeof(UndercityPlague))]
    [XmlInclude(typeof(UnexpectedResults))]
    [XmlInclude(typeof(UrbanEvolution))]
    [XmlInclude(typeof(UrbisProtector))]
    [XmlInclude(typeof(VerdantHaven))]
    [XmlInclude(typeof(ViashinoShanktail))]
    [XmlInclude(typeof(VizkopaConfessor))]
    [XmlInclude(typeof(VizkopaGuildmage))]
    [XmlInclude(typeof(Voidwalk))]
    [XmlInclude(typeof(WarmindInfantry))]
    [XmlInclude(typeof(WastelandViper))]
    [XmlInclude(typeof(WateryGrave))]
    [XmlInclude(typeof(WayoftheThief))]
    [XmlInclude(typeof(WhisperingMadness))]
    [XmlInclude(typeof(WightofPrecinctSix))]
    [XmlInclude(typeof(WildwoodRebirth))]
    [XmlInclude(typeof(WojekHalberdiers))]
    [XmlInclude(typeof(WreckingOgre))]
    [XmlInclude(typeof(ZameckGuildmage))]
    [XmlInclude(typeof(ZarichiTiger))]
    [XmlInclude(typeof(ZhurTaaSwine))]

    # endregion
    # region DGM
    [XmlInclude(typeof(AdventoftheWurm))]
    [XmlInclude(typeof(AEtherling))]
    [XmlInclude(typeof(AliveWell))]
    [XmlInclude(typeof(ArmedDangerous))]
    [XmlInclude(typeof(ArmoredWolfRider))]
    [XmlInclude(typeof(AscendedLawmage))]
    [XmlInclude(typeof(AwefortheGuilds))]
    [XmlInclude(typeof(AzoriusCluestone))]
    [XmlInclude(typeof(AzoriusGuildgate))]
    [XmlInclude(typeof(BaneAlleyBlackguard))]
    [XmlInclude(typeof(BatteringKrasis))]
    [XmlInclude(typeof(BeckCall))]
    [XmlInclude(typeof(BeetleformMage))]
    [XmlInclude(typeof(BlastofGenius))]
    [XmlInclude(typeof(BlazeCommando))]
    [XmlInclude(typeof(BloodBaronofVizkopa))]
    [XmlInclude(typeof(BloodScrivener))]
    [XmlInclude(typeof(BorosBattleshaper))]
    [XmlInclude(typeof(BorosCluestone))]
    [XmlInclude(typeof(BorosGuildgate))]
    [XmlInclude(typeof(BorosMastiff))]
    [XmlInclude(typeof(BreakingEntering))]
    [XmlInclude(typeof(BredfortheHunt))]
    [XmlInclude(typeof(BronzebeakMoa))]
    [XmlInclude(typeof(CarnageGladiator))]
    [XmlInclude(typeof(CatchRelease))]
    [XmlInclude(typeof(ClearaPath))]
    [XmlInclude(typeof(CounciloftheAbsolute))]
    [XmlInclude(typeof(CryptIncursion))]
    [XmlInclude(typeof(DeadbridgeChant))]
    [XmlInclude(typeof(DebttotheDeathless))]
    [XmlInclude(typeof(DeputyofAcquittals))]
    [XmlInclude(typeof(DimirCluestone))]
    [XmlInclude(typeof(DimirGuildgate))]
    [XmlInclude(typeof(DownDirty))]
    [XmlInclude(typeof(Dragonshift))]
    [XmlInclude(typeof(DrowninFilth))]
    [XmlInclude(typeof(EmmaraTandris))]
    [XmlInclude(typeof(ExavaRakdosBloodWitch))]
    [XmlInclude(typeof(FarAway))]
    [XmlInclude(typeof(FatalFumes))]
    [XmlInclude(typeof(FeralAnimist))]
    [XmlInclude(typeof(FleshBlood))]
    [XmlInclude(typeof(Fluxcharger))]
    [XmlInclude(typeof(GazeofGranite))]
    [XmlInclude(typeof(GiveTake))]
    [XmlInclude(typeof(GleamofBattle))]
    [XmlInclude(typeof(GoblinTestPilot))]
    [XmlInclude(typeof(GolgariCluestone))]
    [XmlInclude(typeof(GolgariGuildgate))]
    [XmlInclude(typeof(GruulCluestone))]
    [XmlInclude(typeof(GruulGuildgate))]
    [XmlInclude(typeof(GruulWarChant))]
    [XmlInclude(typeof(HaazdaSnareSquad))]
    [XmlInclude(typeof(HaunterofNightveil))]
    [XmlInclude(typeof(HiddenStrings))]
    [XmlInclude(typeof(HiredTorturer))]
    [XmlInclude(typeof(IzzetCluestone))]
    [XmlInclude(typeof(IzzetGuildgate))]
    [XmlInclude(typeof(JelennSphinx))]
    [XmlInclude(typeof(KorozdaGorgon))]
    [XmlInclude(typeof(KrasisIncubation))]
    [XmlInclude(typeof(KraulWarrior))]
    [XmlInclude(typeof(LaviniaoftheTenth))]
    [XmlInclude(typeof(LegionsInitiative))]
    [XmlInclude(typeof(LyevDecree))]
    [XmlInclude(typeof(MasterofCruelties))]
    [XmlInclude(typeof(MawoftheObzedat))]
    [XmlInclude(typeof(MazeAbomination))]
    [XmlInclude(typeof(MazeBehemoth))]
    [XmlInclude(typeof(MazeGlider))]
    [XmlInclude(typeof(MazeRusher))]
    [XmlInclude(typeof(MazeSentinel))]
    [XmlInclude(typeof(MazesEnd))]
    [XmlInclude(typeof(MelekIzzetParagon))]
    [XmlInclude(typeof(MendingTouch))]
    [XmlInclude(typeof(Mindstatic))]
    [XmlInclude(typeof(MirkoVoskMindDrinker))]
    [XmlInclude(typeof(MorgueBurst))]
    [XmlInclude(typeof(MurmuringPhantasm))]
    [XmlInclude(typeof(MutantsPrey))]
    [XmlInclude(typeof(NivixCyclops))]
    [XmlInclude(typeof(NotionThief))]
    [XmlInclude(typeof(ObzedatsAid))]
    [XmlInclude(typeof(OpalLakeGatekeepers))]
    [XmlInclude(typeof(OrzhovCluestone))]
    [XmlInclude(typeof(OrzhovGuildgate))]
    [XmlInclude(typeof(Phytoburst))]
    [XmlInclude(typeof(PilferedPlans))]
    [XmlInclude(typeof(PlasmCapture))]
    [XmlInclude(typeof(PontiffofBlight))]
    [XmlInclude(typeof(PossibilityStorm))]
    [XmlInclude(typeof(ProfitLoss))]
    [XmlInclude(typeof(ProgenitorMimic))]
    [XmlInclude(typeof(ProtectServe))]
    [XmlInclude(typeof(PunishtheEnemy))]
    [XmlInclude(typeof(Putrefy))]
    [XmlInclude(typeof(PyrewildShaman))]
    [XmlInclude(typeof(RakdosCluestone))]
    [XmlInclude(typeof(RakdosDrake))]
    [XmlInclude(typeof(RakdosGuildgate))]
    [XmlInclude(typeof(RalZarek))]
    [XmlInclude(typeof(ReadyWilling))]
    [XmlInclude(typeof(ReapIntellect))]
    [XmlInclude(typeof(RenderSilent))]
    [XmlInclude(typeof(RenegadeKrasis))]
    [XmlInclude(typeof(RenouncetheGuilds))]
    [XmlInclude(typeof(RestorethePeace))]
    [XmlInclude(typeof(RiotControl))]
    [XmlInclude(typeof(RiotPiker))]
    [XmlInclude(typeof(RotFarmSkeleton))]
    [XmlInclude(typeof(RubblebeltMaaka))]
    [XmlInclude(typeof(RunnersBane))]
    [XmlInclude(typeof(RuricThartheUnbowed))]
    [XmlInclude(typeof(SaruliGatekeepers))]
    [XmlInclude(typeof(SavagebornHydra))]
    [XmlInclude(typeof(ScabClanGiant))]
    [XmlInclude(typeof(ScionofVituGhazi))]
    [XmlInclude(typeof(SelesnyaCluestone))]
    [XmlInclude(typeof(SelesnyaGuildgate))]
    [XmlInclude(typeof(Showstopper))]
    [XmlInclude(typeof(SimicCluestone))]
    [XmlInclude(typeof(SimicGuildgate))]
    [XmlInclude(typeof(SinCollector))]
    [XmlInclude(typeof(SinisterPossession))]
    [XmlInclude(typeof(SireofInsanity))]
    [XmlInclude(typeof(Skylasher))]
    [XmlInclude(typeof(SmeltWardGatekeepers))]
    [XmlInclude(typeof(SpeciesGorger))]
    [XmlInclude(typeof(SpikeJester))]
    [XmlInclude(typeof(SteepleRoc))]
    [XmlInclude(typeof(SunspireGatekeepers))]
    [XmlInclude(typeof(TajicBladeoftheLegion))]
    [XmlInclude(typeof(TeysaEnvoyofGhosts))]
    [XmlInclude(typeof(ThrashingMossdog))]
    [XmlInclude(typeof(TitheDrinker))]
    [XmlInclude(typeof(ToilTrouble))]
    [XmlInclude(typeof(TraitDoctoring))]
    [XmlInclude(typeof(TrostanisSummoner))]
    [XmlInclude(typeof(TurnBurn))]
    [XmlInclude(typeof(UbulSarGatekeepers))]
    [XmlInclude(typeof(UncoveredClues))]
    [XmlInclude(typeof(UnflinchingCourage))]
    [XmlInclude(typeof(VarolztheScarStriped))]
    [XmlInclude(typeof(ViashinoFirstblade))]
    [XmlInclude(typeof(VoiceofResurgence))]
    [XmlInclude(typeof(VoreloftheHullClade))]
    [XmlInclude(typeof(WaketheReflections))]
    [XmlInclude(typeof(WarleadersHelix))]
    [XmlInclude(typeof(WarpedPhysique))]
    [XmlInclude(typeof(WeaponSurge))]
    [XmlInclude(typeof(WearTear))]
    [XmlInclude(typeof(WindDrake))]
    [XmlInclude(typeof(WoodlotCrawler))]
    [XmlInclude(typeof(ZhurTaaAncient))]
    [XmlInclude(typeof(ZhurTaaDruid))]

    # endregion
    # region THS
    [XmlInclude(typeof(AbhorrentOverlord))]
    [XmlInclude(typeof(AgentofHorizons))]
    [XmlInclude(typeof(AgentoftheFates))]
    [XmlInclude(typeof(AkroanCrusader))]
    [XmlInclude(typeof(AkroanHoplite))]
    [XmlInclude(typeof(AkroanHorse))]
    [XmlInclude(typeof(AnaxandCymede))]
    [XmlInclude(typeof(AngeroftheGods))]
    [XmlInclude(typeof(Annul))]
    [XmlInclude(typeof(AnthousaSetessanHero))]
    [XmlInclude(typeof(AnvilwroughtRaptor))]
    [XmlInclude(typeof(AqueousForm))]
    [XmlInclude(typeof(ArborColossus))]
    [XmlInclude(typeof(ArtisanofForms))]
    [XmlInclude(typeof(ArtisansSorrow))]
    [XmlInclude(typeof(AshenRider))]
    [XmlInclude(typeof(AshiokNightmareWeaver))]
    [XmlInclude(typeof(AsphodelWanderer))]
    [XmlInclude(typeof(BalefulEidolon))]
    [XmlInclude(typeof(BattlewiseHoplite))]
    [XmlInclude(typeof(BattlewiseValor))]
    [XmlInclude(typeof(BenthicGiant))]
    [XmlInclude(typeof(BidentofThassa))]
    [XmlInclude(typeof(BloodTollHarpy))]
    [XmlInclude(typeof(BoonofErebos))]
    [XmlInclude(typeof(BoonSatyr))]
    [XmlInclude(typeof(BorderlandMinotaur))]
    [XmlInclude(typeof(Boulderfall))]
    [XmlInclude(typeof(BowofNylea))]
    [XmlInclude(typeof(BreachingHippocamp))]
    [XmlInclude(typeof(BronzeSable))]
    [XmlInclude(typeof(BurnishedHart))]
    [XmlInclude(typeof(CavalryPegasus))]
    [XmlInclude(typeof(CavernLampad))]
    [XmlInclude(typeof(CelestialArchon))]
    [XmlInclude(typeof(CentaurBattlemaster))]
    [XmlInclude(typeof(ChainedtotheRocks))]
    [XmlInclude(typeof(ChosenbyHeliod))]
    [XmlInclude(typeof(ChroniclerofHeroes))]
    [XmlInclude(typeof(CoastlineChimera))]
    [XmlInclude(typeof(ColossusofAkros))]
    [XmlInclude(typeof(CommunewiththeGods))]
    [XmlInclude(typeof(CoordinatedAssault))]
    [XmlInclude(typeof(CracklingTriton))]
    [XmlInclude(typeof(CurseoftheSwine))]
    [XmlInclude(typeof(CutthroatManeuver))]
    [XmlInclude(typeof(DarkBetrayal))]
    [XmlInclude(typeof(DauntlessOnslaught))]
    [XmlInclude(typeof(DaxosofMeletis))]
    [XmlInclude(typeof(DeathbellowRaider))]
    [XmlInclude(typeof(DecoratedGriffin))]
    [XmlInclude(typeof(DefendtheHearth))]
    [XmlInclude(typeof(Demolish))]
    [XmlInclude(typeof(DestructiveRevelry))]
    [XmlInclude(typeof(DiscipleofPhenax))]
    [XmlInclude(typeof(Dissolve))]
    [XmlInclude(typeof(DivineVerdict))]
    [XmlInclude(typeof(DragonMantle))]
    [XmlInclude(typeof(ElspethSunsChampion))]
    [XmlInclude(typeof(EmberSwallower))]
    [XmlInclude(typeof(EpharasWarden))]
    [XmlInclude(typeof(ErebosGodoftheDead))]
    [XmlInclude(typeof(ErebossEmissary))]
    [XmlInclude(typeof(EvangelofHeliod))]
    [XmlInclude(typeof(FabledHero))]
    [XmlInclude(typeof(FadeintoAntiquity))]
    [XmlInclude(typeof(FanaticofMogis))]
    [XmlInclude(typeof(FateForetold))]
    [XmlInclude(typeof(FavoredHoplite))]
    [XmlInclude(typeof(FelhideMinotaur))]
    [XmlInclude(typeof(FeralInvocation))]
    [XmlInclude(typeof(FiredrinkerSatyr))]
    [XmlInclude(typeof(FlamecastWheel))]
    [XmlInclude(typeof(FlamespeakerAdept))]
    [XmlInclude(typeof(FleecemaneLion))]
    [XmlInclude(typeof(FleetfeatherSandals))]
    [XmlInclude(typeof(FleshmadSteed))]
    [XmlInclude(typeof(Gainsay))]
    [XmlInclude(typeof(GiftofImmortality))]
    [XmlInclude(typeof(GlareofHeresy))]
    [XmlInclude(typeof(GodsWilling))]
    [XmlInclude(typeof(GrayMerchantofAsphodel))]
    [XmlInclude(typeof(Griptide))]
    [XmlInclude(typeof(GuardiansofMeletis))]
    [XmlInclude(typeof(HammerofPurphoros))]
    [XmlInclude(typeof(HeliodGodoftheSun))]
    [XmlInclude(typeof(HeliodsEmissary))]
    [XmlInclude(typeof(HerosDownfall))]
    [XmlInclude(typeof(HopefulEidolon))]
    [XmlInclude(typeof(HorizonChimera))]
    [XmlInclude(typeof(HorizonScholar))]
    [XmlInclude(typeof(HundredHandedOne))]
    [XmlInclude(typeof(HunttheHunter))]
    [XmlInclude(typeof(HythoniatheCruel))]
    [XmlInclude(typeof(IllTemperedCyclops))]
    [XmlInclude(typeof(InsatiableHarpy))]
    [XmlInclude(typeof(KarametrasAcolyte))]
    [XmlInclude(typeof(KeepsakeGorgon))]
    [XmlInclude(typeof(KragmaWarcaller))]
    [XmlInclude(typeof(LabyrinthChampion))]
    [XmlInclude(typeof(LagonnaBandElder))]
    [XmlInclude(typeof(LashoftheWhip))]
    [XmlInclude(typeof(LastBreath))]
    [XmlInclude(typeof(LeafcrownDryad))]
    [XmlInclude(typeof(LeoninSnarecaster))]
    [XmlInclude(typeof(LightningStrike))]
    [XmlInclude(typeof(LoathsomeCatoblepas))]
    [XmlInclude(typeof(LostinaLabyrinth))]
    [XmlInclude(typeof(MagmaJet))]
    [XmlInclude(typeof(MarchoftheReturned))]
    [XmlInclude(typeof(MasterofWaves))]
    [XmlInclude(typeof(MedomaitheAgeless))]
    [XmlInclude(typeof(MeletisCharlatan))]
    [XmlInclude(typeof(MessengersSpeed))]
    [XmlInclude(typeof(MinotaurSkullcleaver))]
    [XmlInclude(typeof(MistcutterHydra))]
    [XmlInclude(typeof(MnemonicWall))]
    [XmlInclude(typeof(MogissMarauder))]
    [XmlInclude(typeof(NessianAsp))]
    [XmlInclude(typeof(NessianCourser))]
    [XmlInclude(typeof(Nighthowler))]
    [XmlInclude(typeof(NimbusNaiad))]
    [XmlInclude(typeof(NykthosShrinetoNyx))]
    [XmlInclude(typeof(NyleaGodoftheHunt))]
    [XmlInclude(typeof(NyleasDisciple))]
    [XmlInclude(typeof(NyleasEmissary))]
    [XmlInclude(typeof(NyleasPresence))]
    [XmlInclude(typeof(ObservantAlseid))]
    [XmlInclude(typeof(Omenspeaker))]
    [XmlInclude(typeof(OpalineUnicorn))]
    [XmlInclude(typeof(OrdealofErebos))]
    [XmlInclude(typeof(OrdealofHeliod))]
    [XmlInclude(typeof(OrdealofNylea))]
    [XmlInclude(typeof(OrdealofPurphoros))]
    [XmlInclude(typeof(OrdealofThassa))]
    [XmlInclude(typeof(PeakEruption))]
    [XmlInclude(typeof(PhalanxLeader))]
    [XmlInclude(typeof(PharikasCure))]
    [XmlInclude(typeof(PharikasMender))]
    [XmlInclude(typeof(PheresBandCentaurs))]
    [XmlInclude(typeof(PolisCrusher))]
    [XmlInclude(typeof(PolukranosWorldEater))]
    [XmlInclude(typeof(PortentofBetrayal))]
    [XmlInclude(typeof(PrescientChimera))]
    [XmlInclude(typeof(PriestofIroas))]
    [XmlInclude(typeof(PrognosticSphinx))]
    [XmlInclude(typeof(ProphetofKruphix))]
    [XmlInclude(typeof(ProwlersHelm))]
    [XmlInclude(typeof(PsychicIntrusion))]
    [XmlInclude(typeof(PurphorosGodoftheForge))]
    [XmlInclude(typeof(PurphorossEmissary))]
    [XmlInclude(typeof(PyxisofPandemonium))]
    [XmlInclude(typeof(RageofPurphoros))]
    [XmlInclude(typeof(RagebloodShaman))]
    [XmlInclude(typeof(RayofDissolution))]
    [XmlInclude(typeof(ReadtheBones))]
    [XmlInclude(typeof(ReaperoftheWilds))]
    [XmlInclude(typeof(RescuefromtheUnderworld))]
    [XmlInclude(typeof(ReturnedCentaur))]
    [XmlInclude(typeof(ReturnedPhalanx))]
    [XmlInclude(typeof(ReverentHunter))]
    [XmlInclude(typeof(SatyrHedonist))]
    [XmlInclude(typeof(SatyrPiper))]
    [XmlInclude(typeof(SatyrRambler))]
    [XmlInclude(typeof(SavageSurge))]
    [XmlInclude(typeof(ScholarofAthreos))]
    [XmlInclude(typeof(Scourgemark))]
    [XmlInclude(typeof(SeaGodsRevenge))]
    [XmlInclude(typeof(SealockMonster))]
    [XmlInclude(typeof(SedgeScorpion))]
    [XmlInclude(typeof(SedgeScorpion))]
    [XmlInclude(typeof(SentryoftheUnderworld))]
    [XmlInclude(typeof(SetessanBattlePriest))]
    [XmlInclude(typeof(SetessanGriffin))]
    [XmlInclude(typeof(ShipbreakerKraken))]
    [XmlInclude(typeof(ShipwreckSinger))]
    [XmlInclude(typeof(ShreddingWinds))]
    [XmlInclude(typeof(SilentArtisan))]
    [XmlInclude(typeof(SipofHemlock))]
    [XmlInclude(typeof(SoldierofthePantheon))]
    [XmlInclude(typeof(SparkJolt))]
    [XmlInclude(typeof(SpearofHeliod))]
    [XmlInclude(typeof(SpearpointOread))]
    [XmlInclude(typeof(SpellheartChimera))]
    [XmlInclude(typeof(SpellheartChimera))]
    [XmlInclude(typeof(StaunchHeartedWarrior))]
    [XmlInclude(typeof(SteamAugury))]
    [XmlInclude(typeof(StoneshockGiant))]
    [XmlInclude(typeof(StormbreathDragon))]
    [XmlInclude(typeof(StymiedHopes))]
    [XmlInclude(typeof(SwanSong))]
    [XmlInclude(typeof(SylvanCaryatid))]
    [XmlInclude(typeof(TempleofAbandon))]
    [XmlInclude(typeof(TempleofDeceit))]
    [XmlInclude(typeof(TempleofMystery))]
    [XmlInclude(typeof(TempleofSilence))]
    [XmlInclude(typeof(TempleofTriumph))]
    [XmlInclude(typeof(ThassaGodoftheSea))]
    [XmlInclude(typeof(ThassasBounty))]
    [XmlInclude(typeof(ThassasEmissary))]
    [XmlInclude(typeof(Thoughtseize))]
    [XmlInclude(typeof(TimetoFeed))]
    [XmlInclude(typeof(TitanofEternalFire))]
    [XmlInclude(typeof(TitansStrength))]
    [XmlInclude(typeof(TormentedHero))]
    [XmlInclude(typeof(TravelersAmulet))]
    [XmlInclude(typeof(TravelingPhilosopher))]
    [XmlInclude(typeof(TriadofFates))]
    [XmlInclude(typeof(TritonFortuneHunter))]
    [XmlInclude(typeof(TritonShorethief))]
    [XmlInclude(typeof(TritonTactics))]
    [XmlInclude(typeof(TwoHeadedCerberus))]
    [XmlInclude(typeof(TymarettheMurderKing))]
    [XmlInclude(typeof(UnderworldCerberus))]
    [XmlInclude(typeof(UnknownShores))]
    [XmlInclude(typeof(VanquishtheFoul))]
    [XmlInclude(typeof(Vaporkin))]
    [XmlInclude(typeof(VipersKiss))]
    [XmlInclude(typeof(VoyagesEnd))]
    [XmlInclude(typeof(VoyagingSatyr))]
    [XmlInclude(typeof(VulpineGoliath))]
    [XmlInclude(typeof(WarriorsLesson))]
    [XmlInclude(typeof(WavecrashTriton))]
    [XmlInclude(typeof(WhipofErebos))]
    [XmlInclude(typeof(WildCelebrants))]
    [XmlInclude(typeof(WingsteedRider))]
    [XmlInclude(typeof(WitchesEye))]
    [XmlInclude(typeof(XenagostheReveler))]
    [XmlInclude(typeof(YokedOx))]

    # endregion
    # region BNG
    [XmlInclude(typeof(AcolytesReward))]
    [XmlInclude(typeof(AerieWorshippers))]
    [XmlInclude(typeof(AkroanConscriptor))]
    [XmlInclude(typeof(AkroanPhalanx))]
    [XmlInclude(typeof(AkroanSkyguard))]
    [XmlInclude(typeof(ArbiteroftheIdeal))]
    [XmlInclude(typeof(ArchetypeofAggression))]
    [XmlInclude(typeof(ArchetypeofCourage))]
    [XmlInclude(typeof(ArchetypeofEndurance))]
    [XmlInclude(typeof(ArchetypeofFinality))]
    [XmlInclude(typeof(ArchetypeofImagination))]
    [XmlInclude(typeof(AshioksAdept))]
    [XmlInclude(typeof(AspectofHydra))]
    [XmlInclude(typeof(Asphyxiate))]
    [XmlInclude(typeof(AstralCornucopia))]
    [XmlInclude(typeof(BileBlight))]
    [XmlInclude(typeof(BlackOakofOdunos))]
    [XmlInclude(typeof(BoltofKeranos))]
    [XmlInclude(typeof(BrimazKingofOreskos))]
    [XmlInclude(typeof(ChampionofStraySouls))]
    [XmlInclude(typeof(ChargingBadger))]
    [XmlInclude(typeof(ChorusoftheTides))]
    [XmlInclude(typeof(Chromanticore))]
    [XmlInclude(typeof(ClaimofErebos))]
    [XmlInclude(typeof(CourserofKruphix))]
    [XmlInclude(typeof(Crypsis))]
    [XmlInclude(typeof(CullingMark))]
    [XmlInclude(typeof(CyclopsofOneEyedPass))]
    [XmlInclude(typeof(DawntoDusk))]
    [XmlInclude(typeof(DeepwaterHypnotist))]
    [XmlInclude(typeof(Divination))]
    [XmlInclude(typeof(DrowninSorrow))]
    [XmlInclude(typeof(EaterofHope))]
    [XmlInclude(typeof(EidolonofCountlessBattles))]
    [XmlInclude(typeof(EliteSkirmisher))]
    [XmlInclude(typeof(EpharaGodofthePolis))]
    [XmlInclude(typeof(EpharasEnlightenment))]
    [XmlInclude(typeof(EpharasRadiance))]
    [XmlInclude(typeof(EpiphanyStorm))]
    [XmlInclude(typeof(EternitySnare))]
    [XmlInclude(typeof(EvanescentIntellect))]
    [XmlInclude(typeof(EverflameEidolon))]
    [XmlInclude(typeof(Excoriate))]
    [XmlInclude(typeof(EyeGouge))]
    [XmlInclude(typeof(FalloftheHammer))]
    [XmlInclude(typeof(FanaticofXenagos))]
    [XmlInclude(typeof(FateUnraveler))]
    [XmlInclude(typeof(FatedConflagration))]
    [XmlInclude(typeof(FatedInfatuation))]
    [XmlInclude(typeof(FatedIntervention))]
    [XmlInclude(typeof(FatedRetribution))]
    [XmlInclude(typeof(FatedReturn))]
    [XmlInclude(typeof(FearsomeTemper))]
    [XmlInclude(typeof(FelhideBrawler))]
    [XmlInclude(typeof(FelhideSpiritbinder))]
    [XmlInclude(typeof(FlameWreathedPhoenix))]
    [XmlInclude(typeof(FlitterstepEidolon))]
    [XmlInclude(typeof(FloodtideSerpent))]
    [XmlInclude(typeof(ForgestokerDragon))]
    [XmlInclude(typeof(ForlornPseudamma))]
    [XmlInclude(typeof(ForsakenDrifters))]
    [XmlInclude(typeof(GhostbladeEidolon))]
    [XmlInclude(typeof(Gild))]
    [XmlInclude(typeof(GlimpsetheSunGod))]
    [XmlInclude(typeof(GodFavoredGeneral))]
    [XmlInclude(typeof(GorgonsHead))]
    [XmlInclude(typeof(GraverobberSpider))]
    [XmlInclude(typeof(GreatHart))]
    [XmlInclude(typeof(GriffinDreamfinder))]
    [XmlInclude(typeof(GrislyTransformation))]
    [XmlInclude(typeof(HeraldofTorment))]
    [XmlInclude(typeof(HeroofIroas))]
    [XmlInclude(typeof(HeroofLeinaTower))]
    [XmlInclude(typeof(HeroesPodium))]
    [XmlInclude(typeof(HoldatBay))]
    [XmlInclude(typeof(HuntersProwess))]
    [XmlInclude(typeof(ImpetuousSunchaser))]
    [XmlInclude(typeof(KarametraGodofHarvests))]
    [XmlInclude(typeof(KarametrasFavor))]
    [XmlInclude(typeof(KioratheCrashingWave))]
    [XmlInclude(typeof(KiorasFollower))]
    [XmlInclude(typeof(KragmaButcher))]
    [XmlInclude(typeof(KrakenoftheStraits))]
    [XmlInclude(typeof(LightningVolley))]
    [XmlInclude(typeof(LoyalPegasus))]
    [XmlInclude(typeof(MarshmistTitan))]
    [XmlInclude(typeof(MeletisAstronomer))]
    [XmlInclude(typeof(Mindreaver))]
    [XmlInclude(typeof(MischiefandMayhem))]
    [XmlInclude(typeof(MogisGodofSlaughter))]
    [XmlInclude(typeof(MortalsArdor))]
    [XmlInclude(typeof(MortalsResolve))]
    [XmlInclude(typeof(Necrobite))]
    [XmlInclude(typeof(NessianDemolok))]
    [XmlInclude(typeof(NessianWildsRavager))]
    [XmlInclude(typeof(NobleQuarry))]
    [XmlInclude(typeof(Nullify))]
    [XmlInclude(typeof(NyxbornEidolon))]
    [XmlInclude(typeof(NyxbornRollicker))]
    [XmlInclude(typeof(NyxbornShieldmate))]
    [XmlInclude(typeof(NyxbornTriton))]
    [XmlInclude(typeof(NyxbornWolf))]
    [XmlInclude(typeof(OdunosRiverTrawler))]
    [XmlInclude(typeof(OracleofBones))]
    [XmlInclude(typeof(OraclesInsight))]
    [XmlInclude(typeof(OreskosSunGuide))]
    [XmlInclude(typeof(Ornitharch))]
    [XmlInclude(typeof(PainSeer))]
    [XmlInclude(typeof(Peregrination))]
    [XmlInclude(typeof(PerplexingChimera))]
    [XmlInclude(typeof(PharagaxGiant))]
    [XmlInclude(typeof(PhenaxGodofDeception))]
    [XmlInclude(typeof(PheresBandRaiders))]
    [XmlInclude(typeof(PheresBandTromper))]
    [XmlInclude(typeof(PillarofWar))]
    [XmlInclude(typeof(PinnacleofRage))]
    [XmlInclude(typeof(PleaforGuidance))]
    [XmlInclude(typeof(Ragemonger))]
    [XmlInclude(typeof(RaisedbyWolves))]
    [XmlInclude(typeof(ReapWhatIsSown))]
    [XmlInclude(typeof(RecklessReveler))]
    [XmlInclude(typeof(RetractionHelix))]
    [XmlInclude(typeof(RevokeExistence))]
    [XmlInclude(typeof(RisetotheChallenge))]
    [XmlInclude(typeof(Sanguimancy))]
    [XmlInclude(typeof(SatyrFiredancer))]
    [XmlInclude(typeof(SatyrNyxSmith))]
    [XmlInclude(typeof(SatyrWayfinder))]
    [XmlInclude(typeof(ScourgeofSkolaVale))]
    [XmlInclude(typeof(ScouringSands))]
    [XmlInclude(typeof(SearingBlood))]
    [XmlInclude(typeof(ServantofTymaret))]
    [XmlInclude(typeof(SetessanOathsworn))]
    [XmlInclude(typeof(SetessanStarbreaker))]
    [XmlInclude(typeof(ShrikeHarpy))]
    [XmlInclude(typeof(SilentSentinel))]
    [XmlInclude(typeof(SirenoftheFangedCoast))]
    [XmlInclude(typeof(SirenoftheSilentSong))]
    [XmlInclude(typeof(SirenSongLyre))]
    [XmlInclude(typeof(Skyreaping))]
    [XmlInclude(typeof(SnakeoftheGoldenGrove))]
    [XmlInclude(typeof(SphinxsDisciple))]
    [XmlInclude(typeof(SpiritoftheLabyrinth))]
    [XmlInclude(typeof(SpitefulReturned))]
    [XmlInclude(typeof(SpringleafDrum))]
    [XmlInclude(typeof(StormcallerofKeranos))]
    [XmlInclude(typeof(StratusWalk))]
    [XmlInclude(typeof(SuddenStorm))]
    [XmlInclude(typeof(Sunbond))]
    [XmlInclude(typeof(SwordwiseCentaur))]
    [XmlInclude(typeof(TempleofEnlightenment))]
    [XmlInclude(typeof(TempleofMalice))]
    [XmlInclude(typeof(TempleofPlenty))]
    [XmlInclude(typeof(ThassasRebuff))]
    [XmlInclude(typeof(ThunderBrute))]
    [XmlInclude(typeof(ThunderousMight))]
    [XmlInclude(typeof(Tromokratis))]
    [XmlInclude(typeof(UnraveltheÆther))]
    [XmlInclude(typeof(VanguardofBrimaz))]
    [XmlInclude(typeof(VortexElemental))]
    [XmlInclude(typeof(WarchanterofMogis))]
    [XmlInclude(typeof(WeightoftheUnderworld))]
    [XmlInclude(typeof(WhelmingWave))]
    [XmlInclude(typeof(WhimsoftheFates))]
    [XmlInclude(typeof(XenagosGodofRevels))]
    # endregion
    # region JOU
    [XmlInclude(typeof(AegisoftheGods))]
    [XmlInclude(typeof(AerialFormation))]
    [XmlInclude(typeof(AgentofErebos))]
    [XmlInclude(typeof(AjaniMentorofHeroes))]
    [XmlInclude(typeof(AjanisPresence))]
    [XmlInclude(typeof(AkroanLineBreaker))]
    [XmlInclude(typeof(AkroanMastiff))]
    [XmlInclude(typeof(ArmamentofNyx))]
    [XmlInclude(typeof(ArmoryofIroas))]
    [XmlInclude(typeof(AspectofGorgon))]
    [XmlInclude(typeof(AthreosGodofPassage))]
    [XmlInclude(typeof(BanishingLight))]
    [XmlInclude(typeof(BassaraTowerArcher))]
    [XmlInclude(typeof(BattlefieldThaumaturge))]
    [XmlInclude(typeof(BeareroftheHeavens))]
    [XmlInclude(typeof(BladetuskBoar))]
    [XmlInclude(typeof(BlindingFlare))]
    [XmlInclude(typeof(BloodcrazedHoplite))]
    [XmlInclude(typeof(BrainMaggot))]
    [XmlInclude(typeof(CastintoDarkness))]
    [XmlInclude(typeof(ChariotofVictory))]
    [XmlInclude(typeof(CloakedSiren))]
    [XmlInclude(typeof(ColossalHeroics))]
    [XmlInclude(typeof(ConsigntoDust))]
    [XmlInclude(typeof(Countermand))]
    [XmlInclude(typeof(CruelFeeding))]
    [XmlInclude(typeof(CrystallineNautilus))]
    [XmlInclude(typeof(CyclopsofEternalFury))]
    [XmlInclude(typeof(DakraMystic))]
    [XmlInclude(typeof(DaringThief))]
    [XmlInclude(typeof(DawnbringerCharioteers))]
    [XmlInclude(typeof(Deicide))]
    [XmlInclude(typeof(DesecrationPlague))]
    [XmlInclude(typeof(DesertersQuarters))]
    [XmlInclude(typeof(DesperateStand))]
    [XmlInclude(typeof(DictateofErebos))]
    [XmlInclude(typeof(DictateofHeliod))]
    [XmlInclude(typeof(DictateofKarametra))]
    [XmlInclude(typeof(DictateofKruphix))]
    [XmlInclude(typeof(DictateoftheTwinGods))]
    [XmlInclude(typeof(DiscipleofDeceit))]
    [XmlInclude(typeof(DoomwakeGiant))]
    [XmlInclude(typeof(DreadbringerLampads))]
    [XmlInclude(typeof(EagleoftheWatch))]
    [XmlInclude(typeof(EidolonofBlossoms))]
    [XmlInclude(typeof(EidolonofRhetoric))]
    [XmlInclude(typeof(EidolonoftheGreatRevel))]
    [XmlInclude(typeof(ExtinguishAllHope))]
    [XmlInclude(typeof(FeastofDreams))]
    [XmlInclude(typeof(FelhidePetrifier))]
    [XmlInclude(typeof(FlamespeakersWill))]
    [XmlInclude(typeof(FleetfeatherCockatrice))]
    [XmlInclude(typeof(FlurryofHorns))]
    [XmlInclude(typeof(FontofFertility))]
    [XmlInclude(typeof(FontofFortunes))]
    [XmlInclude(typeof(FontofIre))]
    [XmlInclude(typeof(FontofReturn))]
    [XmlInclude(typeof(FontofVigor))]
    [XmlInclude(typeof(ForgebornOreads))]
    [XmlInclude(typeof(GluttonousCyclops))]
    [XmlInclude(typeof(GnarledScarhide))]
    [XmlInclude(typeof(GodhunterOctopus))]
    [XmlInclude(typeof(Godsend))]
    [XmlInclude(typeof(GoldenHind))]
    [XmlInclude(typeof(GoldenhideOx))]
    [XmlInclude(typeof(GoldForgedSentinel))]
    [XmlInclude(typeof(GrimGuardian))]
    [XmlInclude(typeof(HallofTriumph))]
    [XmlInclude(typeof(HarnessbyForce))]
    [XmlInclude(typeof(HarvestguardAlseids))]
    [XmlInclude(typeof(HeroesBane))]
    [XmlInclude(typeof(HourofNeed))]
    [XmlInclude(typeof(Hubris))]
    [XmlInclude(typeof(HumblerofMortals))]
    [XmlInclude(typeof(HydraBroodmaster))]
    [XmlInclude(typeof(HypnoticSiren))]
    [XmlInclude(typeof(InterprettheSigns))]
    [XmlInclude(typeof(IroasGodofVictory))]
    [XmlInclude(typeof(KeranosGodofStorms))]
    [XmlInclude(typeof(KingMacartheGoldCursed))]
    [XmlInclude(typeof(KiorasDismissal))]
    [XmlInclude(typeof(KnowledgeandPower))]
    [XmlInclude(typeof(KruphixGodofHorizons))]
    [XmlInclude(typeof(KruphixsInsight))]
    [XmlInclude(typeof(LagonnaBandTrailblazer))]
    [XmlInclude(typeof(LaunchtheFleet))]
    [XmlInclude(typeof(LeoninIconoclast))]
    [XmlInclude(typeof(LightningDiadem))]
    [XmlInclude(typeof(MagmaSpray))]
    [XmlInclude(typeof(ManaConfluence))]
    [XmlInclude(typeof(MarketFestival))]
    [XmlInclude(typeof(MasteroftheFeast))]
    [XmlInclude(typeof(MogissWarhound))]
    [XmlInclude(typeof(MortalObstinacy))]
    [XmlInclude(typeof(NaturesPanoply))]
    [XmlInclude(typeof(NessianGameWarden))]
    [XmlInclude(typeof(NightmarishEnd))]
    [XmlInclude(typeof(NyxInfusion))]
    [XmlInclude(typeof(NyxFleeceRam))]
    [XmlInclude(typeof(NyxWeaver))]
    [XmlInclude(typeof(OakheartDryads))]
    [XmlInclude(typeof(OppressiveRays))]
    [XmlInclude(typeof(OreskosSwiftclaw))]
    [XmlInclude(typeof(PensiveMinotaur))]
    [XmlInclude(typeof(PhalanxFormation))]
    [XmlInclude(typeof(PharikaGodofAffliction))]
    [XmlInclude(typeof(PharikasChosen))]
    [XmlInclude(typeof(PheresBandThunderhoof))]
    [XmlInclude(typeof(PheresBandWarchief))]
    [XmlInclude(typeof(PintotheEarth))]
    [XmlInclude(typeof(PolymorphousRush))]
    [XmlInclude(typeof(PropheticFlamespeaker))]
    [XmlInclude(typeof(PullfromtheDeep))]
    [XmlInclude(typeof(QuarryColossus))]
    [XmlInclude(typeof(RavenousLeucrocota))]
    [XmlInclude(typeof(RenownedWeaver))]
    [XmlInclude(typeof(Reprisal))]
    [XmlInclude(typeof(ReturnedReveler))]
    [XmlInclude(typeof(ReveloftheFallenGod))]
    [XmlInclude(typeof(RevivingMelody))]
    [XmlInclude(typeof(RiddleofLightning))]
    [XmlInclude(typeof(RiptideChimera))]
    [XmlInclude(typeof(RiseofEagles))]
    [XmlInclude(typeof(RitualoftheReturned))]
    [XmlInclude(typeof(RollickofAbandon))]
    [XmlInclude(typeof(RottedHulk))]
    [XmlInclude(typeof(RousetheMob))]
    [XmlInclude(typeof(SageofHours))]
    [XmlInclude(typeof(SatyrGrovedancer))]
    [XmlInclude(typeof(SatyrHoplite))]
    [XmlInclude(typeof(ScourgeofFleets))]
    [XmlInclude(typeof(SetessanTactics))]
    [XmlInclude(typeof(SightlessBrawler))]
    [XmlInclude(typeof(SigiledSkink))]
    [XmlInclude(typeof(SigiledStarfish))]
    [XmlInclude(typeof(SilencetheBelievers))]
    [XmlInclude(typeof(Skybind))]
    [XmlInclude(typeof(SkyspearCavalry))]
    [XmlInclude(typeof(SolidarityofHeroes))]
    [XmlInclude(typeof(SpawnofThraxes))]
    [XmlInclude(typeof(Spirespine))]
    [XmlInclude(typeof(SpiteofMogis))]
    [XmlInclude(typeof(SpitefulBlow))]
    [XmlInclude(typeof(SquelchingLeeches))]
    [XmlInclude(typeof(Starfall))]
    [XmlInclude(typeof(StonewiseFortifier))]
    [XmlInclude(typeof(StormchaserChimera))]
    [XmlInclude(typeof(StrengthfromtheFallen))]
    [XmlInclude(typeof(SupplyLineCranes))]
    [XmlInclude(typeof(SwarmbornGiant))]
    [XmlInclude(typeof(TempleofEpiphany))]
    [XmlInclude(typeof(TempleofMalady))]
    [XmlInclude(typeof(TethmosHighPriest))]
    [XmlInclude(typeof(ThassasDevourer))]
    [XmlInclude(typeof(ThassasIre))]
    [XmlInclude(typeof(ThoughtrenderLamia))]
    [XmlInclude(typeof(TormentedThoughts))]
    [XmlInclude(typeof(TritonCavalry))]
    [XmlInclude(typeof(TritonShorestalker))]
    [XmlInclude(typeof(Twinflame))]
    [XmlInclude(typeof(UnderworldCoinsmith))]
    [XmlInclude(typeof(WarWingSiren))]
    [XmlInclude(typeof(WhitewaterNaiads))]
    [XmlInclude(typeof(WildfireCerberus))]
    [XmlInclude(typeof(WorstFears))]

    # endregion
    # region Core
    # region Core 14
    [XmlInclude(typeof(AcademyRaider))]
    [XmlInclude(typeof(AccordersShield))]
    [XmlInclude(typeof(AccursedSpirit))]
    [XmlInclude(typeof(ActofTreason))]
    [XmlInclude(typeof(AdvocateoftheBeast))]
    [XmlInclude(typeof(AirServant))]
    [XmlInclude(typeof(AjaniCallerofthePride))]
    [XmlInclude(typeof(AjanisChosen))]
    [XmlInclude(typeof(AltarsReap))]
    [XmlInclude(typeof(AngelicAccord))]
    [XmlInclude(typeof(AngelicWall))]
    [XmlInclude(typeof(Archaeomancer))]
    [XmlInclude(typeof(ArchangelofThune))]
    [XmlInclude(typeof(ArmoredCancrix))]
    [XmlInclude(typeof(ArtificersHex))]
    [XmlInclude(typeof(Auramancer))]
    [XmlInclude(typeof(AwakentheAncient))]
    [XmlInclude(typeof(BanisherPriest))]
    [XmlInclude(typeof(BarrageofExpendables))]
    [XmlInclude(typeof(BattleSliver))]
    [XmlInclude(typeof(Blessing))]
    [XmlInclude(typeof(Blightcaster))]
    [XmlInclude(typeof(BloodBairn))]
    [XmlInclude(typeof(BlurSliver))]
    [XmlInclude(typeof(BogbrewWitch))]
    [XmlInclude(typeof(BonescytheSliver))]
    [XmlInclude(typeof(Bramblecrush))]
    [XmlInclude(typeof(BravetheElements))]
    [XmlInclude(typeof(BriarpackAlpha))]
    [XmlInclude(typeof(BrindleBoar))]
    [XmlInclude(typeof(BubblingCauldron))]
    [XmlInclude(typeof(BurningEarth))]
    [XmlInclude(typeof(Cancel))]
    [XmlInclude(typeof(CanyonMinotaur))]
    [XmlInclude(typeof(CapashenKnight))]
    [XmlInclude(typeof(CelestialFlare))]
    [XmlInclude(typeof(ChandraPyromaster))]
    [XmlInclude(typeof(ChandrasOutrage))]
    [XmlInclude(typeof(ChandrasPhoenix))]
    [XmlInclude(typeof(ChargingGriffin))]
    [XmlInclude(typeof(ChildofNight))]
    [XmlInclude(typeof(Claustrophobia))]
    [XmlInclude(typeof(Clone))]
    [XmlInclude(typeof(ColossalWhale))]
    [XmlInclude(typeof(Congregate))]
    [XmlInclude(typeof(CoralMerfolk))]
    [XmlInclude(typeof(CorpseHauler))]
    [XmlInclude(typeof(Corrupt))]
    [XmlInclude(typeof(CyclopsTyrant))]
    [XmlInclude(typeof(DarkFavor))]
    [XmlInclude(typeof(DarkProphecy))]
    [XmlInclude(typeof(DarksteelForge))]
    [XmlInclude(typeof(DarksteelIngot))]
    [XmlInclude(typeof(DawnstrikePaladin))]
    [XmlInclude(typeof(DeadlyRecluse))]
    [XmlInclude(typeof(DeathgazeCockatrice))]
    [XmlInclude(typeof(Demolish))]
    [XmlInclude(typeof(DevoutInvocation))]
    [XmlInclude(typeof(DiabolicTutor))]
    [XmlInclude(typeof(DismissintoDream))]
    [XmlInclude(typeof(Disperse))]
    [XmlInclude(typeof(Divination))]
    [XmlInclude(typeof(DivineFavor))]
    [XmlInclude(typeof(Domestication))]
    [XmlInclude(typeof(DoomBlade))]
    [XmlInclude(typeof(DoorofDestinies))]
    [XmlInclude(typeof(DragonEgg))]
    [XmlInclude(typeof(DragonHatchling))]
    [XmlInclude(typeof(Duress))]
    [XmlInclude(typeof(EliteArcanist))]
    [XmlInclude(typeof(ElixirofImmortality))]
    [XmlInclude(typeof(ElvishMystic))]
    [XmlInclude(typeof(EncroachingWastes))]
    [XmlInclude(typeof(Enlarge))]
    [XmlInclude(typeof(EssenceScatter))]
    [XmlInclude(typeof(FesteringNewt))]
    [XmlInclude(typeof(FiendslayerPaladin))]
    [XmlInclude(typeof(Fireshrieker))]
    [XmlInclude(typeof(FlamesoftheFirebrand))]
    [XmlInclude(typeof(FleshpulperGiant))]
    [XmlInclude(typeof(Fog))]
    [XmlInclude(typeof(Forest))]
    [XmlInclude(typeof(Fortify))]
    [XmlInclude(typeof(FrostBreath))]
    [XmlInclude(typeof(GaleriderSliver))]
    [XmlInclude(typeof(GarrukCallerofBeasts))]
    [XmlInclude(typeof(GarruksHorde))]
    [XmlInclude(typeof(GiantGrowth))]
    [XmlInclude(typeof(GiantSpider))]
    [XmlInclude(typeof(GladecoverScout))]
    [XmlInclude(typeof(GlimpsetheFuture))]
    [XmlInclude(typeof(GnawingZombie))]
    [XmlInclude(typeof(GoblinDiplomats))]
    [XmlInclude(typeof(GoblinShortcutter))]
    [XmlInclude(typeof(GriffinSentinel))]
    [XmlInclude(typeof(GrimReturn))]
    [XmlInclude(typeof(GroundshakerSliver))]
    [XmlInclude(typeof(GuardianoftheAges))]
    [XmlInclude(typeof(HauntedPlateMail))]
    [XmlInclude(typeof(HiveStirrings))]
    [XmlInclude(typeof(HowloftheNightPack))]
    [XmlInclude(typeof(HunttheWeak))]
    [XmlInclude(typeof(IllusionaryArmor))]
    [XmlInclude(typeof(ImposingSovereign))]
    [XmlInclude(typeof(Indestructibility))]
    [XmlInclude(typeof(IntotheWilds))]
    [XmlInclude(typeof(Island))]
    [XmlInclude(typeof(JaceMemoryAdept))]
    [XmlInclude(typeof(JacesMindseeker))]
    [XmlInclude(typeof(KalonianHydra))]
    [XmlInclude(typeof(KalonianTusker))]
    [XmlInclude(typeof(LavaAxe))]
    [XmlInclude(typeof(LayoftheLand))]
    [XmlInclude(typeof(LifebaneZombie))]
    [XmlInclude(typeof(LightningTalons))]
    [XmlInclude(typeof(LilianaoftheDarkRealms))]
    [XmlInclude(typeof(LilianasReaver))]
    [XmlInclude(typeof(LiturgyofBlood))]
    [XmlInclude(typeof(ManaweftSliver))]
    [XmlInclude(typeof(MaraudingMaulhorn))]
    [XmlInclude(typeof(MarkoftheVampire))]
    [XmlInclude(typeof(MasterofDiversion))]
    [XmlInclude(typeof(MeganticSliver))]
    [XmlInclude(typeof(MerfolkSpy))]
    [XmlInclude(typeof(MessengerDrake))]
    [XmlInclude(typeof(Millstone))]
    [XmlInclude(typeof(MindRot))]
    [XmlInclude(typeof(Mindsparker))]
    [XmlInclude(typeof(MinotaurAbomination))]
    [XmlInclude(typeof(MoltenBirth))]
    [XmlInclude(typeof(Mountain))]
    [XmlInclude(typeof(Mutavault))]
    [XmlInclude(typeof(Naturalize))]
    [XmlInclude(typeof(Negate))]
    [XmlInclude(typeof(NephaliaSeakite))]
    [XmlInclude(typeof(Nightmare))]
    [XmlInclude(typeof(NightwingShade))]
    [XmlInclude(typeof(OathoftheAncientWood))]
    [XmlInclude(typeof(OgreBattledriver))]
    [XmlInclude(typeof(Opportunity))]
    [XmlInclude(typeof(Pacifism))]
    [XmlInclude(typeof(PathofBravery))]
    [XmlInclude(typeof(PayNoHeed))]
    [XmlInclude(typeof(PhantomWarrior))]
    [XmlInclude(typeof(PillarfieldOx))]
    [XmlInclude(typeof(PitchburnDevils))]
    [XmlInclude(typeof(Plains))]
    [XmlInclude(typeof(PlanarCleansing))]
    [XmlInclude(typeof(Plummet))]
    [XmlInclude(typeof(PredatorySliver))]
    [XmlInclude(typeof(PrimevalBounty))]
    [XmlInclude(typeof(PyromancersGauntlet))]
    [XmlInclude(typeof(QuagSickness))]
    [XmlInclude(typeof(Quicken))]
    [XmlInclude(typeof(RangersGuile))]
    [XmlInclude(typeof(RatchetBomb))]
    [XmlInclude(typeof(RegathanFirecat))]
    [XmlInclude(typeof(RingofThreeWishes))]
    [XmlInclude(typeof(RiseoftheDarkRealms))]
    [XmlInclude(typeof(RodofRuin))]
    [XmlInclude(typeof(Rootwalla))]
    [XmlInclude(typeof(RumblingBaloth))]
    [XmlInclude(typeof(SanguineBond))]
    [XmlInclude(typeof(SavageSummoning))]
    [XmlInclude(typeof(ScavengingOoze))]
    [XmlInclude(typeof(ScourgeofValkas))]
    [XmlInclude(typeof(ScrollThief))]
    [XmlInclude(typeof(SeacoastDrake))]
    [XmlInclude(typeof(SeismicStomp))]
    [XmlInclude(typeof(SengirVampire))]
    [XmlInclude(typeof(SensoryDeprivation))]
    [XmlInclude(typeof(SentinelSliver))]
    [XmlInclude(typeof(SeraphoftheSword))]
    [XmlInclude(typeof(SerraAngel))]
    [XmlInclude(typeof(ShadowbornApostle))]
    [XmlInclude(typeof(ShadowbornDemon))]
    [XmlInclude(typeof(ShimmeringGrotto))]
    [XmlInclude(typeof(ShivanDragon))]
    [XmlInclude(typeof(ShivsEmbrace))]
    [XmlInclude(typeof(Shock))]
    [XmlInclude(typeof(ShowofValor))]
    [XmlInclude(typeof(Shrivel))]
    [XmlInclude(typeof(SiegeMastodon))]
    [XmlInclude(typeof(Silence))]
    [XmlInclude(typeof(SliverConstruct))]
    [XmlInclude(typeof(Smelt))]
    [XmlInclude(typeof(SolemnOffering))]
    [XmlInclude(typeof(Soulmender))]
    [XmlInclude(typeof(SpellBlast))]
    [XmlInclude(typeof(Sporemound))]
    [XmlInclude(typeof(StaffoftheDeathMagus))]
    [XmlInclude(typeof(StaffoftheFlameMagus))]
    [XmlInclude(typeof(StaffoftheMindMagus))]
    [XmlInclude(typeof(StaffoftheSunMagus))]
    [XmlInclude(typeof(StaffoftheWildMagus))]
    [XmlInclude(typeof(SteelformSliver))]
    [XmlInclude(typeof(StonehornChanter))]
    [XmlInclude(typeof(StrikingSliver))]
    [XmlInclude(typeof(StrionicResonator))]
    [XmlInclude(typeof(SuntailHawk))]
    [XmlInclude(typeof(Swamp))]
    [XmlInclude(typeof(SyphonSliver))]
    [XmlInclude(typeof(TenaciousDead))]
    [XmlInclude(typeof(ThorncasterSliver))]
    [XmlInclude(typeof(ThunderStrike))]
    [XmlInclude(typeof(TidebinderMage))]
    [XmlInclude(typeof(TimeEbb))]
    [XmlInclude(typeof(TomeScour))]
    [XmlInclude(typeof(TradingPost))]
    [XmlInclude(typeof(TrainedCondor))]
    [XmlInclude(typeof(Traumatize))]
    [XmlInclude(typeof(Trollhide))]
    [XmlInclude(typeof(UndeadMinotaur))]
    [XmlInclude(typeof(VampireWarlord))]
    [XmlInclude(typeof(VastwoodHydra))]
    [XmlInclude(typeof(VerdantHaven))]
    [XmlInclude(typeof(VialofPoison))]
    [XmlInclude(typeof(VileRebirth))]
    [XmlInclude(typeof(VolcanicGeyser))]
    [XmlInclude(typeof(VoraciousWurm))]
    [XmlInclude(typeof(WallofFrost))]
    [XmlInclude(typeof(WallofSwords))]
    [XmlInclude(typeof(WardenofEvosIsle))]
    [XmlInclude(typeof(WaterServant))]
    [XmlInclude(typeof(WildGuess))]
    [XmlInclude(typeof(WildRicochet))]
    [XmlInclude(typeof(WindreaderSphinx))]
    [XmlInclude(typeof(Windstorm))]
    [XmlInclude(typeof(Witchstalker))]
    [XmlInclude(typeof(WoodbornBehemoth))]
    [XmlInclude(typeof(WringFlesh))]
    [XmlInclude(typeof(XathridNecromancer))]
    [XmlInclude(typeof(YoungPyromancer))]
    [XmlInclude(typeof(ZephyrCharge))]

    # endregion
    # region Core 15

    # endregion
    # endregion
    # endregion
    public class MagicCard : ICloneable
    {
        # region declarations
        # region Fields
        //"Name";"Edition";"Rarity";"Color";"Cost";"P/T";"Type";"Text";"Flavor"
        # region Card parts
        public string Name = "";
        public string Edition = "";
        public string Rarity = "";
        public string Color = "";
        public string Cost = "";
        public string PT = "";
        public string Type = "Creature";
        public string Text = "";
        public string Flavor = "";
        # endregion

        # region card states
        public bool Token = false;

        [XmlIgnore]
        public bool _Tapped = false;
        public bool Tapped
        {
            get { return _Tapped; }
            set
            {
                if (_Tapped != value)
                {
                    _Tapped = value;
                    callTapChanged();
                }
            }
        }

        [XmlIgnore]
        public bool Sick = false;
        # endregion

        [XmlIgnore]
        public int Xvalue = 0;

        [XmlIgnore]
        public bool Attacking = false;

        [XmlIgnore]
        public int CMC
        {
            get
            {
                int result = 0;

                foreach (char c in Cost)
                {
                    if (Char.IsNumber(c))
                    {
                        result += (int)char.GetNumericValue(c);
                    }
                    else
                    {
                        result++;
                    }
                }

                return result;
            }
        }

        # region temp parts
        [XmlIgnore]
        public ColourCost manaCost = new ColourCost();
        [XmlIgnore]
        public int Power = 0;
        [XmlIgnore]
        public int Toughness = 0;
        [XmlIgnore]
        public string imgLoc = "";

        # region Spell variables
        [XmlIgnore]
        public int Targets = 0;
        [XmlIgnore]
        public int AbilityIndex = 0;
        [XmlIgnore]
        public ColourCost AdditionalCost = new ColourCost();
        # endregion

        [XmlIgnore]
        public int PBonus = 0;  //temp bonus
        [XmlIgnore]
        public int TBonus = 0;  //temp bonus

        private int countersTurn = 0;
        [XmlIgnore]
        private int _counters = 0;
        public int counters
        {
            get { return _counters; }
            set
            {
                int change = value - _counters;
                _counters = value;
                if (change < 0 && Name == "Protean Hydra")
                {
                    countersTurn -= change;
                }
                checkPT();
                callCountersChanged(change);
            }
        }
        # endregion

        public int quantity = 1;

        [XmlIgnore]
        public List<MagicCard> attachedCards = new List<MagicCard>();
        [XmlIgnore]
        public MagicCard Parent = null;

        [XmlIgnore]
        public PlayArea PArea
        {
            get { return _pArea; }
            set
            {
                _pArea = value;
            }
        }
        private PlayArea _pArea = null;

        [XmlIgnore]
        public PlayArea OppArea
        {
            get { return _oppArea; }
            set
            {
                _oppArea = value;
            }
        }
        private PlayArea _oppArea = null;

        [XmlIgnore]
        public string Location = "Library";

        //[XmlIgnore]
        public List<CardAbility> Abilities = new List<CardAbility>();
        # endregion

        # region handlers
        # region delegates/events
        public delegate void ActiveAbility(MagicCard mc, int index);  //index of ability being used. 0 based.

        public event ValueChanged CountersChanged;
        public event ValueChanged onPingOpponent;
        public event ActiveAbility Activate;
        public event ActiveAbility Activating;
        public event PassiveEvent Evolving;
        public event PassiveEvent OnUpkeep;
        public event PassiveEvent OnAttack;
        public event PassiveEvent OnEquip;
        public event PassiveEvent OnUnequip;
        public event PassiveEvent onAuraAdded;
        public event PassiveEvent onAuraRemoved;
        public event PassiveEvent onEquipmentAdd;
        public event PassiveEvent onEquipmentRemoved;
        public event PassiveEvent onSpellCast;
        public event PassiveEvent onDie;
        public event PassiveEvent onSacrifice;
        public event PassiveEvent TapChanged;
        public event PassiveEvent OnTap;
        public event PassiveEvent OnUntap;
        public event PassiveEvent Discard;
        public event PassiveEvent Destroyed;
        public event PassiveEvent PrePlay;
        public event PassiveEvent OnPlay;
        public event PassiveEvent Resolving;
        public event Action StatsChanged;
        # endregion

        # region event trigger methods
        public void callResolving()
        {
            PassiveEvent handler = Resolving;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callOnUpkeep()
        {
            PassiveEvent handler = OnUpkeep;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callAuraAdded(MagicCard mc)
        {
            PassiveEvent handler = onAuraAdded;
            if (handler != null)
            {
                handler(mc);
            }
        }

        public void callDie()
        {
            PassiveEvent handler = onDie;
            if (handler != null)
            {
                handler(this);
            }
            callDestroyed();
        }

        public void callSacrifice()
        {
            PassiveEvent handler = onSacrifice;
            if (handler != null)
            {
                handler(this);
            }
            callDie();
        }

        public void callActivate(int index)
        {
            ActiveAbility handler = Activate;
            if (handler != null)
            {
                handler(this, index);
            }
        }

        private void callActivating(int index)
        {
            ActiveAbility handler = Activating;
            if (handler != null)
            {
                handler(this, index);
            }
        }

        public void callEvolve()
        {
            PassiveEvent handler = Evolving;

            if (handler != null)
            {
                handler(this);
            }
        }

        public void callAbility(int index)
        {
            ActiveAbility handler = Activate;
            if (handler != null)
            {
                handler(this, index);
            }
        }

        public void callSpellCast()
        {
            PassiveEvent handler = onSpellCast;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callPingOpponent(int damage)
        {
            ValueChanged handler = onPingOpponent;
            if (handler != null)
            {
                handler(damage);
            }
            OppArea.HP -= damage;
        }

        public void callOnEquipmentAdd()
        {
            PassiveEvent handler = onEquipmentAdd;
            if (handler != null)
            {
                handler(this);
            }
        }

        private void callOnEquipmentRemoved(MagicCard mc)
        {
            PassiveEvent handler = onEquipmentRemoved;
            if (handler != null)
            {
                handler(mc);
            }
        }

        public void callOnEquip()
        {
            PassiveEvent handler = OnEquip;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callOnUnequip()
        {
            PassiveEvent handler = OnUnequip;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callOnAttack()
        {
            PassiveEvent handler = OnAttack;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callTapChanged()
        {
            PassiveEvent handler = TapChanged;
            if (handler != null)
            {
                handler(this);
            }

            if (Tapped)
            {
                callOnTap();
            }
            else
            {
                callOnUntap();
            }
        }

        public void callOnTap()
        {
            PassiveEvent handler = OnTap;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callOnUntap()
        {
            PassiveEvent handler = OnUntap;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callDiscard()
        {
            PassiveEvent handler = Discard;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callDestroyed()
        {
            PassiveEvent handler = Destroyed;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callCountersChanged(int count)
        {
            ValueChanged handler = CountersChanged;
            if (handler != null)
            {
                handler(count);
            }
        }

        public void callPrePlay()
        {
            PassiveEvent handler = PrePlay;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callOnPlay()
        {
            PassiveEvent handler = OnPlay;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callStatsChanged()
        {
            Action handler = StatsChanged;
            if (handler != null)
            {
                handler();
            }
        }
        # endregion
        # endregion
        # endregion

        # region methods
        public MagicCard() { }

        public MagicCard(MagicCard mc)
        {
            Name = mc.Name;
            Edition = mc.Edition;
            Rarity = mc.Rarity;
            Color = mc.Color;
            Cost = mc.Cost;
            PT = mc.PT;
            Type = mc.Type;
            Text = mc.Text;
            Flavor = mc.Flavor;

            Power = mc.Power;
            Toughness = mc.Toughness;

            imgLoc = mc.imgLoc;

            quantity = mc.quantity;
            //counters = mc.counters;

            Xvalue = mc.Xvalue;
        }

        public void CopyCard(MagicCard mc)
        {
            Name = mc.Name;
            Edition = mc.Edition;
            Rarity = mc.Rarity;
            Color = mc.Color;
            Cost = mc.Cost;
            PT = mc.PT;
            Type = mc.Type;
            Text = mc.Text;
            Flavor = mc.Flavor;

            Power = mc.Power;
            Toughness = mc.Toughness;

            imgLoc = mc.imgLoc;

            quantity = mc.quantity;
            //counters = mc.counters;

            Xvalue = mc.Xvalue;
        }

        void Setup()
        {
            if (PArea != null)
            {
                PArea.SpellRes += new PassiveEvent(SpellResolved);
            }
        }

        public void Initialise()
        {
            attachedCards.Clear();
            setMana();
            checkPT();
            ParseText();
        }

        public void checkPT()
        {
            string[] parts = PT.Split('/');
            int pOri = Power;
            int tOri = Toughness;

            if (parts.Length > 1)
            {
                int.TryParse(parts[0], out Power);
                int.TryParse(parts[1], out Toughness);
            }

            switch (Name)
            {
                case "Crusader of Odric":
                    if (PArea != null)
                    {
                        Power = PArea._play.cards.Count;
                        Toughness = PArea._play.cards.Count;
                    }
                    break;

                case "Eidolon of Countless Battles":
                    if (PArea != null)
                    {
                        Power = PArea._play.cards.Count;
                        Toughness = PArea._play.cards.Count;
                    }
                    break;

                case "Geist-Honored Monk":
                    if (PArea != null)
                    {
                        Power = PArea._play.cards.Count;
                        Toughness = PArea._play.cards.Count;
                    }
                    break;
            }

            # region cycle through attached cards
            foreach (MagicCard mc in attachedCards)
            {
                List<string> temp = mc.getStats();

                foreach (string s in temp)
                {
                    string[] sPart = s.Split(new string[] { "#" }, StringSplitOptions.None);

                    switch (sPart[0])
                    {
                        case "Power":
                            Power += int.Parse(sPart[1]);
                            break;

                        case "Toughness":
                            Toughness += int.Parse(sPart[1]);
                            break;

                        case "Ability":

                            break;
                    }
                }
            }
            # endregion

            Power += counters;
            Toughness += counters;

            Power += PBonus;
            Toughness += TBonus;

            if (pOri != Power || tOri != Toughness)
            {
                callCountersChanged(0);
            }
        }

        public void setMana()
        {
            manaCost.Clear();
            foreach (char c in Cost)
            {
                # region colourless
                if (char.IsNumber(c))
                {
                    manaCost.grey += (int)char.GetNumericValue(c);
                }
                # endregion
                # region basic mana types
                else
                {
                    switch (c)
                    {
                        case 'U':
                            manaCost.blue++;
                            break;

                        case 'R':
                            manaCost.red++;
                            break;

                        case 'G':
                            manaCost.green++;
                            break;

                        case 'W':
                            manaCost.white++;
                            break;

                        case 'B':
                            manaCost.black++;
                            break;

                        case 'X':
                            manaCost.grey += Xvalue;
                            break;
                    }
                }
                # endregion
            }
        }

        public void ParseText()
        {
            Abilities.Clear();

            List<string> groups = Text.Split(new string[] { "\r", "\n" }, StringSplitOptions.None).ToList();

            # region search for costs ":"
            foreach (string s in groups)
            {
                int i = s.IndexOf(':');

                if (s.Contains(':'))
                {
                    List<string> cost = s.Split(':').ToList();
                    CardAbility abi = new CardAbility();
                    abi.RawCost = cost[0];
                    abi.Text = cost[1];
                    Abilities.Add(abi);
                }

                if (s.Contains("Bestow"))
                {
                    string[] tCost = Text.Split('(');
                    CardAbility abi = new CardAbility();
                    abi.RawCost = tCost[0].Replace("Bestow ", "");
                    abi.Text = tCost[1].Trim();
                    abi.Name = "Bestow";
                    Abilities.Add(abi);
                }
            }
            # endregion

            int e = Text.IndexOf("Equip");
            if (e > -1)
            {
                e += 6;
                int len = Text.Length - e;
                string c = Text.Substring(e, len);
                Debug.WriteLine("Equip cost is {0}", c);

                CardAbility Abi = new CardAbility
                {
                    Text = "Equip " + c,
                    RawCost = c,
                    Name = "Equip",
                };
                Abilities.Add(Abi);
            }
        }

        public void AttachCard(MagicCard mc)
        {
            attachedCards.Add(mc);
            callAuraAdded(mc);
            mc.Parent = this;
        }

        # region Image get/set
        public void set(string im)
        {
            if (!File.Exists(im))
            {

            }
            else
            {
                imgLoc = SplitString.convertTo(im);
            }
        }

        public Image get()
        {
            Image img = null;

            string net = SplitString.convertFrom(imgLoc);

            if (net != "" && File.Exists(net)) { img = Image.FromFile(net); }
            else
            {
                img = Properties.Resources.mr224_back;
            }

            return img;
        }
        # endregion

        # region card actions
        public void UntapStep()
        {
            Sick = false;
            if (Tapped)
            {
                Tap(false, false);
            }
        }

        public virtual void UpkeepCard()
        {
            callOnUpkeep();
            switch (Name)
            {
                case "Primordial Hydra":
                    counters += counters;
                    break;

                case "Goblin Assault":
                    MagicCard mct = new MagicCard
                    {
                        Token = true,
                        Name = "Goblin",
                        Color = "Red",
                        Type = "Creature - Goblin",
                        Text = "Haste",
                        PT = "1/1",
                    };
                    mct.PArea = PArea;
                    mct.OppArea = OppArea;

                    PArea.PlayToken(mct);
                    break;
            }
        }

        public void EndStepCard()
        {
            if (Name == "Protean Hydra")
            {
                counters += countersTurn * 2;
                countersTurn = 0;
            }

            PBonus = 0;
            TBonus = 0;
        }

        public void ChangeTap()
        {
            Tapped = !Tapped;
        }

        # region equipment
        public void AddEquipment(MagicCard mc)
        {
            attachedCards.Add(mc);
            mc.Parent = this;
            callOnEquipmentAdd();
            mc.OnEquip += new PassiveEvent(RemoveEquipment);
        }

        public void RemoveEquipment(MagicCard mc)
        {
            attachedCards.Remove(mc);
            mc.callOnUnequip();

            if (mc.Parent == this)
            {
                mc.Parent = null;
            }

            callOnEquipmentRemoved(mc);
            mc.onEquipmentRemoved -= RemoveEquipment;
        }
        # endregion

        internal void Resolve()
        {
            callResolving();
        }

        public void Tap(bool value, bool silent)
        {
            if (Tapped != value)
            {
                if (silent)
                {
                    _Tapped = value;
                }
                else
                {
                    Tapped = value;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">The index of the ability to try (0 base)</param>
        /// <returns>Whether the ability can activate</returns>
        public bool TryActivate(int i)
        {
            ParseText();

            bool result = false;

            if (Abilities.Count > i)
            {
                result = true;
            }

            callActivating(i);

            return result;
        }

        public virtual void Evolve(int p, int t)
        {
            checkPT();

            if (Text.Contains("Evolve"))
            {
                if (p > Power || t > Toughness)
                {
                    counters++;
                    callEvolve();
                }
            }
        }

        public virtual void Attack()
        {
            callOnAttack();
        }

        /// <summary>
        /// Returns a string list of all the enchancements that the card provides when attached
        /// </summary>
        /// <returns>The enhancements it provides when attached to another card</returns>
        public List<string> getStats()
        {
            List<string> result = new List<string>();

            switch (Name)
            {
                case "Rancor":
                    result.Add("Power#2");
                    result.Add("Toughness#0");
                    result.Add("Ability#Trample");
                    break;

                case "Mogis's Warhound":
                    result.Add("Power#2");
                    result.Add("Toughness#2");
                    result.Add("Ability#Must Attack");
                    break;

                case "Favor of the Overbeing":
                    if (Parent.Cost.Contains("U"))
                    {
                        result.Add("Power#1");
                        result.Add("Toughness#1");
                        result.Add("Ability#Flying");
                    }
                    if (Parent.Cost.Contains("G"))
                    {
                        result.Add("Power#1");
                        result.Add("Toughness#1");
                        result.Add("Ability#Vigilance");
                    }
                    break;

                case "Hopeful Eidolon":
                    result.Add("Power#1");
                    result.Add("Toughness#1");
                    result.Add("Ability#Lifelink");
                    break;

                case "Eidolon of Countless Battles":
                    result.Add("Power#" + PArea._play.cards.Count);
                    result.Add("Toughness#" + PArea._play.cards.Count);
                    break;

                case "Nimbus Wings":
                    result.Add("Power#1");
                    result.Add("Toughness#1");
                    result.Add("Ability#Flying");
                    break;

                case "Nyxborn Rollicker":
                    result.Add("Power#1");
                    result.Add("Toughness#1");
                    break;

                case "Inferno Fist":
                    result.Add("Power#2");
                    break;

                case "Hammerhand":
                    result.Add("Power#1");
                    result.Add("Toughness#1");
                    break;

                case "Flamespeaker's Will":
                    result.Add("Power#1");
                    result.Add("Toughness#1");
                    break;

                case "Madcap Skills":
                    result.Add("Power#3");
                    result.Add("Ability#Can only be blocked by two or more creatures");
                    break;
            }

            return result;
        }
        # endregion

        # region triggers
        public virtual void LifeChanged(int i)
        {
            if (i > 0)
            {
                //hp increase
                if (Name == "Ajani's Pridemate")
                {
                    counters++;
                }
            }
            else if (i < 0)
            {
                //hp decrease

            }
            else
            {
                //no change

            }
        }

        public virtual void SpellResolved(MagicCard mc)
        {
            switch (Name)
            {
                case "Young Pyromancer":
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
                    break;

                case "Guttersnipe":
                    if (mc.Type.Contains("Instant") || mc.Type.Contains("Sorcery"))
                    {
                        callPingOpponent(2);
                    }
                    break;
            }
        }

        public virtual void CreatureEnteredPlay(MagicCard mc)
        {

        }
        # endregion

        public override string ToString()
        {
            return Name + " " + quantity;
        }

        # region toListViewItem
        public ListViewItem toListViewItem()
        {
            ListViewItem result = new ListViewItem(Name);
            if (Token)
            {
                result.Name += " (" + quantity + ")";
            }
            result.ImageKey = Name.ToUpper();

            result.SubItems.Add(quantity.ToString());
            result.SubItems.Add(Edition);
            result.SubItems.Add(Rarity);
            result.SubItems.Add(Color);
            result.SubItems.Add(Cost);
            result.SubItems.Add(PT);
            result.SubItems.Add(Type);
            result.SubItems.Add(Text);
            result.SubItems.Add(Flavor);

            return result;
        }

        public ListViewItem toListViewItem(bool alt)
        {
            if (Token)
            {
                alt = Token;
            }
            ListViewItem result;
            if (alt)
            {
                checkPT();
                result = new ListViewItem(Name + " (" + Power.ToString() + "/" + Toughness.ToString() + ")" + " (" + counters.ToString() + ")");
            }
            else
            {
                result = new ListViewItem(Name + " (" + quantity.ToString() + ")");
            }

            result.ImageKey = Name.ToUpper();

            result.SubItems.Add(quantity.ToString());
            result.SubItems.Add(Edition);
            result.SubItems.Add(Rarity);
            result.SubItems.Add(Color);
            result.SubItems.Add(Cost);
            result.SubItems.Add(PT);
            result.SubItems.Add(Type);
            result.SubItems.Add(Text);
            result.SubItems.Add(Flavor);

            return result;
        }
        # endregion

        # region cloning/copying/comparing
        public object Clone() { return this.MemberwiseClone(); }

        public MagicCard Copy()
        {
            return Clone() as MagicCard;
        }

        public bool CompareCard(MagicCard card)
        {
            bool result = true;
            checkPT();

            if (Name != card.Name) { result = false; }
            //if (Edition != card.Edition) { result = false; }
            //if (Rarity != card.Rarity) { result = false; }
            //if (Color != card.Color) { result = false; }
            //if (Cost != card.Cost) { result = false; }
            //if (PT != card.PT) { result = false; }
            //if (Type != card.Type) { result = false; }
            //if (Text != card.Text) { result = false; }
            //if (Flavor != card.Flavor) { result = false; }

            if (Power != card.Power) { result = false; }
            if (Toughness != card.Toughness) { result = false; }
            if (Tapped != card.Tapped) { result = false; }
            if (attachedCards.Count > 0 || card.attachedCards.Count > 0) { result = false; }
            if (counters != card.counters) { result = false; }

            return result;
        }
        # endregion
        # endregion
    }

    public class MRUList
    {
        [XmlElement("mru")]
        public List<string> _docs = new List<string>();

        public void add(string s)
        {
            List<string> temp = new List<string>();
            string netPath = SplitString.convertTo(s);

            if (_docs.Contains(netPath))
            {
                int i = _docs.IndexOf(netPath);
                _docs.RemoveAt(i);          //remove string from old list.
            }

            temp.Add(netPath);                    //add string to first position.

            foreach (string old in _docs)
                temp.Add(old);

            _docs = temp;                   //confirm changes.            
        }

        public List<string> get()
        {
            return _docs;
        }

        public string get(int i)
        {
            string result = "";

            if (-1 < i && i < _docs.Count)  //i is between 0 & last entry
                result = _docs[i];

            result = SplitString.convertTo(result);

            return result;
        }
    }

    public class SplitString
    {
        public static string[] splitSafe(string s, char Seperator, char Qualifier)
        {
            string[] result;
            bool Text = false;
            List<string> arrTemp = new List<string>();

            //add initial placeholder
            arrTemp.Add("");

            for (int i = 0; i < s.Length; i++)
            {
                char temp = s[i];

                if (temp == Seperator && !Text) { arrTemp.Add(""); }    //start new string

                else
                {
                    if (temp == Qualifier) { Text = !Text; }

                    else { arrTemp[arrTemp.Count - 1] += temp; }
                }
            }

            result = new string[arrTemp.Count];

            arrTemp.CopyTo(result);

            return result;
        }

        public static List<string[]> split_number(string[] s, int count)
        {
            List<string[]> result = new List<string[]>();

            string[] temp = new string[count];
            int j = 0;


            for (int i = 0; i < s.Length; i++)
            {
                if (j == count)
                {
                    result.Add(temp);
                    temp = new string[count];
                    j = 0;
                }

                temp[j] = s[i];
                j++;
            }

            return result;
        }

        public static ColourCost textToMana(string cost)
        {
            ColourCost result = new ColourCost();

            int t = cost.IndexOf('{');

            string trimmed = cost.Substring(t, cost.Length - t);
            trimmed = trimmed.Replace("{", "").Replace("}", "");

            foreach (char c in trimmed)
            {
                # region numbers
                if (char.IsNumber(c))
                {
                    int n = 0;
                    int.TryParse(c.ToString(), out n);
                    result.grey += n;
                }
                # endregion
                # region colours
                else
                {
                    switch (c)
                    {
                        case 'B':
                            result.black++;
                            break;

                        case 'G':
                            result.green++;
                            break;

                        case 'R':
                            result.red++;
                            break;

                        case 'U':
                            result.blue++;
                            break;

                        case 'W':
                            result.white++;
                            break;

                        default:
                            break;
                    }
                }
                # endregion
            }

            return result;
        }

        # region convert paths to/from relative
        public static string convertTo(string s)
        {
            string result = s;
            string userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            s = s.Replace(userDir, "~");

            return s;
        }

        public static string convertFrom(string s)
        {
            string result = s;
            string userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            s = s.Replace("~", userDir);

            return s;
        }
        # endregion
    }

    public static class Output
    {
        public static Stopwatch sw = new Stopwatch();

        public static void Write(string s, params object[] args)
        {
            string result = s;

            int c = args.Length;

            for (int i = 0; i < c; i++)
            {
                result = result.Replace("{" + i + "}", args[i].ToString());
            }
        }
    }

    public class MagicImage
    {
        # region set up colours
        private static Image white = Properties.Resources.W;
        private static Image red = Properties.Resources.R;
        private static Image blue = Properties.Resources.U;
        private static Image green = Properties.Resources.G;
        private static Image black = Properties.Resources.B;

        private static Image zero = Properties.Resources._0;
        private static Image one = Properties.Resources._1;
        private static Image two = Properties.Resources._2;
        private static Image three = Properties.Resources._3;
        private static Image four = Properties.Resources._4;
        private static Image five = Properties.Resources._5;
        private static Image six = Properties.Resources._6;
        private static Image seven = Properties.Resources._7;
        private static Image _X = Properties.Resources.X;
        # endregion

        public static Image FromString(string s)
        {
            if (s.Length <= 0)
            {
                return null;
            }

            string adjusted = s.Replace("%", "").ToUpper();

            int x = adjusted.Length * 16;
            Image result = new Bitmap(x, 16);   //16x16 for each character


            using (Graphics g = Graphics.FromImage(result))
            {
                for (int i = 0; i < adjusted.Length; i++)
                {
                    Rectangle rect = new Rectangle(i * 16, 0, 16, 16);

                    Char c = adjusted[i];

                    # region switch (c)
                    switch (c)
                    {
                        # region base mana
                        case 'U':
                            g.DrawImage(blue, rect);
                            break;

                        case 'B':
                            g.DrawImage(black, rect);
                            break;

                        case 'R':
                            g.DrawImage(red, rect);
                            break;

                        case 'W':
                            g.DrawImage(white, rect);
                            break;

                        case 'G':
                            g.DrawImage(green, rect);
                            break;
                        # endregion

                        # region hybrid
                        case 'P':
                            g.DrawImage(Properties.Resources.P, rect);
                            break;

                        case 'A':
                            g.DrawImage(Properties.Resources.A, rect);
                            break;

                        case 'L':
                            g.DrawImage(Properties.Resources.L, rect);
                            break;

                        case 'D':
                            g.DrawImage(Properties.Resources.D, rect);
                            break;

                        case 'O':
                            g.DrawImage(Properties.Resources.O, rect);
                            break;

                        case 'Q':
                            g.DrawImage(Properties.Resources.Q, rect);
                            break;

                        case 'V':
                            g.DrawImage(Properties.Resources.V, rect);
                            break;

                        case 'S':
                            g.DrawImage(Properties.Resources.S, rect);
                            break;

                        case 'K':
                            g.DrawImage(Properties.Resources.K, rect);
                            break;

                        case 'I':
                            g.DrawImage(Properties.Resources.I, rect);
                            break;
                        # endregion

                        # region numbers
                        case '0':
                            g.DrawImage(zero, rect);
                            break;

                        case '1':
                            g.DrawImage(one, rect);
                            break;

                        case '2':
                            g.DrawImage(two, rect);
                            break;

                        case '3':
                            g.DrawImage(three, rect);
                            break;

                        case '4':
                            g.DrawImage(four, rect);
                            break;

                        case '5':
                            g.DrawImage(five, rect);
                            break;

                        case '6':
                            g.DrawImage(six, rect);
                            break;

                        case '7':
                            g.DrawImage(seven, rect);
                            break;

                        case '8':
                            g.DrawString(c.ToString(), new Font("WingDings 2", 11, FontStyle.Regular), new SolidBrush(Color.Gray), rect);
                            break;

                        case '9':
                            g.DrawString(c.ToString(), new Font("WingDings 2", 11, FontStyle.Regular), new SolidBrush(Color.Gray), rect);
                            break;

                        case 'X':
                            g.DrawImage(_X, rect);
                            break;
                        # endregion

                        default:
                            Output.Write("Invalid Character {0}", c);
                            break;
                    }
                    # endregion
                }
            }

            Output.Write("{0}, {1}", result.Width, result.Height);

            return result;
        }
    }

    public class ColourCost
    {
        public delegate void Action();
        public event Action ManaChanged;

        protected void onManaChanged()
        {
            Action handler = ManaChanged;
            if (handler != null)
            {
                handler();
            }
        }

        # region mana
        # region internal values
        public int _blue = 0;
        public int _green = 0;
        public int _black = 0;
        public int _white = 0;
        public int _red = 0;
        public int _grey = 0;
        # endregion

        # region public values
        public int blue
        {
            get
            {
                return _blue;
            }
            set
            {
                _blue = value;
                onManaChanged();
            }
        }

        public int black
        {
            get
            {
                return _black;
            }
            set
            {
                _black = value;
                onManaChanged();
            }
        }

        public int green
        {
            get
            {
                return _green;
            }
            set
            {
                _green = value;
                onManaChanged();
            }
        }

        public int red
        {
            get
            {
                return _red;
            }
            set
            {
                _red = value;
                onManaChanged();
            }
        }

        public int white
        {
            get
            {
                return _white;
            }
            set
            {
                _white = value;
                onManaChanged();
            }
        }

        public int grey
        {
            get
            {
                return _grey;
            }
            set
            {
                _grey = value;
                onManaChanged();
            }
        }
        # endregion

        public int colourless
        {
            get
            {
                int i = blue + black + green + red + white + grey;

                return i;
            }
        }
        public int colours
        {
            get
            {
                return blue + green + black + red + white;
            }
        }
        # endregion

        public void Clear()
        {
            blue = 0;
            green = 0;
            black = 0;
            white = 0;
            red = 0;
            grey = 0;
        }

        public ColourCost()
        { }

        public ColourCost(string s)
        {
            ParseString(s);
        }

        public void ParseString(string s)
        {
            foreach (char c in s)
            {
                if (char.IsNumber(c))
                {
                    grey += int.Parse(c.ToString());
                }
                else
                {

                }
            }
        }

        # region Math
        public void Add(ColourCost cc)
        {
            blue += cc.blue;
            black += cc.black;
            green += cc.green;
            red += cc.red;
            white += cc.white;
            grey += cc.grey;
        }

        public void Add(string s)
        {
            ColourCost nc = new ColourCost();
            foreach (char c in s)
            {
                if (Char.IsNumber(c))
                {
                    nc.grey += int.Parse(c.ToString());
                    continue;
                }

                switch (c)
                {
                    case 'U':
                        nc.blue++;
                        break;

                    case 'G':
                        nc.green++;
                        break;

                    case 'W':
                        nc.white++;
                        break;

                    case 'R':
                        nc.red++;
                        break;

                    case 'B':
                        nc.black++;
                        break;

                    default:
                        Debug.WriteLine("unrecognised character {0}", c);
                        break;
                }
            }

            Add(nc);
        }

        public void Subtract(ColourCost cc)
        {
            _blue -= cc.blue;
            _black -= cc.black;
            _green -= cc.green;
            _red -= cc.red;
            _white -= cc.white;

            int cless = cc.grey;

            for (int i = 0; cless > 0 && _green > 0; i++)
            {
                cless--;
                _green--;
            }
            for (int i = 0; cless > 0 && _blue > 0; i++)
            {
                cless--;
                _blue--;
            }
            for (int i = 0; cless > 0 && _red > 0; i++)
            {
                cless--;
                _red--;
            }
            for (int i = 0; cless > 0 && _white > 0; i++)
            {
                cless--;
                _white--;
            }
            for (int i = 0; cless > 0 && _black > 0; i++)
            {
                cless--;
                _black--;
            }
        }

        public bool Compare(ColourCost cc)
        {
            bool result = true;

            if (cc.blue > blue) { result = false; }
            if (cc.black > black) { result = false; }
            if (cc.red > red) { result = false; }
            if (cc.green > green) { result = false; }
            if (cc.white > white) { result = false; }

            int g = colourless - cc.colours;

            if (cc.grey > g) { result = false; }

            return result;
        }

        public int CompareInt(ColourCost cc)
        {
            ColourCost result = MemberwiseClone() as ColourCost;

            cc.Subtract(cc);

            return result.colourless;
        }
        # endregion
    }

    public class CardMethods
    {
        public static List<MagicCard> SplitCardList(List<MagicCard> List)
        {
            List<MagicCard> results = new List<MagicCard>();

            foreach (MagicCard mc in List)
            {
                for (int i = 0; i < mc.quantity; i++)
                {
                    MagicCard nmc = mc.Copy();
                    nmc.quantity = 1;
                    results.Add(nmc);
                }
            }

            return results;
        }

        public static MagicCard GetClass(MagicCard mc)
        {
            MagicCard mcn = GetClass(mc.Name);

            mcn.CopyCard(mc);

            return mcn;
        }

        public static MagicCard GetClass(string s)
        {
            MagicCard mcn;
            switch (s)
            {
                # region Born of the Gods
                case "Acolyte's Reward":
                    mcn = new AcolytesReward();
                    break;

                case "Aerie Worshippers":
                    mcn = new AerieWorshippers();
                    break;

                case "Akroan Conscriptor":
                    mcn = new AkroanConscriptor();
                    break;

                case "Akroan Phalanx":
                    mcn = new AkroanPhalanx();
                    break;

                case "Akroan Skyguard":
                    mcn = new AkroanSkyguard();
                    break;

                case "Arbiter of the Ideal":
                    mcn = new ArbiteroftheIdeal();
                    break;

                case "Archetype of Aggression":
                    mcn = new ArchetypeofAggression();
                    break;

                case "Archetype of Courage":
                    mcn = new ArchetypeofCourage();
                    break;

                case "Archetype of Endurance":
                    mcn = new ArchetypeofEndurance();
                    break;

                case "Archetype of Finality":
                    mcn = new ArchetypeofFinality();
                    break;

                case "Archetype of Imagination":
                    mcn = new ArchetypeofImagination();
                    break;

                case "Ashiok's Adept":
                    mcn = new AshioksAdept();
                    break;

                case "Aspect of Hydra":
                    mcn = new AspectofHydra();
                    break;

                case "Asphyxiate":
                    mcn = new Asphyxiate();
                    break;

                case "Astral Cornucopia":
                    mcn = new AstralCornucopia();
                    break;

                case "Bile Blight":
                    mcn = new BileBlight();
                    break;

                case "Black Oak of Odunos":
                    mcn = new BlackOakofOdunos();
                    break;

                case "Bolt of Keranos":
                    mcn = new BoltofKeranos();
                    break;

                case "Brimaz, King of Oreskos":
                    mcn = new BrimazKingofOreskos();
                    break;

                case "Champion of Stray Souls":
                    mcn = new ChampionofStraySouls();
                    break;

                case "Charging Badger":
                    mcn = new ChargingBadger();
                    break;

                case "Chorus of the Tides":
                    mcn = new ChorusoftheTides();
                    break;

                case "Chromanticore":
                    mcn = new Chromanticore();
                    break;

                case "Claim of Erebos":
                    mcn = new ClaimofErebos();
                    break;

                case "Courser of Kruphix":
                    mcn = new CourserofKruphix();
                    break;

                case "Crypsis":
                    mcn = new Crypsis();
                    break;

                case "Culling Mark":
                    mcn = new CullingMark();
                    break;

                case "Cyclops of One-Eyed Pass":
                    mcn = new CyclopsofOneEyedPass();
                    break;

                case "Dawn to Dusk":
                    mcn = new DawntoDusk();
                    break;

                case "Deepwater Hypnotist":
                    mcn = new DeepwaterHypnotist();
                    break;

                case "Divination":
                    mcn = new Divination();
                    break;

                case "Drown in Sorrow":
                    mcn = new DrowninSorrow();
                    break;

                case "Eater of Hope":
                    mcn = new EaterofHope();
                    break;

                case "Eidolon of Countless Battles":
                    mcn = new EidolonofCountlessBattles();
                    break;

                case "Elite Skirmisher":
                    mcn = new EliteSkirmisher();
                    break;

                case "Ephara, God of the Polis":
                    mcn = new EpharaGodofthePolis();
                    break;

                case "Ephara's Enlightenment":
                    mcn = new EpharasEnlightenment();
                    break;

                case "Ephara's Radiance":
                    mcn = new EpharasRadiance();
                    break;

                case "Epiphany Storm":
                    mcn = new EpiphanyStorm();
                    break;

                case "Eternity Snare":
                    mcn = new EternitySnare();
                    break;

                case "Evanescent Intellect":
                    mcn = new EvanescentIntellect();
                    break;

                case "Everflame Eidolon":
                    mcn = new EverflameEidolon();
                    break;

                case "Excoriate":
                    mcn = new Excoriate();
                    break;

                case "Eye Gouge":
                    mcn = new EyeGouge();
                    break;

                case "Fall of the Hammer":
                    mcn = new FalloftheHammer();
                    break;

                case "Fanatic of Xenagos":
                    mcn = new FanaticofXenagos();
                    break;

                case "Fate Unraveler":
                    mcn = new FateUnraveler();
                    break;

                case "Fated Conflagration":
                    mcn = new FatedConflagration();
                    break;

                case "Fated Infatuation":
                    mcn = new FatedInfatuation();
                    break;

                case "Fated Intervention":
                    mcn = new FatedIntervention();
                    break;

                case "Fated Retribution":
                    mcn = new FatedRetribution();
                    break;

                case "Fated Return":
                    mcn = new FatedReturn();
                    break;

                case "Fearsome Temper":
                    mcn = new FearsomeTemper();
                    break;

                case "Felhide Brawler":
                    mcn = new FelhideBrawler();
                    break;

                case "Felhide Spiritbinder":
                    mcn = new FelhideSpiritbinder();
                    break;

                case "Flame-Wreathed Phoenix":
                    mcn = new FlameWreathedPhoenix();
                    break;

                case "Flitterstep Eidolon":
                    mcn = new FlitterstepEidolon();
                    break;

                case "Floodtide Serpent":
                    mcn = new FloodtideSerpent();
                    break;

                case "Forgestoker Dragon":
                    mcn = new ForgestokerDragon();
                    break;

                case "Forlorn Pseudamma":
                    mcn = new ForlornPseudamma();
                    break;

                case "Forsaken Drifters":
                    mcn = new ForsakenDrifters();
                    break;

                case "Ghostblade Eidolon":
                    mcn = new GhostbladeEidolon();
                    break;

                case "Gild":
                    mcn = new Gild();
                    break;

                case "Glimpse the Sun God":
                    mcn = new GlimpsetheSunGod();
                    break;

                case "God-Favored General":
                    mcn = new GodFavoredGeneral();
                    break;

                case "Gorgon's Head":
                    mcn = new GorgonsHead();
                    break;

                case "Graverobber Spider":
                    mcn = new GraverobberSpider();
                    break;

                case "Great Hart":
                    mcn = new GreatHart();
                    break;

                case "Griffin Dreamfinder":
                    mcn = new GriffinDreamfinder();
                    break;

                case "Grisly Transformation":
                    mcn = new GrislyTransformation();
                    break;

                case "Herald of Torment":
                    mcn = new HeraldofTorment();
                    break;

                case "Hero of Iroas":
                    mcn = new HeroofIroas();
                    break;

                case "Hero of Leina Tower":
                    mcn = new HeroofLeinaTower();
                    break;

                case "Heroes' Podium":
                    mcn = new HeroesPodium();
                    break;

                case "Hold at Bay":
                    mcn = new HoldatBay();
                    break;

                case "Hunter's Prowess":
                    mcn = new HuntersProwess();
                    break;

                case "Impetuous Sunchaser":
                    mcn = new ImpetuousSunchaser();
                    break;

                case "Karametra, God of Harvests":
                    mcn = new KarametraGodofHarvests();
                    break;

                case "Karametra's Favor":
                    mcn = new KarametrasFavor();
                    break;

                case "Kiora, the Crashing Wave":
                    mcn = new KioratheCrashingWave();
                    break;

                case "Kiora's Follower":
                    mcn = new KiorasFollower();
                    break;

                case "Kragma Butcher":
                    mcn = new KragmaButcher();
                    break;

                case "Kraken of the Straits":
                    mcn = new KrakenoftheStraits();
                    break;

                case "Lightning Volley":
                    mcn = new LightningVolley();
                    break;

                case "Loyal Pegasus":
                    mcn = new LoyalPegasus();
                    break;

                case "Marshmist Titan":
                    mcn = new MarshmistTitan();
                    break;

                case "Meletis Astronomer":
                    mcn = new MeletisAstronomer();
                    break;

                case "Mindreaver":
                    mcn = new Mindreaver();
                    break;

                case "Mischief and Mayhem":
                    mcn = new MischiefandMayhem();
                    break;

                case "Mogis, God of Slaughter":
                    mcn = new MogisGodofSlaughter();
                    break;

                case "Mortal's Ardor":
                    mcn = new MortalsArdor();
                    break;

                case "Mortal's Resolve":
                    mcn = new MortalsResolve();
                    break;

                case "Necrobite":
                    mcn = new Necrobite();
                    break;

                case "Nessian Demolok":
                    mcn = new NessianDemolok();
                    break;

                case "Nessian Wilds Ravager":
                    mcn = new NessianWildsRavager();
                    break;

                case "Noble Quarry":
                    mcn = new NobleQuarry();
                    break;

                case "Nullify":
                    mcn = new Nullify();
                    break;

                case "Nyxborn Eidolon":
                    mcn = new NyxbornEidolon();
                    break;

                case "Nyxborn Rollicker":
                    mcn = new NyxbornRollicker();
                    break;

                case "Nyxborn Shieldmate":
                    mcn = new NyxbornShieldmate();
                    break;

                case "Nyxborn Triton":
                    mcn = new NyxbornTriton();
                    break;

                case "Nyxborn Wolf":
                    mcn = new NyxbornWolf();
                    break;

                case "Odunos River Trawler":
                    mcn = new OdunosRiverTrawler();
                    break;

                case "Oracle of Bones":
                    mcn = new OracleofBones();
                    break;

                case "Oracle's Insight":
                    mcn = new OraclesInsight();
                    break;

                case "Oreskos Sun Guide":
                    mcn = new OreskosSunGuide();
                    break;

                case "Ornitharch":
                    mcn = new Ornitharch();
                    break;

                case "Pain Seer":
                    mcn = new PainSeer();
                    break;

                case "Peregrination":
                    mcn = new Peregrination();
                    break;

                case "Perplexing Chimera":
                    mcn = new PerplexingChimera();
                    break;

                case "Pharagax Giant":
                    mcn = new PharagaxGiant();
                    break;

                case "Phenax, God of Deception":
                    mcn = new PhenaxGodofDeception();
                    break;

                case "Pheres-Band Raiders":
                    mcn = new PheresBandRaiders();
                    break;

                case "Pheres-Band Tromper":
                    mcn = new PheresBandTromper();
                    break;

                case "Pillar of War":
                    mcn = new PillarofWar();
                    break;

                case "Pinnacle of Rage":
                    mcn = new PinnacleofRage();
                    break;

                case "Plea for Guidance":
                    mcn = new PleaforGuidance();
                    break;

                case "Ragemonger":
                    mcn = new Ragemonger();
                    break;

                case "Raised by Wolves":
                    mcn = new RaisedbyWolves();
                    break;

                case "Reap What Is Sown":
                    mcn = new ReapWhatIsSown();
                    break;

                case "Reckless Reveler":
                    mcn = new RecklessReveler();
                    break;

                case "Retraction Helix":
                    mcn = new RetractionHelix();
                    break;

                case "Revoke Existence":
                    mcn = new RevokeExistence();
                    break;

                case "Rise to the Challenge":
                    mcn = new RisetotheChallenge();
                    break;

                case "Sanguimancy":
                    mcn = new Sanguimancy();
                    break;

                case "Satyr Firedancer":
                    mcn = new SatyrFiredancer();
                    break;

                case "Satyr Nyx-Smith":
                    mcn = new SatyrNyxSmith();
                    break;

                case "Satyr Wayfinder":
                    mcn = new SatyrWayfinder();
                    break;

                case "Scourge of Skola Vale":
                    mcn = new ScourgeofSkolaVale();
                    break;

                case "Scouring Sands":
                    mcn = new ScouringSands();
                    break;

                case "Searing Blood":
                    mcn = new SearingBlood();
                    break;

                case "Servant of Tymaret":
                    mcn = new ServantofTymaret();
                    break;

                case "Setessan Oathsworn":
                    mcn = new SetessanOathsworn();
                    break;

                case "Setessan Starbreaker":
                    mcn = new SetessanStarbreaker();
                    break;

                case "Shrike Harpy":
                    mcn = new ShrikeHarpy();
                    break;

                case "Silent Sentinel":
                    mcn = new SilentSentinel();
                    break;

                case "Siren of the Fanged Coast":
                    mcn = new SirenoftheFangedCoast();
                    break;

                case "Siren of the Silent Song":
                    mcn = new SirenoftheSilentSong();
                    break;

                case "Siren Song Lyre":
                    mcn = new SirenSongLyre();
                    break;

                case "Skyreaping":
                    mcn = new Skyreaping();
                    break;

                case "Snake of the Golden Grove":
                    mcn = new SnakeoftheGoldenGrove();
                    break;

                case "Sphinx's Disciple":
                    mcn = new SphinxsDisciple();
                    break;

                case "Spirit of the Labyrinth":
                    mcn = new SpiritoftheLabyrinth();
                    break;

                case "Spiteful Returned":
                    mcn = new SpitefulReturned();
                    break;

                case "Springleaf Drum":
                    mcn = new SpringleafDrum();
                    break;

                case "Stormcaller of Keranos":
                    mcn = new StormcallerofKeranos();
                    break;

                case "Stratus Walk":
                    mcn = new StratusWalk();
                    break;

                case "Sudden Storm":
                    mcn = new SuddenStorm();
                    break;

                case "Sunbond":
                    mcn = new Sunbond();
                    break;

                case "Swordwise Centaur":
                    mcn = new SwordwiseCentaur();
                    break;

                case "Temple of Enlightenment":
                    mcn = new TempleofEnlightenment();
                    break;

                case "Temple of Malice":
                    mcn = new TempleofMalice();
                    break;

                case "Temple of Plenty":
                    mcn = new TempleofPlenty();
                    break;

                case "Thassa's Rebuff":
                    mcn = new ThassasRebuff();
                    break;

                case "Thunder Brute":
                    mcn = new ThunderBrute();
                    break;

                case "Thunderous Might":
                    mcn = new ThunderousMight();
                    break;

                case "Tromokratis":
                    mcn = new Tromokratis();
                    break;

                case "Unravel the Æther":
                    mcn = new UnraveltheÆther();
                    break;

                case "Vanguard of Brimaz":
                    mcn = new VanguardofBrimaz();
                    break;

                case "Vortex Elemental":
                    mcn = new VortexElemental();
                    break;

                case "Warchanter of Mogis":
                    mcn = new WarchanterofMogis();
                    break;

                case "Weight of the Underworld":
                    mcn = new WeightoftheUnderworld();
                    break;

                case "Whelming Wave":
                    mcn = new WhelmingWave();
                    break;

                case "Whims of the Fates":
                    mcn = new WhimsoftheFates();
                    break;

                case "Xenagos, God of Revels":
                    mcn = new XenagosGodofRevels();
                    break;
                # endregion

                # region Journey into Nyx
                case "Aegis of the Gods":
                    mcn = new AegisoftheGods();
                    break;

                case "Aerial Formation":
                    mcn = new AerialFormation();
                    break;

                case "Agent of Erebos":
                    mcn = new AgentofErebos();
                    break;

                case "Ajani, Mentor of Heroes":
                    mcn = new AjaniMentorofHeroes();
                    break;

                case "Ajani's Presence":
                    mcn = new AjanisPresence();
                    break;

                case "Akroan Line Breaker":
                    mcn = new AkroanLineBreaker();
                    break;

                case "Akroan Mastiff":
                    mcn = new AkroanMastiff();
                    break;

                case "Armament of Nyx":
                    mcn = new ArmamentofNyx();
                    break;

                case "Armory of Iroas":
                    mcn = new ArmoryofIroas();
                    break;

                case "Aspect of Gorgon":
                    mcn = new AspectofGorgon();
                    break;

                case "Athreos, God of Passage":
                    mcn = new AthreosGodofPassage();
                    break;

                case "Banishing Light":
                    mcn = new BanishingLight();
                    break;

                case "Bassara Tower Archer":
                    mcn = new BassaraTowerArcher();
                    break;

                case "Battlefield Thaumaturge":
                    mcn = new BattlefieldThaumaturge();
                    break;

                case "Bearer of the Heavens":
                    mcn = new BeareroftheHeavens();
                    break;

                case "Bladetusk Boar":
                    mcn = new BladetuskBoar();
                    break;

                case "Blinding Flare":
                    mcn = new BlindingFlare();
                    break;

                case "Bloodcrazed Hoplite":
                    mcn = new BloodcrazedHoplite();
                    break;

                case "Brain Maggot":
                    mcn = new BrainMaggot();
                    break;

                case "Cast into Darkness":
                    mcn = new CastintoDarkness();
                    break;

                case "Chariot of Victory":
                    mcn = new ChariotofVictory();
                    break;

                case "Cloaked Siren":
                    mcn = new CloakedSiren();
                    break;

                case "Colossal Heroics":
                    mcn = new ColossalHeroics();
                    break;

                case "Consign to Dust":
                    mcn = new ConsigntoDust();
                    break;

                case "Countermand":
                    mcn = new Countermand();
                    break;

                case "Cruel Feeding":
                    mcn = new CruelFeeding();
                    break;

                case "Crystalline Nautilus":
                    mcn = new CrystallineNautilus();
                    break;

                case "Cyclops of Eternal Fury":
                    mcn = new CyclopsofEternalFury();
                    break;

                case "Dakra Mystic":
                    mcn = new DakraMystic();
                    break;

                case "Daring Thief":
                    mcn = new DaringThief();
                    break;

                case "Dawnbringer Charioteers":
                    mcn = new DawnbringerCharioteers();
                    break;

                case "Deicide":
                    mcn = new Deicide();
                    break;

                case "Desecration Plague":
                    mcn = new DesecrationPlague();
                    break;

                case "Deserter's Quarters":
                    mcn = new DesertersQuarters();
                    break;

                case "Desperate Stand":
                    mcn = new DesperateStand();
                    break;

                case "Dictate of Erebos":
                    mcn = new DictateofErebos();
                    break;

                case "Dictate of Heliod":
                    mcn = new DictateofHeliod();
                    break;

                case "Dictate of Karametra":
                    mcn = new DictateofKarametra();
                    break;

                case "Dictate of Kruphix":
                    mcn = new DictateofKruphix();
                    break;

                case "Dictate of the Twin Gods":
                    mcn = new DictateoftheTwinGods();
                    break;

                case "Disciple of Deceit":
                    mcn = new DiscipleofDeceit();
                    break;

                case "Doomwake Giant":
                    mcn = new DoomwakeGiant();
                    break;

                case "Dreadbringer Lampads":
                    mcn = new DreadbringerLampads();
                    break;

                case "Eagle of the Watch":
                    mcn = new EagleoftheWatch();
                    break;

                case "Eidolon of Blossoms":
                    mcn = new EidolonofBlossoms();
                    break;

                case "Eidolon of Rhetoric":
                    mcn = new EidolonofRhetoric();
                    break;

                case "Eidolon of the Great Revel":
                    mcn = new EidolonoftheGreatRevel();
                    break;

                case "Extinguish All Hope":
                    mcn = new ExtinguishAllHope();
                    break;

                case "Feast of Dreams":
                    mcn = new FeastofDreams();
                    break;

                case "Felhide Petrifier":
                    mcn = new FelhidePetrifier();
                    break;

                case "Flamespeaker's Will":
                    mcn = new FlamespeakersWill();
                    break;

                case "Fleetfeather Cockatrice":
                    mcn = new FleetfeatherCockatrice();
                    break;

                case "Flurry of Horns":
                    mcn = new FlurryofHorns();
                    break;

                case "Font of Fertility":
                    mcn = new FontofFertility();
                    break;

                case "Font of Fortunes":
                    mcn = new FontofFortunes();
                    break;

                case "Font of Ire":
                    mcn = new FontofIre();
                    break;

                case "Font of Return":
                    mcn = new FontofReturn();
                    break;

                case "Font of Vigor":
                    mcn = new FontofVigor();
                    break;

                case "Forgeborn Oreads":
                    mcn = new ForgebornOreads();
                    break;

                case "Gluttonous Cyclops":
                    mcn = new GluttonousCyclops();
                    break;

                case "Gnarled Scarhide":
                    mcn = new GnarledScarhide();
                    break;

                case "Godhunter Octopus":
                    mcn = new GodhunterOctopus();
                    break;

                case "Godsend":
                    mcn = new Godsend();
                    break;

                case "Gold-Forged Sentinel":
                    mcn = new GoldForgedSentinel();
                    break;

                case "Golden Hind":
                    mcn = new GoldenHind();
                    break;

                case "Goldenhide Ox":
                    mcn = new GoldenhideOx();
                    break;

                case "Grim Guardian":
                    mcn = new GrimGuardian();
                    break;

                case "Hall of Triumph":
                    mcn = new HallofTriumph();
                    break;

                case "Harness by Force":
                    mcn = new HarnessbyForce();
                    break;

                case "Harvestguard Alseids":
                    mcn = new HarvestguardAlseids();
                    break;

                case "Heroes' Bane":
                    mcn = new HeroesBane();
                    break;

                case "Hour of Need":
                    mcn = new HourofNeed();
                    break;

                case "Hubris":
                    mcn = new Hubris();
                    break;

                case "Humbler of Mortals":
                    mcn = new HumblerofMortals();
                    break;

                case "Hydra Broodmaster":
                    mcn = new HydraBroodmaster();
                    break;

                case "Hypnotic Siren":
                    mcn = new HypnoticSiren();
                    break;

                case "Interpret the Signs":
                    mcn = new InterprettheSigns();
                    break;

                case "Iroas, God of Victory":
                    mcn = new IroasGodofVictory();
                    break;

                case "Keranos, God of Storms":
                    mcn = new KeranosGodofStorms();
                    break;

                case "King Macar, the Gold-Cursed":
                    mcn = new KingMacartheGoldCursed();
                    break;

                case "Kiora's Dismissal":
                    mcn = new KiorasDismissal();
                    break;

                case "Knowledge and Power":
                    mcn = new KnowledgeandPower();
                    break;

                case "Kruphix, God of Horizons":
                    mcn = new KruphixGodofHorizons();
                    break;

                case "Kruphix's Insight":
                    mcn = new KruphixsInsight();
                    break;

                case "Lagonna-Band Trailblazer":
                    mcn = new LagonnaBandTrailblazer();
                    break;

                case "Launch the Fleet":
                    mcn = new LaunchtheFleet();
                    break;

                case "Leonin Iconoclast":
                    mcn = new LeoninIconoclast();
                    break;

                case "Lightning Diadem":
                    mcn = new LightningDiadem();
                    break;

                case "Magma Spray":
                    mcn = new MagmaSpray();
                    break;

                case "Mana Confluence":
                    mcn = new ManaConfluence();
                    break;

                case "Market Festival":
                    mcn = new MarketFestival();
                    break;

                case "Master of the Feast":
                    mcn = new MasteroftheFeast();
                    break;

                case "Mogis's Warhound":
                    mcn = new MogissWarhound();
                    break;

                case "Mortal Obstinacy":
                    mcn = new MortalObstinacy();
                    break;

                case "Nature's Panoply":
                    mcn = new NaturesPanoply();
                    break;

                case "Nessian Game Warden":
                    mcn = new NessianGameWarden();
                    break;

                case "Nightmarish End":
                    mcn = new NightmarishEnd();
                    break;

                case "Nyx Infusion":
                    mcn = new NyxInfusion();
                    break;

                case "Nyx Weaver":
                    mcn = new NyxWeaver();
                    break;

                case "Nyx-Fleece Ram":
                    mcn = new NyxFleeceRam();
                    break;

                case "Oakheart Dryads":
                    mcn = new OakheartDryads();
                    break;

                case "Oppressive Rays":
                    mcn = new OppressiveRays();
                    break;

                case "Oreskos Swiftclaw":
                    mcn = new OreskosSwiftclaw();
                    break;

                case "Pensive Minotaur":
                    mcn = new PensiveMinotaur();
                    break;

                case "Phalanx Formation":
                    mcn = new PhalanxFormation();
                    break;

                case "Pharika, God of Affliction":
                    mcn = new PharikaGodofAffliction();
                    break;

                case "Pharika's Chosen":
                    mcn = new PharikasChosen();
                    break;

                case "Pheres-Band Thunderhoof":
                    mcn = new PheresBandThunderhoof();
                    break;

                case "Pheres-Band Warchief":
                    mcn = new PheresBandWarchief();
                    break;

                case "Pin to the Earth":
                    mcn = new PintotheEarth();
                    break;

                case "Polymorphous Rush":
                    mcn = new PolymorphousRush();
                    break;

                case "Prophetic Flamespeaker":
                    mcn = new PropheticFlamespeaker();
                    break;

                case "Pull from the Deep":
                    mcn = new PullfromtheDeep();
                    break;

                case "Quarry Colossus":
                    mcn = new QuarryColossus();
                    break;

                case "Ravenous Leucrocota":
                    mcn = new RavenousLeucrocota();
                    break;

                case "Renowned Weaver":
                    mcn = new RenownedWeaver();
                    break;

                case "Reprisal":
                    mcn = new Reprisal();
                    break;

                case "Returned Reveler":
                    mcn = new ReturnedReveler();
                    break;

                case "Revel of the Fallen God":
                    mcn = new ReveloftheFallenGod();
                    break;

                case "Reviving Melody":
                    mcn = new RevivingMelody();
                    break;

                case "Riddle of Lightning":
                    mcn = new RiddleofLightning();
                    break;

                case "Riptide Chimera":
                    mcn = new RiptideChimera();
                    break;

                case "Rise of Eagles":
                    mcn = new RiseofEagles();
                    break;

                case "Ritual of the Returned":
                    mcn = new RitualoftheReturned();
                    break;

                case "Rollick of Abandon":
                    mcn = new RollickofAbandon();
                    break;

                case "Rotted Hulk":
                    mcn = new RottedHulk();
                    break;

                case "Rouse the Mob":
                    mcn = new RousetheMob();
                    break;

                case "Sage of Hours":
                    mcn = new SageofHours();
                    break;

                case "Satyr Grovedancer":
                    mcn = new SatyrGrovedancer();
                    break;

                case "Satyr Hoplite":
                    mcn = new SatyrHoplite();
                    break;

                case "Scourge of Fleets":
                    mcn = new ScourgeofFleets();
                    break;

                case "Setessan Tactics":
                    mcn = new SetessanTactics();
                    break;

                case "Sightless Brawler":
                    mcn = new SightlessBrawler();
                    break;

                case "Sigiled Skink":
                    mcn = new SigiledSkink();
                    break;

                case "Sigiled Starfish":
                    mcn = new SigiledStarfish();
                    break;

                case "Silence the Believers":
                    mcn = new SilencetheBelievers();
                    break;

                case "Skybind":
                    mcn = new Skybind();
                    break;

                case "Skyspear Cavalry":
                    mcn = new SkyspearCavalry();
                    break;

                case "Solidarity of Heroes":
                    mcn = new SolidarityofHeroes();
                    break;

                case "Spawn of Thraxes":
                    mcn = new SpawnofThraxes();
                    break;

                case "Spirespine":
                    mcn = new Spirespine();
                    break;

                case "Spite of Mogis":
                    mcn = new SpiteofMogis();
                    break;

                case "Spiteful Blow":
                    mcn = new SpitefulBlow();
                    break;

                case "Squelching Leeches":
                    mcn = new SquelchingLeeches();
                    break;

                case "Starfall":
                    mcn = new Starfall();
                    break;

                case "Stonewise Fortifier":
                    mcn = new StonewiseFortifier();
                    break;

                case "Stormchaser Chimera":
                    mcn = new StormchaserChimera();
                    break;

                case "Strength from the Fallen":
                    mcn = new StrengthfromtheFallen();
                    break;

                case "Supply-Line Cranes":
                    mcn = new SupplyLineCranes();
                    break;

                case "Swarmborn Giant":
                    mcn = new SwarmbornGiant();
                    break;

                case "Temple of Epiphany":
                    mcn = new TempleofEpiphany();
                    break;

                case "Temple of Malady":
                    mcn = new TempleofMalady();
                    break;

                case "Tethmos High Priest":
                    mcn = new TethmosHighPriest();
                    break;

                case "Thassa's Devourer":
                    mcn = new ThassasDevourer();
                    break;

                case "Thassa's Ire":
                    mcn = new ThassasIre();
                    break;

                case "Thoughtrender Lamia":
                    mcn = new ThoughtrenderLamia();
                    break;

                case "Tormented Thoughts":
                    mcn = new TormentedThoughts();
                    break;

                case "Triton Cavalry":
                    mcn = new TritonCavalry();
                    break;

                case "Triton Shorestalker":
                    mcn = new TritonShorestalker();
                    break;

                case "Twinflame":
                    mcn = new Twinflame();
                    break;

                case "Underworld Coinsmith":
                    mcn = new UnderworldCoinsmith();
                    break;

                case "War-Wing Siren":
                    mcn = new WarWingSiren();
                    break;

                case "Whitewater Naiads":
                    mcn = new WhitewaterNaiads();
                    break;

                case "Wildfire Cerberus":
                    mcn = new WildfireCerberus();
                    break;

                case "Worst Fears":
                    mcn = new WorstFears();
                    break;
                # endregion

                # region Theros
                case "Abhorrent Overlord":
                    mcn = new AbhorrentOverlord();
                    break;

                case "Agent of Horizons":
                    mcn = new AgentofHorizons();
                    break;

                case "Agent of the Fates":
                    mcn = new AgentoftheFates();
                    break;

                case "Akroan Crusader":
                    mcn = new AkroanCrusader();
                    break;

                case "Akroan Hoplite":
                    mcn = new AkroanHoplite();
                    break;

                case "Akroan Horse":
                    mcn = new AkroanHorse();
                    break;

                case "Anax and Cymede":
                    mcn = new AnaxandCymede();
                    break;

                case "Anger of the Gods":
                    mcn = new AngeroftheGods();
                    break;

                case "Annul":
                    mcn = new Annul();
                    break;

                case "Anthousa, Setessan Hero":
                    mcn = new AnthousaSetessanHero();
                    break;

                case "Anvilwrought Raptor":
                    mcn = new AnvilwroughtRaptor();
                    break;

                case "Aqueous Form":
                    mcn = new AqueousForm();
                    break;

                case "Arbor Colossus":
                    mcn = new ArborColossus();
                    break;

                case "Arena Athlete":
                    mcn = new ArenaAthlete();
                    break;

                case "Artisan of Forms":
                    mcn = new ArtisanofForms();
                    break;

                case "Artisan's Sorrow":
                    mcn = new ArtisansSorrow();
                    break;

                case "Ashen Rider":
                    mcn = new AshenRider();
                    break;

                case "Ashiok, Nightmare Weaver":
                    mcn = new AshiokNightmareWeaver();
                    break;

                case "Asphodel Wanderer":
                    mcn = new AsphodelWanderer();
                    break;

                case "Baleful Eidolon":
                    mcn = new BalefulEidolon();
                    break;

                case "Battlewise Hoplite":
                    mcn = new BattlewiseHoplite();
                    break;

                case "Battlewise Valor":
                    mcn = new BattlewiseValor();
                    break;

                case "Benthic Giant":
                    mcn = new BenthicGiant();
                    break;

                case "Bident of Thassa":
                    mcn = new BidentofThassa();
                    break;

                case "Blood-Toll Harpy":
                    mcn = new BloodTollHarpy();
                    break;

                case "Boon of Erebos":
                    mcn = new BoonofErebos();
                    break;

                case "Boon Satyr":
                    mcn = new BoonSatyr();
                    break;

                case "Borderland Minotaur":
                    mcn = new BorderlandMinotaur();
                    break;

                case "Boulderfall":
                    mcn = new Boulderfall();
                    break;

                case "Bow of Nylea":
                    mcn = new BowofNylea();
                    break;

                case "Breaching Hippocamp":
                    mcn = new BreachingHippocamp();
                    break;

                case "Bronze Sable":
                    mcn = new BronzeSable();
                    break;

                case "Burnished Hart":
                    mcn = new BurnishedHart();
                    break;

                case "Cavalry Pegasus":
                    mcn = new CavalryPegasus();
                    break;

                case "Cavern Lampad":
                    mcn = new CavernLampad();
                    break;

                case "Celestial Archon":
                    mcn = new CelestialArchon();
                    break;

                case "Centaur Battlemaster":
                    mcn = new CentaurBattlemaster();
                    break;

                case "Chained to the Rocks":
                    mcn = new ChainedtotheRocks();
                    break;

                case "Chosen by Heliod":
                    mcn = new ChosenbyHeliod();
                    break;

                case "Chronicler of Heroes":
                    mcn = new ChroniclerofHeroes();
                    break;

                case "Coastline Chimera":
                    mcn = new CoastlineChimera();
                    break;

                case "Colossus of Akros":
                    mcn = new ColossusofAkros();
                    break;

                case "Commune with the Gods":
                    mcn = new CommunewiththeGods();
                    break;

                case "Coordinated Assault":
                    mcn = new CoordinatedAssault();
                    break;

                case "Crackling Triton":
                    mcn = new CracklingTriton();
                    break;

                case "Curse of the Swine":
                    mcn = new CurseoftheSwine();
                    break;

                case "Cutthroat Maneuver":
                    mcn = new CutthroatManeuver();
                    break;

                case "Dark Betrayal":
                    mcn = new DarkBetrayal();
                    break;

                case "Dauntless Onslaught":
                    mcn = new DauntlessOnslaught();
                    break;

                case "Daxos of Meletis":
                    mcn = new DaxosofMeletis();
                    break;

                case "Deathbellow Raider":
                    mcn = new DeathbellowRaider();
                    break;

                case "Decorated Griffin":
                    mcn = new DecoratedGriffin();
                    break;

                case "Defend the Hearth":
                    mcn = new DefendtheHearth();
                    break;

                case "Demolish":
                    mcn = new Demolish();
                    break;

                case "Destructive Revelry":
                    mcn = new DestructiveRevelry();
                    break;

                case "Disciple of Phenax":
                    mcn = new DiscipleofPhenax();
                    break;

                case "Dissolve":
                    mcn = new Dissolve();
                    break;

                case "Divine Verdict":
                    mcn = new DivineVerdict();
                    break;

                case "Dragon Mantle":
                    mcn = new DragonMantle();
                    break;

                case "Elspeth, Sun's Champion":
                    mcn = new ElspethSunsChampion();
                    break;

                case "Ember Swallower":
                    mcn = new EmberSwallower();
                    break;

                case "Ephara's Warden":
                    mcn = new EpharasWarden();
                    break;

                case "Erebos, God of the Dead":
                    mcn = new ErebosGodoftheDead();
                    break;

                case "Erebos's Emissary":
                    mcn = new ErebossEmissary();
                    break;

                case "Evangel of Heliod":
                    mcn = new EvangelofHeliod();
                    break;

                case "Fabled Hero":
                    mcn = new FabledHero();
                    break;

                case "Fade into Antiquity":
                    mcn = new FadeintoAntiquity();
                    break;

                case "Fanatic of Mogis":
                    mcn = new FanaticofMogis();
                    break;

                case "Fate Foretold":
                    mcn = new FateForetold();
                    break;

                case "Favored Hoplite":
                    mcn = new FavoredHoplite();
                    break;

                case "Felhide Minotaur":
                    mcn = new FelhideMinotaur();
                    break;

                case "Feral Invocation":
                    mcn = new FeralInvocation();
                    break;

                case "Firedrinker Satyr":
                    mcn = new FiredrinkerSatyr();
                    break;

                case "Flamecast Wheel":
                    mcn = new FlamecastWheel();
                    break;

                case "Flamespeaker Adept":
                    mcn = new FlamespeakerAdept();
                    break;

                case "Fleecemane Lion":
                    mcn = new FleecemaneLion();
                    break;

                case "Fleetfeather Sandals":
                    mcn = new FleetfeatherSandals();
                    break;

                case "Fleshmad Steed":
                    mcn = new FleshmadSteed();
                    break;

                case "Gainsay":
                    mcn = new Gainsay();
                    break;

                case "Gift of Immortality":
                    mcn = new GiftofImmortality();
                    break;

                case "Glare of Heresy":
                    mcn = new GlareofHeresy();
                    break;

                case "Gods Willing":
                    mcn = new GodsWilling();
                    break;

                case "Gray Merchant of Asphodel":
                    mcn = new GrayMerchantofAsphodel();
                    break;

                case "Griptide":
                    mcn = new Griptide();
                    break;

                case "Guardians of Meletis":
                    mcn = new GuardiansofMeletis();
                    break;

                case "Hammer of Purphoros":
                    mcn = new HammerofPurphoros();
                    break;

                case "Heliod, God of the Sun":
                    mcn = new HeliodGodoftheSun();
                    break;

                case "Heliod's Emissary":
                    mcn = new HeliodsEmissary();
                    break;

                case "Hero's Downfall":
                    mcn = new HerosDownfall();
                    break;

                case "Hopeful Eidolon":
                    mcn = new HopefulEidolon();
                    break;

                case "Horizon Chimera":
                    mcn = new HorizonChimera();
                    break;

                case "Horizon Scholar":
                    mcn = new HorizonScholar();
                    break;

                case "Hundred-Handed One":
                    mcn = new HundredHandedOne();
                    break;

                case "Hunt the Hunter":
                    mcn = new HunttheHunter();
                    break;

                case "Hythonia the Cruel":
                    mcn = new HythoniatheCruel();
                    break;

                case "Ill-Tempered Cyclops":
                    mcn = new IllTemperedCyclops();
                    break;

                case "Insatiable Harpy":
                    mcn = new InsatiableHarpy();
                    break;

                case "Karametra's Acolyte":
                    mcn = new KarametrasAcolyte();
                    break;

                case "Keepsake Gorgon":
                    mcn = new KeepsakeGorgon();
                    break;

                case "Kragma Warcaller":
                    mcn = new KragmaWarcaller();
                    break;

                case "Labyrinth Champion":
                    mcn = new LabyrinthChampion();
                    break;

                case "Lagonna-Band Elder":
                    mcn = new LagonnaBandElder();
                    break;

                case "Lash of the Whip":
                    mcn = new LashoftheWhip();
                    break;

                case "Last Breath":
                    mcn = new LastBreath();
                    break;

                case "Leafcrown Dryad":
                    mcn = new LeafcrownDryad();
                    break;

                case "Leonin Snarecaster":
                    mcn = new LeoninSnarecaster();
                    break;

                case "Lightning Strike":
                    mcn = new LightningStrike();
                    break;

                case "Loathsome Catoblepas":
                    mcn = new LoathsomeCatoblepas();
                    break;

                case "Lost in a Labyrinth":
                    mcn = new LostinaLabyrinth();
                    break;

                case "Magma Jet":
                    mcn = new MagmaJet();
                    break;

                case "March of the Returned":
                    mcn = new MarchoftheReturned();
                    break;

                case "Master of Waves":
                    mcn = new MasterofWaves();
                    break;

                case "Medomai the Ageless":
                    mcn = new MedomaitheAgeless();
                    break;

                case "Meletis Charlatan":
                    mcn = new MeletisCharlatan();
                    break;

                case "Messenger's Speed":
                    mcn = new MessengersSpeed();
                    break;

                case "Minotaur Skullcleaver":
                    mcn = new MinotaurSkullcleaver();
                    break;

                case "Mistcutter Hydra":
                    mcn = new MistcutterHydra();
                    break;

                case "Mnemonic Wall":
                    mcn = new MnemonicWall();
                    break;

                case "Mogis's Marauder":
                    mcn = new MogissMarauder();
                    break;

                case "Nemesis of Mortals":
                    mcn = new NemesisofMortals();
                    break;

                case "Nessian Asp":
                    mcn = new NessianAsp();
                    break;

                case "Nessian Courser":
                    mcn = new NessianCourser();
                    break;

                case "Nighthowler":
                    mcn = new Nighthowler();
                    break;

                case "Nimbus Naiad":
                    mcn = new NimbusNaiad();
                    break;

                case "Nykthos, Shrine to Nyx":
                    mcn = new NykthosShrinetoNyx();
                    break;

                case "Nylea, God of the Hunt":
                    mcn = new NyleaGodoftheHunt();
                    break;

                case "Nylea's Disciple":
                    mcn = new NyleasDisciple();
                    break;

                case "Nylea's Emissary":
                    mcn = new NyleasEmissary();
                    break;

                case "Nylea's Presence":
                    mcn = new NyleasPresence();
                    break;

                case "Observant Alseid":
                    mcn = new ObservantAlseid();
                    break;

                case "Omenspeaker":
                    mcn = new Omenspeaker();
                    break;

                case "Opaline Unicorn":
                    mcn = new OpalineUnicorn();
                    break;

                case "Ordeal of Erebos":
                    mcn = new OrdealofErebos();
                    break;

                case "Ordeal of Heliod":
                    mcn = new OrdealofHeliod();
                    break;

                case "Ordeal of Nylea":
                    mcn = new OrdealofNylea();
                    break;

                case "Ordeal of Purphoros":
                    mcn = new OrdealofPurphoros();
                    break;

                case "Ordeal of Thassa":
                    mcn = new OrdealofThassa();
                    break;

                case "Peak Eruption":
                    mcn = new PeakEruption();
                    break;

                case "Phalanx Leader":
                    mcn = new PhalanxLeader();
                    break;

                case "Pharika's Cure":
                    mcn = new PharikasCure();
                    break;

                case "Pharika's Mender":
                    mcn = new PharikasMender();
                    break;

                case "Pheres-Band Centaurs":
                    mcn = new PheresBandCentaurs();
                    break;

                case "Polis Crusher":
                    mcn = new PolisCrusher();
                    break;

                case "Polukranos, World Eater":
                    mcn = new PolukranosWorldEater();
                    break;

                case "Portent of Betrayal":
                    mcn = new PortentofBetrayal();
                    break;

                case "Prescient Chimera":
                    mcn = new PrescientChimera();
                    break;

                case "Priest of Iroas":
                    mcn = new PriestofIroas();
                    break;

                case "Prognostic Sphinx":
                    mcn = new PrognosticSphinx();
                    break;

                case "Prophet of Kruphix":
                    mcn = new ProphetofKruphix();
                    break;

                case "Prowler's Helm":
                    mcn = new ProwlersHelm();
                    break;

                case "Psychic Intrusion":
                    mcn = new PsychicIntrusion();
                    break;

                case "Purphoros, God of the Forge":
                    mcn = new PurphorosGodoftheForge();
                    break;

                case "Purphoros's Emissary":
                    mcn = new PurphorossEmissary();
                    break;

                case "Pyxis of Pandemonium":
                    mcn = new PyxisofPandemonium();
                    break;

                case "Rage of Purphoros":
                    mcn = new RageofPurphoros();
                    break;

                case "Rageblood Shaman":
                    mcn = new RagebloodShaman();
                    break;

                case "Ray of Dissolution":
                    mcn = new RayofDissolution();
                    break;

                case "Read the Bones":
                    mcn = new ReadtheBones();
                    break;

                case "Reaper of the Wilds":
                    mcn = new ReaperoftheWilds();
                    break;

                case "Rescue from the Underworld":
                    mcn = new RescuefromtheUnderworld();
                    break;

                case "Returned Centaur":
                    mcn = new ReturnedCentaur();
                    break;

                case "Returned Phalanx":
                    mcn = new ReturnedPhalanx();
                    break;

                case "Reverent Hunter":
                    mcn = new ReverentHunter();
                    break;

                case "Satyr Hedonist":
                    mcn = new SatyrHedonist();
                    break;

                case "Satyr Piper":
                    mcn = new SatyrPiper();
                    break;

                case "Satyr Rambler":
                    mcn = new SatyrRambler();
                    break;

                case "Savage Surge":
                    mcn = new SavageSurge();
                    break;

                case "Scholar of Athreos":
                    mcn = new ScholarofAthreos();
                    break;

                case "Scourgemark":
                    mcn = new Scourgemark();
                    break;

                case "Sea God's Revenge":
                    mcn = new SeaGodsRevenge();
                    break;

                case "Sealock Monster":
                    mcn = new SealockMonster();
                    break;

                case "Sedge Scorpion":
                    mcn = new SedgeScorpion();
                    break;

                case "Sentry of the Underworld":
                    mcn = new SentryoftheUnderworld();
                    break;

                case "Setessan Battle Priest":
                    mcn = new SetessanBattlePriest();
                    break;

                case "Setessan Griffin":
                    mcn = new SetessanGriffin();
                    break;

                case "Shipbreaker Kraken":
                    mcn = new ShipbreakerKraken();
                    break;

                case "Shipwreck Singer":
                    mcn = new ShipwreckSinger();
                    break;

                case "Shredding Winds":
                    mcn = new ShreddingWinds();
                    break;

                case "Silent Artisan":
                    mcn = new SilentArtisan();
                    break;

                case "Sip of Hemlock":
                    mcn = new SipofHemlock();
                    break;

                case "Soldier of the Pantheon":
                    mcn = new SoldierofthePantheon();
                    break;

                case "Spark Jolt":
                    mcn = new SparkJolt();
                    break;

                case "Spear of Heliod":
                    mcn = new SpearofHeliod();
                    break;

                case "Spearpoint Oread":
                    mcn = new SpearpointOread();
                    break;

                case "Spellheart Chimera":
                    mcn = new SpellheartChimera();
                    break;

                case "Staunch-Hearted Warrior":
                    mcn = new StaunchHeartedWarrior();
                    break;

                case "Steam Augury":
                    mcn = new SteamAugury();
                    break;

                case "Stoneshock Giant":
                    mcn = new StoneshockGiant();
                    break;

                case "Stormbreath Dragon":
                    mcn = new StormbreathDragon();
                    break;

                case "Stymied Hopes":
                    mcn = new StymiedHopes();
                    break;

                case "Swan Song":
                    mcn = new SwanSong();
                    break;

                case "Sylvan Caryatid":
                    mcn = new SylvanCaryatid();
                    break;

                case "Temple of Abandon":
                    mcn = new TempleofAbandon();
                    break;

                case "Temple of Deceit":
                    mcn = new TempleofDeceit();
                    break;

                case "Temple of Mystery":
                    mcn = new TempleofMystery();
                    break;

                case "Temple of Silence":
                    mcn = new TempleofSilence();
                    break;

                case "Temple of Triumph":
                    mcn = new TempleofTriumph();
                    break;

                case "Thassa, God of the Sea":
                    mcn = new ThassaGodoftheSea();
                    break;

                case "Thassa's Bounty":
                    mcn = new ThassasBounty();
                    break;

                case "Thassa's Emissary":
                    mcn = new ThassasEmissary();
                    break;

                case "Thoughtseize":
                    mcn = new Thoughtseize();
                    break;

                case "Time to Feed":
                    mcn = new TimetoFeed();
                    break;

                case "Titan of Eternal Fire":
                    mcn = new TitanofEternalFire();
                    break;

                case "Titan's Strength":
                    mcn = new TitansStrength();
                    break;

                case "Tormented Hero":
                    mcn = new TormentedHero();
                    break;

                case "Traveler's Amulet":
                    mcn = new TravelersAmulet();
                    break;

                case "Traveling Philosopher":
                    mcn = new TravelingPhilosopher();
                    break;

                case "Triad of Fates":
                    mcn = new TriadofFates();
                    break;

                case "Triton Fortune Hunter":
                    mcn = new TritonFortuneHunter();
                    break;

                case "Triton Shorethief":
                    mcn = new TritonShorethief();
                    break;

                case "Triton Tactics":
                    mcn = new TritonTactics();
                    break;

                case "Two-Headed Cerberus":
                    mcn = new TwoHeadedCerberus();
                    break;

                case "Tymaret, the Murder King":
                    mcn = new TymarettheMurderKing();
                    break;

                case "Underworld Cerberus":
                    mcn = new UnderworldCerberus();
                    break;

                case "Unknown Shores":
                    mcn = new UnknownShores();
                    break;

                case "Vanquish the Foul":
                    mcn = new VanquishtheFoul();
                    break;

                case "Vaporkin":
                    mcn = new Vaporkin();
                    break;

                case "Viper's Kiss":
                    mcn = new VipersKiss();
                    break;

                case "Voyage's End":
                    mcn = new VoyagesEnd();
                    break;

                case "Voyaging Satyr":
                    mcn = new VoyagingSatyr();
                    break;

                case "Vulpine Goliath":
                    mcn = new VulpineGoliath();
                    break;

                case "Warriors' Lesson":
                    mcn = new WarriorsLesson();
                    break;

                case "Wavecrash Triton":
                    mcn = new WavecrashTriton();
                    break;

                case "Whip of Erebos":
                    mcn = new WhipofErebos();
                    break;

                case "Wild Celebrants":
                    mcn = new WildCelebrants();
                    break;

                case "Wingsteed Rider":
                    mcn = new WingsteedRider();
                    break;

                case "Witches' Eye":
                    mcn = new WitchesEye();
                    break;

                case "Xenagos, the Reveler":
                    mcn = new XenagostheReveler();
                    break;

                case "Yoked Ox":
                    mcn = new YokedOx();
                    break;
                # endregion

                # region Return to Ravnica
case "Abrupt Decay":
mcn = new ();
break;

case "Aerial Predation":
mcn = new ();
break;

case "Angel of Serenity":
mcn = new ();
break;

case "Annihilating Fire":
mcn = new ();
break;

case "Aquus Steed":
mcn = new ();
break;

case "Archon of the Triumvirate":
mcn = new ();
break;

case "Archweaver":
mcn = new ();
break;

case "Armada Wurm":
mcn = new ();
break;

case "Armory Guard":
mcn = new ();
break;

case "Arrest":
mcn = new ();
break;

case "Ash Zealot":
mcn = new ();
break;

case "Assassin's Strike":
mcn = new ();
break;

case "Auger Spree":
mcn = new ();
break;

case "Avenging Arrow":
mcn = new ();
break;

case "Axebane Guardian":
mcn = new ();
break;

case "Axebane Stag":
mcn = new ();
break;

case "Azorius Arrester":
mcn = new ();
break;

case "Azorius Charm":
mcn = new ();
break;

case "Azorius Guildgate":
mcn = new ();
break;

case "Azorius Justiciar":
mcn = new ();
break;

case "Azorius Keyrune":
mcn = new ();
break;

case "Azor's Elocutors":
mcn = new ();
break;

case "Batterhorn":
mcn = new ();
break;

case "Bazaar Krovod":
mcn = new ();
break;

case "Bellows Lizard":
mcn = new ();
break;

case "Blistercoil Weird":
mcn = new ();
break;

case "Blood Crypt":
mcn = new ();
break;

case "Bloodfray Giant":
mcn = new ();
break;

case "Blustersquall":
mcn = new ();
break;

case "Brushstrider":
mcn = new ();
break;

case "Call of the Conclave":
mcn = new ();
break;

case "Cancel":
mcn = new ();
break;

case "Carnival Hellsteed":
mcn = new ();
break;

case "Catacomb Slug":
mcn = new ();
break;

case "Centaur Healer":
mcn = new ();
break;

case "Centaur's Herald":
mcn = new ();
break;

case "Chaos Imps":
mcn = new ();
break;

case "Chemister's Trick":
mcn = new ();
break;

case "Chorus of Might":
mcn = new ();
break;

case "Chromatic Lantern":
mcn = new ();
break;

case "Chronic Flooding":
mcn = new ();
break;

case "Civic Saber":
mcn = new ();
break;

case "Cobblebrute":
mcn = new ();
break;

case "Codex Shredder":
mcn = new ();
break;

case "Collective Blessing":
mcn = new ();
break;

case "Common Bond":
mcn = new ();
break;

case "Concordia Pegasus":
mcn = new ();
break;

case "Conjured Currency":
mcn = new ();
break;

case "Corpsejack Menace":
mcn = new ();
break;

case "Counterflux":
mcn = new ();
break;

case "Coursers' Accord":
mcn = new ();
break;

case "Cremate":
mcn = new ();
break;

case "Crosstown Courier":
mcn = new ();
break;

case "Cryptborn Horror":
mcn = new ();
break;

case "Cyclonic Rift":
mcn = new ();
break;

case "Daggerdrome Imp":
mcn = new ();
break;

case "Dark Revenant":
mcn = new ();
break;

case "Dead Reveler":
mcn = new ();
break;

case "Deadbridge Goliath":
mcn = new ();
break;

case "Deathrite Shaman":
mcn = new ();
break;

case "Death's Presence":
mcn = new ();
break;

case "Desecration Demon":
mcn = new ();
break;

case "Destroy the Evidence":
mcn = new ();
break;

case "Detention Sphere":
mcn = new ();
break;

case "Deviant Glee":
mcn = new ();
break;

case "Dispel":
mcn = new ();
break;

case "Doorkeeper":
mcn = new ();
break;

case "Downsize":
mcn = new ();
break;

case "Drainpipe Vermin":
mcn = new ();
break;

case "Dramatic Rescue":
mcn = new ();
break;

case "Dreadbore":
mcn = new ();
break;

case "Dreg Mangler":
mcn = new ();
break;

case "Drudge Beetle":
mcn = new ();
break;

case "Druid's Deliverance":
mcn = new ();
break;

case "Dryad Militant":
mcn = new ();
break;

case "Dynacharge":
mcn = new ();
break;

case "Electrickery":
mcn = new ();
break;

case "Epic Experiment":
mcn = new ();
break;

case "Essence Backlash":
mcn = new ();
break;

case "Ethereal Armor":
mcn = new ();
break;

case "Explosive Impact":
mcn = new ();
break;

case "Eyes in the Skies":
mcn = new ();
break;

case "Faerie Impostor":
mcn = new ();
break;

case "Fall of the Gavel":
mcn = new ();
break;

case "Fencing Ace":
mcn = new ();
break;

case "Firemind's Foresight":
mcn = new ();
break;

case "Forest":
mcn = new ();
break;

case "Frostburn Weird":
mcn = new ();
break;

case "Gatecreeper Vine":
mcn = new ();
break;

case "Giant Growth":
mcn = new ();
break;

case "Gobbling Ooze":
mcn = new ();
break;

case "Goblin Electromancer":
mcn = new ();
break;

case "Goblin Rally":
mcn = new ();
break;

case "Golgari Charm":
mcn = new ();
break;

case "Golgari Decoy":
mcn = new ();
break;

case "Golgari Guildgate":
mcn = new ();
break;

case "Golgari Keyrune":
mcn = new ();
break;

case "Golgari Longlegs":
mcn = new ();
break;

case "Gore-House Chainwalker":
mcn = new ();
break;

case "Grave Betrayal":
mcn = new ();
break;

case "Grim Roustabout":
mcn = new ();
break;

case "Grisly Salvage":
mcn = new ();
break;

case "Grove of the Guardian":
mcn = new ();
break;

case "Growing Ranks":
mcn = new ();
break;

case "Guild Feud":
mcn = new ();
break;

case "Guttersnipe":
mcn = new ();
break;

case "Hallowed Fountain":
mcn = new ();
break;

case "Havoc Festival":
mcn = new ();
break;

case "Hellhole Flailer":
mcn = new ();
break;

case "Heroes' Reunion":
mcn = new ();
break;

case "Horncaller's Chant":
mcn = new ();
break;

case "Hover Barrier":
mcn = new ();
break;

case "Hussar Patrol":
mcn = new ();
break;

case "Hypersonic Dragon":
mcn = new ();
break;

case "Inaction Injunction":
mcn = new ();
break;

case "Inspiration":
mcn = new ();
break;

case "Island":
mcn = new ();
break;

case "Isperia, Supreme Judge":
mcn = new ();
break;

case "Isperia's Skywatch":
mcn = new ();
break;

case "Izzet Charm":
mcn = new ();
break;

case "Izzet Guildgate":
mcn = new ();
break;

case "Izzet Keyrune":
mcn = new ();
break;

case "Izzet Staticaster":
mcn = new ();
break;

case "Jace, Architect of Thought":
mcn = new ();
break;

case "Jarad, Golgari Lich Lord":
mcn = new ();
break;

case "Jarad's Orders":
mcn = new ();
break;

case "Judge's Familiar":
mcn = new ();
break;

case "Keening Apparition":
mcn = new ();
break;

case "Knightly Valor":
mcn = new ();
break;

case "Korozda Guildmage":
mcn = new ();
break;

case "Korozda Monitor":
mcn = new ();
break;

case "Launch Party":
mcn = new ();
break;

case "Lobber Crew":
mcn = new ();
break;

case "Lotleth Troll":
mcn = new ();
break;

case "Loxodon Smiter":
mcn = new ();
break;

case "Lyev Skyknight":
mcn = new ();
break;

case "Mana Bloom":
mcn = new ();
break;

case "Martial Law":
mcn = new ();
break;

case "Mercurial Chemister":
mcn = new ();
break;

case "Mind Rot":
mcn = new ();
break;

case "Minotaur Aggressor":
mcn = new ();
break;

case "Mizzium Mortars":
mcn = new ();
break;

case "Mizzium Skin":
mcn = new ();
break;

case "Mountain":
mcn = new ();
break;

case "Necropolis Regent":
mcn = new ();
break;

case "New Prahv Guildmage":
mcn = new ();
break;

case "Nivix Guildmage":
mcn = new ();
break;

case "Nivmagus Elemental":
mcn = new ();
break;

case "Niv-Mizzet, Dracogenius":
mcn = new ();
break;

case "Oak Street Innkeeper":
mcn = new ();
break;

case "Ogre Jailbreaker":
mcn = new ();
break;

case "Overgrown Tomb":
mcn = new ();
break;

case "Pack Rat":
mcn = new ();
break;

case "Palisade Giant":
mcn = new ();
break;

case "Paralyzing Grasp":
mcn = new ();
break;

case "Perilous Shadow":
mcn = new ();
break;

case "Phantom General":
mcn = new ();
break;

case "Pithing Needle":
mcn = new ();
break;

case "Plains":
mcn = new ();
break;

case "Precinct Captain":
mcn = new ();
break;

case "Psychic Spiral":
mcn = new ();
break;

case "Pursuit of Flight":
mcn = new ();
break;

case "Pyroconvergence":
mcn = new ();
break;

case "Racecourse Fury":
mcn = new ();
break;

case "Rakdos Cackler":
mcn = new ();
break;

case "Rakdos Charm":
mcn = new ();
break;

case "Rakdos Guildgate":
mcn = new ();
break;

case "Rakdos Keyrune":
mcn = new ();
break;

case "Rakdos Ragemutt":
mcn = new ();
break;

case "Rakdos Ringleader":
mcn = new ();
break;

case "Rakdos Shred-Freak":
mcn = new ();
break;

case "Rakdos, Lord of Riots":
mcn = new ();
break;

case "Rakdos's Return":
mcn = new ();
break;

case "Rest in Peace":
mcn = new ();
break;

case "Righteous Authority":
mcn = new ();
break;

case "Risen Sanctuary":
mcn = new ();
break;

case "Rites of Reaping":
mcn = new ();
break;

case "Rix Maadi Guildmage":
mcn = new ();
break;

case "Rogue's Passage":
mcn = new ();
break;

case "Rootborn Defenses":
mcn = new ();
break;

case "Rubbleback Rhino":
mcn = new ();
break;

case "Runewing":
mcn = new ();
break;

case "Savage Surge":
mcn = new ();
break;

case "Search the City":
mcn = new ();
break;

case "Search Warrant":
mcn = new ();
break;

case "Security Blockade":
mcn = new ();
break;

case "Seek the Horizon":
mcn = new ();
break;

case "Selesnya Charm":
mcn = new ();
break;

case "Selesnya Guildgate":
mcn = new ();
break;

case "Selesnya Keyrune":
mcn = new ();
break;

case "Selesnya Sentry":
mcn = new ();
break;

case "Seller of Songbirds":
mcn = new ();
break;

case "Sewer Shambler":
mcn = new ();
break;

case "Shrieking Affliction":
mcn = new ();
break;

case "Skull Rend":
mcn = new ();
break;

case "Skyline Predator":
mcn = new ();
break;

case "Skymark Roc":
mcn = new ();
break;

case "Slaughter Games":
mcn = new ();
break;

case "Slime Molding":
mcn = new ();
break;

case "Slitherhead":
mcn = new ();
break;

case "Sluiceway Scorpion":
mcn = new ();
break;

case "Slum Reaper":
mcn = new ();
break;

case "Soul Tithe":
mcn = new ();
break;

case "Soulsworn Spirit":
mcn = new ();
break;

case "Spawn of Rix Maadi":
mcn = new ();
break;

case "Sphere of Safety":
mcn = new ();
break;

case "Sphinx of the Chimes":
mcn = new ();
break;

case "Sphinx's Revelation":
mcn = new ();
break;

case "Splatter Thug":
mcn = new ();
break;

case "Stab Wound":
mcn = new ();
break;

case "Stealer of Secrets":
mcn = new ();
break;

case "Steam Vents":
mcn = new ();
break;

case "Stonefare Crocodile":
mcn = new ();
break;

case "Street Spasm":
mcn = new ();
break;

case "Street Sweeper":
mcn = new ();
break;

case "Sundering Growth":
mcn = new ();
break;

case "Sunspire Griffin":
mcn = new ();
break;

case "Supreme Verdict":
mcn = new ();
break;

case "Survey the Wreckage":
mcn = new ();
break;

case "Swamp":
mcn = new ();
break;

case "Swift Justice":
mcn = new ();
break;

case "Syncopate":
mcn = new ();
break;

case "Tablet of the Guilds":
mcn = new ();
break;

case "Tavern Swindler":
mcn = new ();
break;

case "Teleportal":
mcn = new ();
break;

case "Temple Garden":
mcn = new ();
break;

case "Tenement Crasher":
mcn = new ();
break;

case "Terrus Wurm":
mcn = new ();
break;

case "Thoughtflare":
mcn = new ();
break;

case "Thrill-Kill Assassin":
mcn = new ();
break;

case "Tower Drake":
mcn = new ();
break;

case "Towering Indrik":
mcn = new ();
break;

case "Trained Caracal":
mcn = new ();
break;

case "Traitorous Instinct":
mcn = new ();
break;

case "Transguild Promenade":
mcn = new ();
break;

case "Treasured Find":
mcn = new ();
break;

case "Trestle Troll":
mcn = new ();
break;

case "Trostani, Selesnya's Voice":
mcn = new ();
break;

case "Trostani's Judgment":
mcn = new ();
break;

case "Ultimate Price":
mcn = new ();
break;

case "Underworld Connections":
mcn = new ();
break;

case "Urban Burgeoning":
mcn = new ();
break;

case "Utvara Hellkite":
mcn = new ();
break;

case "Vandalblast":
mcn = new ();
break;

case "Vassal Soul":
mcn = new ();
break;

case "Viashino Racketeer":
mcn = new ();
break;

case "Vitu-Ghazi Guildmage":
mcn = new ();
break;

case "Voidwielder":
mcn = new ();
break;

case "Volatile Rig":
mcn = new ();
break;

case "Vraska the Unseen":
mcn = new ();
break;

case "Wayfaring Temple":
mcn = new ();
break;

case "Wild Beastmaster":
mcn = new ();
break;

case "Worldspine Wurm":
mcn = new ();
break;

case "Zanikev Locust":
mcn = new ();
break;

# endregion

                # region Gatecrash
case "Act of Treason":
mcn = new ();
break;

case "Adaptive Snapjaw":
mcn = new ();
break;

case "Aerial Maneuver":
mcn = new ();
break;

case "AEtherize":
mcn = new ();
break;

case "Agoraphobia":
mcn = new ();
break;

case "Alms Beast":
mcn = new ();
break;

case "Alpha Authority":
mcn = new ();
break;

case "Angelic Edict":
mcn = new ();
break;

case "Angelic Skirmisher":
mcn = new ();
break;

case "Armored Transport":
mcn = new ();
break;

case "Arrows of Justice":
mcn = new ();
break;

case "Assault Griffin":
mcn = new ();
break;

case "Assemble the Legion":
mcn = new ();
break;

case "Aurelia, the Warleader":
mcn = new ();
break;

case "Aurelia's Fury":
mcn = new ();
break;

case "Balustrade Spy":
mcn = new ();
break;

case "Bane Alley Broker":
mcn = new ();
break;

case "Basilica Guards":
mcn = new ();
break;

case "Basilica Screecher":
mcn = new ();
break;

case "Beckon Apparition":
mcn = new ();
break;

case "Biomass Mutation":
mcn = new ();
break;

case "Bioshift":
mcn = new ();
break;

case "Biovisionary":
mcn = new ();
break;

case "Blind Obedience":
mcn = new ();
break;

case "Bomber Corps":
mcn = new ();
break;

case "Borborygmos Enraged":
mcn = new ();
break;

case "Boros Charm":
mcn = new ();
break;

case "Boros Elite":
mcn = new ();
break;

case "Boros Guildgate":
mcn = new ();
break;

case "Boros Keyrune":
mcn = new ();
break;

case "Boros Reckoner":
mcn = new ();
break;

case "Breeding Pool":
mcn = new ();
break;

case "Burning-Tree Emissary":
mcn = new ();
break;

case "Burst of Strength":
mcn = new ();
break;

case "Call of the Nightwing":
mcn = new ();
break;

case "Cartel Aristocrat":
mcn = new ();
break;

case "Cinder Elemental":
mcn = new ();
break;

case "Clan Defiance":
mcn = new ();
break;

case "Clinging Anemones":
mcn = new ();
break;

case "Cloudfin Raptor":
mcn = new ();
break;

case "Coerced Confession":
mcn = new ();
break;

case "Consuming Aberration":
mcn = new ();
break;

case "Contaminated Ground":
mcn = new ();
break;

case "Corpse Blockade":
mcn = new ();
break;

case "Court Street Denizen":
mcn = new ();
break;

case "Crackling Perimeter":
mcn = new ();
break;

case "Crocanura":
mcn = new ();
break;

case "Crowned Ceratok":
mcn = new ();
break;

case "Crypt Ghast":
mcn = new ();
break;

case "Daring Skyjek":
mcn = new ();
break;

case "Deathcult Rogue":
mcn = new ();
break;

case "Deathpact Angel":
mcn = new ();
break;

case "Death's Approach":
mcn = new ();
break;

case "Debtor's Pulpit":
mcn = new ();
break;

case "Devour Flesh":
mcn = new ();
break;

case "Diluvian Primordial":
mcn = new ();
break;

case "Dimir Charm":
mcn = new ();
break;

case "Dimir Guildgate":
mcn = new ();
break;

case "Dimir Keyrune":
mcn = new ();
break;

case "Dinrova Horror":
mcn = new ();
break;

case "Disciple of the Old Ways":
mcn = new ();
break;

case "Domri Rade":
mcn = new ();
break;

case "Drakewing Krasis":
mcn = new ();
break;

case "Duskmantle Guildmage":
mcn = new ();
break;

case "Duskmantle Seer":
mcn = new ();
break;

case "Dutiful Thrull":
mcn = new ();
break;

case "Dying Wish":
mcn = new ();
break;

case "Elusive Krasis":
mcn = new ();
break;

case "Ember Beast":
mcn = new ();
break;

case "Enter the Infinite":
mcn = new ();
break;

case "Executioner's Swing":
mcn = new ();
break;

case "Experiment One":
mcn = new ();
break;

case "Fathom Mage":
mcn = new ();
break;

case "Firefist Striker":
mcn = new ();
break;

case "Firemane Avenger":
mcn = new ();
break;

case "Five-Alarm Fire":
mcn = new ();
break;

case "Forced Adaptation":
mcn = new ();
break;

case "Fortress Cyclops":
mcn = new ();
break;

case "Foundry Champion":
mcn = new ();
break;

case "Foundry Street Denizen":
mcn = new ();
break;

case "Frenzied Tilling":
mcn = new ();
break;

case "Frilled Oculus":
mcn = new ();
break;

case "Frontline Medic":
mcn = new ();
break;

case "Furious Resistance":
mcn = new ();
break;

case "Gateway Shade":
mcn = new ();
break;

case "Ghor-Clan Rampager":
mcn = new ();
break;

case "Giant Adephage":
mcn = new ();
break;

case "Gideon, Champion of Justice":
mcn = new ();
break;

case "Gift of Orzhova":
mcn = new ();
break;

case "Glaring Spotlight":
mcn = new ();
break;

case "Godless Shrine":
mcn = new ();
break;

case "Greenside Watcher":
mcn = new ();
break;

case "Gridlock":
mcn = new ();
break;

case "Grisly Spectacle":
mcn = new ();
break;

case "Ground Assault":
mcn = new ();
break;

case "Gruul Charm":
mcn = new ();
break;

case "Gruul Guildgate":
mcn = new ();
break;

case "Gruul Keyrune":
mcn = new ();
break;

case "Gruul Ragebeast":
mcn = new ();
break;

case "Guardian of the Gateless":
mcn = new ();
break;

case "Guildscorn Ward":
mcn = new ();
break;

case "Gutter Skulk":
mcn = new ();
break;

case "Gyre Sage":
mcn = new ();
break;

case "Hands of Binding":
mcn = new ();
break;

case "Hellkite Tyrant":
mcn = new ();
break;

case "Hellraiser Goblin":
mcn = new ();
break;

case "High Priest of Penance":
mcn = new ();
break;

case "Hindervines":
mcn = new ();
break;

case "Hold the Gates":
mcn = new ();
break;

case "Holy Mantle":
mcn = new ();
break;

case "Homing Lightning":
mcn = new ();
break;

case "Horror of the Dim":
mcn = new ();
break;

case "Hydroform":
mcn = new ();
break;

case "Illness in the Ranks":
mcn = new ();
break;

case "Illusionist's Bracers":
mcn = new ();
break;

case "Immortal Servitude":
mcn = new ();
break;

case "Incursion Specialist":
mcn = new ();
break;

case "Ivy Lane Denizen":
mcn = new ();
break;

case "Keymaster Rogue":
mcn = new ();
break;

case "Killing Glare":
mcn = new ();
break;

case "Kingpin's Pet":
mcn = new ();
break;

case "Knight of Obligation":
mcn = new ();
break;

case "Knight Watch":
mcn = new ();
break;

case "Last Thoughts":
mcn = new ();
break;

case "Lazav, Dimir Mastermind":
mcn = new ();
break;

case "Legion Loyalist":
mcn = new ();
break;

case "Leyline Phantom":
mcn = new ();
break;

case "Lord of the Void":
mcn = new ();
break;

case "Luminate Primordial":
mcn = new ();
break;

case "Madcap Skills":
mcn = new ();
break;

case "Mark for Death":
mcn = new ();
break;

case "Martial Glory":
mcn = new ();
break;

case "Massive Raid":
mcn = new ();
break;

case "Master Biomancer":
mcn = new ();
break;

case "Mental Vapors":
mcn = new ();
break;

case "Merciless Eviction":
mcn = new ();
break;

case "Merfolk of the Depths":
mcn = new ();
break;

case "Metropolis Sprite":
mcn = new ();
break;

case "Midnight Recovery":
mcn = new ();
break;

case "Millennial Gargoyle":
mcn = new ();
break;

case "Miming Slime":
mcn = new ();
break;

case "Mind Grind":
mcn = new ();
break;

case "Mindeye Drake":
mcn = new ();
break;

case "Molten Primordial":
mcn = new ();
break;

case "Mortus Strider":
mcn = new ();
break;

case "Mugging":
mcn = new ();
break;

case "Murder Investigation":
mcn = new ();
break;

case "Mystic Genesis":
mcn = new ();
break;

case "Naturalize":
mcn = new ();
break;

case "Nav Squad Commandos":
mcn = new ();
break;

case "Nightveil Specter":
mcn = new ();
break;

case "Nimbus Swimmer":
mcn = new ();
break;

case "Obzedat, Ghost Council":
mcn = new ();
break;

case "Ogre Slumlord":
mcn = new ();
break;

case "One Thousand Lashes":
mcn = new ();
break;

case "Ooze Flux":
mcn = new ();
break;

case "Ordruun Veteran":
mcn = new ();
break;

case "Orzhov Charm":
mcn = new ();
break;

case "Orzhov Guildgate":
mcn = new ();
break;

case "Orzhov Keyrune":
mcn = new ();
break;

case "Paranoid Delusions":
mcn = new ();
break;

case "Pit Fight":
mcn = new ();
break;

case "Predator's Rapport":
mcn = new ();
break;

case "Primal Visitation":
mcn = new ();
break;

case "Prime Speaker Zegana":
mcn = new ();
break;

case "Prophetic Prism":
mcn = new ();
break;

case "Psychic Strike":
mcn = new ();
break;

case "Purge the Profane":
mcn = new ();
break;

case "Rapid Hybridization":
mcn = new ();
break;

case "Razortip Whip":
mcn = new ();
break;

case "Realmwright":
mcn = new ();
break;

case "Righteous Charge":
mcn = new ();
break;

case "Riot Gear":
mcn = new ();
break;

case "Ripscale Predator":
mcn = new ();
break;

case "Rubblebelt Raiders":
mcn = new ();
break;

case "Rubblehulk":
mcn = new ();
break;

case "Ruination Wurm":
mcn = new ();
break;

case "Rust Scarab":
mcn = new ();
break;

case "Sacred Foundry":
mcn = new ();
break;

case "Sage's Row Denizen":
mcn = new ();
break;

case "Sapphire Drake":
mcn = new ();
break;

case "Scab-Clan Charger":
mcn = new ();
break;

case "Scatter Arc":
mcn = new ();
break;

case "Scorchwalker":
mcn = new ();
break;

case "Sepulchral Primordial":
mcn = new ();
break;

case "Serene Remembrance":
mcn = new ();
break;

case "Shadow Alley Denizen":
mcn = new ();
break;

case "Shadow Slice":
mcn = new ();
break;

case "Shambleshark":
mcn = new ();
break;

case "Shattering Blow":
mcn = new ();
break;

case "Shielded Passage":
mcn = new ();
break;

case "Signal the Clans":
mcn = new ();
break;

case "Simic Charm":
mcn = new ();
break;

case "Simic Fluxmage":
mcn = new ();
break;

case "Simic Guildgate":
mcn = new ();
break;

case "Simic Keyrune":
mcn = new ();
break;

case "Simic Manipulator":
mcn = new ();
break;

case "Skarrg Goliath":
mcn = new ();
break;

case "Skarrg Guildmage":
mcn = new ();
break;

case "Skinbrand Goblin":
mcn = new ();
break;

case "Skullcrack":
mcn = new ();
break;

case "Skyblinder Staff":
mcn = new ();
break;

case "Skygames":
mcn = new ();
break;

case "Skyknight Legionnaire":
mcn = new ();
break;

case "Slate Street Ruffian":
mcn = new ();
break;

case "Slaughterhorn":
mcn = new ();
break;

case "Smite":
mcn = new ();
break;

case "Smog Elemental":
mcn = new ();
break;

case "Soul Ransom":
mcn = new ();
break;

case "Spark Trooper":
mcn = new ();
break;

case "Spell Rupture":
mcn = new ();
break;

case "Spire Tracer":
mcn = new ();
break;

case "Stolen Identity":
mcn = new ();
break;

case "Stomping Ground":
mcn = new ();
break;

case "Structural Collapse":
mcn = new ();
break;

case "Sunhome Guildmage":
mcn = new ();
break;

case "Sylvan Primordial":
mcn = new ();
break;

case "Syndic of Tithes":
mcn = new ();
break;

case "Syndicate Enforcer":
mcn = new ();
break;

case "Thespian's Stage":
mcn = new ();
break;

case "Thrull Parasite":
mcn = new ();
break;

case "Tin Street Market":
mcn = new ();
break;

case "Totally Lost":
mcn = new ();
break;

case "Tower Defense":
mcn = new ();
break;

case "Towering Thunderfist":
mcn = new ();
break;

case "Treasury Thrull":
mcn = new ();
break;

case "Truefire Paladin":
mcn = new ();
break;

case "Undercity Informer":
mcn = new ();
break;

case "Undercity Plague":
mcn = new ();
break;

case "Unexpected Results":
mcn = new ();
break;

case "Urban Evolution":
mcn = new ();
break;

case "Urbis Protector":
mcn = new ();
break;

case "Verdant Haven":
mcn = new ();
break;

case "Viashino Shanktail":
mcn = new ();
break;

case "Vizkopa Confessor":
mcn = new ();
break;

case "Vizkopa Guildmage":
mcn = new ();
break;

case "Voidwalk":
mcn = new ();
break;

case "Warmind Infantry":
mcn = new ();
break;

case "Wasteland Viper":
mcn = new ();
break;

case "Watery Grave":
mcn = new ();
break;

case "Way of the Thief":
mcn = new ();
break;

case "Whispering Madness":
mcn = new ();
break;

case "Wight of Precinct Six":
mcn = new ();
break;

case "Wildwood Rebirth":
mcn = new ();
break;

case "Wojek Halberdiers":
mcn = new ();
break;

case "Wrecking Ogre":
mcn = new ();
break;

case "Zameck Guildmage":
mcn = new ();
break;

case "Zarichi Tiger":
mcn = new ();
break;

case "Zhur-Taa Swine":
mcn = new ();
break;

# endregion

                # region Dragon's Maze
case "Advent of the Wurm":
mcn = new ();
break;

case "AEtherling":
mcn = new ();
break;

case "Alive/Well":
mcn = new ();
break;

case "Armed/Dangerous":
mcn = new ();
break;

case "Armored Wolf-Rider":
mcn = new ();
break;

case "Ascended Lawmage":
mcn = new ();
break;

case "Awe for the Guilds":
mcn = new ();
break;

case "Azorius Cluestone":
mcn = new ();
break;

case "Azorius Guildgate":
mcn = new ();
break;

case "Bane Alley Blackguard":
mcn = new ();
break;

case "Battering Krasis":
mcn = new ();
break;

case "Beck/Call":
mcn = new ();
break;

case "Beetleform Mage":
mcn = new ();
break;

case "Blast of Genius":
mcn = new ();
break;

case "Blaze Commando":
mcn = new ();
break;

case "Blood Baron of Vizkopa":
mcn = new ();
break;

case "Blood Scrivener":
mcn = new ();
break;

case "Boros Battleshaper":
mcn = new ();
break;

case "Boros Cluestone":
mcn = new ();
break;

case "Boros Guildgate":
mcn = new ();
break;

case "Boros Mastiff":
mcn = new ();
break;

case "Breaking/Entering":
mcn = new ();
break;

case "Bred for the Hunt":
mcn = new ();
break;

case "Bronzebeak Moa":
mcn = new ();
break;

case "Carnage Gladiator":
mcn = new ();
break;

case "Catch/Release":
mcn = new ();
break;

case "Clear a Path":
mcn = new ();
break;

case "Council of the Absolute":
mcn = new ();
break;

case "Crypt Incursion":
mcn = new ();
break;

case "Deadbridge Chant":
mcn = new ();
break;

case "Debt to the Deathless":
mcn = new ();
break;

case "Deputy of Acquittals":
mcn = new ();
break;

case "Dimir Cluestone":
mcn = new ();
break;

case "Dimir Guildgate":
mcn = new ();
break;

case "Down/Dirty":
mcn = new ();
break;

case "Dragonshift":
mcn = new ();
break;

case "Drown in Filth":
mcn = new ();
break;

case "Emmara Tandris":
mcn = new ();
break;

case "Exava, Rakdos Blood Witch":
mcn = new ();
break;

case "Far/Away":
mcn = new ();
break;

case "Fatal Fumes":
mcn = new ();
break;

case "Feral Animist":
mcn = new ();
break;

case "Flesh/Blood":
mcn = new ();
break;

case "Fluxcharger":
mcn = new ();
break;

case "Gaze of Granite":
mcn = new ();
break;

case "Give/Take":
mcn = new ();
break;

case "Gleam of Battle":
mcn = new ();
break;

case "Goblin Test Pilot":
mcn = new ();
break;

case "Golgari Cluestone":
mcn = new ();
break;

case "Golgari Guildgate":
mcn = new ();
break;

case "Gruul Cluestone":
mcn = new ();
break;

case "Gruul Guildgate":
mcn = new ();
break;

case "Gruul War Chant":
mcn = new ();
break;

case "Haazda Snare Squad":
mcn = new ();
break;

case "Haunter of Nightveil":
mcn = new ();
break;

case "Hidden Strings":
mcn = new ();
break;

case "Hired Torturer":
mcn = new ();
break;

case "Izzet Cluestone":
mcn = new ();
break;

case "Izzet Guildgate":
mcn = new ();
break;

case "Jelenn Sphinx":
mcn = new ();
break;

case "Korozda Gorgon":
mcn = new ();
break;

case "Krasis Incubation":
mcn = new ();
break;

case "Kraul Warrior":
mcn = new ();
break;

case "Lavinia of the Tenth":
mcn = new ();
break;

case "Legion's Initiative":
mcn = new ();
break;

case "Lyev Decree":
mcn = new ();
break;

case "Master of Cruelties":
mcn = new ();
break;

case "Maw of the Obzedat":
mcn = new ();
break;

case "Maze Abomination":
mcn = new ();
break;

case "Maze Behemoth":
mcn = new ();
break;

case "Maze Glider":
mcn = new ();
break;

case "Maze Rusher":
mcn = new ();
break;

case "Maze Sentinel":
mcn = new ();
break;

case "Maze's End":
mcn = new ();
break;

case "Melek, Izzet Paragon":
mcn = new ();
break;

case "Mending Touch":
mcn = new ();
break;

case "Mindstatic":
mcn = new ();
break;

case "Mirko Vosk, Mind Drinker":
mcn = new ();
break;

case "Morgue Burst":
mcn = new ();
break;

case "Murmuring Phantasm":
mcn = new ();
break;

case "Mutant's Prey":
mcn = new ();
break;

case "Nivix Cyclops":
mcn = new ();
break;

case "Notion Thief":
mcn = new ();
break;

case "Obzedat's Aid":
mcn = new ();
break;

case "Opal Lake Gatekeepers":
mcn = new ();
break;

case "Orzhov Cluestone":
mcn = new ();
break;

case "Orzhov Guildgate":
mcn = new ();
break;

case "Phytoburst":
mcn = new ();
break;

case "Pilfered Plans":
mcn = new ();
break;

case "Plasm Capture":
mcn = new ();
break;

case "Pontiff of Blight":
mcn = new ();
break;

case "Possibility Storm":
mcn = new ();
break;

case "Profit/Loss":
mcn = new ();
break;

case "Progenitor Mimic":
mcn = new ();
break;

case "Protect/Serve":
mcn = new ();
break;

case "Punish the Enemy":
mcn = new ();
break;

case "Putrefy":
mcn = new ();
break;

case "Pyrewild Shaman":
mcn = new ();
break;

case "Rakdos Cluestone":
mcn = new ();
break;

case "Rakdos Drake":
mcn = new ();
break;

case "Rakdos Guildgate":
mcn = new ();
break;

case "Ral Zarek":
mcn = new ();
break;

case "Ready/Willing":
mcn = new ();
break;

case "Reap Intellect":
mcn = new ();
break;

case "Render Silent":
mcn = new ();
break;

case "Renegade Krasis":
mcn = new ();
break;

case "Renounce the Guilds":
mcn = new ();
break;

case "Restore the Peace":
mcn = new ();
break;

case "Riot Control":
mcn = new ();
break;

case "Riot Piker":
mcn = new ();
break;

case "Rot Farm Skeleton":
mcn = new ();
break;

case "Rubblebelt Maaka":
mcn = new ();
break;

case "Runner's Bane":
mcn = new ();
break;

case "Ruric Thar, the Unbowed":
mcn = new ();
break;

case "Saruli Gatekeepers":
mcn = new ();
break;

case "Savageborn Hydra":
mcn = new ();
break;

case "Scab-Clan Giant":
mcn = new ();
break;

case "Scion of Vitu-Ghazi":
mcn = new ();
break;

case "Selesnya Cluestone":
mcn = new ();
break;

case "Selesnya Guildgate":
mcn = new ();
break;

case "Showstopper":
mcn = new ();
break;

case "Simic Cluestone":
mcn = new ();
break;

case "Simic Guildgate":
mcn = new ();
break;

case "Sin Collector":
mcn = new ();
break;

case "Sinister Possession":
mcn = new ();
break;

case "Sire of Insanity":
mcn = new ();
break;

case "Skylasher":
mcn = new ();
break;

case "Smelt-Ward Gatekeepers":
mcn = new ();
break;

case "Species Gorger":
mcn = new ();
break;

case "Spike Jester":
mcn = new ();
break;

case "Steeple Roc":
mcn = new ();
break;

case "Sunspire Gatekeepers":
mcn = new ();
break;

case "Tajic, Blade of the Legion":
mcn = new ();
break;

case "Teysa, Envoy of Ghosts":
mcn = new ();
break;

case "Thrashing Mossdog":
mcn = new ();
break;

case "Tithe Drinker":
mcn = new ();
break;

case "Toil/Trouble":
mcn = new ();
break;

case "Trait Doctoring":
mcn = new ();
break;

case "Trostani's Summoner":
mcn = new ();
break;

case "Turn/Burn":
mcn = new ();
break;

case "Ubul Sar Gatekeepers":
mcn = new ();
break;

case "Uncovered Clues":
mcn = new ();
break;

case "Unflinching Courage":
mcn = new ();
break;

case "Varolz, the Scar-Striped":
mcn = new ();
break;

case "Viashino Firstblade":
mcn = new ();
break;

case "Voice of Resurgence":
mcn = new ();
break;

case "Vorel of the Hull Clade":
mcn = new ();
break;

case "Wake the Reflections":
mcn = new ();
break;

case "Warleader's Helix":
mcn = new ();
break;

case "Warped Physique":
mcn = new ();
break;

case "Weapon Surge":
mcn = new ();
break;

case "Wear/Tear":
mcn = new ();
break;

case "Wind Drake":
mcn = new ();
break;

case "Woodlot Crawler":
mcn = new ();
break;

case "Zhur-Taa Ancient":
mcn = new ();
break;

case "Zhur-Taa Druid":
mcn = new ();
break;

# endregion

                # region Core 2014
                # region Young Pyromancer
                case "Young Pyromancer":
                    mcn = new YoungPyromancer();
                    break;
                # endregion
                # endregion

                # region Basic Lands
                case "Forest":
                    mcn = new Forest();
                    break;

                case "Mountain":
                    mcn = new Mountain();
                    break;

                case "Plains":
                    mcn = new Plains();
                    break;

                case "Swamp":
                    mcn = new Swamp();
                    break;

                case "Island":
                    mcn = new Island();
                    break;
                # endregion

                default:
                    mcn = new MagicCard();
                    break;
            }

            return mcn;
        }
    }

    public class CardAbility
    {
        public ColourCost _cost;
        public ColourCost Cost
        {
            get
            {
                if (_cost != null)
                {
                    return _cost;
                }
                else
                {
                    ColourCost c = new ColourCost();

                    string adj = RawCost.Replace(",", "").Replace(" ", "");
                    List<string> colours = adj.Split('%').ToList();

                    # region colours
                    foreach (string s in colours)
                    {
                        switch (s)
                        {
                            case "U":
                                c.blue++;
                                break;

                            case "R":
                                c.red++;
                                break;

                            case "G":
                                c.green++;
                                break;

                            case "W":
                                c.white++;
                                break;

                            case "B":
                                c.black++;
                                break;
                        }
                    }
                    # endregion

                    _cost = c;
                    return c;
                }
            }
        }
        public string RawCost = "";
        public string Text = "";
        public string Name = "";
        public bool Active = false;
    }

    public enum CSize
    {
        vSmall,
        Small,
        Normal,
        Large,
        vLarge
    };

}
