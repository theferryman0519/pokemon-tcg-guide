using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_HGSS_HeartGoldSoulSilverPromos : MonoBehaviour {
		
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
CardDataNumbers.Add(52,"19");
CardDataNumbers.Add(53,"19H");
CardDataNumbers.Add(54,"19RH");
CardDataNumbers.Add(55,"20");
CardDataNumbers.Add(56,"20H");
CardDataNumbers.Add(57,"20RH");
CardDataNumbers.Add(58,"21");
CardDataNumbers.Add(59,"21H");
CardDataNumbers.Add(60,"21RH");
CardDataNumbers.Add(61,"22");
CardDataNumbers.Add(62,"22H");
CardDataNumbers.Add(63,"22RH");
CardDataNumbers.Add(64,"23");
CardDataNumbers.Add(65,"23H");
CardDataNumbers.Add(66,"23RH");
CardDataNumbers.Add(67,"24");
CardDataNumbers.Add(68,"24H");
CardDataNumbers.Add(69,"24RH");
CardDataNumbers.Add(70,"25");
CardDataNumbers.Add(71,"25H");
CardDataNumbers.Add(72,"25RH");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Ho-Oh");
CardDataNames.Add(2,"Ho-Oh Holofoil");
CardDataNames.Add(3,"Ho-Oh Reverse Holo");
CardDataNames.Add(4,"Lugia");
CardDataNames.Add(5,"Lugia Holofoil");
CardDataNames.Add(6,"Lugia Reverse Holo");
CardDataNames.Add(7,"Pikachu");
CardDataNames.Add(8,"Pikachu Holofoil");
CardDataNames.Add(9,"Pikachu Reverse Holo");
CardDataNames.Add(10,"Wobbuffet");
CardDataNames.Add(11,"Wobbuffet Holofoil");
CardDataNames.Add(12,"Wobbuffet Reverse Holo");
CardDataNames.Add(13,"Hoothoot");
CardDataNames.Add(14,"Hoothoot Holofoil");
CardDataNames.Add(15,"Hoothoot Reverse Holo");
CardDataNames.Add(16,"Noctowl");
CardDataNames.Add(17,"Noctowl Holofoil");
CardDataNames.Add(18,"Noctowl Reverse Holo");
CardDataNames.Add(19,"Feraligatr");
CardDataNames.Add(20,"Feraligatr Holofoil");
CardDataNames.Add(21,"Feraligatr Reverse Holo");
CardDataNames.Add(22,"Meganium");
CardDataNames.Add(23,"Meganium Holofoil");
CardDataNames.Add(24,"Meganium Reverse Holo");
CardDataNames.Add(25,"Typhlosion");
CardDataNames.Add(26,"Typhlosion Holofoil");
CardDataNames.Add(27,"Typhlosion Reverse Holo");
CardDataNames.Add(28,"Latias");
CardDataNames.Add(29,"Latias Holofoil");
CardDataNames.Add(30,"Latias Reverse Holo");
CardDataNames.Add(31,"Latios");
CardDataNames.Add(32,"Latios Holofoil");
CardDataNames.Add(33,"Latios Reverse Holo");
CardDataNames.Add(34,"Cleffa");
CardDataNames.Add(35,"Cleffa Holofoil");
CardDataNames.Add(36,"Cleffa Reverse Holo");
CardDataNames.Add(37,"Smoochum");
CardDataNames.Add(38,"Smoochum Holofoil");
CardDataNames.Add(39,"Smoochum Reverse Holo");
CardDataNames.Add(40,"Lapras");
CardDataNames.Add(41,"Lapras Holofoil");
CardDataNames.Add(42,"Lapras Reverse Holo");
CardDataNames.Add(43,"Shuckle");
CardDataNames.Add(44,"Shuckle Holofoil");
CardDataNames.Add(45,"Shuckle Reverse Holo");
CardDataNames.Add(46,"Plusle");
CardDataNames.Add(47,"Plusle Holofoil");
CardDataNames.Add(48,"Plusle Reverse Holo");
CardDataNames.Add(49,"Minun");
CardDataNames.Add(50,"Minun Holofoil");
CardDataNames.Add(51,"Minun Reverse Holo");
CardDataNames.Add(52,"Raikou");
CardDataNames.Add(53,"Raikou Holofoil");
CardDataNames.Add(54,"Raikou Reverse Holo");
CardDataNames.Add(55,"Entei");
CardDataNames.Add(56,"Entei Holofoil");
CardDataNames.Add(57,"Entei Reverse Holo");
CardDataNames.Add(58,"Suicune");
CardDataNames.Add(59,"Suicune Holofoil");
CardDataNames.Add(60,"Suicune Reverse Holo");
CardDataNames.Add(61,"Porygon");
CardDataNames.Add(62,"Porygon Holofoil");
CardDataNames.Add(63,"Porygon Reverse Holo");
CardDataNames.Add(64,"Porygon");
CardDataNames.Add(65,"Porygon Holofoil");
CardDataNames.Add(66,"Porygon Reverse Holo");
CardDataNames.Add(67,"Hitmonchan");
CardDataNames.Add(68,"Hitmonchan Holofoil");
CardDataNames.Add(69,"Hitmonchan Reverse Holo");
CardDataNames.Add(70,"Hitmonlee");
CardDataNames.Add(71,"Hitmonlee Holofoil");
CardDataNames.Add(72,"Hitmonlee Reverse Holo");
	}

	public void SetCardValues() {
CardDataValues.Add(1,20.98);
CardDataValues.Add(2,100.704);
CardDataValues.Add(3,50.352);
CardDataValues.Add(4,32.11);
CardDataValues.Add(5,154.128);
CardDataValues.Add(6,77.064);
CardDataValues.Add(7,3.68);
CardDataValues.Add(8,17.664);
CardDataValues.Add(9,8.832);
CardDataValues.Add(10,2.03);
CardDataValues.Add(11,9.744);
CardDataValues.Add(12,4.872);
CardDataValues.Add(13,3.13);
CardDataValues.Add(14,15.024);
CardDataValues.Add(15,7.512);
CardDataValues.Add(16,4.99);
CardDataValues.Add(17,23.952);
CardDataValues.Add(18,11.976);
CardDataValues.Add(19,28.59);
CardDataValues.Add(20,137.232);
CardDataValues.Add(21,68.616);
CardDataValues.Add(22,16.17);
CardDataValues.Add(23,77.616);
CardDataValues.Add(24,38.808);
CardDataValues.Add(25,23.61);
CardDataValues.Add(26,113.328);
CardDataValues.Add(27,56.664);
CardDataValues.Add(28,6.68);
CardDataValues.Add(29,32.064);
CardDataValues.Add(30,16.032);
CardDataValues.Add(31,9.09);
CardDataValues.Add(32,43.632);
CardDataValues.Add(33,21.816);
CardDataValues.Add(34,14.94);
CardDataValues.Add(35,71.712);
CardDataValues.Add(36,35.856);
CardDataValues.Add(37,10.99);
CardDataValues.Add(38,52.752);
CardDataValues.Add(39,26.376);
CardDataValues.Add(40,13.59);
CardDataValues.Add(41,65.232);
CardDataValues.Add(42,32.616);
CardDataValues.Add(43,4.69);
CardDataValues.Add(44,22.512);
CardDataValues.Add(45,11.256);
CardDataValues.Add(46,7.87);
CardDataValues.Add(47,37.776);
CardDataValues.Add(48,18.888);
CardDataValues.Add(49,8.26);
CardDataValues.Add(50,39.648);
CardDataValues.Add(51,19.824);
CardDataValues.Add(52,21.28);
CardDataValues.Add(53,102.144);
CardDataValues.Add(54,51.072);
CardDataValues.Add(55,25.64);
CardDataValues.Add(56,123.072);
CardDataValues.Add(57,61.536);
CardDataValues.Add(58,20.45);
CardDataValues.Add(59,98.16);
CardDataValues.Add(60,49.08);
CardDataValues.Add(61,4.85);
CardDataValues.Add(62,23.28);
CardDataValues.Add(63,11.64);
CardDataValues.Add(64,4.37);
CardDataValues.Add(65,20.976);
CardDataValues.Add(66,10.488);
CardDataValues.Add(67,6.85);
CardDataValues.Add(68,32.88);
CardDataValues.Add(69,16.44);
CardDataValues.Add(70,5.17);
CardDataValues.Add(71,24.816);
CardDataValues.Add(72,12.408);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}