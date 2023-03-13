using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_DP_PopSeries7 : MonoBehaviour {
		
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
CardDataNames.Add(1,"Ampharos");
CardDataNames.Add(2,"Ampharos Holofoil");
CardDataNames.Add(3,"Ampharos Reverse Holo");
CardDataNames.Add(4,"Gallade");
CardDataNames.Add(5,"Gallade Holofoil");
CardDataNames.Add(6,"Gallade Reverse Holo");
CardDataNames.Add(7,"Latias");
CardDataNames.Add(8,"Latias Holofoil");
CardDataNames.Add(9,"Latias Reverse Holo");
CardDataNames.Add(10,"Latios");
CardDataNames.Add(11,"Latios Holofoil");
CardDataNames.Add(12,"Latios Reverse Holo");
CardDataNames.Add(13,"Mothim");
CardDataNames.Add(14,"Mothim Holofoil");
CardDataNames.Add(15,"Mothim Reverse Holo");
CardDataNames.Add(16,"Delibird");
CardDataNames.Add(17,"Delibird Holofoil");
CardDataNames.Add(18,"Delibird Reverse Holo");
CardDataNames.Add(19,"Flaaffy");
CardDataNames.Add(20,"Flaaffy Holofoil");
CardDataNames.Add(21,"Flaaffy Reverse Holo");
CardDataNames.Add(22,"Kirlia");
CardDataNames.Add(23,"Kirlia Holofoil");
CardDataNames.Add(24,"Kirlia Reverse Holo");
CardDataNames.Add(25,"Stantler");
CardDataNames.Add(26,"Stantler Holofoil");
CardDataNames.Add(27,"Stantler Reverse Holo");
CardDataNames.Add(28,"Wormadam Sandy Cloak");
CardDataNames.Add(29,"Wormadam Sandy Cloak Holofoil");
CardDataNames.Add(30,"Wormadam Sandy Cloak Reverse Holo");
CardDataNames.Add(31,"Burmy Plant Cloak");
CardDataNames.Add(32,"Burmy Plant Cloak Holofoil");
CardDataNames.Add(33,"Burmy Plant Cloak Reverse Holo");
CardDataNames.Add(34,"Burmy Sandy Cloak");
CardDataNames.Add(35,"Burmy Sandy Cloak Holofoil");
CardDataNames.Add(36,"Burmy Sandy Cloak Reverse Holo");
CardDataNames.Add(37,"Corsola");
CardDataNames.Add(38,"Corsola Holofoil");
CardDataNames.Add(39,"Corsola Reverse Holo");
CardDataNames.Add(40,"Mareep");
CardDataNames.Add(41,"Mareep Holofoil");
CardDataNames.Add(42,"Mareep Reverse Holo");
CardDataNames.Add(43,"Ralts");
CardDataNames.Add(44,"Ralts Holofoil");
CardDataNames.Add(45,"Ralts Reverse Holo");
CardDataNames.Add(46,"Sentret");
CardDataNames.Add(47,"Sentret Holofoil");
CardDataNames.Add(48,"Sentret Reverse Holo");
CardDataNames.Add(49,"Spinda");
CardDataNames.Add(50,"Spinda Holofoil");
CardDataNames.Add(51,"Spinda Reverse Holo");
	}

	public void SetCardValues() {
CardDataValues.Add(1,5.95);
CardDataValues.Add(2,28.56);
CardDataValues.Add(3,14.28);
CardDataValues.Add(4,13.47);
CardDataValues.Add(5,64.656);
CardDataValues.Add(6,32.328);
CardDataValues.Add(7,5.37);
CardDataValues.Add(8,25.776);
CardDataValues.Add(9,12.888);
CardDataValues.Add(10,9.81);
CardDataValues.Add(11,47.088);
CardDataValues.Add(12,23.544);
CardDataValues.Add(13,2.27);
CardDataValues.Add(14,10.896);
CardDataValues.Add(15,5.448);
CardDataValues.Add(16,3.99);
CardDataValues.Add(17,19.152);
CardDataValues.Add(18,9.576);
CardDataValues.Add(19,3.69);
CardDataValues.Add(20,17.712);
CardDataValues.Add(21,8.856);
CardDataValues.Add(22,3.31);
CardDataValues.Add(23,15.888);
CardDataValues.Add(24,7.944);
CardDataValues.Add(25,2.17);
CardDataValues.Add(26,10.416);
CardDataValues.Add(27,5.208);
CardDataValues.Add(28,3.19);
CardDataValues.Add(29,15.312);
CardDataValues.Add(30,7.656);
CardDataValues.Add(31,0.6);
CardDataValues.Add(32,2.88);
CardDataValues.Add(33,1.44);
CardDataValues.Add(34,0.82);
CardDataValues.Add(35,3.936);
CardDataValues.Add(36,1.968);
CardDataValues.Add(37,0.8);
CardDataValues.Add(38,3.84);
CardDataValues.Add(39,1.92);
CardDataValues.Add(40,1.27);
CardDataValues.Add(41,6.096);
CardDataValues.Add(42,3.048);
CardDataValues.Add(43,0.79);
CardDataValues.Add(44,3.792);
CardDataValues.Add(45,1.896);
CardDataValues.Add(46,0.88);
CardDataValues.Add(47,4.224);
CardDataValues.Add(48,2.112);
CardDataValues.Add(49,0.99);
CardDataValues.Add(50,4.752);
CardDataValues.Add(51,2.376);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}