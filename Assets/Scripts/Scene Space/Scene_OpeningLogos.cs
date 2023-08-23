// Main Dependencies
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

// Game Dependencies
using CoreSpace;

namespace SceneSpace {
public class Scene_OpeningLogos : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image[] allImages;
	public Text[] allWhiteTexts;
	public Text[] allBlueTexts;
	public Text[] allYellowTexts;

	public Button OverlayButton;
	
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
		OverlayButton.onClick.AddListener(OverlayButtonClicking);

		// Start Coroutine
		Debug.Log("Scene_OpeningLogos: " + "Initiate logos fading");
		StartCoroutine(ImagesFading());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	public IEnumerator ImagesFading() {
		for (int i = 0; i < allImages.Length; i++) {
			float ElapsedTime = 0.0f;
			Debug.Log("Scene_OpeningLogos: " + "Logo fading in");

			while (ElapsedTime < 1.0f) {
				ElapsedTime += Time.deltaTime * 1.0f;
				allImages[i].color = Color.Lerp(AlphaColorImage, OriginalColorImage, ElapsedTime);
				yield return null;
			}

			ElapsedTime = 0.0f;
			yield return new WaitForSeconds(1.0f);
			Debug.Log("Scene_OpeningLogos: " + "Logo fading out");

			while (ElapsedTime < 1.0f) {
				ElapsedTime += Time.deltaTime * 1.0f;
				allImages[i].color = Color.Lerp(OriginalColorImage, AlphaColorImage, ElapsedTime);
				yield return null;
			}

			yield return new WaitForSeconds(0.5f);
		}

		Debug.Log("Scene_OpeningLogos: " + "Change scenes to Profile List");
		SceneManager.LoadScene(Core_Controller.Instance.Scene01);
	}
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	public void OverlayButtonClicking() {
		Debug.Log("Scene_OpeningLogos: " + "Change scenes to Profile List");
		SceneManager.LoadScene(Core_Controller.Instance.Scene01);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}