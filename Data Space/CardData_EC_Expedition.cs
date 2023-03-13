using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_EC_Expedition : MonoBehaviour {
		
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
CardDataNumbers.Add(133,"133");
CardDataNumbers.Add(134,"134");
CardDataNumbers.Add(135,"135");
CardDataNumbers.Add(136,"136");
CardDataNumbers.Add(137,"137");
CardDataNumbers.Add(138,"138");
CardDataNumbers.Add(139,"139");
CardDataNumbers.Add(140,"140");
CardDataNumbers.Add(141,"141");
CardDataNumbers.Add(142,"142");
CardDataNumbers.Add(143,"143");
CardDataNumbers.Add(144,"144");
CardDataNumbers.Add(145,"145");
CardDataNumbers.Add(146,"146");
CardDataNumbers.Add(147,"147");
CardDataNumbers.Add(148,"148");
CardDataNumbers.Add(149,"149");
CardDataNumbers.Add(150,"150");
CardDataNumbers.Add(151,"151");
CardDataNumbers.Add(152,"152");
CardDataNumbers.Add(153,"153");
CardDataNumbers.Add(154,"154");
CardDataNumbers.Add(155,"155");
CardDataNumbers.Add(156,"156");
CardDataNumbers.Add(157,"157");
CardDataNumbers.Add(158,"158");
CardDataNumbers.Add(159,"159");
CardDataNumbers.Add(160,"160");
CardDataNumbers.Add(161,"161");
CardDataNumbers.Add(162,"162");
CardDataNumbers.Add(163,"163");
CardDataNumbers.Add(164,"164");
CardDataNumbers.Add(165,"165");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Alakazam");
CardDataNames.Add(2,"Ampharos");
CardDataNames.Add(3,"Arbok");
CardDataNames.Add(4,"Blastoise");
CardDataNames.Add(5,"Butterfree");
CardDataNames.Add(6,"Charizard");
CardDataNames.Add(7,"Clefable");
CardDataNames.Add(8,"Cloyster");
CardDataNames.Add(9,"Dragonite");
CardDataNames.Add(10,"Dugtrio");
CardDataNames.Add(11,"Fearow");
CardDataNames.Add(12,"Feraligatr");
CardDataNames.Add(13,"Gengar");
CardDataNames.Add(14,"Golem");
CardDataNames.Add(15,"Kingler");
CardDataNames.Add(16,"Machamp");
CardDataNames.Add(17,"Magby");
CardDataNames.Add(18,"Meganium");
CardDataNames.Add(19,"Mew");
CardDataNames.Add(20,"Mewtwo");
CardDataNames.Add(21,"Ninetales");
CardDataNames.Add(22,"Pichu");
CardDataNames.Add(23,"Pidgeot");
CardDataNames.Add(24,"Poliwrath");
CardDataNames.Add(25,"Raichu");
CardDataNames.Add(26,"Rapidash");
CardDataNames.Add(27,"Skarmory");
CardDataNames.Add(28,"Typhlosion");
CardDataNames.Add(29,"Tyranitar");
CardDataNames.Add(30,"Venusaur");
CardDataNames.Add(31,"Vileplume");
CardDataNames.Add(32,"Weezing");
CardDataNames.Add(33,"Alakazam");
CardDataNames.Add(34,"Ampharos");
CardDataNames.Add(35,"Arbok");
CardDataNames.Add(36,"Blastoise");
CardDataNames.Add(37,"Blastoise");
CardDataNames.Add(38,"Butterfree");
CardDataNames.Add(39,"Charizard");
CardDataNames.Add(40,"Charizard");
CardDataNames.Add(41,"Clefable");
CardDataNames.Add(42,"Cloyster");
CardDataNames.Add(43,"Dragonite");
CardDataNames.Add(44,"Dugtrio");
CardDataNames.Add(45,"Fearow");
CardDataNames.Add(46,"Feraligatr");
CardDataNames.Add(47,"Feraligatr");
CardDataNames.Add(48,"Gengar");
CardDataNames.Add(49,"Golem");
CardDataNames.Add(50,"Kingler");
CardDataNames.Add(51,"Machamp");
CardDataNames.Add(52,"Magby");
CardDataNames.Add(53,"Meganium");
CardDataNames.Add(54,"Meganium");
CardDataNames.Add(55,"Mew");
CardDataNames.Add(56,"Mewtwo");
CardDataNames.Add(57,"Ninetales");
CardDataNames.Add(58,"Pichu");
CardDataNames.Add(59,"Pidgeot");
CardDataNames.Add(60,"Poliwrath");
CardDataNames.Add(61,"Raichu");
CardDataNames.Add(62,"Rapidash");
CardDataNames.Add(63,"Skarmory");
CardDataNames.Add(64,"Typhlosion");
CardDataNames.Add(65,"Typhlosion");
CardDataNames.Add(66,"Tyranitar");
CardDataNames.Add(67,"Venusaur");
CardDataNames.Add(68,"Venusaur");
CardDataNames.Add(69,"Vileplume");
CardDataNames.Add(70,"Weezing");
CardDataNames.Add(71,"Bayleef");
CardDataNames.Add(72,"Chansey");
CardDataNames.Add(73,"Charmeleon");
CardDataNames.Add(74,"Croconaw");
CardDataNames.Add(75,"Dragonair");
CardDataNames.Add(76,"Electabuzz");
CardDataNames.Add(77,"Flaaffy");
CardDataNames.Add(78,"Gloom");
CardDataNames.Add(79,"Graveler");
CardDataNames.Add(80,"Haunter");
CardDataNames.Add(81,"Hitmonlee");
CardDataNames.Add(82,"Ivysaur");
CardDataNames.Add(83,"Jynx");
CardDataNames.Add(84,"Kadabra");
CardDataNames.Add(85,"Machoke");
CardDataNames.Add(86,"Magmar");
CardDataNames.Add(87,"Metapod");
CardDataNames.Add(88,"Pidgeotto");
CardDataNames.Add(89,"Poliwhirl");
CardDataNames.Add(90,"Pupitar");
CardDataNames.Add(91,"Quilava");
CardDataNames.Add(92,"Wartortle");
CardDataNames.Add(93,"Abra");
CardDataNames.Add(94,"Bulbasaur");
CardDataNames.Add(95,"Bulbasaur");
CardDataNames.Add(96,"Caterpie");
CardDataNames.Add(97,"Charmander");
CardDataNames.Add(98,"Charmander");
CardDataNames.Add(99,"Chikorita");
CardDataNames.Add(100,"Chikorita");
CardDataNames.Add(101,"Clefairy");
CardDataNames.Add(102,"Corsola");
CardDataNames.Add(103,"Cubone");
CardDataNames.Add(104,"Cyndaquil");
CardDataNames.Add(105,"Cyndaquil");
CardDataNames.Add(106,"Diglett");
CardDataNames.Add(107,"Dratini");
CardDataNames.Add(108,"Ekans");
CardDataNames.Add(109,"Gastly");
CardDataNames.Add(110,"Geodude");
CardDataNames.Add(111,"Goldeen");
CardDataNames.Add(112,"Hoppip");
CardDataNames.Add(113,"Houndour");
CardDataNames.Add(114,"Koffing");
CardDataNames.Add(115,"Krabby");
CardDataNames.Add(116,"Larvitar");
CardDataNames.Add(117,"Machop");
CardDataNames.Add(118,"Magikarp");
CardDataNames.Add(119,"Mareep");
CardDataNames.Add(120,"Marill");
CardDataNames.Add(121,"Meowth");
CardDataNames.Add(122,"Oddish");
CardDataNames.Add(123,"Pidgey");
CardDataNames.Add(124,"Pikachu");
CardDataNames.Add(125,"Poliwag");
CardDataNames.Add(126,"Ponyta");
CardDataNames.Add(127,"Qwilfish");
CardDataNames.Add(128,"Rattata");
CardDataNames.Add(129,"Shellder");
CardDataNames.Add(130,"Spearow");
CardDataNames.Add(131,"Squirtle");
CardDataNames.Add(132,"Squirtle");
CardDataNames.Add(133,"Tauros");
CardDataNames.Add(134,"Totodile");
CardDataNames.Add(135,"Totodile");
CardDataNames.Add(136,"Vulpix");
CardDataNames.Add(137,"Bill's Maintenance");
CardDataNames.Add(138,"Copycat");
CardDataNames.Add(139,"Dual Ball");
CardDataNames.Add(140,"Energy Removal 2");
CardDataNames.Add(141,"Energy Restore");
CardDataNames.Add(142,"Mary's Impulse");
CardDataNames.Add(143,"Master Ball");
CardDataNames.Add(144,"Multi Technical Machine 01");
CardDataNames.Add(145,"Pokémon Nurse");
CardDataNames.Add(146,"Pokémon Reversal");
CardDataNames.Add(147,"Power Charge");
CardDataNames.Add(148,"Professor Elm's Training Method");
CardDataNames.Add(149,"Professor Oak's Research");
CardDataNames.Add(150,"Strength Charm");
CardDataNames.Add(151,"Super Scoop Up");
CardDataNames.Add(152,"Warp Point");
CardDataNames.Add(153,"Energy Search");
CardDataNames.Add(154,"Full Heal");
CardDataNames.Add(155,"Moo-Moo Milk");
CardDataNames.Add(156,"Potion");
CardDataNames.Add(157,"Switch");
CardDataNames.Add(158,"Darkness Energy");
CardDataNames.Add(159,"Metal Energy");
CardDataNames.Add(160,"Fighting");
CardDataNames.Add(161,"Fire");
CardDataNames.Add(162,"Grass");
CardDataNames.Add(163,"Lightning");
CardDataNames.Add(164,"Psychic");
CardDataNames.Add(165,"Water");
	}

	public void SetCardValues() {
CardDataValues.Add(1,74.99);
CardDataValues.Add(2,39.5);
CardDataValues.Add(3,50.89);
CardDataValues.Add(4,258.31);
CardDataValues.Add(5,56.94);
CardDataValues.Add(6,487.49);
CardDataValues.Add(7,70.98);
CardDataValues.Add(8,49.99);
CardDataValues.Add(9,224.97);
CardDataValues.Add(10,34.57);
CardDataValues.Add(11,38.78);
CardDataValues.Add(12,89.5);
CardDataValues.Add(13,133.12);
CardDataValues.Add(14,34.23);
CardDataValues.Add(15,29.96);
CardDataValues.Add(16,69.99);
CardDataValues.Add(17,37.02);
CardDataValues.Add(18,69.25);
CardDataValues.Add(19,180);
CardDataValues.Add(20,255.98);
CardDataValues.Add(21,60);
CardDataValues.Add(22,73.56);
CardDataValues.Add(23,69.99);
CardDataValues.Add(24,44.99);
CardDataValues.Add(25,71.25);
CardDataValues.Add(26,27.65);
CardDataValues.Add(27,50.14);
CardDataValues.Add(28,108.05);
CardDataValues.Add(29,170.39);
CardDataValues.Add(30,67.47);
CardDataValues.Add(31,39.95);
CardDataValues.Add(32,87.74);
CardDataValues.Add(33,6.99);
CardDataValues.Add(34,8.85);
CardDataValues.Add(35,4);
CardDataValues.Add(36,24.95);
CardDataValues.Add(37,21.5);
CardDataValues.Add(38,5.13);
CardDataValues.Add(39,77.49);
CardDataValues.Add(40,66);
CardDataValues.Add(41,1.84);
CardDataValues.Add(42,6.31);
CardDataValues.Add(43,25.51);
CardDataValues.Add(44,4.28);
CardDataValues.Add(45,3.48);
CardDataValues.Add(46,8.83);
CardDataValues.Add(47,18.88);
CardDataValues.Add(48,33.97);
CardDataValues.Add(49,5.81);
CardDataValues.Add(50,4.05);
CardDataValues.Add(51,3.27);
CardDataValues.Add(52,4.29);
CardDataValues.Add(53,7.55);
CardDataValues.Add(54,6.19);
CardDataValues.Add(55,26.47);
CardDataValues.Add(56,22.95);
CardDataValues.Add(57,9.11);
CardDataValues.Add(58,14.32);
CardDataValues.Add(59,5.16);
CardDataValues.Add(60,7.99);
CardDataValues.Add(61,4.15);
CardDataValues.Add(62,4.99);
CardDataValues.Add(63,4.31);
CardDataValues.Add(64,12);
CardDataValues.Add(65,9.99);
CardDataValues.Add(66,18.97);
CardDataValues.Add(67,16.26);
CardDataValues.Add(68,10.65);
CardDataValues.Add(69,1.85);
CardDataValues.Add(70,1.59);
CardDataValues.Add(71,3.88);
CardDataValues.Add(72,1.1);
CardDataValues.Add(73,9.48);
CardDataValues.Add(74,3.49);
CardDataValues.Add(75,4.35);
CardDataValues.Add(76,1);
CardDataValues.Add(77,1.48);
CardDataValues.Add(78,1.11);
CardDataValues.Add(79,2.05);
CardDataValues.Add(80,2.08);
CardDataValues.Add(81,3.49);
CardDataValues.Add(82,5.68);
CardDataValues.Add(83,2.49);
CardDataValues.Add(84,3.74);
CardDataValues.Add(85,1.34);
CardDataValues.Add(86,2.43);
CardDataValues.Add(87,3.46);
CardDataValues.Add(88,3.89);
CardDataValues.Add(89,4.73);
CardDataValues.Add(90,1.52);
CardDataValues.Add(91,5.16);
CardDataValues.Add(92,9.7);
CardDataValues.Add(93,0.99);
CardDataValues.Add(94,6.49);
CardDataValues.Add(95,9.82);
CardDataValues.Add(96,1.8);
CardDataValues.Add(97,4.74);
CardDataValues.Add(98,10.22);
CardDataValues.Add(99,2.99);
CardDataValues.Add(100,2.57);
CardDataValues.Add(101,0.99);
CardDataValues.Add(102,1.17);
CardDataValues.Add(103,9);
CardDataValues.Add(104,4.17);
CardDataValues.Add(105,2.7);
CardDataValues.Add(106,1.13);
CardDataValues.Add(107,2.69);
CardDataValues.Add(108,1.07);
CardDataValues.Add(109,0.94);
CardDataValues.Add(110,1.04);
CardDataValues.Add(111,1.16);
CardDataValues.Add(112,0.58);
CardDataValues.Add(113,1.94);
CardDataValues.Add(114,0.76);
CardDataValues.Add(115,1);
CardDataValues.Add(116,1.6);
CardDataValues.Add(117,0.83);
CardDataValues.Add(118,3.53);
CardDataValues.Add(119,0.94);
CardDataValues.Add(120,1.99);
CardDataValues.Add(121,1.06);
CardDataValues.Add(122,0.6);
CardDataValues.Add(123,1.86);
CardDataValues.Add(124,4.45);
CardDataValues.Add(125,2);
CardDataValues.Add(126,1.49);
CardDataValues.Add(127,1.4);
CardDataValues.Add(128,1.34);
CardDataValues.Add(129,1.13);
CardDataValues.Add(130,1.5);
CardDataValues.Add(131,7.99);
CardDataValues.Add(132,25);
CardDataValues.Add(133,1.98);
CardDataValues.Add(134,4.96);
CardDataValues.Add(135,3.39);
CardDataValues.Add(136,5);
CardDataValues.Add(137,0.49);
CardDataValues.Add(138,0.97);
CardDataValues.Add(139,1.45);
CardDataValues.Add(140,0.99);
CardDataValues.Add(141,1.23);
CardDataValues.Add(142,1.99);
CardDataValues.Add(143,2.14);
CardDataValues.Add(144,1.49);
CardDataValues.Add(145,4.92);
CardDataValues.Add(146,2.15);
CardDataValues.Add(147,0.85);
CardDataValues.Add(148,0.98);
CardDataValues.Add(149,1);
CardDataValues.Add(150,3.13);
CardDataValues.Add(151,2.41);
CardDataValues.Add(152,2.24);
CardDataValues.Add(153,0.57);
CardDataValues.Add(154,0.5);
CardDataValues.Add(155,0.49);
CardDataValues.Add(156,0.45);
CardDataValues.Add(157,1.66);
CardDataValues.Add(158,5.01);
CardDataValues.Add(159,7.62);
CardDataValues.Add(160,0.65);
CardDataValues.Add(161,1.29);
CardDataValues.Add(162,0.75);
CardDataValues.Add(163,0.7);
CardDataValues.Add(164,1);
CardDataValues.Add(165,2.71);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}