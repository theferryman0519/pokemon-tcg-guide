using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_PLAT_PopSeries9 : MonoBehaviour {
		
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
CardDataNumbers.Add(2,"1H");
CardDataNumbers.Add(3,"1RH");
CardDataNumbers.Add(4,"2");
CardDataNumbers.Add(5,"2H");
CardDataNumbers.Add(6,"2RH");
CardDataNumbers.Add(7,"3");
CardDataNumbers.Add(8,"3H");
CardDataNumbers.Add(9,"3RH");
CardDataNumbers.Add(10,"4");
CardDataNumbers.Add(11,"4H");
CardDataNumbers.Add(12,"4RH");
CardDataNumbers.Add(13,"5");
CardDataNumbers.Add(14,"5H");
CardDataNumbers.Add(15,"5RH");
CardDataNumbers.Add(16,"6");
CardDataNumbers.Add(17,"6H");
CardDataNumbers.Add(18,"6RH");
CardDataNumbers.Add(19,"7");
CardDataNumbers.Add(20,"7H");
CardDataNumbers.Add(21,"7RH");
CardDataNumbers.Add(22,"8");
CardDataNumbers.Add(23,"8H");
CardDataNumbers.Add(24,"8RH");
CardDataNumbers.Add(25,"9");
CardDataNumbers.Add(26,"9H");
CardDataNumbers.Add(27,"9RH");
CardDataNumbers.Add(28,"10");
CardDataNumbers.Add(29,"10H");
CardDataNumbers.Add(30,"10RH");
CardDataNumbers.Add(31,"11");
CardDataNumbers.Add(32,"11H");
CardDataNumbers.Add(33,"11RH");
CardDataNumbers.Add(34,"12");
CardDataNumbers.Add(35,"12H");
CardDataNumbers.Add(36,"12RH");
CardDataNumbers.Add(37,"13");
CardDataNumbers.Add(38,"13H");
CardDataNumbers.Add(39,"13RH");
CardDataNumbers.Add(40,"14");
CardDataNumbers.Add(41,"14H");
CardDataNumbers.Add(42,"14RH");
CardDataNumbers.Add(43,"15");
CardDataNumbers.Add(44,"15H");
CardDataNumbers.Add(45,"15RH");
CardDataNumbers.Add(46,"16");
CardDataNumbers.Add(47,"16H");
CardDataNumbers.Add(48,"16RH");
CardDataNumbers.Add(49,"17");
CardDataNumbers.Add(50,"17H");
CardDataNumbers.Add(51,"17RH");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Garchomp");
CardDataNames.Add(2,"Garchomp Holofoil");
CardDataNames.Add(3,"Garchomp Reverse Holo");
CardDataNames.Add(4,"Manaphy");
CardDataNames.Add(5,"Manaphy Holofoil");
CardDataNames.Add(6,"Manaphy Reverse Holo");
CardDataNames.Add(7,"Raichu");
CardDataNames.Add(8,"Raichu Holofoil");
CardDataNames.Add(9,"Raichu Reverse Holo");
CardDataNames.Add(10,"Regigigas");
CardDataNames.Add(11,"Regigigas Holofoil");
CardDataNames.Add(12,"Regigigas Reverse Holo");
CardDataNames.Add(13,"Rotom");
CardDataNames.Add(14,"Rotom Holofoil");
CardDataNames.Add(15,"Rotom Reverse Holo");
CardDataNames.Add(16,"Buizel");
CardDataNames.Add(17,"Buizel Holofoil");
CardDataNames.Add(18,"Buizel Reverse Holo");
CardDataNames.Add(19,"Croagunk");
CardDataNames.Add(20,"Croagunk Holofoil");
CardDataNames.Add(21,"Croagunk Reverse Holo");
CardDataNames.Add(22,"Gabite");
CardDataNames.Add(23,"Gabite Holofoil");
CardDataNames.Add(24,"Gabite Reverse Holo");
CardDataNames.Add(25,"Lopunny");
CardDataNames.Add(26,"Lopunny Holofoil");
CardDataNames.Add(27,"Lopunny Reverse Holo");
CardDataNames.Add(28,"Pachirisu");
CardDataNames.Add(29,"Pachirisu Holofoil");
CardDataNames.Add(30,"Pachirisu Reverse Holo");
CardDataNames.Add(31,"Pichu");
CardDataNames.Add(32,"Pichu Holofoil");
CardDataNames.Add(33,"Pichu Reverse Holo");
CardDataNames.Add(34,"Buneary");
CardDataNames.Add(35,"Buneary Holofoil");
CardDataNames.Add(36,"Buneary Reverse Holo");
CardDataNames.Add(37,"Chimchar");
CardDataNames.Add(38,"Chimchar Holofoil");
CardDataNames.Add(39,"Chimchar Reverse Holo");
CardDataNames.Add(40,"Gible");
CardDataNames.Add(41,"Gible Holofoil");
CardDataNames.Add(42,"Gible Reverse Holo");
CardDataNames.Add(43,"Pikachu");
CardDataNames.Add(44,"Pikachu Holofoil");
CardDataNames.Add(45,"Pikachu Reverse Holo");
CardDataNames.Add(46,"Piplup");
CardDataNames.Add(47,"Piplup Holofoil");
CardDataNames.Add(48,"Piplup Reverse Holo");
CardDataNames.Add(49,"Turtwig");
CardDataNames.Add(50,"Turtwig Holofoil");
CardDataNames.Add(51,"Turtwig Reverse Holo");
	}

	public void SetCardValues() {
CardDataValues.Add(1,8.47);
CardDataValues.Add(2,40.656);
CardDataValues.Add(3,20.328);
CardDataValues.Add(4,4);
CardDataValues.Add(5,19.2);
CardDataValues.Add(6,9.6);
CardDataValues.Add(7,3.99);
CardDataValues.Add(8,19.152);
CardDataValues.Add(9,9.576);
CardDataValues.Add(10,2.45);
CardDataValues.Add(11,11.76);
CardDataValues.Add(12,5.88);
CardDataValues.Add(13,2.74);
CardDataValues.Add(14,13.152);
CardDataValues.Add(15,6.576);
CardDataValues.Add(16,5.1);
CardDataValues.Add(17,24.48);
CardDataValues.Add(18,12.24);
CardDataValues.Add(19,5);
CardDataValues.Add(20,24);
CardDataValues.Add(21,12);
CardDataValues.Add(22,5.17);
CardDataValues.Add(23,24.816);
CardDataValues.Add(24,12.408);
CardDataValues.Add(25,0.6);
CardDataValues.Add(26,2.88);
CardDataValues.Add(27,1.44);
CardDataValues.Add(28,3.8);
CardDataValues.Add(29,18.24);
CardDataValues.Add(30,9.12);
CardDataValues.Add(31,9.13);
CardDataValues.Add(32,43.824);
CardDataValues.Add(33,21.912);
CardDataValues.Add(34,0.54);
CardDataValues.Add(35,2.592);
CardDataValues.Add(36,1.296);
CardDataValues.Add(37,0.55);
CardDataValues.Add(38,2.64);
CardDataValues.Add(39,1.32);
CardDataValues.Add(40,0.61);
CardDataValues.Add(41,2.928);
CardDataValues.Add(42,1.464);
CardDataValues.Add(43,4.72);
CardDataValues.Add(44,22.656);
CardDataValues.Add(45,11.328);
CardDataValues.Add(46,1.17);
CardDataValues.Add(47,5.616);
CardDataValues.Add(48,2.808);
CardDataValues.Add(49,0.6);
CardDataValues.Add(50,2.88);
CardDataValues.Add(51,1.44);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}