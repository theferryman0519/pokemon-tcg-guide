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
			// string FullJsonData1 = response.Text.ToString();
            // string FullJsonData2 = FullJsonData1.Replace('{',' ');
            // string FullJsonData3 = FullJsonData2.Replace('}',' ');
            // string FullJsonData4 = FullJsonData3.Replace('"',' ');
            // string[] SplitJsonData = FullJsonData4.Split(',',':');

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
                    SubSetData.SubSetReleaseDate = SubSetInfo[7].Trim().ToString();

                    string SpriteString = SubSetData.SubSetMainSetAbbrev + "_" + SubSetData.SubSetDataName;

                    Data_Controller.Instance.SetSubSetSprite(SpriteString, SubSetData);
                    Data_Controller.Instance.SubSetInfo.Add(SpriteString, SubSetData);
                    // Debug.Log("Firebase_Controller: " + "Adding data into dictionary for " + SpriteString);
                }
            }

            Debug.Log("Firebase_Controller: " + "Main set data has been successfully downloaded from Firebase");
            Scene_Controller.Instance.SuccessfulDownloadMainSetData();
		});
    }
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}