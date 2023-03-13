using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_EX_PopSeries1 : MonoBehaviour {
		
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
CardDataNames.Add(1,"Blaziken");
CardDataNames.Add(2,"Blaziken Reverse Holo");
CardDataNames.Add(3,"Blaziken Holofoil");
CardDataNames.Add(4,"Metagross");
CardDataNames.Add(5,"Metagross Reverse Holo");
CardDataNames.Add(6,"Metagross Holofoil");
CardDataNames.Add(7,"Rayquaza");
CardDataNames.Add(8,"Rayquaza Reverse Holo");
CardDataNames.Add(9,"Rayquaza Holofoil");
CardDataNames.Add(10,"Sceptile");
CardDataNames.Add(11,"Sceptile Reverse Holo");
CardDataNames.Add(12,"Sceptile Holofoil");
CardDataNames.Add(13,"Swampert");
CardDataNames.Add(14,"Swampert Reverse Holo");
CardDataNames.Add(15,"Swampert Holofoil");
CardDataNames.Add(16,"Beautifly");
CardDataNames.Add(17,"Beautifly Reverse Holo");
CardDataNames.Add(18,"Beautifly Holofoil");
CardDataNames.Add(19,"Masquerain");
CardDataNames.Add(20,"Masquerain Reverse Holo");
CardDataNames.Add(21,"Masquerain Holofoil");
CardDataNames.Add(22,"Murkrow");
CardDataNames.Add(23,"Murkrow Reverse Holo");
CardDataNames.Add(24,"Murkrow Holofoil");
CardDataNames.Add(25,"Pupitar");
CardDataNames.Add(26,"Pupitar Reverse Holo");
CardDataNames.Add(27,"Pupitar Holofoil");
CardDataNames.Add(28,"Torkoal");
CardDataNames.Add(29,"Torkoal Reverse Holo");
CardDataNames.Add(30,"Torkoal Holofoil");
CardDataNames.Add(31,"Larvitar");
CardDataNames.Add(32,"Larvitar Reverse Holo");
CardDataNames.Add(33,"Larvitar Holofoil");
CardDataNames.Add(34,"Minun");
CardDataNames.Add(35,"Minun Reverse Holo");
CardDataNames.Add(36,"Minun Holofoil");
CardDataNames.Add(37,"Plusle");
CardDataNames.Add(38,"Plusle Reverse Holo");
CardDataNames.Add(39,"Plusle Holofoil");
CardDataNames.Add(40,"Surskit");
CardDataNames.Add(41,"Surskit Reverse Holo");
CardDataNames.Add(42,"Surskit Holofoil");
CardDataNames.Add(43,"Swellow");
CardDataNames.Add(44,"Swellow Reverse Holo");
CardDataNames.Add(45,"Swellow Holofoil");
CardDataNames.Add(46,"Armaldo ex");
CardDataNames.Add(47,"Tyranitar ex");
	}

	public void SetCardValues() {
CardDataValues.Add(1,13.24);
CardDataValues.Add(2,31.776);
CardDataValues.Add(3,63.552);
CardDataValues.Add(4,2.98);
CardDataValues.Add(5,7.152);
CardDataValues.Add(6,14.304);
CardDataValues.Add(7,9.23);
CardDataValues.Add(8,22.152);
CardDataValues.Add(9,44.304);
CardDataValues.Add(10,18.97);
CardDataValues.Add(11,45.528);
CardDataValues.Add(12,91.056);
CardDataValues.Add(13,14);
CardDataValues.Add(14,33.6);
CardDataValues.Add(15,67.2);
CardDataValues.Add(16,5.49);
CardDataValues.Add(17,13.176);
CardDataValues.Add(18,26.352);
CardDataValues.Add(19,3.91);
CardDataValues.Add(20,9.384);
CardDataValues.Add(21,18.768);
CardDataValues.Add(22,4);
CardDataValues.Add(23,9.6);
CardDataValues.Add(24,19.2);
CardDataValues.Add(25,5.21);
CardDataValues.Add(26,12.504);
CardDataValues.Add(27,25.008);
CardDataValues.Add(28,7.35);
CardDataValues.Add(29,17.64);
CardDataValues.Add(30,35.28);
CardDataValues.Add(31,0.59);
CardDataValues.Add(32,1.416);
CardDataValues.Add(33,2.832);
CardDataValues.Add(34,1);
CardDataValues.Add(35,2.4);
CardDataValues.Add(36,4.8);
CardDataValues.Add(37,0.7);
CardDataValues.Add(38,1.68);
CardDataValues.Add(39,3.36);
CardDataValues.Add(40,0.63);
CardDataValues.Add(41,1.512);
CardDataValues.Add(42,3.024);
CardDataValues.Add(43,0.48);
CardDataValues.Add(44,1.152);
CardDataValues.Add(45,2.304);
CardDataValues.Add(46,24.97);
CardDataValues.Add(47,52.48);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}