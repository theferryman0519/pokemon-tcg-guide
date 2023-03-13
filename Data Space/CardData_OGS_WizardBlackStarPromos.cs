using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_OGS_WizardBlackStarPromos : MonoBehaviour {
		
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
CardDataNumbers.Add(1,"1a");
CardDataNumbers.Add(2,"1b");
CardDataNumbers.Add(3,"1c");
CardDataNumbers.Add(4,"1d");
CardDataNumbers.Add(5,"2");
CardDataNumbers.Add(6,"3");
CardDataNumbers.Add(7,"4");
CardDataNumbers.Add(8,"5");
CardDataNumbers.Add(9,"6");
CardDataNumbers.Add(10,"7");
CardDataNumbers.Add(11,"8a");
CardDataNumbers.Add(12,"8b");
CardDataNumbers.Add(13,"9a");
CardDataNumbers.Add(14,"9b");
CardDataNumbers.Add(15,"10");
CardDataNumbers.Add(16,"11");
CardDataNumbers.Add(17,"12");
CardDataNumbers.Add(18,"13");
CardDataNumbers.Add(19,"14");
CardDataNumbers.Add(20,"15");
CardDataNumbers.Add(21,"16");
CardDataNumbers.Add(22,"17");
CardDataNumbers.Add(23,"18");
CardDataNumbers.Add(24,"19");
CardDataNumbers.Add(25,"19");
CardDataNumbers.Add(26,"20");
CardDataNumbers.Add(27,"21");
CardDataNumbers.Add(28,"22");
CardDataNumbers.Add(29,"23");
CardDataNumbers.Add(30,"24");
CardDataNumbers.Add(31,"25");
CardDataNumbers.Add(32,"26");
CardDataNumbers.Add(33,"27");
CardDataNumbers.Add(34,"28");
CardDataNumbers.Add(35,"29");
CardDataNumbers.Add(36,"30");
CardDataNumbers.Add(37,"31");
CardDataNumbers.Add(38,"32a");
CardDataNumbers.Add(39,"32b");
CardDataNumbers.Add(40,"33");
CardDataNumbers.Add(41,"34");
CardDataNumbers.Add(42,"35");
CardDataNumbers.Add(43,"36");
CardDataNumbers.Add(44,"37a");
CardDataNumbers.Add(45,"37b");
CardDataNumbers.Add(46,"38");
CardDataNumbers.Add(47,"39");
CardDataNumbers.Add(48,"40");
CardDataNumbers.Add(49,"41");
CardDataNumbers.Add(50,"42");
CardDataNumbers.Add(51,"43");
CardDataNumbers.Add(52,"44");
CardDataNumbers.Add(53,"45");
CardDataNumbers.Add(54,"46");
CardDataNumbers.Add(55,"47");
CardDataNumbers.Add(56,"48");
CardDataNumbers.Add(57,"49");
CardDataNumbers.Add(58,"50a");
CardDataNumbers.Add(59,"50b");
CardDataNumbers.Add(60,"51a");
CardDataNumbers.Add(61,"51b");
CardDataNumbers.Add(62,"52");
CardDataNumbers.Add(63,"53");
CardDataNumbers.Add(64,"54");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Aerodactyl");
CardDataNames.Add(2,"Clefable");
CardDataNames.Add(3,"Pikachu");
CardDataNames.Add(4,"Pikachu");
CardDataNames.Add(5,"Electabuzz");
CardDataNames.Add(6,"Mewtwo");
CardDataNames.Add(7,"Pikachu");
CardDataNames.Add(8,"Dragonite");
CardDataNames.Add(9,"Arcanine");
CardDataNames.Add(10,"Jigglypuff");
CardDataNames.Add(11,"Dark Gyarados");
CardDataNames.Add(12,"Mew");
CardDataNames.Add(13,"Mew");
CardDataNames.Add(14,"Misty's Seadra");
CardDataNames.Add(15,"Meowth");
CardDataNames.Add(16,"Eevee");
CardDataNames.Add(17,"Mewtwo");
CardDataNames.Add(18,"Venusaur");
CardDataNames.Add(19,"Mewtwo");
CardDataNames.Add(20,"Cool Porygon");
CardDataNames.Add(21,"Computer Error");
CardDataNames.Add(22,"Dark Persian");
CardDataNames.Add(23,"Team Rocket's Meowth");
CardDataNames.Add(24,"Dark Arbok");
CardDataNames.Add(25,"Sabrina's Abra");
CardDataNames.Add(26,"Psyduck");
CardDataNames.Add(27,"Moltres");
CardDataNames.Add(28,"Articuno");
CardDataNames.Add(29,"Zapdos");
CardDataNames.Add(30,"Pikachu");
CardDataNames.Add(31,"Flying Pikachu");
CardDataNames.Add(32,"Pikachu");
CardDataNames.Add(33,"Pikachu");
CardDataNames.Add(34,"Surfing Pikachu");
CardDataNames.Add(35,"Marill");
CardDataNames.Add(36,"Togepi");
CardDataNames.Add(37,"Cleffa");
CardDataNames.Add(38,"Dark Charmeleon");
CardDataNames.Add(39,"Smeargle");
CardDataNames.Add(40,"Scizor");
CardDataNames.Add(41,"Entei");
CardDataNames.Add(42,"Pichu");
CardDataNames.Add(43,"Igglybuff");
CardDataNames.Add(44,"Brock's Vulpix");
CardDataNames.Add(45,"Hitmontop");
CardDataNames.Add(46,"Unown J");
CardDataNames.Add(47,"Misdreavus");
CardDataNames.Add(48,"Pokemon Center");
CardDataNames.Add(49,"Lucky Stadium");
CardDataNames.Add(50,"Pokemon Tower");
CardDataNames.Add(51,"Machamp");
CardDataNames.Add(52,"Magmar");
CardDataNames.Add(53,"Scyther");
CardDataNames.Add(54,"Electabuzz");
CardDataNames.Add(55,"Mew");
CardDataNames.Add(56,"Articuno");
CardDataNames.Add(57,"Snorlax");
CardDataNames.Add(58,"Celebi");
CardDataNames.Add(59,"Kabuto");
CardDataNames.Add(60,"Rapidash");
CardDataNames.Add(61,"Rapidash");
CardDataNames.Add(62,"Ho-oh");
CardDataNames.Add(63,"Suicune");
CardDataNames.Add(64,"Misty's Psyduck");
	}

	public void SetCardValues() {
CardDataValues.Add(1,31.32);
CardDataValues.Add(2,193.53);
CardDataValues.Add(3,8.66);
CardDataValues.Add(4,25);
CardDataValues.Add(5,3.5);
CardDataValues.Add(6,11.08);
CardDataValues.Add(7,10.34);
CardDataValues.Add(8,13.3);
CardDataValues.Add(9,6.46);
CardDataValues.Add(10,8.64);
CardDataValues.Add(11,9.62);
CardDataValues.Add(12,2.32);
CardDataValues.Add(13,28.62);
CardDataValues.Add(14,6.32);
CardDataValues.Add(15,9.51);
CardDataValues.Add(16,14.03);
CardDataValues.Add(17,36.96);
CardDataValues.Add(18,93.67);
CardDataValues.Add(19,6.86);
CardDataValues.Add(20,21.63);
CardDataValues.Add(21,1.5);
CardDataValues.Add(22,33.82);
CardDataValues.Add(23,3.58);
CardDataValues.Add(24,29.99);
CardDataValues.Add(25,22.45);
CardDataValues.Add(26,6.99);
CardDataValues.Add(27,4.76);
CardDataValues.Add(28,7);
CardDataValues.Add(29,6.95);
CardDataValues.Add(30,104.18);
CardDataValues.Add(31,24.73);
CardDataValues.Add(32,26.99);
CardDataValues.Add(33,5.97);
CardDataValues.Add(34,11.5);
CardDataValues.Add(35,2.3);
CardDataValues.Add(36,5.38);
CardDataValues.Add(37,5.08);
CardDataValues.Add(38,499.95);
CardDataValues.Add(39,2.99);
CardDataValues.Add(40,4.3);
CardDataValues.Add(41,6.04);
CardDataValues.Add(42,16.17);
CardDataValues.Add(43,3.63);
CardDataValues.Add(44,7.99);
CardDataValues.Add(45,3.31);
CardDataValues.Add(46,11.12);
CardDataValues.Add(47,2.23);
CardDataValues.Add(48,599.95);
CardDataValues.Add(49,750);
CardDataValues.Add(50,4.7);
CardDataValues.Add(51,10);
CardDataValues.Add(52,8.56);
CardDataValues.Add(53,13.14);
CardDataValues.Add(54,9.34);
CardDataValues.Add(55,41.35);
CardDataValues.Add(56,32.89);
CardDataValues.Add(57,45.94);
CardDataValues.Add(58,27.8);
CardDataValues.Add(59,23.11);
CardDataValues.Add(60,25.97);
CardDataValues.Add(61,29.59);
CardDataValues.Add(62,16.8);
CardDataValues.Add(63,24.98);
CardDataValues.Add(64,16.05);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}