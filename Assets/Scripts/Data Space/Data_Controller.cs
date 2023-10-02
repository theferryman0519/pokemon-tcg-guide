using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class Data_Controller : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public string UserProfile = "none";
    public string SetChosen = "none";
    public string SubSetTitle = "none";
    public string SubSetChosen = "none";
    public string UpdatedCardName = "none";
	public string UpdatedCardNumber = "none";
	public string UpdatedCardJsonNumber = "none";
	public string UpdatedCardType = "none";

    public Dictionary<string, string> MainSetNames = new Dictionary<string, string>();
    public Dictionary<string, string> MainSetAbbrevs = new Dictionary<string, string>();
    public Dictionary<string, Data_SubSetData> SubSetInfo = new Dictionary<string, Data_SubSetData>();
    public Dictionary<string, Data_SubSetData> SubSetInfoStats = new Dictionary<string, Data_SubSetData>();
    public Dictionary<string, Data_CardData> CardInfo = new Dictionary<string, Data_CardData>();
    public Dictionary<string, Data_CardData> CardInfoStats = new Dictionary<string, Data_CardData>();

	public double UpdatedCardValue = 0.00;

	public int UpdatedCardCareyHave = 0;
	public int UpdatedCardCareyDuplicate = 0;
	public int UpdatedCardKCHave = 0;
	public int UpdatedCardSlotNumber = 0;
    public int AllStatsTracker = 0;

    public Sprite SubSetSprite;
	public Sprite OGS_Base;
	public Sprite OGS_Jungle;
	public Sprite OGS_WizardBlackStarPromos;
	public Sprite OGS_Fossil;
	public Sprite OGS_Base2;
	public Sprite OGS_TeamRocket;
	public Sprite GYM_GymHeroes;
	public Sprite GYM_GymChallenge;
	public Sprite NEO_NeoGenesis;
	public Sprite NEO_NeoDiscovery;
	public Sprite NEO_SouthernIslands;
	public Sprite NEO_NeoRevelation;
	public Sprite NEO_NeoDestiny;
	public Sprite LCS_LegendaryCollection;
	public Sprite EC_Expedition;
	public Sprite EC_Aquapolis;
	public Sprite EC_Skyridge;
	public Sprite EX_RubySapphire;
	public Sprite EX_Sandstorm;
	public Sprite EC_NintendoBlackStarPromos;
	public Sprite EX_Dragon;
	public Sprite EX_TeamMagmaTeamAqua;
	public Sprite EX_HiddenLegends;
	public Sprite EX_FireRedLeafGreen;
	public Sprite EX_PopSeries1;
	public Sprite EX_TeamRocketReturns;
	public Sprite EX_Deoxys;
	public Sprite EX_Emerald;
	public Sprite EX_PopSeries2;
	public Sprite EX_UnseenForces;
	public Sprite EX_DeltaSpecies;
	public Sprite EX_LegendMaker;
	public Sprite EX_PopSeries3;
	public Sprite EX_HolonPhantoms;
	public Sprite EX_PopSeries4;
	public Sprite EX_CrystalGuardians;
	public Sprite EX_DragonFrontiers;
	public Sprite EX_PowerKeepers;
	public Sprite EX_PopSeries5;
	public Sprite DP_DiamondPearl;
	public Sprite DP_DiamondPearlPromos;
	public Sprite DP_MysteriousTreasures;
	public Sprite DP_PopSeries6;
	public Sprite DP_SecretWonders;
	public Sprite DP_GreatEncounters;
	public Sprite DP_PopSeries7;
	public Sprite DP_MajesticDawn;
	public Sprite DP_LegendsAwakened;
	public Sprite DP_PopSeries8;
	public Sprite DP_Stormfront;
	public Sprite PLAT_Platinum;
	public Sprite PLAT_PopSeries9;
	public Sprite PLAT_RisingRivals;
	public Sprite PLAT_SupremeVictors;
	public Sprite PLAT_Arceus;
	public Sprite HGSS_HeartGoldSoulSilver;
	public Sprite HGSS_HeartGoldSoulSilverPromos;
	public Sprite HGSS_Unleashed;
	public Sprite HGSS_Undaunted;
	public Sprite HGSS_Triumphant;
	public Sprite HGSS_CallOfLegends;
	public Sprite BW_BlackWhite;
	public Sprite BW_EmergingPowers;
	public Sprite BW_NobleVictories;
	public Sprite BW_NextDestinies;
	public Sprite BW_DarkExplorers;
	public Sprite BW_DragonsExalted;
	public Sprite BW_DragonVault;
	public Sprite BW_BoundariesCrossed;
	public Sprite BW_PlasmaStorm;
	public Sprite BW_PlasmaFreeze;
	public Sprite BW_PlasmaBlast;
	public Sprite BW_LegendaryTreasures;
	public Sprite XY_KalosStarterSet;
	public Sprite XY_XY;
	public Sprite XY_XYPromos;
	public Sprite XY_Flashfire;
	public Sprite XY_FuriousFists;
	public Sprite XY_PhantomForces;
	public Sprite XY_PrimalClash;
	public Sprite XY_DoubleCrisis;
	public Sprite XY_RoaringSkies;
	public Sprite XY_AncientOrigins;
	public Sprite XY_BreakThrough;
	public Sprite XY_BreakPoint;
	public Sprite XY_Generations;
	public Sprite XY_FatesCollide;
	public Sprite XY_SteamSiege;
	public Sprite XY_Evolutions;
	public Sprite SUMO_SunMoon;
	public Sprite SUMO_SunMoonPromos;
	public Sprite SUMO_GuardiansRising;
	public Sprite SUMO_BurningShadows;
	public Sprite SUMO_ShiningLegends;
	public Sprite SUMO_CrimsonInvasion;
	public Sprite SUMO_UltraPrism;
	public Sprite SUMO_ForbiddenLight;
	public Sprite SUMO_CelestialStorm;
	public Sprite SUMO_DragonMajesty;
	public Sprite SUMO_LostThunder;
	public Sprite SUMO_TeamUp;
	public Sprite SUMO_DetectivePikachu;
	public Sprite SUMO_UnbrokenBonds;
	public Sprite SUMO_UnifiedMinds;
	public Sprite SUMO_HiddenFates;
	public Sprite SUMO_CosmicEclipse;
	public Sprite SWSH_SwordShield;
	public Sprite SWSH_SwordShieldPromos;
	public Sprite SWSH_RebelClash;
	public Sprite SWSH_DarknessAblaze;
	public Sprite SWSH_ChampionsPath;
	public Sprite SWSH_VividVoltage;
	public Sprite SWSH_ShiningFates;
	public Sprite SWSH_BattleStyles;
	public Sprite SWSH_ChillingReign;
	public Sprite SWSH_EvolvingSkies;
	public Sprite SWSH_Celebrations;
	public Sprite SWSH_FusionStrike;
	public Sprite SWSH_BrilliantStars;
	public Sprite SWSH_AstralRadiance;
	public Sprite SWSH_PokemonGo;
	public Sprite SWSH_LostOrigin;
	public Sprite SWSH_SilverTempest;
	public Sprite SWSH_CrownZenith;
	public Sprite SCVI_ScarletViolet;
	public Sprite SCVI_ScarletVioletPromos;
	public Sprite SCVI_PaldeaEvolved;
	public Sprite SCVI_ObsidianFlames;
    public Sprite SCVI_151;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Data_Controller Instance {
        get {
            return Data_Controller_Instance;
        }
    }
    
    private static Data_Controller Data_Controller_Instance = null;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        MainSetNames.Clear();
        MainSetAbbrevs.Clear();
        SubSetInfo.Clear();
        SubSetInfoStats.Clear();
        CardInfo.Clear();
        CardInfoStats.Clear();

		SetMainSetNames();
        SetMainSetAbbrevs();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		if ((Data_Controller_Instance != null) && (Data_Controller_Instance != this)) {
            Destroy(this.gameObject);
            return;
        }
        
        else {
            Data_Controller_Instance = this;
        }
        
        DontDestroyOnLoad(this.gameObject);
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
    public void SetMainSetNames() {
        MainSetNames.Add("Set01", "Original Series");
        MainSetNames.Add("Set02", "Gym Series");
        MainSetNames.Add("Set03", "NEO Series");
        MainSetNames.Add("Set04", "Legendary Collections");
        MainSetNames.Add("Set05", "E-Card Series");
        MainSetNames.Add("Set06", "EX");
        MainSetNames.Add("Set07", "Diamond / Pearl");
        MainSetNames.Add("Set08", "Platinum");
        MainSetNames.Add("Set09", "HeartGold / SoulSilver");
        MainSetNames.Add("Set10", "Black / White");
        MainSetNames.Add("Set11", "X / Y");
        MainSetNames.Add("Set12", "Sun / Moon");
        MainSetNames.Add("Set13", "Sword / Shield");
        MainSetNames.Add("Set14", "Scarlet / Violet");
    }

    public void SetMainSetAbbrevs() {
        MainSetAbbrevs.Add("Set01", "OGS");
        MainSetAbbrevs.Add("Set02", "GYM");
        MainSetAbbrevs.Add("Set03", "NEO");
        MainSetAbbrevs.Add("Set04", "LCS");
        MainSetAbbrevs.Add("Set05", "EC");
        MainSetAbbrevs.Add("Set06", "EX");
        MainSetAbbrevs.Add("Set07", "DP");
        MainSetAbbrevs.Add("Set08", "PLAT");
        MainSetAbbrevs.Add("Set09", "HGSS");
        MainSetAbbrevs.Add("Set10", "BW");
        MainSetAbbrevs.Add("Set11", "XY");
        MainSetAbbrevs.Add("Set12", "SUMO");
        MainSetAbbrevs.Add("Set13", "SWSH");
        MainSetAbbrevs.Add("Set14", "SCVI");
    }

	public void SetSubSetSprite(string SpriteString, Data_SubSetData SubSetData) {
        switch (SpriteString) {
            case "OGS_Base": SubSetData.SubSetSprite = OGS_Base; break;
            case "OGS_Jungle": SubSetData.SubSetSprite = OGS_Jungle; break;
            case "OGS_WizardBlackStarPromos": SubSetData.SubSetSprite = OGS_WizardBlackStarPromos; break;
            case "OGS_Fossil": SubSetData.SubSetSprite = OGS_Fossil; break;
            case "OGS_Base2": SubSetData.SubSetSprite = OGS_Base2; break;
            case "OGS_TeamRocket": SubSetData.SubSetSprite = OGS_TeamRocket; break;
            case "GYM_GymHeroes": SubSetData.SubSetSprite = GYM_GymHeroes; break;
            case "GYM_GymChallenge": SubSetData.SubSetSprite = GYM_GymChallenge; break;
            case "NEO_NeoGenesis": SubSetData.SubSetSprite = NEO_NeoGenesis; break;
            case "NEO_NeoDiscovery": SubSetData.SubSetSprite = NEO_NeoDiscovery; break;
            case "NEO_SouthernIslands": SubSetData.SubSetSprite = NEO_SouthernIslands; break;
            case "NEO_NeoRevelation": SubSetData.SubSetSprite = NEO_NeoRevelation; break;
            case "NEO_NeoDestiny": SubSetData.SubSetSprite = NEO_NeoDestiny; break;
            case "LCS_LegendaryCollection": SubSetData.SubSetSprite = LCS_LegendaryCollection; break;
            case "EC_Expedition": SubSetData.SubSetSprite = EC_Expedition; break;
            case "EC_Aquapolis": SubSetData.SubSetSprite = EC_Aquapolis; break;
            case "EC_Skyridge": SubSetData.SubSetSprite = EC_Skyridge; break;
            case "EX_RubySapphire": SubSetData.SubSetSprite = EX_RubySapphire; break;
            case "EX_Sandstorm": SubSetData.SubSetSprite = EX_Sandstorm; break;
            case "EC_NintendoBlackStarPromos": SubSetData.SubSetSprite = EC_NintendoBlackStarPromos; break;
            case "EX_Dragon": SubSetData.SubSetSprite = EX_Dragon; break;
            case "EX_TeamMagmaTeamAqua": SubSetData.SubSetSprite = EX_TeamMagmaTeamAqua; break;
            case "EX_HiddenLegends": SubSetData.SubSetSprite = EX_HiddenLegends; break;
            case "EX_FireRedLeafGreen": SubSetData.SubSetSprite = EX_FireRedLeafGreen; break;
            case "EX_PopSeries1": SubSetData.SubSetSprite = EX_PopSeries1; break;
            case "EX_TeamRocketReturns": SubSetData.SubSetSprite = EX_TeamRocketReturns; break;
            case "EX_Deoxys": SubSetData.SubSetSprite = EX_Deoxys; break;
            case "EX_Emerald": SubSetData.SubSetSprite = EX_Emerald; break;
            case "EX_PopSeries2": SubSetData.SubSetSprite = EX_PopSeries2; break;
            case "EX_UnseenForces": SubSetData.SubSetSprite = EX_UnseenForces; break;
            case "EX_DeltaSpecies": SubSetData.SubSetSprite = EX_DeltaSpecies; break;
            case "EX_LegendMaker": SubSetData.SubSetSprite = EX_LegendMaker; break;
            case "EX_PopSeries3": SubSetData.SubSetSprite = EX_PopSeries3; break;
            case "EX_HolonPhantoms": SubSetData.SubSetSprite = EX_HolonPhantoms; break;
            case "EX_PopSeries4": SubSetData.SubSetSprite = EX_PopSeries4; break;
            case "EX_CrystalGuardians": SubSetData.SubSetSprite = EX_CrystalGuardians; break;
            case "EX_DragonFrontiers": SubSetData.SubSetSprite = EX_DragonFrontiers; break;
            case "EX_PowerKeepers": SubSetData.SubSetSprite = EX_PowerKeepers; break;
            case "EX_PopSeries5": SubSetData.SubSetSprite = EX_PopSeries5; break;
            case "DP_DiamondPearl": SubSetData.SubSetSprite = DP_DiamondPearl; break;
            case "DP_DiamondPearlPromos": SubSetData.SubSetSprite = DP_DiamondPearlPromos; break;
            case "DP_MysteriousTreasures": SubSetData.SubSetSprite = DP_MysteriousTreasures; break;
            case "DP_PopSeries6": SubSetData.SubSetSprite = DP_PopSeries6; break;
            case "DP_SecretWonders": SubSetData.SubSetSprite = DP_SecretWonders; break;
            case "DP_GreatEncounters": SubSetData.SubSetSprite = DP_GreatEncounters; break;
            case "DP_PopSeries7": SubSetData.SubSetSprite = DP_PopSeries7; break;
            case "DP_MajesticDawn": SubSetData.SubSetSprite = DP_MajesticDawn; break;
            case "DP_LegendsAwakened": SubSetData.SubSetSprite = DP_LegendsAwakened; break;
            case "DP_PopSeries8": SubSetData.SubSetSprite = DP_PopSeries8; break;
            case "DP_Stormfront": SubSetData.SubSetSprite = DP_Stormfront; break;
            case "PLAT_Platinum": SubSetData.SubSetSprite = PLAT_Platinum; break;
            case "PLAT_PopSeries9": SubSetData.SubSetSprite = PLAT_PopSeries9; break;
            case "PLAT_RisingRivals": SubSetData.SubSetSprite = PLAT_RisingRivals; break;
            case "PLAT_SupremeVictors": SubSetData.SubSetSprite = PLAT_SupremeVictors; break;
            case "PLAT_Arceus": SubSetData.SubSetSprite = PLAT_Arceus; break;
            case "HGSS_HeartGoldSoulSilver": SubSetData.SubSetSprite = HGSS_HeartGoldSoulSilver; break;
            case "HGSS_HeartGoldSoulSilverPromos": SubSetData.SubSetSprite = HGSS_HeartGoldSoulSilverPromos; break;
            case "HGSS_Unleashed": SubSetData.SubSetSprite = HGSS_Unleashed; break;
            case "HGSS_Undaunted": SubSetData.SubSetSprite = HGSS_Undaunted; break;
            case "HGSS_Triumphant": SubSetData.SubSetSprite = HGSS_Triumphant; break;
            case "HGSS_CallOfLegends": SubSetData.SubSetSprite = HGSS_CallOfLegends; break;
            case "BW_BlackWhite": SubSetData.SubSetSprite = BW_BlackWhite; break;
            case "BW_EmergingPowers": SubSetData.SubSetSprite = BW_EmergingPowers; break;
            case "BW_NobleVictories": SubSetData.SubSetSprite = BW_NobleVictories; break;
            case "BW_NextDestinies": SubSetData.SubSetSprite = BW_NextDestinies; break;
            case "BW_DarkExplorers": SubSetData.SubSetSprite = BW_DarkExplorers; break;
            case "BW_DragonsExalted": SubSetData.SubSetSprite = BW_DragonsExalted; break;
            case "BW_DragonVault": SubSetData.SubSetSprite = BW_DragonVault; break;
            case "BW_BoundariesCrossed": SubSetData.SubSetSprite = BW_BoundariesCrossed; break;
            case "BW_PlasmaStorm": SubSetData.SubSetSprite = BW_PlasmaStorm; break;
            case "BW_PlasmaFreeze": SubSetData.SubSetSprite = BW_PlasmaFreeze; break;
            case "BW_PlasmaBlast": SubSetData.SubSetSprite = BW_PlasmaBlast; break;
            case "BW_LegendaryTreasures": SubSetData.SubSetSprite = BW_LegendaryTreasures; break;
            case "XY_KalosStarterSet": SubSetData.SubSetSprite = XY_KalosStarterSet; break;
            case "XY_XY": SubSetData.SubSetSprite = XY_XY; break;
            case "XY_XYPromos": SubSetData.SubSetSprite = XY_XYPromos; break;
            case "XY_Flashfire": SubSetData.SubSetSprite = XY_Flashfire; break;
            case "XY_FuriousFists": SubSetData.SubSetSprite = XY_FuriousFists; break;
            case "XY_PhantomForces": SubSetData.SubSetSprite = XY_PhantomForces; break;
            case "XY_PrimalClash": SubSetData.SubSetSprite = XY_PrimalClash; break;
            case "XY_DoubleCrisis": SubSetData.SubSetSprite = XY_DoubleCrisis; break;
            case "XY_RoaringSkies": SubSetData.SubSetSprite = XY_RoaringSkies; break;
            case "XY_AncientOrigins": SubSetData.SubSetSprite = XY_AncientOrigins; break;
            case "XY_BreakThrough": SubSetData.SubSetSprite = XY_BreakThrough; break;
            case "XY_BreakPoint": SubSetData.SubSetSprite = XY_BreakPoint; break;
            case "XY_Generations": SubSetData.SubSetSprite = XY_Generations; break;
            case "XY_FatesCollide": SubSetData.SubSetSprite = XY_FatesCollide; break;
            case "XY_SteamSiege": SubSetData.SubSetSprite = XY_SteamSiege; break;
            case "XY_Evolutions": SubSetData.SubSetSprite = XY_Evolutions; break;
            case "SUMO_SunMoon": SubSetData.SubSetSprite = SUMO_SunMoon; break;
            case "SUMO_SunMoonPromos": SubSetData.SubSetSprite = SUMO_SunMoonPromos; break;
            case "SUMO_GuardiansRising": SubSetData.SubSetSprite = SUMO_GuardiansRising; break;
            case "SUMO_BurningShadows": SubSetData.SubSetSprite = SUMO_BurningShadows; break;
            case "SUMO_ShiningLegends": SubSetData.SubSetSprite = SUMO_ShiningLegends; break;
            case "SUMO_CrimsonInvasion": SubSetData.SubSetSprite = SUMO_CrimsonInvasion; break;
            case "SUMO_UltraPrism": SubSetData.SubSetSprite = SUMO_UltraPrism; break;
            case "SUMO_ForbiddenLight": SubSetData.SubSetSprite = SUMO_ForbiddenLight; break;
            case "SUMO_CelestialStorm": SubSetData.SubSetSprite = SUMO_CelestialStorm; break;
            case "SUMO_DragonMajesty": SubSetData.SubSetSprite = SUMO_DragonMajesty; break;
            case "SUMO_LostThunder": SubSetData.SubSetSprite = SUMO_LostThunder; break;
            case "SUMO_TeamUp": SubSetData.SubSetSprite = SUMO_TeamUp; break;
            case "SUMO_DetectivePikachu": SubSetData.SubSetSprite = SUMO_DetectivePikachu; break;
            case "SUMO_UnbrokenBonds": SubSetData.SubSetSprite = SUMO_UnbrokenBonds; break;
            case "SUMO_UnifiedMinds": SubSetData.SubSetSprite = SUMO_UnifiedMinds; break;
            case "SUMO_HiddenFates": SubSetData.SubSetSprite = SUMO_HiddenFates; break;
            case "SUMO_CosmicEclipse": SubSetData.SubSetSprite = SUMO_CosmicEclipse; break;
            case "SWSH_SwordShield": SubSetData.SubSetSprite = SWSH_SwordShield; break;
            case "SWSH_SwordShieldPromos": SubSetData.SubSetSprite = SWSH_SwordShieldPromos; break;
            case "SWSH_RebelClash": SubSetData.SubSetSprite = SWSH_RebelClash; break;
            case "SWSH_DarknessAblaze": SubSetData.SubSetSprite = SWSH_DarknessAblaze; break;
            case "SWSH_ChampionsPath": SubSetData.SubSetSprite = SWSH_ChampionsPath; break;
            case "SWSH_VividVoltage": SubSetData.SubSetSprite = SWSH_VividVoltage; break;
            case "SWSH_ShiningFates": SubSetData.SubSetSprite = SWSH_ShiningFates; break;
            case "SWSH_BattleStyles": SubSetData.SubSetSprite = SWSH_BattleStyles; break;
            case "SWSH_ChillingReign": SubSetData.SubSetSprite = SWSH_ChillingReign; break;
            case "SWSH_EvolvingSkies": SubSetData.SubSetSprite = SWSH_EvolvingSkies; break;
            case "SWSH_Celebrations": SubSetData.SubSetSprite = SWSH_Celebrations; break;
            case "SWSH_FusionStrike": SubSetData.SubSetSprite = SWSH_FusionStrike; break;
            case "SWSH_BrilliantStars": SubSetData.SubSetSprite = SWSH_BrilliantStars; break;
            case "SWSH_AstralRadiance": SubSetData.SubSetSprite = SWSH_AstralRadiance; break;
            case "SWSH_PokemonGo": SubSetData.SubSetSprite = SWSH_PokemonGo; break;
            case "SWSH_LostOrigin": SubSetData.SubSetSprite = SWSH_LostOrigin; break;
            case "SWSH_SilverTempest": SubSetData.SubSetSprite = SWSH_SilverTempest; break;
            case "SWSH_CrownZenith": SubSetData.SubSetSprite = SWSH_CrownZenith; break;
            case "SCVI_ScarletViolet": SubSetData.SubSetSprite = SCVI_ScarletViolet; break;
            case "SCVI_ScarletVioletPromos": SubSetData.SubSetSprite = SCVI_ScarletVioletPromos; break;
            case "SCVI_PaldeaEvolved": SubSetData.SubSetSprite = SCVI_PaldeaEvolved; break;
            case "SCVI_ObsidianFlames": SubSetData.SubSetSprite = SCVI_ObsidianFlames; break;
            case "SCVI_151": SubSetData.SubSetSprite = SCVI_151; break;
        }
    }
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}