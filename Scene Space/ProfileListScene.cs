using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using CoreSpace;
using DataSpace;

namespace SceneSpace {
public class ProfileListScene : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image OverlayImage;

	public Button CareyButton;
	public Button KCButton;

	public Text VersionText;
	
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
		CareyButton.onClick.AddListener(CareyButtonClicking);
		KCButton.onClick.AddListener(KCButtonClicking);

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
		VersionText.text = "Version: 1.0.1";
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

		SceneManager.LoadScene(SceneChange.Scene02);
	}
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	public void CareyButtonClicking() {
		SetData.ListChoice = "Carey";
		StartCoroutine(FadeOverlayIn());
	}

	public void KCButtonClicking() {
		SetData.ListChoice = "KC";
		StartCoroutine(FadeOverlayIn());
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}