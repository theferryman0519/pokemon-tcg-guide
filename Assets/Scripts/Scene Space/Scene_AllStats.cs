// Main Dependencies
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

// Game Dependencies
using CoreSpace;
using DataSpace;
using FirebaseSpace;

namespace SceneSpace {
public class Scene_AllStats : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public List<Image> allImages = new List<Image>();
	public List<Text> allWhiteTexts = new List<Text>();
	public List<Text> allBlueTexts = new List<Text>();
	public List<Text> allYellowTexts = new List<Text>();

	public Text FullStatsText;

	public Button GoBackButton;

	public RectTransform ScrollViewContent;

	public GameObject SubSetStats;
	
// --------------- PRIVATE VARIABLES ---------------
	Color OriginalColorImage = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	Color OriginalColorWhiteText = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	Color OriginalColorBlueText = new Color(0.208f, 0.384f, 0.6784f, 1.0f);
	Color OriginalColorYellowText = new Color(1.0f, 0.796f, 0.012f, 1.0f);

	Color AlphaColorImage = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	Color AlphaColorWhiteText = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	Color AlphaColorBlueText = new Color(0.208f, 0.384f, 0.6784f, 0.0f);
	Color AlphaColorYellowText = new Color(1.0f, 0.796f, 0.012f, 0.0f);

	int CardsHave = 0;
	int DuplicatesHave = 0;
	int TotalCardsHave = 0;
	int TotalDuplicatesHave = 0;

	double CardsValue = 0.00;
	double DuplicatesValue = 0.00;
	double TotalCardsValue = 0.00;
	double TotalDuplicatesValue = 0.00;

	Dictionary<string, List<Data_CardData>> FullSetDict = new Dictionary<string, List<Data_CardData>>();

	List<Data_CardData> FullCardList = new List<Data_CardData>();
	
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

		// Set Tracker
		Data_Controller.Instance.AllStatsTracker = 0;

		// Start Coroutine
		Debug.Log("Scene_AllStats: " + "Initiate logos fading");
		StartCoroutine(FadeInAll());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	public IEnumerator FadeInAll() {
		float ElapsedTime = 0.0f;
		Debug.Log("Scene_AllStats: " + "All objects fading in begin");

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
		
		Debug.Log("Scene_AllStats: " + "All objects fading in end");
	}

	public IEnumerator FadeOutAll() {
		float ElapsedTime = 0.0f;
		Debug.Log("Scene_AllStats: " + "All objects fading out begin");

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
		
		Debug.Log("Scene_AllStats: " + "All objects fading out end");
		Data_Controller.Instance.SubSetInfo.Clear();
		Debug.Log("Scene_AllStats: " + "Change scenes to Overall List");
		SceneManager.LoadScene(Core_Controller.Instance.Scene02);
	}
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	public void GoBackButtonClicking() {
		Debug.Log("Scene_AllStats: " + "Button pressed for Go Back");
		StartCoroutine(FadeOutAll());
	}

	public void InstantiateSubSetListA() {
		Debug.Log("Scene_AllStats: " + "Initializing instantiation part 1");
		Firebase_Controller.Instance.DownloadAllData();
	}

	public void InstantiateSubSetListB() {
		Debug.Log("Scene_AllStats: " + "Initializing instantiation part 2");

		// Add Specifically Chosen Sub Lists
		List<Data_SubSetData> SpecificSubSetInfo = new List<Data_SubSetData>();

		foreach (KeyValuePair<string, Data_SubSetData> SubSet in Data_Controller.Instance.SubSetInfo) {
			SpecificSubSetInfo.Add(SubSet.Value);
		}

		// Sort By Date
		SpecificSubSetInfo = SpecificSubSetInfo.OrderBy(SubSet => SubSet.SubSetReleaseDate).ToList();

		// Instantiate Sub Lists
		ScrollViewContent.sizeDelta = new Vector2(0, (SpecificSubSetInfo.Count * 350));
		int i = 0;

		foreach (Data_SubSetData SubSetData in SpecificSubSetInfo) {
			// Pao
			if (Data_Controller.Instance.UserProfile == "Pao") {
				GameObject SetStats = Instantiate(SubSetStats, new Vector3(0,0,0), Quaternion.identity);
				SetStats.transform.SetParent(ScrollViewContent.transform);
				SetStats.transform.localScale = Vector2.one;
				i++;
				SetStats.name = SubSetData.SubSetMainSetAbbrev + "_" + SubSetData.SubSetDataName;

				SetStats.transform.GetChild(0).GetComponent<Text>().text = SubSetData.SubSetMainSetAbbrev + " - " + SubSetData.SubSetName;
				SetStats.transform.GetChild(3).GetComponent<Text>().text = "Cards Have: " + CardsHave.ToString("n0") + "\n" + "Value: $" + CardsValue.ToString("n2");

				SetStats.transform.GetChild(1).gameObject.SetActive(false);
				SetStats.transform.GetChild(2).gameObject.SetActive(false);
				SetStats.transform.GetChild(3).gameObject.SetActive(true);

				allImages.Add(SetStats.GetComponent<Image>());
				allWhiteTexts.Add(SetStats.transform.GetChild(0).GetComponent<Text>());
				allWhiteTexts.Add(SetStats.transform.GetChild(1).GetComponent<Text>());
				allWhiteTexts.Add(SetStats.transform.GetChild(2).GetComponent<Text>());
				allWhiteTexts.Add(SetStats.transform.GetChild(3).GetComponent<Text>());
			}

			// Carey
			else if (Data_Controller.Instance.UserProfile == "Carey") {
				GameObject SetStats = Instantiate(SubSetStats, new Vector3(0,0,0), Quaternion.identity);
				SetStats.transform.SetParent(ScrollViewContent.transform);
				SetStats.transform.localScale = Vector2.one;
				i++;
				SetStats.name = SubSetData.SubSetMainSetAbbrev + "_" + SubSetData.SubSetDataName;

				SetStats.transform.GetChild(0).GetComponent<Text>().text = SubSetData.SubSetMainSetAbbrev + " - " + SubSetData.SubSetName;
				SetStats.transform.GetChild(1).GetComponent<Text>().text = "Cards Have: " + CardsHave.ToString("n0") + "\n" + "Value: $" + CardsValue.ToString("n2");
				SetStats.transform.GetChild(2).GetComponent<Text>().text = "Duplicates Have: " + DuplicatesHave.ToString("n0") + "\n" + "Value: $" + DuplicatesValue.ToString("n2");

				SetStats.transform.GetChild(1).gameObject.SetActive(true);
				SetStats.transform.GetChild(2).gameObject.SetActive(true);
				SetStats.transform.GetChild(3).gameObject.SetActive(false);

				allImages.Add(SetStats.GetComponent<Image>());
				allWhiteTexts.Add(SetStats.transform.GetChild(0).GetComponent<Text>());
				allWhiteTexts.Add(SetStats.transform.GetChild(1).GetComponent<Text>());
				allWhiteTexts.Add(SetStats.transform.GetChild(2).GetComponent<Text>());
				allWhiteTexts.Add(SetStats.transform.GetChild(3).GetComponent<Text>());
			}
		}

		Debug.Log("Scene_AllStats: " + "All sub sets have been instantiated");
		GatherAllData();
	}

	public void GatherAllData() {
		Debug.Log("Scene_AllStats: " + "Initializing gathering all card data");

		List<string> FullDataString = new List<string>();
		List<Data_SubSetData> FullDataSubs = new List<Data_SubSetData>();

		foreach (KeyValuePair<string, Data_SubSetData> pair in Data_Controller.Instance.SubSetInfo) {
			FullDataString.Add(pair.Key);
			FullDataSubs.Add(pair.Value);
		}

		for (int i = 0; i < FullDataString.Count; i++) {
			string[] SplitName = FullDataString[i].Split("_");

			Debug.Log("Scene_AllStats: " + SplitName[0] + " / " + SplitName[1]);

			Firebase_Controller.Instance.DownloadSubSetDataB(SplitName[0], SplitName[1]);
		}

		Debug.Log("Scene_AllStats: " + "Successfully gathered all card data");
	}

	public void InputAllData() {
		Debug.Log("Scene_AllStats: " + "Initializing inputting all card data into the scene");

		List<string> DataHolderNames = new List<string>();
		Dictionary<string, Data_CardData> DataHolderData = new Dictionary<string, Data_CardData>();

		foreach (Transform DataHolder in ScrollViewContent.transform) {
			DataHolderNames.Add(DataHolder.name);
		}

		foreach (string HolderName in DataHolderNames) {
			CardsHave = 0;
			CardsValue = 0.00;
			DuplicatesHave = 0;
			DuplicatesValue = 0.00;

			foreach (KeyValuePair<string, Data_CardData> CardPair in Data_Controller.Instance.CardInfo) {
				if (CardPair.Key.Contains(HolderName)) {
					// Pao
					if (Data_Controller.Instance.UserProfile == "Pao") {
						CardsHave += CardPair.Value.CardKCHave;

						if (CardPair.Value.CardKCHave == 1)
							CardsValue += CardPair.Value.CardValue;

						GameObject.Find(HolderName).transform.GetChild(3).GetComponent<Text>().text = "Cards Have: " + CardsHave.ToString("n0") + "\n" + "Value: $" + CardsValue.ToString("n2");
					}

					// Carey
					else if (Data_Controller.Instance.UserProfile == "Carey") {
						CardsHave += CardPair.Value.CardCareyHave;
						DuplicatesHave += CardPair.Value.CardCareyDuplicate;

						if (CardPair.Value.CardCareyHave == 1)
							CardsValue += CardPair.Value.CardValue;
						
						DuplicatesValue += ((double)CardPair.Value.CardCareyDuplicate * CardPair.Value.CardValue);

						GameObject.Find(HolderName).transform.GetChild(1).GetComponent<Text>().text = "Cards Have: " + CardsHave.ToString("n0") + "\n" + "Value: $" + CardsValue.ToString("n2");
						GameObject.Find(HolderName).transform.GetChild(2).GetComponent<Text>().text = "Duplicates Have: " + DuplicatesHave.ToString("n0") + "\n" + "Value: $" + DuplicatesValue.ToString("n2");
					}
				}
			}

			TotalCardsHave += CardsHave;
			TotalCardsValue += CardsValue;
			TotalDuplicatesHave += DuplicatesHave;
			TotalDuplicatesValue += DuplicatesValue;
			UpdateUpperData();
		}
	}

	public void UpdateUpperData() {
		// Pao
		if (Data_Controller.Instance.UserProfile == "Pao") {
			FullStatsText.text = "Total Cards Have: " + TotalCardsHave.ToString("n0") + "\n" + "Total Value: $" + TotalCardsValue.ToString("n2");
		}

		// Carey
		else if (Data_Controller.Instance.UserProfile == "Carey") {
			FullStatsText.text = "Total Cards Have: " + TotalCardsHave.ToString("n0") + "\n" + "Total Value: $" + TotalCardsValue.ToString("n2") + "\n\n" + "Total Duplicates Have: " + TotalDuplicatesHave.ToString("n0") + "\n" + "Total Duplicates Value: $" + TotalDuplicatesValue.ToString("n2");
		}
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}