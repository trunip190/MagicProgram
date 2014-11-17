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
                    List<MagicCard> temp = new List<MagicCard>();
                    temp.AddRange(cards.Where(o => o.Rarity == "M"));
                    temp.AddRange(cards.Where(o => o.Rarity == "R"));
                    temp.AddRange(cards.Where(o => o.Rarity == "U"));
                    temp.AddRange(cards.Where(o => o.Rarity == "C"));
                    cards = temp;
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
            //TODO card duplication happens here

            string st = (card.Name + card.Tapped + card.PT).ToUpper().Trim();
            index();

            # region already in link
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
            # endregion
            # region not in list
            else
            {
                link.Add(st, cards.Count);
                cards.Add(card);
            }
            # endregion

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
                string _cost = Cost.Replace("{", "").Replace("}", "").Trim();
                foreach (char c in _cost)
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

        protected void callActivating(int index)
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

        private void callSpellCast()
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

            # region search for costs":"
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
                    abi.RawCost = tCost[0].Replace("Bestow", "");
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
                    Text = "Equip" + c,
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

            if (net != "" && File.Exists(net))
            {
                img = Image.FromFile(net);
            }
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
            # region TODO move to hard code
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
            # endregion
            foreach (MagicCard mc in attachedCards)
            {
                mc.UpkeepCard();
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

            callEndStep();
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

        public virtual void Attack()
        {
            callOnAttack();
        }

        /// <summary>
        /// Returns a string list of all the enchancements that the card provides when attached
        /// </summary>
        /// <returns>The enhancements it provides when attached to another card</returns>
        public virtual List<string> getStats()
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

        public virtual void SpellTarget()
        {
            callSpellCast();
        }

        public virtual void CreatureEnteredPlay(MagicCard mc)
        {

        }
        # endregion

        public override string ToString()
        {
            return Name + "" + quantity;
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

            temp.Add(netPath);              //add string to first position.

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
        static Random r = new Random();

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

                # region Alpha
                # region Air Elemental
                case "Air Elemental":
                    mcn = new AirElementalA();
                    break;
                # endregion

                # region Ancestral Recall
                case "Ancestral Recall":
                    mcn = new AncestralRecallA();
                    break;
                # endregion

                # region Animate Artifact
                case "Animate Artifact":
                    mcn = new AnimateArtifactA();
                    break;
                # endregion

                # region Animate Dead
                case "Animate Dead":
                    mcn = new AnimateDeadA();
                    break;
                # endregion

                # region Animate Wall
                case "Animate Wall":
                    mcn = new AnimateWallA();
                    break;
                # endregion

                # region Ankh of Mishra
                case "Ankh of Mishra":
                    mcn = new AnkhofMishraA();
                    break;
                # endregion

                # region Armageddon
                case "Armageddon":
                    mcn = new ArmageddonA();
                    break;
                # endregion

                # region Aspect of Wolf
                case "Aspect of Wolf":
                    mcn = new AspectofWolfA();
                    break;
                # endregion

                # region Bad Moon
                case "Bad Moon":
                    mcn = new BadMoonA();
                    break;
                # endregion

                # region Badlands
                case "Badlands":
                    mcn = new BadlandsA();
                    break;
                # endregion

                # region Balance
                case "Balance":
                    mcn = new BalanceA();
                    break;
                # endregion

                # region Basalt Monolith
                case "Basalt Monolith":
                    mcn = new BasaltMonolithA();
                    break;
                # endregion

                # region Bayou
                case "Bayou":
                    mcn = new BayouA();
                    break;
                # endregion

                # region Benalish Hero
                case "Benalish Hero":
                    mcn = new BenalishHeroA();
                    break;
                # endregion

                # region Berserk
                case "Berserk":
                    mcn = new BerserkA();
                    break;
                # endregion

                # region Birds of Paradise
                case "Birds of Paradise":
                    mcn = new BirdsofParadiseA();
                    break;
                # endregion

                # region Black Knight
                case "Black Knight":
                    mcn = new BlackKnightA();
                    break;
                # endregion

                # region Black Lotus
                case "Black Lotus":
                    mcn = new BlackLotusA();
                    break;
                # endregion

                # region Black Vise
                case "Black Vise":
                    mcn = new BlackViseA();
                    break;
                # endregion

                # region Black Ward
                case "Black Ward":
                    mcn = new BlackWardA();
                    break;
                # endregion

                # region Blaze of Glory
                case "Blaze of Glory":
                    mcn = new BlazeofGloryA();
                    break;
                # endregion

                # region Blessing
                case "Blessing":
                    mcn = new BlessingA();
                    break;
                # endregion

                # region Blue Elemental Blast
                case "Blue Elemental Blast":
                    mcn = new BlueElementalBlastA();
                    break;
                # endregion

                # region Blue Ward
                case "Blue Ward":
                    mcn = new BlueWardA();
                    break;
                # endregion

                # region Bog Wraith
                case "Bog Wraith":
                    mcn = new BogWraithA();
                    break;
                # endregion

                # region Braingeyser
                case "Braingeyser":
                    mcn = new BraingeyserA();
                    break;
                # endregion

                # region Burrowing
                case "Burrowing":
                    mcn = new BurrowingA();
                    break;
                # endregion

                # region Camouflage
                case "Camouflage":
                    mcn = new CamouflageA();
                    break;
                # endregion

                # region Castle
                case "Castle":
                    mcn = new CastleA();
                    break;
                # endregion

                # region Celestial Prism
                case "Celestial Prism":
                    mcn = new CelestialPrismA();
                    break;
                # endregion

                # region Channel
                case "Channel":
                    mcn = new ChannelA();
                    break;
                # endregion

                # region Chaos Orb
                case "Chaos Orb":
                    mcn = new ChaosOrbA();
                    break;
                # endregion

                # region Chaoslace
                case "Chaoslace":
                    mcn = new ChaoslaceA();
                    break;
                # endregion

                # region Circle of Protection: Blue
                case "Circle of Protection: Blue":
                    mcn = new CircleofProtectionBlueA();
                    break;
                # endregion

                # region Circle of Protection: Green
                case "Circle of Protection: Green":
                    mcn = new CircleofProtectionGreenA();
                    break;
                # endregion

                # region Circle of Protection: Red
                case "Circle of Protection: Red":
                    mcn = new CircleofProtectionRedA();
                    break;
                # endregion

                # region Circle of Protection: White
                case "Circle of Protection: White":
                    mcn = new CircleofProtectionWhiteA();
                    break;
                # endregion

                # region Clockwork Beast
                case "Clockwork Beast":
                    mcn = new ClockworkBeastA();
                    break;
                # endregion

                # region Clone
                case "Clone":
                    mcn = new CloneA();
                    break;
                # endregion

                # region Cockatrice
                case "Cockatrice":
                    mcn = new CockatriceA();
                    break;
                # endregion

                # region Consecrate Land
                case "Consecrate Land":
                    mcn = new ConsecrateLandA();
                    break;
                # endregion

                # region Conservator
                case "Conservator":
                    mcn = new ConservatorA();
                    break;
                # endregion

                # region Contract from Below
                case "Contract from Below":
                    mcn = new ContractfromBelowA();
                    break;
                # endregion

                # region Control Magic
                case "Control Magic":
                    mcn = new ControlMagicA();
                    break;
                # endregion

                # region Conversion
                case "Conversion":
                    mcn = new ConversionA();
                    break;
                # endregion

                # region Copper Tablet
                case "Copper Tablet":
                    mcn = new CopperTabletA();
                    break;
                # endregion

                # region Copy Artifact
                case "Copy Artifact":
                    mcn = new CopyArtifactA();
                    break;
                # endregion

                # region Counterspell
                case "Counterspell":
                    mcn = new CounterspellA();
                    break;
                # endregion

                # region Craw Wurm
                case "Craw Wurm":
                    mcn = new CrawWurmA();
                    break;
                # endregion

                # region Creature Bond
                case "Creature Bond":
                    mcn = new CreatureBondA();
                    break;
                # endregion

                # region Crusade
                case "Crusade":
                    mcn = new CrusadeA();
                    break;
                # endregion

                # region Crystal Rod
                case "Crystal Rod":
                    mcn = new CrystalRodA();
                    break;
                # endregion

                # region Cursed Land
                case "Cursed Land":
                    mcn = new CursedLandA();
                    break;
                # endregion

                # region Cyclopean Tomb
                case "Cyclopean Tomb":
                    mcn = new CyclopeanTombA();
                    break;
                # endregion

                # region Dark Ritual
                case "Dark Ritual":
                    mcn = new DarkRitualA();
                    break;
                # endregion

                # region Darkpact
                case "Darkpact":
                    mcn = new DarkpactA();
                    break;
                # endregion

                # region Death Ward
                case "Death Ward":
                    mcn = new DeathWardA();
                    break;
                # endregion

                # region Deathgrip
                case "Deathgrip":
                    mcn = new DeathgripA();
                    break;
                # endregion

                # region Deathlace
                case "Deathlace":
                    mcn = new DeathlaceA();
                    break;
                # endregion

                # region Demonic Attorney
                case "Demonic Attorney":
                    mcn = new DemonicAttorneyA();
                    break;
                # endregion

                # region Demonic Hordes
                case "Demonic Hordes":
                    mcn = new DemonicHordesA();
                    break;
                # endregion

                # region Demonic Tutor
                case "Demonic Tutor":
                    mcn = new DemonicTutorA();
                    break;
                # endregion

                # region Dingus Egg
                case "Dingus Egg":
                    mcn = new DingusEggA();
                    break;
                # endregion

                # region Disenchant
                case "Disenchant":
                    mcn = new DisenchantA();
                    break;
                # endregion

                # region Disintegrate
                case "Disintegrate":
                    mcn = new DisintegrateA();
                    break;
                # endregion

                # region Disrupting Scepter
                case "Disrupting Scepter":
                    mcn = new DisruptingScepterA();
                    break;
                # endregion

                # region Dragon Whelp
                case "Dragon Whelp":
                    mcn = new DragonWhelpA();
                    break;
                # endregion

                # region Drain Life
                case "Drain Life":
                    mcn = new DrainLifeA();
                    break;
                # endregion

                # region Drain Power
                case "Drain Power":
                    mcn = new DrainPowerA();
                    break;
                # endregion

                # region Drudge Skeletons
                case "Drudge Skeletons":
                    mcn = new DrudgeSkeletonsA();
                    break;
                # endregion

                # region Dwarven Demolition Team
                case "Dwarven Demolition Team":
                    mcn = new DwarvenDemolitionTeamA();
                    break;
                # endregion

                # region Dwarven Warriors
                case "Dwarven Warriors":
                    mcn = new DwarvenWarriorsA();
                    break;
                # endregion

                # region Earth Elemental
                case "Earth Elemental":
                    mcn = new EarthElementalA();
                    break;
                # endregion

                # region Earthbind
                case "Earthbind":
                    mcn = new EarthbindA();
                    break;
                # endregion

                # region Earthquake
                case "Earthquake":
                    mcn = new EarthquakeA();
                    break;
                # endregion

                # region Elvish Archers
                case "Elvish Archers":
                    mcn = new ElvishArchersA();
                    break;
                # endregion

                # region Evil Presence
                case "Evil Presence":
                    mcn = new EvilPresenceA();
                    break;
                # endregion

                # region False Orders
                case "False Orders":
                    mcn = new FalseOrdersA();
                    break;
                # endregion

                # region Farmstead
                case "Farmstead":
                    mcn = new FarmsteadA();
                    break;
                # endregion

                # region Fastbond
                case "Fastbond":
                    mcn = new FastbondA();
                    break;
                # endregion

                # region Fear
                case "Fear":
                    mcn = new FearA();
                    break;
                # endregion

                # region Feedback
                case "Feedback":
                    mcn = new FeedbackA();
                    break;
                # endregion

                # region Fire Elemental
                case "Fire Elemental":
                    mcn = new FireElementalA();
                    break;
                # endregion

                # region Fireball
                case "Fireball":
                    mcn = new FireballA();
                    break;
                # endregion

                # region Firebreathing
                case "Firebreathing":
                    mcn = new FirebreathingA();
                    break;
                # endregion

                # region Flashfires
                case "Flashfires":
                    mcn = new FlashfiresA();
                    break;
                # endregion

                # region Flight
                case "Flight":
                    mcn = new FlightA();
                    break;
                # endregion

                # region Fog
                case "Fog":
                    mcn = new FogA();
                    break;
                # endregion

                # region Force of Nature
                case "Force of Nature":
                    mcn = new ForceofNatureA();
                    break;
                # endregion

                # region Forcefield
                case "Forcefield":
                    mcn = new ForcefieldA();
                    break;
                # endregion

                //# region Forest 
                //case"Forest":
                //mcn = new ForestA();
                //break;
                //# endregion

                # region Fork
                case "Fork":
                    mcn = new ForkA();
                    break;
                # endregion

                # region Frozen Shade
                case "Frozen Shade":
                    mcn = new FrozenShadeA();
                    break;
                # endregion

                # region Fungusaur
                case "Fungusaur":
                    mcn = new FungusaurA();
                    break;
                # endregion

                # region Gaea's Liege
                case "Gaea's Liege":
                    mcn = new GaeasLiegeA();
                    break;
                # endregion

                # region Gauntlet of Might
                case "Gauntlet of Might":
                    mcn = new GauntletofMightA();
                    break;
                # endregion

                //# region Giant Growth
                //case"Giant Growth":
                //mcn = new GiantGrowthA();
                //break;
                //# endregion

                # region Giant Spider
                case "Giant Spider":
                    mcn = new GiantSpiderA();
                    break;
                # endregion

                # region Glasses of Urza
                case "Glasses of Urza":
                    mcn = new GlassesofUrzaA();
                    break;
                # endregion

                # region Gloom
                case "Gloom":
                    mcn = new GloomA();
                    break;
                # endregion

                # region Goblin Balloon Brigade
                case "Goblin Balloon Brigade":
                    mcn = new GoblinBalloonBrigadeA();
                    break;
                # endregion

                # region Goblin King
                case "Goblin King":
                    mcn = new GoblinKingA();
                    break;
                # endregion

                # region Granite Gargoyle
                case "Granite Gargoyle":
                    mcn = new GraniteGargoyleA();
                    break;
                # endregion

                # region Gray Ogre
                case "Gray Ogre":
                    mcn = new GrayOgreA();
                    break;
                # endregion

                # region Green Ward
                case "Green Ward":
                    mcn = new GreenWardA();
                    break;
                # endregion

                # region Grizzly Bears
                case "Grizzly Bears":
                    mcn = new GrizzlyBearsA();
                    break;
                # endregion

                # region Guardian Angel
                case "Guardian Angel":
                    mcn = new GuardianAngelA();
                    break;
                # endregion

                # region Healing Salve
                case "Healing Salve":
                    mcn = new HealingSalveA();
                    break;
                # endregion

                # region Helm of Chatzuk
                case "Helm of Chatzuk":
                    mcn = new HelmofChatzukA();
                    break;
                # endregion

                # region Hill Giant
                case "Hill Giant":
                    mcn = new HillGiantA();
                    break;
                # endregion

                # region Holy Armor
                case "Holy Armor":
                    mcn = new HolyArmorA();
                    break;
                # endregion

                # region Holy Strength
                case "Holy Strength":
                    mcn = new HolyStrengthA();
                    break;
                # endregion

                # region Howl from Beyond
                case "Howl from Beyond":
                    mcn = new HowlfromBeyondA();
                    break;
                # endregion

                # region Howling Mine
                case "Howling Mine":
                    mcn = new HowlingMineA();
                    break;
                # endregion

                # region Hurloon Minotaur
                case "Hurloon Minotaur":
                    mcn = new HurloonMinotaurA();
                    break;
                # endregion

                # region Hurricane
                case "Hurricane":
                    mcn = new HurricaneA();
                    break;
                # endregion

                # region Hypnotic Specter
                case "Hypnotic Specter":
                    mcn = new HypnoticSpecterA();
                    break;
                # endregion

                # region Ice Storm
                case "Ice Storm":
                    mcn = new IceStormA();
                    break;
                # endregion

                # region Icy Manipulator
                case "Icy Manipulator":
                    mcn = new IcyManipulatorA();
                    break;
                # endregion

                # region Illusionary Mask
                case "Illusionary Mask":
                    mcn = new IllusionaryMaskA();
                    break;
                # endregion

                # region Instill Energy
                case "Instill Energy":
                    mcn = new InstillEnergyA();
                    break;
                # endregion

                # region Invisibility
                case "Invisibility":
                    mcn = new InvisibilityA();
                    break;
                # endregion

                # region Iron Star
                case "Iron Star":
                    mcn = new IronStarA();
                    break;
                # endregion

                # region Ironclaw Orcs
                case "Ironclaw Orcs":
                    mcn = new IronclawOrcsA();
                    break;
                # endregion

                # region Ironroot Treefolk
                case "Ironroot Treefolk":
                    mcn = new IronrootTreefolkA();
                    break;
                # endregion

                //# region Island 
                //case"Island":
                //mcn = new IslandA();
                //break;
                //# endregion

                # region Island Sanctuary
                case "Island Sanctuary":
                    mcn = new IslandSanctuaryA();
                    break;
                # endregion

                # region Ivory Cup
                case "Ivory Cup":
                    mcn = new IvoryCupA();
                    break;
                # endregion

                # region Jade Monolith
                case "Jade Monolith":
                    mcn = new JadeMonolithA();
                    break;
                # endregion

                # region Jade Statue
                case "Jade Statue":
                    mcn = new JadeStatueA();
                    break;
                # endregion

                # region Jayemdae Tome
                case "Jayemdae Tome":
                    mcn = new JayemdaeTomeA();
                    break;
                # endregion

                # region Juggernaut
                case "Juggernaut":
                    mcn = new JuggernautA();
                    break;
                # endregion

                # region Jump
                case "Jump":
                    mcn = new JumpA();
                    break;
                # endregion

                # region Karma
                case "Karma":
                    mcn = new KarmaA();
                    break;
                # endregion

                # region Keldon Warlord
                case "Keldon Warlord":
                    mcn = new KeldonWarlordA();
                    break;
                # endregion

                # region Kormus Bell
                case "Kormus Bell":
                    mcn = new KormusBellA();
                    break;
                # endregion

                # region Kudzu
                case "Kudzu":
                    mcn = new KudzuA();
                    break;
                # endregion

                # region Lance
                case "Lance":
                    mcn = new LanceA();
                    break;
                # endregion

                # region Ley Druid
                case "Ley Druid":
                    mcn = new LeyDruidA();
                    break;
                # endregion

                # region Library of Leng
                case "Library of Leng":
                    mcn = new LibraryofLengA();
                    break;
                # endregion

                # region Lich
                case "Lich":
                    mcn = new LichA();
                    break;
                # endregion

                # region Lifeforce
                case "Lifeforce":
                    mcn = new LifeforceA();
                    break;
                # endregion

                # region Lifelace
                case "Lifelace":
                    mcn = new LifelaceA();
                    break;
                # endregion

                # region Lifetap
                case "Lifetap":
                    mcn = new LifetapA();
                    break;
                # endregion

                # region Lightning Bolt
                case "Lightning Bolt":
                    mcn = new LightningBoltA();
                    break;
                # endregion

                # region Living Artifact
                case "Living Artifact":
                    mcn = new LivingArtifactA();
                    break;
                # endregion

                # region Living Lands
                case "Living Lands":
                    mcn = new LivingLandsA();
                    break;
                # endregion

                # region Living Wall
                case "Living Wall":
                    mcn = new LivingWallA();
                    break;
                # endregion

                # region Llanowar Elves
                case "Llanowar Elves":
                    mcn = new LlanowarElvesA();
                    break;
                # endregion

                # region Lord of Atlantis
                case "Lord of Atlantis":
                    mcn = new LordofAtlantisA();
                    break;
                # endregion

                # region Lord of the Pit
                case "Lord of the Pit":
                    mcn = new LordofthePitA();
                    break;
                # endregion

                # region Lure
                case "Lure":
                    mcn = new LureA();
                    break;
                # endregion

                # region Magical Hack
                case "Magical Hack":
                    mcn = new MagicalHackA();
                    break;
                # endregion

                # region Mahamoti Djinn
                case "Mahamoti Djinn":
                    mcn = new MahamotiDjinnA();
                    break;
                # endregion

                # region Mana Flare
                case "Mana Flare":
                    mcn = new ManaFlareA();
                    break;
                # endregion

                # region Mana Short
                case "Mana Short":
                    mcn = new ManaShortA();
                    break;
                # endregion

                # region Mana Vault
                case "Mana Vault":
                    mcn = new ManaVaultA();
                    break;
                # endregion

                # region Manabarbs
                case "Manabarbs":
                    mcn = new ManabarbsA();
                    break;
                # endregion

                # region Meekstone
                case "Meekstone":
                    mcn = new MeekstoneA();
                    break;
                # endregion

                # region Merfolk of the Pearl Trident
                case "Merfolk of the Pearl Trident":
                    mcn = new MerfolkofthePearlTridentA();
                    break;
                # endregion

                # region Mesa Pegasus
                case "Mesa Pegasus":
                    mcn = new MesaPegasusA();
                    break;
                # endregion

                # region Mind Twist
                case "Mind Twist":
                    mcn = new MindTwistA();
                    break;
                # endregion

                # region Mons's Goblin Raiders
                case "Mons's Goblin Raiders":
                    mcn = new MonssGoblinRaidersA();
                    break;
                # endregion

                //# region Mountain 
                //case"Mountain":
                //mcn = new MountainA();
                //break;
                //# endregion

                # region Mox Emerald
                case "Mox Emerald":
                    mcn = new MoxEmeraldA();
                    break;
                # endregion

                # region Mox Jet
                case "Mox Jet":
                    mcn = new MoxJetA();
                    break;
                # endregion

                # region Mox Pearl
                case "Mox Pearl":
                    mcn = new MoxPearlA();
                    break;
                # endregion

                # region Mox Ruby
                case "Mox Ruby":
                    mcn = new MoxRubyA();
                    break;
                # endregion

                # region Mox Sapphire
                case "Mox Sapphire":
                    mcn = new MoxSapphireA();
                    break;
                # endregion

                # region Natural Selection
                case "Natural Selection":
                    mcn = new NaturalSelectionA();
                    break;
                # endregion

                # region Nether Shadow
                case "Nether Shadow":
                    mcn = new NetherShadowA();
                    break;
                # endregion

                # region Nettling Imp
                case "Nettling Imp":
                    mcn = new NettlingImpA();
                    break;
                # endregion

                # region Nevinyrral's Disk
                case "Nevinyrral's Disk":
                    mcn = new NevinyrralsDiskA();
                    break;
                # endregion

                # region Nightmare
                case "Nightmare":
                    mcn = new NightmareA();
                    break;
                # endregion

                # region Northern Paladin
                case "Northern Paladin":
                    mcn = new NorthernPaladinA();
                    break;
                # endregion

                # region Obsianus Golem
                case "Obsianus Golem":
                    mcn = new ObsianusGolemA();
                    break;
                # endregion

                # region Orcish Artillery
                case "Orcish Artillery":
                    mcn = new OrcishArtilleryA();
                    break;
                # endregion

                # region Orcish Oriflamme
                case "Orcish Oriflamme":
                    mcn = new OrcishOriflammeA();
                    break;
                # endregion

                # region Paralyze
                case "Paralyze":
                    mcn = new ParalyzeA();
                    break;
                # endregion

                # region Pearled Unicorn
                case "Pearled Unicorn":
                    mcn = new PearledUnicornA();
                    break;
                # endregion

                # region Personal Incarnation
                case "Personal Incarnation":
                    mcn = new PersonalIncarnationA();
                    break;
                # endregion

                # region Pestilence
                case "Pestilence":
                    mcn = new PestilenceA();
                    break;
                # endregion

                # region Phantasmal Forces
                case "Phantasmal Forces":
                    mcn = new PhantasmalForcesA();
                    break;
                # endregion

                # region Phantasmal Terrain
                case "Phantasmal Terrain":
                    mcn = new PhantasmalTerrainA();
                    break;
                # endregion

                # region Phantom Monster
                case "Phantom Monster":
                    mcn = new PhantomMonsterA();
                    break;
                # endregion

                # region Pirate Ship
                case "Pirate Ship":
                    mcn = new PirateShipA();
                    break;
                # endregion

                # region Plague Rats
                case "Plague Rats":
                    mcn = new PlagueRatsA();
                    break;
                # endregion

                //# region Plains 
                //case"Plains":
                //mcn = new PlainsA();
                //break;
                //# endregion

                # region Plateau
                case "Plateau":
                    mcn = new PlateauA();
                    break;
                # endregion

                # region Power Leak
                case "Power Leak":
                    mcn = new PowerLeakA();
                    break;
                # endregion

                # region Power Sink
                case "Power Sink":
                    mcn = new PowerSinkA();
                    break;
                # endregion

                # region Power Surge
                case "Power Surge":
                    mcn = new PowerSurgeA();
                    break;
                # endregion

                # region Prodigal Sorcerer
                case "Prodigal Sorcerer":
                    mcn = new ProdigalSorcererA();
                    break;
                # endregion

                # region Psionic Blast
                case "Psionic Blast":
                    mcn = new PsionicBlastA();
                    break;
                # endregion

                # region Psychic Venom
                case "Psychic Venom":
                    mcn = new PsychicVenomA();
                    break;
                # endregion

                # region Purelace
                case "Purelace":
                    mcn = new PurelaceA();
                    break;
                # endregion

                # region Raging River
                case "Raging River":
                    mcn = new RagingRiverA();
                    break;
                # endregion

                # region Raise Dead
                case "Raise Dead":
                    mcn = new RaiseDeadA();
                    break;
                # endregion

                # region Red Elemental Blast
                case "Red Elemental Blast":
                    mcn = new RedElementalBlastA();
                    break;
                # endregion

                # region Red Ward
                case "Red Ward":
                    mcn = new RedWardA();
                    break;
                # endregion

                # region Regeneration
                case "Regeneration":
                    mcn = new RegenerationA();
                    break;
                # endregion

                # region Regrowth
                case "Regrowth":
                    mcn = new RegrowthA();
                    break;
                # endregion

                # region Resurrection
                case "Resurrection":
                    mcn = new ResurrectionA();
                    break;
                # endregion

                # region Reverse Damage
                case "Reverse Damage":
                    mcn = new ReverseDamageA();
                    break;
                # endregion

                # region Righteousness
                case "Righteousness":
                    mcn = new RighteousnessA();
                    break;
                # endregion

                # region Roc of Kher Ridges
                case "Roc of Kher Ridges":
                    mcn = new RocofKherRidgesA();
                    break;
                # endregion

                # region Rock Hydra
                case "Rock Hydra":
                    mcn = new RockHydraA();
                    break;
                # endregion

                # region Rod of Ruin
                case "Rod of Ruin":
                    mcn = new RodofRuinA();
                    break;
                # endregion

                # region Royal Assassin
                case "Royal Assassin":
                    mcn = new RoyalAssassinA();
                    break;
                # endregion

                # region Sacrifice
                case "Sacrifice":
                    mcn = new SacrificeA();
                    break;
                # endregion

                # region Samite Healer
                case "Samite Healer":
                    mcn = new SamiteHealerA();
                    break;
                # endregion

                # region Savannah
                case "Savannah":
                    mcn = new SavannahA();
                    break;
                # endregion

                # region Savannah Lions
                case "Savannah Lions":
                    mcn = new SavannahLionsA();
                    break;
                # endregion

                # region Scathe Zombies
                case "Scathe Zombies":
                    mcn = new ScatheZombiesA();
                    break;
                # endregion

                # region Scavenging Ghoul
                case "Scavenging Ghoul":
                    mcn = new ScavengingGhoulA();
                    break;
                # endregion

                # region Scrubland
                case "Scrubland":
                    mcn = new ScrublandA();
                    break;
                # endregion

                # region Scryb Sprites
                case "Scryb Sprites":
                    mcn = new ScrybSpritesA();
                    break;
                # endregion

                # region Sea Serpent
                case "Sea Serpent":
                    mcn = new SeaSerpentA();
                    break;
                # endregion

                # region Sedge Troll
                case "Sedge Troll":
                    mcn = new SedgeTrollA();
                    break;
                # endregion

                # region Sengir Vampire
                case "Sengir Vampire":
                    mcn = new SengirVampireA();
                    break;
                # endregion

                # region Serra Angel
                case "Serra Angel":
                    mcn = new SerraAngelA();
                    break;
                # endregion

                # region Shanodin Dryads
                case "Shanodin Dryads":
                    mcn = new ShanodinDryadsA();
                    break;
                # endregion

                # region Shatter
                case "Shatter":
                    mcn = new ShatterA();
                    break;
                # endregion

                # region Shivan Dragon
                case "Shivan Dragon":
                    mcn = new ShivanDragonA();
                    break;
                # endregion

                # region Simulacrum
                case "Simulacrum":
                    mcn = new SimulacrumA();
                    break;
                # endregion

                # region Sinkhole
                case "Sinkhole":
                    mcn = new SinkholeA();
                    break;
                # endregion

                # region Siren's Call
                case "Siren's Call":
                    mcn = new SirensCallA();
                    break;
                # endregion

                # region Sleight of Mind
                case "Sleight of Mind":
                    mcn = new SleightofMindA();
                    break;
                # endregion

                # region Smoke
                case "Smoke":
                    mcn = new SmokeA();
                    break;
                # endregion

                # region Sol Ring
                case "Sol Ring":
                    mcn = new SolRingA();
                    break;
                # endregion

                # region Soul Net
                case "Soul Net":
                    mcn = new SoulNetA();
                    break;
                # endregion

                # region Spell Blast
                case "Spell Blast":
                    mcn = new SpellBlastA();
                    break;
                # endregion

                # region Stasis
                case "Stasis":
                    mcn = new StasisA();
                    break;
                # endregion

                # region Steal Artifact
                case "Steal Artifact":
                    mcn = new StealArtifactA();
                    break;
                # endregion

                # region Stone Giant
                case "Stone Giant":
                    mcn = new StoneGiantA();
                    break;
                # endregion

                # region Stone Rain
                case "Stone Rain":
                    mcn = new StoneRainA();
                    break;
                # endregion

                # region Stream of Life
                case "Stream of Life":
                    mcn = new StreamofLifeA();
                    break;
                # endregion

                # region Sunglasses of Urza
                case "Sunglasses of Urza":
                    mcn = new SunglassesofUrzaA();
                    break;
                # endregion

                //# region Swamp
                //case "Swamp":
                //    mcn = new SwampA();
                //    break;
                //# endregion

                # region Swords to Plowshares
                case "Swords to Plowshares":
                    mcn = new SwordstoPlowsharesA();
                    break;
                # endregion

                # region Taiga
                case "Taiga":
                    mcn = new TaigaA();
                    break;
                # endregion

                # region Terror
                case "Terror":
                    mcn = new TerrorA();
                    break;
                # endregion

                # region The Hive
                case "The Hive":
                    mcn = new TheHiveA();
                    break;
                # endregion

                # region Thicket Basilisk
                case "Thicket Basilisk":
                    mcn = new ThicketBasiliskA();
                    break;
                # endregion

                # region Thoughtlace
                case "Thoughtlace":
                    mcn = new ThoughtlaceA();
                    break;
                # endregion

                # region Throne of Bone
                case "Throne of Bone":
                    mcn = new ThroneofBoneA();
                    break;
                # endregion

                # region Timber Wolves
                case "Timber Wolves":
                    mcn = new TimberWolvesA();
                    break;
                # endregion

                # region Time Vault
                case "Time Vault":
                    mcn = new TimeVaultA();
                    break;
                # endregion

                # region Time Walk
                case "Time Walk":
                    mcn = new TimeWalkA();
                    break;
                # endregion

                # region Timetwister
                case "Timetwister":
                    mcn = new TimetwisterA();
                    break;
                # endregion

                # region Tranquility
                case "Tranquility":
                    mcn = new TranquilityA();
                    break;
                # endregion

                # region Tropical Island
                case "Tropical Island":
                    mcn = new TropicalIslandA();
                    break;
                # endregion

                # region Tsunami
                case "Tsunami":
                    mcn = new TsunamiA();
                    break;
                # endregion

                # region Tundra
                case "Tundra":
                    mcn = new TundraA();
                    break;
                # endregion

                # region Tunnel
                case "Tunnel":
                    mcn = new TunnelA();
                    break;
                # endregion

                # region Twiddle
                case "Twiddle":
                    mcn = new TwiddleA();
                    break;
                # endregion

                # region Two-Headed Giant of Foriys
                case "Two-Headed Giant of Foriys":
                    mcn = new TwoHeadedGiantofForiysA();
                    break;
                # endregion

                # region Underground Sea
                case "Underground Sea":
                    mcn = new UndergroundSeaA();
                    break;
                # endregion

                # region Unholy Strength
                case "Unholy Strength":
                    mcn = new UnholyStrengthA();
                    break;
                # endregion

                # region Unsummon
                case "Unsummon":
                    mcn = new UnsummonA();
                    break;
                # endregion

                # region Uthden Troll
                case "Uthden Troll":
                    mcn = new UthdenTrollA();
                    break;
                # endregion

                # region Verduran Enchantress
                case "Verduran Enchantress":
                    mcn = new VerduranEnchantressA();
                    break;
                # endregion

                # region Vesuvan Doppelganger
                case "Vesuvan Doppelganger":
                    mcn = new VesuvanDoppelgangerA();
                    break;
                # endregion

                # region Veteran Bodyguard
                case "Veteran Bodyguard":
                    mcn = new VeteranBodyguardA();
                    break;
                # endregion

                # region Volcanic Eruption
                case "Volcanic Eruption":
                    mcn = new VolcanicEruptionA();
                    break;
                # endregion

                # region Wall of Air
                case "Wall of Air":
                    mcn = new WallofAirA();
                    break;
                # endregion

                # region Wall of Bone
                case "Wall of Bone":
                    mcn = new WallofBoneA();
                    break;
                # endregion

                # region Wall of Brambles
                case "Wall of Brambles":
                    mcn = new WallofBramblesA();
                    break;
                # endregion

                # region Wall of Fire
                case "Wall of Fire":
                    mcn = new WallofFireA();
                    break;
                # endregion

                # region Wall of Ice
                case "Wall of Ice":
                    mcn = new WallofIceA();
                    break;
                # endregion

                # region Wall of Stone
                case "Wall of Stone":
                    mcn = new WallofStoneA();
                    break;
                # endregion

                # region Wall of Swords
                case "Wall of Swords":
                    mcn = new WallofSwordsA();
                    break;
                # endregion

                # region Wall of Water
                case "Wall of Water":
                    mcn = new WallofWaterA();
                    break;
                # endregion

                # region Wall of Wood
                case "Wall of Wood":
                    mcn = new WallofWoodA();
                    break;
                # endregion

                # region Wanderlust
                case "Wanderlust":
                    mcn = new WanderlustA();
                    break;
                # endregion

                # region War Mammoth
                case "War Mammoth":
                    mcn = new WarMammothA();
                    break;
                # endregion

                # region Warp Artifact
                case "Warp Artifact":
                    mcn = new WarpArtifactA();
                    break;
                # endregion

                # region Water Elemental
                case "Water Elemental":
                    mcn = new WaterElementalA();
                    break;
                # endregion

                # region Weakness
                case "Weakness":
                    mcn = new WeaknessA();
                    break;
                # endregion

                # region Web
                case "Web":
                    mcn = new WebA();
                    break;
                # endregion

                # region Wheel of Fortune
                case "Wheel of Fortune":
                    mcn = new WheelofFortuneA();
                    break;
                # endregion

                # region White Knight
                case "White Knight":
                    mcn = new WhiteKnightA();
                    break;
                # endregion

                # region White Ward
                case "White Ward":
                    mcn = new WhiteWardA();
                    break;
                # endregion

                # region Wild Growth
                case "Wild Growth":
                    mcn = new WildGrowthA();
                    break;
                # endregion

                # region Will-o'-the-Wisp
                case "Will-o'-the-Wisp":
                    mcn = new WillotheWispA();
                    break;
                # endregion

                # region Winter Orb
                case "Winter Orb":
                    mcn = new WinterOrbA();
                    break;
                # endregion

                # region Wooden Sphere
                case "Wooden Sphere":
                    mcn = new WoodenSphereA();
                    break;
                # endregion

                # region Word of Command
                case "Word of Command":
                    mcn = new WordofCommandA();
                    break;
                # endregion

                # region Wrath of God
                case "Wrath of God":
                    mcn = new WrathofGodA();
                    break;
                # endregion

                # region Zombie Master
                case "Zombie Master":
                    mcn = new ZombieMasterA();
                    break;
                # endregion


                # endregion

                # region Stronghold uncomplete
                case "Sliver Queen":
                    mcn = new SliverQueenSH();
                    break;
                # endregion

                # region Mirrodin
                # region AEther Spellbomb
                case "AEther Spellbomb":
                    mcn = new AEtherSpellbombMR();
                    break;
                # endregion

                # region Alpha Myr
                case "Alpha Myr":
                    mcn = new AlphaMyrMR();
                    break;
                # endregion

                # region Altar of Shadows
                case "Altar of Shadows":
                    mcn = new AltarofShadowsMR();
                    break;
                # endregion

                # region Altar's Light
                case "Altar's Light":
                    mcn = new AltarsLightMR();
                    break;
                # endregion

                # region Ancient Den
                case "Ancient Den":
                    mcn = new AncientDenMR();
                    break;
                # endregion

                # region Annul
                case "Annul":
                    mcn = new AnnulMR();
                    break;
                # endregion

                # region Arc-Slogger
                case "Arc-Slogger":
                    mcn = new ArcSloggerMR();
                    break;
                # endregion

                # region Arrest
                case "Arrest":
                    mcn = new ArrestMR();
                    break;
                # endregion

                # region Assert Authority
                case "Assert Authority":
                    mcn = new AssertAuthorityMR();
                    break;
                # endregion

                # region Atog
                case "Atog":
                    mcn = new AtogMR();
                    break;
                # endregion

                # region Auriok Bladewarden
                case "Auriok Bladewarden":
                    mcn = new AuriokBladewardenMR();
                    break;
                # endregion

                # region Auriok Steelshaper
                case "Auriok Steelshaper":
                    mcn = new AuriokSteelshaperMR();
                    break;
                # endregion

                # region Auriok Transfixer
                case "Auriok Transfixer":
                    mcn = new AuriokTransfixerMR();
                    break;
                # endregion

                # region Awe Strike
                case "Awe Strike":
                    mcn = new AweStrikeMR();
                    break;
                # endregion

                # region Banshee's Blade
                case "Banshee's Blade":
                    mcn = new BansheesBladeMR();
                    break;
                # endregion

                # region Barter in Blood
                case "Barter in Blood":
                    mcn = new BarterinBloodMR();
                    break;
                # endregion

                # region Battlegrowth
                case "Battlegrowth":
                    mcn = new BattlegrowthMR();
                    break;
                # endregion

                # region Betrayal of Flesh
                case "Betrayal of Flesh":
                    mcn = new BetrayalofFleshMR();
                    break;
                # endregion

                # region Blinding Beam
                case "Blinding Beam":
                    mcn = new BlindingBeamMR();
                    break;
                # endregion

                # region Blinkmoth Urn
                case "Blinkmoth Urn":
                    mcn = new BlinkmothUrnMR();
                    break;
                # endregion

                # region Blinkmoth Well
                case "Blinkmoth Well":
                    mcn = new BlinkmothWellMR();
                    break;
                # endregion

                # region Bloodscent
                case "Bloodscent":
                    mcn = new BloodscentMR();
                    break;
                # endregion

                # region Bonesplitter
                case "Bonesplitter":
                    mcn = new BonesplitterMR();
                    break;
                # endregion

                # region Bosh, Iron Golem
                case "Bosh, Iron Golem":
                    mcn = new BoshIronGolemMR();
                    break;
                # endregion

                # region Bottle Gnomes
                case "Bottle Gnomes":
                    mcn = new BottleGnomesMR();
                    break;
                # endregion

                # region Broodstar
                case "Broodstar":
                    mcn = new BroodstarMR();
                    break;
                # endregion

                # region Brown Ouphe
                case "Brown Ouphe":
                    mcn = new BrownOupheMR();
                    break;
                # endregion

                # region Cathodion
                case "Cathodion":
                    mcn = new CathodionMR();
                    break;
                # endregion

                # region Chalice of the Void
                case "Chalice of the Void":
                    mcn = new ChaliceoftheVoidMR();
                    break;
                # endregion

                # region Chimney Imp
                case "Chimney Imp":
                    mcn = new ChimneyImpMR();
                    break;
                # endregion

                # region Chromatic Sphere
                case "Chromatic Sphere":
                    mcn = new ChromaticSphereMR();
                    break;
                # endregion

                # region Chrome Mox
                case "Chrome Mox":
                    mcn = new ChromeMoxMR();
                    break;
                # endregion

                # region Clockwork Beetle
                case "Clockwork Beetle":
                    mcn = new ClockworkBeetleMR();
                    break;
                # endregion

                # region Clockwork Condor
                case "Clockwork Condor":
                    mcn = new ClockworkCondorMR();
                    break;
                # endregion

                # region Clockwork Dragon
                case "Clockwork Dragon":
                    mcn = new ClockworkDragonMR();
                    break;
                # endregion

                # region Clockwork Vorrac
                case "Clockwork Vorrac":
                    mcn = new ClockworkVorracMR();
                    break;
                # endregion

                # region Cloudpost
                case "Cloudpost":
                    mcn = new CloudpostMR();
                    break;
                # endregion

                # region Cobalt Golem
                case "Cobalt Golem":
                    mcn = new CobaltGolemMR();
                    break;
                # endregion

                # region Confusion in the Ranks
                case "Confusion in the Ranks":
                    mcn = new ConfusionintheRanksMR();
                    break;
                # endregion

                # region Consume Spirit
                case "Consume Spirit":
                    mcn = new ConsumeSpiritMR();
                    break;
                # endregion

                # region Contaminated Bond
                case "Contaminated Bond":
                    mcn = new ContaminatedBondMR();
                    break;
                # endregion

                # region Copper Myr
                case "Copper Myr":
                    mcn = new CopperMyrMR();
                    break;
                # endregion

                # region Copperhoof Vorrac
                case "Copperhoof Vorrac":
                    mcn = new CopperhoofVorracMR();
                    break;
                # endregion

                # region Creeping Mold
                case "Creeping Mold":
                    mcn = new CreepingMoldMR();
                    break;
                # endregion

                # region Crystal Shard
                case "Crystal Shard":
                    mcn = new CrystalShardMR();
                    break;
                # endregion

                # region Culling Scales
                case "Culling Scales":
                    mcn = new CullingScalesMR();
                    break;
                # endregion

                # region Damping Matrix
                case "Damping Matrix":
                    mcn = new DampingMatrixMR();
                    break;
                # endregion

                # region Dead-Iron Sledge
                case "Dead-Iron Sledge":
                    mcn = new DeadIronSledgeMR();
                    break;
                # endregion

                # region Deconstruct
                case "Deconstruct":
                    mcn = new DeconstructMR();
                    break;
                # endregion

                # region Detonate
                case "Detonate":
                    mcn = new DetonateMR();
                    break;
                # endregion

                # region Disarm
                case "Disarm":
                    mcn = new DisarmMR();
                    break;
                # endregion

                # region Disciple of the Vault
                case "Disciple of the Vault":
                    mcn = new DiscipleoftheVaultMR();
                    break;
                # endregion

                # region Domineer
                case "Domineer":
                    mcn = new DomineerMR();
                    break;
                # endregion

                # region Dragon Blood
                case "Dragon Blood":
                    mcn = new DragonBloodMR();
                    break;
                # endregion

                # region Dream's Grip
                case "Dream's Grip":
                    mcn = new DreamsGripMR();
                    break;
                # endregion

                # region Dross Harvester
                case "Dross Harvester":
                    mcn = new DrossHarvesterMR();
                    break;
                # endregion

                # region Dross Prowler
                case "Dross Prowler":
                    mcn = new DrossProwlerMR();
                    break;
                # endregion

                # region Dross Scorpion
                case "Dross Scorpion":
                    mcn = new DrossScorpionMR();
                    break;
                # endregion

                # region Duplicant
                case "Duplicant":
                    mcn = new DuplicantMR();
                    break;
                # endregion

                # region Duskworker
                case "Duskworker":
                    mcn = new DuskworkerMR();
                    break;
                # endregion

                # region Electrostatic Bolt
                case "Electrostatic Bolt":
                    mcn = new ElectrostaticBoltMR();
                    break;
                # endregion

                # region Elf Replica
                case "Elf Replica":
                    mcn = new ElfReplicaMR();
                    break;
                # endregion

                # region Empyrial Plate
                case "Empyrial Plate":
                    mcn = new EmpyrialPlateMR();
                    break;
                # endregion

                # region Extraplanar Lens
                case "Extraplanar Lens":
                    mcn = new ExtraplanarLensMR();
                    break;
                # endregion

                # region Fabricate
                case "Fabricate":
                    mcn = new FabricateMR();
                    break;
                # endregion

                # region Fangren Hunter
                case "Fangren Hunter":
                    mcn = new FangrenHunterMR();
                    break;
                # endregion

                # region Farsight Mask
                case "Farsight Mask":
                    mcn = new FarsightMaskMR();
                    break;
                # endregion

                # region Fatespinner
                case "Fatespinner":
                    mcn = new FatespinnerMR();
                    break;
                # endregion

                # region Fiery Gambit
                case "Fiery Gambit":
                    mcn = new FieryGambitMR();
                    break;
                # endregion

                # region Fireshrieker
                case "Fireshrieker":
                    mcn = new FireshriekerMR();
                    break;
                # endregion

                # region Fists of the Anvil
                case "Fists of the Anvil":
                    mcn = new FistsoftheAnvilMR();
                    break;
                # endregion

                # region Flayed Nim
                case "Flayed Nim":
                    mcn = new FlayedNimMR();
                    break;
                # endregion

                //# region Forest 
                //case "Forest ":
                //mcn = new ForestMR();
                //break;
                //# endregion

                //# region Forest 
                //case "Forest ":
                //mcn = new ForestMR();
                //break;
                //# endregion

                //# region Forest 
                //case "Forest ":
                //mcn = new ForestMR();
                //break;
                //# endregion

                //# region Forest 
                //case "Forest ":
                //mcn = new ForestMR();
                //break;
                //# endregion

                # region Forge Armor
                case "Forge Armor":
                    mcn = new ForgeArmorMR();
                    break;
                # endregion

                # region Fractured Loyalty
                case "Fractured Loyalty":
                    mcn = new FracturedLoyaltyMR();
                    break;
                # endregion

                # region Frogmite
                case "Frogmite":
                    mcn = new FrogmiteMR();
                    break;
                # endregion

                # region Galvanic Key
                case "Galvanic Key":
                    mcn = new GalvanicKeyMR();
                    break;
                # endregion

                # region Gate to the AEther
                case "Gate to the AEther":
                    mcn = new GatetotheAEtherMR();
                    break;
                # endregion

                # region Gilded Lotus
                case "Gilded Lotus":
                    mcn = new GildedLotusMR();
                    break;
                # endregion

                # region Glimmervoid
                case "Glimmervoid":
                    mcn = new GlimmervoidMR();
                    break;
                # endregion

                # region Glissa Sunseeker
                case "Glissa Sunseeker":
                    mcn = new GlissaSunseekerMR();
                    break;
                # endregion

                # region Goblin Charbelcher
                case "Goblin Charbelcher":
                    mcn = new GoblinCharbelcherMR();
                    break;
                # endregion

                # region Goblin Dirigible
                case "Goblin Dirigible":
                    mcn = new GoblinDirigibleMR();
                    break;
                # endregion

                # region Goblin Replica
                case "Goblin Replica":
                    mcn = new GoblinReplicaMR();
                    break;
                # endregion

                # region Goblin Striker
                case "Goblin Striker":
                    mcn = new GoblinStrikerMR();
                    break;
                # endregion

                # region Goblin War Wagon
                case "Goblin War Wagon":
                    mcn = new GoblinWarWagonMR();
                    break;
                # endregion

                # region Gold Myr
                case "Gold Myr":
                    mcn = new GoldMyrMR();
                    break;
                # endregion

                # region Golem-Skin Gauntlets
                case "Golem-Skin Gauntlets":
                    mcn = new GolemSkinGauntletsMR();
                    break;
                # endregion

                # region Grab the Reins
                case "Grab the Reins":
                    mcn = new GrabtheReinsMR();
                    break;
                # endregion

                # region Granite Shard
                case "Granite Shard":
                    mcn = new GraniteShardMR();
                    break;
                # endregion

                # region Great Furnace
                case "Great Furnace":
                    mcn = new GreatFurnaceMR();
                    break;
                # endregion

                # region Grid Monitor
                case "Grid Monitor":
                    mcn = new GridMonitorMR();
                    break;
                # endregion

                # region Grim Reminder
                case "Grim Reminder":
                    mcn = new GrimReminderMR();
                    break;
                # endregion

                # region Groffskithur
                case "Groffskithur":
                    mcn = new GroffskithurMR();
                    break;
                # endregion

                # region Heartwood Shard
                case "Heartwood Shard":
                    mcn = new HeartwoodShardMR();
                    break;
                # endregion

                # region Hematite Golem
                case "Hematite Golem":
                    mcn = new HematiteGolemMR();
                    break;
                # endregion

                # region Hum of the Radix
                case "Hum of the Radix":
                    mcn = new HumoftheRadixMR();
                    break;
                # endregion

                //# region Icy Manipulator
                //case "Icy Manipulator":
                //mcn = new IcyManipulatorMR();
                //break;
                //# endregion

                # region Incite War
                case "Incite War":
                    mcn = new InciteWarMR();
                    break;
                # endregion

                # region Inertia Bubble
                case "Inertia Bubble":
                    mcn = new InertiaBubbleMR();
                    break;
                # endregion

                # region Iron Myr
                case "Iron Myr":
                    mcn = new IronMyrMR();
                    break;
                # endregion

                # region Irradiate
                case "Irradiate":
                    mcn = new IrradiateMR();
                    break;
                # endregion

                //# region Island 
                //case "Island ":
                //mcn = new IslandMR();
                //break;
                //# endregion

                //# region Island 
                //case "Island ":
                //mcn = new IslandMR();
                //break;
                //# endregion

                //# region Island 
                //case "Island ":
                //mcn = new IslandMR();
                //break;
                //# endregion

                //# region Island 
                //case "Island ":
                //mcn = new IslandMR();
                //break;
                //# endregion

                # region Isochron Scepter
                case "Isochron Scepter":
                    mcn = new IsochronScepterMR();
                    break;
                # endregion

                # region Jinxed Choker
                case "Jinxed Choker":
                    mcn = new JinxedChokerMR();
                    break;
                # endregion

                # region Journey of Discovery
                case "Journey of Discovery":
                    mcn = new JourneyofDiscoveryMR();
                    break;
                # endregion

                # region Krark-Clan Grunt
                case "Krark-Clan Grunt":
                    mcn = new KrarkClanGruntMR();
                    break;
                # endregion

                # region Krark-Clan Shaman
                case "Krark-Clan Shaman":
                    mcn = new KrarkClanShamanMR();
                    break;
                # endregion

                # region Krark's Thumb
                case "Krark's Thumb":
                    mcn = new KrarksThumbMR();
                    break;
                # endregion

                # region Leaden Myr
                case "Leaden Myr":
                    mcn = new LeadenMyrMR();
                    break;
                # endregion

                # region Leonin Abunas
                case "Leonin Abunas":
                    mcn = new LeoninAbunasMR();
                    break;
                # endregion

                # region Leonin Bladetrap
                case "Leonin Bladetrap":
                    mcn = new LeoninBladetrapMR();
                    break;
                # endregion

                # region Leonin Den-Guard
                case "Leonin Den-Guard":
                    mcn = new LeoninDenGuardMR();
                    break;
                # endregion

                # region Leonin Elder
                case "Leonin Elder":
                    mcn = new LeoninElderMR();
                    break;
                # endregion

                # region Leonin Scimitar
                case "Leonin Scimitar":
                    mcn = new LeoninScimitarMR();
                    break;
                # endregion

                # region Leonin Skyhunter
                case "Leonin Skyhunter":
                    mcn = new LeoninSkyhunterMR();
                    break;
                # endregion

                # region Leonin Sun Standard
                case "Leonin Sun Standard":
                    mcn = new LeoninSunStandardMR();
                    break;
                # endregion

                # region Leveler
                case "Leveler":
                    mcn = new LevelerMR();
                    break;
                # endregion

                # region Liar's Pendulum
                case "Liar's Pendulum":
                    mcn = new LiarsPendulumMR();
                    break;
                # endregion

                # region Lifespark Spellbomb
                case "Lifespark Spellbomb":
                    mcn = new LifesparkSpellbombMR();
                    break;
                # endregion

                # region Lightning Coils
                case "Lightning Coils":
                    mcn = new LightningCoilsMR();
                    break;
                # endregion

                # region Lightning Greaves
                case "Lightning Greaves":
                    mcn = new LightningGreavesMR();
                    break;
                # endregion

                # region Living Hive
                case "Living Hive":
                    mcn = new LivingHiveMR();
                    break;
                # endregion

                # region Lodestone Myr
                case "Lodestone Myr":
                    mcn = new LodestoneMyrMR();
                    break;
                # endregion

                # region Looming Hoverguard
                case "Looming Hoverguard":
                    mcn = new LoomingHoverguardMR();
                    break;
                # endregion

                # region Loxodon Mender
                case "Loxodon Mender":
                    mcn = new LoxodonMenderMR();
                    break;
                # endregion

                # region Loxodon Peacekeeper
                case "Loxodon Peacekeeper":
                    mcn = new LoxodonPeacekeeperMR();
                    break;
                # endregion

                # region Loxodon Punisher
                case "Loxodon Punisher":
                    mcn = new LoxodonPunisherMR();
                    break;
                # endregion

                # region Loxodon Warhammer
                case "Loxodon Warhammer":
                    mcn = new LoxodonWarhammerMR();
                    break;
                # endregion

                # region Lumengrid Augur
                case "Lumengrid Augur":
                    mcn = new LumengridAugurMR();
                    break;
                # endregion

                # region Lumengrid Sentinel
                case "Lumengrid Sentinel":
                    mcn = new LumengridSentinelMR();
                    break;
                # endregion

                # region Lumengrid Warden
                case "Lumengrid Warden":
                    mcn = new LumengridWardenMR();
                    break;
                # endregion

                # region Luminous Angel
                case "Luminous Angel":
                    mcn = new LuminousAngelMR();
                    break;
                # endregion

                # region Malachite Golem
                case "Malachite Golem":
                    mcn = new MalachiteGolemMR();
                    break;
                # endregion

                # region March of the Machines
                case "March of the Machines":
                    mcn = new MarchoftheMachinesMR();
                    break;
                # endregion

                # region Mask of Memory
                case "Mask of Memory":
                    mcn = new MaskofMemoryMR();
                    break;
                # endregion

                # region Mass Hysteria
                case "Mass Hysteria":
                    mcn = new MassHysteriaMR();
                    break;
                # endregion

                # region Megatog
                case "Megatog":
                    mcn = new MegatogMR();
                    break;
                # endregion

                # region Mesmeric Orb
                case "Mesmeric Orb":
                    mcn = new MesmericOrbMR();
                    break;
                # endregion

                # region Mind's Eye
                case "Mind's Eye":
                    mcn = new MindsEyeMR();
                    break;
                # endregion

                # region Mindslaver
                case "Mindslaver":
                    mcn = new MindslaverMR();
                    break;
                # endregion

                # region Mindstorm Crown
                case "Mindstorm Crown":
                    mcn = new MindstormCrownMR();
                    break;
                # endregion

                # region Mirror Golem
                case "Mirror Golem":
                    mcn = new MirrorGolemMR();
                    break;
                # endregion

                # region Molder Slug
                case "Molder Slug":
                    mcn = new MolderSlugMR();
                    break;
                # endregion

                # region Molten Rain
                case "Molten Rain":
                    mcn = new MoltenRainMR();
                    break;
                # endregion

                # region Moriok Scavenger
                case "Moriok Scavenger":
                    mcn = new MoriokScavengerMR();
                    break;
                # endregion

                //# region Mountain 
                //case "Mountain ":
                //mcn = new MountainMR();
                //break;
                //# endregion

                //# region Mountain 
                //case "Mountain ":
                //mcn = new MountainMR();
                //break;
                //# endregion

                //# region Mountain 
                //case "Mountain ":
                //mcn = new MountainMR();
                //break;
                //# endregion

                //# region Mountain 
                //case "Mountain ":
                //mcn = new MountainMR();
                //break;
                //# endregion

                # region Mourner's Shield
                case "Mourner's Shield":
                    mcn = new MournersShieldMR();
                    break;
                # endregion

                # region Myr Adapter
                case "Myr Adapter":
                    mcn = new MyrAdapterMR();
                    break;
                # endregion

                # region Myr Enforcer
                case "Myr Enforcer":
                    mcn = new MyrEnforcerMR();
                    break;
                # endregion

                # region Myr Incubator
                case "Myr Incubator":
                    mcn = new MyrIncubatorMR();
                    break;
                # endregion

                # region Myr Mindservant
                case "Myr Mindservant":
                    mcn = new MyrMindservantMR();
                    break;
                # endregion

                # region Myr Prototype
                case "Myr Prototype":
                    mcn = new MyrPrototypeMR();
                    break;
                # endregion

                # region Myr Retriever
                case "Myr Retriever":
                    mcn = new MyrRetrieverMR();
                    break;
                # endregion

                # region Necrogen Mists
                case "Necrogen Mists":
                    mcn = new NecrogenMistsMR();
                    break;
                # endregion

                # region Necrogen Spellbomb
                case "Necrogen Spellbomb":
                    mcn = new NecrogenSpellbombMR();
                    break;
                # endregion

                # region Needlebug
                case "Needlebug":
                    mcn = new NeedlebugMR();
                    break;
                # endregion

                # region Neurok Familiar
                case "Neurok Familiar":
                    mcn = new NeurokFamiliarMR();
                    break;
                # endregion

                # region Neurok Hoversail
                case "Neurok Hoversail":
                    mcn = new NeurokHoversailMR();
                    break;
                # endregion

                # region Neurok Spy
                case "Neurok Spy":
                    mcn = new NeurokSpyMR();
                    break;
                # endregion

                # region Nightmare Lash
                case "Nightmare Lash":
                    mcn = new NightmareLashMR();
                    break;
                # endregion

                # region Nim Devourer
                case "Nim Devourer":
                    mcn = new NimDevourerMR();
                    break;
                # endregion

                # region Nim Lasher
                case "Nim Lasher":
                    mcn = new NimLasherMR();
                    break;
                # endregion

                # region Nim Replica
                case "Nim Replica":
                    mcn = new NimReplicaMR();
                    break;
                # endregion

                # region Nim Shambler
                case "Nim Shambler":
                    mcn = new NimShamblerMR();
                    break;
                # endregion

                # region Nim Shrieker
                case "Nim Shrieker":
                    mcn = new NimShriekerMR();
                    break;
                # endregion

                # region Nuisance Engine
                case "Nuisance Engine":
                    mcn = new NuisanceEngineMR();
                    break;
                # endregion

                # region Oblivion Stone
                case "Oblivion Stone":
                    mcn = new OblivionStoneMR();
                    break;
                # endregion

                # region Ogre Leadfoot
                case "Ogre Leadfoot":
                    mcn = new OgreLeadfootMR();
                    break;
                # endregion

                # region Omega Myr
                case "Omega Myr":
                    mcn = new OmegaMyrMR();
                    break;
                # endregion

                # region One Dozen Eyes
                case "One Dozen Eyes":
                    mcn = new OneDozenEyesMR();
                    break;
                # endregion

                # region Ornithopter
                case "Ornithopter":
                    mcn = new OrnithopterMR();
                    break;
                # endregion

                # region Override
                case "Override":
                    mcn = new OverrideMR();
                    break;
                # endregion

                # region Pearl Shard
                case "Pearl Shard":
                    mcn = new PearlShardMR();
                    break;
                # endregion

                # region Pentavus
                case "Pentavus":
                    mcn = new PentavusMR();
                    break;
                # endregion

                # region Pewter Golem
                case "Pewter Golem":
                    mcn = new PewterGolemMR();
                    break;
                # endregion

                //# region Plains 
                //case "Plains ":
                //mcn = new PlainsMR();
                //break;
                //# endregion

                //# region Plains 
                //case "Plains ":
                //mcn = new PlainsMR();
                //break;
                //# endregion

                //# region Plains 
                //case "Plains ":
                //mcn = new PlainsMR();
                //break;
                //# endregion

                //# region Plains 
                //case "Plains ":
                //mcn = new PlainsMR();
                //break;
                //# endregion

                # region Plated Slagwurm
                case "Plated Slagwurm":
                    mcn = new PlatedSlagwurmMR();
                    break;
                # endregion

                # region Platinum Angel
                case "Platinum Angel":
                    mcn = new PlatinumAngelMR();
                    break;
                # endregion

                # region Power Conduit
                case "Power Conduit":
                    mcn = new PowerConduitMR();
                    break;
                # endregion

                # region Predator's Strike
                case "Predator's Strike":
                    mcn = new PredatorsStrikeMR();
                    break;
                # endregion

                # region Promise of Power
                case "Promise of Power":
                    mcn = new PromiseofPowerMR();
                    break;
                # endregion

                # region Proteus Staff
                case "Proteus Staff":
                    mcn = new ProteusStaffMR();
                    break;
                # endregion

                # region Psychic Membrane
                case "Psychic Membrane":
                    mcn = new PsychicMembraneMR();
                    break;
                # endregion

                # region Psychogenic Probe
                case "Psychogenic Probe":
                    mcn = new PsychogenicProbeMR();
                    break;
                # endregion

                # region Pyrite Spellbomb
                case "Pyrite Spellbomb":
                    mcn = new PyriteSpellbombMR();
                    break;
                # endregion

                # region Quicksilver Elemental
                case "Quicksilver Elemental":
                    mcn = new QuicksilverElementalMR();
                    break;
                # endregion

                # region Quicksilver Fountain
                case "Quicksilver Fountain":
                    mcn = new QuicksilverFountainMR();
                    break;
                # endregion

                # region Raise the Alarm
                case "Raise the Alarm":
                    mcn = new RaisetheAlarmMR();
                    break;
                # endregion

                # region Razor Barrier
                case "Razor Barrier":
                    mcn = new RazorBarrierMR();
                    break;
                # endregion

                # region Regress
                case "Regress":
                    mcn = new RegressMR();
                    break;
                # endregion

                # region Reiver Demon
                case "Reiver Demon":
                    mcn = new ReiverDemonMR();
                    break;
                # endregion

                # region Relic Bane
                case "Relic Bane":
                    mcn = new RelicBaneMR();
                    break;
                # endregion

                # region Roar of the Kha
                case "Roar of the Kha":
                    mcn = new RoaroftheKhaMR();
                    break;
                # endregion

                # region Rule of Law
                case "Rule of Law":
                    mcn = new RuleofLawMR();
                    break;
                # endregion

                # region Rust Elemental
                case "Rust Elemental":
                    mcn = new RustElementalMR();
                    break;
                # endregion

                # region Rustmouth Ogre
                case "Rustmouth Ogre":
                    mcn = new RustmouthOgreMR();
                    break;
                # endregion

                # region Rustspore Ram
                case "Rustspore Ram":
                    mcn = new RustsporeRamMR();
                    break;
                # endregion

                # region Scale of Chiss-Goria
                case "Scale of Chiss-Goria":
                    mcn = new ScaleofChissGoriaMR();
                    break;
                # endregion

                # region Scrabbling Claws
                case "Scrabbling Claws":
                    mcn = new ScrabblingClawsMR();
                    break;
                # endregion

                # region Sculpting Steel
                case "Sculpting Steel":
                    mcn = new SculptingSteelMR();
                    break;
                # endregion

                # region Scythe of the Wretched
                case "Scythe of the Wretched":
                    mcn = new ScytheoftheWretchedMR();
                    break;
                # endregion

                # region Seat of the Synod
                case "Seat of the Synod":
                    mcn = new SeatoftheSynodMR();
                    break;
                # endregion

                # region Second Sunrise
                case "Second Sunrise":
                    mcn = new SecondSunriseMR();
                    break;
                # endregion

                # region Seething Song
                case "Seething Song":
                    mcn = new SeethingSongMR();
                    break;
                # endregion

                # region Serum Tank
                case "Serum Tank":
                    mcn = new SerumTankMR();
                    break;
                # endregion

                # region Shared Fate
                case "Shared Fate":
                    mcn = new SharedFateMR();
                    break;
                # endregion

                //# region Shatter
                //case "Shatter":
                //mcn = new ShatterMR();
                //break;
                //# endregion

                # region Shrapnel Blast
                case "Shrapnel Blast":
                    mcn = new ShrapnelBlastMR();
                    break;
                # endregion

                # region Silver Myr
                case "Silver Myr":
                    mcn = new SilverMyrMR();
                    break;
                # endregion

                # region Skeleton Shard
                case "Skeleton Shard":
                    mcn = new SkeletonShardMR();
                    break;
                # endregion

                # region Skyhunter Cub
                case "Skyhunter Cub":
                    mcn = new SkyhunterCubMR();
                    break;
                # endregion

                # region Skyhunter Patrol
                case "Skyhunter Patrol":
                    mcn = new SkyhunterPatrolMR();
                    break;
                # endregion

                # region Slagwurm Armor
                case "Slagwurm Armor":
                    mcn = new SlagwurmArmorMR();
                    break;
                # endregion

                # region Slith Ascendant
                case "Slith Ascendant":
                    mcn = new SlithAscendantMR();
                    break;
                # endregion

                # region Slith Bloodletter
                case "Slith Bloodletter":
                    mcn = new SlithBloodletterMR();
                    break;
                # endregion

                # region Slith Firewalker
                case "Slith Firewalker":
                    mcn = new SlithFirewalkerMR();
                    break;
                # endregion

                # region Slith Predator
                case "Slith Predator":
                    mcn = new SlithPredatorMR();
                    break;
                # endregion

                # region Slith Strider
                case "Slith Strider":
                    mcn = new SlithStriderMR();
                    break;
                # endregion

                # region Solar Tide
                case "Solar Tide":
                    mcn = new SolarTideMR();
                    break;
                # endregion

                # region Soldier Replica
                case "Soldier Replica":
                    mcn = new SoldierReplicaMR();
                    break;
                # endregion

                # region Solemn Simulacrum
                case "Solemn Simulacrum":
                    mcn = new SolemnSimulacrumMR();
                    break;
                # endregion

                # region Somber Hoverguard
                case "Somber Hoverguard":
                    mcn = new SomberHoverguardMR();
                    break;
                # endregion

                # region Soul Foundry
                case "Soul Foundry":
                    mcn = new SoulFoundryMR();
                    break;
                # endregion

                # region Soul Nova
                case "Soul Nova":
                    mcn = new SoulNovaMR();
                    break;
                # endregion

                # region Spellweaver Helix
                case "Spellweaver Helix":
                    mcn = new SpellweaverHelixMR();
                    break;
                # endregion

                # region Sphere of Purity
                case "Sphere of Purity":
                    mcn = new SphereofPurityMR();
                    break;
                # endregion

                # region Spikeshot Goblin
                case "Spikeshot Goblin":
                    mcn = new SpikeshotGoblinMR();
                    break;
                # endregion

                # region Spoils of the Vault
                case "Spoils of the Vault":
                    mcn = new SpoilsoftheVaultMR();
                    break;
                # endregion

                # region Stalking Stones
                case "Stalking Stones":
                    mcn = new StalkingStonesMR();
                    break;
                # endregion

                # region Steel Wall
                case "Steel Wall":
                    mcn = new SteelWallMR();
                    break;
                # endregion

                # region Sun Droplet
                case "Sun Droplet":
                    mcn = new SunDropletMR();
                    break;
                # endregion

                # region Sunbeam Spellbomb
                case "Sunbeam Spellbomb":
                    mcn = new SunbeamSpellbombMR();
                    break;
                # endregion

                //# region Swamp 
                //case "Swamp ":
                //mcn = new SwampMR();
                //break;
                //# endregion

                //# region Swamp 
                //case "Swamp ":
                //mcn = new SwampMR();
                //break;
                //# endregion

                //# region Swamp 
                //case "Swamp ":
                //mcn = new SwampMR();
                //break;
                //# endregion

                //# region Swamp 
                //case "Swamp ":
                //mcn = new SwampMR();
                //break;
                //# endregion

                # region Sword of Kaldra
                case "Sword of Kaldra":
                    mcn = new SwordofKaldraMR();
                    break;
                # endregion

                # region Sylvan Scrying
                case "Sylvan Scrying":
                    mcn = new SylvanScryingMR();
                    break;
                # endregion

                # region Synod Sanctum
                case "Synod Sanctum":
                    mcn = new SynodSanctumMR();
                    break;
                # endregion

                # region Taj-Nar Swordsmith
                case "Taj-Nar Swordsmith":
                    mcn = new TajNarSwordsmithMR();
                    break;
                # endregion

                # region Talisman of Dominance
                case "Talisman of Dominance":
                    mcn = new TalismanofDominanceMR();
                    break;
                # endregion

                # region Talisman of Impulse
                case "Talisman of Impulse":
                    mcn = new TalismanofImpulseMR();
                    break;
                # endregion

                # region Talisman of Indulgence
                case "Talisman of Indulgence":
                    mcn = new TalismanofIndulgenceMR();
                    break;
                # endregion

                # region Talisman of Progress
                case "Talisman of Progress":
                    mcn = new TalismanofProgressMR();
                    break;
                # endregion

                # region Talisman of Unity
                case "Talisman of Unity":
                    mcn = new TalismanofUnityMR();
                    break;
                # endregion

                # region Tanglebloom
                case "Tanglebloom":
                    mcn = new TanglebloomMR();
                    break;
                # endregion

                # region Tangleroot
                case "Tangleroot":
                    mcn = new TanglerootMR();
                    break;
                # endregion

                # region Tel-Jilad Archers
                case "Tel-Jilad Archers":
                    mcn = new TelJiladArchersMR();
                    break;
                # endregion

                # region Tel-Jilad Chosen
                case "Tel-Jilad Chosen":
                    mcn = new TelJiladChosenMR();
                    break;
                # endregion

                # region Tel-Jilad Exile
                case "Tel-Jilad Exile":
                    mcn = new TelJiladExileMR();
                    break;
                # endregion

                # region Tel-Jilad Stylus
                case "Tel-Jilad Stylus":
                    mcn = new TelJiladStylusMR();
                    break;
                # endregion

                # region Tempest of Light
                case "Tempest of Light":
                    mcn = new TempestofLightMR();
                    break;
                # endregion

                # region Temporal Cascade
                case "Temporal Cascade":
                    mcn = new TemporalCascadeMR();
                    break;
                # endregion

                //# region Terror
                //case "Terror":
                //mcn = new TerrorMR();
                //break;
                //# endregion

                # region Thirst for Knowledge
                case "Thirst for Knowledge":
                    mcn = new ThirstforKnowledgeMR();
                    break;
                # endregion

                # region Thought Prison
                case "Thought Prison":
                    mcn = new ThoughtPrisonMR();
                    break;
                # endregion

                # region Thoughtcast
                case "Thoughtcast":
                    mcn = new ThoughtcastMR();
                    break;
                # endregion

                # region Timesifter
                case "Timesifter":
                    mcn = new TimesifterMR();
                    break;
                # endregion

                # region Titanium Golem
                case "Titanium Golem":
                    mcn = new TitaniumGolemMR();
                    break;
                # endregion

                # region Tooth and Nail
                case "Tooth and Nail":
                    mcn = new ToothandNailMR();
                    break;
                # endregion

                # region Tooth of Chiss-Goria
                case "Tooth of Chiss-Goria":
                    mcn = new ToothofChissGoriaMR();
                    break;
                # endregion

                # region Tower of Champions
                case "Tower of Champions":
                    mcn = new TowerofChampionsMR();
                    break;
                # endregion

                # region Tower of Eons
                case "Tower of Eons":
                    mcn = new TowerofEonsMR();
                    break;
                # endregion

                # region Tower of Fortunes
                case "Tower of Fortunes":
                    mcn = new TowerofFortunesMR();
                    break;
                # endregion

                # region Tower of Murmurs
                case "Tower of Murmurs":
                    mcn = new TowerofMurmursMR();
                    break;
                # endregion

                # region Trash for Treasure
                case "Trash for Treasure":
                    mcn = new TrashforTreasureMR();
                    break;
                # endregion

                # region Tree of Tales
                case "Tree of Tales":
                    mcn = new TreeofTalesMR();
                    break;
                # endregion

                # region Triskelion
                case "Triskelion":
                    mcn = new TriskelionMR();
                    break;
                # endregion

                # region Troll Ascetic
                case "Troll Ascetic":
                    mcn = new TrollAsceticMR();
                    break;
                # endregion

                # region Trolls of Tel-Jilad
                case "Trolls of Tel-Jilad":
                    mcn = new TrollsofTelJiladMR();
                    break;
                # endregion

                # region Turn to Dust
                case "Turn to Dust":
                    mcn = new TurntoDustMR();
                    break;
                # endregion

                # region Vault of Whispers
                case "Vault of Whispers":
                    mcn = new VaultofWhispersMR();
                    break;
                # endregion

                # region Vedalken Archmage
                case "Vedalken Archmage":
                    mcn = new VedalkenArchmageMR();
                    break;
                # endregion

                # region Vermiculos
                case "Vermiculos":
                    mcn = new VermiculosMR();
                    break;
                # endregion

                # region Viridian Joiner
                case "Viridian Joiner":
                    mcn = new ViridianJoinerMR();
                    break;
                # endregion

                # region Viridian Longbow
                case "Viridian Longbow":
                    mcn = new ViridianLongbowMR();
                    break;
                # endregion

                # region Viridian Shaman
                case "Viridian Shaman":
                    mcn = new ViridianShamanMR();
                    break;
                # endregion

                # region Vorrac Battlehorns
                case "Vorrac Battlehorns":
                    mcn = new VorracBattlehornsMR();
                    break;
                # endregion

                # region Vulshok Battlegear
                case "Vulshok Battlegear":
                    mcn = new VulshokBattlegearMR();
                    break;
                # endregion

                # region Vulshok Battlemaster
                case "Vulshok Battlemaster":
                    mcn = new VulshokBattlemasterMR();
                    break;
                # endregion

                # region Vulshok Berserker
                case "Vulshok Berserker":
                    mcn = new VulshokBerserkerMR();
                    break;
                # endregion

                # region Vulshok Gauntlets
                case "Vulshok Gauntlets":
                    mcn = new VulshokGauntletsMR();
                    break;
                # endregion

                # region Wail of the Nim
                case "Wail of the Nim":
                    mcn = new WailoftheNimMR();
                    break;
                # endregion

                # region Wall of Blood
                case "Wall of Blood":
                    mcn = new WallofBloodMR();
                    break;
                # endregion

                # region Wanderguard Sentry
                case "Wanderguard Sentry":
                    mcn = new WanderguardSentryMR();
                    break;
                # endregion

                # region War Elemental
                case "War Elemental":
                    mcn = new WarElementalMR();
                    break;
                # endregion

                # region Welding Jar
                case "Welding Jar":
                    mcn = new WeldingJarMR();
                    break;
                # endregion

                # region Wizard Replica
                case "Wizard Replica":
                    mcn = new WizardReplicaMR();
                    break;
                # endregion

                # region Woebearer
                case "Woebearer":
                    mcn = new WoebearerMR();
                    break;
                # endregion

                # region Worldslayer
                case "Worldslayer":
                    mcn = new WorldslayerMR();
                    break;
                # endregion

                # region Wrench Mind
                case "Wrench Mind":
                    mcn = new WrenchMindMR();
                    break;
                # endregion

                # region Wurmskin Forger
                case "Wurmskin Forger":
                    mcn = new WurmskinForgerMR();
                    break;
                # endregion

                # region Yotian Soldier
                case "Yotian Soldier":
                    mcn = new YotianSoldierMR();
                    break;
                # endregion


                # endregion

                # region Lorwyn
                # region Adder-Staff Boggart
                case "Adder-Staff Boggart":
                    mcn = new AdderStaffBoggartLRW();
                    break;
                # endregion

                # region AEthersnipe
                case "AEthersnipe":
                    mcn = new AEthersnipeLRW();
                    break;
                # endregion

                # region Ajani Goldmane
                case "Ajani Goldmane":
                    mcn = new AjaniGoldmaneLRW();
                    break;
                # endregion

                # region Amoeboid Changeling
                case "Amoeboid Changeling":
                    mcn = new AmoeboidChangelingLRW();
                    break;
                # endregion

                # region Ancient Amphitheater
                case "Ancient Amphitheater":
                    mcn = new AncientAmphitheaterLRW();
                    break;
                # endregion

                # region Aquitect's Will
                case "Aquitect's Will":
                    mcn = new AquitectsWillLRW();
                    break;
                # endregion

                # region Arbiter of Knollridge
                case "Arbiter of Knollridge":
                    mcn = new ArbiterofKnollridgeLRW();
                    break;
                # endregion

                # region Ashling the Pilgrim
                case "Ashling the Pilgrim":
                    mcn = new AshlingthePilgrimLRW();
                    break;
                # endregion

                # region Ashling's Prerogative
                case "Ashling's Prerogative":
                    mcn = new AshlingsPrerogativeLRW();
                    break;
                # endregion

                # region Auntie's Hovel
                case "Auntie's Hovel":
                    mcn = new AuntiesHovelLRW();
                    break;
                # endregion

                # region Austere Command
                case "Austere Command":
                    mcn = new AustereCommandLRW();
                    break;
                # endregion

                # region Avian Changeling
                case "Avian Changeling":
                    mcn = new AvianChangelingLRW();
                    break;
                # endregion

                # region Axegrinder Giant
                case "Axegrinder Giant":
                    mcn = new AxegrinderGiantLRW();
                    break;
                # endregion

                # region Battle Mastery
                case "Battle Mastery":
                    mcn = new BattleMasteryLRW();
                    break;
                # endregion

                # region Battlewand Oak
                case "Battlewand Oak":
                    mcn = new BattlewandOakLRW();
                    break;
                # endregion

                # region Benthicore
                case "Benthicore":
                    mcn = new BenthicoreLRW();
                    break;
                # endregion

                # region Black Poplar Shaman
                case "Black Poplar Shaman":
                    mcn = new BlackPoplarShamanLRW();
                    break;
                # endregion

                # region Blades of Velis Vel
                case "Blades of Velis Vel":
                    mcn = new BladesofVelisVelLRW();
                    break;
                # endregion

                # region Blind-Spot Giant
                case "Blind-Spot Giant":
                    mcn = new BlindSpotGiantLRW();
                    break;
                # endregion

                # region Bog Hoodlums
                case "Bog Hoodlums":
                    mcn = new BogHoodlumsLRW();
                    break;
                # endregion

                # region Boggart Birth Rite
                case "Boggart Birth Rite":
                    mcn = new BoggartBirthRiteLRW();
                    break;
                # endregion

                # region Boggart Forager
                case "Boggart Forager":
                    mcn = new BoggartForagerLRW();
                    break;
                # endregion

                # region Boggart Harbinger
                case "Boggart Harbinger":
                    mcn = new BoggartHarbingerLRW();
                    break;
                # endregion

                # region Boggart Loggers
                case "Boggart Loggers":
                    mcn = new BoggartLoggersLRW();
                    break;
                # endregion

                # region Boggart Mob
                case "Boggart Mob":
                    mcn = new BoggartMobLRW();
                    break;
                # endregion

                # region Boggart Shenanigans
                case "Boggart Shenanigans":
                    mcn = new BoggartShenanigansLRW();
                    break;
                # endregion

                # region Boggart Sprite-Chaser
                case "Boggart Sprite-Chaser":
                    mcn = new BoggartSpriteChaserLRW();
                    break;
                # endregion

                # region Bog-Strider Ash
                case "Bog-Strider Ash":
                    mcn = new BogStriderAshLRW();
                    break;
                # endregion

                # region Briarhorn
                case "Briarhorn":
                    mcn = new BriarhornLRW();
                    break;
                # endregion

                # region Brigid, Hero of Kinsbaile
                case "Brigid, Hero of Kinsbaile":
                    mcn = new BrigidHeroofKinsbaileLRW();
                    break;
                # endregion

                # region Brion Stoutarm
                case "Brion Stoutarm":
                    mcn = new BrionStoutarmLRW();
                    break;
                # endregion

                # region Broken Ambitions
                case "Broken Ambitions":
                    mcn = new BrokenAmbitionsLRW();
                    break;
                # endregion

                # region Burrenton Forge-Tender
                case "Burrenton Forge-Tender":
                    mcn = new BurrentonForgeTenderLRW();
                    break;
                # endregion

                # region Cairn Wanderer
                case "Cairn Wanderer":
                    mcn = new CairnWandererLRW();
                    break;
                # endregion

                # region Captivating Glance
                case "Captivating Glance":
                    mcn = new CaptivatingGlanceLRW();
                    break;
                # endregion

                # region Caterwauling Boggart
                case "Caterwauling Boggart":
                    mcn = new CaterwaulingBoggartLRW();
                    break;
                # endregion

                # region Ceaseless Searblades
                case "Ceaseless Searblades":
                    mcn = new CeaselessSearbladesLRW();
                    break;
                # endregion

                # region Cenn's Heir
                case "Cenn's Heir":
                    mcn = new CennsHeirLRW();
                    break;
                # endregion

                # region Chandra Nalaar
                case "Chandra Nalaar":
                    mcn = new ChandraNalaarLRW();
                    break;
                # endregion

                # region Changeling Berserker
                case "Changeling Berserker":
                    mcn = new ChangelingBerserkerLRW();
                    break;
                # endregion

                # region Changeling Hero
                case "Changeling Hero":
                    mcn = new ChangelingHeroLRW();
                    break;
                # endregion

                # region Changeling Titan
                case "Changeling Titan":
                    mcn = new ChangelingTitanLRW();
                    break;
                # endregion

                # region Cloudcrown Oak
                case "Cloudcrown Oak":
                    mcn = new CloudcrownOakLRW();
                    break;
                # endregion

                # region Cloudgoat Ranger
                case "Cloudgoat Ranger":
                    mcn = new CloudgoatRangerLRW();
                    break;
                # endregion

                # region Cloudthresher
                case "Cloudthresher":
                    mcn = new CloudthresherLRW();
                    break;
                # endregion

                # region Colfenor's Plans
                case "Colfenor's Plans":
                    mcn = new ColfenorsPlansLRW();
                    break;
                # endregion

                # region Colfenor's Urn
                case "Colfenor's Urn":
                    mcn = new ColfenorsUrnLRW();
                    break;
                # endregion

                # region Consuming Bonfire
                case "Consuming Bonfire":
                    mcn = new ConsumingBonfireLRW();
                    break;
                # endregion

                # region Crib Swap
                case "Crib Swap":
                    mcn = new CribSwapLRW();
                    break;
                # endregion

                # region Crush Underfoot
                case "Crush Underfoot":
                    mcn = new CrushUnderfootLRW();
                    break;
                # endregion

                # region Cryptic Command
                case "Cryptic Command":
                    mcn = new CrypticCommandLRW();
                    break;
                # endregion

                # region Dauntless Dourbark
                case "Dauntless Dourbark":
                    mcn = new DauntlessDourbarkLRW();
                    break;
                # endregion

                # region Dawnfluke
                case "Dawnfluke":
                    mcn = new DawnflukeLRW();
                    break;
                # endregion

                # region Deathrender
                case "Deathrender":
                    mcn = new DeathrenderLRW();
                    break;
                # endregion

                # region Deeptread Merrow
                case "Deeptread Merrow":
                    mcn = new DeeptreadMerrowLRW();
                    break;
                # endregion

                # region Dolmen Gate
                case "Dolmen Gate":
                    mcn = new DolmenGateLRW();
                    break;
                # endregion

                # region Doran, the Siege Tower
                case "Doran, the Siege Tower":
                    mcn = new DorantheSiegeTowerLRW();
                    break;
                # endregion

                # region Dread
                case "Dread":
                    mcn = new DreadLRW();
                    break;
                # endregion

                # region Dreamspoiler Witches
                case "Dreamspoiler Witches":
                    mcn = new DreamspoilerWitchesLRW();
                    break;
                # endregion

                # region Drowner of Secrets
                case "Drowner of Secrets":
                    mcn = new DrownerofSecretsLRW();
                    break;
                # endregion

                # region Ego Erasure
                case "Ego Erasure":
                    mcn = new EgoErasureLRW();
                    break;
                # endregion

                # region Elvish Branchbender
                case "Elvish Branchbender":
                    mcn = new ElvishBranchbenderLRW();
                    break;
                # endregion

                # region Elvish Eulogist
                case "Elvish Eulogist":
                    mcn = new ElvishEulogistLRW();
                    break;
                # endregion

                # region Elvish Handservant
                case "Elvish Handservant":
                    mcn = new ElvishHandservantLRW();
                    break;
                # endregion

                # region Elvish Harbinger
                case "Elvish Harbinger":
                    mcn = new ElvishHarbingerLRW();
                    break;
                # endregion

                # region Elvish Promenade
                case "Elvish Promenade":
                    mcn = new ElvishPromenadeLRW();
                    break;
                # endregion

                # region Entangling Trap
                case "Entangling Trap":
                    mcn = new EntanglingTrapLRW();
                    break;
                # endregion

                # region Epic Proportions
                case "Epic Proportions":
                    mcn = new EpicProportionsLRW();
                    break;
                # endregion

                # region Ethereal Whiskergill
                case "Ethereal Whiskergill":
                    mcn = new EtherealWhiskergillLRW();
                    break;
                # endregion

                # region Exiled Boggart
                case "Exiled Boggart":
                    mcn = new ExiledBoggartLRW();
                    break;
                # endregion

                # region Eyeblight's Ending
                case "Eyeblight's Ending":
                    mcn = new EyeblightsEndingLRW();
                    break;
                # endregion

                # region Eyes of the Wisent
                case "Eyes of the Wisent":
                    mcn = new EyesoftheWisentLRW();
                    break;
                # endregion

                # region Facevaulter
                case "Facevaulter":
                    mcn = new FacevaulterLRW();
                    break;
                # endregion

                # region Faerie Harbinger
                case "Faerie Harbinger":
                    mcn = new FaerieHarbingerLRW();
                    break;
                # endregion

                # region Faerie Tauntings
                case "Faerie Tauntings":
                    mcn = new FaerieTauntingsLRW();
                    break;
                # endregion

                # region Faerie Trickery
                case "Faerie Trickery":
                    mcn = new FaerieTrickeryLRW();
                    break;
                # endregion

                # region Fallowsage
                case "Fallowsage":
                    mcn = new FallowsageLRW();
                    break;
                # endregion

                # region Familiar's Ruse
                case "Familiar's Ruse":
                    mcn = new FamiliarsRuseLRW();
                    break;
                # endregion

                # region Fathom Trawl
                case "Fathom Trawl":
                    mcn = new FathomTrawlLRW();
                    break;
                # endregion

                # region Faultgrinder
                case "Faultgrinder":
                    mcn = new FaultgrinderLRW();
                    break;
                # endregion

                # region Favor of the Mighty
                case "Favor of the Mighty":
                    mcn = new FavoroftheMightyLRW();
                    break;
                # endregion

                # region Fertile Ground
                case "Fertile Ground":
                    mcn = new FertileGroundLRW();
                    break;
                # endregion

                # region Final Revels
                case "Final Revels":
                    mcn = new FinalRevelsLRW();
                    break;
                # endregion

                # region Fire-Belly Changeling
                case "Fire-Belly Changeling":
                    mcn = new FireBellyChangelingLRW();
                    break;
                # endregion

                # region Fistful of Force
                case "Fistful of Force":
                    mcn = new FistfulofForceLRW();
                    break;
                # endregion

                # region Flamekin Bladewhirl
                case "Flamekin Bladewhirl":
                    mcn = new FlamekinBladewhirlLRW();
                    break;
                # endregion

                # region Flamekin Brawler
                case "Flamekin Brawler":
                    mcn = new FlamekinBrawlerLRW();
                    break;
                # endregion

                # region Flamekin Harbinger
                case "Flamekin Harbinger":
                    mcn = new FlamekinHarbingerLRW();
                    break;
                # endregion

                # region Flamekin Spitfire
                case "Flamekin Spitfire":
                    mcn = new FlamekinSpitfireLRW();
                    break;
                # endregion

                # region Fodder Launch
                case "Fodder Launch":
                    mcn = new FodderLaunchLRW();
                    break;
                # endregion

                # region Footbottom Feast
                case "Footbottom Feast":
                    mcn = new FootbottomFeastLRW();
                    break;
                # endregion

                # region Forced Fruition
                case "Forced Fruition":
                    mcn = new ForcedFruitionLRW();
                    break;
                # endregion

                //# region Forest
                //case "Forest":
                //    mcn = new ForestLRW();
                //    break;
                //# endregion

                # region Gaddock Teeg
                case "Gaddock Teeg":
                    mcn = new GaddockTeegLRW();
                    break;
                # endregion

                # region Galepowder Mage
                case "Galepowder Mage":
                    mcn = new GalepowderMageLRW();
                    break;
                # endregion

                # region Garruk Wildspeaker
                case "Garruk Wildspeaker":
                    mcn = new GarrukWildspeakerLRW();
                    break;
                # endregion

                # region Ghostly Changeling
                case "Ghostly Changeling":
                    mcn = new GhostlyChangelingLRW();
                    break;
                # endregion

                # region Giant Harbinger
                case "Giant Harbinger":
                    mcn = new GiantHarbingerLRW();
                    break;
                # endregion

                # region Giant's Ire
                case "Giant's Ire":
                    mcn = new GiantsIreLRW();
                    break;
                # endregion

                # region Gilt-Leaf Ambush
                case "Gilt-Leaf Ambush":
                    mcn = new GiltLeafAmbushLRW();
                    break;
                # endregion

                # region Gilt-Leaf Palace
                case "Gilt-Leaf Palace":
                    mcn = new GiltLeafPalaceLRW();
                    break;
                # endregion

                # region Gilt-Leaf Seer
                case "Gilt-Leaf Seer":
                    mcn = new GiltLeafSeerLRW();
                    break;
                # endregion

                # region Glarewielder
                case "Glarewielder":
                    mcn = new GlarewielderLRW();
                    break;
                # endregion

                # region Glen Elendra Pranksters
                case "Glen Elendra Pranksters":
                    mcn = new GlenElendraPrankstersLRW();
                    break;
                # endregion

                # region Glimmerdust Nap
                case "Glimmerdust Nap":
                    mcn = new GlimmerdustNapLRW();
                    break;
                # endregion

                # region Goatnapper
                case "Goatnapper":
                    mcn = new GoatnapperLRW();
                    break;
                # endregion

                # region Goldmeadow Dodger
                case "Goldmeadow Dodger":
                    mcn = new GoldmeadowDodgerLRW();
                    break;
                # endregion

                # region Goldmeadow Harrier
                case "Goldmeadow Harrier":
                    mcn = new GoldmeadowHarrierLRW();
                    break;
                # endregion

                # region Goldmeadow Stalwart
                case "Goldmeadow Stalwart":
                    mcn = new GoldmeadowStalwartLRW();
                    break;
                # endregion

                # region Guardian of Cloverdell
                case "Guardian of Cloverdell":
                    mcn = new GuardianofCloverdellLRW();
                    break;
                # endregion

                # region Guile
                case "Guile":
                    mcn = new GuileLRW();
                    break;
                # endregion

                # region Hamletback Goliath
                case "Hamletback Goliath":
                    mcn = new HamletbackGoliathLRW();
                    break;
                # endregion

                # region Harpoon Sniper
                case "Harpoon Sniper":
                    mcn = new HarpoonSniperLRW();
                    break;
                # endregion

                # region Heal the Scars
                case "Heal the Scars":
                    mcn = new HealtheScarsLRW();
                    break;
                # endregion

                # region Hearthcage Giant
                case "Hearthcage Giant":
                    mcn = new HearthcageGiantLRW();
                    break;
                # endregion

                # region Heat Shimmer
                case "Heat Shimmer":
                    mcn = new HeatShimmerLRW();
                    break;
                # endregion

                # region Herbal Poultice
                case "Herbal Poultice":
                    mcn = new HerbalPoulticeLRW();
                    break;
                # endregion

                # region Hillcomber Giant
                case "Hillcomber Giant":
                    mcn = new HillcomberGiantLRW();
                    break;
                # endregion

                # region Hoarder's Greed
                case "Hoarder's Greed":
                    mcn = new HoardersGreedLRW();
                    break;
                # endregion

                # region Hoofprints of the Stag
                case "Hoofprints of the Stag":
                    mcn = new HoofprintsoftheStagLRW();
                    break;
                # endregion

                # region Horde of Notions
                case "Horde of Notions":
                    mcn = new HordeofNotionsLRW();
                    break;
                # endregion

                # region Hornet Harasser
                case "Hornet Harasser":
                    mcn = new HornetHarasserLRW();
                    break;
                # endregion

                # region Hostility
                case "Hostility":
                    mcn = new HostilityLRW();
                    break;
                # endregion

                # region Howltooth Hollow
                case "Howltooth Hollow":
                    mcn = new HowltoothHollowLRW();
                    break;
                # endregion

                # region Hunt Down
                case "Hunt Down":
                    mcn = new HuntDownLRW();
                    break;
                # endregion

                # region Hunter of Eyeblights
                case "Hunter of Eyeblights":
                    mcn = new HunterofEyeblightsLRW();
                    break;
                # endregion

                # region Hurly-Burly
                case "Hurly-Burly":
                    mcn = new HurlyBurlyLRW();
                    break;
                # endregion

                # region Immaculate Magistrate
                case "Immaculate Magistrate":
                    mcn = new ImmaculateMagistrateLRW();
                    break;
                # endregion

                # region Imperious Perfect
                case "Imperious Perfect":
                    mcn = new ImperiousPerfectLRW();
                    break;
                # endregion

                # region Incandescent Soulstoke
                case "Incandescent Soulstoke":
                    mcn = new IncandescentSoulstokeLRW();
                    break;
                # endregion

                # region Incendiary Command
                case "Incendiary Command":
                    mcn = new IncendiaryCommandLRW();
                    break;
                # endregion

                # region Incremental Growth
                case "Incremental Growth":
                    mcn = new IncrementalGrowthLRW();
                    break;
                # endregion

                # region Ingot Chewer
                case "Ingot Chewer":
                    mcn = new IngotChewerLRW();
                    break;
                # endregion

                # region Inkfathom Divers
                case "Inkfathom Divers":
                    mcn = new InkfathomDiversLRW();
                    break;
                # endregion

                # region Inner-Flame Acolyte
                case "Inner-Flame Acolyte":
                    mcn = new InnerFlameAcolyteLRW();
                    break;
                # endregion

                # region Inner-Flame Igniter
                case "Inner-Flame Igniter":
                    mcn = new InnerFlameIgniterLRW();
                    break;
                # endregion

                //# region Island
                //case "Island":
                //    mcn = new IslandLRW();
                //    break;
                //# endregion

                # region Jace Beleren
                case "Jace Beleren":
                    mcn = new JaceBelerenLRW();
                    break;
                # endregion

                # region Jagged-Scar Archers
                case "Jagged-Scar Archers":
                    mcn = new JaggedScarArchersLRW();
                    break;
                # endregion

                # region Judge of Currents
                case "Judge of Currents":
                    mcn = new JudgeofCurrentsLRW();
                    break;
                # endregion

                # region Kinsbaile Balloonist
                case "Kinsbaile Balloonist":
                    mcn = new KinsbaileBalloonistLRW();
                    break;
                # endregion

                # region Kinsbaile Skirmisher
                case "Kinsbaile Skirmisher":
                    mcn = new KinsbaileSkirmisherLRW();
                    break;
                # endregion

                # region Kithkin Daggerdare
                case "Kithkin Daggerdare":
                    mcn = new KithkinDaggerdareLRW();
                    break;
                # endregion

                # region Kithkin Greatheart
                case "Kithkin Greatheart":
                    mcn = new KithkinGreatheartLRW();
                    break;
                # endregion

                # region Kithkin Harbinger
                case "Kithkin Harbinger":
                    mcn = new KithkinHarbingerLRW();
                    break;
                # endregion

                # region Kithkin Healer
                case "Kithkin Healer":
                    mcn = new KithkinHealerLRW();
                    break;
                # endregion

                # region Kithkin Mourncaller
                case "Kithkin Mourncaller":
                    mcn = new KithkinMourncallerLRW();
                    break;
                # endregion

                # region Knight of Meadowgrain
                case "Knight of Meadowgrain":
                    mcn = new KnightofMeadowgrainLRW();
                    break;
                # endregion

                # region Knucklebone Witch
                case "Knucklebone Witch":
                    mcn = new KnuckleboneWitchLRW();
                    break;
                # endregion

                # region Lace with Moonglove
                case "Lace with Moonglove":
                    mcn = new LacewithMoongloveLRW();
                    break;
                # endregion

                # region Lairwatch Giant
                case "Lairwatch Giant":
                    mcn = new LairwatchGiantLRW();
                    break;
                # endregion

                # region Lammastide Weave
                case "Lammastide Weave":
                    mcn = new LammastideWeaveLRW();
                    break;
                # endregion

                # region Lash Out
                case "Lash Out":
                    mcn = new LashOutLRW();
                    break;
                # endregion

                # region Leaf Gilder
                case "Leaf Gilder":
                    mcn = new LeafGilderLRW();
                    break;
                # endregion

                # region Lignify
                case "Lignify":
                    mcn = new LignifyLRW();
                    break;
                # endregion

                # region Liliana Vess
                case "Liliana Vess":
                    mcn = new LilianaVessLRW();
                    break;
                # endregion

                # region Lowland Oaf
                case "Lowland Oaf":
                    mcn = new LowlandOafLRW();
                    break;
                # endregion

                # region Lys Alana Huntmaster
                case "Lys Alana Huntmaster":
                    mcn = new LysAlanaHuntmasterLRW();
                    break;
                # endregion

                # region Lys Alana Scarblade
                case "Lys Alana Scarblade":
                    mcn = new LysAlanaScarbladeLRW();
                    break;
                # endregion

                # region Mad Auntie
                case "Mad Auntie":
                    mcn = new MadAuntieLRW();
                    break;
                # endregion

                # region Makeshift Mannequin
                case "Makeshift Mannequin":
                    mcn = new MakeshiftMannequinLRW();
                    break;
                # endregion

                # region Marsh Flitter
                case "Marsh Flitter":
                    mcn = new MarshFlitterLRW();
                    break;
                # endregion

                # region Masked Admirers
                case "Masked Admirers":
                    mcn = new MaskedAdmirersLRW();
                    break;
                # endregion

                # region Merrow Commerce
                case "Merrow Commerce":
                    mcn = new MerrowCommerceLRW();
                    break;
                # endregion

                # region Merrow Harbinger
                case "Merrow Harbinger":
                    mcn = new MerrowHarbingerLRW();
                    break;
                # endregion

                # region Merrow Reejerey
                case "Merrow Reejerey":
                    mcn = new MerrowReejereyLRW();
                    break;
                # endregion

                # region Militia's Pride
                case "Militia's Pride":
                    mcn = new MilitiasPrideLRW();
                    break;
                # endregion

                # region Mirror Entity
                case "Mirror Entity":
                    mcn = new MirrorEntityLRW();
                    break;
                # endregion

                # region Mistbind Clique
                case "Mistbind Clique":
                    mcn = new MistbindCliqueLRW();
                    break;
                # endregion

                # region Moonglove Extract
                case "Moonglove Extract":
                    mcn = new MoongloveExtractLRW();
                    break;
                # endregion

                # region Moonglove Winnower
                case "Moonglove Winnower":
                    mcn = new MoongloveWinnowerLRW();
                    break;
                # endregion

                # region Mosswort Bridge
                case "Mosswort Bridge":
                    mcn = new MosswortBridgeLRW();
                    break;
                # endregion

                //# region Mountain
                //case "Mountain":
                //    mcn = new MountainLRW();
                //    break;
                //# endregion

                # region Mournwhelk
                case "Mournwhelk":
                    mcn = new MournwhelkLRW();
                    break;
                # endregion

                # region Mudbutton Torchrunner
                case "Mudbutton Torchrunner":
                    mcn = new MudbuttonTorchrunnerLRW();
                    break;
                # endregion

                # region Mulldrifter
                case "Mulldrifter":
                    mcn = new MulldrifterLRW();
                    break;
                # endregion

                # region Nameless Inversion
                case "Nameless Inversion":
                    mcn = new NamelessInversionLRW();
                    break;
                # endregion

                # region Nath of the Gilt-Leaf
                case "Nath of the Gilt-Leaf":
                    mcn = new NathoftheGiltLeafLRW();
                    break;
                # endregion

                # region Nath's Buffoon
                case "Nath's Buffoon":
                    mcn = new NathsBuffoonLRW();
                    break;
                # endregion

                # region Nath's Elite
                case "Nath's Elite":
                    mcn = new NathsEliteLRW();
                    break;
                # endregion

                # region Neck Snap
                case "Neck Snap":
                    mcn = new NeckSnapLRW();
                    break;
                # endregion

                # region Nectar Faerie
                case "Nectar Faerie":
                    mcn = new NectarFaerieLRW();
                    break;
                # endregion

                # region Needle Drop
                case "Needle Drop":
                    mcn = new NeedleDropLRW();
                    break;
                # endregion

                # region Nettlevine Blight
                case "Nettlevine Blight":
                    mcn = new NettlevineBlightLRW();
                    break;
                # endregion

                # region Nightshade Stinger
                case "Nightshade Stinger":
                    mcn = new NightshadeStingerLRW();
                    break;
                # endregion

                # region Nova Chaser
                case "Nova Chaser":
                    mcn = new NovaChaserLRW();
                    break;
                # endregion

                # region Oaken Brawler
                case "Oaken Brawler":
                    mcn = new OakenBrawlerLRW();
                    break;
                # endregion

                # region Oakgnarl Warrior
                case "Oakgnarl Warrior":
                    mcn = new OakgnarlWarriorLRW();
                    break;
                # endregion

                # region Oblivion Ring
                case "Oblivion Ring":
                    mcn = new OblivionRingLRW();
                    break;
                # endregion

                # region Oona's Prowler
                case "Oona's Prowler":
                    mcn = new OonasProwlerLRW();
                    break;
                # endregion

                # region Paperfin Rascal
                case "Paperfin Rascal":
                    mcn = new PaperfinRascalLRW();
                    break;
                # endregion

                # region Peppersmoke
                case "Peppersmoke":
                    mcn = new PeppersmokeLRW();
                    break;
                # endregion

                # region Pestermite
                case "Pestermite":
                    mcn = new PestermiteLRW();
                    break;
                # endregion

                //# region Plains
                //case "Plains":
                //    mcn = new PlainsLRW();
                //    break;
                //# endregion

                # region Plover Knights
                case "Plover Knights":
                    mcn = new PloverKnightsLRW();
                    break;
                # endregion

                # region Pollen Lullaby
                case "Pollen Lullaby":
                    mcn = new PollenLullabyLRW();
                    break;
                # endregion

                # region Ponder
                case "Ponder":
                    mcn = new PonderLRW();
                    break;
                # endregion

                # region Primal Command
                case "Primal Command":
                    mcn = new PrimalCommandLRW();
                    break;
                # endregion

                # region Profane Command
                case "Profane Command":
                    mcn = new ProfaneCommandLRW();
                    break;
                # endregion

                # region Protective Bubble
                case "Protective Bubble":
                    mcn = new ProtectiveBubbleLRW();
                    break;
                # endregion

                # region Prowess of the Fair
                case "Prowess of the Fair":
                    mcn = new ProwessoftheFairLRW();
                    break;
                # endregion

                # region Purity
                case "Purity":
                    mcn = new PurityLRW();
                    break;
                # endregion

                # region Quill-Slinger Boggart
                case "Quill-Slinger Boggart":
                    mcn = new QuillSlingerBoggartLRW();
                    break;
                # endregion

                # region Rebellion of the Flamekin
                case "Rebellion of the Flamekin":
                    mcn = new RebellionoftheFlamekinLRW();
                    break;
                # endregion

                # region Rings of Brighthearth
                case "Rings of Brighthearth":
                    mcn = new RingsofBrighthearthLRW();
                    break;
                # endregion

                # region Ringskipper
                case "Ringskipper":
                    mcn = new RingskipperLRW();
                    break;
                # endregion

                # region Rootgrapple
                case "Rootgrapple":
                    mcn = new RootgrappleLRW();
                    break;
                # endregion

                # region Runed Stalactite
                case "Runed Stalactite":
                    mcn = new RunedStalactiteLRW();
                    break;
                # endregion

                # region Scarred Vinebreeder
                case "Scarred Vinebreeder":
                    mcn = new ScarredVinebreederLRW();
                    break;
                # endregion

                # region Scattering Stroke
                case "Scattering Stroke":
                    mcn = new ScatteringStrokeLRW();
                    break;
                # endregion

                # region Scion of Oona
                case "Scion of Oona":
                    mcn = new ScionofOonaLRW();
                    break;
                # endregion

                # region Secluded Glen
                case "Secluded Glen":
                    mcn = new SecludedGlenLRW();
                    break;
                # endregion

                # region Seedguide Ash
                case "Seedguide Ash":
                    mcn = new SeedguideAshLRW();
                    break;
                # endregion

                # region Sentinels of Glen Elendra
                case "Sentinels of Glen Elendra":
                    mcn = new SentinelsofGlenElendraLRW();
                    break;
                # endregion

                # region Sentry Oak
                case "Sentry Oak":
                    mcn = new SentryOakLRW();
                    break;
                # endregion

                # region Shapesharer
                case "Shapesharer":
                    mcn = new ShapesharerLRW();
                    break;
                # endregion

                # region Shelldock Isle
                case "Shelldock Isle":
                    mcn = new ShelldockIsleLRW();
                    break;
                # endregion

                # region Shields of Velis Vel
                case "Shields of Velis Vel":
                    mcn = new ShieldsofVelisVelLRW();
                    break;
                # endregion

                # region Shimmering Grotto
                case "Shimmering Grotto":
                    mcn = new ShimmeringGrottoLRW();
                    break;
                # endregion

                # region Shriekmaw
                case "Shriekmaw":
                    mcn = new ShriekmawLRW();
                    break;
                # endregion

                # region Silvergill Adept
                case "Silvergill Adept":
                    mcn = new SilvergillAdeptLRW();
                    break;
                # endregion

                # region Silvergill Douser
                case "Silvergill Douser":
                    mcn = new SilvergillDouserLRW();
                    break;
                # endregion

                # region Skeletal Changeling
                case "Skeletal Changeling":
                    mcn = new SkeletalChangelingLRW();
                    break;
                # endregion

                # region Smokebraider
                case "Smokebraider":
                    mcn = new SmokebraiderLRW();
                    break;
                # endregion

                # region Soaring Hope
                case "Soaring Hope":
                    mcn = new SoaringHopeLRW();
                    break;
                # endregion

                # region Soulbright Flamekin
                case "Soulbright Flamekin":
                    mcn = new SoulbrightFlamekinLRW();
                    break;
                # endregion

                # region Sower of Temptation
                case "Sower of Temptation":
                    mcn = new SowerofTemptationLRW();
                    break;
                # endregion

                # region Spellstutter Sprite
                case "Spellstutter Sprite":
                    mcn = new SpellstutterSpriteLRW();
                    break;
                # endregion

                # region Spiderwig Boggart
                case "Spiderwig Boggart":
                    mcn = new SpiderwigBoggartLRW();
                    break;
                # endregion

                # region Spinerock Knoll
                case "Spinerock Knoll":
                    mcn = new SpinerockKnollLRW();
                    break;
                # endregion

                # region Spring Cleaning
                case "Spring Cleaning":
                    mcn = new SpringCleaningLRW();
                    break;
                # endregion

                # region Springjack Knight
                case "Springjack Knight":
                    mcn = new SpringjackKnightLRW();
                    break;
                # endregion

                # region Springleaf Drum
                case "Springleaf Drum":
                    mcn = new SpringleafDrumLRW();
                    break;
                # endregion

                # region Squeaking Pie Sneak
                case "Squeaking Pie Sneak":
                    mcn = new SqueakingPieSneakLRW();
                    break;
                # endregion

                # region Stinkdrinker Daredevil
                case "Stinkdrinker Daredevil":
                    mcn = new StinkdrinkerDaredevilLRW();
                    break;
                # endregion

                # region Stonybrook Angler
                case "Stonybrook Angler":
                    mcn = new StonybrookAnglerLRW();
                    break;
                # endregion

                # region Streambed Aquitects
                case "Streambed Aquitects":
                    mcn = new StreambedAquitectsLRW();
                    break;
                # endregion

                # region Summon the School
                case "Summon the School":
                    mcn = new SummontheSchoolLRW();
                    break;
                # endregion

                # region Sunrise Sovereign
                case "Sunrise Sovereign":
                    mcn = new SunriseSovereignLRW();
                    break;
                # endregion

                # region Surge of Thoughtweft
                case "Surge of Thoughtweft":
                    mcn = new SurgeofThoughtweftLRW();
                    break;
                # endregion

                # region Surgespanner
                case "Surgespanner":
                    mcn = new SurgespannerLRW();
                    break;
                # endregion

                //# region Swamp
                //case "Swamp":
                //    mcn = new SwampLRW();
                //    break;
                //# endregion

                # region Sygg, River Guide
                case "Sygg, River Guide":
                    mcn = new SyggRiverGuideLRW();
                    break;
                # endregion

                # region Sylvan Echoes
                case "Sylvan Echoes":
                    mcn = new SylvanEchoesLRW();
                    break;
                # endregion

                # region Tar Pitcher
                case "Tar Pitcher":
                    mcn = new TarPitcherLRW();
                    break;
                # endregion

                # region Tarfire
                case "Tarfire":
                    mcn = new TarfireLRW();
                    break;
                # endregion

                # region Thieving Sprite
                case "Thieving Sprite":
                    mcn = new ThievingSpriteLRW();
                    break;
                # endregion

                # region Thorn of Amethyst
                case "Thorn of Amethyst":
                    mcn = new ThornofAmethystLRW();
                    break;
                # endregion

                # region Thorntooth Witch
                case "Thorntooth Witch":
                    mcn = new ThorntoothWitchLRW();
                    break;
                # endregion

                # region Thoughtseize
                case "Thoughtseize":
                    mcn = new ThoughtseizeLRW();
                    break;
                # endregion

                # region Thoughtweft Trio
                case "Thoughtweft Trio":
                    mcn = new ThoughtweftTrioLRW();
                    break;
                # endregion

                # region Thousand-Year Elixir
                case "Thousand-Year Elixir":
                    mcn = new ThousandYearElixirLRW();
                    break;
                # endregion

                # region Thundercloud Shaman
                case "Thundercloud Shaman":
                    mcn = new ThundercloudShamanLRW();
                    break;
                # endregion

                # region Tideshaper Mystic
                case "Tideshaper Mystic":
                    mcn = new TideshaperMysticLRW();
                    break;
                # endregion

                # region Timber Protector
                case "Timber Protector":
                    mcn = new TimberProtectorLRW();
                    break;
                # endregion

                # region Treefolk Harbinger
                case "Treefolk Harbinger":
                    mcn = new TreefolkHarbingerLRW();
                    break;
                # endregion

                # region Triclopean Sight
                case "Triclopean Sight":
                    mcn = new TriclopeanSightLRW();
                    break;
                # endregion

                # region Turtleshell Changeling
                case "Turtleshell Changeling":
                    mcn = new TurtleshellChangelingLRW();
                    break;
                # endregion

                # region Twinning Glass
                case "Twinning Glass":
                    mcn = new TwinningGlassLRW();
                    break;
                # endregion

                # region Veteran of the Depths
                case "Veteran of the Depths":
                    mcn = new VeteranoftheDepthsLRW();
                    break;
                # endregion

                # region Vigor
                case "Vigor":
                    mcn = new VigorLRW();
                    break;
                # endregion

                # region Vivid Crag
                case "Vivid Crag":
                    mcn = new VividCragLRW();
                    break;
                # endregion

                # region Vivid Creek
                case "Vivid Creek":
                    mcn = new VividCreekLRW();
                    break;
                # endregion

                # region Vivid Grove
                case "Vivid Grove":
                    mcn = new VividGroveLRW();
                    break;
                # endregion

                # region Vivid Marsh
                case "Vivid Marsh":
                    mcn = new VividMarshLRW();
                    break;
                # endregion

                # region Vivid Meadow
                case "Vivid Meadow":
                    mcn = new VividMeadowLRW();
                    break;
                # endregion

                # region Wanderer's Twig
                case "Wanderer's Twig":
                    mcn = new WanderersTwigLRW();
                    break;
                # endregion

                # region Wanderwine Hub
                case "Wanderwine Hub":
                    mcn = new WanderwineHubLRW();
                    break;
                # endregion

                # region Wanderwine Prophets
                case "Wanderwine Prophets":
                    mcn = new WanderwineProphetsLRW();
                    break;
                # endregion

                # region Warren Pilferers
                case "Warren Pilferers":
                    mcn = new WarrenPilferersLRW();
                    break;
                # endregion

                # region Warren-Scourge Elf
                case "Warren-Scourge Elf":
                    mcn = new WarrenScourgeElfLRW();
                    break;
                # endregion

                # region Weed Strangle
                case "Weed Strangle":
                    mcn = new WeedStrangleLRW();
                    break;
                # endregion

                # region Wellgabber Apothecary
                case "Wellgabber Apothecary":
                    mcn = new WellgabberApothecaryLRW();
                    break;
                # endregion

                # region Whirlpool Whelm
                case "Whirlpool Whelm":
                    mcn = new WhirlpoolWhelmLRW();
                    break;
                # endregion

                # region Wild Ricochet
                case "Wild Ricochet":
                    mcn = new WildRicochetLRW();
                    break;
                # endregion

                # region Windbrisk Heights
                case "Windbrisk Heights":
                    mcn = new WindbriskHeightsLRW();
                    break;
                # endregion

                # region Wings of Velis Vel
                case "Wings of Velis Vel":
                    mcn = new WingsofVelisVelLRW();
                    break;
                # endregion

                # region Wispmare
                case "Wispmare":
                    mcn = new WispmareLRW();
                    break;
                # endregion

                # region Wizened Cenn
                case "Wizened Cenn":
                    mcn = new WizenedCennLRW();
                    break;
                # endregion

                # region Woodland Changeling
                case "Woodland Changeling":
                    mcn = new WoodlandChangelingLRW();
                    break;
                # endregion

                # region Woodland Guidance
                case "Woodland Guidance":
                    mcn = new WoodlandGuidanceLRW();
                    break;
                # endregion

                # region Wort, Boggart Auntie
                case "Wort, Boggart Auntie":
                    mcn = new WortBoggartAuntieLRW();
                    break;
                # endregion

                # region Wren's Run Packmaster
                case "Wren's Run Packmaster":
                    mcn = new WrensRunPackmasterLRW();
                    break;
                # endregion

                # region Wren's Run Vanquisher
                case "Wren's Run Vanquisher":
                    mcn = new WrensRunVanquisherLRW();
                    break;
                # endregion

                # region Wydwen, the Biting Gale
                case "Wydwen, the Biting Gale":
                    mcn = new WydwentheBitingGaleLRW();
                    break;
                # endregion

                # region Zephyr Net
                case "Zephyr Net":
                    mcn = new ZephyrNetLRW();
                    break;
                # endregion
                # endregion

                # region Morningtide

                # endregion

                # region Shadowmoor
                # region Advice from the Fae
                case "Advice from the Fae":
                    mcn = new AdvicefromtheFaeSHM();
                    break;
                # endregion

                # region AEthertow
                case "AEthertow":
                    mcn = new AEthertowSHM();
                    break;
                # endregion

                # region Aphotic Wisps
                case "Aphotic Wisps":
                    mcn = new AphoticWispsSHM();
                    break;
                # endregion

                # region Apothecary Initiate
                case "Apothecary Initiate":
                    mcn = new ApothecaryInitiateSHM();
                    break;
                # endregion

                # region Armored Ascension
                case "Armored Ascension":
                    mcn = new ArmoredAscensionSHM();
                    break;
                # endregion

                # region Ashenmoor Cohort
                case "Ashenmoor Cohort":
                    mcn = new AshenmoorCohortSHM();
                    break;
                # endregion

                # region Ashenmoor Gouger
                case "Ashenmoor Gouger":
                    mcn = new AshenmoorGougerSHM();
                    break;
                # endregion

                # region Ashenmoor Liege
                case "Ashenmoor Liege":
                    mcn = new AshenmoorLiegeSHM();
                    break;
                # endregion

                # region Augury Adept
                case "Augury Adept":
                    mcn = new AuguryAdeptSHM();
                    break;
                # endregion

                # region Ballynock Cohort
                case "Ballynock Cohort":
                    mcn = new BallynockCohortSHM();
                    break;
                # endregion

                # region Barkshell Blessing
                case "Barkshell Blessing":
                    mcn = new BarkshellBlessingSHM();
                    break;
                # endregion

                # region Barrenton Cragtreads
                case "Barrenton Cragtreads":
                    mcn = new BarrentonCragtreadsSHM();
                    break;
                # endregion

                # region Barrenton Medic
                case "Barrenton Medic":
                    mcn = new BarrentonMedicSHM();
                    break;
                # endregion

                # region Beseech the Queen
                case "Beseech the Queen":
                    mcn = new BeseechtheQueenSHM();
                    break;
                # endregion

                # region Biting Tether
                case "Biting Tether":
                    mcn = new BitingTetherSHM();
                    break;
                # endregion

                # region Blazethorn Scarecrow
                case "Blazethorn Scarecrow":
                    mcn = new BlazethornScarecrowSHM();
                    break;
                # endregion

                # region Blight Sickle
                case "Blight Sickle":
                    mcn = new BlightSickleSHM();
                    break;
                # endregion

                # region Blistering Dieflyn
                case "Blistering Dieflyn":
                    mcn = new BlisteringDieflynSHM();
                    break;
                # endregion

                # region Bloodmark Mentor
                case "Bloodmark Mentor":
                    mcn = new BloodmarkMentorSHM();
                    break;
                # endregion

                # region Bloodshed Fever
                case "Bloodshed Fever":
                    mcn = new BloodshedFeverSHM();
                    break;
                # endregion

                # region Blowfly Infestation
                case "Blowfly Infestation":
                    mcn = new BlowflyInfestationSHM();
                    break;
                # endregion

                # region Boartusk Liege
                case "Boartusk Liege":
                    mcn = new BoartuskLiegeSHM();
                    break;
                # endregion

                # region Boggart Arsonists
                case "Boggart Arsonists":
                    mcn = new BoggartArsonistsSHM();
                    break;
                # endregion

                # region Boggart Ram-Gang
                case "Boggart Ram-Gang":
                    mcn = new BoggartRamGangSHM();
                    break;
                # endregion

                # region Boon Reflection
                case "Boon Reflection":
                    mcn = new BoonReflectionSHM();
                    break;
                # endregion

                # region Briarberry Cohort
                case "Briarberry Cohort":
                    mcn = new BriarberryCohortSHM();
                    break;
                # endregion

                # region Burn Trail
                case "Burn Trail":
                    mcn = new BurnTrailSHM();
                    break;
                # endregion

                # region Cauldron of Souls
                case "Cauldron of Souls":
                    mcn = new CauldronofSoulsSHM();
                    break;
                # endregion

                # region Cemetery Puca
                case "Cemetery Puca":
                    mcn = new CemeteryPucaSHM();
                    break;
                # endregion

                # region Cerulean Wisps
                case "Cerulean Wisps":
                    mcn = new CeruleanWispsSHM();
                    break;
                # endregion

                # region Chainbreaker
                case "Chainbreaker":
                    mcn = new ChainbreakerSHM();
                    break;
                # endregion

                # region Cinderbones
                case "Cinderbones":
                    mcn = new CinderbonesSHM();
                    break;
                # endregion

                # region Cinderhaze Wretch
                case "Cinderhaze Wretch":
                    mcn = new CinderhazeWretchSHM();
                    break;
                # endregion

                # region Consign to Dream
                case "Consign to Dream":
                    mcn = new ConsigntoDreamSHM();
                    break;
                # endregion

                # region Corrosive Mentor
                case "Corrosive Mentor":
                    mcn = new CorrosiveMentorSHM();
                    break;
                # endregion

                # region Corrupt
                case "Corrupt":
                    mcn = new CorruptSHM();
                    break;
                # endregion

                # region Counterbore
                case "Counterbore":
                    mcn = new CounterboreSHM();
                    break;
                # endregion

                # region Crabapple Cohort
                case "Crabapple Cohort":
                    mcn = new CrabappleCohortSHM();
                    break;
                # endregion

                # region Cragganwick Cremator
                case "Cragganwick Cremator":
                    mcn = new CragganwickCrematorSHM();
                    break;
                # endregion

                # region Crimson Wisps
                case "Crimson Wisps":
                    mcn = new CrimsonWispsSHM();
                    break;
                # endregion

                # region Crowd of Cinders
                case "Crowd of Cinders":
                    mcn = new CrowdofCindersSHM();
                    break;
                # endregion

                # region Cultbrand Cinder
                case "Cultbrand Cinder":
                    mcn = new CultbrandCinderSHM();
                    break;
                # endregion

                # region Curse of Chains
                case "Curse of Chains":
                    mcn = new CurseofChainsSHM();
                    break;
                # endregion

                # region Cursecatcher
                case "Cursecatcher":
                    mcn = new CursecatcherSHM();
                    break;
                # endregion

                # region Dawnglow Infusion
                case "Dawnglow Infusion":
                    mcn = new DawnglowInfusionSHM();
                    break;
                # endregion

                # region Deepchannel Mentor
                case "Deepchannel Mentor":
                    mcn = new DeepchannelMentorSHM();
                    break;
                # endregion

                # region Deep-Slumber Titan
                case "Deep-Slumber Titan":
                    mcn = new DeepSlumberTitanSHM();
                    break;
                # endregion

                # region Demigod of Revenge
                case "Demigod of Revenge":
                    mcn = new DemigodofRevengeSHM();
                    break;
                # endregion

                # region Deus of Calamity
                case "Deus of Calamity":
                    mcn = new DeusofCalamitySHM();
                    break;
                # endregion

                # region Devoted Druid
                case "Devoted Druid":
                    mcn = new DevotedDruidSHM();
                    break;
                # endregion

                # region Din of the Fireherd
                case "Din of the Fireherd":
                    mcn = new DinoftheFireherdSHM();
                    break;
                # endregion

                # region Dire Undercurrents
                case "Dire Undercurrents":
                    mcn = new DireUndercurrentsSHM();
                    break;
                # endregion

                # region Disturbing Plot
                case "Disturbing Plot":
                    mcn = new DisturbingPlotSHM();
                    break;
                # endregion

                # region Dramatic Entrance
                case "Dramatic Entrance":
                    mcn = new DramaticEntranceSHM();
                    break;
                # endregion

                # region Dream Salvage
                case "Dream Salvage":
                    mcn = new DreamSalvageSHM();
                    break;
                # endregion

                # region Drove of Elves
                case "Drove of Elves":
                    mcn = new DroveofElvesSHM();
                    break;
                # endregion

                # region Drowner Initiate
                case "Drowner Initiate":
                    mcn = new DrownerInitiateSHM();
                    break;
                # endregion

                # region Dusk Urchins
                case "Dusk Urchins":
                    mcn = new DuskUrchinsSHM();
                    break;
                # endregion

                # region Elemental Mastery
                case "Elemental Mastery":
                    mcn = new ElementalMasterySHM();
                    break;
                # endregion

                # region Elsewhere Flask
                case "Elsewhere Flask":
                    mcn = new ElsewhereFlaskSHM();
                    break;
                # endregion

                # region Elvish Hexhunter
                case "Elvish Hexhunter":
                    mcn = new ElvishHexhunterSHM();
                    break;
                # endregion

                # region Ember Gale
                case "Ember Gale":
                    mcn = new EmberGaleSHM();
                    break;
                # endregion

                # region Emberstrike Duo
                case "Emberstrike Duo":
                    mcn = new EmberstrikeDuoSHM();
                    break;
                # endregion

                # region Enchanted Evening
                case "Enchanted Evening":
                    mcn = new EnchantedEveningSHM();
                    break;
                # endregion

                # region Everlasting Torment
                case "Everlasting Torment":
                    mcn = new EverlastingTormentSHM();
                    break;
                # endregion

                # region Faerie Macabre
                case "Faerie Macabre":
                    mcn = new FaerieMacabreSHM();
                    break;
                # endregion

                # region Faerie Swarm
                case "Faerie Swarm":
                    mcn = new FaerieSwarmSHM();
                    break;
                # endregion

                # region Farhaven Elf
                case "Farhaven Elf":
                    mcn = new FarhavenElfSHM();
                    break;
                # endregion

                # region Fate Transfer
                case "Fate Transfer":
                    mcn = new FateTransferSHM();
                    break;
                # endregion

                # region Fire-Lit Thicket
                case "Fire-Lit Thicket":
                    mcn = new FireLitThicketSHM();
                    break;
                # endregion

                # region Firespout
                case "Firespout":
                    mcn = new FirespoutSHM();
                    break;
                # endregion

                # region Fists of the Demigod
                case "Fists of the Demigod":
                    mcn = new FistsoftheDemigodSHM();
                    break;
                # endregion

                # region Flame Javelin
                case "Flame Javelin":
                    mcn = new FlameJavelinSHM();
                    break;
                # endregion

                # region Flourishing Defenses
                case "Flourishing Defenses":
                    mcn = new FlourishingDefensesSHM();
                    break;
                # endregion

                # region Flow of Ideas
                case "Flow of Ideas":
                    mcn = new FlowofIdeasSHM();
                    break;
                # endregion

                //# region Forest
                //case "Forest":
                //mcn = new ForestSHM();
                //break;
                //# endregion

                # region Fossil Find
                case "Fossil Find":
                    mcn = new FossilFindSHM();
                    break;
                # endregion

                # region Foxfire Oak
                case "Foxfire Oak":
                    mcn = new FoxfireOakSHM();
                    break;
                # endregion

                # region Fracturing Gust
                case "Fracturing Gust":
                    mcn = new FracturingGustSHM();
                    break;
                # endregion

                # region Fulminator Mage
                case "Fulminator Mage":
                    mcn = new FulminatorMageSHM();
                    break;
                # endregion

                # region Furystoke Giant
                case "Furystoke Giant":
                    mcn = new FurystokeGiantSHM();
                    break;
                # endregion

                # region Ghastlord of Fugue
                case "Ghastlord of Fugue":
                    mcn = new GhastlordofFugueSHM();
                    break;
                # endregion

                # region Ghastly Discovery
                case "Ghastly Discovery":
                    mcn = new GhastlyDiscoverySHM();
                    break;
                # endregion

                # region Giantbaiting
                case "Giantbaiting":
                    mcn = new GiantbaitingSHM();
                    break;
                # endregion

                # region Glamer Spinners
                case "Glamer Spinners":
                    mcn = new GlamerSpinnersSHM();
                    break;
                # endregion

                # region Gleeful Sabotage
                case "Gleeful Sabotage":
                    mcn = new GleefulSabotageSHM();
                    break;
                # endregion

                # region Glen Elendra Liege
                case "Glen Elendra Liege":
                    mcn = new GlenElendraLiegeSHM();
                    break;
                # endregion

                # region Gloomlance
                case "Gloomlance":
                    mcn = new GloomlanceSHM();
                    break;
                # endregion

                # region Gloomwidow
                case "Gloomwidow":
                    mcn = new GloomwidowSHM();
                    break;
                # endregion

                # region Gloomwidow's Feast
                case "Gloomwidow's Feast":
                    mcn = new GloomwidowsFeastSHM();
                    break;
                # endregion

                # region Gnarled Effigy
                case "Gnarled Effigy":
                    mcn = new GnarledEffigySHM();
                    break;
                # endregion

                # region Godhead of Awe
                case "Godhead of Awe":
                    mcn = new GodheadofAweSHM();
                    break;
                # endregion

                # region Goldenglow Moth
                case "Goldenglow Moth":
                    mcn = new GoldenglowMothSHM();
                    break;
                # endregion

                # region Gravelgill Axeshark
                case "Gravelgill Axeshark":
                    mcn = new GravelgillAxesharkSHM();
                    break;
                # endregion

                # region Gravelgill Duo
                case "Gravelgill Duo":
                    mcn = new GravelgillDuoSHM();
                    break;
                # endregion

                # region Graven Cairns
                case "Graven Cairns":
                    mcn = new GravenCairnsSHM();
                    break;
                # endregion

                # region Greater Auramancy
                case "Greater Auramancy":
                    mcn = new GreaterAuramancySHM();
                    break;
                # endregion

                # region Grief Tyrant
                case "Grief Tyrant":
                    mcn = new GriefTyrantSHM();
                    break;
                # endregion

                # region Grim Poppet
                case "Grim Poppet":
                    mcn = new GrimPoppetSHM();
                    break;
                # endregion

                # region Guttural Response
                case "Guttural Response":
                    mcn = new GutturalResponseSHM();
                    break;
                # endregion

                # region Heap Doll
                case "Heap Doll":
                    mcn = new HeapDollSHM();
                    break;
                # endregion

                # region Heartmender
                case "Heartmender":
                    mcn = new HeartmenderSHM();
                    break;
                # endregion

                # region Helm of the Ghastlord
                case "Helm of the Ghastlord":
                    mcn = new HelmoftheGhastlordSHM();
                    break;
                # endregion

                # region Hollowborn Barghest
                case "Hollowborn Barghest":
                    mcn = new HollowbornBarghestSHM();
                    break;
                # endregion

                # region Hollowsage
                case "Hollowsage":
                    mcn = new HollowsageSHM();
                    break;
                # endregion

                # region Horde of Boggarts
                case "Horde of Boggarts":
                    mcn = new HordeofBoggartsSHM();
                    break;
                # endregion

                # region Howl of the Night Pack
                case "Howl of the Night Pack":
                    mcn = new HowloftheNightPackSHM();
                    break;
                # endregion

                # region Hungry Spriggan
                case "Hungry Spriggan":
                    mcn = new HungrySprigganSHM();
                    break;
                # endregion

                # region Illuminated Folio
                case "Illuminated Folio":
                    mcn = new IlluminatedFolioSHM();
                    break;
                # endregion

                # region Impromptu Raid
                case "Impromptu Raid":
                    mcn = new ImpromptuRaidSHM();
                    break;
                # endregion

                # region Incremental Blight
                case "Incremental Blight":
                    mcn = new IncrementalBlightSHM();
                    break;
                # endregion

                # region Inescapable Brute
                case "Inescapable Brute":
                    mcn = new InescapableBruteSHM();
                    break;
                # endregion

                # region Inkfathom Infiltrator
                case "Inkfathom Infiltrator":
                    mcn = new InkfathomInfiltratorSHM();
                    break;
                # endregion

                # region Inkfathom Witch
                case "Inkfathom Witch":
                    mcn = new InkfathomWitchSHM();
                    break;
                # endregion

                # region Inquisitor's Snare
                case "Inquisitor's Snare":
                    mcn = new InquisitorsSnareSHM();
                    break;
                # endregion

                # region Intimidator Initiate
                case "Intimidator Initiate":
                    mcn = new IntimidatorInitiateSHM();
                    break;
                # endregion

                //# region Island
                //case "Island":
                //mcn = new IslandSHM();
                //break;
                //# endregion

                # region Isleback Spawn
                case "Isleback Spawn":
                    mcn = new IslebackSpawnSHM();
                    break;
                # endregion

                # region Jaws of Stone
                case "Jaws of Stone":
                    mcn = new JawsofStoneSHM();
                    break;
                # endregion

                # region Juvenile Gloomwidow
                case "Juvenile Gloomwidow":
                    mcn = new JuvenileGloomwidowSHM();
                    break;
                # endregion

                # region Kinscaer Harpoonist
                case "Kinscaer Harpoonist":
                    mcn = new KinscaerHarpoonistSHM();
                    break;
                # endregion

                # region Kitchen Finks
                case "Kitchen Finks":
                    mcn = new KitchenFinksSHM();
                    break;
                # endregion

                # region Kithkin Rabble
                case "Kithkin Rabble":
                    mcn = new KithkinRabbleSHM();
                    break;
                # endregion

                # region Kithkin Shielddare
                case "Kithkin Shielddare":
                    mcn = new KithkinShielddareSHM();
                    break;
                # endregion

                # region Knacksaw Clique
                case "Knacksaw Clique":
                    mcn = new KnacksawCliqueSHM();
                    break;
                # endregion

                # region Knollspine Dragon
                case "Knollspine Dragon":
                    mcn = new KnollspineDragonSHM();
                    break;
                # endregion

                # region Knollspine Invocation
                case "Knollspine Invocation":
                    mcn = new KnollspineInvocationSHM();
                    break;
                # endregion

                # region Kulrath Knight
                case "Kulrath Knight":
                    mcn = new KulrathKnightSHM();
                    break;
                # endregion

                # region Last Breath
                case "Last Breath":
                    mcn = new LastBreathSHM();
                    break;
                # endregion

                # region Leech Bonder
                case "Leech Bonder":
                    mcn = new LeechBonderSHM();
                    break;
                # endregion

                # region Leechridden Swamp
                case "Leechridden Swamp":
                    mcn = new LeechriddenSwampSHM();
                    break;
                # endregion

                # region Loamdragger Giant
                case "Loamdragger Giant":
                    mcn = new LoamdraggerGiantSHM();
                    break;
                # endregion

                # region Loch Korrigan
                case "Loch Korrigan":
                    mcn = new LochKorriganSHM();
                    break;
                # endregion

                # region Lockjaw Snapper
                case "Lockjaw Snapper":
                    mcn = new LockjawSnapperSHM();
                    break;
                # endregion

                # region Lurebound Scarecrow
                case "Lurebound Scarecrow":
                    mcn = new LureboundScarecrowSHM();
                    break;
                # endregion

                # region Madblind Mountain
                case "Madblind Mountain":
                    mcn = new MadblindMountainSHM();
                    break;
                # endregion

                # region Mana Reflection
                case "Mana Reflection":
                    mcn = new ManaReflectionSHM();
                    break;
                # endregion

                # region Manaforge Cinder
                case "Manaforge Cinder":
                    mcn = new ManaforgeCinderSHM();
                    break;
                # endregion

                # region Manamorphose
                case "Manamorphose":
                    mcn = new ManamorphoseSHM();
                    break;
                # endregion

                # region Mass Calcify
                case "Mass Calcify":
                    mcn = new MassCalcifySHM();
                    break;
                # endregion

                # region Medicine Runner
                case "Medicine Runner":
                    mcn = new MedicineRunnerSHM();
                    break;
                # endregion

                # region Memory Plunder
                case "Memory Plunder":
                    mcn = new MemoryPlunderSHM();
                    break;
                # endregion

                # region Memory Sluice
                case "Memory Sluice":
                    mcn = new MemorySluiceSHM();
                    break;
                # endregion

                # region Mercy Killing
                case "Mercy Killing":
                    mcn = new MercyKillingSHM();
                    break;
                # endregion

                # region Merrow Grimeblotter
                case "Merrow Grimeblotter":
                    mcn = new MerrowGrimeblotterSHM();
                    break;
                # endregion

                # region Merrow Wavebreakers
                case "Merrow Wavebreakers":
                    mcn = new MerrowWavebreakersSHM();
                    break;
                # endregion

                # region Midnight Banshee
                case "Midnight Banshee":
                    mcn = new MidnightBansheeSHM();
                    break;
                # endregion

                # region Mine Excavation
                case "Mine Excavation":
                    mcn = new MineExcavationSHM();
                    break;
                # endregion

                # region Mirrorweave
                case "Mirrorweave":
                    mcn = new MirrorweaveSHM();
                    break;
                # endregion

                # region Mistmeadow Skulk
                case "Mistmeadow Skulk":
                    mcn = new MistmeadowSkulkSHM();
                    break;
                # endregion

                # region Mistmeadow Witch
                case "Mistmeadow Witch":
                    mcn = new MistmeadowWitchSHM();
                    break;
                # endregion

                # region Mistveil Plains
                case "Mistveil Plains":
                    mcn = new MistveilPlainsSHM();
                    break;
                # endregion

                # region Moonring Island
                case "Moonring Island":
                    mcn = new MoonringIslandSHM();
                    break;
                # endregion

                # region Morselhoarder
                case "Morselhoarder":
                    mcn = new MorselhoarderSHM();
                    break;
                # endregion

                # region Mossbridge Troll
                case "Mossbridge Troll":
                    mcn = new MossbridgeTrollSHM();
                    break;
                # endregion

                //# region Mountain
                //case "Mountain":
                //mcn = new MountainSHM();
                //break;
                //# endregion

                # region Mudbrawler Cohort
                case "Mudbrawler Cohort":
                    mcn = new MudbrawlerCohortSHM();
                    break;
                # endregion

                # region Mudbrawler Raiders
                case "Mudbrawler Raiders":
                    mcn = new MudbrawlerRaidersSHM();
                    break;
                # endregion

                # region Murderous Redcap
                case "Murderous Redcap":
                    mcn = new MurderousRedcapSHM();
                    break;
                # endregion

                # region Mystic Gate
                case "Mystic Gate":
                    mcn = new MysticGateSHM();
                    break;
                # endregion

                # region Niveous Wisps
                case "Niveous Wisps":
                    mcn = new NiveousWispsSHM();
                    break;
                # endregion

                # region Nurturer Initiate
                case "Nurturer Initiate":
                    mcn = new NurturerInitiateSHM();
                    break;
                # endregion

                # region Old Ghastbark
                case "Old Ghastbark":
                    mcn = new OldGhastbarkSHM();
                    break;
                # endregion

                # region Oona, Queen of the Fae
                case "Oona, Queen of the Fae":
                    mcn = new OonaQueenoftheFaeSHM();
                    break;
                # endregion

                # region Oona's Gatewarden
                case "Oona's Gatewarden":
                    mcn = new OonasGatewardenSHM();
                    break;
                # endregion

                # region Oracle of Nectars
                case "Oracle of Nectars":
                    mcn = new OracleofNectarsSHM();
                    break;
                # endregion

                # region Order of Whiteclay
                case "Order of Whiteclay":
                    mcn = new OrderofWhiteclaySHM();
                    break;
                # endregion

                # region Oversoul of Dusk
                case "Oversoul of Dusk":
                    mcn = new OversoulofDuskSHM();
                    break;
                # endregion

                # region Painter's Servant
                case "Painter's Servant":
                    mcn = new PaintersServantSHM();
                    break;
                # endregion

                # region Pale Wayfarer
                case "Pale Wayfarer":
                    mcn = new PaleWayfarerSHM();
                    break;
                # endregion

                # region Parapet Watchers
                case "Parapet Watchers":
                    mcn = new ParapetWatchersSHM();
                    break;
                # endregion

                # region Pili-Pala
                case "Pili-Pala":
                    mcn = new PiliPalaSHM();
                    break;
                # endregion

                # region Plague of Vermin
                case "Plague of Vermin":
                    mcn = new PlagueofVerminSHM();
                    break;
                # endregion

                //# region Plains
                //case "Plains":
                //mcn = new PlainsSHM();
                //break;
                //# endregion

                # region Plumeveil
                case "Plumeveil":
                    mcn = new PlumeveilSHM();
                    break;
                # endregion

                # region Poison the Well
                case "Poison the Well":
                    mcn = new PoisontheWellSHM();
                    break;
                # endregion

                # region Polluted Bonds
                case "Polluted Bonds":
                    mcn = new PollutedBondsSHM();
                    break;
                # endregion

                # region Power of Fire
                case "Power of Fire":
                    mcn = new PowerofFireSHM();
                    break;
                # endregion

                # region Presence of Gond
                case "Presence of Gond":
                    mcn = new PresenceofGondSHM();
                    break;
                # endregion

                # region Prismatic Omen
                case "Prismatic Omen":
                    mcn = new PrismaticOmenSHM();
                    break;
                # endregion

                # region Prismwake Merrow
                case "Prismwake Merrow":
                    mcn = new PrismwakeMerrowSHM();
                    break;
                # endregion

                # region Prison Term
                case "Prison Term":
                    mcn = new PrisonTermSHM();
                    break;
                # endregion

                # region Puca's Mischief
                case "Puca's Mischief":
                    mcn = new PucasMischiefSHM();
                    break;
                # endregion

                # region Puncture Bolt
                case "Puncture Bolt":
                    mcn = new PunctureBoltSHM();
                    break;
                # endregion

                # region Puppeteer Clique
                case "Puppeteer Clique":
                    mcn = new PuppeteerCliqueSHM();
                    break;
                # endregion

                # region Puresight Merrow
                case "Puresight Merrow":
                    mcn = new PuresightMerrowSHM();
                    break;
                # endregion

                # region Put Away
                case "Put Away":
                    mcn = new PutAwaySHM();
                    break;
                # endregion

                # region Pyre Charger
                case "Pyre Charger":
                    mcn = new PyreChargerSHM();
                    break;
                # endregion

                # region Rage Reflection
                case "Rage Reflection":
                    mcn = new RageReflectionSHM();
                    break;
                # endregion

                # region Raking Canopy
                case "Raking Canopy":
                    mcn = new RakingCanopySHM();
                    break;
                # endregion

                # region Rattleblaze Scarecrow
                case "Rattleblaze Scarecrow":
                    mcn = new RattleblazeScarecrowSHM();
                    break;
                # endregion

                # region Raven's Run Dragoon
                case "Raven's Run Dragoon":
                    mcn = new RavensRunDragoonSHM();
                    break;
                # endregion

                # region Reaper King
                case "Reaper King":
                    mcn = new ReaperKingSHM();
                    break;
                # endregion

                # region Reflecting Pool
                case "Reflecting Pool":
                    mcn = new ReflectingPoolSHM();
                    break;
                # endregion

                # region Reknit
                case "Reknit":
                    mcn = new ReknitSHM();
                    break;
                # endregion

                # region Repel Intruders
                case "Repel Intruders":
                    mcn = new RepelIntrudersSHM();
                    break;
                # endregion

                # region Resplendent Mentor
                case "Resplendent Mentor":
                    mcn = new ResplendentMentorSHM();
                    break;
                # endregion

                # region Revelsong Horn
                case "Revelsong Horn":
                    mcn = new RevelsongHornSHM();
                    break;
                # endregion

                # region Rhys the Redeemed
                case "Rhys the Redeemed":
                    mcn = new RhystheRedeemedSHM();
                    break;
                # endregion

                # region Rite of Consumption
                case "Rite of Consumption":
                    mcn = new RiteofConsumptionSHM();
                    break;
                # endregion

                # region River Kelpie
                case "River Kelpie":
                    mcn = new RiverKelpieSHM();
                    break;
                # endregion

                # region River's Grasp
                case "River's Grasp":
                    mcn = new RiversGraspSHM();
                    break;
                # endregion

                # region Rosheen Meanderer
                case "Rosheen Meanderer":
                    mcn = new RosheenMeandererSHM();
                    break;
                # endregion

                # region Roughshod Mentor
                case "Roughshod Mentor":
                    mcn = new RoughshodMentorSHM();
                    break;
                # endregion

                # region Rune-Cervin Rider
                case "Rune-Cervin Rider":
                    mcn = new RuneCervinRiderSHM();
                    break;
                # endregion

                # region Runed Halo
                case "Runed Halo":
                    mcn = new RunedHaloSHM();
                    break;
                # endregion

                # region Runes of the Deus
                case "Runes of the Deus":
                    mcn = new RunesoftheDeusSHM();
                    break;
                # endregion

                # region Rustrazor Butcher
                case "Rustrazor Butcher":
                    mcn = new RustrazorButcherSHM();
                    break;
                # endregion

                # region Safehold Duo
                case "Safehold Duo":
                    mcn = new SafeholdDuoSHM();
                    break;
                # endregion

                # region Safehold Elite
                case "Safehold Elite":
                    mcn = new SafeholdEliteSHM();
                    break;
                # endregion

                # region Safehold Sentry
                case "Safehold Sentry":
                    mcn = new SafeholdSentrySHM();
                    break;
                # endregion

                # region Safewright Quest
                case "Safewright Quest":
                    mcn = new SafewrightQuestSHM();
                    break;
                # endregion

                # region Sapseep Forest
                case "Sapseep Forest":
                    mcn = new SapseepForestSHM();
                    break;
                # endregion

                # region Savor the Moment
                case "Savor the Moment":
                    mcn = new SavortheMomentSHM();
                    break;
                # endregion

                # region Scar
                case "Scar":
                    mcn = new ScarSHM();
                    break;
                # endregion

                # region Scarscale Ritual
                case "Scarscale Ritual":
                    mcn = new ScarscaleRitualSHM();
                    break;
                # endregion

                # region Scrapbasket
                case "Scrapbasket":
                    mcn = new ScrapbasketSHM();
                    break;
                # endregion

                # region Scuttlemutt
                case "Scuttlemutt":
                    mcn = new ScuttlemuttSHM();
                    break;
                # endregion

                # region Scuzzback Marauders
                case "Scuzzback Marauders":
                    mcn = new ScuzzbackMaraudersSHM();
                    break;
                # endregion

                # region Scuzzback Scrapper
                case "Scuzzback Scrapper":
                    mcn = new ScuzzbackScrapperSHM();
                    break;
                # endregion

                # region Seedcradle Witch
                case "Seedcradle Witch":
                    mcn = new SeedcradleWitchSHM();
                    break;
                # endregion

                # region Shield of the Oversoul
                case "Shield of the Oversoul":
                    mcn = new ShieldoftheOversoulSHM();
                    break;
                # endregion

                # region Sickle Ripper
                case "Sickle Ripper":
                    mcn = new SickleRipperSHM();
                    break;
                # endregion

                # region Silkbind Faerie
                case "Silkbind Faerie":
                    mcn = new SilkbindFaerieSHM();
                    break;
                # endregion

                # region Sinking Feeling
                case "Sinking Feeling":
                    mcn = new SinkingFeelingSHM();
                    break;
                # endregion

                # region Slinking Giant
                case "Slinking Giant":
                    mcn = new SlinkingGiantSHM();
                    break;
                # endregion

                # region Smash to Smithereens
                case "Smash to Smithereens":
                    mcn = new SmashtoSmithereensSHM();
                    break;
                # endregion

                # region Smolder Initiate
                case "Smolder Initiate":
                    mcn = new SmolderInitiateSHM();
                    break;
                # endregion

                # region Somnomancer
                case "Somnomancer":
                    mcn = new SomnomancerSHM();
                    break;
                # endregion

                # region Sootstoke Kindler
                case "Sootstoke Kindler":
                    mcn = new SootstokeKindlerSHM();
                    break;
                # endregion

                # region Sootwalkers
                case "Sootwalkers":
                    mcn = new SootwalkersSHM();
                    break;
                # endregion

                # region Spawnwrithe
                case "Spawnwrithe":
                    mcn = new SpawnwritheSHM();
                    break;
                # endregion

                # region Spectral Procession
                case "Spectral Procession":
                    mcn = new SpectralProcessionSHM();
                    break;
                # endregion

                # region Spell Syphon
                case "Spell Syphon":
                    mcn = new SpellSyphonSHM();
                    break;
                # endregion

                # region Spiteflame Witch
                case "Spiteflame Witch":
                    mcn = new SpiteflameWitchSHM();
                    break;
                # endregion

                # region Spiteful Visions
                case "Spiteful Visions":
                    mcn = new SpitefulVisionsSHM();
                    break;
                # endregion

                # region Splitting Headache
                case "Splitting Headache":
                    mcn = new SplittingHeadacheSHM();
                    break;
                # endregion

                # region Steel of the Godhead
                case "Steel of the Godhead":
                    mcn = new SteeloftheGodheadSHM();
                    break;
                # endregion

                # region Strip Bare
                case "Strip Bare":
                    mcn = new StripBareSHM();
                    break;
                # endregion

                # region Sunken Ruins
                case "Sunken Ruins":
                    mcn = new SunkenRuinsSHM();
                    break;
                # endregion

                //# region Swamp
                //case "Swamp":
                //mcn = new SwampSHM();
                //break;
                //# endregion

                # region Swans of Bryn Argoll
                case "Swans of Bryn Argoll":
                    mcn = new SwansofBrynArgollSHM();
                    break;
                # endregion

                # region Sygg, River Cutthroat
                case "Sygg, River Cutthroat":
                    mcn = new SyggRiverCutthroatSHM();
                    break;
                # endregion

                # region Tatterkite
                case "Tatterkite":
                    mcn = new TatterkiteSHM();
                    break;
                # endregion

                # region Tattermunge Duo
                case "Tattermunge Duo":
                    mcn = new TattermungeDuoSHM();
                    break;
                # endregion

                # region Tattermunge Maniac
                case "Tattermunge Maniac":
                    mcn = new TattermungeManiacSHM();
                    break;
                # endregion

                # region Tattermunge Witch
                case "Tattermunge Witch":
                    mcn = new TattermungeWitchSHM();
                    break;
                # endregion

                # region Thistledown Duo
                case "Thistledown Duo":
                    mcn = new ThistledownDuoSHM();
                    break;
                # endregion

                # region Thistledown Liege
                case "Thistledown Liege":
                    mcn = new ThistledownLiegeSHM();
                    break;
                # endregion

                # region Thornwatch Scarecrow
                case "Thornwatch Scarecrow":
                    mcn = new ThornwatchScarecrowSHM();
                    break;
                # endregion

                # region Thought Reflection
                case "Thought Reflection":
                    mcn = new ThoughtReflectionSHM();
                    break;
                # endregion

                # region Thoughtweft Gambit
                case "Thoughtweft Gambit":
                    mcn = new ThoughtweftGambitSHM();
                    break;
                # endregion

                # region Toil to Renown
                case "Toil to Renown":
                    mcn = new ToiltoRenownSHM();
                    break;
                # endregion

                # region Torpor Dust
                case "Torpor Dust":
                    mcn = new TorporDustSHM();
                    break;
                # endregion

                # region Torrent of Souls
                case "Torrent of Souls":
                    mcn = new TorrentofSoulsSHM();
                    break;
                # endregion

                # region Torture
                case "Torture":
                    mcn = new TortureSHM();
                    break;
                # endregion

                # region Tower Above
                case "Tower Above":
                    mcn = new TowerAboveSHM();
                    break;
                # endregion

                # region Traitor's Roar
                case "Traitor's Roar":
                    mcn = new TraitorsRoarSHM();
                    break;
                # endregion

                # region Trip Noose
                case "Trip Noose":
                    mcn = new TripNooseSHM();
                    break;
                # endregion

                # region Turn to Mist
                case "Turn to Mist":
                    mcn = new TurntoMistSHM();
                    break;
                # endregion

                # region Twilight Shepherd
                case "Twilight Shepherd":
                    mcn = new TwilightShepherdSHM();
                    break;
                # endregion

                # region Tyrannize
                case "Tyrannize":
                    mcn = new TyrannizeSHM();
                    break;
                # endregion

                # region Umbral Mantle
                case "Umbral Mantle":
                    mcn = new UmbralMantleSHM();
                    break;
                # endregion

                # region Valleymaker
                case "Valleymaker":
                    mcn = new ValleymakerSHM();
                    break;
                # endregion

                # region Vexing Shusher
                case "Vexing Shusher":
                    mcn = new VexingShusherSHM();
                    break;
                # endregion

                # region Viridescent Wisps
                case "Viridescent Wisps":
                    mcn = new ViridescentWispsSHM();
                    break;
                # endregion

                # region Wanderbrine Rootcutters
                case "Wanderbrine Rootcutters":
                    mcn = new WanderbrineRootcuttersSHM();
                    break;
                # endregion

                # region Wasp Lancer
                case "Wasp Lancer":
                    mcn = new WaspLancerSHM();
                    break;
                # endregion

                # region Watchwing Scarecrow
                case "Watchwing Scarecrow":
                    mcn = new WatchwingScarecrowSHM();
                    break;
                # endregion

                # region Wheel of Sun and Moon
                case "Wheel of Sun and Moon":
                    mcn = new WheelofSunandMoonSHM();
                    break;
                # endregion

                # region Whimwader
                case "Whimwader":
                    mcn = new WhimwaderSHM();
                    break;
                # endregion

                # region Wicker Warcrawler
                case "Wicker Warcrawler":
                    mcn = new WickerWarcrawlerSHM();
                    break;
                # endregion

                # region Wild Swing
                case "Wild Swing":
                    mcn = new WildSwingSHM();
                    break;
                # endregion

                # region Wildslayer Elves
                case "Wildslayer Elves":
                    mcn = new WildslayerElvesSHM();
                    break;
                # endregion

                # region Wilt-Leaf Cavaliers
                case "Wilt-Leaf Cavaliers":
                    mcn = new WiltLeafCavaliersSHM();
                    break;
                # endregion

                # region Wilt-Leaf Liege
                case "Wilt-Leaf Liege":
                    mcn = new WiltLeafLiegeSHM();
                    break;
                # endregion

                # region Windbrisk Raptor
                case "Windbrisk Raptor":
                    mcn = new WindbriskRaptorSHM();
                    break;
                # endregion

                # region Wingrattle Scarecrow
                case "Wingrattle Scarecrow":
                    mcn = new WingrattleScarecrowSHM();
                    break;
                # endregion

                # region Witherscale Wurm
                case "Witherscale Wurm":
                    mcn = new WitherscaleWurmSHM();
                    break;
                # endregion

                # region Woeleecher
                case "Woeleecher":
                    mcn = new WoeleecherSHM();
                    break;
                # endregion

                # region Wooded Bastion
                case "Wooded Bastion":
                    mcn = new WoodedBastionSHM();
                    break;
                # endregion

                # region Woodfall Primus
                case "Woodfall Primus":
                    mcn = new WoodfallPrimusSHM();
                    break;
                # endregion

                # region Worldpurge
                case "Worldpurge":
                    mcn = new WorldpurgeSHM();
                    break;
                # endregion

                # region Wort, the Raidmother
                case "Wort, the Raidmother":
                    mcn = new WorttheRaidmotherSHM();
                    break;
                # endregion

                # region Wound Reflection
                case "Wound Reflection":
                    mcn = new WoundReflectionSHM();
                    break;
                # endregion

                # region Zealous Guardian
                case "Zealous Guardian":
                    mcn = new ZealousGuardianSHM();
                    break;
                # endregion


                # endregion

                # region Eventide

                # endregion

                # region Innistrad

                # endregion

                # region Dark Ascension
                # region Afflicted Deserter/Werewolf Ransacker
                case "Afflicted Deserter/Werewolf Ransacker":
                    mcn = new AfflictedDeserterWerewolfRansackerDKA();
                    break;
                # endregion

                # region Alpha Brawl
                case "Alpha Brawl":
                    mcn = new AlphaBrawlDKA();
                    break;
                # endregion

                # region Altar of the Lost
                case "Altar of the Lost":
                    mcn = new AltaroftheLostDKA();
                    break;
                # endregion

                # region Archangel's Light
                case "Archangel's Light":
                    mcn = new ArchangelsLightDKA();
                    break;
                # endregion

                # region Artful Dodge
                case "Artful Dodge":
                    mcn = new ArtfulDodgeDKA();
                    break;
                # endregion

                # region Avacyn's Collar
                case "Avacyn's Collar":
                    mcn = new AvacynsCollarDKA();
                    break;
                # endregion

                # region Bar the Door
                case "Bar the Door":
                    mcn = new BartheDoorDKA();
                    break;
                # endregion

                # region Beguiler of Wills
                case "Beguiler of Wills":
                    mcn = new BeguilerofWillsDKA();
                    break;
                # endregion

                # region Black Cat
                case "Black Cat":
                    mcn = new BlackCatDKA();
                    break;
                # endregion

                # region Blood Feud
                case "Blood Feud":
                    mcn = new BloodFeudDKA();
                    break;
                # endregion

                # region Bone to Ash
                case "Bone to Ash":
                    mcn = new BonetoAshDKA();
                    break;
                # endregion

                # region Break of Day
                case "Break of Day":
                    mcn = new BreakofDayDKA();
                    break;
                # endregion

                # region Briarpack Alpha
                case "Briarpack Alpha":
                    mcn = new BriarpackAlphaDKA();
                    break;
                # endregion

                # region Burden of Guilt
                case "Burden of Guilt":
                    mcn = new BurdenofGuiltDKA();
                    break;
                # endregion

                # region Burning Oil
                case "Burning Oil":
                    mcn = new BurningOilDKA();
                    break;
                # endregion

                # region Call to the Kindred
                case "Call to the Kindred":
                    mcn = new CalltotheKindredDKA();
                    break;
                # endregion

                # region Chalice of Life/Chalice of Death
                case "Chalice of Life/Chalice of Death":
                    mcn = new ChaliceofLifeChaliceofDeathDKA();
                    break;
                # endregion

                # region Chant of the Skifsang
                case "Chant of the Skifsang":
                    mcn = new ChantoftheSkifsangDKA();
                    break;
                # endregion

                # region Chill of Foreboding
                case "Chill of Foreboding":
                    mcn = new ChillofForebodingDKA();
                    break;
                # endregion

                # region Chosen of Markov/Markov's Servant
                case "Chosen of Markov/Markov's Servant":
                    mcn = new ChosenofMarkovMarkovsServantDKA();
                    break;
                # endregion

                # region Clinging Mists
                case "Clinging Mists":
                    mcn = new ClingingMistsDKA();
                    break;
                # endregion

                # region Counterlash
                case "Counterlash":
                    mcn = new CounterlashDKA();
                    break;
                # endregion

                # region Crushing Vines
                case "Crushing Vines":
                    mcn = new CrushingVinesDKA();
                    break;
                # endregion

                # region Curse of Bloodletting
                case "Curse of Bloodletting":
                    mcn = new CurseofBloodlettingDKA();
                    break;
                # endregion

                # region Curse of Echoes
                case "Curse of Echoes":
                    mcn = new CurseofEchoesDKA();
                    break;
                # endregion

                # region Curse of Exhaustion
                case "Curse of Exhaustion":
                    mcn = new CurseofExhaustionDKA();
                    break;
                # endregion

                # region Curse of Misfortunes
                case "Curse of Misfortunes":
                    mcn = new CurseofMisfortunesDKA();
                    break;
                # endregion

                # region Curse of Thirst
                case "Curse of Thirst":
                    mcn = new CurseofThirstDKA();
                    break;
                # endregion

                # region Dawntreader Elk
                case "Dawntreader Elk":
                    mcn = new DawntreaderElkDKA();
                    break;
                # endregion

                # region Deadly Allure
                case "Deadly Allure":
                    mcn = new DeadlyAllureDKA();
                    break;
                # endregion

                # region Death's Caress
                case "Death's Caress":
                    mcn = new DeathsCaressDKA();
                    break;
                # endregion

                # region Deranged Outcast
                case "Deranged Outcast":
                    mcn = new DerangedOutcastDKA();
                    break;
                # endregion

                # region Diregraf Captain
                case "Diregraf Captain":
                    mcn = new DiregrafCaptainDKA();
                    break;
                # endregion

                # region Divination
                case "Divination":
                    mcn = new DivinationDKA();
                    break;
                # endregion

                # region Drogskol Captain
                case "Drogskol Captain":
                    mcn = new DrogskolCaptainDKA();
                    break;
                # endregion

                # region Drogskol Reaver
                case "Drogskol Reaver":
                    mcn = new DrogskolReaverDKA();
                    break;
                # endregion

                # region Dungeon Geists
                case "Dungeon Geists":
                    mcn = new DungeonGeistsDKA();
                    break;
                # endregion

                # region Elbrus, the Binding Blade/Withengar Unbound
                case "Elbrus, the Binding Blade/Withengar Unbound":
                    mcn = new ElbrustheBindingBladeWithengarUnboundDKA();
                    break;
                # endregion

                # region Elgaud Inquisitor
                case "Elgaud Inquisitor":
                    mcn = new ElgaudInquisitorDKA();
                    break;
                # endregion

                # region Erdwal Ripper
                case "Erdwal Ripper":
                    mcn = new ErdwalRipperDKA();
                    break;
                # endregion

                # region Evolving Wilds
                case "Evolving Wilds":
                    mcn = new EvolvingWildsDKA();
                    break;
                # endregion

                # region Executioner's Hood
                case "Executioner's Hood":
                    mcn = new ExecutionersHoodDKA();
                    break;
                # endregion

                # region Faithless Looting
                case "Faithless Looting":
                    mcn = new FaithlessLootingDKA();
                    break;
                # endregion

                # region Faith's Shield
                case "Faith's Shield":
                    mcn = new FaithsShieldDKA();
                    break;
                # endregion

                # region Falkenrath Aristocrat
                case "Falkenrath Aristocrat":
                    mcn = new FalkenrathAristocratDKA();
                    break;
                # endregion

                # region Falkenrath Torturer
                case "Falkenrath Torturer":
                    mcn = new FalkenrathTorturerDKA();
                    break;
                # endregion

                # region Farbog Boneflinger
                case "Farbog Boneflinger":
                    mcn = new FarbogBoneflingerDKA();
                    break;
                # endregion

                # region Favor of the Woods
                case "Favor of the Woods":
                    mcn = new FavoroftheWoodsDKA();
                    break;
                # endregion

                # region Feed the Pack
                case "Feed the Pack":
                    mcn = new FeedthePackDKA();
                    break;
                # endregion

                # region Fiend of the Shadows
                case "Fiend of the Shadows":
                    mcn = new FiendoftheShadowsDKA();
                    break;
                # endregion

                # region Fires of Undeath
                case "Fires of Undeath":
                    mcn = new FiresofUndeathDKA();
                    break;
                # endregion

                # region Flayer of the Hatebound
                case "Flayer of the Hatebound":
                    mcn = new FlayeroftheHateboundDKA();
                    break;
                # endregion

                # region Fling
                case "Fling":
                    mcn = new FlingDKA();
                    break;
                # endregion

                # region Forge Devil
                case "Forge Devil":
                    mcn = new ForgeDevilDKA();
                    break;
                # endregion

                # region Gather the Townsfolk
                case "Gather the Townsfolk":
                    mcn = new GathertheTownsfolkDKA();
                    break;
                # endregion

                # region Gavony Ironwright
                case "Gavony Ironwright":
                    mcn = new GavonyIronwrightDKA();
                    break;
                # endregion

                # region Geralf's Messenger
                case "Geralf's Messenger":
                    mcn = new GeralfsMessengerDKA();
                    break;
                # endregion

                # region Geralf's Mindcrusher
                case "Geralf's Mindcrusher":
                    mcn = new GeralfsMindcrusherDKA();
                    break;
                # endregion

                # region Ghoultree
                case "Ghoultree":
                    mcn = new GhoultreeDKA();
                    break;
                # endregion

                # region Grafdigger's Cage
                case "Grafdigger's Cage":
                    mcn = new GrafdiggersCageDKA();
                    break;
                # endregion

                # region Gravecrawler
                case "Gravecrawler":
                    mcn = new GravecrawlerDKA();
                    break;
                # endregion

                # region Gravepurge
                case "Gravepurge":
                    mcn = new GravepurgeDKA();
                    break;
                # endregion

                # region Gravetiller Wurm
                case "Gravetiller Wurm":
                    mcn = new GravetillerWurmDKA();
                    break;
                # endregion

                # region Grim Backwoods
                case "Grim Backwoods":
                    mcn = new GrimBackwoodsDKA();
                    break;
                # endregion

                # region Grim Flowering
                case "Grim Flowering":
                    mcn = new GrimFloweringDKA();
                    break;
                # endregion

                # region Griptide
                case "Griptide":
                    mcn = new GriptideDKA();
                    break;
                # endregion

                # region Gruesome Discovery
                case "Gruesome Discovery":
                    mcn = new GruesomeDiscoveryDKA();
                    break;
                # endregion

                # region Harrowing Journey
                case "Harrowing Journey":
                    mcn = new HarrowingJourneyDKA();
                    break;
                # endregion

                # region Haunted Fengraf
                case "Haunted Fengraf":
                    mcn = new HauntedFengrafDKA();
                    break;
                # endregion

                # region Havengul Lich
                case "Havengul Lich":
                    mcn = new HavengulLichDKA();
                    break;
                # endregion

                # region Havengul Runebinder
                case "Havengul Runebinder":
                    mcn = new HavengulRunebinderDKA();
                    break;
                # endregion

                # region Headless Skaab
                case "Headless Skaab":
                    mcn = new HeadlessSkaabDKA();
                    break;
                # endregion

                # region Heavy Mattock
                case "Heavy Mattock":
                    mcn = new HeavyMattockDKA();
                    break;
                # endregion

                # region Heckling Fiends
                case "Heckling Fiends":
                    mcn = new HecklingFiendsDKA();
                    break;
                # endregion

                # region Hellrider
                case "Hellrider":
                    mcn = new HellriderDKA();
                    break;
                # endregion

                # region Helvault
                case "Helvault":
                    mcn = new HelvaultDKA();
                    break;
                # endregion

                # region Highborn Ghoul
                case "Highborn Ghoul":
                    mcn = new HighbornGhoulDKA();
                    break;
                # endregion

                # region Hinterland Hermit/Hinterland Scourge
                case "Hinterland Hermit/Hinterland Scourge":
                    mcn = new HinterlandHermitHinterlandScourgeDKA();
                    break;
                # endregion

                # region Hollowhenge Beast
                case "Hollowhenge Beast":
                    mcn = new HollowhengeBeastDKA();
                    break;
                # endregion

                # region Hollowhenge Spirit
                case "Hollowhenge Spirit":
                    mcn = new HollowhengeSpiritDKA();
                    break;
                # endregion

                # region Hunger of the Howlpack
                case "Hunger of the Howlpack":
                    mcn = new HungeroftheHowlpackDKA();
                    break;
                # endregion

                # region Huntmaster of the Fells/Ravager of the Fells
                case "Huntmaster of the Fells/Ravager of the Fells":
                    mcn = new HuntmasteroftheFellsRavageroftheFellsDKA();
                    break;
                # endregion

                # region Immerwolf
                case "Immerwolf":
                    mcn = new ImmerwolfDKA();
                    break;
                # endregion

                # region Increasing Ambition
                case "Increasing Ambition":
                    mcn = new IncreasingAmbitionDKA();
                    break;
                # endregion

                # region Increasing Confusion
                case "Increasing Confusion":
                    mcn = new IncreasingConfusionDKA();
                    break;
                # endregion

                # region Increasing Devotion
                case "Increasing Devotion":
                    mcn = new IncreasingDevotionDKA();
                    break;
                # endregion

                # region Increasing Savagery
                case "Increasing Savagery":
                    mcn = new IncreasingSavageryDKA();
                    break;
                # endregion

                # region Increasing Vengeance
                case "Increasing Vengeance":
                    mcn = new IncreasingVengeanceDKA();
                    break;
                # endregion

                # region Jar of Eyeballs
                case "Jar of Eyeballs":
                    mcn = new JarofEyeballsDKA();
                    break;
                # endregion

                # region Kessig Recluse
                case "Kessig Recluse":
                    mcn = new KessigRecluseDKA();
                    break;
                # endregion

                # region Lambholt Elder/Silverpelt Werewolf
                case "Lambholt Elder/Silverpelt Werewolf":
                    mcn = new LambholtElderSilverpeltWerewolfDKA();
                    break;
                # endregion

                # region Lingering Souls
                case "Lingering Souls":
                    mcn = new LingeringSoulsDKA();
                    break;
                # endregion

                # region Lost in the Woods
                case "Lost in the Woods":
                    mcn = new LostintheWoodsDKA();
                    break;
                # endregion

                # region Loyal Cathar/Unhallowed Cathar
                case "Loyal Cathar/Unhallowed Cathar":
                    mcn = new LoyalCatharUnhallowedCatharDKA();
                    break;
                # endregion

                # region Markov Blademaster
                case "Markov Blademaster":
                    mcn = new MarkovBlademasterDKA();
                    break;
                # endregion

                # region Markov Warlord
                case "Markov Warlord":
                    mcn = new MarkovWarlordDKA();
                    break;
                # endregion

                # region Midnight Guard
                case "Midnight Guard":
                    mcn = new MidnightGuardDKA();
                    break;
                # endregion

                # region Mikaeus, the Unhallowed
                case "Mikaeus, the Unhallowed":
                    mcn = new MikaeustheUnhallowedDKA();
                    break;
                # endregion

                # region Mondronen Shaman/Tovolar's Magehunter
                case "Mondronen Shaman/Tovolar's Magehunter":
                    mcn = new MondronenShamanTovolarsMagehunterDKA();
                    break;
                # endregion

                # region Moonveil Dragon
                case "Moonveil Dragon":
                    mcn = new MoonveilDragonDKA();
                    break;
                # endregion

                # region Mystic Retrieval
                case "Mystic Retrieval":
                    mcn = new MysticRetrievalDKA();
                    break;
                # endregion

                # region Nearheath Stalker
                case "Nearheath Stalker":
                    mcn = new NearheathStalkerDKA();
                    break;
                # endregion

                # region Nephalia Seakite
                case "Nephalia Seakite":
                    mcn = new NephaliaSeakiteDKA();
                    break;
                # endregion

                # region Niblis of the Breath
                case "Niblis of the Breath":
                    mcn = new NiblisoftheBreathDKA();
                    break;
                # endregion

                # region Niblis of the Mist
                case "Niblis of the Mist":
                    mcn = new NiblisoftheMistDKA();
                    break;
                # endregion

                # region Niblis of the Urn
                case "Niblis of the Urn":
                    mcn = new NiblisoftheUrnDKA();
                    break;
                # endregion

                # region Predator Ooze
                case "Predator Ooze":
                    mcn = new PredatorOozeDKA();
                    break;
                # endregion

                # region Pyreheart Wolf
                case "Pyreheart Wolf":
                    mcn = new PyreheartWolfDKA();
                    break;
                # endregion

                # region Ravenous Demon/Archdemon of Greed
                case "Ravenous Demon/Archdemon of Greed":
                    mcn = new RavenousDemonArchdemonofGreedDKA();
                    break;
                # endregion

                # region Ray of Revelation
                case "Ray of Revelation":
                    mcn = new RayofRevelationDKA();
                    break;
                # endregion

                # region Reap the Seagraf
                case "Reap the Seagraf":
                    mcn = new ReaptheSeagrafDKA();
                    break;
                # endregion

                # region Relentless Skaabs
                case "Relentless Skaabs":
                    mcn = new RelentlessSkaabsDKA();
                    break;
                # endregion

                # region Requiem Angel
                case "Requiem Angel":
                    mcn = new RequiemAngelDKA();
                    break;
                # endregion

                # region Russet Wolves
                case "Russet Wolves":
                    mcn = new RussetWolvesDKA();
                    break;
                # endregion

                # region Sanctuary Cat
                case "Sanctuary Cat":
                    mcn = new SanctuaryCatDKA();
                    break;
                # endregion

                # region Saving Grasp
                case "Saving Grasp":
                    mcn = new SavingGraspDKA();
                    break;
                # endregion

                # region Scorch the Fields
                case "Scorch the Fields":
                    mcn = new ScorchtheFieldsDKA();
                    break;
                # endregion

                # region Scorned Villager/Moonscarred Werewolf
                case "Scorned Villager/Moonscarred Werewolf":
                    mcn = new ScornedVillagerMoonscarredWerewolfDKA();
                    break;
                # endregion

                # region Screeching Skaab
                case "Screeching Skaab":
                    mcn = new ScreechingSkaabDKA();
                    break;
                # endregion

                # region Seance
                case "Seance":
                    mcn = new SeanceDKA();
                    break;
                # endregion

                # region Secrets of the Dead
                case "Secrets of the Dead":
                    mcn = new SecretsoftheDeadDKA();
                    break;
                # endregion

                # region Shattered Perception
                case "Shattered Perception":
                    mcn = new ShatteredPerceptionDKA();
                    break;
                # endregion

                # region Shriekgeist
                case "Shriekgeist":
                    mcn = new ShriekgeistDKA();
                    break;
                # endregion

                # region Sightless Ghoul
                case "Sightless Ghoul":
                    mcn = new SightlessGhoulDKA();
                    break;
                # endregion

                # region Silverclaw Griffin
                case "Silverclaw Griffin":
                    mcn = new SilverclawGriffinDKA();
                    break;
                # endregion

                # region Skillful Lunge
                case "Skillful Lunge":
                    mcn = new SkillfulLungeDKA();
                    break;
                # endregion

                # region Skirsdag Flayer
                case "Skirsdag Flayer":
                    mcn = new SkirsdagFlayerDKA();
                    break;
                # endregion

                # region Somberwald Dryad
                case "Somberwald Dryad":
                    mcn = new SomberwaldDryadDKA();
                    break;
                # endregion

                # region Sorin, Lord of Innistrad
                case "Sorin, Lord of Innistrad":
                    mcn = new SorinLordofInnistradDKA();
                    break;
                # endregion

                # region Soul Seizer/Ghastly Haunting
                case "Soul Seizer/Ghastly Haunting":
                    mcn = new SoulSeizerGhastlyHauntingDKA();
                    break;
                # endregion

                # region Spiteful Shadows
                case "Spiteful Shadows":
                    mcn = new SpitefulShadowsDKA();
                    break;
                # endregion

                # region Stormbound Geist
                case "Stormbound Geist":
                    mcn = new StormboundGeistDKA();
                    break;
                # endregion

                # region Strangleroot Geist
                case "Strangleroot Geist":
                    mcn = new StranglerootGeistDKA();
                    break;
                # endregion

                # region Stromkirk Captain
                case "Stromkirk Captain":
                    mcn = new StromkirkCaptainDKA();
                    break;
                # endregion

                # region Sudden Disappearance
                case "Sudden Disappearance":
                    mcn = new SuddenDisappearanceDKA();
                    break;
                # endregion

                # region Talons of Falkenrath
                case "Talons of Falkenrath":
                    mcn = new TalonsofFalkenrathDKA();
                    break;
                # endregion

                # region Thalia, Guardian of Thraben
                case "Thalia, Guardian of Thraben":
                    mcn = new ThaliaGuardianofThrabenDKA();
                    break;
                # endregion

                # region Thought Scour
                case "Thought Scour":
                    mcn = new ThoughtScourDKA();
                    break;
                # endregion

                # region Thraben Doomsayer
                case "Thraben Doomsayer":
                    mcn = new ThrabenDoomsayerDKA();
                    break;
                # endregion

                # region Thraben Heretic
                case "Thraben Heretic":
                    mcn = new ThrabenHereticDKA();
                    break;
                # endregion

                # region Torch Fiend
                case "Torch Fiend":
                    mcn = new TorchFiendDKA();
                    break;
                # endregion

                # region Tower Geist
                case "Tower Geist":
                    mcn = new TowerGeistDKA();
                    break;
                # endregion

                # region Tracker's Instincts
                case "Tracker's Instincts":
                    mcn = new TrackersInstinctsDKA();
                    break;
                # endregion

                # region Tragic Slip
                case "Tragic Slip":
                    mcn = new TragicSlipDKA();
                    break;
                # endregion

                # region Ulvenwald Bear
                case "Ulvenwald Bear":
                    mcn = new UlvenwaldBearDKA();
                    break;
                # endregion

                # region Undying Evil
                case "Undying Evil":
                    mcn = new UndyingEvilDKA();
                    break;
                # endregion

                # region Vault of the Archangel
                case "Vault of the Archangel":
                    mcn = new VaultoftheArchangelDKA();
                    break;
                # endregion

                # region Vengeful Vampire
                case "Vengeful Vampire":
                    mcn = new VengefulVampireDKA();
                    break;
                # endregion

                # region Village Survivors
                case "Village Survivors":
                    mcn = new VillageSurvivorsDKA();
                    break;
                # endregion

                # region Vorapede
                case "Vorapede":
                    mcn = new VorapedeDKA();
                    break;
                # endregion

                # region Wakedancer
                case "Wakedancer":
                    mcn = new WakedancerDKA();
                    break;
                # endregion

                # region Warden of the Wall
                case "Warden of the Wall":
                    mcn = new WardenoftheWallDKA();
                    break;
                # endregion

                # region Wild Hunger
                case "Wild Hunger":
                    mcn = new WildHungerDKA();
                    break;
                # endregion

                # region Wolfbitten Captive/Krallenhorde Killer
                case "Wolfbitten Captive/Krallenhorde Killer":
                    mcn = new WolfbittenCaptiveKrallenhordeKillerDKA();
                    break;
                # endregion

                # region Wolfhunter's Quiver
                case "Wolfhunter's Quiver":
                    mcn = new WolfhuntersQuiverDKA();
                    break;
                # endregion

                # region Wrack with Madness
                case "Wrack with Madness":
                    mcn = new WrackwithMadnessDKA();
                    break;
                # endregion

                # region Young Wolf
                case "Young Wolf":
                    mcn = new YoungWolfDKA();
                    break;
                # endregion

                # region Zombie Apocalypse
                case "Zombie Apocalypse":
                    mcn = new ZombieApocalypseDKA();
                    break;
                # endregion


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

                //# region Barter in Blood
                //case "Barter in Blood":
                //    mcn = new BarterinBloodAVR();
                //    break;
                //# endregion

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

                //# region Forest
                //case "Forest":
                //    mcn = new ForestAVR();
                //    break;
                //# endregion

                //# region Gallows at Willow Hill
                //case "Gallows at Willow Hill":
                //    mcn = new GallowsatWillowHillAVR();
                //    break;
                //# endregion

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

                //# region Gloomwidow
                //case "Gloomwidow":
                //    mcn = new GloomwidowAVR();
                //    break;
                //# endregion

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

                //# region Island
                //case "Island":
                //    mcn = new IslandAVR();
                //    break;
                //# endregion

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

                //# region Mountain
                //case "Mountain":
                //    mcn = new MountainAVR();
                //    break;
                //# endregion

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

                //# region Plains
                //case "Plains":
                //    mcn = new PlainsAVR();
                //    break;
                //# endregion

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

                //# region Swamp
                //case"Swamp":
                //    mcn = new SwampAVR();
                //    break;
                //# endregion

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

                # region Shards of Alara
                # region Ad Nauseam
                case "Ad Nauseam":
                    mcn = new AdNauseamALA();
                    break;
                # endregion

                # region Agony Warp
                case "Agony Warp":
                    mcn = new AgonyWarpALA();
                    break;
                # endregion

                # region Ajani Vengeant
                case "Ajani Vengeant":
                    mcn = new AjaniVengeantALA();
                    break;
                # endregion

                # region Akrasan Squire
                case "Akrasan Squire":
                    mcn = new AkrasanSquireALA();
                    break;
                # endregion

                # region Algae Gharial
                case "Algae Gharial":
                    mcn = new AlgaeGharialALA();
                    break;
                # endregion

                # region Angelic Benediction
                case "Angelic Benediction":
                    mcn = new AngelicBenedictionALA();
                    break;
                # endregion

                # region Angel's Herald
                case "Angel's Herald":
                    mcn = new AngelsHeraldALA();
                    break;
                # endregion

                # region Angelsong
                case "Angelsong":
                    mcn = new AngelsongALA();
                    break;
                # endregion

                # region Arcane Sanctum
                case "Arcane Sanctum":
                    mcn = new ArcaneSanctumALA();
                    break;
                # endregion

                # region Archdemon of Unx
                case "Archdemon of Unx":
                    mcn = new ArchdemonofUnxALA();
                    break;
                # endregion

                # region Banewasp Affliction
                case "Banewasp Affliction":
                    mcn = new BanewaspAfflictionALA();
                    break;
                # endregion

                # region Bant Battlemage
                case "Bant Battlemage":
                    mcn = new BantBattlemageALA();
                    break;
                # endregion

                # region Bant Charm
                case "Bant Charm":
                    mcn = new BantCharmALA();
                    break;
                # endregion

                # region Bant Panorama
                case "Bant Panorama":
                    mcn = new BantPanoramaALA();
                    break;
                # endregion

                # region Battlegrace Angel
                case "Battlegrace Angel":
                    mcn = new BattlegraceAngelALA();
                    break;
                # endregion

                # region Behemoth's Herald
                case "Behemoth's Herald":
                    mcn = new BehemothsHeraldALA();
                    break;
                # endregion

                # region Blightning
                case "Blightning":
                    mcn = new BlightningALA();
                    break;
                # endregion

                # region Blister Beetle
                case "Blister Beetle":
                    mcn = new BlisterBeetleALA();
                    break;
                # endregion

                # region Blood Cultist
                case "Blood Cultist":
                    mcn = new BloodCultistALA();
                    break;
                # endregion

                # region Bloodpyre Elemental
                case "Bloodpyre Elemental":
                    mcn = new BloodpyreElementalALA();
                    break;
                # endregion

                # region Bloodthorn Taunter
                case "Bloodthorn Taunter":
                    mcn = new BloodthornTaunterALA();
                    break;
                # endregion

                //# region Bone Splinters
                //case "Bone Splinters":
                //mcn = new BoneSplintersALA();
                //break;
                //# endregion

                # region Branching Bolt
                case "Branching Bolt":
                    mcn = new BranchingBoltALA();
                    break;
                # endregion

                # region Brilliant Ultimatum
                case "Brilliant Ultimatum":
                    mcn = new BrilliantUltimatumALA();
                    break;
                # endregion

                # region Broodmate Dragon
                case "Broodmate Dragon":
                    mcn = new BroodmateDragonALA();
                    break;
                # endregion

                # region Bull Cerodon
                case "Bull Cerodon":
                    mcn = new BullCerodonALA();
                    break;
                # endregion

                # region Caldera Hellion
                case "Caldera Hellion":
                    mcn = new CalderaHellionALA();
                    break;
                # endregion

                # region Call to Heel
                case "Call to Heel":
                    mcn = new CalltoHeelALA();
                    break;
                # endregion

                # region Cancel
                case "Cancel":
                    mcn = new CancelALA();
                    break;
                # endregion

                # region Carrion Thrash
                case "Carrion Thrash":
                    mcn = new CarrionThrashALA();
                    break;
                # endregion

                # region Cathartic Adept
                case "Cathartic Adept":
                    mcn = new CatharticAdeptALA();
                    break;
                # endregion

                # region Cavern Thoctar
                case "Cavern Thoctar":
                    mcn = new CavernThoctarALA();
                    break;
                # endregion

                # region Clarion Ultimatum
                case "Clarion Ultimatum":
                    mcn = new ClarionUltimatumALA();
                    break;
                # endregion

                # region Cloudheath Drake
                case "Cloudheath Drake":
                    mcn = new CloudheathDrakeALA();
                    break;
                # endregion

                # region Coma Veil
                case "Coma Veil":
                    mcn = new ComaVeilALA();
                    break;
                # endregion

                # region Corpse Connoisseur
                case "Corpse Connoisseur":
                    mcn = new CorpseConnoisseurALA();
                    break;
                # endregion

                # region Courier's Capsule
                case "Courier's Capsule":
                    mcn = new CouriersCapsuleALA();
                    break;
                # endregion

                # region Court Archers
                case "Court Archers":
                    mcn = new CourtArchersALA();
                    break;
                # endregion

                # region Covenant of Minds
                case "Covenant of Minds":
                    mcn = new CovenantofMindsALA();
                    break;
                # endregion

                # region Cradle of Vitality
                case "Cradle of Vitality":
                    mcn = new CradleofVitalityALA();
                    break;
                # endregion

                # region Crucible of Fire
                case "Crucible of Fire":
                    mcn = new CrucibleofFireALA();
                    break;
                # endregion

                # region Cruel Ultimatum
                case "Cruel Ultimatum":
                    mcn = new CruelUltimatumALA();
                    break;
                # endregion

                # region Crumbling Necropolis
                case "Crumbling Necropolis":
                    mcn = new CrumblingNecropolisALA();
                    break;
                # endregion

                # region Cunning Lethemancer
                case "Cunning Lethemancer":
                    mcn = new CunningLethemancerALA();
                    break;
                # endregion

                # region Cylian Elf
                case "Cylian Elf":
                    mcn = new CylianElfALA();
                    break;
                # endregion

                # region Dawnray Archer
                case "Dawnray Archer":
                    mcn = new DawnrayArcherALA();
                    break;
                # endregion

                # region Death Baron
                case "Death Baron":
                    mcn = new DeathBaronALA();
                    break;
                # endregion

                # region Deathgreeter
                case "Deathgreeter":
                    mcn = new DeathgreeterALA();
                    break;
                # endregion

                # region Deft Duelist
                case "Deft Duelist":
                    mcn = new DeftDuelistALA();
                    break;
                # endregion

                # region Demon's Herald
                case "Demon's Herald":
                    mcn = new DemonsHeraldALA();
                    break;
                # endregion

                # region Dispeller's Capsule
                case "Dispeller's Capsule":
                    mcn = new DispellersCapsuleALA();
                    break;
                # endregion

                # region Dragon Fodder
                case "Dragon Fodder":
                    mcn = new DragonFodderALA();
                    break;
                # endregion

                # region Dragon's Herald
                case "Dragon's Herald":
                    mcn = new DragonsHeraldALA();
                    break;
                # endregion

                # region Dreg Reaver
                case "Dreg Reaver":
                    mcn = new DregReaverALA();
                    break;
                # endregion

                # region Dregscape Zombie
                case "Dregscape Zombie":
                    mcn = new DregscapeZombieALA();
                    break;
                # endregion

                # region Druid of the Anima
                case "Druid of the Anima":
                    mcn = new DruidoftheAnimaALA();
                    break;
                # endregion

                # region Drumhunter
                case "Drumhunter":
                    mcn = new DrumhunterALA();
                    break;
                # endregion

                # region Elspeth, Knight-Errant
                case "Elspeth, Knight-Errant":
                    mcn = new ElspethKnightErrantALA();
                    break;
                # endregion

                # region Elvish Visionary
                case "Elvish Visionary":
                    mcn = new ElvishVisionaryALA();
                    break;
                # endregion

                # region Empyrial Archangel
                case "Empyrial Archangel":
                    mcn = new EmpyrialArchangelALA();
                    break;
                # endregion

                # region Esper Battlemage
                case "Esper Battlemage":
                    mcn = new EsperBattlemageALA();
                    break;
                # endregion

                # region Esper Charm
                case "Esper Charm":
                    mcn = new EsperCharmALA();
                    break;
                # endregion

                # region Esper Panorama
                case "Esper Panorama":
                    mcn = new EsperPanoramaALA();
                    break;
                # endregion

                # region Etherium Astrolabe
                case "Etherium Astrolabe":
                    mcn = new EtheriumAstrolabeALA();
                    break;
                # endregion

                # region Etherium Sculptor
                case "Etherium Sculptor":
                    mcn = new EtheriumSculptorALA();
                    break;
                # endregion

                # region Ethersworn Canonist
                case "Ethersworn Canonist":
                    mcn = new EtherswornCanonistALA();
                    break;
                # endregion

                # region Excommunicate
                case "Excommunicate":
                    mcn = new ExcommunicateALA();
                    break;
                # endregion

                # region Executioner's Capsule
                case "Executioner's Capsule":
                    mcn = new ExecutionersCapsuleALA();
                    break;
                # endregion

                # region Exuberant Firestoker
                case "Exuberant Firestoker":
                    mcn = new ExuberantFirestokerALA();
                    break;
                # endregion

                # region Fatestitcher
                case "Fatestitcher":
                    mcn = new FatestitcherALA();
                    break;
                # endregion

                # region Feral Hydra
                case "Feral Hydra":
                    mcn = new FeralHydraALA();
                    break;
                # endregion

                # region Filigree Sages
                case "Filigree Sages":
                    mcn = new FiligreeSagesALA();
                    break;
                # endregion

                # region Fire-Field Ogre
                case "Fire-Field Ogre":
                    mcn = new FireFieldOgreALA();
                    break;
                # endregion

                # region Flameblast Dragon
                case "Flameblast Dragon":
                    mcn = new FlameblastDragonALA();
                    break;
                # endregion

                # region Fleshbag Marauder
                case "Fleshbag Marauder":
                    mcn = new FleshbagMarauderALA();
                    break;
                # endregion

                //# region Forest
                //case "Forest":
                //mcn = new ForestALA();
                //break;
                //# endregion

                # region Gather Specimens
                case "Gather Specimens":
                    mcn = new GatherSpecimensALA();
                    break;
                # endregion

                # region Gift of the Gargantuan
                case "Gift of the Gargantuan":
                    mcn = new GiftoftheGargantuanALA();
                    break;
                # endregion

                # region Glaze Fiend
                case "Glaze Fiend":
                    mcn = new GlazeFiendALA();
                    break;
                # endregion

                # region Goblin Assault
                case "Goblin Assault":
                    mcn = new GoblinAssaultALA();
                    break;
                # endregion

                # region Goblin Deathraiders
                case "Goblin Deathraiders":
                    mcn = new GoblinDeathraidersALA();
                    break;
                # endregion

                # region Goblin Mountaineer
                case "Goblin Mountaineer":
                    mcn = new GoblinMountaineerALA();
                    break;
                # endregion

                # region Godsire
                case "Godsire":
                    mcn = new GodsireALA();
                    break;
                # endregion

                # region Godtoucher
                case "Godtoucher":
                    mcn = new GodtoucherALA();
                    break;
                # endregion

                # region Grixis Battlemage
                case "Grixis Battlemage":
                    mcn = new GrixisBattlemageALA();
                    break;
                # endregion

                # region Grixis Charm
                case "Grixis Charm":
                    mcn = new GrixisCharmALA();
                    break;
                # endregion

                # region Grixis Panorama
                case "Grixis Panorama":
                    mcn = new GrixisPanoramaALA();
                    break;
                # endregion

                # region Guardians of Akrasa
                case "Guardians of Akrasa":
                    mcn = new GuardiansofAkrasaALA();
                    break;
                # endregion

                # region Gustrider Exuberant
                case "Gustrider Exuberant":
                    mcn = new GustriderExuberantALA();
                    break;
                # endregion

                # region Hellkite Overlord
                case "Hellkite Overlord":
                    mcn = new HellkiteOverlordALA();
                    break;
                # endregion

                # region Hell's Thunder
                case "Hell's Thunder":
                    mcn = new HellsThunderALA();
                    break;
                # endregion

                # region Hindering Light
                case "Hindering Light":
                    mcn = new HinderingLightALA();
                    break;
                # endregion

                # region Hissing Iguanar
                case "Hissing Iguanar":
                    mcn = new HissingIguanarALA();
                    break;
                # endregion

                # region Immortal Coil
                case "Immortal Coil":
                    mcn = new ImmortalCoilALA();
                    break;
                # endregion

                # region Incurable Ogre
                case "Incurable Ogre":
                    mcn = new IncurableOgreALA();
                    break;
                # endregion

                # region Infest
                case "Infest":
                    mcn = new InfestALA();
                    break;
                # endregion

                # region Invincible Hymn
                case "Invincible Hymn":
                    mcn = new InvincibleHymnALA();
                    break;
                # endregion

                //# region Island
                //case "Island":
                //mcn = new IslandALA();
                //break;
                //# endregion

                # region Jhessian Infiltrator
                case "Jhessian Infiltrator":
                    mcn = new JhessianInfiltratorALA();
                    break;
                # endregion

                # region Jhessian Lookout
                case "Jhessian Lookout":
                    mcn = new JhessianLookoutALA();
                    break;
                # endregion

                # region Jund Battlemage
                case "Jund Battlemage":
                    mcn = new JundBattlemageALA();
                    break;
                # endregion

                # region Jund Charm
                case "Jund Charm":
                    mcn = new JundCharmALA();
                    break;
                # endregion

                # region Jund Panorama
                case "Jund Panorama":
                    mcn = new JundPanoramaALA();
                    break;
                # endregion

                # region Jungle Shrine
                case "Jungle Shrine":
                    mcn = new JungleShrineALA();
                    break;
                # endregion

                # region Jungle Weaver
                case "Jungle Weaver":
                    mcn = new JungleWeaverALA();
                    break;
                # endregion

                # region Kathari Screecher
                case "Kathari Screecher":
                    mcn = new KathariScreecherALA();
                    break;
                # endregion

                # region Kederekt Creeper
                case "Kederekt Creeper":
                    mcn = new KederektCreeperALA();
                    break;
                # endregion

                # region Kederekt Leviathan
                case "Kederekt Leviathan":
                    mcn = new KederektLeviathanALA();
                    break;
                # endregion

                # region Keeper of Progenitus
                case "Keeper of Progenitus":
                    mcn = new KeeperofProgenitusALA();
                    break;
                # endregion

                # region Kiss of the Amesha
                case "Kiss of the Amesha":
                    mcn = new KissoftheAmeshaALA();
                    break;
                # endregion

                # region Knight of the Skyward Eye
                case "Knight of the Skyward Eye":
                    mcn = new KnightoftheSkywardEyeALA();
                    break;
                # endregion

                # region Knight of the White Orchid
                case "Knight of the White Orchid":
                    mcn = new KnightoftheWhiteOrchidALA();
                    break;
                # endregion

                # region Knight-Captain of Eos
                case "Knight-Captain of Eos":
                    mcn = new KnightCaptainofEosALA();
                    break;
                # endregion

                # region Kresh the Bloodbraided
                case "Kresh the Bloodbraided":
                    mcn = new KreshtheBloodbraidedALA();
                    break;
                # endregion

                # region Lich's Mirror
                case "Lich's Mirror":
                    mcn = new LichsMirrorALA();
                    break;
                # endregion

                # region Lightning Talons
                case "Lightning Talons":
                    mcn = new LightningTalonsALA();
                    break;
                # endregion

                # region Lush Growth
                case "Lush Growth":
                    mcn = new LushGrowthALA();
                    break;
                # endregion

                # region Magma Spray
                case "Magma Spray":
                    mcn = new MagmaSprayALA();
                    break;
                # endregion

                # region Manaplasm
                case "Manaplasm":
                    mcn = new ManaplasmALA();
                    break;
                # endregion

                # region Marble Chalice
                case "Marble Chalice":
                    mcn = new MarbleChaliceALA();
                    break;
                # endregion

                # region Master of Etherium
                case "Master of Etherium":
                    mcn = new MasterofEtheriumALA();
                    break;
                # endregion

                # region Mayael the Anima
                case "Mayael the Anima":
                    mcn = new MayaeltheAnimaALA();
                    break;
                # endregion

                # region Memory Erosion
                case "Memory Erosion":
                    mcn = new MemoryErosionALA();
                    break;
                # endregion

                # region Metallurgeon
                case "Metallurgeon":
                    mcn = new MetallurgeonALA();
                    break;
                # endregion

                # region Mighty Emergence
                case "Mighty Emergence":
                    mcn = new MightyEmergenceALA();
                    break;
                # endregion

                # region Mindlock Orb
                case "Mindlock Orb":
                    mcn = new MindlockOrbALA();
                    break;
                # endregion

                # region Minion Reflector
                case "Minion Reflector":
                    mcn = new MinionReflectorALA();
                    break;
                # endregion

                # region Mosstodon
                case "Mosstodon":
                    mcn = new MosstodonALA();
                    break;
                # endregion

                //# region Mountain
                //case "Mountain":
                //mcn = new MountainALA();
                //break;
                //# endregion

                # region Mycoloth
                case "Mycoloth":
                    mcn = new MycolothALA();
                    break;
                # endregion

                # region Naturalize
                case "Naturalize":
                    mcn = new NaturalizeALA();
                    break;
                # endregion

                # region Naya Battlemage
                case "Naya Battlemage":
                    mcn = new NayaBattlemageALA();
                    break;
                # endregion

                # region Naya Charm
                case "Naya Charm":
                    mcn = new NayaCharmALA();
                    break;
                # endregion

                # region Naya Panorama
                case "Naya Panorama":
                    mcn = new NayaPanoramaALA();
                    break;
                # endregion

                # region Necrogenesis
                case "Necrogenesis":
                    mcn = new NecrogenesisALA();
                    break;
                # endregion

                # region Obelisk of Bant
                case "Obelisk of Bant":
                    mcn = new ObeliskofBantALA();
                    break;
                # endregion

                # region Obelisk of Esper
                case "Obelisk of Esper":
                    mcn = new ObeliskofEsperALA();
                    break;
                # endregion

                # region Obelisk of Grixis
                case "Obelisk of Grixis":
                    mcn = new ObeliskofGrixisALA();
                    break;
                # endregion

                # region Obelisk of Jund
                case "Obelisk of Jund":
                    mcn = new ObeliskofJundALA();
                    break;
                # endregion

                # region Obelisk of Naya
                case "Obelisk of Naya":
                    mcn = new ObeliskofNayaALA();
                    break;
                # endregion

                //# region Oblivion Ring
                //case "Oblivion Ring":
                //    mcn = new OblivionRingALA();
                //    break;
                //# endregion

                # region Onyx Goblet
                case "Onyx Goblet":
                    mcn = new OnyxGobletALA();
                    break;
                # endregion

                # region Ooze Garden
                case "Ooze Garden":
                    mcn = new OozeGardenALA();
                    break;
                # endregion

                # region Outrider of Jhess
                case "Outrider of Jhess":
                    mcn = new OutriderofJhessALA();
                    break;
                # endregion

                //# region Plains
                //case "Plains":
                //mcn = new PlainsALA();
                //break;
                //# endregion

                # region Predator Dragon
                case "Predator Dragon":
                    mcn = new PredatorDragonALA();
                    break;
                # endregion

                # region Prince of Thralls
                case "Prince of Thralls":
                    mcn = new PrinceofThrallsALA();
                    break;
                # endregion

                # region Protomatter Powder
                case "Protomatter Powder":
                    mcn = new ProtomatterPowderALA();
                    break;
                # endregion

                # region Punish Ignorance
                case "Punish Ignorance":
                    mcn = new PunishIgnoranceALA();
                    break;
                # endregion

                # region Puppet Conjurer
                case "Puppet Conjurer":
                    mcn = new PuppetConjurerALA();
                    break;
                # endregion

                # region Qasali Ambusher
                case "Qasali Ambusher":
                    mcn = new QasaliAmbusherALA();
                    break;
                # endregion

                # region Quietus Spike
                case "Quietus Spike":
                    mcn = new QuietusSpikeALA();
                    break;
                # endregion

                # region Rafiq of the Many
                case "Rafiq of the Many":
                    mcn = new RafiqoftheManyALA();
                    break;
                # endregion

                # region Rakeclaw Gargantuan
                case "Rakeclaw Gargantuan":
                    mcn = new RakeclawGargantuanALA();
                    break;
                # endregion

                # region Ranger of Eos
                case "Ranger of Eos":
                    mcn = new RangerofEosALA();
                    break;
                # endregion

                # region Realm Razer
                case "Realm Razer":
                    mcn = new RealmRazerALA();
                    break;
                # endregion

                # region Relic of Progenitus
                case "Relic of Progenitus":
                    mcn = new RelicofProgenitusALA();
                    break;
                # endregion

                # region Resounding Roar
                case "Resounding Roar":
                    mcn = new ResoundingRoarALA();
                    break;
                # endregion

                # region Resounding Scream
                case "Resounding Scream":
                    mcn = new ResoundingScreamALA();
                    break;
                # endregion

                # region Resounding Silence
                case "Resounding Silence":
                    mcn = new ResoundingSilenceALA();
                    break;
                # endregion

                # region Resounding Thunder
                case "Resounding Thunder":
                    mcn = new ResoundingThunderALA();
                    break;
                # endregion

                # region Resounding Wave
                case "Resounding Wave":
                    mcn = new ResoundingWaveALA();
                    break;
                # endregion

                # region Rhox Charger
                case "Rhox Charger":
                    mcn = new RhoxChargerALA();
                    break;
                # endregion

                # region Rhox War Monk
                case "Rhox War Monk":
                    mcn = new RhoxWarMonkALA();
                    break;
                # endregion

                # region Ridge Rannet
                case "Ridge Rannet":
                    mcn = new RidgeRannetALA();
                    break;
                # endregion

                # region Rip-Clan Crasher
                case "Rip-Clan Crasher":
                    mcn = new RipClanCrasherALA();
                    break;
                # endregion

                # region Rockcaster Platoon
                case "Rockcaster Platoon":
                    mcn = new RockcasterPlatoonALA();
                    break;
                # endregion

                # region Rockslide Elemental
                case "Rockslide Elemental":
                    mcn = new RockslideElementalALA();
                    break;
                # endregion

                # region Sacellum Godspeaker
                case "Sacellum Godspeaker":
                    mcn = new SacellumGodspeakerALA();
                    break;
                # endregion

                # region Salvage Titan
                case "Salvage Titan":
                    mcn = new SalvageTitanALA();
                    break;
                # endregion

                # region Sanctum Gargoyle
                case "Sanctum Gargoyle":
                    mcn = new SanctumGargoyleALA();
                    break;
                # endregion

                # region Sangrite Surge
                case "Sangrite Surge":
                    mcn = new SangriteSurgeALA();
                    break;
                # endregion

                # region Sarkhan Vol
                case "Sarkhan Vol":
                    mcn = new SarkhanVolALA();
                    break;
                # endregion

                # region Savage Hunger
                case "Savage Hunger":
                    mcn = new SavageHungerALA();
                    break;
                # endregion

                # region Savage Lands
                case "Savage Lands":
                    mcn = new SavageLandsALA();
                    break;
                # endregion

                # region Scavenger Drake
                case "Scavenger Drake":
                    mcn = new ScavengerDrakeALA();
                    break;
                # endregion

                # region Scourge Devil
                case "Scourge Devil":
                    mcn = new ScourgeDevilALA();
                    break;
                # endregion

                # region Scourglass
                case "Scourglass":
                    mcn = new ScourglassALA();
                    break;
                # endregion

                # region Seaside Citadel
                case "Seaside Citadel":
                    mcn = new SeasideCitadelALA();
                    break;
                # endregion

                # region Sedraxis Specter
                case "Sedraxis Specter":
                    mcn = new SedraxisSpecterALA();
                    break;
                # endregion

                # region Sedris, the Traitor King
                case "Sedris, the Traitor King":
                    mcn = new SedristheTraitorKingALA();
                    break;
                # endregion

                # region Shadowfeed
                case "Shadowfeed":
                    mcn = new ShadowfeedALA();
                    break;
                # endregion

                # region Sharding Sphinx
                case "Sharding Sphinx":
                    mcn = new ShardingSphinxALA();
                    break;
                # endregion

                # region Sharuum the Hegemon
                case "Sharuum the Hegemon":
                    mcn = new SharuumtheHegemonALA();
                    break;
                # endregion

                # region Shore Snapper
                case "Shore Snapper":
                    mcn = new ShoreSnapperALA();
                    break;
                # endregion

                # region Sighted-Caste Sorcerer
                case "Sighted-Caste Sorcerer":
                    mcn = new SightedCasteSorcererALA();
                    break;
                # endregion

                # region Sigil Blessing
                case "Sigil Blessing":
                    mcn = new SigilBlessingALA();
                    break;
                # endregion

                # region Sigil of Distinction
                case "Sigil of Distinction":
                    mcn = new SigilofDistinctionALA();
                    break;
                # endregion

                # region Sigiled Paladin
                case "Sigiled Paladin":
                    mcn = new SigiledPaladinALA();
                    break;
                # endregion

                # region Skeletal Kathari
                case "Skeletal Kathari":
                    mcn = new SkeletalKathariALA();
                    break;
                # endregion

                # region Skeletonize
                case "Skeletonize":
                    mcn = new SkeletonizeALA();
                    break;
                # endregion

                # region Skill Borrower
                case "Skill Borrower":
                    mcn = new SkillBorrowerALA();
                    break;
                # endregion

                # region Skullmulcher
                case "Skullmulcher":
                    mcn = new SkullmulcherALA();
                    break;
                # endregion

                # region Soul's Fire
                case "Soul's Fire":
                    mcn = new SoulsFireALA();
                    break;
                # endregion

                # region Soul's Grace
                case "Soul's Grace":
                    mcn = new SoulsGraceALA();
                    break;
                # endregion

                # region Soul's Might
                case "Soul's Might":
                    mcn = new SoulsMightALA();
                    break;
                # endregion

                # region Spearbreaker Behemoth
                case "Spearbreaker Behemoth":
                    mcn = new SpearbreakerBehemothALA();
                    break;
                # endregion

                # region Spell Snip
                case "Spell Snip":
                    mcn = new SpellSnipALA();
                    break;
                # endregion

                # region Sphinx Sovereign
                case "Sphinx Sovereign":
                    mcn = new SphinxSovereignALA();
                    break;
                # endregion

                # region Sphinx's Herald
                case "Sphinx's Herald":
                    mcn = new SphinxsHeraldALA();
                    break;
                # endregion

                # region Sprouting Thrinax
                case "Sprouting Thrinax":
                    mcn = new SproutingThrinaxALA();
                    break;
                # endregion

                # region Steelclad Serpent
                case "Steelclad Serpent":
                    mcn = new SteelcladSerpentALA();
                    break;
                # endregion

                # region Steward of Valeron
                case "Steward of Valeron":
                    mcn = new StewardofValeronALA();
                    break;
                # endregion

                # region Stoic Angel
                case "Stoic Angel":
                    mcn = new StoicAngelALA();
                    break;
                # endregion

                # region Sunseed Nurturer
                case "Sunseed Nurturer":
                    mcn = new SunseedNurturerALA();
                    break;
                # endregion

                //# region Swamp
                //case "Swamp":
                //mcn = new SwampALA();
                //break;
                //# endregion

                # region Swerve
                case "Swerve":
                    mcn = new SwerveALA();
                    break;
                # endregion

                # region Tar Fiend
                case "Tar Fiend":
                    mcn = new TarFiendALA();
                    break;
                # endregion

                # region Tezzeret the Seeker
                case "Tezzeret the Seeker":
                    mcn = new TezzerettheSeekerALA();
                    break;
                # endregion

                # region Thorn-Thrash Viashino
                case "Thorn-Thrash Viashino":
                    mcn = new ThornThrashViashinoALA();
                    break;
                # endregion

                # region Thoughtcutter Agent
                case "Thoughtcutter Agent":
                    mcn = new ThoughtcutterAgentALA();
                    break;
                # endregion

                # region Thunder-Thrash Elder
                case "Thunder-Thrash Elder":
                    mcn = new ThunderThrashElderALA();
                    break;
                # endregion

                # region Tidehollow Sculler
                case "Tidehollow Sculler":
                    mcn = new TidehollowScullerALA();
                    break;
                # endregion

                # region Tidehollow Strix
                case "Tidehollow Strix":
                    mcn = new TidehollowStrixALA();
                    break;
                # endregion

                # region Titanic Ultimatum
                case "Titanic Ultimatum":
                    mcn = new TitanicUltimatumALA();
                    break;
                # endregion

                # region Topan Ascetic
                case "Topan Ascetic":
                    mcn = new TopanAsceticALA();
                    break;
                # endregion

                # region Tortoise Formation
                case "Tortoise Formation":
                    mcn = new TortoiseFormationALA();
                    break;
                # endregion

                # region Tower Gargoyle
                case "Tower Gargoyle":
                    mcn = new TowerGargoyleALA();
                    break;
                # endregion

                # region Undead Leotau
                case "Undead Leotau":
                    mcn = new UndeadLeotauALA();
                    break;
                # endregion

                # region Vectis Silencers
                case "Vectis Silencers":
                    mcn = new VectisSilencersALA();
                    break;
                # endregion

                # region Vein Drinker
                case "Vein Drinker":
                    mcn = new VeinDrinkerALA();
                    break;
                # endregion

                # region Viashino Skeleton
                case "Viashino Skeleton":
                    mcn = new ViashinoSkeletonALA();
                    break;
                # endregion

                # region Vicious Shadows
                case "Vicious Shadows":
                    mcn = new ViciousShadowsALA();
                    break;
                # endregion

                # region Violent Ultimatum
                case "Violent Ultimatum":
                    mcn = new ViolentUltimatumALA();
                    break;
                # endregion

                # region Viscera Dragger
                case "Viscera Dragger":
                    mcn = new VisceraDraggerALA();
                    break;
                # endregion

                # region Vithian Stinger
                case "Vithian Stinger":
                    mcn = new VithianStingerALA();
                    break;
                # endregion

                # region Volcanic Submersion
                case "Volcanic Submersion":
                    mcn = new VolcanicSubmersionALA();
                    break;
                # endregion

                # region Waveskimmer Aven
                case "Waveskimmer Aven":
                    mcn = new WaveskimmerAvenALA();
                    break;
                # endregion

                # region Welkin Guide
                case "Welkin Guide":
                    mcn = new WelkinGuideALA();
                    break;
                # endregion

                # region Where Ancients Tread
                case "Where Ancients Tread":
                    mcn = new WhereAncientsTreadALA();
                    break;
                # endregion

                # region Wild Nacatl
                case "Wild Nacatl":
                    mcn = new WildNacatlALA();
                    break;
                # endregion

                # region Windwright Mage
                case "Windwright Mage":
                    mcn = new WindwrightMageALA();
                    break;
                # endregion

                # region Woolly Thoctar
                case "Woolly Thoctar":
                    mcn = new WoollyThoctarALA();
                    break;
                # endregion

                # region Yoked Plowbeast
                case "Yoked Plowbeast":
                    mcn = new YokedPlowbeastALA();
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

                //case "Divination":
                //    mcn = new Divination();
                //    break;

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

                //case"Necrobite":
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

                //case "Springleaf Drum":
                //    mcn = new SpringleafDrum();
                //    break;

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

                //case "Magma Spray":
                //    mcn = new MagmaSpray();
                //    break;

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

                //case "Annul":
                //    mcn = new Annul();
                //    break;

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

                //case"Demolish":
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

                //case "Griptide":
                //    mcn = new Griptide();
                //    break;

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

                //case "Last Breath":
                //    mcn = new LastBreath();
                //    break;

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

                //case "Thoughtseize":
                //    mcn = new Thoughtseize();
                //    break;

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

                //# region Arrest
                //case "Arrest":
                //    mcn = new Arrest();
                //    break;
                //# endregion

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

                //# region Cancel
                //case "Cancel":
                //    mcn = new Cancel();
                //    break;
                //# endregion

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
                //case"Forest":
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
                //case"Island":
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
                //case"Mountain":
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
                //case"Plains":
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
                //case"Savage Surge":
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
                //case"Swamp":
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

                //# region Naturalize
                //case "Naturalize":
                //    mcn = new Naturalize();
                //    break;
                //# endregion

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
                //case"Azorius Guildgate":
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
                //case"Boros Guildgate":
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
                //case"Dimir Guildgate":
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
                //case"Golgari Guildgate":
                //    mcn = new GolgariGuildgate();
                //    break;
                //# endregion

                # region Gruul Cluestone
                case "Gruul Cluestone":
                    mcn = new GruulCluestone();
                    break;
                # endregion

                //# region Gruul Guildgate
                //case"Gruul Guildgate":
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
                //case"Izzet Guildgate":
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
                //case"Orzhov Guildgate":
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
                //case"Rakdos Guildgate":
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
                //case"Selesnya Guildgate":
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
                //case"Simic Guildgate":
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

                # region Magic 2012
                # region Acidic Slime
                case "Acidic Slime":
                    mcn = new AcidicSlimeM12();
                    break;
                # endregion

                //# region Act of Treason
                //case "Act of Treason":
                //    mcn = new ActofTreasonM12();
                //    break;
                //# endregion

                # region Adaptive Automaton
                case "Adaptive Automaton":
                    mcn = new AdaptiveAutomatonM12();
                    break;
                # endregion

                # region Aegis Angel
                case "Aegis Angel":
                    mcn = new AegisAngelM12();
                    break;
                # endregion

                # region AEther Adept
                case "AEther Adept":
                    mcn = new AEtherAdeptM12();
                    break;
                # endregion

                # region Alabaster Mage
                case "Alabaster Mage":
                    mcn = new AlabasterMageM12();
                    break;
                # endregion

                # region Alluring Siren
                case "Alluring Siren":
                    mcn = new AlluringSirenM12();
                    break;
                # endregion

                # region Amphin Cutthroat
                case "Amphin Cutthroat":
                    mcn = new AmphinCutthroatM12();
                    break;
                # endregion

                # region Angelic Destiny
                case "Angelic Destiny":
                    mcn = new AngelicDestinyM12();
                    break;
                # endregion

                # region Angel's Feather
                case "Angel's Feather":
                    mcn = new AngelsFeatherM12();
                    break;
                # endregion

                //# region Angel's Mercy
                //case "Angel's Mercy":
                //    mcn = new AngelsMercyM12();
                //    break;
                //# endregion

                # region Arachnus Spinner
                case "Arachnus Spinner":
                    mcn = new ArachnusSpinnerM12();
                    break;
                # endregion

                # region Arachnus Web
                case "Arachnus Web":
                    mcn = new ArachnusWebM12();
                    break;
                # endregion

                # region Arbalest Elite
                case "Arbalest Elite":
                    mcn = new ArbalestEliteM12();
                    break;
                # endregion

                # region Archon of Justice
                case "Archon of Justice":
                    mcn = new ArchonofJusticeM12();
                    break;
                # endregion

                # region Armored Warhorse
                case "Armored Warhorse":
                    mcn = new ArmoredWarhorseM12();
                    break;
                # endregion

                //# region Assault Griffin
                //case "Assault Griffin":
                //    mcn = new AssaultGriffinM12();
                //    break;
                //# endregion

                # region Auramancer
                case "Auramancer":
                    mcn = new AuramancerM12();
                    break;
                # endregion

                # region Autumn's Veil
                case "Autumn's Veil":
                    mcn = new AutumnsVeilM12();
                    break;
                # endregion

                # region Aven Fleetwing
                case "Aven Fleetwing":
                    mcn = new AvenFleetwingM12();
                    break;
                # endregion

                # region Azure Mage
                case "Azure Mage":
                    mcn = new AzureMageM12();
                    break;
                # endregion

                # region Belltower Sphinx
                case "Belltower Sphinx":
                    mcn = new BelltowerSphinxM12();
                    break;
                # endregion

                # region Benalish Veteran
                case "Benalish Veteran":
                    mcn = new BenalishVeteranM12();
                    break;
                # endregion

                //# region Birds of Paradise
                //case "Birds of Paradise":
                //    mcn = new BirdsofParadiseM12();
                //    break;
                //# endregion

                # region Blood Ogre
                case "Blood Ogre":
                    mcn = new BloodOgreM12();
                    break;
                # endregion

                # region Blood Seeker
                case "Blood Seeker":
                    mcn = new BloodSeekerM12();
                    break;
                # endregion

                # region Bloodlord of Vaasgoth
                case "Bloodlord of Vaasgoth":
                    mcn = new BloodlordofVaasgothM12();
                    break;
                # endregion

                # region Bloodrage Vampire
                case "Bloodrage Vampire":
                    mcn = new BloodrageVampireM12();
                    break;
                # endregion

                # region Bonebreaker Giant
                case "Bonebreaker Giant":
                    mcn = new BonebreakerGiantM12();
                    break;
                # endregion

                # region Bountiful Harvest
                case "Bountiful Harvest":
                    mcn = new BountifulHarvestM12();
                    break;
                # endregion

                # region Brindle Boar
                case "Brindle Boar":
                    mcn = new BrindleBoarM12();
                    break;
                # endregion

                # region Brink of Disaster
                case "Brink of Disaster":
                    mcn = new BrinkofDisasterM12();
                    break;
                # endregion

                # region Buried Ruin
                case "Buried Ruin":
                    mcn = new BuriedRuinM12();
                    break;
                # endregion

                # region Call to the Grave
                case "Call to the Grave":
                    mcn = new CalltotheGraveM12();
                    break;
                # endregion

                //# region Cancel
                //case "Cancel":
                //    mcn = new CancelM12();
                //    break;
                //# endregion

                # region Carnage Wurm
                case "Carnage Wurm":
                    mcn = new CarnageWurmM12();
                    break;
                # endregion

                # region Celestial Purge
                case "Celestial Purge":
                    mcn = new CelestialPurgeM12();
                    break;
                # endregion

                # region Cemetery Reaper
                case "Cemetery Reaper":
                    mcn = new CemeteryReaperM12();
                    break;
                # endregion

                # region Chandra, the Firebrand
                case "Chandra, the Firebrand":
                    mcn = new ChandratheFirebrandM12();
                    break;
                # endregion

                # region Chandra's Outrage
                case "Chandra's Outrage":
                    mcn = new ChandrasOutrageM12();
                    break;
                # endregion

                # region Chandra's Phoenix
                case "Chandra's Phoenix":
                    mcn = new ChandrasPhoenixM12();
                    break;
                # endregion

                # region Chasm Drake
                case "Chasm Drake":
                    mcn = new ChasmDrakeM12();
                    break;
                # endregion

                # region Child of Night
                case "Child of Night":
                    mcn = new ChildofNightM12();
                    break;
                # endregion

                # region Circle of Flame
                case "Circle of Flame":
                    mcn = new CircleofFlameM12();
                    break;
                # endregion

                # region Combust
                case "Combust":
                    mcn = new CombustM12();
                    break;
                # endregion

                //# region Consume Spirit
                //case "Consume Spirit":
                //    mcn = new ConsumeSpiritM12();
                //    break;
                //# endregion

                # region Coral Merfolk
                case "Coral Merfolk":
                    mcn = new CoralMerfolkM12();
                    break;
                # endregion

                # region Crimson Mage
                case "Crimson Mage":
                    mcn = new CrimsonMageM12();
                    break;
                # endregion

                # region Crown of Empires
                case "Crown of Empires":
                    mcn = new CrownofEmpiresM12();
                    break;
                # endregion

                # region Crumbling Colossus
                case "Crumbling Colossus":
                    mcn = new CrumblingColossusM12();
                    break;
                # endregion

                # region Cudgel Troll
                case "Cudgel Troll":
                    mcn = new CudgelTrollM12();
                    break;
                # endregion

                # region Dark Favor
                case "Dark Favor":
                    mcn = new DarkFavorM12();
                    break;
                # endregion

                # region Day of Judgment
                case "Day of Judgment":
                    mcn = new DayofJudgmentM12();
                    break;
                # endregion

                # region Deathmark
                case "Deathmark":
                    mcn = new DeathmarkM12();
                    break;
                # endregion

                # region Demon's Horn
                case "Demon's Horn":
                    mcn = new DemonsHornM12();
                    break;
                # endregion

                # region Demystify
                case "Demystify":
                    mcn = new DemystifyM12();
                    break;
                # endregion

                # region Devouring Swarm
                case "Devouring Swarm":
                    mcn = new DevouringSwarmM12();
                    break;
                # endregion

                # region Diabolic Tutor
                case "Diabolic Tutor":
                    mcn = new DiabolicTutorM12();
                    break;
                # endregion

                # region Disentomb
                case "Disentomb":
                    mcn = new DisentombM12();
                    break;
                # endregion

                # region Distress
                case "Distress":
                    mcn = new DistressM12();
                    break;
                # endregion

                //# region Divination
                //case "Divination":
                //    mcn = new DivinationM12();
                //    break;
                //# endregion

                # region Divine Favor
                case "Divine Favor":
                    mcn = new DivineFavorM12();
                    break;
                # endregion

                # region Djinn of Wishes
                case "Djinn of Wishes":
                    mcn = new DjinnofWishesM12();
                    break;
                # endregion

                # region Doom Blade
                case "Doom Blade":
                    mcn = new DoomBladeM12();
                    break;
                # endregion

                # region Doubling Chant
                case "Doubling Chant":
                    mcn = new DoublingChantM12();
                    break;
                # endregion

                # region Dragon's Claw
                case "Dragon's Claw":
                    mcn = new DragonsClawM12();
                    break;
                # endregion

                # region Dragonskull Summit
                case "Dragonskull Summit":
                    mcn = new DragonskullSummitM12();
                    break;
                # endregion

                # region Drifting Shade
                case "Drifting Shade":
                    mcn = new DriftingShadeM12();
                    break;
                # endregion

                # region Drowned Catacomb
                case "Drowned Catacomb":
                    mcn = new DrownedCatacombM12();
                    break;
                # endregion

                # region Druidic Satchel
                case "Druidic Satchel":
                    mcn = new DruidicSatchelM12();
                    break;
                # endregion

                # region Dungrove Elder
                case "Dungrove Elder":
                    mcn = new DungroveElderM12();
                    break;
                # endregion

                # region Duskhunter Bat
                case "Duskhunter Bat":
                    mcn = new DuskhunterBatM12();
                    break;
                # endregion

                # region Elite Vanguard
                case "Elite Vanguard":
                    mcn = new EliteVanguardM12();
                    break;
                # endregion

                # region Elixir of Immortality
                case "Elixir of Immortality":
                    mcn = new ElixirofImmortalityM12();
                    break;
                # endregion

                # region Elvish Archdruid
                case "Elvish Archdruid":
                    mcn = new ElvishArchdruidM12();
                    break;
                # endregion

                # region Fiery Hellhound
                case "Fiery Hellhound":
                    mcn = new FieryHellhoundM12();
                    break;
                # endregion

                //# region Fireball
                //case "Fireball":
                //    mcn = new FireballM12();
                //    break;
                //# endregion

                //# region Firebreathing
                //case "Firebreathing":
                //    mcn = new FirebreathingM12();
                //    break;
                //# endregion

                //# region Flameblast Dragon
                //case "Flameblast Dragon":
                //    mcn = new FlameblastDragonM12();
                //    break;
                //# endregion

                # region Flashfreeze
                case "Flashfreeze":
                    mcn = new FlashfreezeM12();
                    break;
                # endregion

                //# region Flight
                //case "Flight":
                //    mcn = new FlightM12();
                //    break;
                //# endregion

                //# region Fling
                //case "Fling":
                //    mcn = new FlingM12();
                //    break;
                //# endregion

                //# region Fog
                //case "Fog":
                //mcn = new FogM12();
                //break;
                //# endregion

                //# region Forest
                //case "Forest":
                //    mcn = new ForestM12();
                //    break;
                //# endregion

                # region Frost Breath
                case "Frost Breath":
                    mcn = new FrostBreathM12();
                    break;
                # endregion

                # region Frost Titan
                case "Frost Titan":
                    mcn = new FrostTitanM12();
                    break;
                # endregion

                # region Furyborn Hellkite
                case "Furyborn Hellkite":
                    mcn = new FurybornHellkiteM12();
                    break;
                # endregion

                # region Garruk, Primal Hunter
                case "Garruk, Primal Hunter":
                    mcn = new GarrukPrimalHunterM12();
                    break;
                # endregion

                # region Garruk's Companion
                case "Garruk's Companion":
                    mcn = new GarruksCompanionM12();
                    break;
                # endregion

                # region Garruk's Horde
                case "Garruk's Horde":
                    mcn = new GarruksHordeM12();
                    break;
                # endregion

                //# region Giant Spider
                //case "Giant Spider":
                //    mcn = new GiantSpiderM12();
                //    break;
                //# endregion

                # region Gideon Jura
                case "Gideon Jura":
                    mcn = new GideonJuraM12();
                    break;
                # endregion

                # region Gideon's Avenger
                case "Gideon's Avenger":
                    mcn = new GideonsAvengerM12();
                    break;
                # endregion

                # region Gideon's Lawkeeper
                case "Gideon's Lawkeeper":
                    mcn = new GideonsLawkeeperM12();
                    break;
                # endregion

                # region Glacial Fortress
                case "Glacial Fortress":
                    mcn = new GlacialFortressM12();
                    break;
                # endregion

                # region Gladecover Scout
                case "Gladecover Scout":
                    mcn = new GladecoverScoutM12();
                    break;
                # endregion

                # region Goblin Arsonist
                case "Goblin Arsonist":
                    mcn = new GoblinArsonistM12();
                    break;
                # endregion

                # region Goblin Bangchuckers
                case "Goblin Bangchuckers":
                    mcn = new GoblinBangchuckersM12();
                    break;
                # endregion

                # region Goblin Chieftain
                case "Goblin Chieftain":
                    mcn = new GoblinChieftainM12();
                    break;
                # endregion

                # region Goblin Fireslinger
                case "Goblin Fireslinger":
                    mcn = new GoblinFireslingerM12();
                    break;
                # endregion

                # region Goblin Grenade
                case "Goblin Grenade":
                    mcn = new GoblinGrenadeM12();
                    break;
                # endregion

                # region Goblin Piker
                case "Goblin Piker":
                    mcn = new GoblinPikerM12();
                    break;
                # endregion

                # region Goblin Tunneler
                case "Goblin Tunneler":
                    mcn = new GoblinTunnelerM12();
                    break;
                # endregion

                # region Goblin War Paint
                case "Goblin War Paint":
                    mcn = new GoblinWarPaintM12();
                    break;
                # endregion

                # region Gorehorn Minotaurs
                case "Gorehorn Minotaurs":
                    mcn = new GorehornMinotaursM12();
                    break;
                # endregion

                # region Grand Abolisher
                case "Grand Abolisher":
                    mcn = new GrandAbolisherM12();
                    break;
                # endregion

                # region Grave Titan
                case "Grave Titan":
                    mcn = new GraveTitanM12();
                    break;
                # endregion

                # region Gravedigger
                case "Gravedigger":
                    mcn = new GravediggerM12();
                    break;
                # endregion

                # region Greater Basilisk
                case "Greater Basilisk":
                    mcn = new GreaterBasiliskM12();
                    break;
                # endregion

                # region Greatsword
                case "Greatsword":
                    mcn = new GreatswordM12();
                    break;
                # endregion

                # region Griffin Rider
                case "Griffin Rider":
                    mcn = new GriffinRiderM12();
                    break;
                # endregion

                # region Griffin Sentinel
                case "Griffin Sentinel":
                    mcn = new GriffinSentinelM12();
                    break;
                # endregion

                # region Grim Lavamancer
                case "Grim Lavamancer":
                    mcn = new GrimLavamancerM12();
                    break;
                # endregion

                # region Guardians' Pledge
                case "Guardians' Pledge":
                    mcn = new GuardiansPledgeM12();
                    break;
                # endregion

                # region Harbor Serpent
                case "Harbor Serpent":
                    mcn = new HarborSerpentM12();
                    break;
                # endregion

                # region Hideous Visage
                case "Hideous Visage":
                    mcn = new HideousVisageM12();
                    break;
                # endregion

                # region Honor of the Pure
                case "Honor of the Pure":
                    mcn = new HonorofthePureM12();
                    break;
                # endregion

                # region Hunter's Insight
                case "Hunter's Insight":
                    mcn = new HuntersInsightM12();
                    break;
                # endregion

                # region Ice Cage
                case "Ice Cage":
                    mcn = new IceCageM12();
                    break;
                # endregion

                # region Incinerate
                case "Incinerate":
                    mcn = new IncinerateM12();
                    break;
                # endregion

                # region Inferno Titan
                case "Inferno Titan":
                    mcn = new InfernoTitanM12();
                    break;
                # endregion

                //# region Island
                //case "Island":
                //    mcn = new IslandM12();
                //    break;
                //# endregion

                # region Jace, Memory Adept
                case "Jace, Memory Adept":
                    mcn = new JaceMemoryAdeptM12();
                    break;
                # endregion

                # region Jace's Archivist
                case "Jace's Archivist":
                    mcn = new JacesArchivistM12();
                    break;
                # endregion

                # region Jace's Erasure
                case "Jace's Erasure":
                    mcn = new JacesErasureM12();
                    break;
                # endregion

                # region Jade Mage
                case "Jade Mage":
                    mcn = new JadeMageM12();
                    break;
                # endregion

                # region Kite Shield
                case "Kite Shield":
                    mcn = new KiteShieldM12();
                    break;
                # endregion

                # region Kraken's Eye
                case "Kraken's Eye":
                    mcn = new KrakensEyeM12();
                    break;
                # endregion

                # region Lava Axe
                case "Lava Axe":
                    mcn = new LavaAxeM12();
                    break;
                # endregion

                # region Levitation
                case "Levitation":
                    mcn = new LevitationM12();
                    break;
                # endregion

                # region Lifelink
                case "Lifelink":
                    mcn = new LifelinkM12();
                    break;
                # endregion

                # region Lightning Elemental
                case "Lightning Elemental":
                    mcn = new LightningElementalM12();
                    break;
                # endregion

                //# region Llanowar Elves
                //case "Llanowar Elves":
                //    mcn = new LlanowarElvesM12();
                //    break;
                //# endregion

                # region Lord of the Unreal
                case "Lord of the Unreal":
                    mcn = new LordoftheUnrealM12();
                    break;
                # endregion

                //# region Lure
                //case "Lure":
                //    mcn = new LureM12();
                //    break;
                //# endregion

                # region Lurking Crocodile
                case "Lurking Crocodile":
                    mcn = new LurkingCrocodileM12();
                    break;
                # endregion

                # region Mana Leak
                case "Mana Leak":
                    mcn = new ManaLeakM12();
                    break;
                # endregion

                //# region Manabarbs
                //case "Manabarbs":
                //    mcn = new ManabarbsM12();
                //    break;
                //# endregion

                # region Manalith
                case "Manalith":
                    mcn = new ManalithM12();
                    break;
                # endregion

                # region Manic Vandal
                case "Manic Vandal":
                    mcn = new ManicVandalM12();
                    break;
                # endregion

                # region Master Thief
                case "Master Thief":
                    mcn = new MasterThiefM12();
                    break;
                # endregion

                # region Merfolk Looter
                case "Merfolk Looter":
                    mcn = new MerfolkLooterM12();
                    break;
                # endregion

                # region Merfolk Mesmerist
                case "Merfolk Mesmerist":
                    mcn = new MerfolkMesmeristM12();
                    break;
                # endregion

                # region Mesa Enchantress
                case "Mesa Enchantress":
                    mcn = new MesaEnchantressM12();
                    break;
                # endregion

                # region Mighty Leap
                case "Mighty Leap":
                    mcn = new MightyLeapM12();
                    break;
                # endregion

                # region Mind Control
                case "Mind Control":
                    mcn = new MindControlM12();
                    break;
                # endregion

                //# region Mind Rot
                //case "Mind Rot":
                //    mcn = new MindRotM12();
                //    break;
                //# endregion

                # region Mind Unbound
                case "Mind Unbound":
                    mcn = new MindUnboundM12();
                    break;
                # endregion

                # region Monomania
                case "Monomania":
                    mcn = new MonomaniaM12();
                    break;
                # endregion

                //# region Mountain
                //case "Mountain":
                //    mcn = new MountainM12();
                //    break;
                //# endregion

                //# region Naturalize
                //case "Naturalize":
                //mcn = new NaturalizeM12();
                //break;
                //# endregion

                # region Negate
                case "Negate":
                    mcn = new NegateM12();
                    break;
                # endregion

                //# region Oblivion Ring
                //case "Oblivion Ring":
                //mcn = new OblivionRingM12();
                //break;
                //# endregion

                # region Onyx Mage
                case "Onyx Mage":
                    mcn = new OnyxMageM12();
                    break;
                # endregion

                # region Overrun
                case "Overrun":
                    mcn = new OverrunM12();
                    break;
                # endregion

                # region Pacifism
                case "Pacifism":
                    mcn = new PacifismM12();
                    break;
                # endregion

                //# region Pentavus
                //case "Pentavus":
                //    mcn = new PentavusM12();
                //    break;
                //# endregion

                # region Peregrine Griffin
                case "Peregrine Griffin":
                    mcn = new PeregrineGriffinM12();
                    break;
                # endregion

                # region Personal Sanctuary
                case "Personal Sanctuary":
                    mcn = new PersonalSanctuaryM12();
                    break;
                # endregion

                # region Phantasmal Bear
                case "Phantasmal Bear":
                    mcn = new PhantasmalBearM12();
                    break;
                # endregion

                # region Phantasmal Dragon
                case "Phantasmal Dragon":
                    mcn = new PhantasmalDragonM12();
                    break;
                # endregion

                # region Phantasmal Image
                case "Phantasmal Image":
                    mcn = new PhantasmalImageM12();
                    break;
                # endregion

                //# region Plains
                //case "Plains":
                //    mcn = new PlainsM12();
                //    break;
                //# endregion

                # region Plummet
                case "Plummet":
                    mcn = new PlummetM12();
                    break;
                # endregion

                //# region Ponder
                //case "Ponder":
                //mcn = new PonderM12();
                //break;
                //# endregion

                # region Pride Guardian
                case "Pride Guardian":
                    mcn = new PrideGuardianM12();
                    break;
                # endregion

                # region Primeval Titan
                case "Primeval Titan":
                    mcn = new PrimevalTitanM12();
                    break;
                # endregion

                # region Primordial Hydra
                case "Primordial Hydra":
                    mcn = new PrimordialHydraM12();
                    break;
                # endregion

                # region Quicksilver Amulet
                case "Quicksilver Amulet":
                    mcn = new QuicksilverAmuletM12();
                    break;
                # endregion

                # region Rampant Growth
                case "Rampant Growth":
                    mcn = new RampantGrowthM12();
                    break;
                # endregion

                # region Reassembling Skeleton
                case "Reassembling Skeleton":
                    mcn = new ReassemblingSkeletonM12();
                    break;
                # endregion

                # region Reclaim
                case "Reclaim":
                    mcn = new ReclaimM12();
                    break;
                # endregion

                # region Redirect
                case "Redirect":
                    mcn = new RedirectM12();
                    break;
                # endregion

                # region Reverberate
                case "Reverberate":
                    mcn = new ReverberateM12();
                    break;
                # endregion

                # region Rites of Flourishing
                case "Rites of Flourishing":
                    mcn = new RitesofFlourishingM12();
                    break;
                # endregion

                # region Roc Egg
                case "Roc Egg":
                    mcn = new RocEggM12();
                    break;
                # endregion

                # region Rootbound Crag
                case "Rootbound Crag":
                    mcn = new RootboundCragM12();
                    break;
                # endregion

                //# region Royal Assassin
                //case "Royal Assassin":
                //    mcn = new RoyalAssassinM12();
                //    break;
                //# endregion

                # region Runeclaw Bear
                case "Runeclaw Bear":
                    mcn = new RuneclawBearM12();
                    break;
                # endregion

                # region Rune-Scarred Demon
                case "Rune-Scarred Demon":
                    mcn = new RuneScarredDemonM12();
                    break;
                # endregion

                # region Rusted Sentinel
                case "Rusted Sentinel":
                    mcn = new RustedSentinelM12();
                    break;
                # endregion

                # region Sacred Wolf
                case "Sacred Wolf":
                    mcn = new SacredWolfM12();
                    break;
                # endregion

                # region Scepter of Empires
                case "Scepter of Empires":
                    mcn = new ScepterofEmpiresM12();
                    break;
                # endregion

                # region Scrambleverse
                case "Scrambleverse":
                    mcn = new ScrambleverseM12();
                    break;
                # endregion

                //# region Sengir Vampire
                //case "Sengir Vampire":
                //    mcn = new SengirVampireM12();
                //    break;
                //# endregion

                //# region Serra Angel
                //case "Serra Angel":
                //    mcn = new SerraAngelM12();
                //    break;
                //# endregion

                # region Shock
                case "Shock":
                    mcn = new ShockM12();
                    break;
                # endregion

                # region Siege Mastodon
                case "Siege Mastodon":
                    mcn = new SiegeMastodonM12();
                    break;
                # endregion

                # region Skinshifter
                case "Skinshifter":
                    mcn = new SkinshifterM12();
                    break;
                # endregion

                # region Skywinder Drake
                case "Skywinder Drake":
                    mcn = new SkywinderDrakeM12();
                    break;
                # endregion

                # region Slaughter Cry
                case "Slaughter Cry":
                    mcn = new SlaughterCryM12();
                    break;
                # endregion

                # region Smallpox
                case "Smallpox":
                    mcn = new SmallpoxM12();
                    break;
                # endregion

                //# region Solemn Simulacrum
                //case "Solemn Simulacrum":
                //    mcn = new SolemnSimulacrumM12();
                //    break;
                //# endregion

                # region Sorin Markov
                case "Sorin Markov":
                    mcn = new SorinMarkovM12();
                    break;
                # endregion

                # region Sorin's Thirst
                case "Sorin's Thirst":
                    mcn = new SorinsThirstM12();
                    break;
                # endregion

                # region Sorin's Vengeance
                case "Sorin's Vengeance":
                    mcn = new SorinsVengeanceM12();
                    break;
                # endregion

                # region Sphinx of Uthuun
                case "Sphinx of Uthuun":
                    mcn = new SphinxofUthuunM12();
                    break;
                # endregion

                # region Spirit Mantle
                case "Spirit Mantle":
                    mcn = new SpiritMantleM12();
                    break;
                # endregion

                # region Stampeding Rhino
                case "Stampeding Rhino":
                    mcn = new StampedingRhinoM12();
                    break;
                # endregion

                # region Stave Off
                case "Stave Off":
                    mcn = new StaveOffM12();
                    break;
                # endregion

                # region Stingerfling Spider
                case "Stingerfling Spider":
                    mcn = new StingerflingSpiderM12();
                    break;
                # endregion

                # region Stonehorn Dignitary
                case "Stonehorn Dignitary":
                    mcn = new StonehornDignitaryM12();
                    break;
                # endregion

                # region Stormblood Berserker
                case "Stormblood Berserker":
                    mcn = new StormbloodBerserkerM12();
                    break;
                # endregion

                # region Stormfront Pegasus
                case "Stormfront Pegasus":
                    mcn = new StormfrontPegasusM12();
                    break;
                # endregion

                # region Sun Titan
                case "Sun Titan":
                    mcn = new SunTitanM12();
                    break;
                # endregion

                # region Sundial of the Infinite
                case "Sundial of the Infinite":
                    mcn = new SundialoftheInfiniteM12();
                    break;
                # endregion

                # region Sunpetal Grove
                case "Sunpetal Grove":
                    mcn = new SunpetalGroveM12();
                    break;
                # endregion

                # region Sutured Ghoul
                case "Sutured Ghoul":
                    mcn = new SuturedGhoulM12();
                    break;
                # endregion

                //# region Swamp
                //case "Swamp":
                //    mcn = new SwampM12();
                //    break;
                //# endregion

                # region Swiftfoot Boots
                case "Swiftfoot Boots":
                    mcn = new SwiftfootBootsM12();
                    break;
                # endregion

                # region Taste of Blood
                case "Taste of Blood":
                    mcn = new TasteofBloodM12();
                    break;
                # endregion

                # region Tectonic Rift
                case "Tectonic Rift":
                    mcn = new TectonicRiftM12();
                    break;
                # endregion

                # region Thran Golem
                case "Thran Golem":
                    mcn = new ThranGolemM12();
                    break;
                # endregion

                # region Throne of Empires
                case "Throne of Empires":
                    mcn = new ThroneofEmpiresM12();
                    break;
                # endregion

                # region Time Reversal
                case "Time Reversal":
                    mcn = new TimeReversalM12();
                    break;
                # endregion

                # region Timely Reinforcements
                case "Timely Reinforcements":
                    mcn = new TimelyReinforcementsM12();
                    break;
                # endregion

                # region Titanic Growth
                case "Titanic Growth":
                    mcn = new TitanicGrowthM12();
                    break;
                # endregion

                # region Tormented Soul
                case "Tormented Soul":
                    mcn = new TormentedSoulM12();
                    break;
                # endregion

                # region Trollhide
                case "Trollhide":
                    mcn = new TrollhideM12();
                    break;
                # endregion

                # region Turn to Frog
                case "Turn to Frog":
                    mcn = new TurntoFrogM12();
                    break;
                # endregion

                //# region Unsummon
                //case "Unsummon":
                //    mcn = new UnsummonM12();
                //    break;
                //# endregion

                # region Vampire Outcasts
                case "Vampire Outcasts":
                    mcn = new VampireOutcastsM12();
                    break;
                # endregion

                # region Vastwood Gorger
                case "Vastwood Gorger":
                    mcn = new VastwoodGorgerM12();
                    break;
                # endregion

                # region Vengeful Pharaoh
                case "Vengeful Pharaoh":
                    mcn = new VengefulPharaohM12();
                    break;
                # endregion

                # region Visions of Beyond
                case "Visions of Beyond":
                    mcn = new VisionsofBeyondM12();
                    break;
                # endregion

                # region Volcanic Dragon
                case "Volcanic Dragon":
                    mcn = new VolcanicDragonM12();
                    break;
                # endregion

                # region Wall of Torches
                case "Wall of Torches":
                    mcn = new WallofTorchesM12();
                    break;
                # endregion

                # region Warpath Ghoul
                case "Warpath Ghoul":
                    mcn = new WarpathGhoulM12();
                    break;
                # endregion

                # region Warstorm Surge
                case "Warstorm Surge":
                    mcn = new WarstormSurgeM12();
                    break;
                # endregion

                //# region Worldslayer
                //case "Worldslayer":
                //    mcn = new WorldslayerM12();
                //    break;
                //# endregion

                # region Wring Flesh
                case "Wring Flesh":
                    mcn = new WringFleshM12();
                    break;
                # endregion

                # region Wurm's Tooth
                case "Wurm's Tooth":
                    mcn = new WurmsToothM12();
                    break;
                # endregion

                # region Zombie Goliath
                case "Zombie Goliath":
                    mcn = new ZombieGoliathM12();
                    break;
                # endregion

                # region Zombie Infestation
                case "Zombie Infestation":
                    mcn = new ZombieInfestationM12();
                    break;
                # endregion


                # endregion

                # region Magic 2013 Empty

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
                //case"Act of Treason":
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
                //case"Angelic Wall":
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

                //# region Auramancer
                //case "Auramancer":
                //    mcn = new Auramancer();
                //    break;
                //# endregion

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

                //# region Blessing
                //case "Blessing":
                //    mcn = new BlessingM14();
                //    break;
                //# endregion

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

                //# region Briarpack Alpha
                //case "Briarpack Alpha":
                //    mcn = new BriarpackAlpha();
                //    break;
                //# endregion

                //# region Brindle Boar
                //case "Brindle Boar":
                //    mcn = new BrindleBoar();
                //    break;
                //# endregion

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
                //case"Cancel":
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

                //# region Chandra's Outrage
                //case "Chandra's Outrage":
                //    mcn = new ChandrasOutrage();
                //    break;
                //# endregion

                //# region Chandra's Phoenix
                //case "Chandra's Phoenix":
                //    mcn = new ChandrasPhoenix();
                //    break;
                //# endregion

                # region Charging Griffin
                case "Charging Griffin":
                    mcn = new ChargingGriffin();
                    break;
                # endregion

                //# region Child of Night
                //case "Child of Night":
                //    mcn = new ChildofNight();
                //    break;
                //# endregion

                # region Claustrophobia
                case "Claustrophobia":
                    mcn = new Claustrophobia();
                    break;
                # endregion

                //# region Clone
                //case "Clone":
                //    mcn = new CloneM14();
                //    break;
                //# endregion

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

                //# region Coral Merfolk
                //case "Coral Merfolk":
                //    mcn = new CoralMerfolk();
                //    break;
                //# endregion

                # region Corpse Hauler
                case "Corpse Hauler":
                    mcn = new CorpseHauler();
                    break;
                # endregion

                //# region Corrupt
                //case "Corrupt":
                //    mcn = new Corrupt();
                //    break;
                //# endregion

                # region Cyclops Tyrant
                case "Cyclops Tyrant":
                    mcn = new CyclopsTyrant();
                    break;
                # endregion

                //# region Dark Favor
                //case "Dark Favor":
                //    mcn = new DarkFavor();
                //    break;
                //# endregion

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
                //case"Demolish":
                //    mcn = new DemolishM14();
                //    break;
                //# endregion

                # region Devout Invocation
                case "Devout Invocation":
                    mcn = new DevoutInvocation();
                    break;
                # endregion

                //# region Diabolic Tutor
                //case "Diabolic Tutor":
                //    mcn = new DiabolicTutor();
                //    break;
                //# endregion

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
                //case"Divination":
                //    mcn = new DivinationM14();
                //    break;
                //# endregion

                //# region Divine Favor
                //case "Divine Favor":
                //    mcn = new DivineFavor();
                //    break;
                //# endregion

                # region Domestication
                case "Domestication":
                    mcn = new Domestication();
                    break;
                # endregion

                //# region Doom Blade
                //case "Doom Blade":
                //    mcn = new DoomBlade();
                //    break;
                //# endregion

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

                //# region Elixir of Immortality
                //case "Elixir of Immortality":
                //    mcn = new ElixirofImmortality();
                //    break;
                //# endregion

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

                //# region Fireshrieker
                //case "Fireshrieker":
                //    mcn = new Fireshrieker();
                //    break;
                //# endregion

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

                //# region Fog
                //case "Fog":
                //    mcn = new FogM14();
                //    break;
                //# endregion

                //# region Forest
                //case"Forest":
                //    mcn = new ForestRTR();
                //    break;
                //# endregion

                # region Fortify
                case "Fortify":
                    mcn = new Fortify();
                    break;
                # endregion

                //# region Frost Breath
                //case "Frost Breath":
                //    mcn = new FrostBreath();
                //    break;
                //# endregion

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

                //# region Garruk's Horde
                //case "Garruk's Horde":
                //    mcn = new GarruksHorde();
                //    break;
                //# endregion

                //# region Giant Growth
                //case"Giant Growth":
                //    mcn = new GiantGrowthRTR();
                //    break;
                //# endregion

                //# region Giant Spider
                //case "Giant Spider":
                //    mcn = new GiantSpiderM14();
                //    break;
                //# endregion

                //# region Gladecover Scout
                //case "Gladecover Scout":
                //    mcn = new GladecoverScout();
                //    break;
                //# endregion

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

                //# region Griffin Sentinel
                //case "Griffin Sentinel":
                //    mcn = new GriffinSentinel();
                //    break;
                //# endregion

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

                //# region Howl of the Night Pack
                //case "Howl of the Night Pack":
                //    mcn = new HowloftheNightPack();
                //    break;
                //# endregion

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
                //case"Island":
                //    mcn = new IslandRTR();
                //    break;
                //# endregion

                //# region Jace, Memory Adept
                //case "Jace, Memory Adept":
                //    mcn = new JaceMemoryAdept();
                //    break;
                //# endregion

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

                //# region Lava Axe
                //case "Lava Axe":
                //    mcn = new LavaAxe();
                //    break;
                //# endregion

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

                //# region Lightning Talons
                //case "Lightning Talons":
                //    mcn = new LightningTalons();
                //    break;
                //# endregion

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
                //case"Mind Rot":
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
                //case"Mountain":
                //    mcn = new MountainRTR();
                //    break;
                //# endregion

                # region Mutavault
                case "Mutavault":
                    mcn = new Mutavault();
                    break;
                # endregion

                //# region Naturalize
                //case"Naturalize":
                //    mcn = new NaturalizeM14();
                //    break;
                //# endregion

                //# region Negate
                //case "Negate":
                //    mcn = new Negate();
                //    break;
                //# endregion

                //# region Nephalia Seakite
                //case "Nephalia Seakite":
                //    mcn = new NephaliaSeakite();
                //    break;
                //# endregion

                //# region Nightmare
                //case "Nightmare":
                //    mcn = new NightmareM14();
                //    break;
                //# endregion

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

                //# region Pacifism
                //case "Pacifism":
                //    mcn = new Pacifism();
                //    break;
                //# endregion

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
                //case"Plains":
                //    mcn = new PlainsRTR();
                //    break;
                //# endregion

                # region Planar Cleansing
                case "Planar Cleansing":
                    mcn = new PlanarCleansing();
                    break;
                # endregion

                //# region Plummet
                //case "Plummet":
                //    mcn = new Plummet();
                //    break;
                //# endregion

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

                //# region Rod of Ruin
                //case "Rod of Ruin":
                //    mcn = new RodofRuinM14();
                //    break;
                //# endregion

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

                //# region Sengir Vampire
                //case "Sengir Vampire":
                //    mcn = new SengirVampireM14();
                //    break;
                //# endregion

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

                //# region Serra Angel
                //case "Serra Angel":
                //    mcn = new SerraAngelM14();
                //    break;
                //# endregion

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

                //# region Shimmering Grotto
                //case "Shimmering Grotto":
                //    mcn = new ShimmeringGrotto();
                //    break;
                //# endregion

                //# region Shivan Dragon
                //case "Shivan Dragon":
                //    mcn = new ShivanDragonM14();
                //    break;
                //# endregion

                # region Shiv's Embrace
                case "Shiv's Embrace":
                    mcn = new ShivsEmbrace();
                    break;
                # endregion

                //# region Shock
                //case "Shock":
                //    mcn = new Shock();
                //    break;
                //# endregion

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

                //# region Siege Mastodon
                //case "Siege Mastodon":
                //    mcn = new SiegeMastodon();
                //    break;
                //# endregion

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

                //# region Spell Blast
                //case "Spell Blast":
                //    mcn = new SpellBlastM14();
                //    break;
                //# endregion

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
                //case"Swamp":
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

                //# region Trollhide
                //case "Trollhide":
                //    mcn = new Trollhide();
                //    break;
                //# endregion

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
                //case"Verdant Haven":
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

                //# region Wall of Swords
                //case "Wall of Swords":
                //    mcn = new WallofSwordsM14();
                //    break;
                //# endregion

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

                //# region Wild Ricochet
                //case "Wild Ricochet":
                //    mcn = new WildRicochet();
                //    break;
                //# endregion

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

                //# region Wring Flesh
                //case "Wring Flesh":
                //    mcn = new WringFlesh();
                //    break;
                //# endregion

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
                //case"Accursed Spirit":
                //    mcn = new AccursedSpiritM15();
                //    break;
                //# endregion

                # region Act on Impulse
                case "Act on Impulse":
                    mcn = new ActonImpulseM15();
                    break;
                # endregion

                //# region Aegis Angel
                //case "Aegis Angel":
                //    mcn = new AegisAngelM15();
                //    break;
                //# endregion

                # region Aeronaut Tinkerer
                case "Aeronaut Tinkerer":
                    mcn = new AeronautTinkererM15();
                    break;
                # endregion

                # region AEtherspouts
                case "AEtherspouts":
                    mcn = new AEtherspoutsM15();
                    break;
                # endregion

                # region Aggressive Mining
                case "Aggressive Mining":
                    mcn = new AggressiveMiningM15();
                    break;
                # endregion

                # region Ajani Steadfast
                case "Ajani Steadfast":
                    mcn = new AjaniSteadfastM15();
                    break;
                # endregion

                # region Ajani's Pridemate
                case "Ajani's Pridemate":
                    mcn = new AjanisPridemateM15();
                    break;
                # endregion

                # region Altac Bloodseeker
                case "Altac Bloodseeker":
                    mcn = new AltacBloodseekerM15();
                    break;
                # endregion

                # region Amphin Pathmage
                case "Amphin Pathmage":
                    mcn = new AmphinPathmageM15();
                    break;
                # endregion

                # region Ancient Silverback
                case "Ancient Silverback":
                    mcn = new AncientSilverbackM15();
                    break;
                # endregion

                # region Avacyn, Guardian Angel
                case "Avacyn, Guardian Angel":
                    mcn = new AvacynGuardianAngelM15();
                    break;
                # endregion

                # region Avarice Amulet
                case "Avarice Amulet":
                    mcn = new AvariceAmuletM15();
                    break;
                # endregion

                # region Back to Nature
                case "Back to Nature":
                    mcn = new BacktoNatureM15();
                    break;
                # endregion

                //# region Battle Mastery
                //case "Battle Mastery":
                //    mcn = new BattleMasteryM15();
                //    break;
                //# endregion

                # region Battlefield Forge
                case "Battlefield Forge":
                    mcn = new BattlefieldForgeM15();
                    break;
                # endregion

                # region Belligerent Sliver
                case "Belligerent Sliver":
                    mcn = new BelligerentSliverM15();
                    break;
                # endregion

                //# region Black Cat
                //case "Black Cat":
                //    mcn = new BlackCatM15();
                //    break;
                //# endregion

                # region Blastfire Bolt
                case "Blastfire Bolt":
                    mcn = new BlastfireBoltM15();
                    break;
                # endregion

                # region Blood Host
                case "Blood Host":
                    mcn = new BloodHostM15();
                    break;
                # endregion

                # region Boonweaver Giant
                case "Boonweaver Giant":
                    mcn = new BoonweaverGiantM15();
                    break;
                # endregion

                # region Borderland Marauder
                case "Borderland Marauder":
                    mcn = new BorderlandMarauderM15();
                    break;
                # endregion

                # region Brawler's Plate
                case "Brawler's Plate":
                    mcn = new BrawlersPlateM15();
                    break;
                # endregion

                //# region Bronze Sable
                //case"Bronze Sable":
                //    mcn = new BronzeSableMM15();
                //    break;
                //# endregion

                # region Brood Keeper
                case "Brood Keeper":
                    mcn = new BroodKeeperM15();
                    break;
                # endregion

                # region Burning Anger
                case "Burning Anger":
                    mcn = new BurningAngerM15();
                    break;
                # endregion

                //# region Cancel
                //case"Cancel":
                //    mcn = new CancelM15();
                //    break;
                //# endregion

                # region Carnivorous Moss-Beast
                case "Carnivorous Moss-Beast":
                    mcn = new CarnivorousMossBeastM15();
                    break;
                # endregion

                # region Carrion Crow
                case "Carrion Crow":
                    mcn = new CarrionCrowM15();
                    break;
                # endregion

                # region Caustic Tar
                case "Caustic Tar":
                    mcn = new CausticTarM15();
                    break;
                # endregion

                # region Caves of Koilos
                case "Caves of Koilos":
                    mcn = new CavesofKoilosM15();
                    break;
                # endregion

                # region Centaur Courser
                case "Centaur Courser":
                    mcn = new CentaurCourserM15();
                    break;
                # endregion

                //# region Chandra, Pyromaster
                //case"Chandra, Pyromaster":
                //    mcn = new ChandraPyromasterMM15();
                //    break;
                //# endregion

                # region Charging Rhino
                case "Charging Rhino":
                    mcn = new ChargingRhinoM15();
                    break;
                # endregion

                # region Chasm Skulker
                case "Chasm Skulker":
                    mcn = new ChasmSkulkerM15();
                    break;
                # endregion

                # region Chief Engineer
                case "Chief Engineer":
                    mcn = new ChiefEngineerM15();
                    break;
                # endregion

                //# region Child of Night
                //case"Child of Night":
                //    mcn = new ChildofNightMM15();
                //    break;
                //# endregion

                # region Chord of Calling
                case "Chord of Calling":
                    mcn = new ChordofCallingM15();
                    break;
                # endregion

                # region Chronostutter
                case "Chronostutter":
                    mcn = new ChronostutterM15();
                    break;
                # endregion

                //# region Circle of Flame
                //case "Circle of Flame":
                //    mcn = new CircleofFlameM15();
                //    break;
                //# endregion

                //# region Clear a Path
                //case"Clear a Path":
                //    mcn = new ClearaPathM15();
                //    break;
                //# endregion

                # region Cone of Flame
                case "Cone of Flame":
                    mcn = new ConeofFlameM15();
                    break;
                # endregion

                //# region Congregate
                //case"Congregate":
                //    mcn = new CongregateMM15();
                //    break;
                //# endregion

                # region Constricting Sliver
                case "Constricting Sliver":
                    mcn = new ConstrictingSliverM15();
                    break;
                # endregion

                # region Coral Barrier
                case "Coral Barrier":
                    mcn = new CoralBarrierM15();
                    break;
                # endregion

                # region Covenant of Blood
                case "Covenant of Blood":
                    mcn = new CovenantofBloodM15();
                    break;
                # endregion

                # region Crippling Blight
                case "Crippling Blight":
                    mcn = new CripplingBlightM15();
                    break;
                # endregion

                # region Crowd's Favor
                case "Crowd's Favor":
                    mcn = new CrowdsFavorM15();
                    break;
                # endregion

                //# region Crucible of Fire
                //case "Crucible of Fire":
                //    mcn = new CrucibleofFireM15();
                //    break;
                //# endregion

                # region Cruel Sadist
                case "Cruel Sadist":
                    mcn = new CruelSadistM15();
                    break;
                # endregion

                # region Darksteel Citadel
                case "Darksteel Citadel":
                    mcn = new DarksteelCitadelM15();
                    break;
                # endregion

                # region Dauntless River Marshal
                case "Dauntless River Marshal":
                    mcn = new DauntlessRiverMarshalM15();
                    break;
                # endregion

                # region Devouring Light
                case "Devouring Light":
                    mcn = new DevouringLightM15();
                    break;
                # endregion

                # region Diffusion Sliver
                case "Diffusion Sliver":
                    mcn = new DiffusionSliverM15();
                    break;
                # endregion

                # region Dissipate
                case "Dissipate":
                    mcn = new DissipateM15();
                    break;
                # endregion

                //# region Divination
                //case"Divination":
                //    mcn = new DivinationM15();
                //    break;
                //# endregion

                //# region Divine Favor
                //case"Divine Favor":
                //    mcn = new DivineFavorM15();
                //    break;
                //# endregion

                //# region Divine Verdict
                //case"Divine Verdict":
                //    mcn = new DivineVerdictM15();
                //    break;
                //# endregion

                //# region Elvish Mystic
                //case"Elvish Mystic":
                //    mcn = new ElvishMysticM15();
                //    break;
                //# endregion

                # region Encrust
                case "Encrust":
                    mcn = new EncrustM15();
                    break;
                # endregion

                # region Endless Obedience
                case "Endless Obedience":
                    mcn = new EndlessObedienceM15();
                    break;
                # endregion

                # region Ensoul Artifact
                case "Ensoul Artifact":
                    mcn = new EnsoulArtifactM15();
                    break;
                # endregion

                # region Ephemeral Shields
                case "Ephemeral Shields":
                    mcn = new EphemeralShieldsM15();
                    break;
                # endregion

                # region Eternal Thirst
                case "Eternal Thirst":
                    mcn = new EternalThirstM15();
                    break;
                # endregion

                //# region Evolving Wilds
                //case "Evolving Wilds":
                //    mcn = new EvolvingWildsM15();
                //    break;
                //# endregion

                # region Feast on the Fallen
                case "Feast on the Fallen":
                    mcn = new FeastontheFallenM15();
                    break;
                # endregion

                # region Feral Incarnation
                case "Feral Incarnation":
                    mcn = new FeralIncarnationM15();
                    break;
                # endregion

                # region Festergloom
                case "Festergloom":
                    mcn = new FestergloomM15();
                    break;
                # endregion

                # region First Response
                case "First Response":
                    mcn = new FirstResponseM15();
                    break;
                # endregion

                # region Flesh to Dust
                case "Flesh to Dust":
                    mcn = new FleshtoDustM15();
                    break;
                # endregion

                //# region Forest
                //case"Forest":
                //    mcn = new ForestM15();
                //    break;
                //# endregion

                //# region Forge Devil
                //case "Forge Devil":
                //    mcn = new ForgeDevilM15();
                //    break;
                //# endregion

                //# region Foundry Street Denizen
                //case"Foundry Street Denizen":
                //    mcn = new FoundryStreetDenizenM15();
                //    break;
                //# endregion

                # region Frenzied Goblin
                case "Frenzied Goblin":
                    mcn = new FrenziedGoblinM15();
                    break;
                # endregion

                # region Frost Lynx
                case "Frost Lynx":
                    mcn = new FrostLynxM15();
                    break;
                # endregion

                # region Fugitive Wizard
                case "Fugitive Wizard":
                    mcn = new FugitiveWizardM15();
                    break;
                # endregion

                # region Furnace Whelp
                case "Furnace Whelp":
                    mcn = new FurnaceWhelpM15();
                    break;
                # endregion

                # region Gargoyle Sentinel
                case "Gargoyle Sentinel":
                    mcn = new GargoyleSentinelM15();
                    break;
                # endregion

                # region Garruk, Apex Predator
                case "Garruk, Apex Predator":
                    mcn = new GarrukApexPredatorM15();
                    break;
                # endregion

                # region Garruk's Packleader
                case "Garruk's Packleader":
                    mcn = new GarruksPackleaderM15();
                    break;
                # endregion

                # region Gather Courage
                case "Gather Courage":
                    mcn = new GatherCourageM15();
                    break;
                # endregion

                # region Geist of the Moors
                case "Geist of the Moors":
                    mcn = new GeistoftheMoorsM15();
                    break;
                # endregion

                # region Generator Servant
                case "Generator Servant":
                    mcn = new GeneratorServantM15();
                    break;
                # endregion

                # region Genesis Hydra
                case "Genesis Hydra":
                    mcn = new GenesisHydraM15();
                    break;
                # endregion

                # region Glacial Crasher
                case "Glacial Crasher":
                    mcn = new GlacialCrasherM15();
                    break;
                # endregion

                # region Goblin Kaboomist
                case "Goblin Kaboomist":
                    mcn = new GoblinKaboomistM15();
                    break;
                # endregion

                # region Goblin Rabblemaster
                case "Goblin Rabblemaster":
                    mcn = new GoblinRabblemasterM15();
                    break;
                # endregion

                # region Goblin Roughrider
                case "Goblin Roughrider":
                    mcn = new GoblinRoughriderM15();
                    break;
                # endregion

                //# region Gravedigger
                //case "Gravedigger":
                //    mcn = new GravediggerM15();
                //    break;
                //# endregion

                # region Grindclock
                case "Grindclock":
                    mcn = new GrindclockM15();
                    break;
                # endregion

                # region Hammerhand
                case "Hammerhand":
                    mcn = new HammerhandM15();
                    break;
                # endregion

                //# region Haunted Plate Mail
                //case"Haunted Plate Mail":
                //    mcn = new HauntedPlateMailM15();
                //    break;
                //# endregion

                # region Heat Ray
                case "Heat Ray":
                    mcn = new HeatRayM15();
                    break;
                # endregion

                # region Heliod's Pilgrim
                case "Heliod's Pilgrim":
                    mcn = new HeliodsPilgrimM15();
                    break;
                # endregion

                # region Hoarding Dragon
                case "Hoarding Dragon":
                    mcn = new HoardingDragonM15();
                    break;
                # endregion

                # region Hornet Nest
                case "Hornet Nest":
                    mcn = new HornetNestM15();
                    break;
                # endregion

                # region Hornet Queen
                case "Hornet Queen":
                    mcn = new HornetQueenM15();
                    break;
                # endregion

                # region Hot Soup
                case "Hot Soup":
                    mcn = new HotSoupM15();
                    break;
                # endregion

                //# region Hunt the Weak
                //case"Hunt the Weak":
                //    mcn = new HunttheWeakM15();
                //    break;
                //# endregion

                # region Hunter's Ambush
                case "Hunter's Ambush":
                    mcn = new HuntersAmbushM15();
                    break;
                # endregion

                # region Hushwing Gryff
                case "Hushwing Gryff":
                    mcn = new HushwingGryffM15();
                    break;
                # endregion

                # region Hydrosurge
                case "Hydrosurge":
                    mcn = new HydrosurgeM15();
                    break;
                # endregion

                # region Illusory Angel
                case "Illusory Angel":
                    mcn = new IllusoryAngelM15();
                    break;
                # endregion

                # region In Garruk's Wake
                case "In Garruk's Wake":
                    mcn = new InGarruksWakeM15();
                    break;
                # endregion

                # region Indulgent Tormentor
                case "Indulgent Tormentor":
                    mcn = new IndulgentTormentorM15();
                    break;
                # endregion

                # region Inferno Fist
                case "Inferno Fist":
                    mcn = new InfernoFistM15();
                    break;
                # endregion

                # region Inspired Charge
                case "Inspired Charge":
                    mcn = new InspiredChargeM15();
                    break;
                # endregion

                //# region Into the Void
                //case"Into the Void":
                //    mcn = new IntotheVoidM15();
                //    break;
                //# endregion

                # region Invasive Species
                case "Invasive Species":
                    mcn = new InvasiveSpeciesM15();
                    break;
                # endregion

                //# region Invisibility
                //case "Invisibility":
                //    mcn = new InvisibilityM15();
                //    break;
                //# endregion

                //# region Island
                //case"Island":
                //    mcn = new IslandM15();
                //    break;
                //# endregion

                # region Jace, the Living Guildpact
                case "Jace, the Living Guildpact":
                    mcn = new JacetheLivingGuildpactM15();
                    break;
                # endregion

                # region Jace's Ingenuity
                case "Jace's Ingenuity":
                    mcn = new JacesIngenuityM15();
                    break;
                # endregion

                # region Jalira, Master Polymorphist
                case "Jalira, Master Polymorphist":
                    mcn = new JaliraMasterPolymorphistM15();
                    break;
                # endregion

                # region Jorubai Murk Lurker
                case "Jorubai Murk Lurker":
                    mcn = new JorubaiMurkLurkerM15();
                    break;
                # endregion

                //# region Juggernaut
                //case "Juggernaut":
                //    mcn = new JuggernautM15();
                //    break;
                //# endregion

                # region Kalonian Twingrove
                case "Kalonian Twingrove":
                    mcn = new KalonianTwingroveM15();
                    break;
                # endregion

                # region Kapsho Kitefins
                case "Kapsho Kitefins":
                    mcn = new KapshoKitefinsM15();
                    break;
                # endregion

                //# region Kinsbaile Skirmisher
                //case "Kinsbaile Skirmisher":
                //    mcn = new KinsbaileSkirmisherM15();
                //    break;
                //# endregion

                # region Kird Chieftain
                case "Kird Chieftain":
                    mcn = new KirdChieftainM15();
                    break;
                # endregion

                # region Krenko's Enforcer
                case "Krenko's Enforcer":
                    mcn = new KrenkosEnforcerM15();
                    break;
                # endregion

                # region Kurkesh, Onakke Ancient
                case "Kurkesh, Onakke Ancient":
                    mcn = new KurkeshOnakkeAncientM15();
                    break;
                # endregion

                //# region Lava Axe
                //case"Lava Axe":
                //    mcn = new LavaAxeM15();
                //    break;
                //# endregion

                # region Leeching Sliver
                case "Leeching Sliver":
                    mcn = new LeechingSliverM15();
                    break;
                # endregion

                # region Life's Legacy
                case "Life's Legacy":
                    mcn = new LifesLegacyM15();
                    break;
                # endregion

                //# region Lightning Strike
                //case"Lightning Strike":
                //    mcn = new LightningStrikeM15();
                //    break;
                //# endregion

                //# region Liliana Vess
                //case "Liliana Vess":
                //    mcn = new LilianaVessM15();
                //    break;
                //# endregion

                # region Living Totem
                case "Living Totem":
                    mcn = new LivingTotemM15();
                    break;
                # endregion

                # region Llanowar Wastes
                case "Llanowar Wastes":
                    mcn = new LlanowarWastesM15();
                    break;
                # endregion

                //# region Mahamoti Djinn
                //case "Mahamoti Djinn":
                //    mcn = new MahamotiDjinnM15();
                //    break;
                //# endregion

                # region Marked by Honor
                case "Marked by Honor":
                    mcn = new MarkedbyHonorM15();
                    break;
                # endregion

                //# region Mass Calcify
                //case "Mass Calcify":
                //    mcn = new MassCalcifyM15();
                //    break;
                //# endregion

                # region Master of Predicaments
                case "Master of Predicaments":
                    mcn = new MasterofPredicamentsM15();
                    break;
                # endregion

                # region Meditation Puzzle
                case "Meditation Puzzle":
                    mcn = new MeditationPuzzleM15();
                    break;
                # endregion

                # region Mercurial Pretender
                case "Mercurial Pretender":
                    mcn = new MercurialPretenderM15();
                    break;
                # endregion

                # region Meteorite
                case "Meteorite":
                    mcn = new MeteoriteM15();
                    break;
                # endregion

                //# region Midnight Guard
                //case "Midnight Guard":
                //    mcn = new MidnightGuardM15();
                //    break;
                //# endregion

                # region Might Makes Right
                case "Might Makes Right":
                    mcn = new MightMakesRightM15();
                    break;
                # endregion

                # region Military Intelligence
                case "Military Intelligence":
                    mcn = new MilitaryIntelligenceM15();
                    break;
                # endregion

                //# region Mind Rot
                //case"Mind Rot":
                //    mcn = new MindRotM15();
                //    break;
                //# endregion

                # region Mind Sculpt
                case "Mind Sculpt":
                    mcn = new MindSculptM15();
                    break;
                # endregion

                # region Miner's Bane
                case "Miner's Bane":
                    mcn = new MinersBaneM15();
                    break;
                # endregion

                //# region Mountain
                //case"Mountain":
                //    mcn = new MountainM15();
                //    break;
                //# endregion

                //# region Naturalize
                //case"Naturalize":
                //    mcn = new NaturalizeM15();
                //    break;
                //# endregion

                //# region Necrobite
                //case"Necrobite":
                //    mcn = new NecrobiteM15();
                //    break;
                //# endregion

                # region Necrogen Scudder
                case "Necrogen Scudder":
                    mcn = new NecrogenScudderM15();
                    break;
                # endregion

                # region Necromancer's Assistant
                case "Necromancer's Assistant":
                    mcn = new NecromancersAssistantM15();
                    break;
                # endregion

                # region Necromancer's Stockpile
                case "Necromancer's Stockpile":
                    mcn = new NecromancersStockpileM15();
                    break;
                # endregion

                //# region Negate
                //case"Negate":
                //    mcn = new NegateM15();
                //    break;
                //# endregion

                # region Netcaster Spider
                case "Netcaster Spider":
                    mcn = new NetcasterSpiderM15();
                    break;
                # endregion

                # region Nightfire Giant
                case "Nightfire Giant":
                    mcn = new NightfireGiantM15();
                    break;
                # endregion

                //# region Nightmare
                //case"Nightmare":
                //    mcn = new NightmareM15();
                //    break;
                //# endregion

                # region Nimbus of the Isles
                case "Nimbus of the Isles":
                    mcn = new NimbusoftheIslesM15();
                    break;
                # endregion

                # region Nissa, Worldwaker
                case "Nissa, Worldwaker":
                    mcn = new NissaWorldwakerM15();
                    break;
                # endregion

                # region Nissa's Expedition
                case "Nissa's Expedition":
                    mcn = new NissasExpeditionM15();
                    break;
                # endregion

                # region Ob Nixilis, Unshackled
                case "Ob Nixilis, Unshackled":
                    mcn = new ObNixilisUnshackledM15();
                    break;
                # endregion

                # region Obelisk of Urd
                case "Obelisk of Urd":
                    mcn = new ObeliskofUrdM15();
                    break;
                # endregion

                //# region Oppressive Rays
                //case"Oppressive Rays":
                //    mcn = new OppressiveRaysM15();
                //    break;
                //# endregion

                //# region Oreskos Swiftclaw
                //case"Oreskos Swiftclaw":
                //    mcn = new OreskosSwiftclawM15();
                //    break;
                //# endregion

                //# region Ornithopter
                //case "Ornithopter":
                //    mcn = new OrnithopterM15();
                //    break;
                //# endregion

                # region Overwhelm
                case "Overwhelm":
                    mcn = new OverwhelmM15();
                    break;
                # endregion

                # region Paragon of Eternal Wilds
                case "Paragon of Eternal Wilds":
                    mcn = new ParagonofEternalWildsM15();
                    break;
                # endregion

                # region Paragon of Fierce Defiance
                case "Paragon of Fierce Defiance":
                    mcn = new ParagonofFierceDefianceM15();
                    break;
                # endregion

                # region Paragon of Gathering Mists
                case "Paragon of Gathering Mists":
                    mcn = new ParagonofGatheringMistsM15();
                    break;
                # endregion

                # region Paragon of New Dawns
                case "Paragon of New Dawns":
                    mcn = new ParagonofNewDawnsM15();
                    break;
                # endregion

                # region Paragon of Open Graves
                case "Paragon of Open Graves":
                    mcn = new ParagonofOpenGravesM15();
                    break;
                # endregion

                //# region Peel from Reality
                //case"Peel from Reality":
                //    mcn = new PeelfromRealityM15();
                //    break;
                //# endregion

                # region Perilous Vault
                case "Perilous Vault":
                    mcn = new PerilousVaultM15();
                    break;
                # endregion

                # region Phyrexian Revoker
                case "Phyrexian Revoker":
                    mcn = new PhyrexianRevokerM15();
                    break;
                # endregion

                # region Phytotitan
                case "Phytotitan":
                    mcn = new PhytotitanM15();
                    break;
                # endregion

                # region Pillar of Light
                case "Pillar of Light":
                    mcn = new PillarofLightM15();
                    break;
                # endregion

                //# region Plains
                //case"Plains":
                //    mcn = new PlainsM15();
                //    break;
                //# endregion

                //# region Plummet
                //case"Plummet":
                //    mcn = new PlummetM15();
                //    break;
                //# endregion

                # region Polymorphist's Jest
                case "Polymorphist's Jest":
                    mcn = new PolymorphistsJestM15();
                    break;
                # endregion

                # region Preeminent Captain
                case "Preeminent Captain":
                    mcn = new PreeminentCaptainM15();
                    break;
                # endregion

                # region Profane Memento
                case "Profane Memento":
                    mcn = new ProfaneMementoM15();
                    break;
                # endregion

                # region Quickling
                case "Quickling":
                    mcn = new QuicklingM15();
                    break;
                # endregion

                # region Radiant Fountain
                case "Radiant Fountain":
                    mcn = new RadiantFountainM15();
                    break;
                # endregion

                //# region Raise the Alarm
                //case "Raise the Alarm":
                //    mcn = new RaisetheAlarmM15();
                //    break;
                //# endregion

                //# region Ranger's Guile
                //case"Ranger's Guile":
                //    mcn = new RangersGuileM15();
                //    break;
                //# endregion

                # region Razorfoot Griffin
                case "Razorfoot Griffin":
                    mcn = new RazorfootGriffinM15();
                    break;
                # endregion

                # region Reclamation Sage
                case "Reclamation Sage":
                    mcn = new ReclamationSageM15();
                    break;
                # endregion

                # region Research Assistant
                case "Research Assistant":
                    mcn = new ResearchAssistantM15();
                    break;
                # endregion

                # region Resolute Archangel
                case "Resolute Archangel":
                    mcn = new ResoluteArchangelM15();
                    break;
                # endregion

                # region Restock
                case "Restock":
                    mcn = new RestockM15();
                    break;
                # endregion

                # region Return to the Ranks
                case "Return to the Ranks":
                    mcn = new ReturntotheRanksM15();
                    break;
                # endregion

                # region Roaring Primadox
                case "Roaring Primadox":
                    mcn = new RoaringPrimadoxM15();
                    break;
                # endregion

                # region Rogue's Gloves
                case "Rogue's Gloves":
                    mcn = new RoguesGlovesM15();
                    break;
                # endregion

                # region Rotfeaster Maggot
                case "Rotfeaster Maggot":
                    mcn = new RotfeasterMaggotM15();
                    break;
                # endregion

                # region Rummaging Goblin
                case "Rummaging Goblin":
                    mcn = new RummagingGoblinM15();
                    break;
                # endregion

                //# region Runeclaw Bear
                //case "Runeclaw Bear":
                //    mcn = new RuneclawBearM15();
                //    break;
                //# endregion

                # region Sacred Armory
                case "Sacred Armory":
                    mcn = new SacredArmoryM15();
                    break;
                # endregion

                # region Sanctified Charge
                case "Sanctified Charge":
                    mcn = new SanctifiedChargeM15();
                    break;
                # endregion

                //# region Satyr Wayfinder
                //case"Satyr Wayfinder":
                //    mcn = new SatyrWayfinderM15();
                //    break;
                //# endregion

                # region Scrapyard Mongrel
                case "Scrapyard Mongrel":
                    mcn = new ScrapyardMongrelM15();
                    break;
                # endregion

                # region Scuttling Doom Engine
                case "Scuttling Doom Engine":
                    mcn = new ScuttlingDoomEngineM15();
                    break;
                # endregion

                # region Seismic Strike
                case "Seismic Strike":
                    mcn = new SeismicStrikeM15();
                    break;
                # endregion

                # region Selfless Cathar
                case "Selfless Cathar":
                    mcn = new SelflessCatharM15();
                    break;
                # endregion

                //# region Sengir Vampire
                //case"Sengir Vampire":
                //    mcn = new SengirVampireM15();
                //    break;
                //# endregion

                # region Seraph of the Masses
                case "Seraph of the Masses":
                    mcn = new SeraphoftheMassesM15();
                    break;
                # endregion

                //# region Serra Angel
                //case"Serra Angel":
                //    mcn = new SerraAngelM15();
                //    break;
                //# endregion

                # region Shadowcloak Vampire
                case "Shadowcloak Vampire":
                    mcn = new ShadowcloakVampireM15();
                    break;
                # endregion

                # region Shaman of Spring
                case "Shaman of Spring":
                    mcn = new ShamanofSpringM15();
                    break;
                # endregion

                # region Shield of the Avatar
                case "Shield of the Avatar":
                    mcn = new ShieldoftheAvatarM15();
                    break;
                # endregion

                //# region Shivan Dragon
                //case"Shivan Dragon":
                //    mcn = new ShivanDragonM15();
                //    break;
                //# endregion

                # region Shivan Reef
                case "Shivan Reef":
                    mcn = new ShivanReefM15();
                    break;
                # endregion

                //# region Shrapnel Blast
                //case "Shrapnel Blast":
                //    mcn = new ShrapnelBlastM15();
                //    break;
                //# endregion

                # region Siege Dragon
                case "Siege Dragon":
                    mcn = new SiegeDragonM15();
                    break;
                # endregion

                # region Siege Wurm
                case "Siege Wurm":
                    mcn = new SiegeWurmM15();
                    break;
                # endregion

                # region Sign in Blood
                case "Sign in Blood":
                    mcn = new SigninBloodM15();
                    break;
                # endregion

                # region Sliver Hive
                case "Sliver Hive":
                    mcn = new SliverHiveM15();
                    break;
                # endregion

                # region Sliver Hivelord
                case "Sliver Hivelord":
                    mcn = new SliverHivelordM15();
                    break;
                # endregion

                //# region Solemn Offering
                //case"Solemn Offering":
                //    mcn = new SolemnOfferingM15();
                //    break;
                //# endregion

                # region Soul of Innistrad
                case "Soul of Innistrad":
                    mcn = new SoulofInnistradM15();
                    break;
                # endregion

                # region Soul of New Phyrexia
                case "Soul of New Phyrexia":
                    mcn = new SoulofNewPhyrexiaM15();
                    break;
                # endregion

                # region Soul of Ravnica
                case "Soul of Ravnica":
                    mcn = new SoulofRavnicaM15();
                    break;
                # endregion

                # region Soul of Shandalar
                case "Soul of Shandalar":
                    mcn = new SoulofShandalarM15();
                    break;
                # endregion

                # region Soul of Theros
                case "Soul of Theros":
                    mcn = new SoulofTherosM15();
                    break;
                # endregion

                # region Soul of Zendikar
                case "Soul of Zendikar":
                    mcn = new SoulofZendikarM15();
                    break;
                # endregion

                //# region Soulmender
                //case"Soulmender":
                //    mcn = new SoulmenderM15();
                //    break;
                //# endregion

                # region Spectra Ward
                case "Spectra Ward":
                    mcn = new SpectraWardM15();
                    break;
                # endregion

                # region Spirit Bonds
                case "Spirit Bonds":
                    mcn = new SpiritBondsM15();
                    break;
                # endregion

                //# region Stab Wound
                //case"Stab Wound":
                //    mcn = new StabWoundM15();
                //    break;
                //# endregion

                //# region Staff of the Death Magus
                //case"Staff of the Death Magus":
                //    mcn = new StaffoftheDeathMagusM15();
                //    break;
                //# endregion

                //# region Staff of the Flame Magus
                //case"Staff of the Flame Magus":
                //    mcn = new StaffoftheFlameMagusM15();
                //    break;
                //# endregion

                //# region Staff of the Mind Magus
                //case"Staff of the Mind Magus":
                //    mcn = new StaffoftheMindMagusM15();
                //    break;
                //# endregion

                //# region Staff of the Sun Magus
                //case"Staff of the Sun Magus":
                //    mcn = new StaffoftheSunMagusM15();
                //    break;
                //# endregion

                //# region Staff of the Wild Magus
                //case"Staff of the Wild Magus":
                //    mcn = new StaffoftheWildMagusM15();
                //    break;
                //# endregion

                # region Stain the Mind
                case "Stain the Mind":
                    mcn = new StaintheMindM15();
                    break;
                # endregion

                # region Statute of Denial
                case "Statute of Denial":
                    mcn = new StatuteofDenialM15();
                    break;
                # endregion

                # region Stoke the Flames
                case "Stoke the Flames":
                    mcn = new StoketheFlamesM15();
                    break;
                # endregion

                # region Stormtide Leviathan
                case "Stormtide Leviathan":
                    mcn = new StormtideLeviathanM15();
                    break;
                # endregion

                # region Sunblade Elf
                case "Sunblade Elf":
                    mcn = new SunbladeElfM15();
                    break;
                # endregion

                # region Sungrace Pegasus
                case "Sungrace Pegasus":
                    mcn = new SungracePegasusM15();
                    break;
                # endregion

                //# region Swamp
                //case"Swamp":
                //    mcn = new SwampM15();
                //    break;
                //# endregion

                # region Terra Stomper
                case "Terra Stomper":
                    mcn = new TerraStomperM15();
                    break;
                # endregion

                # region The Chain Veil
                case "The Chain Veil":
                    mcn = new TheChainVeilM15();
                    break;
                # endregion

                # region Thundering Giant
                case "Thundering Giant":
                    mcn = new ThunderingGiantM15();
                    break;
                # endregion

                # region Tireless Missionaries
                case "Tireless Missionaries":
                    mcn = new TirelessMissionariesM15();
                    break;
                # endregion

                //# region Titanic Growth
                //case "Titanic Growth":
                //    mcn = new TitanicGrowthM15();
                //    break;
                //# endregion

                //# region Torch Fiend
                //case "Torch Fiend":
                //    mcn = new TorchFiendM15();
                //    break;
                //# endregion

                # region Tormod's Crypt
                case "Tormod's Crypt":
                    mcn = new TormodsCryptM15();
                    break;
                # endregion

                # region Triplicate Spirits
                case "Triplicate Spirits":
                    mcn = new TriplicateSpiritsM15();
                    break;
                # endregion

                //# region Turn to Frog
                //case "Turn to Frog":
                //    mcn = new TurntoFrogM15();
                //    break;
                //# endregion

                # region Typhoid Rats
                case "Typhoid Rats":
                    mcn = new TyphoidRatsM15();
                    break;
                # endregion

                # region Tyrant's Machine
                case "Tyrant's Machine":
                    mcn = new TyrantsMachineM15();
                    break;
                # endregion

                # region Ulcerate
                case "Ulcerate":
                    mcn = new UlcerateM15();
                    break;
                # endregion

                # region Undergrowth Scavenger
                case "Undergrowth Scavenger":
                    mcn = new UndergrowthScavengerM15();
                    break;
                # endregion

                # region Unmake the Graves
                case "Unmake the Graves":
                    mcn = new UnmaketheGravesM15();
                    break;
                # endregion

                # region Urborg, Tomb of Yawgmoth
                case "Urborg, Tomb of Yawgmoth":
                    mcn = new UrborgTombofYawgmothM15();
                    break;
                # endregion

                # region Venom Sliver
                case "Venom Sliver":
                    mcn = new VenomSliverM15();
                    break;
                # endregion

                //# region Verdant Haven
                //case"Verdant Haven":
                //    mcn = new VerdantHavenM15();
                //    break;
                //# endregion

                # region Vineweft
                case "Vineweft":
                    mcn = new VineweftM15();
                    break;
                # endregion

                # region Void Snare
                case "Void Snare":
                    mcn = new VoidSnareM15();
                    break;
                # endregion

                # region Walking Corpse
                case "Walking Corpse":
                    mcn = new WalkingCorpseM15();
                    break;
                # endregion

                # region Wall of Essence
                case "Wall of Essence":
                    mcn = new WallofEssenceM15();
                    break;
                # endregion

                //# region Wall of Fire
                //case "Wall of Fire":
                //    mcn = new WallofFireM15();
                //    break;
                //# endregion

                //# region Wall of Frost
                //case"Wall of Frost":
                //    mcn = new WallofFrostM15();
                //    break;
                //# endregion

                # region Wall of Limbs
                case "Wall of Limbs":
                    mcn = new WallofLimbsM15();
                    break;
                # endregion

                # region Wall of Mulch
                case "Wall of Mulch":
                    mcn = new WallofMulchM15();
                    break;
                # endregion

                # region Warden of the Beyond
                case "Warden of the Beyond":
                    mcn = new WardenoftheBeyondM15();
                    break;
                # endregion

                # region Waste Not
                case "Waste Not":
                    mcn = new WasteNotM15();
                    break;
                # endregion

                # region Welkin Tern
                case "Welkin Tern":
                    mcn = new WelkinTernM15();
                    break;
                # endregion

                # region Will-Forged Golem
                case "Will-Forged Golem":
                    mcn = new WillForgedGolemM15();
                    break;
                # endregion

                # region Witch's Familiar
                case "Witch's Familiar":
                    mcn = new WitchsFamiliarM15();
                    break;
                # endregion

                # region Xathrid Slyblade
                case "Xathrid Slyblade":
                    mcn = new XathridSlybladeM15();
                    break;
                # endregion

                # region Yavimaya Coast
                case "Yavimaya Coast":
                    mcn = new YavimayaCoastM15();
                    break;
                # endregion

                # region Yisan, the Wanderer Bard
                case "Yisan, the Wanderer Bard":
                    mcn = new YisantheWandererBardM15();
                    break;
                # endregion

                # region Zof Shade
                case "Zof Shade":
                    mcn = new ZofShadeM15();
                    break;
                # endregion

                # endregion

                # region Commander 2011
                case "Fists of Ironwood":
                    mcn = new FistsofIronwoodC11();
                    break;
                # endregion

                # region Commander 2014
                case "Overwhelming Stampede":
                    mcn = new OverwhelmingStampede();
                    break;
                # endregion

                # region Ice Age
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

                //# region Brown Ouphe
                //case "Brown Ouphe":
                //    mcn = new BrownOupheIA();
                //    break;
                //# endregion

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

                //# region Circle of Protection: Black
                //case "Circle of Protection: Black":
                //    mcn = new CircleofProtectionBlackIA();
                //    break;
                //# endregion

                //# region Circle of Protection: Blue
                //case "Circle of Protection: Blue":
                //    mcn = new CircleofProtectionBlueIA();
                //    break;
                //# endregion

                //# region Circle of Protection: Green
                //case "Circle of Protection: Green":
                //    mcn = new CircleofProtectionGreenIA();
                //    break;
                //# endregion

                //# region Circle of Protection: Red
                //case "Circle of Protection: Red":
                //    mcn = new CircleofProtectionRedIA();
                //    break;
                //# endregion

                //# region Circle of Protection: White
                //case "Circle of Protection: White":
                //    mcn = new CircleofProtectionWhiteIA();
                //    break;
                //# endregion

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

                //# region Counterspell
                //case "Counterspell":
                //    mcn = new CounterspellIA();
                //    break;
                //# endregion

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

                //# region Dark Ritual
                //case "Dark Ritual":
                //    mcn = new DarkRitualIA();
                //    break;
                //# endregion

                //# region Death Ward
                //case "Death Ward":
                //    mcn = new DeathWardIA();
                //    break;
                //# endregion

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

                //# region Disenchant
                //case "Disenchant":
                //    mcn = new DisenchantIA();
                //    break;
                //# endregion

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

                //# region Fear
                //case "Fear":
                //    mcn = new FearIA();
                //    break;
                //# endregion

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

                //# region Forest
                //case "Forest":
                //    mcn = new ForestIA();
                //    break;
                //# endregion

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
                //case"Giant Growth":
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

                //# region Howl from Beyond
                //case "Howl from Beyond":
                //    mcn = new HowlfromBeyondIA();
                //    break;
                //# endregion

                //# region Hurricane
                //case "Hurricane":
                //    mcn = new HurricaneIA();
                //    break;
                //# endregion

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

                //# region Icy Manipulator
                //case "Icy Manipulator":
                //    mcn = new IcyManipulatorIA();
                //    break;
                //# endregion

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

                //# region Incinerate
                //case "Incinerate":
                //    mcn = new IncinerateIA();
                //    break;
                //# endregion

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

                //# region Island
                //case "Island":
                //    mcn = new IslandIA();
                //    break;
                //# endregion

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

                //# region Lure
                //case "Lure":
                //    mcn = new LureIA();
                //    break;
                //# endregion

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

                //# region Mountain
                //case "Mountain":
                //    mcn = new MountainIA();
                //    break;
                //# endregion

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

                //# region Plains
                //case "Plains":
                //    mcn = new PlainsIA();
                //    break;
                //# endregion

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

                //# region Power Sink
                //case "Power Sink":
                //    mcn = new PowerSinkIA();
                //    break;
                //# endregion

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

                //# region Regeneration
                //case "Regeneration":
                //    mcn = new RegenerationIA();
                //    break;
                //# endregion

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

                //# region Shatter
                //case "Shatter":
                //    mcn = new ShatterIA();
                //    break;
                //# endregion

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

                //# region Sleight of Mind
                //case "Sleight of Mind":
                //    mcn = new SleightofMindIA();
                //    break;
                //# endregion

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

                //# region Stone Rain
                //case "Stone Rain":
                //    mcn = new StoneRainIA();
                //    break;
                //# endregion

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

                //# region Swamp
                //case "Swamp":
                //    mcn = new SwampIA();
                //    break;
                //# endregion

                //# region Swords to Plowshares
                //case "Swords to Plowshares":
                //    mcn = new SwordstoPlowsharesIA();
                //    break;
                //# endregion

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

                //# region Wild Growth
                //case "Wild Growth":
                //    mcn = new WildGrowthIA();
                //    break;
                //# endregion

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
                # endregion

                # region Duel Decks: Ajani vs. Nicol Bolas
                # region Ageless Entity
                case "Ageless Entity":
                    mcn = new AgelessEntityDDH();
                    break;
                # endregion

                # region Agonizing Demise
                case "Agonizing Demise":
                    mcn = new AgonizingDemiseDDH();
                    break;
                # endregion

                //# region Ajani Vengeant
                //case "Ajani Vengeant":
                //    mcn = new AjaniVengeantDDH();
                //    break;
                //# endregion

                # region Ajani's Mantra
                case "Ajani's Mantra":
                    mcn = new AjanisMantraDDH();
                    break;
                # endregion

                //# region Ajani's Pridemate
                //case "Ajani's Pridemate":
                //    mcn = new AjanisPridemateDDH();
                //    break;
                //# endregion

                # region Behemoth Sledge
                case "Behemoth Sledge":
                    mcn = new BehemothSledgeDDH();
                    break;
                # endregion

                # region Blazing Specter
                case "Blazing Specter":
                    mcn = new BlazingSpecterDDH();
                    break;
                # endregion

                # region Brackwater Elemental
                case "Brackwater Elemental":
                    mcn = new BrackwaterElementalDDH();
                    break;
                # endregion

                //# region Briarhorn
                //case "Briarhorn":
                //    mcn = new BriarhornDDH();
                //    break;
                //# endregion

                # region Canyon Wildcat
                case "Canyon Wildcat":
                    mcn = new CanyonWildcatDDH();
                    break;
                # endregion

                # region Countersquall
                case "Countersquall":
                    mcn = new CountersquallDDH();
                    break;
                # endregion

                //# region Cruel Ultimatum
                //case "Cruel Ultimatum":
                //    mcn = new CruelUltimatumDDH();
                //    break;
                //# endregion

                //# region Crumbling Necropolis
                //case "Crumbling Necropolis":
                //    mcn = new CrumblingNecropolisDDH();
                //    break;
                //# endregion

                # region Deep Analysis
                case "Deep Analysis":
                    mcn = new DeepAnalysisDDH();
                    break;
                # endregion

                # region Dimir Cutpurse
                case "Dimir Cutpurse":
                    mcn = new DimirCutpurseDDH();
                    break;
                # endregion

                # region Elder Mastery
                case "Elder Mastery":
                    mcn = new ElderMasteryDDH();
                    break;
                # endregion

                # region Essence Warden
                case "Essence Warden":
                    mcn = new EssenceWardenDDH();
                    break;
                # endregion

                //# region Evolving Wilds
                //case "Evolving Wilds":
                //    mcn = new EvolvingWildsDDH();
                //    break;
                //# endregion

                //# region Fire-Field Ogre
                //case "Fire-Field Ogre":
                //    mcn = new FireFieldOgreDDH();
                //    break;
                //# endregion

                # region Firemane Angel
                case "Firemane Angel":
                    mcn = new FiremaneAngelDDH();
                    break;
                # endregion

                # region Fleetfoot Panther
                case "Fleetfoot Panther":
                    mcn = new FleetfootPantherDDH();
                    break;
                # endregion

                //# region Forest
                //case "Forest":
                //    mcn = new ForestDDH();
                //    break;
                //# endregion

                # region Graypelt Refuge
                case "Graypelt Refuge":
                    mcn = new GraypeltRefugeDDH();
                    break;
                # endregion

                # region Grazing Gladehart
                case "Grazing Gladehart":
                    mcn = new GrazingGladehartDDH();
                    break;
                # endregion

                # region Griffin Guide
                case "Griffin Guide":
                    mcn = new GriffinGuideDDH();
                    break;
                # endregion

                //# region Grixis Charm
                //case "Grixis Charm":
                //    mcn = new GrixisCharmDDH();
                //    break;
                //# endregion

                # region Hellfire Mongrel
                case "Hellfire Mongrel":
                    mcn = new HellfireMongrelDDH();
                    break;
                # endregion

                //# region Icy Manipulator
                //case "Icy Manipulator":
                //    mcn = new IcyManipulatorDDH();
                //    break;
                //# endregion

                # region Igneous Pouncer
                case "Igneous Pouncer":
                    mcn = new IgneousPouncerDDH();
                    break;
                # endregion

                //# region Island
                //case "Island":
                //    mcn = new IslandDDH();
                //    break;
                //# endregion

                //# region Jade Mage
                //case "Jade Mage":
                //    mcn = new JadeMageDDH();
                //    break;
                //# endregion

                # region Jhessian Zombies
                case "Jhessian Zombies":
                    mcn = new JhessianZombiesDDH();
                    break;
                # endregion

                //# region Jungle Shrine
                //case "Jungle Shrine":
                //    mcn = new JungleShrineDDH();
                //    break;
                //# endregion

                # region Kazandu Refuge
                case "Kazandu Refuge":
                    mcn = new KazanduRefugeDDH();
                    break;
                # endregion

                # region Kird Ape
                case "Kird Ape":
                    mcn = new KirdApeDDH();
                    break;
                # endregion

                # region Lead the Stampede
                case "Lead the Stampede":
                    mcn = new LeadtheStampedeDDH();
                    break;
                # endregion

                # region Lightning Helix
                case "Lightning Helix":
                    mcn = new LightningHelixDDH();
                    break;
                # endregion

                # region Loam Lion
                case "Loam Lion":
                    mcn = new LoamLionDDH();
                    break;
                # endregion

                # region Loxodon Hierarch
                case "Loxodon Hierarch":
                    mcn = new LoxodonHierarchDDH();
                    break;
                # endregion

                # region Marisi's Twinclaws
                case "Marisi's Twinclaws":
                    mcn = new MarisisTwinclawsDDH();
                    break;
                # endregion

                # region Morgue Toad
                case "Morgue Toad":
                    mcn = new MorgueToadDDH();
                    break;
                # endregion

                # region Moroii
                case "Moroii":
                    mcn = new MoroiiDDH();
                    break;
                # endregion

                //# region Mountain
                //case "Mountain":
                //    mcn = new MountainDDH();
                //    break;
                //# endregion

                # region Nacatl Hunt-Pride
                case "Nacatl Hunt-Pride":
                    mcn = new NacatlHuntPrideDDH();
                    break;
                # endregion

                //# region Naya Charm
                //case "Naya Charm":
                //    mcn = new NayaCharmDDH();
                //    break;
                //# endregion

                # region Nicol Bolas, Planeswalker
                case "Nicol Bolas, Planeswalker":
                    mcn = new NicolBolasPlaneswalkerDDH();
                    break;
                # endregion

                # region Nightscape Familiar
                case "Nightscape Familiar":
                    mcn = new NightscapeFamiliarDDH();
                    break;
                # endregion

                //# region Obelisk of Grixis
                //case "Obelisk of Grixis":
                //    mcn = new ObeliskofGrixisDDH();
                //    break;
                //# endregion

                # region Ogre Savant
                case "Ogre Savant":
                    mcn = new OgreSavantDDH();
                    break;
                # endregion

                # region Pain/Suffering
                case "Pain/Suffering":
                    mcn = new PainSufferingDDH();
                    break;
                # endregion

                //# region Plains
                //case "Plains":
                //    mcn = new PlainsDDH();
                //    break;
                //# endregion

                # region Pride of Lions
                case "Pride of Lions":
                    mcn = new PrideofLionsDDH();
                    break;
                # endregion

                //# region Profane Command
                //case "Profane Command":
                //    mcn = new ProfaneCommandDDH();
                //    break;
                //# endregion

                # region Qasali Pridemage
                case "Qasali Pridemage":
                    mcn = new QasaliPridemageDDH();
                    break;
                # endregion

                # region Recoil
                case "Recoil":
                    mcn = new RecoilDDH();
                    break;
                # endregion

                # region Recumbent Bliss
                case "Recumbent Bliss":
                    mcn = new RecumbentBlissDDH();
                    break;
                # endregion

                # region Rise/Fall
                case "Rise/Fall":
                    mcn = new RiseFallDDH();
                    break;
                # endregion

                # region Rupture Spire
                case "Rupture Spire":
                    mcn = new RuptureSpireDDH();
                    break;
                # endregion

                //# region Sapseep Forest
                //case "Sapseep Forest":
                //    mcn = new SapseepForestDDH();
                //    break;
                //# endregion

                # region Searing Meditation
                case "Searing Meditation":
                    mcn = new SearingMeditationDDH();
                    break;
                # endregion

                //# region Shriekmaw
                //case "Shriekmaw":
                //    mcn = new ShriekmawDDH();
                //    break;
                //# endregion

                # region Slave of Bolas
                case "Slave of Bolas":
                    mcn = new SlaveofBolasDDH();
                    break;
                # endregion

                # region Slavering Nulls
                case "Slavering Nulls":
                    mcn = new SlaveringNullsDDH();
                    break;
                # endregion

                # region Spite/Malice
                case "Spite/Malice":
                    mcn = new SpiteMaliceDDH();
                    break;
                # endregion

                # region Spitemare
                case "Spitemare":
                    mcn = new SpitemareDDH();
                    break;
                # endregion

                # region Steamcore Weird
                case "Steamcore Weird":
                    mcn = new SteamcoreWeirdDDH();
                    break;
                # endregion

                # region Surveilling Sprite
                case "Surveilling Sprite":
                    mcn = new SurveillingSpriteDDH();
                    break;
                # endregion

                //# region Swamp
                //case "Swamp":
                //    mcn = new SwampDDH();
                //    break;
                //# endregion

                # region Sylvan Bounty
                case "Sylvan Bounty":
                    mcn = new SylvanBountyDDH();
                    break;
                # endregion

                # region Sylvan Ranger
                case "Sylvan Ranger":
                    mcn = new SylvanRangerDDH();
                    break;
                # endregion

                # region Terramorphic Expanse
                case "Terramorphic Expanse":
                    mcn = new TerramorphicExpanseDDH();
                    break;
                # endregion

                //# region Titanic Ultimatum
                //case "Titanic Ultimatum":
                //    mcn = new TitanicUltimatumDDH();
                //    break;
                //# endregion

                # region Undermine
                case "Undermine":
                    mcn = new UndermineDDH();
                    break;
                # endregion

                # region Vapor Snag
                case "Vapor Snag":
                    mcn = new VaporSnagDDH();
                    break;
                # endregion

                # region Vitu-Ghazi, the City-Tree
                case "Vitu-Ghazi, the City-Tree":
                    mcn = new VituGhazitheCityTreeDDH();
                    break;
                # endregion

                //# region Wild Nacatl
                //case "Wild Nacatl":
                //    mcn = new WildNacatlDDH();
                //    break;
                //# endregion

                //# region Woolly Thoctar
                //case "Woolly Thoctar":
                //    mcn = new WoollyThoctarDDH();
                //    break;
                //# endregion
                # endregion

                # region Khans of Tarkir
                # region Abomination of Gudul
                case "Abomination of Gudul":
                    mcn = new AbominationofGudulKTK();
                    break;
                # endregion

                # region Abzan Ascendancy
                case "Abzan Ascendancy":
                    mcn = new AbzanAscendancyKTK();
                    break;
                # endregion

                # region Abzan Banner
                case "Abzan Banner":
                    mcn = new AbzanBannerKTK();
                    break;
                # endregion

                # region Abzan Battle Priest
                case "Abzan Battle Priest":
                    mcn = new AbzanBattlePriestKTK();
                    break;
                # endregion

                # region Abzan Charm
                case "Abzan Charm":
                    mcn = new AbzanCharmKTK();
                    break;
                # endregion

                # region Abzan Falconer
                case "Abzan Falconer":
                    mcn = new AbzanFalconerKTK();
                    break;
                # endregion

                # region Abzan Guide
                case "Abzan Guide":
                    mcn = new AbzanGuideKTK();
                    break;
                # endregion

                //# region Act of Treason
                //case "Act of Treason":
                //    mcn = new ActofTreasonKTK();
                //    break;
                //# endregion

                # region Ainok Bond-Kin
                case "Ainok Bond-Kin":
                    mcn = new AinokBondKinKTK();
                    break;
                # endregion

                # region Ainok Tracker
                case "Ainok Tracker":
                    mcn = new AinokTrackerKTK();
                    break;
                # endregion

                # region Alabaster Kirin
                case "Alabaster Kirin":
                    mcn = new AlabasterKirinKTK();
                    break;
                # endregion

                # region Alpine Grizzly
                case "Alpine Grizzly":
                    mcn = new AlpineGrizzlyKTK();
                    break;
                # endregion

                # region Altar of the Brood
                case "Altar of the Brood":
                    mcn = new AltaroftheBroodKTK();
                    break;
                # endregion

                # region Anafenza, the Foremost
                case "Anafenza, the Foremost":
                    mcn = new AnafenzatheForemostKTK();
                    break;
                # endregion

                # region Ankle Shanker
                case "Ankle Shanker":
                    mcn = new AnkleShankerKTK();
                    break;
                # endregion

                # region Arc Lightning
                case "Arc Lightning":
                    mcn = new ArcLightningKTK();
                    break;
                # endregion

                # region Archers' Parapet
                case "Archers' Parapet":
                    mcn = new ArchersParapetKTK();
                    break;
                # endregion

                # region Armament Corps
                case "Armament Corps":
                    mcn = new ArmamentCorpsKTK();
                    break;
                # endregion

                # region Arrow Storm
                case "Arrow Storm":
                    mcn = new ArrowStormKTK();
                    break;
                # endregion

                # region Ashcloud Phoenix
                case "Ashcloud Phoenix":
                    mcn = new AshcloudPhoenixKTK();
                    break;
                # endregion

                # region Avalanche Tusker
                case "Avalanche Tusker":
                    mcn = new AvalancheTuskerKTK();
                    break;
                # endregion

                # region Awaken the Bear
                case "Awaken the Bear":
                    mcn = new AwakentheBearKTK();
                    break;
                # endregion

                # region Barrage of Boulders
                case "Barrage of Boulders":
                    mcn = new BarrageofBouldersKTK();
                    break;
                # endregion

                # region Bear's Companion
                case "Bear's Companion":
                    mcn = new BearsCompanionKTK();
                    break;
                # endregion

                # region Become Immense
                case "Become Immense":
                    mcn = new BecomeImmenseKTK();
                    break;
                # endregion

                # region Bellowing Saddlebrute
                case "Bellowing Saddlebrute":
                    mcn = new BellowingSaddlebruteKTK();
                    break;
                # endregion

                # region Bitter Revelation
                case "Bitter Revelation":
                    mcn = new BitterRevelationKTK();
                    break;
                # endregion

                # region Blinding Spray
                case "Blinding Spray":
                    mcn = new BlindingSprayKTK();
                    break;
                # endregion

                # region Bloodfell Caves
                case "Bloodfell Caves":
                    mcn = new BloodfellCavesKTK();
                    break;
                # endregion

                # region Bloodfire Expert
                case "Bloodfire Expert":
                    mcn = new BloodfireExpertKTK();
                    break;
                # endregion

                # region Bloodfire Mentor
                case "Bloodfire Mentor":
                    mcn = new BloodfireMentorKTK();
                    break;
                # endregion

                # region Bloodsoaked Champion
                case "Bloodsoaked Champion":
                    mcn = new BloodsoakedChampionKTK();
                    break;
                # endregion

                # region Bloodstained Mire
                case "Bloodstained Mire":
                    mcn = new BloodstainedMireKTK();
                    break;
                # endregion

                # region Blossoming Sands
                case "Blossoming Sands":
                    mcn = new BlossomingSandsKTK();
                    break;
                # endregion

                # region Brave the Sands
                case "Brave the Sands":
                    mcn = new BravetheSandsKTK();
                    break;
                # endregion

                # region Briber's Purse
                case "Briber's Purse":
                    mcn = new BribersPurseKTK();
                    break;
                # endregion

                # region Bring Low
                case "Bring Low":
                    mcn = new BringLowKTK();
                    break;
                # endregion

                # region Burn Away
                case "Burn Away":
                    mcn = new BurnAwayKTK();
                    break;
                # endregion

                # region Butcher of the Horde
                case "Butcher of the Horde":
                    mcn = new ButcheroftheHordeKTK();
                    break;
                # endregion

                //# region Cancel
                //case "Cancel":
                //    mcn = new CancelKTK();
                //    break;
                //# endregion

                # region Canyon Lurkers
                case "Canyon Lurkers":
                    mcn = new CanyonLurkersKTK();
                    break;
                # endregion

                # region Chief of the Edge
                case "Chief of the Edge":
                    mcn = new ChiefoftheEdgeKTK();
                    break;
                # endregion

                # region Chief of the Scale
                case "Chief of the Scale":
                    mcn = new ChiefoftheScaleKTK();
                    break;
                # endregion

                # region Clever Impersonator
                case "Clever Impersonator":
                    mcn = new CleverImpersonatorKTK();
                    break;
                # endregion

                # region Crackling Doom
                case "Crackling Doom":
                    mcn = new CracklingDoomKTK();
                    break;
                # endregion

                # region Cranial Archive
                case "Cranial Archive":
                    mcn = new CranialArchiveKTK();
                    break;
                # endregion

                # region Crater's Claws
                case "Crater's Claws":
                    mcn = new CratersClawsKTK();
                    break;
                # endregion

                //# region Crippling Chill
                //case "Crippling Chill":
                //    mcn = new CripplingChillKTK();
                //    break;
                //# endregion

                # region Dazzling Ramparts
                case "Dazzling Ramparts":
                    mcn = new DazzlingRampartsKTK();
                    break;
                # endregion

                # region Dead Drop
                case "Dead Drop":
                    mcn = new DeadDropKTK();
                    break;
                # endregion

                # region Death Frenzy
                case "Death Frenzy":
                    mcn = new DeathFrenzyKTK();
                    break;
                # endregion

                # region Debilitating Injury
                case "Debilitating Injury":
                    mcn = new DebilitatingInjuryKTK();
                    break;
                # endregion

                # region Defiant Strike
                case "Defiant Strike":
                    mcn = new DefiantStrikeKTK();
                    break;
                # endregion

                # region Deflecting Palm
                case "Deflecting Palm":
                    mcn = new DeflectingPalmKTK();
                    break;
                # endregion

                # region Despise
                case "Despise":
                    mcn = new DespiseKTK();
                    break;
                # endregion

                # region Dig Through Time
                case "Dig Through Time":
                    mcn = new DigThroughTimeKTK();
                    break;
                # endregion

                # region Disdainful Stroke
                case "Disdainful Stroke":
                    mcn = new DisdainfulStrokeKTK();
                    break;
                # endregion

                # region Dismal Backwater
                case "Dismal Backwater":
                    mcn = new DismalBackwaterKTK();
                    break;
                # endregion

                # region Disowned Ancestor
                case "Disowned Ancestor":
                    mcn = new DisownedAncestorKTK();
                    break;
                # endregion

                # region Dragon Grip
                case "Dragon Grip":
                    mcn = new DragonGripKTK();
                    break;
                # endregion

                # region Dragon Throne of Tarkir
                case "Dragon Throne of Tarkir":
                    mcn = new DragonThroneofTarkirKTK();
                    break;
                # endregion

                # region Dragon's Eye Savants
                case "Dragon's Eye Savants":
                    mcn = new DragonsEyeSavantsKTK();
                    break;
                # endregion

                # region Dragonscale Boon
                case "Dragonscale Boon":
                    mcn = new DragonscaleBoonKTK();
                    break;
                # endregion

                # region Dragon-Style Twins
                case "Dragon-Style Twins":
                    mcn = new DragonStyleTwinsKTK();
                    break;
                # endregion

                # region Duneblast
                case "Duneblast":
                    mcn = new DuneblastKTK();
                    break;
                # endregion

                # region Dutiful Return
                case "Dutiful Return":
                    mcn = new DutifulReturnKTK();
                    break;
                # endregion

                # region Efreet Weaponmaster
                case "Efreet Weaponmaster":
                    mcn = new EfreetWeaponmasterKTK();
                    break;
                # endregion

                # region Embodiment of Spring
                case "Embodiment of Spring":
                    mcn = new EmbodimentofSpringKTK();
                    break;
                # endregion

                # region Empty the Pits
                case "Empty the Pits":
                    mcn = new EmptythePitsKTK();
                    break;
                # endregion

                # region End Hostilities
                case "End Hostilities":
                    mcn = new EndHostilitiesKTK();
                    break;
                # endregion

                # region Erase
                case "Erase":
                    mcn = new EraseKTK();
                    break;
                # endregion

                # region Feat of Resistance
                case "Feat of Resistance":
                    mcn = new FeatofResistanceKTK();
                    break;
                # endregion

                # region Feed the Clan
                case "Feed the Clan":
                    mcn = new FeedtheClanKTK();
                    break;
                # endregion

                # region Firehoof Cavalry
                case "Firehoof Cavalry":
                    mcn = new FirehoofCavalryKTK();
                    break;
                # endregion

                # region Flooded Strand
                case "Flooded Strand":
                    mcn = new FloodedStrandKTK();
                    break;
                # endregion

                # region Flying Crane Technique
                case "Flying Crane Technique":
                    mcn = new FlyingCraneTechniqueKTK();
                    break;
                # endregion

                # region Force Away
                case "Force Away":
                    mcn = new ForceAwayKTK();
                    break;
                # endregion

                //# region Forest
                //case "Forest":
                //    mcn = new ForestKTK();
                //    break;
                //# endregion

                # region Frontier Bivouac
                case "Frontier Bivouac":
                    mcn = new FrontierBivouacKTK();
                    break;
                # endregion

                # region Ghostfire Blade
                case "Ghostfire Blade":
                    mcn = new GhostfireBladeKTK();
                    break;
                # endregion

                # region Glacial Stalker
                case "Glacial Stalker":
                    mcn = new GlacialStalkerKTK();
                    break;
                # endregion

                # region Goblinslide
                case "Goblinslide":
                    mcn = new GoblinslideKTK();
                    break;
                # endregion

                # region Grim Haruspex
                case "Grim Haruspex":
                    mcn = new GrimHaruspexKTK();
                    break;
                # endregion

                # region Gurmag Swiftwing
                case "Gurmag Swiftwing":
                    mcn = new GurmagSwiftwingKTK();
                    break;
                # endregion

                # region Hardened Scales
                case "Hardened Scales":
                    mcn = new HardenedScalesKTK();
                    break;
                # endregion

                # region Heart-Piercer Bow
                case "Heart-Piercer Bow":
                    mcn = new HeartPiercerBowKTK();
                    break;
                # endregion

                # region Heir of the Wilds
                case "Heir of the Wilds":
                    mcn = new HeiroftheWildsKTK();
                    break;
                # endregion

                # region Herald of Anafenza
                case "Herald of Anafenza":
                    mcn = new HeraldofAnafenzaKTK();
                    break;
                # endregion

                # region High Sentinels of Arashin
                case "High Sentinels of Arashin":
                    mcn = new HighSentinelsofArashinKTK();
                    break;
                # endregion

                # region Highland Game
                case "Highland Game":
                    mcn = new HighlandGameKTK();
                    break;
                # endregion

                # region Highspire Mantis
                case "Highspire Mantis":
                    mcn = new HighspireMantisKTK();
                    break;
                # endregion

                # region Hooded Hydra
                case "Hooded Hydra":
                    mcn = new HoodedHydraKTK();
                    break;
                # endregion

                # region Hooting Mandrills
                case "Hooting Mandrills":
                    mcn = new HootingMandrillsKTK();
                    break;
                # endregion

                # region Horde Ambusher
                case "Horde Ambusher":
                    mcn = new HordeAmbusherKTK();
                    break;
                # endregion

                # region Hordeling Outburst
                case "Hordeling Outburst":
                    mcn = new HordelingOutburstKTK();
                    break;
                # endregion

                # region Howl of the Horde
                case "Howl of the Horde":
                    mcn = new HowloftheHordeKTK();
                    break;
                # endregion

                # region Icefeather Aven
                case "Icefeather Aven":
                    mcn = new IcefeatherAvenKTK();
                    break;
                # endregion

                # region Icy Blast
                case "Icy Blast":
                    mcn = new IcyBlastKTK();
                    break;
                # endregion

                //# region Incremental Growth
                //case "Incremental Growth":
                //    mcn = new IncrementalGrowthKTK();
                //    break;
                //# endregion

                //# region Island
                //case "Island":
                //    mcn = new IslandKTK();
                //    break;
                //# endregion

                # region Ivorytusk Fortress
                case "Ivorytusk Fortress":
                    mcn = new IvorytuskFortressKTK();
                    break;
                # endregion

                # region Jeering Instigator
                case "Jeering Instigator":
                    mcn = new JeeringInstigatorKTK();
                    break;
                # endregion

                # region Jeskai Ascendancy
                case "Jeskai Ascendancy":
                    mcn = new JeskaiAscendancyKTK();
                    break;
                # endregion

                # region Jeskai Banner
                case "Jeskai Banner":
                    mcn = new JeskaiBannerKTK();
                    break;
                # endregion

                # region Jeskai Charm
                case "Jeskai Charm":
                    mcn = new JeskaiCharmKTK();
                    break;
                # endregion

                # region Jeskai Elder
                case "Jeskai Elder":
                    mcn = new JeskaiElderKTK();
                    break;
                # endregion

                # region Jeskai Student
                case "Jeskai Student":
                    mcn = new JeskaiStudentKTK();
                    break;
                # endregion

                # region Jeskai Windscout
                case "Jeskai Windscout":
                    mcn = new JeskaiWindscoutKTK();
                    break;
                # endregion

                # region Jungle Hollow
                case "Jungle Hollow":
                    mcn = new JungleHollowKTK();
                    break;
                # endregion

                # region Kheru Bloodsucker
                case "Kheru Bloodsucker":
                    mcn = new KheruBloodsuckerKTK();
                    break;
                # endregion

                # region Kheru Dreadmaw
                case "Kheru Dreadmaw":
                    mcn = new KheruDreadmawKTK();
                    break;
                # endregion

                # region Kheru Lich Lord
                case "Kheru Lich Lord":
                    mcn = new KheruLichLordKTK();
                    break;
                # endregion

                # region Kheru Spellsnatcher
                case "Kheru Spellsnatcher":
                    mcn = new KheruSpellsnatcherKTK();
                    break;
                # endregion

                # region Kill Shot
                case "Kill Shot":
                    mcn = new KillShotKTK();
                    break;
                # endregion

                # region Kin-Tree Invocation
                case "Kin-Tree Invocation":
                    mcn = new KinTreeInvocationKTK();
                    break;
                # endregion

                # region Kin-Tree Warden
                case "Kin-Tree Warden":
                    mcn = new KinTreeWardenKTK();
                    break;
                # endregion

                # region Krumar Bond-Kin
                case "Krumar Bond-Kin":
                    mcn = new KrumarBondKinKTK();
                    break;
                # endregion

                # region Leaping Master
                case "Leaping Master":
                    mcn = new LeapingMasterKTK();
                    break;
                # endregion

                # region Lens of Clarity
                case "Lens of Clarity":
                    mcn = new LensofClarityKTK();
                    break;
                # endregion

                # region Longshot Squad
                case "Longshot Squad":
                    mcn = new LongshotSquadKTK();
                    break;
                # endregion

                # region Mantis Rider
                case "Mantis Rider":
                    mcn = new MantisRiderKTK();
                    break;
                # endregion

                # region Mardu Ascendancy
                case "Mardu Ascendancy":
                    mcn = new MarduAscendancyKTK();
                    break;
                # endregion

                # region Mardu Banner
                case "Mardu Banner":
                    mcn = new MarduBannerKTK();
                    break;
                # endregion

                # region Mardu Blazebringer
                case "Mardu Blazebringer":
                    mcn = new MarduBlazebringerKTK();
                    break;
                # endregion

                # region Mardu Charm
                case "Mardu Charm":
                    mcn = new MarduCharmKTK();
                    break;
                # endregion

                # region Mardu Hateblade
                case "Mardu Hateblade":
                    mcn = new MarduHatebladeKTK();
                    break;
                # endregion

                # region Mardu Heart-Piercer
                case "Mardu Heart-Piercer":
                    mcn = new MarduHeartPiercerKTK();
                    break;
                # endregion

                # region Mardu Hordechief
                case "Mardu Hordechief":
                    mcn = new MarduHordechiefKTK();
                    break;
                # endregion

                # region Mardu Roughrider
                case "Mardu Roughrider":
                    mcn = new MarduRoughriderKTK();
                    break;
                # endregion

                # region Mardu Skullhunter
                case "Mardu Skullhunter":
                    mcn = new MarduSkullhunterKTK();
                    break;
                # endregion

                # region Mardu Warshrieker
                case "Mardu Warshrieker":
                    mcn = new MarduWarshriekerKTK();
                    break;
                # endregion

                # region Master of Pearls
                case "Master of Pearls":
                    mcn = new MasterofPearlsKTK();
                    break;
                # endregion

                # region Master the Way
                case "Master the Way":
                    mcn = new MastertheWayKTK();
                    break;
                # endregion

                # region Meandering Towershell
                case "Meandering Towershell":
                    mcn = new MeanderingTowershellKTK();
                    break;
                # endregion

                # region Mer-Ek Nightblade
                case "Mer-Ek Nightblade":
                    mcn = new MerEkNightbladeKTK();
                    break;
                # endregion

                # region Mindswipe
                case "Mindswipe":
                    mcn = new MindswipeKTK();
                    break;
                # endregion

                # region Mistfire Weaver
                case "Mistfire Weaver":
                    mcn = new MistfireWeaverKTK();
                    break;
                # endregion

                # region Molting Snakeskin
                case "Molting Snakeskin":
                    mcn = new MoltingSnakeskinKTK();
                    break;
                # endregion

                # region Monastery Flock
                case "Monastery Flock":
                    mcn = new MonasteryFlockKTK();
                    break;
                # endregion

                # region Monastery Swiftspear
                case "Monastery Swiftspear":
                    mcn = new MonasterySwiftspearKTK();
                    break;
                # endregion

                //# region Mountain
                //case "Mountain":
                //    mcn = new MountainKTK();
                //    break;
                //# endregion

                # region Murderous Cut
                case "Murderous Cut":
                    mcn = new MurderousCutKTK();
                    break;
                # endregion

                # region Mystic Monastery
                case "Mystic Monastery":
                    mcn = new MysticMonasteryKTK();
                    break;
                # endregion

                # region Mystic of the Hidden Way
                case "Mystic of the Hidden Way":
                    mcn = new MysticoftheHiddenWayKTK();
                    break;
                # endregion

                # region Narset, Enlightened Master
                case "Narset, Enlightened Master":
                    mcn = new NarsetEnlightenedMasterKTK();
                    break;
                # endregion

                //# region Naturalize
                //case "Naturalize":
                //    mcn = new NaturalizeKTK();
                //    break;
                //# endregion

                # region Necropolis Fiend
                case "Necropolis Fiend":
                    mcn = new NecropolisFiendKTK();
                    break;
                # endregion

                # region Nomad Outpost
                case "Nomad Outpost":
                    mcn = new NomadOutpostKTK();
                    break;
                # endregion

                # region Opulent Palace
                case "Opulent Palace":
                    mcn = new OpulentPalaceKTK();
                    break;
                # endregion

                # region Pearl Lake Ancient
                case "Pearl Lake Ancient":
                    mcn = new PearlLakeAncientKTK();
                    break;
                # endregion

                # region Pine Walker
                case "Pine Walker":
                    mcn = new PineWalkerKTK();
                    break;
                # endregion

                //# region Plains
                //case "Plains":
                //    mcn = new PlainsKTK();
                //    break;
                //# endregion

                # region Polluted Delta
                case "Polluted Delta":
                    mcn = new PollutedDeltaKTK();
                    break;
                # endregion

                # region Ponyback Brigade
                case "Ponyback Brigade":
                    mcn = new PonybackBrigadeKTK();
                    break;
                # endregion
                # endregion

                # region Modern Masters
                # region Absorb Vis
                case "Absorb Vis":
                    mcn = new AbsorbVisMMA();
                    break;
                # endregion

                # region Academy Ruins
                case "Academy Ruins":
                    mcn = new AcademyRuinsMMA();
                    break;
                # endregion

                # region Adarkar Valkyrie
                case "Adarkar Valkyrie":
                    mcn = new AdarkarValkyrieMMA();
                    break;
                # endregion

                //# region AEther Spellbomb
                //case "AEther Spellbomb":
                //    mcn = new AEtherSpellbombMMA();
                //    break;
                //# endregion

                # region AEther Vial
                case "AEther Vial":
                    mcn = new AEtherVialMMA();
                    break;
                # endregion

                //# region AEthersnipe
                //case "AEthersnipe":
                //    mcn = new AEthersnipeMMA();
                //    break;
                //# endregion

                # region Amrou Scout
                case "Amrou Scout":
                    mcn = new AmrouScoutMMA();
                    break;
                # endregion

                # region Amrou Seekers
                case "Amrou Seekers":
                    mcn = new AmrouSeekersMMA();
                    break;
                # endregion

                # region Angel's Grace
                case "Angel's Grace":
                    mcn = new AngelsGraceMMA();
                    break;
                # endregion

                # region Arcbound Ravager
                case "Arcbound Ravager":
                    mcn = new ArcboundRavagerMMA();
                    break;
                # endregion

                # region Arcbound Stinger
                case "Arcbound Stinger":
                    mcn = new ArcboundStingerMMA();
                    break;
                # endregion

                # region Arcbound Wanderer
                case "Arcbound Wanderer":
                    mcn = new ArcboundWandererMMA();
                    break;
                # endregion

                # region Arcbound Worker
                case "Arcbound Worker":
                    mcn = new ArcboundWorkerMMA();
                    break;
                # endregion

                # region Auntie's Snitch
                case "Auntie's Snitch":
                    mcn = new AuntiesSnitchMMA();
                    break;
                # endregion

                # region Auriok Salvagers
                case "Auriok Salvagers":
                    mcn = new AuriokSalvagersMMA();
                    break;
                # endregion

                //# region Avian Changeling
                //case "Avian Changeling":
                //    mcn = new AvianChangelingMMA();
                //    break;
                //# endregion

                # region Blightspeaker
                case "Blightspeaker":
                    mcn = new BlightspeakerMMA();
                    break;
                # endregion

                //# region Blinding Beam
                //case "Blinding Beam":
                //    mcn = new BlindingBeamMMA();
                //    break;
                //# endregion

                //# region Blind-Spot Giant
                //case "Blind-Spot Giant":
                //    mcn = new BlindSpotGiantMMA();
                //    break;
                //# endregion

                # region Blinkmoth Nexus
                case "Blinkmoth Nexus":
                    mcn = new BlinkmothNexusMMA();
                    break;
                # endregion

                # region Blood Moon
                case "Blood Moon":
                    mcn = new BloodMoonMMA();
                    break;
                # endregion

                //# region Bonesplitter
                //case "Bonesplitter":
                //    mcn = new BonesplitterMMA();
                //    break;
                //# endregion

                # region Bound in Silence
                case "Bound in Silence":
                    mcn = new BoundinSilenceMMA();
                    break;
                # endregion

                # region Bridge from Below
                case "Bridge from Below":
                    mcn = new BridgefromBelowMMA();
                    break;
                # endregion

                # region Brute Force
                case "Brute Force":
                    mcn = new BruteForceMMA();
                    break;
                # endregion

                # region Careful Consideration
                case "Careful Consideration":
                    mcn = new CarefulConsiderationMMA();
                    break;
                # endregion

                # region Cenn's Enlistment
                case "Cenn's Enlistment":
                    mcn = new CennsEnlistmentMMA();
                    break;
                # endregion

                //# region Chalice of the Void
                //case "Chalice of the Void":
                //    mcn = new ChaliceoftheVoidMMA();
                //    break;
                //# endregion

                # region Citanul Woodreaders
                case "Citanul Woodreaders":
                    mcn = new CitanulWoodreadersMMA();
                    break;
                # endregion

                # region City of Brass
                case "City of Brass":
                    mcn = new CityofBrassMMA();
                    break;
                # endregion

                //# region Cloudgoat Ranger
                //case "Cloudgoat Ranger":
                //    mcn = new CloudgoatRangerMMA();
                //    break;
                //# endregion

                # region Cold-Eyed Selkie
                case "Cold-Eyed Selkie":
                    mcn = new ColdEyedSelkieMMA();
                    break;
                # endregion

                # region Countryside Crusher
                case "Countryside Crusher":
                    mcn = new CountrysideCrusherMMA();
                    break;
                # endregion

                # region Court Homunculus
                case "Court Homunculus":
                    mcn = new CourtHomunculusMMA();
                    break;
                # endregion

                //# region Crush Underfoot
                //case "Crush Underfoot":
                //    mcn = new CrushUnderfootMMA();
                //    break;
                //# endregion

                //# region Cryptic Command
                //case "Cryptic Command":
                //    mcn = new CrypticCommandMMA();
                //    break;
                //# endregion

                # region Dakmor Salvage
                case "Dakmor Salvage":
                    mcn = new DakmorSalvageMMA();
                    break;
                # endregion

                # region Dampen Thought
                case "Dampen Thought":
                    mcn = new DampenThoughtMMA();
                    break;
                # endregion

                # region Dark Confidant
                case "Dark Confidant":
                    mcn = new DarkConfidantMMA();
                    break;
                # endregion

                # region Death Cloud
                case "Death Cloud":
                    mcn = new DeathCloudMMA();
                    break;
                # endregion

                # region Death Denied
                case "Death Denied":
                    mcn = new DeathDeniedMMA();
                    break;
                # endregion

                # region Death Rattle
                case "Death Rattle":
                    mcn = new DeathRattleMMA();
                    break;
                # endregion

                # region Deepcavern Imp
                case "Deepcavern Imp":
                    mcn = new DeepcavernImpMMA();
                    break;
                # endregion

                //# region Demigod of Revenge
                //case "Demigod of Revenge":
                //    mcn = new DemigodofRevengeMMA();
                //    break;
                //# endregion

                # region Desperate Ritual
                case "Desperate Ritual":
                    mcn = new DesperateRitualMMA();
                    break;
                # endregion

                //# region Dispeller's Capsule
                //case "Dispeller's Capsule":
                //    mcn = new DispellersCapsuleMMA();
                //    break;
                //# endregion

                # region Divinity of Pride
                case "Divinity of Pride":
                    mcn = new DivinityofPrideMMA();
                    break;
                # endregion

                # region Doubling Season
                case "Doubling Season":
                    mcn = new DoublingSeasonMMA();
                    break;
                # endregion

                # region Drag Down
                case "Drag Down":
                    mcn = new DragDownMMA();
                    break;
                # endregion

                # region Dragonstorm
                case "Dragonstorm":
                    mcn = new DragonstormMMA();
                    break;
                # endregion

                //# region Dreamspoiler Witches
                //case "Dreamspoiler Witches":
                //    mcn = new DreamspoilerWitchesMMA();
                //    break;
                //# endregion

                # region Durkwood Baloth
                case "Durkwood Baloth":
                    mcn = new DurkwoodBalothMMA();
                    break;
                # endregion

                # region Earwig Squad
                case "Earwig Squad":
                    mcn = new EarwigSquadMMA();
                    break;
                # endregion

                # region Echoing Courage
                case "Echoing Courage":
                    mcn = new EchoingCourageMMA();
                    break;
                # endregion

                # region Echoing Truth
                case "Echoing Truth":
                    mcn = new EchoingTruthMMA();
                    break;
                # endregion

                # region Electrolyze
                case "Electrolyze":
                    mcn = new ElectrolyzeMMA();
                    break;
                # endregion

                //# region Elspeth, Knight-Errant
                //case "Elspeth, Knight-Errant":
                //    mcn = new ElspethKnightErrantMMA();
                //    break;
                //# endregion

                # region Empty the Warrens
                case "Empty the Warrens":
                    mcn = new EmptytheWarrensMMA();
                    break;
                # endregion

                # region Engineered Explosives
                case "Engineered Explosives":
                    mcn = new EngineeredExplosivesMMA();
                    break;
                # endregion

                # region Epochrasite
                case "Epochrasite":
                    mcn = new EpochrasiteMMA();
                    break;
                # endregion

                # region Errant Ephemeron
                case "Errant Ephemeron":
                    mcn = new ErrantEphemeronMMA();
                    break;
                # endregion

                # region Erratic Mutation
                case "Erratic Mutation":
                    mcn = new ErraticMutationMMA();
                    break;
                # endregion

                # region Esperzoa
                case "Esperzoa":
                    mcn = new EsperzoaMMA();
                    break;
                # endregion

                # region Etched Oracle
                case "Etched Oracle":
                    mcn = new EtchedOracleMMA();
                    break;
                # endregion

                # region Eternal Witness
                case "Eternal Witness":
                    mcn = new EternalWitnessMMA();
                    break;
                # endregion

                //# region Etherium Sculptor
                //case "Etherium Sculptor":
                //    mcn = new EtheriumSculptorMMA();
                //    break;
                //# endregion

                //# region Ethersworn Canonist
                //case "Ethersworn Canonist":
                //    mcn = new EtherswornCanonistMMA();
                //    break;
                //# endregion

                //# region Executioner's Capsule
                //case "Executioner's Capsule":
                //    mcn = new ExecutionersCapsuleMMA();
                //    break;
                //# endregion

                # region Extirpate
                case "Extirpate":
                    mcn = new ExtirpateMMA();
                    break;
                # endregion

                //# region Facevaulter
                //case "Facevaulter":
                //    mcn = new FacevaulterMMA();
                //    break;
                //# endregion

                //# region Faerie Macabre
                //case "Faerie Macabre":
                //    mcn = new FaerieMacabreMMA();
                //    break;
                //# endregion

                # region Faerie Mechanist
                case "Faerie Mechanist":
                    mcn = new FaerieMechanistMMA();
                    break;
                # endregion

                # region Festering Goblin
                case "Festering Goblin":
                    mcn = new FesteringGoblinMMA();
                    break;
                # endregion

                # region Feudkiller's Verdict
                case "Feudkiller's Verdict":
                    mcn = new FeudkillersVerdictMMA();
                    break;
                # endregion

                # region Fiery Fall
                case "Fiery Fall":
                    mcn = new FieryFallMMA();
                    break;
                # endregion

                # region Figure of Destiny
                case "Figure of Destiny":
                    mcn = new FigureofDestinyMMA();
                    break;
                # endregion

                # region Flickerwisp
                case "Flickerwisp":
                    mcn = new FlickerwispMMA();
                    break;
                # endregion

                //# region Frogmite
                //case "Frogmite":
                //    mcn = new FrogmiteMMA();
                //    break;
                //# endregion

                # region Fury Charm
                case "Fury Charm":
                    mcn = new FuryCharmMMA();
                    break;
                # endregion

                # region Giant Dustwasp
                case "Giant Dustwasp":
                    mcn = new GiantDustwaspMMA();
                    break;
                # endregion

                # region Gifts Ungiven
                case "Gifts Ungiven":
                    mcn = new GiftsUngivenMMA();
                    break;
                # endregion

                # region Glacial Ray
                case "Glacial Ray":
                    mcn = new GlacialRayMMA();
                    break;
                # endregion

                # region Gleam of Resistance
                case "Gleam of Resistance":
                    mcn = new GleamofResistanceMMA();
                    break;
                # endregion

                # region Glen Elendra Archmage
                case "Glen Elendra Archmage":
                    mcn = new GlenElendraArchmageMMA();
                    break;
                # endregion

                //# region Glimmervoid
                //case "Glimmervoid":
                //    mcn = new GlimmervoidMMA();
                //    break;
                //# endregion

                # region Grand Arbiter Augustin IV
                case "Grand Arbiter Augustin IV":
                    mcn = new GrandArbiterAugustinIVMMA();
                    break;
                # endregion

                # region Grapeshot
                case "Grapeshot":
                    mcn = new GrapeshotMMA();
                    break;
                # endregion

                # region Greater Gargadon
                case "Greater Gargadon":
                    mcn = new GreaterGargadonMMA();
                    break;
                # endregion

                # region Greater Mossdog
                case "Greater Mossdog":
                    mcn = new GreaterMossdogMMA();
                    break;
                # endregion

                # region Grinning Ignus
                case "Grinning Ignus":
                    mcn = new GrinningIgnusMMA();
                    break;
                # endregion

                # region Hammerheim Deadeye
                case "Hammerheim Deadeye":
                    mcn = new HammerheimDeadeyeMMA();
                    break;
                # endregion

                # region Hana Kami
                case "Hana Kami":
                    mcn = new HanaKamiMMA();
                    break;
                # endregion

                //# region Hillcomber Giant
                //case "Hillcomber Giant":
                //    mcn = new HillcomberGiantMMA();
                //    break;
                //# endregion

                # region Horobi's Whisper
                case "Horobi's Whisper":
                    mcn = new HorobisWhisperMMA();
                    break;
                # endregion

                # region Imperiosaur
                case "Imperiosaur":
                    mcn = new ImperiosaurMMA();
                    break;
                # endregion

                //# region Incremental Growth
                //case "Incremental Growth":
                //    mcn = new IncrementalGrowthMMA();
                //    break;
                //# endregion

                # region Ivory Giant
                case "Ivory Giant":
                    mcn = new IvoryGiantMMA();
                    break;
                # endregion

                # region Jhoira of the Ghitu
                case "Jhoira of the Ghitu":
                    mcn = new JhoiraoftheGhituMMA();
                    break;
                # endregion

                # region Jugan, the Rising Star
                case "Jugan, the Rising Star":
                    mcn = new JugantheRisingStarMMA();
                    break;
                # endregion

                # region Kataki, War's Wage
                case "Kataki, War's Wage":
                    mcn = new KatakiWarsWageMMA();
                    break;
                # endregion

                # region Keiga, the Tide Star
                case "Keiga, the Tide Star":
                    mcn = new KeigatheTideStarMMA();
                    break;
                # endregion

                # region Kiki-Jiki, Mirror Breaker
                case "Kiki-Jiki, Mirror Breaker":
                    mcn = new KikiJikiMirrorBreakerMMA();
                    break;
                # endregion

                # region Kira, Great Glass-Spinner
                case "Kira, Great Glass-Spinner":
                    mcn = new KiraGreatGlassSpinnerMMA();
                    break;
                # endregion

                //# region Kitchen Finks
                //case "Kitchen Finks":
                //    mcn = new KitchenFinksMMA();
                //    break;
                //# endregion

                //# region Kithkin Greatheart
                //case "Kithkin Greatheart":
                //    mcn = new KithkinGreatheartMMA();
                //    break;
                //# endregion

                # region Knight of the Reliquary
                case "Knight of the Reliquary":
                    mcn = new KnightoftheReliquaryMMA();
                    break;
                # endregion

                # region Kodama's Reach
                case "Kodama's Reach":
                    mcn = new KodamasReachMMA();
                    break;
                # endregion

                # region Kokusho, the Evening Star
                case "Kokusho, the Evening Star":
                    mcn = new KokushotheEveningStarMMA();
                    break;
                # endregion

                # region Krosan Grip
                case "Krosan Grip":
                    mcn = new KrosanGripMMA();
                    break;
                # endregion

                # region Latchkey Faerie
                case "Latchkey Faerie":
                    mcn = new LatchkeyFaerieMMA();
                    break;
                # endregion

                # region Lava Spike
                case "Lava Spike":
                    mcn = new LavaSpikeMMA();
                    break;
                # endregion

                # region Life from the Loam
                case "Life from the Loam":
                    mcn = new LifefromtheLoamMMA();
                    break;
                # endregion

                //# region Lightning Helix
                //case "Lightning Helix":
                //    mcn = new LightningHelixMMA();
                //    break;
                //# endregion

                # region Logic Knot
                case "Logic Knot":
                    mcn = new LogicKnotMMA();
                    break;
                # endregion

                # region Lotus Bloom
                case "Lotus Bloom":
                    mcn = new LotusBloomMMA();
                    break;
                # endregion

                //# region Mad Auntie
                //case "Mad Auntie":
                //    mcn = new MadAuntieMMA();
                //    break;
                //# endregion

                # region Maelstrom Pulse
                case "Maelstrom Pulse":
                    mcn = new MaelstromPulseMMA();
                    break;
                # endregion

                //# region Manamorphose
                //case "Manamorphose":
                //    mcn = new ManamorphoseMMA();
                //    break;
                //# endregion

                //# region Marsh Flitter
                //case "Marsh Flitter":
                //    mcn = new MarshFlitterMMA();
                //    break;
                //# endregion

                //# region Masked Admirers
                //case "Masked Admirers":
                //    mcn = new MaskedAdmirersMMA();
                //    break;
                //# endregion

                # region Meadowboon
                case "Meadowboon":
                    mcn = new MeadowboonMMA();
                    break;
                # endregion

                # region Meloku the Clouded Mirror
                case "Meloku the Clouded Mirror":
                    mcn = new MelokutheCloudedMirrorMMA();
                    break;
                # endregion

                # region Mind Funeral
                case "Mind Funeral":
                    mcn = new MindFuneralMMA();
                    break;
                # endregion

                # region Mogg War Marshal
                case "Mogg War Marshal":
                    mcn = new MoggWarMarshalMMA();
                    break;
                # endregion

                # region Moldervine Cloak
                case "Moldervine Cloak":
                    mcn = new MoldervineCloakMMA();
                    break;
                # endregion

                # region Molten Disaster
                case "Molten Disaster":
                    mcn = new MoltenDisasterMMA();
                    break;
                # endregion

                # region Mothdust Changeling
                case "Mothdust Changeling":
                    mcn = new MothdustChangelingMMA();
                    break;
                # endregion

                //# region Mulldrifter
                //case "Mulldrifter":
                //    mcn = new MulldrifterMMA();
                //    break;
                //# endregion

                //# region Murderous Redcap
                //case "Murderous Redcap":
                //    mcn = new MurderousRedcapMMA();
                //    break;
                //# endregion

                //# region Myr Enforcer
                //case "Myr Enforcer":
                //    mcn = new MyrEnforcerMMA();
                //    break;
                //# endregion

                //# region Myr Retriever
                //case "Myr Retriever":
                //    mcn = new MyrRetrieverMMA();
                //    break;
                //# endregion

                # region Nantuko Shaman
                case "Nantuko Shaman":
                    mcn = new NantukoShamanMMA();
                    break;
                # endregion

                # region Narcomoeba
                case "Narcomoeba":
                    mcn = new NarcomoebaMMA();
                    break;
                # endregion

                //# region Oona, Queen of the Fae
                //case "Oona, Queen of the Fae":
                //    mcn = new OonaQueenoftheFaeMMA();
                //    break;
                //# endregion

                # region Otherworldly Journey
                case "Otherworldly Journey":
                    mcn = new OtherworldlyJourneyMMA();
                    break;
                # endregion

                # region Pact of Negation
                case "Pact of Negation":
                    mcn = new PactofNegationMMA();
                    break;
                # endregion

                # region Pallid Mycoderm
                case "Pallid Mycoderm":
                    mcn = new PallidMycodermMMA();
                    break;
                # endregion

                # region Paradise Mantle
                case "Paradise Mantle":
                    mcn = new ParadiseMantleMMA();
                    break;
                # endregion

                # region Pardic Dragon
                case "Pardic Dragon":
                    mcn = new PardicDragonMMA();
                    break;
                # endregion

                # region Path to Exile
                case "Path to Exile":
                    mcn = new PathtoExileMMA();
                    break;
                # endregion

                # region Peer Through Depths
                case "Peer Through Depths":
                    mcn = new PeerThroughDepthsMMA();
                    break;
                # endregion

                # region Penumbra Spider
                case "Penumbra Spider":
                    mcn = new PenumbraSpiderMMA();
                    break;
                # endregion

                //# region Peppersmoke
                //case "Peppersmoke":
                //    mcn = new PeppersmokeMMA();
                //    break;
                //# endregion

                # region Perilous Research
                case "Perilous Research":
                    mcn = new PerilousResearchMMA();
                    break;
                # endregion

                //# region Pestermite
                //case "Pestermite":
                //    mcn = new PestermiteMMA();
                //    break;
                //# endregion

                # region Petals of Insight
                case "Petals of Insight":
                    mcn = new PetalsofInsightMMA();
                    break;
                # endregion

                # region Phthisis
                case "Phthisis":
                    mcn = new PhthisisMMA();
                    break;
                # endregion

                //# region Plumeveil
                //case "Plumeveil":
                //    mcn = new PlumeveilMMA();
                //    break;
                //# endregion

                # region Progenitus
                case "Progenitus":
                    mcn = new ProgenitusMMA();
                    break;
                # endregion

                //# region Pyrite Spellbomb
                //case "Pyrite Spellbomb":
                //    mcn = new PyriteSpellbombMMA();
                //    break;
                //# endregion

                # region Pyromancer's Swath
                case "Pyromancer's Swath":
                    mcn = new PyromancersSwathMMA();
                    break;
                # endregion

                # region Rathi Trapper
                case "Rathi Trapper":
                    mcn = new RathiTrapperMMA();
                    break;
                # endregion

                # region Raven's Crime
                case "Raven's Crime":
                    mcn = new RavensCrimeMMA();
                    break;
                # endregion

                # region Reach of Branches
                case "Reach of Branches":
                    mcn = new ReachofBranchesMMA();
                    break;
                # endregion

                # region Reach Through Mists
                case "Reach Through Mists":
                    mcn = new ReachThroughMistsMMA();
                    break;
                # endregion

                //# region Relic of Progenitus
                //case "Relic of Progenitus":
                //    mcn = new RelicofProgenitusMMA();
                //    break;
                //# endregion

                # region Reveillark
                case "Reveillark":
                    mcn = new ReveillarkMMA();
                    break;
                # endregion

                # region Rift Bolt
                case "Rift Bolt":
                    mcn = new RiftBoltMMA();
                    break;
                # endregion

                # region Rift Elemental
                case "Rift Elemental":
                    mcn = new RiftElementalMMA();
                    break;
                # endregion

                # region Riftsweeper
                case "Riftsweeper":
                    mcn = new RiftsweeperMMA();
                    break;
                # endregion

                # region Riftwing Cloudskate
                case "Riftwing Cloudskate":
                    mcn = new RiftwingCloudskateMMA();
                    break;
                # endregion

                # region Rude Awakening
                case "Rude Awakening":
                    mcn = new RudeAwakeningMMA();
                    break;
                # endregion

                //# region Runed Stalactite
                //case "Runed Stalactite":
                //    mcn = new RunedStalactiteMMA();
                //    break;
                //# endregion

                # region Ryusei, the Falling Star
                case "Ryusei, the Falling Star":
                    mcn = new RyuseitheFallingStarMMA();
                    break;
                # endregion

                # region Saltfield Recluse
                case "Saltfield Recluse":
                    mcn = new SaltfieldRecluseMMA();
                    break;
                # endregion

                //# region Sanctum Gargoyle
                //case "Sanctum Gargoyle":
                //    mcn = new SanctumGargoyleMMA();
                //    break;
                //# endregion

                # region Sandsower
                case "Sandsower":
                    mcn = new SandsowerMMA();
                    break;
                # endregion

                //# region Sarkhan Vol
                //case "Sarkhan Vol":
                //    mcn = new SarkhanVolMMA();
                //    break;
                //# endregion

                //# region Scion of Oona
                //case "Scion of Oona":
                //    mcn = new ScionofOonaMMA();
                //    break;
                //# endregion

                # region Search for Tomorrow
                case "Search for Tomorrow":
                    mcn = new SearchforTomorrowMMA();
                    break;
                # endregion

                //# region Shrapnel Blast
                //case "Shrapnel Blast":
                //    mcn = new ShrapnelBlastMMA();
                //    break;
                //# endregion

                # region Skeletal Vampire
                case "Skeletal Vampire":
                    mcn = new SkeletalVampireMMA();
                    break;
                # endregion

                # region Skyreach Manta
                case "Skyreach Manta":
                    mcn = new SkyreachMantaMMA();
                    break;
                # endregion

                # region Slaughter Pact
                case "Slaughter Pact":
                    mcn = new SlaughterPactMMA();
                    break;
                # endregion

                # region Spell Snare
                case "Spell Snare":
                    mcn = new SpellSnareMMA();
                    break;
                # endregion

                //# region Spellstutter Sprite
                //case "Spellstutter Sprite":
                //    mcn = new SpellstutterSpriteMMA();
                //    break;
                //# endregion

                # region Sporesower Thallid
                case "Sporesower Thallid":
                    mcn = new SporesowerThallidMMA();
                    break;
                # endregion

                # region Sporoloth Ancient
                case "Sporoloth Ancient":
                    mcn = new SporolothAncientMMA();
                    break;
                # endregion

                # region Squee, Goblin Nabob
                case "Squee, Goblin Nabob":
                    mcn = new SqueeGoblinNabobMMA();
                    break;
                # endregion

                # region Stingscourger
                case "Stingscourger":
                    mcn = new StingscourgerMMA();
                    break;
                # endregion

                //# region Stinkdrinker Daredevil
                //case "Stinkdrinker Daredevil":
                //    mcn = new StinkdrinkerDaredevilMMA();
                //    break;
                //# endregion

                # region Stinkweed Imp
                case "Stinkweed Imp":
                    mcn = new StinkweedImpMMA();
                    break;
                # endregion

                # region Stir the Pride
                case "Stir the Pride":
                    mcn = new StirthePrideMMA();
                    break;
                # endregion

                # region Stonehewer Giant
                case "Stonehewer Giant":
                    mcn = new StonehewerGiantMMA();
                    break;
                # endregion

                # region Street Wraith
                case "Street Wraith":
                    mcn = new StreetWraithMMA();
                    break;
                # endregion

                # region Sudden Shock
                case "Sudden Shock":
                    mcn = new SuddenShockMMA();
                    break;
                # endregion

                # region Summoner's Pact
                case "Summoner's Pact":
                    mcn = new SummonersPactMMA();
                    break;
                # endregion

                # region Sword of Fire and Ice
                case "Sword of Fire and Ice":
                    mcn = new SwordofFireandIceMMA();
                    break;
                # endregion

                # region Sword of Light and Shadow
                case "Sword of Light and Shadow":
                    mcn = new SwordofLightandShadowMMA();
                    break;
                # endregion

                //# region Sylvan Bounty
                //case "Sylvan Bounty":
                //    mcn = new SylvanBountyMMA();
                //    break;
                //# endregion

                # region Syphon Life
                case "Syphon Life":
                    mcn = new SyphonLifeMMA();
                    break;
                # endregion

                # region Take Possession
                case "Take Possession":
                    mcn = new TakePossessionMMA();
                    break;
                # endregion

                //# region Tar Pitcher
                //case "Tar Pitcher":
                //    mcn = new TarPitcherMMA();
                //    break;
                //# endregion

                # region Tarmogoyf
                case "Tarmogoyf":
                    mcn = new TarmogoyfMMA();
                    break;
                # endregion

                # region Terashi's Grasp
                case "Terashi's Grasp":
                    mcn = new TerashisGraspMMA();
                    break;
                # endregion

                //# region Terramorphic Expanse
                //case "Terramorphic Expanse":
                //    mcn = new TerramorphicExpanseMMA();
                //    break;
                //# endregion

                # region Test of Faith
                case "Test of Faith":
                    mcn = new TestofFaithMMA();
                    break;
                # endregion

                # region Thallid
                case "Thallid":
                    mcn = new ThallidMMA();
                    break;
                # endregion

                # region Thallid Germinator
                case "Thallid Germinator":
                    mcn = new ThallidGerminatorMMA();
                    break;
                # endregion

                # region Thallid Shell-Dweller
                case "Thallid Shell-Dweller":
                    mcn = new ThallidShellDwellerMMA();
                    break;
                # endregion

                //# region Thieving Sprite
                //case "Thieving Sprite":
                //    mcn = new ThievingSpriteMMA();
                //    break;
                //# endregion

                //# region Thirst for Knowledge
                //case "Thirst for Knowledge":
                //    mcn = new ThirstforKnowledgeMMA();
                //    break;
                //# endregion

                //# region Thundercloud Shaman
                //case "Thundercloud Shaman":
                //    mcn = new ThundercloudShamanMMA();
                //    break;
                //# endregion

                //# region Thundering Giant
                //case "Thundering Giant":
                //    mcn = new ThunderingGiantMMA();
                //    break;
                //# endregion

                //# region Tidehollow Sculler
                //case "Tidehollow Sculler":
                //    mcn = new TidehollowScullerMMA();
                //    break;
                //# endregion

                # region Tombstalker
                case "Tombstalker":
                    mcn = new TombstalkerMMA();
                    break;
                # endregion

                //# region Tooth and Nail
                //case "Tooth and Nail":
                //    mcn = new ToothandNailMMA();
                //    break;
                //# endregion

                # region Torrent of Stone
                case "Torrent of Stone":
                    mcn = new TorrentofStoneMMA();
                    break;
                # endregion

                # region Traumatic Visions
                case "Traumatic Visions":
                    mcn = new TraumaticVisionsMMA();
                    break;
                # endregion

                # region Tribal Flames
                case "Tribal Flames":
                    mcn = new TribalFlamesMMA();
                    break;
                # endregion

                # region Tromp the Domains
                case "Tromp the Domains":
                    mcn = new TromptheDomainsMMA();
                    break;
                # endregion

                # region Trygon Predator
                case "Trygon Predator":
                    mcn = new TrygonPredatorMMA();
                    break;
                # endregion

                # region Vedalken Dismisser
                case "Vedalken Dismisser":
                    mcn = new VedalkenDismisserMMA();
                    break;
                # endregion

                # region Vedalken Shackles
                case "Vedalken Shackles":
                    mcn = new VedalkenShacklesMMA();
                    break;
                # endregion

                # region Vendilion Clique
                case "Vendilion Clique":
                    mcn = new VendilionCliqueMMA();
                    break;
                # endregion

                # region Verdeloth the Ancient
                case "Verdeloth the Ancient":
                    mcn = new VerdeloththeAncientMMA();
                    break;
                # endregion

                # region Veteran Armorer
                case "Veteran Armorer":
                    mcn = new VeteranArmorerMMA();
                    break;
                # endregion

                //# region Vivid Crag
                //case "Vivid Crag":
                //    mcn = new VividCragMMA();
                //    break;
                //# endregion

                //# region Vivid Creek
                //case "Vivid Creek":
                //    mcn = new VividCreekMMA();
                //    break;
                //# endregion

                //# region Vivid Grove
                //case "Vivid Grove":
                //    mcn = new VividGroveMMA();
                //    break;
                //# endregion

                //# region Vivid Marsh
                //case "Vivid Marsh":
                //    mcn = new VividMarshMMA();
                //    break;
                //# endregion

                //# region Vivid Meadow
                //case "Vivid Meadow":
                //    mcn = new VividMeadowMMA();
                //    break;
                //# endregion

                # region Walker of the Grove
                case "Walker of the Grove":
                    mcn = new WalkeroftheGroveMMA();
                    break;
                # endregion

                //# region Warren Pilferers
                //case "Warren Pilferers":
                //    mcn = new WarrenPilferersMMA();
                //    break;
                //# endregion

                # region Warren Weirding
                case "Warren Weirding":
                    mcn = new WarrenWeirdingMMA();
                    break;
                # endregion

                # region War-Spike Changeling
                case "War-Spike Changeling":
                    mcn = new WarSpikeChangelingMMA();
                    break;
                # endregion

                //# region Woodfall Primus
                //case "Woodfall Primus":
                //    mcn = new WoodfallPrimusMMA();
                //    break;
                //# endregion

                # region Worm Harvest
                case "Worm Harvest":
                    mcn = new WormHarvestMMA();
                    break;
                # endregion

                # region Yosei, the Morning Star
                case "Yosei, the Morning Star":
                    mcn = new YoseitheMorningStarMMA();
                    break;
                # endregion
                # endregion

                # region Fifth Dawn
                # region Abuna's Chant
                case "Abuna's Chant":
                    mcn = new AbunasChantFD();
                    break;
                # endregion

                # region Acquire
                case "Acquire":
                    mcn = new AcquireFD();
                    break;
                # endregion

                # region Advanced Hoverguard
                case "Advanced Hoverguard":
                    mcn = new AdvancedHoverguardFD();
                    break;
                # endregion

                # region All Suns' Dawn
                case "All Suns' Dawn":
                    mcn = new AllSunsDawnFD();
                    break;
                # endregion

                # region Anodet Lurker
                case "Anodet Lurker":
                    mcn = new AnodetLurkerFD();
                    break;
                # endregion

                # region Arachnoid
                case "Arachnoid":
                    mcn = new ArachnoidFD();
                    break;
                # endregion

                //# region Arcbound Wanderer
                //case "Arcbound Wanderer":
                //    mcn = new ArcboundWandererFD();
                //    break;
                //# endregion

                # region Armed Response
                case "Armed Response":
                    mcn = new ArmedResponseFD();
                    break;
                # endregion

                # region Artificer's Intuition
                case "Artificer's Intuition":
                    mcn = new ArtificersIntuitionFD();
                    break;
                # endregion

                # region Auriok Champion
                case "Auriok Champion":
                    mcn = new AuriokChampionFD();
                    break;
                # endregion

                //# region Auriok Salvagers
                //case "Auriok Salvagers":
                //    mcn = new AuriokSalvagersFD();
                //    break;
                //# endregion

                # region Auriok Windwalker
                case "Auriok Windwalker":
                    mcn = new AuriokWindwalkerFD();
                    break;
                # endregion

                # region Avarice Totem
                case "Avarice Totem":
                    mcn = new AvariceTotemFD();
                    break;
                # endregion

                # region Baton of Courage
                case "Baton of Courage":
                    mcn = new BatonofCourageFD();
                    break;
                # endregion

                # region Battered Golem
                case "Battered Golem":
                    mcn = new BatteredGolemFD();
                    break;
                # endregion

                # region Beacon of Creation
                case "Beacon of Creation":
                    mcn = new BeaconofCreationFD();
                    break;
                # endregion

                # region Beacon of Destruction
                case "Beacon of Destruction":
                    mcn = new BeaconofDestructionFD();
                    break;
                # endregion

                # region Beacon of Immortality
                case "Beacon of Immortality":
                    mcn = new BeaconofImmortalityFD();
                    break;
                # endregion

                # region Beacon of Tomorrows
                case "Beacon of Tomorrows":
                    mcn = new BeaconofTomorrowsFD();
                    break;
                # endregion

                # region Beacon of Unrest
                case "Beacon of Unrest":
                    mcn = new BeaconofUnrestFD();
                    break;
                # endregion

                # region Blasting Station
                case "Blasting Station":
                    mcn = new BlastingStationFD();
                    break;
                # endregion

                # region Blind Creeper
                case "Blind Creeper":
                    mcn = new BlindCreeperFD();
                    break;
                # endregion

                # region Blinkmoth Infusion
                case "Blinkmoth Infusion":
                    mcn = new BlinkmothInfusionFD();
                    break;
                # endregion

                # region Bringer of the Black Dawn
                case "Bringer of the Black Dawn":
                    mcn = new BringeroftheBlackDawnFD();
                    break;
                # endregion

                # region Bringer of the Blue Dawn
                case "Bringer of the Blue Dawn":
                    mcn = new BringeroftheBlueDawnFD();
                    break;
                # endregion

                # region Bringer of the Green Dawn
                case "Bringer of the Green Dawn":
                    mcn = new BringeroftheGreenDawnFD();
                    break;
                # endregion

                # region Bringer of the Red Dawn
                case "Bringer of the Red Dawn":
                    mcn = new BringeroftheRedDawnFD();
                    break;
                # endregion

                # region Bringer of the White Dawn
                case "Bringer of the White Dawn":
                    mcn = new BringeroftheWhiteDawnFD();
                    break;
                # endregion

                # region Cackling Imp
                case "Cackling Imp":
                    mcn = new CacklingImpFD();
                    break;
                # endregion

                # region Channel the Suns
                case "Channel the Suns":
                    mcn = new ChanneltheSunsFD();
                    break;
                # endregion

                # region Chimeric Coils
                case "Chimeric Coils":
                    mcn = new ChimericCoilsFD();
                    break;
                # endregion

                # region Circle of Protection: Artifacts
                case "Circle of Protection: Artifacts":
                    mcn = new CircleofProtectionArtifactsFD();
                    break;
                # endregion

                # region Clearwater Goblet
                case "Clearwater Goblet":
                    mcn = new ClearwaterGobletFD();
                    break;
                # endregion

                # region Clock of Omens
                case "Clock of Omens":
                    mcn = new ClockofOmensFD();
                    break;
                # endregion

                # region Composite Golem
                case "Composite Golem":
                    mcn = new CompositeGolemFD();
                    break;
                # endregion

                # region Condescend
                case "Condescend":
                    mcn = new CondescendFD();
                    break;
                # endregion

                # region Conjurer's Bauble
                case "Conjurer's Bauble":
                    mcn = new ConjurersBaubleFD();
                    break;
                # endregion

                # region Cosmic Larva
                case "Cosmic Larva":
                    mcn = new CosmicLarvaFD();
                    break;
                # endregion

                # region Cranial Plating
                case "Cranial Plating":
                    mcn = new CranialPlatingFD();
                    break;
                # endregion

                # region Crucible of Worlds
                case "Crucible of Worlds":
                    mcn = new CrucibleofWorldsFD();
                    break;
                # endregion

                # region Dawn's Reflection
                case "Dawn's Reflection":
                    mcn = new DawnsReflectionFD();
                    break;
                # endregion

                # region Desecration Elemental
                case "Desecration Elemental":
                    mcn = new DesecrationElementalFD();
                    break;
                # endregion

                # region Devour in Shadow
                case "Devour in Shadow":
                    mcn = new DevourinShadowFD();
                    break;
                # endregion

                # region Disruption Aura
                case "Disruption Aura":
                    mcn = new DisruptionAuraFD();
                    break;
                # endregion

                # region Door to Nothingness
                case "Door to Nothingness":
                    mcn = new DoortoNothingnessFD();
                    break;
                # endregion

                # region Doubling Cube
                case "Doubling Cube":
                    mcn = new DoublingCubeFD();
                    break;
                # endregion

                # region Dross Crocodile
                case "Dross Crocodile":
                    mcn = new DrossCrocodileFD();
                    break;
                # endregion

                # region Early Frost
                case "Early Frost":
                    mcn = new EarlyFrostFD();
                    break;
                # endregion

                # region Ebon Drake
                case "Ebon Drake":
                    mcn = new EbonDrakeFD();
                    break;
                # endregion

                # region Endless Whispers
                case "Endless Whispers":
                    mcn = new EndlessWhispersFD();
                    break;
                # endregion

                # region Energy Chamber
                case "Energy Chamber":
                    mcn = new EnergyChamberFD();
                    break;
                # endregion

                //# region Engineered Explosives
                //case "Engineered Explosives":
                //    mcn = new EngineeredExplosivesFD();
                //    break;
                //# endregion

                # region Ensouled Scimitar
                case "Ensouled Scimitar":
                    mcn = new EnsouledScimitarFD();
                    break;
                # endregion

                # region Eon Hub
                case "Eon Hub":
                    mcn = new EonHubFD();
                    break;
                # endregion

                //# region Etched Oracle
                //case "Etched Oracle":
                //    mcn = new EtchedOracleFD();
                //    break;
                //# endregion

                //# region Eternal Witness
                //case "Eternal Witness":
                //    mcn = new EternalWitnessFD();
                //    break;
                //# endregion

                # region Eyes of the Watcher
                case "Eyes of the Watcher":
                    mcn = new EyesoftheWatcherFD();
                    break;
                # endregion

                # region Fangren Pathcutter
                case "Fangren Pathcutter":
                    mcn = new FangrenPathcutterFD();
                    break;
                # endregion

                # region Feedback Bolt
                case "Feedback Bolt":
                    mcn = new FeedbackBoltFD();
                    break;
                # endregion

                # region Ferocious Charge
                case "Ferocious Charge":
                    mcn = new FerociousChargeFD();
                    break;
                # endregion

                # region Ferropede
                case "Ferropede":
                    mcn = new FerropedeFD();
                    break;
                # endregion

                # region Fill with Fright
                case "Fill with Fright":
                    mcn = new FillwithFrightFD();
                    break;
                # endregion

                # region Fist of Suns
                case "Fist of Suns":
                    mcn = new FistofSunsFD();
                    break;
                # endregion

                # region Fleshgrafter
                case "Fleshgrafter":
                    mcn = new FleshgrafterFD();
                    break;
                # endregion

                # region Fold into AEther
                case "Fold into AEther":
                    mcn = new FoldintoAEtherFD();
                    break;
                # endregion

                //# region Furnace Whelp
                //case "Furnace Whelp":
                //    mcn = new FurnaceWhelpFD();
                //    break;
                //# endregion

                # region Gemstone Array
                case "Gemstone Array":
                    mcn = new GemstoneArrayFD();
                    break;
                # endregion

                # region Goblin Brawler
                case "Goblin Brawler":
                    mcn = new GoblinBrawlerFD();
                    break;
                # endregion

                # region Goblin Cannon
                case "Goblin Cannon":
                    mcn = new GoblinCannonFD();
                    break;
                # endregion

                # region Grafted Wargear
                case "Grafted Wargear":
                    mcn = new GraftedWargearFD();
                    break;
                # endregion

                # region Granulate
                case "Granulate":
                    mcn = new GranulateFD();
                    break;
                # endregion

                # region Grinding Station
                case "Grinding Station":
                    mcn = new GrindingStationFD();
                    break;
                # endregion

                # region Guardian Idol
                case "Guardian Idol":
                    mcn = new GuardianIdolFD();
                    break;
                # endregion

                # region Healer's Headdress
                case "Healer's Headdress":
                    mcn = new HealersHeaddressFD();
                    break;
                # endregion

                # region Heliophial
                case "Heliophial":
                    mcn = new HeliophialFD();
                    break;
                # endregion

                # region Helm of Kaldra
                case "Helm of Kaldra":
                    mcn = new HelmofKaldraFD();
                    break;
                # endregion

                # region Horned Helm
                case "Horned Helm":
                    mcn = new HornedHelmFD();
                    break;
                # endregion

                # region Hoverguard Sweepers
                case "Hoverguard Sweepers":
                    mcn = new HoverguardSweepersFD();
                    break;
                # endregion

                # region Infused Arrows
                case "Infused Arrows":
                    mcn = new InfusedArrowsFD();
                    break;
                # endregion

                # region Into Thin Air
                case "Into Thin Air":
                    mcn = new IntoThinAirFD();
                    break;
                # endregion

                # region Ion Storm
                case "Ion Storm":
                    mcn = new IonStormFD();
                    break;
                # endregion

                # region Iron-Barb Hellion
                case "Iron-Barb Hellion":
                    mcn = new IronBarbHellionFD();
                    break;
                # endregion

                # region Joiner Adept
                case "Joiner Adept":
                    mcn = new JoinerAdeptFD();
                    break;
                # endregion

                # region Krark-Clan Engineers
                case "Krark-Clan Engineers":
                    mcn = new KrarkClanEngineersFD();
                    break;
                # endregion

                # region Krark-Clan Ironworks
                case "Krark-Clan Ironworks":
                    mcn = new KrarkClanIronworksFD();
                    break;
                # endregion

                # region Krark-Clan Ogre
                case "Krark-Clan Ogre":
                    mcn = new KrarkClanOgreFD();
                    break;
                # endregion

                # region Lantern of Insight
                case "Lantern of Insight":
                    mcn = new LanternofInsightFD();
                    break;
                # endregion

                # region Leonin Squire
                case "Leonin Squire":
                    mcn = new LeoninSquireFD();
                    break;
                # endregion

                # region Lose Hope
                case "Lose Hope":
                    mcn = new LoseHopeFD();
                    break;
                # endregion

                # region Loxodon Anchorite
                case "Loxodon Anchorite":
                    mcn = new LoxodonAnchoriteFD();
                    break;
                # endregion

                # region Loxodon Stalwart
                case "Loxodon Stalwart":
                    mcn = new LoxodonStalwartFD();
                    break;
                # endregion

                # region Lunar Avenger
                case "Lunar Avenger":
                    mcn = new LunarAvengerFD();
                    break;
                # endregion

                # region Magma Giant
                case "Magma Giant":
                    mcn = new MagmaGiantFD();
                    break;
                # endregion

                //# region Magma Jet
                //case "Magma Jet":
                //    mcn = new MagmaJetFD();
                //    break;
                //# endregion

                # region Magnetic Theft
                case "Magnetic Theft":
                    mcn = new MagneticTheftFD();
                    break;
                # endregion

                # region Mana Geyser
                case "Mana Geyser":
                    mcn = new ManaGeyserFD();
                    break;
                # endregion

                # region Mephidross Vampire
                case "Mephidross Vampire":
                    mcn = new MephidrossVampireFD();
                    break;
                # endregion

                # region Moriok Rigger
                case "Moriok Rigger":
                    mcn = new MoriokRiggerFD();
                    break;
                # endregion

                # region Mycosynth Golem
                case "Mycosynth Golem":
                    mcn = new MycosynthGolemFD();
                    break;
                # endregion

                # region Myr Quadropod
                case "Myr Quadropod":
                    mcn = new MyrQuadropodFD();
                    break;
                # endregion

                # region Myr Servitor
                case "Myr Servitor":
                    mcn = new MyrServitorFD();
                    break;
                # endregion

                # region Neurok Stealthsuit
                case "Neurok Stealthsuit":
                    mcn = new NeurokStealthsuitFD();
                    break;
                # endregion

                # region Night's Whisper
                case "Night's Whisper":
                    mcn = new NightsWhisperFD();
                    break;
                # endregion

                # region Nim Grotesque
                case "Nim Grotesque":
                    mcn = new NimGrotesqueFD();
                    break;
                # endregion

                # region Opaline Bracers
                case "Opaline Bracers":
                    mcn = new OpalineBracersFD();
                    break;
                # endregion

                # region Ouphe Vandals
                case "Ouphe Vandals":
                    mcn = new OupheVandalsFD();
                    break;
                # endregion

                //# region Paradise Mantle
                //case "Paradise Mantle":
                //    mcn = new ParadiseMantleFD();
                //    break;
                //# endregion

                # region Pentad Prism
                case "Pentad Prism":
                    mcn = new PentadPrismFD();
                    break;
                # endregion

                # region Plasma Elemental
                case "Plasma Elemental":
                    mcn = new PlasmaElementalFD();
                    break;
                # endregion

                # region Plunge into Darkness
                case "Plunge into Darkness":
                    mcn = new PlungeintoDarknessFD();
                    break;
                # endregion

                # region Possessed Portal
                case "Possessed Portal":
                    mcn = new PossessedPortalFD();
                    break;
                # endregion

                # region Qumulox
                case "Qumulox":
                    mcn = new QumuloxFD();
                    break;
                # endregion

                # region Rain of Rust
                case "Rain of Rust":
                    mcn = new RainofRustFD();
                    break;
                # endregion

                # region Raksha Golden Cub
                case "Raksha Golden Cub":
                    mcn = new RakshaGoldenCubFD();
                    break;
                # endregion

                # region Razorgrass Screen
                case "Razorgrass Screen":
                    mcn = new RazorgrassScreenFD();
                    break;
                # endregion

                # region Razormane Masticore
                case "Razormane Masticore":
                    mcn = new RazormaneMasticoreFD();
                    break;
                # endregion

                # region Relentless Rats
                case "Relentless Rats":
                    mcn = new RelentlessRatsFD();
                    break;
                # endregion

                # region Relic Barrier
                case "Relic Barrier":
                    mcn = new RelicBarrierFD();
                    break;
                # endregion

                # region Retaliate
                case "Retaliate":
                    mcn = new RetaliateFD();
                    break;
                # endregion

                # region Reversal of Fortune
                case "Reversal of Fortune":
                    mcn = new ReversalofFortuneFD();
                    break;
                # endregion

                # region Rite of Passage
                case "Rite of Passage":
                    mcn = new RiteofPassageFD();
                    break;
                # endregion

                # region Roar of Reclamation
                case "Roar of Reclamation":
                    mcn = new RoarofReclamationFD();
                    break;
                # endregion

                //# region Rude Awakening
                //case "Rude Awakening":
                //    mcn = new RudeAwakeningFD();
                //    break;
                //# endregion

                # region Salvaging Station
                case "Salvaging Station":
                    mcn = new SalvagingStationFD();
                    break;
                # endregion

                # region Sawtooth Thresher
                case "Sawtooth Thresher":
                    mcn = new SawtoothThresherFD();
                    break;
                # endregion

                # region Screaming Fury
                case "Screaming Fury":
                    mcn = new ScreamingFuryFD();
                    break;
                # endregion

                # region Serum Visions
                case "Serum Visions":
                    mcn = new SerumVisionsFD();
                    break;
                # endregion

                # region Shattered Dreams
                case "Shattered Dreams":
                    mcn = new ShatteredDreamsFD();
                    break;
                # endregion

                # region Silent Arbiter
                case "Silent Arbiter":
                    mcn = new SilentArbiterFD();
                    break;
                # endregion

                # region Skullcage
                case "Skullcage":
                    mcn = new SkullcageFD();
                    break;
                # endregion

                # region Skyhunter Prowler
                case "Skyhunter Prowler":
                    mcn = new SkyhunterProwlerFD();
                    break;
                # endregion

                # region Skyhunter Skirmisher
                case "Skyhunter Skirmisher":
                    mcn = new SkyhunterSkirmisherFD();
                    break;
                # endregion

                //# region Skyreach Manta
                //case "Skyreach Manta":
                //    mcn = new SkyreachMantaFD();
                //    break;
                //# endregion

                # region Solarion
                case "Solarion":
                    mcn = new SolarionFD();
                    break;
                # endregion

                # region Spark Elemental
                case "Spark Elemental":
                    mcn = new SparkElementalFD();
                    break;
                # endregion

                # region Sparring Collar
                case "Sparring Collar":
                    mcn = new SparringCollarFD();
                    break;
                # endregion

                # region Spectral Shift
                case "Spectral Shift":
                    mcn = new SpectralShiftFD();
                    break;
                # endregion

                # region Spinal Parasite
                case "Spinal Parasite":
                    mcn = new SpinalParasiteFD();
                    break;
                # endregion

                # region Staff of Domination
                case "Staff of Domination":
                    mcn = new StaffofDominationFD();
                    break;
                # endregion

                # region Stand Firm
                case "Stand Firm":
                    mcn = new StandFirmFD();
                    break;
                # endregion

                # region Stasis Cocoon
                case "Stasis Cocoon":
                    mcn = new StasisCocoonFD();
                    break;
                # endregion

                # region Steelshaper's Gift
                case "Steelshaper's Gift":
                    mcn = new SteelshapersGiftFD();
                    break;
                # endregion

                # region Summoner's Egg
                case "Summoner's Egg":
                    mcn = new SummonersEggFD();
                    break;
                # endregion

                # region Summoning Station
                case "Summoning Station":
                    mcn = new SummoningStationFD();
                    break;
                # endregion

                # region Suncrusher
                case "Suncrusher":
                    mcn = new SuncrusherFD();
                    break;
                # endregion

                # region Suntouched Myr
                case "Suntouched Myr":
                    mcn = new SuntouchedMyrFD();
                    break;
                # endregion

                # region Sylvok Explorer
                case "Sylvok Explorer":
                    mcn = new SylvokExplorerFD();
                    break;
                # endregion

                # region Synod Centurion
                case "Synod Centurion":
                    mcn = new SynodCenturionFD();
                    break;
                # endregion

                # region Tangle Asp
                case "Tangle Asp":
                    mcn = new TangleAspFD();
                    break;
                # endregion

                # region Tel-Jilad Justice
                case "Tel-Jilad Justice":
                    mcn = new TelJiladJusticeFD();
                    break;
                # endregion

                # region Tel-Jilad Lifebreather
                case "Tel-Jilad Lifebreather":
                    mcn = new TelJiladLifebreatherFD();
                    break;
                # endregion

                # region Thermal Navigator
                case "Thermal Navigator":
                    mcn = new ThermalNavigatorFD();
                    break;
                # endregion

                # region Thought Courier
                case "Thought Courier":
                    mcn = new ThoughtCourierFD();
                    break;
                # endregion

                # region Tornado Elemental
                case "Tornado Elemental":
                    mcn = new TornadoElementalFD();
                    break;
                # endregion

                # region Trinket Mage
                case "Trinket Mage":
                    mcn = new TrinketMageFD();
                    break;
                # endregion

                # region Tyrranax
                case "Tyrranax":
                    mcn = new TyrranaxFD();
                    break;
                # endregion

                # region Vanquish
                case "Vanquish":
                    mcn = new VanquishFD();
                    break;
                # endregion

                # region Vedalken Mastermind
                case "Vedalken Mastermind":
                    mcn = new VedalkenMastermindFD();
                    break;
                # endregion

                # region Vedalken Orrery
                case "Vedalken Orrery":
                    mcn = new VedalkenOrreryFD();
                    break;
                # endregion

                //# region Vedalken Shackles
                //case "Vedalken Shackles":
                //    mcn = new VedalkenShacklesFD();
                //    break;
                //# endregion

                # region Vicious Betrayal
                case "Vicious Betrayal":
                    mcn = new ViciousBetrayalFD();
                    break;
                # endregion

                # region Viridian Lorebearers
                case "Viridian Lorebearers":
                    mcn = new ViridianLorebearersFD();
                    break;
                # endregion

                # region Viridian Scout
                case "Viridian Scout":
                    mcn = new ViridianScoutFD();
                    break;
                # endregion

                # region Vulshok Sorcerer
                case "Vulshok Sorcerer":
                    mcn = new VulshokSorcererFD();
                    break;
                # endregion

                # region Wayfarer's Bauble
                case "Wayfarer's Bauble":
                    mcn = new WayfarersBaubleFD();
                    break;
                # endregion


                # endregion

                default:
                    mcn = new MagicCard();
                    mcn.Name = s;
                    break;
            }

            return mcn;
        }

        public static List<MagicCard> CreateSealed(List<MagicCard> source)
        {
            List<MagicCard> result = new List<MagicCard>();

            List<MagicCard> MythicRare = source.Where(o => o.Rarity == "M" || o.Rarity == "R").ToList();
            List<MagicCard> Uncommon = source.Where(o => o.Rarity == "U").ToList();
            List<MagicCard> Common = source.Where(o => o.Rarity == "C").ToList();
            List<MagicCard> Land = source.Where(o => o.Type.Contains("Basic Land")).ToList();

            for (int i = 0; i < 15; i++)
            {
                # region Mythic or Rare
                if (i == 0 && MythicRare.Count > 0)
                {
                    int j = r.Next(0, MythicRare.Count);
                    MagicCard mc = CardMethods.GetClass(MythicRare[j]);
                    result.Add(mc);
                    MythicRare.RemoveAt(j);
                }
                # endregion
                # region Uncommon
                else if (i <= 3 && Uncommon.Count > 0)
                {
                    int j = r.Next(0, Uncommon.Count);
                    MagicCard mc = CardMethods.GetClass(Uncommon[j]);
                    result.Add(mc);
                    Uncommon.RemoveAt(j);
                }
                # endregion
                # region Common
                else if (i <= 13 && Common.Count > 0)
                {
                    int j = r.Next(0, Common.Count);
                    MagicCard mc = CardMethods.GetClass(Common[j]);
                    result.Add(mc);
                    Common.RemoveAt(j);
                }
                # endregion
                # region Land
                else if (Land.Count > 0)
                {
                    int j = r.Next(0, Land.Count);
                    MagicCard mc = CardMethods.GetClass(Land[j]);
                    result.Add(mc);
                    Land.RemoveAt(j);
                }
                # endregion
            }

            return result;
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
