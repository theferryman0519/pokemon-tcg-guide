using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_EX_PopSeries4 : MonoBehaviour {
		
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
CardDataNames.Add(1,"Chimecho");
CardDataNames.Add(2,"Chimecho Reverse Holo");
CardDataNames.Add(3,"Chimecho Holofoil");
CardDataNames.Add(4,"Deoxys");
CardDataNames.Add(5,"Deoxys Reverse Holo");
CardDataNames.Add(6,"Deoxys Holofoil");
CardDataNames.Add(7,"Flygon");
CardDataNames.Add(8,"Flygon Reverse Holo");
CardDataNames.Add(9,"Flygon Holofoil");
CardDataNames.Add(10,"Mew");
CardDataNames.Add(11,"Mew Reverse Holo");
CardDataNames.Add(12,"Mew Holofoil");
CardDataNames.Add(13,"Sceptile");
CardDataNames.Add(14,"Sceptile Reverse Holo");
CardDataNames.Add(15,"Sceptile Holofoil");
CardDataNames.Add(16,"Combusken");
CardDataNames.Add(17,"Combusken Reverse Holo");
CardDataNames.Add(18,"Combusken Holofoil");
CardDataNames.Add(19,"Grovyle");
CardDataNames.Add(20,"Grovyle Reverse Holo");
CardDataNames.Add(21,"Grovyle Holofoil");
CardDataNames.Add(22,"Heal Energy");
CardDataNames.Add(23,"Heal Energy Reverse Holo");
CardDataNames.Add(24,"Heal Energy Holofoil");
CardDataNames.Add(25,"Pokemon Fan Club");
CardDataNames.Add(26,"Pokemon Fan Club Reverse Holo");
CardDataNames.Add(27,"Pokemon Fan Club Holofoil");
CardDataNames.Add(28,"Scramble Energy");
CardDataNames.Add(29,"Scramble Energy Reverse Holo");
CardDataNames.Add(30,"Scramble Energy Holofoil");
CardDataNames.Add(31,"Mudkip");
CardDataNames.Add(32,"Mudkip Reverse Holo");
CardDataNames.Add(33,"Mudkip Holofoil");
CardDataNames.Add(34,"Pidgey");
CardDataNames.Add(35,"Pidgey Reverse Holo");
CardDataNames.Add(36,"Pidgey Holofoil");
CardDataNames.Add(37,"Pikachu");
CardDataNames.Add(38,"Pikachu Reverse Holo");
CardDataNames.Add(39,"Pikachu Holofoil");
CardDataNames.Add(40,"Squirtle");
CardDataNames.Add(41,"Squirtle Reverse Holo");
CardDataNames.Add(42,"Squirtle Holofoil");
CardDataNames.Add(43,"Treecko");
CardDataNames.Add(44,"Treecko Reverse Holo");
CardDataNames.Add(45,"Treecko Holofoil");
CardDataNames.Add(46,"Wobbuffet");
CardDataNames.Add(47,"Wobbuffet Reverse Holo");
CardDataNames.Add(48,"Wobbuffet Holofoil");
CardDataNames.Add(49,"Deoxys ex");
	}

	public void SetCardValues() {
CardDataValues.Add(1,349.99);
CardDataValues.Add(2,839.976);
CardDataValues.Add(3,1679.952);
CardDataValues.Add(4,26.87);
CardDataValues.Add(5,64.488);
CardDataValues.Add(6,128.976);
CardDataValues.Add(7,15.46);
CardDataValues.Add(8,37.104);
CardDataValues.Add(9,74.208);
CardDataValues.Add(10,11.58);
CardDataValues.Add(11,27.792);
CardDataValues.Add(12,55.584);
CardDataValues.Add(13,79.95);
CardDataValues.Add(14,191.88);
CardDataValues.Add(15,383.76);
CardDataValues.Add(16,6.44);
CardDataValues.Add(17,15.456);
CardDataValues.Add(18,30.912);
CardDataValues.Add(19,13.13);
CardDataValues.Add(20,31.512);
CardDataValues.Add(21,63.024);
CardDataValues.Add(22,8.99);
CardDataValues.Add(23,21.576);
CardDataValues.Add(24,43.152);
CardDataValues.Add(25,39.97);
CardDataValues.Add(26,95.928);
CardDataValues.Add(27,191.856);
CardDataValues.Add(28,8.44);
CardDataValues.Add(29,20.256);
CardDataValues.Add(30,40.512);
CardDataValues.Add(31,5.03);
CardDataValues.Add(32,12.072);
CardDataValues.Add(33,24.144);
CardDataValues.Add(34,1.99);
CardDataValues.Add(35,4.776);
CardDataValues.Add(36,9.552);
CardDataValues.Add(37,12.89);
CardDataValues.Add(38,30.936);
CardDataValues.Add(39,61.872);
CardDataValues.Add(40,9.99);
CardDataValues.Add(41,23.976);
CardDataValues.Add(42,47.952);
CardDataValues.Add(43,1.65);
CardDataValues.Add(44,3.96);
CardDataValues.Add(45,7.92);
CardDataValues.Add(46,1.27);
CardDataValues.Add(47,3.048);
CardDataValues.Add(48,6.096);
CardDataValues.Add(49,299.95);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}