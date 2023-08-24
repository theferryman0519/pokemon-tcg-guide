// Main Dependencies
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

// Game Dependencies
using DataSpace;

namespace SceneSpace {
public class Scene_Controller : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Scene_Controller Instance {
        get {
            return Scene_Controller_Instance;
        }
    }
    
    private static Scene_Controller Scene_Controller_Instance = null;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		if ((Scene_Controller_Instance != null) && (Scene_Controller_Instance != this)) {
            Destroy(this.gameObject);
            return;
        }
        
        else {
            Scene_Controller_Instance = this;
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
	public void SuccessfulDownloadMainSetData() {
        Debug.Log("Scene_Controller: " + "Successfully downloaded the main set data");
        GameObject.Find("MainFunctions").GetComponentInChildren<Scene_SpecificSetList>().InstantiateSubSetListB();
    }

    public void SuccessfulDownloadSubSetData() {
        Debug.Log("Scene_Controller: " + "Successfully downloaded the sub set data");
        GameObject.Find("MainFunctions").GetComponentInChildren<Scene_SpecificCardList>().InstantiateCardListB();
    }

    public void InstantiateFullData() {
        Debug.Log("Scene_Controller: " + "Successfully downloaded all data");
        GameObject.Find("MainFunctions").GetComponentInChildren<Scene_AllStats>().InstantiateSubSetListB();
    }

    public void InstantiateFullCardData() {
        Debug.Log("Scene_Controller: " + "Successfully downloaded all card data for this sub set");

        Data_Controller.Instance.AllStatsTracker += 1;

        if (Data_Controller.Instance.AllStatsTracker >= (Data_Controller.Instance.SubSetInfo.Count - 2)) {
            Debug.Log("Scene_Controller: " + "Successfully download every piece of card data for all stats");
            GameObject.Find("MainFunctions").GetComponentInChildren<Scene_AllStats>().InputAllData();
        }
    }
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}