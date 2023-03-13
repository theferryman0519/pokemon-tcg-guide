using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_OGS_Base : MonoBehaviour {
		
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
	}

	public void SetCardNames() {
		CardDataNames.Add(1, "Alakazam");
		CardDataNames.Add(2, "Blastoise");
		CardDataNames.Add(3, "Chansey");
		CardDataNames.Add(4, "Charizard");
		CardDataNames.Add(5, "Clefairy");
		CardDataNames.Add(6, "Gyarados");
		CardDataNames.Add(7, "Hitmonchan");
		CardDataNames.Add(8, "Machamp");
		CardDataNames.Add(9, "Magneton");
		CardDataNames.Add(10, "Mewtwo");
		CardDataNames.Add(11, "Nidoking");
		CardDataNames.Add(12, "Ninetales");
		CardDataNames.Add(13, "Poliwrath");
		CardDataNames.Add(14, "Raichu");
		CardDataNames.Add(15, "Venusaur");
		CardDataNames.Add(16, "Zapdos");
		CardDataNames.Add(17, "Beedrill");
		CardDataNames.Add(18, "Dragonair");
		CardDataNames.Add(19, "Dugtrio");
		CardDataNames.Add(20, "Electabuzz");
		CardDataNames.Add(21, "Electrode");
		CardDataNames.Add(22, "Pidgeotto");
		CardDataNames.Add(23, "Arcanine");
		CardDataNames.Add(24, "Charmeleon");
		CardDataNames.Add(25, "Dewgong");
		CardDataNames.Add(26, "Dratini");
		CardDataNames.Add(27, "Farfetch'd");
		CardDataNames.Add(28, "Growlithe");
		CardDataNames.Add(29, "Haunter");
		CardDataNames.Add(30, "Ivysaur");
		CardDataNames.Add(31, "Jynx");
		CardDataNames.Add(32, "Kadabra");
		CardDataNames.Add(33, "Kakuna");
		CardDataNames.Add(34, "Machoke");
		CardDataNames.Add(35, "Magikarp");
		CardDataNames.Add(36, "Magmar");
		CardDataNames.Add(37, "Nidorino");
		CardDataNames.Add(38, "Poliwhirl");
		CardDataNames.Add(39, "Porygon");
		CardDataNames.Add(40, "Raticate");
		CardDataNames.Add(41, "Seel");
		CardDataNames.Add(42, "Wartortle");
		CardDataNames.Add(43, "Abra");
		CardDataNames.Add(44, "Bulbasaur");
		CardDataNames.Add(45, "Caterpie");
		CardDataNames.Add(46, "Charmander");
		CardDataNames.Add(47, "Diglett");
		CardDataNames.Add(48, "Doduo");
		CardDataNames.Add(49, "Drowzee");
		CardDataNames.Add(50, "Gastly");
		CardDataNames.Add(51, "Koffing");
		CardDataNames.Add(52, "Machop");
		CardDataNames.Add(53, "Magnemite");
		CardDataNames.Add(54, "Metapod");
		CardDataNames.Add(55, "Nidoran♂");
		CardDataNames.Add(56, "Onix");
		CardDataNames.Add(57, "Pidgey");
		CardDataNames.Add(58, "Pikachu");
		CardDataNames.Add(59, "Poliwag");
		CardDataNames.Add(60, "Ponyta");
		CardDataNames.Add(61, "Rattata");
		CardDataNames.Add(62, "Sandshrew");
		CardDataNames.Add(63, "Squirtle");
		CardDataNames.Add(64, "Starmie");
		CardDataNames.Add(65, "Staryu");
		CardDataNames.Add(66, "Tangela");
		CardDataNames.Add(67, "Voltorb");
		CardDataNames.Add(68, "Vulpix");
		CardDataNames.Add(69, "Weedle");
		CardDataNames.Add(70, "Clefairy Doll");
		CardDataNames.Add(71, "Computer Search");
		CardDataNames.Add(72, "Devolution Spray");
		CardDataNames.Add(73, "Imposter Professor Oak");
		CardDataNames.Add(74, "Itemfinder");
		CardDataNames.Add(75, "Lass");
		CardDataNames.Add(76, "Pokémon Breeder");
		CardDataNames.Add(77, "Pokémon Trader");
		CardDataNames.Add(78, "Scoop Up");
		CardDataNames.Add(79, "Super Energy Removal");
		CardDataNames.Add(80, "Defender");
		CardDataNames.Add(81, "Energy Retrieval");
		CardDataNames.Add(82, "Full Heal");
		CardDataNames.Add(83, "Maintanence");
		CardDataNames.Add(84, "Plus Power");
		CardDataNames.Add(85, "Pokémon Center");
		CardDataNames.Add(86, "Pokémon Flute");
		CardDataNames.Add(87, "Professor Oak");
		CardDataNames.Add(88, "Pokédex");
		CardDataNames.Add(89, "Revive");
		CardDataNames.Add(90, "Super Potion");
		CardDataNames.Add(91, "Bill");
		CardDataNames.Add(92, "Energy Removal");
		CardDataNames.Add(93, "Gust of Wind");
		CardDataNames.Add(94, "Potion");
		CardDataNames.Add(95, "Switch");
		CardDataNames.Add(96, "Double Colorless");
		CardDataNames.Add(97, "Fighting");
		CardDataNames.Add(98, "Fire");
		CardDataNames.Add(99, "Grass");
		CardDataNames.Add(100, "Lightning");
		CardDataNames.Add(101, "Psychic");
		CardDataNames.Add(102, "Water");
	}

	public void SetCardValues() {
		CardDataValues.Add(1, 36.05);
		CardDataValues.Add(2, 124.16);
		CardDataValues.Add(3, 24.55);
		CardDataValues.Add(4, 330.22);
		CardDataValues.Add(5, 20.18);
		CardDataValues.Add(6, 20.52);
		CardDataValues.Add(7, 12.69);
		CardDataValues.Add(8, 15.22);
		CardDataValues.Add(9, 10.27);
		CardDataValues.Add(10, 25.41);
		CardDataValues.Add(11, 21.23);
		CardDataValues.Add(12, 13.67);
		CardDataValues.Add(13, 17.62);
		CardDataValues.Add(14, 34.96);
		CardDataValues.Add(15, 81.72);
		CardDataValues.Add(16, 23.51);
		CardDataValues.Add(17, 2.99);
		CardDataValues.Add(18, 7.5);
		CardDataValues.Add(19, 4);
		CardDataValues.Add(20, 4.93);
		CardDataValues.Add(21, 4.31);
		CardDataValues.Add(22, 6.6);
		CardDataValues.Add(23, 2.17);
		CardDataValues.Add(24, 1.43);
		CardDataValues.Add(25, 2.15);
		CardDataValues.Add(26, 1.42);
		CardDataValues.Add(27, 0.95);
		CardDataValues.Add(28, 0.9);
		CardDataValues.Add(29, 1.32);
		CardDataValues.Add(30, 3.55);
		CardDataValues.Add(31, 0.8);
		CardDataValues.Add(32, 1.48);
		CardDataValues.Add(33, 0.87);
		CardDataValues.Add(34, 0.7);
		CardDataValues.Add(35, 1.44);
		CardDataValues.Add(36, 2.16);
		CardDataValues.Add(37, 2.01);
		CardDataValues.Add(38, 1.01);
		CardDataValues.Add(39, 1.75);
		CardDataValues.Add(40, 1.82);
		CardDataValues.Add(41, 1.2);
		CardDataValues.Add(42, 3.08);
		CardDataValues.Add(43, 0.5);
		CardDataValues.Add(44, 2.5);
		CardDataValues.Add(45, 0.81);
		CardDataValues.Add(46, 2);
		CardDataValues.Add(47, 0.4);
		CardDataValues.Add(48, 0.67);
		CardDataValues.Add(49, 0.51);
		CardDataValues.Add(50, 0.5);
		CardDataValues.Add(51, 0.39);
		CardDataValues.Add(52, 0.34);
		CardDataValues.Add(53, 0.5);
		CardDataValues.Add(54, 0.59);
		CardDataValues.Add(55, 0.49);
		CardDataValues.Add(56, 0.5);
		CardDataValues.Add(57, 0.84);
		CardDataValues.Add(58, 3.48);
		CardDataValues.Add(59, 0.43);
		CardDataValues.Add(60, 0.44);
		CardDataValues.Add(61, 0.49);
		CardDataValues.Add(62, 0.51);
		CardDataValues.Add(63, 3.8);
		CardDataValues.Add(64, 0.49);
		CardDataValues.Add(65, 0.4);
		CardDataValues.Add(66, 0.61);
		CardDataValues.Add(67, 1.65);
		CardDataValues.Add(68, 0.62);
		CardDataValues.Add(69, 0.49);
		CardDataValues.Add(70, 3.5);
		CardDataValues.Add(71, 4.51);
		CardDataValues.Add(72, 2.21);
		CardDataValues.Add(73, 3.47);
		CardDataValues.Add(74, 8.45);
		CardDataValues.Add(75, 2);
		CardDataValues.Add(76, 5.45);
		CardDataValues.Add(77, 3.05);
		CardDataValues.Add(78, 4.84);
		CardDataValues.Add(79, 3.11);
		CardDataValues.Add(80, 1.21);
		CardDataValues.Add(81, 0.47);
		CardDataValues.Add(82, 1.03);
		CardDataValues.Add(83, 1.52);
		CardDataValues.Add(84, 0.72);
		CardDataValues.Add(85, 1.5);
		CardDataValues.Add(86, 1.59);
		CardDataValues.Add(87, 0.4);
		CardDataValues.Add(88, 1.35);
		CardDataValues.Add(89, 1.8);
		CardDataValues.Add(90, 0.28);
		CardDataValues.Add(91, 0.32);
		CardDataValues.Add(92, 0.45);
		CardDataValues.Add(93, 0.31);
		CardDataValues.Add(94, 0.25);
		CardDataValues.Add(95, 0.36);
		CardDataValues.Add(96, 3.5);
		CardDataValues.Add(97, 0.3);
		CardDataValues.Add(98, 0.31);
		CardDataValues.Add(99, 0.25);
		CardDataValues.Add(100, 0.39);
		CardDataValues.Add(101, 0.35);
		CardDataValues.Add(102, 0.31);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}