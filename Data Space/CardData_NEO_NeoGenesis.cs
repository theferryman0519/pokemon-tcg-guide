using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_NEO_NeoGenesis : MonoBehaviour {
		
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
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Ampharos");
CardDataNames.Add(2,"Azumarill");
CardDataNames.Add(3,"Bellossom");
CardDataNames.Add(4,"Feraligatr");
CardDataNames.Add(5,"Feraligatr");
CardDataNames.Add(6,"Heracross");
CardDataNames.Add(7,"Jumpluff");
CardDataNames.Add(8,"Kingdra");
CardDataNames.Add(9,"Lugia");
CardDataNames.Add(10,"Meganium");
CardDataNames.Add(11,"Meganium");
CardDataNames.Add(12,"Pichu");
CardDataNames.Add(13,"Skarmory");
CardDataNames.Add(14,"Slowking");
CardDataNames.Add(15,"Steelix");
CardDataNames.Add(16,"Togetic");
CardDataNames.Add(17,"Typhlosion");
CardDataNames.Add(18,"Typhlosion");
CardDataNames.Add(19,"Metal Energy");
CardDataNames.Add(20,"Cleffa");
CardDataNames.Add(21,"Donphan");
CardDataNames.Add(22,"Elekid");
CardDataNames.Add(23,"Magby");
CardDataNames.Add(24,"Murkrow");
CardDataNames.Add(25,"Sneasel");
CardDataNames.Add(26,"Aipom");
CardDataNames.Add(27,"Ariados");
CardDataNames.Add(28,"Bayleef");
CardDataNames.Add(29,"Bayleef");
CardDataNames.Add(30,"Clefairy");
CardDataNames.Add(31,"Croconaw");
CardDataNames.Add(32,"Croconaw");
CardDataNames.Add(33,"Electabuzz");
CardDataNames.Add(34,"Flaaffy");
CardDataNames.Add(35,"Furret");
CardDataNames.Add(36,"Gloom");
CardDataNames.Add(37,"Granbull");
CardDataNames.Add(38,"Lanturn");
CardDataNames.Add(39,"Ledian");
CardDataNames.Add(40,"Magmar");
CardDataNames.Add(41,"Miltank");
CardDataNames.Add(42,"Noctowl");
CardDataNames.Add(43,"Phanpy");
CardDataNames.Add(44,"Piloswine");
CardDataNames.Add(45,"Quagsire");
CardDataNames.Add(46,"Quilava");
CardDataNames.Add(47,"Quilava");
CardDataNames.Add(48,"Seadra");
CardDataNames.Add(49,"Skiploom");
CardDataNames.Add(50,"Sunflora");
CardDataNames.Add(51,"Togepi");
CardDataNames.Add(52,"Xatu");
CardDataNames.Add(53,"Chikorita");
CardDataNames.Add(54,"Chikorita");
CardDataNames.Add(55,"Chinchou");
CardDataNames.Add(56,"Cyndaquil");
CardDataNames.Add(57,"Cyndaquil");
CardDataNames.Add(58,"Girafarig");
CardDataNames.Add(59,"Gligar");
CardDataNames.Add(60,"Hoothoot");
CardDataNames.Add(61,"Hoppip");
CardDataNames.Add(62,"Horsea");
CardDataNames.Add(63,"Ledyba");
CardDataNames.Add(64,"Mantine");
CardDataNames.Add(65,"Mareep");
CardDataNames.Add(66,"Marill");
CardDataNames.Add(67,"Natu");
CardDataNames.Add(68,"Oddish");
CardDataNames.Add(69,"Onix");
CardDataNames.Add(70,"Pikachu");
CardDataNames.Add(71,"Sentret");
CardDataNames.Add(72,"Shuckle");
CardDataNames.Add(73,"Slowpoke");
CardDataNames.Add(74,"Snubbull");
CardDataNames.Add(75,"Spinarak");
CardDataNames.Add(76,"Stantler");
CardDataNames.Add(77,"Sudowoodo");
CardDataNames.Add(78,"Sunkern");
CardDataNames.Add(79,"Swinub");
CardDataNames.Add(80,"Totodile");
CardDataNames.Add(81,"Totodile");
CardDataNames.Add(82,"Wooper");
CardDataNames.Add(83,"Arcade Game");
CardDataNames.Add(84,"Ecogym");
CardDataNames.Add(85,"Energy Charge");
CardDataNames.Add(86,"Focus Band");
CardDataNames.Add(87,"Mary");
CardDataNames.Add(88,"PokéGear");
CardDataNames.Add(89,"Super Energy Retrieval");
CardDataNames.Add(90,"Time Capsule");
CardDataNames.Add(91,"Bill's Teleporter");
CardDataNames.Add(92,"Card-Flip Game");
CardDataNames.Add(93,"Gold Berry");
CardDataNames.Add(94,"Miracle Berry");
CardDataNames.Add(95,"New Pokédex");
CardDataNames.Add(96,"Professor Elm");
CardDataNames.Add(97,"Sprout Tower");
CardDataNames.Add(98,"Super Scoop Up");
CardDataNames.Add(99,"Berry");
CardDataNames.Add(100,"Double Gust");
CardDataNames.Add(101,"Moo-Moo Milk");
CardDataNames.Add(102,"Pokémon March");
CardDataNames.Add(103,"Super Rod");
CardDataNames.Add(104,"Darkness Energy");
CardDataNames.Add(105,"Recycle Energy");
CardDataNames.Add(106,"Fighting");
CardDataNames.Add(107,"Fire");
CardDataNames.Add(108,"Grass");
CardDataNames.Add(109,"Lightning");
CardDataNames.Add(110,"Psychic");
CardDataNames.Add(111,"Water");
	}

	public void SetCardValues() {
CardDataValues.Add(1,53.16);
CardDataValues.Add(2,49.63);
CardDataValues.Add(3,31.09);
CardDataValues.Add(4,134.99);
CardDataValues.Add(5,165.85);
CardDataValues.Add(6,62.94);
CardDataValues.Add(7,30.72);
CardDataValues.Add(8,44.85);
CardDataValues.Add(9,800);
CardDataValues.Add(10,100);
CardDataValues.Add(11,138.38);
CardDataValues.Add(12,127.35);
CardDataValues.Add(13,40.49);
CardDataValues.Add(14,82.14);
CardDataValues.Add(15,64.96);
CardDataValues.Add(16,40.01);
CardDataValues.Add(17,527.65);
CardDataValues.Add(18,172.71);
CardDataValues.Add(19,33.15);
CardDataValues.Add(20,14.52);
CardDataValues.Add(21,5.24);
CardDataValues.Add(22,7.34);
CardDataValues.Add(23,6.15);
CardDataValues.Add(24,5.42);
CardDataValues.Add(25,5.88);
CardDataValues.Add(26,2.56);
CardDataValues.Add(27,1.17);
CardDataValues.Add(28,3.05);
CardDataValues.Add(29,2.52);
CardDataValues.Add(30,2.34);
CardDataValues.Add(31,2.61);
CardDataValues.Add(32,2.96);
CardDataValues.Add(33,1.56);
CardDataValues.Add(34,3.48);
CardDataValues.Add(35,2.06);
CardDataValues.Add(36,2.09);
CardDataValues.Add(37,1.34);
CardDataValues.Add(38,1.32);
CardDataValues.Add(39,1.79);
CardDataValues.Add(40,1.91);
CardDataValues.Add(41,3.3);
CardDataValues.Add(42,4.24);
CardDataValues.Add(43,2.03);
CardDataValues.Add(44,1.97);
CardDataValues.Add(45,2.72);
CardDataValues.Add(46,5.37);
CardDataValues.Add(47,5.96);
CardDataValues.Add(48,1.85);
CardDataValues.Add(49,1.16);
CardDataValues.Add(50,2.69);
CardDataValues.Add(51,9.49);
CardDataValues.Add(52,1.58);
CardDataValues.Add(53,2.96);
CardDataValues.Add(54,1.96);
CardDataValues.Add(55,0.77);
CardDataValues.Add(56,4.03);
CardDataValues.Add(57,3.36);
CardDataValues.Add(58,0.77);
CardDataValues.Add(59,1.04);
CardDataValues.Add(60,0.99);
CardDataValues.Add(61,0.94);
CardDataValues.Add(62,1.15);
CardDataValues.Add(63,0.79);
CardDataValues.Add(64,0.73);
CardDataValues.Add(65,0.92);
CardDataValues.Add(66,1.06);
CardDataValues.Add(67,0.86);
CardDataValues.Add(68,0.8);
CardDataValues.Add(69,1.1);
CardDataValues.Add(70,6.04);
CardDataValues.Add(71,0.97);
CardDataValues.Add(72,1.1);
CardDataValues.Add(73,1.44);
CardDataValues.Add(74,0.75);
CardDataValues.Add(75,0.9);
CardDataValues.Add(76,0.82);
CardDataValues.Add(77,1.08);
CardDataValues.Add(78,0.92);
CardDataValues.Add(79,0.73);
CardDataValues.Add(80,2.6);
CardDataValues.Add(81,2.22);
CardDataValues.Add(82,0.84);
CardDataValues.Add(83,3.81);
CardDataValues.Add(84,3.25);
CardDataValues.Add(85,2.14);
CardDataValues.Add(86,14.01);
CardDataValues.Add(87,2.74);
CardDataValues.Add(88,2.51);
CardDataValues.Add(89,2.43);
CardDataValues.Add(90,2.08);
CardDataValues.Add(91,0.79);
CardDataValues.Add(92,1.22);
CardDataValues.Add(93,4.11);
CardDataValues.Add(94,0.91);
CardDataValues.Add(95,0.88);
CardDataValues.Add(96,2.53);
CardDataValues.Add(97,1.37);
CardDataValues.Add(98,1.42);
CardDataValues.Add(99,0.47);
CardDataValues.Add(100,1.56);
CardDataValues.Add(101,0.72);
CardDataValues.Add(102,0.62);
CardDataValues.Add(103,0.62);
CardDataValues.Add(104,7.9);
CardDataValues.Add(105,5.52);
CardDataValues.Add(106,0.7);
CardDataValues.Add(107,0.6);
CardDataValues.Add(108,0.59);
CardDataValues.Add(109,0.68);
CardDataValues.Add(110,0.88);
CardDataValues.Add(111,0.83);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}