using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_EX_PopSeries3 : MonoBehaviour {
		
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
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Blastoise");
CardDataNames.Add(2,"Blastoise Reverse Holo");
CardDataNames.Add(3,"Blastoise Holofoil");
CardDataNames.Add(4,"Flareon");
CardDataNames.Add(5,"Flareon Reverse Holo");
CardDataNames.Add(6,"Flareon Holofoil");
CardDataNames.Add(7,"Jolteon");
CardDataNames.Add(8,"Jolteon Reverse Holo");
CardDataNames.Add(9,"Jolteon Holofoil");
CardDataNames.Add(10,"Minun");
CardDataNames.Add(11,"Minun Reverse Holo");
CardDataNames.Add(12,"Minun Holofoil");
CardDataNames.Add(13,"Plusle");
CardDataNames.Add(14,"Plusle Reverse Holo");
CardDataNames.Add(15,"Plusle Holofoil");
CardDataNames.Add(16,"Vaporeon");
CardDataNames.Add(17,"Vaporeon Reverse Holo");
CardDataNames.Add(18,"Vaporeon Holofoil");
CardDataNames.Add(19,"Combusken");
CardDataNames.Add(20,"Combusken Reverse Holo");
CardDataNames.Add(21,"Combusken Holofoil");
CardDataNames.Add(22,"Donphan");
CardDataNames.Add(23,"Donphan Reverse Holo");
CardDataNames.Add(24,"Donphan Holofoil");
CardDataNames.Add(25,"Forretress");
CardDataNames.Add(26,"Forretress Reverse Holo");
CardDataNames.Add(27,"Forretress Holofoil");
CardDataNames.Add(28,"High Pressure System");
CardDataNames.Add(29,"High Pressure System Reverse Holo");
CardDataNames.Add(30,"High Pressure System Holofoil");
CardDataNames.Add(31,"Low Pressure System");
CardDataNames.Add(32,"Low Pressure System Reverse Holo");
CardDataNames.Add(33,"Low Pressure System Holofoil");
CardDataNames.Add(34,"Ditto");
CardDataNames.Add(35,"Ditto Reverse Holo");
CardDataNames.Add(36,"Ditto Holofoil");
CardDataNames.Add(37,"Eevee");
CardDataNames.Add(38,"Eevee Reverse Holo");
CardDataNames.Add(39,"Eevee Holofoil");
CardDataNames.Add(40,"Ivysaur");
CardDataNames.Add(41,"Ivysaur Reverse Holo");
CardDataNames.Add(42,"Ivysaur Holofoil");
CardDataNames.Add(43,"Marshtomp");
CardDataNames.Add(44,"Marshtomp Reverse Holo");
CardDataNames.Add(45,"Marshtomp Holofoil");
CardDataNames.Add(46,"Pichu Bros");
CardDataNames.Add(47,"Pichu Bros Reverse Holo");
CardDataNames.Add(48,"Pichu Bros Holofoil");
CardDataNames.Add(49,"Ho-Oh ex");
	}

	public void SetCardValues() {
CardDataValues.Add(1,99.95);
CardDataValues.Add(2,239.88);
CardDataValues.Add(3,479.76);
CardDataValues.Add(4,25.01);
CardDataValues.Add(5,60.024);
CardDataValues.Add(6,120.048);
CardDataValues.Add(7,15);
CardDataValues.Add(8,36);
CardDataValues.Add(9,72);
CardDataValues.Add(10,5.78);
CardDataValues.Add(11,13.872);
CardDataValues.Add(12,27.744);
CardDataValues.Add(13,5);
CardDataValues.Add(14,12);
CardDataValues.Add(15,24);
CardDataValues.Add(16,17.01);
CardDataValues.Add(17,40.824);
CardDataValues.Add(18,81.648);
CardDataValues.Add(19,10.44);
CardDataValues.Add(20,25.056);
CardDataValues.Add(21,50.112);
CardDataValues.Add(22,10.95);
CardDataValues.Add(23,26.28);
CardDataValues.Add(24,52.56);
CardDataValues.Add(25,9.9);
CardDataValues.Add(26,23.76);
CardDataValues.Add(27,47.52);
CardDataValues.Add(28,4.24);
CardDataValues.Add(29,10.176);
CardDataValues.Add(30,20.352);
CardDataValues.Add(31,4.99);
CardDataValues.Add(32,11.976);
CardDataValues.Add(33,23.952);
CardDataValues.Add(34,8.18);
CardDataValues.Add(35,19.632);
CardDataValues.Add(36,39.264);
CardDataValues.Add(37,11.99);
CardDataValues.Add(38,28.776);
CardDataValues.Add(39,57.552);
CardDataValues.Add(40,3.45);
CardDataValues.Add(41,8.28);
CardDataValues.Add(42,16.56);
CardDataValues.Add(43,0.99);
CardDataValues.Add(44,2.376);
CardDataValues.Add(45,4.752);
CardDataValues.Add(46,24.98);
CardDataValues.Add(47,59.952);
CardDataValues.Add(48,119.904);
CardDataValues.Add(49,169.93);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}