using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_DP_DiamondPearlPromos : MonoBehaviour {
		
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
CardDataNumbers.Add(5,"2H");
CardDataNumbers.Add(6,"2RH");
CardDataNumbers.Add(7,"3");
CardDataNumbers.Add(8,"3H");
CardDataNumbers.Add(9,"3RH");
CardDataNumbers.Add(10,"4");
CardDataNumbers.Add(11,"4H");
CardDataNumbers.Add(12,"4RH");
CardDataNumbers.Add(13,"6");
CardDataNumbers.Add(14,"6H");
CardDataNumbers.Add(15,"6RH");
CardDataNumbers.Add(16,"7");
CardDataNumbers.Add(17,"7H");
CardDataNumbers.Add(18,"7RH");
CardDataNumbers.Add(19,"8");
CardDataNumbers.Add(20,"8H");
CardDataNumbers.Add(21,"8RH");
CardDataNumbers.Add(22,"9");
CardDataNumbers.Add(23,"10");
CardDataNumbers.Add(24,"11");
CardDataNumbers.Add(25,"12");
CardDataNumbers.Add(26,"13");
CardDataNumbers.Add(27,"13H");
CardDataNumbers.Add(28,"13RH");
CardDataNumbers.Add(29,"14");
CardDataNumbers.Add(30,"14H");
CardDataNumbers.Add(31,"14RH");
CardDataNumbers.Add(32,"15");
CardDataNumbers.Add(33,"15H");
CardDataNumbers.Add(34,"15RH");
CardDataNumbers.Add(35,"16");
CardDataNumbers.Add(36,"16H");
CardDataNumbers.Add(37,"16RH");
CardDataNumbers.Add(38,"17");
CardDataNumbers.Add(39,"18");
CardDataNumbers.Add(40,"19");
CardDataNumbers.Add(41,"20");
CardDataNumbers.Add(42,"20H");
CardDataNumbers.Add(43,"20RH");
CardDataNumbers.Add(44,"21");
CardDataNumbers.Add(45,"21H");
CardDataNumbers.Add(46,"21RH");
CardDataNumbers.Add(47,"22");
CardDataNumbers.Add(48,"22H");
CardDataNumbers.Add(49,"22RH");
CardDataNumbers.Add(50,"23");
CardDataNumbers.Add(51,"23H");
CardDataNumbers.Add(52,"23RH");
CardDataNumbers.Add(53,"24");
CardDataNumbers.Add(54,"24H");
CardDataNumbers.Add(55,"24RH");
CardDataNumbers.Add(56,"26");
CardDataNumbers.Add(57,"26H");
CardDataNumbers.Add(58,"26RH");
CardDataNumbers.Add(59,"27");
CardDataNumbers.Add(60,"27H");
CardDataNumbers.Add(61,"27RH");
CardDataNumbers.Add(62,"28");
CardDataNumbers.Add(63,"29");
CardDataNumbers.Add(64,"30");
CardDataNumbers.Add(65,"31");
CardDataNumbers.Add(66,"32");
CardDataNumbers.Add(67,"32H");
CardDataNumbers.Add(68,"32RH");
CardDataNumbers.Add(69,"33");
CardDataNumbers.Add(70,"33H");
CardDataNumbers.Add(71,"33RH");
CardDataNumbers.Add(72,"34");
CardDataNumbers.Add(73,"34H");
CardDataNumbers.Add(74,"34RH");
CardDataNumbers.Add(75,"35");
CardDataNumbers.Add(76,"35H");
CardDataNumbers.Add(77,"35RH");
CardDataNumbers.Add(78,"36");
CardDataNumbers.Add(79,"36H");
CardDataNumbers.Add(80,"36RH");
CardDataNumbers.Add(81,"37");
CardDataNumbers.Add(82,"38");
CardDataNumbers.Add(83,"39");
CardDataNumbers.Add(84,"40");
CardDataNumbers.Add(85,"40H");
CardDataNumbers.Add(86,"40RH");
CardDataNumbers.Add(87,"41");
CardDataNumbers.Add(88,"42");
CardDataNumbers.Add(89,"43");
CardDataNumbers.Add(90,"44");
CardDataNumbers.Add(91,"44H");
CardDataNumbers.Add(92,"44RH");
CardDataNumbers.Add(93,"45");
CardDataNumbers.Add(94,"46");
CardDataNumbers.Add(95,"47");
CardDataNumbers.Add(96,"49");
CardDataNumbers.Add(97,"49H");
CardDataNumbers.Add(98,"49RH");
CardDataNumbers.Add(99,"50");
CardDataNumbers.Add(100,"50H");
CardDataNumbers.Add(101,"50RH");
CardDataNumbers.Add(102,"51");
CardDataNumbers.Add(103,"51H");
CardDataNumbers.Add(104,"51RH");
CardDataNumbers.Add(105,"52");
CardDataNumbers.Add(106,"52H");
CardDataNumbers.Add(107,"52RH");
CardDataNumbers.Add(108,"53");
CardDataNumbers.Add(109,"56");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Turtwig");
CardDataNames.Add(2,"Turtwig Holofoil");
CardDataNames.Add(3,"Turtwig Reverse Holo");
CardDataNames.Add(4,"Chimchar");
CardDataNames.Add(5,"Chimchar Holofoil");
CardDataNames.Add(6,"Chimchar Reverse Holo");
CardDataNames.Add(7,"Piplup");
CardDataNames.Add(8,"Piplup Holofoil");
CardDataNames.Add(9,"Piplup Reverse Holo");
CardDataNames.Add(10,"Pachirisu");
CardDataNames.Add(11,"Pachirisu Holofoil");
CardDataNames.Add(12,"Pachirisu Reverse Holo");
CardDataNames.Add(13,"Buneary");
CardDataNames.Add(14,"Buneary Holofoil");
CardDataNames.Add(15,"Buneary Reverse Holo");
CardDataNames.Add(16,"Cranidos");
CardDataNames.Add(17,"Cranidos Holofoil");
CardDataNames.Add(18,"Cranidos Reverse Holo");
CardDataNames.Add(19,"Shieldon");
CardDataNames.Add(20,"Shieldon Holofoil");
CardDataNames.Add(21,"Shieldon Reverse Holo");
CardDataNames.Add(22,"Torterra LvX");
CardDataNames.Add(23,"Infernape LvX");
CardDataNames.Add(24,"Empoleon LvX");
CardDataNames.Add(25,"Lucario LvX");
CardDataNames.Add(26,"Buizel");
CardDataNames.Add(27,"Buizel Holofoil");
CardDataNames.Add(28,"Buizel Reverse Holo");
CardDataNames.Add(29,"Chatot");
CardDataNames.Add(30,"Chatot Holofoil");
CardDataNames.Add(31,"Chatot Reverse Holo");
CardDataNames.Add(32,"Shinx");
CardDataNames.Add(33,"Shinx Holofoil");
CardDataNames.Add(34,"Shinx Reverse Holo");
CardDataNames.Add(35,"Pikachu");
CardDataNames.Add(36,"Pikachu Holofoil");
CardDataNames.Add(37,"Pikachu Reverse Holo");
CardDataNames.Add(38,"Dialga LvX");
CardDataNames.Add(39,"Palkia LvX");
CardDataNames.Add(40,"Darkrai LvX");
CardDataNames.Add(41,"Magmortar");
CardDataNames.Add(42,"Magmortar Holofoil");
CardDataNames.Add(43,"Magmortar Reverse Holo");
CardDataNames.Add(44,"Raichu");
CardDataNames.Add(45,"Raichu Holofoil");
CardDataNames.Add(46,"Raichu Reverse Holo");
CardDataNames.Add(47,"Mime Jr");
CardDataNames.Add(48,"Mime Jr Holofoil");
CardDataNames.Add(49,"Mime Jr Reverse Holo");
CardDataNames.Add(50,"Glameow");
CardDataNames.Add(51,"Glameow Holofoil");
CardDataNames.Add(52,"Glameow Reverse Holo");
CardDataNames.Add(53,"Darkrai");
CardDataNames.Add(54,"Darkrai Holofoil");
CardDataNames.Add(55,"Darkrai Reverse Holo");
CardDataNames.Add(56,"Dialga");
CardDataNames.Add(57,"Dialga Holofoil");
CardDataNames.Add(58,"Dialga Reverse Holo");
CardDataNames.Add(59,"Palkia");
CardDataNames.Add(60,"Palkia Holofoil");
CardDataNames.Add(61,"Palkia Reverse Holo");
CardDataNames.Add(62,"Mewtwo LvX");
CardDataNames.Add(63,"Rhyperior LvX");
CardDataNames.Add(64,"Regigigas LvX");
CardDataNames.Add(65,"Heatran LvX");
CardDataNames.Add(66,"Magnezone");
CardDataNames.Add(67,"Magnezone Holofoil");
CardDataNames.Add(68,"Magnezone Reverse Holo");
CardDataNames.Add(69,"Dusknoir");
CardDataNames.Add(70,"Dusknoir Holofoil");
CardDataNames.Add(71,"Dusknoir Reverse Holo");
CardDataNames.Add(72,"Drifblim");
CardDataNames.Add(73,"Drifblim Holofoil");
CardDataNames.Add(74,"Drifblim Reverse Holo");
CardDataNames.Add(75,"Porygon-Z");
CardDataNames.Add(76,"Porygon-Z Holofoil");
CardDataNames.Add(77,"Porygon-Z Reverse Holo");
CardDataNames.Add(78,"Gliscor");
CardDataNames.Add(79,"Gliscor Holofoil");
CardDataNames.Add(80,"Gliscor Reverse Holo");
CardDataNames.Add(81,"Dialga LvX");
CardDataNames.Add(82,"Giratina LvX");
CardDataNames.Add(83,"Shaymin LvX");
CardDataNames.Add(84,"Regigigas");
CardDataNames.Add(85,"Regigigas Holofoil");
CardDataNames.Add(86,"Regigigas Reverse Holo");
CardDataNames.Add(87,"Toxicroak G");
CardDataNames.Add(88,"Carnivine G");
CardDataNames.Add(89,"Probopass G");
CardDataNames.Add(90,"Magnezone");
CardDataNames.Add(91,"Magnezone Holofoil");
CardDataNames.Add(92,"Magnezone Reverse Holo");
CardDataNames.Add(93,"Charizard G LvX");
CardDataNames.Add(94,"Garchomp C LvX");
CardDataNames.Add(95,"Rayquaza C LvX");
CardDataNames.Add(96,"Dialga");
CardDataNames.Add(97,"Dialga Holofoil");
CardDataNames.Add(98,"Dialga Reverse Holo");
CardDataNames.Add(99,"Arceus");
CardDataNames.Add(100,"Arceus Holofoil");
CardDataNames.Add(101,"Arceus Reverse Holo");
CardDataNames.Add(102,"Cresselia");
CardDataNames.Add(103,"Cresselia Holofoil");
CardDataNames.Add(104,"Cresselia Reverse Holo");
CardDataNames.Add(105,"Darkrai");
CardDataNames.Add(106,"Darkrai Holofoil");
CardDataNames.Add(107,"Darkrai Reverse Holo");
CardDataNames.Add(108,"Arceus LvX");
CardDataNames.Add(109,"Arceus LvX");
	}

	public void SetCardValues() {
CardDataValues.Add(1,7.18);
CardDataValues.Add(2,34.464);
CardDataValues.Add(3,17.232);
CardDataValues.Add(4,3.75);
CardDataValues.Add(5,18);
CardDataValues.Add(6,9);
CardDataValues.Add(7,7.16);
CardDataValues.Add(8,34.368);
CardDataValues.Add(9,17.184);
CardDataValues.Add(10,2.83);
CardDataValues.Add(11,13.584);
CardDataValues.Add(12,6.792);
CardDataValues.Add(13,3.8);
CardDataValues.Add(14,18.24);
CardDataValues.Add(15,9.12);
CardDataValues.Add(16,9.12);
CardDataValues.Add(17,43.776);
CardDataValues.Add(18,21.888);
CardDataValues.Add(19,2.21);
CardDataValues.Add(20,10.608);
CardDataValues.Add(21,5.304);
CardDataValues.Add(22,13.58);
CardDataValues.Add(23,22.97);
CardDataValues.Add(24,19.03);
CardDataValues.Add(25,36.53);
CardDataValues.Add(26,6.53);
CardDataValues.Add(27,31.344);
CardDataValues.Add(28,15.672);
CardDataValues.Add(29,6.85);
CardDataValues.Add(30,32.88);
CardDataValues.Add(31,16.44);
CardDataValues.Add(32,8.76);
CardDataValues.Add(33,42.048);
CardDataValues.Add(34,21.024);
CardDataValues.Add(35,42.64);
CardDataValues.Add(36,204.672);
CardDataValues.Add(37,102.336);
CardDataValues.Add(38,14.44);
CardDataValues.Add(39,22.06);
CardDataValues.Add(40,23.73);
CardDataValues.Add(41,2.99);
CardDataValues.Add(42,14.352);
CardDataValues.Add(43,7.176);
CardDataValues.Add(44,6.98);
CardDataValues.Add(45,33.504);
CardDataValues.Add(46,16.752);
CardDataValues.Add(47,7.99);
CardDataValues.Add(48,38.352);
CardDataValues.Add(49,19.176);
CardDataValues.Add(50,2.28);
CardDataValues.Add(51,10.944);
CardDataValues.Add(52,5.472);
CardDataValues.Add(53,5.31);
CardDataValues.Add(54,25.488);
CardDataValues.Add(55,12.744);
CardDataValues.Add(56,3.97);
CardDataValues.Add(57,19.056);
CardDataValues.Add(58,9.528);
CardDataValues.Add(59,8.5);
CardDataValues.Add(60,40.8);
CardDataValues.Add(61,20.4);
CardDataValues.Add(62,26.62);
CardDataValues.Add(63,19.95);
CardDataValues.Add(64,12.66);
CardDataValues.Add(65,10.58);
CardDataValues.Add(66,1.8);
CardDataValues.Add(67,8.64);
CardDataValues.Add(68,4.32);
CardDataValues.Add(69,4.13);
CardDataValues.Add(70,19.824);
CardDataValues.Add(71,9.912);
CardDataValues.Add(72,7.08);
CardDataValues.Add(73,33.984);
CardDataValues.Add(74,16.992);
CardDataValues.Add(75,6.31);
CardDataValues.Add(76,30.288);
CardDataValues.Add(77,15.144);
CardDataValues.Add(78,2.54);
CardDataValues.Add(79,12.192);
CardDataValues.Add(80,6.096);
CardDataValues.Add(81,14.19);
CardDataValues.Add(82,23.7);
CardDataValues.Add(83,10.41);
CardDataValues.Add(84,17.98);
CardDataValues.Add(85,86.304);
CardDataValues.Add(86,43.152);
CardDataValues.Add(87,26.66);
CardDataValues.Add(88,3.44);
CardDataValues.Add(89,3.07);
CardDataValues.Add(90,2.35);
CardDataValues.Add(91,11.28);
CardDataValues.Add(92,5.64);
CardDataValues.Add(93,84.06);
CardDataValues.Add(94,15.17);
CardDataValues.Add(95,33.05);
CardDataValues.Add(96,7.01);
CardDataValues.Add(97,33.648);
CardDataValues.Add(98,16.824);
CardDataValues.Add(99,8.67);
CardDataValues.Add(100,41.616);
CardDataValues.Add(101,20.808);
CardDataValues.Add(102,4.26);
CardDataValues.Add(103,20.448);
CardDataValues.Add(104,10.224);
CardDataValues.Add(105,6.94);
CardDataValues.Add(106,33.312);
CardDataValues.Add(107,16.656);
CardDataValues.Add(108,26.34);
CardDataValues.Add(109,28.87);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}