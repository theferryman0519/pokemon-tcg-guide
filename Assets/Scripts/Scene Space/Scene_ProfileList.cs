// Main Dependencies
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

// Game Dependencies
using CoreSpace;
using DataSpace;

namespace SceneSpace {
public class Scene_ProfileList : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image[] allImages;
	public Text[] allWhiteTexts;
	public Text[] allBlueTexts;
	public Text[] allYellowTexts;

	public Button CardListCareyButton;
	public Button CardListPaoButton;

	public Text VersionText;
	
// --------------- PRIVATE VARIABLES ---------------
	Color OriginalColorImage = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	Color OriginalColorWhiteText = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	Color OriginalColorBlueText = new Color(0.208f, 0.384f, 0.6784f, 1.0f);
	Color OriginalColorYellowText = new Color(1.0f, 0.796f, 0.012f, 1.0f);

	Color AlphaColorImage = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	Color AlphaColorWhiteText = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	Color AlphaColorBlueText = new Color(0.208f, 0.384f, 0.6784f, 0.0f);
	Color AlphaColorYellowText = new Color(1.0f, 0.796f, 0.012f, 0.0f);
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Set Colors
		foreach (Image Img in allImages)
			Img.color = AlphaColorImage;
		foreach (Text TxtWhite in allWhiteTexts)
			TxtWhite.color = AlphaColorWhiteText;
		foreach (Text TxtBlue in allBlueTexts)
			TxtBlue.color = AlphaColorBlueText;
		foreach (Text TxtYellow in allYellowTexts)
			TxtYellow.color = AlphaColorYellowText;

		// Set Button
		CardListCareyButton.onClick.AddListener(CardListCareyButtonClicking);
		CardListPaoButton.onClick.AddListener(CardListPaoButtonClicking);

		// Start Coroutine
		Debug.Log("Scene_ProfileList: " + "Initiate logos fading");
		StartCoroutine(FadeInAll());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		VersionText.text = "Version: " + Application.version;
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	public IEnumerator FadeInAll() {
		float ElapsedTime = 0.0f;
		Debug.Log("Scene_ProfileList: " + "All objects fading in begin");

		while (ElapsedTime < 1.0f) {
			ElapsedTime += Time.deltaTime * 1.0f;

			foreach (Image Img in allImages)
				Img.color = Color.Lerp(AlphaColorImage, OriginalColorImage, ElapsedTime);
			foreach (Text TxtWhite in allWhiteTexts)
				TxtWhite.color = Color.Lerp(AlphaColorWhiteText, OriginalColorWhiteText, ElapsedTime);
			foreach (Text TxtYellow in allYellowTexts)
				TxtYellow.color = Color.Lerp(AlphaColorYellowText, OriginalColorYellowText, ElapsedTime);
			foreach (Text TxtBlue in allBlueTexts)
				TxtBlue.color = Color.Lerp(AlphaColorBlueText, OriginalColorBlueText, ElapsedTime);

			yield return null;
		}
		
		Debug.Log("Scene_ProfileList: " + "All objects fading in end");
	}

	public IEnumerator FadeOutAll() {
		float ElapsedTime = 0.0f;
		Debug.Log("Scene_ProfileList: " + "All objects fading out begin");

		while (ElapsedTime < 1.0f) {
			ElapsedTime += Time.deltaTime * 1.0f;

			foreach (Image Img in allImages)
				Img.color = Color.Lerp(OriginalColorImage, AlphaColorImage, ElapsedTime);
			foreach (Text TxtWhite in allWhiteTexts)
				TxtWhite.color = Color.Lerp(OriginalColorWhiteText, AlphaColorWhiteText, ElapsedTime);
			foreach (Text TxtYellow in allYellowTexts)
				TxtYellow.color = Color.Lerp(OriginalColorYellowText, AlphaColorYellowText, ElapsedTime);
			foreach (Text TxtBlue in allBlueTexts)
				TxtBlue.color = Color.Lerp(OriginalColorBlueText, AlphaColorBlueText, ElapsedTime);

			yield return null;
		}
		
		Debug.Log("Scene_ProfileList: " + "All objects fading out end");
		Debug.Log("Scene_ProfileList: " + "Change scenes to Overall List");
		SceneManager.LoadScene(Core_Controller.Instance.Scene02);
	}
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	public void CardListCareyButtonClicking() {
		Debug.Log("Scene_ProfileList: " + "Button pressed for Card List Carey");
		Data_Controller.Instance.UserProfile = "Carey";
		StartCoroutine(FadeOutAll());
	}

	public void CardListPaoButtonClicking() {
		Debug.Log("Scene_ProfileList: " + "Button pressed for Card List Pao");
		Data_Controller.Instance.UserProfile = "Pao";
		StartCoroutine(FadeOutAll());
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}