using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_EX_PopSeries5 : MonoBehaviour {
		
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
CardDataNumbers.Add(47,"17");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Ho-Oh");
CardDataNames.Add(2,"Ho-Oh Reverse Holo");
CardDataNames.Add(3,"Ho-Oh Holofoil");
CardDataNames.Add(4,"Lugia");
CardDataNames.Add(5,"Lugia Reverse Holo");
CardDataNames.Add(6,"Lugia Holofoil");
CardDataNames.Add(7,"Mew");
CardDataNames.Add(8,"Mew Reverse Holo");
CardDataNames.Add(9,"Mew Holofoil");
CardDataNames.Add(10,"Double Rainbow Energy");
CardDataNames.Add(11,"Double Rainbow Energy Reverse Holo");
CardDataNames.Add(12,"Double Rainbow Energy Holofoil");
CardDataNames.Add(13,"Charmeleon");
CardDataNames.Add(14,"Charmeleon Reverse Holo");
CardDataNames.Add(15,"Charmeleon Holofoil");
CardDataNames.Add(16,"Bill's Maintenance");
CardDataNames.Add(17,"Bill's Maintenance Reverse Holo");
CardDataNames.Add(18,"Bill's Maintenance Holofoil");
CardDataNames.Add(19,"Rare Candy");
CardDataNames.Add(20,"Rare Candy Reverse Holo");
CardDataNames.Add(21,"Rare Candy Holofoil");
CardDataNames.Add(22,"Boost Energy");
CardDataNames.Add(23,"Boost Energy Reverse Holo");
CardDataNames.Add(24,"Boost Energy Holofoil");
CardDataNames.Add(25,"Delta Rainbow Energy");
CardDataNames.Add(26,"Delta Rainbow Energy Reverse Holo");
CardDataNames.Add(27,"Delta Rainbow Energy Holofoil");
CardDataNames.Add(28,"Charmander");
CardDataNames.Add(29,"Charmander Reverse Holo");
CardDataNames.Add(30,"Charmander Holofoil");
CardDataNames.Add(31,"Meowth");
CardDataNames.Add(32,"Meowth Reverse Holo");
CardDataNames.Add(33,"Meowth Holofoil");
CardDataNames.Add(34,"Pikachu");
CardDataNames.Add(35,"Pikachu Reverse Holo");
CardDataNames.Add(36,"Pikachu Holofoil");
CardDataNames.Add(37,"Pikachu");
CardDataNames.Add(38,"Pikachu Reverse Holo");
CardDataNames.Add(39,"Pikachu Holofoil");
CardDataNames.Add(40,"Pelipper");
CardDataNames.Add(41,"Pelipper Reverse Holo");
CardDataNames.Add(42,"Pelipper Holofoil");
CardDataNames.Add(43,"Zangoose");
CardDataNames.Add(44,"Zangoose Reverse Holo");
CardDataNames.Add(45,"Zangoose Holofoil");
CardDataNames.Add(46,"Espeon Star");
CardDataNames.Add(47,"Umbreon Star");
	}

	public void SetCardValues() {
CardDataValues.Add(1,6.75);
CardDataValues.Add(2,16.2);
CardDataValues.Add(3,32.4);
CardDataValues.Add(4,99.5);
CardDataValues.Add(5,238.8);
CardDataValues.Add(6,477.6);
CardDataValues.Add(7,139.3);
CardDataValues.Add(8,334.32);
CardDataValues.Add(9,668.64);
CardDataValues.Add(10,30.49);
CardDataValues.Add(11,73.176);
CardDataValues.Add(12,146.352);
CardDataValues.Add(13,23);
CardDataValues.Add(14,55.2);
CardDataValues.Add(15,110.4);
CardDataValues.Add(16,1.99);
CardDataValues.Add(17,4.776);
CardDataValues.Add(18,9.552);
CardDataValues.Add(19,8.99);
CardDataValues.Add(20,21.576);
CardDataValues.Add(21,43.152);
CardDataValues.Add(22,1.99);
CardDataValues.Add(23,4.776);
CardDataValues.Add(24,9.552);
CardDataValues.Add(25,3.65);
CardDataValues.Add(26,8.76);
CardDataValues.Add(27,17.52);
CardDataValues.Add(28,11.99);
CardDataValues.Add(29,28.776);
CardDataValues.Add(30,57.552);
CardDataValues.Add(31,3.23);
CardDataValues.Add(32,7.752);
CardDataValues.Add(33,15.504);
CardDataValues.Add(34,17.24);
CardDataValues.Add(35,41.376);
CardDataValues.Add(36,82.752);
CardDataValues.Add(37,12.74);
CardDataValues.Add(38,30.576);
CardDataValues.Add(39,61.152);
CardDataValues.Add(40,1);
CardDataValues.Add(41,2.4);
CardDataValues.Add(42,4.8);
CardDataValues.Add(43,1.56);
CardDataValues.Add(44,3.744);
CardDataValues.Add(45,7.488);
CardDataValues.Add(46,20.99);
CardDataValues.Add(47,21.99);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}