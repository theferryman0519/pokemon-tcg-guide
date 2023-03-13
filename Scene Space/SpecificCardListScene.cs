using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using CoreSpace;
using DataSpace;
using Proyecto26;

namespace SceneSpace {
public class SpecificCardListScene : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image OverlayImage;
	public Image CardIcon;

	public GameObject CardPrefabCarey;
	public GameObject CardPrefabKC;
	public GameObject ViewContent;
	public GameObject LoadMoreCards;

	public Text TitleText;
	public Text InfoText;

	public Button BackButton;
	
// --------------- PRIVATE VARIABLES ---------------
	Color OverlayOriginal = new Color(0.125f, 0.125f, 0.125f, 1.0f);
	Color OverlayAlpha = new Color(0.125f, 0.125f, 0.125f, 0.0f);
	Color CardHaveOff = new Color(0.1321f, 0.1321f, 0.1321f, 0.5f);
	Color CardHaveOn = new Color(1.0f, 1.0f, 1.0f, 1.0f);

	Button CardHaveButton;
	Button DuplicateAddButton;
	Button DuplicateMinusButton;
	Button NeedMoreCardsButton;

	int TotalCardNumbers = 0;
	int CardSlotNumber = 0;
	int CardPageNumber = 1;
	
	double TotalCardValues = 0.00;
	double TotalDuplicateValues = 0.00;

	bool LoadingRestOfCards = false;
	
// --------------- STATIC VARIABLES ---------------
	public static Dictionary <int, string> CardDataNumbers = new Dictionary<int, string>();
	public static Dictionary <int, string> CardDataNames = new Dictionary<int, string>();
	public static Dictionary <int, double> CardDataValues = new Dictionary<int, double>();

	public static int UserCardsHaveInt;
	public static int UserDuplicatesHaveInt;
	
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

		// Set Instatiations
		SetTitleInfo();
		InstantiateCardNames();

		// Start Coroutine
		StartCoroutine(FadeOverlayOut());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		SetTitleInfo();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	public IEnumerator FadeOverlayOut() {
		float ElapsedTime = 0.0f;
		SetInfoText();

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
	}

	public IEnumerator FadeOverlayInBack() {
		OverlayImage.gameObject.SetActive(true);
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 2.0f) {
			ElapsedTime += Time.deltaTime;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayAlpha, OverlayOriginal, ElapsedTime);
			yield return null;
		}

		SetData.MainCardsChoice = "";
		SceneManager.LoadScene(SceneChange.Scene03);
	}
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	public void InstantiateCardNames() {
		if (SetData.ListChoice == "KC") {
			ViewContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, (100 * 300));
			int i = 0;

			for (int j = 1; j < CardDataNumbers.Count + 1; j++) {
				if (j < 100) {
					SetData.CardNumberInt = j;
					string SpecificCardNumber = CardDataNumbers[j];
					string SpecificCardName = CardDataNames[j];
					double SpecificCardValue = CardDataValues[j];

					GameObject CardName = Instantiate(CardPrefabKC, new Vector3(0,0,0), Quaternion.identity);
					CardName.transform.SetParent(ViewContent.transform);
					CardName.transform.localScale = Vector2.one;
					i++;
					CardName.name = "Card_" + SpecificCardNumber + SpecificCardName;

					GetCardData(CardName, SpecificCardValue, SpecificCardName, SpecificCardNumber, j);

					CardName.transform.GetChild(3).GetComponent<Text>().text = "#" + SpecificCardNumber;
					CardName.transform.GetChild(4).GetComponent<Text>().text = SpecificCardName;
					CardHaveButton = CardName.transform.GetChild(6).GetComponent<Button>();
					CardHaveButton.onClick.AddListener(() => CardHaveButtonClicking(CardName, SpecificCardValue, SpecificCardName, SpecificCardNumber, j));

					SetCardBackground(CardName, SpecificCardName);
				}

				else if ((j == 100) && (LoadingRestOfCards == false)) {
					GameObject NeedMoreCards = Instantiate(LoadMoreCards, new Vector3(0,0,0), Quaternion.identity);
					NeedMoreCards.transform.SetParent(ViewContent.transform);
					NeedMoreCards.transform.localScale = (Vector2.one / 2);

					NeedMoreCardsButton = NeedMoreCards.gameObject.GetComponent<Button>();
					NeedMoreCardsButton.onClick.AddListener(() => NeedMoreCardsButtonClicking(NeedMoreCards));
				}
			}
		}

		else {
			ViewContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, (100 * 375));
			int i = 0;

			for (int j = 1; j < CardDataNumbers.Count + 1; j++) {
				if (j < 100) {
					SetData.CardNumberInt = j;
					string SpecificCardNumber = CardDataNumbers[j];
					string SpecificCardName = CardDataNames[j];
					double SpecificCardValue = CardDataValues[j];

					GameObject CardName = Instantiate(CardPrefabCarey, new Vector3(0,0,0), Quaternion.identity);
					CardName.transform.SetParent(ViewContent.transform);
					CardName.transform.localScale = Vector2.one;
					i++;
					CardName.name = "Card_" + SpecificCardNumber + SpecificCardName;

					GetCardData(CardName, SpecificCardValue, SpecificCardName, SpecificCardNumber, j);

					CardName.transform.GetChild(3).GetComponent<Text>().text = "#" + CardDataNumbers[j];
					CardName.transform.GetChild(4).GetComponent<Text>().text = CardDataNames[j];

					CardHaveButton = CardName.transform.GetChild(7).GetComponent<Button>();
					DuplicateMinusButton = CardName.transform.GetChild(11).GetComponent<Button>();
					DuplicateAddButton = CardName.transform.GetChild(12).GetComponent<Button>();

					CardHaveButton.onClick.AddListener(() => CardHaveButtonClicking(CardName, SpecificCardValue, SpecificCardName, SpecificCardNumber, j));
					DuplicateMinusButton.onClick.AddListener(() => DuplicateMinusButtonClicking(CardName, SpecificCardValue, SpecificCardName, SpecificCardNumber, j));
					DuplicateAddButton.onClick.AddListener(() => DuplicateAddButtonClicking(CardName, SpecificCardValue, SpecificCardName, SpecificCardNumber, j));

					SetCardBackground(CardName, SpecificCardName);

					CardSlotNumber++;

					if (CardSlotNumber > 18) {
						CardPageNumber++;
						CardSlotNumber = 1;
					}

					CardName.transform.GetChild(5).GetComponent<Text>().text = "Page: " + CardPageNumber.ToString() + " / Slot: " + CardSlotNumber.ToString();
				}

				else if ((j == 100) && (LoadingRestOfCards == false)) {
					GameObject NeedMoreCards = Instantiate(LoadMoreCards, new Vector3(0,0,0), Quaternion.identity);
					NeedMoreCards.transform.SetParent(ViewContent.transform);
					NeedMoreCards.transform.localScale = (Vector2.one / 2);

					NeedMoreCardsButton = NeedMoreCards.gameObject.GetComponent<Button>();
					NeedMoreCardsButton.onClick.AddListener(() => NeedMoreCardsButtonClicking(NeedMoreCards));
				}
			}
		}
	}

	public void NeedMoreCardsButtonClicking(GameObject NeedMoreCards) {
		NeedMoreCards.SetActive(false);
		LoadingRestOfCards = true;

		if (SetData.ListChoice == "KC") {
			ViewContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, (CardDataNumbers.Count * 300));
			int i = 0;

			for (int j = 100; j < CardDataNumbers.Count; j++) {
				SetData.CardNumberInt = j;
				string SpecificCardNumber = CardDataNumbers[j];
				string SpecificCardName = CardDataNames[j];
				double SpecificCardValue = CardDataValues[j];

				GameObject CardName = Instantiate(CardPrefabKC, new Vector3(0,0,0), Quaternion.identity);
				CardName.transform.SetParent(ViewContent.transform);
				CardName.transform.localScale = Vector2.one;
				i++;
				CardName.name = "Card_" + SpecificCardNumber.ToString() + SpecificCardName;

				GetCardData(CardName, SpecificCardValue, SpecificCardName, SpecificCardNumber, j);

				CardName.transform.GetChild(3).GetComponent<Text>().text = "#" + SpecificCardNumber;
				CardName.transform.GetChild(4).GetComponent<Text>().text = SpecificCardName;
				CardHaveButton = CardName.transform.GetChild(6).GetComponent<Button>();
				CardHaveButton.onClick.AddListener(() => CardHaveButtonClicking(CardName, SpecificCardValue, SpecificCardName, SpecificCardNumber, j));

				SetCardBackground(CardName, SpecificCardName);
			}
		}

		else {
			ViewContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, (CardDataNumbers.Count * 300));
			int i = 0;

			for (int j = 100; j < CardDataNumbers.Count + 1; j++) {
				SetData.CardNumberInt = j;
				string SpecificCardNumber = CardDataNumbers[j];
				string SpecificCardName = CardDataNames[j];
				double SpecificCardValue = CardDataValues[j];

				GameObject CardName = Instantiate(CardPrefabCarey, new Vector3(0,0,0), Quaternion.identity);
				CardName.transform.SetParent(ViewContent.transform);
				CardName.transform.localScale = Vector2.one;
				i++;
				CardName.name = "Card_" + SpecificCardNumber.ToString() + SpecificCardName;

				GetCardData(CardName, SpecificCardValue, SpecificCardName, SpecificCardNumber, j);

				CardName.transform.GetChild(3).GetComponent<Text>().text = "#" + CardDataNumbers[j];
				CardName.transform.GetChild(4).GetComponent<Text>().text = CardDataNames[j];

				CardHaveButton = CardName.transform.GetChild(7).GetComponent<Button>();
				DuplicateMinusButton = CardName.transform.GetChild(11).GetComponent<Button>();
				DuplicateAddButton = CardName.transform.GetChild(12).GetComponent<Button>();

				CardHaveButton.onClick.AddListener(() => CardHaveButtonClicking(CardName, SpecificCardValue, SpecificCardName, SpecificCardNumber, j));
				DuplicateMinusButton.onClick.AddListener(() => DuplicateMinusButtonClicking(CardName, SpecificCardValue, SpecificCardName, SpecificCardNumber, j));
				DuplicateAddButton.onClick.AddListener(() => DuplicateAddButtonClicking(CardName, SpecificCardValue, SpecificCardName, SpecificCardNumber, j));

				SetCardBackground(CardName, SpecificCardName);

				CardSlotNumber++;

				if (CardSlotNumber > 18) {
					CardPageNumber++;
					CardSlotNumber = 1;
				}

				CardName.transform.GetChild(5).GetComponent<Text>().text = "Page: " + CardPageNumber.ToString() + " / Slot: " + CardSlotNumber.ToString();
			}
		}
	}

	public void BackButtonClicking() {
		StartCoroutine(FadeOverlayInBack());
	}

	public void CardHaveButtonClicking(GameObject CardName, double SpecificCardValue, string SpecificCardName, string SpecificCardNumber, int CardNumber) {
		if (SetData.ListChoice == "KC") {
			if (CardName.transform.GetChild(6).GetComponent<Image>().color == CardHaveOff) {
				CardName.transform.GetChild(6).GetComponent<Image>().color = CardHaveOn;
				CardName.transform.GetChild(8).GetComponent<Text>().text = "$" + SpecificCardValue.ToString("n2");
				SetData.CardNumberInt = CardNumber;
				UserCardsHaveInt = 1;
				TotalCardNumbers += 1;
				TotalCardValues += SpecificCardValue;
				SetCardData(SpecificCardValue, SpecificCardName, SpecificCardNumber, CardNumber);
				SetInfoText();
			}

			else {
				CardName.transform.GetChild(6).GetComponent<Image>().color = CardHaveOff;
				CardName.transform.GetChild(8).GetComponent<Text>().text = "---";
				SetData.CardNumberInt = CardNumber;
				UserCardsHaveInt = 0;
				TotalCardNumbers -= 1;
				TotalCardValues -= SpecificCardValue;
				SetCardData(SpecificCardValue, SpecificCardName, SpecificCardNumber, CardNumber);
				SetInfoText();
			}
		}

		else {
			if (CardName.transform.GetChild(7).GetComponent<Image>().color == CardHaveOff) {
				CardName.transform.GetChild(7).GetComponent<Image>().color = CardHaveOn;
				CardName.transform.GetChild(9).GetComponent<Text>().text = "$" + SpecificCardValue.ToString("n2");
				CardName.transform.GetChild(11).gameObject.SetActive(true);
				CardName.transform.GetChild(12).gameObject.SetActive(true);
				CardName.transform.GetChild(13).gameObject.SetActive(true);
				SetData.CardNumberInt = CardNumber;
				UserCardsHaveInt = 1;
				TotalCardNumbers += 1;
				TotalCardValues += SpecificCardValue;
				UserDuplicatesHaveInt = 0;
				SetCardData(SpecificCardValue, SpecificCardName, SpecificCardNumber, CardNumber);
				SetInfoText();
			}

			else {
				CardName.transform.GetChild(7).GetComponent<Image>().color = CardHaveOff;
				CardName.transform.GetChild(9).GetComponent<Text>().text = "---";
				CardName.transform.GetChild(11).gameObject.SetActive(false);
				CardName.transform.GetChild(12).gameObject.SetActive(false);
				CardName.transform.GetChild(13).gameObject.SetActive(false);
				SetData.CardNumberInt = CardNumber;
				UserCardsHaveInt = 0;
				TotalCardNumbers -= 1;
				TotalCardValues -= SpecificCardValue;
				UserDuplicatesHaveInt = 0;
				SetCardData(SpecificCardValue, SpecificCardName, SpecificCardNumber, CardNumber);
				SetInfoText();
			}
		}
	}

	public void DuplicateMinusButtonClicking(GameObject CardName, double SpecificCardValue, string SpecificCardName, string SpecificCardNumber, int CardNumber) {
		string DuplicateInfoText = CardName.transform.GetChild(13).GetComponent<Text>().text;
		string[] splitArray =  DuplicateInfoText.Split(char.Parse("\n"));
		int DuplicateNumberInt = Int32.Parse(splitArray[0]);

		if (DuplicateNumberInt == 0) {
			DuplicateNumberInt = 0;
			CardName.transform.GetChild(13).GetComponent<Text>().text = "0" + "\n" + "$0.00";
		}

		else {
			DuplicateNumberInt -= 1;
			TotalDuplicateValues -= SpecificCardValue;
			CardName.transform.GetChild(13).GetComponent<Text>().text = DuplicateNumberInt.ToString("n0") + "\n" + "$" + (DuplicateNumberInt * SpecificCardValue).ToString("n2");
		}

		UserDuplicatesHaveInt = DuplicateNumberInt;
		SetInfoText();
		SetCardData(SpecificCardValue, SpecificCardName, SpecificCardNumber, CardNumber);
	}

	public void DuplicateAddButtonClicking(GameObject CardName, double SpecificCardValue, string SpecificCardName, string SpecificCardNumber, int CardNumber) {
		string DuplicateInfoText = CardName.transform.GetChild(13).GetComponent<Text>().text;
		string[] splitArray =  DuplicateInfoText.Split(char.Parse("\n"));
		int DuplicateNumberInt = Int32.Parse(splitArray[0]);
		DuplicateNumberInt += 1;
		UserCardsHaveInt = 1;
		TotalDuplicateValues += SpecificCardValue;
		CardName.transform.GetChild(13).GetComponent<Text>().text = DuplicateNumberInt.ToString("n0") + "\n" + "$" + (DuplicateNumberInt * SpecificCardValue).ToString("n2");

		UserDuplicatesHaveInt = DuplicateNumberInt;
		SetInfoText();
		SetCardData(SpecificCardValue, SpecificCardName, SpecificCardNumber, CardNumber);
	}

	public void SetTitleInfo() {
		TitleText.text = SetData.FullSetNames[SetData.MainCardsChoice];
		CardIcon.sprite = SetData.FullSetIconImages[SetData.MainCardsChoice];
	}

	public void SetInfoText() {
		if (SetData.ListChoice == "KC") {
			InfoText.text = "Cards Have: " + TotalCardNumbers.ToString("n0") + "\n" + "Worth: $" + TotalCardValues.ToString("n2");
		}

		else {
			InfoText.text = "Cards Have: " + TotalCardNumbers.ToString("n0") + "\n" + "Worth: $" + TotalCardValues.ToString("n2") + "\n" + "Profit: $" + TotalDuplicateValues.ToString("n2");
		}
	}

	public void SetCardBackground(GameObject CardName, string SpecificCardName) {
		if (SpecificCardName.Contains("Reverse Holo")) {
			CardName.transform.GetChild(0).gameObject.SetActive(true);
			CardName.transform.GetChild(1).gameObject.SetActive(true);
			CardName.transform.GetChild(2).gameObject.SetActive(false);
		}

		else if (SpecificCardName.Contains("Holofoil")) {
			CardName.transform.GetChild(0).gameObject.SetActive(false);
			CardName.transform.GetChild(1).gameObject.SetActive(false);
			CardName.transform.GetChild(2).gameObject.SetActive(true);
		}

		else {
			CardName.transform.GetChild(0).gameObject.SetActive(true);
			CardName.transform.GetChild(1).gameObject.SetActive(false);
			CardName.transform.GetChild(2).gameObject.SetActive(false);
		}
	}

	public void GetCardData(GameObject CardName, double SpecificCardValue, string SpecificCardName, string SpecificCardNumber, int CardNumber) {
		if (SetData.ListChoice == "KC") {
			UserCards UserCards = new UserCards();
			RestClient.Get<UserCards>(SetData.FirebaseUrl + SetData.MainCardsChoice + "/" + SpecificCardNumber + "_" + SpecificCardName + "/" + SetData.ListChoice + ".json").Then(response => {
				UserCardsHaveInt = response.CardHaveInt;
				UserDuplicatesHaveInt = response.CardDuplicateInt;

				// Set Have / Not
				if (response.CardHaveInt == 1) {
					CardName.transform.GetChild(6).GetComponent<Image>().color = CardHaveOn;
					CardName.transform.GetChild(8).GetComponent<Text>().text = "$" + SpecificCardValue.ToString("n2");
					TotalCardNumbers += 1;
					TotalCardValues += SpecificCardValue;
					SetInfoText();
				}

				else {
					CardName.transform.GetChild(6).GetComponent<Image>().color = CardHaveOff;
					CardName.transform.GetChild(8).GetComponent<Text>().text = "---";
				}
			});
		}

		else {
			UserCards UserCards = new UserCards();
			RestClient.Get<UserCards>(SetData.FirebaseUrl + SetData.MainCardsChoice + "/" + SpecificCardNumber + "_" + SpecificCardName + "/" + SetData.ListChoice + ".json").Then(response2 => {
				UserCardsHaveInt = response2.CardHaveInt;
				UserDuplicatesHaveInt = response2.CardDuplicateInt;

				// Set Have / Not
				if (response2.CardHaveInt == 1) {
					CardName.transform.GetChild(7).GetComponent<Image>().color = CardHaveOn;
					CardName.transform.GetChild(9).GetComponent<Text>().text = "$" + SpecificCardValue.ToString("n2");
					CardName.transform.GetChild(13).GetComponent<Text>().text = response2.CardDuplicateInt.ToString("n0") + "\n" + "$" + (response2.CardDuplicateInt * SpecificCardValue).ToString("n2");
					TotalCardNumbers += 1;
					TotalCardValues += SpecificCardValue;
					TotalDuplicateValues += (response2.CardDuplicateInt * SpecificCardValue);
					SetInfoText();
				}

				else {
					CardName.transform.GetChild(7).GetComponent<Image>().color = CardHaveOff;
					CardName.transform.GetChild(9).GetComponent<Text>().text = "---";
					CardName.transform.GetChild(11).gameObject.SetActive(false);
					CardName.transform.GetChild(12).gameObject.SetActive(false);
					CardName.transform.GetChild(13).gameObject.SetActive(false);
				}
			});
		}
	}

	public void SetCardData(double SpecificCardValue, string SpecificCardName, string SpecificCardNumber, int CardNumber) {
		UserCards UserCards = new UserCards();
		RestClient.Put(SetData.FirebaseUrl + SetData.MainCardsChoice + "/" + SpecificCardNumber + "_" + SpecificCardName + "/" + SetData.ListChoice + ".json", UserCards);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}