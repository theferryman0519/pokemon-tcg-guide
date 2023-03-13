using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_DP_PopSeries6 : MonoBehaviour {
		
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
CardDataNames.Add(1,"Bastiodon");
CardDataNames.Add(2,"Bastiodon Holofoil");
CardDataNames.Add(3,"Bastiodon Reverse Holo");
CardDataNames.Add(4,"Lucario");
CardDataNames.Add(5,"Lucario Holofoil");
CardDataNames.Add(6,"Lucario Reverse Holo");
CardDataNames.Add(7,"Manaphy");
CardDataNames.Add(8,"Manaphy Holofoil");
CardDataNames.Add(9,"Manaphy Reverse Holo");
CardDataNames.Add(10,"Pachirisu");
CardDataNames.Add(11,"Pachirisu Holofoil");
CardDataNames.Add(12,"Pachirisu Reverse Holo");
CardDataNames.Add(13,"Rampardos");
CardDataNames.Add(14,"Rampardos Holofoil");
CardDataNames.Add(15,"Rampardos Reverse Holo");
CardDataNames.Add(16,"Drifloon");
CardDataNames.Add(17,"Drifloon Holofoil");
CardDataNames.Add(18,"Drifloon Reverse Holo");
CardDataNames.Add(19,"Gible");
CardDataNames.Add(20,"Gible Holofoil");
CardDataNames.Add(21,"Gible Reverse Holo");
CardDataNames.Add(22,"Riolu");
CardDataNames.Add(23,"Riolu Holofoil");
CardDataNames.Add(24,"Riolu Reverse Holo");
CardDataNames.Add(25,"Pikachu");
CardDataNames.Add(26,"Pikachu Holofoil");
CardDataNames.Add(27,"Pikachu Reverse Holo");
CardDataNames.Add(28,"Staravia");
CardDataNames.Add(29,"Staravia Holofoil");
CardDataNames.Add(30,"Staravia Reverse Holo");
CardDataNames.Add(31,"Bidoof");
CardDataNames.Add(32,"Bidoof Holofoil");
CardDataNames.Add(33,"Bidoof Reverse Holo");
CardDataNames.Add(34,"Buneary");
CardDataNames.Add(35,"Buneary Holofoil");
CardDataNames.Add(36,"Buneary Reverse Holo");
CardDataNames.Add(37,"Cherubi");
CardDataNames.Add(38,"Cherubi Holofoil");
CardDataNames.Add(39,"Cherubi Reverse Holo");
CardDataNames.Add(40,"Chimchar");
CardDataNames.Add(41,"Chimchar Holofoil");
CardDataNames.Add(42,"Chimchar Reverse Holo");
CardDataNames.Add(43,"Piplup");
CardDataNames.Add(44,"Piplup Holofoil");
CardDataNames.Add(45,"Piplup Reverse Holo");
CardDataNames.Add(46,"Starly");
CardDataNames.Add(47,"Starly Holofoil");
CardDataNames.Add(48,"Starly Reverse Holo");
CardDataNames.Add(49,"Turtwig");
CardDataNames.Add(50,"Turtwig Holofoil");
CardDataNames.Add(51,"Turtwig Reverse Holo");
	}

	public void SetCardValues() {
CardDataValues.Add(1,1.65);
CardDataValues.Add(2,7.92);
CardDataValues.Add(3,3.96);
CardDataValues.Add(4,3.12);
CardDataValues.Add(5,14.976);
CardDataValues.Add(6,7.488);
CardDataValues.Add(7,1.66);
CardDataValues.Add(8,7.968);
CardDataValues.Add(9,3.984);
CardDataValues.Add(10,2.74);
CardDataValues.Add(11,13.152);
CardDataValues.Add(12,6.576);
CardDataValues.Add(13,1.5);
CardDataValues.Add(14,7.2);
CardDataValues.Add(15,3.6);
CardDataValues.Add(16,18.99);
CardDataValues.Add(17,91.152);
CardDataValues.Add(18,45.576);
CardDataValues.Add(19,3.22);
CardDataValues.Add(20,15.456);
CardDataValues.Add(21,7.728);
CardDataValues.Add(22,6.48);
CardDataValues.Add(23,31.104);
CardDataValues.Add(24,15.552);
CardDataValues.Add(25,22.85);
CardDataValues.Add(26,109.68);
CardDataValues.Add(27,54.84);
CardDataValues.Add(28,11.99);
CardDataValues.Add(29,57.552);
CardDataValues.Add(30,28.776);
CardDataValues.Add(31,6.25);
CardDataValues.Add(32,30);
CardDataValues.Add(33,15);
CardDataValues.Add(34,3);
CardDataValues.Add(35,14.4);
CardDataValues.Add(36,7.2);
CardDataValues.Add(37,5);
CardDataValues.Add(38,24);
CardDataValues.Add(39,12);
CardDataValues.Add(40,1.99);
CardDataValues.Add(41,9.552);
CardDataValues.Add(42,4.776);
CardDataValues.Add(43,2.86);
CardDataValues.Add(44,13.728);
CardDataValues.Add(45,6.864);
CardDataValues.Add(46,2.94);
CardDataValues.Add(47,14.112);
CardDataValues.Add(48,7.056);
CardDataValues.Add(49,1.99);
CardDataValues.Add(50,9.552);
CardDataValues.Add(51,4.776);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}