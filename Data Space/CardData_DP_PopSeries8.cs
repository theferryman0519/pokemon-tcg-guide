using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_DP_PopSeries8 : MonoBehaviour {
		
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
CardDataNames.Add(1,"Heatran");
CardDataNames.Add(2,"Heatran Holofoil");
CardDataNames.Add(3,"Heatran Reverse Holo");
CardDataNames.Add(4,"Lucario");
CardDataNames.Add(5,"Lucario Holofoil");
CardDataNames.Add(6,"Lucario Reverse Holo");
CardDataNames.Add(7,"Luxray");
CardDataNames.Add(8,"Luxray Holofoil");
CardDataNames.Add(9,"Luxray Reverse Holo");
CardDataNames.Add(10,"Probopass");
CardDataNames.Add(11,"Probopass Holofoil");
CardDataNames.Add(12,"Probopass Reverse Holo");
CardDataNames.Add(13,"Yanmega");
CardDataNames.Add(14,"Yanmega Holofoil");
CardDataNames.Add(15,"Yanmega Reverse Holo");
CardDataNames.Add(16,"Cherrim");
CardDataNames.Add(17,"Cherrim Holofoil");
CardDataNames.Add(18,"Cherrim Reverse Holo");
CardDataNames.Add(19,"Carnivine");
CardDataNames.Add(20,"Carnivine Holofoil");
CardDataNames.Add(21,"Carnivine Reverse Holo");
CardDataNames.Add(22,"Luxio");
CardDataNames.Add(23,"Luxio Holofoil");
CardDataNames.Add(24,"Luxio Reverse Holo");
CardDataNames.Add(25,"Night Maintenance");
CardDataNames.Add(26,"Night Maintenance Holofoil");
CardDataNames.Add(27,"Night Maintenance Reverse Holo");
CardDataNames.Add(28,"Rare Candy");
CardDataNames.Add(29,"Rare Candy Holofoil");
CardDataNames.Add(30,"Rare Candy Reverse Holo");
CardDataNames.Add(31,"Roseanne's Research");
CardDataNames.Add(32,"Roseanne's Research Holofoil");
CardDataNames.Add(33,"Roseanne's Research Reverse Holo");
CardDataNames.Add(34,"Chimchar");
CardDataNames.Add(35,"Chimchar Holofoil");
CardDataNames.Add(36,"Chimchar Reverse Holo");
CardDataNames.Add(37,"Croagunk");
CardDataNames.Add(38,"Croagunk Holofoil");
CardDataNames.Add(39,"Croagunk Reverse Holo");
CardDataNames.Add(40,"Happiny");
CardDataNames.Add(41,"Happiny Holofoil");
CardDataNames.Add(42,"Happiny Reverse Holo");
CardDataNames.Add(43,"Piplup");
CardDataNames.Add(44,"Piplup Holofoil");
CardDataNames.Add(45,"Piplup Reverse Holo");
CardDataNames.Add(46,"Riolu");
CardDataNames.Add(47,"Riolu Holofoil");
CardDataNames.Add(48,"Riolu Reverse Holo");
CardDataNames.Add(49,"Turtwig");
CardDataNames.Add(50,"Turtwig Holofoil");
CardDataNames.Add(51,"Turtwig Reverse Holo");
	}

	public void SetCardValues() {
CardDataValues.Add(1,4.75);
CardDataValues.Add(2,22.8);
CardDataValues.Add(3,11.4);
CardDataValues.Add(4,3.25);
CardDataValues.Add(5,15.6);
CardDataValues.Add(6,7.8);
CardDataValues.Add(7,3.49);
CardDataValues.Add(8,16.752);
CardDataValues.Add(9,8.376);
CardDataValues.Add(10,1.5);
CardDataValues.Add(11,7.2);
CardDataValues.Add(12,3.6);
CardDataValues.Add(13,10.5);
CardDataValues.Add(14,50.4);
CardDataValues.Add(15,25.2);
CardDataValues.Add(16,2.1);
CardDataValues.Add(17,10.08);
CardDataValues.Add(18,5.04);
CardDataValues.Add(19,2.31);
CardDataValues.Add(20,11.088);
CardDataValues.Add(21,5.544);
CardDataValues.Add(22,2.99);
CardDataValues.Add(23,14.352);
CardDataValues.Add(24,7.176);
CardDataValues.Add(25,2.99);
CardDataValues.Add(26,14.352);
CardDataValues.Add(27,7.176);
CardDataValues.Add(28,7.95);
CardDataValues.Add(29,38.16);
CardDataValues.Add(30,19.08);
CardDataValues.Add(31,8.45);
CardDataValues.Add(32,40.56);
CardDataValues.Add(33,20.28);
CardDataValues.Add(34,0.79);
CardDataValues.Add(35,3.792);
CardDataValues.Add(36,1.896);
CardDataValues.Add(37,0.79);
CardDataValues.Add(38,3.792);
CardDataValues.Add(39,1.896);
CardDataValues.Add(40,0.99);
CardDataValues.Add(41,4.752);
CardDataValues.Add(42,2.376);
CardDataValues.Add(43,2.36);
CardDataValues.Add(44,11.328);
CardDataValues.Add(45,5.664);
CardDataValues.Add(46,0.9);
CardDataValues.Add(47,4.32);
CardDataValues.Add(48,2.16);
CardDataValues.Add(49,0.65);
CardDataValues.Add(50,3.12);
CardDataValues.Add(51,1.56);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}