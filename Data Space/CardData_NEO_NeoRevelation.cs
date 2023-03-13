using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_NEO_NeoRevelation : MonoBehaviour {
		
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
CardDataNumbers.Add(2,"2");
CardDataNumbers.Add(3,"3");
CardDataNumbers.Add(4,"4");
CardDataNumbers.Add(5,"5");
CardDataNumbers.Add(6,"6");
CardDataNumbers.Add(7,"7");
CardDataNumbers.Add(8,"8");
CardDataNumbers.Add(9,"9");
CardDataNumbers.Add(10,"10");
CardDataNumbers.Add(11,"11");
CardDataNumbers.Add(12,"12");
CardDataNumbers.Add(13,"13");
CardDataNumbers.Add(14,"14");
CardDataNumbers.Add(15,"15");
CardDataNumbers.Add(16,"16");
CardDataNumbers.Add(17,"17");
CardDataNumbers.Add(18,"18");
CardDataNumbers.Add(19,"19");
CardDataNumbers.Add(20,"20");
CardDataNumbers.Add(21,"21");
CardDataNumbers.Add(22,"22");
CardDataNumbers.Add(23,"23");
CardDataNumbers.Add(24,"24");
CardDataNumbers.Add(25,"25");
CardDataNumbers.Add(26,"26");
CardDataNumbers.Add(27,"27");
CardDataNumbers.Add(28,"28");
CardDataNumbers.Add(29,"29");
CardDataNumbers.Add(30,"30");
CardDataNumbers.Add(31,"31");
CardDataNumbers.Add(32,"32");
CardDataNumbers.Add(33,"33");
CardDataNumbers.Add(34,"34");
CardDataNumbers.Add(35,"35");
CardDataNumbers.Add(36,"36");
CardDataNumbers.Add(37,"37");
CardDataNumbers.Add(38,"38");
CardDataNumbers.Add(39,"39");
CardDataNumbers.Add(40,"40");
CardDataNumbers.Add(41,"41");
CardDataNumbers.Add(42,"42");
CardDataNumbers.Add(43,"43");
CardDataNumbers.Add(44,"44");
CardDataNumbers.Add(45,"45");
CardDataNumbers.Add(46,"46");
CardDataNumbers.Add(47,"47");
CardDataNumbers.Add(48,"48");
CardDataNumbers.Add(49,"49");
CardDataNumbers.Add(50,"50");
CardDataNumbers.Add(51,"51");
CardDataNumbers.Add(52,"52");
CardDataNumbers.Add(53,"53");
CardDataNumbers.Add(54,"54");
CardDataNumbers.Add(55,"55");
CardDataNumbers.Add(56,"56");
CardDataNumbers.Add(57,"57");
CardDataNumbers.Add(58,"58");
CardDataNumbers.Add(59,"59");
CardDataNumbers.Add(60,"60");
CardDataNumbers.Add(61,"61");
CardDataNumbers.Add(62,"62");
CardDataNumbers.Add(63,"63");
CardDataNumbers.Add(64,"64");
CardDataNumbers.Add(65,"65");
CardDataNumbers.Add(66,"66");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Ampharos");
CardDataNames.Add(2,"Blissey");
CardDataNames.Add(3,"Celebi");
CardDataNames.Add(4,"Crobat");
CardDataNames.Add(5,"Delibird");
CardDataNames.Add(6,"Entei");
CardDataNames.Add(7,"Ho-Oh");
CardDataNames.Add(8,"Houndoom");
CardDataNames.Add(9,"Jumpluff");
CardDataNames.Add(10,"Magneton");
CardDataNames.Add(11,"Misdreavus");
CardDataNames.Add(12,"Porygon2");
CardDataNames.Add(13,"Raikou");
CardDataNames.Add(14,"Suicune");
CardDataNames.Add(15,"Aerodactyl");
CardDataNames.Add(16,"Celebi");
CardDataNames.Add(17,"Entei");
CardDataNames.Add(18,"Ho-Oh");
CardDataNames.Add(19,"Kingdra");
CardDataNames.Add(20,"Lugia");
CardDataNames.Add(21,"Raichu");
CardDataNames.Add(22,"Raikou");
CardDataNames.Add(23,"Skarmory");
CardDataNames.Add(24,"Sneasel");
CardDataNames.Add(25,"Starmie");
CardDataNames.Add(26,"Sudowoodo");
CardDataNames.Add(27,"Suicune");
CardDataNames.Add(28,"Flaaffy");
CardDataNames.Add(29,"Golbat");
CardDataNames.Add(30,"Graveler");
CardDataNames.Add(31,"Jynx");
CardDataNames.Add(32,"Lanturn");
CardDataNames.Add(33,"Magcargo");
CardDataNames.Add(34,"Octillery");
CardDataNames.Add(35,"Parasect");
CardDataNames.Add(36,"Piloswine");
CardDataNames.Add(37,"Seaking");
CardDataNames.Add(38,"Stantler");
CardDataNames.Add(39,"Unown B");
CardDataNames.Add(40,"Unown Y");
CardDataNames.Add(41,"Aipom");
CardDataNames.Add(42,"Chinchou");
CardDataNames.Add(43,"Farfetch'd");
CardDataNames.Add(44,"Geodude");
CardDataNames.Add(45,"Goldeen");
CardDataNames.Add(46,"Murkrow");
CardDataNames.Add(47,"Paras");
CardDataNames.Add(48,"Quagsire");
CardDataNames.Add(49,"Qwilfish");
CardDataNames.Add(50,"Remoraid");
CardDataNames.Add(51,"Shuckle");
CardDataNames.Add(52,"Skiploom");
CardDataNames.Add(53,"Slugma");
CardDataNames.Add(54,"Smoochum");
CardDataNames.Add(55,"Snubbull");
CardDataNames.Add(56,"Staryu");
CardDataNames.Add(57,"Swinub");
CardDataNames.Add(58,"Unown K");
CardDataNames.Add(59,"Zubat");
CardDataNames.Add(60,"Balloon Berry");
CardDataNames.Add(61,"Healing Field");
CardDataNames.Add(62,"Pokémon Breeder Fields");
CardDataNames.Add(63,"Rocket's Hideout");
CardDataNames.Add(64,"Old Rod");
CardDataNames.Add(65,"Shining Gyarados");
CardDataNames.Add(66,"Shining Magikarp");
	}

	public void SetCardValues() {
CardDataValues.Add(1,84.2);
CardDataValues.Add(2,51.81);
CardDataValues.Add(3,277.84);
CardDataValues.Add(4,64.44);
CardDataValues.Add(5,50.32);
CardDataValues.Add(6,295);
CardDataValues.Add(7,131.2);
CardDataValues.Add(8,138.61);
CardDataValues.Add(9,55.47);
CardDataValues.Add(10,45.49);
CardDataValues.Add(11,63.31);
CardDataValues.Add(12,64.99);
CardDataValues.Add(13,217.48);
CardDataValues.Add(14,232.4);
CardDataValues.Add(15,13.86);
CardDataValues.Add(16,23.07);
CardDataValues.Add(17,32.62);
CardDataValues.Add(18,33.61);
CardDataValues.Add(19,12.91);
CardDataValues.Add(20,55.27);
CardDataValues.Add(21,15.24);
CardDataValues.Add(22,28.57);
CardDataValues.Add(23,9.43);
CardDataValues.Add(24,6.43);
CardDataValues.Add(25,8.56);
CardDataValues.Add(26,6.17);
CardDataValues.Add(27,37.08);
CardDataValues.Add(28,2.71);
CardDataValues.Add(29,1.46);
CardDataValues.Add(30,1.75);
CardDataValues.Add(31,3.32);
CardDataValues.Add(32,2.06);
CardDataValues.Add(33,2.43);
CardDataValues.Add(34,2.9);
CardDataValues.Add(35,2.01);
CardDataValues.Add(36,1.89);
CardDataValues.Add(37,1.52);
CardDataValues.Add(38,1.92);
CardDataValues.Add(39,1.42);
CardDataValues.Add(40,1.68);
CardDataValues.Add(41,1.27);
CardDataValues.Add(42,0.89);
CardDataValues.Add(43,1.47);
CardDataValues.Add(44,1.39);
CardDataValues.Add(45,1.16);
CardDataValues.Add(46,1.33);
CardDataValues.Add(47,1.13);
CardDataValues.Add(48,1.75);
CardDataValues.Add(49,1.07);
CardDataValues.Add(50,1.2);
CardDataValues.Add(51,1.76);
CardDataValues.Add(52,1.24);
CardDataValues.Add(53,1.09);
CardDataValues.Add(54,0.99);
CardDataValues.Add(55,1.04);
CardDataValues.Add(56,1.02);
CardDataValues.Add(57,1.05);
CardDataValues.Add(58,1.39);
CardDataValues.Add(59,1.01);
CardDataValues.Add(60,1.12);
CardDataValues.Add(61,1.74);
CardDataValues.Add(62,1.79);
CardDataValues.Add(63,2.24);
CardDataValues.Add(64,0.71);
CardDataValues.Add(65,899.99);
CardDataValues.Add(66,489.15);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}