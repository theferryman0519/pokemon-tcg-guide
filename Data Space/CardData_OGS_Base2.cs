using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_OGS_Base2 : MonoBehaviour {
		
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
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Alakazam");
CardDataNames.Add(2,"Blastoise");
CardDataNames.Add(3,"Chansey");
CardDataNames.Add(4,"Charizard");
CardDataNames.Add(5,"Clefable");
CardDataNames.Add(6,"Clefairy");
CardDataNames.Add(7,"Gyarados");
CardDataNames.Add(8,"Hitmonchan");
CardDataNames.Add(9,"Magneton");
CardDataNames.Add(10,"Mewtwo");
CardDataNames.Add(11,"Nidoking");
CardDataNames.Add(12,"Nidoqueen");
CardDataNames.Add(13,"Ninetales");
CardDataNames.Add(14,"Pidgeot");
CardDataNames.Add(15,"Poliwrath");
CardDataNames.Add(16,"Raichu");
CardDataNames.Add(17,"Scyther");
CardDataNames.Add(18,"Venusaur");
CardDataNames.Add(19,"Wigglytuff");
CardDataNames.Add(20,"Zapdos");
CardDataNames.Add(21,"Beedrill");
CardDataNames.Add(22,"Dragonair");
CardDataNames.Add(23,"Dugtrio");
CardDataNames.Add(24,"Electabuzz");
CardDataNames.Add(25,"Electrode");
CardDataNames.Add(26,"Kangaskhan");
CardDataNames.Add(27,"Mr Mime");
CardDataNames.Add(28,"Pidgeotto");
CardDataNames.Add(29,"Pinsir");
CardDataNames.Add(30,"Snorlax");
CardDataNames.Add(31,"Venomoth");
CardDataNames.Add(32,"Victreebel");
CardDataNames.Add(33,"Arcanine");
CardDataNames.Add(34,"Butterfree");
CardDataNames.Add(35,"Charmeleon");
CardDataNames.Add(36,"Dewgong");
CardDataNames.Add(37,"Dodrio");
CardDataNames.Add(38,"Dratini");
CardDataNames.Add(39,"Exeggutor");
CardDataNames.Add(40,"Farfetch'd");
CardDataNames.Add(41,"Fearow");
CardDataNames.Add(42,"Growlithe");
CardDataNames.Add(43,"Haunter");
CardDataNames.Add(44,"Ivysaur");
CardDataNames.Add(45,"Jynx");
CardDataNames.Add(46,"Kadabra");
CardDataNames.Add(47,"Kakuna");
CardDataNames.Add(48,"Lickitung");
CardDataNames.Add(49,"Machoke");
CardDataNames.Add(50,"Magikarp");
CardDataNames.Add(51,"Magmar");
CardDataNames.Add(52,"Marowak");
CardDataNames.Add(53,"Nidorina");
CardDataNames.Add(54,"Nidorino");
CardDataNames.Add(55,"Parasect");
CardDataNames.Add(56,"Persian");
CardDataNames.Add(57,"Poliwhirl");
CardDataNames.Add(58,"Raticate");
CardDataNames.Add(59,"Rhydon");
CardDataNames.Add(60,"Seaking");
CardDataNames.Add(61,"Seel");
CardDataNames.Add(62,"Tauros");
CardDataNames.Add(63,"Wartortle");
CardDataNames.Add(64,"Weepinbell");
CardDataNames.Add(65,"Abra");
CardDataNames.Add(66,"Bellsprout");
CardDataNames.Add(67,"Bulbasaur");
CardDataNames.Add(68,"Caterpie");
CardDataNames.Add(69,"Charmander");
CardDataNames.Add(70,"Cubone");
CardDataNames.Add(71,"Diglett");
CardDataNames.Add(72,"Doduo");
CardDataNames.Add(73,"Drowzee");
CardDataNames.Add(74,"Exeggcute");
CardDataNames.Add(75,"Gastly");
CardDataNames.Add(76,"Goldeen");
CardDataNames.Add(77,"Jigglypuff");
CardDataNames.Add(78,"Machop");
CardDataNames.Add(79,"Magnemite");
CardDataNames.Add(80,"Meowth");
CardDataNames.Add(81,"Metapod");
CardDataNames.Add(82,"Nidoran♀");
CardDataNames.Add(83,"Nidoran♂");
CardDataNames.Add(84,"Onix");
CardDataNames.Add(85,"Paras");
CardDataNames.Add(86,"Pidgey");
CardDataNames.Add(87,"Pikachu");
CardDataNames.Add(88,"Poliwag");
CardDataNames.Add(89,"Rattata");
CardDataNames.Add(90,"Rhyhorn");
CardDataNames.Add(91,"Sandshrew");
CardDataNames.Add(92,"Spearow");
CardDataNames.Add(93,"Squirtle");
CardDataNames.Add(94,"Starmie");
CardDataNames.Add(95,"Staryu");
CardDataNames.Add(96,"Tangela");
CardDataNames.Add(97,"Venonat");
CardDataNames.Add(98,"Voltorb");
CardDataNames.Add(99,"Vulpix");
CardDataNames.Add(100,"Weedle");
CardDataNames.Add(101,"Computer Search");
CardDataNames.Add(102,"Imposter Professor Oak");
CardDataNames.Add(103,"Item Finder");
CardDataNames.Add(104,"Lass");
CardDataNames.Add(105,"Pokemon Breeder");
CardDataNames.Add(106,"Pokemon Trader");
CardDataNames.Add(107,"Scoop Up");
CardDataNames.Add(108,"Super Energy Removal");
CardDataNames.Add(109,"Defender");
CardDataNames.Add(110,"Energy Retrieval");
CardDataNames.Add(111,"Full Heal");
CardDataNames.Add(112,"Maintenance");
CardDataNames.Add(113,"PlusPower");
CardDataNames.Add(114,"Pokemon Center");
CardDataNames.Add(115,"Pokedex");
CardDataNames.Add(116,"Professor Oak");
CardDataNames.Add(117,"Super Potion");
CardDataNames.Add(118,"Bill");
CardDataNames.Add(119,"Energy Removal");
CardDataNames.Add(120,"Gust of Wind");
CardDataNames.Add(121,"Poke Ball");
CardDataNames.Add(122,"Potion");
CardDataNames.Add(123,"Switch");
CardDataNames.Add(124,"Double Colorless Energy");
CardDataNames.Add(125,"Fighting Energy");
CardDataNames.Add(126,"Fire Energy");
CardDataNames.Add(127,"Grass Energy");
CardDataNames.Add(128,"Lightning Energy");
CardDataNames.Add(129,"Psychic Energy");
CardDataNames.Add(130,"Water Energy");
	}

	public void SetCardValues() {
CardDataValues.Add(1,19.88);
CardDataValues.Add(2,66.02);
CardDataValues.Add(3,10.3);
CardDataValues.Add(4,227.79);
CardDataValues.Add(5,10.16);
CardDataValues.Add(6,8.73);
CardDataValues.Add(7,15.67);
CardDataValues.Add(8,13.71);
CardDataValues.Add(9,9.83);
CardDataValues.Add(10,21);
CardDataValues.Add(11,12.41);
CardDataValues.Add(12,15.04);
CardDataValues.Add(13,11.77);
CardDataValues.Add(14,19.27);
CardDataValues.Add(15,7.9);
CardDataValues.Add(16,19.6);
CardDataValues.Add(17,16.79);
CardDataValues.Add(18,56.11);
CardDataValues.Add(19,7.25);
CardDataValues.Add(20,16.54);
CardDataValues.Add(21,1.75);
CardDataValues.Add(22,4.28);
CardDataValues.Add(23,2.53);
CardDataValues.Add(24,2.24);
CardDataValues.Add(25,2.49);
CardDataValues.Add(26,2.47);
CardDataValues.Add(27,3.65);
CardDataValues.Add(28,2.89);
CardDataValues.Add(29,2.85);
CardDataValues.Add(30,4.98);
CardDataValues.Add(31,2.66);
CardDataValues.Add(32,1.99);
CardDataValues.Add(33,1.84);
CardDataValues.Add(34,1.46);
CardDataValues.Add(35,1.69);
CardDataValues.Add(36,1);
CardDataValues.Add(37,1.46);
CardDataValues.Add(38,0.79);
CardDataValues.Add(39,1.16);
CardDataValues.Add(40,0.49);
CardDataValues.Add(41,1.14);
CardDataValues.Add(42,1.13);
CardDataValues.Add(43,0.85);
CardDataValues.Add(44,2.73);
CardDataValues.Add(45,0.57);
CardDataValues.Add(46,1.25);
CardDataValues.Add(47,0.52);
CardDataValues.Add(48,1.35);
CardDataValues.Add(49,0.49);
CardDataValues.Add(50,0.81);
CardDataValues.Add(51,1.14);
CardDataValues.Add(52,1.32);
CardDataValues.Add(53,1);
CardDataValues.Add(54,1.13);
CardDataValues.Add(55,1);
CardDataValues.Add(56,1.11);
CardDataValues.Add(57,0.82);
CardDataValues.Add(58,0.95);
CardDataValues.Add(59,1.72);
CardDataValues.Add(60,0.55);
CardDataValues.Add(61,0.51);
CardDataValues.Add(62,2.59);
CardDataValues.Add(63,1.4);
CardDataValues.Add(64,0.55);
CardDataValues.Add(65,0.48);
CardDataValues.Add(66,0.35);
CardDataValues.Add(67,2.24);
CardDataValues.Add(68,0.4);
CardDataValues.Add(69,1.25);
CardDataValues.Add(70,0.59);
CardDataValues.Add(71,0.35);
CardDataValues.Add(72,0.37);
CardDataValues.Add(73,0.37);
CardDataValues.Add(74,0.45);
CardDataValues.Add(75,0.45);
CardDataValues.Add(76,0.33);
CardDataValues.Add(77,0.76);
CardDataValues.Add(78,0.26);
CardDataValues.Add(79,0.39);
CardDataValues.Add(80,0.52);
CardDataValues.Add(81,0.45);
CardDataValues.Add(82,0.33);
CardDataValues.Add(83,0.34);
CardDataValues.Add(84,0.8);
CardDataValues.Add(85,0.36);
CardDataValues.Add(86,0.6);
CardDataValues.Add(87,1.5);
CardDataValues.Add(88,0.31);
CardDataValues.Add(89,0.31);
CardDataValues.Add(90,0.39);
CardDataValues.Add(91,0.35);
CardDataValues.Add(92,0.35);
CardDataValues.Add(93,1.14);
CardDataValues.Add(94,0.4);
CardDataValues.Add(95,0.26);
CardDataValues.Add(96,0.33);
CardDataValues.Add(97,0.39);
CardDataValues.Add(98,0.5);
CardDataValues.Add(99,0.53);
CardDataValues.Add(100,0.3);
CardDataValues.Add(101,4.04);
CardDataValues.Add(102,1.41);
CardDataValues.Add(103,6.89);
CardDataValues.Add(104,2.02);
CardDataValues.Add(105,3.19);
CardDataValues.Add(106,2);
CardDataValues.Add(107,3.55);
CardDataValues.Add(108,2.15);
CardDataValues.Add(109,0.34);
CardDataValues.Add(110,0.41);
CardDataValues.Add(111,0.26);
CardDataValues.Add(112,0.6);
CardDataValues.Add(113,0.41);
CardDataValues.Add(114,0.85);
CardDataValues.Add(115,0.35);
CardDataValues.Add(116,1.43);
CardDataValues.Add(117,0.25);
CardDataValues.Add(118,0.3);
CardDataValues.Add(119,0.26);
CardDataValues.Add(120,0.25);
CardDataValues.Add(121,0.25);
CardDataValues.Add(122,0.23);
CardDataValues.Add(123,0.25);
CardDataValues.Add(124,2.13);
CardDataValues.Add(125,0.25);
CardDataValues.Add(126,0.33);
CardDataValues.Add(127,0.22);
CardDataValues.Add(128,0.26);
CardDataValues.Add(129,0.25);
CardDataValues.Add(130,0.25);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}