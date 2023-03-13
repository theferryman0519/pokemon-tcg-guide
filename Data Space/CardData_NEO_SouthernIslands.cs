using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_NEO_SouthernIslands : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Dictionary <int, string> CardDataNumbers = new Dictionary<int, string>();
	public static Dictionary <int, string> CardDataNames = new Dictionary<int, string>();
	public static Dictionary <int, double> CardDataValues = new Dictionary<int, double>();
	
	public static int CardDataTotal;
	public static double CardDataTotalValue;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		SetCardNumbers();
		SetCardNames();
		SetCardValues();
		SetCardTotals();
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	public void SetCardTotals() {
		CardDataTotal = CardDataNumbers.Count;
		
		foreach (double Value in CardDataValues.Values) {
			CardDataTotalValue = CardDataTotalValue + Value;
		}
	}

	public void SetCardNumbers() {
CardDataNumbers.Add(1,"1");
CardDataNumbers.Add(2,"2");
CardDataNumbers.Add(3,"3");
CardDataNumbers.Add(4,"4");
CardDataNumbers.Add(5,"5");
CardDataNumbers.Add(6,"6");
CardDataNumbers.Add(7,"7");
CardDataNumbers.Add(8,"8");
CardDataNumbers.Add(9,"9");
CardDataNumbers.Add(10,"10");
CardDataNumbers.Add(11,"11");
CardDataNumbers.Add(12,"12");
CardDataNumbers.Add(13,"13");
CardDataNumbers.Add(14,"14");
CardDataNumbers.Add(15,"15");
CardDataNumbers.Add(16,"16");
CardDataNumbers.Add(17,"17");
CardDataNumbers.Add(18,"18");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Mew");
CardDataNames.Add(2,"Pidgeot");
CardDataNames.Add(3,"Onix");
CardDataNames.Add(4,"Togepi");
CardDataNames.Add(5,"Ivysaur");
CardDataNames.Add(6,"Raticate");
CardDataNames.Add(7,"Ledyba");
CardDataNames.Add(8,"Jigglypuff");
CardDataNames.Add(9,"Butterfree");
CardDataNames.Add(10,"Tentacruel");
CardDataNames.Add(11,"Marill");
CardDataNames.Add(12,"Lapras");
CardDataNames.Add(13,"Exeggutor");
CardDataNames.Add(14,"Slowking");
CardDataNames.Add(15,"Wartortle");
CardDataNames.Add(16,"Lickitung");
CardDataNames.Add(17,"Vileplume");
CardDataNames.Add(18,"Primeape");
	}

	public void SetCardValues() {
CardDataValues.Add(1,92.67);
CardDataValues.Add(2,14.04);
CardDataValues.Add(3,19.97);
CardDataValues.Add(4,35.34);
CardDataValues.Add(5,16.86);
CardDataValues.Add(6,10.44);
CardDataValues.Add(7,17.6);
CardDataValues.Add(8,26.12);
CardDataValues.Add(9,13);
CardDataValues.Add(10,14.36);
CardDataValues.Add(11,19.81);
CardDataValues.Add(12,20.11);
CardDataValues.Add(13,9.99);
CardDataValues.Add(14,36);
CardDataValues.Add(15,16.2);
CardDataValues.Add(16,12.7);
CardDataValues.Add(17,19.07);
CardDataValues.Add(18,8.23);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}