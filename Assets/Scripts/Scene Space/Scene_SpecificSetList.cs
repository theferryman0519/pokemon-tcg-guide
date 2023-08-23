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
using FirebaseSpace;

namespace SceneSpace {
public class Scene_SpecificSetList : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image[] allImages;
	public Text[] allWhiteTexts;
	public Text[] allBlueTexts;
	public Text[] allYellowTexts;

	public Text TitleText;
	public Text MainSetText;

	public Button GoBackButton;

	public RectTransform ScrollViewContent;

	public GameObject SubSetPrefab;
	
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

	Button SubSetButton;
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Instantiate List
		InstantiateSubSetListA();

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
		GoBackButton.onClick.AddListener(GoBackButtonClicking);

		// Start Coroutine
		Debug.Log("Scene_SpecificSetList: " + "Initiate logos fading");
		StartCoroutine(FadeInAll());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		TitleText.text = Data_Controller.Instance.MainSetNames[Data_Controller.Instance.SetChosen];
		MainSetText.text = "These are the various card lists under the main set: " + Data_Controller.Instance.MainSetNames[Data_Controller.Instance.SetChosen] + ".";
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	public IEnumerator FadeInAll() {
		float ElapsedTime = 0.0f;
		Debug.Log("Scene_SpecificSetList: " + "All objects fading in begin");

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
		
		Debug.Log("Scene_SpecificSetList: " + "All objects fading in end");
	}

	public IEnumerator FadeOutAll() {
		float ElapsedTime = 0.0f;
		Debug.Log("Scene_SpecificSetList: " + "All objects fading out begin");

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
		
		Debug.Log("Scene_SpecificSetList: " + "All objects fading out end");

		if (OptionInt == 1) {
			Debug.Log("Scene_SpecificSetList: " + "Change scenes to Specific Set List");
			SceneManager.LoadScene(Core_Controller.Instance.Scene03);
		}

		else if (OptionInt == 2) {
			Data_Controller.Instance.SetChosen = "none";
			Data_Controller.Instance.SubSetInfo.Clear();
			Debug.Log("Scene_SpecificSetList: " + "Change scenes to Overall List");
			SceneManager.LoadScene(Core_Controller.Instance.Scene02);
		}
	}
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	public void GoBackButtonClicking() {
		Debug.Log("Scene_SpecificSetList: " + "Button pressed for Go Back");
		OptionInt = 2;
		StartCoroutine(FadeOutAll());
	}

	public void InstantiateSubSetListA() {
		Firebase_Controller.Instance.DownloadMainSetData(Data_Controller.Instance.MainSetAbbrevs[Data_Controller.Instance.SetChosen]);
	}

	public void InstantiateSubSetListB() {
		// Add Specifically Chosen Sub Lists
		List<Data_SubSetData> SpecificSubSetInfo = new List<Data_SubSetData>();

		foreach (KeyValuePair<string, Data_SubSetData> SubSet in Data_Controller.Instance.SubSetInfo) {
			if (SubSet.Key.Contains(Data_Controller.Instance.MainSetAbbrevs[Data_Controller.Instance.SetChosen] + "_")) {
				SpecificSubSetInfo.Add(SubSet.Value);
			}
		}

		// Instantiate Sub Lists
		ScrollViewContent.sizeDelta = new Vector2(0, (SpecificSubSetInfo.Count * 350));
		int i = 0;

		foreach (Data_SubSetData SubSetData in SpecificSubSetInfo) {
			GameObject SubSet = Instantiate(SubSetPrefab, new Vector3(0,0,0), Quaternion.identity);
			SubSet.transform.SetParent(ScrollViewContent.transform);
			SubSet.transform.localScale = Vector2.one;
			i++;
			SubSet.name = SubSetData.SubSetDataName;

			SubSet.transform.GetChild(0).GetComponent<Text>().text = SubSetData.SubSetName;
			SubSet.transform.GetChild(1).GetComponent<Text>().text = "Released:" + "\n" + SubSetData.SubSetReleaseDate;
			SubSet.transform.GetChild(2).GetComponent<Image>().sprite = SubSetData.SubSetSprite;
			// SubSetButton = SubSet.transform.GetChild(4).GetComponent<Button>();
			// SubSetButton.onClick.AddListener(() => SubSetButtonClicking(SubSet.name));
		}
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}