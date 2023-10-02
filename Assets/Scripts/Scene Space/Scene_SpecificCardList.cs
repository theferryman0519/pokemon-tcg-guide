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
public class Scene_SpecificCardList : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public List<Image> allImages = new List<Image>();
	public List<Text> allWhiteTexts = new List<Text>();
	public List<Text> allBlueTexts = new List<Text>();
	public List<Text> allYellowTexts = new List<Text>();

	public Text TitleText;
	public Text InfoSetText;

	public Image IconImage;

	public Button GoBackButton;

	public RectTransform ScrollViewContent;

	public GameObject CardsKC;
	public GameObject CardsCarey;

	public Sprite PokeballOn;
	public Sprite PokeballOff;
	public Sprite CardBackgroundKCRegular;
	public Sprite CardBackgroundKCReverse;
	public Sprite CardBackgroundKCHolo;
	public Sprite CardBackgroundCareyRegular;
	public Sprite CardBackgroundCareyReverse;
	public Sprite CardBackgroundCareyHolo;
	
// --------------- PRIVATE VARIABLES ---------------
	Color OriginalColorImage = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	Color OriginalColorWhiteText = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	Color OriginalColorBlueText = new Color(0.208f, 0.384f, 0.6784f, 1.0f);
	Color OriginalColorYellowText = new Color(1.0f, 0.796f, 0.012f, 1.0f);

	Color AlphaColorImage = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	Color AlphaColorWhiteText = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	Color AlphaColorBlueText = new Color(0.208f, 0.384f, 0.6784f, 0.0f);
	Color AlphaColorYellowText = new Color(1.0f, 0.796f, 0.012f, 0.0f);

	Button CardAButton;
	Button CardBButton;
	Button CardADuplicateUpButton;
	Button CardADuplicateDownButton;
	Button CardBDuplicateUpButton;
	Button CardBDuplicateDownButton;
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Instantiate List
		InstantiateCardListA();

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

		// Set Icon Image
		IconImage.sprite = Data_Controller.Instance.SubSetSprite;

		// Set Title Texts
		TitleText.text = Data_Controller.Instance.SubSetTitle;

		// Start Coroutine
		Debug.Log("Scene_SpecificCardList: " + "Initiate logos fading");
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
		Debug.Log("Scene_SpecificCardList: " + "All objects fading in begin");

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
		
		Debug.Log("Scene_SpecificCardList: " + "All objects fading in end");
	}

	public IEnumerator FadeOutAll() {
		float ElapsedTime = 0.0f;
		Debug.Log("Scene_SpecificCardList: " + "All objects fading out begin");

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
		
		Debug.Log("Scene_SpecificCardList: " + "All objects fading out end");

		Data_Controller.Instance.SubSetChosen = "none";
		Data_Controller.Instance.SubSetInfo.Clear();
		Data_Controller.Instance.CardInfo.Clear();
		Debug.Log("Scene_SpecificCardList: " + "Change scenes to Main Set List");
		SceneManager.LoadScene(Core_Controller.Instance.Scene03);
	}
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	public void GoBackButtonClicking() {
		Debug.Log("Scene_SpecificCardList: " + "Button pressed for Go Back");
		StartCoroutine(FadeOutAll());
	}

	public void CardAButtonClicking(string CardJsonString, Data_CardData Card, GameObject CardObject) {
		Debug.Log("Scene_SpecificCardList: " + "Button pressed for Card A");

		// Pao
		if (Data_Controller.Instance.UserProfile == "Pao") {
			if (Card.CardKCHave == 1) {
				// Turn Off
				TurnCardOff(CardJsonString, Card, CardObject);
			}

			else if (Card.CardKCHave == 0) {
				// Turn On
				TurnCardOn(CardJsonString, Card, CardObject);
			}
		}

		// Carey
		else if (Data_Controller.Instance.UserProfile == "Carey") {
			if (Card.CardCareyHave == 1) {
				// Turn Off
				TurnCardOff(CardJsonString, Card, CardObject);
			}

			else if (Card.CardCareyHave == 0) {
				// Turn On
				TurnCardOn(CardJsonString, Card, CardObject);
			}
		}
	}

	public void CardBButtonClicking(string CardJsonString, Data_CardData Card, GameObject CardObject) {
		Debug.Log("Scene_SpecificCardList: " + "Button pressed for Card B");

		// Pao
		if (Data_Controller.Instance.UserProfile == "Pao") {
			if (Card.CardKCHave == 1) {
				// Turn Off
				TurnCardOff(CardJsonString, Card, CardObject);
			}

			else if (Card.CardKCHave == 0) {
				// Turn On
				TurnCardOn(CardJsonString, Card, CardObject);
			}
		}

		// Carey
		else if (Data_Controller.Instance.UserProfile == "Carey") {
			if (Card.CardCareyHave == 1) {
				// Turn Off
				TurnCardOff(CardJsonString, Card, CardObject);
			}

			else if (Card.CardCareyHave == 0) {
				// Turn On
				TurnCardOn(CardJsonString, Card, CardObject);
			}
		}
	}

	public void CardADuplicateDownButtonClicking(string CardJsonString, Data_CardData Card, GameObject CardObject) {
		Debug.Log("Scene_SpecificCardList: " + "Button pressed for Card A Duplicate Down");

		Card.CardCareyDuplicate -= 1;

		if (Card.CardCareyDuplicate < 0)
			Card.CardCareyDuplicate = 0;
		
		CardObject.transform.GetChild(5).GetComponent<Text>().text = Card.CardCareyDuplicate.ToString("n0");
		CardObject.transform.GetChild(7).GetComponent<Text>().text = "Duplicate Values:" + "\n" + "$" + ((double)Card.CardCareyDuplicate * Card.CardValue).ToString("n2");

		Firebase_Controller.Instance.SetNewCardInfo(CardJsonString, Card);
		UpdateFullSetText();
	}

	public void CardADuplicateUpButtonClicking(string CardJsonString, Data_CardData Card, GameObject CardObject) {
		Debug.Log("Scene_SpecificCardList: " + "Button pressed for Card A Duplicate Up");

		Card.CardCareyDuplicate += 1;

		CardObject.transform.GetChild(5).GetComponent<Text>().text = Card.CardCareyDuplicate.ToString("n0");
		CardObject.transform.GetChild(7).GetComponent<Text>().text = "Duplicate Values:" + "\n" + "$" + ((double)Card.CardCareyDuplicate * Card.CardValue).ToString("n2");

		Firebase_Controller.Instance.SetNewCardInfo(CardJsonString, Card);
		UpdateFullSetText();
	}

	public void CardBDuplicateDownButtonClicking(string CardJsonString, Data_CardData Card, GameObject CardObject) {
		Debug.Log("Scene_SpecificCardList: " + "Button pressed for Card B Duplicate Down");

		Card.CardCareyDuplicate -= 1;

		if (Card.CardCareyDuplicate < 0)
			Card.CardCareyDuplicate = 0;
		
		CardObject.transform.GetChild(5).GetComponent<Text>().text = Card.CardCareyDuplicate.ToString("n0");
		CardObject.transform.GetChild(7).GetComponent<Text>().text = "Duplicate Values:" + "\n" + "$" + ((double)Card.CardCareyDuplicate * Card.CardValue).ToString("n2");

		Firebase_Controller.Instance.SetNewCardInfo(CardJsonString, Card);
		UpdateFullSetText();
	}

	public void CardBDuplicateUpButtonClicking(string CardJsonString, Data_CardData Card, GameObject CardObject) {
		Debug.Log("Scene_SpecificCardList: " + "Button pressed for Card B Duplicate Up");

		Card.CardCareyDuplicate += 1;

		CardObject.transform.GetChild(5).GetComponent<Text>().text = Card.CardCareyDuplicate.ToString("n0");
		CardObject.transform.GetChild(7).GetComponent<Text>().text = "Duplicate Values:" + "\n" + "$" + ((double)Card.CardCareyDuplicate * Card.CardValue).ToString("n2");

		Firebase_Controller.Instance.SetNewCardInfo(CardJsonString, Card);
		UpdateFullSetText();
	}

	public void InstantiateCardListA() {
		Debug.Log("Scene_SpecificCardList: " + "Initializing instantiation part 1");
		Debug.Log("Scene_SpecificCardList: " + Data_Controller.Instance.MainSetAbbrevs[Data_Controller.Instance.SetChosen] + " / " + Data_Controller.Instance.SubSetChosen);
		Firebase_Controller.Instance.DownloadSubSetData(Data_Controller.Instance.MainSetAbbrevs[Data_Controller.Instance.SetChosen], Data_Controller.Instance.SubSetChosen);
	}

	public void InstantiateCardListB() {
		Debug.Log("Scene_SpecificCardList: " + "Initializing instantiation part 2");

		// Add Cards List
		List<Data_CardData> SpecificCardInfo = new List<Data_CardData>();

		foreach (KeyValuePair<string, Data_CardData> Card in Data_Controller.Instance.CardInfo) {
			if (Card.Key.Contains(Data_Controller.Instance.MainSetAbbrevs[Data_Controller.Instance.SetChosen] + "_" + Data_Controller.Instance.SubSetChosen + "_")) {
				SpecificCardInfo.Add(Card.Value);
			}
		}

		// Sort By Number
		SpecificCardInfo = SpecificCardInfo.OrderBy(Card => Card.CardSlotNumber).ToList();

		// Half List
		List<Data_CardData> HalvedCardList = new List<Data_CardData>();

		for (int j = 0; j < SpecificCardInfo.Count; j++) {
			if ((j % 2) == 0) {
				HalvedCardList.Add(SpecificCardInfo[j]);
			}
		}

		// // Instantiate Sub Lists
		if (Data_Controller.Instance.UserProfile == "Pao")
			ScrollViewContent.sizeDelta = new Vector2(0, (HalvedCardList.Count * 600));
		else if (Data_Controller.Instance.UserProfile == "Carey")
			ScrollViewContent.sizeDelta = new Vector2(0, (HalvedCardList.Count * 1000));
		
		int i = 0;
		int k = 0;

		int PageNum = 1;
		int SlotNum = 1;

		foreach (Data_CardData Card in HalvedCardList) {
			// Pao
			if (Data_Controller.Instance.UserProfile == "Pao") {
				GameObject PaoCard = Instantiate(CardsKC, new Vector3(0,0,0), Quaternion.identity);
				PaoCard.transform.SetParent(ScrollViewContent.transform);
				PaoCard.transform.localScale = Vector2.one;
				i++;
				PaoCard.name = "CardPair" + i;

				// Card A
				if (SpecificCardInfo[k].CardKCHave == 1) {
					PaoCard.transform.GetChild(0).name = SpecificCardInfo[k].CardJsonNumber;
					PaoCard.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = SpecificCardInfo[k].CardName;
					PaoCard.transform.GetChild(0).GetChild(1).GetComponent<Text>().text = "#: " + SpecificCardInfo[k].CardNumber + "\n" + "Type: " + SpecificCardInfo[k].CardType;
					PaoCard.transform.GetChild(0).GetChild(2).GetComponent<Image>().sprite = PokeballOn;
					PaoCard.transform.GetChild(0).GetChild(3).GetComponent<Text>().text = "Card Value: $" + SpecificCardInfo[k].CardValue.ToString("n2");
				}

				else {
					PaoCard.transform.GetChild(0).name = SpecificCardInfo[k].CardJsonNumber;
					PaoCard.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = SpecificCardInfo[k].CardName;
					PaoCard.transform.GetChild(0).GetChild(1).GetComponent<Text>().text = "#: " + SpecificCardInfo[k].CardNumber + "\n" + "Type: " + SpecificCardInfo[k].CardType;
					PaoCard.transform.GetChild(0).GetChild(2).GetComponent<Image>().sprite = PokeballOff;
					PaoCard.transform.GetChild(0).GetChild(3).GetComponent<Text>().text = "Card Value: $0.00";
				}

				string JsonButtonNumberA = SpecificCardInfo[k].CardJsonNumber;
				Data_CardData JsonCardA = SpecificCardInfo[k];

				CardAButton = PaoCard.transform.GetChild(0).GetComponent<Button>();
				CardAButton.onClick.AddListener(() => CardAButtonClicking(JsonButtonNumberA, JsonCardA, PaoCard.transform.GetChild(0).gameObject));

				// Card Type
				if (SpecificCardInfo[k].CardType == "Regular")
					PaoCard.transform.GetChild(0).GetComponent<Image>().sprite = CardBackgroundKCRegular;
				else if (SpecificCardInfo[k].CardType == "Reverse Holo")
					PaoCard.transform.GetChild(0).GetComponent<Image>().sprite = CardBackgroundKCReverse;
				else if (SpecificCardInfo[k].CardType == "Holofoil")
					PaoCard.transform.GetChild(0).GetComponent<Image>().sprite = CardBackgroundKCHolo;

				allImages.Add(PaoCard.transform.GetChild(0).GetComponent<Image>());
				allImages.Add(PaoCard.transform.GetChild(0).GetChild(2).GetComponent<Image>());
				allWhiteTexts.Add(PaoCard.transform.GetChild(0).GetChild(0).GetComponent<Text>());
				allWhiteTexts.Add(PaoCard.transform.GetChild(0).GetChild(1).GetComponent<Text>());
				allWhiteTexts.Add(PaoCard.transform.GetChild(0).GetChild(3).GetComponent<Text>());

				// Card B
				if ((k+1) < SpecificCardInfo.Count) {
					if (SpecificCardInfo[k+1].CardKCHave == 1) {
						PaoCard.transform.GetChild(1).name = SpecificCardInfo[k+1].CardJsonNumber;
						PaoCard.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = SpecificCardInfo[k+1].CardName;
						PaoCard.transform.GetChild(1).GetChild(1).GetComponent<Text>().text = "#: " + SpecificCardInfo[k+1].CardNumber + "\n" + "Type: " + SpecificCardInfo[k+1].CardType;
						PaoCard.transform.GetChild(1).GetChild(2).GetComponent<Image>().sprite = PokeballOn;
						PaoCard.transform.GetChild(1).GetChild(3).GetComponent<Text>().text = "Card Value: $" + SpecificCardInfo[k+1].CardValue.ToString("n2");
					}

					else {
						PaoCard.transform.GetChild(1).name = SpecificCardInfo[k+1].CardJsonNumber;
						PaoCard.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = SpecificCardInfo[k+1].CardName;
						PaoCard.transform.GetChild(1).GetChild(1).GetComponent<Text>().text = "#: " + SpecificCardInfo[k+1].CardNumber + "\n" + "Type: " + SpecificCardInfo[k+1].CardType;
						PaoCard.transform.GetChild(1).GetChild(2).GetComponent<Image>().sprite = PokeballOff;
						PaoCard.transform.GetChild(1).GetChild(3).GetComponent<Text>().text = "Card Value: $0.00";
					}

					string JsonButtonNumberB = SpecificCardInfo[k+1].CardJsonNumber;
					Data_CardData JsonCardB = SpecificCardInfo[k+1];

					CardBButton = PaoCard.transform.GetChild(1).GetComponent<Button>();
					CardBButton.onClick.AddListener(() => CardBButtonClicking(JsonButtonNumberB, JsonCardB, PaoCard.transform.GetChild(1).gameObject));

					// Card Type
					if (SpecificCardInfo[k+1].CardType == "Regular")
						PaoCard.transform.GetChild(1).GetComponent<Image>().sprite = CardBackgroundKCRegular;
					else if (SpecificCardInfo[k+1].CardType == "Reverse Holo")
						PaoCard.transform.GetChild(1).GetComponent<Image>().sprite = CardBackgroundKCReverse;
					else if (SpecificCardInfo[k+1].CardType == "Holofoil")
						PaoCard.transform.GetChild(1).GetComponent<Image>().sprite = CardBackgroundKCHolo;
					
					allImages.Add(PaoCard.transform.GetChild(1).GetComponent<Image>());
					allImages.Add(PaoCard.transform.GetChild(1).GetChild(2).GetComponent<Image>());
					allWhiteTexts.Add(PaoCard.transform.GetChild(1).GetChild(0).GetComponent<Text>());
					allWhiteTexts.Add(PaoCard.transform.GetChild(1).GetChild(1).GetComponent<Text>());
					allWhiteTexts.Add(PaoCard.transform.GetChild(1).GetChild(3).GetComponent<Text>());
				}

				else {
					PaoCard.transform.GetChild(1).gameObject.SetActive(false);
				}

				k += 2;
			}

			// Carey
			else if (Data_Controller.Instance.UserProfile == "Carey") {
				GameObject CareyCard = Instantiate(CardsCarey, new Vector3(0,0,0), Quaternion.identity);
				CareyCard.transform.SetParent(ScrollViewContent.transform);
				CareyCard.transform.localScale = Vector2.one;
				i++;
				CareyCard.name = "CardPair" + i;

				// Card A
				if (SpecificCardInfo[k].CardCareyHave == 1) {
					CareyCard.transform.GetChild(0).name = SpecificCardInfo[k].CardJsonNumber;
					CareyCard.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = SpecificCardInfo[k].CardName;
					CareyCard.transform.GetChild(0).GetChild(1).GetComponent<Text>().text = "#: " + SpecificCardInfo[k].CardNumber + "\n" + "Type: " + SpecificCardInfo[k].CardType;
					CareyCard.transform.GetChild(0).GetChild(2).GetComponent<Image>().sprite = PokeballOn;
					CareyCard.transform.GetChild(0).GetChild(3).GetComponent<Text>().text = "Card Value: $" + SpecificCardInfo[k].CardValue.ToString("n2");

					// Card Location
					if (SlotNum > 18) {
						PageNum += 1;
						SlotNum = 1;
					}

					CareyCard.transform.GetChild(0).GetChild(8).GetComponent<Text>().text = "Card Location: " + "\n" + "Page: " + PageNum.ToString() + " / " + "Slot: " + SlotNum.ToString();

					SlotNum += 1;

					// Duplicates
					CareyCard.transform.GetChild(0).GetChild(4).gameObject.SetActive(true);
					CareyCard.transform.GetChild(0).GetChild(5).gameObject.SetActive(true);
					CareyCard.transform.GetChild(0).GetChild(6).gameObject.SetActive(true);
					CareyCard.transform.GetChild(0).GetChild(7).gameObject.SetActive(true);

					CareyCard.transform.GetChild(0).GetChild(5).GetComponent<Text>().text = SpecificCardInfo[k].CardCareyDuplicate.ToString("n0");
					CareyCard.transform.GetChild(0).GetChild(7).GetComponent<Text>().text = "Duplicate Values:" + "\n" + "$" + ((double)SpecificCardInfo[k].CardCareyDuplicate * SpecificCardInfo[k].CardValue).ToString("n2");
				}

				else {
					CareyCard.transform.GetChild(0).name = SpecificCardInfo[k].CardJsonNumber;
					CareyCard.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = SpecificCardInfo[k].CardName;
					CareyCard.transform.GetChild(0).GetChild(1).GetComponent<Text>().text = "#: " + SpecificCardInfo[k].CardNumber + "\n" + "Type: " + SpecificCardInfo[k].CardType;
					CareyCard.transform.GetChild(0).GetChild(2).GetComponent<Image>().sprite = PokeballOff;
					CareyCard.transform.GetChild(0).GetChild(3).GetComponent<Text>().text = "Card Value: $0.00";

					// Card Location
					if (SlotNum > 18) {
						PageNum += 1;
						SlotNum = 1;
					}

					CareyCard.transform.GetChild(0).GetChild(8).GetComponent<Text>().text = "Card Location: " + "\n" + "Page: " + PageNum.ToString() + " / " + "Slot: " + SlotNum.ToString();

					SlotNum += 1;

					// Duplicates
					CareyCard.transform.GetChild(0).GetChild(4).gameObject.SetActive(false);
					CareyCard.transform.GetChild(0).GetChild(5).gameObject.SetActive(false);
					CareyCard.transform.GetChild(0).GetChild(6).gameObject.SetActive(false);
					CareyCard.transform.GetChild(0).GetChild(7).gameObject.SetActive(false);
				}

				string JsonButtonNumberA = SpecificCardInfo[k].CardJsonNumber;
				Data_CardData JsonCardA = SpecificCardInfo[k];

				CardAButton = CareyCard.transform.GetChild(0).GetChild(2).GetComponent<Button>();
				CardADuplicateDownButton = CareyCard.transform.GetChild(0).GetChild(4).GetComponent<Button>();
				CardADuplicateUpButton = CareyCard.transform.GetChild(0).GetChild(6).GetComponent<Button>();

				CardAButton.onClick.AddListener(() => CardAButtonClicking(JsonButtonNumberA, JsonCardA, CareyCard.transform.GetChild(0).gameObject));
				CardADuplicateDownButton.onClick.AddListener(() => CardADuplicateDownButtonClicking(JsonButtonNumberA, JsonCardA, CareyCard.transform.GetChild(0).gameObject));
				CardADuplicateUpButton.onClick.AddListener(() => CardADuplicateUpButtonClicking(JsonButtonNumberA, JsonCardA, CareyCard.transform.GetChild(0).gameObject));

				// Card Type
				if (SpecificCardInfo[k].CardType == "Regular")
					CareyCard.transform.GetChild(0).GetComponent<Image>().sprite = CardBackgroundCareyRegular;
				else if (SpecificCardInfo[k].CardType == "Reverse Holo")
					CareyCard.transform.GetChild(0).GetComponent<Image>().sprite = CardBackgroundCareyReverse;
				else if (SpecificCardInfo[k].CardType == "Holofoil")
					CareyCard.transform.GetChild(0).GetComponent<Image>().sprite = CardBackgroundCareyHolo;

				allImages.Add(CareyCard.transform.GetChild(0).GetComponent<Image>());
				allImages.Add(CareyCard.transform.GetChild(0).GetChild(2).GetComponent<Image>());
				allImages.Add(CareyCard.transform.GetChild(0).GetChild(4).GetComponent<Image>());
				allImages.Add(CareyCard.transform.GetChild(0).GetChild(6).GetComponent<Image>());
				allWhiteTexts.Add(CareyCard.transform.GetChild(0).GetChild(0).GetComponent<Text>());
				allWhiteTexts.Add(CareyCard.transform.GetChild(0).GetChild(1).GetComponent<Text>());
				allWhiteTexts.Add(CareyCard.transform.GetChild(0).GetChild(3).GetComponent<Text>());
				allWhiteTexts.Add(CareyCard.transform.GetChild(0).GetChild(5).GetComponent<Text>());
				allWhiteTexts.Add(CareyCard.transform.GetChild(0).GetChild(7).GetComponent<Text>());
				allWhiteTexts.Add(CareyCard.transform.GetChild(0).GetChild(8).GetComponent<Text>());

				// Card B
				if ((k+1) < SpecificCardInfo.Count) {
					if (SpecificCardInfo[k+1].CardCareyHave == 1) {
						CareyCard.transform.GetChild(1).name = SpecificCardInfo[k+1].CardJsonNumber;
						CareyCard.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = SpecificCardInfo[k+1].CardName;
						CareyCard.transform.GetChild(1).GetChild(1).GetComponent<Text>().text = "#: " + SpecificCardInfo[k+1].CardNumber + "\n" + "Type: " + SpecificCardInfo[k+1].CardType;
						CareyCard.transform.GetChild(1).GetChild(2).GetComponent<Image>().sprite = PokeballOn;
						CareyCard.transform.GetChild(1).GetChild(3).GetComponent<Text>().text = "Card Value: $" + SpecificCardInfo[k+1].CardValue.ToString("n2");

						// Card Location
						if (SlotNum > 18) {
							PageNum += 1;
							SlotNum = 1;
						}

						CareyCard.transform.GetChild(1).GetChild(8).GetComponent<Text>().text = "Card Location: " + "\n" + "Page: " + PageNum.ToString() + " / " + "Slot: " + SlotNum.ToString();

						SlotNum += 1;

						// Duplicates
						CareyCard.transform.GetChild(1).GetChild(4).gameObject.SetActive(true);
						CareyCard.transform.GetChild(1).GetChild(5).gameObject.SetActive(true);
						CareyCard.transform.GetChild(1).GetChild(6).gameObject.SetActive(true);
						CareyCard.transform.GetChild(1).GetChild(7).gameObject.SetActive(true);

						CareyCard.transform.GetChild(1).GetChild(5).GetComponent<Text>().text = SpecificCardInfo[k+1].CardCareyDuplicate.ToString("n0");
						CareyCard.transform.GetChild(1).GetChild(7).GetComponent<Text>().text = "Duplicate Values:" + "\n" + "$" + ((double)SpecificCardInfo[k+1].CardCareyDuplicate * SpecificCardInfo[k+1].CardValue).ToString("n2");
					}

					else {
						CareyCard.transform.GetChild(1).name = SpecificCardInfo[k+1].CardJsonNumber;
						CareyCard.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = SpecificCardInfo[k+1].CardName;
						CareyCard.transform.GetChild(1).GetChild(1).GetComponent<Text>().text = "#: " + SpecificCardInfo[k+1].CardNumber + "\n" + "Type: " + SpecificCardInfo[k+1].CardType;
						CareyCard.transform.GetChild(1).GetChild(2).GetComponent<Image>().sprite = PokeballOff;
						CareyCard.transform.GetChild(1).GetChild(3).GetComponent<Text>().text = "Card Value: $0.00";

						// Card Location
						if (SlotNum > 18) {
							PageNum += 1;
							SlotNum = 1;
						}

						CareyCard.transform.GetChild(1).GetChild(8).GetComponent<Text>().text = "Card Location: " + "\n" + "Page: " + PageNum.ToString() + " / " + "Slot: " + SlotNum.ToString();

						SlotNum += 1;

						// Duplicates
						CareyCard.transform.GetChild(1).GetChild(4).gameObject.SetActive(false);
						CareyCard.transform.GetChild(1).GetChild(5).gameObject.SetActive(false);
						CareyCard.transform.GetChild(1).GetChild(6).gameObject.SetActive(false);
						CareyCard.transform.GetChild(1).GetChild(7).gameObject.SetActive(false);
					}

					string JsonButtonNumberB = SpecificCardInfo[k+1].CardJsonNumber;
					Data_CardData JsonCardB = SpecificCardInfo[k+1];

					CardBButton = CareyCard.transform.GetChild(1).GetChild(2).GetComponent<Button>();
					CardBDuplicateDownButton = CareyCard.transform.GetChild(1).GetChild(4).GetComponent<Button>();
					CardBDuplicateUpButton = CareyCard.transform.GetChild(1).GetChild(6).GetComponent<Button>();

					CardBButton.onClick.AddListener(() => CardBButtonClicking(JsonButtonNumberB, JsonCardB, CareyCard.transform.GetChild(1).gameObject));
					CardBDuplicateDownButton.onClick.AddListener(() => CardBDuplicateDownButtonClicking(JsonButtonNumberB, JsonCardB, CareyCard.transform.GetChild(1).gameObject));
					CardBDuplicateUpButton.onClick.AddListener(() => CardBDuplicateUpButtonClicking(JsonButtonNumberB, JsonCardB, CareyCard.transform.GetChild(1).gameObject));

					// Card Type
					if (SpecificCardInfo[k+1].CardType == "Regular")
						CareyCard.transform.GetChild(1).GetComponent<Image>().sprite = CardBackgroundCareyRegular;
					else if (SpecificCardInfo[k+1].CardType == "Reverse Holo")
						CareyCard.transform.GetChild(1).GetComponent<Image>().sprite = CardBackgroundCareyReverse;
					else if (SpecificCardInfo[k+1].CardType == "Holofoil")
						CareyCard.transform.GetChild(1).GetComponent<Image>().sprite = CardBackgroundCareyHolo;
					
					allImages.Add(CareyCard.transform.GetChild(1).GetComponent<Image>());
					allImages.Add(CareyCard.transform.GetChild(1).GetChild(2).GetComponent<Image>());
					allImages.Add(CareyCard.transform.GetChild(1).GetChild(4).GetComponent<Image>());
					allImages.Add(CareyCard.transform.GetChild(1).GetChild(6).GetComponent<Image>());
					allWhiteTexts.Add(CareyCard.transform.GetChild(1).GetChild(0).GetComponent<Text>());
					allWhiteTexts.Add(CareyCard.transform.GetChild(1).GetChild(1).GetComponent<Text>());
					allWhiteTexts.Add(CareyCard.transform.GetChild(1).GetChild(3).GetComponent<Text>());
					allWhiteTexts.Add(CareyCard.transform.GetChild(1).GetChild(5).GetComponent<Text>());
					allWhiteTexts.Add(CareyCard.transform.GetChild(1).GetChild(7).GetComponent<Text>());
					allWhiteTexts.Add(CareyCard.transform.GetChild(1).GetChild(8).GetComponent<Text>());
				}

				else {
					CareyCard.transform.GetChild(1).gameObject.SetActive(false);
				}

				k += 2;
			}
		}

		UpdateFullSetText();
		Debug.Log("Scene_SpecificCardList: " + "All sub sets have been instantiated");
	}

	public void TurnCardOff(string CardJsonString, Data_CardData Card, GameObject CardObject) {
		Debug.Log("Scene_SpecificCardList: " + "Card is being turned off for " + CardJsonString);

		// Pao
		if (Data_Controller.Instance.UserProfile == "Pao") {
			Card.CardKCHave = 0;
			CardObject.transform.GetChild(2).GetComponent<Image>().sprite = PokeballOff;
			CardObject.transform.GetChild(3).GetComponent<Text>().text = "Card Value: $0.00";
		}

		// Carey
		else if (Data_Controller.Instance.UserProfile == "Carey") {
			Card.CardCareyHave = 0;
			Card.CardCareyDuplicate = 0;
			CardObject.transform.GetChild(2).GetComponent<Image>().sprite = PokeballOff;
			CardObject.transform.GetChild(3).GetComponent<Text>().text = "Card Value: $0.00";

			CardObject.transform.GetChild(4).gameObject.SetActive(false);
			CardObject.transform.GetChild(5).gameObject.SetActive(false);
			CardObject.transform.GetChild(6).gameObject.SetActive(false);
			CardObject.transform.GetChild(7).gameObject.SetActive(false);
		}

		Firebase_Controller.Instance.SetNewCardInfo(CardJsonString, Card);
		UpdateFullSetText();
	}

	public void TurnCardOn(string CardJsonString, Data_CardData Card, GameObject CardObject) {
		Debug.Log("Scene_SpecificCardList: " + "Card is being turned on for " + CardJsonString);

		// Pao
		if (Data_Controller.Instance.UserProfile == "Pao") {
			Card.CardKCHave = 1;
			CardObject.transform.GetChild(2).GetComponent<Image>().sprite = PokeballOn;
			CardObject.transform.GetChild(3).GetComponent<Text>().text = "Card Value: $" + Card.CardValue.ToString("n2");
		}

		// Carey
		else if (Data_Controller.Instance.UserProfile == "Carey") {
			Card.CardCareyHave = 1;
			CardObject.transform.GetChild(2).GetComponent<Image>().sprite = PokeballOn;
			CardObject.transform.GetChild(3).GetComponent<Text>().text = "Card Value: $" + Card.CardValue.ToString("n2");

			CardObject.transform.GetChild(4).gameObject.SetActive(true);
			CardObject.transform.GetChild(5).gameObject.SetActive(true);
			CardObject.transform.GetChild(6).gameObject.SetActive(true);
			CardObject.transform.GetChild(7).gameObject.SetActive(true);

			CardObject.transform.GetChild(5).GetComponent<Text>().text = Card.CardCareyDuplicate.ToString("n0");
			CardObject.transform.GetChild(7).GetComponent<Text>().text = "Duplicate Values:" + "\n" + ((double)Card.CardCareyDuplicate * Card.CardValue).ToString("n2");
		}

		Firebase_Controller.Instance.SetNewCardInfo(CardJsonString, Card);
		UpdateFullSetText();
	}

	public void UpdateFullSetText() {
		// Pao
		if (Data_Controller.Instance.UserProfile == "Pao") {
			int TotalCardsHave = 0;
			double TotalCardsValue = 0.00;

			foreach (KeyValuePair<string, Data_CardData> Card in Data_Controller.Instance.CardInfo) {
				if (Card.Key.Contains(Data_Controller.Instance.MainSetAbbrevs[Data_Controller.Instance.SetChosen] + "_" + Data_Controller.Instance.SubSetChosen + "_")) {
					TotalCardsHave += Card.Value.CardKCHave;

					if (Card.Value.CardKCHave == 1)
						TotalCardsValue += Card.Value.CardValue;
					else if (Card.Value.CardKCHave == 0)
						TotalCardsValue += 0.00;
				}
			}

			InfoSetText.text = "Set Cards Have: " + TotalCardsHave.ToString("n0") + "\n" + "Set Value: $" + TotalCardsValue.ToString("n2");
		}

		// Carey
		else if (Data_Controller.Instance.UserProfile == "Carey") {
			int TotalCardsHave = 0;
			int TotalDuplicates = 0;
			double TotalCardsValue = 0.00;
			double TotalDuplicatesValue = 0.00;

			foreach (KeyValuePair<string, Data_CardData> Card in Data_Controller.Instance.CardInfo) {
				if (Card.Key.Contains(Data_Controller.Instance.MainSetAbbrevs[Data_Controller.Instance.SetChosen] + "_" + Data_Controller.Instance.SubSetChosen + "_")) {
					TotalCardsHave += Card.Value.CardCareyHave;
					TotalDuplicates += Card.Value.CardCareyDuplicate;

					if (Card.Value.CardCareyHave == 1)
						TotalCardsValue += Card.Value.CardValue;
					else if (Card.Value.CardCareyHave == 0)
						TotalCardsValue += 0.00;
					
					if (Card.Value.CardCareyDuplicate >= 1)
						TotalDuplicatesValue += (Card.Value.CardValue * (double)Card.Value.CardCareyDuplicate);
					else if (Card.Value.CardCareyDuplicate == 0)
						TotalDuplicatesValue += 0.00;
				}
			}

			InfoSetText.text = "Set Cards Have: " + TotalCardsHave.ToString("n0") + "\n" + "Set Value: $" + TotalCardsValue.ToString("n2") + "\n\n" + "Duplicates Have: " + TotalDuplicates.ToString("n0") + "\n" + "Value: $" + TotalDuplicatesValue.ToString("n2");
		}
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}