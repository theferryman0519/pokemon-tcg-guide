using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_BW_DragonVault : MonoBehaviour {
		
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
CardDataNumbers.Add(52,"18");
CardDataNumbers.Add(53,"18H");
CardDataNumbers.Add(54,"18RH");
CardDataNumbers.Add(55,"19");
CardDataNumbers.Add(56,"19H");
CardDataNumbers.Add(57,"19RH");
CardDataNumbers.Add(58,"20");
CardDataNumbers.Add(59,"20H");
CardDataNumbers.Add(60,"20RH");
CardDataNumbers.Add(61,"21");
CardDataNumbers.Add(62,"21H");
CardDataNumbers.Add(63,"21RH");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Dratini");
CardDataNames.Add(2,"Dratini Holofoil");
CardDataNames.Add(3,"Dratini Reverse Holo");
CardDataNames.Add(4,"Dratini");
CardDataNames.Add(5,"Dratini Holofoil");
CardDataNames.Add(6,"Dratini Reverse Holo");
CardDataNames.Add(7,"Dragonair");
CardDataNames.Add(8,"Dragonair Holofoil");
CardDataNames.Add(9,"Dragonair Reverse Holo");
CardDataNames.Add(10,"Dragonair");
CardDataNames.Add(11,"Dragonair Holofoil");
CardDataNames.Add(12,"Dragonair Reverse Holo");
CardDataNames.Add(13,"Dragonite");
CardDataNames.Add(14,"Dragonite Holofoil");
CardDataNames.Add(15,"Dragonite Reverse Holo");
CardDataNames.Add(16,"Bagon");
CardDataNames.Add(17,"Bagon Holofoil");
CardDataNames.Add(18,"Bagon Reverse Holo");
CardDataNames.Add(19,"Shelgon");
CardDataNames.Add(20,"Shelgon Holofoil");
CardDataNames.Add(21,"Shelgon Reverse Holo");
CardDataNames.Add(22,"Salamence");
CardDataNames.Add(23,"Salamence Holofoil");
CardDataNames.Add(24,"Salamence Reverse Holo");
CardDataNames.Add(25,"Latias");
CardDataNames.Add(26,"Latias Holofoil");
CardDataNames.Add(27,"Latias Reverse Holo");
CardDataNames.Add(28,"Latios");
CardDataNames.Add(29,"Latios Holofoil");
CardDataNames.Add(30,"Latios Reverse Holo");
CardDataNames.Add(31,"Rayquaza");
CardDataNames.Add(32,"Rayquaza Holofoil");
CardDataNames.Add(33,"Rayquaza Reverse Holo");
CardDataNames.Add(34,"Axew");
CardDataNames.Add(35,"Axew Holofoil");
CardDataNames.Add(36,"Axew Reverse Holo");
CardDataNames.Add(37,"Axew");
CardDataNames.Add(38,"Axew Holofoil");
CardDataNames.Add(39,"Axew Reverse Holo");
CardDataNames.Add(40,"Fraxure");
CardDataNames.Add(41,"Fraxure Holofoil");
CardDataNames.Add(42,"Fraxure Reverse Holo");
CardDataNames.Add(43,"Fraxure");
CardDataNames.Add(44,"Fraxure Holofoil");
CardDataNames.Add(45,"Fraxure Reverse Holo");
CardDataNames.Add(46,"Haxorus");
CardDataNames.Add(47,"Haxorus Holofoil");
CardDataNames.Add(48,"Haxorus Reverse Holo");
CardDataNames.Add(49,"Druddigon");
CardDataNames.Add(50,"Druddigon Holofoil");
CardDataNames.Add(51,"Druddigon Reverse Holo");
CardDataNames.Add(52,"Exp Share");
CardDataNames.Add(53,"Exp Share Holofoil");
CardDataNames.Add(54,"Exp Share Reverse Holo");
CardDataNames.Add(55,"Fast Ticket");
CardDataNames.Add(56,"Fast Ticket Holofoil");
CardDataNames.Add(57,"Fast Ticket Reverse Holo");
CardDataNames.Add(58,"Super Rod");
CardDataNames.Add(59,"Super Rod Holofoil");
CardDataNames.Add(60,"Super Rod Reverse Holo");
CardDataNames.Add(61,"Kyurem");
CardDataNames.Add(62,"Kyurem Holofoil");
CardDataNames.Add(63,"Kyurem Reverse Holo");
	}

	public void SetCardValues() {
CardDataValues.Add(1,1.28);
CardDataValues.Add(2,6.144);
CardDataValues.Add(3,3.072);
CardDataValues.Add(4,5.32);
CardDataValues.Add(5,25.536);
CardDataValues.Add(6,12.768);
CardDataValues.Add(7,2.24);
CardDataValues.Add(8,10.752);
CardDataValues.Add(9,5.376);
CardDataValues.Add(10,7.05);
CardDataValues.Add(11,33.84);
CardDataValues.Add(12,16.92);
CardDataValues.Add(13,8.33);
CardDataValues.Add(14,39.984);
CardDataValues.Add(15,19.992);
CardDataValues.Add(16,0.89);
CardDataValues.Add(17,4.272);
CardDataValues.Add(18,2.136);
CardDataValues.Add(19,1.05);
CardDataValues.Add(20,5.04);
CardDataValues.Add(21,2.52);
CardDataValues.Add(22,2.12);
CardDataValues.Add(23,10.176);
CardDataValues.Add(24,5.088);
CardDataValues.Add(25,3.73);
CardDataValues.Add(26,17.904);
CardDataValues.Add(27,8.952);
CardDataValues.Add(28,3.09);
CardDataValues.Add(29,14.832);
CardDataValues.Add(30,7.416);
CardDataValues.Add(31,8.65);
CardDataValues.Add(32,41.52);
CardDataValues.Add(33,20.76);
CardDataValues.Add(34,0.91);
CardDataValues.Add(35,4.368);
CardDataValues.Add(36,2.184);
CardDataValues.Add(37,0.87);
CardDataValues.Add(38,4.176);
CardDataValues.Add(39,2.088);
CardDataValues.Add(40,1.61);
CardDataValues.Add(41,7.728);
CardDataValues.Add(42,3.864);
CardDataValues.Add(43,0.75);
CardDataValues.Add(44,3.6);
CardDataValues.Add(45,1.8);
CardDataValues.Add(46,3.49);
CardDataValues.Add(47,16.752);
CardDataValues.Add(48,8.376);
CardDataValues.Add(49,1.65);
CardDataValues.Add(50,7.92);
CardDataValues.Add(51,3.96);
CardDataValues.Add(52,1.21);
CardDataValues.Add(53,5.808);
CardDataValues.Add(54,2.904);
CardDataValues.Add(55,0.82);
CardDataValues.Add(56,3.936);
CardDataValues.Add(57,1.968);
CardDataValues.Add(58,2.96);
CardDataValues.Add(59,14.208);
CardDataValues.Add(60,7.104);
CardDataValues.Add(61,54.24);
CardDataValues.Add(62,260.352);
CardDataValues.Add(63,130.176);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}