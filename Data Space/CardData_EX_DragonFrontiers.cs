using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_EX_DragonFrontiers : MonoBehaviour {
		
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
CardDataNumbers.Add(33,"32H");
CardDataNumbers.Add(34,"32RH");
CardDataNumbers.Add(35,"33");
CardDataNumbers.Add(36,"34");
CardDataNumbers.Add(37,"35");
CardDataNumbers.Add(38,"36");
CardDataNumbers.Add(39,"37");
CardDataNumbers.Add(40,"38");
CardDataNumbers.Add(41,"39");
CardDataNumbers.Add(42,"40");
CardDataNumbers.Add(43,"41");
CardDataNumbers.Add(44,"42");
CardDataNumbers.Add(45,"43");
CardDataNumbers.Add(46,"44");
CardDataNumbers.Add(47,"45");
CardDataNumbers.Add(48,"46");
CardDataNumbers.Add(49,"47");
CardDataNumbers.Add(50,"48");
CardDataNumbers.Add(51,"49");
CardDataNumbers.Add(52,"50");
CardDataNumbers.Add(53,"51");
CardDataNumbers.Add(54,"51H");
CardDataNumbers.Add(55,"51RH");
CardDataNumbers.Add(56,"52");
CardDataNumbers.Add(57,"53");
CardDataNumbers.Add(58,"54");
CardDataNumbers.Add(59,"55");
CardDataNumbers.Add(60,"56");
CardDataNumbers.Add(61,"57");
CardDataNumbers.Add(62,"58");
CardDataNumbers.Add(63,"58H");
CardDataNumbers.Add(64,"58RH");
CardDataNumbers.Add(65,"59");
CardDataNumbers.Add(66,"60");
CardDataNumbers.Add(67,"60H");
CardDataNumbers.Add(68,"60RH");
CardDataNumbers.Add(69,"61");
CardDataNumbers.Add(70,"62");
CardDataNumbers.Add(71,"63");
CardDataNumbers.Add(72,"64");
CardDataNumbers.Add(73,"65");
CardDataNumbers.Add(74,"66");
CardDataNumbers.Add(75,"67");
CardDataNumbers.Add(76,"68");
CardDataNumbers.Add(77,"69");
CardDataNumbers.Add(78,"70");
CardDataNumbers.Add(79,"71");
CardDataNumbers.Add(80,"72");
CardDataNumbers.Add(81,"72H");
CardDataNumbers.Add(82,"72RH");
CardDataNumbers.Add(83,"73");
CardDataNumbers.Add(84,"73H");
CardDataNumbers.Add(85,"73RH");
CardDataNumbers.Add(86,"74");
CardDataNumbers.Add(87,"74H");
CardDataNumbers.Add(88,"74RH");
CardDataNumbers.Add(89,"75");
CardDataNumbers.Add(90,"75H");
CardDataNumbers.Add(91,"75RH");
CardDataNumbers.Add(92,"76");
CardDataNumbers.Add(93,"76H");
CardDataNumbers.Add(94,"76RH");
CardDataNumbers.Add(95,"77");
CardDataNumbers.Add(96,"77H");
CardDataNumbers.Add(97,"77RH");
CardDataNumbers.Add(98,"78");
CardDataNumbers.Add(99,"78H");
CardDataNumbers.Add(100,"78RH");
CardDataNumbers.Add(101,"79");
CardDataNumbers.Add(102,"79H");
CardDataNumbers.Add(103,"79RH");
CardDataNumbers.Add(104,"80");
CardDataNumbers.Add(105,"80H");
CardDataNumbers.Add(106,"80RH");
CardDataNumbers.Add(107,"81");
CardDataNumbers.Add(108,"81H");
CardDataNumbers.Add(109,"81RH");
CardDataNumbers.Add(110,"82");
CardDataNumbers.Add(111,"82H");
CardDataNumbers.Add(112,"82RH");
CardDataNumbers.Add(113,"83");
CardDataNumbers.Add(114,"83H");
CardDataNumbers.Add(115,"83RH");
CardDataNumbers.Add(116,"84");
CardDataNumbers.Add(117,"84H");
CardDataNumbers.Add(118,"84RH");
CardDataNumbers.Add(119,"85");
CardDataNumbers.Add(120,"85H");
CardDataNumbers.Add(121,"85RH");
CardDataNumbers.Add(122,"86");
CardDataNumbers.Add(123,"86H");
CardDataNumbers.Add(124,"86RH");
CardDataNumbers.Add(125,"87");
CardDataNumbers.Add(126,"87H");
CardDataNumbers.Add(127,"87RH");
CardDataNumbers.Add(128,"88");
CardDataNumbers.Add(129,"88H");
CardDataNumbers.Add(130,"88RH");
CardDataNumbers.Add(131,"89");
CardDataNumbers.Add(132,"89H");
CardDataNumbers.Add(133,"89RH");
CardDataNumbers.Add(134,"90");
CardDataNumbers.Add(135,"91");
CardDataNumbers.Add(136,"92");
CardDataNumbers.Add(137,"93");
CardDataNumbers.Add(138,"94");
CardDataNumbers.Add(139,"95");
CardDataNumbers.Add(140,"96");
CardDataNumbers.Add(141,"97");
CardDataNumbers.Add(142,"98");
CardDataNumbers.Add(143,"99");
CardDataNumbers.Add(144,"100");
CardDataNumbers.Add(145,"101");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Ampharos δ");
CardDataNames.Add(2,"Feraligatr δ");
CardDataNames.Add(3,"Heracross δ");
CardDataNames.Add(4,"Meganium δ");
CardDataNames.Add(5,"Milotic δ");
CardDataNames.Add(6,"Nidoking δ");
CardDataNames.Add(7,"Nidoqueen δ");
CardDataNames.Add(8,"Ninetales δ");
CardDataNames.Add(9,"Pinsir δ");
CardDataNames.Add(10,"Snorlax δ");
CardDataNames.Add(11,"Togetic δ");
CardDataNames.Add(12,"Typhlosion δ");
CardDataNames.Add(13,"Arbok δ");
CardDataNames.Add(14,"Cloyster δ");
CardDataNames.Add(15,"Dewgong δ");
CardDataNames.Add(16,"Gligar δ");
CardDataNames.Add(17,"Jynx δ");
CardDataNames.Add(18,"Ledian δ");
CardDataNames.Add(19,"Lickitung δ");
CardDataNames.Add(20,"Mantine δ");
CardDataNames.Add(21,"Quagsire δ");
CardDataNames.Add(22,"Seadra δ");
CardDataNames.Add(23,"Tropius δ");
CardDataNames.Add(24,"Vibrava δ");
CardDataNames.Add(25,"Xatu δ");
CardDataNames.Add(26,"Bayleef δ");
CardDataNames.Add(27,"Croconaw δ");
CardDataNames.Add(28,"Dragonair δ");
CardDataNames.Add(29,"Electabuzz δ");
CardDataNames.Add(30,"Flaaffy δ");
CardDataNames.Add(31,"Horsea δ");
CardDataNames.Add(32,"Kirlia");
CardDataNames.Add(33,"Kirlia Holofoil");
CardDataNames.Add(34,"Kirlia Reverse Holo");
CardDataNames.Add(35,"Kirlia δ");
CardDataNames.Add(36,"Nidorina δ");
CardDataNames.Add(37,"Nidorino δ");
CardDataNames.Add(38,"Quilava δ");
CardDataNames.Add(39,"Seadra δ");
CardDataNames.Add(40,"Shelgon δ");
CardDataNames.Add(41,"Smeargle δ");
CardDataNames.Add(42,"Swellow δ");
CardDataNames.Add(43,"Togepi δ");
CardDataNames.Add(44,"Vibrava δ");
CardDataNames.Add(45,"Bagon δ");
CardDataNames.Add(46,"Chikorita δ");
CardDataNames.Add(47,"Cyndaquil δ");
CardDataNames.Add(48,"Dratini δ");
CardDataNames.Add(49,"Ekans δ");
CardDataNames.Add(50,"Elekid δ");
CardDataNames.Add(51,"Feebas δ");
CardDataNames.Add(52,"Horsea δ");
CardDataNames.Add(53,"Larvitar");
CardDataNames.Add(54,"Larvitar Holofoil");
CardDataNames.Add(55,"Larvitar Reverse Holo");
CardDataNames.Add(56,"Larvitar δ");
CardDataNames.Add(57,"Ledyba δ");
CardDataNames.Add(58,"Mareep δ");
CardDataNames.Add(59,"Natu δ");
CardDataNames.Add(60,"Nidoran♀ δ");
CardDataNames.Add(61,"Nidoran♂ δ");
CardDataNames.Add(62,"Pupitar");
CardDataNames.Add(63,"Pupitar Holofoil");
CardDataNames.Add(64,"Pupitar Reverse Holo");
CardDataNames.Add(65,"Pupitar δ");
CardDataNames.Add(66,"Ralts");
CardDataNames.Add(67,"Ralts Holofoil");
CardDataNames.Add(68,"Ralts Reverse Holo");
CardDataNames.Add(69,"Ralts δ");
CardDataNames.Add(70,"Seel δ");
CardDataNames.Add(71,"Shellder δ");
CardDataNames.Add(72,"Smoochum δ");
CardDataNames.Add(73,"Swablu δ");
CardDataNames.Add(74,"Taillow δ");
CardDataNames.Add(75,"Totodile δ");
CardDataNames.Add(76,"Trapinch δ");
CardDataNames.Add(77,"Trapinch δ");
CardDataNames.Add(78,"Vulpix δ");
CardDataNames.Add(79,"Wooper δ");
CardDataNames.Add(80,"Buffer Piece");
CardDataNames.Add(81,"Buffer Piece Holofoil");
CardDataNames.Add(82,"Buffer Piece Reverse Holo");
CardDataNames.Add(83,"Copycat");
CardDataNames.Add(84,"Copycat Holofoil");
CardDataNames.Add(85,"Copycat Reverse Holo");
CardDataNames.Add(86,"Holon Legacy");
CardDataNames.Add(87,"Holon Legacy Holofoil");
CardDataNames.Add(88,"Holon Legacy Reverse Holo");
CardDataNames.Add(89,"Holon Mentor");
CardDataNames.Add(90,"Holon Mentor Holofoil");
CardDataNames.Add(91,"Holon Mentor Reverse Holo");
CardDataNames.Add(92,"Island Hermit");
CardDataNames.Add(93,"Island Hermit Holofoil");
CardDataNames.Add(94,"Island Hermit Reverse Holo");
CardDataNames.Add(95,"Mr Stone's Project");
CardDataNames.Add(96,"Mr Stone's Project Holofoil");
CardDataNames.Add(97,"Mr Stone's Project Reverse Holo");
CardDataNames.Add(98,"Old Rod");
CardDataNames.Add(99,"Old Rod Holofoil");
CardDataNames.Add(100,"Old Rod Reverse Holo");
CardDataNames.Add(101,"Professor Elm's Training Method");
CardDataNames.Add(102,"Professor Elm's Training Method Holofoil");
CardDataNames.Add(103,"Professor Elm's Training Method Reverse Holo");
CardDataNames.Add(104,"Professor Oak's Research");
CardDataNames.Add(105,"Professor Oak's Research Holofoil");
CardDataNames.Add(106,"Professor Oak's Research Reverse Holo");
CardDataNames.Add(107,"Strength Charm");
CardDataNames.Add(108,"Strength Charm Holofoil");
CardDataNames.Add(109,"Strength Charm Reverse Holo");
CardDataNames.Add(110,"TV Reporter");
CardDataNames.Add(111,"TV Reporter Holofoil");
CardDataNames.Add(112,"TV Reporter Reverse Holo");
CardDataNames.Add(113,"Switch");
CardDataNames.Add(114,"Switch Holofoil");
CardDataNames.Add(115,"Switch Reverse Holo");
CardDataNames.Add(116,"Holon Energy FF");
CardDataNames.Add(117,"Holon Energy FF Holofoil");
CardDataNames.Add(118,"Holon Energy FF Reverse Holo");
CardDataNames.Add(119,"Holon Energy GL");
CardDataNames.Add(120,"Holon Energy GL Holofoil");
CardDataNames.Add(121,"Holon Energy GL Reverse Holo");
CardDataNames.Add(122,"Holon Energy WP");
CardDataNames.Add(123,"Holon Energy WP Holofoil");
CardDataNames.Add(124,"Holon Energy WP Reverse Holo");
CardDataNames.Add(125,"Boost Energy");
CardDataNames.Add(126,"Boost Energy Holofoil");
CardDataNames.Add(127,"Boost Energy Reverse Holo");
CardDataNames.Add(128,"δ Rainbow Energy");
CardDataNames.Add(129,"δ Rainbow Energy Holofoil");
CardDataNames.Add(130,"δ Rainbow Energy Reverse Holo");
CardDataNames.Add(131,"Scramble Energy");
CardDataNames.Add(132,"Scramble Energy Holofoil");
CardDataNames.Add(133,"Scramble Energy Reverse Holo");
CardDataNames.Add(134,"Altaria ex δ");
CardDataNames.Add(135,"Dragonite ex δ");
CardDataNames.Add(136,"Flygon ex δ");
CardDataNames.Add(137,"Gardevoir ex δ");
CardDataNames.Add(138,"Kingdra ex δ");
CardDataNames.Add(139,"Latias ex δ");
CardDataNames.Add(140,"Latios ex δ");
CardDataNames.Add(141,"Rayquaza ex δ");
CardDataNames.Add(142,"Salamence ex δ");
CardDataNames.Add(143,"Tyranitar ex δ");
CardDataNames.Add(144,"Charizard δ");
CardDataNames.Add(145,"Mew δ");
	}

	public void SetCardValues() {
CardDataValues.Add(1,15.48);
CardDataValues.Add(2,20.54);
CardDataValues.Add(3,8.8);
CardDataValues.Add(4,11.77);
CardDataValues.Add(5,11.82);
CardDataValues.Add(6,17.22);
CardDataValues.Add(7,10.91);
CardDataValues.Add(8,33.48);
CardDataValues.Add(9,8.37);
CardDataValues.Add(10,31.8);
CardDataValues.Add(11,6.27);
CardDataValues.Add(12,25.03);
CardDataValues.Add(13,1.19);
CardDataValues.Add(14,0.99);
CardDataValues.Add(15,2.41);
CardDataValues.Add(16,1.11);
CardDataValues.Add(17,1.99);
CardDataValues.Add(18,1.5);
CardDataValues.Add(19,1.62);
CardDataValues.Add(20,1.05);
CardDataValues.Add(21,4.98);
CardDataValues.Add(22,0.91);
CardDataValues.Add(23,1.99);
CardDataValues.Add(24,0.78);
CardDataValues.Add(25,1.97);
CardDataValues.Add(26,1.77);
CardDataValues.Add(27,1.01);
CardDataValues.Add(28,6.89);
CardDataValues.Add(29,1.48);
CardDataValues.Add(30,1.99);
CardDataValues.Add(31,0.76);
CardDataValues.Add(32,0.52);
CardDataValues.Add(33,2.496);
CardDataValues.Add(34,1.248);
CardDataValues.Add(35,0.66);
CardDataValues.Add(36,1.1);
CardDataValues.Add(37,1.01);
CardDataValues.Add(38,1.24);
CardDataValues.Add(39,0.88);
CardDataValues.Add(40,0.8);
CardDataValues.Add(41,1.15);
CardDataValues.Add(42,0.8);
CardDataValues.Add(43,2);
CardDataValues.Add(44,0.79);
CardDataValues.Add(45,0.47);
CardDataValues.Add(46,0.91);
CardDataValues.Add(47,0.64);
CardDataValues.Add(48,1.03);
CardDataValues.Add(49,0.43);
CardDataValues.Add(50,0.81);
CardDataValues.Add(51,0.53);
CardDataValues.Add(52,0.5);
CardDataValues.Add(53,0.5);
CardDataValues.Add(54,2.4);
CardDataValues.Add(55,1.2);
CardDataValues.Add(56,0.41);
CardDataValues.Add(57,0.42);
CardDataValues.Add(58,0.45);
CardDataValues.Add(59,0.47);
CardDataValues.Add(60,0.43);
CardDataValues.Add(61,0.5);
CardDataValues.Add(62,0.34);
CardDataValues.Add(63,1.632);
CardDataValues.Add(64,0.816);
CardDataValues.Add(65,0.42);
CardDataValues.Add(66,0.5);
CardDataValues.Add(67,2.4);
CardDataValues.Add(68,1.2);
CardDataValues.Add(69,0.46);
CardDataValues.Add(70,0.5);
CardDataValues.Add(71,0.31);
CardDataValues.Add(72,0.5);
CardDataValues.Add(73,0.43);
CardDataValues.Add(74,0.37);
CardDataValues.Add(75,0.6);
CardDataValues.Add(76,0.35);
CardDataValues.Add(77,0.49);
CardDataValues.Add(78,0.46);
CardDataValues.Add(79,1.01);
CardDataValues.Add(80,0.25);
CardDataValues.Add(81,1.2);
CardDataValues.Add(82,0.6);
CardDataValues.Add(83,1.79);
CardDataValues.Add(84,8.592);
CardDataValues.Add(85,4.296);
CardDataValues.Add(86,0.5);
CardDataValues.Add(87,2.4);
CardDataValues.Add(88,1.2);
CardDataValues.Add(89,4.25);
CardDataValues.Add(90,20.4);
CardDataValues.Add(91,10.2);
CardDataValues.Add(92,1.59);
CardDataValues.Add(93,7.632);
CardDataValues.Add(94,3.816);
CardDataValues.Add(95,0.66);
CardDataValues.Add(96,3.168);
CardDataValues.Add(97,1.584);
CardDataValues.Add(98,0.47);
CardDataValues.Add(99,2.256);
CardDataValues.Add(100,1.128);
CardDataValues.Add(101,0.48);
CardDataValues.Add(102,2.304);
CardDataValues.Add(103,1.152);
CardDataValues.Add(104,0.81);
CardDataValues.Add(105,3.888);
CardDataValues.Add(106,1.944);
CardDataValues.Add(107,0.5);
CardDataValues.Add(108,2.4);
CardDataValues.Add(109,1.2);
CardDataValues.Add(110,0.4);
CardDataValues.Add(111,1.92);
CardDataValues.Add(112,0.96);
CardDataValues.Add(113,0.49);
CardDataValues.Add(114,2.352);
CardDataValues.Add(115,1.176);
CardDataValues.Add(116,1.62);
CardDataValues.Add(117,7.776);
CardDataValues.Add(118,3.888);
CardDataValues.Add(119,0.99);
CardDataValues.Add(120,4.752);
CardDataValues.Add(121,2.376);
CardDataValues.Add(122,1.59);
CardDataValues.Add(123,7.632);
CardDataValues.Add(124,3.816);
CardDataValues.Add(125,1);
CardDataValues.Add(126,4.8);
CardDataValues.Add(127,2.4);
CardDataValues.Add(128,0.66);
CardDataValues.Add(129,3.168);
CardDataValues.Add(130,1.584);
CardDataValues.Add(131,2.39);
CardDataValues.Add(132,11.472);
CardDataValues.Add(133,5.736);
CardDataValues.Add(134,53.52);
CardDataValues.Add(135,164.74);
CardDataValues.Add(136,54.01);
CardDataValues.Add(137,50.62);
CardDataValues.Add(138,46.66);
CardDataValues.Add(139,95.89);
CardDataValues.Add(140,84.66);
CardDataValues.Add(141,181.66);
CardDataValues.Add(142,70.33);
CardDataValues.Add(143,132.79);
CardDataValues.Add(144,499.5);
CardDataValues.Add(145,624.5);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}