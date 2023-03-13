using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_EX_PopSeries2 : MonoBehaviour {
		
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
CardDataNames.Add(1,"Entei");
CardDataNames.Add(2,"Entei Reverse Holo");
CardDataNames.Add(3,"Entei Holofoil");
CardDataNames.Add(4,"Pidgeot");
CardDataNames.Add(5,"Pidgeot Reverse Holo");
CardDataNames.Add(6,"Pidgeot Holofoil");
CardDataNames.Add(7,"Raikou");
CardDataNames.Add(8,"Raikou Reverse Holo");
CardDataNames.Add(9,"Raikou Holofoil");
CardDataNames.Add(10,"Suicune");
CardDataNames.Add(11,"Suicune Reverse Holo");
CardDataNames.Add(12,"Suicune Holofoil");
CardDataNames.Add(13,"Tauros");
CardDataNames.Add(14,"Tauros Reverse Holo");
CardDataNames.Add(15,"Tauros Holofoil");
CardDataNames.Add(16,"Venusaur");
CardDataNames.Add(17,"Venusaur Reverse Holo");
CardDataNames.Add(18,"Venusaur Holofoil");
CardDataNames.Add(19,"Ivysaur");
CardDataNames.Add(20,"Ivysaur Reverse Holo");
CardDataNames.Add(21,"Ivysaur Holofoil");
CardDataNames.Add(22,"Mr Briney's Compassion");
CardDataNames.Add(23,"Mr Briney's Compassion Reverse Holo");
CardDataNames.Add(24,"Mr Briney's Compassion Holofoil");
CardDataNames.Add(25,"Multi Technical Machine 01");
CardDataNames.Add(26,"Multi Technical Machine 01 Reverse Holo");
CardDataNames.Add(27,"Multi Technical Machine 01 Holofoil");
CardDataNames.Add(28,"Pokemon Park");
CardDataNames.Add(29,"Pokemon Park Reverse Holo");
CardDataNames.Add(30,"Pokemon Park Holofoil");
CardDataNames.Add(31,"TV Reporter");
CardDataNames.Add(32,"TV Reporter Reverse Holo");
CardDataNames.Add(33,"TV Reporter Holofoil");
CardDataNames.Add(34,"Bulbasaur");
CardDataNames.Add(35,"Bulbasaur Reverse Holo");
CardDataNames.Add(36,"Bulbasaur Holofoil");
CardDataNames.Add(37,"Cacnea");
CardDataNames.Add(38,"Cacnea Reverse Holo");
CardDataNames.Add(39,"Cacnea Holofoil");
CardDataNames.Add(40,"Luvdisc");
CardDataNames.Add(41,"Luvdisc Reverse Holo");
CardDataNames.Add(42,"Luvdisc Holofoil");
CardDataNames.Add(43,"Phanpy");
CardDataNames.Add(44,"Phanpy Reverse Holo");
CardDataNames.Add(45,"Phanpy Holofoil");
CardDataNames.Add(46,"Pikachu");
CardDataNames.Add(47,"Pikachu Reverse Holo");
CardDataNames.Add(48,"Pikachu Holofoil");
CardDataNames.Add(49,"Celebi ex");
	}

	public void SetCardValues() {
CardDataValues.Add(1,10.49);
CardDataValues.Add(2,25.176);
CardDataValues.Add(3,50.352);
CardDataValues.Add(4,5.99);
CardDataValues.Add(5,14.376);
CardDataValues.Add(6,28.752);
CardDataValues.Add(7,16.48);
CardDataValues.Add(8,39.552);
CardDataValues.Add(9,79.104);
CardDataValues.Add(10,16);
CardDataValues.Add(11,38.4);
CardDataValues.Add(12,76.8);
CardDataValues.Add(13,2.75);
CardDataValues.Add(14,6.6);
CardDataValues.Add(15,13.2);
CardDataValues.Add(16,10.09);
CardDataValues.Add(17,24.216);
CardDataValues.Add(18,48.432);
CardDataValues.Add(19,18.99);
CardDataValues.Add(20,45.576);
CardDataValues.Add(21,91.152);
CardDataValues.Add(22,19.94);
CardDataValues.Add(23,47.856);
CardDataValues.Add(24,95.712);
CardDataValues.Add(25,3.49);
CardDataValues.Add(26,8.376);
CardDataValues.Add(27,16.752);
CardDataValues.Add(28,9.99);
CardDataValues.Add(29,23.976);
CardDataValues.Add(30,47.952);
CardDataValues.Add(31,6.49);
CardDataValues.Add(32,15.576);
CardDataValues.Add(33,31.152);
CardDataValues.Add(34,7.04);
CardDataValues.Add(35,16.896);
CardDataValues.Add(36,33.792);
CardDataValues.Add(37,0.53);
CardDataValues.Add(38,1.272);
CardDataValues.Add(39,2.544);
CardDataValues.Add(40,0.82);
CardDataValues.Add(41,1.968);
CardDataValues.Add(42,3.936);
CardDataValues.Add(43,1.99);
CardDataValues.Add(44,4.776);
CardDataValues.Add(45,9.552);
CardDataValues.Add(46,8.12);
CardDataValues.Add(47,19.488);
CardDataValues.Add(48,38.976);
CardDataValues.Add(49,38.78);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}