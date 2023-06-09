using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_EX_HolonPhantoms : MonoBehaviour {
		
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
CardDataNumbers.Add(19,"18H");
CardDataNumbers.Add(20,"18RH");
CardDataNumbers.Add(21,"19");
CardDataNumbers.Add(22,"20");
CardDataNumbers.Add(23,"20H");
CardDataNumbers.Add(24,"20RH");
CardDataNumbers.Add(25,"21");
CardDataNumbers.Add(26,"22");
CardDataNumbers.Add(27,"23");
CardDataNumbers.Add(28,"23H");
CardDataNumbers.Add(29,"23RH");
CardDataNumbers.Add(30,"24");
CardDataNumbers.Add(31,"25");
CardDataNumbers.Add(32,"25H");
CardDataNumbers.Add(33,"25RH");
CardDataNumbers.Add(34,"26");
CardDataNumbers.Add(35,"27");
CardDataNumbers.Add(36,"27H");
CardDataNumbers.Add(37,"27RH");
CardDataNumbers.Add(38,"28");
CardDataNumbers.Add(39,"28H");
CardDataNumbers.Add(40,"28RH");
CardDataNumbers.Add(41,"29");
CardDataNumbers.Add(42,"29H");
CardDataNumbers.Add(43,"29RH");
CardDataNumbers.Add(44,"30");
CardDataNumbers.Add(45,"30H");
CardDataNumbers.Add(46,"30RH");
CardDataNumbers.Add(47,"31");
CardDataNumbers.Add(48,"31H");
CardDataNumbers.Add(49,"31RH");
CardDataNumbers.Add(50,"32");
CardDataNumbers.Add(51,"32H");
CardDataNumbers.Add(52,"32RH");
CardDataNumbers.Add(53,"33");
CardDataNumbers.Add(54,"33H");
CardDataNumbers.Add(55,"33RH");
CardDataNumbers.Add(56,"34");
CardDataNumbers.Add(57,"34H");
CardDataNumbers.Add(58,"34RH");
CardDataNumbers.Add(59,"35");
CardDataNumbers.Add(60,"36");
CardDataNumbers.Add(61,"36H");
CardDataNumbers.Add(62,"36RH");
CardDataNumbers.Add(63,"37");
CardDataNumbers.Add(64,"38");
CardDataNumbers.Add(65,"38H");
CardDataNumbers.Add(66,"38RH");
CardDataNumbers.Add(67,"39");
CardDataNumbers.Add(68,"39H");
CardDataNumbers.Add(69,"39RH");
CardDataNumbers.Add(70,"40");
CardDataNumbers.Add(71,"40H");
CardDataNumbers.Add(72,"40RH");
CardDataNumbers.Add(73,"41");
CardDataNumbers.Add(74,"42");
CardDataNumbers.Add(75,"43");
CardDataNumbers.Add(76,"44");
CardDataNumbers.Add(77,"44H");
CardDataNumbers.Add(78,"44RH");
CardDataNumbers.Add(79,"45");
CardDataNumbers.Add(80,"45H");
CardDataNumbers.Add(81,"45RH");
CardDataNumbers.Add(82,"46");
CardDataNumbers.Add(83,"46H");
CardDataNumbers.Add(84,"46RH");
CardDataNumbers.Add(85,"47");
CardDataNumbers.Add(86,"47H");
CardDataNumbers.Add(87,"47RH");
CardDataNumbers.Add(88,"48");
CardDataNumbers.Add(89,"49");
CardDataNumbers.Add(90,"50");
CardDataNumbers.Add(91,"51");
CardDataNumbers.Add(92,"51H");
CardDataNumbers.Add(93,"51RH");
CardDataNumbers.Add(94,"52");
CardDataNumbers.Add(95,"53");
CardDataNumbers.Add(96,"54");
CardDataNumbers.Add(97,"55");
CardDataNumbers.Add(98,"55H");
CardDataNumbers.Add(99,"55RH");
CardDataNumbers.Add(100,"56");
CardDataNumbers.Add(101,"56H");
CardDataNumbers.Add(102,"56RH");
CardDataNumbers.Add(103,"57");
CardDataNumbers.Add(104,"58");
CardDataNumbers.Add(105,"58H");
CardDataNumbers.Add(106,"58RH");
CardDataNumbers.Add(107,"59");
CardDataNumbers.Add(108,"59H");
CardDataNumbers.Add(109,"59RH");
CardDataNumbers.Add(110,"60");
CardDataNumbers.Add(111,"60H");
CardDataNumbers.Add(112,"60RH");
CardDataNumbers.Add(113,"61");
CardDataNumbers.Add(114,"62");
CardDataNumbers.Add(115,"62H");
CardDataNumbers.Add(116,"62RH");
CardDataNumbers.Add(117,"63");
CardDataNumbers.Add(118,"63H");
CardDataNumbers.Add(119,"63RH");
CardDataNumbers.Add(120,"64");
CardDataNumbers.Add(121,"64H");
CardDataNumbers.Add(122,"64RH");
CardDataNumbers.Add(123,"65");
CardDataNumbers.Add(124,"66");
CardDataNumbers.Add(125,"67");
CardDataNumbers.Add(126,"68");
CardDataNumbers.Add(127,"69");
CardDataNumbers.Add(128,"70");
CardDataNumbers.Add(129,"71");
CardDataNumbers.Add(130,"72");
CardDataNumbers.Add(131,"72H");
CardDataNumbers.Add(132,"72RH");
CardDataNumbers.Add(133,"73");
CardDataNumbers.Add(134,"74");
CardDataNumbers.Add(135,"75");
CardDataNumbers.Add(136,"75H");
CardDataNumbers.Add(137,"75RH");
CardDataNumbers.Add(138,"76");
CardDataNumbers.Add(139,"77");
CardDataNumbers.Add(140,"78");
CardDataNumbers.Add(141,"78H");
CardDataNumbers.Add(142,"78RH");
CardDataNumbers.Add(143,"79");
CardDataNumbers.Add(144,"80");
CardDataNumbers.Add(145,"80H");
CardDataNumbers.Add(146,"80RH");
CardDataNumbers.Add(147,"81");
CardDataNumbers.Add(148,"82");
CardDataNumbers.Add(149,"82H");
CardDataNumbers.Add(150,"82RH");
CardDataNumbers.Add(151,"83");
CardDataNumbers.Add(152,"83H");
CardDataNumbers.Add(153,"83RH");
CardDataNumbers.Add(154,"84");
CardDataNumbers.Add(155,"85");
CardDataNumbers.Add(156,"85H");
CardDataNumbers.Add(157,"85RH");
CardDataNumbers.Add(158,"86");
CardDataNumbers.Add(159,"86H");
CardDataNumbers.Add(160,"86RH");
CardDataNumbers.Add(161,"87");
CardDataNumbers.Add(162,"87H");
CardDataNumbers.Add(163,"87RH");
CardDataNumbers.Add(164,"88");
CardDataNumbers.Add(165,"88H");
CardDataNumbers.Add(166,"88RH");
CardDataNumbers.Add(167,"89");
CardDataNumbers.Add(168,"89H");
CardDataNumbers.Add(169,"89RH");
CardDataNumbers.Add(170,"90");
CardDataNumbers.Add(171,"90H");
CardDataNumbers.Add(172,"90RH");
CardDataNumbers.Add(173,"91");
CardDataNumbers.Add(174,"91H");
CardDataNumbers.Add(175,"91RH");
CardDataNumbers.Add(176,"92");
CardDataNumbers.Add(177,"92H");
CardDataNumbers.Add(178,"92RH");
CardDataNumbers.Add(179,"93");
CardDataNumbers.Add(180,"93H");
CardDataNumbers.Add(181,"93RH");
CardDataNumbers.Add(182,"94");
CardDataNumbers.Add(183,"94H");
CardDataNumbers.Add(184,"94RH");
CardDataNumbers.Add(185,"95");
CardDataNumbers.Add(186,"95H");
CardDataNumbers.Add(187,"95RH");
CardDataNumbers.Add(188,"96");
CardDataNumbers.Add(189,"96H");
CardDataNumbers.Add(190,"96RH");
CardDataNumbers.Add(191,"97");
CardDataNumbers.Add(192,"97H");
CardDataNumbers.Add(193,"97RH");
CardDataNumbers.Add(194,"98");
CardDataNumbers.Add(195,"98H");
CardDataNumbers.Add(196,"98RH");
CardDataNumbers.Add(197,"99");
CardDataNumbers.Add(198,"100");
CardDataNumbers.Add(199,"101");
CardDataNumbers.Add(200,"102");
CardDataNumbers.Add(201,"103");
CardDataNumbers.Add(202,"103H");
CardDataNumbers.Add(203,"103RH");
CardDataNumbers.Add(204,"104");
CardDataNumbers.Add(205,"104H");
CardDataNumbers.Add(206,"104RH");
CardDataNumbers.Add(207,"105");
CardDataNumbers.Add(208,"105H");
CardDataNumbers.Add(209,"105RH");
CardDataNumbers.Add(210,"106");
CardDataNumbers.Add(211,"106H");
CardDataNumbers.Add(212,"106RH");
CardDataNumbers.Add(213,"107");
CardDataNumbers.Add(214,"107H");
CardDataNumbers.Add(215,"107RH");
CardDataNumbers.Add(216,"108");
CardDataNumbers.Add(217,"108H");
CardDataNumbers.Add(218,"108RH");
CardDataNumbers.Add(219,"109");
CardDataNumbers.Add(220,"109H");
CardDataNumbers.Add(221,"109RH");
CardDataNumbers.Add(222,"110");
CardDataNumbers.Add(223,"110H");
CardDataNumbers.Add(224,"110RH");
CardDataNumbers.Add(225,"111");
CardDataNumbers.Add(226,"111H");
CardDataNumbers.Add(227,"111RH");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Armaldo δ");
CardDataNames.Add(2,"Cradily δ");
CardDataNames.Add(3,"Deoxys δ");
CardDataNames.Add(4,"Deoxys δ");
CardDataNames.Add(5,"Deoxys δ");
CardDataNames.Add(6,"Deoxys δ");
CardDataNames.Add(7,"Flygon δ");
CardDataNames.Add(8,"Gyarados δ");
CardDataNames.Add(9,"Kabutops δ");
CardDataNames.Add(10,"Kingdra δ");
CardDataNames.Add(11,"Latias δ");
CardDataNames.Add(12,"Latios δ");
CardDataNames.Add(13,"Omastar δ");
CardDataNames.Add(14,"Pidgeot δ");
CardDataNames.Add(15,"Raichu δ");
CardDataNames.Add(16,"Rayquaza δ");
CardDataNames.Add(17,"Vileplume δ");
CardDataNames.Add(18,"Absol");
CardDataNames.Add(19,"Absol Holofoil");
CardDataNames.Add(20,"Absol Reverse Holo");
CardDataNames.Add(21,"Bellossom δ");
CardDataNames.Add(22,"Blaziken");
CardDataNames.Add(23,"Blaziken Holofoil");
CardDataNames.Add(24,"Blaziken Reverse Holo");
CardDataNames.Add(25,"Latias δ");
CardDataNames.Add(26,"Latios δ");
CardDataNames.Add(27,"Mawile");
CardDataNames.Add(28,"Mawile Holofoil");
CardDataNames.Add(29,"Mawile Reverse Holo");
CardDataNames.Add(30,"Mewtwo δ");
CardDataNames.Add(31,"Nosepass");
CardDataNames.Add(32,"Nosepass Holofoil");
CardDataNames.Add(33,"Nosepass Reverse Holo");
CardDataNames.Add(34,"Rayquaza δ");
CardDataNames.Add(35,"Regice");
CardDataNames.Add(36,"Regice Holofoil");
CardDataNames.Add(37,"Regice Reverse Holo");
CardDataNames.Add(38,"Regirock");
CardDataNames.Add(39,"Regirock Holofoil");
CardDataNames.Add(40,"Regirock Reverse Holo");
CardDataNames.Add(41,"Registeel");
CardDataNames.Add(42,"Registeel Holofoil");
CardDataNames.Add(43,"Registeel Reverse Holo");
CardDataNames.Add(44,"Relicanth");
CardDataNames.Add(45,"Relicanth Holofoil");
CardDataNames.Add(46,"Relicanth Reverse Holo");
CardDataNames.Add(47,"Sableye");
CardDataNames.Add(48,"Sableye Holofoil");
CardDataNames.Add(49,"Sableye Reverse Holo");
CardDataNames.Add(50,"Seviper");
CardDataNames.Add(51,"Seviper Holofoil");
CardDataNames.Add(52,"Seviper Reverse Holo");
CardDataNames.Add(53,"Torkoal");
CardDataNames.Add(54,"Torkoal Holofoil");
CardDataNames.Add(55,"Torkoal Reverse Holo");
CardDataNames.Add(56,"Zangoose");
CardDataNames.Add(57,"Zangoose Holofoil");
CardDataNames.Add(58,"Zangoose Reverse Holo");
CardDataNames.Add(59,"Aerodactyl δ");
CardDataNames.Add(60,"Camerupt");
CardDataNames.Add(61,"Camerupt Holofoil");
CardDataNames.Add(62,"Camerupt Reverse Holo");
CardDataNames.Add(63,"Chimecho δ");
CardDataNames.Add(64,"Claydol");
CardDataNames.Add(65,"Claydol Holofoil");
CardDataNames.Add(66,"Claydol Reverse Holo");
CardDataNames.Add(67,"Combusken");
CardDataNames.Add(68,"Combusken Holofoil");
CardDataNames.Add(69,"Combusken Reverse Holo");
CardDataNames.Add(70,"Donphan");
CardDataNames.Add(71,"Donphan Holofoil");
CardDataNames.Add(72,"Donphan Reverse Holo");
CardDataNames.Add(73,"Exeggutor δ");
CardDataNames.Add(74,"Gloom δ");
CardDataNames.Add(75,"Golduck δ");
CardDataNames.Add(76,"Holon's Castform");
CardDataNames.Add(77,"Holon's Castform Holofoil");
CardDataNames.Add(78,"Holon's Castform Reverse Holo");
CardDataNames.Add(79,"Lairon");
CardDataNames.Add(80,"Lairon Holofoil");
CardDataNames.Add(81,"Lairon Reverse Holo");
CardDataNames.Add(82,"Manectric");
CardDataNames.Add(83,"Manectric Holofoil");
CardDataNames.Add(84,"Manectric Reverse Holo");
CardDataNames.Add(85,"Masquerain");
CardDataNames.Add(86,"Masquerain Holofoil");
CardDataNames.Add(87,"Masquerain Reverse Holo");
CardDataNames.Add(88,"Persian δ");
CardDataNames.Add(89,"Pidgeotto δ");
CardDataNames.Add(90,"Primeape δ");
CardDataNames.Add(91,"Raichu");
CardDataNames.Add(92,"Raichu Holofoil");
CardDataNames.Add(93,"Raichu Reverse Holo");
CardDataNames.Add(94,"Seadra δ");
CardDataNames.Add(95,"Sharpedo δ");
CardDataNames.Add(96,"Vibrava δ");
CardDataNames.Add(97,"Whiscash");
CardDataNames.Add(98,"Whiscash Holofoil");
CardDataNames.Add(99,"Whiscash Reverse Holo");
CardDataNames.Add(100,"Wobbuffet");
CardDataNames.Add(101,"Wobbuffet Holofoil");
CardDataNames.Add(102,"Wobbuffet Reverse Holo");
CardDataNames.Add(103,"Anorith δ");
CardDataNames.Add(104,"Aron");
CardDataNames.Add(105,"Aron Holofoil");
CardDataNames.Add(106,"Aron Reverse Holo");
CardDataNames.Add(107,"Baltoy");
CardDataNames.Add(108,"Baltoy Holofoil");
CardDataNames.Add(109,"Baltoy Reverse Holo");
CardDataNames.Add(110,"Barboach");
CardDataNames.Add(111,"Barboach Holofoil");
CardDataNames.Add(112,"Barboach Reverse Holo");
CardDataNames.Add(113,"Carvanha δ");
CardDataNames.Add(114,"Corphish");
CardDataNames.Add(115,"Corphish Holofoil");
CardDataNames.Add(116,"Corphish Reverse Holo");
CardDataNames.Add(117,"Corphish");
CardDataNames.Add(118,"Corphish Holofoil");
CardDataNames.Add(119,"Corphish Reverse Holo");
CardDataNames.Add(120,"Electrike");
CardDataNames.Add(121,"Electrike Holofoil");
CardDataNames.Add(122,"Electrike Reverse Holo");
CardDataNames.Add(123,"Exeggcute δ");
CardDataNames.Add(124,"Horsea δ");
CardDataNames.Add(125,"Kabuto δ");
CardDataNames.Add(126,"Lileep δ");
CardDataNames.Add(127,"Magikarp δ");
CardDataNames.Add(128,"Mankey δ");
CardDataNames.Add(129,"Meowth δ");
CardDataNames.Add(130,"Numel");
CardDataNames.Add(131,"Numel Holofoil");
CardDataNames.Add(132,"Numel Reverse Holo");
CardDataNames.Add(133,"Oddish δ");
CardDataNames.Add(134,"Omanyte δ");
CardDataNames.Add(135,"Phanpy");
CardDataNames.Add(136,"Phanpy Holofoil");
CardDataNames.Add(137,"Phanpy Reverse Holo");
CardDataNames.Add(138,"Pichu δ");
CardDataNames.Add(139,"Pidgey δ");
CardDataNames.Add(140,"Pikachu");
CardDataNames.Add(141,"Pikachu Holofoil");
CardDataNames.Add(142,"Pikachu Reverse Holo");
CardDataNames.Add(143,"Pikachu δ");
CardDataNames.Add(144,"Poochyena");
CardDataNames.Add(145,"Poochyena Holofoil");
CardDataNames.Add(146,"Poochyena Reverse Holo");
CardDataNames.Add(147,"Psyduck δ");
CardDataNames.Add(148,"Surskit");
CardDataNames.Add(149,"Surskit Holofoil");
CardDataNames.Add(150,"Surskit Reverse Holo");
CardDataNames.Add(151,"Torchic");
CardDataNames.Add(152,"Torchic Holofoil");
CardDataNames.Add(153,"Torchic Reverse Holo");
CardDataNames.Add(154,"Trapinch δ");
CardDataNames.Add(155,"Holon Adventurer");
CardDataNames.Add(156,"Holon Adventurer Holofoil");
CardDataNames.Add(157,"Holon Adventurer Reverse Holo");
CardDataNames.Add(158,"Holon Fossil");
CardDataNames.Add(159,"Holon Fossil Holofoil");
CardDataNames.Add(160,"Holon Fossil Reverse Holo");
CardDataNames.Add(161,"Holon Lake");
CardDataNames.Add(162,"Holon Lake Holofoil");
CardDataNames.Add(163,"Holon Lake Reverse Holo");
CardDataNames.Add(164,"Mr Stone's Project");
CardDataNames.Add(165,"Mr Stone's Project Holofoil");
CardDataNames.Add(166,"Mr Stone's Project Reverse Holo");
CardDataNames.Add(167,"Professor Cozmo's Discovery");
CardDataNames.Add(168,"Professor Cozmo's Discovery Holofoil");
CardDataNames.Add(169,"Professor Cozmo's Discovery Reverse Holo");
CardDataNames.Add(170,"Rare Candy");
CardDataNames.Add(171,"Rare Candy Holofoil");
CardDataNames.Add(172,"Rare Candy Reverse Holo");
CardDataNames.Add(173,"Claw Fossil");
CardDataNames.Add(174,"Claw Fossil Holofoil");
CardDataNames.Add(175,"Claw Fossil Reverse Holo");
CardDataNames.Add(176,"Mysterious Fossil");
CardDataNames.Add(177,"Mysterious Fossil Holofoil");
CardDataNames.Add(178,"Mysterious Fossil Reverse Holo");
CardDataNames.Add(179,"Root Fossil");
CardDataNames.Add(180,"Root Fossil Holofoil");
CardDataNames.Add(181,"Root Fossil Reverse Holo");
CardDataNames.Add(182,"Darkness Energy");
CardDataNames.Add(183,"Darkness Energy Holofoil");
CardDataNames.Add(184,"Darkness Energy Reverse Holo");
CardDataNames.Add(185,"Metal Energy");
CardDataNames.Add(186,"Metal Energy Holofoil");
CardDataNames.Add(187,"Metal Energy Reverse Holo");
CardDataNames.Add(188,"Multi Energy");
CardDataNames.Add(189,"Multi Energy Holofoil");
CardDataNames.Add(190,"Multi Energy Reverse Holo");
CardDataNames.Add(191,"Dark Metal Energy");
CardDataNames.Add(192,"Dark Metal Energy Holofoil");
CardDataNames.Add(193,"Dark Metal Energy Reverse Holo");
CardDataNames.Add(194,"δ Rainbow Energy");
CardDataNames.Add(195,"δ Rainbow Energy Holofoil");
CardDataNames.Add(196,"δ Rainbow Energy Reverse Holo");
CardDataNames.Add(197,"Crawdaunt ex");
CardDataNames.Add(198,"Mew ex");
CardDataNames.Add(199,"Mightyena ex");
CardDataNames.Add(200,"Gyarados δ");
CardDataNames.Add(201,"Mewtwo");
CardDataNames.Add(202,"Mewtwo Holofoil");
CardDataNames.Add(203,"Mewtwo Reverse Holo");
CardDataNames.Add(204,"Pikachu");
CardDataNames.Add(205,"Pikachu Holofoil");
CardDataNames.Add(206,"Pikachu Reverse Holo");
CardDataNames.Add(207,"Grass");
CardDataNames.Add(208,"Grass Holofoil");
CardDataNames.Add(209,"Grass Reverse Holo");
CardDataNames.Add(210,"Fire");
CardDataNames.Add(211,"Fire Holofoil");
CardDataNames.Add(212,"Fire Reverse Holo");
CardDataNames.Add(213,"Water");
CardDataNames.Add(214,"Water Holofoil");
CardDataNames.Add(215,"Water Reverse Holo");
CardDataNames.Add(216,"Lightning");
CardDataNames.Add(217,"Lightning Holofoil");
CardDataNames.Add(218,"Lightning Reverse Holo");
CardDataNames.Add(219,"Psychic");
CardDataNames.Add(220,"Psychic Holofoil");
CardDataNames.Add(221,"Psychic Reverse Holo");
CardDataNames.Add(222,"Fighting");
CardDataNames.Add(223,"Fighting Holofoil");
CardDataNames.Add(224,"Fighting Reverse Holo");
CardDataNames.Add(225,"Mew");
CardDataNames.Add(226,"Mew Holofoil");
CardDataNames.Add(227,"Mew Reverse Holo");
	}

	public void SetCardValues() {
CardDataValues.Add(1,9.87);
CardDataValues.Add(2,3.26);
CardDataValues.Add(3,16.4);
CardDataValues.Add(4,13.03);
CardDataValues.Add(5,20.71);
CardDataValues.Add(6,19.68);
CardDataValues.Add(7,16.4);
CardDataValues.Add(8,63.04);
CardDataValues.Add(9,15.52);
CardDataValues.Add(10,17.44);
CardDataValues.Add(11,23.65);
CardDataValues.Add(12,15.59);
CardDataValues.Add(13,8.14);
CardDataValues.Add(14,13.66);
CardDataValues.Add(15,20.79);
CardDataValues.Add(16,39.06);
CardDataValues.Add(17,9.78);
CardDataValues.Add(18,1.89);
CardDataValues.Add(19,9.072);
CardDataValues.Add(20,4.536);
CardDataValues.Add(21,1.25);
CardDataValues.Add(22,3.99);
CardDataValues.Add(23,19.152);
CardDataValues.Add(24,9.576);
CardDataValues.Add(25,3.99);
CardDataValues.Add(26,4.83);
CardDataValues.Add(27,1.99);
CardDataValues.Add(28,9.552);
CardDataValues.Add(29,4.776);
CardDataValues.Add(30,11.69);
CardDataValues.Add(31,0.99);
CardDataValues.Add(32,4.752);
CardDataValues.Add(33,2.376);
CardDataValues.Add(34,20.92);
CardDataValues.Add(35,4.29);
CardDataValues.Add(36,20.592);
CardDataValues.Add(37,10.296);
CardDataValues.Add(38,2.4);
CardDataValues.Add(39,11.52);
CardDataValues.Add(40,5.76);
CardDataValues.Add(41,2.91);
CardDataValues.Add(42,13.968);
CardDataValues.Add(43,6.984);
CardDataValues.Add(44,1.69);
CardDataValues.Add(45,8.112);
CardDataValues.Add(46,4.056);
CardDataValues.Add(47,1.54);
CardDataValues.Add(48,7.392);
CardDataValues.Add(49,3.696);
CardDataValues.Add(50,0.96);
CardDataValues.Add(51,4.608);
CardDataValues.Add(52,2.304);
CardDataValues.Add(53,1.59);
CardDataValues.Add(54,7.632);
CardDataValues.Add(55,3.816);
CardDataValues.Add(56,0.8);
CardDataValues.Add(57,3.84);
CardDataValues.Add(58,1.92);
CardDataValues.Add(59,9.92);
CardDataValues.Add(60,0.7);
CardDataValues.Add(61,3.36);
CardDataValues.Add(62,1.68);
CardDataValues.Add(63,1);
CardDataValues.Add(64,0.5);
CardDataValues.Add(65,2.4);
CardDataValues.Add(66,1.2);
CardDataValues.Add(67,0.6);
CardDataValues.Add(68,2.88);
CardDataValues.Add(69,1.44);
CardDataValues.Add(70,0.94);
CardDataValues.Add(71,4.512);
CardDataValues.Add(72,2.256);
CardDataValues.Add(73,1.57);
CardDataValues.Add(74,0.75);
CardDataValues.Add(75,1.97);
CardDataValues.Add(76,4.63);
CardDataValues.Add(77,22.224);
CardDataValues.Add(78,11.112);
CardDataValues.Add(79,0.75);
CardDataValues.Add(80,3.6);
CardDataValues.Add(81,1.8);
CardDataValues.Add(82,0.79);
CardDataValues.Add(83,3.792);
CardDataValues.Add(84,1.896);
CardDataValues.Add(85,0.84);
CardDataValues.Add(86,4.032);
CardDataValues.Add(87,2.016);
CardDataValues.Add(88,1.02);
CardDataValues.Add(89,1.99);
CardDataValues.Add(90,0.87);
CardDataValues.Add(91,3.01);
CardDataValues.Add(92,14.448);
CardDataValues.Add(93,7.224);
CardDataValues.Add(94,2.5);
CardDataValues.Add(95,1);
CardDataValues.Add(96,0.99);
CardDataValues.Add(97,0.5);
CardDataValues.Add(98,2.4);
CardDataValues.Add(99,1.2);
CardDataValues.Add(100,0.8);
CardDataValues.Add(101,3.84);
CardDataValues.Add(102,1.92);
CardDataValues.Add(103,0.58);
CardDataValues.Add(104,0.4);
CardDataValues.Add(105,1.92);
CardDataValues.Add(106,0.96);
CardDataValues.Add(107,0.37);
CardDataValues.Add(108,1.776);
CardDataValues.Add(109,0.888);
CardDataValues.Add(110,0.4);
CardDataValues.Add(111,1.92);
CardDataValues.Add(112,0.96);
CardDataValues.Add(113,0.48);
CardDataValues.Add(114,0.34);
CardDataValues.Add(115,1.632);
CardDataValues.Add(116,0.816);
CardDataValues.Add(117,0.35);
CardDataValues.Add(118,1.68);
CardDataValues.Add(119,0.84);
CardDataValues.Add(120,0.41);
CardDataValues.Add(121,1.968);
CardDataValues.Add(122,0.984);
CardDataValues.Add(123,0.41);
CardDataValues.Add(124,0.53);
CardDataValues.Add(125,0.51);
CardDataValues.Add(126,0.49);
CardDataValues.Add(127,0.94);
CardDataValues.Add(128,0.49);
CardDataValues.Add(129,0.87);
CardDataValues.Add(130,0.4);
CardDataValues.Add(131,1.92);
CardDataValues.Add(132,0.96);
CardDataValues.Add(133,0.7);
CardDataValues.Add(134,0.5);
CardDataValues.Add(135,0.5);
CardDataValues.Add(136,2.4);
CardDataValues.Add(137,1.2);
CardDataValues.Add(138,4);
CardDataValues.Add(139,0.7);
CardDataValues.Add(140,2.97);
CardDataValues.Add(141,14.256);
CardDataValues.Add(142,7.128);
CardDataValues.Add(143,3.26);
CardDataValues.Add(144,0.49);
CardDataValues.Add(145,2.352);
CardDataValues.Add(146,1.176);
CardDataValues.Add(147,1.24);
CardDataValues.Add(148,0.44);
CardDataValues.Add(149,2.112);
CardDataValues.Add(150,1.056);
CardDataValues.Add(151,0.38);
CardDataValues.Add(152,1.824);
CardDataValues.Add(153,0.912);
CardDataValues.Add(154,0.5);
CardDataValues.Add(155,0.69);
CardDataValues.Add(156,3.312);
CardDataValues.Add(157,1.656);
CardDataValues.Add(158,0.67);
CardDataValues.Add(159,3.216);
CardDataValues.Add(160,1.608);
CardDataValues.Add(161,0.45);
CardDataValues.Add(162,2.16);
CardDataValues.Add(163,1.08);
CardDataValues.Add(164,0.5);
CardDataValues.Add(165,2.4);
CardDataValues.Add(166,1.2);
CardDataValues.Add(167,0.5);
CardDataValues.Add(168,2.4);
CardDataValues.Add(169,1.2);
CardDataValues.Add(170,3.99);
CardDataValues.Add(171,19.152);
CardDataValues.Add(172,9.576);
CardDataValues.Add(173,0.36);
CardDataValues.Add(174,1.728);
CardDataValues.Add(175,0.864);
CardDataValues.Add(176,0.4);
CardDataValues.Add(177,1.92);
CardDataValues.Add(178,0.96);
CardDataValues.Add(179,0.4);
CardDataValues.Add(180,1.92);
CardDataValues.Add(181,0.96);
CardDataValues.Add(182,1.97);
CardDataValues.Add(183,9.456);
CardDataValues.Add(184,4.728);
CardDataValues.Add(185,1.3);
CardDataValues.Add(186,6.24);
CardDataValues.Add(187,3.12);
CardDataValues.Add(188,1.42);
CardDataValues.Add(189,6.816);
CardDataValues.Add(190,3.408);
CardDataValues.Add(191,1.49);
CardDataValues.Add(192,7.152);
CardDataValues.Add(193,3.576);
CardDataValues.Add(194,1.14);
CardDataValues.Add(195,5.472);
CardDataValues.Add(196,2.736);
CardDataValues.Add(197,39.98);
CardDataValues.Add(198,133.55);
CardDataValues.Add(199,39.47);
CardDataValues.Add(200,260);
CardDataValues.Add(201,199.99);
CardDataValues.Add(202,959.952);
CardDataValues.Add(203,479.976);
CardDataValues.Add(204,500);
CardDataValues.Add(205,2400);
CardDataValues.Add(206,1200);
CardDataValues.Add(207,5.31);
CardDataValues.Add(208,25.488);
CardDataValues.Add(209,12.744);
CardDataValues.Add(210,5.54);
CardDataValues.Add(211,26.592);
CardDataValues.Add(212,13.296);
CardDataValues.Add(213,7.77);
CardDataValues.Add(214,37.296);
CardDataValues.Add(215,18.648);
CardDataValues.Add(216,5.87);
CardDataValues.Add(217,28.176);
CardDataValues.Add(218,14.088);
CardDataValues.Add(219,5.66);
CardDataValues.Add(220,27.168);
CardDataValues.Add(221,13.584);
CardDataValues.Add(222,3.49);
CardDataValues.Add(223,16.752);
CardDataValues.Add(224,8.376);
CardDataValues.Add(225,96.29);
CardDataValues.Add(226,462.192);
CardDataValues.Add(227,231.096);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}