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
using MagicProgram.Controls;

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
    //[XmlInclude(typeof(SliverQueenSH))]
    //#region AVR
    //[XmlInclude(typeof(AbundantGrowthAVR))]
    //[XmlInclude(typeof(AggravateAVR))]
    //[XmlInclude(typeof(AlchemistsApprenticeAVR))]
    //[XmlInclude(typeof(AlchemistsRefugeAVR))]
    //[XmlInclude(typeof(AmasstheComponentsAVR))]
    //[XmlInclude(typeof(AngelofGlorysRiseAVR))]
    //[XmlInclude(typeof(AngelofJubilationAVR))]
    //[XmlInclude(typeof(AngelicArmamentsAVR))]
    //[XmlInclude(typeof(AngelicWallAVR))]
    //[XmlInclude(typeof(AngelsMercyAVR))]
    //[XmlInclude(typeof(AngelsTombAVR))]
    //[XmlInclude(typeof(AppetiteforBrainsAVR))]
    //[XmlInclude(typeof(ArcaneMeleeAVR))]
    //[XmlInclude(typeof(ArchangelAVR))]
    //[XmlInclude(typeof(ArchwingDragonAVR))]
    //[XmlInclude(typeof(AvacynAngelofHopeAVR))]
    //[XmlInclude(typeof(BanishingStrokeAVR))]
    //[XmlInclude(typeof(BannersRaisedAVR))]
    //[XmlInclude(typeof(BarterinBloodAVR))]
    //[XmlInclude(typeof(BattleHymnAVR))]
    //[XmlInclude(typeof(BladedBracersAVR))]
    //[XmlInclude(typeof(BlessingsofNatureAVR))]
    //[XmlInclude(typeof(BloodArtistAVR))]
    //[XmlInclude(typeof(BloodflowConnoisseurAVR))]
    //[XmlInclude(typeof(BoneSplintersAVR))]
    //[XmlInclude(typeof(BonfireoftheDamnedAVR))]
    //[XmlInclude(typeof(BorderlandRangerAVR))]
    //[XmlInclude(typeof(BowerPassageAVR))]
    //[XmlInclude(typeof(BrunaLightofAlabasterAVR))]
    //[XmlInclude(typeof(BuildersBlessingAVR))]
    //[XmlInclude(typeof(BurnattheStakeAVR))]
    //[XmlInclude(typeof(ButcherGhoulAVR))]
    //[XmlInclude(typeof(CalltoServeAVR))]
    //[XmlInclude(typeof(CaptainoftheMistsAVR))]
    //[XmlInclude(typeof(CatharsCrusadeAVR))]
    //[XmlInclude(typeof(CathedralSanctifierAVR))]
    //[XmlInclude(typeof(CavernofSoulsAVR))]
    //[XmlInclude(typeof(ChampionofLambholtAVR))]
    //[XmlInclude(typeof(CloudshiftAVR))]
    //[XmlInclude(typeof(CommandersAuthorityAVR))]
    //[XmlInclude(typeof(ConjurersClosetAVR))]
    //[XmlInclude(typeof(CorpseTradersAVR))]
    //[XmlInclude(typeof(CraterhoofBehemothAVR))]
    //[XmlInclude(typeof(CripplingChillAVR))]
    //[XmlInclude(typeof(CryptCreeperAVR))]
    //[XmlInclude(typeof(CursebreakAVR))]
    //[XmlInclude(typeof(DangerousWagerAVR))]
    //[XmlInclude(typeof(DarkImpostorAVR))]
    //[XmlInclude(typeof(DeadeyeNavigatorAVR))]
    //[XmlInclude(typeof(DeathWindAVR))]
    //[XmlInclude(typeof(DefangAVR))]
    //[XmlInclude(typeof(DefyDeathAVR))]
    //[XmlInclude(typeof(DemolishAVR))]
    //[XmlInclude(typeof(DemonicRisingAVR))]
    //[XmlInclude(typeof(DemonicTaskmasterAVR))]
    //[XmlInclude(typeof(DemonlordofAshmouthAVR))]
    //[XmlInclude(typeof(DescendantsPathAVR))]
    //[XmlInclude(typeof(DescentintoMadnessAVR))]
    //[XmlInclude(typeof(DesolateLighthouseAVR))]
    //[XmlInclude(typeof(DevastationTideAVR))]
    //[XmlInclude(typeof(DevoutChaplainAVR))]
    //[XmlInclude(typeof(DiregrafEscortAVR))]
    //[XmlInclude(typeof(DivineDeflectionAVR))]
    //[XmlInclude(typeof(DreadSlaverAVR))]
    //[XmlInclude(typeof(DreadwatersAVR))]
    //[XmlInclude(typeof(DriveroftheDeadAVR))]
    //[XmlInclude(typeof(DruidsFamiliarAVR))]
    //[XmlInclude(typeof(DruidsRepositoryAVR))]
    //[XmlInclude(typeof(DualCastingAVR))]
    //[XmlInclude(typeof(EatenbySpidersAVR))]
    //[XmlInclude(typeof(ElgaudShieldmateAVR))]
    //[XmlInclude(typeof(EmancipationAngelAVR))]
    //[XmlInclude(typeof(EntreattheAngelsAVR))]
    //[XmlInclude(typeof(EssenceHarvestAVR))]
    //[XmlInclude(typeof(EvernightShadeAVR))]
    //[XmlInclude(typeof(ExquisiteBloodAVR))]
    //[XmlInclude(typeof(FalkenrathExterminatorAVR))]
    //[XmlInclude(typeof(FarbogExplorerAVR))]
    //[XmlInclude(typeof(FavorableWindsAVR))]
    //[XmlInclude(typeof(FerventCatharAVR))]
    //[XmlInclude(typeof(FettergeistAVR))]
    //[XmlInclude(typeof(FleetingDistractionAVR))]
    //[XmlInclude(typeof(FloweringLumberknotAVR))]
    //[XmlInclude(typeof(ForestAVR))]
    //[XmlInclude(typeof(GallowsatWillowHillAVR))]
    //[XmlInclude(typeof(GalvanicAlchemistAVR))]
    //[XmlInclude(typeof(GangofDevilsAVR))]
    //[XmlInclude(typeof(GeistSnatchAVR))]
    //[XmlInclude(typeof(GeistTrappersAVR))]
    //[XmlInclude(typeof(GhostformAVR))]
    //[XmlInclude(typeof(GhostlyFlickerAVR))]
    //[XmlInclude(typeof(GhostlyTouchAVR))]
    //[XmlInclude(typeof(GhoulfleshAVR))]
    //[XmlInclude(typeof(GiselaBladeofGoldnightAVR))]
    //[XmlInclude(typeof(GloomSurgeonAVR))]
    //[XmlInclude(typeof(GloomwidowAVR))]
    //[XmlInclude(typeof(GoldnightCommanderAVR))]
    //[XmlInclude(typeof(GoldnightRedeemerAVR))]
    //[XmlInclude(typeof(GraveExchangeAVR))]
    //[XmlInclude(typeof(GriselbrandAVR))]
    //[XmlInclude(typeof(GroundedAVR))]
    //[XmlInclude(typeof(GryffVanguardAVR))]
    //[XmlInclude(typeof(GuiseofFireAVR))]
    //[XmlInclude(typeof(HanweirLancerAVR))]
    //[XmlInclude(typeof(HarvesterofSoulsAVR))]
    //[XmlInclude(typeof(HauntedGuardianAVR))]
    //[XmlInclude(typeof(HavengulSkaabAVR))]
    //[XmlInclude(typeof(HavengulVampireAVR))]
    //[XmlInclude(typeof(HeirsofStromkirkAVR))]
    //[XmlInclude(typeof(HeraldofWarAVR))]
    //[XmlInclude(typeof(HolyJusticiarAVR))]
    //[XmlInclude(typeof(HomicidalSeclusionAVR))]
    //[XmlInclude(typeof(HoundofGriselbrandAVR))]
    //[XmlInclude(typeof(HowlgeistAVR))]
    //[XmlInclude(typeof(HumanFrailtyAVR))]
    //[XmlInclude(typeof(HuntedGhoulAVR))]
    //[XmlInclude(typeof(InfiniteReflectionAVR))]
    //[XmlInclude(typeof(IntotheVoidAVR))]
    //[XmlInclude(typeof(IslandAVR))]
    //[XmlInclude(typeof(JointAssaultAVR))]
    //[XmlInclude(typeof(KessigMalcontentsAVR))]
    //[XmlInclude(typeof(KillingWaveAVR))]
    //[XmlInclude(typeof(KruinStrikerAVR))]
    //[XmlInclude(typeof(LairDelveAVR))]
    //[XmlInclude(typeof(LatchSeekerAVR))]
    //[XmlInclude(typeof(LeapofFaithAVR))]
    //[XmlInclude(typeof(LightningMaulerAVR))]
    //[XmlInclude(typeof(LightningProwessAVR))]
    //[XmlInclude(typeof(LoneRevenantAVR))]
    //[XmlInclude(typeof(LunarMysticAVR))]
    //[XmlInclude(typeof(MaalfeldTwinsAVR))]
    //[XmlInclude(typeof(MadProphetAVR))]
    //[XmlInclude(typeof(MaliciousIntentAVR))]
    //[XmlInclude(typeof(MalignusAVR))]
    //[XmlInclude(typeof(MarrowBatsAVR))]
    //[XmlInclude(typeof(MassAppealAVR))]
    //[XmlInclude(typeof(MentalAgonyAVR))]
    //[XmlInclude(typeof(MidnightDuelistAVR))]
    //[XmlInclude(typeof(MidvastProtectorAVR))]
    //[XmlInclude(typeof(MistRavenAVR))]
    //[XmlInclude(typeof(MisthollowGriffinAVR))]
    //[XmlInclude(typeof(MoonlightGeistAVR))]
    //[XmlInclude(typeof(MoonsilverSpearAVR))]
    //[XmlInclude(typeof(MoorlandInquisitorAVR))]
    //[XmlInclude(typeof(MountainAVR))]
    //[XmlInclude(typeof(NarstadScrapperAVR))]
    //[XmlInclude(typeof(NaturalEndAVR))]
    //[XmlInclude(typeof(NearheathPilgrimAVR))]
    //[XmlInclude(typeof(NecrobiteAVR))]
    //[XmlInclude(typeof(NephaliaSmugglerAVR))]
    //[XmlInclude(typeof(NettleSwineAVR))]
    //[XmlInclude(typeof(NightshadePeddlerAVR))]
    //[XmlInclude(typeof(OtherworldAtlasAVR))]
    //[XmlInclude(typeof(OutwitAVR))]
    //[XmlInclude(typeof(PathbreakerWurmAVR))]
    //[XmlInclude(typeof(PeelfromRealityAVR))]
    //[XmlInclude(typeof(PillarofFlameAVR))]
    //[XmlInclude(typeof(PlainsAVR))]
    //[XmlInclude(typeof(PollutedDeadAVR))]
    //[XmlInclude(typeof(PredatorsGambitAVR))]
    //[XmlInclude(typeof(PrimalSurgeAVR))]
    //[XmlInclude(typeof(RagingPoltergeistAVR))]
    //[XmlInclude(typeof(RainofThornsAVR))]
    //[XmlInclude(typeof(ReforgetheSoulAVR))]
    //[XmlInclude(typeof(RenegadeDemonAVR))]
    //[XmlInclude(typeof(RestorationAngelAVR))]
    //[XmlInclude(typeof(RevengeoftheHuntedAVR))]
    //[XmlInclude(typeof(RidersofGavonyAVR))]
    //[XmlInclude(typeof(RighteousBlowAVR))]
    //[XmlInclude(typeof(RiotRingleaderAVR))]
    //[XmlInclude(typeof(RiteofRuinAVR))]
    //[XmlInclude(typeof(RotcrownGhoulAVR))]
    //[XmlInclude(typeof(RushofBloodAVR))]
    //[XmlInclude(typeof(ScaldingDevilAVR))]
    //[XmlInclude(typeof(ScrapskinDrakeAVR))]
    //[XmlInclude(typeof(ScrollofAvacynAVR))]
    //[XmlInclude(typeof(ScrollofGriselbrandAVR))]
    //[XmlInclude(typeof(SearchlightGeistAVR))]
    //[XmlInclude(typeof(SecondGuessAVR))]
    //[XmlInclude(typeof(SeraphofDawnAVR))]
    //[XmlInclude(typeof(SeraphSanctuaryAVR))]
    //[XmlInclude(typeof(ShelteringWordAVR))]
    //[XmlInclude(typeof(SigardaHostofHeronsAVR))]
    //[XmlInclude(typeof(SilverbladePaladinAVR))]
    //[XmlInclude(typeof(SlayersStrongholdAVR))]
    //[XmlInclude(typeof(SnaretheSkiesAVR))]
    //[XmlInclude(typeof(SomberwaldSageAVR))]
    //[XmlInclude(typeof(SomberwaldVigilanteAVR))]
    //[XmlInclude(typeof(SouloftheHarvestAVR))]
    //[XmlInclude(typeof(SoulcageFiendAVR))]
    //[XmlInclude(typeof(SpectralGateguardsAVR))]
    //[XmlInclude(typeof(SpectralPrisonAVR))]
    //[XmlInclude(typeof(SpiritAwayAVR))]
    //[XmlInclude(typeof(SternMentorAVR))]
    //[XmlInclude(typeof(StolenGoodsAVR))]
    //[XmlInclude(typeof(StonewrightAVR))]
    //[XmlInclude(typeof(SwampAVR))]
    //[XmlInclude(typeof(TamiyotheMoonSageAVR))]
    //[XmlInclude(typeof(TandemLookoutAVR))]
    //[XmlInclude(typeof(TemporalMasteryAVR))]
    //[XmlInclude(typeof(TerminusAVR))]
    //[XmlInclude(typeof(TerrifyingPresenceAVR))]
    //[XmlInclude(typeof(ThatcherRevoltAVR))]
    //[XmlInclude(typeof(ThrabenValiantAVR))]
    //[XmlInclude(typeof(ThunderboltAVR))]
    //[XmlInclude(typeof(ThunderousWrathAVR))]
    //[XmlInclude(typeof(TibalttheFiendBloodedAVR))]
    //[XmlInclude(typeof(TimberlandGuideAVR))]
    //[XmlInclude(typeof(TormentorsTridentAVR))]
    //[XmlInclude(typeof(TreacherousPitDwellerAVR))]
    //[XmlInclude(typeof(TriumphofCrueltyAVR))]
    //[XmlInclude(typeof(TriumphofFerocityAVR))]
    //[XmlInclude(typeof(TrustedForcemageAVR))]
    //[XmlInclude(typeof(TyrantofDiscordAVR))]
    //[XmlInclude(typeof(UlvenwaldTrackerAVR))]
    //[XmlInclude(typeof(UncannySpeedAVR))]
    //[XmlInclude(typeof(UndeadExecutionerAVR))]
    //[XmlInclude(typeof(UnhallowedPactAVR))]
    //[XmlInclude(typeof(VanguardsShieldAVR))]
    //[XmlInclude(typeof(VanishmentAVR))]
    //[XmlInclude(typeof(VesselofEndlessRestAVR))]
    //[XmlInclude(typeof(VexingDevilAVR))]
    //[XmlInclude(typeof(VigilanteJusticeAVR))]
    //[XmlInclude(typeof(VoiceoftheProvincesAVR))]
    //[XmlInclude(typeof(VorstclawAVR))]
    //[XmlInclude(typeof(WanderingWolfAVR))]
    //[XmlInclude(typeof(WildDefianceAVR))]
    //[XmlInclude(typeof(WildwoodGeistAVR))]
    //[XmlInclude(typeof(WingcrafterAVR))]
    //[XmlInclude(typeof(WolfirAvengerAVR))]
    //[XmlInclude(typeof(WolfirSilverheartAVR))]
    //[XmlInclude(typeof(YewSpiritAVR))]
    //[XmlInclude(typeof(ZealousConscriptsAVR))]
    //[XmlInclude(typeof(ZealousStrikeAVR))]
    //#endregion
    //# region RTR
    //[XmlInclude(typeof(AbruptDecay))]
    //[XmlInclude(typeof(AerialPredation))]
    //[XmlInclude(typeof(AngelofSerenity))]
    //[XmlInclude(typeof(AnnihilatingFire))]
    //[XmlInclude(typeof(AquusSteed))]
    //[XmlInclude(typeof(ArchonoftheTriumvirate))]
    //[XmlInclude(typeof(Archweaver))]
    //[XmlInclude(typeof(ArmadaWurm))]
    //[XmlInclude(typeof(ArmoryGuard))]
    //[XmlInclude(typeof(Arrest))]
    //[XmlInclude(typeof(AshZealot))]
    //[XmlInclude(typeof(AssassinsStrike))]
    //[XmlInclude(typeof(AugerSpree))]
    //[XmlInclude(typeof(AvengingArrow))]
    //[XmlInclude(typeof(AxebaneGuardian))]
    //[XmlInclude(typeof(AxebaneStag))]
    //[XmlInclude(typeof(AzoriusArrester))]
    //[XmlInclude(typeof(AzoriusCharm))]
    //[XmlInclude(typeof(AzoriusGuildgate))]
    //[XmlInclude(typeof(AzoriusJusticiar))]
    //[XmlInclude(typeof(AzoriusKeyrune))]
    //[XmlInclude(typeof(AzorsElocutors))]
    //[XmlInclude(typeof(Batterhorn))]
    //[XmlInclude(typeof(BazaarKrovod))]
    //[XmlInclude(typeof(BellowsLizard))]
    //[XmlInclude(typeof(BlistercoilWeird))]
    //[XmlInclude(typeof(BloodCrypt))]
    //[XmlInclude(typeof(BloodfrayGiant))]
    //[XmlInclude(typeof(Blustersquall))]
    //[XmlInclude(typeof(Brushstrider))]
    //[XmlInclude(typeof(CalloftheConclave))]
    //[XmlInclude(typeof(Cancel))]
    //[XmlInclude(typeof(CarnivalHellsteed))]
    //[XmlInclude(typeof(CatacombSlug))]
    //[XmlInclude(typeof(CentaurHealer))]
    //[XmlInclude(typeof(CentaursHerald))]
    //[XmlInclude(typeof(ChaosImps))]
    //[XmlInclude(typeof(ChemistersTrick))]
    //[XmlInclude(typeof(ChorusofMight))]
    //[XmlInclude(typeof(ChromaticLantern))]
    //[XmlInclude(typeof(ChronicFlooding))]
    //[XmlInclude(typeof(CivicSaber))]
    //[XmlInclude(typeof(Cobblebrute))]
    //[XmlInclude(typeof(CodexShredder))]
    //[XmlInclude(typeof(CollectiveBlessing))]
    //[XmlInclude(typeof(CommonBond))]
    //[XmlInclude(typeof(ConcordiaPegasus))]
    //[XmlInclude(typeof(ConjuredCurrency))]
    //[XmlInclude(typeof(CorpsejackMenace))]
    //[XmlInclude(typeof(Counterflux))]
    //[XmlInclude(typeof(CoursersAccord))]
    //[XmlInclude(typeof(Cremate))]
    //[XmlInclude(typeof(CrosstownCourier))]
    //[XmlInclude(typeof(CryptbornHorror))]
    //[XmlInclude(typeof(CyclonicRift))]
    //[XmlInclude(typeof(DaggerdromeImp))]
    //[XmlInclude(typeof(DarkRevenant))]
    //[XmlInclude(typeof(DeadReveler))]
    //[XmlInclude(typeof(DeadbridgeGoliath))]
    //[XmlInclude(typeof(DeathriteShaman))]
    //[XmlInclude(typeof(DeathsPresence))]
    //[XmlInclude(typeof(DesecrationDemon))]
    //[XmlInclude(typeof(DestroytheEvidence))]
    //[XmlInclude(typeof(DetentionSphere))]
    //[XmlInclude(typeof(DeviantGlee))]
    //[XmlInclude(typeof(Dispel))]
    //[XmlInclude(typeof(Doorkeeper))]
    //[XmlInclude(typeof(Downsize))]
    //[XmlInclude(typeof(DrainpipeVermin))]
    //[XmlInclude(typeof(DramaticRescue))]
    //[XmlInclude(typeof(Dreadbore))]
    //[XmlInclude(typeof(DregMangler))]
    //[XmlInclude(typeof(DrudgeBeetle))]
    //[XmlInclude(typeof(DruidsDeliverance))]
    //[XmlInclude(typeof(DryadMilitant))]
    //[XmlInclude(typeof(Dynacharge))]
    //[XmlInclude(typeof(Electrickery))]
    //[XmlInclude(typeof(EpicExperiment))]
    //[XmlInclude(typeof(EssenceBacklash))]
    //[XmlInclude(typeof(EtherealArmor))]
    //[XmlInclude(typeof(ExplosiveImpact))]
    //[XmlInclude(typeof(EyesintheSkies))]
    //[XmlInclude(typeof(FaerieImpostor))]
    //[XmlInclude(typeof(FalloftheGavel))]
    //[XmlInclude(typeof(FencingAce))]
    //[XmlInclude(typeof(FiremindsForesight))]
    //[XmlInclude(typeof(Forest))]
    //[XmlInclude(typeof(FrostburnWeird))]
    //[XmlInclude(typeof(GatecreeperVine))]
    //[XmlInclude(typeof(GiantGrowth))]
    //[XmlInclude(typeof(GobblingOoze))]
    //[XmlInclude(typeof(GoblinElectromancer))]
    //[XmlInclude(typeof(GoblinRally))]
    //[XmlInclude(typeof(GolgariCharm))]
    //[XmlInclude(typeof(GolgariDecoy))]
    //[XmlInclude(typeof(GolgariGuildgate))]
    //[XmlInclude(typeof(GolgariKeyrune))]
    //[XmlInclude(typeof(GolgariLonglegs))]
    //[XmlInclude(typeof(GoreHouseChainwalker))]
    //[XmlInclude(typeof(GraveBetrayal))]
    //[XmlInclude(typeof(GrimRoustabout))]
    //[XmlInclude(typeof(GrislySalvage))]
    //[XmlInclude(typeof(GroveoftheGuardian))]
    //[XmlInclude(typeof(GrowingRanks))]
    //[XmlInclude(typeof(GuildFeud))]
    //[XmlInclude(typeof(Guttersnipe))]
    //[XmlInclude(typeof(HallowedFountain))]
    //[XmlInclude(typeof(HavocFestival))]
    //[XmlInclude(typeof(HellholeFlailer))]
    //[XmlInclude(typeof(HeroesReunion))]
    //[XmlInclude(typeof(HorncallersChant))]
    //[XmlInclude(typeof(HoverBarrier))]
    //[XmlInclude(typeof(HussarPatrol))]
    //[XmlInclude(typeof(HypersonicDragon))]
    //[XmlInclude(typeof(InactionInjunction))]
    //[XmlInclude(typeof(Inspiration))]
    //[XmlInclude(typeof(Island))]
    //[XmlInclude(typeof(IsperiaSupremeJudge))]
    //[XmlInclude(typeof(IsperiasSkywatch))]
    //[XmlInclude(typeof(IzzetCharm))]
    //[XmlInclude(typeof(IzzetGuildgate))]
    //[XmlInclude(typeof(IzzetKeyrune))]
    //[XmlInclude(typeof(IzzetStaticaster))]
    //[XmlInclude(typeof(JaceArchitectofThought))]
    //[XmlInclude(typeof(JaradGolgariLichLord))]
    //[XmlInclude(typeof(JaradsOrders))]
    //[XmlInclude(typeof(JudgesFamiliar))]
    //[XmlInclude(typeof(KeeningApparition))]
    //[XmlInclude(typeof(KnightlyValor))]
    //[XmlInclude(typeof(KorozdaGuildmage))]
    //[XmlInclude(typeof(KorozdaMonitor))]
    //[XmlInclude(typeof(LaunchParty))]
    //[XmlInclude(typeof(LobberCrew))]
    //[XmlInclude(typeof(LotlethTroll))]
    //[XmlInclude(typeof(LoxodonSmiter))]
    //[XmlInclude(typeof(LyevSkyknight))]
    //[XmlInclude(typeof(ManaBloom))]
    //[XmlInclude(typeof(MartialLaw))]
    //[XmlInclude(typeof(MercurialChemister))]
    //[XmlInclude(typeof(MindRot))]
    //[XmlInclude(typeof(MinotaurAggressor))]
    //[XmlInclude(typeof(MizziumMortars))]
    //[XmlInclude(typeof(MizziumSkin))]
    //[XmlInclude(typeof(Mountain))]
    //[XmlInclude(typeof(NecropolisRegent))]
    //[XmlInclude(typeof(NewPrahvGuildmage))]
    //[XmlInclude(typeof(NivixGuildmage))]
    //[XmlInclude(typeof(NivmagusElemental))]
    //[XmlInclude(typeof(NivMizzetDracogenius))]
    //[XmlInclude(typeof(OakStreetInnkeeper))]
    //[XmlInclude(typeof(OgreJailbreaker))]
    //[XmlInclude(typeof(OvergrownTomb))]
    //[XmlInclude(typeof(PackRat))]
    //[XmlInclude(typeof(PalisadeGiant))]
    //[XmlInclude(typeof(ParalyzingGrasp))]
    //[XmlInclude(typeof(PerilousShadow))]
    //[XmlInclude(typeof(PhantomGeneral))]
    //[XmlInclude(typeof(PithingNeedle))]
    //[XmlInclude(typeof(Plains))]
    //[XmlInclude(typeof(PrecinctCaptain))]
    //[XmlInclude(typeof(PsychicSpiral))]
    //[XmlInclude(typeof(PursuitofFlight))]
    //[XmlInclude(typeof(Pyroconvergence))]
    //[XmlInclude(typeof(RacecourseFury))]
    //[XmlInclude(typeof(RakdosCackler))]
    //[XmlInclude(typeof(RakdosCharm))]
    //[XmlInclude(typeof(RakdosGuildgate))]
    //[XmlInclude(typeof(RakdosKeyrune))]
    //[XmlInclude(typeof(RakdosRagemutt))]
    //[XmlInclude(typeof(RakdosRingleader))]
    //[XmlInclude(typeof(RakdosShredFreak))]
    //[XmlInclude(typeof(RakdosLordofRiots))]
    //[XmlInclude(typeof(RakdossReturn))]
    //[XmlInclude(typeof(RestinPeace))]
    //[XmlInclude(typeof(RighteousAuthority))]
    //[XmlInclude(typeof(RisenSanctuary))]
    //[XmlInclude(typeof(RitesofReaping))]
    //[XmlInclude(typeof(RixMaadiGuildmage))]
    //[XmlInclude(typeof(RoguesPassage))]
    //[XmlInclude(typeof(RootbornDefenses))]
    //[XmlInclude(typeof(RubblebackRhino))]
    //[XmlInclude(typeof(Runewing))]
    //[XmlInclude(typeof(SavageSurge))]
    //[XmlInclude(typeof(SearchtheCity))]
    //[XmlInclude(typeof(SearchWarrant))]
    //[XmlInclude(typeof(SecurityBlockade))]
    //[XmlInclude(typeof(SeektheHorizon))]
    //[XmlInclude(typeof(SelesnyaCharm))]
    //[XmlInclude(typeof(SelesnyaGuildgate))]
    //[XmlInclude(typeof(SelesnyaKeyrune))]
    //[XmlInclude(typeof(SelesnyaSentry))]
    //[XmlInclude(typeof(SellerofSongbirds))]
    //[XmlInclude(typeof(SewerShambler))]
    //[XmlInclude(typeof(ShriekingAffliction))]
    //[XmlInclude(typeof(SkullRend))]
    //[XmlInclude(typeof(SkylinePredator))]
    //[XmlInclude(typeof(SkymarkRoc))]
    //[XmlInclude(typeof(SlaughterGames))]
    //[XmlInclude(typeof(SlimeMolding))]
    //[XmlInclude(typeof(Slitherhead))]
    //[XmlInclude(typeof(SluicewayScorpion))]
    //[XmlInclude(typeof(SlumReaper))]
    //[XmlInclude(typeof(SoulTithe))]
    //[XmlInclude(typeof(SoulswornSpirit))]
    //[XmlInclude(typeof(SpawnofRixMaadi))]
    //[XmlInclude(typeof(SphereofSafety))]
    //[XmlInclude(typeof(SphinxoftheChimes))]
    //[XmlInclude(typeof(SphinxsRevelation))]
    //[XmlInclude(typeof(SplatterThug))]
    //[XmlInclude(typeof(StabWound))]
    //[XmlInclude(typeof(StealerofSecrets))]
    //[XmlInclude(typeof(SteamVents))]
    //[XmlInclude(typeof(StonefareCrocodile))]
    //[XmlInclude(typeof(StreetSpasm))]
    //[XmlInclude(typeof(StreetSweeper))]
    //[XmlInclude(typeof(SunderingGrowth))]
    //[XmlInclude(typeof(SunspireGriffin))]
    //[XmlInclude(typeof(SupremeVerdict))]
    //[XmlInclude(typeof(SurveytheWreckage))]
    //[XmlInclude(typeof(Swamp))]
    //[XmlInclude(typeof(SwiftJustice))]
    //[XmlInclude(typeof(Syncopate))]
    //[XmlInclude(typeof(TabletoftheGuilds))]
    //[XmlInclude(typeof(TavernSwindler))]
    //[XmlInclude(typeof(Teleportal))]
    //[XmlInclude(typeof(TempleGarden))]
    //[XmlInclude(typeof(TenementCrasher))]
    //[XmlInclude(typeof(TerrusWurm))]
    //[XmlInclude(typeof(Thoughtflare))]
    //[XmlInclude(typeof(ThrillKillAssassin))]
    //[XmlInclude(typeof(TowerDrake))]
    //[XmlInclude(typeof(ToweringIndrik))]
    //[XmlInclude(typeof(TrainedCaracal))]
    //[XmlInclude(typeof(TraitorousInstinct))]
    //[XmlInclude(typeof(TransguildPromenade))]
    //[XmlInclude(typeof(TreasuredFind))]
    //[XmlInclude(typeof(TrestleTroll))]
    //[XmlInclude(typeof(TrostaniSelesnyasVoice))]
    //[XmlInclude(typeof(TrostanisJudgment))]
    //[XmlInclude(typeof(UltimatePrice))]
    //[XmlInclude(typeof(UnderworldConnections))]
    //[XmlInclude(typeof(UrbanBurgeoning))]
    //[XmlInclude(typeof(UtvaraHellkite))]
    //[XmlInclude(typeof(Vandalblast))]
    //[XmlInclude(typeof(VassalSoul))]
    //[XmlInclude(typeof(ViashinoRacketeer))]
    //[XmlInclude(typeof(VituGhaziGuildmage))]
    //[XmlInclude(typeof(Voidwielder))]
    //[XmlInclude(typeof(VolatileRig))]
    //[XmlInclude(typeof(VraskatheUnseen))]
    //[XmlInclude(typeof(WayfaringTemple))]
    //[XmlInclude(typeof(WildBeastmaster))]
    //[XmlInclude(typeof(WorldspineWurm))]
    //[XmlInclude(typeof(ZanikevLocust))]
    //# endregion
    //# region GTC
    //[XmlInclude(typeof(ActofTreason))]
    //[XmlInclude(typeof(AdaptiveSnapjaw))]
    //[XmlInclude(typeof(AerialManeuver))]
    //[XmlInclude(typeof(AEtherize))]
    //[XmlInclude(typeof(Agoraphobia))]
    //[XmlInclude(typeof(AlmsBeast))]
    //[XmlInclude(typeof(AlphaAuthority))]
    //[XmlInclude(typeof(AngelicEdict))]
    //[XmlInclude(typeof(AngelicSkirmisher))]
    //[XmlInclude(typeof(ArmoredTransport))]
    //[XmlInclude(typeof(ArrowsofJustice))]
    //[XmlInclude(typeof(AssaultGriffin))]
    //[XmlInclude(typeof(AssembletheLegion))]
    //[XmlInclude(typeof(AureliatheWarleader))]
    //[XmlInclude(typeof(AureliasFury))]
    //[XmlInclude(typeof(BalustradeSpy))]
    //[XmlInclude(typeof(BaneAlleyBroker))]
    //[XmlInclude(typeof(BasilicaGuards))]
    //[XmlInclude(typeof(BasilicaScreecher))]
    //[XmlInclude(typeof(BeckonApparition))]
    //[XmlInclude(typeof(BiomassMutation))]
    //[XmlInclude(typeof(Bioshift))]
    //[XmlInclude(typeof(Biovisionary))]
    //[XmlInclude(typeof(BlindObedience))]
    //[XmlInclude(typeof(BomberCorps))]
    //[XmlInclude(typeof(BorborygmosEnraged))]
    //[XmlInclude(typeof(BorosCharm))]
    //[XmlInclude(typeof(BorosElite))]
    //[XmlInclude(typeof(BorosGuildgate))]
    //[XmlInclude(typeof(BorosKeyrune))]
    //[XmlInclude(typeof(BorosReckoner))]
    //[XmlInclude(typeof(BreedingPool))]
    //[XmlInclude(typeof(BurningTreeEmissary))]
    //[XmlInclude(typeof(BurstofStrength))]
    //[XmlInclude(typeof(CalloftheNightwing))]
    //[XmlInclude(typeof(CartelAristocrat))]
    //[XmlInclude(typeof(CinderElemental))]
    //[XmlInclude(typeof(ClanDefiance))]
    //[XmlInclude(typeof(ClingingAnemones))]
    //[XmlInclude(typeof(CloudfinRaptor))]
    //[XmlInclude(typeof(CoercedConfession))]
    //[XmlInclude(typeof(ConsumingAberration))]
    //[XmlInclude(typeof(ContaminatedGround))]
    //[XmlInclude(typeof(CorpseBlockade))]
    //[XmlInclude(typeof(CourtStreetDenizen))]
    //[XmlInclude(typeof(CracklingPerimeter))]
    //[XmlInclude(typeof(Crocanura))]
    //[XmlInclude(typeof(CrownedCeratok))]
    //[XmlInclude(typeof(CryptGhast))]
    //[XmlInclude(typeof(DaringSkyjek))]
    //[XmlInclude(typeof(DeathcultRogue))]
    //[XmlInclude(typeof(DeathpactAngel))]
    //[XmlInclude(typeof(DeathsApproach))]
    //[XmlInclude(typeof(DebtorsPulpit))]
    //[XmlInclude(typeof(DevourFlesh))]
    //[XmlInclude(typeof(DiluvianPrimordial))]
    //[XmlInclude(typeof(DimirCharm))]
    //[XmlInclude(typeof(DimirGuildgate))]
    //[XmlInclude(typeof(DimirKeyrune))]
    //[XmlInclude(typeof(DinrovaHorror))]
    //[XmlInclude(typeof(DinrovaHorror))]
    //[XmlInclude(typeof(DiscipleoftheOldWays))]
    //[XmlInclude(typeof(DomriRade))]
    //[XmlInclude(typeof(DrakewingKrasis))]
    //[XmlInclude(typeof(DuskmantleGuildmage))]
    //[XmlInclude(typeof(DuskmantleSeer))]
    //[XmlInclude(typeof(DutifulThrull))]
    //[XmlInclude(typeof(DyingWish))]
    //[XmlInclude(typeof(ElusiveKrasis))]
    //[XmlInclude(typeof(EmberBeast))]
    //[XmlInclude(typeof(EntertheInfinite))]
    //[XmlInclude(typeof(ExecutionersSwing))]
    //[XmlInclude(typeof(ExperimentOne))]
    //[XmlInclude(typeof(FathomMage))]
    //[XmlInclude(typeof(FirefistStriker))]
    //[XmlInclude(typeof(FiremaneAvenger))]
    //[XmlInclude(typeof(FiveAlarmFire))]
    //[XmlInclude(typeof(ForcedAdaptation))]
    //[XmlInclude(typeof(FortressCyclops))]
    //[XmlInclude(typeof(FoundryChampion))]
    //[XmlInclude(typeof(FoundryStreetDenizen))]
    //[XmlInclude(typeof(FrenziedTilling))]
    //[XmlInclude(typeof(FrilledOculus))]
    //[XmlInclude(typeof(FrontlineMedic))]
    //[XmlInclude(typeof(FuriousResistance))]
    //[XmlInclude(typeof(GatewayShade))]
    //[XmlInclude(typeof(GhorClanRampager))]
    //[XmlInclude(typeof(GiantAdephage))]
    //[XmlInclude(typeof(GideonChampionofJustice))]
    //[XmlInclude(typeof(GiftofOrzhova))]
    //[XmlInclude(typeof(GlaringSpotlight))]
    //[XmlInclude(typeof(GodlessShrine))]
    //[XmlInclude(typeof(GreensideWatcher))]
    //[XmlInclude(typeof(Gridlock))]
    //[XmlInclude(typeof(GrislySpectacle))]
    //[XmlInclude(typeof(GroundAssault))]
    //[XmlInclude(typeof(GruulCharm))]
    //[XmlInclude(typeof(GruulGuildgate))]
    //[XmlInclude(typeof(GruulKeyrune))]
    //[XmlInclude(typeof(GruulRagebeast))]
    //[XmlInclude(typeof(GuardianoftheGateless))]
    //[XmlInclude(typeof(GuildscornWard))]
    //[XmlInclude(typeof(GutterSkulk))]
    //[XmlInclude(typeof(GyreSage))]
    //[XmlInclude(typeof(HandsofBinding))]
    //[XmlInclude(typeof(HellkiteTyrant))]
    //[XmlInclude(typeof(HellraiserGoblin))]
    //[XmlInclude(typeof(HighPriestofPenance))]
    //[XmlInclude(typeof(Hindervines))]
    //[XmlInclude(typeof(HoldtheGates))]
    //[XmlInclude(typeof(HolyMantle))]
    //[XmlInclude(typeof(HomingLightning))]
    //[XmlInclude(typeof(HorroroftheDim))]
    //[XmlInclude(typeof(Hydroform))]
    //[XmlInclude(typeof(IllnessintheRanks))]
    //[XmlInclude(typeof(IllusionistsBracers))]
    //[XmlInclude(typeof(ImmortalServitude))]
    //[XmlInclude(typeof(IncursionSpecialist))]
    //[XmlInclude(typeof(IvyLaneDenizen))]
    //[XmlInclude(typeof(KeymasterRogue))]
    //[XmlInclude(typeof(KillingGlare))]
    //[XmlInclude(typeof(KingpinsPet))]
    //[XmlInclude(typeof(KnightofObligation))]
    //[XmlInclude(typeof(KnightWatch))]
    //[XmlInclude(typeof(LastThoughts))]
    //[XmlInclude(typeof(LazavDimirMastermind))]
    //[XmlInclude(typeof(LegionLoyalist))]
    //[XmlInclude(typeof(LeylinePhantom))]
    //[XmlInclude(typeof(LordoftheVoid))]
    //[XmlInclude(typeof(LuminatePrimordial))]
    //[XmlInclude(typeof(MadcapSkills))]
    //[XmlInclude(typeof(MarkforDeath))]
    //[XmlInclude(typeof(MartialGlory))]
    //[XmlInclude(typeof(MassiveRaid))]
    //[XmlInclude(typeof(MasterBiomancer))]
    //[XmlInclude(typeof(MentalVapors))]
    //[XmlInclude(typeof(MercilessEviction))]
    //[XmlInclude(typeof(MerfolkoftheDepths))]
    //[XmlInclude(typeof(MetropolisSprite))]
    //[XmlInclude(typeof(MidnightRecovery))]
    //[XmlInclude(typeof(MillennialGargoyle))]
    //[XmlInclude(typeof(MimingSlime))]
    //[XmlInclude(typeof(MindGrind))]
    //[XmlInclude(typeof(MindeyeDrake))]
    //[XmlInclude(typeof(MoltenPrimordial))]
    //[XmlInclude(typeof(MortusStrider))]
    //[XmlInclude(typeof(Mugging))]
    //[XmlInclude(typeof(MurderInvestigation))]
    //[XmlInclude(typeof(MysticGenesis))]
    //[XmlInclude(typeof(Naturalize))]
    //[XmlInclude(typeof(NavSquadCommandos))]
    //[XmlInclude(typeof(NightveilSpecter))]
    //[XmlInclude(typeof(NimbusSwimmer))]
    //[XmlInclude(typeof(ObzedatGhostCouncil))]
    //[XmlInclude(typeof(OgreSlumlord))]
    //[XmlInclude(typeof(OneThousandLashes))]
    //[XmlInclude(typeof(OozeFlux))]
    //[XmlInclude(typeof(OrdruunVeteran))]
    //[XmlInclude(typeof(OrzhovCharm))]
    //[XmlInclude(typeof(OrzhovGuildgate))]
    //[XmlInclude(typeof(OrzhovKeyrune))]
    //[XmlInclude(typeof(ParanoidDelusions))]
    //[XmlInclude(typeof(PitFight))]
    //[XmlInclude(typeof(PredatorsRapport))]
    //[XmlInclude(typeof(PrimalVisitation))]
    //[XmlInclude(typeof(PrimeSpeakerZegana))]
    //[XmlInclude(typeof(PropheticPrism))]
    //[XmlInclude(typeof(PsychicStrike))]
    //[XmlInclude(typeof(PurgetheProfane))]
    //[XmlInclude(typeof(RapidHybridization))]
    //[XmlInclude(typeof(RazortipWhip))]
    //[XmlInclude(typeof(Realmwright))]
    //[XmlInclude(typeof(RighteousCharge))]
    //[XmlInclude(typeof(RiotGear))]
    //[XmlInclude(typeof(RipscalePredator))]
    //[XmlInclude(typeof(RubblebeltRaiders))]
    //[XmlInclude(typeof(Rubblehulk))]
    //[XmlInclude(typeof(RuinationWurm))]
    //[XmlInclude(typeof(RuinationWurm))]
    //[XmlInclude(typeof(RustScarab))]
    //[XmlInclude(typeof(SacredFoundry))]
    //[XmlInclude(typeof(SagesRowDenizen))]
    //[XmlInclude(typeof(SapphireDrake))]
    //[XmlInclude(typeof(ScabClanCharger))]
    //[XmlInclude(typeof(ScatterArc))]
    //[XmlInclude(typeof(Scorchwalker))]
    //[XmlInclude(typeof(SepulchralPrimordial))]
    //[XmlInclude(typeof(SereneRemembrance))]
    //[XmlInclude(typeof(ShadowAlleyDenizen))]
    //[XmlInclude(typeof(ShadowSlice))]
    //[XmlInclude(typeof(Shambleshark))]
    //[XmlInclude(typeof(ShatteringBlow))]
    //[XmlInclude(typeof(ShieldedPassage))]
    //[XmlInclude(typeof(SignaltheClans))]
    //[XmlInclude(typeof(SimicCharm))]
    //[XmlInclude(typeof(SimicFluxmage))]
    //[XmlInclude(typeof(SimicGuildgate))]
    //[XmlInclude(typeof(SimicKeyrune))]
    //[XmlInclude(typeof(SimicManipulator))]
    //[XmlInclude(typeof(SkarrgGoliath))]
    //[XmlInclude(typeof(SkarrgGuildmage))]
    //[XmlInclude(typeof(SkinbrandGoblin))]
    //[XmlInclude(typeof(Skullcrack))]
    //[XmlInclude(typeof(SkyblinderStaff))]
    //[XmlInclude(typeof(Skygames))]
    //[XmlInclude(typeof(SkyknightLegionnaire))]
    //[XmlInclude(typeof(SlateStreetRuffian))]
    //[XmlInclude(typeof(Slaughterhorn))]
    //[XmlInclude(typeof(Smite))]
    //[XmlInclude(typeof(SmogElemental))]
    //[XmlInclude(typeof(SoulRansom))]
    //[XmlInclude(typeof(SparkTrooper))]
    //[XmlInclude(typeof(SpellRupture))]
    //[XmlInclude(typeof(SpireTracer))]
    //[XmlInclude(typeof(StolenIdentity))]
    //[XmlInclude(typeof(StompingGround))]
    //[XmlInclude(typeof(StructuralCollapse))]
    //[XmlInclude(typeof(SunhomeGuildmage))]
    //[XmlInclude(typeof(SylvanPrimordial))]
    //[XmlInclude(typeof(SyndicofTithes))]
    //[XmlInclude(typeof(SyndicateEnforcer))]
    //[XmlInclude(typeof(ThespiansStage))]
    //[XmlInclude(typeof(ThrullParasite))]
    //[XmlInclude(typeof(TinStreetMarket))]
    //[XmlInclude(typeof(TotallyLost))]
    //[XmlInclude(typeof(TowerDefense))]
    //[XmlInclude(typeof(ToweringThunderfist))]
    //[XmlInclude(typeof(TreasuryThrull))]
    //[XmlInclude(typeof(TruefirePaladin))]
    //[XmlInclude(typeof(UndercityInformer))]
    //[XmlInclude(typeof(UndercityPlague))]
    //[XmlInclude(typeof(UnexpectedResults))]
    //[XmlInclude(typeof(UrbanEvolution))]
    //[XmlInclude(typeof(UrbisProtector))]
    //[XmlInclude(typeof(VerdantHaven))]
    //[XmlInclude(typeof(ViashinoShanktail))]
    //[XmlInclude(typeof(VizkopaConfessor))]
    //[XmlInclude(typeof(VizkopaGuildmage))]
    //[XmlInclude(typeof(Voidwalk))]
    //[XmlInclude(typeof(WarmindInfantry))]
    //[XmlInclude(typeof(WastelandViper))]
    //[XmlInclude(typeof(WateryGrave))]
    //[XmlInclude(typeof(WayoftheThief))]
    //[XmlInclude(typeof(WhisperingMadness))]
    //[XmlInclude(typeof(WightofPrecinctSix))]
    //[XmlInclude(typeof(WildwoodRebirth))]
    //[XmlInclude(typeof(WojekHalberdiers))]
    //[XmlInclude(typeof(WreckingOgre))]
    //[XmlInclude(typeof(ZameckGuildmage))]
    //[XmlInclude(typeof(ZarichiTiger))]
    //[XmlInclude(typeof(ZhurTaaSwine))]

    //# endregion
    //# region DGM
    //[XmlInclude(typeof(AdventoftheWurm))]
    //[XmlInclude(typeof(AEtherling))]
    //[XmlInclude(typeof(AliveWell))]
    //[XmlInclude(typeof(ArmedDangerous))]
    //[XmlInclude(typeof(ArmoredWolfRider))]
    //[XmlInclude(typeof(AscendedLawmage))]
    //[XmlInclude(typeof(AwefortheGuilds))]
    //[XmlInclude(typeof(AzoriusCluestone))]
    //[XmlInclude(typeof(AzoriusGuildgate))]
    //[XmlInclude(typeof(BaneAlleyBlackguard))]
    //[XmlInclude(typeof(BatteringKrasis))]
    //[XmlInclude(typeof(BeckCall))]
    //[XmlInclude(typeof(BeetleformMage))]
    //[XmlInclude(typeof(BlastofGenius))]
    //[XmlInclude(typeof(BlazeCommando))]
    //[XmlInclude(typeof(BloodBaronofVizkopa))]
    //[XmlInclude(typeof(BloodScrivener))]
    //[XmlInclude(typeof(BorosBattleshaper))]
    //[XmlInclude(typeof(BorosCluestone))]
    //[XmlInclude(typeof(BorosGuildgate))]
    //[XmlInclude(typeof(BorosMastiff))]
    //[XmlInclude(typeof(BreakingEntering))]
    //[XmlInclude(typeof(BredfortheHunt))]
    //[XmlInclude(typeof(BronzebeakMoa))]
    //[XmlInclude(typeof(CarnageGladiator))]
    //[XmlInclude(typeof(CatchRelease))]
    //[XmlInclude(typeof(ClearaPath))]
    //[XmlInclude(typeof(CounciloftheAbsolute))]
    //[XmlInclude(typeof(CryptIncursion))]
    //[XmlInclude(typeof(DeadbridgeChant))]
    //[XmlInclude(typeof(DebttotheDeathless))]
    //[XmlInclude(typeof(DeputyofAcquittals))]
    //[XmlInclude(typeof(DimirCluestone))]
    //[XmlInclude(typeof(DimirGuildgate))]
    //[XmlInclude(typeof(DownDirty))]
    //[XmlInclude(typeof(Dragonshift))]
    //[XmlInclude(typeof(DrowninFilth))]
    //[XmlInclude(typeof(EmmaraTandris))]
    //[XmlInclude(typeof(ExavaRakdosBloodWitch))]
    //[XmlInclude(typeof(FarAway))]
    //[XmlInclude(typeof(FatalFumes))]
    //[XmlInclude(typeof(FeralAnimist))]
    //[XmlInclude(typeof(FleshBlood))]
    //[XmlInclude(typeof(Fluxcharger))]
    //[XmlInclude(typeof(GazeofGranite))]
    //[XmlInclude(typeof(GiveTake))]
    //[XmlInclude(typeof(GleamofBattle))]
    //[XmlInclude(typeof(GoblinTestPilot))]
    //[XmlInclude(typeof(GolgariCluestone))]
    //[XmlInclude(typeof(GolgariGuildgate))]
    //[XmlInclude(typeof(GruulCluestone))]
    //[XmlInclude(typeof(GruulGuildgate))]
    //[XmlInclude(typeof(GruulWarChant))]
    //[XmlInclude(typeof(HaazdaSnareSquad))]
    //[XmlInclude(typeof(HaunterofNightveil))]
    //[XmlInclude(typeof(HiddenStrings))]
    //[XmlInclude(typeof(HiredTorturer))]
    //[XmlInclude(typeof(IzzetCluestone))]
    //[XmlInclude(typeof(IzzetGuildgate))]
    //[XmlInclude(typeof(JelennSphinx))]
    //[XmlInclude(typeof(KorozdaGorgon))]
    //[XmlInclude(typeof(KrasisIncubation))]
    //[XmlInclude(typeof(KraulWarrior))]
    //[XmlInclude(typeof(LaviniaoftheTenth))]
    //[XmlInclude(typeof(LegionsInitiative))]
    //[XmlInclude(typeof(LyevDecree))]
    //[XmlInclude(typeof(MasterofCruelties))]
    //[XmlInclude(typeof(MawoftheObzedat))]
    //[XmlInclude(typeof(MazeAbomination))]
    //[XmlInclude(typeof(MazeBehemoth))]
    //[XmlInclude(typeof(MazeGlider))]
    //[XmlInclude(typeof(MazeRusher))]
    //[XmlInclude(typeof(MazeSentinel))]
    //[XmlInclude(typeof(MazesEnd))]
    //[XmlInclude(typeof(MelekIzzetParagon))]
    //[XmlInclude(typeof(MendingTouch))]
    //[XmlInclude(typeof(Mindstatic))]
    //[XmlInclude(typeof(MirkoVoskMindDrinker))]
    //[XmlInclude(typeof(MorgueBurst))]
    //[XmlInclude(typeof(MurmuringPhantasm))]
    //[XmlInclude(typeof(MutantsPrey))]
    //[XmlInclude(typeof(NivixCyclops))]
    //[XmlInclude(typeof(NotionThief))]
    //[XmlInclude(typeof(ObzedatsAid))]
    //[XmlInclude(typeof(OpalLakeGatekeepers))]
    //[XmlInclude(typeof(OrzhovCluestone))]
    //[XmlInclude(typeof(OrzhovGuildgate))]
    //[XmlInclude(typeof(Phytoburst))]
    //[XmlInclude(typeof(PilferedPlans))]
    //[XmlInclude(typeof(PlasmCapture))]
    //[XmlInclude(typeof(PontiffofBlight))]
    //[XmlInclude(typeof(PossibilityStorm))]
    //[XmlInclude(typeof(ProfitLoss))]
    //[XmlInclude(typeof(ProgenitorMimic))]
    //[XmlInclude(typeof(ProtectServe))]
    //[XmlInclude(typeof(PunishtheEnemy))]
    //[XmlInclude(typeof(Putrefy))]
    //[XmlInclude(typeof(PyrewildShaman))]
    //[XmlInclude(typeof(RakdosCluestone))]
    //[XmlInclude(typeof(RakdosDrake))]
    //[XmlInclude(typeof(RakdosGuildgate))]
    //[XmlInclude(typeof(RalZarek))]
    //[XmlInclude(typeof(ReadyWilling))]
    //[XmlInclude(typeof(ReapIntellect))]
    //[XmlInclude(typeof(RenderSilent))]
    //[XmlInclude(typeof(RenegadeKrasis))]
    //[XmlInclude(typeof(RenouncetheGuilds))]
    //[XmlInclude(typeof(RestorethePeace))]
    //[XmlInclude(typeof(RiotControl))]
    //[XmlInclude(typeof(RiotPiker))]
    //[XmlInclude(typeof(RotFarmSkeleton))]
    //[XmlInclude(typeof(RubblebeltMaaka))]
    //[XmlInclude(typeof(RunnersBane))]
    //[XmlInclude(typeof(RuricThartheUnbowed))]
    //[XmlInclude(typeof(SaruliGatekeepers))]
    //[XmlInclude(typeof(SavagebornHydra))]
    //[XmlInclude(typeof(ScabClanGiant))]
    //[XmlInclude(typeof(ScionofVituGhazi))]
    //[XmlInclude(typeof(SelesnyaCluestone))]
    //[XmlInclude(typeof(SelesnyaGuildgate))]
    //[XmlInclude(typeof(Showstopper))]
    //[XmlInclude(typeof(SimicCluestone))]
    //[XmlInclude(typeof(SimicGuildgate))]
    //[XmlInclude(typeof(SinCollector))]
    //[XmlInclude(typeof(SinisterPossession))]
    //[XmlInclude(typeof(SireofInsanity))]
    //[XmlInclude(typeof(Skylasher))]
    //[XmlInclude(typeof(SmeltWardGatekeepers))]
    //[XmlInclude(typeof(SpeciesGorger))]
    //[XmlInclude(typeof(SpikeJester))]
    //[XmlInclude(typeof(SteepleRoc))]
    //[XmlInclude(typeof(SunspireGatekeepers))]
    //[XmlInclude(typeof(TajicBladeoftheLegion))]
    //[XmlInclude(typeof(TeysaEnvoyofGhosts))]
    //[XmlInclude(typeof(ThrashingMossdog))]
    //[XmlInclude(typeof(TitheDrinker))]
    //[XmlInclude(typeof(ToilTrouble))]
    //[XmlInclude(typeof(TraitDoctoring))]
    //[XmlInclude(typeof(TrostanisSummoner))]
    //[XmlInclude(typeof(TurnBurn))]
    //[XmlInclude(typeof(UbulSarGatekeepers))]
    //[XmlInclude(typeof(UncoveredClues))]
    //[XmlInclude(typeof(UnflinchingCourage))]
    //[XmlInclude(typeof(VarolztheScarStriped))]
    //[XmlInclude(typeof(ViashinoFirstblade))]
    //[XmlInclude(typeof(VoiceofResurgence))]
    //[XmlInclude(typeof(VoreloftheHullClade))]
    //[XmlInclude(typeof(WaketheReflections))]
    //[XmlInclude(typeof(WarleadersHelix))]
    //[XmlInclude(typeof(WarpedPhysique))]
    //[XmlInclude(typeof(WeaponSurge))]
    //[XmlInclude(typeof(WearTear))]
    //[XmlInclude(typeof(WindDrake))]
    //[XmlInclude(typeof(WoodlotCrawler))]
    //[XmlInclude(typeof(ZhurTaaAncient))]
    //[XmlInclude(typeof(ZhurTaaDruid))]

    //# endregion
    //# region THS
    //[XmlInclude(typeof(AbhorrentOverlord))]
    //[XmlInclude(typeof(AgentofHorizons))]
    //[XmlInclude(typeof(AgentoftheFates))]
    //[XmlInclude(typeof(AkroanCrusader))]
    //[XmlInclude(typeof(AkroanHoplite))]
    //[XmlInclude(typeof(AkroanHorse))]
    //[XmlInclude(typeof(AnaxandCymede))]
    //[XmlInclude(typeof(AngeroftheGods))]
    //[XmlInclude(typeof(Annul))]
    //[XmlInclude(typeof(AnthousaSetessanHero))]
    //[XmlInclude(typeof(AnvilwroughtRaptor))]
    //[XmlInclude(typeof(AqueousForm))]
    //[XmlInclude(typeof(ArborColossus))]
    //[XmlInclude(typeof(ArtisanofForms))]
    //[XmlInclude(typeof(ArtisansSorrow))]
    //[XmlInclude(typeof(AshenRider))]
    //[XmlInclude(typeof(AshiokNightmareWeaver))]
    //[XmlInclude(typeof(AsphodelWanderer))]
    //[XmlInclude(typeof(BalefulEidolon))]
    //[XmlInclude(typeof(BattlewiseHoplite))]
    //[XmlInclude(typeof(BattlewiseValor))]
    //[XmlInclude(typeof(BenthicGiant))]
    //[XmlInclude(typeof(BidentofThassa))]
    //[XmlInclude(typeof(BloodTollHarpy))]
    //[XmlInclude(typeof(BoonofErebos))]
    //[XmlInclude(typeof(BoonSatyr))]
    //[XmlInclude(typeof(BorderlandMinotaur))]
    //[XmlInclude(typeof(Boulderfall))]
    //[XmlInclude(typeof(BowofNylea))]
    //[XmlInclude(typeof(BreachingHippocamp))]
    //[XmlInclude(typeof(BronzeSable))]
    //[XmlInclude(typeof(BurnishedHart))]
    //[XmlInclude(typeof(CavalryPegasus))]
    //[XmlInclude(typeof(CavernLampad))]
    //[XmlInclude(typeof(CelestialArchon))]
    //[XmlInclude(typeof(CentaurBattlemaster))]
    //[XmlInclude(typeof(ChainedtotheRocks))]
    //[XmlInclude(typeof(ChosenbyHeliod))]
    //[XmlInclude(typeof(ChroniclerofHeroes))]
    //[XmlInclude(typeof(CoastlineChimera))]
    //[XmlInclude(typeof(ColossusofAkros))]
    //[XmlInclude(typeof(CommunewiththeGods))]
    //[XmlInclude(typeof(CoordinatedAssault))]
    //[XmlInclude(typeof(CracklingTriton))]
    //[XmlInclude(typeof(CurseoftheSwine))]
    //[XmlInclude(typeof(CutthroatManeuver))]
    //[XmlInclude(typeof(DarkBetrayal))]
    //[XmlInclude(typeof(DauntlessOnslaught))]
    //[XmlInclude(typeof(DaxosofMeletis))]
    //[XmlInclude(typeof(DeathbellowRaider))]
    //[XmlInclude(typeof(DecoratedGriffin))]
    //[XmlInclude(typeof(DefendtheHearth))]
    //[XmlInclude(typeof(Demolish))]
    //[XmlInclude(typeof(DestructiveRevelry))]
    //[XmlInclude(typeof(DiscipleofPhenax))]
    //[XmlInclude(typeof(Dissolve))]
    //[XmlInclude(typeof(DivineVerdict))]
    //[XmlInclude(typeof(DragonMantle))]
    //[XmlInclude(typeof(ElspethSunsChampion))]
    //[XmlInclude(typeof(EmberSwallower))]
    //[XmlInclude(typeof(EpharasWarden))]
    //[XmlInclude(typeof(ErebosGodoftheDead))]
    //[XmlInclude(typeof(ErebossEmissary))]
    //[XmlInclude(typeof(EvangelofHeliod))]
    //[XmlInclude(typeof(FabledHero))]
    //[XmlInclude(typeof(FadeintoAntiquity))]
    //[XmlInclude(typeof(FanaticofMogis))]
    //[XmlInclude(typeof(FateForetold))]
    //[XmlInclude(typeof(FavoredHoplite))]
    //[XmlInclude(typeof(FelhideMinotaur))]
    //[XmlInclude(typeof(FeralInvocation))]
    //[XmlInclude(typeof(FiredrinkerSatyr))]
    //[XmlInclude(typeof(FlamecastWheel))]
    //[XmlInclude(typeof(FlamespeakerAdept))]
    //[XmlInclude(typeof(FleecemaneLion))]
    //[XmlInclude(typeof(FleetfeatherSandals))]
    //[XmlInclude(typeof(FleshmadSteed))]
    //[XmlInclude(typeof(Gainsay))]
    //[XmlInclude(typeof(GiftofImmortality))]
    //[XmlInclude(typeof(GlareofHeresy))]
    //[XmlInclude(typeof(GodsWilling))]
    //[XmlInclude(typeof(GrayMerchantofAsphodel))]
    //[XmlInclude(typeof(Griptide))]
    //[XmlInclude(typeof(GuardiansofMeletis))]
    //[XmlInclude(typeof(HammerofPurphoros))]
    //[XmlInclude(typeof(HeliodGodoftheSun))]
    //[XmlInclude(typeof(HeliodsEmissary))]
    //[XmlInclude(typeof(HerosDownfall))]
    //[XmlInclude(typeof(HopefulEidolon))]
    //[XmlInclude(typeof(HorizonChimera))]
    //[XmlInclude(typeof(HorizonScholar))]
    //[XmlInclude(typeof(HundredHandedOne))]
    //[XmlInclude(typeof(HunttheHunter))]
    //[XmlInclude(typeof(HythoniatheCruel))]
    //[XmlInclude(typeof(IllTemperedCyclops))]
    //[XmlInclude(typeof(InsatiableHarpy))]
    //[XmlInclude(typeof(KarametrasAcolyte))]
    //[XmlInclude(typeof(KeepsakeGorgon))]
    //[XmlInclude(typeof(KragmaWarcaller))]
    //[XmlInclude(typeof(LabyrinthChampion))]
    //[XmlInclude(typeof(LagonnaBandElder))]
    //[XmlInclude(typeof(LashoftheWhip))]
    //[XmlInclude(typeof(LastBreath))]
    //[XmlInclude(typeof(LeafcrownDryad))]
    //[XmlInclude(typeof(LeoninSnarecaster))]
    //[XmlInclude(typeof(LightningStrike))]
    //[XmlInclude(typeof(LoathsomeCatoblepas))]
    //[XmlInclude(typeof(LostinaLabyrinth))]
    //[XmlInclude(typeof(MagmaJet))]
    //[XmlInclude(typeof(MarchoftheReturned))]
    //[XmlInclude(typeof(MasterofWaves))]
    //[XmlInclude(typeof(MedomaitheAgeless))]
    //[XmlInclude(typeof(MeletisCharlatan))]
    //[XmlInclude(typeof(MessengersSpeed))]
    //[XmlInclude(typeof(MinotaurSkullcleaver))]
    //[XmlInclude(typeof(MistcutterHydra))]
    //[XmlInclude(typeof(MnemonicWall))]
    //[XmlInclude(typeof(MogissMarauder))]
    //[XmlInclude(typeof(NessianAsp))]
    //[XmlInclude(typeof(NessianCourser))]
    //[XmlInclude(typeof(Nighthowler))]
    //[XmlInclude(typeof(NimbusNaiad))]
    //[XmlInclude(typeof(NykthosShrinetoNyx))]
    //[XmlInclude(typeof(NyleaGodoftheHunt))]
    //[XmlInclude(typeof(NyleasDisciple))]
    //[XmlInclude(typeof(NyleasEmissary))]
    //[XmlInclude(typeof(NyleasPresence))]
    //[XmlInclude(typeof(ObservantAlseid))]
    //[XmlInclude(typeof(Omenspeaker))]
    //[XmlInclude(typeof(OpalineUnicorn))]
    //[XmlInclude(typeof(OrdealofErebos))]
    //[XmlInclude(typeof(OrdealofHeliod))]
    //[XmlInclude(typeof(OrdealofNylea))]
    //[XmlInclude(typeof(OrdealofPurphoros))]
    //[XmlInclude(typeof(OrdealofThassa))]
    //[XmlInclude(typeof(PeakEruption))]
    //[XmlInclude(typeof(PhalanxLeader))]
    //[XmlInclude(typeof(PharikasCure))]
    //[XmlInclude(typeof(PharikasMender))]
    //[XmlInclude(typeof(PheresBandCentaurs))]
    //[XmlInclude(typeof(PolisCrusher))]
    //[XmlInclude(typeof(PolukranosWorldEater))]
    //[XmlInclude(typeof(PortentofBetrayal))]
    //[XmlInclude(typeof(PrescientChimera))]
    //[XmlInclude(typeof(PriestofIroas))]
    //[XmlInclude(typeof(PrognosticSphinx))]
    //[XmlInclude(typeof(ProphetofKruphix))]
    //[XmlInclude(typeof(ProwlersHelm))]
    //[XmlInclude(typeof(PsychicIntrusion))]
    //[XmlInclude(typeof(PurphorosGodoftheForge))]
    //[XmlInclude(typeof(PurphorossEmissary))]
    //[XmlInclude(typeof(PyxisofPandemonium))]
    //[XmlInclude(typeof(RageofPurphoros))]
    //[XmlInclude(typeof(RagebloodShaman))]
    //[XmlInclude(typeof(RayofDissolution))]
    //[XmlInclude(typeof(ReadtheBones))]
    //[XmlInclude(typeof(ReaperoftheWilds))]
    //[XmlInclude(typeof(RescuefromtheUnderworld))]
    //[XmlInclude(typeof(ReturnedCentaur))]
    //[XmlInclude(typeof(ReturnedPhalanx))]
    //[XmlInclude(typeof(ReverentHunter))]
    //[XmlInclude(typeof(SatyrHedonist))]
    //[XmlInclude(typeof(SatyrPiper))]
    //[XmlInclude(typeof(SatyrRambler))]
    //[XmlInclude(typeof(SavageSurge))]
    //[XmlInclude(typeof(ScholarofAthreos))]
    //[XmlInclude(typeof(Scourgemark))]
    //[XmlInclude(typeof(SeaGodsRevenge))]
    //[XmlInclude(typeof(SealockMonster))]
    //[XmlInclude(typeof(SedgeScorpion))]
    //[XmlInclude(typeof(SedgeScorpion))]
    //[XmlInclude(typeof(SentryoftheUnderworld))]
    //[XmlInclude(typeof(SetessanBattlePriest))]
    //[XmlInclude(typeof(SetessanGriffin))]
    //[XmlInclude(typeof(ShipbreakerKraken))]
    //[XmlInclude(typeof(ShipwreckSinger))]
    //[XmlInclude(typeof(ShreddingWinds))]
    //[XmlInclude(typeof(SilentArtisan))]
    //[XmlInclude(typeof(SipofHemlock))]
    //[XmlInclude(typeof(SoldierofthePantheon))]
    //[XmlInclude(typeof(SparkJolt))]
    //[XmlInclude(typeof(SpearofHeliod))]
    //[XmlInclude(typeof(SpearpointOread))]
    //[XmlInclude(typeof(SpellheartChimera))]
    //[XmlInclude(typeof(SpellheartChimera))]
    //[XmlInclude(typeof(StaunchHeartedWarrior))]
    //[XmlInclude(typeof(SteamAugury))]
    //[XmlInclude(typeof(StoneshockGiant))]
    //[XmlInclude(typeof(StormbreathDragon))]
    //[XmlInclude(typeof(StymiedHopes))]
    //[XmlInclude(typeof(SwanSong))]
    //[XmlInclude(typeof(SylvanCaryatid))]
    //[XmlInclude(typeof(TempleofAbandon))]
    //[XmlInclude(typeof(TempleofDeceit))]
    //[XmlInclude(typeof(TempleofMystery))]
    //[XmlInclude(typeof(TempleofSilence))]
    //[XmlInclude(typeof(TempleofTriumph))]
    //[XmlInclude(typeof(ThassaGodoftheSea))]
    //[XmlInclude(typeof(ThassasBounty))]
    //[XmlInclude(typeof(ThassasEmissary))]
    //[XmlInclude(typeof(Thoughtseize))]
    //[XmlInclude(typeof(TimetoFeed))]
    //[XmlInclude(typeof(TitanofEternalFire))]
    //[XmlInclude(typeof(TitansStrength))]
    //[XmlInclude(typeof(TormentedHero))]
    //[XmlInclude(typeof(TravelersAmulet))]
    //[XmlInclude(typeof(TravelingPhilosopher))]
    //[XmlInclude(typeof(TriadofFates))]
    //[XmlInclude(typeof(TritonFortuneHunter))]
    //[XmlInclude(typeof(TritonShorethief))]
    //[XmlInclude(typeof(TritonTactics))]
    //[XmlInclude(typeof(TwoHeadedCerberus))]
    //[XmlInclude(typeof(TymarettheMurderKing))]
    //[XmlInclude(typeof(UnderworldCerberus))]
    //[XmlInclude(typeof(UnknownShores))]
    //[XmlInclude(typeof(VanquishtheFoul))]
    //[XmlInclude(typeof(Vaporkin))]
    //[XmlInclude(typeof(VipersKiss))]
    //[XmlInclude(typeof(VoyagesEnd))]
    //[XmlInclude(typeof(VoyagingSatyr))]
    //[XmlInclude(typeof(VulpineGoliath))]
    //[XmlInclude(typeof(WarriorsLesson))]
    //[XmlInclude(typeof(WavecrashTriton))]
    //[XmlInclude(typeof(WhipofErebos))]
    //[XmlInclude(typeof(WildCelebrants))]
    //[XmlInclude(typeof(WingsteedRider))]
    //[XmlInclude(typeof(WitchesEye))]
    //[XmlInclude(typeof(XenagostheReveler))]
    //[XmlInclude(typeof(YokedOx))]

    //# endregion
    //# region BNG
    //[XmlInclude(typeof(AcolytesReward))]
    //[XmlInclude(typeof(AerieWorshippers))]
    //[XmlInclude(typeof(AkroanConscriptor))]
    //[XmlInclude(typeof(AkroanPhalanx))]
    //[XmlInclude(typeof(AkroanSkyguard))]
    //[XmlInclude(typeof(ArbiteroftheIdeal))]
    //[XmlInclude(typeof(ArchetypeofAggression))]
    //[XmlInclude(typeof(ArchetypeofCourage))]
    //[XmlInclude(typeof(ArchetypeofEndurance))]
    //[XmlInclude(typeof(ArchetypeofFinality))]
    //[XmlInclude(typeof(ArchetypeofImagination))]
    //[XmlInclude(typeof(AshioksAdept))]
    //[XmlInclude(typeof(AspectofHydra))]
    //[XmlInclude(typeof(Asphyxiate))]
    //[XmlInclude(typeof(AstralCornucopia))]
    //[XmlInclude(typeof(BileBlight))]
    //[XmlInclude(typeof(BlackOakofOdunos))]
    //[XmlInclude(typeof(BoltofKeranos))]
    //[XmlInclude(typeof(BrimazKingofOreskos))]
    //[XmlInclude(typeof(ChampionofStraySouls))]
    //[XmlInclude(typeof(ChargingBadger))]
    //[XmlInclude(typeof(ChorusoftheTides))]
    //[XmlInclude(typeof(Chromanticore))]
    //[XmlInclude(typeof(ClaimofErebos))]
    //[XmlInclude(typeof(CourserofKruphix))]
    //[XmlInclude(typeof(Crypsis))]
    //[XmlInclude(typeof(CullingMark))]
    //[XmlInclude(typeof(CyclopsofOneEyedPass))]
    //[XmlInclude(typeof(DawntoDusk))]
    //[XmlInclude(typeof(DeepwaterHypnotist))]
    //[XmlInclude(typeof(Divination))]
    //[XmlInclude(typeof(DrowninSorrow))]
    //[XmlInclude(typeof(EaterofHope))]
    //[XmlInclude(typeof(EidolonofCountlessBattles))]
    //[XmlInclude(typeof(EliteSkirmisher))]
    //[XmlInclude(typeof(EpharaGodofthePolis))]
    //[XmlInclude(typeof(EpharasEnlightenment))]
    //[XmlInclude(typeof(EpharasRadiance))]
    //[XmlInclude(typeof(EpiphanyStorm))]
    //[XmlInclude(typeof(EternitySnare))]
    //[XmlInclude(typeof(EvanescentIntellect))]
    //[XmlInclude(typeof(EverflameEidolon))]
    //[XmlInclude(typeof(Excoriate))]
    //[XmlInclude(typeof(EyeGouge))]
    //[XmlInclude(typeof(FalloftheHammer))]
    //[XmlInclude(typeof(FanaticofXenagos))]
    //[XmlInclude(typeof(FateUnraveler))]
    //[XmlInclude(typeof(FatedConflagration))]
    //[XmlInclude(typeof(FatedInfatuation))]
    //[XmlInclude(typeof(FatedIntervention))]
    //[XmlInclude(typeof(FatedRetribution))]
    //[XmlInclude(typeof(FatedReturn))]
    //[XmlInclude(typeof(FearsomeTemper))]
    //[XmlInclude(typeof(FelhideBrawler))]
    //[XmlInclude(typeof(FelhideSpiritbinder))]
    //[XmlInclude(typeof(FlameWreathedPhoenix))]
    //[XmlInclude(typeof(FlitterstepEidolon))]
    //[XmlInclude(typeof(FloodtideSerpent))]
    //[XmlInclude(typeof(ForgestokerDragon))]
    //[XmlInclude(typeof(ForlornPseudamma))]
    //[XmlInclude(typeof(ForsakenDrifters))]
    //[XmlInclude(typeof(GhostbladeEidolon))]
    //[XmlInclude(typeof(Gild))]
    //[XmlInclude(typeof(GlimpsetheSunGod))]
    //[XmlInclude(typeof(GodFavoredGeneral))]
    //[XmlInclude(typeof(GorgonsHead))]
    //[XmlInclude(typeof(GraverobberSpider))]
    //[XmlInclude(typeof(GreatHart))]
    //[XmlInclude(typeof(GriffinDreamfinder))]
    //[XmlInclude(typeof(GrislyTransformation))]
    //[XmlInclude(typeof(HeraldofTorment))]
    //[XmlInclude(typeof(HeroofIroas))]
    //[XmlInclude(typeof(HeroofLeinaTower))]
    //[XmlInclude(typeof(HeroesPodium))]
    //[XmlInclude(typeof(HoldatBay))]
    //[XmlInclude(typeof(HuntersProwess))]
    //[XmlInclude(typeof(ImpetuousSunchaser))]
    //[XmlInclude(typeof(KarametraGodofHarvests))]
    //[XmlInclude(typeof(KarametrasFavor))]
    //[XmlInclude(typeof(KioratheCrashingWave))]
    //[XmlInclude(typeof(KiorasFollower))]
    //[XmlInclude(typeof(KragmaButcher))]
    //[XmlInclude(typeof(KrakenoftheStraits))]
    //[XmlInclude(typeof(LightningVolley))]
    //[XmlInclude(typeof(LoyalPegasus))]
    //[XmlInclude(typeof(MarshmistTitan))]
    //[XmlInclude(typeof(MeletisAstronomer))]
    //[XmlInclude(typeof(Mindreaver))]
    //[XmlInclude(typeof(MischiefandMayhem))]
    //[XmlInclude(typeof(MogisGodofSlaughter))]
    //[XmlInclude(typeof(MortalsArdor))]
    //[XmlInclude(typeof(MortalsResolve))]
    //[XmlInclude(typeof(Necrobite))]
    //[XmlInclude(typeof(NessianDemolok))]
    //[XmlInclude(typeof(NessianWildsRavager))]
    //[XmlInclude(typeof(NobleQuarry))]
    //[XmlInclude(typeof(Nullify))]
    //[XmlInclude(typeof(NyxbornEidolon))]
    //[XmlInclude(typeof(NyxbornRollicker))]
    //[XmlInclude(typeof(NyxbornShieldmate))]
    //[XmlInclude(typeof(NyxbornTriton))]
    //[XmlInclude(typeof(NyxbornWolf))]
    //[XmlInclude(typeof(OdunosRiverTrawler))]
    //[XmlInclude(typeof(OracleofBones))]
    //[XmlInclude(typeof(OraclesInsight))]
    //[XmlInclude(typeof(OreskosSunGuide))]
    //[XmlInclude(typeof(Ornitharch))]
    //[XmlInclude(typeof(PainSeer))]
    //[XmlInclude(typeof(Peregrination))]
    //[XmlInclude(typeof(PerplexingChimera))]
    //[XmlInclude(typeof(PharagaxGiant))]
    //[XmlInclude(typeof(PhenaxGodofDeception))]
    //[XmlInclude(typeof(PheresBandRaiders))]
    //[XmlInclude(typeof(PheresBandTromper))]
    //[XmlInclude(typeof(PillarofWar))]
    //[XmlInclude(typeof(PinnacleofRage))]
    //[XmlInclude(typeof(PleaforGuidance))]
    //[XmlInclude(typeof(Ragemonger))]
    //[XmlInclude(typeof(RaisedbyWolves))]
    //[XmlInclude(typeof(ReapWhatIsSown))]
    //[XmlInclude(typeof(RecklessReveler))]
    //[XmlInclude(typeof(RetractionHelix))]
    //[XmlInclude(typeof(RevokeExistence))]
    //[XmlInclude(typeof(RisetotheChallenge))]
    //[XmlInclude(typeof(Sanguimancy))]
    //[XmlInclude(typeof(SatyrFiredancer))]
    //[XmlInclude(typeof(SatyrNyxSmith))]
    //[XmlInclude(typeof(SatyrWayfinder))]
    //[XmlInclude(typeof(ScourgeofSkolaVale))]
    //[XmlInclude(typeof(ScouringSands))]
    //[XmlInclude(typeof(SearingBlood))]
    //[XmlInclude(typeof(ServantofTymaret))]
    //[XmlInclude(typeof(SetessanOathsworn))]
    //[XmlInclude(typeof(SetessanStarbreaker))]
    //[XmlInclude(typeof(ShrikeHarpy))]
    //[XmlInclude(typeof(SilentSentinel))]
    //[XmlInclude(typeof(SirenoftheFangedCoast))]
    //[XmlInclude(typeof(SirenoftheSilentSong))]
    //[XmlInclude(typeof(SirenSongLyre))]
    //[XmlInclude(typeof(Skyreaping))]
    //[XmlInclude(typeof(SnakeoftheGoldenGrove))]
    //[XmlInclude(typeof(SphinxsDisciple))]
    //[XmlInclude(typeof(SpiritoftheLabyrinth))]
    //[XmlInclude(typeof(SpitefulReturned))]
    //[XmlInclude(typeof(SpringleafDrum))]
    //[XmlInclude(typeof(StormcallerofKeranos))]
    //[XmlInclude(typeof(StratusWalk))]
    //[XmlInclude(typeof(SuddenStorm))]
    //[XmlInclude(typeof(Sunbond))]
    //[XmlInclude(typeof(SwordwiseCentaur))]
    //[XmlInclude(typeof(TempleofEnlightenment))]
    //[XmlInclude(typeof(TempleofMalice))]
    //[XmlInclude(typeof(TempleofPlenty))]
    //[XmlInclude(typeof(ThassasRebuff))]
    //[XmlInclude(typeof(ThunderBrute))]
    //[XmlInclude(typeof(ThunderousMight))]
    //[XmlInclude(typeof(Tromokratis))]
    //[XmlInclude(typeof(UnraveltheÆther))]
    //[XmlInclude(typeof(VanguardofBrimaz))]
    //[XmlInclude(typeof(VortexElemental))]
    //[XmlInclude(typeof(WarchanterofMogis))]
    //[XmlInclude(typeof(WeightoftheUnderworld))]
    //[XmlInclude(typeof(WhelmingWave))]
    //[XmlInclude(typeof(WhimsoftheFates))]
    //[XmlInclude(typeof(XenagosGodofRevels))]
    //# endregion
    //# region JOU
    //[XmlInclude(typeof(AegisoftheGods))]
    //[XmlInclude(typeof(AerialFormation))]
    //[XmlInclude(typeof(AgentofErebos))]
    //[XmlInclude(typeof(AjaniMentorofHeroes))]
    //[XmlInclude(typeof(AjanisPresence))]
    //[XmlInclude(typeof(AkroanLineBreaker))]
    //[XmlInclude(typeof(AkroanMastiff))]
    //[XmlInclude(typeof(ArmamentofNyx))]
    //[XmlInclude(typeof(ArmoryofIroas))]
    //[XmlInclude(typeof(AspectofGorgon))]
    //[XmlInclude(typeof(AthreosGodofPassage))]
    //[XmlInclude(typeof(BanishingLight))]
    //[XmlInclude(typeof(BassaraTowerArcher))]
    //[XmlInclude(typeof(BattlefieldThaumaturge))]
    //[XmlInclude(typeof(BeareroftheHeavens))]
    //[XmlInclude(typeof(BladetuskBoar))]
    //[XmlInclude(typeof(BlindingFlare))]
    //[XmlInclude(typeof(BloodcrazedHoplite))]
    //[XmlInclude(typeof(BrainMaggot))]
    //[XmlInclude(typeof(CastintoDarkness))]
    //[XmlInclude(typeof(ChariotofVictory))]
    //[XmlInclude(typeof(CloakedSiren))]
    //[XmlInclude(typeof(ColossalHeroics))]
    //[XmlInclude(typeof(ConsigntoDust))]
    //[XmlInclude(typeof(Countermand))]
    //[XmlInclude(typeof(CruelFeeding))]
    //[XmlInclude(typeof(CrystallineNautilus))]
    //[XmlInclude(typeof(CyclopsofEternalFury))]
    //[XmlInclude(typeof(DakraMystic))]
    //[XmlInclude(typeof(DaringThief))]
    //[XmlInclude(typeof(DawnbringerCharioteers))]
    //[XmlInclude(typeof(Deicide))]
    //[XmlInclude(typeof(DesecrationPlague))]
    //[XmlInclude(typeof(DesertersQuarters))]
    //[XmlInclude(typeof(DesperateStand))]
    //[XmlInclude(typeof(DictateofErebos))]
    //[XmlInclude(typeof(DictateofHeliod))]
    //[XmlInclude(typeof(DictateofKarametra))]
    //[XmlInclude(typeof(DictateofKruphix))]
    //[XmlInclude(typeof(DictateoftheTwinGods))]
    //[XmlInclude(typeof(DiscipleofDeceit))]
    //[XmlInclude(typeof(DoomwakeGiant))]
    //[XmlInclude(typeof(DreadbringerLampads))]
    //[XmlInclude(typeof(EagleoftheWatch))]
    //[XmlInclude(typeof(EidolonofBlossoms))]
    //[XmlInclude(typeof(EidolonofRhetoric))]
    //[XmlInclude(typeof(EidolonoftheGreatRevel))]
    //[XmlInclude(typeof(ExtinguishAllHope))]
    //[XmlInclude(typeof(FeastofDreams))]
    //[XmlInclude(typeof(FelhidePetrifier))]
    //[XmlInclude(typeof(FlamespeakersWill))]
    //[XmlInclude(typeof(FleetfeatherCockatrice))]
    //[XmlInclude(typeof(FlurryofHorns))]
    //[XmlInclude(typeof(FontofFertility))]
    //[XmlInclude(typeof(FontofFortunes))]
    //[XmlInclude(typeof(FontofIre))]
    //[XmlInclude(typeof(FontofReturn))]
    //[XmlInclude(typeof(FontofVigor))]
    //[XmlInclude(typeof(ForgebornOreads))]
    //[XmlInclude(typeof(GluttonousCyclops))]
    //[XmlInclude(typeof(GnarledScarhide))]
    //[XmlInclude(typeof(GodhunterOctopus))]
    //[XmlInclude(typeof(Godsend))]
    //[XmlInclude(typeof(GoldenHind))]
    //[XmlInclude(typeof(GoldenhideOx))]
    //[XmlInclude(typeof(GoldForgedSentinel))]
    //[XmlInclude(typeof(GrimGuardian))]
    //[XmlInclude(typeof(HallofTriumph))]
    //[XmlInclude(typeof(HarnessbyForce))]
    //[XmlInclude(typeof(HarvestguardAlseids))]
    //[XmlInclude(typeof(HeroesBane))]
    //[XmlInclude(typeof(HourofNeed))]
    //[XmlInclude(typeof(Hubris))]
    //[XmlInclude(typeof(HumblerofMortals))]
    //[XmlInclude(typeof(HydraBroodmaster))]
    //[XmlInclude(typeof(HypnoticSiren))]
    //[XmlInclude(typeof(InterprettheSigns))]
    //[XmlInclude(typeof(IroasGodofVictory))]
    //[XmlInclude(typeof(KeranosGodofStorms))]
    //[XmlInclude(typeof(KingMacartheGoldCursed))]
    //[XmlInclude(typeof(KiorasDismissal))]
    //[XmlInclude(typeof(KnowledgeandPower))]
    //[XmlInclude(typeof(KruphixGodofHorizons))]
    //[XmlInclude(typeof(KruphixsInsight))]
    //[XmlInclude(typeof(LagonnaBandTrailblazer))]
    //[XmlInclude(typeof(LaunchtheFleet))]
    //[XmlInclude(typeof(LeoninIconoclast))]
    //[XmlInclude(typeof(LightningDiadem))]
    //[XmlInclude(typeof(MagmaSpray))]
    //[XmlInclude(typeof(ManaConfluence))]
    //[XmlInclude(typeof(MarketFestival))]
    //[XmlInclude(typeof(MasteroftheFeast))]
    //[XmlInclude(typeof(MogissWarhound))]
    //[XmlInclude(typeof(MortalObstinacy))]
    //[XmlInclude(typeof(NaturesPanoply))]
    //[XmlInclude(typeof(NessianGameWarden))]
    //[XmlInclude(typeof(NightmarishEnd))]
    //[XmlInclude(typeof(NyxInfusion))]
    //[XmlInclude(typeof(NyxFleeceRam))]
    //[XmlInclude(typeof(NyxWeaver))]
    //[XmlInclude(typeof(OakheartDryads))]
    //[XmlInclude(typeof(OppressiveRays))]
    //[XmlInclude(typeof(OreskosSwiftclaw))]
    //[XmlInclude(typeof(PensiveMinotaur))]
    //[XmlInclude(typeof(PhalanxFormation))]
    //[XmlInclude(typeof(PharikaGodofAffliction))]
    //[XmlInclude(typeof(PharikasChosen))]
    //[XmlInclude(typeof(PheresBandThunderhoof))]
    //[XmlInclude(typeof(PheresBandWarchief))]
    //[XmlInclude(typeof(PintotheEarth))]
    //[XmlInclude(typeof(PolymorphousRush))]
    //[XmlInclude(typeof(PropheticFlamespeaker))]
    //[XmlInclude(typeof(PullfromtheDeep))]
    //[XmlInclude(typeof(QuarryColossus))]
    //[XmlInclude(typeof(RavenousLeucrocota))]
    //[XmlInclude(typeof(RenownedWeaver))]
    //[XmlInclude(typeof(Reprisal))]
    //[XmlInclude(typeof(ReturnedReveler))]
    //[XmlInclude(typeof(ReveloftheFallenGod))]
    //[XmlInclude(typeof(RevivingMelody))]
    //[XmlInclude(typeof(RiddleofLightning))]
    //[XmlInclude(typeof(RiptideChimera))]
    //[XmlInclude(typeof(RiseofEagles))]
    //[XmlInclude(typeof(RitualoftheReturned))]
    //[XmlInclude(typeof(RollickofAbandon))]
    //[XmlInclude(typeof(RottedHulk))]
    //[XmlInclude(typeof(RousetheMob))]
    //[XmlInclude(typeof(SageofHours))]
    //[XmlInclude(typeof(SatyrGrovedancer))]
    //[XmlInclude(typeof(SatyrHoplite))]
    //[XmlInclude(typeof(ScourgeofFleets))]
    //[XmlInclude(typeof(SetessanTactics))]
    //[XmlInclude(typeof(SightlessBrawler))]
    //[XmlInclude(typeof(SigiledSkink))]
    //[XmlInclude(typeof(SigiledStarfish))]
    //[XmlInclude(typeof(SilencetheBelievers))]
    //[XmlInclude(typeof(Skybind))]
    //[XmlInclude(typeof(SkyspearCavalry))]
    //[XmlInclude(typeof(SolidarityofHeroes))]
    //[XmlInclude(typeof(SpawnofThraxes))]
    //[XmlInclude(typeof(Spirespine))]
    //[XmlInclude(typeof(SpiteofMogis))]
    //[XmlInclude(typeof(SpitefulBlow))]
    //[XmlInclude(typeof(SquelchingLeeches))]
    //[XmlInclude(typeof(Starfall))]
    //[XmlInclude(typeof(StonewiseFortifier))]
    //[XmlInclude(typeof(StormchaserChimera))]
    //[XmlInclude(typeof(StrengthfromtheFallen))]
    //[XmlInclude(typeof(SupplyLineCranes))]
    //[XmlInclude(typeof(SwarmbornGiant))]
    //[XmlInclude(typeof(TempleofEpiphany))]
    //[XmlInclude(typeof(TempleofMalady))]
    //[XmlInclude(typeof(TethmosHighPriest))]
    //[XmlInclude(typeof(ThassasDevourer))]
    //[XmlInclude(typeof(ThassasIre))]
    //[XmlInclude(typeof(ThoughtrenderLamia))]
    //[XmlInclude(typeof(TormentedThoughts))]
    //[XmlInclude(typeof(TritonCavalry))]
    //[XmlInclude(typeof(TritonShorestalker))]
    //[XmlInclude(typeof(Twinflame))]
    //[XmlInclude(typeof(UnderworldCoinsmith))]
    //[XmlInclude(typeof(WarWingSiren))]
    //[XmlInclude(typeof(WhitewaterNaiads))]
    //[XmlInclude(typeof(WildfireCerberus))]
    //[XmlInclude(typeof(WorstFears))]

    //# endregion
    //# region Core
    //# region Core 14
    //[XmlInclude(typeof(AcademyRaider))]
    //[XmlInclude(typeof(AccordersShield))]
    //[XmlInclude(typeof(AccursedSpirit))]
    //[XmlInclude(typeof(ActofTreason))]
    //[XmlInclude(typeof(AdvocateoftheBeast))]
    //[XmlInclude(typeof(AirServant))]
    //[XmlInclude(typeof(AjaniCallerofthePride))]
    //[XmlInclude(typeof(AjanisChosen))]
    //[XmlInclude(typeof(AltarsReap))]
    //[XmlInclude(typeof(AngelicAccord))]
    //[XmlInclude(typeof(AngelicWall))]
    //[XmlInclude(typeof(Archaeomancer))]
    //[XmlInclude(typeof(ArchangelofThune))]
    //[XmlInclude(typeof(ArmoredCancrix))]
    //[XmlInclude(typeof(ArtificersHex))]
    //[XmlInclude(typeof(Auramancer))]
    //[XmlInclude(typeof(AwakentheAncient))]
    //[XmlInclude(typeof(BanisherPriest))]
    //[XmlInclude(typeof(BarrageofExpendables))]
    //[XmlInclude(typeof(BattleSliver))]
    //[XmlInclude(typeof(Blessing))]
    //[XmlInclude(typeof(Blightcaster))]
    //[XmlInclude(typeof(BloodBairn))]
    //[XmlInclude(typeof(BlurSliver))]
    //[XmlInclude(typeof(BogbrewWitch))]
    //[XmlInclude(typeof(BonescytheSliver))]
    //[XmlInclude(typeof(Bramblecrush))]
    //[XmlInclude(typeof(BravetheElements))]
    //[XmlInclude(typeof(BriarpackAlpha))]
    //[XmlInclude(typeof(BrindleBoar))]
    //[XmlInclude(typeof(BubblingCauldron))]
    //[XmlInclude(typeof(BurningEarth))]
    //[XmlInclude(typeof(Cancel))]
    //[XmlInclude(typeof(CanyonMinotaur))]
    //[XmlInclude(typeof(CapashenKnight))]
    //[XmlInclude(typeof(CelestialFlare))]
    //[XmlInclude(typeof(ChandraPyromaster))]
    //[XmlInclude(typeof(ChandrasOutrage))]
    //[XmlInclude(typeof(ChandrasPhoenix))]
    //[XmlInclude(typeof(ChargingGriffin))]
    //[XmlInclude(typeof(ChildofNight))]
    //[XmlInclude(typeof(Claustrophobia))]
    //[XmlInclude(typeof(Clone))]
    //[XmlInclude(typeof(ColossalWhale))]
    //[XmlInclude(typeof(Congregate))]
    //[XmlInclude(typeof(CoralMerfolk))]
    //[XmlInclude(typeof(CorpseHauler))]
    //[XmlInclude(typeof(Corrupt))]
    //[XmlInclude(typeof(CyclopsTyrant))]
    //[XmlInclude(typeof(DarkFavor))]
    //[XmlInclude(typeof(DarkProphecy))]
    //[XmlInclude(typeof(DarksteelForge))]
    //[XmlInclude(typeof(DarksteelIngot))]
    //[XmlInclude(typeof(DawnstrikePaladin))]
    //[XmlInclude(typeof(DeadlyRecluse))]
    //[XmlInclude(typeof(DeathgazeCockatrice))]
    //[XmlInclude(typeof(Demolish))]
    //[XmlInclude(typeof(DevoutInvocation))]
    //[XmlInclude(typeof(DiabolicTutor))]
    //[XmlInclude(typeof(DismissintoDream))]
    //[XmlInclude(typeof(Disperse))]
    //[XmlInclude(typeof(Divination))]
    //[XmlInclude(typeof(DivineFavor))]
    //[XmlInclude(typeof(Domestication))]
    //[XmlInclude(typeof(DoomBlade))]
    //[XmlInclude(typeof(DoorofDestinies))]
    //[XmlInclude(typeof(DragonEgg))]
    //[XmlInclude(typeof(DragonHatchling))]
    //[XmlInclude(typeof(Duress))]
    //[XmlInclude(typeof(EliteArcanist))]
    //[XmlInclude(typeof(ElixirofImmortality))]
    //[XmlInclude(typeof(ElvishMystic))]
    //[XmlInclude(typeof(EncroachingWastes))]
    //[XmlInclude(typeof(Enlarge))]
    //[XmlInclude(typeof(EssenceScatter))]
    //[XmlInclude(typeof(FesteringNewt))]
    //[XmlInclude(typeof(FiendslayerPaladin))]
    //[XmlInclude(typeof(Fireshrieker))]
    //[XmlInclude(typeof(FlamesoftheFirebrand))]
    //[XmlInclude(typeof(FleshpulperGiant))]
    //[XmlInclude(typeof(Fog))]
    //[XmlInclude(typeof(Forest))]
    //[XmlInclude(typeof(Fortify))]
    //[XmlInclude(typeof(FrostBreath))]
    //[XmlInclude(typeof(GaleriderSliver))]
    //[XmlInclude(typeof(GarrukCallerofBeasts))]
    //[XmlInclude(typeof(GarruksHorde))]
    //[XmlInclude(typeof(GiantGrowth))]
    //[XmlInclude(typeof(GiantSpider))]
    //[XmlInclude(typeof(GladecoverScout))]
    //[XmlInclude(typeof(GlimpsetheFuture))]
    //[XmlInclude(typeof(GnawingZombie))]
    //[XmlInclude(typeof(GoblinDiplomats))]
    //[XmlInclude(typeof(GoblinShortcutter))]
    //[XmlInclude(typeof(GriffinSentinel))]
    //[XmlInclude(typeof(GrimReturn))]
    //[XmlInclude(typeof(GroundshakerSliver))]
    //[XmlInclude(typeof(GuardianoftheAges))]
    //[XmlInclude(typeof(HauntedPlateMail))]
    //[XmlInclude(typeof(HiveStirrings))]
    //[XmlInclude(typeof(HowloftheNightPack))]
    //[XmlInclude(typeof(HunttheWeak))]
    //[XmlInclude(typeof(IllusionaryArmor))]
    //[XmlInclude(typeof(ImposingSovereign))]
    //[XmlInclude(typeof(Indestructibility))]
    //[XmlInclude(typeof(IntotheWilds))]
    //[XmlInclude(typeof(Island))]
    //[XmlInclude(typeof(JaceMemoryAdept))]
    //[XmlInclude(typeof(JacesMindseeker))]
    //[XmlInclude(typeof(KalonianHydra))]
    //[XmlInclude(typeof(KalonianTusker))]
    //[XmlInclude(typeof(LavaAxe))]
    //[XmlInclude(typeof(LayoftheLand))]
    //[XmlInclude(typeof(LifebaneZombie))]
    //[XmlInclude(typeof(LightningTalons))]
    //[XmlInclude(typeof(LilianaoftheDarkRealms))]
    //[XmlInclude(typeof(LilianasReaver))]
    //[XmlInclude(typeof(LiturgyofBlood))]
    //[XmlInclude(typeof(ManaweftSliver))]
    //[XmlInclude(typeof(MaraudingMaulhorn))]
    //[XmlInclude(typeof(MarkoftheVampire))]
    //[XmlInclude(typeof(MasterofDiversion))]
    //[XmlInclude(typeof(MeganticSliver))]
    //[XmlInclude(typeof(MerfolkSpy))]
    //[XmlInclude(typeof(MessengerDrake))]
    //[XmlInclude(typeof(Millstone))]
    //[XmlInclude(typeof(MindRot))]
    //[XmlInclude(typeof(Mindsparker))]
    //[XmlInclude(typeof(MinotaurAbomination))]
    //[XmlInclude(typeof(MoltenBirth))]
    //[XmlInclude(typeof(Mountain))]
    //[XmlInclude(typeof(Mutavault))]
    //[XmlInclude(typeof(Naturalize))]
    //[XmlInclude(typeof(Negate))]
    //[XmlInclude(typeof(NephaliaSeakite))]
    //[XmlInclude(typeof(Nightmare))]
    //[XmlInclude(typeof(NightwingShade))]
    //[XmlInclude(typeof(OathoftheAncientWood))]
    //[XmlInclude(typeof(OgreBattledriver))]
    //[XmlInclude(typeof(Opportunity))]
    //[XmlInclude(typeof(Pacifism))]
    //[XmlInclude(typeof(PathofBravery))]
    //[XmlInclude(typeof(PayNoHeed))]
    //[XmlInclude(typeof(PhantomWarrior))]
    //[XmlInclude(typeof(PillarfieldOx))]
    //[XmlInclude(typeof(PitchburnDevils))]
    //[XmlInclude(typeof(Plains))]
    //[XmlInclude(typeof(PlanarCleansing))]
    //[XmlInclude(typeof(Plummet))]
    //[XmlInclude(typeof(PredatorySliver))]
    //[XmlInclude(typeof(PrimevalBounty))]
    //[XmlInclude(typeof(PyromancersGauntlet))]
    //[XmlInclude(typeof(QuagSickness))]
    //[XmlInclude(typeof(Quicken))]
    //[XmlInclude(typeof(RangersGuile))]
    //[XmlInclude(typeof(RatchetBomb))]
    //[XmlInclude(typeof(RegathanFirecat))]
    //[XmlInclude(typeof(RingofThreeWishes))]
    //[XmlInclude(typeof(RiseoftheDarkRealms))]
    //[XmlInclude(typeof(RodofRuin))]
    //[XmlInclude(typeof(Rootwalla))]
    //[XmlInclude(typeof(RumblingBaloth))]
    //[XmlInclude(typeof(SanguineBond))]
    //[XmlInclude(typeof(SavageSummoning))]
    //[XmlInclude(typeof(ScavengingOoze))]
    //[XmlInclude(typeof(ScourgeofValkas))]
    //[XmlInclude(typeof(ScrollThief))]
    //[XmlInclude(typeof(SeacoastDrake))]
    //[XmlInclude(typeof(SeismicStomp))]
    //[XmlInclude(typeof(SengirVampire))]
    //[XmlInclude(typeof(SensoryDeprivation))]
    //[XmlInclude(typeof(SentinelSliver))]
    //[XmlInclude(typeof(SeraphoftheSword))]
    //[XmlInclude(typeof(SerraAngel))]
    //[XmlInclude(typeof(ShadowbornApostle))]
    //[XmlInclude(typeof(ShadowbornDemon))]
    //[XmlInclude(typeof(ShimmeringGrotto))]
    //[XmlInclude(typeof(ShivanDragon))]
    //[XmlInclude(typeof(ShivsEmbrace))]
    //[XmlInclude(typeof(Shock))]
    //[XmlInclude(typeof(ShowofValor))]
    //[XmlInclude(typeof(Shrivel))]
    //[XmlInclude(typeof(SiegeMastodon))]
    //[XmlInclude(typeof(Silence))]
    //[XmlInclude(typeof(SliverConstruct))]
    //[XmlInclude(typeof(Smelt))]
    //[XmlInclude(typeof(SolemnOffering))]
    //[XmlInclude(typeof(Soulmender))]
    //[XmlInclude(typeof(SpellBlast))]
    //[XmlInclude(typeof(Sporemound))]
    //[XmlInclude(typeof(StaffoftheDeathMagus))]
    //[XmlInclude(typeof(StaffoftheFlameMagus))]
    //[XmlInclude(typeof(StaffoftheMindMagus))]
    //[XmlInclude(typeof(StaffoftheSunMagus))]
    //[XmlInclude(typeof(StaffoftheWildMagus))]
    //[XmlInclude(typeof(SteelformSliver))]
    //[XmlInclude(typeof(StonehornChanter))]
    //[XmlInclude(typeof(StrikingSliver))]
    //[XmlInclude(typeof(StrionicResonator))]
    //[XmlInclude(typeof(SuntailHawk))]
    //[XmlInclude(typeof(Swamp))]
    //[XmlInclude(typeof(SyphonSliver))]
    //[XmlInclude(typeof(TenaciousDead))]
    //[XmlInclude(typeof(ThorncasterSliver))]
    //[XmlInclude(typeof(ThunderStrike))]
    //[XmlInclude(typeof(TidebinderMage))]
    //[XmlInclude(typeof(TimeEbb))]
    //[XmlInclude(typeof(TomeScour))]
    //[XmlInclude(typeof(TradingPost))]
    //[XmlInclude(typeof(TrainedCondor))]
    //[XmlInclude(typeof(Traumatize))]
    //[XmlInclude(typeof(Trollhide))]
    //[XmlInclude(typeof(UndeadMinotaur))]
    //[XmlInclude(typeof(VampireWarlord))]
    //[XmlInclude(typeof(VastwoodHydra))]
    //[XmlInclude(typeof(VerdantHaven))]
    //[XmlInclude(typeof(VialofPoison))]
    //[XmlInclude(typeof(VileRebirth))]
    //[XmlInclude(typeof(VolcanicGeyser))]
    //[XmlInclude(typeof(VoraciousWurm))]
    //[XmlInclude(typeof(WallofFrost))]
    //[XmlInclude(typeof(WallofSwords))]
    //[XmlInclude(typeof(WardenofEvosIsle))]
    //[XmlInclude(typeof(WaterServant))]
    //[XmlInclude(typeof(WildGuess))]
    //[XmlInclude(typeof(WildRicochet))]
    //[XmlInclude(typeof(WindreaderSphinx))]
    //[XmlInclude(typeof(Windstorm))]
    //[XmlInclude(typeof(Witchstalker))]
    //[XmlInclude(typeof(WoodbornBehemoth))]
    //[XmlInclude(typeof(WringFlesh))]
    //[XmlInclude(typeof(XathridNecromancer))]
    //[XmlInclude(typeof(YoungPyromancer))]
    //[XmlInclude(typeof(ZephyrCharge))]

    //# endregion
    //# region Magic 2015
    //[XmlInclude(typeof(AccursedSpiritM15))]
    //[XmlInclude(typeof(ActonImpulse15))]
    //[XmlInclude(typeof(AegisAngel15))]
    //[XmlInclude(typeof(AeronautTinkerer15))]
    //[XmlInclude(typeof(AEtherspouts15))]
    //[XmlInclude(typeof(AggressiveMining15))]
    //[XmlInclude(typeof(AjaniSteadfast15))]
    //[XmlInclude(typeof(AjanisPridemate15))]
    //[XmlInclude(typeof(AltacBloodseeker15))]
    //[XmlInclude(typeof(AmphinPathmage15))]
    //[XmlInclude(typeof(AncientSilverback15))]
    //[XmlInclude(typeof(AvacynGuardianAngel15))]
    //[XmlInclude(typeof(AvariceAmulet15))]
    //[XmlInclude(typeof(BacktoNature15))]
    //[XmlInclude(typeof(BattleMastery15))]
    //[XmlInclude(typeof(BattlefieldForge15))]
    //[XmlInclude(typeof(BelligerentSliver15))]
    //[XmlInclude(typeof(BlackCat15))]
    //[XmlInclude(typeof(BlastfireBolt15))]
    //[XmlInclude(typeof(BloodHost15))]
    //[XmlInclude(typeof(BoonweaverGiant15))]
    //[XmlInclude(typeof(BorderlandMarauder15))]
    //[XmlInclude(typeof(BrawlersPlate15))]
    //[XmlInclude(typeof(BronzeSableM15))]
    //[XmlInclude(typeof(BroodKeeper15))]
    //[XmlInclude(typeof(BurningAnger15))]
    //[XmlInclude(typeof(Cancel15))]
    //[XmlInclude(typeof(CarnivorousMossBeast15))]
    //[XmlInclude(typeof(CarrionCrow15))]
    //[XmlInclude(typeof(CausticTar15))]
    //[XmlInclude(typeof(CavesofKoilos15))]
    //[XmlInclude(typeof(CentaurCourser15))]
    //[XmlInclude(typeof(ChandraPyromasterM15))]
    //[XmlInclude(typeof(ChargingRhino15))]
    //[XmlInclude(typeof(ChasmSkulker15))]
    //[XmlInclude(typeof(ChiefEngineer15))]
    //[XmlInclude(typeof(ChildofNightM15))]
    //[XmlInclude(typeof(ChordofCalling15))]
    //[XmlInclude(typeof(Chronostutter15))]
    //[XmlInclude(typeof(CircleofFlame15))]
    //[XmlInclude(typeof(ClearaPath15))]
    //[XmlInclude(typeof(ConeofFlame15))]
    //[XmlInclude(typeof(CongregateM15))]
    //[XmlInclude(typeof(ConstrictingSliver15))]
    //[XmlInclude(typeof(CoralBarrier15))]
    //[XmlInclude(typeof(CovenantofBlood15))]
    //[XmlInclude(typeof(CripplingBlight15))]
    //[XmlInclude(typeof(CrowdsFavor15))]
    //[XmlInclude(typeof(CrucibleofFire15))]
    //[XmlInclude(typeof(CruelSadist15))]
    //[XmlInclude(typeof(DarksteelCitadel15))]
    //[XmlInclude(typeof(DauntlessRiverMarshal15))]
    //[XmlInclude(typeof(DevouringLight15))]
    //[XmlInclude(typeof(DiffusionSliver15))]
    //[XmlInclude(typeof(Dissipate15))]
    //[XmlInclude(typeof(Divination15))]
    //[XmlInclude(typeof(DivineFavor15))]
    //[XmlInclude(typeof(DivineVerdict15))]
    //[XmlInclude(typeof(ElvishMystic15))]
    //[XmlInclude(typeof(Encrust15))]
    //[XmlInclude(typeof(EndlessObedience15))]
    //[XmlInclude(typeof(EnsoulArtifact15))]
    //[XmlInclude(typeof(EphemeralShields15))]
    //[XmlInclude(typeof(EternalThirst15))]
    //[XmlInclude(typeof(EvolvingWilds15))]
    //[XmlInclude(typeof(FeastontheFallen15))]
    //[XmlInclude(typeof(FeralIncarnation15))]
    //[XmlInclude(typeof(Festergloom15))]
    //[XmlInclude(typeof(FirstResponse15))]
    //[XmlInclude(typeof(FleshtoDust15))]
    //[XmlInclude(typeof(Forest15))]
    //[XmlInclude(typeof(ForgeDevil15))]
    //[XmlInclude(typeof(FoundryStreetDenizen15))]
    //[XmlInclude(typeof(FrenziedGoblin15))]
    //[XmlInclude(typeof(FrostLynx15))]
    //[XmlInclude(typeof(FugitiveWizard15))]
    //[XmlInclude(typeof(FurnaceWhelp15))]
    //[XmlInclude(typeof(GargoyleSentinel15))]
    //[XmlInclude(typeof(GarrukApexPredator15))]
    //[XmlInclude(typeof(GarruksPackleader15))]
    //[XmlInclude(typeof(GatherCourage15))]
    //[XmlInclude(typeof(GeistoftheMoors15))]
    //[XmlInclude(typeof(GeneratorServant15))]
    //[XmlInclude(typeof(GenesisHydra15))]
    //[XmlInclude(typeof(GlacialCrasher15))]
    //[XmlInclude(typeof(GoblinKaboomist15))]
    //[XmlInclude(typeof(GoblinRabblemaster15))]
    //[XmlInclude(typeof(GoblinRoughrider15))]
    //[XmlInclude(typeof(Gravedigger15))]
    //[XmlInclude(typeof(Grindclock15))]
    //[XmlInclude(typeof(Hammerhand15))]
    //[XmlInclude(typeof(HauntedPlateMail15))]
    //[XmlInclude(typeof(HeatRay15))]
    //[XmlInclude(typeof(HeliodsPilgrim15))]
    //[XmlInclude(typeof(HoardingDragon15))]
    //[XmlInclude(typeof(HornetNest15))]
    //[XmlInclude(typeof(HornetQueen15))]
    //[XmlInclude(typeof(HotSoup15))]
    //[XmlInclude(typeof(HunttheWeak15))]
    //[XmlInclude(typeof(HuntersAmbush15))]
    //[XmlInclude(typeof(HushwingGryff15))]
    //[XmlInclude(typeof(Hydrosurge15))]
    //[XmlInclude(typeof(IllusoryAngel15))]
    //[XmlInclude(typeof(InGarruksWake15))]
    //[XmlInclude(typeof(IndulgentTormentor15))]
    //[XmlInclude(typeof(InfernoFist15))]
    //[XmlInclude(typeof(InspiredCharge15))]
    //[XmlInclude(typeof(IntotheVoid15))]
    //[XmlInclude(typeof(InvasiveSpecies15))]
    //[XmlInclude(typeof(Invisibility15))]
    //[XmlInclude(typeof(Island15))]
    //[XmlInclude(typeof(JacetheLivingGuildpact15))]
    //[XmlInclude(typeof(JacesIngenuity15))]
    //[XmlInclude(typeof(JaliraMasterPolymorphist15))]
    //[XmlInclude(typeof(JorubaiMurkLurker15))]
    //[XmlInclude(typeof(Juggernaut15))]
    //[XmlInclude(typeof(KalonianTwingrove15))]
    //[XmlInclude(typeof(KapshoKitefins15))]
    //[XmlInclude(typeof(KinsbaileSkirmisher15))]
    //[XmlInclude(typeof(KirdChieftain15))]
    //[XmlInclude(typeof(KrenkosEnforcer15))]
    //[XmlInclude(typeof(KurkeshOnakkeAncient15))]
    //[XmlInclude(typeof(LavaAxe15))]
    //[XmlInclude(typeof(LeechingSliver15))]
    //[XmlInclude(typeof(LifesLegacy15))]
    //[XmlInclude(typeof(LightningStrike15))]
    //[XmlInclude(typeof(LilianaVess15))]
    //[XmlInclude(typeof(LivingTotem15))]
    //[XmlInclude(typeof(LlanowarWastes15))]
    //[XmlInclude(typeof(MahamotiDjinn15))]
    //[XmlInclude(typeof(MarkedbyHonor15))]
    //[XmlInclude(typeof(MassCalcify15))]
    //[XmlInclude(typeof(MasterofPredicaments15))]
    //[XmlInclude(typeof(MeditationPuzzle15))]
    //[XmlInclude(typeof(MercurialPretender15))]
    //[XmlInclude(typeof(Meteorite15))]
    //[XmlInclude(typeof(MidnightGuard15))]
    //[XmlInclude(typeof(MightMakesRight15))]
    //[XmlInclude(typeof(MilitaryIntelligence15))]
    //[XmlInclude(typeof(MindRot15))]
    //[XmlInclude(typeof(MindSculpt15))]
    //[XmlInclude(typeof(MinersBane15))]
    //[XmlInclude(typeof(Mountain15))]
    //[XmlInclude(typeof(Naturalize15))]
    //[XmlInclude(typeof(Necrobite15))]
    //[XmlInclude(typeof(NecrogenScudder15))]
    //[XmlInclude(typeof(NecromancersAssistant15))]
    //[XmlInclude(typeof(NecromancersStockpile15))]
    //[XmlInclude(typeof(Negate15))]
    //[XmlInclude(typeof(NetcasterSpider15))]
    //[XmlInclude(typeof(NightfireGiant15))]
    //[XmlInclude(typeof(Nightmare15))]
    //[XmlInclude(typeof(NimbusoftheIsles15))]
    //[XmlInclude(typeof(NissaWorldwaker15))]
    //[XmlInclude(typeof(NissasExpedition15))]
    //[XmlInclude(typeof(ObNixilisUnshackled15))]
    //[XmlInclude(typeof(ObeliskofUrd15))]
    //[XmlInclude(typeof(OppressiveRays15))]
    //[XmlInclude(typeof(OreskosSwiftclaw15))]
    //[XmlInclude(typeof(Ornithopter15))]
    //[XmlInclude(typeof(Overwhelm15))]
    //[XmlInclude(typeof(ParagonofEternalWilds15))]
    //[XmlInclude(typeof(ParagonofFierceDefiance15))]
    //[XmlInclude(typeof(ParagonofGatheringMists15))]
    //[XmlInclude(typeof(ParagonofNewDawns15))]
    //[XmlInclude(typeof(ParagonofOpenGraves15))]
    //[XmlInclude(typeof(PeelfromReality15))]
    //[XmlInclude(typeof(PerilousVault15))]
    //[XmlInclude(typeof(PhyrexianRevoker15))]
    //[XmlInclude(typeof(Phytotitan15))]
    //[XmlInclude(typeof(PillarofLight15))]
    //[XmlInclude(typeof(Plains15))]
    //[XmlInclude(typeof(Plummet15))]
    //[XmlInclude(typeof(PolymorphistsJest15))]
    //[XmlInclude(typeof(PreeminentCaptain15))]
    //[XmlInclude(typeof(ProfaneMemento15))]
    //[XmlInclude(typeof(Quickling15))]
    //[XmlInclude(typeof(RadiantFountain15))]
    //[XmlInclude(typeof(RaisetheAlarm15))]
    //[XmlInclude(typeof(RangersGuile15))]
    //[XmlInclude(typeof(RazorfootGriffin15))]
    //[XmlInclude(typeof(ReclamationSage15))]
    //[XmlInclude(typeof(ResearchAssistant15))]
    //[XmlInclude(typeof(ResoluteArchangel15))]
    //[XmlInclude(typeof(Restock15))]
    //[XmlInclude(typeof(ReturntotheRanks15))]
    //[XmlInclude(typeof(RoaringPrimadox15))]
    //[XmlInclude(typeof(RoguesGloves15))]
    //[XmlInclude(typeof(RotfeasterMaggot15))]
    //[XmlInclude(typeof(RummagingGoblin15))]
    //[XmlInclude(typeof(RuneclawBear15))]
    //[XmlInclude(typeof(SacredArmory15))]
    //[XmlInclude(typeof(SanctifiedCharge15))]
    //[XmlInclude(typeof(SatyrWayfinder15))]
    //[XmlInclude(typeof(ScrapyardMongrel15))]
    //[XmlInclude(typeof(ScuttlingDoomEngine15))]
    //[XmlInclude(typeof(SeismicStrike15))]
    //[XmlInclude(typeof(SelflessCathar15))]
    //[XmlInclude(typeof(SengirVampire15))]
    //[XmlInclude(typeof(SeraphoftheMasses15))]
    //[XmlInclude(typeof(SerraAngel15))]
    //[XmlInclude(typeof(ShadowcloakVampire15))]
    //[XmlInclude(typeof(ShamanofSpring15))]
    //[XmlInclude(typeof(ShieldoftheAvatar15))]
    //[XmlInclude(typeof(ShivanDragon15))]
    //[XmlInclude(typeof(ShivanReef15))]
    //[XmlInclude(typeof(ShrapnelBlast15))]
    //[XmlInclude(typeof(SiegeDragon15))]
    //[XmlInclude(typeof(SiegeWurm15))]
    //[XmlInclude(typeof(SigninBlood15))]
    //[XmlInclude(typeof(SliverHive15))]
    //[XmlInclude(typeof(SliverHivelord15))]
    //[XmlInclude(typeof(SolemnOffering15))]
    //[XmlInclude(typeof(SoulofInnistrad15))]
    //[XmlInclude(typeof(SoulofNewPhyrexia15))]
    //[XmlInclude(typeof(SoulofRavnica15))]
    //[XmlInclude(typeof(SoulofShandalar15))]
    //[XmlInclude(typeof(SoulofTheros15))]
    //[XmlInclude(typeof(SoulofZendikar15))]
    //[XmlInclude(typeof(Soulmender15))]
    //[XmlInclude(typeof(SpectraWard15))]
    //[XmlInclude(typeof(SpiritBonds15))]
    //[XmlInclude(typeof(StabWound15))]
    //[XmlInclude(typeof(StaffoftheDeathMagus15))]
    //[XmlInclude(typeof(StaffoftheFlameMagus15))]
    //[XmlInclude(typeof(StaffoftheMindMagus15))]
    //[XmlInclude(typeof(StaffoftheSunMagus15))]
    //[XmlInclude(typeof(StaffoftheWildMagus15))]
    //[XmlInclude(typeof(StaintheMind15))]
    //[XmlInclude(typeof(StatuteofDenial15))]
    //[XmlInclude(typeof(StoketheFlames15))]
    //[XmlInclude(typeof(StormtideLeviathan15))]
    //[XmlInclude(typeof(SunbladeElf15))]
    //[XmlInclude(typeof(SungracePegasus15))]
    //[XmlInclude(typeof(Swamp15))]
    //[XmlInclude(typeof(TerraStomper15))]
    //[XmlInclude(typeof(TheChainVeil15))]
    //[XmlInclude(typeof(ThunderingGiant15))]
    //[XmlInclude(typeof(TirelessMissionaries15))]
    //[XmlInclude(typeof(TitanicGrowth15))]
    //[XmlInclude(typeof(TorchFiend15))]
    //[XmlInclude(typeof(TormodsCrypt15))]
    //[XmlInclude(typeof(TriplicateSpirits15))]
    //[XmlInclude(typeof(TurntoFrog15))]
    //[XmlInclude(typeof(TyphoidRats15))]
    //[XmlInclude(typeof(TyrantsMachine15))]
    //[XmlInclude(typeof(Ulcerate15))]
    //[XmlInclude(typeof(UndergrowthScavenger15))]
    //[XmlInclude(typeof(UnmaketheGraves15))]
    //[XmlInclude(typeof(UrborgTombofYawgmoth15))]
    //[XmlInclude(typeof(VenomSliver15))]
    //[XmlInclude(typeof(VerdantHaven15))]
    //[XmlInclude(typeof(Vineweft15))]
    //[XmlInclude(typeof(VoidSnare15))]
    //[XmlInclude(typeof(WalkingCorpse15))]
    //[XmlInclude(typeof(WallofEssence15))]
    //[XmlInclude(typeof(WallofFire15))]
    //[XmlInclude(typeof(WallofFrost15))]
    //[XmlInclude(typeof(WallofLimbs15))]
    //[XmlInclude(typeof(WallofMulch15))]
    //[XmlInclude(typeof(WardenoftheBeyond15))]
    //[XmlInclude(typeof(WasteNot15))]
    //[XmlInclude(typeof(WelkinTern15))]
    //[XmlInclude(typeof(WillForgedGolem15))]
    //[XmlInclude(typeof(WitchsFamiliar15))]
    //[XmlInclude(typeof(XathridSlyblade15))]
    //[XmlInclude(typeof(YavimayaCoast15))]
    //[XmlInclude(typeof(YisantheWandererBard15))]
    //[XmlInclude(typeof(ZofShade15))]
    //# endregion
    //# endregion
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
        public delegate void ValueAbility(MagicCard mc, int index);  //index of ability being used. 0 based.

        public event ValueChanged CountersChanged;
        public event ValueChanged onPingOpponent;
        public event ValueAbility Activate;
        public event ValueAbility Activating;
        public event PassiveEvent Evolving;
        public event PassiveEvent OnUpkeep;
        public event PassiveEvent onEndStep;
        public event PassiveEvent OnAttack;
        public event PassiveEvent OnEquip;
        public event PassiveEvent OnUnequip;
        public event PassiveEvent onAuraAdded;
        public event PassiveEvent onAuraRemoved;
        public event PassiveEvent onEquipmentAdd;
        public event PassiveEvent onEquipmentRemoved;
        public event PassiveEvent onSpellCast;
        public event PassiveEvent onDie;
        public event PassiveEvent onExile;
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

        public void callExile()
        {
            PassiveEvent handler = onExile;
            if (handler != null)
            {
                handler(this);
            }

            if (PArea != null)
            {
                PArea.Play_Exile(this);
            }
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
            ValueAbility handler = Activate;
            if (handler != null)
            {
                handler(this, index);
            }
        }

        private void callActivating(int index)
        {
            ValueAbility handler = Activating;
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
            ValueAbility handler = Activate;
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

        public void callEndStep()
        {
            PassiveEvent handler = onEndStep;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callUpkeep()
        {
            PassiveEvent handler = OnUpkeep;
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

        public virtual void Resolve()
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
        public virtual bool TryActivate(int i)
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

        public virtual void DoActivate(int i)
        {
            callActivate(i);
        }

        public virtual bool Evolve(int p, int t)
        {
            checkPT();
            bool result = false;

            if (Text.Contains("Evolve"))
            {
                if (p > Power || t > Toughness)
                {
                    counters++;
                    callEvolve();
                    result = true;
                }
            }

            return result;
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
                # region Stronghold uncomplete
                case "Sliver Queen":
                    mcn = new SliverQueenSH();
                    break;
                # endregion

                # region Innistrad

                # endregion

                # region Avacyn Restored
                # region Abundant Growth
                case "Abundant Growth":
                    mcn = new AbundantGrowthAVR();
                    break;
                # endregion

                # region Aggravate
                case "Aggravate":
                    mcn = new AggravateAVR();
                    break;
                # endregion

                # region Alchemist's Apprentice
                case "Alchemist's Apprentice":
                    mcn = new AlchemistsApprenticeAVR();
                    break;
                # endregion

                # region Alchemist's Refuge
                case "Alchemist's Refuge":
                    mcn = new AlchemistsRefugeAVR();
                    break;
                # endregion

                # region Amass the Components
                case "Amass the Components":
                    mcn = new AmasstheComponentsAVR();
                    break;
                # endregion

                # region Angel of Glory's Rise
                case "Angel of Glory's Rise":
                    mcn = new AngelofGlorysRiseAVR();
                    break;
                # endregion

                # region Angel of Jubilation
                case "Angel of Jubilation":
                    mcn = new AngelofJubilationAVR();
                    break;
                # endregion

                # region Angelic Armaments
                case "Angelic Armaments":
                    mcn = new AngelicArmamentsAVR();
                    break;
                # endregion

                # region Angelic Wall
                case "Angelic Wall":
                    mcn = new AngelicWallAVR();
                    break;
                # endregion

                # region Angel's Mercy
                case "Angel's Mercy":
                    mcn = new AngelsMercyAVR();
                    break;
                # endregion

                # region Angel's Tomb
                case "Angel's Tomb":
                    mcn = new AngelsTombAVR();
                    break;
                # endregion

                # region Appetite for Brains
                case "Appetite for Brains":
                    mcn = new AppetiteforBrainsAVR();
                    break;
                # endregion

                # region Arcane Melee
                case "Arcane Melee":
                    mcn = new ArcaneMeleeAVR();
                    break;
                # endregion

                # region Archangel
                case "Archangel":
                    mcn = new ArchangelAVR();
                    break;
                # endregion

                # region Archwing Dragon
                case "Archwing Dragon":
                    mcn = new ArchwingDragonAVR();
                    break;
                # endregion

                # region Avacyn, Angel of Hope
                case "Avacyn, Angel of Hope":
                    mcn = new AvacynAngelofHopeAVR();
                    break;
                # endregion

                # region Banishing Stroke
                case "Banishing Stroke":
                    mcn = new BanishingStrokeAVR();
                    break;
                # endregion

                # region Banners Raised
                case "Banners Raised":
                    mcn = new BannersRaisedAVR();
                    break;
                # endregion

                # region Barter in Blood
                case "Barter in Blood":
                    mcn = new BarterinBloodAVR();
                    break;
                # endregion

                # region Battle Hymn
                case "Battle Hymn":
                    mcn = new BattleHymnAVR();
                    break;
                # endregion

                # region Bladed Bracers
                case "Bladed Bracers":
                    mcn = new BladedBracersAVR();
                    break;
                # endregion

                # region Blessings of Nature
                case "Blessings of Nature":
                    mcn = new BlessingsofNatureAVR();
                    break;
                # endregion

                # region Blood Artist
                case "Blood Artist":
                    mcn = new BloodArtistAVR();
                    break;
                # endregion

                # region Bloodflow Connoisseur
                case "Bloodflow Connoisseur":
                    mcn = new BloodflowConnoisseurAVR();
                    break;
                # endregion

                # region Bone Splinters
                case "Bone Splinters":
                    mcn = new BoneSplintersAVR();
                    break;
                # endregion

                # region Bonfire of the Damned
                case "Bonfire of the Damned":
                    mcn = new BonfireoftheDamnedAVR();
                    break;
                # endregion

                # region Borderland Ranger
                case "Borderland Ranger":
                    mcn = new BorderlandRangerAVR();
                    break;
                # endregion

                # region Bower Passage
                case "Bower Passage":
                    mcn = new BowerPassageAVR();
                    break;
                # endregion

                # region Bruna, Light of Alabaster
                case "Bruna, Light of Alabaster":
                    mcn = new BrunaLightofAlabasterAVR();
                    break;
                # endregion

                # region Builder's Blessing
                case "Builder's Blessing":
                    mcn = new BuildersBlessingAVR();
                    break;
                # endregion

                # region Burn at the Stake
                case "Burn at the Stake":
                    mcn = new BurnattheStakeAVR();
                    break;
                # endregion

                # region Butcher Ghoul
                case "Butcher Ghoul":
                    mcn = new ButcherGhoulAVR();
                    break;
                # endregion

                # region Call to Serve
                case "Call to Serve":
                    mcn = new CalltoServeAVR();
                    break;
                # endregion

                # region Captain of the Mists
                case "Captain of the Mists":
                    mcn = new CaptainoftheMistsAVR();
                    break;
                # endregion

                # region Cathars' Crusade
                case "Cathars' Crusade":
                    mcn = new CatharsCrusadeAVR();
                    break;
                # endregion

                # region Cathedral Sanctifier
                case "Cathedral Sanctifier":
                    mcn = new CathedralSanctifierAVR();
                    break;
                # endregion

                # region Cavern of Souls
                case "Cavern of Souls":
                    mcn = new CavernofSoulsAVR();
                    break;
                # endregion

                # region Champion of Lambholt
                case "Champion of Lambholt":
                    mcn = new ChampionofLambholtAVR();
                    break;
                # endregion

                # region Cloudshift
                case "Cloudshift":
                    mcn = new CloudshiftAVR();
                    break;
                # endregion

                # region Commander's Authority
                case "Commander's Authority":
                    mcn = new CommandersAuthorityAVR();
                    break;
                # endregion

                # region Conjurer's Closet
                case "Conjurer's Closet":
                    mcn = new ConjurersClosetAVR();
                    break;
                # endregion

                # region Corpse Traders
                case "Corpse Traders":
                    mcn = new CorpseTradersAVR();
                    break;
                # endregion

                # region Craterhoof Behemoth
                case "Craterhoof Behemoth":
                    mcn = new CraterhoofBehemothAVR();
                    break;
                # endregion

                # region Crippling Chill
                case "Crippling Chill":
                    mcn = new CripplingChillAVR();
                    break;
                # endregion

                # region Crypt Creeper
                case "Crypt Creeper":
                    mcn = new CryptCreeperAVR();
                    break;
                # endregion

                # region Cursebreak
                case "Cursebreak":
                    mcn = new CursebreakAVR();
                    break;
                # endregion

                # region Dangerous Wager
                case "Dangerous Wager":
                    mcn = new DangerousWagerAVR();
                    break;
                # endregion

                # region Dark Impostor
                case "Dark Impostor":
                    mcn = new DarkImpostorAVR();
                    break;
                # endregion

                # region Deadeye Navigator
                case "Deadeye Navigator":
                    mcn = new DeadeyeNavigatorAVR();
                    break;
                # endregion

                # region Death Wind
                case "Death Wind":
                    mcn = new DeathWindAVR();
                    break;
                # endregion

                # region Defang
                case "Defang":
                    mcn = new DefangAVR();
                    break;
                # endregion

                # region Defy Death
                case "Defy Death":
                    mcn = new DefyDeathAVR();
                    break;
                # endregion

                # region Demolish
                case "Demolish":
                    mcn = new DemolishAVR();
                    break;
                # endregion

                # region Demonic Rising
                case "Demonic Rising":
                    mcn = new DemonicRisingAVR();
                    break;
                # endregion

                # region Demonic Taskmaster
                case "Demonic Taskmaster":
                    mcn = new DemonicTaskmasterAVR();
                    break;
                # endregion

                # region Demonlord of Ashmouth
                case "Demonlord of Ashmouth":
                    mcn = new DemonlordofAshmouthAVR();
                    break;
                # endregion

                # region Descendants' Path
                case "Descendants' Path":
                    mcn = new DescendantsPathAVR();
                    break;
                # endregion

                # region Descent into Madness
                case "Descent into Madness":
                    mcn = new DescentintoMadnessAVR();
                    break;
                # endregion

                # region Desolate Lighthouse
                case "Desolate Lighthouse":
                    mcn = new DesolateLighthouseAVR();
                    break;
                # endregion

                # region Devastation Tide
                case "Devastation Tide":
                    mcn = new DevastationTideAVR();
                    break;
                # endregion

                # region Devout Chaplain
                case "Devout Chaplain":
                    mcn = new DevoutChaplainAVR();
                    break;
                # endregion

                # region Diregraf Escort
                case "Diregraf Escort":
                    mcn = new DiregrafEscortAVR();
                    break;
                # endregion

                # region Divine Deflection
                case "Divine Deflection":
                    mcn = new DivineDeflectionAVR();
                    break;
                # endregion

                # region Dread Slaver
                case "Dread Slaver":
                    mcn = new DreadSlaverAVR();
                    break;
                # endregion

                # region Dreadwaters
                case "Dreadwaters":
                    mcn = new DreadwatersAVR();
                    break;
                # endregion

                # region Driver of the Dead
                case "Driver of the Dead":
                    mcn = new DriveroftheDeadAVR();
                    break;
                # endregion

                # region Druid's Familiar
                case "Druid's Familiar":
                    mcn = new DruidsFamiliarAVR();
                    break;
                # endregion

                # region Druids' Repository
                case "Druids' Repository":
                    mcn = new DruidsRepositoryAVR();
                    break;
                # endregion

                # region Dual Casting
                case "Dual Casting":
                    mcn = new DualCastingAVR();
                    break;
                # endregion

                # region Eaten by Spiders
                case "Eaten by Spiders":
                    mcn = new EatenbySpidersAVR();
                    break;
                # endregion

                # region Elgaud Shieldmate
                case "Elgaud Shieldmate":
                    mcn = new ElgaudShieldmateAVR();
                    break;
                # endregion

                # region Emancipation Angel
                case "Emancipation Angel":
                    mcn = new EmancipationAngelAVR();
                    break;
                # endregion

                # region Entreat the Angels
                case "Entreat the Angels":
                    mcn = new EntreattheAngelsAVR();
                    break;
                # endregion

                # region Essence Harvest
                case "Essence Harvest":
                    mcn = new EssenceHarvestAVR();
                    break;
                # endregion

                # region Evernight Shade
                case "Evernight Shade":
                    mcn = new EvernightShadeAVR();
                    break;
                # endregion

                # region Exquisite Blood
                case "Exquisite Blood":
                    mcn = new ExquisiteBloodAVR();
                    break;
                # endregion

                # region Falkenrath Exterminator
                case "Falkenrath Exterminator":
                    mcn = new FalkenrathExterminatorAVR();
                    break;
                # endregion

                # region Farbog Explorer
                case "Farbog Explorer":
                    mcn = new FarbogExplorerAVR();
                    break;
                # endregion

                # region Favorable Winds
                case "Favorable Winds":
                    mcn = new FavorableWindsAVR();
                    break;
                # endregion

                # region Fervent Cathar
                case "Fervent Cathar":
                    mcn = new FerventCatharAVR();
                    break;
                # endregion

                # region Fettergeist
                case "Fettergeist":
                    mcn = new FettergeistAVR();
                    break;
                # endregion

                # region Fleeting Distraction
                case "Fleeting Distraction":
                    mcn = new FleetingDistractionAVR();
                    break;
                # endregion

                # region Flowering Lumberknot
                case "Flowering Lumberknot":
                    mcn = new FloweringLumberknotAVR();
                    break;
                # endregion

                # region Forest
                case "Forest":
                    mcn = new ForestAVR();
                    break;
                # endregion

                # region Gallows at Willow Hill
                case "Gallows at Willow Hill":
                    mcn = new GallowsatWillowHillAVR();
                    break;
                # endregion

                # region Galvanic Alchemist
                case "Galvanic Alchemist":
                    mcn = new GalvanicAlchemistAVR();
                    break;
                # endregion

                # region Gang of Devils
                case "Gang of Devils":
                    mcn = new GangofDevilsAVR();
                    break;
                # endregion

                # region Geist Snatch
                case "Geist Snatch":
                    mcn = new GeistSnatchAVR();
                    break;
                # endregion

                # region Geist Trappers
                case "Geist Trappers":
                    mcn = new GeistTrappersAVR();
                    break;
                # endregion

                # region Ghostform
                case "Ghostform":
                    mcn = new GhostformAVR();
                    break;
                # endregion

                # region Ghostly Flicker
                case "Ghostly Flicker":
                    mcn = new GhostlyFlickerAVR();
                    break;
                # endregion

                # region Ghostly Touch
                case "Ghostly Touch":
                    mcn = new GhostlyTouchAVR();
                    break;
                # endregion

                # region Ghoulflesh
                case "Ghoulflesh":
                    mcn = new GhoulfleshAVR();
                    break;
                # endregion

                # region Gisela, Blade of Goldnight
                case "Gisela, Blade of Goldnight":
                    mcn = new GiselaBladeofGoldnightAVR();
                    break;
                # endregion

                # region Gloom Surgeon
                case "Gloom Surgeon":
                    mcn = new GloomSurgeonAVR();
                    break;
                # endregion

                # region Gloomwidow
                case "Gloomwidow":
                    mcn = new GloomwidowAVR();
                    break;
                # endregion

                # region Goldnight Commander
                case "Goldnight Commander":
                    mcn = new GoldnightCommanderAVR();
                    break;
                # endregion

                # region Goldnight Redeemer
                case "Goldnight Redeemer":
                    mcn = new GoldnightRedeemerAVR();
                    break;
                # endregion

                # region Grave Exchange
                case "Grave Exchange":
                    mcn = new GraveExchangeAVR();
                    break;
                # endregion

                # region Griselbrand
                case "Griselbrand":
                    mcn = new GriselbrandAVR();
                    break;
                # endregion

                # region Grounded
                case "Grounded":
                    mcn = new GroundedAVR();
                    break;
                # endregion

                # region Gryff Vanguard
                case "Gryff Vanguard":
                    mcn = new GryffVanguardAVR();
                    break;
                # endregion

                # region Guise of Fire
                case "Guise of Fire":
                    mcn = new GuiseofFireAVR();
                    break;
                # endregion

                # region Hanweir Lancer
                case "Hanweir Lancer":
                    mcn = new HanweirLancerAVR();
                    break;
                # endregion

                # region Harvester of Souls
                case "Harvester of Souls":
                    mcn = new HarvesterofSoulsAVR();
                    break;
                # endregion

                # region Haunted Guardian
                case "Haunted Guardian":
                    mcn = new HauntedGuardianAVR();
                    break;
                # endregion

                # region Havengul Skaab
                case "Havengul Skaab":
                    mcn = new HavengulSkaabAVR();
                    break;
                # endregion

                # region Havengul Vampire
                case "Havengul Vampire":
                    mcn = new HavengulVampireAVR();
                    break;
                # endregion

                # region Heirs of Stromkirk
                case "Heirs of Stromkirk":
                    mcn = new HeirsofStromkirkAVR();
                    break;
                # endregion

                # region Herald of War
                case "Herald of War":
                    mcn = new HeraldofWarAVR();
                    break;
                # endregion

                # region Holy Justiciar
                case "Holy Justiciar":
                    mcn = new HolyJusticiarAVR();
                    break;
                # endregion

                # region Homicidal Seclusion
                case "Homicidal Seclusion":
                    mcn = new HomicidalSeclusionAVR();
                    break;
                # endregion

                # region Hound of Griselbrand
                case "Hound of Griselbrand":
                    mcn = new HoundofGriselbrandAVR();
                    break;
                # endregion

                # region Howlgeist
                case "Howlgeist":
                    mcn = new HowlgeistAVR();
                    break;
                # endregion

                # region Human Frailty
                case "Human Frailty":
                    mcn = new HumanFrailtyAVR();
                    break;
                # endregion

                # region Hunted Ghoul
                case "Hunted Ghoul":
                    mcn = new HuntedGhoulAVR();
                    break;
                # endregion

                # region Infinite Reflection
                case "Infinite Reflection":
                    mcn = new InfiniteReflectionAVR();
                    break;
                # endregion

                # region Into the Void
                case "Into the Void":
                    mcn = new IntotheVoidAVR();
                    break;
                # endregion

                # region Island
                case "Island":
                    mcn = new IslandAVR();
                    break;
                # endregion

                # region Joint Assault
                case "Joint Assault":
                    mcn = new JointAssaultAVR();
                    break;
                # endregion

                # region Kessig Malcontents
                case "Kessig Malcontents":
                    mcn = new KessigMalcontentsAVR();
                    break;
                # endregion

                # region Killing Wave
                case "Killing Wave":
                    mcn = new KillingWaveAVR();
                    break;
                # endregion

                # region Kruin Striker
                case "Kruin Striker":
                    mcn = new KruinStrikerAVR();
                    break;
                # endregion

                # region Lair Delve
                case "Lair Delve":
                    mcn = new LairDelveAVR();
                    break;
                # endregion

                # region Latch Seeker
                case "Latch Seeker":
                    mcn = new LatchSeekerAVR();
                    break;
                # endregion

                # region Leap of Faith
                case "Leap of Faith":
                    mcn = new LeapofFaithAVR();
                    break;
                # endregion

                # region Lightning Mauler
                case "Lightning Mauler":
                    mcn = new LightningMaulerAVR();
                    break;
                # endregion

                # region Lightning Prowess
                case "Lightning Prowess":
                    mcn = new LightningProwessAVR();
                    break;
                # endregion

                # region Lone Revenant
                case "Lone Revenant":
                    mcn = new LoneRevenantAVR();
                    break;
                # endregion

                # region Lunar Mystic
                case "Lunar Mystic":
                    mcn = new LunarMysticAVR();
                    break;
                # endregion

                # region Maalfeld Twins
                case "Maalfeld Twins":
                    mcn = new MaalfeldTwinsAVR();
                    break;
                # endregion

                # region Mad Prophet
                case "Mad Prophet":
                    mcn = new MadProphetAVR();
                    break;
                # endregion

                # region Malicious Intent
                case "Malicious Intent":
                    mcn = new MaliciousIntentAVR();
                    break;
                # endregion

                # region Malignus
                case "Malignus":
                    mcn = new MalignusAVR();
                    break;
                # endregion

                # region Marrow Bats
                case "Marrow Bats":
                    mcn = new MarrowBatsAVR();
                    break;
                # endregion

                # region Mass Appeal
                case "Mass Appeal":
                    mcn = new MassAppealAVR();
                    break;
                # endregion

                # region Mental Agony
                case "Mental Agony":
                    mcn = new MentalAgonyAVR();
                    break;
                # endregion

                # region Midnight Duelist
                case "Midnight Duelist":
                    mcn = new MidnightDuelistAVR();
                    break;
                # endregion

                # region Midvast Protector
                case "Midvast Protector":
                    mcn = new MidvastProtectorAVR();
                    break;
                # endregion

                # region Mist Raven
                case "Mist Raven":
                    mcn = new MistRavenAVR();
                    break;
                # endregion

                # region Misthollow Griffin
                case "Misthollow Griffin":
                    mcn = new MisthollowGriffinAVR();
                    break;
                # endregion

                # region Moonlight Geist
                case "Moonlight Geist":
                    mcn = new MoonlightGeistAVR();
                    break;
                # endregion

                # region Moonsilver Spear
                case "Moonsilver Spear":
                    mcn = new MoonsilverSpearAVR();
                    break;
                # endregion

                # region Moorland Inquisitor
                case "Moorland Inquisitor":
                    mcn = new MoorlandInquisitorAVR();
                    break;
                # endregion

                # region Mountain
                case "Mountain":
                    mcn = new MountainAVR();
                    break;
                # endregion

                # region Narstad Scrapper
                case "Narstad Scrapper":
                    mcn = new NarstadScrapperAVR();
                    break;
                # endregion

                # region Natural End
                case "Natural End":
                    mcn = new NaturalEndAVR();
                    break;
                # endregion

                # region Nearheath Pilgrim
                case "Nearheath Pilgrim":
                    mcn = new NearheathPilgrimAVR();
                    break;
                # endregion

                # region Necrobite
                case "Necrobite":
                    mcn = new NecrobiteAVR();
                    break;
                # endregion

                # region Nephalia Smuggler
                case "Nephalia Smuggler":
                    mcn = new NephaliaSmugglerAVR();
                    break;
                # endregion

                # region Nettle Swine
                case "Nettle Swine":
                    mcn = new NettleSwineAVR();
                    break;
                # endregion

                # region Nightshade Peddler
                case "Nightshade Peddler":
                    mcn = new NightshadePeddlerAVR();
                    break;
                # endregion

                # region Otherworld Atlas
                case "Otherworld Atlas":
                    mcn = new OtherworldAtlasAVR();
                    break;
                # endregion

                # region Outwit
                case "Outwit":
                    mcn = new OutwitAVR();
                    break;
                # endregion

                # region Pathbreaker Wurm
                case "Pathbreaker Wurm":
                    mcn = new PathbreakerWurmAVR();
                    break;
                # endregion

                # region Peel from Reality
                case "Peel from Reality":
                    mcn = new PeelfromRealityAVR();
                    break;
                # endregion

                # region Pillar of Flame
                case "Pillar of Flame":
                    mcn = new PillarofFlameAVR();
                    break;
                # endregion

                # region Plains
                case "Plains":
                    mcn = new PlainsAVR();
                    break;
                # endregion

                # region Polluted Dead
                case "Polluted Dead":
                    mcn = new PollutedDeadAVR();
                    break;
                # endregion

                # region Predator's Gambit
                case "Predator's Gambit":
                    mcn = new PredatorsGambitAVR();
                    break;
                # endregion

                # region Primal Surge
                case "Primal Surge":
                    mcn = new PrimalSurgeAVR();
                    break;
                # endregion

                # region Raging Poltergeist
                case "Raging Poltergeist":
                    mcn = new RagingPoltergeistAVR();
                    break;
                # endregion

                # region Rain of Thorns
                case "Rain of Thorns":
                    mcn = new RainofThornsAVR();
                    break;
                # endregion

                # region Reforge the Soul
                case "Reforge the Soul":
                    mcn = new ReforgetheSoulAVR();
                    break;
                # endregion

                # region Renegade Demon
                case "Renegade Demon":
                    mcn = new RenegadeDemonAVR();
                    break;
                # endregion

                # region Restoration Angel
                case "Restoration Angel":
                    mcn = new RestorationAngelAVR();
                    break;
                # endregion

                # region Revenge of the Hunted
                case "Revenge of the Hunted":
                    mcn = new RevengeoftheHuntedAVR();
                    break;
                # endregion

                # region Riders of Gavony
                case "Riders of Gavony":
                    mcn = new RidersofGavonyAVR();
                    break;
                # endregion

                # region Righteous Blow
                case "Righteous Blow":
                    mcn = new RighteousBlowAVR();
                    break;
                # endregion

                # region Riot Ringleader
                case "Riot Ringleader":
                    mcn = new RiotRingleaderAVR();
                    break;
                # endregion

                # region Rite of Ruin
                case "Rite of Ruin":
                    mcn = new RiteofRuinAVR();
                    break;
                # endregion

                # region Rotcrown Ghoul
                case "Rotcrown Ghoul":
                    mcn = new RotcrownGhoulAVR();
                    break;
                # endregion

                # region Rush of Blood
                case "Rush of Blood":
                    mcn = new RushofBloodAVR();
                    break;
                # endregion

                # region Scalding Devil
                case "Scalding Devil":
                    mcn = new ScaldingDevilAVR();
                    break;
                # endregion

                # region Scrapskin Drake
                case "Scrapskin Drake":
                    mcn = new ScrapskinDrakeAVR();
                    break;
                # endregion

                # region Scroll of Avacyn
                case "Scroll of Avacyn":
                    mcn = new ScrollofAvacynAVR();
                    break;
                # endregion

                # region Scroll of Griselbrand
                case "Scroll of Griselbrand":
                    mcn = new ScrollofGriselbrandAVR();
                    break;
                # endregion

                # region Searchlight Geist
                case "Searchlight Geist":
                    mcn = new SearchlightGeistAVR();
                    break;
                # endregion

                # region Second Guess
                case "Second Guess":
                    mcn = new SecondGuessAVR();
                    break;
                # endregion

                # region Seraph of Dawn
                case "Seraph of Dawn":
                    mcn = new SeraphofDawnAVR();
                    break;
                # endregion

                # region Seraph Sanctuary
                case "Seraph Sanctuary":
                    mcn = new SeraphSanctuaryAVR();
                    break;
                # endregion

                # region Sheltering Word
                case "Sheltering Word":
                    mcn = new ShelteringWordAVR();
                    break;
                # endregion

                # region Sigarda, Host of Herons
                case "Sigarda, Host of Herons":
                    mcn = new SigardaHostofHeronsAVR();
                    break;
                # endregion

                # region Silverblade Paladin
                case "Silverblade Paladin":
                    mcn = new SilverbladePaladinAVR();
                    break;
                # endregion

                # region Slayers' Stronghold
                case "Slayers' Stronghold":
                    mcn = new SlayersStrongholdAVR();
                    break;
                # endregion

                # region Snare the Skies
                case "Snare the Skies":
                    mcn = new SnaretheSkiesAVR();
                    break;
                # endregion

                # region Somberwald Sage
                case "Somberwald Sage":
                    mcn = new SomberwaldSageAVR();
                    break;
                # endregion

                # region Somberwald Vigilante
                case "Somberwald Vigilante":
                    mcn = new SomberwaldVigilanteAVR();
                    break;
                # endregion

                # region Soul of the Harvest
                case "Soul of the Harvest":
                    mcn = new SouloftheHarvestAVR();
                    break;
                # endregion

                # region Soulcage Fiend
                case "Soulcage Fiend":
                    mcn = new SoulcageFiendAVR();
                    break;
                # endregion

                # region Spectral Gateguards
                case "Spectral Gateguards":
                    mcn = new SpectralGateguardsAVR();
                    break;
                # endregion

                # region Spectral Prison
                case "Spectral Prison":
                    mcn = new SpectralPrisonAVR();
                    break;
                # endregion

                # region Spirit Away
                case "Spirit Away":
                    mcn = new SpiritAwayAVR();
                    break;
                # endregion

                # region Stern Mentor
                case "Stern Mentor":
                    mcn = new SternMentorAVR();
                    break;
                # endregion

                # region Stolen Goods
                case "Stolen Goods":
                    mcn = new StolenGoodsAVR();
                    break;
                # endregion

                # region Stonewright
                case "Stonewright":
                    mcn = new StonewrightAVR();
                    break;
                # endregion

                # region Swamp
                case "Swamp":
                    mcn = new SwampAVR();
                    break;
                # endregion

                # region Tamiyo, the Moon Sage
                case "Tamiyo, the Moon Sage":
                    mcn = new TamiyotheMoonSageAVR();
                    break;
                # endregion

                # region Tandem Lookout
                case "Tandem Lookout":
                    mcn = new TandemLookoutAVR();
                    break;
                # endregion

                # region Temporal Mastery
                case "Temporal Mastery":
                    mcn = new TemporalMasteryAVR();
                    break;
                # endregion

                # region Terminus
                case "Terminus":
                    mcn = new TerminusAVR();
                    break;
                # endregion

                # region Terrifying Presence
                case "Terrifying Presence":
                    mcn = new TerrifyingPresenceAVR();
                    break;
                # endregion

                # region Thatcher Revolt
                case "Thatcher Revolt":
                    mcn = new ThatcherRevoltAVR();
                    break;
                # endregion

                # region Thraben Valiant
                case "Thraben Valiant":
                    mcn = new ThrabenValiantAVR();
                    break;
                # endregion

                # region Thunderbolt
                case "Thunderbolt":
                    mcn = new ThunderboltAVR();
                    break;
                # endregion

                # region Thunderous Wrath
                case "Thunderous Wrath":
                    mcn = new ThunderousWrathAVR();
                    break;
                # endregion

                # region Tibalt, the Fiend-Blooded
                case "Tibalt, the Fiend-Blooded":
                    mcn = new TibalttheFiendBloodedAVR();
                    break;
                # endregion

                # region Timberland Guide
                case "Timberland Guide":
                    mcn = new TimberlandGuideAVR();
                    break;
                # endregion

                # region Tormentor's Trident
                case "Tormentor's Trident":
                    mcn = new TormentorsTridentAVR();
                    break;
                # endregion

                # region Treacherous Pit-Dweller
                case "Treacherous Pit-Dweller":
                    mcn = new TreacherousPitDwellerAVR();
                    break;
                # endregion

                # region Triumph of Cruelty
                case "Triumph of Cruelty":
                    mcn = new TriumphofCrueltyAVR();
                    break;
                # endregion

                # region Triumph of Ferocity
                case "Triumph of Ferocity":
                    mcn = new TriumphofFerocityAVR();
                    break;
                # endregion

                # region Trusted Forcemage
                case "Trusted Forcemage":
                    mcn = new TrustedForcemageAVR();
                    break;
                # endregion

                # region Tyrant of Discord
                case "Tyrant of Discord":
                    mcn = new TyrantofDiscordAVR();
                    break;
                # endregion

                # region Ulvenwald Tracker
                case "Ulvenwald Tracker":
                    mcn = new UlvenwaldTrackerAVR();
                    break;
                # endregion

                # region Uncanny Speed
                case "Uncanny Speed":
                    mcn = new UncannySpeedAVR();
                    break;
                # endregion

                # region Undead Executioner
                case "Undead Executioner":
                    mcn = new UndeadExecutionerAVR();
                    break;
                # endregion

                # region Unhallowed Pact
                case "Unhallowed Pact":
                    mcn = new UnhallowedPactAVR();
                    break;
                # endregion

                # region Vanguard's Shield
                case "Vanguard's Shield":
                    mcn = new VanguardsShieldAVR();
                    break;
                # endregion

                # region Vanishment
                case "Vanishment":
                    mcn = new VanishmentAVR();
                    break;
                # endregion

                # region Vessel of Endless Rest
                case "Vessel of Endless Rest":
                    mcn = new VesselofEndlessRestAVR();
                    break;
                # endregion

                # region Vexing Devil
                case "Vexing Devil":
                    mcn = new VexingDevilAVR();
                    break;
                # endregion

                # region Vigilante Justice
                case "Vigilante Justice":
                    mcn = new VigilanteJusticeAVR();
                    break;
                # endregion

                # region Voice of the Provinces
                case "Voice of the Provinces":
                    mcn = new VoiceoftheProvincesAVR();
                    break;
                # endregion

                # region Vorstclaw
                case "Vorstclaw":
                    mcn = new VorstclawAVR();
                    break;
                # endregion

                # region Wandering Wolf
                case "Wandering Wolf":
                    mcn = new WanderingWolfAVR();
                    break;
                # endregion

                # region Wild Defiance
                case "Wild Defiance":
                    mcn = new WildDefianceAVR();
                    break;
                # endregion

                # region Wildwood Geist
                case "Wildwood Geist":
                    mcn = new WildwoodGeistAVR();
                    break;
                # endregion

                # region Wingcrafter
                case "Wingcrafter":
                    mcn = new WingcrafterAVR();
                    break;
                # endregion

                # region Wolfir Avenger
                case "Wolfir Avenger":
                    mcn = new WolfirAvengerAVR();
                    break;
                # endregion

                # region Wolfir Silverheart
                case "Wolfir Silverheart":
                    mcn = new WolfirSilverheartAVR();
                    break;
                # endregion

                # region Yew Spirit
                case "Yew Spirit":
                    mcn = new YewSpiritAVR();
                    break;
                # endregion

                # region Zealous Conscripts
                case "Zealous Conscripts":
                    mcn = new ZealousConscriptsAVR();
                    break;
                # endregion

                # region Zealous Strike
                case "Zealous Strike":
                    mcn = new ZealousStrikeAVR();
                    break;
                # endregion
                # endregion

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

                //case "Necrobite":
                //    mcn = new Necrobite();
                //    break;

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

                //case "Demolish":
                //    mcn = new Demolish();
                //    break;

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
                # region Abrupt Decay
                case "Abrupt Decay":
                    mcn = new AbruptDecay();
                    break;
                # endregion

                # region Aerial Predation
                case "Aerial Predation":
                    mcn = new AerialPredation();
                    break;
                # endregion

                # region Angel of Serenity
                case "Angel of Serenity":
                    mcn = new AngelofSerenity();
                    break;
                # endregion

                # region Annihilating Fire
                case "Annihilating Fire":
                    mcn = new AnnihilatingFire();
                    break;
                # endregion

                # region Aquus Steed
                case "Aquus Steed":
                    mcn = new AquusSteed();
                    break;
                # endregion

                # region Archon of the Triumvirate
                case "Archon of the Triumvirate":
                    mcn = new ArchonoftheTriumvirate();
                    break;
                # endregion

                # region Archweaver
                case "Archweaver":
                    mcn = new Archweaver();
                    break;
                # endregion

                # region Armada Wurm
                case "Armada Wurm":
                    mcn = new ArmadaWurm();
                    break;
                # endregion

                # region Armory Guard
                case "Armory Guard":
                    mcn = new ArmoryGuard();
                    break;
                # endregion

                # region Arrest
                case "Arrest":
                    mcn = new Arrest();
                    break;
                # endregion

                # region Ash Zealot
                case "Ash Zealot":
                    mcn = new AshZealot();
                    break;
                # endregion

                # region Assassin's Strike
                case "Assassin's Strike":
                    mcn = new AssassinsStrike();
                    break;
                # endregion

                # region Auger Spree
                case "Auger Spree":
                    mcn = new AugerSpree();
                    break;
                # endregion

                # region Avenging Arrow
                case "Avenging Arrow":
                    mcn = new AvengingArrow();
                    break;
                # endregion

                # region Axebane Guardian
                case "Axebane Guardian":
                    mcn = new AxebaneGuardian();
                    break;
                # endregion

                # region Axebane Stag
                case "Axebane Stag":
                    mcn = new AxebaneStag();
                    break;
                # endregion

                # region Azorius Arrester
                case "Azorius Arrester":
                    mcn = new AzoriusArrester();
                    break;
                # endregion

                # region Azorius Charm
                case "Azorius Charm":
                    mcn = new AzoriusCharm();
                    break;
                # endregion

                # region Azorius Guildgate
                case "Azorius Guildgate":
                    mcn = new AzoriusGuildgate();
                    break;
                # endregion

                # region Azorius Justiciar
                case "Azorius Justiciar":
                    mcn = new AzoriusJusticiar();
                    break;
                # endregion

                # region Azorius Keyrune
                case "Azorius Keyrune":
                    mcn = new AzoriusKeyrune();
                    break;
                # endregion

                # region Azor's Elocutors
                case "Azor's Elocutors":
                    mcn = new AzorsElocutors();
                    break;
                # endregion

                # region Batterhorn
                case "Batterhorn":
                    mcn = new Batterhorn();
                    break;
                # endregion

                # region Bazaar Krovod
                case "Bazaar Krovod":
                    mcn = new BazaarKrovod();
                    break;
                # endregion

                # region Bellows Lizard
                case "Bellows Lizard":
                    mcn = new BellowsLizard();
                    break;
                # endregion

                # region Blistercoil Weird
                case "Blistercoil Weird":
                    mcn = new BlistercoilWeird();
                    break;
                # endregion

                # region Blood Crypt
                case "Blood Crypt":
                    mcn = new BloodCrypt();
                    break;
                # endregion

                # region Bloodfray Giant
                case "Bloodfray Giant":
                    mcn = new BloodfrayGiant();
                    break;
                # endregion

                # region Blustersquall
                case "Blustersquall":
                    mcn = new Blustersquall();
                    break;
                # endregion

                # region Brushstrider
                case "Brushstrider":
                    mcn = new Brushstrider();
                    break;
                # endregion

                # region Call of the Conclave
                case "Call of the Conclave":
                    mcn = new CalloftheConclave();
                    break;
                # endregion

                # region Cancel
                case "Cancel":
                    mcn = new Cancel();
                    break;
                # endregion

                # region Carnival Hellsteed
                case "Carnival Hellsteed":
                    mcn = new CarnivalHellsteed();
                    break;
                # endregion

                # region Catacomb Slug
                case "Catacomb Slug":
                    mcn = new CatacombSlug();
                    break;
                # endregion

                # region Centaur Healer
                case "Centaur Healer":
                    mcn = new CentaurHealer();
                    break;
                # endregion

                # region Centaur's Herald
                case "Centaur's Herald":
                    mcn = new CentaursHerald();
                    break;
                # endregion

                # region Chaos Imps
                case "Chaos Imps":
                    mcn = new ChaosImps();
                    break;
                # endregion

                # region Chemister's Trick
                case "Chemister's Trick":
                    mcn = new ChemistersTrick();
                    break;
                # endregion

                # region Chorus of Might
                case "Chorus of Might":
                    mcn = new ChorusofMight();
                    break;
                # endregion

                # region Chromatic Lantern
                case "Chromatic Lantern":
                    mcn = new ChromaticLantern();
                    break;
                # endregion

                # region Chronic Flooding
                case "Chronic Flooding":
                    mcn = new ChronicFlooding();
                    break;
                # endregion

                # region Civic Saber
                case "Civic Saber":
                    mcn = new CivicSaber();
                    break;
                # endregion

                # region Cobblebrute
                case "Cobblebrute":
                    mcn = new Cobblebrute();
                    break;
                # endregion

                # region Codex Shredder
                case "Codex Shredder":
                    mcn = new CodexShredder();
                    break;
                # endregion

                # region Collective Blessing
                case "Collective Blessing":
                    mcn = new CollectiveBlessing();
                    break;
                # endregion

                # region Common Bond
                case "Common Bond":
                    mcn = new CommonBond();
                    break;
                # endregion

                # region Concordia Pegasus
                case "Concordia Pegasus":
                    mcn = new ConcordiaPegasus();
                    break;
                # endregion

                # region Conjured Currency
                case "Conjured Currency":
                    mcn = new ConjuredCurrency();
                    break;
                # endregion

                # region Corpsejack Menace
                case "Corpsejack Menace":
                    mcn = new CorpsejackMenace();
                    break;
                # endregion

                # region Counterflux
                case "Counterflux":
                    mcn = new Counterflux();
                    break;
                # endregion

                # region Coursers' Accord
                case "Coursers' Accord":
                    mcn = new CoursersAccord();
                    break;
                # endregion

                # region Cremate
                case "Cremate":
                    mcn = new Cremate();
                    break;
                # endregion

                # region Crosstown Courier
                case "Crosstown Courier":
                    mcn = new CrosstownCourier();
                    break;
                # endregion

                # region Cryptborn Horror
                case "Cryptborn Horror":
                    mcn = new CryptbornHorror();
                    break;
                # endregion

                # region Cyclonic Rift
                case "Cyclonic Rift":
                    mcn = new CyclonicRift();
                    break;
                # endregion

                # region Daggerdrome Imp
                case "Daggerdrome Imp":
                    mcn = new DaggerdromeImp();
                    break;
                # endregion

                # region Dark Revenant
                case "Dark Revenant":
                    mcn = new DarkRevenant();
                    break;
                # endregion

                # region Dead Reveler
                case "Dead Reveler":
                    mcn = new DeadReveler();
                    break;
                # endregion

                # region Deadbridge Goliath
                case "Deadbridge Goliath":
                    mcn = new DeadbridgeGoliath();
                    break;
                # endregion

                # region Deathrite Shaman
                case "Deathrite Shaman":
                    mcn = new DeathriteShaman();
                    break;
                # endregion

                # region Death's Presence
                case "Death's Presence":
                    mcn = new DeathsPresence();
                    break;
                # endregion

                # region Desecration Demon
                case "Desecration Demon":
                    mcn = new DesecrationDemon();
                    break;
                # endregion

                # region Destroy the Evidence
                case "Destroy the Evidence":
                    mcn = new DestroytheEvidence();
                    break;
                # endregion

                # region Detention Sphere
                case "Detention Sphere":
                    mcn = new DetentionSphere();
                    break;
                # endregion

                # region Deviant Glee
                case "Deviant Glee":
                    mcn = new DeviantGlee();
                    break;
                # endregion

                # region Dispel
                case "Dispel":
                    mcn = new Dispel();
                    break;
                # endregion

                # region Doorkeeper
                case "Doorkeeper":
                    mcn = new Doorkeeper();
                    break;
                # endregion

                # region Downsize
                case "Downsize":
                    mcn = new Downsize();
                    break;
                # endregion

                # region Drainpipe Vermin
                case "Drainpipe Vermin":
                    mcn = new DrainpipeVermin();
                    break;
                # endregion

                # region Dramatic Rescue
                case "Dramatic Rescue":
                    mcn = new DramaticRescue();
                    break;
                # endregion

                # region Dreadbore
                case "Dreadbore":
                    mcn = new Dreadbore();
                    break;
                # endregion

                # region Dreg Mangler
                case "Dreg Mangler":
                    mcn = new DregMangler();
                    break;
                # endregion

                # region Drudge Beetle
                case "Drudge Beetle":
                    mcn = new DrudgeBeetle();
                    break;
                # endregion

                # region Druid's Deliverance
                case "Druid's Deliverance":
                    mcn = new DruidsDeliverance();
                    break;
                # endregion

                # region Dryad Militant
                case "Dryad Militant":
                    mcn = new DryadMilitant();
                    break;
                # endregion

                # region Dynacharge
                case "Dynacharge":
                    mcn = new Dynacharge();
                    break;
                # endregion

                # region Electrickery
                case "Electrickery":
                    mcn = new Electrickery();
                    break;
                # endregion

                # region Epic Experiment
                case "Epic Experiment":
                    mcn = new EpicExperiment();
                    break;
                # endregion

                # region Essence Backlash
                case "Essence Backlash":
                    mcn = new EssenceBacklash();
                    break;
                # endregion

                # region Ethereal Armor
                case "Ethereal Armor":
                    mcn = new EtherealArmor();
                    break;
                # endregion

                # region Explosive Impact
                case "Explosive Impact":
                    mcn = new ExplosiveImpact();
                    break;
                # endregion

                # region Eyes in the Skies
                case "Eyes in the Skies":
                    mcn = new EyesintheSkies();
                    break;
                # endregion

                # region Faerie Impostor
                case "Faerie Impostor":
                    mcn = new FaerieImpostor();
                    break;
                # endregion

                # region Fall of the Gavel
                case "Fall of the Gavel":
                    mcn = new FalloftheGavel();
                    break;
                # endregion

                # region Fencing Ace
                case "Fencing Ace":
                    mcn = new FencingAce();
                    break;
                # endregion

                # region Firemind's Foresight
                case "Firemind's Foresight":
                    mcn = new FiremindsForesight();
                    break;
                # endregion

                //# region Forest
                //case "Forest":
                //    mcn = new Forest();
                //    break;
                //# endregion

                # region Frostburn Weird
                case "Frostburn Weird":
                    mcn = new FrostburnWeird();
                    break;
                # endregion

                # region Gatecreeper Vine
                case "Gatecreeper Vine":
                    mcn = new GatecreeperVine();
                    break;
                # endregion

                # region Giant Growth
                case "Giant Growth":
                    mcn = new GiantGrowth();
                    break;
                # endregion

                # region Gobbling Ooze
                case "Gobbling Ooze":
                    mcn = new GobblingOoze();
                    break;
                # endregion

                # region Goblin Electromancer
                case "Goblin Electromancer":
                    mcn = new GoblinElectromancer();
                    break;
                # endregion

                # region Goblin Rally
                case "Goblin Rally":
                    mcn = new GoblinRally();
                    break;
                # endregion

                # region Golgari Charm
                case "Golgari Charm":
                    mcn = new GolgariCharm();
                    break;
                # endregion

                # region Golgari Decoy
                case "Golgari Decoy":
                    mcn = new GolgariDecoy();
                    break;
                # endregion

                # region Golgari Guildgate
                case "Golgari Guildgate":
                    mcn = new GolgariGuildgate();
                    break;
                # endregion

                # region Golgari Keyrune
                case "Golgari Keyrune":
                    mcn = new GolgariKeyrune();
                    break;
                # endregion

                # region Golgari Longlegs
                case "Golgari Longlegs":
                    mcn = new GolgariLonglegs();
                    break;
                # endregion

                # region Gore-House Chainwalker
                case "Gore-House Chainwalker":
                    mcn = new GoreHouseChainwalker();
                    break;
                # endregion

                # region Grave Betrayal
                case "Grave Betrayal":
                    mcn = new GraveBetrayal();
                    break;
                # endregion

                # region Grim Roustabout
                case "Grim Roustabout":
                    mcn = new GrimRoustabout();
                    break;
                # endregion

                # region Grisly Salvage
                case "Grisly Salvage":
                    mcn = new GrislySalvage();
                    break;
                # endregion

                # region Grove of the Guardian
                case "Grove of the Guardian":
                    mcn = new GroveoftheGuardian();
                    break;
                # endregion

                # region Growing Ranks
                case "Growing Ranks":
                    mcn = new GrowingRanks();
                    break;
                # endregion

                # region Guild Feud
                case "Guild Feud":
                    mcn = new GuildFeud();
                    break;
                # endregion

                # region Guttersnipe
                case "Guttersnipe":
                    mcn = new Guttersnipe();
                    break;
                # endregion

                # region Hallowed Fountain
                case "Hallowed Fountain":
                    mcn = new HallowedFountain();
                    break;
                # endregion

                # region Havoc Festival
                case "Havoc Festival":
                    mcn = new HavocFestival();
                    break;
                # endregion

                # region Hellhole Flailer
                case "Hellhole Flailer":
                    mcn = new HellholeFlailer();
                    break;
                # endregion

                # region Heroes' Reunion
                case "Heroes' Reunion":
                    mcn = new HeroesReunion();
                    break;
                # endregion

                # region Horncaller's Chant
                case "Horncaller's Chant":
                    mcn = new HorncallersChant();
                    break;
                # endregion

                # region Hover Barrier
                case "Hover Barrier":
                    mcn = new HoverBarrier();
                    break;
                # endregion

                # region Hussar Patrol
                case "Hussar Patrol":
                    mcn = new HussarPatrol();
                    break;
                # endregion

                # region Hypersonic Dragon
                case "Hypersonic Dragon":
                    mcn = new HypersonicDragon();
                    break;
                # endregion

                # region Inaction Injunction
                case "Inaction Injunction":
                    mcn = new InactionInjunction();
                    break;
                # endregion

                # region Inspiration
                case "Inspiration":
                    mcn = new Inspiration();
                    break;
                # endregion

                //# region Island
                //case "Island":
                //    mcn = new Island();
                //    break;
                //# endregion

                # region Isperia, Supreme Judge
                case "Isperia, Supreme Judge":
                    mcn = new IsperiaSupremeJudge();
                    break;
                # endregion

                # region Isperia's Skywatch
                case "Isperia's Skywatch":
                    mcn = new IsperiasSkywatch();
                    break;
                # endregion

                # region Izzet Charm
                case "Izzet Charm":
                    mcn = new IzzetCharm();
                    break;
                # endregion

                # region Izzet Guildgate
                case "Izzet Guildgate":
                    mcn = new IzzetGuildgate();
                    break;
                # endregion

                # region Izzet Keyrune
                case "Izzet Keyrune":
                    mcn = new IzzetKeyrune();
                    break;
                # endregion

                # region Izzet Staticaster
                case "Izzet Staticaster":
                    mcn = new IzzetStaticaster();
                    break;
                # endregion

                # region Jace, Architect of Thought
                case "Jace, Architect of Thought":
                    mcn = new JaceArchitectofThought();
                    break;
                # endregion

                # region Jarad, Golgari Lich Lord
                case "Jarad, Golgari Lich Lord":
                    mcn = new JaradGolgariLichLord();
                    break;
                # endregion

                # region Jarad's Orders
                case "Jarad's Orders":
                    mcn = new JaradsOrders();
                    break;
                # endregion

                # region Judge's Familiar
                case "Judge's Familiar":
                    mcn = new JudgesFamiliar();
                    break;
                # endregion

                # region Keening Apparition
                case "Keening Apparition":
                    mcn = new KeeningApparition();
                    break;
                # endregion

                # region Knightly Valor
                case "Knightly Valor":
                    mcn = new KnightlyValor();
                    break;
                # endregion

                # region Korozda Guildmage
                case "Korozda Guildmage":
                    mcn = new KorozdaGuildmage();
                    break;
                # endregion

                # region Korozda Monitor
                case "Korozda Monitor":
                    mcn = new KorozdaMonitor();
                    break;
                # endregion

                # region Launch Party
                case "Launch Party":
                    mcn = new LaunchParty();
                    break;
                # endregion

                # region Lobber Crew
                case "Lobber Crew":
                    mcn = new LobberCrew();
                    break;
                # endregion

                # region Lotleth Troll
                case "Lotleth Troll":
                    mcn = new LotlethTroll();
                    break;
                # endregion

                # region Loxodon Smiter
                case "Loxodon Smiter":
                    mcn = new LoxodonSmiter();
                    break;
                # endregion

                # region Lyev Skyknight
                case "Lyev Skyknight":
                    mcn = new LyevSkyknight();
                    break;
                # endregion

                # region Mana Bloom
                case "Mana Bloom":
                    mcn = new ManaBloom();
                    break;
                # endregion

                # region Martial Law
                case "Martial Law":
                    mcn = new MartialLaw();
                    break;
                # endregion

                # region Mercurial Chemister
                case "Mercurial Chemister":
                    mcn = new MercurialChemister();
                    break;
                # endregion

                # region Mind Rot
                case "Mind Rot":
                    mcn = new MindRot();
                    break;
                # endregion

                # region Minotaur Aggressor
                case "Minotaur Aggressor":
                    mcn = new MinotaurAggressor();
                    break;
                # endregion

                # region Mizzium Mortars
                case "Mizzium Mortars":
                    mcn = new MizziumMortars();
                    break;
                # endregion

                # region Mizzium Skin
                case "Mizzium Skin":
                    mcn = new MizziumSkin();
                    break;
                # endregion

                //# region Mountain
                //case "Mountain":
                //    mcn = new Mountain();
                //    break;
                //# endregion

                # region Necropolis Regent
                case "Necropolis Regent":
                    mcn = new NecropolisRegent();
                    break;
                # endregion

                # region New Prahv Guildmage
                case "New Prahv Guildmage":
                    mcn = new NewPrahvGuildmage();
                    break;
                # endregion

                # region Nivix Guildmage
                case "Nivix Guildmage":
                    mcn = new NivixGuildmage();
                    break;
                # endregion

                # region Nivmagus Elemental
                case "Nivmagus Elemental":
                    mcn = new NivmagusElemental();
                    break;
                # endregion

                # region Niv-Mizzet, Dracogenius
                case "Niv-Mizzet, Dracogenius":
                    mcn = new NivMizzetDracogenius();
                    break;
                # endregion

                # region Oak Street Innkeeper
                case "Oak Street Innkeeper":
                    mcn = new OakStreetInnkeeper();
                    break;
                # endregion

                # region Ogre Jailbreaker
                case "Ogre Jailbreaker":
                    mcn = new OgreJailbreaker();
                    break;
                # endregion

                # region Overgrown Tomb
                case "Overgrown Tomb":
                    mcn = new OvergrownTomb();
                    break;
                # endregion

                # region Pack Rat
                case "Pack Rat":
                    mcn = new PackRat();
                    break;
                # endregion

                # region Palisade Giant
                case "Palisade Giant":
                    mcn = new PalisadeGiant();
                    break;
                # endregion

                # region Paralyzing Grasp
                case "Paralyzing Grasp":
                    mcn = new ParalyzingGrasp();
                    break;
                # endregion

                # region Perilous Shadow
                case "Perilous Shadow":
                    mcn = new PerilousShadow();
                    break;
                # endregion

                # region Phantom General
                case "Phantom General":
                    mcn = new PhantomGeneral();
                    break;
                # endregion

                # region Pithing Needle
                case "Pithing Needle":
                    mcn = new PithingNeedle();
                    break;
                # endregion

                //# region Plains
                //case "Plains":
                //    mcn = new Plains();
                //    break;
                //# endregion

                # region Precinct Captain
                case "Precinct Captain":
                    mcn = new PrecinctCaptain();
                    break;
                # endregion

                # region Psychic Spiral
                case "Psychic Spiral":
                    mcn = new PsychicSpiral();
                    break;
                # endregion

                # region Pursuit of Flight
                case "Pursuit of Flight":
                    mcn = new PursuitofFlight();
                    break;
                # endregion

                # region Pyroconvergence
                case "Pyroconvergence":
                    mcn = new Pyroconvergence();
                    break;
                # endregion

                # region Racecourse Fury
                case "Racecourse Fury":
                    mcn = new RacecourseFury();
                    break;
                # endregion

                # region Rakdos Cackler
                case "Rakdos Cackler":
                    mcn = new RakdosCackler();
                    break;
                # endregion

                # region Rakdos Charm
                case "Rakdos Charm":
                    mcn = new RakdosCharm();
                    break;
                # endregion

                # region Rakdos Guildgate
                case "Rakdos Guildgate":
                    mcn = new RakdosGuildgate();
                    break;
                # endregion

                # region Rakdos Keyrune
                case "Rakdos Keyrune":
                    mcn = new RakdosKeyrune();
                    break;
                # endregion

                # region Rakdos Ragemutt
                case "Rakdos Ragemutt":
                    mcn = new RakdosRagemutt();
                    break;
                # endregion

                # region Rakdos Ringleader
                case "Rakdos Ringleader":
                    mcn = new RakdosRingleader();
                    break;
                # endregion

                # region Rakdos Shred-Freak
                case "Rakdos Shred-Freak":
                    mcn = new RakdosShredFreak();
                    break;
                # endregion

                # region Rakdos, Lord of Riots
                case "Rakdos, Lord of Riots":
                    mcn = new RakdosLordofRiots();
                    break;
                # endregion

                # region Rakdos's Return
                case "Rakdos's Return":
                    mcn = new RakdossReturn();
                    break;
                # endregion

                # region Rest in Peace
                case "Rest in Peace":
                    mcn = new RestinPeace();
                    break;
                # endregion

                # region Righteous Authority
                case "Righteous Authority":
                    mcn = new RighteousAuthority();
                    break;
                # endregion

                # region Risen Sanctuary
                case "Risen Sanctuary":
                    mcn = new RisenSanctuary();
                    break;
                # endregion

                # region Rites of Reaping
                case "Rites of Reaping":
                    mcn = new RitesofReaping();
                    break;
                # endregion

                # region Rix Maadi Guildmage
                case "Rix Maadi Guildmage":
                    mcn = new RixMaadiGuildmage();
                    break;
                # endregion

                # region Rogue's Passage
                case "Rogue's Passage":
                    mcn = new RoguesPassage();
                    break;
                # endregion

                # region Rootborn Defenses
                case "Rootborn Defenses":
                    mcn = new RootbornDefenses();
                    break;
                # endregion

                # region Rubbleback Rhino
                case "Rubbleback Rhino":
                    mcn = new RubblebackRhino();
                    break;
                # endregion

                # region Runewing
                case "Runewing":
                    mcn = new Runewing();
                    break;
                # endregion

                //# region Savage Surge
                //case "Savage Surge":
                //    mcn = new SavageSurge();
                //    break;
                //# endregion

                # region Search the City
                case "Search the City":
                    mcn = new SearchtheCity();
                    break;
                # endregion

                # region Search Warrant
                case "Search Warrant":
                    mcn = new SearchWarrant();
                    break;
                # endregion

                # region Security Blockade
                case "Security Blockade":
                    mcn = new SecurityBlockade();
                    break;
                # endregion

                # region Seek the Horizon
                case "Seek the Horizon":
                    mcn = new SeektheHorizon();
                    break;
                # endregion

                # region Selesnya Charm
                case "Selesnya Charm":
                    mcn = new SelesnyaCharm();
                    break;
                # endregion

                # region Selesnya Guildgate
                case "Selesnya Guildgate":
                    mcn = new SelesnyaGuildgate();
                    break;
                # endregion

                # region Selesnya Keyrune
                case "Selesnya Keyrune":
                    mcn = new SelesnyaKeyrune();
                    break;
                # endregion

                # region Selesnya Sentry
                case "Selesnya Sentry":
                    mcn = new SelesnyaSentry();
                    break;
                # endregion

                # region Seller of Songbirds
                case "Seller of Songbirds":
                    mcn = new SellerofSongbirds();
                    break;
                # endregion

                # region Sewer Shambler
                case "Sewer Shambler":
                    mcn = new SewerShambler();
                    break;
                # endregion

                # region Shrieking Affliction
                case "Shrieking Affliction":
                    mcn = new ShriekingAffliction();
                    break;
                # endregion

                # region Skull Rend
                case "Skull Rend":
                    mcn = new SkullRend();
                    break;
                # endregion

                # region Skyline Predator
                case "Skyline Predator":
                    mcn = new SkylinePredator();
                    break;
                # endregion

                # region Skymark Roc
                case "Skymark Roc":
                    mcn = new SkymarkRoc();
                    break;
                # endregion

                # region Slaughter Games
                case "Slaughter Games":
                    mcn = new SlaughterGames();
                    break;
                # endregion

                # region Slime Molding
                case "Slime Molding":
                    mcn = new SlimeMolding();
                    break;
                # endregion

                # region Slitherhead
                case "Slitherhead":
                    mcn = new Slitherhead();
                    break;
                # endregion

                # region Sluiceway Scorpion
                case "Sluiceway Scorpion":
                    mcn = new SluicewayScorpion();
                    break;
                # endregion

                # region Slum Reaper
                case "Slum Reaper":
                    mcn = new SlumReaper();
                    break;
                # endregion

                # region Soul Tithe
                case "Soul Tithe":
                    mcn = new SoulTithe();
                    break;
                # endregion

                # region Soulsworn Spirit
                case "Soulsworn Spirit":
                    mcn = new SoulswornSpirit();
                    break;
                # endregion

                # region Spawn of Rix Maadi
                case "Spawn of Rix Maadi":
                    mcn = new SpawnofRixMaadi();
                    break;
                # endregion

                # region Sphere of Safety
                case "Sphere of Safety":
                    mcn = new SphereofSafety();
                    break;
                # endregion

                # region Sphinx of the Chimes
                case "Sphinx of the Chimes":
                    mcn = new SphinxoftheChimes();
                    break;
                # endregion

                # region Sphinx's Revelation
                case "Sphinx's Revelation":
                    mcn = new SphinxsRevelation();
                    break;
                # endregion

                # region Splatter Thug
                case "Splatter Thug":
                    mcn = new SplatterThug();
                    break;
                # endregion

                # region Stab Wound
                case "Stab Wound":
                    mcn = new StabWound();
                    break;
                # endregion

                # region Stealer of Secrets
                case "Stealer of Secrets":
                    mcn = new StealerofSecrets();
                    break;
                # endregion

                # region Steam Vents
                case "Steam Vents":
                    mcn = new SteamVents();
                    break;
                # endregion

                # region Stonefare Crocodile
                case "Stonefare Crocodile":
                    mcn = new StonefareCrocodile();
                    break;
                # endregion

                # region Street Spasm
                case "Street Spasm":
                    mcn = new StreetSpasm();
                    break;
                # endregion

                # region Street Sweeper
                case "Street Sweeper":
                    mcn = new StreetSweeper();
                    break;
                # endregion

                # region Sundering Growth
                case "Sundering Growth":
                    mcn = new SunderingGrowth();
                    break;
                # endregion

                # region Sunspire Griffin
                case "Sunspire Griffin":
                    mcn = new SunspireGriffin();
                    break;
                # endregion

                # region Supreme Verdict
                case "Supreme Verdict":
                    mcn = new SupremeVerdict();
                    break;
                # endregion

                # region Survey the Wreckage
                case "Survey the Wreckage":
                    mcn = new SurveytheWreckage();
                    break;
                # endregion

                //# region Swamp
                //case "Swamp":
                //    mcn = new Swamp();
                //    break;
                //# endregion

                # region Swift Justice
                case "Swift Justice":
                    mcn = new SwiftJustice();
                    break;
                # endregion

                # region Syncopate
                case "Syncopate":
                    mcn = new Syncopate();
                    break;
                # endregion

                # region Tablet of the Guilds
                case "Tablet of the Guilds":
                    mcn = new TabletoftheGuilds();
                    break;
                # endregion

                # region Tavern Swindler
                case "Tavern Swindler":
                    mcn = new TavernSwindler();
                    break;
                # endregion

                # region Teleportal
                case "Teleportal":
                    mcn = new Teleportal();
                    break;
                # endregion

                # region Temple Garden
                case "Temple Garden":
                    mcn = new TempleGarden();
                    break;
                # endregion

                # region Tenement Crasher
                case "Tenement Crasher":
                    mcn = new TenementCrasher();
                    break;
                # endregion

                # region Terrus Wurm
                case "Terrus Wurm":
                    mcn = new TerrusWurm();
                    break;
                # endregion

                # region Thoughtflare
                case "Thoughtflare":
                    mcn = new Thoughtflare();
                    break;
                # endregion

                # region Thrill-Kill Assassin
                case "Thrill-Kill Assassin":
                    mcn = new ThrillKillAssassin();
                    break;
                # endregion

                # region Tower Drake
                case "Tower Drake":
                    mcn = new TowerDrake();
                    break;
                # endregion

                # region Towering Indrik
                case "Towering Indrik":
                    mcn = new ToweringIndrik();
                    break;
                # endregion

                # region Trained Caracal
                case "Trained Caracal":
                    mcn = new TrainedCaracal();
                    break;
                # endregion

                # region Traitorous Instinct
                case "Traitorous Instinct":
                    mcn = new TraitorousInstinct();
                    break;
                # endregion

                # region Transguild Promenade
                case "Transguild Promenade":
                    mcn = new TransguildPromenade();
                    break;
                # endregion

                # region Treasured Find
                case "Treasured Find":
                    mcn = new TreasuredFind();
                    break;
                # endregion

                # region Trestle Troll
                case "Trestle Troll":
                    mcn = new TrestleTroll();
                    break;
                # endregion

                # region Trostani, Selesnya's Voice
                case "Trostani, Selesnya's Voice":
                    mcn = new TrostaniSelesnyasVoice();
                    break;
                # endregion

                # region Trostani's Judgment
                case "Trostani's Judgment":
                    mcn = new TrostanisJudgment();
                    break;
                # endregion

                # region Ultimate Price
                case "Ultimate Price":
                    mcn = new UltimatePrice();
                    break;
                # endregion

                # region Underworld Connections
                case "Underworld Connections":
                    mcn = new UnderworldConnections();
                    break;
                # endregion

                # region Urban Burgeoning
                case "Urban Burgeoning":
                    mcn = new UrbanBurgeoning();
                    break;
                # endregion

                # region Utvara Hellkite
                case "Utvara Hellkite":
                    mcn = new UtvaraHellkite();
                    break;
                # endregion

                # region Vandalblast
                case "Vandalblast":
                    mcn = new Vandalblast();
                    break;
                # endregion

                # region Vassal Soul
                case "Vassal Soul":
                    mcn = new VassalSoul();
                    break;
                # endregion

                # region Viashino Racketeer
                case "Viashino Racketeer":
                    mcn = new ViashinoRacketeer();
                    break;
                # endregion

                # region Vitu-Ghazi Guildmage
                case "Vitu-Ghazi Guildmage":
                    mcn = new VituGhaziGuildmage();
                    break;
                # endregion

                # region Voidwielder
                case "Voidwielder":
                    mcn = new Voidwielder();
                    break;
                # endregion

                # region Volatile Rig
                case "Volatile Rig":
                    mcn = new VolatileRig();
                    break;
                # endregion

                # region Vraska the Unseen
                case "Vraska the Unseen":
                    mcn = new VraskatheUnseen();
                    break;
                # endregion

                # region Wayfaring Temple
                case "Wayfaring Temple":
                    mcn = new WayfaringTemple();
                    break;
                # endregion

                # region Wild Beastmaster
                case "Wild Beastmaster":
                    mcn = new WildBeastmaster();
                    break;
                # endregion

                # region Worldspine Wurm
                case "Worldspine Wurm":
                    mcn = new WorldspineWurm();
                    break;
                # endregion

                # region Zanikev Locust
                case "Zanikev Locust":
                    mcn = new ZanikevLocust();
                    break;
                # endregion
                # endregion

                # region Gatecrash
                # region Act of Treason
                case "Act of Treason":
                    mcn = new ActofTreason();
                    break;
                # endregion

                # region Adaptive Snapjaw
                case "Adaptive Snapjaw":
                    mcn = new AdaptiveSnapjaw();
                    break;
                # endregion

                # region Aerial Maneuver
                case "Aerial Maneuver":
                    mcn = new AerialManeuver();
                    break;
                # endregion

                # region AEtherize
                case "AEtherize":
                    mcn = new AEtherize();
                    break;
                # endregion

                # region Agoraphobia
                case "Agoraphobia":
                    mcn = new Agoraphobia();
                    break;
                # endregion

                # region Alms Beast
                case "Alms Beast":
                    mcn = new AlmsBeast();
                    break;
                # endregion

                # region Alpha Authority
                case "Alpha Authority":
                    mcn = new AlphaAuthority();
                    break;
                # endregion

                # region Angelic Edict
                case "Angelic Edict":
                    mcn = new AngelicEdict();
                    break;
                # endregion

                # region Angelic Skirmisher
                case "Angelic Skirmisher":
                    mcn = new AngelicSkirmisher();
                    break;
                # endregion

                # region Armored Transport
                case "Armored Transport":
                    mcn = new ArmoredTransport();
                    break;
                # endregion

                # region Arrows of Justice
                case "Arrows of Justice":
                    mcn = new ArrowsofJustice();
                    break;
                # endregion

                # region Assault Griffin
                case "Assault Griffin":
                    mcn = new AssaultGriffin();
                    break;
                # endregion

                # region Assemble the Legion
                case "Assemble the Legion":
                    mcn = new AssembletheLegion();
                    break;
                # endregion

                # region Aurelia, the Warleader
                case "Aurelia, the Warleader":
                    mcn = new AureliatheWarleader();
                    break;
                # endregion

                # region Aurelia's Fury
                case "Aurelia's Fury":
                    mcn = new AureliasFury();
                    break;
                # endregion

                # region Balustrade Spy
                case "Balustrade Spy":
                    mcn = new BalustradeSpy();
                    break;
                # endregion

                # region Bane Alley Broker
                case "Bane Alley Broker":
                    mcn = new BaneAlleyBroker();
                    break;
                # endregion

                # region Basilica Guards
                case "Basilica Guards":
                    mcn = new BasilicaGuards();
                    break;
                # endregion

                # region Basilica Screecher
                case "Basilica Screecher":
                    mcn = new BasilicaScreecher();
                    break;
                # endregion

                # region Beckon Apparition
                case "Beckon Apparition":
                    mcn = new BeckonApparition();
                    break;
                # endregion

                # region Biomass Mutation
                case "Biomass Mutation":
                    mcn = new BiomassMutation();
                    break;
                # endregion

                # region Bioshift
                case "Bioshift":
                    mcn = new Bioshift();
                    break;
                # endregion

                # region Biovisionary
                case "Biovisionary":
                    mcn = new Biovisionary();
                    break;
                # endregion

                # region Blind Obedience
                case "Blind Obedience":
                    mcn = new BlindObedience();
                    break;
                # endregion

                # region Bomber Corps
                case "Bomber Corps":
                    mcn = new BomberCorps();
                    break;
                # endregion

                # region Borborygmos Enraged
                case "Borborygmos Enraged":
                    mcn = new BorborygmosEnraged();
                    break;
                # endregion

                # region Boros Charm
                case "Boros Charm":
                    mcn = new BorosCharm();
                    break;
                # endregion

                # region Boros Elite
                case "Boros Elite":
                    mcn = new BorosElite();
                    break;
                # endregion

                # region Boros Guildgate
                case "Boros Guildgate":
                    mcn = new BorosGuildgate();
                    break;
                # endregion

                # region Boros Keyrune
                case "Boros Keyrune":
                    mcn = new BorosKeyrune();
                    break;
                # endregion

                # region Boros Reckoner
                case "Boros Reckoner":
                    mcn = new BorosReckoner();
                    break;
                # endregion

                # region Breeding Pool
                case "Breeding Pool":
                    mcn = new BreedingPool();
                    break;
                # endregion

                # region Burning-Tree Emissary
                case "Burning-Tree Emissary":
                    mcn = new BurningTreeEmissary();
                    break;
                # endregion

                # region Burst of Strength
                case "Burst of Strength":
                    mcn = new BurstofStrength();
                    break;
                # endregion

                # region Call of the Nightwing
                case "Call of the Nightwing":
                    mcn = new CalloftheNightwing();
                    break;
                # endregion

                # region Cartel Aristocrat
                case "Cartel Aristocrat":
                    mcn = new CartelAristocrat();
                    break;
                # endregion

                # region Cinder Elemental
                case "Cinder Elemental":
                    mcn = new CinderElemental();
                    break;
                # endregion

                # region Clan Defiance
                case "Clan Defiance":
                    mcn = new ClanDefiance();
                    break;
                # endregion

                # region Clinging Anemones
                case "Clinging Anemones":
                    mcn = new ClingingAnemones();
                    break;
                # endregion

                # region Cloudfin Raptor
                case "Cloudfin Raptor":
                    mcn = new CloudfinRaptor();
                    break;
                # endregion

                # region Coerced Confession
                case "Coerced Confession":
                    mcn = new CoercedConfession();
                    break;
                # endregion

                # region Consuming Aberration
                case "Consuming Aberration":
                    mcn = new ConsumingAberration();
                    break;
                # endregion

                # region Contaminated Ground
                case "Contaminated Ground":
                    mcn = new ContaminatedGround();
                    break;
                # endregion

                # region Corpse Blockade
                case "Corpse Blockade":
                    mcn = new CorpseBlockade();
                    break;
                # endregion

                # region Court Street Denizen
                case "Court Street Denizen":
                    mcn = new CourtStreetDenizen();
                    break;
                # endregion

                # region Crackling Perimeter
                case "Crackling Perimeter":
                    mcn = new CracklingPerimeter();
                    break;
                # endregion

                # region Crocanura
                case "Crocanura":
                    mcn = new Crocanura();
                    break;
                # endregion

                # region Crowned Ceratok
                case "Crowned Ceratok":
                    mcn = new CrownedCeratok();
                    break;
                # endregion

                # region Crypt Ghast
                case "Crypt Ghast":
                    mcn = new CryptGhast();
                    break;
                # endregion

                # region Daring Skyjek
                case "Daring Skyjek":
                    mcn = new DaringSkyjek();
                    break;
                # endregion

                # region Deathcult Rogue
                case "Deathcult Rogue":
                    mcn = new DeathcultRogue();
                    break;
                # endregion

                # region Deathpact Angel
                case "Deathpact Angel":
                    mcn = new DeathpactAngel();
                    break;
                # endregion

                # region Death's Approach
                case "Death's Approach":
                    mcn = new DeathsApproach();
                    break;
                # endregion

                # region Debtor's Pulpit
                case "Debtor's Pulpit":
                    mcn = new DebtorsPulpit();
                    break;
                # endregion

                # region Devour Flesh
                case "Devour Flesh":
                    mcn = new DevourFlesh();
                    break;
                # endregion

                # region Diluvian Primordial
                case "Diluvian Primordial":
                    mcn = new DiluvianPrimordial();
                    break;
                # endregion

                # region Dimir Charm
                case "Dimir Charm":
                    mcn = new DimirCharm();
                    break;
                # endregion

                # region Dimir Guildgate
                case "Dimir Guildgate":
                    mcn = new DimirGuildgate();
                    break;
                # endregion

                # region Dimir Keyrune
                case "Dimir Keyrune":
                    mcn = new DimirKeyrune();
                    break;
                # endregion

                # region Dinrova Horror
                case "Dinrova Horror":
                    mcn = new DinrovaHorror();
                    break;
                # endregion

                # region Disciple of the Old Ways
                case "Disciple of the Old Ways":
                    mcn = new DiscipleoftheOldWays();
                    break;
                # endregion

                # region Domri Rade
                case "Domri Rade":
                    mcn = new DomriRade();
                    break;
                # endregion

                # region Drakewing Krasis
                case "Drakewing Krasis":
                    mcn = new DrakewingKrasis();
                    break;
                # endregion

                # region Duskmantle Guildmage
                case "Duskmantle Guildmage":
                    mcn = new DuskmantleGuildmage();
                    break;
                # endregion

                # region Duskmantle Seer
                case "Duskmantle Seer":
                    mcn = new DuskmantleSeer();
                    break;
                # endregion

                # region Dutiful Thrull
                case "Dutiful Thrull":
                    mcn = new DutifulThrull();
                    break;
                # endregion

                # region Dying Wish
                case "Dying Wish":
                    mcn = new DyingWish();
                    break;
                # endregion

                # region Elusive Krasis
                case "Elusive Krasis":
                    mcn = new ElusiveKrasis();
                    break;
                # endregion

                # region Ember Beast
                case "Ember Beast":
                    mcn = new EmberBeast();
                    break;
                # endregion

                # region Enter the Infinite
                case "Enter the Infinite":
                    mcn = new EntertheInfinite();
                    break;
                # endregion

                # region Executioner's Swing
                case "Executioner's Swing":
                    mcn = new ExecutionersSwing();
                    break;
                # endregion

                # region Experiment One
                case "Experiment One":
                    mcn = new ExperimentOne();
                    break;
                # endregion

                # region Fathom Mage
                case "Fathom Mage":
                    mcn = new FathomMage();
                    break;
                # endregion

                # region Firefist Striker
                case "Firefist Striker":
                    mcn = new FirefistStriker();
                    break;
                # endregion

                # region Firemane Avenger
                case "Firemane Avenger":
                    mcn = new FiremaneAvenger();
                    break;
                # endregion

                # region Five-Alarm Fire
                case "Five-Alarm Fire":
                    mcn = new FiveAlarmFire();
                    break;
                # endregion

                # region Forced Adaptation
                case "Forced Adaptation":
                    mcn = new ForcedAdaptation();
                    break;
                # endregion

                # region Fortress Cyclops
                case "Fortress Cyclops":
                    mcn = new FortressCyclops();
                    break;
                # endregion

                # region Foundry Champion
                case "Foundry Champion":
                    mcn = new FoundryChampion();
                    break;
                # endregion

                # region Foundry Street Denizen
                case "Foundry Street Denizen":
                    mcn = new FoundryStreetDenizen();
                    break;
                # endregion

                # region Frenzied Tilling
                case "Frenzied Tilling":
                    mcn = new FrenziedTilling();
                    break;
                # endregion

                # region Frilled Oculus
                case "Frilled Oculus":
                    mcn = new FrilledOculus();
                    break;
                # endregion

                # region Frontline Medic
                case "Frontline Medic":
                    mcn = new FrontlineMedic();
                    break;
                # endregion

                # region Furious Resistance
                case "Furious Resistance":
                    mcn = new FuriousResistance();
                    break;
                # endregion

                # region Gateway Shade
                case "Gateway Shade":
                    mcn = new GatewayShade();
                    break;
                # endregion

                # region Ghor-Clan Rampager
                case "Ghor-Clan Rampager":
                    mcn = new GhorClanRampager();
                    break;
                # endregion

                # region Giant Adephage
                case "Giant Adephage":
                    mcn = new GiantAdephage();
                    break;
                # endregion

                # region Gideon, Champion of Justice
                case "Gideon, Champion of Justice":
                    mcn = new GideonChampionofJustice();
                    break;
                # endregion

                # region Gift of Orzhova
                case "Gift of Orzhova":
                    mcn = new GiftofOrzhova();
                    break;
                # endregion

                # region Glaring Spotlight
                case "Glaring Spotlight":
                    mcn = new GlaringSpotlight();
                    break;
                # endregion

                # region Godless Shrine
                case "Godless Shrine":
                    mcn = new GodlessShrine();
                    break;
                # endregion

                # region Greenside Watcher
                case "Greenside Watcher":
                    mcn = new GreensideWatcher();
                    break;
                # endregion

                # region Gridlock
                case "Gridlock":
                    mcn = new Gridlock();
                    break;
                # endregion

                # region Grisly Spectacle
                case "Grisly Spectacle":
                    mcn = new GrislySpectacle();
                    break;
                # endregion

                # region Ground Assault
                case "Ground Assault":
                    mcn = new GroundAssault();
                    break;
                # endregion

                # region Gruul Charm
                case "Gruul Charm":
                    mcn = new GruulCharm();
                    break;
                # endregion

                # region Gruul Guildgate
                case "Gruul Guildgate":
                    mcn = new GruulGuildgate();
                    break;
                # endregion

                # region Gruul Keyrune
                case "Gruul Keyrune":
                    mcn = new GruulKeyrune();
                    break;
                # endregion

                # region Gruul Ragebeast
                case "Gruul Ragebeast":
                    mcn = new GruulRagebeast();
                    break;
                # endregion

                # region Guardian of the Gateless
                case "Guardian of the Gateless":
                    mcn = new GuardianoftheGateless();
                    break;
                # endregion

                # region Guildscorn Ward
                case "Guildscorn Ward":
                    mcn = new GuildscornWard();
                    break;
                # endregion

                # region Gutter Skulk
                case "Gutter Skulk":
                    mcn = new GutterSkulk();
                    break;
                # endregion

                # region Gyre Sage
                case "Gyre Sage":
                    mcn = new GyreSage();
                    break;
                # endregion

                # region Hands of Binding
                case "Hands of Binding":
                    mcn = new HandsofBinding();
                    break;
                # endregion

                # region Hellkite Tyrant
                case "Hellkite Tyrant":
                    mcn = new HellkiteTyrant();
                    break;
                # endregion

                # region Hellraiser Goblin
                case "Hellraiser Goblin":
                    mcn = new HellraiserGoblin();
                    break;
                # endregion

                # region High Priest of Penance
                case "High Priest of Penance":
                    mcn = new HighPriestofPenance();
                    break;
                # endregion

                # region Hindervines
                case "Hindervines":
                    mcn = new Hindervines();
                    break;
                # endregion

                # region Hold the Gates
                case "Hold the Gates":
                    mcn = new HoldtheGates();
                    break;
                # endregion

                # region Holy Mantle
                case "Holy Mantle":
                    mcn = new HolyMantle();
                    break;
                # endregion

                # region Homing Lightning
                case "Homing Lightning":
                    mcn = new HomingLightning();
                    break;
                # endregion

                # region Horror of the Dim
                case "Horror of the Dim":
                    mcn = new HorroroftheDim();
                    break;
                # endregion

                # region Hydroform
                case "Hydroform":
                    mcn = new Hydroform();
                    break;
                # endregion

                # region Illness in the Ranks
                case "Illness in the Ranks":
                    mcn = new IllnessintheRanks();
                    break;
                # endregion

                # region Illusionist's Bracers
                case "Illusionist's Bracers":
                    mcn = new IllusionistsBracers();
                    break;
                # endregion

                # region Immortal Servitude
                case "Immortal Servitude":
                    mcn = new ImmortalServitude();
                    break;
                # endregion

                # region Incursion Specialist
                case "Incursion Specialist":
                    mcn = new IncursionSpecialist();
                    break;
                # endregion

                # region Ivy Lane Denizen
                case "Ivy Lane Denizen":
                    mcn = new IvyLaneDenizen();
                    break;
                # endregion

                # region Keymaster Rogue
                case "Keymaster Rogue":
                    mcn = new KeymasterRogue();
                    break;
                # endregion

                # region Killing Glare
                case "Killing Glare":
                    mcn = new KillingGlare();
                    break;
                # endregion

                # region Kingpin's Pet
                case "Kingpin's Pet":
                    mcn = new KingpinsPet();
                    break;
                # endregion

                # region Knight of Obligation
                case "Knight of Obligation":
                    mcn = new KnightofObligation();
                    break;
                # endregion

                # region Knight Watch
                case "Knight Watch":
                    mcn = new KnightWatch();
                    break;
                # endregion

                # region Last Thoughts
                case "Last Thoughts":
                    mcn = new LastThoughts();
                    break;
                # endregion

                # region Lazav, Dimir Mastermind
                case "Lazav, Dimir Mastermind":
                    mcn = new LazavDimirMastermind();
                    break;
                # endregion

                # region Legion Loyalist
                case "Legion Loyalist":
                    mcn = new LegionLoyalist();
                    break;
                # endregion

                # region Leyline Phantom
                case "Leyline Phantom":
                    mcn = new LeylinePhantom();
                    break;
                # endregion

                # region Lord of the Void
                case "Lord of the Void":
                    mcn = new LordoftheVoid();
                    break;
                # endregion

                # region Luminate Primordial
                case "Luminate Primordial":
                    mcn = new LuminatePrimordial();
                    break;
                # endregion

                # region Madcap Skills
                case "Madcap Skills":
                    mcn = new MadcapSkills();
                    break;
                # endregion

                # region Mark for Death
                case "Mark for Death":
                    mcn = new MarkforDeath();
                    break;
                # endregion

                # region Martial Glory
                case "Martial Glory":
                    mcn = new MartialGlory();
                    break;
                # endregion

                # region Massive Raid
                case "Massive Raid":
                    mcn = new MassiveRaid();
                    break;
                # endregion

                # region Master Biomancer
                case "Master Biomancer":
                    mcn = new MasterBiomancer();
                    break;
                # endregion

                # region Mental Vapors
                case "Mental Vapors":
                    mcn = new MentalVapors();
                    break;
                # endregion

                # region Merciless Eviction
                case "Merciless Eviction":
                    mcn = new MercilessEviction();
                    break;
                # endregion

                # region Merfolk of the Depths
                case "Merfolk of the Depths":
                    mcn = new MerfolkoftheDepths();
                    break;
                # endregion

                # region Metropolis Sprite
                case "Metropolis Sprite":
                    mcn = new MetropolisSprite();
                    break;
                # endregion

                # region Midnight Recovery
                case "Midnight Recovery":
                    mcn = new MidnightRecovery();
                    break;
                # endregion

                # region Millennial Gargoyle
                case "Millennial Gargoyle":
                    mcn = new MillennialGargoyle();
                    break;
                # endregion

                # region Miming Slime
                case "Miming Slime":
                    mcn = new MimingSlime();
                    break;
                # endregion

                # region Mind Grind
                case "Mind Grind":
                    mcn = new MindGrind();
                    break;
                # endregion

                # region Mindeye Drake
                case "Mindeye Drake":
                    mcn = new MindeyeDrake();
                    break;
                # endregion

                # region Molten Primordial
                case "Molten Primordial":
                    mcn = new MoltenPrimordial();
                    break;
                # endregion

                # region Mortus Strider
                case "Mortus Strider":
                    mcn = new MortusStrider();
                    break;
                # endregion

                # region Mugging
                case "Mugging":
                    mcn = new Mugging();
                    break;
                # endregion

                # region Murder Investigation
                case "Murder Investigation":
                    mcn = new MurderInvestigation();
                    break;
                # endregion

                # region Mystic Genesis
                case "Mystic Genesis":
                    mcn = new MysticGenesis();
                    break;
                # endregion

                # region Naturalize
                case "Naturalize":
                    mcn = new Naturalize();
                    break;
                # endregion

                # region Nav Squad Commandos
                case "Nav Squad Commandos":
                    mcn = new NavSquadCommandos();
                    break;
                # endregion

                # region Nightveil Specter
                case "Nightveil Specter":
                    mcn = new NightveilSpecter();
                    break;
                # endregion

                # region Nimbus Swimmer
                case "Nimbus Swimmer":
                    mcn = new NimbusSwimmer();
                    break;
                # endregion

                # region Obzedat, Ghost Council
                case "Obzedat, Ghost Council":
                    mcn = new ObzedatGhostCouncil();
                    break;
                # endregion

                # region Ogre Slumlord
                case "Ogre Slumlord":
                    mcn = new OgreSlumlord();
                    break;
                # endregion

                # region One Thousand Lashes
                case "One Thousand Lashes":
                    mcn = new OneThousandLashes();
                    break;
                # endregion

                # region Ooze Flux
                case "Ooze Flux":
                    mcn = new OozeFlux();
                    break;
                # endregion

                # region Ordruun Veteran
                case "Ordruun Veteran":
                    mcn = new OrdruunVeteran();
                    break;
                # endregion

                # region Orzhov Charm
                case "Orzhov Charm":
                    mcn = new OrzhovCharm();
                    break;
                # endregion

                # region Orzhov Guildgate
                case "Orzhov Guildgate":
                    mcn = new OrzhovGuildgate();
                    break;
                # endregion

                # region Orzhov Keyrune
                case "Orzhov Keyrune":
                    mcn = new OrzhovKeyrune();
                    break;
                # endregion

                # region Paranoid Delusions
                case "Paranoid Delusions":
                    mcn = new ParanoidDelusions();
                    break;
                # endregion

                # region Pit Fight
                case "Pit Fight":
                    mcn = new PitFight();
                    break;
                # endregion

                # region Predator's Rapport
                case "Predator's Rapport":
                    mcn = new PredatorsRapport();
                    break;
                # endregion

                # region Primal Visitation
                case "Primal Visitation":
                    mcn = new PrimalVisitation();
                    break;
                # endregion

                # region Prime Speaker Zegana
                case "Prime Speaker Zegana":
                    mcn = new PrimeSpeakerZegana();
                    break;
                # endregion

                # region Prophetic Prism
                case "Prophetic Prism":
                    mcn = new PropheticPrism();
                    break;
                # endregion

                # region Psychic Strike
                case "Psychic Strike":
                    mcn = new PsychicStrike();
                    break;
                # endregion

                # region Purge the Profane
                case "Purge the Profane":
                    mcn = new PurgetheProfane();
                    break;
                # endregion

                # region Rapid Hybridization
                case "Rapid Hybridization":
                    mcn = new RapidHybridization();
                    break;
                # endregion

                # region Razortip Whip
                case "Razortip Whip":
                    mcn = new RazortipWhip();
                    break;
                # endregion

                # region Realmwright
                case "Realmwright":
                    mcn = new Realmwright();
                    break;
                # endregion

                # region Righteous Charge
                case "Righteous Charge":
                    mcn = new RighteousCharge();
                    break;
                # endregion

                # region Riot Gear
                case "Riot Gear":
                    mcn = new RiotGear();
                    break;
                # endregion

                # region Ripscale Predator
                case "Ripscale Predator":
                    mcn = new RipscalePredator();
                    break;
                # endregion

                # region Rubblebelt Raiders
                case "Rubblebelt Raiders":
                    mcn = new RubblebeltRaiders();
                    break;
                # endregion

                # region Rubblehulk
                case "Rubblehulk":
                    mcn = new Rubblehulk();
                    break;
                # endregion

                # region Ruination Wurm
                case "Ruination Wurm":
                    mcn = new RuinationWurm();
                    break;
                # endregion

                # region Rust Scarab
                case "Rust Scarab":
                    mcn = new RustScarab();
                    break;
                # endregion

                # region Sacred Foundry
                case "Sacred Foundry":
                    mcn = new SacredFoundry();
                    break;
                # endregion

                # region Sage's Row Denizen
                case "Sage's Row Denizen":
                    mcn = new SagesRowDenizen();
                    break;
                # endregion

                # region Sapphire Drake
                case "Sapphire Drake":
                    mcn = new SapphireDrake();
                    break;
                # endregion

                # region Scab-Clan Charger
                case "Scab-Clan Charger":
                    mcn = new ScabClanCharger();
                    break;
                # endregion

                # region Scatter Arc
                case "Scatter Arc":
                    mcn = new ScatterArc();
                    break;
                # endregion

                # region Scorchwalker
                case "Scorchwalker":
                    mcn = new Scorchwalker();
                    break;
                # endregion

                # region Sepulchral Primordial
                case "Sepulchral Primordial":
                    mcn = new SepulchralPrimordial();
                    break;
                # endregion

                # region Serene Remembrance
                case "Serene Remembrance":
                    mcn = new SereneRemembrance();
                    break;
                # endregion

                # region Shadow Alley Denizen
                case "Shadow Alley Denizen":
                    mcn = new ShadowAlleyDenizen();
                    break;
                # endregion

                # region Shadow Slice
                case "Shadow Slice":
                    mcn = new ShadowSlice();
                    break;
                # endregion

                # region Shambleshark
                case "Shambleshark":
                    mcn = new Shambleshark();
                    break;
                # endregion

                # region Shattering Blow
                case "Shattering Blow":
                    mcn = new ShatteringBlow();
                    break;
                # endregion

                # region Shielded Passage
                case "Shielded Passage":
                    mcn = new ShieldedPassage();
                    break;
                # endregion

                # region Signal the Clans
                case "Signal the Clans":
                    mcn = new SignaltheClans();
                    break;
                # endregion

                # region Simic Charm
                case "Simic Charm":
                    mcn = new SimicCharm();
                    break;
                # endregion

                # region Simic Fluxmage
                case "Simic Fluxmage":
                    mcn = new SimicFluxmage();
                    break;
                # endregion

                # region Simic Guildgate
                case "Simic Guildgate":
                    mcn = new SimicGuildgate();
                    break;
                # endregion

                # region Simic Keyrune
                case "Simic Keyrune":
                    mcn = new SimicKeyrune();
                    break;
                # endregion

                # region Simic Manipulator
                case "Simic Manipulator":
                    mcn = new SimicManipulator();
                    break;
                # endregion

                # region Skarrg Goliath
                case "Skarrg Goliath":
                    mcn = new SkarrgGoliath();
                    break;
                # endregion

                # region Skarrg Guildmage
                case "Skarrg Guildmage":
                    mcn = new SkarrgGuildmage();
                    break;
                # endregion

                # region Skinbrand Goblin
                case "Skinbrand Goblin":
                    mcn = new SkinbrandGoblin();
                    break;
                # endregion

                # region Skullcrack
                case "Skullcrack":
                    mcn = new Skullcrack();
                    break;
                # endregion

                # region Skyblinder Staff
                case "Skyblinder Staff":
                    mcn = new SkyblinderStaff();
                    break;
                # endregion

                # region Skygames
                case "Skygames":
                    mcn = new Skygames();
                    break;
                # endregion

                # region Skyknight Legionnaire
                case "Skyknight Legionnaire":
                    mcn = new SkyknightLegionnaire();
                    break;
                # endregion

                # region Slate Street Ruffian
                case "Slate Street Ruffian":
                    mcn = new SlateStreetRuffian();
                    break;
                # endregion

                # region Slaughterhorn
                case "Slaughterhorn":
                    mcn = new Slaughterhorn();
                    break;
                # endregion

                # region Smite
                case "Smite":
                    mcn = new Smite();
                    break;
                # endregion

                # region Smog Elemental
                case "Smog Elemental":
                    mcn = new SmogElemental();
                    break;
                # endregion

                # region Soul Ransom
                case "Soul Ransom":
                    mcn = new SoulRansom();
                    break;
                # endregion

                # region Spark Trooper
                case "Spark Trooper":
                    mcn = new SparkTrooper();
                    break;
                # endregion

                # region Spell Rupture
                case "Spell Rupture":
                    mcn = new SpellRupture();
                    break;
                # endregion

                # region Spire Tracer
                case "Spire Tracer":
                    mcn = new SpireTracer();
                    break;
                # endregion

                # region Stolen Identity
                case "Stolen Identity":
                    mcn = new StolenIdentity();
                    break;
                # endregion

                # region Stomping Ground
                case "Stomping Ground":
                    mcn = new StompingGround();
                    break;
                # endregion

                # region Structural Collapse
                case "Structural Collapse":
                    mcn = new StructuralCollapse();
                    break;
                # endregion

                # region Sunhome Guildmage
                case "Sunhome Guildmage":
                    mcn = new SunhomeGuildmage();
                    break;
                # endregion

                # region Sylvan Primordial
                case "Sylvan Primordial":
                    mcn = new SylvanPrimordial();
                    break;
                # endregion

                # region Syndic of Tithes
                case "Syndic of Tithes":
                    mcn = new SyndicofTithes();
                    break;
                # endregion

                # region Syndicate Enforcer
                case "Syndicate Enforcer":
                    mcn = new SyndicateEnforcer();
                    break;
                # endregion

                # region Thespian's Stage
                case "Thespian's Stage":
                    mcn = new ThespiansStage();
                    break;
                # endregion

                # region Thrull Parasite
                case "Thrull Parasite":
                    mcn = new ThrullParasite();
                    break;
                # endregion

                # region Tin Street Market
                case "Tin Street Market":
                    mcn = new TinStreetMarket();
                    break;
                # endregion

                # region Totally Lost
                case "Totally Lost":
                    mcn = new TotallyLost();
                    break;
                # endregion

                # region Tower Defense
                case "Tower Defense":
                    mcn = new TowerDefense();
                    break;
                # endregion

                # region Towering Thunderfist
                case "Towering Thunderfist":
                    mcn = new ToweringThunderfist();
                    break;
                # endregion

                # region Treasury Thrull
                case "Treasury Thrull":
                    mcn = new TreasuryThrull();
                    break;
                # endregion

                # region Truefire Paladin
                case "Truefire Paladin":
                    mcn = new TruefirePaladin();
                    break;
                # endregion

                # region Undercity Informer
                case "Undercity Informer":
                    mcn = new UndercityInformer();
                    break;
                # endregion

                # region Undercity Plague
                case "Undercity Plague":
                    mcn = new UndercityPlague();
                    break;
                # endregion

                # region Unexpected Results
                case "Unexpected Results":
                    mcn = new UnexpectedResults();
                    break;
                # endregion

                # region Urban Evolution
                case "Urban Evolution":
                    mcn = new UrbanEvolution();
                    break;
                # endregion

                # region Urbis Protector
                case "Urbis Protector":
                    mcn = new UrbisProtector();
                    break;
                # endregion

                # region Verdant Haven
                case "Verdant Haven":
                    mcn = new VerdantHaven();
                    break;
                # endregion

                # region Viashino Shanktail
                case "Viashino Shanktail":
                    mcn = new ViashinoShanktail();
                    break;
                # endregion

                # region Vizkopa Confessor
                case "Vizkopa Confessor":
                    mcn = new VizkopaConfessor();
                    break;
                # endregion

                # region Vizkopa Guildmage
                case "Vizkopa Guildmage":
                    mcn = new VizkopaGuildmage();
                    break;
                # endregion

                # region Voidwalk
                case "Voidwalk":
                    mcn = new Voidwalk();
                    break;
                # endregion

                # region Warmind Infantry
                case "Warmind Infantry":
                    mcn = new WarmindInfantry();
                    break;
                # endregion

                # region Wasteland Viper
                case "Wasteland Viper":
                    mcn = new WastelandViper();
                    break;
                # endregion

                # region Watery Grave
                case "Watery Grave":
                    mcn = new WateryGrave();
                    break;
                # endregion

                # region Way of the Thief
                case "Way of the Thief":
                    mcn = new WayoftheThief();
                    break;
                # endregion

                # region Whispering Madness
                case "Whispering Madness":
                    mcn = new WhisperingMadness();
                    break;
                # endregion

                # region Wight of Precinct Six
                case "Wight of Precinct Six":
                    mcn = new WightofPrecinctSix();
                    break;
                # endregion

                # region Wildwood Rebirth
                case "Wildwood Rebirth":
                    mcn = new WildwoodRebirth();
                    break;
                # endregion

                # region Wojek Halberdiers
                case "Wojek Halberdiers":
                    mcn = new WojekHalberdiers();
                    break;
                # endregion

                # region Wrecking Ogre
                case "Wrecking Ogre":
                    mcn = new WreckingOgre();
                    break;
                # endregion

                # region Zameck Guildmage
                case "Zameck Guildmage":
                    mcn = new ZameckGuildmage();
                    break;
                # endregion

                # region Zarichi Tiger
                case "Zarichi Tiger":
                    mcn = new ZarichiTiger();
                    break;
                # endregion

                # region Zhur-Taa Swine
                case "Zhur-Taa Swine":
                    mcn = new ZhurTaaSwine();
                    break;
                # endregion
                # endregion

                # region Dragon's Maze
                # region Advent of the Wurm
                case "Advent of the Wurm":
                    mcn = new AdventoftheWurm();
                    break;
                # endregion

                # region AEtherling
                case "AEtherling":
                    mcn = new AEtherling();
                    break;
                # endregion

                # region Alive/Well
                case "Alive/Well":
                    mcn = new AliveWell();
                    break;
                # endregion

                # region Armed/Dangerous
                case "Armed/Dangerous":
                    mcn = new ArmedDangerous();
                    break;
                # endregion

                # region Armored Wolf-Rider
                case "Armored Wolf-Rider":
                    mcn = new ArmoredWolfRider();
                    break;
                # endregion

                # region Ascended Lawmage
                case "Ascended Lawmage":
                    mcn = new AscendedLawmage();
                    break;
                # endregion

                # region Awe for the Guilds
                case "Awe for the Guilds":
                    mcn = new AwefortheGuilds();
                    break;
                # endregion

                # region Azorius Cluestone
                case "Azorius Cluestone":
                    mcn = new AzoriusCluestone();
                    break;
                # endregion

                //# region Azorius Guildgate
                //case "Azorius Guildgate":
                //    mcn = new AzoriusGuildgate();
                //    break;
                //# endregion

                # region Bane Alley Blackguard
                case "Bane Alley Blackguard":
                    mcn = new BaneAlleyBlackguard();
                    break;
                # endregion

                # region Battering Krasis
                case "Battering Krasis":
                    mcn = new BatteringKrasis();
                    break;
                # endregion

                # region Beck/Call
                case "Beck/Call":
                    mcn = new BeckCall();
                    break;
                # endregion

                # region Beetleform Mage
                case "Beetleform Mage":
                    mcn = new BeetleformMage();
                    break;
                # endregion

                # region Blast of Genius
                case "Blast of Genius":
                    mcn = new BlastofGenius();
                    break;
                # endregion

                # region Blaze Commando
                case "Blaze Commando":
                    mcn = new BlazeCommando();
                    break;
                # endregion

                # region Blood Baron of Vizkopa
                case "Blood Baron of Vizkopa":
                    mcn = new BloodBaronofVizkopa();
                    break;
                # endregion

                # region Blood Scrivener
                case "Blood Scrivener":
                    mcn = new BloodScrivener();
                    break;
                # endregion

                # region Boros Battleshaper
                case "Boros Battleshaper":
                    mcn = new BorosBattleshaper();
                    break;
                # endregion

                # region Boros Cluestone
                case "Boros Cluestone":
                    mcn = new BorosCluestone();
                    break;
                # endregion

                //# region Boros Guildgate
                //case "Boros Guildgate":
                //    mcn = new BorosGuildgate();
                //    break;
                //# endregion

                # region Boros Mastiff
                case "Boros Mastiff":
                    mcn = new BorosMastiff();
                    break;
                # endregion

                # region Breaking/Entering
                case "Breaking/Entering":
                    mcn = new BreakingEntering();
                    break;
                # endregion

                # region Bred for the Hunt
                case "Bred for the Hunt":
                    mcn = new BredfortheHunt();
                    break;
                # endregion

                # region Bronzebeak Moa
                case "Bronzebeak Moa":
                    mcn = new BronzebeakMoa();
                    break;
                # endregion

                # region Carnage Gladiator
                case "Carnage Gladiator":
                    mcn = new CarnageGladiator();
                    break;
                # endregion

                # region Catch/Release
                case "Catch/Release":
                    mcn = new CatchRelease();
                    break;
                # endregion

                # region Clear a Path
                case "Clear a Path":
                    mcn = new ClearaPath();
                    break;
                # endregion

                # region Council of the Absolute
                case "Council of the Absolute":
                    mcn = new CounciloftheAbsolute();
                    break;
                # endregion

                # region Crypt Incursion
                case "Crypt Incursion":
                    mcn = new CryptIncursion();
                    break;
                # endregion

                # region Deadbridge Chant
                case "Deadbridge Chant":
                    mcn = new DeadbridgeChant();
                    break;
                # endregion

                # region Debt to the Deathless
                case "Debt to the Deathless":
                    mcn = new DebttotheDeathless();
                    break;
                # endregion

                # region Deputy of Acquittals
                case "Deputy of Acquittals":
                    mcn = new DeputyofAcquittals();
                    break;
                # endregion

                # region Dimir Cluestone
                case "Dimir Cluestone":
                    mcn = new DimirCluestone();
                    break;
                # endregion

                //# region Dimir Guildgate
                //case "Dimir Guildgate":
                //    mcn = new DimirGuildgate();
                //    break;
                //# endregion

                # region Down/Dirty
                case "Down/Dirty":
                    mcn = new DownDirty();
                    break;
                # endregion

                # region Dragonshift
                case "Dragonshift":
                    mcn = new Dragonshift();
                    break;
                # endregion

                # region Drown in Filth
                case "Drown in Filth":
                    mcn = new DrowninFilth();
                    break;
                # endregion

                # region Emmara Tandris
                case "Emmara Tandris":
                    mcn = new EmmaraTandris();
                    break;
                # endregion

                # region Exava, Rakdos Blood Witch
                case "Exava, Rakdos Blood Witch":
                    mcn = new ExavaRakdosBloodWitch();
                    break;
                # endregion

                # region Far/Away
                case "Far/Away":
                    mcn = new FarAway();
                    break;
                # endregion

                # region Fatal Fumes
                case "Fatal Fumes":
                    mcn = new FatalFumes();
                    break;
                # endregion

                # region Feral Animist
                case "Feral Animist":
                    mcn = new FeralAnimist();
                    break;
                # endregion

                # region Flesh/Blood
                case "Flesh/Blood":
                    mcn = new FleshBlood();
                    break;
                # endregion

                # region Fluxcharger
                case "Fluxcharger":
                    mcn = new Fluxcharger();
                    break;
                # endregion

                # region Gaze of Granite
                case "Gaze of Granite":
                    mcn = new GazeofGranite();
                    break;
                # endregion

                # region Give/Take
                case "Give/Take":
                    mcn = new GiveTake();
                    break;
                # endregion

                # region Gleam of Battle
                case "Gleam of Battle":
                    mcn = new GleamofBattle();
                    break;
                # endregion

                # region Goblin Test Pilot
                case "Goblin Test Pilot":
                    mcn = new GoblinTestPilot();
                    break;
                # endregion

                # region Golgari Cluestone
                case "Golgari Cluestone":
                    mcn = new GolgariCluestone();
                    break;
                # endregion

                //# region Golgari Guildgate
                //case "Golgari Guildgate":
                //    mcn = new GolgariGuildgate();
                //    break;
                //# endregion

                # region Gruul Cluestone
                case "Gruul Cluestone":
                    mcn = new GruulCluestone();
                    break;
                # endregion

                //# region Gruul Guildgate
                //case "Gruul Guildgate":
                //    mcn = new GruulGuildgate();
                //    break;
                //# endregion

                # region Gruul War Chant
                case "Gruul War Chant":
                    mcn = new GruulWarChant();
                    break;
                # endregion

                # region Haazda Snare Squad
                case "Haazda Snare Squad":
                    mcn = new HaazdaSnareSquad();
                    break;
                # endregion

                # region Haunter of Nightveil
                case "Haunter of Nightveil":
                    mcn = new HaunterofNightveil();
                    break;
                # endregion

                # region Hidden Strings
                case "Hidden Strings":
                    mcn = new HiddenStrings();
                    break;
                # endregion

                # region Hired Torturer
                case "Hired Torturer":
                    mcn = new HiredTorturer();
                    break;
                # endregion

                # region Izzet Cluestone
                case "Izzet Cluestone":
                    mcn = new IzzetCluestone();
                    break;
                # endregion

                //# region Izzet Guildgate
                //case "Izzet Guildgate":
                //    mcn = new IzzetGuildgate();
                //    break;
                //# endregion

                # region Jelenn Sphinx
                case "Jelenn Sphinx":
                    mcn = new JelennSphinx();
                    break;
                # endregion

                # region Korozda Gorgon
                case "Korozda Gorgon":
                    mcn = new KorozdaGorgon();
                    break;
                # endregion

                # region Krasis Incubation
                case "Krasis Incubation":
                    mcn = new KrasisIncubation();
                    break;
                # endregion

                # region Kraul Warrior
                case "Kraul Warrior":
                    mcn = new KraulWarrior();
                    break;
                # endregion

                # region Lavinia of the Tenth
                case "Lavinia of the Tenth":
                    mcn = new LaviniaoftheTenth();
                    break;
                # endregion

                # region Legion's Initiative
                case "Legion's Initiative":
                    mcn = new LegionsInitiative();
                    break;
                # endregion

                # region Lyev Decree
                case "Lyev Decree":
                    mcn = new LyevDecree();
                    break;
                # endregion

                # region Master of Cruelties
                case "Master of Cruelties":
                    mcn = new MasterofCruelties();
                    break;
                # endregion

                # region Maw of the Obzedat
                case "Maw of the Obzedat":
                    mcn = new MawoftheObzedat();
                    break;
                # endregion

                # region Maze Abomination
                case "Maze Abomination":
                    mcn = new MazeAbomination();
                    break;
                # endregion

                # region Maze Behemoth
                case "Maze Behemoth":
                    mcn = new MazeBehemoth();
                    break;
                # endregion

                # region Maze Glider
                case "Maze Glider":
                    mcn = new MazeGlider();
                    break;
                # endregion

                # region Maze Rusher
                case "Maze Rusher":
                    mcn = new MazeRusher();
                    break;
                # endregion

                # region Maze Sentinel
                case "Maze Sentinel":
                    mcn = new MazeSentinel();
                    break;
                # endregion

                # region Maze's End
                case "Maze's End":
                    mcn = new MazesEnd();
                    break;
                # endregion

                # region Melek, Izzet Paragon
                case "Melek, Izzet Paragon":
                    mcn = new MelekIzzetParagon();
                    break;
                # endregion

                # region Mending Touch
                case "Mending Touch":
                    mcn = new MendingTouch();
                    break;
                # endregion

                # region Mindstatic
                case "Mindstatic":
                    mcn = new Mindstatic();
                    break;
                # endregion

                # region Mirko Vosk, Mind Drinker
                case "Mirko Vosk, Mind Drinker":
                    mcn = new MirkoVoskMindDrinker();
                    break;
                # endregion

                # region Morgue Burst
                case "Morgue Burst":
                    mcn = new MorgueBurst();
                    break;
                # endregion

                # region Murmuring Phantasm
                case "Murmuring Phantasm":
                    mcn = new MurmuringPhantasm();
                    break;
                # endregion

                # region Mutant's Prey
                case "Mutant's Prey":
                    mcn = new MutantsPrey();
                    break;
                # endregion

                # region Nivix Cyclops
                case "Nivix Cyclops":
                    mcn = new NivixCyclops();
                    break;
                # endregion

                # region Notion Thief
                case "Notion Thief":
                    mcn = new NotionThief();
                    break;
                # endregion

                # region Obzedat's Aid
                case "Obzedat's Aid":
                    mcn = new ObzedatsAid();
                    break;
                # endregion

                # region Opal Lake Gatekeepers
                case "Opal Lake Gatekeepers":
                    mcn = new OpalLakeGatekeepers();
                    break;
                # endregion

                # region Orzhov Cluestone
                case "Orzhov Cluestone":
                    mcn = new OrzhovCluestone();
                    break;
                # endregion

                //# region Orzhov Guildgate
                //case "Orzhov Guildgate":
                //    mcn = new OrzhovGuildgate();
                //    break;
                //# endregion

                # region Phytoburst
                case "Phytoburst":
                    mcn = new Phytoburst();
                    break;
                # endregion

                # region Pilfered Plans
                case "Pilfered Plans":
                    mcn = new PilferedPlans();
                    break;
                # endregion

                # region Plasm Capture
                case "Plasm Capture":
                    mcn = new PlasmCapture();
                    break;
                # endregion

                # region Pontiff of Blight
                case "Pontiff of Blight":
                    mcn = new PontiffofBlight();
                    break;
                # endregion

                # region Possibility Storm
                case "Possibility Storm":
                    mcn = new PossibilityStorm();
                    break;
                # endregion

                # region Profit/Loss
                case "Profit/Loss":
                    mcn = new ProfitLoss();
                    break;
                # endregion

                # region Progenitor Mimic
                case "Progenitor Mimic":
                    mcn = new ProgenitorMimic();
                    break;
                # endregion

                # region Protect/Serve
                case "Protect/Serve":
                    mcn = new ProtectServe();
                    break;
                # endregion

                # region Punish the Enemy
                case "Punish the Enemy":
                    mcn = new PunishtheEnemy();
                    break;
                # endregion

                # region Putrefy
                case "Putrefy":
                    mcn = new Putrefy();
                    break;
                # endregion

                # region Pyrewild Shaman
                case "Pyrewild Shaman":
                    mcn = new PyrewildShaman();
                    break;
                # endregion

                # region Rakdos Cluestone
                case "Rakdos Cluestone":
                    mcn = new RakdosCluestone();
                    break;
                # endregion

                # region Rakdos Drake
                case "Rakdos Drake":
                    mcn = new RakdosDrake();
                    break;
                # endregion

                //# region Rakdos Guildgate
                //case "Rakdos Guildgate":
                //    mcn = new RakdosGuildgate();
                //    break;
                //# endregion

                # region Ral Zarek
                case "Ral Zarek":
                    mcn = new RalZarek();
                    break;
                # endregion

                # region Ready/Willing
                case "Ready/Willing":
                    mcn = new ReadyWilling();
                    break;
                # endregion

                # region Reap Intellect
                case "Reap Intellect":
                    mcn = new ReapIntellect();
                    break;
                # endregion

                # region Render Silent
                case "Render Silent":
                    mcn = new RenderSilent();
                    break;
                # endregion

                # region Renegade Krasis
                case "Renegade Krasis":
                    mcn = new RenegadeKrasis();
                    break;
                # endregion

                # region Renounce the Guilds
                case "Renounce the Guilds":
                    mcn = new RenouncetheGuilds();
                    break;
                # endregion

                # region Restore the Peace
                case "Restore the Peace":
                    mcn = new RestorethePeace();
                    break;
                # endregion

                # region Riot Control
                case "Riot Control":
                    mcn = new RiotControl();
                    break;
                # endregion

                # region Riot Piker
                case "Riot Piker":
                    mcn = new RiotPiker();
                    break;
                # endregion

                # region Rot Farm Skeleton
                case "Rot Farm Skeleton":
                    mcn = new RotFarmSkeleton();
                    break;
                # endregion

                # region Rubblebelt Maaka
                case "Rubblebelt Maaka":
                    mcn = new RubblebeltMaaka();
                    break;
                # endregion

                # region Runner's Bane
                case "Runner's Bane":
                    mcn = new RunnersBane();
                    break;
                # endregion

                # region Ruric Thar, the Unbowed
                case "Ruric Thar, the Unbowed":
                    mcn = new RuricThartheUnbowed();
                    break;
                # endregion

                # region Saruli Gatekeepers
                case "Saruli Gatekeepers":
                    mcn = new SaruliGatekeepers();
                    break;
                # endregion

                # region Savageborn Hydra
                case "Savageborn Hydra":
                    mcn = new SavagebornHydra();
                    break;
                # endregion

                # region Scab-Clan Giant
                case "Scab-Clan Giant":
                    mcn = new ScabClanGiant();
                    break;
                # endregion

                # region Scion of Vitu-Ghazi
                case "Scion of Vitu-Ghazi":
                    mcn = new ScionofVituGhazi();
                    break;
                # endregion

                # region Selesnya Cluestone
                case "Selesnya Cluestone":
                    mcn = new SelesnyaCluestone();
                    break;
                # endregion

                //# region Selesnya Guildgate
                //case "Selesnya Guildgate":
                //    mcn = new SelesnyaGuildgate();
                //    break;
                //# endregion

                # region Showstopper
                case "Showstopper":
                    mcn = new Showstopper();
                    break;
                # endregion

                # region Simic Cluestone
                case "Simic Cluestone":
                    mcn = new SimicCluestone();
                    break;
                # endregion

                //# region Simic Guildgate
                //case "Simic Guildgate":
                //    mcn = new SimicGuildgate();
                //    break;
                //# endregion

                # region Sin Collector
                case "Sin Collector":
                    mcn = new SinCollector();
                    break;
                # endregion

                # region Sinister Possession
                case "Sinister Possession":
                    mcn = new SinisterPossession();
                    break;
                # endregion

                # region Sire of Insanity
                case "Sire of Insanity":
                    mcn = new SireofInsanity();
                    break;
                # endregion

                # region Skylasher
                case "Skylasher":
                    mcn = new Skylasher();
                    break;
                # endregion

                # region Smelt-Ward Gatekeepers
                case "Smelt-Ward Gatekeepers":
                    mcn = new SmeltWardGatekeepers();
                    break;
                # endregion

                # region Species Gorger
                case "Species Gorger":
                    mcn = new SpeciesGorger();
                    break;
                # endregion

                # region Spike Jester
                case "Spike Jester":
                    mcn = new SpikeJester();
                    break;
                # endregion

                # region Steeple Roc
                case "Steeple Roc":
                    mcn = new SteepleRoc();
                    break;
                # endregion

                # region Sunspire Gatekeepers
                case "Sunspire Gatekeepers":
                    mcn = new SunspireGatekeepers();
                    break;
                # endregion

                # region Tajic, Blade of the Legion
                case "Tajic, Blade of the Legion":
                    mcn = new TajicBladeoftheLegion();
                    break;
                # endregion

                # region Teysa, Envoy of Ghosts
                case "Teysa, Envoy of Ghosts":
                    mcn = new TeysaEnvoyofGhosts();
                    break;
                # endregion

                # region Thrashing Mossdog
                case "Thrashing Mossdog":
                    mcn = new ThrashingMossdog();
                    break;
                # endregion

                # region Tithe Drinker
                case "Tithe Drinker":
                    mcn = new TitheDrinker();
                    break;
                # endregion

                # region Toil/Trouble
                case "Toil/Trouble":
                    mcn = new ToilTrouble();
                    break;
                # endregion

                # region Trait Doctoring
                case "Trait Doctoring":
                    mcn = new TraitDoctoring();
                    break;
                # endregion

                # region Trostani's Summoner
                case "Trostani's Summoner":
                    mcn = new TrostanisSummoner();
                    break;
                # endregion

                # region Turn/Burn
                case "Turn/Burn":
                    mcn = new TurnBurn();
                    break;
                # endregion

                # region Ubul Sar Gatekeepers
                case "Ubul Sar Gatekeepers":
                    mcn = new UbulSarGatekeepers();
                    break;
                # endregion

                # region Uncovered Clues
                case "Uncovered Clues":
                    mcn = new UncoveredClues();
                    break;
                # endregion

                # region Unflinching Courage
                case "Unflinching Courage":
                    mcn = new UnflinchingCourage();
                    break;
                # endregion

                # region Varolz, the Scar-Striped
                case "Varolz, the Scar-Striped":
                    mcn = new VarolztheScarStriped();
                    break;
                # endregion

                # region Viashino Firstblade
                case "Viashino Firstblade":
                    mcn = new ViashinoFirstblade();
                    break;
                # endregion

                # region Voice of Resurgence
                case "Voice of Resurgence":
                    mcn = new VoiceofResurgence();
                    break;
                # endregion

                # region Vorel of the Hull Clade
                case "Vorel of the Hull Clade":
                    mcn = new VoreloftheHullClade();
                    break;
                # endregion

                # region Wake the Reflections
                case "Wake the Reflections":
                    mcn = new WaketheReflections();
                    break;
                # endregion

                # region Warleader's Helix
                case "Warleader's Helix":
                    mcn = new WarleadersHelix();
                    break;
                # endregion

                # region Warped Physique
                case "Warped Physique":
                    mcn = new WarpedPhysique();
                    break;
                # endregion

                # region Weapon Surge
                case "Weapon Surge":
                    mcn = new WeaponSurge();
                    break;
                # endregion

                # region Wear/Tear
                case "Wear/Tear":
                    mcn = new WearTear();
                    break;
                # endregion

                # region Wind Drake
                case "Wind Drake":
                    mcn = new WindDrake();
                    break;
                # endregion

                # region Woodlot Crawler
                case "Woodlot Crawler":
                    mcn = new WoodlotCrawler();
                    break;
                # endregion

                # region Zhur-Taa Ancient
                case "Zhur-Taa Ancient":
                    mcn = new ZhurTaaAncient();
                    break;
                # endregion

                # region Zhur-Taa Druid
                case "Zhur-Taa Druid":
                    mcn = new ZhurTaaDruid();
                    break;
                # endregion
                # endregion

                # region Magic 2014
                # region Academy Raider
                case "Academy Raider":
                    mcn = new AcademyRaider();
                    break;
                # endregion

                # region Accorder's Shield
                case "Accorder's Shield":
                    mcn = new AccordersShield();
                    break;
                # endregion

                # region Accursed Spirit
                case "Accursed Spirit":
                    mcn = new AccursedSpirit();
                    break;
                # endregion

                //# region Act of Treason
                //case "Act of Treason":
                //    mcn = new ActofTreasonM14();
                //    break;
                //# endregion

                # region Advocate of the Beast
                case "Advocate of the Beast":
                    mcn = new AdvocateoftheBeast();
                    break;
                # endregion

                # region Air Servant
                case "Air Servant":
                    mcn = new AirServant();
                    break;
                # endregion

                # region Ajani, Caller of the Pride
                case "Ajani, Caller of the Pride":
                    mcn = new AjaniCallerofthePride();
                    break;
                # endregion

                # region Ajani's Chosen
                case "Ajani's Chosen":
                    mcn = new AjanisChosen();
                    break;
                # endregion

                # region Altar's Reap
                case "Altar's Reap":
                    mcn = new AltarsReap();
                    break;
                # endregion

                # region Angelic Accord
                case "Angelic Accord":
                    mcn = new AngelicAccord();
                    break;
                # endregion

                //# region Angelic Wall
                //case "Angelic Wall":
                //    mcn = new AngelicWall();
                //    break;
                //# endregion

                # region Archaeomancer
                case "Archaeomancer":
                    mcn = new Archaeomancer();
                    break;
                # endregion

                # region Archangel of Thune
                case "Archangel of Thune":
                    mcn = new ArchangelofThune();
                    break;
                # endregion

                # region Armored Cancrix
                case "Armored Cancrix":
                    mcn = new ArmoredCancrix();
                    break;
                # endregion

                # region Artificer's Hex
                case "Artificer's Hex":
                    mcn = new ArtificersHex();
                    break;
                # endregion

                # region Auramancer
                case "Auramancer":
                    mcn = new Auramancer();
                    break;
                # endregion

                # region Awaken the Ancient
                case "Awaken the Ancient":
                    mcn = new AwakentheAncient();
                    break;
                # endregion

                # region Banisher Priest
                case "Banisher Priest":
                    mcn = new BanisherPriest();
                    break;
                # endregion

                # region Barrage of Expendables
                case "Barrage of Expendables":
                    mcn = new BarrageofExpendables();
                    break;
                # endregion

                # region Battle Sliver
                case "Battle Sliver":
                    mcn = new BattleSliver();
                    break;
                # endregion

                # region Blessing
                case "Blessing":
                    mcn = new BlessingM14();
                    break;
                # endregion

                # region Blightcaster
                case "Blightcaster":
                    mcn = new Blightcaster();
                    break;
                # endregion

                # region Blood Bairn
                case "Blood Bairn":
                    mcn = new BloodBairn();
                    break;
                # endregion

                # region Blur Sliver
                case "Blur Sliver":
                    mcn = new BlurSliver();
                    break;
                # endregion

                # region Bogbrew Witch
                case "Bogbrew Witch":
                    mcn = new BogbrewWitch();
                    break;
                # endregion

                # region Bonescythe Sliver
                case "Bonescythe Sliver":
                    mcn = new BonescytheSliver();
                    break;
                # endregion

                # region Bramblecrush
                case "Bramblecrush":
                    mcn = new Bramblecrush();
                    break;
                # endregion

                # region Brave the Elements
                case "Brave the Elements":
                    mcn = new BravetheElements();
                    break;
                # endregion

                # region Briarpack Alpha
                case "Briarpack Alpha":
                    mcn = new BriarpackAlpha();
                    break;
                # endregion

                # region Brindle Boar
                case "Brindle Boar":
                    mcn = new BrindleBoar();
                    break;
                # endregion

                # region Bubbling Cauldron
                case "Bubbling Cauldron":
                    mcn = new BubblingCauldron();
                    break;
                # endregion

                # region Burning Earth
                case "Burning Earth":
                    mcn = new BurningEarth();
                    break;
                # endregion

                //# region Cancel
                //case "Cancel":
                //    mcn = new CancelM14();
                //    break;
                //# endregion

                # region Canyon Minotaur
                case "Canyon Minotaur":
                    mcn = new CanyonMinotaur();
                    break;
                # endregion

                # region Capashen Knight
                case "Capashen Knight":
                    mcn = new CapashenKnight();
                    break;
                # endregion

                # region Celestial Flare
                case "Celestial Flare":
                    mcn = new CelestialFlare();
                    break;
                # endregion

                # region Chandra, Pyromaster
                case "Chandra, Pyromaster":
                    mcn = new ChandraPyromaster();
                    break;
                # endregion

                # region Chandra's Outrage
                case "Chandra's Outrage":
                    mcn = new ChandrasOutrage();
                    break;
                # endregion

                # region Chandra's Phoenix
                case "Chandra's Phoenix":
                    mcn = new ChandrasPhoenix();
                    break;
                # endregion

                # region Charging Griffin
                case "Charging Griffin":
                    mcn = new ChargingGriffin();
                    break;
                # endregion

                # region Child of Night
                case "Child of Night":
                    mcn = new ChildofNight();
                    break;
                # endregion

                # region Claustrophobia
                case "Claustrophobia":
                    mcn = new Claustrophobia();
                    break;
                # endregion

                # region Clone
                case "Clone":
                    mcn = new CloneM14();
                    break;
                # endregion

                # region Colossal Whale
                case "Colossal Whale":
                    mcn = new ColossalWhale();
                    break;
                # endregion

                # region Congregate
                case "Congregate":
                    mcn = new Congregate();
                    break;
                # endregion

                # region Coral Merfolk
                case "Coral Merfolk":
                    mcn = new CoralMerfolk();
                    break;
                # endregion

                # region Corpse Hauler
                case "Corpse Hauler":
                    mcn = new CorpseHauler();
                    break;
                # endregion

                # region Corrupt
                case "Corrupt":
                    mcn = new Corrupt();
                    break;
                # endregion

                # region Cyclops Tyrant
                case "Cyclops Tyrant":
                    mcn = new CyclopsTyrant();
                    break;
                # endregion

                # region Dark Favor
                case "Dark Favor":
                    mcn = new DarkFavor();
                    break;
                # endregion

                # region Dark Prophecy
                case "Dark Prophecy":
                    mcn = new DarkProphecy();
                    break;
                # endregion

                # region Darksteel Forge
                case "Darksteel Forge":
                    mcn = new DarksteelForge();
                    break;
                # endregion

                # region Darksteel Ingot
                case "Darksteel Ingot":
                    mcn = new DarksteelIngot();
                    break;
                # endregion

                # region Dawnstrike Paladin
                case "Dawnstrike Paladin":
                    mcn = new DawnstrikePaladin();
                    break;
                # endregion

                # region Deadly Recluse
                case "Deadly Recluse":
                    mcn = new DeadlyRecluse();
                    break;
                # endregion

                # region Deathgaze Cockatrice
                case "Deathgaze Cockatrice":
                    mcn = new DeathgazeCockatrice();
                    break;
                # endregion

                //# region Demolish
                //case "Demolish":
                //    mcn = new DemolishM14();
                //    break;
                //# endregion

                # region Devout Invocation
                case "Devout Invocation":
                    mcn = new DevoutInvocation();
                    break;
                # endregion

                # region Diabolic Tutor
                case "Diabolic Tutor":
                    mcn = new DiabolicTutor();
                    break;
                # endregion

                # region Dismiss into Dream
                case "Dismiss into Dream":
                    mcn = new DismissintoDream();
                    break;
                # endregion

                # region Disperse
                case "Disperse":
                    mcn = new Disperse();
                    break;
                # endregion

                //# region Divination
                //case "Divination":
                //    mcn = new DivinationM14();
                //    break;
                //# endregion

                # region Divine Favor
                case "Divine Favor":
                    mcn = new DivineFavor();
                    break;
                # endregion

                # region Domestication
                case "Domestication":
                    mcn = new Domestication();
                    break;
                # endregion

                # region Doom Blade
                case "Doom Blade":
                    mcn = new DoomBlade();
                    break;
                # endregion

                # region Door of Destinies
                case "Door of Destinies":
                    mcn = new DoorofDestinies();
                    break;
                # endregion

                # region Dragon Egg
                case "Dragon Egg":
                    mcn = new DragonEgg();
                    break;
                # endregion

                # region Dragon Hatchling
                case "Dragon Hatchling":
                    mcn = new DragonHatchling();
                    break;
                # endregion

                # region Duress
                case "Duress":
                    mcn = new Duress();
                    break;
                # endregion

                # region Elite Arcanist
                case "Elite Arcanist":
                    mcn = new EliteArcanist();
                    break;
                # endregion

                # region Elixir of Immortality
                case "Elixir of Immortality":
                    mcn = new ElixirofImmortality();
                    break;
                # endregion

                # region Elvish Mystic
                case "Elvish Mystic":
                    mcn = new ElvishMystic();
                    break;
                # endregion

                # region Encroaching Wastes
                case "Encroaching Wastes":
                    mcn = new EncroachingWastes();
                    break;
                # endregion

                # region Enlarge
                case "Enlarge":
                    mcn = new Enlarge();
                    break;
                # endregion

                # region Essence Scatter
                case "Essence Scatter":
                    mcn = new EssenceScatter();
                    break;
                # endregion

                # region Festering Newt
                case "Festering Newt":
                    mcn = new FesteringNewt();
                    break;
                # endregion

                # region Fiendslayer Paladin
                case "Fiendslayer Paladin":
                    mcn = new FiendslayerPaladin();
                    break;
                # endregion

                # region Fireshrieker
                case "Fireshrieker":
                    mcn = new Fireshrieker();
                    break;
                # endregion

                # region Flames of the Firebrand
                case "Flames of the Firebrand":
                    mcn = new FlamesoftheFirebrand();
                    break;
                # endregion

                # region Fleshpulper Giant
                case "Fleshpulper Giant":
                    mcn = new FleshpulperGiant();
                    break;
                # endregion

                # region Fog
                case "Fog":
                    mcn = new FogM14();
                    break;
                # endregion

                //# region Forest
                //case "Forest":
                //    mcn = new ForestRTR();
                //    break;
                //# endregion

                # region Fortify
                case "Fortify":
                    mcn = new Fortify();
                    break;
                # endregion

                # region Frost Breath
                case "Frost Breath":
                    mcn = new FrostBreath();
                    break;
                # endregion

                # region Galerider Sliver
                case "Galerider Sliver":
                    mcn = new GaleriderSliver();
                    break;
                # endregion

                # region Garruk, Caller of Beasts
                case "Garruk, Caller of Beasts":
                    mcn = new GarrukCallerofBeasts();
                    break;
                # endregion

                # region Garruk's Horde
                case "Garruk's Horde":
                    mcn = new GarruksHorde();
                    break;
                # endregion

                //# region Giant Growth
                //case "Giant Growth":
                //    mcn = new GiantGrowthRTR();
                //    break;
                //# endregion

                # region Giant Spider
                case "Giant Spider":
                    mcn = new GiantSpiderM14();
                    break;
                # endregion

                # region Gladecover Scout
                case "Gladecover Scout":
                    mcn = new GladecoverScout();
                    break;
                # endregion

                # region Glimpse the Future
                case "Glimpse the Future":
                    mcn = new GlimpsetheFuture();
                    break;
                # endregion

                # region Gnawing Zombie
                case "Gnawing Zombie":
                    mcn = new GnawingZombie();
                    break;
                # endregion

                # region Goblin Diplomats
                case "Goblin Diplomats":
                    mcn = new GoblinDiplomats();
                    break;
                # endregion

                # region Goblin Shortcutter
                case "Goblin Shortcutter":
                    mcn = new GoblinShortcutter();
                    break;
                # endregion

                # region Griffin Sentinel
                case "Griffin Sentinel":
                    mcn = new GriffinSentinel();
                    break;
                # endregion

                # region Grim Return
                case "Grim Return":
                    mcn = new GrimReturn();
                    break;
                # endregion

                # region Groundshaker Sliver
                case "Groundshaker Sliver":
                    mcn = new GroundshakerSliver();
                    break;
                # endregion

                # region Guardian of the Ages
                case "Guardian of the Ages":
                    mcn = new GuardianoftheAges();
                    break;
                # endregion

                # region Haunted Plate Mail
                case "Haunted Plate Mail":
                    mcn = new HauntedPlateMail();
                    break;
                # endregion

                # region Hive Stirrings
                case "Hive Stirrings":
                    mcn = new HiveStirrings();
                    break;
                # endregion

                # region Howl of the Night Pack
                case "Howl of the Night Pack":
                    mcn = new HowloftheNightPack();
                    break;
                # endregion

                # region Hunt the Weak
                case "Hunt the Weak":
                    mcn = new HunttheWeak();
                    break;
                # endregion

                # region Illusionary Armor
                case "Illusionary Armor":
                    mcn = new IllusionaryArmor();
                    break;
                # endregion

                # region Imposing Sovereign
                case "Imposing Sovereign":
                    mcn = new ImposingSovereign();
                    break;
                # endregion

                # region Indestructibility
                case "Indestructibility":
                    mcn = new Indestructibility();
                    break;
                # endregion

                # region Into the Wilds
                case "Into the Wilds":
                    mcn = new IntotheWilds();
                    break;
                # endregion

                //# region Island
                //case "Island":
                //    mcn = new IslandRTR();
                //    break;
                //# endregion

                # region Jace, Memory Adept
                case "Jace, Memory Adept":
                    mcn = new JaceMemoryAdept();
                    break;
                # endregion

                # region Jace's Mindseeker
                case "Jace's Mindseeker":
                    mcn = new JacesMindseeker();
                    break;
                # endregion

                # region Kalonian Hydra
                case "Kalonian Hydra":
                    mcn = new KalonianHydra();
                    break;
                # endregion

                # region Kalonian Tusker
                case "Kalonian Tusker":
                    mcn = new KalonianTusker();
                    break;
                # endregion

                # region Lava Axe
                case "Lava Axe":
                    mcn = new LavaAxe();
                    break;
                # endregion

                # region Lay of the Land
                case "Lay of the Land":
                    mcn = new LayoftheLand();
                    break;
                # endregion

                # region Lifebane Zombie
                case "Lifebane Zombie":
                    mcn = new LifebaneZombie();
                    break;
                # endregion

                # region Lightning Talons
                case "Lightning Talons":
                    mcn = new LightningTalons();
                    break;
                # endregion

                # region Liliana of the Dark Realms
                case "Liliana of the Dark Realms":
                    mcn = new LilianaoftheDarkRealms();
                    break;
                # endregion

                # region Liliana's Reaver
                case "Liliana's Reaver":
                    mcn = new LilianasReaver();
                    break;
                # endregion

                # region Liturgy of Blood
                case "Liturgy of Blood":
                    mcn = new LiturgyofBlood();
                    break;
                # endregion

                # region Manaweft Sliver
                case "Manaweft Sliver":
                    mcn = new ManaweftSliver();
                    break;
                # endregion

                # region Marauding Maulhorn
                case "Marauding Maulhorn":
                    mcn = new MaraudingMaulhorn();
                    break;
                # endregion

                # region Mark of the Vampire
                case "Mark of the Vampire":
                    mcn = new MarkoftheVampire();
                    break;
                # endregion

                # region Master of Diversion
                case "Master of Diversion":
                    mcn = new MasterofDiversion();
                    break;
                # endregion

                # region Megantic Sliver
                case "Megantic Sliver":
                    mcn = new MeganticSliver();
                    break;
                # endregion

                # region Merfolk Spy
                case "Merfolk Spy":
                    mcn = new MerfolkSpy();
                    break;
                # endregion

                # region Messenger Drake
                case "Messenger Drake":
                    mcn = new MessengerDrake();
                    break;
                # endregion

                # region Millstone
                case "Millstone":
                    mcn = new Millstone();
                    break;
                # endregion

                //# region Mind Rot
                //case "Mind Rot":
                //    mcn = new MindRotM14();
                //    break;
                //# endregion

                # region Mindsparker
                case "Mindsparker":
                    mcn = new Mindsparker();
                    break;
                # endregion

                # region Minotaur Abomination
                case "Minotaur Abomination":
                    mcn = new MinotaurAbomination();
                    break;
                # endregion

                # region Molten Birth
                case "Molten Birth":
                    mcn = new MoltenBirth();
                    break;
                # endregion

                //# region Mountain
                //case "Mountain":
                //    mcn = new MountainRTR();
                //    break;
                //# endregion

                # region Mutavault
                case "Mutavault":
                    mcn = new Mutavault();
                    break;
                # endregion

                //# region Naturalize
                //case "Naturalize":
                //    mcn = new NaturalizeM14();
                //    break;
                //# endregion

                # region Negate
                case "Negate":
                    mcn = new Negate();
                    break;
                # endregion

                # region Nephalia Seakite
                case "Nephalia Seakite":
                    mcn = new NephaliaSeakite();
                    break;
                # endregion

                # region Nightmare
                case "Nightmare":
                    mcn = new NightmareM14();
                    break;
                # endregion

                # region Nightwing Shade
                case "Nightwing Shade":
                    mcn = new NightwingShade();
                    break;
                # endregion

                # region Oath of the Ancient Wood
                case "Oath of the Ancient Wood":
                    mcn = new OathoftheAncientWood();
                    break;
                # endregion

                # region Ogre Battledriver
                case "Ogre Battledriver":
                    mcn = new OgreBattledriver();
                    break;
                # endregion

                # region Opportunity
                case "Opportunity":
                    mcn = new Opportunity();
                    break;
                # endregion

                # region Pacifism
                case "Pacifism":
                    mcn = new Pacifism();
                    break;
                # endregion

                # region Path of Bravery
                case "Path of Bravery":
                    mcn = new PathofBravery();
                    break;
                # endregion

                # region Pay No Heed
                case "Pay No Heed":
                    mcn = new PayNoHeed();
                    break;
                # endregion

                # region Phantom Warrior
                case "Phantom Warrior":
                    mcn = new PhantomWarrior();
                    break;
                # endregion

                # region Pillarfield Ox
                case "Pillarfield Ox":
                    mcn = new PillarfieldOx();
                    break;
                # endregion

                # region Pitchburn Devils
                case "Pitchburn Devils":
                    mcn = new PitchburnDevils();
                    break;
                # endregion

                //# region Plains
                //case "Plains":
                //    mcn = new PlainsRTR();
                //    break;
                //# endregion

                # region Planar Cleansing
                case "Planar Cleansing":
                    mcn = new PlanarCleansing();
                    break;
                # endregion

                # region Plummet
                case "Plummet":
                    mcn = new Plummet();
                    break;
                # endregion

                # region Predatory Sliver
                case "Predatory Sliver":
                    mcn = new PredatorySliver();
                    break;
                # endregion

                # region Primeval Bounty
                case "Primeval Bounty":
                    mcn = new PrimevalBounty();
                    break;
                # endregion

                # region Pyromancer's Gauntlet
                case "Pyromancer's Gauntlet":
                    mcn = new PyromancersGauntlet();
                    break;
                # endregion

                # region Quag Sickness
                case "Quag Sickness":
                    mcn = new QuagSickness();
                    break;
                # endregion

                # region Quicken
                case "Quicken":
                    mcn = new Quicken();
                    break;
                # endregion

                # region Ranger's Guile
                case "Ranger's Guile":
                    mcn = new RangersGuile();
                    break;
                # endregion

                # region Ratchet Bomb
                case "Ratchet Bomb":
                    mcn = new RatchetBomb();
                    break;
                # endregion

                # region Regathan Firecat
                case "Regathan Firecat":
                    mcn = new RegathanFirecat();
                    break;
                # endregion

                # region Ring of Three Wishes
                case "Ring of Three Wishes":
                    mcn = new RingofThreeWishes();
                    break;
                # endregion

                # region Rise of the Dark Realms
                case "Rise of the Dark Realms":
                    mcn = new RiseoftheDarkRealms();
                    break;
                # endregion

                # region Rod of Ruin
                case "Rod of Ruin":
                    mcn = new RodofRuinM14();
                    break;
                # endregion

                # region Rootwalla
                case "Rootwalla":
                    mcn = new Rootwalla();
                    break;
                # endregion

                # region Rumbling Baloth
                case "Rumbling Baloth":
                    mcn = new RumblingBaloth();
                    break;
                # endregion

                # region Sanguine Bond
                case "Sanguine Bond":
                    mcn = new SanguineBond();
                    break;
                # endregion

                # region Savage Summoning
                case "Savage Summoning":
                    mcn = new SavageSummoning();
                    break;
                # endregion

                # region Scavenging Ooze
                case "Scavenging Ooze":
                    mcn = new ScavengingOoze();
                    break;
                # endregion

                # region Scourge of Valkas
                case "Scourge of Valkas":
                    mcn = new ScourgeofValkas();
                    break;
                # endregion

                # region Scroll Thief
                case "Scroll Thief":
                    mcn = new ScrollThief();
                    break;
                # endregion

                # region Seacoast Drake
                case "Seacoast Drake":
                    mcn = new SeacoastDrake();
                    break;
                # endregion

                # region Seismic Stomp
                case "Seismic Stomp":
                    mcn = new SeismicStomp();
                    break;
                # endregion

                # region Sengir Vampire
                case "Sengir Vampire":
                    mcn = new SengirVampireM14();
                    break;
                # endregion

                # region Sensory Deprivation
                case "Sensory Deprivation":
                    mcn = new SensoryDeprivation();
                    break;
                # endregion

                # region Sentinel Sliver
                case "Sentinel Sliver":
                    mcn = new SentinelSliver();
                    break;
                # endregion

                # region Seraph of the Sword
                case "Seraph of the Sword":
                    mcn = new SeraphoftheSword();
                    break;
                # endregion

                # region Serra Angel
                case "Serra Angel":
                    mcn = new SerraAngelM14();
                    break;
                # endregion

                # region Shadowborn Apostle
                case "Shadowborn Apostle":
                    mcn = new ShadowbornApostle();
                    break;
                # endregion

                # region Shadowborn Demon
                case "Shadowborn Demon":
                    mcn = new ShadowbornDemon();
                    break;
                # endregion

                # region Shimmering Grotto
                case "Shimmering Grotto":
                    mcn = new ShimmeringGrotto();
                    break;
                # endregion

                # region Shivan Dragon
                case "Shivan Dragon":
                    mcn = new ShivanDragonM14();
                    break;
                # endregion

                # region Shiv's Embrace
                case "Shiv's Embrace":
                    mcn = new ShivsEmbrace();
                    break;
                # endregion

                # region Shock
                case "Shock":
                    mcn = new Shock();
                    break;
                # endregion

                # region Show of Valor
                case "Show of Valor":
                    mcn = new ShowofValor();
                    break;
                # endregion

                # region Shrivel
                case "Shrivel":
                    mcn = new Shrivel();
                    break;
                # endregion

                # region Siege Mastodon
                case "Siege Mastodon":
                    mcn = new SiegeMastodon();
                    break;
                # endregion

                # region Silence
                case "Silence":
                    mcn = new Silence();
                    break;
                # endregion

                # region Sliver Construct
                case "Sliver Construct":
                    mcn = new SliverConstruct();
                    break;
                # endregion

                # region Smelt
                case "Smelt":
                    mcn = new Smelt();
                    break;
                # endregion

                # region Solemn Offering
                case "Solemn Offering":
                    mcn = new SolemnOffering();
                    break;
                # endregion

                # region Soulmender
                case "Soulmender":
                    mcn = new Soulmender();
                    break;
                # endregion

                # region Spell Blast
                case "Spell Blast":
                    mcn = new SpellBlastM14();
                    break;
                # endregion

                # region Sporemound
                case "Sporemound":
                    mcn = new Sporemound();
                    break;
                # endregion

                # region Staff of the Death Magus
                case "Staff of the Death Magus":
                    mcn = new StaffoftheDeathMagus();
                    break;
                # endregion

                # region Staff of the Flame Magus
                case "Staff of the Flame Magus":
                    mcn = new StaffoftheFlameMagus();
                    break;
                # endregion

                # region Staff of the Mind Magus
                case "Staff of the Mind Magus":
                    mcn = new StaffoftheMindMagus();
                    break;
                # endregion

                # region Staff of the Sun Magus
                case "Staff of the Sun Magus":
                    mcn = new StaffoftheSunMagus();
                    break;
                # endregion

                # region Staff of the Wild Magus
                case "Staff of the Wild Magus":
                    mcn = new StaffoftheWildMagus();
                    break;
                # endregion

                # region Steelform Sliver
                case "Steelform Sliver":
                    mcn = new SteelformSliver();
                    break;
                # endregion

                # region Stonehorn Chanter
                case "Stonehorn Chanter":
                    mcn = new StonehornChanter();
                    break;
                # endregion

                # region Striking Sliver
                case "Striking Sliver":
                    mcn = new StrikingSliver();
                    break;
                # endregion

                # region Strionic Resonator
                case "Strionic Resonator":
                    mcn = new StrionicResonator();
                    break;
                # endregion

                # region Suntail Hawk
                case "Suntail Hawk":
                    mcn = new SuntailHawk();
                    break;
                # endregion

                //# region Swamp
                //case "Swamp":
                //    mcn = new SwampRTR();
                //    break;
                //# endregion

                # region Syphon Sliver
                case "Syphon Sliver":
                    mcn = new SyphonSliver();
                    break;
                # endregion

                # region Tenacious Dead
                case "Tenacious Dead":
                    mcn = new TenaciousDead();
                    break;
                # endregion

                # region Thorncaster Sliver
                case "Thorncaster Sliver":
                    mcn = new ThorncasterSliver();
                    break;
                # endregion

                # region Thunder Strike
                case "Thunder Strike":
                    mcn = new ThunderStrike();
                    break;
                # endregion

                # region Tidebinder Mage
                case "Tidebinder Mage":
                    mcn = new TidebinderMage();
                    break;
                # endregion

                # region Time Ebb
                case "Time Ebb":
                    mcn = new TimeEbb();
                    break;
                # endregion

                # region Tome Scour
                case "Tome Scour":
                    mcn = new TomeScour();
                    break;
                # endregion

                # region Trading Post
                case "Trading Post":
                    mcn = new TradingPost();
                    break;
                # endregion

                # region Trained Condor
                case "Trained Condor":
                    mcn = new TrainedCondor();
                    break;
                # endregion

                # region Traumatize
                case "Traumatize":
                    mcn = new Traumatize();
                    break;
                # endregion

                # region Trollhide
                case "Trollhide":
                    mcn = new Trollhide();
                    break;
                # endregion

                # region Undead Minotaur
                case "Undead Minotaur":
                    mcn = new UndeadMinotaur();
                    break;
                # endregion

                # region Vampire Warlord
                case "Vampire Warlord":
                    mcn = new VampireWarlord();
                    break;
                # endregion

                # region Vastwood Hydra
                case "Vastwood Hydra":
                    mcn = new VastwoodHydra();
                    break;
                # endregion

                //# region Verdant Haven
                //case "Verdant Haven":
                //    mcn = new VerdantHavenM14();
                //    break;
                //# endregion

                # region Vial of Poison
                case "Vial of Poison":
                    mcn = new VialofPoison();
                    break;
                # endregion

                # region Vile Rebirth
                case "Vile Rebirth":
                    mcn = new VileRebirth();
                    break;
                # endregion

                # region Volcanic Geyser
                case "Volcanic Geyser":
                    mcn = new VolcanicGeyser();
                    break;
                # endregion

                # region Voracious Wurm
                case "Voracious Wurm":
                    mcn = new VoraciousWurm();
                    break;
                # endregion

                # region Wall of Frost
                case "Wall of Frost":
                    mcn = new WallofFrost();
                    break;
                # endregion

                # region Wall of Swords
                case "Wall of Swords":
                    mcn = new WallofSwordsM14();
                    break;
                # endregion

                # region Warden of Evos Isle
                case "Warden of Evos Isle":
                    mcn = new WardenofEvosIsle();
                    break;
                # endregion

                # region Water Servant
                case "Water Servant":
                    mcn = new WaterServant();
                    break;
                # endregion

                # region Wild Guess
                case "Wild Guess":
                    mcn = new WildGuess();
                    break;
                # endregion

                # region Wild Ricochet
                case "Wild Ricochet":
                    mcn = new WildRicochet();
                    break;
                # endregion

                # region Windreader Sphinx
                case "Windreader Sphinx":
                    mcn = new WindreaderSphinx();
                    break;
                # endregion

                # region Windstorm
                case "Windstorm":
                    mcn = new Windstorm();
                    break;
                # endregion

                # region Witchstalker
                case "Witchstalker":
                    mcn = new Witchstalker();
                    break;
                # endregion

                # region Woodborn Behemoth
                case "Woodborn Behemoth":
                    mcn = new WoodbornBehemoth();
                    break;
                # endregion

                # region Wring Flesh
                case "Wring Flesh":
                    mcn = new WringFlesh();
                    break;
                # endregion

                # region Xathrid Necromancer
                case "Xathrid Necromancer":
                    mcn = new XathridNecromancer();
                    break;
                # endregion

                # region Young Pyromancer
                case "Young Pyromancer":
                    mcn = new YoungPyromancer();
                    break;
                # endregion

                # region Zephyr Charge
                case "Zephyr Charge":
                    mcn = new ZephyrCharge();
                    break;
                # endregion

                # endregion

                # region Magic 2015
                //# region Accursed Spirit
                //case "Accursed Spirit":
                //    mcn = new AccursedSpiritM15();
                //    break;
                //# endregion

                # region Act on Impulse
                case "Act on Impulse":
                    mcn = new ActonImpulse15();
                    break;
                # endregion

                # region Aegis Angel
                case "Aegis Angel":
                    mcn = new AegisAngel15();
                    break;
                # endregion

                # region Aeronaut Tinkerer
                case "Aeronaut Tinkerer":
                    mcn = new AeronautTinkerer15();
                    break;
                # endregion

                # region AEtherspouts
                case "AEtherspouts":
                    mcn = new AEtherspouts15();
                    break;
                # endregion

                # region Aggressive Mining
                case "Aggressive Mining":
                    mcn = new AggressiveMining15();
                    break;
                # endregion

                # region Ajani Steadfast
                case "Ajani Steadfast":
                    mcn = new AjaniSteadfast15();
                    break;
                # endregion

                # region Ajani's Pridemate
                case "Ajani's Pridemate":
                    mcn = new AjanisPridemate15();
                    break;
                # endregion

                # region Altac Bloodseeker
                case "Altac Bloodseeker":
                    mcn = new AltacBloodseeker15();
                    break;
                # endregion

                # region Amphin Pathmage
                case "Amphin Pathmage":
                    mcn = new AmphinPathmage15();
                    break;
                # endregion

                # region Ancient Silverback
                case "Ancient Silverback":
                    mcn = new AncientSilverback15();
                    break;
                # endregion

                # region Avacyn, Guardian Angel
                case "Avacyn, Guardian Angel":
                    mcn = new AvacynGuardianAngel15();
                    break;
                # endregion

                # region Avarice Amulet
                case "Avarice Amulet":
                    mcn = new AvariceAmulet15();
                    break;
                # endregion

                # region Back to Nature
                case "Back to Nature":
                    mcn = new BacktoNature15();
                    break;
                # endregion

                # region Battle Mastery
                case "Battle Mastery":
                    mcn = new BattleMastery15();
                    break;
                # endregion

                # region Battlefield Forge
                case "Battlefield Forge":
                    mcn = new BattlefieldForge15();
                    break;
                # endregion

                # region Belligerent Sliver
                case "Belligerent Sliver":
                    mcn = new BelligerentSliver15();
                    break;
                # endregion

                # region Black Cat
                case "Black Cat":
                    mcn = new BlackCat15();
                    break;
                # endregion

                # region Blastfire Bolt
                case "Blastfire Bolt":
                    mcn = new BlastfireBolt15();
                    break;
                # endregion

                # region Blood Host
                case "Blood Host":
                    mcn = new BloodHost15();
                    break;
                # endregion

                # region Boonweaver Giant
                case "Boonweaver Giant":
                    mcn = new BoonweaverGiant15();
                    break;
                # endregion

                # region Borderland Marauder
                case "Borderland Marauder":
                    mcn = new BorderlandMarauder15();
                    break;
                # endregion

                # region Brawler's Plate
                case "Brawler's Plate":
                    mcn = new BrawlersPlate15();
                    break;
                # endregion

                //# region Bronze Sable
                //case "Bronze Sable":
                //    mcn = new BronzeSableM15();
                //    break;
                //# endregion

                # region Brood Keeper
                case "Brood Keeper":
                    mcn = new BroodKeeper15();
                    break;
                # endregion

                # region Burning Anger
                case "Burning Anger":
                    mcn = new BurningAnger15();
                    break;
                # endregion

                //# region Cancel
                //case "Cancel":
                //    mcn = new Cancel15();
                //    break;
                //# endregion

                # region Carnivorous Moss-Beast
                case "Carnivorous Moss-Beast":
                    mcn = new CarnivorousMossBeast15();
                    break;
                # endregion

                # region Carrion Crow
                case "Carrion Crow":
                    mcn = new CarrionCrow15();
                    break;
                # endregion

                # region Caustic Tar
                case "Caustic Tar":
                    mcn = new CausticTar15();
                    break;
                # endregion

                # region Caves of Koilos
                case "Caves of Koilos":
                    mcn = new CavesofKoilos15();
                    break;
                # endregion

                # region Centaur Courser
                case "Centaur Courser":
                    mcn = new CentaurCourser15();
                    break;
                # endregion

                //# region Chandra, Pyromaster
                //case "Chandra, Pyromaster":
                //    mcn = new ChandraPyromasterM15();
                //    break;
                //# endregion

                # region Charging Rhino
                case "Charging Rhino":
                    mcn = new ChargingRhino15();
                    break;
                # endregion

                # region Chasm Skulker
                case "Chasm Skulker":
                    mcn = new ChasmSkulker15();
                    break;
                # endregion

                # region Chief Engineer
                case "Chief Engineer":
                    mcn = new ChiefEngineer15();
                    break;
                # endregion

                //# region Child of Night
                //case "Child of Night":
                //    mcn = new ChildofNightM15();
                //    break;
                //# endregion

                # region Chord of Calling
                case "Chord of Calling":
                    mcn = new ChordofCalling15();
                    break;
                # endregion

                # region Chronostutter
                case "Chronostutter":
                    mcn = new Chronostutter15();
                    break;
                # endregion

                # region Circle of Flame
                case "Circle of Flame":
                    mcn = new CircleofFlame15();
                    break;
                # endregion

                //# region Clear a Path
                //case "Clear a Path":
                //    mcn = new ClearaPath15();
                //    break;
                //# endregion

                # region Cone of Flame
                case "Cone of Flame":
                    mcn = new ConeofFlame15();
                    break;
                # endregion

                //# region Congregate
                //case "Congregate":
                //    mcn = new CongregateM15();
                //    break;
                //# endregion

                # region Constricting Sliver
                case "Constricting Sliver":
                    mcn = new ConstrictingSliver15();
                    break;
                # endregion

                # region Coral Barrier
                case "Coral Barrier":
                    mcn = new CoralBarrier15();
                    break;
                # endregion

                # region Covenant of Blood
                case "Covenant of Blood":
                    mcn = new CovenantofBlood15();
                    break;
                # endregion

                # region Crippling Blight
                case "Crippling Blight":
                    mcn = new CripplingBlight15();
                    break;
                # endregion

                # region Crowd's Favor
                case "Crowd's Favor":
                    mcn = new CrowdsFavor15();
                    break;
                # endregion

                # region Crucible of Fire
                case "Crucible of Fire":
                    mcn = new CrucibleofFire15();
                    break;
                # endregion

                # region Cruel Sadist
                case "Cruel Sadist":
                    mcn = new CruelSadist15();
                    break;
                # endregion

                # region Darksteel Citadel
                case "Darksteel Citadel":
                    mcn = new DarksteelCitadel15();
                    break;
                # endregion

                # region Dauntless River Marshal
                case "Dauntless River Marshal":
                    mcn = new DauntlessRiverMarshal15();
                    break;
                # endregion

                # region Devouring Light
                case "Devouring Light":
                    mcn = new DevouringLight15();
                    break;
                # endregion

                # region Diffusion Sliver
                case "Diffusion Sliver":
                    mcn = new DiffusionSliver15();
                    break;
                # endregion

                # region Dissipate
                case "Dissipate":
                    mcn = new Dissipate15();
                    break;
                # endregion

                //# region Divination
                //case "Divination":
                //    mcn = new Divination15();
                //    break;
                //# endregion

                //# region Divine Favor
                //case "Divine Favor":
                //    mcn = new DivineFavor15();
                //    break;
                //# endregion

                //# region Divine Verdict
                //case "Divine Verdict":
                //    mcn = new DivineVerdict15();
                //    break;
                //# endregion

                //# region Elvish Mystic
                //case "Elvish Mystic":
                //    mcn = new ElvishMystic15();
                //    break;
                //# endregion

                # region Encrust
                case "Encrust":
                    mcn = new Encrust15();
                    break;
                # endregion

                # region Endless Obedience
                case "Endless Obedience":
                    mcn = new EndlessObedience15();
                    break;
                # endregion

                # region Ensoul Artifact
                case "Ensoul Artifact":
                    mcn = new EnsoulArtifact15();
                    break;
                # endregion

                # region Ephemeral Shields
                case "Ephemeral Shields":
                    mcn = new EphemeralShields15();
                    break;
                # endregion

                # region Eternal Thirst
                case "Eternal Thirst":
                    mcn = new EternalThirst15();
                    break;
                # endregion

                # region Evolving Wilds
                case "Evolving Wilds":
                    mcn = new EvolvingWilds15();
                    break;
                # endregion

                # region Feast on the Fallen
                case "Feast on the Fallen":
                    mcn = new FeastontheFallen15();
                    break;
                # endregion

                # region Feral Incarnation
                case "Feral Incarnation":
                    mcn = new FeralIncarnation15();
                    break;
                # endregion

                # region Festergloom
                case "Festergloom":
                    mcn = new Festergloom15();
                    break;
                # endregion

                # region First Response
                case "First Response":
                    mcn = new FirstResponse15();
                    break;
                # endregion

                # region Flesh to Dust
                case "Flesh to Dust":
                    mcn = new FleshtoDust15();
                    break;
                # endregion

                //# region Forest
                //case "Forest":
                //    mcn = new Forest15();
                //    break;
                //# endregion

                # region Forge Devil
                case "Forge Devil":
                    mcn = new ForgeDevil15();
                    break;
                # endregion

                //# region Foundry Street Denizen
                //case "Foundry Street Denizen":
                //    mcn = new FoundryStreetDenizen15();
                //    break;
                //# endregion

                # region Frenzied Goblin
                case "Frenzied Goblin":
                    mcn = new FrenziedGoblin15();
                    break;
                # endregion

                # region Frost Lynx
                case "Frost Lynx":
                    mcn = new FrostLynx15();
                    break;
                # endregion

                # region Fugitive Wizard
                case "Fugitive Wizard":
                    mcn = new FugitiveWizard15();
                    break;
                # endregion

                # region Furnace Whelp
                case "Furnace Whelp":
                    mcn = new FurnaceWhelp15();
                    break;
                # endregion

                # region Gargoyle Sentinel
                case "Gargoyle Sentinel":
                    mcn = new GargoyleSentinel15();
                    break;
                # endregion

                # region Garruk, Apex Predator
                case "Garruk, Apex Predator":
                    mcn = new GarrukApexPredator15();
                    break;
                # endregion

                # region Garruk's Packleader
                case "Garruk's Packleader":
                    mcn = new GarruksPackleader15();
                    break;
                # endregion

                # region Gather Courage
                case "Gather Courage":
                    mcn = new GatherCourage15();
                    break;
                # endregion

                # region Geist of the Moors
                case "Geist of the Moors":
                    mcn = new GeistoftheMoors15();
                    break;
                # endregion

                # region Generator Servant
                case "Generator Servant":
                    mcn = new GeneratorServant15();
                    break;
                # endregion

                # region Genesis Hydra
                case "Genesis Hydra":
                    mcn = new GenesisHydra15();
                    break;
                # endregion

                # region Glacial Crasher
                case "Glacial Crasher":
                    mcn = new GlacialCrasher15();
                    break;
                # endregion

                # region Goblin Kaboomist
                case "Goblin Kaboomist":
                    mcn = new GoblinKaboomist15();
                    break;
                # endregion

                # region Goblin Rabblemaster
                case "Goblin Rabblemaster":
                    mcn = new GoblinRabblemaster15();
                    break;
                # endregion

                # region Goblin Roughrider
                case "Goblin Roughrider":
                    mcn = new GoblinRoughrider15();
                    break;
                # endregion

                # region Gravedigger
                case "Gravedigger":
                    mcn = new Gravedigger15();
                    break;
                # endregion

                # region Grindclock
                case "Grindclock":
                    mcn = new Grindclock15();
                    break;
                # endregion

                # region Hammerhand
                case "Hammerhand":
                    mcn = new Hammerhand15();
                    break;
                # endregion

                //# region Haunted Plate Mail
                //case "Haunted Plate Mail":
                //    mcn = new HauntedPlateMail15();
                //    break;
                //# endregion

                # region Heat Ray
                case "Heat Ray":
                    mcn = new HeatRay15();
                    break;
                # endregion

                # region Heliod's Pilgrim
                case "Heliod's Pilgrim":
                    mcn = new HeliodsPilgrim15();
                    break;
                # endregion

                # region Hoarding Dragon
                case "Hoarding Dragon":
                    mcn = new HoardingDragon15();
                    break;
                # endregion

                # region Hornet Nest
                case "Hornet Nest":
                    mcn = new HornetNest15();
                    break;
                # endregion

                # region Hornet Queen
                case "Hornet Queen":
                    mcn = new HornetQueen15();
                    break;
                # endregion

                # region Hot Soup
                case "Hot Soup":
                    mcn = new HotSoup15();
                    break;
                # endregion

                //# region Hunt the Weak
                //case "Hunt the Weak":
                //    mcn = new HunttheWeak15();
                //    break;
                //# endregion

                # region Hunter's Ambush
                case "Hunter's Ambush":
                    mcn = new HuntersAmbush15();
                    break;
                # endregion

                # region Hushwing Gryff
                case "Hushwing Gryff":
                    mcn = new HushwingGryff15();
                    break;
                # endregion

                # region Hydrosurge
                case "Hydrosurge":
                    mcn = new Hydrosurge15();
                    break;
                # endregion

                # region Illusory Angel
                case "Illusory Angel":
                    mcn = new IllusoryAngel15();
                    break;
                # endregion

                # region In Garruk's Wake
                case "In Garruk's Wake":
                    mcn = new InGarruksWake15();
                    break;
                # endregion

                # region Indulgent Tormentor
                case "Indulgent Tormentor":
                    mcn = new IndulgentTormentor15();
                    break;
                # endregion

                # region Inferno Fist
                case "Inferno Fist":
                    mcn = new InfernoFist15();
                    break;
                # endregion

                # region Inspired Charge
                case "Inspired Charge":
                    mcn = new InspiredCharge15();
                    break;
                # endregion

                //# region Into the Void
                //case "Into the Void":
                //    mcn = new IntotheVoid15();
                //    break;
                //# endregion

                # region Invasive Species
                case "Invasive Species":
                    mcn = new InvasiveSpecies15();
                    break;
                # endregion

                # region Invisibility
                case "Invisibility":
                    mcn = new Invisibility15();
                    break;
                # endregion

                //# region Island
                //case "Island":
                //    mcn = new Island15();
                //    break;
                //# endregion

                # region Jace, the Living Guildpact
                case "Jace, the Living Guildpact":
                    mcn = new JacetheLivingGuildpact15();
                    break;
                # endregion

                # region Jace's Ingenuity
                case "Jace's Ingenuity":
                    mcn = new JacesIngenuity15();
                    break;
                # endregion

                # region Jalira, Master Polymorphist
                case "Jalira, Master Polymorphist":
                    mcn = new JaliraMasterPolymorphist15();
                    break;
                # endregion

                # region Jorubai Murk Lurker
                case "Jorubai Murk Lurker":
                    mcn = new JorubaiMurkLurker15();
                    break;
                # endregion

                # region Juggernaut
                case "Juggernaut":
                    mcn = new Juggernaut15();
                    break;
                # endregion

                # region Kalonian Twingrove
                case "Kalonian Twingrove":
                    mcn = new KalonianTwingrove15();
                    break;
                # endregion

                # region Kapsho Kitefins
                case "Kapsho Kitefins":
                    mcn = new KapshoKitefins15();
                    break;
                # endregion

                # region Kinsbaile Skirmisher
                case "Kinsbaile Skirmisher":
                    mcn = new KinsbaileSkirmisher15();
                    break;
                # endregion

                # region Kird Chieftain
                case "Kird Chieftain":
                    mcn = new KirdChieftain15();
                    break;
                # endregion

                # region Krenko's Enforcer
                case "Krenko's Enforcer":
                    mcn = new KrenkosEnforcer15();
                    break;
                # endregion

                # region Kurkesh, Onakke Ancient
                case "Kurkesh, Onakke Ancient":
                    mcn = new KurkeshOnakkeAncient15();
                    break;
                # endregion

                //# region Lava Axe
                //case "Lava Axe":
                //    mcn = new LavaAxe15();
                //    break;
                //# endregion

                # region Leeching Sliver
                case "Leeching Sliver":
                    mcn = new LeechingSliver15();
                    break;
                # endregion

                # region Life's Legacy
                case "Life's Legacy":
                    mcn = new LifesLegacy15();
                    break;
                # endregion

                //# region Lightning Strike
                //case "Lightning Strike":
                //    mcn = new LightningStrike15();
                //    break;
                //# endregion

                # region Liliana Vess
                case "Liliana Vess":
                    mcn = new LilianaVess15();
                    break;
                # endregion

                # region Living Totem
                case "Living Totem":
                    mcn = new LivingTotem15();
                    break;
                # endregion

                # region Llanowar Wastes
                case "Llanowar Wastes":
                    mcn = new LlanowarWastes15();
                    break;
                # endregion

                # region Mahamoti Djinn
                case "Mahamoti Djinn":
                    mcn = new MahamotiDjinn15();
                    break;
                # endregion

                # region Marked by Honor
                case "Marked by Honor":
                    mcn = new MarkedbyHonor15();
                    break;
                # endregion

                # region Mass Calcify
                case "Mass Calcify":
                    mcn = new MassCalcify15();
                    break;
                # endregion

                # region Master of Predicaments
                case "Master of Predicaments":
                    mcn = new MasterofPredicaments15();
                    break;
                # endregion

                # region Meditation Puzzle
                case "Meditation Puzzle":
                    mcn = new MeditationPuzzle15();
                    break;
                # endregion

                # region Mercurial Pretender
                case "Mercurial Pretender":
                    mcn = new MercurialPretender15();
                    break;
                # endregion

                # region Meteorite
                case "Meteorite":
                    mcn = new Meteorite15();
                    break;
                # endregion

                # region Midnight Guard
                case "Midnight Guard":
                    mcn = new MidnightGuard15();
                    break;
                # endregion

                # region Might Makes Right
                case "Might Makes Right":
                    mcn = new MightMakesRight15();
                    break;
                # endregion

                # region Military Intelligence
                case "Military Intelligence":
                    mcn = new MilitaryIntelligence15();
                    break;
                # endregion

                //# region Mind Rot
                //case "Mind Rot":
                //    mcn = new MindRot15();
                //    break;
                //# endregion

                # region Mind Sculpt
                case "Mind Sculpt":
                    mcn = new MindSculpt15();
                    break;
                # endregion

                # region Miner's Bane
                case "Miner's Bane":
                    mcn = new MinersBane15();
                    break;
                # endregion

                //# region Mountain
                //case "Mountain":
                //    mcn = new Mountain15();
                //    break;
                //# endregion

                //# region Naturalize
                //case "Naturalize":
                //    mcn = new Naturalize15();
                //    break;
                //# endregion

                //# region Necrobite
                //case "Necrobite":
                //    mcn = new Necrobite15();
                //    break;
                //# endregion

                # region Necrogen Scudder
                case "Necrogen Scudder":
                    mcn = new NecrogenScudder15();
                    break;
                # endregion

                # region Necromancer's Assistant
                case "Necromancer's Assistant":
                    mcn = new NecromancersAssistant15();
                    break;
                # endregion

                # region Necromancer's Stockpile
                case "Necromancer's Stockpile":
                    mcn = new NecromancersStockpile15();
                    break;
                # endregion

                //# region Negate
                //case "Negate":
                //    mcn = new Negate15();
                //    break;
                //# endregion

                # region Netcaster Spider
                case "Netcaster Spider":
                    mcn = new NetcasterSpider15();
                    break;
                # endregion

                # region Nightfire Giant
                case "Nightfire Giant":
                    mcn = new NightfireGiant15();
                    break;
                # endregion

                //# region Nightmare
                //case "Nightmare":
                //    mcn = new Nightmare15();
                //    break;
                //# endregion

                # region Nimbus of the Isles
                case "Nimbus of the Isles":
                    mcn = new NimbusoftheIsles15();
                    break;
                # endregion

                # region Nissa, Worldwaker
                case "Nissa, Worldwaker":
                    mcn = new NissaWorldwaker15();
                    break;
                # endregion

                # region Nissa's Expedition
                case "Nissa's Expedition":
                    mcn = new NissasExpedition15();
                    break;
                # endregion

                # region Ob Nixilis, Unshackled
                case "Ob Nixilis, Unshackled":
                    mcn = new ObNixilisUnshackled15();
                    break;
                # endregion

                # region Obelisk of Urd
                case "Obelisk of Urd":
                    mcn = new ObeliskofUrd15();
                    break;
                # endregion

                //# region Oppressive Rays
                //case "Oppressive Rays":
                //    mcn = new OppressiveRays15();
                //    break;
                //# endregion

                //# region Oreskos Swiftclaw
                //case "Oreskos Swiftclaw":
                //    mcn = new OreskosSwiftclaw15();
                //    break;
                //# endregion

                # region Ornithopter
                case "Ornithopter":
                    mcn = new Ornithopter15();
                    break;
                # endregion

                # region Overwhelm
                case "Overwhelm":
                    mcn = new Overwhelm15();
                    break;
                # endregion

                # region Paragon of Eternal Wilds
                case "Paragon of Eternal Wilds":
                    mcn = new ParagonofEternalWilds15();
                    break;
                # endregion

                # region Paragon of Fierce Defiance
                case "Paragon of Fierce Defiance":
                    mcn = new ParagonofFierceDefiance15();
                    break;
                # endregion

                # region Paragon of Gathering Mists
                case "Paragon of Gathering Mists":
                    mcn = new ParagonofGatheringMists15();
                    break;
                # endregion

                # region Paragon of New Dawns
                case "Paragon of New Dawns":
                    mcn = new ParagonofNewDawns15();
                    break;
                # endregion

                # region Paragon of Open Graves
                case "Paragon of Open Graves":
                    mcn = new ParagonofOpenGraves15();
                    break;
                # endregion

                //# region Peel from Reality
                //case "Peel from Reality":
                //    mcn = new PeelfromReality15();
                //    break;
                //# endregion

                # region Perilous Vault
                case "Perilous Vault":
                    mcn = new PerilousVault15();
                    break;
                # endregion

                # region Phyrexian Revoker
                case "Phyrexian Revoker":
                    mcn = new PhyrexianRevoker15();
                    break;
                # endregion

                # region Phytotitan
                case "Phytotitan":
                    mcn = new Phytotitan15();
                    break;
                # endregion

                # region Pillar of Light
                case "Pillar of Light":
                    mcn = new PillarofLight15();
                    break;
                # endregion

                //# region Plains
                //case "Plains":
                //    mcn = new Plains15();
                //    break;
                //# endregion

                //# region Plummet
                //case "Plummet":
                //    mcn = new Plummet15();
                //    break;
                //# endregion

                # region Polymorphist's Jest
                case "Polymorphist's Jest":
                    mcn = new PolymorphistsJest15();
                    break;
                # endregion

                # region Preeminent Captain
                case "Preeminent Captain":
                    mcn = new PreeminentCaptain15();
                    break;
                # endregion

                # region Profane Memento
                case "Profane Memento":
                    mcn = new ProfaneMemento15();
                    break;
                # endregion

                # region Quickling
                case "Quickling":
                    mcn = new Quickling15();
                    break;
                # endregion

                # region Radiant Fountain
                case "Radiant Fountain":
                    mcn = new RadiantFountain15();
                    break;
                # endregion

                # region Raise the Alarm
                case "Raise the Alarm":
                    mcn = new RaisetheAlarm15();
                    break;
                # endregion

                //# region Ranger's Guile
                //case "Ranger's Guile":
                //    mcn = new RangersGuile15();
                //    break;
                //# endregion

                # region Razorfoot Griffin
                case "Razorfoot Griffin":
                    mcn = new RazorfootGriffin15();
                    break;
                # endregion

                # region Reclamation Sage
                case "Reclamation Sage":
                    mcn = new ReclamationSage15();
                    break;
                # endregion

                # region Research Assistant
                case "Research Assistant":
                    mcn = new ResearchAssistant15();
                    break;
                # endregion

                # region Resolute Archangel
                case "Resolute Archangel":
                    mcn = new ResoluteArchangel15();
                    break;
                # endregion

                # region Restock
                case "Restock":
                    mcn = new Restock15();
                    break;
                # endregion

                # region Return to the Ranks
                case "Return to the Ranks":
                    mcn = new ReturntotheRanks15();
                    break;
                # endregion

                # region Roaring Primadox
                case "Roaring Primadox":
                    mcn = new RoaringPrimadox15();
                    break;
                # endregion

                # region Rogue's Gloves
                case "Rogue's Gloves":
                    mcn = new RoguesGloves15();
                    break;
                # endregion

                # region Rotfeaster Maggot
                case "Rotfeaster Maggot":
                    mcn = new RotfeasterMaggot15();
                    break;
                # endregion

                # region Rummaging Goblin
                case "Rummaging Goblin":
                    mcn = new RummagingGoblin15();
                    break;
                # endregion

                # region Runeclaw Bear
                case "Runeclaw Bear":
                    mcn = new RuneclawBear15();
                    break;
                # endregion

                # region Sacred Armory
                case "Sacred Armory":
                    mcn = new SacredArmory15();
                    break;
                # endregion

                # region Sanctified Charge
                case "Sanctified Charge":
                    mcn = new SanctifiedCharge15();
                    break;
                # endregion

                //# region Satyr Wayfinder
                //case "Satyr Wayfinder":
                //    mcn = new SatyrWayfinder15();
                //    break;
                //# endregion

                # region Scrapyard Mongrel
                case "Scrapyard Mongrel":
                    mcn = new ScrapyardMongrel15();
                    break;
                # endregion

                # region Scuttling Doom Engine
                case "Scuttling Doom Engine":
                    mcn = new ScuttlingDoomEngine15();
                    break;
                # endregion

                # region Seismic Strike
                case "Seismic Strike":
                    mcn = new SeismicStrike15();
                    break;
                # endregion

                # region Selfless Cathar
                case "Selfless Cathar":
                    mcn = new SelflessCathar15();
                    break;
                # endregion

                //# region Sengir Vampire
                //case "Sengir Vampire":
                //    mcn = new SengirVampire15();
                //    break;
                //# endregion

                # region Seraph of the Masses
                case "Seraph of the Masses":
                    mcn = new SeraphoftheMasses15();
                    break;
                # endregion

                //# region Serra Angel
                //case "Serra Angel":
                //    mcn = new SerraAngel15();
                //    break;
                //# endregion

                # region Shadowcloak Vampire
                case "Shadowcloak Vampire":
                    mcn = new ShadowcloakVampire15();
                    break;
                # endregion

                # region Shaman of Spring
                case "Shaman of Spring":
                    mcn = new ShamanofSpring15();
                    break;
                # endregion

                # region Shield of the Avatar
                case "Shield of the Avatar":
                    mcn = new ShieldoftheAvatar15();
                    break;
                # endregion

                //# region Shivan Dragon
                //case "Shivan Dragon":
                //    mcn = new ShivanDragon15();
                //    break;
                //# endregion

                # region Shivan Reef
                case "Shivan Reef":
                    mcn = new ShivanReef15();
                    break;
                # endregion

                # region Shrapnel Blast
                case "Shrapnel Blast":
                    mcn = new ShrapnelBlast15();
                    break;
                # endregion

                # region Siege Dragon
                case "Siege Dragon":
                    mcn = new SiegeDragon15();
                    break;
                # endregion

                # region Siege Wurm
                case "Siege Wurm":
                    mcn = new SiegeWurm15();
                    break;
                # endregion

                # region Sign in Blood
                case "Sign in Blood":
                    mcn = new SigninBlood15();
                    break;
                # endregion

                # region Sliver Hive
                case "Sliver Hive":
                    mcn = new SliverHive15();
                    break;
                # endregion

                # region Sliver Hivelord
                case "Sliver Hivelord":
                    mcn = new SliverHivelord15();
                    break;
                # endregion

                //# region Solemn Offering
                //case "Solemn Offering":
                //    mcn = new SolemnOffering15();
                //    break;
                //# endregion

                # region Soul of Innistrad
                case "Soul of Innistrad":
                    mcn = new SoulofInnistrad15();
                    break;
                # endregion

                # region Soul of New Phyrexia
                case "Soul of New Phyrexia":
                    mcn = new SoulofNewPhyrexia15();
                    break;
                # endregion

                # region Soul of Ravnica
                case "Soul of Ravnica":
                    mcn = new SoulofRavnica15();
                    break;
                # endregion

                # region Soul of Shandalar
                case "Soul of Shandalar":
                    mcn = new SoulofShandalar15();
                    break;
                # endregion

                # region Soul of Theros
                case "Soul of Theros":
                    mcn = new SoulofTheros15();
                    break;
                # endregion

                # region Soul of Zendikar
                case "Soul of Zendikar":
                    mcn = new SoulofZendikar15();
                    break;
                # endregion

                //# region Soulmender
                //case "Soulmender":
                //    mcn = new Soulmender15();
                //    break;
                //# endregion

                # region Spectra Ward
                case "Spectra Ward":
                    mcn = new SpectraWard15();
                    break;
                # endregion

                # region Spirit Bonds
                case "Spirit Bonds":
                    mcn = new SpiritBonds15();
                    break;
                # endregion

                //# region Stab Wound
                //case "Stab Wound":
                //    mcn = new StabWound15();
                //    break;
                //# endregion

                //# region Staff of the Death Magus
                //case "Staff of the Death Magus":
                //    mcn = new StaffoftheDeathMagus15();
                //    break;
                //# endregion

                //# region Staff of the Flame Magus
                //case "Staff of the Flame Magus":
                //    mcn = new StaffoftheFlameMagus15();
                //    break;
                //# endregion

                //# region Staff of the Mind Magus
                //case "Staff of the Mind Magus":
                //    mcn = new StaffoftheMindMagus15();
                //    break;
                //# endregion

                //# region Staff of the Sun Magus
                //case "Staff of the Sun Magus":
                //    mcn = new StaffoftheSunMagus15();
                //    break;
                //# endregion

                //# region Staff of the Wild Magus
                //case "Staff of the Wild Magus":
                //    mcn = new StaffoftheWildMagus15();
                //    break;
                //# endregion

                # region Stain the Mind
                case "Stain the Mind":
                    mcn = new StaintheMind15();
                    break;
                # endregion

                # region Statute of Denial
                case "Statute of Denial":
                    mcn = new StatuteofDenial15();
                    break;
                # endregion

                # region Stoke the Flames
                case "Stoke the Flames":
                    mcn = new StoketheFlames15();
                    break;
                # endregion

                # region Stormtide Leviathan
                case "Stormtide Leviathan":
                    mcn = new StormtideLeviathan15();
                    break;
                # endregion

                # region Sunblade Elf
                case "Sunblade Elf":
                    mcn = new SunbladeElf15();
                    break;
                # endregion

                # region Sungrace Pegasus
                case "Sungrace Pegasus":
                    mcn = new SungracePegasus15();
                    break;
                # endregion

                //# region Swamp
                //case "Swamp":
                //    mcn = new Swamp15();
                //    break;
                //# endregion

                # region Terra Stomper
                case "Terra Stomper":
                    mcn = new TerraStomper15();
                    break;
                # endregion

                # region The Chain Veil
                case "The Chain Veil":
                    mcn = new TheChainVeil15();
                    break;
                # endregion

                # region Thundering Giant
                case "Thundering Giant":
                    mcn = new ThunderingGiant15();
                    break;
                # endregion

                # region Tireless Missionaries
                case "Tireless Missionaries":
                    mcn = new TirelessMissionaries15();
                    break;
                # endregion

                # region Titanic Growth
                case "Titanic Growth":
                    mcn = new TitanicGrowth15();
                    break;
                # endregion

                # region Torch Fiend
                case "Torch Fiend":
                    mcn = new TorchFiend15();
                    break;
                # endregion

                # region Tormod's Crypt
                case "Tormod's Crypt":
                    mcn = new TormodsCrypt15();
                    break;
                # endregion

                # region Triplicate Spirits
                case "Triplicate Spirits":
                    mcn = new TriplicateSpirits15();
                    break;
                # endregion

                # region Turn to Frog
                case "Turn to Frog":
                    mcn = new TurntoFrog15();
                    break;
                # endregion

                # region Typhoid Rats
                case "Typhoid Rats":
                    mcn = new TyphoidRats15();
                    break;
                # endregion

                # region Tyrant's Machine
                case "Tyrant's Machine":
                    mcn = new TyrantsMachine15();
                    break;
                # endregion

                # region Ulcerate
                case "Ulcerate":
                    mcn = new Ulcerate15();
                    break;
                # endregion

                # region Undergrowth Scavenger
                case "Undergrowth Scavenger":
                    mcn = new UndergrowthScavenger15();
                    break;
                # endregion

                # region Unmake the Graves
                case "Unmake the Graves":
                    mcn = new UnmaketheGraves15();
                    break;
                # endregion

                # region Urborg, Tomb of Yawgmoth
                case "Urborg, Tomb of Yawgmoth":
                    mcn = new UrborgTombofYawgmoth15();
                    break;
                # endregion

                # region Venom Sliver
                case "Venom Sliver":
                    mcn = new VenomSliver15();
                    break;
                # endregion

                //# region Verdant Haven
                //case "Verdant Haven":
                //    mcn = new VerdantHaven15();
                //    break;
                //# endregion

                # region Vineweft
                case "Vineweft":
                    mcn = new Vineweft15();
                    break;
                # endregion

                # region Void Snare
                case "Void Snare":
                    mcn = new VoidSnare15();
                    break;
                # endregion

                # region Walking Corpse
                case "Walking Corpse":
                    mcn = new WalkingCorpse15();
                    break;
                # endregion

                # region Wall of Essence
                case "Wall of Essence":
                    mcn = new WallofEssence15();
                    break;
                # endregion

                # region Wall of Fire
                case "Wall of Fire":
                    mcn = new WallofFire15();
                    break;
                # endregion

                //# region Wall of Frost
                //case "Wall of Frost":
                //    mcn = new WallofFrost15();
                //    break;
                //# endregion

                # region Wall of Limbs
                case "Wall of Limbs":
                    mcn = new WallofLimbs15();
                    break;
                # endregion

                # region Wall of Mulch
                case "Wall of Mulch":
                    mcn = new WallofMulch15();
                    break;
                # endregion

                # region Warden of the Beyond
                case "Warden of the Beyond":
                    mcn = new WardenoftheBeyond15();
                    break;
                # endregion

                # region Waste Not
                case "Waste Not":
                    mcn = new WasteNot15();
                    break;
                # endregion

                # region Welkin Tern
                case "Welkin Tern":
                    mcn = new WelkinTern15();
                    break;
                # endregion

                # region Will-Forged Golem
                case "Will-Forged Golem":
                    mcn = new WillForgedGolem15();
                    break;
                # endregion

                # region Witch's Familiar
                case "Witch's Familiar":
                    mcn = new WitchsFamiliar15();
                    break;
                # endregion

                # region Xathrid Slyblade
                case "Xathrid Slyblade":
                    mcn = new XathridSlyblade15();
                    break;
                # endregion

                # region Yavimaya Coast
                case "Yavimaya Coast":
                    mcn = new YavimayaCoast15();
                    break;
                # endregion

                # region Yisan, the Wanderer Bard
                case "Yisan, the Wanderer Bard":
                    mcn = new YisantheWandererBard15();
                    break;
                # endregion

                # region Zof Shade
                case "Zof Shade":
                    mcn = new ZofShade15();
                    break;
                # endregion

                # endregion

                # region Basic Lands
                //case "Forest":
                //    mcn = new Forest();
                //    break;

                //case "Mountain":
                //    mcn = new Mountain();
                //    break;

                //case "Plains":
                //    mcn = new Plains();
                //    break;

                //case "Swamp":
                //    mcn = new Swamp();
                //    break;

                //case "Island":
                //    mcn = new Island();
                //    break;
                # endregion
                    
                    # region Abyssal Specter
case "Abyssal Specter":
mcn = new AbyssalSpecterIA();
break;
# endregion

# region Adarkar Sentinel
case "Adarkar Sentinel":
mcn = new AdarkarSentinelIA();
break;
# endregion

# region Adarkar Unicorn
case "Adarkar Unicorn":
mcn = new AdarkarUnicornIA();
break;
# endregion

# region Adarkar Wastes
case "Adarkar Wastes":
mcn = new AdarkarWastesIA();
break;
# endregion

# region Aegis of the Meek
case "Aegis of the Meek":
mcn = new AegisoftheMeekIA();
break;
# endregion

# region Aggression
case "Aggression":
mcn = new AggressionIA();
break;
# endregion

# region Altar of Bone
case "Altar of Bone":
mcn = new AltarofBoneIA();
break;
# endregion

# region Amulet of Quoz
case "Amulet of Quoz":
mcn = new AmuletofQuozIA();
break;
# endregion

# region Anarchy
case "Anarchy":
mcn = new AnarchyIA();
break;
# endregion

# region Arctic Foxes
case "Arctic Foxes":
mcn = new ArcticFoxesIA();
break;
# endregion

# region Arcum's Sleigh
case "Arcum's Sleigh":
mcn = new ArcumsSleighIA();
break;
# endregion

# region Arcum's Weathervane
case "Arcum's Weathervane":
mcn = new ArcumsWeathervaneIA();
break;
# endregion

# region Arcum's Whistle
case "Arcum's Whistle":
mcn = new ArcumsWhistleIA();
break;
# endregion

# region Arenson's Aura
case "Arenson's Aura":
mcn = new ArensonsAuraIA();
break;
# endregion

# region Armor of Faith
case "Armor of Faith":
mcn = new ArmorofFaithIA();
break;
# endregion

# region Arnjlot's Ascent
case "Arnjlot's Ascent":
mcn = new ArnjlotsAscentIA();
break;
# endregion

# region Ashen Ghoul
case "Ashen Ghoul":
mcn = new AshenGhoulIA();
break;
# endregion

# region Aurochs
case "Aurochs":
mcn = new AurochsIA();
break;
# endregion

# region Avalanche
case "Avalanche":
mcn = new AvalancheIA();
break;
# endregion

# region Balduvian Barbarians
case "Balduvian Barbarians":
mcn = new BalduvianBarbariansIA();
break;
# endregion

# region Balduvian Bears
case "Balduvian Bears":
mcn = new BalduvianBearsIA();
break;
# endregion

# region Balduvian Conjurer
case "Balduvian Conjurer":
mcn = new BalduvianConjurerIA();
break;
# endregion

# region Balduvian Hydra
case "Balduvian Hydra":
mcn = new BalduvianHydraIA();
break;
# endregion

# region Balduvian Shaman
case "Balduvian Shaman":
mcn = new BalduvianShamanIA();
break;
# endregion

# region Barbarian Guides
case "Barbarian Guides":
mcn = new BarbarianGuidesIA();
break;
# endregion

# region Barbed Sextant
case "Barbed Sextant":
mcn = new BarbedSextantIA();
break;
# endregion

# region Baton of Morale
case "Baton of Morale":
mcn = new BatonofMoraleIA();
break;
# endregion

# region Battle Cry
case "Battle Cry":
mcn = new BattleCryIA();
break;
# endregion

# region Battle Frenzy
case "Battle Frenzy":
mcn = new BattleFrenzyIA();
break;
# endregion

# region Binding Grasp
case "Binding Grasp":
mcn = new BindingGraspIA();
break;
# endregion

# region Black Scarab
case "Black Scarab":
mcn = new BlackScarabIA();
break;
# endregion

# region Blessed Wine
case "Blessed Wine":
mcn = new BlessedWineIA();
break;
# endregion

# region Blinking Spirit
case "Blinking Spirit":
mcn = new BlinkingSpiritIA();
break;
# endregion

# region Blizzard
case "Blizzard":
mcn = new BlizzardIA();
break;
# endregion

# region Blue Scarab
case "Blue Scarab":
mcn = new BlueScarabIA();
break;
# endregion

# region Bone Shaman
case "Bone Shaman":
mcn = new BoneShamanIA();
break;
# endregion

# region Brainstorm
case "Brainstorm":
mcn = new BrainstormIA();
break;
# endregion

# region Brand of Ill Omen
case "Brand of Ill Omen":
mcn = new BrandofIllOmenIA();
break;
# endregion

# region Breath of Dreams
case "Breath of Dreams":
mcn = new BreathofDreamsIA();
break;
# endregion

# region Brine Shaman
case "Brine Shaman":
mcn = new BrineShamanIA();
break;
# endregion

# region Brown Ouphe
case "Brown Ouphe":
mcn = new BrownOupheIA();
break;
# endregion

# region Brushland
case "Brushland":
mcn = new BrushlandIA();
break;
# endregion

# region Burnt Offering
case "Burnt Offering":
mcn = new BurntOfferingIA();
break;
# endregion

# region Call to Arms
case "Call to Arms":
mcn = new CalltoArmsIA();
break;
# endregion

# region Caribou Range
case "Caribou Range":
mcn = new CaribouRangeIA();
break;
# endregion

# region Celestial Sword
case "Celestial Sword":
mcn = new CelestialSwordIA();
break;
# endregion

# region Centaur Archer
case "Centaur Archer":
mcn = new CentaurArcherIA();
break;
# endregion

# region Chaos Lord
case "Chaos Lord":
mcn = new ChaosLordIA();
break;
# endregion

# region Chaos Moon
case "Chaos Moon":
mcn = new ChaosMoonIA();
break;
# endregion

# region Chromatic Armor
case "Chromatic Armor":
mcn = new ChromaticArmorIA();
break;
# endregion

# region Chub Toad
case "Chub Toad":
mcn = new ChubToadIA();
break;
# endregion

# region Circle of Protection: Black
case "Circle of Protection: Black":
mcn = new CircleofProtectionBlackIA();
break;
# endregion

# region Circle of Protection: Blue
case "Circle of Protection: Blue":
mcn = new CircleofProtectionBlueIA();
break;
# endregion

# region Circle of Protection: Green
case "Circle of Protection: Green":
mcn = new CircleofProtectionGreenIA();
break;
# endregion

# region Circle of Protection: Red
case "Circle of Protection: Red":
mcn = new CircleofProtectionRedIA();
break;
# endregion

# region Circle of Protection: White
case "Circle of Protection: White":
mcn = new CircleofProtectionWhiteIA();
break;
# endregion

# region Clairvoyance
case "Clairvoyance":
mcn = new ClairvoyanceIA();
break;
# endregion

# region Cloak of Confusion
case "Cloak of Confusion":
mcn = new CloakofConfusionIA();
break;
# endregion

# region Cold Snap
case "Cold Snap":
mcn = new ColdSnapIA();
break;
# endregion

# region Conquer
case "Conquer":
mcn = new ConquerIA();
break;
# endregion

# region Cooperation
case "Cooperation":
mcn = new CooperationIA();
break;
# endregion

# region Counterspell
case "Counterspell":
mcn = new CounterspellIA();
break;
# endregion

# region Crown of the Ages
case "Crown of the Ages":
mcn = new CrownoftheAgesIA();
break;
# endregion

# region Curse of Marit Lage
case "Curse of Marit Lage":
mcn = new CurseofMaritLageIA();
break;
# endregion

# region Dance of the Dead
case "Dance of the Dead":
mcn = new DanceoftheDeadIA();
break;
# endregion

# region Dark Banishing
case "Dark Banishing":
mcn = new DarkBanishingIA();
break;
# endregion

# region Dark Ritual
case "Dark Ritual":
mcn = new DarkRitualIA();
break;
# endregion

# region Death Ward
case "Death Ward":
mcn = new DeathWardIA();
break;
# endregion

# region Deflection
case "Deflection":
mcn = new DeflectionIA();
break;
# endregion

# region Demonic Consultation
case "Demonic Consultation":
mcn = new DemonicConsultationIA();
break;
# endregion

# region Despotic Scepter
case "Despotic Scepter":
mcn = new DespoticScepterIA();
break;
# endregion

# region Diabolic Vision
case "Diabolic Vision":
mcn = new DiabolicVisionIA();
break;
# endregion

# region Dire Wolves
case "Dire Wolves":
mcn = new DireWolvesIA();
break;
# endregion

# region Disenchant
case "Disenchant":
mcn = new DisenchantIA();
break;
# endregion

# region Dread Wight
case "Dread Wight":
mcn = new DreadWightIA();
break;
# endregion

# region Dreams of the Dead
case "Dreams of the Dead":
mcn = new DreamsoftheDeadIA();
break;
# endregion

# region Drift of the Dead
case "Drift of the Dead":
mcn = new DriftoftheDeadIA();
break;
# endregion

# region Drought
case "Drought":
mcn = new DroughtIA();
break;
# endregion

# region Dwarven Armory
case "Dwarven Armory":
mcn = new DwarvenArmoryIA();
break;
# endregion

# region Earthlink
case "Earthlink":
mcn = new EarthlinkIA();
break;
# endregion

# region Earthlore
case "Earthlore":
mcn = new EarthloreIA();
break;
# endregion

# region Elder Druid
case "Elder Druid":
mcn = new ElderDruidIA();
break;
# endregion

# region Elemental Augury
case "Elemental Augury":
mcn = new ElementalAuguryIA();
break;
# endregion

# region Elkin Bottle
case "Elkin Bottle":
mcn = new ElkinBottleIA();
break;
# endregion

# region Elvish Healer
case "Elvish Healer":
mcn = new ElvishHealerIA();
break;
# endregion

# region Enduring Renewal
case "Enduring Renewal":
mcn = new EnduringRenewalIA();
break;
# endregion

# region Energy Storm
case "Energy Storm":
mcn = new EnergyStormIA();
break;
# endregion

# region Enervate
case "Enervate":
mcn = new EnervateIA();
break;
# endregion

# region Errant Minion
case "Errant Minion":
mcn = new ErrantMinionIA();
break;
# endregion

# region Errantry
case "Errantry":
mcn = new ErrantryIA();
break;
# endregion

# region Essence Filter
case "Essence Filter":
mcn = new EssenceFilterIA();
break;
# endregion

# region Essence Flare
case "Essence Flare":
mcn = new EssenceFlareIA();
break;
# endregion

# region Essence Vortex
case "Essence Vortex":
mcn = new EssenceVortexIA();
break;
# endregion

# region Fanatical Fever
case "Fanatical Fever":
mcn = new FanaticalFeverIA();
break;
# endregion

# region Fear
case "Fear":
mcn = new FearIA();
break;
# endregion

# region Fiery Justice
case "Fiery Justice":
mcn = new FieryJusticeIA();
break;
# endregion

# region Fire Covenant
case "Fire Covenant":
mcn = new FireCovenantIA();
break;
# endregion

# region Flame Spirit
case "Flame Spirit":
mcn = new FlameSpiritIA();
break;
# endregion

# region Flare
case "Flare":
mcn = new FlareIA();
break;
# endregion

# region Flooded Woodlands
case "Flooded Woodlands":
mcn = new FloodedWoodlandsIA();
break;
# endregion

# region Flow of Maggots
case "Flow of Maggots":
mcn = new FlowofMaggotsIA();
break;
# endregion

# region Folk of the Pines
case "Folk of the Pines":
mcn = new FolkofthePinesIA();
break;
# endregion

# region Forbidden Lore
case "Forbidden Lore":
mcn = new ForbiddenLoreIA();
break;
# endregion

# region Force Void
case "Force Void":
mcn = new ForceVoidIA();
break;
# endregion

# region Forest 
case "Forest ":
mcn = new ForestIA();
break;
# endregion

# region Forgotten Lore
case "Forgotten Lore":
mcn = new ForgottenLoreIA();
break;
# endregion

# region Formation
case "Formation":
mcn = new FormationIA();
break;
# endregion

# region Foul Familiar
case "Foul Familiar":
mcn = new FoulFamiliarIA();
break;
# endregion

# region Foxfire
case "Foxfire":
mcn = new FoxfireIA();
break;
# endregion

# region Freyalise Supplicant
case "Freyalise Supplicant":
mcn = new FreyaliseSupplicantIA();
break;
# endregion

# region Freyalise's Charm
case "Freyalise's Charm":
mcn = new FreyalisesCharmIA();
break;
# endregion

# region Freyalise's Winds
case "Freyalise's Winds":
mcn = new FreyalisesWindsIA();
break;
# endregion

# region Fumarole
case "Fumarole":
mcn = new FumaroleIA();
break;
# endregion

# region Fylgja
case "Fylgja":
mcn = new FylgjaIA();
break;
# endregion

# region Fyndhorn Bow
case "Fyndhorn Bow":
mcn = new FyndhornBowIA();
break;
# endregion

# region Fyndhorn Brownie
case "Fyndhorn Brownie":
mcn = new FyndhornBrownieIA();
break;
# endregion

# region Fyndhorn Elder
case "Fyndhorn Elder":
mcn = new FyndhornElderIA();
break;
# endregion

# region Fyndhorn Elves
case "Fyndhorn Elves":
mcn = new FyndhornElvesIA();
break;
# endregion

# region Fyndhorn Pollen
case "Fyndhorn Pollen":
mcn = new FyndhornPollenIA();
break;
# endregion

# region Game of Chaos
case "Game of Chaos":
mcn = new GameofChaosIA();
break;
# endregion

# region Gangrenous Zombies
case "Gangrenous Zombies":
mcn = new GangrenousZombiesIA();
break;
# endregion

# region Gaze of Pain
case "Gaze of Pain":
mcn = new GazeofPainIA();
break;
# endregion

# region General Jarkeld
case "General Jarkeld":
mcn = new GeneralJarkeldIA();
break;
# endregion

# region Ghostly Flame
case "Ghostly Flame":
mcn = new GhostlyFlameIA();
break;
# endregion

//# region Giant Growth
//case "Giant Growth":
//mcn = new GiantGrowthIA();
//break;
//# endregion

# region Giant Trap Door Spider
case "Giant Trap Door Spider":
mcn = new GiantTrapDoorSpiderIA();
break;
# endregion

# region Glacial Chasm
case "Glacial Chasm":
mcn = new GlacialChasmIA();
break;
# endregion

# region Glacial Crevasses
case "Glacial Crevasses":
mcn = new GlacialCrevassesIA();
break;
# endregion

# region Glacial Wall
case "Glacial Wall":
mcn = new GlacialWallIA();
break;
# endregion

# region Glaciers
case "Glaciers":
mcn = new GlaciersIA();
break;
# endregion

# region Goblin Lyre
case "Goblin Lyre":
mcn = new GoblinLyreIA();
break;
# endregion

# region Goblin Mutant
case "Goblin Mutant":
mcn = new GoblinMutantIA();
break;
# endregion

# region Goblin Sappers
case "Goblin Sappers":
mcn = new GoblinSappersIA();
break;
# endregion

# region Goblin Ski Patrol
case "Goblin Ski Patrol":
mcn = new GoblinSkiPatrolIA();
break;
# endregion

# region Goblin Snowman
case "Goblin Snowman":
mcn = new GoblinSnowmanIA();
break;
# endregion

# region Gorilla Pack
case "Gorilla Pack":
mcn = new GorillaPackIA();
break;
# endregion

# region Gravebind
case "Gravebind":
mcn = new GravebindIA();
break;
# endregion

# region Green Scarab
case "Green Scarab":
mcn = new GreenScarabIA();
break;
# endregion

# region Grizzled Wolverine
case "Grizzled Wolverine":
mcn = new GrizzledWolverineIA();
break;
# endregion

# region Hallowed Ground
case "Hallowed Ground":
mcn = new HallowedGroundIA();
break;
# endregion

# region Halls of Mist
case "Halls of Mist":
mcn = new HallsofMistIA();
break;
# endregion

# region Heal
case "Heal":
mcn = new HealIA();
break;
# endregion

# region Hecatomb
case "Hecatomb":
mcn = new HecatombIA();
break;
# endregion

# region Hematite Talisman
case "Hematite Talisman":
mcn = new HematiteTalismanIA();
break;
# endregion

# region Hipparion
case "Hipparion":
mcn = new HipparionIA();
break;
# endregion

# region Hoar Shade
case "Hoar Shade":
mcn = new HoarShadeIA();
break;
# endregion

# region Hot Springs
case "Hot Springs":
mcn = new HotSpringsIA();
break;
# endregion

# region Howl from Beyond
case "Howl from Beyond":
mcn = new HowlfromBeyondIA();
break;
# endregion

# region Hurricane
case "Hurricane":
mcn = new HurricaneIA();
break;
# endregion

# region Hyalopterous Lemure
case "Hyalopterous Lemure":
mcn = new HyalopterousLemureIA();
break;
# endregion

# region Hydroblast
case "Hydroblast":
mcn = new HydroblastIA();
break;
# endregion

# region Hymn of Rebirth
case "Hymn of Rebirth":
mcn = new HymnofRebirthIA();
break;
# endregion

# region Ice Cauldron
case "Ice Cauldron":
mcn = new IceCauldronIA();
break;
# endregion

# region Ice Floe
case "Ice Floe":
mcn = new IceFloeIA();
break;
# endregion

# region Iceberg
case "Iceberg":
mcn = new IcebergIA();
break;
# endregion

# region Icequake
case "Icequake":
mcn = new IcequakeIA();
break;
# endregion

# region Icy Manipulator
case "Icy Manipulator":
mcn = new IcyManipulatorIA();
break;
# endregion

# region Icy Prison
case "Icy Prison":
mcn = new IcyPrisonIA();
break;
# endregion

# region Illusionary Forces
case "Illusionary Forces":
mcn = new IllusionaryForcesIA();
break;
# endregion

# region Illusionary Presence
case "Illusionary Presence":
mcn = new IllusionaryPresenceIA();
break;
# endregion

# region Illusionary Terrain
case "Illusionary Terrain":
mcn = new IllusionaryTerrainIA();
break;
# endregion

# region Illusionary Wall
case "Illusionary Wall":
mcn = new IllusionaryWallIA();
break;
# endregion

# region Illusions of Grandeur
case "Illusions of Grandeur":
mcn = new IllusionsofGrandeurIA();
break;
# endregion

# region Imposing Visage
case "Imposing Visage":
mcn = new ImposingVisageIA();
break;
# endregion

# region Incinerate
case "Incinerate":
mcn = new IncinerateIA();
break;
# endregion

# region Infernal Darkness
case "Infernal Darkness":
mcn = new InfernalDarknessIA();
break;
# endregion

# region Infernal Denizen
case "Infernal Denizen":
mcn = new InfernalDenizenIA();
break;
# endregion

# region Infinite Hourglass
case "Infinite Hourglass":
mcn = new InfiniteHourglassIA();
break;
# endregion

# region Infuse
case "Infuse":
mcn = new InfuseIA();
break;
# endregion

# region Island 
case "Island ":
mcn = new IslandIA();
break;
# endregion

# region Jester's Cap
case "Jester's Cap":
mcn = new JestersCapIA();
break;
# endregion

# region Jester's Mask
case "Jester's Mask":
mcn = new JestersMaskIA();
break;
# endregion

# region Jeweled Amulet
case "Jeweled Amulet":
mcn = new JeweledAmuletIA();
break;
# endregion

# region Johtull Wurm
case "Johtull Wurm":
mcn = new JohtullWurmIA();
break;
# endregion

# region Jokulhaups
case "Jokulhaups":
mcn = new JokulhaupsIA();
break;
# endregion

# region Juniper Order Druid
case "Juniper Order Druid":
mcn = new JuniperOrderDruidIA();
break;
# endregion

# region Justice
case "Justice":
mcn = new JusticeIA();
break;
# endregion

# region Karplusan Forest
case "Karplusan Forest":
mcn = new KarplusanForestIA();
break;
# endregion

# region Karplusan Giant
case "Karplusan Giant":
mcn = new KarplusanGiantIA();
break;
# endregion

# region Karplusan Yeti
case "Karplusan Yeti":
mcn = new KarplusanYetiIA();
break;
# endregion

# region Kelsinko Ranger
case "Kelsinko Ranger":
mcn = new KelsinkoRangerIA();
break;
# endregion

# region Kjeldoran Dead
case "Kjeldoran Dead":
mcn = new KjeldoranDeadIA();
break;
# endregion

# region Kjeldoran Elite Guard
case "Kjeldoran Elite Guard":
mcn = new KjeldoranEliteGuardIA();
break;
# endregion

# region Kjeldoran Frostbeast
case "Kjeldoran Frostbeast":
mcn = new KjeldoranFrostbeastIA();
break;
# endregion

# region Kjeldoran Guard
case "Kjeldoran Guard":
mcn = new KjeldoranGuardIA();
break;
# endregion

# region Kjeldoran Knight
case "Kjeldoran Knight":
mcn = new KjeldoranKnightIA();
break;
# endregion

# region Kjeldoran Phalanx
case "Kjeldoran Phalanx":
mcn = new KjeldoranPhalanxIA();
break;
# endregion

# region Kjeldoran Royal Guard
case "Kjeldoran Royal Guard":
mcn = new KjeldoranRoyalGuardIA();
break;
# endregion

# region Kjeldoran Skycaptain
case "Kjeldoran Skycaptain":
mcn = new KjeldoranSkycaptainIA();
break;
# endregion

# region Kjeldoran Skyknight
case "Kjeldoran Skyknight":
mcn = new KjeldoranSkyknightIA();
break;
# endregion

# region Kjeldoran Warrior
case "Kjeldoran Warrior":
mcn = new KjeldoranWarriorIA();
break;
# endregion

# region Knight of Stromgald
case "Knight of Stromgald":
mcn = new KnightofStromgaldIA();
break;
# endregion

# region Krovikan Elementalist
case "Krovikan Elementalist":
mcn = new KrovikanElementalistIA();
break;
# endregion

# region Krovikan Fetish
case "Krovikan Fetish":
mcn = new KrovikanFetishIA();
break;
# endregion

# region Krovikan Sorcerer
case "Krovikan Sorcerer":
mcn = new KrovikanSorcererIA();
break;
# endregion

# region Krovikan Vampire
case "Krovikan Vampire":
mcn = new KrovikanVampireIA();
break;
# endregion

# region Land Cap
case "Land Cap":
mcn = new LandCapIA();
break;
# endregion

# region Lapis Lazuli Talisman
case "Lapis Lazuli Talisman":
mcn = new LapisLazuliTalismanIA();
break;
# endregion

# region Lava Burst
case "Lava Burst":
mcn = new LavaBurstIA();
break;
# endregion

# region Lava Tubes
case "Lava Tubes":
mcn = new LavaTubesIA();
break;
# endregion

# region Legions of Lim-Dul
case "Legions of Lim-Dul":
mcn = new LegionsofLimDulIA();
break;
# endregion

# region Leshrac's Rite
case "Leshrac's Rite":
mcn = new LeshracsRiteIA();
break;
# endregion

# region Leshrac's Sigil
case "Leshrac's Sigil":
mcn = new LeshracsSigilIA();
break;
# endregion

# region Lhurgoyf
case "Lhurgoyf":
mcn = new LhurgoyfIA();
break;
# endregion

# region Lightning Blow
case "Lightning Blow":
mcn = new LightningBlowIA();
break;
# endregion

# region Lim-Dul's Cohort
case "Lim-Dul's Cohort":
mcn = new LimDulsCohortIA();
break;
# endregion

# region Lim-Dul's Hex
case "Lim-Dul's Hex":
mcn = new LimDulsHexIA();
break;
# endregion

# region Lost Order of Jarkeld
case "Lost Order of Jarkeld":
mcn = new LostOrderofJarkeldIA();
break;
# endregion

# region Lure
case "Lure":
mcn = new LureIA();
break;
# endregion

# region Maddening Wind
case "Maddening Wind":
mcn = new MaddeningWindIA();
break;
# endregion

# region Magus of the Unseen
case "Magus of the Unseen":
mcn = new MagusoftheUnseenIA();
break;
# endregion

# region Malachite Talisman
case "Malachite Talisman":
mcn = new MalachiteTalismanIA();
break;
# endregion

# region Marton Stromgald
case "Marton Stromgald":
mcn = new MartonStromgaldIA();
break;
# endregion

# region Melee
case "Melee":
mcn = new MeleeIA();
break;
# endregion

# region Melting
case "Melting":
mcn = new MeltingIA();
break;
# endregion

# region Mercenaries
case "Mercenaries":
mcn = new MercenariesIA();
break;
# endregion

# region Merieke Ri Berit
case "Merieke Ri Berit":
mcn = new MeriekeRiBeritIA();
break;
# endregion

# region Mesmeric Trance
case "Mesmeric Trance":
mcn = new MesmericTranceIA();
break;
# endregion

# region Meteor Shower
case "Meteor Shower":
mcn = new MeteorShowerIA();
break;
# endregion

# region Mind Ravel
case "Mind Ravel":
mcn = new MindRavelIA();
break;
# endregion

# region Mind Warp
case "Mind Warp":
mcn = new MindWarpIA();
break;
# endregion

# region Mind Whip
case "Mind Whip":
mcn = new MindWhipIA();
break;
# endregion

# region Minion of Leshrac
case "Minion of Leshrac":
mcn = new MinionofLeshracIA();
break;
# endregion

# region Minion of Tevesh Szat
case "Minion of Tevesh Szat":
mcn = new MinionofTeveshSzatIA();
break;
# endregion

# region Mistfolk
case "Mistfolk":
mcn = new MistfolkIA();
break;
# endregion

# region Mole Worms
case "Mole Worms":
mcn = new MoleWormsIA();
break;
# endregion

# region Monsoon
case "Monsoon":
mcn = new MonsoonIA();
break;
# endregion

# region Moor Fiend
case "Moor Fiend":
mcn = new MoorFiendIA();
break;
# endregion

# region Mountain 
case "Mountain ":
mcn = new MountainIA();
break;
# endregion

# region Mountain Goat
case "Mountain Goat":
mcn = new MountainGoatIA();
break;
# endregion

# region Mountain Titan
case "Mountain Titan":
mcn = new MountainTitanIA();
break;
# endregion

# region Mudslide
case "Mudslide":
mcn = new MudslideIA();
break;
# endregion

# region Musician
case "Musician":
mcn = new MusicianIA();
break;
# endregion

# region Mystic Might
case "Mystic Might":
mcn = new MysticMightIA();
break;
# endregion

# region Mystic Remora
case "Mystic Remora":
mcn = new MysticRemoraIA();
break;
# endregion

# region Nacre Talisman
case "Nacre Talisman":
mcn = new NacreTalismanIA();
break;
# endregion

# region Naked Singularity
case "Naked Singularity":
mcn = new NakedSingularityIA();
break;
# endregion

# region Nature's Lore
case "Nature's Lore":
mcn = new NaturesLoreIA();
break;
# endregion

# region Necropotence
case "Necropotence":
mcn = new NecropotenceIA();
break;
# endregion

# region Norritt
case "Norritt":
mcn = new NorrittIA();
break;
# endregion

# region Oath of Lim-Dul
case "Oath of Lim-Dul":
mcn = new OathofLimDulIA();
break;
# endregion

# region Onyx Talisman
case "Onyx Talisman":
mcn = new OnyxTalismanIA();
break;
# endregion

# region Orcish Cannoneers
case "Orcish Cannoneers":
mcn = new OrcishCannoneersIA();
break;
# endregion

# region Orcish Conscripts
case "Orcish Conscripts":
mcn = new OrcishConscriptsIA();
break;
# endregion

# region Orcish Farmer
case "Orcish Farmer":
mcn = new OrcishFarmerIA();
break;
# endregion

# region Orcish Healer
case "Orcish Healer":
mcn = new OrcishHealerIA();
break;
# endregion

# region Orcish Librarian
case "Orcish Librarian":
mcn = new OrcishLibrarianIA();
break;
# endregion

# region Orcish Lumberjack
case "Orcish Lumberjack":
mcn = new OrcishLumberjackIA();
break;
# endregion

# region Orcish Squatters
case "Orcish Squatters":
mcn = new OrcishSquattersIA();
break;
# endregion

# region Order of the Sacred Torch
case "Order of the Sacred Torch":
mcn = new OrderoftheSacredTorchIA();
break;
# endregion

# region Order of the White Shield
case "Order of the White Shield":
mcn = new OrderoftheWhiteShieldIA();
break;
# endregion

# region Pale Bears
case "Pale Bears":
mcn = new PaleBearsIA();
break;
# endregion

# region Panic
case "Panic":
mcn = new PanicIA();
break;
# endregion

# region Pentagram of the Ages
case "Pentagram of the Ages":
mcn = new PentagramoftheAgesIA();
break;
# endregion

# region Pestilence Rats
case "Pestilence Rats":
mcn = new PestilenceRatsIA();
break;
# endregion

# region Phantasmal Mount
case "Phantasmal Mount":
mcn = new PhantasmalMountIA();
break;
# endregion

# region Pit Trap
case "Pit Trap":
mcn = new PitTrapIA();
break;
# endregion

# region Plains 
case "Plains ":
mcn = new PlainsIA();
break;
# endregion

# region Polar Kraken
case "Polar Kraken":
mcn = new PolarKrakenIA();
break;
# endregion

# region Portent
case "Portent":
mcn = new PortentIA();
break;
# endregion

# region Power Sink
case "Power Sink":
mcn = new PowerSinkIA();
break;
# endregion

# region Pox
case "Pox":
mcn = new PoxIA();
break;
# endregion

# region Prismatic Ward
case "Prismatic Ward":
mcn = new PrismaticWardIA();
break;
# endregion

# region Pygmy Allosaurus
case "Pygmy Allosaurus":
mcn = new PygmyAllosaurusIA();
break;
# endregion

# region Pyknite
case "Pyknite":
mcn = new PykniteIA();
break;
# endregion

# region Pyroblast
case "Pyroblast":
mcn = new PyroblastIA();
break;
# endregion

# region Pyroclasm
case "Pyroclasm":
mcn = new PyroclasmIA();
break;
# endregion

# region Rally
case "Rally":
mcn = new RallyIA();
break;
# endregion

# region Ray of Command
case "Ray of Command":
mcn = new RayofCommandIA();
break;
# endregion

# region Ray of Erasure
case "Ray of Erasure":
mcn = new RayofErasureIA();
break;
# endregion

# region Reality Twist
case "Reality Twist":
mcn = new RealityTwistIA();
break;
# endregion

# region Reclamation
case "Reclamation":
mcn = new ReclamationIA();
break;
# endregion

# region Red Scarab
case "Red Scarab":
mcn = new RedScarabIA();
break;
# endregion

# region Regeneration
case "Regeneration":
mcn = new RegenerationIA();
break;
# endregion

# region Rime Dryad
case "Rime Dryad":
mcn = new RimeDryadIA();
break;
# endregion

# region Ritual of Subdual
case "Ritual of Subdual":
mcn = new RitualofSubdualIA();
break;
# endregion

# region River Delta
case "River Delta":
mcn = new RiverDeltaIA();
break;
# endregion

# region Runed Arch
case "Runed Arch":
mcn = new RunedArchIA();
break;
# endregion

# region Sabretooth Tiger
case "Sabretooth Tiger":
mcn = new SabretoothTigerIA();
break;
# endregion

# region Sacred Boon
case "Sacred Boon":
mcn = new SacredBoonIA();
break;
# endregion

# region Scaled Wurm
case "Scaled Wurm":
mcn = new ScaledWurmIA();
break;
# endregion

# region Sea Spirit
case "Sea Spirit":
mcn = new SeaSpiritIA();
break;
# endregion

# region Seizures
case "Seizures":
mcn = new SeizuresIA();
break;
# endregion

# region Seraph
case "Seraph":
mcn = new SeraphIA();
break;
# endregion

# region Shambling Strider
case "Shambling Strider":
mcn = new ShamblingStriderIA();
break;
# endregion

# region Shatter
case "Shatter":
mcn = new ShatterIA();
break;
# endregion

# region Shield Bearer
case "Shield Bearer":
mcn = new ShieldBearerIA();
break;
# endregion

# region Shield of the Ages
case "Shield of the Ages":
mcn = new ShieldoftheAgesIA();
break;
# endregion

# region Shyft
case "Shyft":
mcn = new ShyftIA();
break;
# endregion

# region Sibilant Spirit
case "Sibilant Spirit":
mcn = new SibilantSpiritIA();
break;
# endregion

# region Silver Erne
case "Silver Erne":
mcn = new SilverErneIA();
break;
# endregion

# region Skeleton Ship
case "Skeleton Ship":
mcn = new SkeletonShipIA();
break;
# endregion

# region Skull Catapult
case "Skull Catapult":
mcn = new SkullCatapultIA();
break;
# endregion

# region Sleight of Mind
case "Sleight of Mind":
mcn = new SleightofMindIA();
break;
# endregion

# region Snow Devil
case "Snow Devil":
mcn = new SnowDevilIA();
break;
# endregion

# region Snow Fortress
case "Snow Fortress":
mcn = new SnowFortressIA();
break;
# endregion

# region Snow Hound
case "Snow Hound":
mcn = new SnowHoundIA();
break;
# endregion

# region Snowblind
case "Snowblind":
mcn = new SnowblindIA();
break;
# endregion

# region Snow-Covered Forest
case "Snow-Covered Forest":
mcn = new SnowCoveredForestIA();
break;
# endregion

# region Snow-Covered Island
case "Snow-Covered Island":
mcn = new SnowCoveredIslandIA();
break;
# endregion

# region Snow-Covered Mountain
case "Snow-Covered Mountain":
mcn = new SnowCoveredMountainIA();
break;
# endregion

# region Snow-Covered Plains
case "Snow-Covered Plains":
mcn = new SnowCoveredPlainsIA();
break;
# endregion

# region Snow-Covered Swamp
case "Snow-Covered Swamp":
mcn = new SnowCoveredSwampIA();
break;
# endregion

# region Snowfall
case "Snowfall":
mcn = new SnowfallIA();
break;
# endregion

# region Soldevi Golem
case "Soldevi Golem":
mcn = new SoldeviGolemIA();
break;
# endregion

# region Soldevi Machinist
case "Soldevi Machinist":
mcn = new SoldeviMachinistIA();
break;
# endregion

# region Soldevi Simulacrum
case "Soldevi Simulacrum":
mcn = new SoldeviSimulacrumIA();
break;
# endregion

# region Songs of the Damned
case "Songs of the Damned":
mcn = new SongsoftheDamnedIA();
break;
# endregion

# region Soul Barrier
case "Soul Barrier":
mcn = new SoulBarrierIA();
break;
# endregion

# region Soul Burn
case "Soul Burn":
mcn = new SoulBurnIA();
break;
# endregion

# region Soul Kiss
case "Soul Kiss":
mcn = new SoulKissIA();
break;
# endregion

# region Spectral Shield
case "Spectral Shield":
mcn = new SpectralShieldIA();
break;
# endregion

# region Spoils of Evil
case "Spoils of Evil":
mcn = new SpoilsofEvilIA();
break;
# endregion

# region Spoils of War
case "Spoils of War":
mcn = new SpoilsofWarIA();
break;
# endregion

# region Staff of the Ages
case "Staff of the Ages":
mcn = new StaffoftheAgesIA();
break;
# endregion

# region Stampede
case "Stampede":
mcn = new StampedeIA();
break;
# endregion

# region Stench of Evil
case "Stench of Evil":
mcn = new StenchofEvilIA();
break;
# endregion

# region Stone Rain
case "Stone Rain":
mcn = new StoneRainIA();
break;
# endregion

# region Stone Spirit
case "Stone Spirit":
mcn = new StoneSpiritIA();
break;
# endregion

# region Stonehands
case "Stonehands":
mcn = new StonehandsIA();
break;
# endregion

# region Storm Spirit
case "Storm Spirit":
mcn = new StormSpiritIA();
break;
# endregion

# region Stormbind
case "Stormbind":
mcn = new StormbindIA();
break;
# endregion

# region Stromgald Cabal
case "Stromgald Cabal":
mcn = new StromgaldCabalIA();
break;
# endregion

# region Stunted Growth
case "Stunted Growth":
mcn = new StuntedGrowthIA();
break;
# endregion

# region Sulfurous Springs
case "Sulfurous Springs":
mcn = new SulfurousSpringsIA();
break;
# endregion

# region Sunstone
case "Sunstone":
mcn = new SunstoneIA();
break;
# endregion

# region Swamp 
case "Swamp ":
mcn = new SwampIA();
break;
# endregion

# region Swords to Plowshares
case "Swords to Plowshares":
mcn = new SwordstoPlowsharesIA();
break;
# endregion

# region Tarpan
case "Tarpan":
mcn = new TarpanIA();
break;
# endregion

# region Thermokarst
case "Thermokarst":
mcn = new ThermokarstIA();
break;
# endregion

# region Thoughtleech
case "Thoughtleech":
mcn = new ThoughtleechIA();
break;
# endregion

# region Thunder Wall
case "Thunder Wall":
mcn = new ThunderWallIA();
break;
# endregion

# region Timberline Ridge
case "Timberline Ridge":
mcn = new TimberlineRidgeIA();
break;
# endregion

# region Time Bomb
case "Time Bomb":
mcn = new TimeBombIA();
break;
# endregion

# region Tinder Wall
case "Tinder Wall":
mcn = new TinderWallIA();
break;
# endregion

# region Tor Giant
case "Tor Giant":
mcn = new TorGiantIA();
break;
# endregion

# region Total War
case "Total War":
mcn = new TotalWarIA();
break;
# endregion

# region Touch of Death
case "Touch of Death":
mcn = new TouchofDeathIA();
break;
# endregion

# region Touch of Vitae
case "Touch of Vitae":
mcn = new TouchofVitaeIA();
break;
# endregion

# region Trailblazer
case "Trailblazer":
mcn = new TrailblazerIA();
break;
# endregion

# region Underground River
case "Underground River":
mcn = new UndergroundRiverIA();
break;
# endregion

# region Updraft
case "Updraft":
mcn = new UpdraftIA();
break;
# endregion

# region Urza's Bauble
case "Urza's Bauble":
mcn = new UrzasBaubleIA();
break;
# endregion

# region Veldt
case "Veldt":
mcn = new VeldtIA();
break;
# endregion

# region Venomous Breath
case "Venomous Breath":
mcn = new VenomousBreathIA();
break;
# endregion

# region Vertigo
case "Vertigo":
mcn = new VertigoIA();
break;
# endregion

# region Vexing Arcanix
case "Vexing Arcanix":
mcn = new VexingArcanixIA();
break;
# endregion

# region Vibrating Sphere
case "Vibrating Sphere":
mcn = new VibratingSphereIA();
break;
# endregion

# region Walking Wall
case "Walking Wall":
mcn = new WalkingWallIA();
break;
# endregion

# region Wall of Lava
case "Wall of Lava":
mcn = new WallofLavaIA();
break;
# endregion

# region Wall of Pine Needles
case "Wall of Pine Needles":
mcn = new WallofPineNeedlesIA();
break;
# endregion

# region Wall of Shields
case "Wall of Shields":
mcn = new WallofShieldsIA();
break;
# endregion

# region War Chariot
case "War Chariot":
mcn = new WarChariotIA();
break;
# endregion

# region Warning
case "Warning":
mcn = new WarningIA();
break;
# endregion

# region Whalebone Glider
case "Whalebone Glider":
mcn = new WhaleboneGliderIA();
break;
# endregion

# region White Scarab
case "White Scarab":
mcn = new WhiteScarabIA();
break;
# endregion

# region Whiteout
case "Whiteout":
mcn = new WhiteoutIA();
break;
# endregion

# region Wiitigo
case "Wiitigo":
mcn = new WiitigoIA();
break;
# endregion

# region Wild Growth
case "Wild Growth":
mcn = new WildGrowthIA();
break;
# endregion

# region Wind Spirit
case "Wind Spirit":
mcn = new WindSpiritIA();
break;
# endregion

# region Wings of Aesthir
case "Wings of Aesthir":
mcn = new WingsofAesthirIA();
break;
# endregion

# region Winter's Chill
case "Winter's Chill":
mcn = new WintersChillIA();
break;
# endregion

# region Withering Wisps
case "Withering Wisps":
mcn = new WitheringWispsIA();
break;
# endregion

# region Woolly Mammoths
case "Woolly Mammoths":
mcn = new WoollyMammothsIA();
break;
# endregion

# region Woolly Spider
case "Woolly Spider":
mcn = new WoollySpiderIA();
break;
# endregion

# region Word of Blasting
case "Word of Blasting":
mcn = new WordofBlastingIA();
break;
# endregion

# region Word of Undoing
case "Word of Undoing":
mcn = new WordofUndoingIA();
break;
# endregion

# region Wrath of Marit Lage
case "Wrath of Marit Lage":
mcn = new WrathofMaritLageIA();
break;
# endregion

# region Yavimaya Gnats
case "Yavimaya Gnats":
mcn = new YavimayaGnatsIA();
break;
# endregion

# region Zuran Enchanter
case "Zuran Enchanter":
mcn = new ZuranEnchanterIA();
break;
# endregion

# region Zuran Orb
case "Zuran Orb":
mcn = new ZuranOrbIA();
break;
# endregion

# region Zur's Weirding
case "Zur's Weirding":
mcn = new ZursWeirdingIA();
break;
# endregion



                default:
                    mcn = new MagicCard();
                    mcn.Name = s;
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

    public class TempAbility : CardAbility
    {
        public string Expire = "End Turn";
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
