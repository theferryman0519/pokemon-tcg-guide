using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_GYM_GymChallenge : MonoBehaviour {
		
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
CardDataNames.Add(1,"Blaine's Arcanine");
CardDataNames.Add(2,"Blaine's Charizard");
CardDataNames.Add(3,"Brock's Ninetales");
CardDataNames.Add(4,"Erika's Venusaur");
CardDataNames.Add(5,"Giovanni's Gyarados");
CardDataNames.Add(6,"Giovanni's Machamp");
CardDataNames.Add(7,"Giovanni's Nidoking");
CardDataNames.Add(8,"Giovanni's Persian");
CardDataNames.Add(9,"Koga's Beedrill");
CardDataNames.Add(10,"Koga's Ditto");
CardDataNames.Add(11,"Lt Surge's Raichu");
CardDataNames.Add(12,"Misty's Golduck");
CardDataNames.Add(13,"Misty's Gyarados");
CardDataNames.Add(14,"Rocket's Mewtwo");
CardDataNames.Add(15,"Rocket's Zapdos");
CardDataNames.Add(16,"Sabrina's Alakazam");
CardDataNames.Add(17,"Blaine");
CardDataNames.Add(18,"Giovanni");
CardDataNames.Add(19,"Koga");
CardDataNames.Add(20,"Sabrina");
CardDataNames.Add(21,"Blaine's Ninetales");
CardDataNames.Add(22,"Brock's Dugtrio");
CardDataNames.Add(23,"Giovanni's Nidoqueen");
CardDataNames.Add(24,"Giovanni's Pinsir");
CardDataNames.Add(25,"Koga's Arbok");
CardDataNames.Add(26,"Koga's Muk");
CardDataNames.Add(27,"Koga's Pidgeotto");
CardDataNames.Add(28,"Lt Surge's Jolteon");
CardDataNames.Add(29,"Sabrina's Gengar");
CardDataNames.Add(30,"Sabrina's Golduck");
CardDataNames.Add(31,"Blaine's Charmeleon");
CardDataNames.Add(32,"Blaine's Dodrio");
CardDataNames.Add(33,"Blaine's Rapidash");
CardDataNames.Add(34,"Brock's Graveler");
CardDataNames.Add(35,"Brock's Primeape");
CardDataNames.Add(36,"Brock's Sandslash");
CardDataNames.Add(37,"Brock's Vulpix");
CardDataNames.Add(38,"Erika's Bellsprout");
CardDataNames.Add(39,"Erika's Bulbasaur");
CardDataNames.Add(40,"Erika's Clefairy");
CardDataNames.Add(41,"Erika's Ivysaur");
CardDataNames.Add(42,"Giovanni's Machoke");
CardDataNames.Add(43,"Giovanni's Meowth");
CardDataNames.Add(44,"Giovanni's Nidorina");
CardDataNames.Add(45,"Giovanni's Nidorino");
CardDataNames.Add(46,"Koga's Golbat");
CardDataNames.Add(47,"Koga's Kakuna");
CardDataNames.Add(48,"Koga's Koffing");
CardDataNames.Add(49,"Koga's Pidgey");
CardDataNames.Add(50,"Koga's Weezing");
CardDataNames.Add(51,"Lt Surge's Eevee");
CardDataNames.Add(52,"Lt Surge's Electrode");
CardDataNames.Add(53,"Lt Surge's Raticate");
CardDataNames.Add(54,"Misty's Dewgong");
CardDataNames.Add(55,"Sabrina's Haunter");
CardDataNames.Add(56,"Sabrina's Hypno");
CardDataNames.Add(57,"Sabrina's Jynx");
CardDataNames.Add(58,"Sabrina's Kadabra");
CardDataNames.Add(59,"Sabrina's Mr Mime");
CardDataNames.Add(60,"Blaine's Charmander");
CardDataNames.Add(61,"Blaine's Doduo");
CardDataNames.Add(62,"Blaine's Growlithe");
CardDataNames.Add(63,"Blaine's Mankey");
CardDataNames.Add(64,"Blaine's Ponyta");
CardDataNames.Add(65,"Blaine's Rhyhorn");
CardDataNames.Add(66,"Blaine's Vulpix");
CardDataNames.Add(67,"Brock's Diglett");
CardDataNames.Add(68,"Brock's Geodude");
CardDataNames.Add(69,"Erika's Jigglypuff");
CardDataNames.Add(70,"Erika's Oddish");
CardDataNames.Add(71,"Erika's Paras");
CardDataNames.Add(72,"Giovanni's Machop");
CardDataNames.Add(73,"Giovanni's Magikarp");
CardDataNames.Add(74,"Giovanni's Meowth");
CardDataNames.Add(75,"Giovanni's Nidoran♀");
CardDataNames.Add(76,"Giovanni's Nidoran♂");
CardDataNames.Add(77,"Koga's Ekans");
CardDataNames.Add(78,"Koga's Grimer");
CardDataNames.Add(79,"Koga's Koffing");
CardDataNames.Add(80,"Koga's Pidgey");
CardDataNames.Add(81,"Koga's Tangela");
CardDataNames.Add(82,"Koga's Weedle");
CardDataNames.Add(83,"Koga's Zubat");
CardDataNames.Add(84,"Lt Surge's Pikachu");
CardDataNames.Add(85,"Lt Surge's Rattata");
CardDataNames.Add(86,"Lt Surge's Voltorb");
CardDataNames.Add(87,"Misty's Horsea");
CardDataNames.Add(88,"Misty's Magikarp");
CardDataNames.Add(89,"Misty's Poliwag");
CardDataNames.Add(90,"Misty's Psyduck");
CardDataNames.Add(91,"Misty's Seel");
CardDataNames.Add(92,"Misty's Staryu");
CardDataNames.Add(93,"Sabrina's Abra");
CardDataNames.Add(94,"Sabrina's Abra");
CardDataNames.Add(95,"Sabrina's Drowzee");
CardDataNames.Add(96,"Sabrina's Gastly");
CardDataNames.Add(97,"Sabrina's Gastly");
CardDataNames.Add(98,"Sabrina's Porygon");
CardDataNames.Add(99,"Sabrina's Psyduck");
CardDataNames.Add(100,"Blaine");
CardDataNames.Add(101,"Brock's Protection");
CardDataNames.Add(102,"Chaos Gym");
CardDataNames.Add(103,"Erika's Kindness");
CardDataNames.Add(104,"Giovanni");
CardDataNames.Add(105,"Giovanni's Last Resort");
CardDataNames.Add(106,"Koga");
CardDataNames.Add(107,"Lt Surge's Secret Plan");
CardDataNames.Add(108,"Misty's Wish");
CardDataNames.Add(109,"Resistance Gym");
CardDataNames.Add(110,"Sabrina");
CardDataNames.Add(111,"Blaine's Quiz 2");
CardDataNames.Add(112,"Blaine's Quiz 3");
CardDataNames.Add(113,"Cinnabar City Gym");
CardDataNames.Add(114,"Fuchsia City Gym");
CardDataNames.Add(115,"Koga's Ninja Trick");
CardDataNames.Add(116,"Master Ball");
CardDataNames.Add(117,"Max Revive");
CardDataNames.Add(118,"Misty's Tears");
CardDataNames.Add(119,"Rocket's Minefield Gym");
CardDataNames.Add(120,"Rocket's Secret Experiment");
CardDataNames.Add(121,"Sabrina's Psychic Control");
CardDataNames.Add(122,"Saffron City Gym");
CardDataNames.Add(123,"Viridian City Gym");
CardDataNames.Add(124,"Fervor");
CardDataNames.Add(125,"Transparent Walls");
CardDataNames.Add(126,"Warp Point");
CardDataNames.Add(127,"Fighting");
CardDataNames.Add(128,"Fire");
CardDataNames.Add(129,"Grass");
CardDataNames.Add(130,"Lightning");
CardDataNames.Add(131,"Psychic");
CardDataNames.Add(132,"Water");
	}

	public void SetCardValues() {
CardDataValues.Add(1,177.99);
CardDataValues.Add(2,950.49);
CardDataValues.Add(3,116.98);
CardDataValues.Add(4,120);
CardDataValues.Add(5,144.52);
CardDataValues.Add(6,81.65);
CardDataValues.Add(7,93.67);
CardDataValues.Add(8,81.74);
CardDataValues.Add(9,76.34);
CardDataValues.Add(10,73.92);
CardDataValues.Add(11,94.34);
CardDataValues.Add(12,78.02);
CardDataValues.Add(13,146.12);
CardDataValues.Add(14,323.32);
CardDataValues.Add(15,146.8);
CardDataValues.Add(16,123.53);
CardDataValues.Add(17,66.74);
CardDataValues.Add(18,51.06);
CardDataValues.Add(19,54.82);
CardDataValues.Add(20,90.15);
CardDataValues.Add(21,17.14);
CardDataValues.Add(22,8.03);
CardDataValues.Add(23,10.84);
CardDataValues.Add(24,10.63);
CardDataValues.Add(25,7.29);
CardDataValues.Add(26,6.7);
CardDataValues.Add(27,7.82);
CardDataValues.Add(28,20.24);
CardDataValues.Add(29,66.74);
CardDataValues.Add(30,7.43);
CardDataValues.Add(31,8.2);
CardDataValues.Add(32,2.38);
CardDataValues.Add(33,4.06);
CardDataValues.Add(34,2.44);
CardDataValues.Add(35,3.17);
CardDataValues.Add(36,2.6);
CardDataValues.Add(37,5.83);
CardDataValues.Add(38,2.04);
CardDataValues.Add(39,12.99);
CardDataValues.Add(40,4.53);
CardDataValues.Add(41,10.21);
CardDataValues.Add(42,3.17);
CardDataValues.Add(43,3.24);
CardDataValues.Add(44,2.72);
CardDataValues.Add(45,2.49);
CardDataValues.Add(46,2.18);
CardDataValues.Add(47,1.96);
CardDataValues.Add(48,1.82);
CardDataValues.Add(49,3.05);
CardDataValues.Add(50,2.46);
CardDataValues.Add(51,10.42);
CardDataValues.Add(52,2.88);
CardDataValues.Add(53,2.02);
CardDataValues.Add(54,4.73);
CardDataValues.Add(55,8.27);
CardDataValues.Add(56,3.58);
CardDataValues.Add(57,2.46);
CardDataValues.Add(58,6.62);
CardDataValues.Add(59,4.09);
CardDataValues.Add(60,10.74);
CardDataValues.Add(61,1.2);
CardDataValues.Add(62,2.09);
CardDataValues.Add(63,1.04);
CardDataValues.Add(64,1.35);
CardDataValues.Add(65,0.96);
CardDataValues.Add(66,2.11);
CardDataValues.Add(67,0.92);
CardDataValues.Add(68,1.23);
CardDataValues.Add(69,1.97);
CardDataValues.Add(70,1.19);
CardDataValues.Add(71,0.93);
CardDataValues.Add(72,1.3);
CardDataValues.Add(73,3.02);
CardDataValues.Add(74,1.53);
CardDataValues.Add(75,0.97);
CardDataValues.Add(76,1.53);
CardDataValues.Add(77,1.05);
CardDataValues.Add(78,1.03);
CardDataValues.Add(79,1.04);
CardDataValues.Add(80,1.22);
CardDataValues.Add(81,1.22);
CardDataValues.Add(82,1.45);
CardDataValues.Add(83,1.02);
CardDataValues.Add(84,9.36);
CardDataValues.Add(85,1.03);
CardDataValues.Add(86,1.15);
CardDataValues.Add(87,1.33);
CardDataValues.Add(88,2.77);
CardDataValues.Add(89,1.63);
CardDataValues.Add(90,3.64);
CardDataValues.Add(91,1.15);
CardDataValues.Add(92,1.24);
CardDataValues.Add(93,1.83);
CardDataValues.Add(94,3.05);
CardDataValues.Add(95,1.29);
CardDataValues.Add(96,1.82);
CardDataValues.Add(97,3.88);
CardDataValues.Add(98,1.6);
CardDataValues.Add(99,2.7);
CardDataValues.Add(100,6.89);
CardDataValues.Add(101,5.69);
CardDataValues.Add(102,9.17);
CardDataValues.Add(103,15.82);
CardDataValues.Add(104,7.64);
CardDataValues.Add(105,4.9);
CardDataValues.Add(106,4.62);
CardDataValues.Add(107,4.05);
CardDataValues.Add(108,9.42);
CardDataValues.Add(109,5.42);
CardDataValues.Add(110,10.93);
CardDataValues.Add(111,3.14);
CardDataValues.Add(112,2.79);
CardDataValues.Add(113,1.43);
CardDataValues.Add(114,1.09);
CardDataValues.Add(115,1.71);
CardDataValues.Add(116,3.89);
CardDataValues.Add(117,2.02);
CardDataValues.Add(118,13.53);
CardDataValues.Add(119,1.95);
CardDataValues.Add(120,3.35);
CardDataValues.Add(121,2.47);
CardDataValues.Add(122,1.35);
CardDataValues.Add(123,1.3);
CardDataValues.Add(124,0.92);
CardDataValues.Add(125,1.01);
CardDataValues.Add(126,1.19);
CardDataValues.Add(127,0.89);
CardDataValues.Add(128,0.92);
CardDataValues.Add(129,0.88);
CardDataValues.Add(130,0.92);
CardDataValues.Add(131,1.04);
CardDataValues.Add(132,1.12);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}