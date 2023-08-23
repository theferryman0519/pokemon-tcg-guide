// Main Dependencies
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

// Game Dependencies

namespace DataSpace {
public class Data_Card {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public string CardName;
	public string CardNumber;
	public string CardType;
	public double CardValue;
	public int CareyHave;
	public int CareyDuplicate;
	public int KCHave;
	public int CardSlotNumber;

	public Data_Card() {
		CardName = Data_Controller.Instance.UpdatedCardName;
		CardNumber = Data_Controller.Instance.UpdatedCardNumber;
		CardType = Data_Controller.Instance.UpdatedCardType;
		CardValue = Data_Controller.Instance.UpdatedCardValue;
		CareyHave = Data_Controller.Instance.UpdatedCardCareyHave;
		CareyDuplicate = Data_Controller.Instance.UpdatedCardCareyDuplicate;
		KCHave = Data_Controller.Instance.UpdatedCardKCHave;
		CardSlotNumber = Data_Controller.Instance.UpdatedCardSlotNumber;
	}
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}