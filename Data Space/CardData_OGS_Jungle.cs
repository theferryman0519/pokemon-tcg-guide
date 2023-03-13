using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_OGS_Jungle : MonoBehaviour {
		
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
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Clefable");
CardDataNames.Add(2,"Electrode");
CardDataNames.Add(3,"Flareon");
CardDataNames.Add(4,"Jolteon");
CardDataNames.Add(5,"Kangaskhan");
CardDataNames.Add(6,"Mr Mime");
CardDataNames.Add(7,"Nidoqueen");
CardDataNames.Add(8,"Pidgeot");
CardDataNames.Add(9,"Pinsir");
CardDataNames.Add(10,"Scyther");
CardDataNames.Add(11,"Snorlax");
CardDataNames.Add(12,"Vaporeon");
CardDataNames.Add(13,"Venomoth");
CardDataNames.Add(14,"Victreebel");
CardDataNames.Add(15,"Vileplume");
CardDataNames.Add(16,"Wigglytuff");
CardDataNames.Add(17,"Clefable");
CardDataNames.Add(18,"Electrode");
CardDataNames.Add(19,"Flareon");
CardDataNames.Add(20,"Jolteon");
CardDataNames.Add(21,"Kangaskhan");
CardDataNames.Add(22,"Mr Mime");
CardDataNames.Add(23,"Nidoqueen");
CardDataNames.Add(24,"Pidgeot");
CardDataNames.Add(25,"Pinsir");
CardDataNames.Add(26,"Scyther");
CardDataNames.Add(27,"Snorlax");
CardDataNames.Add(28,"Vaporeon");
CardDataNames.Add(29,"Venomoth");
CardDataNames.Add(30,"Victreebel");
CardDataNames.Add(31,"Vileplume");
CardDataNames.Add(32,"Wigglytuff");
CardDataNames.Add(33,"Butterfree");
CardDataNames.Add(34,"Dodrio");
CardDataNames.Add(35,"Exeggutor");
CardDataNames.Add(36,"Fearow");
CardDataNames.Add(37,"Gloom");
CardDataNames.Add(38,"Lickitung");
CardDataNames.Add(39,"Marowak");
CardDataNames.Add(40,"Nidorina");
CardDataNames.Add(41,"Parasect");
CardDataNames.Add(42,"Persian");
CardDataNames.Add(43,"Primeape");
CardDataNames.Add(44,"Rapidash");
CardDataNames.Add(45,"Rhydon");
CardDataNames.Add(46,"Seaking");
CardDataNames.Add(47,"Tauros");
CardDataNames.Add(48,"Weepinbell");
CardDataNames.Add(49,"Bellsprout");
CardDataNames.Add(50,"Cubone");
CardDataNames.Add(51,"Eevee");
CardDataNames.Add(52,"Exeggcute");
CardDataNames.Add(53,"Goldeen");
CardDataNames.Add(54,"Jigglypuff");
CardDataNames.Add(55,"Mankey");
CardDataNames.Add(56,"Meowth");
CardDataNames.Add(57,"Nidoran♀");
CardDataNames.Add(58,"Oddish");
CardDataNames.Add(59,"Paras");
CardDataNames.Add(60,"Pikachu");
CardDataNames.Add(61,"Rhyhorn");
CardDataNames.Add(62,"Spearow");
CardDataNames.Add(63,"Venonat");
CardDataNames.Add(64,"Poké Ball");
	}

	public void SetCardValues() {
CardDataValues.Add(1,44.63);
CardDataValues.Add(2,51.98);
CardDataValues.Add(3,138.89);
CardDataValues.Add(4,182.37);
CardDataValues.Add(5,65.45);
CardDataValues.Add(6,54.14);
CardDataValues.Add(7,53.82);
CardDataValues.Add(8,66.96);
CardDataValues.Add(9,49.15);
CardDataValues.Add(10,74.29);
CardDataValues.Add(11,174.74);
CardDataValues.Add(12,112.41);
CardDataValues.Add(13,45.12);
CardDataValues.Add(14,48.28);
CardDataValues.Add(15,53.28);
CardDataValues.Add(16,67.5);
CardDataValues.Add(17,9.52);
CardDataValues.Add(18,15.37);
CardDataValues.Add(19,23.31);
CardDataValues.Add(20,21.97);
CardDataValues.Add(21,8.56);
CardDataValues.Add(22,11.05);
CardDataValues.Add(23,10.65);
CardDataValues.Add(24,9.45);
CardDataValues.Add(25,7.3);
CardDataValues.Add(26,15.28);
CardDataValues.Add(27,21.52);
CardDataValues.Add(28,14.6);
CardDataValues.Add(29,7.88);
CardDataValues.Add(30,10.27);
CardDataValues.Add(31,9.76);
CardDataValues.Add(32,11.17);
CardDataValues.Add(33,4.91);
CardDataValues.Add(34,2.48);
CardDataValues.Add(35,3.54);
CardDataValues.Add(36,1.94);
CardDataValues.Add(37,1.75);
CardDataValues.Add(38,2.58);
CardDataValues.Add(39,2.91);
CardDataValues.Add(40,1.56);
CardDataValues.Add(41,1.99);
CardDataValues.Add(42,3.08);
CardDataValues.Add(43,2.54);
CardDataValues.Add(44,3.22);
CardDataValues.Add(45,3.99);
CardDataValues.Add(46,2.29);
CardDataValues.Add(47,1.79);
CardDataValues.Add(48,1.75);
CardDataValues.Add(49,1.08);
CardDataValues.Add(50,1.75);
CardDataValues.Add(51,4.99);
CardDataValues.Add(52,0.83);
CardDataValues.Add(53,0.82);
CardDataValues.Add(54,1.38);
CardDataValues.Add(55,0.96);
CardDataValues.Add(56,1.4);
CardDataValues.Add(57,0.97);
CardDataValues.Add(58,1.02);
CardDataValues.Add(59,0.98);
CardDataValues.Add(60,8.68);
CardDataValues.Add(61,0.85);
CardDataValues.Add(62,0.89);
CardDataValues.Add(63,0.94);
CardDataValues.Add(64,0.43);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}