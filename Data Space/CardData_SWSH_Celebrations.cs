using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_SWSH_Celebrations : MonoBehaviour {
		
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
CardDataNumbers.Add(5,"2");
CardDataNumbers.Add(6,"2H");
CardDataNumbers.Add(7,"2H");
CardDataNumbers.Add(8,"2RH");
CardDataNumbers.Add(9,"2RH");
CardDataNumbers.Add(10,"3");
CardDataNumbers.Add(11,"3H");
CardDataNumbers.Add(12,"3RH");
CardDataNumbers.Add(13,"4");
CardDataNumbers.Add(14,"4");
CardDataNumbers.Add(15,"4H");
CardDataNumbers.Add(16,"4H");
CardDataNumbers.Add(17,"4RH");
CardDataNumbers.Add(18,"4RH");
CardDataNumbers.Add(19,"5");
CardDataNumbers.Add(20,"5H");
CardDataNumbers.Add(21,"5RH");
CardDataNumbers.Add(22,"6");
CardDataNumbers.Add(23,"7");
CardDataNumbers.Add(24,"8");
CardDataNumbers.Add(25,"8");
CardDataNumbers.Add(26,"8H");
CardDataNumbers.Add(27,"8RH");
CardDataNumbers.Add(28,"9");
CardDataNumbers.Add(29,"9");
CardDataNumbers.Add(30,"9H");
CardDataNumbers.Add(31,"9RH");
CardDataNumbers.Add(32,"10");
CardDataNumbers.Add(33,"10H");
CardDataNumbers.Add(34,"10RH");
CardDataNumbers.Add(35,"11");
CardDataNumbers.Add(36,"11H");
CardDataNumbers.Add(37,"11RH");
CardDataNumbers.Add(38,"12");
CardDataNumbers.Add(39,"12H");
CardDataNumbers.Add(40,"12RH");
CardDataNumbers.Add(41,"13");
CardDataNumbers.Add(42,"13H");
CardDataNumbers.Add(43,"13RH");
CardDataNumbers.Add(44,"14");
CardDataNumbers.Add(45,"14H");
CardDataNumbers.Add(46,"14RH");
CardDataNumbers.Add(47,"15");
CardDataNumbers.Add(48,"15");
CardDataNumbers.Add(49,"15");
CardDataNumbers.Add(50,"15");
CardDataNumbers.Add(51,"15");
CardDataNumbers.Add(52,"15H");
CardDataNumbers.Add(53,"15H");
CardDataNumbers.Add(54,"15H");
CardDataNumbers.Add(55,"15H");
CardDataNumbers.Add(56,"15H");
CardDataNumbers.Add(57,"15RH");
CardDataNumbers.Add(58,"15RH");
CardDataNumbers.Add(59,"15RH");
CardDataNumbers.Add(60,"15RH");
CardDataNumbers.Add(61,"15RH");
CardDataNumbers.Add(62,"16");
CardDataNumbers.Add(63,"17");
CardDataNumbers.Add(64,"17");
CardDataNumbers.Add(65,"17H");
CardDataNumbers.Add(66,"17H");
CardDataNumbers.Add(67,"17RH");
CardDataNumbers.Add(68,"17RH");
CardDataNumbers.Add(69,"18");
CardDataNumbers.Add(70,"19");
CardDataNumbers.Add(71,"19H");
CardDataNumbers.Add(72,"19RH");
CardDataNumbers.Add(73,"20");
CardDataNumbers.Add(74,"20");
CardDataNumbers.Add(75,"20H");
CardDataNumbers.Add(76,"20H");
CardDataNumbers.Add(77,"20RH");
CardDataNumbers.Add(78,"20RH");
CardDataNumbers.Add(79,"21");
CardDataNumbers.Add(80,"21H");
CardDataNumbers.Add(81,"21RH");
CardDataNumbers.Add(82,"22");
CardDataNumbers.Add(83,"22H");
CardDataNumbers.Add(84,"22RH");
CardDataNumbers.Add(85,"23");
CardDataNumbers.Add(86,"23H");
CardDataNumbers.Add(87,"23RH");
CardDataNumbers.Add(88,"24");
CardDataNumbers.Add(89,"24");
CardDataNumbers.Add(90,"24H");
CardDataNumbers.Add(91,"24H");
CardDataNumbers.Add(92,"24RH");
CardDataNumbers.Add(93,"24RH");
CardDataNumbers.Add(94,"25");
CardDataNumbers.Add(95,"25H");
CardDataNumbers.Add(96,"25RH");
CardDataNumbers.Add(97,"54");
CardDataNumbers.Add(98,"60");
CardDataNumbers.Add(99,"66");
CardDataNumbers.Add(100,"66H");
CardDataNumbers.Add(101,"66RH");
CardDataNumbers.Add(102,"73");
CardDataNumbers.Add(103,"73H");
CardDataNumbers.Add(104,"73RH");
CardDataNumbers.Add(105,"76");
CardDataNumbers.Add(106,"86");
CardDataNumbers.Add(107,"86H");
CardDataNumbers.Add(108,"86RH");
CardDataNumbers.Add(109,"88");
CardDataNumbers.Add(110,"93");
CardDataNumbers.Add(111,"97");
CardDataNumbers.Add(112,"107");
CardDataNumbers.Add(113,"107H");
CardDataNumbers.Add(114,"107RH");
CardDataNumbers.Add(115,"109");
CardDataNumbers.Add(116,"113");
CardDataNumbers.Add(117,"113H");
CardDataNumbers.Add(118,"113RH");
CardDataNumbers.Add(119,"114");
CardDataNumbers.Add(120,"114H");
CardDataNumbers.Add(121,"114RH");
CardDataNumbers.Add(122,"145");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Ho-Oh");
CardDataNames.Add(2,"Ho-Oh Holofoil");
CardDataNames.Add(3,"Ho-Oh Reverse Holo");
CardDataNames.Add(4,"Reshiram");
CardDataNames.Add(5,"Blastoise");
CardDataNames.Add(6,"Reshiram Holofoil");
CardDataNames.Add(7,"Blastoise Holofoil");
CardDataNames.Add(8,"Reshiram Reverse Holo");
CardDataNames.Add(9,"Blastoise Reverse Holo");
CardDataNames.Add(10,"Kyogre");
CardDataNames.Add(11,"Kyogre Holofoil");
CardDataNames.Add(12,"Kyogre Reverse Holo");
CardDataNames.Add(13,"Palkia");
CardDataNames.Add(14,"Charizard");
CardDataNames.Add(15,"Palkia Holofoil");
CardDataNames.Add(16,"Charizard Holofoil");
CardDataNames.Add(17,"Palkia Reverse Holo");
CardDataNames.Add(18,"Charizard Reverse Holo");
CardDataNames.Add(19,"Pikachu");
CardDataNames.Add(20,"Pikachu Holofoil");
CardDataNames.Add(21,"Pikachu Reverse Holo");
CardDataNames.Add(22,"Flying Pikachu V");
CardDataNames.Add(23,"Flying Pikachu VMAX");
CardDataNames.Add(24,"Surfing Pikachu V");
CardDataNames.Add(25,"Dark Gyarados");
CardDataNames.Add(26,"Dark Gyarados Holofoil");
CardDataNames.Add(27,"Dark Gyarados Reverse Holo");
CardDataNames.Add(28,"Surfing Pikachu VMAX");
CardDataNames.Add(29,"Team Magma's Groudon");
CardDataNames.Add(30,"Team Magma's Groudon Holofoil");
CardDataNames.Add(31,"Team Magma's Groudon Reverse Holo");
CardDataNames.Add(32,"Zekrom");
CardDataNames.Add(33,"Zekrom Holofoil");
CardDataNames.Add(34,"Zekrom Reverse Holo");
CardDataNames.Add(35,"Mew");
CardDataNames.Add(36,"Mew Holofoil");
CardDataNames.Add(37,"Mew Reverse Holo");
CardDataNames.Add(38,"Xerneas");
CardDataNames.Add(39,"Xerneas Holofoil");
CardDataNames.Add(40,"Xerneas Reverse Holo");
CardDataNames.Add(41,"Cosmog");
CardDataNames.Add(42,"Cosmog Holofoil");
CardDataNames.Add(43,"Cosmog Reverse Holo");
CardDataNames.Add(44,"Cosmoem");
CardDataNames.Add(45,"Cosmoem Holofoil");
CardDataNames.Add(46,"Cosmoem Reverse Holo");
CardDataNames.Add(47,"Lunala");
CardDataNames.Add(48,"Venusaur");
CardDataNames.Add(49,"Here Comes Team Rocket");
CardDataNames.Add(50,"Rocket's Zapdos");
CardDataNames.Add(51,"Claydol");
CardDataNames.Add(52,"Lunala Holofoil");
CardDataNames.Add(53,"Venusaur Holofoil");
CardDataNames.Add(54,"Here Comes Team Rocket Holofoil");
CardDataNames.Add(55,"Rocket's Zapdos Holofoil");
CardDataNames.Add(56,"Claydol Holofoil");
CardDataNames.Add(57,"Lunala Reverse Holo");
CardDataNames.Add(58,"Venusaur Reverse Holo");
CardDataNames.Add(59,"Here Comes Team Rocket Reverse Holo");
CardDataNames.Add(60,"Rocket's Zapdos Reverse Holo");
CardDataNames.Add(61,"Claydol Reverse Holo");
CardDataNames.Add(62,"Zacian V");
CardDataNames.Add(63,"Groudon");
CardDataNames.Add(64,"Umbreon");
CardDataNames.Add(65,"Groudon Holofoil");
CardDataNames.Add(66,"Umbreon Holofoil");
CardDataNames.Add(67,"Groudon Reverse Holo");
CardDataNames.Add(68,"Umbreon Reverse Holo");
CardDataNames.Add(69,"Zamazenta V");
CardDataNames.Add(70,"Yveltal");
CardDataNames.Add(71,"Yveltal Holofoil");
CardDataNames.Add(72,"Yveltal Reverse Holo");
CardDataNames.Add(73,"Dialga");
CardDataNames.Add(74,"Cleffa");
CardDataNames.Add(75,"Dialga Holofoil");
CardDataNames.Add(76,"Cleffa Holofoil");
CardDataNames.Add(77,"Dialga Reverse Holo");
CardDataNames.Add(78,"Cleffa Reverse Holo");
CardDataNames.Add(79,"Solgaleo");
CardDataNames.Add(80,"Solgaleo Holofoil");
CardDataNames.Add(81,"Solgaleo Reverse Holo");
CardDataNames.Add(82,"Lugia");
CardDataNames.Add(83,"Lugia Holofoil");
CardDataNames.Add(84,"Lugia Reverse Holo");
CardDataNames.Add(85,"Professor's Research");
CardDataNames.Add(86,"Professor's Research Holofoil");
CardDataNames.Add(87,"Professor's Research Reverse Holo");
CardDataNames.Add(88,"Professor's Research");
CardDataNames.Add(89,"Pikachu");
CardDataNames.Add(90,"Professor's Research Holofoil");
CardDataNames.Add(91,"Pikachu Holofoil");
CardDataNames.Add(92,"Professor's Research Reverse Holo");
CardDataNames.Add(93,"Pikachu Reverse Holo");
CardDataNames.Add(94,"Mew");
CardDataNames.Add(95,"Mew Holofoil");
CardDataNames.Add(96,"Mew Reverse Holo");
CardDataNames.Add(97,"Mewtwo EX");
CardDataNames.Add(98,"Tapu Lele GX");
CardDataNames.Add(99,"Shining Magikarp");
CardDataNames.Add(100,"Shining Magikarp Holofoil");
CardDataNames.Add(101,"Shining Magikarp Reverse Holo");
CardDataNames.Add(102,"Imposter Professor Oak");
CardDataNames.Add(103,"Imposter Professor Oak Holofoil");
CardDataNames.Add(104,"Imposter Professor Oak Reverse Holo");
CardDataNames.Add(105,"M Rayquaza EX");
CardDataNames.Add(106,"Rocket's Admin");
CardDataNames.Add(107,"Rocket's Admin Holofoil");
CardDataNames.Add(108,"Rocket's Admin Reverse Holo");
CardDataNames.Add(109,"Mew ex");
CardDataNames.Add(110,"Gardevoir ex δ");
CardDataNames.Add(111,"Xerneas EX");
CardDataNames.Add(112,"Donphan");
CardDataNames.Add(113,"Donphan Holofoil");
CardDataNames.Add(114,"Donphan Reverse Holo");
CardDataNames.Add(115,"Luxray Lv X");
CardDataNames.Add(116,"Reshiram");
CardDataNames.Add(117,"Reshiram Holofoil");
CardDataNames.Add(118,"Reshiram Reverse Holo");
CardDataNames.Add(119,"Zekrom");
CardDataNames.Add(120,"Zekrom Holofoil");
CardDataNames.Add(121,"Zekrom Reverse Holo");
CardDataNames.Add(122,"Garchomp Lv X");
	}

	public void SetCardValues() {
CardDataValues.Add(1,0.17);
CardDataValues.Add(2,0.816);
CardDataValues.Add(3,0.408);
CardDataValues.Add(4,0.12);
CardDataValues.Add(5,5.63);
CardDataValues.Add(6,0.576);
CardDataValues.Add(7,27.024);
CardDataValues.Add(8,0.288);
CardDataValues.Add(9,13.512);
CardDataValues.Add(10,0.13);
CardDataValues.Add(11,0.624);
CardDataValues.Add(12,0.312);
CardDataValues.Add(13,0.13);
CardDataValues.Add(14,71.44);
CardDataValues.Add(15,0.624);
CardDataValues.Add(16,342.912);
CardDataValues.Add(17,0.312);
CardDataValues.Add(18,171.456);
CardDataValues.Add(19,0.39);
CardDataValues.Add(20,1.872);
CardDataValues.Add(21,0.936);
CardDataValues.Add(22,1.05);
CardDataValues.Add(23,2.43);
CardDataValues.Add(24,0.77);
CardDataValues.Add(25,0.84);
CardDataValues.Add(26,4.032);
CardDataValues.Add(27,2.016);
CardDataValues.Add(28,1.34);
CardDataValues.Add(29,0.51);
CardDataValues.Add(30,2.448);
CardDataValues.Add(31,1.224);
CardDataValues.Add(32,0.16);
CardDataValues.Add(33,0.768);
CardDataValues.Add(34,0.384);
CardDataValues.Add(35,0.41);
CardDataValues.Add(36,1.968);
CardDataValues.Add(37,0.984);
CardDataValues.Add(38,0.21);
CardDataValues.Add(39,1.008);
CardDataValues.Add(40,0.504);
CardDataValues.Add(41,0.11);
CardDataValues.Add(42,0.528);
CardDataValues.Add(43,0.264);
CardDataValues.Add(44,0.1);
CardDataValues.Add(45,0.48);
CardDataValues.Add(46,0.24);
CardDataValues.Add(47,0.16);
CardDataValues.Add(48,1.66);
CardDataValues.Add(49,3.35);
CardDataValues.Add(50,0.27);
CardDataValues.Add(51,0.69);
CardDataValues.Add(52,0.768);
CardDataValues.Add(53,7.968);
CardDataValues.Add(54,16.08);
CardDataValues.Add(55,1.296);
CardDataValues.Add(56,3.312);
CardDataValues.Add(57,0.384);
CardDataValues.Add(58,3.984);
CardDataValues.Add(59,8.04);
CardDataValues.Add(60,0.648);
CardDataValues.Add(61,1.656);
CardDataValues.Add(62,0.31);
CardDataValues.Add(63,0.58);
CardDataValues.Add(64,0.2);
CardDataValues.Add(65,2.784);
CardDataValues.Add(66,0.96);
CardDataValues.Add(67,1.392);
CardDataValues.Add(68,0.48);
CardDataValues.Add(69,21.27);
CardDataValues.Add(70,0.55);
CardDataValues.Add(71,2.64);
CardDataValues.Add(72,1.32);
CardDataValues.Add(73,0.16);
CardDataValues.Add(74,0.13);
CardDataValues.Add(75,0.768);
CardDataValues.Add(76,0.624);
CardDataValues.Add(77,0.384);
CardDataValues.Add(78,0.312);
CardDataValues.Add(79,0.56);
CardDataValues.Add(80,2.688);
CardDataValues.Add(81,1.344);
CardDataValues.Add(82,0.19);
CardDataValues.Add(83,0.912);
CardDataValues.Add(84,0.456);
CardDataValues.Add(85,0.18);
CardDataValues.Add(86,0.864);
CardDataValues.Add(87,0.432);
CardDataValues.Add(88,0.18);
CardDataValues.Add(89,1.32);
CardDataValues.Add(90,0.864);
CardDataValues.Add(91,6.336);
CardDataValues.Add(92,0.432);
CardDataValues.Add(93,3.168);
CardDataValues.Add(94,4.02);
CardDataValues.Add(95,19.296);
CardDataValues.Add(96,9.648);
CardDataValues.Add(97,38.74);
CardDataValues.Add(98,10.76);
CardDataValues.Add(99,4.8);
CardDataValues.Add(100,23.04);
CardDataValues.Add(101,11.52);
CardDataValues.Add(102,17);
CardDataValues.Add(103,81.6);
CardDataValues.Add(104,40.8);
CardDataValues.Add(105,0.22);
CardDataValues.Add(106,10.14);
CardDataValues.Add(107,48.672);
CardDataValues.Add(108,24.336);
CardDataValues.Add(109,0.34);
CardDataValues.Add(110,3.76);
CardDataValues.Add(111,5.43);
CardDataValues.Add(112,4.6);
CardDataValues.Add(113,22.08);
CardDataValues.Add(114,11.04);
CardDataValues.Add(115,1.47);
CardDataValues.Add(116,1.61);
CardDataValues.Add(117,7.728);
CardDataValues.Add(118,3.864);
CardDataValues.Add(119,3.46);
CardDataValues.Add(120,16.608);
CardDataValues.Add(121,8.304);
CardDataValues.Add(122,3.09);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}