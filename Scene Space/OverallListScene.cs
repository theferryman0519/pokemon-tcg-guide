using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using CoreSpace;
using DataSpace;

namespace SceneSpace {
public class OverallListScene : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image OverlayImage;

	public Text WelcomeText;

	public Button OriginalSeriesButton;
	public Button GymSeriesButton;
	public Button NeoSeriesButton;
	public Button LegendaryCollectionSeriesButton;
	public Button ECardSeriesButton;
	public Button EXSeriesButton;
	public Button DiamondPearlSeriesButton;
	public Button PlatinumSeriesButton;
	public Button HGSSSeriesButton;
	public Button BWSeriesButton;
	public Button XYSeriesButton;
	public Button SunMoonSeriesButton;
	public Button SwordShieldSeriesButton;
	public Button ScarletVioletSeriesButton;
	
// --------------- PRIVATE VARIABLES ---------------
	Color OverlayOriginal = new Color(0.125f, 0.125f, 0.125f, 1.0f);
	Color OverlayAlpha = new Color(0.125f, 0.125f, 0.125f, 0.0f);
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Set Buttons
		OriginalSeriesButton.onClick.AddListener(OriginalSeriesButtonClicking);
		GymSeriesButton.onClick.AddListener(GymSeriesButtonClicking);
		NeoSeriesButton.onClick.AddListener(NeoSeriesButtonClicking);
		LegendaryCollectionSeriesButton.onClick.AddListener(LegendaryCollectionSeriesButtonClicking);
		ECardSeriesButton.onClick.AddListener(ECardSeriesButtonClicking);
		EXSeriesButton.onClick.AddListener(EXSeriesButtonClicking);
		DiamondPearlSeriesButton.onClick.AddListener(DiamondPearlSeriesButtonClicking);
		PlatinumSeriesButton.onClick.AddListener(PlatinumSeriesButtonClicking);
		HGSSSeriesButton.onClick.AddListener(HGSSSeriesButtonClicking);
		BWSeriesButton.onClick.AddListener(BWSeriesButtonClicking);
		XYSeriesButton.onClick.AddListener(XYSeriesButtonClicking);
		SunMoonSeriesButton.onClick.AddListener(SunMoonSeriesButtonClicking);
		SwordShieldSeriesButton.onClick.AddListener(SwordShieldSeriesButtonClicking);
		ScarletVioletSeriesButton.onClick.AddListener(ScarletVioletSeriesButtonClicking);

		// Set Image Colors
		OverlayImage.color = OverlayOriginal;

		// Start Coroutine
		StartCoroutine(FadeOverlayOut());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (SetData.ListChoice == "Carey")
			WelcomeText.text = "Welcome to your card list," + "\n" + "Carey.";
		
		else if (SetData.ListChoice == "KC")
			WelcomeText.text = "Welcome to your card list," + "\n" + "Kristen and Charles.";
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

		SceneManager.LoadScene(SceneChange.Scene03);
	}
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	public void OriginalSeriesButtonClicking() {
		SetData.MainSetChoice = "Original";
		StartCoroutine(FadeOverlayIn());
	}

	public void GymSeriesButtonClicking() {
		SetData.MainSetChoice = "Gym";
		StartCoroutine(FadeOverlayIn());
	}

	public void NeoSeriesButtonClicking() {
		SetData.MainSetChoice = "Neo";
		StartCoroutine(FadeOverlayIn());
	}

	public void LegendaryCollectionSeriesButtonClicking() {
		SetData.MainSetChoice = "LegendaryCollection";
		StartCoroutine(FadeOverlayIn());
	}

	public void ECardSeriesButtonClicking() {
		SetData.MainSetChoice = "ECard";
		StartCoroutine(FadeOverlayIn());
	}

	public void EXSeriesButtonClicking() {
		SetData.MainSetChoice = "EX";
		StartCoroutine(FadeOverlayIn());
	}

	public void DiamondPearlSeriesButtonClicking() {
		SetData.MainSetChoice = "DiamondPearl";
		StartCoroutine(FadeOverlayIn());
	}

	public void PlatinumSeriesButtonClicking() {
		SetData.MainSetChoice = "Platinum";
		StartCoroutine(FadeOverlayIn());
	}

	public void HGSSSeriesButtonClicking() {
		SetData.MainSetChoice = "HGSS";
		StartCoroutine(FadeOverlayIn());
	}

	public void BWSeriesButtonClicking() {
		SetData.MainSetChoice = "BW";
		StartCoroutine(FadeOverlayIn());
	}

	public void XYSeriesButtonClicking() {
		SetData.MainSetChoice = "XY";
		StartCoroutine(FadeOverlayIn());
	}

	public void SunMoonSeriesButtonClicking() {
		SetData.MainSetChoice = "SunMoon";
		StartCoroutine(FadeOverlayIn());
	}

	public void SwordShieldSeriesButtonClicking() {
		SetData.MainSetChoice = "SwordShield";
		StartCoroutine(FadeOverlayIn());
	}

	public void ScarletVioletSeriesButtonClicking() {
		SetData.MainSetChoice = "ScarletViolet";
		StartCoroutine(FadeOverlayIn());
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}