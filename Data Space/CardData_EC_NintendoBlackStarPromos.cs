using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_EC_NintendoBlackStarPromos : MonoBehaviour {
		
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
CardDataNumbers.Add(19,"19");
CardDataNumbers.Add(20,"20");
CardDataNumbers.Add(21,"21");
CardDataNumbers.Add(22,"22");
CardDataNumbers.Add(23,"23");
CardDataNumbers.Add(24,"24");
CardDataNumbers.Add(25,"25");
CardDataNumbers.Add(26,"26");
CardDataNumbers.Add(27,"29");
CardDataNumbers.Add(28,"30");
CardDataNumbers.Add(29,"31");
CardDataNumbers.Add(30,"32");
CardDataNumbers.Add(31,"33");
CardDataNumbers.Add(32,"34");
CardDataNumbers.Add(33,"35");
CardDataNumbers.Add(34,"37");
CardDataNumbers.Add(35,"38");
CardDataNumbers.Add(36,"39");
CardDataNumbers.Add(37,"40");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Kyogre ex");
CardDataNames.Add(2,"Groudon ex");
CardDataNames.Add(3,"Treecko");
CardDataNames.Add(4,"Grovyle");
CardDataNames.Add(5,"Mudkip");
CardDataNames.Add(6,"Torchic");
CardDataNames.Add(7,"Treecko");
CardDataNames.Add(8,"Torchic");
CardDataNames.Add(9,"Combusken");
CardDataNames.Add(10,"Mudkip");
CardDataNames.Add(11,"Marshtomp");
CardDataNames.Add(12,"Pikachu");
CardDataNames.Add(13,"Meowth");
CardDataNames.Add(14,"Latias");
CardDataNames.Add(15,"Latios");
CardDataNames.Add(16,"Treecko");
CardDataNames.Add(17,"Torchic");
CardDataNames.Add(18,"Mudkip");
CardDataNames.Add(19,"Whismur");
CardDataNames.Add(20,"Ludicolo");
CardDataNames.Add(21,"Jirachi");
CardDataNames.Add(22,"Beldum");
CardDataNames.Add(23,"Metang");
CardDataNames.Add(24,"Chimecho");
CardDataNames.Add(25,"Flygon");
CardDataNames.Add(26,"Tropical Wind");
CardDataNames.Add(27,"Celebi");
CardDataNames.Add(28,"Suicune");
CardDataNames.Add(29,"Moltres ex");
CardDataNames.Add(30,"Articuno ex");
CardDataNames.Add(31,"Zapdos ex");
CardDataNames.Add(32,"Typhlosion");
CardDataNames.Add(33,"Pikachu");
CardDataNames.Add(34,"Kyogre ex");
CardDataNames.Add(35,"Groudon ex");
CardDataNames.Add(36,"Rayquaza ex");
CardDataNames.Add(37,"Mew");
	}

	public void SetCardValues() {
CardDataValues.Add(1,10.71);
CardDataValues.Add(2,7.92);
CardDataValues.Add(3,5.02);
CardDataValues.Add(4,64.5);
CardDataValues.Add(5,350);
CardDataValues.Add(6,8.5);
CardDataValues.Add(7,8.75);
CardDataValues.Add(8,9.78);
CardDataValues.Add(9,35.93);
CardDataValues.Add(10,10.13);
CardDataValues.Add(11,36.17);
CardDataValues.Add(12,18.91);
CardDataValues.Add(13,3.21);
CardDataValues.Add(14,4.09);
CardDataValues.Add(15,4.49);
CardDataValues.Add(16,19.01);
CardDataValues.Add(17,3);
CardDataValues.Add(18,19.9);
CardDataValues.Add(19,2.99);
CardDataValues.Add(20,2.87);
CardDataValues.Add(21,6.15);
CardDataValues.Add(22,29.99);
CardDataValues.Add(23,869.92);
CardDataValues.Add(24,63.95);
CardDataValues.Add(25,137.94);
CardDataValues.Add(26,192.5);
CardDataValues.Add(27,15.18);
CardDataValues.Add(28,14.3);
CardDataValues.Add(29,35.8);
CardDataValues.Add(30,43.78);
CardDataValues.Add(31,58.22);
CardDataValues.Add(32,25.6);
CardDataValues.Add(33,73.5);
CardDataValues.Add(34,27.84);
CardDataValues.Add(35,28.41);
CardDataValues.Add(36,52.04);
CardDataValues.Add(37,20.06);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}