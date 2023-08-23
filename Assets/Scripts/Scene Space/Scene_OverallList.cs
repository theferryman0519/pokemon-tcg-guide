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
public class Scene_OverallList : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image[] allImages;
	public Text[] allWhiteTexts;
	public Text[] allBlueTexts;
	public Text[] allYellowTexts;

	public Text WelcomeText;

	public Button Set01Button;
	public Button Set02Button;
	public Button Set03Button;
	public Button Set04Button;
	public Button Set05Button;
	public Button Set06Button;
	public Button Set07Button;
	public Button Set08Button;
	public Button Set09Button;
	public Button Set10Button;
	public Button Set11Button;
	public Button Set12Button;
	public Button Set13Button;
	public Button Set14Button;
	public Button GoBackButton;
	public Button AllStatsButton;
	
// --------------- PRIVATE VARIABLES ---------------
	Color OriginalColorImage = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	Color OriginalColorWhiteText = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	Color OriginalColorBlueText = new Color(0.208f, 0.384f, 0.6784f, 1.0f);
	Color OriginalColorYellowText = new Color(1.0f, 0.796f, 0.012f, 1.0f);

	Color AlphaColorImage = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	Color AlphaColorWhiteText = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	Color AlphaColorBlueText = new Color(0.208f, 0.384f, 0.6784f, 0.0f);
	Color AlphaColorYellowText = new Color(1.0f, 0.796f, 0.012f, 0.0f);

	int OptionInt = 0;
	
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
		Set01Button.onClick.AddListener(Set01ButtonClicking);
		Set02Button.onClick.AddListener(Set02ButtonClicking);
		Set03Button.onClick.AddListener(Set03ButtonClicking);
		Set04Button.onClick.AddListener(Set04ButtonClicking);
		Set05Button.onClick.AddListener(Set05ButtonClicking);
		Set06Button.onClick.AddListener(Set06ButtonClicking);
		Set07Button.onClick.AddListener(Set07ButtonClicking);
		Set08Button.onClick.AddListener(Set08ButtonClicking);
		Set09Button.onClick.AddListener(Set09ButtonClicking);
		Set10Button.onClick.AddListener(Set10ButtonClicking);
		Set11Button.onClick.AddListener(Set11ButtonClicking);
		Set12Button.onClick.AddListener(Set12ButtonClicking);
		Set13Button.onClick.AddListener(Set13ButtonClicking);
		Set14Button.onClick.AddListener(Set14ButtonClicking);
		GoBackButton.onClick.AddListener(GoBackButtonClicking);
		AllStatsButton.onClick.AddListener(AllStatsButtonClicking);

		// Start Coroutine
		Debug.Log("Scene_OverallList: " + "Initiate logos fading");
		StartCoroutine(FadeInAll());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (Data_Controller.Instance.UserProfile == "Carey")
			WelcomeText.text = "Welcome back, Carey! Please select one of the card sets below:";
		else if (Data_Controller.Instance.UserProfile == "Pao")
			WelcomeText.text = "Welcome back, Kristen and Charles! Please select one of the card sets below:";
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	public IEnumerator FadeInAll() {
		float ElapsedTime = 0.0f;
		Debug.Log("Scene_OverallList: " + "All objects fading in begin");

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
		
		Debug.Log("Scene_OverallList: " + "All objects fading in end");
	}

	public IEnumerator FadeOutAll() {
		float ElapsedTime = 0.0f;
		Debug.Log("Scene_OverallList: " + "All objects fading out begin");

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
		
		Debug.Log("Scene_OverallList: " + "All objects fading out end");

		if (OptionInt == 1) {
			Debug.Log("Scene_OverallList: " + "Change scenes to Specific Set List");
			SceneManager.LoadScene(Core_Controller.Instance.Scene03);
		}

		else if (OptionInt == 2) {
			Debug.Log("Scene_OverallList: " + "Change scenes to Profile List");
			SceneManager.LoadScene(Core_Controller.Instance.Scene01);
		}

		else if (OptionInt == 3) {
			Debug.Log("Scene_OverallList: " + "Change scenes to All Card Stats");
			SceneManager.LoadScene(Core_Controller.Instance.Scene05);
		}
	}
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	public void Set01ButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Set 01");
		Data_Controller.Instance.SetChosen = "Set01";
		OptionInt = 1;
		StartCoroutine(FadeOutAll());
	}

	public void Set02ButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Set 02");
		Data_Controller.Instance.SetChosen = "Set02";
		OptionInt = 1;
		StartCoroutine(FadeOutAll());
	}

	public void Set03ButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Set 03");
		Data_Controller.Instance.SetChosen = "Set03";
		OptionInt = 1;
		StartCoroutine(FadeOutAll());
	}

	public void Set04ButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Set 04");
		Data_Controller.Instance.SetChosen = "Set04";
		OptionInt = 1;
		StartCoroutine(FadeOutAll());
	}

	public void Set05ButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Set 05");
		Data_Controller.Instance.SetChosen = "Set05";
		OptionInt = 1;
		StartCoroutine(FadeOutAll());
	}

	public void Set06ButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Set 06");
		Data_Controller.Instance.SetChosen = "Set06";
		OptionInt = 1;
		StartCoroutine(FadeOutAll());
	}

	public void Set07ButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Set 07");
		Data_Controller.Instance.SetChosen = "Set07";
		OptionInt = 1;
		StartCoroutine(FadeOutAll());
	}

	public void Set08ButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Set 08");
		Data_Controller.Instance.SetChosen = "Set08";
		OptionInt = 1;
		StartCoroutine(FadeOutAll());
	}

	public void Set09ButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Set 09");
		Data_Controller.Instance.SetChosen = "Set09";
		OptionInt = 1;
		StartCoroutine(FadeOutAll());
	}

	public void Set10ButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Set 10");
		Data_Controller.Instance.SetChosen = "Set10";
		OptionInt = 1;
		StartCoroutine(FadeOutAll());
	}

	public void Set11ButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Set 11");
		Data_Controller.Instance.SetChosen = "Set11";
		OptionInt = 1;
		StartCoroutine(FadeOutAll());
	}

	public void Set12ButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Set 12");
		Data_Controller.Instance.SetChosen = "Set12";
		OptionInt = 1;
		StartCoroutine(FadeOutAll());
	}

	public void Set13ButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Set 13");
		Data_Controller.Instance.SetChosen = "Set13";
		OptionInt = 1;
		StartCoroutine(FadeOutAll());
	}

	public void Set14ButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Set 14");
		Data_Controller.Instance.SetChosen = "Set14";
		OptionInt = 1;
		StartCoroutine(FadeOutAll());
	}

	public void GoBackButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for Go Back");
		Data_Controller.Instance.UserProfile = "none";
		Data_Controller.Instance.SetChosen = "none";
		OptionInt = 2;
		StartCoroutine(FadeOutAll());
	}

	public void AllStatsButtonClicking() {
		Debug.Log("Scene_OverallList: " + "Button pressed for All Stats");
		Data_Controller.Instance.SetChosen = "none";
		OptionInt = 3;
		StartCoroutine(FadeOutAll());
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}