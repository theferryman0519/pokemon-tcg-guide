using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_GYM_GymHeroes : MonoBehaviour {
		
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
CardDataNumbers.Add(84,"84");
CardDataNumbers.Add(85,"85");
CardDataNumbers.Add(86,"86");
CardDataNumbers.Add(87,"87");
CardDataNumbers.Add(88,"88");
CardDataNumbers.Add(89,"89");
CardDataNumbers.Add(90,"90");
CardDataNumbers.Add(91,"91");
CardDataNumbers.Add(92,"92");
CardDataNumbers.Add(93,"93");
CardDataNumbers.Add(94,"94");
CardDataNumbers.Add(95,"95");
CardDataNumbers.Add(96,"96");
CardDataNumbers.Add(97,"97");
CardDataNumbers.Add(98,"98");
CardDataNumbers.Add(99,"99");
CardDataNumbers.Add(100,"100");
CardDataNumbers.Add(101,"101");
CardDataNumbers.Add(102,"102");
CardDataNumbers.Add(103,"103");
CardDataNumbers.Add(104,"104");
CardDataNumbers.Add(105,"105");
CardDataNumbers.Add(106,"106");
CardDataNumbers.Add(107,"107");
CardDataNumbers.Add(108,"108");
CardDataNumbers.Add(109,"109");
CardDataNumbers.Add(110,"110");
CardDataNumbers.Add(111,"111");
CardDataNumbers.Add(112,"112");
CardDataNumbers.Add(113,"113");
CardDataNumbers.Add(114,"114");
CardDataNumbers.Add(115,"115");
CardDataNumbers.Add(116,"116");
CardDataNumbers.Add(117,"117");
CardDataNumbers.Add(118,"118");
CardDataNumbers.Add(119,"119");
CardDataNumbers.Add(120,"120");
CardDataNumbers.Add(121,"121");
CardDataNumbers.Add(122,"122");
CardDataNumbers.Add(123,"123");
CardDataNumbers.Add(124,"124");
CardDataNumbers.Add(125,"125");
CardDataNumbers.Add(126,"126");
CardDataNumbers.Add(127,"127");
CardDataNumbers.Add(128,"128");
CardDataNumbers.Add(129,"129");
CardDataNumbers.Add(130,"130");
CardDataNumbers.Add(131,"131");
CardDataNumbers.Add(132,"132");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Blaine's Moltres");
CardDataNames.Add(2,"Brock's Rhydon");
CardDataNames.Add(3,"Erika's Clefable");
CardDataNames.Add(4,"Erika's Dragonair");
CardDataNames.Add(5,"Erika's Vileplume");
CardDataNames.Add(6,"Lt Surge's Electabuzz");
CardDataNames.Add(7,"Lt Surge's Fearow");
CardDataNames.Add(8,"Lt Surge's Magneton");
CardDataNames.Add(9,"Misty's Seadra");
CardDataNames.Add(10,"Misty's Tentacruel");
CardDataNames.Add(11,"Rocket's Hitmonchan");
CardDataNames.Add(12,"Rocket's Moltres");
CardDataNames.Add(13,"Rocket's Scyther");
CardDataNames.Add(14,"Sabrina's Gengar");
CardDataNames.Add(15,"Brock");
CardDataNames.Add(16,"Erika");
CardDataNames.Add(17,"Lt Surge");
CardDataNames.Add(18,"Misty");
CardDataNames.Add(19,"The Rocket's Trap");
CardDataNames.Add(20,"Brock's Golem");
CardDataNames.Add(21,"Brock's Onix");
CardDataNames.Add(22,"Brock's Rhyhorn");
CardDataNames.Add(23,"Brock's Sandslash");
CardDataNames.Add(24,"Brock's Zubat");
CardDataNames.Add(25,"Erika's Clefairy");
CardDataNames.Add(26,"Erika's Victreebel");
CardDataNames.Add(27,"Lt Surge's Electabuzz");
CardDataNames.Add(28,"Lt Surge's Raichu");
CardDataNames.Add(29,"Misty's Cloyster");
CardDataNames.Add(30,"Misty's Goldeen");
CardDataNames.Add(31,"Misty's Poliwrath");
CardDataNames.Add(32,"Misty's Tentacool");
CardDataNames.Add(33,"Rocket's Snorlax");
CardDataNames.Add(34,"Sabrina's Venomoth");
CardDataNames.Add(35,"Blaine's Growlithe");
CardDataNames.Add(36,"Blaine's Kangaskhan");
CardDataNames.Add(37,"Blaine's Magmar");
CardDataNames.Add(38,"Brock's Geodude");
CardDataNames.Add(39,"Brock's Golbat");
CardDataNames.Add(40,"Brock's Graveler");
CardDataNames.Add(41,"Brock's Lickitung");
CardDataNames.Add(42,"Erika's Dratini");
CardDataNames.Add(43,"Erika's Exeggcute");
CardDataNames.Add(44,"Erika's Exeggutor");
CardDataNames.Add(45,"Erika's Gloom");
CardDataNames.Add(46,"Erika's Gloom");
CardDataNames.Add(47,"Erika's Oddish");
CardDataNames.Add(48,"Erika's Weepinbell");
CardDataNames.Add(49,"Erika's Weepinbell");
CardDataNames.Add(50,"Lt Surge's Magnemite");
CardDataNames.Add(51,"Lt Surge's Raticate");
CardDataNames.Add(52,"Lt Surge's Spearow");
CardDataNames.Add(53,"Misty's Poliwhirl");
CardDataNames.Add(54,"Misty's Psyduck");
CardDataNames.Add(55,"Misty's Seaking");
CardDataNames.Add(56,"Misty's Starmie");
CardDataNames.Add(57,"Misty's Tentacool");
CardDataNames.Add(58,"Sabrina's Haunter");
CardDataNames.Add(59,"Sabrina's Jynx");
CardDataNames.Add(60,"Sabrina's Slowbro");
CardDataNames.Add(61,"Blaine's Charmander");
CardDataNames.Add(62,"Blaine's Growlithe");
CardDataNames.Add(63,"Blaine's Ponyta");
CardDataNames.Add(64,"Blaine's Tauros");
CardDataNames.Add(65,"Blaine's Vulpix");
CardDataNames.Add(66,"Brock's Geodude");
CardDataNames.Add(67,"Brock's Mankey");
CardDataNames.Add(68,"Brock's Mankey");
CardDataNames.Add(69,"Brock's Onix");
CardDataNames.Add(70,"Brock's Rhyhorn");
CardDataNames.Add(71,"Brock's Sandshrew");
CardDataNames.Add(72,"Brock's Sandshrew");
CardDataNames.Add(73,"Brock's Vulpix");
CardDataNames.Add(74,"Brock's Zubat");
CardDataNames.Add(75,"Erika's Bellsprout");
CardDataNames.Add(76,"Erika's Bellsprout");
CardDataNames.Add(77,"Erika's Exeggcute");
CardDataNames.Add(78,"Erika's Oddish");
CardDataNames.Add(79,"Erika's Tangela");
CardDataNames.Add(80,"Lt Surge's Magnemite");
CardDataNames.Add(81,"Lt Surge's Pikachu");
CardDataNames.Add(82,"Lt Surge's Rattata");
CardDataNames.Add(83,"Lt Surge's Spearow");
CardDataNames.Add(84,"Lt Surge's Voltorb");
CardDataNames.Add(85,"Misty's Goldeen");
CardDataNames.Add(86,"Misty's Horsea");
CardDataNames.Add(87,"Misty's Poliwag");
CardDataNames.Add(88,"Misty's Seel");
CardDataNames.Add(89,"Misty's Shellder");
CardDataNames.Add(90,"Misty's Staryu");
CardDataNames.Add(91,"Sabrina's Abra");
CardDataNames.Add(92,"Sabrina's Drowzee");
CardDataNames.Add(93,"Sabrina's Gastly");
CardDataNames.Add(94,"Sabrina's Mr Mime");
CardDataNames.Add(95,"Sabrina's Slowpoke");
CardDataNames.Add(96,"Sabrina's Venonat");
CardDataNames.Add(97,"Blaine's Quiz 1");
CardDataNames.Add(98,"Brock");
CardDataNames.Add(99,"Charity");
CardDataNames.Add(100,"Erika");
CardDataNames.Add(101,"Lt Surge");
CardDataNames.Add(102,"Misty");
CardDataNames.Add(103,"No Removal Gym");
CardDataNames.Add(104,"The Rocket's Training Gym");
CardDataNames.Add(105,"Blaine's Last Resort");
CardDataNames.Add(106,"Brock's Training Method");
CardDataNames.Add(107,"Celadon City Gym");
CardDataNames.Add(108,"Cerulean City Gym");
CardDataNames.Add(109,"Erika's Maids");
CardDataNames.Add(110,"Erika's Perfume");
CardDataNames.Add(111,"Good Manners");
CardDataNames.Add(112,"Lt Surge's Treaty");
CardDataNames.Add(113,"Minion of Team Rocket");
CardDataNames.Add(114,"Misty's Wrath");
CardDataNames.Add(115,"Pewter City Gym");
CardDataNames.Add(116,"Recall");
CardDataNames.Add(117,"Sabrina's ESP");
CardDataNames.Add(118,"Secret Mission");
CardDataNames.Add(119,"Tickling Machine");
CardDataNames.Add(120,"Vermillion City Gym");
CardDataNames.Add(121,"Blaine's Gamble");
CardDataNames.Add(122,"Energy Flow");
CardDataNames.Add(123,"Misty's Duel");
CardDataNames.Add(124,"Narrow Gym");
CardDataNames.Add(125,"Sabrina's Gaze");
CardDataNames.Add(126,"Trash Exchange");
CardDataNames.Add(127,"Fighting");
CardDataNames.Add(128,"Fire");
CardDataNames.Add(129,"Grass");
CardDataNames.Add(130,"Lightning");
CardDataNames.Add(131,"Psychic");
CardDataNames.Add(132,"Water");
	}

	public void SetCardValues() {
CardDataValues.Add(1,174.73);
CardDataValues.Add(2,76.44);
CardDataValues.Add(3,57.61);
CardDataValues.Add(4,106.62);
CardDataValues.Add(5,39.6);
CardDataValues.Add(6,43.63);
CardDataValues.Add(7,45.56);
CardDataValues.Add(8,35.65);
CardDataValues.Add(9,42.19);
CardDataValues.Add(10,47.82);
CardDataValues.Add(11,53.35);
CardDataValues.Add(12,132.27);
CardDataValues.Add(13,132.97);
CardDataValues.Add(14,275);
CardDataValues.Add(15,70.97);
CardDataValues.Add(16,61.67);
CardDataValues.Add(17,43.59);
CardDataValues.Add(18,97.04);
CardDataValues.Add(19,47.84);
CardDataValues.Add(20,12.09);
CardDataValues.Add(21,11.58);
CardDataValues.Add(22,11.83);
CardDataValues.Add(23,10.71);
CardDataValues.Add(24,12.64);
CardDataValues.Add(25,7.36);
CardDataValues.Add(26,13.06);
CardDataValues.Add(27,9.04);
CardDataValues.Add(28,22.12);
CardDataValues.Add(29,16.08);
CardDataValues.Add(30,6.88);
CardDataValues.Add(31,16.41);
CardDataValues.Add(32,10.17);
CardDataValues.Add(33,40.25);
CardDataValues.Add(34,7.96);
CardDataValues.Add(35,4.05);
CardDataValues.Add(36,4.88);
CardDataValues.Add(37,4.82);
CardDataValues.Add(38,2.75);
CardDataValues.Add(39,2.74);
CardDataValues.Add(40,1.95);
CardDataValues.Add(41,3.03);
CardDataValues.Add(42,6.12);
CardDataValues.Add(43,2.33);
CardDataValues.Add(44,2.89);
CardDataValues.Add(45,2.2);
CardDataValues.Add(46,3.9);
CardDataValues.Add(47,2.71);
CardDataValues.Add(48,5.83);
CardDataValues.Add(49,2.44);
CardDataValues.Add(50,2.16);
CardDataValues.Add(51,2.15);
CardDataValues.Add(52,1.73);
CardDataValues.Add(53,3.23);
CardDataValues.Add(54,4.48);
CardDataValues.Add(55,2.8);
CardDataValues.Add(56,5.01);
CardDataValues.Add(57,3.89);
CardDataValues.Add(58,7.83);
CardDataValues.Add(59,3.37);
CardDataValues.Add(60,5.38);
CardDataValues.Add(61,4.24);
CardDataValues.Add(62,2.89);
CardDataValues.Add(63,1.61);
CardDataValues.Add(64,1.63);
CardDataValues.Add(65,2.01);
CardDataValues.Add(66,1.17);
CardDataValues.Add(67,0.98);
CardDataValues.Add(68,1.28);
CardDataValues.Add(69,1.6);
CardDataValues.Add(70,1.13);
CardDataValues.Add(71,1.34);
CardDataValues.Add(72,2.03);
CardDataValues.Add(73,2.63);
CardDataValues.Add(74,1.21);
CardDataValues.Add(75,1.39);
CardDataValues.Add(76,0.95);
CardDataValues.Add(77,1.35);
CardDataValues.Add(78,1.34);
CardDataValues.Add(79,1.15);
CardDataValues.Add(80,1.27);
CardDataValues.Add(81,8.12);
CardDataValues.Add(82,1.02);
CardDataValues.Add(83,0.93);
CardDataValues.Add(84,1.33);
CardDataValues.Add(85,1.04);
CardDataValues.Add(86,1.39);
CardDataValues.Add(87,1.51);
CardDataValues.Add(88,1.24);
CardDataValues.Add(89,1.32);
CardDataValues.Add(90,1.47);
CardDataValues.Add(91,1.6);
CardDataValues.Add(92,1.42);
CardDataValues.Add(93,2.28);
CardDataValues.Add(94,1.43);
CardDataValues.Add(95,1.73);
CardDataValues.Add(96,1.29);
CardDataValues.Add(97,7.87);
CardDataValues.Add(98,8.82);
CardDataValues.Add(99,8.24);
CardDataValues.Add(100,9.11);
CardDataValues.Add(101,7.2);
CardDataValues.Add(102,10.47);
CardDataValues.Add(103,9.16);
CardDataValues.Add(104,12.57);
CardDataValues.Add(105,1.37);
CardDataValues.Add(106,1.85);
CardDataValues.Add(107,1.52);
CardDataValues.Add(108,1.57);
CardDataValues.Add(109,2.36);
CardDataValues.Add(110,1.93);
CardDataValues.Add(111,4.16);
CardDataValues.Add(112,1.59);
CardDataValues.Add(113,5.72);
CardDataValues.Add(114,3.82);
CardDataValues.Add(115,1.76);
CardDataValues.Add(116,5.06);
CardDataValues.Add(117,2.5);
CardDataValues.Add(118,1.81);
CardDataValues.Add(119,3.39);
CardDataValues.Add(120,1.4);
CardDataValues.Add(121,0.95);
CardDataValues.Add(122,0.64);
CardDataValues.Add(123,1.66);
CardDataValues.Add(124,1.37);
CardDataValues.Add(125,1.14);
CardDataValues.Add(126,1.63);
CardDataValues.Add(127,1.33);
CardDataValues.Add(128,1.53);
CardDataValues.Add(129,0.99);
CardDataValues.Add(130,1.04);
CardDataValues.Add(131,1);
CardDataValues.Add(132,1.08);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}