using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_OGS_TeamRocket : MonoBehaviour {
		
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
CardDataNumbers.Add(67,"67");
CardDataNumbers.Add(68,"68");
CardDataNumbers.Add(69,"69");
CardDataNumbers.Add(70,"70");
CardDataNumbers.Add(71,"71");
CardDataNumbers.Add(72,"72");
CardDataNumbers.Add(73,"73");
CardDataNumbers.Add(74,"74");
CardDataNumbers.Add(75,"75");
CardDataNumbers.Add(76,"76");
CardDataNumbers.Add(77,"77");
CardDataNumbers.Add(78,"78");
CardDataNumbers.Add(79,"79");
CardDataNumbers.Add(80,"80");
CardDataNumbers.Add(81,"81");
CardDataNumbers.Add(82,"82");
CardDataNumbers.Add(83,"83");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Dark Alakazam");
CardDataNames.Add(2,"Dark Arbok");
CardDataNames.Add(3,"Dark Blastoise");
CardDataNames.Add(4,"Dark Charizard");
CardDataNames.Add(5,"Dark Dragonite");
CardDataNames.Add(6,"Dark Dugtrio");
CardDataNames.Add(7,"Dark Golbat");
CardDataNames.Add(8,"Dark Gyarados");
CardDataNames.Add(9,"Dark Hypno");
CardDataNames.Add(10,"Dark Machamp");
CardDataNames.Add(11,"Dark Magneton");
CardDataNames.Add(12,"Dark Slowbro");
CardDataNames.Add(13,"Dark Vileplume");
CardDataNames.Add(14,"Dark Weezing");
CardDataNames.Add(15,"Here Comes Team Rocket");
CardDataNames.Add(16,"Rocket's Sneak Attack");
CardDataNames.Add(17,"Rainbow Energy");
CardDataNames.Add(18,"Dark Alakazam");
CardDataNames.Add(19,"Dark Arbok");
CardDataNames.Add(20,"Dark Blastoise");
CardDataNames.Add(21,"Dark Charizard");
CardDataNames.Add(22,"Dark Dragonite");
CardDataNames.Add(23,"Dark Dugtrio");
CardDataNames.Add(24,"Dark Golbat");
CardDataNames.Add(25,"Dark Gyarados");
CardDataNames.Add(26,"Dark Hypno");
CardDataNames.Add(27,"Dark Machamp");
CardDataNames.Add(28,"Dark Magneton");
CardDataNames.Add(29,"Dark Slowbro");
CardDataNames.Add(30,"Dark Vileplume");
CardDataNames.Add(31,"Dark Weezing");
CardDataNames.Add(32,"Dark Charmeleon");
CardDataNames.Add(33,"Dark Dragonair");
CardDataNames.Add(34,"Dark Electrode");
CardDataNames.Add(35,"Dark Flareon");
CardDataNames.Add(36,"Dark Gloom");
CardDataNames.Add(37,"Dark Golduck");
CardDataNames.Add(38,"Dark Jolteon");
CardDataNames.Add(39,"Dark Kadabra");
CardDataNames.Add(40,"Dark Machoke");
CardDataNames.Add(41,"Dark Muk");
CardDataNames.Add(42,"Dark Persian");
CardDataNames.Add(43,"Dark Primeape");
CardDataNames.Add(44,"Dark Rapidash");
CardDataNames.Add(45,"Dark Vaporeon");
CardDataNames.Add(46,"Dark Wartortle");
CardDataNames.Add(47,"Magikarp");
CardDataNames.Add(48,"Porygon");
CardDataNames.Add(49,"Abra");
CardDataNames.Add(50,"Charmander");
CardDataNames.Add(51,"Dark Raticate");
CardDataNames.Add(52,"Diglett");
CardDataNames.Add(53,"Dratini");
CardDataNames.Add(54,"Drowzee");
CardDataNames.Add(55,"Eevee");
CardDataNames.Add(56,"Ekans");
CardDataNames.Add(57,"Grimer");
CardDataNames.Add(58,"Koffing");
CardDataNames.Add(59,"Machop");
CardDataNames.Add(60,"Magnemite");
CardDataNames.Add(61,"Mankey");
CardDataNames.Add(62,"Meowth");
CardDataNames.Add(63,"Oddish");
CardDataNames.Add(64,"Ponyta");
CardDataNames.Add(65,"Psyduck");
CardDataNames.Add(66,"Rattata");
CardDataNames.Add(67,"Slowpoke");
CardDataNames.Add(68,"Squirtle");
CardDataNames.Add(69,"Voltorb");
CardDataNames.Add(70,"Zubat");
CardDataNames.Add(71,"Here Comes Team Rocket");
CardDataNames.Add(72,"Rocket's Sneak Attack");
CardDataNames.Add(73,"The Boss's Way");
CardDataNames.Add(74,"Challenge!");
CardDataNames.Add(75,"Digger");
CardDataNames.Add(76,"Imposter Oak's Revenge");
CardDataNames.Add(77,"Nightly Garbage Run");
CardDataNames.Add(78,"Goop Gas Attack");
CardDataNames.Add(79,"Sleep!");
CardDataNames.Add(80,"Rainbow Energy");
CardDataNames.Add(81,"Full Heal Energy");
CardDataNames.Add(82,"Potion Energy");
CardDataNames.Add(83,"Dark Raichu");
	}

	public void SetCardValues() {
CardDataValues.Add(1,66.99);
CardDataValues.Add(2,26.16);
CardDataValues.Add(3,244.54);
CardDataValues.Add(4,489.21);
CardDataValues.Add(5,181.95);
CardDataValues.Add(6,34.57);
CardDataValues.Add(7,23.71);
CardDataValues.Add(8,53.6);
CardDataValues.Add(9,41.83);
CardDataValues.Add(10,56.01);
CardDataValues.Add(11,40.57);
CardDataValues.Add(12,43.73);
CardDataValues.Add(13,30.12);
CardDataValues.Add(14,18.75);
CardDataValues.Add(15,16.08);
CardDataValues.Add(16,22.06);
CardDataValues.Add(17,28.59);
CardDataValues.Add(18,11.25);
CardDataValues.Add(19,4.84);
CardDataValues.Add(20,30.7);
CardDataValues.Add(21,79.73);
CardDataValues.Add(22,27.55);
CardDataValues.Add(23,5.13);
CardDataValues.Add(24,4.63);
CardDataValues.Add(25,13.74);
CardDataValues.Add(26,5.1);
CardDataValues.Add(27,7.88);
CardDataValues.Add(28,5.29);
CardDataValues.Add(29,6);
CardDataValues.Add(30,5.82);
CardDataValues.Add(31,4.84);
CardDataValues.Add(32,10.15);
CardDataValues.Add(33,5.57);
CardDataValues.Add(34,1.88);
CardDataValues.Add(35,7.95);
CardDataValues.Add(36,1.62);
CardDataValues.Add(37,2.69);
CardDataValues.Add(38,10.31);
CardDataValues.Add(39,3.1);
CardDataValues.Add(40,3.41);
CardDataValues.Add(41,1.67);
CardDataValues.Add(42,2.07);
CardDataValues.Add(43,2.09);
CardDataValues.Add(44,2.35);
CardDataValues.Add(45,8.14);
CardDataValues.Add(46,3.8);
CardDataValues.Add(47,2.7);
CardDataValues.Add(48,1.83);
CardDataValues.Add(49,0.92);
CardDataValues.Add(50,3.56);
CardDataValues.Add(51,0.83);
CardDataValues.Add(52,0.71);
CardDataValues.Add(53,0.97);
CardDataValues.Add(54,0.7);
CardDataValues.Add(55,2.77);
CardDataValues.Add(56,0.83);
CardDataValues.Add(57,0.77);
CardDataValues.Add(58,0.69);
CardDataValues.Add(59,0.86);
CardDataValues.Add(60,0.78);
CardDataValues.Add(61,0.74);
CardDataValues.Add(62,0.85);
CardDataValues.Add(63,0.76);
CardDataValues.Add(64,0.85);
CardDataValues.Add(65,0.9);
CardDataValues.Add(66,0.77);
CardDataValues.Add(67,0.8);
CardDataValues.Add(68,2.54);
CardDataValues.Add(69,0.68);
CardDataValues.Add(70,0.72);
CardDataValues.Add(71,5.67);
CardDataValues.Add(72,6.34);
CardDataValues.Add(73,1.05);
CardDataValues.Add(74,1.08);
CardDataValues.Add(75,0.67);
CardDataValues.Add(76,1.57);
CardDataValues.Add(77,1.78);
CardDataValues.Add(78,0.44);
CardDataValues.Add(79,0.3);
CardDataValues.Add(80,8.4);
CardDataValues.Add(81,0.56);
CardDataValues.Add(82,1.1);
CardDataValues.Add(83,117.78);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}