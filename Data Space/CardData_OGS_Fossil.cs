using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_OGS_Fossil : MonoBehaviour {
		
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
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Aerodactyl");
CardDataNames.Add(2,"Articuno");
CardDataNames.Add(3,"Ditto");
CardDataNames.Add(4,"Dragonite");
CardDataNames.Add(5,"Gengar");
CardDataNames.Add(6,"Haunter");
CardDataNames.Add(7,"Hitmonlee");
CardDataNames.Add(8,"Hypno");
CardDataNames.Add(9,"Kabutops");
CardDataNames.Add(10,"Lapras");
CardDataNames.Add(11,"Magneton");
CardDataNames.Add(12,"Moltres");
CardDataNames.Add(13,"Muk");
CardDataNames.Add(14,"Raichu");
CardDataNames.Add(15,"Zapdos");
CardDataNames.Add(16,"Aerodactyl");
CardDataNames.Add(17,"Articuno");
CardDataNames.Add(18,"Ditto");
CardDataNames.Add(19,"Dragonite");
CardDataNames.Add(20,"Gengar");
CardDataNames.Add(21,"Haunter");
CardDataNames.Add(22,"Hitmonlee");
CardDataNames.Add(23,"Hypno");
CardDataNames.Add(24,"Kabutops");
CardDataNames.Add(25,"Lapras");
CardDataNames.Add(26,"Magneton");
CardDataNames.Add(27,"Moltres");
CardDataNames.Add(28,"Muk");
CardDataNames.Add(29,"Raichu");
CardDataNames.Add(30,"Zapdos");
CardDataNames.Add(31,"Arbok");
CardDataNames.Add(32,"Cloyster");
CardDataNames.Add(33,"Gastly");
CardDataNames.Add(34,"Golbat");
CardDataNames.Add(35,"Golduck");
CardDataNames.Add(36,"Golem");
CardDataNames.Add(37,"Graveler");
CardDataNames.Add(38,"Kingler");
CardDataNames.Add(39,"Magmar");
CardDataNames.Add(40,"Omastar");
CardDataNames.Add(41,"Sandslash");
CardDataNames.Add(42,"Seadra");
CardDataNames.Add(43,"Slowbro");
CardDataNames.Add(44,"Tentacruel");
CardDataNames.Add(45,"Weezing");
CardDataNames.Add(46,"Ekans");
CardDataNames.Add(47,"Geodude");
CardDataNames.Add(48,"Grimer");
CardDataNames.Add(49,"Horsea");
CardDataNames.Add(50,"Kabuto");
CardDataNames.Add(51,"Krabby");
CardDataNames.Add(52,"Omanyte");
CardDataNames.Add(53,"Psyduck");
CardDataNames.Add(54,"Shellder");
CardDataNames.Add(55,"Slowpoke");
CardDataNames.Add(56,"Tentacool");
CardDataNames.Add(57,"Zubat");
CardDataNames.Add(58,"Mr Fuji");
CardDataNames.Add(59,"Energy Search");
CardDataNames.Add(60,"Gambler");
CardDataNames.Add(61,"Recycle");
CardDataNames.Add(62,"Mysterious Fossil");
	}

	public void SetCardValues() {
CardDataValues.Add(1,49.68);
CardDataValues.Add(2,102.19);
CardDataValues.Add(3,42.06);
CardDataValues.Add(4,218.28);
CardDataValues.Add(5,130.78);
CardDataValues.Add(6,52.83);
CardDataValues.Add(7,49.7);
CardDataValues.Add(8,35.29);
CardDataValues.Add(9,57.13);
CardDataValues.Add(10,86.18);
CardDataValues.Add(11,32.07);
CardDataValues.Add(12,98.15);
CardDataValues.Add(13,27.6);
CardDataValues.Add(14,66.2);
CardDataValues.Add(15,81.63);
CardDataValues.Add(16,10.32);
CardDataValues.Add(17,14.82);
CardDataValues.Add(18,8.98);
CardDataValues.Add(19,26.85);
CardDataValues.Add(20,18.92);
CardDataValues.Add(21,8.15);
CardDataValues.Add(22,8.76);
CardDataValues.Add(23,11);
CardDataValues.Add(24,10.62);
CardDataValues.Add(25,10.75);
CardDataValues.Add(26,7.29);
CardDataValues.Add(27,15.92);
CardDataValues.Add(28,7.08);
CardDataValues.Add(29,12.72);
CardDataValues.Add(30,17.1);
CardDataValues.Add(31,2.38);
CardDataValues.Add(32,1.88);
CardDataValues.Add(33,2.22);
CardDataValues.Add(34,2.09);
CardDataValues.Add(35,2.56);
CardDataValues.Add(36,3.07);
CardDataValues.Add(37,1.92);
CardDataValues.Add(38,1.99);
CardDataValues.Add(39,1.71);
CardDataValues.Add(40,2.56);
CardDataValues.Add(41,2.43);
CardDataValues.Add(42,1.69);
CardDataValues.Add(43,3.8);
CardDataValues.Add(44,2.11);
CardDataValues.Add(45,2.15);
CardDataValues.Add(46,0.85);
CardDataValues.Add(47,1.27);
CardDataValues.Add(48,1.04);
CardDataValues.Add(49,0.91);
CardDataValues.Add(50,0.93);
CardDataValues.Add(51,0.97);
CardDataValues.Add(52,1);
CardDataValues.Add(53,1.78);
CardDataValues.Add(54,0.83);
CardDataValues.Add(55,0.98);
CardDataValues.Add(56,0.94);
CardDataValues.Add(57,0.96);
CardDataValues.Add(58,1.13);
CardDataValues.Add(59,0.4);
CardDataValues.Add(60,0.45);
CardDataValues.Add(61,0.36);
CardDataValues.Add(62,0.33);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}