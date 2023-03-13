using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_LCS_LegendaryCollection : MonoBehaviour {
		
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
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Alakazam");
CardDataNames.Add(2,"Articuno");
CardDataNames.Add(3,"Charizard");
CardDataNames.Add(4,"Dark Blastoise");
CardDataNames.Add(5,"Dark Dragonite");
CardDataNames.Add(6,"Dark Persian");
CardDataNames.Add(7,"Dark Raichu");
CardDataNames.Add(8,"Dark Slowbro");
CardDataNames.Add(9,"Dark Vaporeon");
CardDataNames.Add(10,"Flareon");
CardDataNames.Add(11,"Gengar");
CardDataNames.Add(12,"Gyarados");
CardDataNames.Add(13,"Hitmonlee");
CardDataNames.Add(14,"Jolteon");
CardDataNames.Add(15,"Machamp");
CardDataNames.Add(16,"Muk");
CardDataNames.Add(17,"Ninetales");
CardDataNames.Add(18,"Venusaur");
CardDataNames.Add(19,"Zapdos");
CardDataNames.Add(20,"Beedrill");
CardDataNames.Add(21,"Butterfree");
CardDataNames.Add(22,"Electrode");
CardDataNames.Add(23,"Exeggutor");
CardDataNames.Add(24,"Golem");
CardDataNames.Add(25,"Hypno");
CardDataNames.Add(26,"Jynx");
CardDataNames.Add(27,"Kabutops");
CardDataNames.Add(28,"Magneton");
CardDataNames.Add(29,"Mewtwo");
CardDataNames.Add(30,"Moltres");
CardDataNames.Add(31,"Nidoking");
CardDataNames.Add(32,"Nidoqueen");
CardDataNames.Add(33,"Pidgeot");
CardDataNames.Add(34,"Pidgeotto");
CardDataNames.Add(35,"Rhydon");
CardDataNames.Add(36,"Arcanine");
CardDataNames.Add(37,"Charmeleon");
CardDataNames.Add(38,"Dark Dragonair");
CardDataNames.Add(39,"Dark Wartortle");
CardDataNames.Add(40,"Dewgong");
CardDataNames.Add(41,"Dodrio");
CardDataNames.Add(42,"Fearow");
CardDataNames.Add(43,"Golduck");
CardDataNames.Add(44,"Graveler");
CardDataNames.Add(45,"Growlithe");
CardDataNames.Add(46,"Haunter");
CardDataNames.Add(47,"Ivysaur");
CardDataNames.Add(48,"Kabuto");
CardDataNames.Add(49,"Kadabra");
CardDataNames.Add(50,"Kakuna");
CardDataNames.Add(51,"Machoke");
CardDataNames.Add(52,"Magikarp");
CardDataNames.Add(53,"Meowth");
CardDataNames.Add(54,"Metapod");
CardDataNames.Add(55,"Nidorina");
CardDataNames.Add(56,"Nidorino");
CardDataNames.Add(57,"Omanyte");
CardDataNames.Add(58,"Omastar");
CardDataNames.Add(59,"Primeape");
CardDataNames.Add(60,"Rapidash");
CardDataNames.Add(61,"Raticate");
CardDataNames.Add(62,"Sandslash");
CardDataNames.Add(63,"Seadra");
CardDataNames.Add(64,"Snorlax");
CardDataNames.Add(65,"Tauros");
CardDataNames.Add(66,"Tentacruel");
CardDataNames.Add(67,"Abra");
CardDataNames.Add(68,"Bulbasaur");
CardDataNames.Add(69,"Caterpie");
CardDataNames.Add(70,"Charmander");
CardDataNames.Add(71,"Doduo");
CardDataNames.Add(72,"Dratini");
CardDataNames.Add(73,"Drowzee");
CardDataNames.Add(74,"Eevee");
CardDataNames.Add(75,"Exeggcute");
CardDataNames.Add(76,"Gastly");
CardDataNames.Add(77,"Geodude");
CardDataNames.Add(78,"Grimer");
CardDataNames.Add(79,"Machop");
CardDataNames.Add(80,"Magnemite");
CardDataNames.Add(81,"Mankey");
CardDataNames.Add(82,"Nidoran♀");
CardDataNames.Add(83,"Nidoran♂");
CardDataNames.Add(84,"Onix");
CardDataNames.Add(85,"Pidgey");
CardDataNames.Add(86,"Pikachu");
CardDataNames.Add(87,"Ponyta");
CardDataNames.Add(88,"Psyduck");
CardDataNames.Add(89,"Rattata");
CardDataNames.Add(90,"Rhyhorn");
CardDataNames.Add(91,"Sandshrew");
CardDataNames.Add(92,"Seel");
CardDataNames.Add(93,"Slowpoke");
CardDataNames.Add(94,"Spearow");
CardDataNames.Add(95,"Squirtle");
CardDataNames.Add(96,"Tentacool");
CardDataNames.Add(97,"Voltorb");
CardDataNames.Add(98,"Vulpix");
CardDataNames.Add(99,"Weedle");
CardDataNames.Add(100,"Full Heal Energy");
CardDataNames.Add(101,"Potion Energy");
CardDataNames.Add(102,"Pokemon Breeder");
CardDataNames.Add(103,"Pokemon Trader");
CardDataNames.Add(104,"Scoop Up");
CardDataNames.Add(105,"The Boss's Way");
CardDataNames.Add(106,"Challenge!");
CardDataNames.Add(107,"Energy Retrieval");
CardDataNames.Add(108,"Bill");
CardDataNames.Add(109,"Mysterious Fossil");
CardDataNames.Add(110,"Potion");
	}

	public void SetCardValues() {
CardDataValues.Add(1,35.99);
CardDataValues.Add(2,31.16);
CardDataValues.Add(3,312.5);
CardDataValues.Add(4,81.11);
CardDataValues.Add(5,49.99);
CardDataValues.Add(6,15.87);
CardDataValues.Add(7,33.99);
CardDataValues.Add(8,16.82);
CardDataValues.Add(9,40.15);
CardDataValues.Add(10,57.26);
CardDataValues.Add(11,45.05);
CardDataValues.Add(12,15.49);
CardDataValues.Add(13,18.66);
CardDataValues.Add(14,24.29);
CardDataValues.Add(15,19.59);
CardDataValues.Add(16,12.45);
CardDataValues.Add(17,12.53);
CardDataValues.Add(18,60.44);
CardDataValues.Add(19,17.37);
CardDataValues.Add(20,3.58);
CardDataValues.Add(21,3.21);
CardDataValues.Add(22,2.41);
CardDataValues.Add(23,3);
CardDataValues.Add(24,4);
CardDataValues.Add(25,3.25);
CardDataValues.Add(26,3.12);
CardDataValues.Add(27,5.01);
CardDataValues.Add(28,2.2);
CardDataValues.Add(29,19.84);
CardDataValues.Add(30,8.19);
CardDataValues.Add(31,6.78);
CardDataValues.Add(32,5.73);
CardDataValues.Add(33,5.17);
CardDataValues.Add(34,4.71);
CardDataValues.Add(35,3.96);
CardDataValues.Add(36,3.28);
CardDataValues.Add(37,1.66);
CardDataValues.Add(38,2.04);
CardDataValues.Add(39,1.98);
CardDataValues.Add(40,1.09);
CardDataValues.Add(41,1.49);
CardDataValues.Add(42,1.8);
CardDataValues.Add(43,1.54);
CardDataValues.Add(44,1.54);
CardDataValues.Add(45,2.99);
CardDataValues.Add(46,3.41);
CardDataValues.Add(47,5);
CardDataValues.Add(48,1.6);
CardDataValues.Add(49,3.94);
CardDataValues.Add(50,1.5);
CardDataValues.Add(51,1.68);
CardDataValues.Add(52,2);
CardDataValues.Add(53,2.3);
CardDataValues.Add(54,1.31);
CardDataValues.Add(55,1.48);
CardDataValues.Add(56,1.89);
CardDataValues.Add(57,1.55);
CardDataValues.Add(58,1.98);
CardDataValues.Add(59,1.11);
CardDataValues.Add(60,1.41);
CardDataValues.Add(61,0.99);
CardDataValues.Add(62,1.09);
CardDataValues.Add(63,1.6);
CardDataValues.Add(64,5.3);
CardDataValues.Add(65,1.43);
CardDataValues.Add(66,1.55);
CardDataValues.Add(67,1.27);
CardDataValues.Add(68,2.86);
CardDataValues.Add(69,0.83);
CardDataValues.Add(70,1.49);
CardDataValues.Add(71,0.58);
CardDataValues.Add(72,0.76);
CardDataValues.Add(73,0.59);
CardDataValues.Add(74,2.28);
CardDataValues.Add(75,0.5);
CardDataValues.Add(76,1);
CardDataValues.Add(77,0.5);
CardDataValues.Add(78,0.57);
CardDataValues.Add(79,0.5);
CardDataValues.Add(80,0.5);
CardDataValues.Add(81,0.49);
CardDataValues.Add(82,0.51);
CardDataValues.Add(83,0.73);
CardDataValues.Add(84,0.5);
CardDataValues.Add(85,0.63);
CardDataValues.Add(86,3.01);
CardDataValues.Add(87,0.5);
CardDataValues.Add(88,1.49);
CardDataValues.Add(89,0.46);
CardDataValues.Add(90,0.5);
CardDataValues.Add(91,0.49);
CardDataValues.Add(92,0.5);
CardDataValues.Add(93,0.72);
CardDataValues.Add(94,0.56);
CardDataValues.Add(95,2.05);
CardDataValues.Add(96,0.5);
CardDataValues.Add(97,0.64);
CardDataValues.Add(98,0.92);
CardDataValues.Add(99,0.68);
CardDataValues.Add(100,1.49);
CardDataValues.Add(101,0.84);
CardDataValues.Add(102,4.55);
CardDataValues.Add(103,2.06);
CardDataValues.Add(104,6.81);
CardDataValues.Add(105,0.85);
CardDataValues.Add(106,0.88);
CardDataValues.Add(107,0.49);
CardDataValues.Add(108,0.5);
CardDataValues.Add(109,0.66);
CardDataValues.Add(110,0.28);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}