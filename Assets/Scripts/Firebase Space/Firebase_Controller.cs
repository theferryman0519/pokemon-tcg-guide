// Main Dependencies
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

// Game Dependencies
using Proyecto26;
using DataSpace;
using SceneSpace;

namespace FirebaseSpace {
public class Firebase_Controller : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public string FirebaseUrl = "https://pokemon-tcg-guide-default-rtdb.firebaseio.com/";
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Firebase_Controller Instance {
        get {
            return Firebase_Controller_Instance;
        }
    }
    
    private static Firebase_Controller Firebase_Controller_Instance = null;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		if ((Firebase_Controller_Instance != null) && (Firebase_Controller_Instance != this)) {
            Destroy(this.gameObject);
            return;
        }
        
        else {
            Firebase_Controller_Instance = this;
        }
        
        DontDestroyOnLoad(this.gameObject);
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	public void DownloadMainSetData(string MainSet) {
        Debug.Log("Firebase_Controller: " + "Initializing main set data download");

        RestClient.Get(FirebaseUrl + "SubSetData" + ".json").Then(response => {
            string FullJsonData1 = response.Text.ToString();
            string[] SplitJsonData = FullJsonData1.Split('{','}');
            
            for (int i = 0; i < (SplitJsonData.Length - 2); i++) {
                if ((i % 2) != 0) {
                    string SubSetTitle = SplitJsonData[i].Replace('"',' ').Replace(':',' ').Replace(',',' ').Trim();
                    string SubSetInfo1 = SplitJsonData[i+1].Replace('"',' ').Trim();
                    string[] SubSetInfo = SubSetInfo1.Split(':',',');

                    Data_SubSetData SubSetData = new Data_SubSetData();

                    SubSetData.SubSetName = SubSetInfo[5].Trim().ToString();
                    SubSetData.SubSetDataName = SubSetInfo[1].Trim().ToString();
                    SubSetData.SubSetMainSetAbbrev = SubSetInfo[3].Trim().ToString();
                    SubSetData.SubSetReleaseDate = System.DateTime.Parse(SubSetInfo[7].Trim());

                    string SpriteString = SubSetData.SubSetMainSetAbbrev + "_" + SubSetData.SubSetDataName;

                    Data_Controller.Instance.SetSubSetSprite(SpriteString, SubSetData);
                    Data_Controller.Instance.SubSetInfo.Add(SpriteString, SubSetData);
                }
            }

            Debug.Log("Firebase_Controller: " + "Main set data has been successfully downloaded from Firebase");
            Scene_Controller.Instance.SuccessfulDownloadMainSetData();
		});
    }

    public void DownloadSubSetData(string MainSet, string SubSet) {
        Debug.Log("Firebase_Controller: " + "Initializing sub set data download");

        RestClient.Get(FirebaseUrl + MainSet + "/" + SubSet + ".json").Then(response => {
            string FullJsonData1 = response.Text.ToString();
            string[] SplitJsonData = FullJsonData1.Split('{','}');
            
            for (int i = 0; i < (SplitJsonData.Length - 2); i++) {
                if ((i % 2) != 0) {
                    string CardJsonTitle = SplitJsonData[i].Replace('"',' ').Replace(':',' ').Replace(',',' ').Trim();
                    string CardJsonInfo1 = SplitJsonData[i+1].Replace('"',' ').Trim();
                    string[] CardInfo = CardJsonInfo1.Split(':',',');

                    Data_CardData CardData = new Data_CardData();

                    CardData.CardName = CardInfo[1].Trim().ToString();
                    CardData.CardNumber = CardInfo[3].Trim().ToString();
                    CardData.CardJsonNumber = CardJsonTitle.Trim().ToString();
                    CardData.CardType = CardInfo[7].Trim().ToString();

                    CardData.CardValue = double.Parse(CardInfo[9].Trim());

                    CardData.CardCareyHave = System.Int32.Parse(CardInfo[13].Trim());
                    CardData.CardCareyDuplicate = System.Int32.Parse(CardInfo[11].Trim());
                    CardData.CardKCHave = System.Int32.Parse(CardInfo[15].Trim());
                    CardData.CardSlotNumber = System.Int32.Parse(CardInfo[5].Trim());

                    string CardString = MainSet + "_" + SubSet + "_" + CardData.CardJsonNumber;

                    Data_Controller.Instance.CardInfo.Add(CardString, CardData);
                }
            }

            Debug.Log("Firebase_Controller: " + "Sub set data has been successfully downloaded from Firebase");
            Scene_Controller.Instance.SuccessfulDownloadSubSetData();
		});
    }

    public void DownloadAllData() {
        Debug.Log("Firebase_Controller: " + "Initializing all data download");

        RestClient.Get(FirebaseUrl + "SubSetData" + ".json").Then(response => {
            string FullJsonData1 = response.Text.ToString();
            string[] SplitJsonData = FullJsonData1.Split('{','}');
            
            for (int i = 0; i < (SplitJsonData.Length - 2); i++) {
                if ((i % 2) != 0) {
                    string SubSetTitle = SplitJsonData[i].Replace('"',' ').Replace(':',' ').Replace(',',' ').Trim();
                    string SubSetInfo1 = SplitJsonData[i+1].Replace('"',' ').Trim();
                    string[] SubSetInfo = SubSetInfo1.Split(':',',');

                    Data_SubSetData SubSetData = new Data_SubSetData();

                    SubSetData.SubSetName = SubSetInfo[5].Trim().ToString();
                    SubSetData.SubSetDataName = SubSetInfo[1].Trim().ToString();
                    SubSetData.SubSetMainSetAbbrev = SubSetInfo[3].Trim().ToString();
                    SubSetData.SubSetReleaseDate = System.DateTime.Parse(SubSetInfo[7].Trim());

                    string SpriteString = SubSetData.SubSetMainSetAbbrev + "_" + SubSetData.SubSetDataName;

                    Data_Controller.Instance.SetSubSetSprite(SpriteString, SubSetData);
                    Data_Controller.Instance.SubSetInfo.Add(SpriteString, SubSetData);
                }
            }

            Scene_Controller.Instance.InstantiateFullData();
            // DownloadAllDataB();
        });
    }

    public void DownloadSubSetDataB(string MainSet, string SubSet) {
        Debug.Log("Firebase_Controller: " + "Initializing sub set data download");

        RestClient.Get(FirebaseUrl + MainSet + "/" + SubSet + ".json").Then(response => {
            string FullJsonData1 = response.Text.ToString();
            string[] SplitJsonData = FullJsonData1.Split('{','}');
            
            for (int i = 0; i < (SplitJsonData.Length - 2); i++) {
                if ((i % 2) != 0) {
                    string CardJsonTitle = SplitJsonData[i].Replace('"',' ').Replace(':',' ').Replace(',',' ').Trim();
                    string CardJsonInfo1 = SplitJsonData[i+1].Replace('"',' ').Trim();
                    string[] CardInfo = CardJsonInfo1.Split(':',',');

                    Data_CardData CardData = new Data_CardData();

                    CardData.CardName = CardInfo[1].Trim().ToString();
                    CardData.CardNumber = CardInfo[3].Trim().ToString();
                    CardData.CardJsonNumber = CardJsonTitle.Trim().ToString();
                    CardData.CardType = CardInfo[7].Trim().ToString();

                    CardData.CardValue = double.Parse(CardInfo[9].Trim());

                    CardData.CardCareyHave = System.Int32.Parse(CardInfo[13].Trim());
                    CardData.CardCareyDuplicate = System.Int32.Parse(CardInfo[11].Trim());
                    CardData.CardKCHave = System.Int32.Parse(CardInfo[15].Trim());
                    CardData.CardSlotNumber = System.Int32.Parse(CardInfo[5].Trim());

                    string CardString = MainSet + "_" + SubSet + "_" + CardData.CardJsonNumber;

                    Data_Controller.Instance.CardInfo.Add(CardString, CardData);
                }
            }

            Debug.Log("Firebase_Controller: " + "Sub set data has been successfully downloaded from Firebase");
            Scene_Controller.Instance.InstantiateFullCardData();
		});
    }

    public void SetNewCardInfo(string CardJsonString, Data_CardData Card) {
        Debug.Log("Firebase_Controller: " + "Initializing updating card data");

        Data_Controller.Instance.UpdatedCardName = Card.CardName;
		Data_Controller.Instance.UpdatedCardNumber = Card.CardNumber;
		Data_Controller.Instance.UpdatedCardType = Card.CardType;
		Data_Controller.Instance.UpdatedCardValue = Card.CardValue;
		Data_Controller.Instance.UpdatedCardCareyHave = Card.CardCareyHave;
		Data_Controller.Instance.UpdatedCardCareyDuplicate = Card.CardCareyDuplicate;
		Data_Controller.Instance.UpdatedCardKCHave = Card.CardKCHave;
		Data_Controller.Instance.UpdatedCardSlotNumber = Card.CardSlotNumber;

        Data_Card UpdatedCard = new Data_Card();

		RestClient.Put(FirebaseUrl + Data_Controller.Instance.MainSetAbbrevs[Data_Controller.Instance.SetChosen] + "/" + Data_Controller.Instance.SubSetChosen + "/" + CardJsonString + ".json", UpdatedCard);

        Data_Controller.Instance.UpdatedCardName = "none";
		Data_Controller.Instance.UpdatedCardNumber = "none";
		Data_Controller.Instance.UpdatedCardType = "none";
		Data_Controller.Instance.UpdatedCardValue = 0.00;
		Data_Controller.Instance.UpdatedCardCareyHave = 0;
		Data_Controller.Instance.UpdatedCardCareyDuplicate = 0;
		Data_Controller.Instance.UpdatedCardKCHave = 0;
		Data_Controller.Instance.UpdatedCardSlotNumber = 0;

        Debug.Log("Firebase_Controller: " + "Card data has been successfully updated on Firebase");
    }
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}