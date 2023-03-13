using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_SUMO_DetectivePikachu : MonoBehaviour {
		
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
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Bulbasaur");
CardDataNames.Add(2,"Bulbasaur Holofoil");
CardDataNames.Add(3,"Bulbasaur Reverse Holo");
CardDataNames.Add(4,"Ludicolo");
CardDataNames.Add(5,"Ludicolo Holofoil");
CardDataNames.Add(6,"Ludicolo Reverse Holo");
CardDataNames.Add(7,"Morelull");
CardDataNames.Add(8,"Morelull Holofoil");
CardDataNames.Add(9,"Morelull Reverse Holo");
CardDataNames.Add(10,"Charmander");
CardDataNames.Add(11,"Charmander Holofoil");
CardDataNames.Add(12,"Charmander Reverse Holo");
CardDataNames.Add(13,"Charizard");
CardDataNames.Add(14,"Charizard Holofoil");
CardDataNames.Add(15,"Charizard Reverse Holo");
CardDataNames.Add(16,"Arcanine");
CardDataNames.Add(17,"Arcanine Holofoil");
CardDataNames.Add(18,"Arcanine Reverse Holo");
CardDataNames.Add(19,"Psyduck");
CardDataNames.Add(20,"Psyduck Holofoil");
CardDataNames.Add(21,"Psyduck Reverse Holo");
CardDataNames.Add(22,"Magikarp");
CardDataNames.Add(23,"Magikarp Holofoil");
CardDataNames.Add(24,"Magikarp Reverse Holo");
CardDataNames.Add(25,"Greninja");
CardDataNames.Add(26,"Greninja Holofoil");
CardDataNames.Add(27,"Greninja Reverse Holo");
CardDataNames.Add(28,"Detective Pikachu");
CardDataNames.Add(29,"Detective Pikachu Holofoil");
CardDataNames.Add(30,"Detective Pikachu Reverse Holo");
CardDataNames.Add(31,"Mr Mime");
CardDataNames.Add(32,"Mr Mime Holofoil");
CardDataNames.Add(33,"Mr Mime Reverse Holo");
CardDataNames.Add(34,"Mewtwo");
CardDataNames.Add(35,"Mewtwo Holofoil");
CardDataNames.Add(36,"Mewtwo Reverse Holo");
CardDataNames.Add(37,"Machamp");
CardDataNames.Add(38,"Machamp Holofoil");
CardDataNames.Add(39,"Machamp Reverse Holo");
CardDataNames.Add(40,"Jigglypuff");
CardDataNames.Add(41,"Jigglypuff Holofoil");
CardDataNames.Add(42,"Jigglypuff Reverse Holo");
CardDataNames.Add(43,"Snubbull");
CardDataNames.Add(44,"Snubbull Holofoil");
CardDataNames.Add(45,"Snubbull Reverse Holo");
CardDataNames.Add(46,"Lickitung");
CardDataNames.Add(47,"Lickitung Holofoil");
CardDataNames.Add(48,"Lickitung Reverse Holo");
CardDataNames.Add(49,"Ditto");
CardDataNames.Add(50,"Ditto Holofoil");
CardDataNames.Add(51,"Ditto Reverse Holo");
CardDataNames.Add(52,"Slaking");
CardDataNames.Add(53,"Slaking Holofoil");
CardDataNames.Add(54,"Slaking Reverse Holo");
	}

	public void SetCardValues() {
CardDataValues.Add(1,0.45);
CardDataValues.Add(2,2.16);
CardDataValues.Add(3,1.08);
CardDataValues.Add(4,0.64);
CardDataValues.Add(5,3.072);
CardDataValues.Add(6,1.536);
CardDataValues.Add(7,0.35);
CardDataValues.Add(8,1.68);
CardDataValues.Add(9,0.84);
CardDataValues.Add(10,0.27);
CardDataValues.Add(11,1.296);
CardDataValues.Add(12,0.648);
CardDataValues.Add(13,8.86);
CardDataValues.Add(14,42.528);
CardDataValues.Add(15,21.264);
CardDataValues.Add(16,1.74);
CardDataValues.Add(17,8.352);
CardDataValues.Add(18,4.176);
CardDataValues.Add(19,0.75);
CardDataValues.Add(20,3.6);
CardDataValues.Add(21,1.8);
CardDataValues.Add(22,0.75);
CardDataValues.Add(23,3.6);
CardDataValues.Add(24,1.8);
CardDataValues.Add(25,3.67);
CardDataValues.Add(26,17.616);
CardDataValues.Add(27,8.808);
CardDataValues.Add(28,3.12);
CardDataValues.Add(29,14.976);
CardDataValues.Add(30,7.488);
CardDataValues.Add(31,1.27);
CardDataValues.Add(32,6.096);
CardDataValues.Add(33,3.048);
CardDataValues.Add(34,5.78);
CardDataValues.Add(35,27.744);
CardDataValues.Add(36,13.872);
CardDataValues.Add(37,1.03);
CardDataValues.Add(38,4.944);
CardDataValues.Add(39,2.472);
CardDataValues.Add(40,0.21);
CardDataValues.Add(41,1.008);
CardDataValues.Add(42,0.504);
CardDataValues.Add(43,0.99);
CardDataValues.Add(44,4.752);
CardDataValues.Add(45,2.376);
CardDataValues.Add(46,0.75);
CardDataValues.Add(47,3.6);
CardDataValues.Add(48,1.8);
CardDataValues.Add(49,3.5);
CardDataValues.Add(50,16.8);
CardDataValues.Add(51,8.4);
CardDataValues.Add(52,1.5);
CardDataValues.Add(53,7.2);
CardDataValues.Add(54,3.6);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}