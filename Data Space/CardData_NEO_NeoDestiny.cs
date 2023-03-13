using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_NEO_NeoDestiny : MonoBehaviour {
		
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
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Dark Ampharos");
CardDataNames.Add(2,"Dark Crobat");
CardDataNames.Add(3,"Dark Donphan");
CardDataNames.Add(4,"Dark Espeon");
CardDataNames.Add(5,"Dark Feraligatr");
CardDataNames.Add(6,"Dark Gengar");
CardDataNames.Add(7,"Dark Houndoom");
CardDataNames.Add(8,"Dark Porygon2");
CardDataNames.Add(9,"Dark Scizor");
CardDataNames.Add(10,"Dark Typhlosion");
CardDataNames.Add(11,"Dark Tyranitar");
CardDataNames.Add(12,"Light Arcanine");
CardDataNames.Add(13,"Light Azumarill");
CardDataNames.Add(14,"Light Dragonite");
CardDataNames.Add(15,"Light Togetic");
CardDataNames.Add(16,"Miracle Energy");
CardDataNames.Add(17,"Dark Ariados");
CardDataNames.Add(18,"Dark Magcargo");
CardDataNames.Add(19,"Dark Omastar");
CardDataNames.Add(20,"Dark Slowking");
CardDataNames.Add(21,"Dark Ursaring");
CardDataNames.Add(22,"Light Dragonair");
CardDataNames.Add(23,"Light Lanturn");
CardDataNames.Add(24,"Light Ledian");
CardDataNames.Add(25,"Light Machamp");
CardDataNames.Add(26,"Light Piloswine");
CardDataNames.Add(27,"Unown G");
CardDataNames.Add(28,"Unown H");
CardDataNames.Add(29,"Unown W");
CardDataNames.Add(30,"Unown X");
CardDataNames.Add(31,"Chansey");
CardDataNames.Add(32,"Dark Croconaw");
CardDataNames.Add(33,"Dark Exeggutor");
CardDataNames.Add(34,"Dark Flaaffy");
CardDataNames.Add(35,"Dark Forretress");
CardDataNames.Add(36,"Dark Haunter");
CardDataNames.Add(37,"Dark Omanyte");
CardDataNames.Add(38,"Dark Pupitar");
CardDataNames.Add(39,"Dark Quilava");
CardDataNames.Add(40,"Dark Wigglytuff");
CardDataNames.Add(41,"Heracross");
CardDataNames.Add(42,"Hitmonlee");
CardDataNames.Add(43,"Houndour");
CardDataNames.Add(44,"Jigglypuff");
CardDataNames.Add(45,"Light Dewgong");
CardDataNames.Add(46,"Light Flareon");
CardDataNames.Add(47,"Light Golduck");
CardDataNames.Add(48,"Light Jolteon");
CardDataNames.Add(49,"Light Machoke");
CardDataNames.Add(50,"Light Ninetales");
CardDataNames.Add(51,"Light Slowbro");
CardDataNames.Add(52,"Light Vaporeon");
CardDataNames.Add(53,"Light Venomoth");
CardDataNames.Add(54,"Light Wigglytuff");
CardDataNames.Add(55,"Scyther");
CardDataNames.Add(56,"Togepi");
CardDataNames.Add(57,"Unown C");
CardDataNames.Add(58,"Unown P");
CardDataNames.Add(59,"Unown Q");
CardDataNames.Add(60,"Unown Z");
CardDataNames.Add(61,"Cyndaquil");
CardDataNames.Add(62,"Dark Octillery");
CardDataNames.Add(63,"Dratini");
CardDataNames.Add(64,"Exeggcute");
CardDataNames.Add(65,"Gastly");
CardDataNames.Add(66,"Girafarig");
CardDataNames.Add(67,"Gligar");
CardDataNames.Add(68,"Growlithe");
CardDataNames.Add(69,"Hitmonchan");
CardDataNames.Add(70,"Larvitar");
CardDataNames.Add(71,"Ledyba");
CardDataNames.Add(72,"Light Sunflora");
CardDataNames.Add(73,"Machop");
CardDataNames.Add(74,"Mantine");
CardDataNames.Add(75,"Mareep");
CardDataNames.Add(76,"Phanpy");
CardDataNames.Add(77,"Pineco");
CardDataNames.Add(78,"Porygon");
CardDataNames.Add(79,"Psyduck");
CardDataNames.Add(80,"Remoraid");
CardDataNames.Add(81,"Seel");
CardDataNames.Add(82,"Slugma");
CardDataNames.Add(83,"Sunkern");
CardDataNames.Add(84,"Swinub");
CardDataNames.Add(85,"Totodile");
CardDataNames.Add(86,"Unown L");
CardDataNames.Add(87,"Unown S");
CardDataNames.Add(88,"Unown T");
CardDataNames.Add(89,"Unown V");
CardDataNames.Add(90,"Venonat");
CardDataNames.Add(91,"Vulpix");
CardDataNames.Add(92,"Broken Ground Gym");
CardDataNames.Add(93,"Exp ALL");
CardDataNames.Add(94,"Imposter Professor Oak's Invention");
CardDataNames.Add(95,"Radio Tower");
CardDataNames.Add(96,"Thought Wave Machine");
CardDataNames.Add(97,"Counterattack Claws");
CardDataNames.Add(98,"Energy Amplifier");
CardDataNames.Add(99,"Energy Stadium");
CardDataNames.Add(100,"Lucky Stadium");
CardDataNames.Add(101,"Magnifier");
CardDataNames.Add(102,"Pokémon Personality Test");
CardDataNames.Add(103,"Team Rocket's Evil Deeds");
CardDataNames.Add(104,"Heal Powder");
CardDataNames.Add(105,"Mail from Bill");
CardDataNames.Add(106,"Shining Celebi");
CardDataNames.Add(107,"Shining Charizard");
CardDataNames.Add(108,"Shining Kabutops");
CardDataNames.Add(109,"Shining Mewtwo");
CardDataNames.Add(110,"Shining Noctowl");
CardDataNames.Add(111,"Shining Raichu");
CardDataNames.Add(112,"Shining Steelix");
CardDataNames.Add(113,"Shining Tyranitar");
	}

	public void SetCardValues() {
CardDataValues.Add(1,63.74);
CardDataValues.Add(2,102.5);
CardDataValues.Add(3,58.16);
CardDataValues.Add(4,300.94);
CardDataValues.Add(5,61.46);
CardDataValues.Add(6,399.99);
CardDataValues.Add(7,90);
CardDataValues.Add(8,99.99);
CardDataValues.Add(9,225);
CardDataValues.Add(10,42.01);
CardDataValues.Add(11,247.85);
CardDataValues.Add(12,212.47);
CardDataValues.Add(13,49.99);
CardDataValues.Add(14,349.99);
CardDataValues.Add(15,143.99);
CardDataValues.Add(16,74.99);
CardDataValues.Add(17,17.99);
CardDataValues.Add(18,12.79);
CardDataValues.Add(19,17.78);
CardDataValues.Add(20,17.74);
CardDataValues.Add(21,12.06);
CardDataValues.Add(22,58.83);
CardDataValues.Add(23,11);
CardDataValues.Add(24,13.54);
CardDataValues.Add(25,18.97);
CardDataValues.Add(26,10.12);
CardDataValues.Add(27,13.08);
CardDataValues.Add(28,19.85);
CardDataValues.Add(29,8.18);
CardDataValues.Add(30,25.57);
CardDataValues.Add(31,13.51);
CardDataValues.Add(32,9.45);
CardDataValues.Add(33,7.82);
CardDataValues.Add(34,6.49);
CardDataValues.Add(35,4.63);
CardDataValues.Add(36,17.12);
CardDataValues.Add(37,5.52);
CardDataValues.Add(38,7.69);
CardDataValues.Add(39,14.2);
CardDataValues.Add(40,10.73);
CardDataValues.Add(41,9.22);
CardDataValues.Add(42,7.45);
CardDataValues.Add(43,5.15);
CardDataValues.Add(44,10.85);
CardDataValues.Add(45,6.08);
CardDataValues.Add(46,40.95);
CardDataValues.Add(47,5.7);
CardDataValues.Add(48,60);
CardDataValues.Add(49,8.27);
CardDataValues.Add(50,22.72);
CardDataValues.Add(51,16.19);
CardDataValues.Add(52,29.75);
CardDataValues.Add(53,7.18);
CardDataValues.Add(54,8.63);
CardDataValues.Add(55,14.27);
CardDataValues.Add(56,14.69);
CardDataValues.Add(57,8.64);
CardDataValues.Add(58,4.19);
CardDataValues.Add(59,5.17);
CardDataValues.Add(60,5.1);
CardDataValues.Add(61,6.04);
CardDataValues.Add(62,1.9);
CardDataValues.Add(63,3.87);
CardDataValues.Add(64,1.38);
CardDataValues.Add(65,2.48);
CardDataValues.Add(66,2.51);
CardDataValues.Add(67,1.56);
CardDataValues.Add(68,3.58);
CardDataValues.Add(69,4.16);
CardDataValues.Add(70,4.17);
CardDataValues.Add(71,1.79);
CardDataValues.Add(72,2.34);
CardDataValues.Add(73,2);
CardDataValues.Add(74,1.49);
CardDataValues.Add(75,1.62);
CardDataValues.Add(76,2.09);
CardDataValues.Add(77,1.33);
CardDataValues.Add(78,1.99);
CardDataValues.Add(79,3.93);
CardDataValues.Add(80,1.73);
CardDataValues.Add(81,1.75);
CardDataValues.Add(82,2.24);
CardDataValues.Add(83,0.97);
CardDataValues.Add(84,1.97);
CardDataValues.Add(85,4.96);
CardDataValues.Add(86,1.48);
CardDataValues.Add(87,1.48);
CardDataValues.Add(88,1.41);
CardDataValues.Add(89,1.51);
CardDataValues.Add(90,1.75);
CardDataValues.Add(91,4.02);
CardDataValues.Add(92,10.95);
CardDataValues.Add(93,8.89);
CardDataValues.Add(94,7.47);
CardDataValues.Add(95,9.27);
CardDataValues.Add(96,7.82);
CardDataValues.Add(97,2.45);
CardDataValues.Add(98,1.74);
CardDataValues.Add(99,8.39);
CardDataValues.Add(100,5.91);
CardDataValues.Add(101,2.81);
CardDataValues.Add(102,7.87);
CardDataValues.Add(103,4.03);
CardDataValues.Add(104,1.37);
CardDataValues.Add(105,1.08);
CardDataValues.Add(106,132);
CardDataValues.Add(107,1469.99);
CardDataValues.Add(108,569.17);
CardDataValues.Add(109,523.33);
CardDataValues.Add(110,186.5);
CardDataValues.Add(111,312.81);
CardDataValues.Add(112,600);
CardDataValues.Add(113,422.26);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}