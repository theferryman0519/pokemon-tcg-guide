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
        if (SceneManager.GetActiveScene().name == "03SpecificSetList") {
            Debug.Log("Scene_Controller: " + "Successfully downloaded the main set data");
            GameObject.Find("MainFunctions").GetComponentInChildren<Scene_SpecificSetList>().InstantiateSubSetListB();
        }
    }
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}