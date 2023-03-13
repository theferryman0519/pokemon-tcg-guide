using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using CoreSpace;
using DataSpace;
using Proyecto26;

namespace SceneSpace {
public class SpecificSetListScene : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image OverlayImage;

	public GameObject CardSetPrefab;
	public GameObject ViewContent;

	public Text TitleText;

	public Button BackButton;

	public string FullSetName;
	public string SubSetString;

	public double FullSetValue;

	public int FullSetInt;

	public List <string> FullSubSetNames = new List<string>();
	
// --------------- PRIVATE VARIABLES ---------------
	Color OverlayOriginal = new Color(0.125f, 0.125f, 0.125f, 1.0f);
	Color OverlayAlpha = new Color(0.125f, 0.125f, 0.125f, 0.0f);

	Button SetCardsButton;
	
// --------------- STATIC VARIABLES ---------------
	public static string CardNumberStrings;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Set Gameplay Buttons
		BackButton.onClick.AddListener(BackButtonClicking);

		// Set Image Colors
		OverlayImage.color = OverlayOriginal;

		// Reset Card Data
		SpecificCardListScene.CardDataNumbers.Clear();
		SpecificCardListScene.CardDataNames.Clear();
		SpecificCardListScene.CardDataValues.Clear();

		// Set Instatiations
		SetTitleText();
		GetSubSetList();
		InstantiateCardSets();

		// Start Coroutine
		StartCoroutine(FadeOverlayOut());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		SetTitleText();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	public IEnumerator FadeOverlayOut() {
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 2.0f) {
			ElapsedTime += Time.deltaTime;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayOriginal, OverlayAlpha, ElapsedTime);
			yield return null;
		}

		OverlayImage.gameObject.SetActive(false);
	}

	public IEnumerator FadeOverlayIn() {
		OverlayImage.gameObject.SetActive(true);
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 2.0f) {
			ElapsedTime += Time.deltaTime;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayAlpha, OverlayOriginal, ElapsedTime);
			yield return null;
		}

		SetCardData();
		SceneManager.LoadScene(SceneChange.Scene04);
	}

	public IEnumerator FadeOverlayInBack() {
		OverlayImage.gameObject.SetActive(true);
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 2.0f) {
			ElapsedTime += Time.deltaTime;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayAlpha, OverlayOriginal, ElapsedTime);
			yield return null;
		}

		SetData.MainSetChoice = "";
		SceneManager.LoadScene(SceneChange.Scene02);
	}
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	public void GetSubSetList() {
		FullSubSetNames.Clear();

		foreach (var FullSetNameKey in SetData.FullSetNames.Keys) {
			if (FullSetNameKey.Contains(FullSetName)) {
				FullSubSetNames.Add(FullSetNameKey);
			}
		}
	}

	public void InstantiateCardSets() {
		ViewContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, (FullSubSetNames.Count * 350));
		int i = 0;

		foreach (var FullSetNameKey in SetData.FullSetNames.Keys) {
			foreach (var SetName in FullSubSetNames) {
				if (FullSetNameKey == SetName) {
					GameObject CardSet = Instantiate(CardSetPrefab, new Vector3(0,0,0), Quaternion.identity);
					CardSet.transform.SetParent(ViewContent.transform);
					CardSet.transform.localScale = Vector2.one;
					i++;
					CardSet.name = FullSetNameKey;
					SubSetString = FullSetNameKey;

					GetSetData();

					CardSet.transform.GetChild(1).GetComponent<Text>().text = SetData.FullSetNames[FullSetNameKey];
					CardSet.transform.GetChild(2).GetComponent<Image>().sprite = SetData.FullSetIconImages[FullSetNameKey];
					CardSet.transform.GetChild(3).GetComponent<Text>().text = "Release Date:" + "\n" + SetData.FullSetDates[FullSetNameKey];
					SetCardsButton = CardSet.transform.GetChild(4).GetComponent<Button>();
					SetCardsButton.onClick.AddListener(() => SetCardsButtonClicking(CardSet.name));
				}
			}
		}
	}

	public void BackButtonClicking() {
		StartCoroutine(FadeOverlayInBack());
	}

	public void SetCardsButtonClicking(string SetNameClicked) {
		SetData.MainCardsChoice = SetNameClicked;
		StartCoroutine(FadeOverlayIn());
	}

	public void SetTitleText() {
		switch (SetData.MainSetChoice) {
			case "Original":
				TitleText.text = "Original Series";
				FullSetName = "OGS_";
				break;
			case "Gym":
				TitleText.text = "Gym Series";
				FullSetName = "GYM_";
				break;
			case "Neo":
				TitleText.text = "Neo Series";
				FullSetName = "NEO_";
				break;
			case "LegendaryCollection":
				TitleText.text = "Legendary Collection Series";
				FullSetName = "LCS_";
				break;
			case "ECard":
				TitleText.text = "E-Card Series";
				FullSetName = "EC_";
				break;
			case "EX":
				TitleText.text = "EX Series";
				FullSetName = "EX_";
				break;
			case "DiamondPearl":
				TitleText.text = "Diamond & Pearl Series";
				FullSetName = "DP_";
				break;
			case "Platinum":
				TitleText.text = "Platinum Series";
				FullSetName = "PLAT_";
				break;
			case "HGSS":
				TitleText.text = "HeartGold & SoulSilver Series";
				FullSetName = "HGSS_";
				break;
			case "BW":
				TitleText.text = "Black & White Series";
				FullSetName = "BW_";
				break;
			case "XY":
				TitleText.text = "X & Y Series";
				FullSetName = "XY_";
				break;
			case "SunMoon":
				TitleText.text = "Sun & Moon Series";
				FullSetName = "SUMO_";
				break;
			case "SwordShield":
				TitleText.text = "Sword & Shield Series";
				FullSetName = "SWSH_";
				break;
			case "ScarletViolet":
				TitleText.text = "Scarlet Violet Series";
				FullSetName = "SCVI_";
				break;
			default:
				TitleText.text = "Series";
				FullSetName = "";
				break;
		}
	}

	public void GetSetData() {
		switch (SubSetString) {
			case "OGS_Base":
				FullSetInt = CardData_OGS_Base.CardDataTotal;
				FullSetValue = CardData_OGS_Base.CardDataTotalValue;
				break;
			case "OGS_Jungle":
				FullSetInt = CardData_OGS_Jungle.CardDataTotal;
				FullSetValue = CardData_OGS_Jungle.CardDataTotalValue;
				break;
			case "OGS_WizardBlackStarPromos":
				FullSetInt = CardData_OGS_WizardBlackStarPromos.CardDataTotal;
				FullSetValue = CardData_OGS_WizardBlackStarPromos.CardDataTotalValue;
				break;
			case "OGS_Base2":
				FullSetInt = CardData_OGS_Base2.CardDataTotal;
				FullSetValue = CardData_OGS_Base2.CardDataTotalValue;
				break;
			case "OGS_Fossil":
				FullSetInt = CardData_OGS_Fossil.CardDataTotal;
				FullSetValue = CardData_OGS_Fossil.CardDataTotalValue;
				break;
			case "OGS_TeamRocket":
				FullSetInt = CardData_OGS_TeamRocket.CardDataTotal;
				FullSetValue = CardData_OGS_TeamRocket.CardDataTotalValue;
				break;
			case "GYM_GymChallenge":
				FullSetInt = CardData_GYM_GymChallenge.CardDataTotal;
				FullSetValue = CardData_GYM_GymChallenge.CardDataTotalValue;
				break;
			case "GYM_GymHeroes":
				FullSetInt = CardData_GYM_GymHeroes.CardDataTotal;
				FullSetValue = CardData_GYM_GymHeroes.CardDataTotalValue;
				break;
			case "NEO_NeoGenesis":
				FullSetInt = CardData_NEO_NeoGenesis.CardDataTotal;
				FullSetValue = CardData_NEO_NeoGenesis.CardDataTotalValue;
				break;
			case "NEO_NeoDiscovery":
				FullSetInt = CardData_NEO_NeoDiscovery.CardDataTotal;
				FullSetValue = CardData_NEO_NeoDiscovery.CardDataTotalValue;
				break;
			case "NEO_NeoRevelation":
				FullSetInt = CardData_NEO_NeoRevelation.CardDataTotal;
				FullSetValue = CardData_NEO_NeoRevelation.CardDataTotalValue;
				break;
			case "NEO_SouthernIslands":
				FullSetInt = CardData_NEO_SouthernIslands.CardDataTotal;
				FullSetValue = CardData_NEO_SouthernIslands.CardDataTotalValue;
				break;
			case "NEO_NeoDestiny":
				FullSetInt = CardData_NEO_NeoDestiny.CardDataTotal;
				FullSetValue = CardData_NEO_NeoDestiny.CardDataTotalValue;
				break;
			case "LCS_LegendaryCollection":
				FullSetInt = CardData_LCS_LegendaryCollection.CardDataTotal;
				FullSetValue = CardData_LCS_LegendaryCollection.CardDataTotalValue;
				break;
			case "BW_BlackWhite":
				FullSetInt = CardData_BW_BlackWhite.CardDataTotal;
				FullSetValue = CardData_BW_BlackWhite.CardDataTotalValue;
				break;
			case "BW_BoundariesCrossed":
				FullSetInt = CardData_BW_BoundariesCrossed.CardDataTotal;
				FullSetValue = CardData_BW_BoundariesCrossed.CardDataTotalValue;
				break;
			case "BW_DarkExplorers":
				FullSetInt = CardData_BW_DarkExplorers.CardDataTotal;
				FullSetValue = CardData_BW_DarkExplorers.CardDataTotalValue;
				break;
			case "BW_DragonsExalted":
				FullSetInt = CardData_BW_DragonsExalted.CardDataTotal;
				FullSetValue = CardData_BW_DragonsExalted.CardDataTotalValue;
				break;
			case "BW_DragonVault":
				FullSetInt = CardData_BW_DragonVault.CardDataTotal;
				FullSetValue = CardData_BW_DragonVault.CardDataTotalValue;
				break;
			case "BW_EmergingPowers":
				FullSetInt = CardData_BW_EmergingPowers.CardDataTotal;
				FullSetValue = CardData_BW_EmergingPowers.CardDataTotalValue;
				break;
			case "BW_LegendaryTreasures":
				FullSetInt = CardData_BW_LegendaryTreasures.CardDataTotal;
				FullSetValue = CardData_BW_LegendaryTreasures.CardDataTotalValue;
				break;
			case "BW_NextDestinies":
				FullSetInt = CardData_BW_NextDestinies.CardDataTotal;
				FullSetValue = CardData_BW_NextDestinies.CardDataTotalValue;
				break;
			case "BW_NobleVictories":
				FullSetInt = CardData_BW_NobleVictories.CardDataTotal;
				FullSetValue = CardData_BW_NobleVictories.CardDataTotalValue;
				break;
			case "BW_PlasmaBlast":
				FullSetInt = CardData_BW_PlasmaBlast.CardDataTotal;
				FullSetValue = CardData_BW_PlasmaBlast.CardDataTotalValue;
				break;
			case "BW_PlasmaFreeze":
				FullSetInt = CardData_BW_PlasmaFreeze.CardDataTotal;
				FullSetValue = CardData_BW_PlasmaFreeze.CardDataTotalValue;
				break;
			case "BW_PlasmaStorm":
				FullSetInt = CardData_BW_PlasmaStorm.CardDataTotal;
				FullSetValue = CardData_BW_PlasmaStorm.CardDataTotalValue;
				break;
			case "DP_DiamondPearl":
				FullSetInt = CardData_DP_DiamondPearl.CardDataTotal;
				FullSetValue = CardData_DP_DiamondPearl.CardDataTotalValue;
				break;
			case "DP_DiamondPearlPromos":
				FullSetInt = CardData_DP_DiamondPearlPromos.CardDataTotal;
				FullSetValue = CardData_DP_DiamondPearlPromos.CardDataTotalValue;
				break;
			case "DP_GreatEncounters":
				FullSetInt = CardData_DP_GreatEncounters.CardDataTotal;
				FullSetValue = CardData_DP_GreatEncounters.CardDataTotalValue;
				break;
			case "DP_LegendsAwakened":
				FullSetInt = CardData_DP_LegendsAwakened.CardDataTotal;
				FullSetValue = CardData_DP_LegendsAwakened.CardDataTotalValue;
				break;
			case "DP_MajesticDawn":
				FullSetInt = CardData_DP_MajesticDawn.CardDataTotal;
				FullSetValue = CardData_DP_MajesticDawn.CardDataTotalValue;
				break;
			case "DP_MysteriousTreasures":
				FullSetInt = CardData_DP_MysteriousTreasures.CardDataTotal;
				FullSetValue = CardData_DP_MysteriousTreasures.CardDataTotalValue;
				break;
			case "DP_PopSeries6":
				FullSetInt = CardData_DP_PopSeries6.CardDataTotal;
				FullSetValue = CardData_DP_PopSeries6.CardDataTotalValue;
				break;
			case "DP_PopSeries7":
				FullSetInt = CardData_DP_PopSeries7.CardDataTotal;
				FullSetValue = CardData_DP_PopSeries7.CardDataTotalValue;
				break;
			case "DP_PopSeries8":
				FullSetInt = CardData_DP_PopSeries8.CardDataTotal;
				FullSetValue = CardData_DP_PopSeries8.CardDataTotalValue;
				break;
			case "DP_SecretWonders":
				FullSetInt = CardData_DP_SecretWonders.CardDataTotal;
				FullSetValue = CardData_DP_SecretWonders.CardDataTotalValue;
				break;
			case "DP_Stormfront":
				FullSetInt = CardData_DP_Stormfront.CardDataTotal;
				FullSetValue = CardData_DP_Stormfront.CardDataTotalValue;
				break;
			case "EC_Aquapolis":
				FullSetInt = CardData_EC_Aquapolis.CardDataTotal;
				FullSetValue = CardData_EC_Aquapolis.CardDataTotalValue;
				break;
			case "EC_Expedition":
				FullSetInt = CardData_EC_Expedition.CardDataTotal;
				FullSetValue = CardData_EC_Expedition.CardDataTotalValue;
				break;
			case "EC_NintendoBlackStarPromos":
				FullSetInt = CardData_EC_NintendoBlackStarPromos.CardDataTotal;
				FullSetValue = CardData_EC_NintendoBlackStarPromos.CardDataTotalValue;
				break;
			case "EC_Skyridge":
				FullSetInt = CardData_EC_Skyridge.CardDataTotal;
				FullSetValue = CardData_EC_Skyridge.CardDataTotalValue;
				break;
			case "EX_CrystalGuardians":
				FullSetInt = CardData_EX_CrystalGuardians.CardDataTotal;
				FullSetValue = CardData_EX_CrystalGuardians.CardDataTotalValue;
				break;
			case "EX_DeltaSpecies":
				FullSetInt = CardData_EX_DeltaSpecies.CardDataTotal;
				FullSetValue = CardData_EX_DeltaSpecies.CardDataTotalValue;
				break;
			case "EX_Deoxys":
				FullSetInt = CardData_EX_Deoxys.CardDataTotal;
				FullSetValue = CardData_EX_Deoxys.CardDataTotalValue;
				break;
			case "EX_Dragon":
				FullSetInt = CardData_EX_Dragon.CardDataTotal;
				FullSetValue = CardData_EX_Dragon.CardDataTotalValue;
				break;
			case "EX_DragonFrontiers":
				FullSetInt = CardData_EX_DragonFrontiers.CardDataTotal;
				FullSetValue = CardData_EX_DragonFrontiers.CardDataTotalValue;
				break;
			case "EX_Emerald":
				FullSetInt = CardData_EX_Emerald.CardDataTotal;
				FullSetValue = CardData_EX_Emerald.CardDataTotalValue;
				break;
			case "EX_FireRedLeafGreen":
				FullSetInt = CardData_EX_FireRedLeafGreen.CardDataTotal;
				FullSetValue = CardData_EX_FireRedLeafGreen.CardDataTotalValue;
				break;
			case "EX_HiddenLegends":
				FullSetInt = CardData_EX_HiddenLegends.CardDataTotal;
				FullSetValue = CardData_EX_HiddenLegends.CardDataTotalValue;
				break;
			case "EX_HolonPhantoms":
				FullSetInt = CardData_EX_HolonPhantoms.CardDataTotal;
				FullSetValue = CardData_EX_HolonPhantoms.CardDataTotalValue;
				break;
			case "EX_LegendMaker":
				FullSetInt = CardData_EX_LegendMaker.CardDataTotal;
				FullSetValue = CardData_EX_LegendMaker.CardDataTotalValue;
				break;
			case "EX_PopSeries1":
				FullSetInt = CardData_EX_PopSeries1.CardDataTotal;
				FullSetValue = CardData_EX_PopSeries1.CardDataTotalValue;
				break;
			case "EX_PopSeries2":
				FullSetInt = CardData_EX_PopSeries2.CardDataTotal;
				FullSetValue = CardData_EX_PopSeries2.CardDataTotalValue;
				break;
			case "EX_PopSeries3":
				FullSetInt = CardData_EX_PopSeries3.CardDataTotal;
				FullSetValue = CardData_EX_PopSeries3.CardDataTotalValue;
				break;
			case "EX_PopSeries4":
				FullSetInt = CardData_EX_PopSeries4.CardDataTotal;
				FullSetValue = CardData_EX_PopSeries4.CardDataTotalValue;
				break;
			case "EX_PopSeries5":
				FullSetInt = CardData_EX_PopSeries5.CardDataTotal;
				FullSetValue = CardData_EX_PopSeries5.CardDataTotalValue;
				break;
			case "EX_PowerKeepers":
				FullSetInt = CardData_EX_PowerKeepers.CardDataTotal;
				FullSetValue = CardData_EX_PowerKeepers.CardDataTotalValue;
				break;
			case "EX_RubySapphire":
				FullSetInt = CardData_EX_RubySapphire.CardDataTotal;
				FullSetValue = CardData_EX_RubySapphire.CardDataTotalValue;
				break;
			case "EX_Sandstorm":
				FullSetInt = CardData_EX_Sandstorm.CardDataTotal;
				FullSetValue = CardData_EX_Sandstorm.CardDataTotalValue;
				break;
			case "EX_TeamMagmaTeamAqua":
				FullSetInt = CardData_EX_TeamMagmaTeamAqua.CardDataTotal;
				FullSetValue = CardData_EX_TeamMagmaTeamAqua.CardDataTotalValue;
				break;
			case "EX_TeamRocketReturns":
				FullSetInt = CardData_EX_TeamRocketReturns.CardDataTotal;
				FullSetValue = CardData_EX_TeamRocketReturns.CardDataTotalValue;
				break;
			case "EX_UnseenForces":
				FullSetInt = CardData_EX_UnseenForces.CardDataTotal;
				FullSetValue = CardData_EX_UnseenForces.CardDataTotalValue;
				break;
			case "HGSS_CallOfLegends":
				FullSetInt = CardData_HGSS_CallOfLegends.CardDataTotal;
				FullSetValue = CardData_HGSS_CallOfLegends.CardDataTotalValue;
				break;
			case "HGSS_HeartGoldSoulSilver":
				FullSetInt = CardData_HGSS_HeartGoldSoulSilver.CardDataTotal;
				FullSetValue = CardData_HGSS_HeartGoldSoulSilver.CardDataTotalValue;
				break;
			case "HGSS_HeartGoldSoulSilverPromos":
				FullSetInt = CardData_HGSS_HeartGoldSoulSilverPromos.CardDataTotal;
				FullSetValue = CardData_HGSS_HeartGoldSoulSilverPromos.CardDataTotalValue;
				break;
			case "HGSS_Triumphant":
				FullSetInt = CardData_HGSS_Triumphant.CardDataTotal;
				FullSetValue = CardData_HGSS_Triumphant.CardDataTotalValue;
				break;
			case "HGSS_Undaunted":
				FullSetInt = CardData_HGSS_Undaunted.CardDataTotal;
				FullSetValue = CardData_HGSS_Undaunted.CardDataTotalValue;
				break;
			case "HGSS_Unleashed":
				FullSetInt = CardData_HGSS_Unleashed.CardDataTotal;
				FullSetValue = CardData_HGSS_Unleashed.CardDataTotalValue;
				break;
			case "PLAT_Arceus":
				FullSetInt = CardData_PLAT_Arceus.CardDataTotal;
				FullSetValue = CardData_PLAT_Arceus.CardDataTotalValue;
				break;
			case "PLAT_Platinum":
				FullSetInt = CardData_PLAT_Platinum.CardDataTotal;
				FullSetValue = CardData_PLAT_Platinum.CardDataTotalValue;
				break;
			case "PLAT_PopSeries9":
				FullSetInt = CardData_PLAT_PopSeries9.CardDataTotal;
				FullSetValue = CardData_PLAT_PopSeries9.CardDataTotalValue;
				break;
			case "PLAT_RisingRivals":
				FullSetInt = CardData_PLAT_RisingRivals.CardDataTotal;
				FullSetValue = CardData_PLAT_RisingRivals.CardDataTotalValue;
				break;
			case "PLAT_SupremeVictors":
				FullSetInt = CardData_PLAT_SupremeVictors.CardDataTotal;
				FullSetValue = CardData_PLAT_SupremeVictors.CardDataTotalValue;
				break;
			case "SUMO_BurningShadows":
				FullSetInt = CardData_SUMO_BurningShadows.CardDataTotal;
				FullSetValue = CardData_SUMO_BurningShadows.CardDataTotalValue;
				break;
			case "SUMO_CelestialStorm":
				FullSetInt = CardData_SUMO_CelestialStorm.CardDataTotal;
				FullSetValue = CardData_SUMO_CelestialStorm.CardDataTotalValue;
				break;
			case "SUMO_CosmicEclipse":
				FullSetInt = CardData_SUMO_CosmicEclipse.CardDataTotal;
				FullSetValue = CardData_SUMO_CosmicEclipse.CardDataTotalValue;
				break;
			case "SUMO_CrimsonInvasion":
				FullSetInt = CardData_SUMO_CrimsonInvasion.CardDataTotal;
				FullSetValue = CardData_SUMO_CrimsonInvasion.CardDataTotalValue;
				break;
			case "SUMO_DetectivePikachu":
				FullSetInt = CardData_SUMO_DetectivePikachu.CardDataTotal;
				FullSetValue = CardData_SUMO_DetectivePikachu.CardDataTotalValue;
				break;
			case "SUMO_DragonMajesty":
				FullSetInt = CardData_SUMO_DragonMajesty.CardDataTotal;
				FullSetValue = CardData_SUMO_DragonMajesty.CardDataTotalValue;
				break;
			case "SUMO_ForbiddenLight":
				FullSetInt = CardData_SUMO_ForbiddenLight.CardDataTotal;
				FullSetValue = CardData_SUMO_ForbiddenLight.CardDataTotalValue;
				break;
			case "SUMO_GuardiansRising":
				FullSetInt = CardData_SUMO_GuardiansRising.CardDataTotal;
				FullSetValue = CardData_SUMO_GuardiansRising.CardDataTotalValue;
				break;
			case "SUMO_HiddenFates":
				FullSetInt = CardData_SUMO_HiddenFates.CardDataTotal;
				FullSetValue = CardData_SUMO_HiddenFates.CardDataTotalValue;
				break;
			case "SUMO_LostThunder":
				FullSetInt = CardData_SUMO_LostThunder.CardDataTotal;
				FullSetValue = CardData_SUMO_LostThunder.CardDataTotalValue;
				break;
			case "SUMO_ShiningLegends":
				FullSetInt = CardData_SUMO_ShiningLegends.CardDataTotal;
				FullSetValue = CardData_SUMO_ShiningLegends.CardDataTotalValue;
				break;
			case "SUMO_SunMoon":
				FullSetInt = CardData_SUMO_SunMoon.CardDataTotal;
				FullSetValue = CardData_SUMO_SunMoon.CardDataTotalValue;
				break;
			case "SUMO_SunMoonPromos":
				FullSetInt = CardData_SUMO_SunMoonPromos.CardDataTotal;
				FullSetValue = CardData_SUMO_SunMoonPromos.CardDataTotalValue;
				break;
			case "SUMO_TeamUp":
				FullSetInt = CardData_SUMO_TeamUp.CardDataTotal;
				FullSetValue = CardData_SUMO_TeamUp.CardDataTotalValue;
				break;
			case "SUMO_UltraPrism":
				FullSetInt = CardData_SUMO_UltraPrism.CardDataTotal;
				FullSetValue = CardData_SUMO_UltraPrism.CardDataTotalValue;
				break;
			case "SUMO_UnbrokenBonds":
				FullSetInt = CardData_SUMO_UnbrokenBonds.CardDataTotal;
				FullSetValue = CardData_SUMO_UnbrokenBonds.CardDataTotalValue;
				break;
			case "SUMO_UnifiedMinds":
				FullSetInt = CardData_SUMO_UnifiedMinds.CardDataTotal;
				FullSetValue = CardData_SUMO_UnifiedMinds.CardDataTotalValue;
				break;
			case "SWSH_AstralRadiance":
				FullSetInt = CardData_SWSH_AstralRadiance.CardDataTotal;
				FullSetValue = CardData_SWSH_AstralRadiance.CardDataTotalValue;
				break;
			case "SWSH_BattleStyles":
				FullSetInt = CardData_SWSH_BattleStyles.CardDataTotal;
				FullSetValue = CardData_SWSH_BattleStyles.CardDataTotalValue;
				break;
			case "SWSH_BrilliantStars":
				FullSetInt = CardData_SWSH_BrilliantStars.CardDataTotal;
				FullSetValue = CardData_SWSH_BrilliantStars.CardDataTotalValue;
				break;
			case "SWSH_Celebrations":
				FullSetInt = CardData_SWSH_Celebrations.CardDataTotal;
				FullSetValue = CardData_SWSH_Celebrations.CardDataTotalValue;
				break;
			case "SWSH_ChampionsPath":
				FullSetInt = CardData_SWSH_ChampionsPath.CardDataTotal;
				FullSetValue = CardData_SWSH_ChampionsPath.CardDataTotalValue;
				break;
			case "SWSH_ChillingReign":
				FullSetInt = CardData_SWSH_ChillingReign.CardDataTotal;
				FullSetValue = CardData_SWSH_ChillingReign.CardDataTotalValue;
				break;
			case "SWSH_CrownZenith":
				FullSetInt = CardData_SWSH_CrownZenith.CardDataTotal;
				FullSetValue = CardData_SWSH_CrownZenith.CardDataTotalValue;
				break;
			case "SWSH_DarknessAblaze":
				FullSetInt = CardData_SWSH_DarknessAblaze.CardDataTotal;
				FullSetValue = CardData_SWSH_DarknessAblaze.CardDataTotalValue;
				break;
			case "SWSH_EvolvingSkies":
				FullSetInt = CardData_SWSH_EvolvingSkies.CardDataTotal;
				FullSetValue = CardData_SWSH_EvolvingSkies.CardDataTotalValue;
				break;
			case "SWSH_FusionStrike":
				FullSetInt = CardData_SWSH_FusionStrike.CardDataTotal;
				FullSetValue = CardData_SWSH_FusionStrike.CardDataTotalValue;
				break;
			case "SWSH_LostOrigin":
				FullSetInt = CardData_SWSH_LostOrigin.CardDataTotal;
				FullSetValue = CardData_SWSH_LostOrigin.CardDataTotalValue;
				break;
			case "SWSH_PokemonGo":
				FullSetInt = CardData_SWSH_PokemonGo.CardDataTotal;
				FullSetValue = CardData_SWSH_PokemonGo.CardDataTotalValue;
				break;
			case "SWSH_RebelClash":
				FullSetInt = CardData_SWSH_RebelClash.CardDataTotal;
				FullSetValue = CardData_SWSH_RebelClash.CardDataTotalValue;
				break;
			case "SWSH_ShiningFates":
				FullSetInt = CardData_SWSH_ShiningFates.CardDataTotal;
				FullSetValue = CardData_SWSH_ShiningFates.CardDataTotalValue;
				break;
			case "SWSH_SilverTempest":
				FullSetInt = CardData_SWSH_SilverTempest.CardDataTotal;
				FullSetValue = CardData_SWSH_SilverTempest.CardDataTotalValue;
				break;
			case "SWSH_SwordShield":
				FullSetInt = CardData_SWSH_SwordShield.CardDataTotal;
				FullSetValue = CardData_SWSH_SwordShield.CardDataTotalValue;
				break;
			case "SWSH_SwordShieldPromos":
				FullSetInt = CardData_SWSH_SwordShieldPromos.CardDataTotal;
				FullSetValue = CardData_SWSH_SwordShieldPromos.CardDataTotalValue;
				break;
			case "SWSH_VividVoltage":
				FullSetInt = CardData_SWSH_VividVoltage.CardDataTotal;
				FullSetValue = CardData_SWSH_VividVoltage.CardDataTotalValue;
				break;
			case "XY_AncientOrigins":
				FullSetInt = CardData_XY_AncientOrigins.CardDataTotal;
				FullSetValue = CardData_XY_AncientOrigins.CardDataTotalValue;
				break;
			case "XY_BreakPoint":
				FullSetInt = CardData_XY_BreakPoint.CardDataTotal;
				FullSetValue = CardData_XY_BreakPoint.CardDataTotalValue;
				break;
			case "XY_BreakThrough":
				FullSetInt = CardData_XY_BreakThrough.CardDataTotal;
				FullSetValue = CardData_XY_BreakThrough.CardDataTotalValue;
				break;
			case "XY_DoubleCrisis":
				FullSetInt = CardData_XY_DoubleCrisis.CardDataTotal;
				FullSetValue = CardData_XY_DoubleCrisis.CardDataTotalValue;
				break;
			case "XY_Evolutions":
				FullSetInt = CardData_XY_Evolutions.CardDataTotal;
				FullSetValue = CardData_XY_Evolutions.CardDataTotalValue;
				break;
			case "XY_FatesCollide":
				FullSetInt = CardData_XY_FatesCollide.CardDataTotal;
				FullSetValue = CardData_XY_FatesCollide.CardDataTotalValue;
				break;
			case "XY_Flashfire":
				FullSetInt = CardData_XY_Flashfire.CardDataTotal;
				FullSetValue = CardData_XY_Flashfire.CardDataTotalValue;
				break;
			case "XY_FuriousFists":
				FullSetInt = CardData_XY_FuriousFists.CardDataTotal;
				FullSetValue = CardData_XY_FuriousFists.CardDataTotalValue;
				break;
			case "XY_Generations":
				FullSetInt = CardData_XY_Generations.CardDataTotal;
				FullSetValue = CardData_XY_Generations.CardDataTotalValue;
				break;
			case "XY_KalosStarterSet":
				FullSetInt = CardData_XY_KalosStarterSet.CardDataTotal;
				FullSetValue = CardData_XY_KalosStarterSet.CardDataTotalValue;
				break;
			case "XY_PhantomForces":
				FullSetInt = CardData_XY_PhantomForces.CardDataTotal;
				FullSetValue = CardData_XY_PhantomForces.CardDataTotalValue;
				break;
			case "XY_PrimalClash":
				FullSetInt = CardData_XY_PrimalClash.CardDataTotal;
				FullSetValue = CardData_XY_PrimalClash.CardDataTotalValue;
				break;
			case "XY_RoaringSkies":
				FullSetInt = CardData_XY_RoaringSkies.CardDataTotal;
				FullSetValue = CardData_XY_RoaringSkies.CardDataTotalValue;
				break;
			case "XY_SteamSiege":
				FullSetInt = CardData_XY_SteamSiege.CardDataTotal;
				FullSetValue = CardData_XY_SteamSiege.CardDataTotalValue;
				break;
			case "XY_XY":
				FullSetInt = CardData_XY_XY.CardDataTotal;
				FullSetValue = CardData_XY_XY.CardDataTotalValue;
				break;
			case "XY_XYPromos":
				FullSetInt = CardData_XY_XYPromos.CardDataTotal;
				FullSetValue = CardData_XY_XYPromos.CardDataTotalValue;
				break;
			case "SCVI_ScarletViolet":
				FullSetInt = CardData_SCVI_ScarletViolet.CardDataTotal;
				FullSetValue = CardData_SCVI_ScarletViolet.CardDataTotalValue;
				break;
			default:
				FullSetInt = 0;
				FullSetValue = 0;
				break;
		}
	}

	public void SetCardData() {
		switch (SetData.MainCardsChoice) {
			case "OGS_Base":
				foreach (KeyValuePair<int, string> CardNumber in CardData_OGS_Base.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_OGS_Base.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_OGS_Base.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "OGS_Jungle":
				foreach (KeyValuePair<int, string> CardNumber in CardData_OGS_Jungle.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_OGS_Jungle.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_OGS_Jungle.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "OGS_WizardBlackStarPromos":
				foreach (KeyValuePair<int, string> CardNumber in CardData_OGS_WizardBlackStarPromos.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_OGS_WizardBlackStarPromos.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_OGS_WizardBlackStarPromos.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "OGS_Base2":
				foreach (KeyValuePair<int, string> CardNumber in CardData_OGS_Base2.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_OGS_Base2.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_OGS_Base2.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "OGS_Fossil":
				foreach (KeyValuePair<int, string> CardNumber in CardData_OGS_Fossil.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_OGS_Fossil.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_OGS_Fossil.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "OGS_TeamRocket":
				foreach (KeyValuePair<int, string> CardNumber in CardData_OGS_TeamRocket.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_OGS_TeamRocket.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_OGS_TeamRocket.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "GYM_GymChallenge":
				foreach (KeyValuePair<int, string> CardNumber in CardData_GYM_GymChallenge.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_GYM_GymChallenge.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_GYM_GymChallenge.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "GYM_GymHeroes":
				foreach (KeyValuePair<int, string> CardNumber in CardData_GYM_GymHeroes.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_GYM_GymHeroes.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_GYM_GymHeroes.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "NEO_NeoGenesis":
				foreach (KeyValuePair<int, string> CardNumber in CardData_NEO_NeoGenesis.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_NEO_NeoGenesis.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_NEO_NeoGenesis.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "NEO_NeoDiscovery":
				foreach (KeyValuePair<int, string> CardNumber in CardData_NEO_NeoDiscovery.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_NEO_NeoDiscovery.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_NEO_NeoDiscovery.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "NEO_NeoRevelation":
				foreach (KeyValuePair<int, string> CardNumber in CardData_NEO_NeoRevelation.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_NEO_NeoRevelation.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_NEO_NeoRevelation.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "NEO_SouthernIslands":
				foreach (KeyValuePair<int, string> CardNumber in CardData_NEO_SouthernIslands.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_NEO_SouthernIslands.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_NEO_SouthernIslands.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "NEO_NeoDestiny":
				foreach (KeyValuePair<int, string> CardNumber in CardData_NEO_NeoDestiny.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_NEO_NeoDestiny.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_NEO_NeoDestiny.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "LCS_LegendaryCollection":
				foreach (KeyValuePair<int, string> CardNumber in CardData_LCS_LegendaryCollection.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_LCS_LegendaryCollection.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_LCS_LegendaryCollection.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "BW_BlackWhite":
				foreach (KeyValuePair<int, string> CardNumber in CardData_BW_BlackWhite.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_BW_BlackWhite.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_BW_BlackWhite.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "BW_BoundariesCrossed":
				foreach (KeyValuePair<int, string> CardNumber in CardData_BW_BoundariesCrossed.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_BW_BoundariesCrossed.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_BW_BoundariesCrossed.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "BW_DarkExplorers":
				foreach (KeyValuePair<int, string> CardNumber in CardData_BW_DarkExplorers.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_BW_DarkExplorers.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_BW_DarkExplorers.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "BW_DragonsExalted":
				foreach (KeyValuePair<int, string> CardNumber in CardData_BW_DragonsExalted.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_BW_DragonsExalted.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_BW_DragonsExalted.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "BW_DragonVault":
				foreach (KeyValuePair<int, string> CardNumber in CardData_BW_DragonVault.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_BW_DragonVault.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_BW_DragonVault.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "BW_EmergingPowers":
				foreach (KeyValuePair<int, string> CardNumber in CardData_BW_EmergingPowers.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_BW_EmergingPowers.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_BW_EmergingPowers.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "BW_LegendaryTreasures":
				foreach (KeyValuePair<int, string> CardNumber in CardData_BW_LegendaryTreasures.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_BW_LegendaryTreasures.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_BW_LegendaryTreasures.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "BW_NextDestinies":
				foreach (KeyValuePair<int, string> CardNumber in CardData_BW_NextDestinies.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_BW_NextDestinies.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_BW_NextDestinies.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "BW_NobleVictories":
				foreach (KeyValuePair<int, string> CardNumber in CardData_BW_NobleVictories.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_BW_NobleVictories.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_BW_NobleVictories.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "BW_PlasmaBlast":
				foreach (KeyValuePair<int, string> CardNumber in CardData_BW_PlasmaBlast.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_BW_PlasmaBlast.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_BW_PlasmaBlast.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "BW_PlasmaFreeze":
				foreach (KeyValuePair<int, string> CardNumber in CardData_BW_PlasmaFreeze.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_BW_PlasmaFreeze.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_BW_PlasmaFreeze.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "BW_PlasmaStorm":
				foreach (KeyValuePair<int, string> CardNumber in CardData_BW_PlasmaStorm.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_BW_PlasmaStorm.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_BW_PlasmaStorm.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "DP_DiamondPearl":
				foreach (KeyValuePair<int, string> CardNumber in CardData_DP_DiamondPearl.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_DP_DiamondPearl.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_DP_DiamondPearl.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "DP_DiamondPearlPromos":
				foreach (KeyValuePair<int, string> CardNumber in CardData_DP_DiamondPearlPromos.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_DP_DiamondPearlPromos.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_DP_DiamondPearlPromos.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "DP_GreatEncounters":
				foreach (KeyValuePair<int, string> CardNumber in CardData_DP_GreatEncounters.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_DP_GreatEncounters.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_DP_GreatEncounters.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "DP_LegendsAwakened":
				foreach (KeyValuePair<int, string> CardNumber in CardData_DP_LegendsAwakened.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_DP_LegendsAwakened.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_DP_LegendsAwakened.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "DP_MajesticDawn":
				foreach (KeyValuePair<int, string> CardNumber in CardData_DP_MajesticDawn.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_DP_MajesticDawn.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_DP_MajesticDawn.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "DP_MysteriousTreasures":
				foreach (KeyValuePair<int, string> CardNumber in CardData_DP_MysteriousTreasures.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_DP_MysteriousTreasures.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_DP_MysteriousTreasures.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "DP_PopSeries6":
				foreach (KeyValuePair<int, string> CardNumber in CardData_DP_PopSeries6.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_DP_PopSeries6.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_DP_PopSeries6.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "DP_PopSeries7":
				foreach (KeyValuePair<int, string> CardNumber in CardData_DP_PopSeries7.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_DP_PopSeries7.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_DP_PopSeries7.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "DP_PopSeries8":
				foreach (KeyValuePair<int, string> CardNumber in CardData_DP_PopSeries8.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_DP_PopSeries8.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_DP_PopSeries8.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "DP_SecretWonders":
				foreach (KeyValuePair<int, string> CardNumber in CardData_DP_SecretWonders.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_DP_SecretWonders.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_DP_SecretWonders.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "DP_Stormfront":
				foreach (KeyValuePair<int, string> CardNumber in CardData_DP_Stormfront.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_DP_Stormfront.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_DP_Stormfront.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EC_Aquapolis":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EC_Aquapolis.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EC_Aquapolis.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EC_Aquapolis.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EC_Expedition":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EC_Expedition.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EC_Expedition.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EC_Expedition.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EC_NintendoBlackStarPromos":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EC_NintendoBlackStarPromos.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EC_NintendoBlackStarPromos.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EC_NintendoBlackStarPromos.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EC_Skyridge":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EC_Skyridge.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EC_Skyridge.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EC_Skyridge.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_CrystalGuardians":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_CrystalGuardians.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_CrystalGuardians.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_CrystalGuardians.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_DeltaSpecies":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_DeltaSpecies.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_DeltaSpecies.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_DeltaSpecies.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_Deoxys":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_Deoxys.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_Deoxys.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_Deoxys.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_Dragon":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_Dragon.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_Dragon.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_Dragon.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_DragonFrontiers":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_DragonFrontiers.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_DragonFrontiers.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_DragonFrontiers.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_Emerald":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_Emerald.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_Emerald.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_Emerald.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_FireRedLeafGreen":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_FireRedLeafGreen.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_FireRedLeafGreen.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_FireRedLeafGreen.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_HiddenLegends":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_HiddenLegends.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_HiddenLegends.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_HiddenLegends.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_HolonPhantoms":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_HolonPhantoms.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_HolonPhantoms.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_HolonPhantoms.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_LegendMaker":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_LegendMaker.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_LegendMaker.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_LegendMaker.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_PopSeries1":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_PopSeries1.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_PopSeries1.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_PopSeries1.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_PopSeries2":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_PopSeries2.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_PopSeries2.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_PopSeries2.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_PopSeries3":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_PopSeries3.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_PopSeries3.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_PopSeries3.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_PopSeries4":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_PopSeries4.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_PopSeries4.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_PopSeries4.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_PopSeries5":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_PopSeries5.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_PopSeries5.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_PopSeries5.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_PowerKeepers":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_PowerKeepers.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_PowerKeepers.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_PowerKeepers.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_RubySapphire":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_RubySapphire.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_RubySapphire.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_RubySapphire.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_Sandstorm":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_Sandstorm.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_Sandstorm.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_Sandstorm.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_TeamMagmaTeamAqua":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_TeamMagmaTeamAqua.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_TeamMagmaTeamAqua.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_TeamMagmaTeamAqua.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_TeamRocketReturns":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_TeamRocketReturns.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_TeamRocketReturns.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_TeamRocketReturns.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "EX_UnseenForces":
				foreach (KeyValuePair<int, string> CardNumber in CardData_EX_UnseenForces.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_EX_UnseenForces.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_EX_UnseenForces.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "HGSS_CallOfLegends":
				foreach (KeyValuePair<int, string> CardNumber in CardData_HGSS_CallOfLegends.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_HGSS_CallOfLegends.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_HGSS_CallOfLegends.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "HGSS_HeartGoldSoulSilver":
				foreach (KeyValuePair<int, string> CardNumber in CardData_HGSS_HeartGoldSoulSilver.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_HGSS_HeartGoldSoulSilver.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_HGSS_HeartGoldSoulSilver.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "HGSS_HeartGoldSoulSilverPromos":
				foreach (KeyValuePair<int, string> CardNumber in CardData_HGSS_HeartGoldSoulSilverPromos.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_HGSS_HeartGoldSoulSilverPromos.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_HGSS_HeartGoldSoulSilverPromos.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "HGSS_Triumphant":
				foreach (KeyValuePair<int, string> CardNumber in CardData_HGSS_Triumphant.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_HGSS_Triumphant.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_HGSS_Triumphant.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "HGSS_Undaunted":
				foreach (KeyValuePair<int, string> CardNumber in CardData_HGSS_Undaunted.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_HGSS_Undaunted.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_HGSS_Undaunted.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "HGSS_Unleashed":
				foreach (KeyValuePair<int, string> CardNumber in CardData_HGSS_Unleashed.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_HGSS_Unleashed.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_HGSS_Unleashed.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "PLAT_Arceus":
				foreach (KeyValuePair<int, string> CardNumber in CardData_PLAT_Arceus.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_PLAT_Arceus.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_PLAT_Arceus.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "PLAT_Platinum":
				foreach (KeyValuePair<int, string> CardNumber in CardData_PLAT_Platinum.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_PLAT_Platinum.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_PLAT_Platinum.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "PLAT_PopSeries9":
				foreach (KeyValuePair<int, string> CardNumber in CardData_PLAT_PopSeries9.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_PLAT_PopSeries9.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_PLAT_PopSeries9.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "PLAT_RisingRivals":
				foreach (KeyValuePair<int, string> CardNumber in CardData_PLAT_RisingRivals.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_PLAT_RisingRivals.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_PLAT_RisingRivals.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "PLAT_SupremeVictors":
				foreach (KeyValuePair<int, string> CardNumber in CardData_PLAT_SupremeVictors.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_PLAT_SupremeVictors.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_PLAT_SupremeVictors.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_BurningShadows":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_BurningShadows.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_BurningShadows.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_BurningShadows.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_CelestialStorm":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_CelestialStorm.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_CelestialStorm.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_CelestialStorm.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_CosmicEclipse":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_CosmicEclipse.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_CosmicEclipse.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_CosmicEclipse.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_CrimsonInvasion":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_CrimsonInvasion.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_CrimsonInvasion.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_CrimsonInvasion.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_DetectivePikachu":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_DetectivePikachu.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_DetectivePikachu.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_DetectivePikachu.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_DragonMajesty":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_DragonMajesty.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_DragonMajesty.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_DragonMajesty.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_ForbiddenLight":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_ForbiddenLight.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_ForbiddenLight.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_ForbiddenLight.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_GuardiansRising":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_GuardiansRising.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_GuardiansRising.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_GuardiansRising.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_HiddenFates":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_HiddenFates.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_HiddenFates.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_HiddenFates.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_LostThunder":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_LostThunder.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_LostThunder.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_LostThunder.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_ShiningLegends":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_ShiningLegends.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_ShiningLegends.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_ShiningLegends.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_SunMoon":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_SunMoon.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_SunMoon.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_SunMoon.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_SunMoonPromos":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_SunMoonPromos.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_SunMoonPromos.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_SunMoonPromos.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_TeamUp":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_TeamUp.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_TeamUp.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_TeamUp.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_UltraPrism":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_UltraPrism.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_UltraPrism.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_UltraPrism.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_UnbrokenBonds":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_UnbrokenBonds.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_UnbrokenBonds.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_UnbrokenBonds.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SUMO_UnifiedMinds":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SUMO_UnifiedMinds.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SUMO_UnifiedMinds.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SUMO_UnifiedMinds.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_AstralRadiance":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_AstralRadiance.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_AstralRadiance.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_AstralRadiance.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_BattleStyles":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_BattleStyles.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_BattleStyles.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_BattleStyles.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_BrilliantStars":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_BrilliantStars.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_BrilliantStars.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_BrilliantStars.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_Celebrations":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_Celebrations.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_Celebrations.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_Celebrations.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_ChampionsPath":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_ChampionsPath.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_ChampionsPath.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_ChampionsPath.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_ChillingReign":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_ChillingReign.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_ChillingReign.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_ChillingReign.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_CrownZenith":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_CrownZenith.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_CrownZenith.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_CrownZenith.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_DarknessAblaze":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_DarknessAblaze.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_DarknessAblaze.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_DarknessAblaze.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_EvolvingSkies":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_EvolvingSkies.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_EvolvingSkies.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_EvolvingSkies.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_FusionStrike":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_FusionStrike.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_FusionStrike.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_FusionStrike.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_LostOrigin":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_LostOrigin.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_LostOrigin.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_LostOrigin.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_PokemonGo":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_PokemonGo.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_PokemonGo.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_PokemonGo.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_RebelClash":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_RebelClash.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_RebelClash.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_RebelClash.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_ShiningFates":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_ShiningFates.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_ShiningFates.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_ShiningFates.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_SilverTempest":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_SilverTempest.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_SilverTempest.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_SilverTempest.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_SwordShield":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_SwordShield.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_SwordShield.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_SwordShield.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_SwordShieldPromos":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_SwordShieldPromos.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_SwordShieldPromos.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_SwordShieldPromos.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SWSH_VividVoltage":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SWSH_VividVoltage.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SWSH_VividVoltage.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SWSH_VividVoltage.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_AncientOrigins":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_AncientOrigins.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_AncientOrigins.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_AncientOrigins.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_BreakPoint":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_BreakPoint.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_BreakPoint.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_BreakPoint.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_BreakThrough":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_BreakThrough.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_BreakThrough.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_BreakThrough.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_DoubleCrisis":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_DoubleCrisis.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_DoubleCrisis.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_DoubleCrisis.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_Evolutions":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_Evolutions.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_Evolutions.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_Evolutions.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_FatesCollide":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_FatesCollide.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_FatesCollide.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_FatesCollide.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_Flashfire":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_Flashfire.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_Flashfire.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_Flashfire.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_FuriousFists":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_FuriousFists.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_FuriousFists.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_FuriousFists.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_Generations":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_Generations.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_Generations.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_Generations.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_KalosStarterSet":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_KalosStarterSet.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_KalosStarterSet.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_KalosStarterSet.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_PhantomForces":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_PhantomForces.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_PhantomForces.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_PhantomForces.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_PrimalClash":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_PrimalClash.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_PrimalClash.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_PrimalClash.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_RoaringSkies":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_RoaringSkies.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_RoaringSkies.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_RoaringSkies.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_SteamSiege":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_SteamSiege.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_SteamSiege.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_SteamSiege.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_XY":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_XY.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_XY.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_XY.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "XY_XYPromos":
				foreach (KeyValuePair<int, string> CardNumber in CardData_XY_XYPromos.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_XY_XYPromos.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_XY_XYPromos.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			case "SCVI_ScarletViolet":
				foreach (KeyValuePair<int, string> CardNumber in CardData_SCVI_ScarletViolet.CardDataNumbers) {
					SpecificCardListScene.CardDataNumbers.Add(CardNumber.Key, CardNumber.Value);
				}

				foreach (KeyValuePair<int, string> CardName in CardData_SCVI_ScarletViolet.CardDataNames) {
					SpecificCardListScene.CardDataNames.Add(CardName.Key, CardName.Value);
				}

				foreach (KeyValuePair<int, double> CardValue in CardData_SCVI_ScarletViolet.CardDataValues) {
					SpecificCardListScene.CardDataValues.Add(CardValue.Key, CardValue.Value);
				}

				break;
			default:
				break;
		}
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}