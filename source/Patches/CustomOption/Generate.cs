using System;

namespace TownOfRoles.CustomOption
{
    public class Generate
    {
        public static CustomHeaderOption CrewRoles;     
        public static CustomNumberOption MysticOn;
        public static CustomNumberOption SnitchOn; 
        public static CustomNumberOption CamouflagerOn;        
        public static CustomNumberOption InformantOn;
        public static CustomNumberOption TrackerOn;
        public static CustomNumberOption TrapperOn;
        public static CustomNumberOption AltruistOn;
        public static CustomNumberOption MedicOn;
        public static CustomNumberOption SheriffOn;
        public static CustomNumberOption VeteranOn;
        public static CustomNumberOption EngineerOn;
        public static CustomNumberOption ImitatorOn;
        public static CustomNumberOption MayorOn;
        public static CustomNumberOption MediumOn;
        public static CustomNumberOption SwapperOn;
        public static CustomNumberOption TransporterOn;

        public static CustomHeaderOption NeutralRolesMinMax;
        public static CustomHeaderOption NeutralRoles;
        public static CustomNumberOption AmnesiacOn;
        public static CustomNumberOption GuardianAngelOn;
        public static CustomNumberOption ExecutionerOn;
        public static CustomNumberOption JesterOn;


        public static CustomHeaderOption NeutralKillingRoles;
        public static CustomNumberOption ArsonistOn;
        public static CustomNumberOption PlaguebearerOn;
        public static CustomNumberOption GlitchOn;
        public static CustomNumberOption WerewolfOn;
        public static CustomNumberOption JuggernautOn;

        public static CustomHeaderOption ImpostorRoles;
        public static CustomNumberOption EscapistOn;
        public static CustomNumberOption MorphlingOn;
        public static CustomNumberOption SwooperOn;
        public static CustomNumberOption GrenadierOn;      
        public static CustomNumberOption BomberOn;
        public static CustomNumberOption TraitorOn;
        public static CustomNumberOption SilencerOn;
        public static CustomNumberOption JanitorOn;
        public static CustomNumberOption MinerOn;
        public static CustomNumberOption UndertakerOn;

        public static CustomToggleOption MorphlingVent;
        public static CustomHeaderOption CrewmateModifiers;
        public static CustomNumberOption BaitOn;
        public static CustomNumberOption BlindOn;
        public static CustomNumberOption DiseasedOn;
        public static CustomNumberOption MultitaskerOn;
        public static CustomNumberOption LighterOn;    
        public static CustomNumberOption ObliviousOn;           
        public static CustomNumberOption TorchOn;



        public static CustomHeaderOption GlobalModifiers;
        public static CustomNumberOption ButtonBarryOn;
        public static CustomNumberOption DrunkOn;         
        public static CustomNumberOption ChameleonModifierOn;               
        public static CustomNumberOption FlashOn;
        public static CustomNumberOption GiantOn;
        public static CustomNumberOption LoversOn;
        public static CustomNumberOption ParanoiacOn;
        public static CustomNumberOption MiniOn;        
        public static CustomNumberOption SleuthOn;
        public static CustomNumberOption TiebreakerOn;

        public static CustomHeaderOption ImpostorModifiers;
        public static CustomNumberOption DisperserOn;
        public static CustomNumberOption DoubleShotOn;
        public static CustomNumberOption UnderdogOn;

        public static CustomHeaderOption MapSettings;
        public static CustomToggleOption RandomMapEnabled;
        public static CustomNumberOption RandomMapSkeld;
        public static CustomNumberOption RandomMapMira;
        public static CustomNumberOption RandomMapPolus;
        public static CustomNumberOption RandomMapAirship;
        public static CustomNumberOption RandomMapSubmerged;
        public static CustomToggleOption AutoAdjustSettings;
        public static CustomToggleOption SmallMapHalfVision;
        public static CustomNumberOption SmallMapDecreasedCooldown;
        public static CustomNumberOption LargeMapIncreasedCooldown;
        public static CustomNumberOption SmallMapIncreasedShortTasks;
        public static CustomNumberOption SmallMapIncreasedLongTasks;
        public static CustomNumberOption LargeMapDecreasedShortTasks;
        public static CustomNumberOption LargeMapDecreasedLongTasks;

        public static CustomHeaderOption CustomGameSettings;      
        public static CustomToggleOption ColourblindComms;  
        public static CustomToggleOption AppearanceAnimation;        
        public static CustomToggleOption OxySlow;
        public static CustomNumberOption ReactorShake;           
        public static CustomToggleOption EveryoneVent;        
        public static CustomToggleOption RandomSpawns;             
        public static CustomToggleOption CamoHideSize;        
        public static CustomToggleOption CamoHideSpeed;        
        public static CustomToggleOption ImpostorSnitcholes;
        public static CustomToggleOption DeadSnitcholes;
        public static CustomNumberOption VanillaGame;
   
        public static CustomNumberOption InitialCooldowns;
        public static CustomToggleOption ParallelMedScans;
        public static CustomStringOption SkipButtonDisable;

        public static CustomHeaderOption QualitySettings;  

        public static CustomHeaderOption BetterMapSettings;
        public static CustomToggleOption SkeldVentImprovements;        
        public static CustomToggleOption VentImprovements;
        public static CustomToggleOption VitalsLab;
        public static CustomToggleOption ColdTempDeathValley;
        public static CustomToggleOption WifiChartCourseSwap;     

        public static CustomHeaderOption mainettings;
        public static CustomStringOption GameMode;

        public static CustomHeaderOption ClassicSettings;
        public static CustomNumberOption MinNeutralNonKillingRoles;
        public static CustomNumberOption MaxNeutralNonKillingRoles;
        public static CustomNumberOption MinNeutralKillingRoles;
        public static CustomNumberOption MaxNeutralKillingRoles;

        public static CustomHeaderOption AllAnySettings;
        public static CustomToggleOption RandomNumberImps;

        public static CustomHeaderOption KillingOnlySettings;
        public static CustomNumberOption NeutralRoles2;
        public static CustomNumberOption VeteranCount;
        public static CustomToggleOption AddArsonist;
        public static CustomToggleOption AddJuggernaut;        
        public static CustomToggleOption AddPlaguebearer;


        public static CustomNumberOption CultistOn;
        public static CustomHeaderOption Cultist;     
        public static CustomNumberOption ReviveCooldown2;
        public static CustomNumberOption IncreasedCooldownPerRevive2;        
        public static CustomHeaderOption TaskTrackingSettings;
        public static CustomToggleOption SeeTasksDuringRound;
        public static CustomToggleOption SeeTasksDuringMeeting;
        public static CustomToggleOption SeeTasksWhenDead;

        public static CustomHeaderOption Mayor;
        public static CustomNumberOption MayorVoteBank;
        public static CustomToggleOption MayorAnonymous;



        public static CustomHeaderOption Sheriff;
        public static CustomToggleOption SheriffKillOther;  
        public static CustomToggleOption SheriffKillsExecutioner;
        public static CustomToggleOption SheriffKillsLovers;        
        public static CustomToggleOption SheriffKillsJester;
        public static CustomToggleOption SheriffKillsArsonist;
        public static CustomToggleOption SheriffKillsJuggernaut;
        public static CustomToggleOption SheriffKillsPlaguebearer;
        public static CustomToggleOption SheriffKillsGlitch;
        public static CustomToggleOption SheriffKillsWerewolf;
        public static CustomNumberOption SheriffKillCd;
        public static CustomToggleOption SheriffBodyReport;

        public static CustomHeaderOption Engineer;
        public static CustomNumberOption MaxFixes;


        public static CustomHeaderOption Medic;
        public static CustomStringOption ShowShielded;
        public static CustomStringOption WhoGetsNotification;
        public static CustomToggleOption ShieldBreaks;
        public static CustomToggleOption MedicReportSwitch;
        public static CustomNumberOption MedicReportNameDuration;
        public static CustomNumberOption MedicReportColorDuration;

        public static CustomHeaderOption Snitch;
        public static CustomNumberOption SnitchCooldown;
        public static CustomToggleOption CrewKillingRed;
        public static CustomToggleOption NeutralNNK;
        public static CustomToggleOption NeutKillingRed;
        public static CustomToggleOption TraitorColourSwap;

        public static CustomHeaderOption Swapper;
        public static CustomToggleOption SwapperButton;

        public static CustomHeaderOption Transporter;
        public static CustomNumberOption TransportCooldown;
        public static CustomNumberOption TransportMaxUses;
        public static CustomToggleOption TransporterVitals;

        public static CustomHeaderOption Jester;
        public static CustomToggleOption JesterButton;
        public static CustomToggleOption JesterVent;
        public static CustomToggleOption JesterKill;        
        public static CustomToggleOption JesterSwitchVent;        
        public static CustomToggleOption JesterImpVision;
     

        public static CustomHeaderOption TheGlitch;
        public static CustomNumberOption MimicCooldownOption;
        public static CustomNumberOption MimicDurationOption;
        public static CustomNumberOption HackCooldownOption;
        public static CustomNumberOption HackDurationOption;
        public static CustomNumberOption GlitchKillCooldownOption;
        public static CustomStringOption GlitchHackDistanceOption;
        public static CustomToggleOption GlitchVent;

        public static CustomHeaderOption Juggernaut;
        public static CustomNumberOption JuggKillCooldown;
        public static CustomNumberOption ReducedKCdPerKill;
        public static CustomToggleOption JuggVent;

        public static CustomHeaderOption Camouflager;
        public static CustomNumberOption ChameleonSwoopCd;
        public static CustomNumberOption ChameleonSwoopDuration;

        public static CustomHeaderOption Morphling;
        public static CustomNumberOption MorphlingCooldown;
        public static CustomNumberOption MorphlingDuration;

        public static CustomHeaderOption Executioner;
        public static CustomStringOption OnTargetDead;
        public static CustomToggleOption ExecutionerButton;
     

        public static CustomHeaderOption Phantom;
        public static CustomNumberOption PhantomTasksRemaining;


        public static CustomHeaderOption Informant;
        public static CustomToggleOption InformantSeesNeutrals;
        public static CustomNumberOption InformantTasksRemaining;
        public static CustomToggleOption InformantSeesImpInMeeting;
        public static CustomToggleOption InformantSeesTraitor;

        public static CustomHeaderOption Mini;
        public static CustomNumberOption MiniSize;     
        public static CustomNumberOption MiniSpeed;

        public static CustomHeaderOption Altruist;
        public static CustomNumberOption ReviveDuration;
        public static CustomToggleOption AltruistTargetBody;

        public static CustomHeaderOption PostMortalRoles;
        public static CustomNumberOption PhantomOn;
        public static CustomNumberOption AvengerOn;

        public static CustomHeaderOption Miner;
        public static CustomNumberOption MineCooldown;

        public static CustomHeaderOption Swooper;
        public static CustomNumberOption SwoopCooldown;
        public static CustomNumberOption SwoopDuration;
        public static CustomToggleOption SwooperVent;
        public static CustomToggleOption SwooperPolusVent;

        public static CustomHeaderOption Arsonist;
        public static CustomNumberOption DouseCooldown;
        public static CustomNumberOption MaxDoused;
        public static CustomToggleOption ArsoImpVision;     
        public static CustomToggleOption ArsoVent;        
        public static CustomToggleOption IgniteCdRemoved;

        public static CustomHeaderOption Undertaker;
        public static CustomNumberOption DragCooldown;
        public static CustomNumberOption UndertakerDragSpeed;

        public static CustomHeaderOption Assassin;
        public static CustomToggleOption ImpostorsVent;        
        public static CustomNumberOption NumberOfImpostorAssassins;
        public static CustomNumberOption NumberOfNeutralAssassins;
        public static CustomNumberOption NumberOfCrewAssassins;        
        public static CustomToggleOption AmneTurnImpAssassin;
        public static CustomToggleOption AmneTurnNeutAssassin;
        public static CustomToggleOption TraitorCanAssassin;
        public static CustomNumberOption AssassinKills;
        public static CustomToggleOption AssassinMultiKill;
        public static CustomToggleOption AssassinCrewmateGuess;
        public static CustomToggleOption AssassinGuessGlobalModifiers;
        public static CustomToggleOption AssassinGuessModifiers;
        public static CustomToggleOption AssassinGuessLovers;
        public static CustomToggleOption AssassinateAfterVoting;

        public static CustomHeaderOption Underdog;
        public static CustomNumberOption UnderdogKillBonus;
        public static CustomToggleOption UnderdogIncreasedKC;


        public static CustomHeaderOption Avenger;
        public static CustomNumberOption AvengerTasksRemainingClicked;
        public static CustomNumberOption AvengerTasksRemainingAlert;
        public static CustomToggleOption AvengerRevealsNeutrals;
        public static CustomStringOption AvengerCanBeClickedBy;

        public static CustomHeaderOption Grenadier;
        public static CustomNumberOption GrenadeCooldown;
        public static CustomNumberOption GrenadeDuration;
        public static CustomToggleOption GrenadierIndicators;
        public static CustomToggleOption GrenadierVent;
        public static CustomNumberOption FlashRadius;

        public static CustomHeaderOption Veteran;
        public static CustomToggleOption KilledOnAlert;
        public static CustomNumberOption AlertCooldown;
        public static CustomNumberOption AlertDuration;
        public static CustomNumberOption MaxAlerts;

        public static CustomHeaderOption Tracker;
        public static CustomNumberOption UpdateInterval;
        public static CustomNumberOption TrackCooldown;
        public static CustomToggleOption ResetOnNewRound;
        public static CustomNumberOption MaxTracks;

        public static CustomHeaderOption Trapper;
        public static CustomNumberOption TrapCooldown;
        public static CustomToggleOption TrapsRemoveOnNewRound;
        public static CustomNumberOption MaxTraps;
        public static CustomNumberOption MinAmountOfTimeInTrap;
        public static CustomNumberOption TrapSize;
        public static CustomNumberOption MinAmountOfPlayersInTrap;

        public static CustomHeaderOption Traitor;
        public static CustomNumberOption LatestSpawn;
        public static CustomToggleOption NeutralKillingTraitorSpawn;

        public static CustomHeaderOption Amnesiac;
        public static CustomToggleOption RememberArrows;
        public static CustomNumberOption RememberArrowDelay;

        public static CustomHeaderOption Medium;
        public static CustomNumberOption MediateCooldown;
        public static CustomToggleOption ShowMediatePlayer;
        public static CustomToggleOption ShowMediumToDead;
        public static CustomStringOption DeadRevealed;


        public static CustomHeaderOption GuardianAngel;
        public static CustomNumberOption ProtectCd;
        public static CustomNumberOption ProtectDuration;
        public static CustomNumberOption ProtectKCReset;
        public static CustomNumberOption MaxProtects;
        public static CustomStringOption ShowProtect;
        public static CustomStringOption GaOnTargetDeath;
        public static CustomToggleOption GATargetKnows;
        public static CustomToggleOption GAKnowsTargetRole;

        public static CustomHeaderOption Mystic;
        public static CustomNumberOption InitialExamineCooldown;
        public static CustomNumberOption ExamineCooldown;
        public static CustomNumberOption RecentKill;
        public static CustomToggleOption MysticReportOn;
        public static CustomNumberOption MysticRoleDuration;
        public static CustomNumberOption MysticFactionDuration;
        public static CustomToggleOption ExamineReportOn;        
        public static CustomNumberOption MysticArrowDuration;

        public static CustomHeaderOption Silencer;
        public static CustomNumberOption SilenceCooldown;

        public static CustomHeaderOption Plaguebearer;
        public static CustomNumberOption InfectCooldown;
        public static CustomNumberOption PestKillCooldown;
         public static CustomToggleOption PlaguebearerVent;       
        public static CustomToggleOption PestVent;

        public static CustomHeaderOption Werewolf;
        public static CustomNumberOption RampageCooldown;
        public static CustomNumberOption RampageDuration;
        public static CustomNumberOption RampageKillCooldown;
        public static CustomToggleOption WerewolfVent;



        public static CustomHeaderOption Escapist;
        public static CustomNumberOption EscapeCooldown;
        public static CustomToggleOption EscapistVent;

        public static CustomHeaderOption Bomber;
        public static CustomNumberOption MaxKillsInDetonation;
        public static CustomNumberOption DetonateDelay;
        public static CustomNumberOption DetonateRadius;
        public static CustomToggleOption BomberVent;

        public static CustomHeaderOption Giant;
        public static CustomNumberOption GiantSize;          
        public static CustomNumberOption GiantSlow;

        public static CustomHeaderOption Flash;
        public static CustomNumberOption FlashSpeed;

        public static CustomHeaderOption Diseased;
        public static CustomNumberOption DiseasedKillMultiplier;

        public static CustomHeaderOption ButtonBarry;
     
        public static CustomHeaderOption Bait;
        public static CustomNumberOption NumberOfBaits;        
        public static CustomNumberOption BaitMinDelay;
        public static CustomNumberOption BaitMaxDelay;

        public static CustomHeaderOption Lovers;
        public static CustomToggleOption BothLoversDie;
        public static CustomNumberOption LovingImpPercent;
        public static CustomToggleOption NeutralLovers;      
        public static CustomToggleOption VentTargetting;
        public static Func<object, string> PercentFormat { get; } = value => $"{value:0}%";
        public static object Multimenu { get; private set; }
        private static Func<object, string> CooldownFormat { get; } = value => $"{value:0.0#}s";
        private static Func<object, string> MultiplierFormat { get; } = value => $"{value:0.0#}x";



        public static void GenerateAll()
        {
            var num = 0;

            Patches.ExportButton = new Export(num++);
            Patches.ImportButton = new Import(num++);


            AltruistOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#2d6aa5>Altruist</color>", 0f, 0f, 100f, 10f,
                PercentFormat); 
            AvengerOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#D3D3D3FF>Avenger</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                   
            CamouflagerOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#708eef>Camouflager</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                  
            EngineerOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#FFA60AFF>Engineer</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                  
            ImitatorOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#B3D94DFF>Imitator</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                   
            InformantOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>Informant</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                                                                                                                   
            MayorOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#704FA8FF>Mayor</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MedicOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#52e36f>Medic</color>", 0f, 0f, 100f, 10f,
                PercentFormat);   
            MediumOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#A680FFFF>Medium</color>", 0f, 0f, 100f, 10f,
                PercentFormat);  
            MysticOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#4D4DFFFF>Mystic</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                                                      
            SheriffOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#f8cd46>Sheriff</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SnitchOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#61b26c>Snitch</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SwapperOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#863756>Swapper</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                
            TrackerOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#009900FF>Tracker</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TransporterOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#00EEFFFF>Transporter</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                
            TrapperOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#75fa4c>Trapper</color>", 0f, 0f, 100f, 10f,
                PercentFormat);              
            VeteranOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#998040FF>Veteran</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

           NeutralRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#80797c>Neutrals</color>");
            AmnesiacOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#80B2FFFF>Amnesiac</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            ExecutionerOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#2d4222>Executioner</color>", 0f, 0f, 100f, 10f,
                PercentFormat);      
            GuardianAngelOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#B3FFFFFF>Guardian Angel</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                             
            JesterOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#cb81c0>Jester</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                              
            PhantomOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#662962FF>Phantom</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                                     



            NeutralKillingRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#80797c>Neutral</color> <color=#FF0000FF>Killers</color>");
            ArsonistOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#FF4D00FF>Arsonist</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            PlaguebearerOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#E6FFB3FF>Plaguebearer</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GlitchOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#00FF00FF>Glitch</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            WerewolfOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#A86629FF>Werewolf</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JuggernautOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#8C004DFF>Juggernaut</color>", 0f, 0f, 100f, 10f,
                PercentFormat);


            BomberOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Bomber</color>", 0f, 0f, 100f, 10f,
                PercentFormat);   
            CultistOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Cultist</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                                
            EscapistOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Escapist</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GrenadierOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Grenadier</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JanitorOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Janitor</color>", 0f, 0f, 100f, 10f,
                PercentFormat);   
            MinerOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Miner</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                                          
            MorphlingOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Morphling</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TraitorOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Traitor</color>", 0f, 0f, 100f, 10f,
                PercentFormat); 
            UndertakerOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Undertaker</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SilencerOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Silencer</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SwooperOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Swooper</color>", 0f, 0f, 100f, 10f,
                PercentFormat);



            CrewmateModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#26ffff>Crewmate</color> <color=#f590bc>Modifiers</color>");
            BaitOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Bait</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            BlindOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Blind</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DiseasedOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Diseased</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            LighterOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Lighter</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                   
            MultitaskerOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Multitasker</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TorchOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Torch</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            GlobalModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#f590bc>Global Modifiers</color>");
            ButtonBarryOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Button Barry</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            ChameleonModifierOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Chameleon</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                
            DrunkOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Drunk</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                
            FlashOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Flash</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GiantOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Giant</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            LoversOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#e839b9>Lovers</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MiniOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Mini</color>", 0f, 0f, 100f, 10f,
                PercentFormat);   
            ObliviousOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Oblivious</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                                 
            ParanoiacOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Paranoiac</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SleuthOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Sleuth</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TiebreakerOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Tiebreaker</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Impostor</color> <color=#f590bc>Modifiers</color>");
            DisperserOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Disperser</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DoubleShotOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Double Shot</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            UnderdogOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Underdog</color>", 0f, 0f, 100f, 10f,
                PercentFormat);


            mainettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Game Mode Settings");
            GameMode = new CustomStringOption(num++, MultiMenu.main, "Game Mode", new[] {"Classic", "All Any", "Killing Only"});

            AllAnySettings =
                new CustomHeaderOption(num++, MultiMenu.main, "All Any Settings");
            RandomNumberImps = new CustomToggleOption(num++, MultiMenu.main, "Random Number Of Impostors", true);

            KillingOnlySettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Killing Only Settings");
            NeutralRoles2 =
                new CustomNumberOption(num++, MultiMenu.main, "Neutral Roles", 1, 0, 5, 1);
            VeteranCount =
                new CustomNumberOption(num++, MultiMenu.main, "<color=#998040FF>Veteran</color> Count", 1, 0, 5, 1);
            AddArsonist = new CustomToggleOption(num++, MultiMenu.main, "Add <color=#FF4D00FF>Arsonist</color>", true);
            AddJuggernaut = new CustomToggleOption(num++, MultiMenu.main, "Add <color=#8C004DFF>Juggernaut</color>", true);            
            AddPlaguebearer = new CustomToggleOption(num++, MultiMenu.main, "Add <color=#E6FFB3FF>Plaguebearer</color>", true);

            CustomGameSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Custom Game Settings");
            ColourblindComms = new CustomToggleOption(num++, MultiMenu.main, "Camouflaged Comms", false);                 
            RandomSpawns = new CustomToggleOption(num++, MultiMenu.main, "Enable Random Spawns", false);                   
            OxySlow = new CustomToggleOption(num++, MultiMenu.main, "Oxygen Sabotage Slows Down Players", true);         
            EveryoneVent = new CustomToggleOption(num++, MultiMenu.main, "Everyone Vent Mode", false);
           // CamoHideSize = new CustomToggleOption(num++, MultiMenu.main, "Camouflage Hides Modified Size", false);
            //CamoHideSpeed = new CustomToggleOption(num++, MultiMenu.main, "Camouflage Hides Modified Speed", false);                        
            ImpostorSnitcholes = new CustomToggleOption(num++, MultiMenu.main, "Impostors Can See The Roles Of Their Team", false);
            DeadSnitcholes =
                new CustomToggleOption(num++, MultiMenu.main, "Dead Can See Everyone's Roles/Votes", false);
            VanillaGame = new CustomNumberOption(num++, MultiMenu.main, "Probability Of A Completely Vanilla Game", 0f, 0f, 100f, 5f,
                PercentFormat);
            InitialCooldowns =
                new CustomNumberOption(num++, MultiMenu.main, "Game Start Cooldowns", 10f, 10f, 30f, 2.5f, CooldownFormat);


            QualitySettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Player Quality Settings");
            AppearanceAnimation = new CustomToggleOption(num++, MultiMenu.main, "Kill Animations Show Morphed Player");                    
            ParallelMedScans = new CustomToggleOption(num++, MultiMenu.main, "Parallel Medbay Scans", false);
            SkipButtonDisable = new CustomStringOption(num++, MultiMenu.main, "Disable Meeting Skip Button", new[] { "No", "Emergency", "Always" });
            SeeTasksDuringRound = new CustomToggleOption(num++, MultiMenu.main, "See Tasks During Round", false);
            SeeTasksDuringMeeting = new CustomToggleOption(num++, MultiMenu.main, "See Tasks During Meetings", false);
            SeeTasksWhenDead = new CustomToggleOption(num++, MultiMenu.main, "See Tasks When Dead", true);

            BetterMapSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Better Map Settings");
            SkeldVentImprovements = new CustomToggleOption(num++, MultiMenu.main, "Better Skeld Vent Layout", false);                
            VentImprovements = new CustomToggleOption(num++, MultiMenu.main, "Better Polus Vent Layout", false);
            VitalsLab = new CustomToggleOption(num++, MultiMenu.main, "Vitals Moved To Lab On Polus", false);
            ColdTempDeathValley = new CustomToggleOption(num++, MultiMenu.main, "Cold Temp Moved To Death Valley On Polus", false);
            WifiChartCourseSwap =
                new CustomToggleOption(num++, MultiMenu.main, "Reboot Wifi And Chart Course Swapped On Polus", false);
            

            MapSettings = new CustomHeaderOption(num++, MultiMenu.main, "Map Settings");
            RandomMapEnabled = new CustomToggleOption(num++, MultiMenu.main, "Choose Random Map", false);
            RandomMapSkeld = new CustomNumberOption(num++, MultiMenu.main, "Skeld Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapMira = new CustomNumberOption(num++, MultiMenu.main, "Mira Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapPolus = new CustomNumberOption(num++, MultiMenu.main, "Polus Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapAirship = new CustomNumberOption(num++, MultiMenu.main, "Airship Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapSubmerged = new CustomNumberOption(num++, MultiMenu.main, "Submerged Chance", 0f, 0f, 100f, 10f, PercentFormat);
            AutoAdjustSettings = new CustomToggleOption(num++, MultiMenu.main, "Auto Adjust Settings", false);
            SmallMapHalfVision = new CustomToggleOption(num++, MultiMenu.main, "Half Vision On Skeld/Mira HQ", false);
            SmallMapDecreasedCooldown =
                new CustomNumberOption(num++, MultiMenu.main, "Mira HQ Decreased Cooldowns", 0f, 0f, 15f, 2.5f, CooldownFormat);
            LargeMapIncreasedCooldown =
                new CustomNumberOption(num++, MultiMenu.main, "Airship/Submerged Increased Cooldowns", 0f, 0f, 15f, 2.5f, CooldownFormat);
            SmallMapIncreasedShortTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Skeld/Mira HQ Increased Short Tasks", 0, 0, 5, 1);
            SmallMapIncreasedLongTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Skeld/Mira HQ Increased Long Tasks", 0, 0, 3, 1);
            LargeMapDecreasedShortTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Airship/Submerged Decreased Short Tasks", 0, 0, 5, 1);
            LargeMapDecreasedLongTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Airship/Submerged Decreased Long Tasks", 0, 0, 3, 1);

            Assassin = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassin Ability</color>");
            NumberOfImpostorAssassins = new CustomNumberOption(num++, MultiMenu.imposter, "Number Of <color=#FF0000FF>Impostor</color> <color=#FF0000FF>Assassins</color>", 1, 0, 4, 1);
            NumberOfNeutralAssassins = new CustomNumberOption(num++, MultiMenu.imposter, "Number Of Neutral <color=#FF0000FF>Assassins</color>", 1, 0, 5, 1);
            NumberOfCrewAssassins = new CustomNumberOption(num++, MultiMenu.imposter, "Number Of <color=#00EEFFFF>Crewmate</color> <color=#FF0000FF>Assassins</color>", 1, 0, 5, 1);
            AmneTurnImpAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "Amnesiac Turned Impostor Gets Ability", false);
            AmneTurnNeutAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "Amnesiac Turned Neutral Killing Gets Ability", false);
            AssassinKills = new CustomNumberOption(num++, MultiMenu.imposter, "Number Of Assassin Kills", 1, 1, 15, 1);
            AssassinMultiKill = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassins</color> Can Kill More Than Once Per Meeting", false);
            AssassinCrewmateGuess = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassins</color> Can Guess \"<color=#00EEFFFF>Crewmate</color>\"", false);
            AssassinGuessGlobalModifiers = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassins</color> Can Guess <color=#f590bc>Button Barry</color>", false);
            AssassinGuessModifiers = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassins</color> Can Guess Crewmate Modifiers", false);
            AssassinateAfterVoting = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassins</color> Can Guess After Voting", false);
            
            Altruist = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#2d6aa5>Altruist</color>");
            ReviveDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#2d6aa5>Altruist</color> Revive Duration", 10f, 1f, 15f, 1f, CooldownFormat);
            AltruistTargetBody =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Target's Body Disappears On Beginning Of Revive", false);

            Avenger =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#d3d3d3FF>Avenger</color>");
            AvengerTasksRemainingClicked =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "Tasks Remaining When <color=#d3d3d3FF>Avenger</color> Can Be Clicked", 5, 1, 15, 1);
            AvengerTasksRemainingAlert =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "Tasks Remaining When Alert Is Sent", 1, 1, 5, 1);
            AvengerRevealsNeutrals = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#d3d3d3FF>Avenger</color> Reveals Neutral Roles", false);
            AvengerCanBeClickedBy = new CustomStringOption(num++, MultiMenu.crewmate, "Who Can Click <color=#d3d3d3FF>Avenger</color>", new[] { "All", "Non-Crew", "Imps Only" });

            Camouflager = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#708eef>Camouflager</color>");
            ChameleonSwoopCd =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Swoop Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ChameleonSwoopDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Swoop Duration", 10f, 5f, 15f, 1f, CooldownFormat);            


            Engineer =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFA60AFF>Engineer</color>");
            MaxFixes =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Fixes", 5, 1, 15, 1);

            Informant = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>Informant</color>");

            InformantSeesNeutrals = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>Informant</color> Sees Neutral Roles", false);
            InformantTasksRemaining =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "Tasks Remaining When Revealed", 1, 1, 5, 1);
            InformantSeesImpInMeeting = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>Informant</color> Sees Impostors In Meetings", true);

            Mayor =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#704FA8FF>Mayor</color>");
            MayorVoteBank =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Initial <color=#704FA8FF>Mayor</color> Vote Bank", 1, 1, 15, 1);
            MayorAnonymous =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#704FA8FF>Mayor</color> Votes Show Anonymous", false);

            Medic =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#52e36f>Medic</color>");
            ShowShielded =
                new CustomStringOption(num++, MultiMenu.crewmate, "Show Shielded Player",
                    new[] { "Self", "<color=#52e36f>Medic</color>", "Self+<color=#52e36f>Medic</color>", "Everyone" });
            WhoGetsNotification =
                new CustomStringOption(num++, MultiMenu.crewmate, "Who Gets Murder Attempt Indicator",
                    new[] { "<color=#52e36f>Medic</color>", "Shielded", "Everyone", "Nobody" });
            ShieldBreaks = new CustomToggleOption(num++, MultiMenu.crewmate, "Shield Breaks On Murder Attempt", false);
            MedicReportSwitch = new CustomToggleOption(num++, MultiMenu.crewmate, "Show <color=#52e36f>Medic</color> Reports");
            MedicReportNameDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Time Where <color=#52e36f>Medic</color> Will Have Name", 0f, 0f, 60f, 2.5f,
                    CooldownFormat);
            MedicReportColorDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Time Where <color=#52e36f>Medic</color> Will Have Color Type", 15f, 0f, 60f, 2.5f,
                    CooldownFormat);

            Medium =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#A680FFFF>Medium</color>");
            MediateCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Mediate Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);
            ShowMediatePlayer =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Reveal Appearance Of Mediate Target", true);
            ShowMediumToDead =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Reveal The Medium To The Mediate Target", true);
            DeadRevealed =
                new CustomStringOption(num++, MultiMenu.crewmate, "Who Is Revealed With Mediate", new[] { "Oldest Dead", "Newest Dead", "All Dead" });

            Mystic =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#4D4DFFFF>Mystic</color>");
            InitialExamineCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Initial Examine Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ExamineCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Examine Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);
            RecentKill =
                new CustomNumberOption(num++, MultiMenu.crewmate, "How Long Players Stay Bloody For", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MysticReportOn = new CustomToggleOption(num++, MultiMenu.crewmate, "Show <color=#4D4DFFFF>Mystic</color> Reports", true);
            MysticRoleDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Time Where <color=#4D4DFFFF>Mystic</color> Will Have Role", 15f, 0f, 60f, 2.5f,
                    CooldownFormat);
            MysticFactionDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Time Where <color=#4D4DFFFF>Mystic</color> Will Have Faction", 30f, 0f, 60f, 2.5f,
                    CooldownFormat);
            ExamineReportOn = new CustomToggleOption(num++, MultiMenu.crewmate, "Show Examine Reports", true);
            MysticArrowDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Dead Body Arrow Duration", 5f, 0f, 15f, 1f, CooldownFormat);

            Sheriff =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#f8cd46>Sheriff</color>");
            SheriffKillOther =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#f8cd46>Sheriff</color> Miskill Kills <color=#00EEFFFF>Crewmate</color>", false);
            SheriffKillsExecutioner =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#f8cd46>Sheriff</color> Kills <color=#2d4222>Executioner</color>", false);
            SheriffKillsJester =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#f8cd46>Sheriff</color> Kills <color=#cb81c0>Jester</color>", false);
            SheriffKillsArsonist =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#f8cd46>Sheriff</color> Kills <color=#FF4D00FF>Arsonist</color>", false);
            SheriffKillsGlitch =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#f8cd46>Sheriff</color> Kills <color=#00FF00FF>Glitch</color>", false);
            SheriffKillsLovers =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#f8cd46>Sheriff</color> Kills <color=#e839b9>Lovers</color>", false);                
            SheriffKillsJuggernaut =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#f8cd46>Sheriff</color> Kills <color=#8C004DFF>Juggernaut</color>", false);
            SheriffKillsPlaguebearer =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#f8cd46>Sheriff</color> Kills <color=#E6FFB3FF>Plaguebearer</color>", false);
            SheriffKillsWerewolf =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#f8cd46>Sheriff</color> Kills <color=#A86629FF>Werewolf</color>", false);
            SheriffKillCd =
                new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#f8cd46>Sheriff</color> Kill Cooldown", 25f, 10f, 40f, 2.5f, CooldownFormat);
            SheriffBodyReport = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#f8cd46>Sheriff</color> Can Report Who They've Killed");

            Snitch =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#61b26c>Snitch</color>");
            SnitchCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#61b26c>Snitch</color> Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            CrewKillingRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Crewmate Killing Roles Show Evil", false);
            NeutralNNK =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Neutral Non-Killing Roles Show Evil", false);
            NeutKillingRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Neutral Killing Roles Show Evil", false);

            Swapper =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#863756>Swapper</color>");
            SwapperButton =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#863756>Swapper</color> Can Button", true);

            Tracker =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#009900FF>Tracker</color>");
            UpdateInterval =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Arrow Update Interval", 5f, 0.5f, 15f, 0.5f, CooldownFormat);
            TrackCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#009900FF>Tracker</color> Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ResetOnNewRound = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#009900FF>Tracker</color> Arrows Reset After Each Round", false);
            MaxTracks = new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Tracks Per Round", 5, 1, 15, 1);

            Transporter =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#00EEFFFF>Transporter</color>");
            TransportCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#00EEFFFF>Transporter</color> Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            TransportMaxUses =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Transports", 5, 1, 15, 1);
            TransporterVitals =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#00EEFFFF>Transporter</color> Can Use Vitals", false);

            Trapper =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#75fa4c>Trapper</color>");
            MinAmountOfTimeInTrap =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Min Amount Of Time In Trap To Register", 1f, 0f, 15f, 0.5f, CooldownFormat);
            TrapCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Trap Cooldown", 25f, 10f, 40f, 2.5f, CooldownFormat);
            TrapsRemoveOnNewRound =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Traps Removed After Each Round", true);
            MaxTraps =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Traps Per Game", 5, 1, 15, 1);
            TrapSize =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Trap Size", 0.25f, 0.05f, 1f, 0.05f, MultiplierFormat);
            MinAmountOfPlayersInTrap =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Minimum Number Of Roles Required To Trigger Trap", 3, 1, 5, 1);

            Veteran =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#998040FF>Veteran</color>");
            KilledOnAlert =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Can Be Killed On Alert", false);
            AlertCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#998040FF>Veteran</color> Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            AlertDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Alert Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            MaxAlerts = new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Alerts", 5, 1, 15, 1);
        

            NeutralRolesMinMax = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#80797c>Neutrals</color> Min/Max");
            MinNeutralNonKillingRoles =
                new CustomNumberOption(num++, MultiMenu.neutral, "Min Neutral Non-Killing Roles", 1, 0, 5, 1);
            MaxNeutralNonKillingRoles =
                new CustomNumberOption(num++, MultiMenu.neutral, "Max Neutral Non-Killing Roles", 1, 0, 5, 1);
            MinNeutralKillingRoles =
                new CustomNumberOption(num++, MultiMenu.neutral, "Min Neutral Killing Roles", 1, 0, 4, 1);
            MaxNeutralKillingRoles =
                new CustomNumberOption(num++, MultiMenu.neutral, "Max Neutral Killing Roles", 1, 0, 4, 1);


           

            Amnesiac = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#80B2FFFF>Amnesiac</color>");
            RememberArrows =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#80B2FFFF>Amnesiac</color> Gets Arrows Pointing To Dead Bodies", false);
            RememberArrowDelay =
                new CustomNumberOption(num++, MultiMenu.neutral, "Time After Death Arrow Appears", 5f, 0f, 15f, 1f, CooldownFormat);
            
            Executioner =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#2d4222>Executioner</color>");
            OnTargetDead = new CustomStringOption(num++, MultiMenu.neutral, "<color=#2d4222>Executioner</color> Becomes On Target Dead",
                new[] { "<color=#00EEFFFF>Crewmate</color>", "<color=#80B2FFFF>Amnesiac</color>", "<color=#cb81c0>Jester</color>" });
            ExecutionerButton =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#2d4222>Executioner</color> Can Button", true);

            GuardianAngel =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#B3FFFFFF>Guardian Angel</color>");
            ProtectCd =
                new CustomNumberOption(num++, MultiMenu.neutral, "Protect Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ProtectDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "Protect Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            ProtectKCReset =
                new CustomNumberOption(num++, MultiMenu.neutral, "Kill Cooldown Reset When Protected", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxProtects =
                new CustomNumberOption(num++, MultiMenu.neutral, "Maximum Number Of Protects", 5, 1, 15, 1);
            ShowProtect =
                new CustomStringOption(num++, MultiMenu.neutral, "Show Protected Player",
                    new[] { "Self", "<color=#B3FFFFFF>Guardian Angel</color>", "Self+<color=#B3FFFFFF>GA</color>", "Everyone" });
            GaOnTargetDeath = new CustomStringOption(num++, MultiMenu.neutral, "<color=#B3FFFFFF>GA</color> Becomes On Target Dead",
                new[] { "<color=#00EEFFFF>Crewmate</color>", "<color=#80B2FFFF>Amnesiac</color>", "<color=#cb81c0>Jester</color>" });
            GATargetKnows =
                new CustomToggleOption(num++, MultiMenu.neutral, "Target Knows <color=#B3FFFFFF>GA</color> Exists", false);
            GAKnowsTargetRole =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#B3FFFFFF>GA</color> Knows Targets Role", false);

            Jester =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#cb81c0>Jester</color>");
            JesterButton =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#cb81c0>Jester</color> Can Button", true);
            JesterVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#cb81c0>Jester</color> Can Hide In Vents", false);
            JesterKill =
                new CustomToggleOption(num++, MultiMenu.neutral, "Enable One Use Kill Button", false);                
            JesterSwitchVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#cb81c0>Jester</color> Can Switch Between Vents", false);                
            JesterImpVision =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#cb81c0>Jester</color> Has Impostor Vision", false);


            Phantom =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#662962FF>Phantom</color>");
            PhantomTasksRemaining =
                 new CustomNumberOption(num++, MultiMenu.neutral, "Tasks Remaining When <color=#662962FF>Phantom</color> Can Be Clicked", 5, 1, 15, 1);

            Arsonist = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FF4D00FF>Arsonist</color>");
            DouseCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Douse Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MaxDoused =
                new CustomNumberOption(num++, MultiMenu.neutral, "Maximum Alive Players Doused", 5, 1, 15, 1);
            ArsoImpVision =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#FF4D00FF>Arsonist</color> Has Impostor Vision", false);               
           ArsoVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#FF4D00FF>Arsonist</color> Can Vent", false);                
            IgniteCdRemoved =
                new CustomToggleOption(num++, MultiMenu.neutral, "Ignite Cooldown Removed When <color=#FF4D00FF>Arsonist</color> Is Last Killer", false);
            TheGlitch =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#00FF00FF>Glitch</color>");
            MimicCooldownOption = new CustomNumberOption(num++, MultiMenu.neutral, "Mimic Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MimicDurationOption = new CustomNumberOption(num++, MultiMenu.neutral, "Mimic Duration", 10f, 1f, 15f, 1f, CooldownFormat);
            HackCooldownOption = new CustomNumberOption(num++, MultiMenu.neutral, "Hack Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            HackDurationOption = new CustomNumberOption(num++, MultiMenu.neutral, "Hack Duration", 10f, 1f, 15f, 1f, CooldownFormat);
            GlitchKillCooldownOption =
                new CustomNumberOption(num++, MultiMenu.neutral, "<color=#00FF00FF>Glitch</color> Kill Cooldown", 25f, 10f, 120f, 2.5f, CooldownFormat);
            GlitchHackDistanceOption =
                new CustomStringOption(num++, MultiMenu.neutral, "<color=#00FF00FF>Glitch</color> Hack Distance", new[] { "Short", "Normal", "Long" });
            GlitchVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#00FF00FF>Glitch</color> Can Vent", false);

            Juggernaut =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#8C004DFF>Juggernaut</color>");
            JuggKillCooldown = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#8C004DFF>Juggernaut</color> Initial Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ReducedKCdPerKill = new CustomNumberOption(num++, MultiMenu.neutral, "Reduced Kill Cooldown Per Kill", 5f, 2.5f, 10f, 2.5f, CooldownFormat);
            JuggVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#8C004DFF>Juggernaut</color> Can Vent", false);

            Plaguebearer = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#E6FFB3FF>Plaguebearer</color>");
            InfectCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "<color=#E6FFB3FF>Plaguebearer</color> Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PlaguebearerVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#E6FFB3FF>Plaguebearer</color> Can Vent", false);           
            PestKillCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "<color=#424242FF>Pestilence</color> Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#424242FF>Pestilence</color> Can Vent", false);

            Werewolf = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#A86629FF>Werewolf</color>");
            RampageCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Rampage Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "Rampage Duration", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageKillCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "<color=#A86629FF>Werewolf</color> Kill Cooldown", 10f, 0.5f, 15f, 0.5f, CooldownFormat);
            WerewolfVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#A86629FF>Werewolf</color> Can Vent", false);

            Cultist =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Cultist</color>"); 
            ReviveCooldown2 =
                new CustomNumberOption(num++, MultiMenu.imposter, "Initial Revive Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            IncreasedCooldownPerRevive2 =
                new CustomNumberOption(num++, MultiMenu.imposter, "Increased Cooldown Per Revive", 25f, 10f, 60f, 2.5f, CooldownFormat);

            Bomber =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Bomber</color>");
            DetonateDelay =
                new CustomNumberOption(num++, MultiMenu.imposter, "Bomb Delay", 5f, 1f, 15f, 1f, CooldownFormat);
            MaxKillsInDetonation =
                new CustomNumberOption(num++, MultiMenu.imposter, "Max Kills In Detonation", 5, 1, 15, 1);
            DetonateRadius =
                new CustomNumberOption(num++, MultiMenu.imposter, "Detonate Radius", 0.25f, 0.05f, 1f, 0.05f, MultiplierFormat);
            BomberVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Bomber</color> Can Vent", false);

            Escapist =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Escapist</color>");
            EscapeCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Recall Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            EscapistVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Escapist</color> Can Vent", false);

            Grenadier =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Grenadier</color>");
            GrenadeCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Flash Grenade Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            GrenadeDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Flash Grenade Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            FlashRadius =
                new CustomNumberOption(num++, MultiMenu.imposter, "Flash Radius", 1f, 0.25f, 5f, 0.25f, MultiplierFormat);
            GrenadierIndicators =
                new CustomToggleOption(num++, MultiMenu.imposter, "Indicate Flashed <color=#00EEFFFF>Crewmates</color>", false);
            GrenadierVent = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Grenadier</color> Can Vent", false);                

            Miner = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Miner</color>");
            MineCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Miner</color> Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);

            Morphling =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Morphling</color>");
            MorphlingCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Morphling</color> Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MorphlingDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Morphling</color> Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            MorphlingVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Morphling</color> Can Vent", false);
            
            Traitor = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Traitor</color>");
            LatestSpawn = new CustomNumberOption(num++, MultiMenu.imposter, "Minimum People Alive When <color=#FF0000FF>Traitor</color> Can Spawn", 5, 3, 15, 1);
            NeutralKillingTraitorSpawn =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Traitor</color> Will Only Spawn If A NK Is Alive", false);
            InformantSeesTraitor = new CustomToggleOption(num++, MultiMenu.imposter, "Informant Sees <color=#FF0000FF>Traitor</color>", true);
            TraitorCanAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Traitor</color> Gets <color=#FF0000FF>Assassin</color> Ability", false);
            TraitorColourSwap =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Traitor</color> Does Not Swap Colours (Snitch)", false);
            
            Undertaker = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Undertaker</color>");
            DragCooldown = new CustomNumberOption(num++, MultiMenu.imposter, "Drag Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            UndertakerDragSpeed =
                new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Undertaker</color> Drag Speed", 0.1f, 0.5f, 2f, 0.5f, MultiplierFormat);

            Silencer = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Silencer</color>");
            SilenceCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Initial <color=#FF0000FF>Silencer</color> Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);

            Swooper = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Swooper</color>");
            SwoopCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Swooper</color> Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            SwoopDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Swoop Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            SwooperVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Swooper</color> Can Vent", false);
            SwooperPolusVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Swooper</color> Can Vent On Polus", false);

            /*ButtonBarry = new CustomHeaderOption(num++, MultiMenu.modifiers, "General <color=#f590bc>Modifier</color> Settings");*/

            Bait = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#f590bc>Bait</color>");
             
            BaitMinDelay = new CustomNumberOption(num++, MultiMenu.modifiers, "Minimum Delay for the <color=#f590bc>Bait</color> Report", 0f, 0f, 15f, 0.5f, CooldownFormat);
            BaitMaxDelay = new CustomNumberOption(num++, MultiMenu.modifiers, "Maximum Delay for the <color=#f590bc>Bait</color> Report", 1f, 0f, 15f, 0.5f, CooldownFormat);

            Diseased = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#f590bc>Diseased</color>");
            DiseasedKillMultiplier = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Diseased</color> Kill Multiplier", 3f, 1.5f, 5f, 0.5f, MultiplierFormat);

            Mini = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#f590bc>Mini</color>");
            MiniSize = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Mini</color> Size", 0.45f, 0.3f, 0.6f, 0.5f, MultiplierFormat);
            MiniSpeed = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Mini</color> Speed", 1.25f, 1.05f, 2.5f, 0.05f, MultiplierFormat);

            Flash = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#f590bc>Flash</color>");
            FlashSpeed = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Flash</color> Speed", 1.25f, 1.05f, 2.5f, 0.05f, MultiplierFormat);

            Giant = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#f590bc>Giant</color>");
            GiantSize = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Giant</color> Size", 0.85f, 0.75f, 1.0f, 0.05f, MultiplierFormat);            
            GiantSlow = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Giant</color> Speed", 0.75f, 0.25f, 1f, 0.05f, MultiplierFormat);


            Lovers =
                new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#e839b9>Lovers</color>");
            BothLoversDie = new CustomToggleOption(num++, MultiMenu.modifiers, "Both <color=#e839b9>Lovers</color> Die");
            LovingImpPercent = new CustomNumberOption(num++, MultiMenu.modifiers, "Loving Impostor Probability", 20f, 0f, 100f, 10f,
                PercentFormat);
            AssassinGuessLovers = new CustomToggleOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Assassin</color> Can Guess <color=#e839b9>Lovers</color>", false);
            NeutralLovers = new CustomToggleOption(num++, MultiMenu.modifiers, "Neutral Roles Can Be <color=#e839b9>Lovers</color>");
            
            Underdog = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#f590bc>Underdog</color>");
            UnderdogKillBonus = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#f590bc>Underdog</color> Kill Cooldown Bonus", 5f, 2.5f, 10f, 2.5f, CooldownFormat);
            UnderdogIncreasedKC = new CustomToggleOption(num++, MultiMenu.modifiers, "<color=#f590bc>Underdog</color> Increased Kill Cooldown When 2+ Imps", true);
        }
    }
}