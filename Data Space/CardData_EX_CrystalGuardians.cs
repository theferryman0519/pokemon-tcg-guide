using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_EX_CrystalGuardians : MonoBehaviour {
		
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
CardDataNumbers.Add(5,"3");
CardDataNumbers.Add(6,"3H");
CardDataNumbers.Add(7,"3RH");
CardDataNumbers.Add(8,"4");
CardDataNumbers.Add(9,"5");
CardDataNumbers.Add(10,"5H");
CardDataNumbers.Add(11,"5RH");
CardDataNumbers.Add(12,"6");
CardDataNumbers.Add(13,"7");
CardDataNumbers.Add(14,"7H");
CardDataNumbers.Add(15,"7RH");
CardDataNumbers.Add(16,"8");
CardDataNumbers.Add(17,"8H");
CardDataNumbers.Add(18,"8RH");
CardDataNumbers.Add(19,"9");
CardDataNumbers.Add(20,"9H");
CardDataNumbers.Add(21,"9RH");
CardDataNumbers.Add(22,"10");
CardDataNumbers.Add(23,"10H");
CardDataNumbers.Add(24,"10RH");
CardDataNumbers.Add(25,"11");
CardDataNumbers.Add(26,"11H");
CardDataNumbers.Add(27,"11RH");
CardDataNumbers.Add(28,"12");
CardDataNumbers.Add(29,"12H");
CardDataNumbers.Add(30,"12RH");
CardDataNumbers.Add(31,"13");
CardDataNumbers.Add(32,"13H");
CardDataNumbers.Add(33,"13RH");
CardDataNumbers.Add(34,"14");
CardDataNumbers.Add(35,"14H");
CardDataNumbers.Add(36,"14RH");
CardDataNumbers.Add(37,"15");
CardDataNumbers.Add(38,"16");
CardDataNumbers.Add(39,"16H");
CardDataNumbers.Add(40,"16RH");
CardDataNumbers.Add(41,"17");
CardDataNumbers.Add(42,"17H");
CardDataNumbers.Add(43,"17RH");
CardDataNumbers.Add(44,"18");
CardDataNumbers.Add(45,"19");
CardDataNumbers.Add(46,"20");
CardDataNumbers.Add(47,"20H");
CardDataNumbers.Add(48,"20RH");
CardDataNumbers.Add(49,"21");
CardDataNumbers.Add(50,"21H");
CardDataNumbers.Add(51,"21RH");
CardDataNumbers.Add(52,"22");
CardDataNumbers.Add(53,"23");
CardDataNumbers.Add(54,"23H");
CardDataNumbers.Add(55,"23RH");
CardDataNumbers.Add(56,"24");
CardDataNumbers.Add(57,"24H");
CardDataNumbers.Add(58,"24RH");
CardDataNumbers.Add(59,"25");
CardDataNumbers.Add(60,"25H");
CardDataNumbers.Add(61,"25RH");
CardDataNumbers.Add(62,"26");
CardDataNumbers.Add(63,"27");
CardDataNumbers.Add(64,"27H");
CardDataNumbers.Add(65,"27RH");
CardDataNumbers.Add(66,"28");
CardDataNumbers.Add(67,"28H");
CardDataNumbers.Add(68,"28RH");
CardDataNumbers.Add(69,"29");
CardDataNumbers.Add(70,"29H");
CardDataNumbers.Add(71,"29RH");
CardDataNumbers.Add(72,"30");
CardDataNumbers.Add(73,"31");
CardDataNumbers.Add(74,"31H");
CardDataNumbers.Add(75,"31RH");
CardDataNumbers.Add(76,"32");
CardDataNumbers.Add(77,"32H");
CardDataNumbers.Add(78,"32RH");
CardDataNumbers.Add(79,"33");
CardDataNumbers.Add(80,"33H");
CardDataNumbers.Add(81,"33RH");
CardDataNumbers.Add(82,"34");
CardDataNumbers.Add(83,"34H");
CardDataNumbers.Add(84,"34RH");
CardDataNumbers.Add(85,"35");
CardDataNumbers.Add(86,"35H");
CardDataNumbers.Add(87,"35RH");
CardDataNumbers.Add(88,"36");
CardDataNumbers.Add(89,"36H");
CardDataNumbers.Add(90,"36RH");
CardDataNumbers.Add(91,"37");
CardDataNumbers.Add(92,"37H");
CardDataNumbers.Add(93,"37RH");
CardDataNumbers.Add(94,"38");
CardDataNumbers.Add(95,"38H");
CardDataNumbers.Add(96,"38RH");
CardDataNumbers.Add(97,"39");
CardDataNumbers.Add(98,"39H");
CardDataNumbers.Add(99,"39RH");
CardDataNumbers.Add(100,"40");
CardDataNumbers.Add(101,"40H");
CardDataNumbers.Add(102,"40RH");
CardDataNumbers.Add(103,"41");
CardDataNumbers.Add(104,"41H");
CardDataNumbers.Add(105,"41RH");
CardDataNumbers.Add(106,"42");
CardDataNumbers.Add(107,"42H");
CardDataNumbers.Add(108,"42RH");
CardDataNumbers.Add(109,"43");
CardDataNumbers.Add(110,"43H");
CardDataNumbers.Add(111,"43RH");
CardDataNumbers.Add(112,"44");
CardDataNumbers.Add(113,"44H");
CardDataNumbers.Add(114,"44RH");
CardDataNumbers.Add(115,"45");
CardDataNumbers.Add(116,"45H");
CardDataNumbers.Add(117,"45RH");
CardDataNumbers.Add(118,"46");
CardDataNumbers.Add(119,"46H");
CardDataNumbers.Add(120,"46RH");
CardDataNumbers.Add(121,"47");
CardDataNumbers.Add(122,"47H");
CardDataNumbers.Add(123,"47RH");
CardDataNumbers.Add(124,"48");
CardDataNumbers.Add(125,"48H");
CardDataNumbers.Add(126,"48RH");
CardDataNumbers.Add(127,"49");
CardDataNumbers.Add(128,"50");
CardDataNumbers.Add(129,"50H");
CardDataNumbers.Add(130,"50RH");
CardDataNumbers.Add(131,"51");
CardDataNumbers.Add(132,"51H");
CardDataNumbers.Add(133,"51RH");
CardDataNumbers.Add(134,"52");
CardDataNumbers.Add(135,"52H");
CardDataNumbers.Add(136,"52RH");
CardDataNumbers.Add(137,"53");
CardDataNumbers.Add(138,"53H");
CardDataNumbers.Add(139,"53RH");
CardDataNumbers.Add(140,"54");
CardDataNumbers.Add(141,"54H");
CardDataNumbers.Add(142,"54RH");
CardDataNumbers.Add(143,"55");
CardDataNumbers.Add(144,"55H");
CardDataNumbers.Add(145,"55RH");
CardDataNumbers.Add(146,"56");
CardDataNumbers.Add(147,"56H");
CardDataNumbers.Add(148,"56RH");
CardDataNumbers.Add(149,"57");
CardDataNumbers.Add(150,"57H");
CardDataNumbers.Add(151,"57RH");
CardDataNumbers.Add(152,"58");
CardDataNumbers.Add(153,"58H");
CardDataNumbers.Add(154,"58RH");
CardDataNumbers.Add(155,"59");
CardDataNumbers.Add(156,"59H");
CardDataNumbers.Add(157,"59RH");
CardDataNumbers.Add(158,"60");
CardDataNumbers.Add(159,"60H");
CardDataNumbers.Add(160,"60RH");
CardDataNumbers.Add(161,"61");
CardDataNumbers.Add(162,"61H");
CardDataNumbers.Add(163,"61RH");
CardDataNumbers.Add(164,"62");
CardDataNumbers.Add(165,"62H");
CardDataNumbers.Add(166,"62RH");
CardDataNumbers.Add(167,"63");
CardDataNumbers.Add(168,"63H");
CardDataNumbers.Add(169,"63RH");
CardDataNumbers.Add(170,"64");
CardDataNumbers.Add(171,"64H");
CardDataNumbers.Add(172,"64RH");
CardDataNumbers.Add(173,"65");
CardDataNumbers.Add(174,"65H");
CardDataNumbers.Add(175,"65RH");
CardDataNumbers.Add(176,"66");
CardDataNumbers.Add(177,"66H");
CardDataNumbers.Add(178,"66RH");
CardDataNumbers.Add(179,"67");
CardDataNumbers.Add(180,"67H");
CardDataNumbers.Add(181,"67RH");
CardDataNumbers.Add(182,"68");
CardDataNumbers.Add(183,"69");
CardDataNumbers.Add(184,"69H");
CardDataNumbers.Add(185,"69RH");
CardDataNumbers.Add(186,"70");
CardDataNumbers.Add(187,"70H");
CardDataNumbers.Add(188,"70RH");
CardDataNumbers.Add(189,"71");
CardDataNumbers.Add(190,"71H");
CardDataNumbers.Add(191,"71RH");
CardDataNumbers.Add(192,"72");
CardDataNumbers.Add(193,"72H");
CardDataNumbers.Add(194,"72RH");
CardDataNumbers.Add(195,"73");
CardDataNumbers.Add(196,"73H");
CardDataNumbers.Add(197,"73RH");
CardDataNumbers.Add(198,"74");
CardDataNumbers.Add(199,"74H");
CardDataNumbers.Add(200,"74RH");
CardDataNumbers.Add(201,"75");
CardDataNumbers.Add(202,"75H");
CardDataNumbers.Add(203,"75RH");
CardDataNumbers.Add(204,"76");
CardDataNumbers.Add(205,"76H");
CardDataNumbers.Add(206,"76RH");
CardDataNumbers.Add(207,"77");
CardDataNumbers.Add(208,"77H");
CardDataNumbers.Add(209,"77RH");
CardDataNumbers.Add(210,"78");
CardDataNumbers.Add(211,"78H");
CardDataNumbers.Add(212,"78RH");
CardDataNumbers.Add(213,"79");
CardDataNumbers.Add(214,"79H");
CardDataNumbers.Add(215,"79RH");
CardDataNumbers.Add(216,"80");
CardDataNumbers.Add(217,"80H");
CardDataNumbers.Add(218,"80RH");
CardDataNumbers.Add(219,"81");
CardDataNumbers.Add(220,"81H");
CardDataNumbers.Add(221,"81RH");
CardDataNumbers.Add(222,"82");
CardDataNumbers.Add(223,"82H");
CardDataNumbers.Add(224,"82RH");
CardDataNumbers.Add(225,"83");
CardDataNumbers.Add(226,"83H");
CardDataNumbers.Add(227,"83RH");
CardDataNumbers.Add(228,"84");
CardDataNumbers.Add(229,"84H");
CardDataNumbers.Add(230,"84RH");
CardDataNumbers.Add(231,"85");
CardDataNumbers.Add(232,"85H");
CardDataNumbers.Add(233,"85RH");
CardDataNumbers.Add(234,"86");
CardDataNumbers.Add(235,"86H");
CardDataNumbers.Add(236,"86RH");
CardDataNumbers.Add(237,"87");
CardDataNumbers.Add(238,"87H");
CardDataNumbers.Add(239,"87RH");
CardDataNumbers.Add(240,"88");
CardDataNumbers.Add(241,"88H");
CardDataNumbers.Add(242,"88RH");
CardDataNumbers.Add(243,"89");
CardDataNumbers.Add(244,"90");
CardDataNumbers.Add(245,"91");
CardDataNumbers.Add(246,"92");
CardDataNumbers.Add(247,"93");
CardDataNumbers.Add(248,"94");
CardDataNumbers.Add(249,"95");
CardDataNumbers.Add(250,"96");
CardDataNumbers.Add(251,"97");
CardDataNumbers.Add(252,"98");
CardDataNumbers.Add(253,"99");
CardDataNumbers.Add(254,"99H");
CardDataNumbers.Add(255,"99RH");
CardDataNumbers.Add(256,"100");
CardDataNumbers.Add(257,"100H");
CardDataNumbers.Add(258,"100RH");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Banette");
CardDataNames.Add(2,"Banette Holofoil");
CardDataNames.Add(3,"Banette Reverse Holo");
CardDataNames.Add(4,"Blastoise δ");
CardDataNames.Add(5,"Camerupt");
CardDataNames.Add(6,"Camerupt Holofoil");
CardDataNames.Add(7,"Camerupt Reverse Holo");
CardDataNames.Add(8,"Charizard δ");
CardDataNames.Add(9,"Dugtrio");
CardDataNames.Add(10,"Dugtrio Holofoil");
CardDataNames.Add(11,"Dugtrio Reverse Holo");
CardDataNames.Add(12,"Ludicolo δ");
CardDataNames.Add(13,"Luvdisc");
CardDataNames.Add(14,"Luvdisc Holofoil");
CardDataNames.Add(15,"Luvdisc Reverse Holo");
CardDataNames.Add(16,"Manectric");
CardDataNames.Add(17,"Manectric Holofoil");
CardDataNames.Add(18,"Manectric Reverse Holo");
CardDataNames.Add(19,"Mawile");
CardDataNames.Add(20,"Mawile Holofoil");
CardDataNames.Add(21,"Mawile Reverse Holo");
CardDataNames.Add(22,"Sableye");
CardDataNames.Add(23,"Sableye Holofoil");
CardDataNames.Add(24,"Sableye Reverse Holo");
CardDataNames.Add(25,"Swalot");
CardDataNames.Add(26,"Swalot Holofoil");
CardDataNames.Add(27,"Swalot Reverse Holo");
CardDataNames.Add(28,"Tauros");
CardDataNames.Add(29,"Tauros Holofoil");
CardDataNames.Add(30,"Tauros Reverse Holo");
CardDataNames.Add(31,"Wigglytuff");
CardDataNames.Add(32,"Wigglytuff Holofoil");
CardDataNames.Add(33,"Wigglytuff Reverse Holo");
CardDataNames.Add(34,"Blastoise");
CardDataNames.Add(35,"Blastoise Holofoil");
CardDataNames.Add(36,"Blastoise Reverse Holo");
CardDataNames.Add(37,"Cacturne δ");
CardDataNames.Add(38,"Combusken");
CardDataNames.Add(39,"Combusken Holofoil");
CardDataNames.Add(40,"Combusken Reverse Holo");
CardDataNames.Add(41,"Dusclops");
CardDataNames.Add(42,"Dusclops Holofoil");
CardDataNames.Add(43,"Dusclops Reverse Holo");
CardDataNames.Add(44,"Fearow δ");
CardDataNames.Add(45,"Grovyle δ");
CardDataNames.Add(46,"Grumpig");
CardDataNames.Add(47,"Grumpig Holofoil");
CardDataNames.Add(48,"Grumpig Reverse Holo");
CardDataNames.Add(49,"Igglybuff");
CardDataNames.Add(50,"Igglybuff Holofoil");
CardDataNames.Add(51,"Igglybuff Reverse Holo");
CardDataNames.Add(52,"Kingler δ");
CardDataNames.Add(53,"Loudred");
CardDataNames.Add(54,"Loudred Holofoil");
CardDataNames.Add(55,"Loudred Reverse Holo");
CardDataNames.Add(56,"Marshtomp");
CardDataNames.Add(57,"Marshtomp Holofoil");
CardDataNames.Add(58,"Marshtomp Reverse Holo");
CardDataNames.Add(59,"Medicham");
CardDataNames.Add(60,"Medicham Holofoil");
CardDataNames.Add(61,"Medicham Reverse Holo");
CardDataNames.Add(62,"Pelipper δ");
CardDataNames.Add(63,"Swampert");
CardDataNames.Add(64,"Swampert Holofoil");
CardDataNames.Add(65,"Swampert Reverse Holo");
CardDataNames.Add(66,"Venusaur");
CardDataNames.Add(67,"Venusaur Holofoil");
CardDataNames.Add(68,"Venusaur Reverse Holo");
CardDataNames.Add(69,"Charmeleon");
CardDataNames.Add(70,"Charmeleon Holofoil");
CardDataNames.Add(71,"Charmeleon Reverse Holo");
CardDataNames.Add(72,"Charmeleon δ");
CardDataNames.Add(73,"Combusken");
CardDataNames.Add(74,"Combusken Holofoil");
CardDataNames.Add(75,"Combusken Reverse Holo");
CardDataNames.Add(76,"Grovyle");
CardDataNames.Add(77,"Grovyle Holofoil");
CardDataNames.Add(78,"Grovyle Reverse Holo");
CardDataNames.Add(79,"Gulpin");
CardDataNames.Add(80,"Gulpin Holofoil");
CardDataNames.Add(81,"Gulpin Reverse Holo");
CardDataNames.Add(82,"Ivysaur");
CardDataNames.Add(83,"Ivysaur Holofoil");
CardDataNames.Add(84,"Ivysaur Reverse Holo");
CardDataNames.Add(85,"Ivysaur");
CardDataNames.Add(86,"Ivysaur Holofoil");
CardDataNames.Add(87,"Ivysaur Reverse Holo");
CardDataNames.Add(88,"Lairon");
CardDataNames.Add(89,"Lairon Holofoil");
CardDataNames.Add(90,"Lairon Reverse Holo");
CardDataNames.Add(91,"Lombre");
CardDataNames.Add(92,"Lombre Holofoil");
CardDataNames.Add(93,"Lombre Reverse Holo");
CardDataNames.Add(94,"Marshtomp");
CardDataNames.Add(95,"Marshtomp Holofoil");
CardDataNames.Add(96,"Marshtomp Reverse Holo");
CardDataNames.Add(97,"Nuzleaf");
CardDataNames.Add(98,"Nuzleaf Holofoil");
CardDataNames.Add(99,"Nuzleaf Reverse Holo");
CardDataNames.Add(100,"Shuppet");
CardDataNames.Add(101,"Shuppet Holofoil");
CardDataNames.Add(102,"Shuppet Reverse Holo");
CardDataNames.Add(103,"Skitty");
CardDataNames.Add(104,"Skitty Holofoil");
CardDataNames.Add(105,"Skitty Reverse Holo");
CardDataNames.Add(106,"Wartortle");
CardDataNames.Add(107,"Wartortle Holofoil");
CardDataNames.Add(108,"Wartortle Reverse Holo");
CardDataNames.Add(109,"Wartortle");
CardDataNames.Add(110,"Wartortle Holofoil");
CardDataNames.Add(111,"Wartortle Reverse Holo");
CardDataNames.Add(112,"Aron");
CardDataNames.Add(113,"Aron Holofoil");
CardDataNames.Add(114,"Aron Reverse Holo");
CardDataNames.Add(115,"Bulbasaur");
CardDataNames.Add(116,"Bulbasaur Holofoil");
CardDataNames.Add(117,"Bulbasaur Reverse Holo");
CardDataNames.Add(118,"Bulbasaur");
CardDataNames.Add(119,"Bulbasaur Holofoil");
CardDataNames.Add(120,"Bulbasaur Reverse Holo");
CardDataNames.Add(121,"Cacnea");
CardDataNames.Add(122,"Cacnea Holofoil");
CardDataNames.Add(123,"Cacnea Reverse Holo");
CardDataNames.Add(124,"Charmander");
CardDataNames.Add(125,"Charmander Holofoil");
CardDataNames.Add(126,"Charmander Reverse Holo");
CardDataNames.Add(127,"Charmander δ");
CardDataNames.Add(128,"Diglett");
CardDataNames.Add(129,"Diglett Holofoil");
CardDataNames.Add(130,"Diglett Reverse Holo");
CardDataNames.Add(131,"Duskull");
CardDataNames.Add(132,"Duskull Holofoil");
CardDataNames.Add(133,"Duskull Reverse Holo");
CardDataNames.Add(134,"Electrike");
CardDataNames.Add(135,"Electrike Holofoil");
CardDataNames.Add(136,"Electrike Reverse Holo");
CardDataNames.Add(137,"Jigglypuff");
CardDataNames.Add(138,"Jigglypuff Holofoil");
CardDataNames.Add(139,"Jigglypuff Reverse Holo");
CardDataNames.Add(140,"Krabby");
CardDataNames.Add(141,"Krabby Holofoil");
CardDataNames.Add(142,"Krabby Reverse Holo");
CardDataNames.Add(143,"Lotad");
CardDataNames.Add(144,"Lotad Holofoil");
CardDataNames.Add(145,"Lotad Reverse Holo");
CardDataNames.Add(146,"Meditite");
CardDataNames.Add(147,"Meditite Holofoil");
CardDataNames.Add(148,"Meditite Reverse Holo");
CardDataNames.Add(149,"Mudkip");
CardDataNames.Add(150,"Mudkip Holofoil");
CardDataNames.Add(151,"Mudkip Reverse Holo");
CardDataNames.Add(152,"Mudkip");
CardDataNames.Add(153,"Mudkip Holofoil");
CardDataNames.Add(154,"Mudkip Reverse Holo");
CardDataNames.Add(155,"Numel");
CardDataNames.Add(156,"Numel Holofoil");
CardDataNames.Add(157,"Numel Reverse Holo");
CardDataNames.Add(158,"Seedot");
CardDataNames.Add(159,"Seedot Holofoil");
CardDataNames.Add(160,"Seedot Reverse Holo");
CardDataNames.Add(161,"Spearow");
CardDataNames.Add(162,"Spearow Holofoil");
CardDataNames.Add(163,"Spearow Reverse Holo");
CardDataNames.Add(164,"Spoink");
CardDataNames.Add(165,"Spoink Holofoil");
CardDataNames.Add(166,"Spoink Reverse Holo");
CardDataNames.Add(167,"Squirtle");
CardDataNames.Add(168,"Squirtle Holofoil");
CardDataNames.Add(169,"Squirtle Reverse Holo");
CardDataNames.Add(170,"Squirtle");
CardDataNames.Add(171,"Squirtle Holofoil");
CardDataNames.Add(172,"Squirtle Reverse Holo");
CardDataNames.Add(173,"Torchic");
CardDataNames.Add(174,"Torchic Holofoil");
CardDataNames.Add(175,"Torchic Reverse Holo");
CardDataNames.Add(176,"Torchic");
CardDataNames.Add(177,"Torchic Holofoil");
CardDataNames.Add(178,"Torchic Reverse Holo");
CardDataNames.Add(179,"Treecko");
CardDataNames.Add(180,"Treecko Holofoil");
CardDataNames.Add(181,"Treecko Reverse Holo");
CardDataNames.Add(182,"Treecko δ");
CardDataNames.Add(183,"Whismur");
CardDataNames.Add(184,"Whismur Holofoil");
CardDataNames.Add(185,"Whismur Reverse Holo");
CardDataNames.Add(186,"Wingull");
CardDataNames.Add(187,"Wingull Holofoil");
CardDataNames.Add(188,"Wingull Reverse Holo");
CardDataNames.Add(189,"Bill's Maintenance");
CardDataNames.Add(190,"Bill's Maintenance Holofoil");
CardDataNames.Add(191,"Bill's Maintenance Reverse Holo");
CardDataNames.Add(192,"Castaway");
CardDataNames.Add(193,"Castaway Holofoil");
CardDataNames.Add(194,"Castaway Reverse Holo");
CardDataNames.Add(195,"Celio's Network");
CardDataNames.Add(196,"Celio's Network Holofoil");
CardDataNames.Add(197,"Celio's Network Reverse Holo");
CardDataNames.Add(198,"Cessation Crystal");
CardDataNames.Add(199,"Cessation Crystal Holofoil");
CardDataNames.Add(200,"Cessation Crystal Reverse Holo");
CardDataNames.Add(201,"Crystal Beach");
CardDataNames.Add(202,"Crystal Beach Holofoil");
CardDataNames.Add(203,"Crystal Beach Reverse Holo");
CardDataNames.Add(204,"Crystal Shard");
CardDataNames.Add(205,"Crystal Shard Holofoil");
CardDataNames.Add(206,"Crystal Shard Reverse Holo");
CardDataNames.Add(207,"Double Full Heal");
CardDataNames.Add(208,"Double Full Heal Holofoil");
CardDataNames.Add(209,"Double Full Heal Reverse Holo");
CardDataNames.Add(210,"Dual Ball");
CardDataNames.Add(211,"Dual Ball Holofoil");
CardDataNames.Add(212,"Dual Ball Reverse Holo");
CardDataNames.Add(213,"Holon Circle");
CardDataNames.Add(214,"Holon Circle Holofoil");
CardDataNames.Add(215,"Holon Circle Reverse Holo");
CardDataNames.Add(216,"Memory Berry");
CardDataNames.Add(217,"Memory Berry Holofoil");
CardDataNames.Add(218,"Memory Berry Reverse Holo");
CardDataNames.Add(219,"Mysterious Shard");
CardDataNames.Add(220,"Mysterious Shard Holofoil");
CardDataNames.Add(221,"Mysterious Shard Reverse Holo");
CardDataNames.Add(222,"Poké Ball");
CardDataNames.Add(223,"Poké Ball Holofoil");
CardDataNames.Add(224,"Poké Ball Reverse Holo");
CardDataNames.Add(225,"PokéNav");
CardDataNames.Add(226,"PokéNav Holofoil");
CardDataNames.Add(227,"PokéNav Reverse Holo");
CardDataNames.Add(228,"Warp Point");
CardDataNames.Add(229,"Warp Point Holofoil");
CardDataNames.Add(230,"Warp Point Reverse Holo");
CardDataNames.Add(231,"Windstorm");
CardDataNames.Add(232,"Windstorm Holofoil");
CardDataNames.Add(233,"Windstorm Reverse Holo");
CardDataNames.Add(234,"Energy Search");
CardDataNames.Add(235,"Energy Search Holofoil");
CardDataNames.Add(236,"Energy Search Reverse Holo");
CardDataNames.Add(237,"Potion");
CardDataNames.Add(238,"Potion Holofoil");
CardDataNames.Add(239,"Potion Reverse Holo");
CardDataNames.Add(240,"Double Rainbow Energy");
CardDataNames.Add(241,"Double Rainbow Energy Holofoil");
CardDataNames.Add(242,"Double Rainbow Energy Reverse Holo");
CardDataNames.Add(243,"Aggron ex");
CardDataNames.Add(244,"Blaziken ex");
CardDataNames.Add(245,"Delcatty ex");
CardDataNames.Add(246,"Exploud ex");
CardDataNames.Add(247,"Groudon ex");
CardDataNames.Add(248,"Jirachi ex");
CardDataNames.Add(249,"Kyogre ex");
CardDataNames.Add(250,"Sceptile ex δ");
CardDataNames.Add(251,"Shiftry ex");
CardDataNames.Add(252,"Swampert ex");
CardDataNames.Add(253,"Alakazam");
CardDataNames.Add(254,"Alakazam Holofoil");
CardDataNames.Add(255,"Alakazam Reverse Holo");
CardDataNames.Add(256,"Celebi");
CardDataNames.Add(257,"Celebi Holofoil");
CardDataNames.Add(258,"Celebi Reverse Holo");
	}

	public void SetCardValues() {
CardDataValues.Add(1,4.64);
CardDataValues.Add(2,22.272);
CardDataValues.Add(3,11.136);
CardDataValues.Add(4,57.42);
CardDataValues.Add(5,2.51);
CardDataValues.Add(6,12.048);
CardDataValues.Add(7,6.024);
CardDataValues.Add(8,232);
CardDataValues.Add(9,5.74);
CardDataValues.Add(10,27.552);
CardDataValues.Add(11,13.776);
CardDataValues.Add(12,7.43);
CardDataValues.Add(13,2.65);
CardDataValues.Add(14,12.72);
CardDataValues.Add(15,6.36);
CardDataValues.Add(16,4.95);
CardDataValues.Add(17,23.76);
CardDataValues.Add(18,11.88);
CardDataValues.Add(19,5.23);
CardDataValues.Add(20,25.104);
CardDataValues.Add(21,12.552);
CardDataValues.Add(22,7.86);
CardDataValues.Add(23,37.728);
CardDataValues.Add(24,18.864);
CardDataValues.Add(25,2.68);
CardDataValues.Add(26,12.864);
CardDataValues.Add(27,6.432);
CardDataValues.Add(28,5.25);
CardDataValues.Add(29,25.2);
CardDataValues.Add(30,12.6);
CardDataValues.Add(31,4.91);
CardDataValues.Add(32,23.568);
CardDataValues.Add(33,11.784);
CardDataValues.Add(34,6.43);
CardDataValues.Add(35,30.864);
CardDataValues.Add(36,15.432);
CardDataValues.Add(37,1.21);
CardDataValues.Add(38,1.39);
CardDataValues.Add(39,6.672);
CardDataValues.Add(40,3.336);
CardDataValues.Add(41,0.96);
CardDataValues.Add(42,4.608);
CardDataValues.Add(43,2.304);
CardDataValues.Add(44,0.99);
CardDataValues.Add(45,1.47);
CardDataValues.Add(46,0.56);
CardDataValues.Add(47,2.688);
CardDataValues.Add(48,1.344);
CardDataValues.Add(49,0.99);
CardDataValues.Add(50,4.752);
CardDataValues.Add(51,2.376);
CardDataValues.Add(52,3.4);
CardDataValues.Add(53,0.52);
CardDataValues.Add(54,2.496);
CardDataValues.Add(55,1.248);
CardDataValues.Add(56,1.73);
CardDataValues.Add(57,8.304);
CardDataValues.Add(58,4.152);
CardDataValues.Add(59,0.61);
CardDataValues.Add(60,2.928);
CardDataValues.Add(61,1.464);
CardDataValues.Add(62,0.6);
CardDataValues.Add(63,2.23);
CardDataValues.Add(64,10.704);
CardDataValues.Add(65,5.352);
CardDataValues.Add(66,4.52);
CardDataValues.Add(67,21.696);
CardDataValues.Add(68,10.848);
CardDataValues.Add(69,1.61);
CardDataValues.Add(70,7.728);
CardDataValues.Add(71,3.864);
CardDataValues.Add(72,2.1);
CardDataValues.Add(73,0.5);
CardDataValues.Add(74,2.4);
CardDataValues.Add(75,1.2);
CardDataValues.Add(76,0.45);
CardDataValues.Add(77,2.16);
CardDataValues.Add(78,1.08);
CardDataValues.Add(79,0.4);
CardDataValues.Add(80,1.92);
CardDataValues.Add(81,0.96);
CardDataValues.Add(82,2.03);
CardDataValues.Add(83,9.744);
CardDataValues.Add(84,4.872);
CardDataValues.Add(85,1.85);
CardDataValues.Add(86,8.88);
CardDataValues.Add(87,4.44);
CardDataValues.Add(88,0.58);
CardDataValues.Add(89,2.784);
CardDataValues.Add(90,1.392);
CardDataValues.Add(91,0.49);
CardDataValues.Add(92,2.352);
CardDataValues.Add(93,1.176);
CardDataValues.Add(94,0.5);
CardDataValues.Add(95,2.4);
CardDataValues.Add(96,1.2);
CardDataValues.Add(97,0.75);
CardDataValues.Add(98,3.6);
CardDataValues.Add(99,1.8);
CardDataValues.Add(100,0.5);
CardDataValues.Add(101,2.4);
CardDataValues.Add(102,1.2);
CardDataValues.Add(103,0.53);
CardDataValues.Add(104,2.544);
CardDataValues.Add(105,1.272);
CardDataValues.Add(106,2.42);
CardDataValues.Add(107,11.616);
CardDataValues.Add(108,5.808);
CardDataValues.Add(109,1);
CardDataValues.Add(110,4.8);
CardDataValues.Add(111,2.4);
CardDataValues.Add(112,0.3);
CardDataValues.Add(113,1.44);
CardDataValues.Add(114,0.72);
CardDataValues.Add(115,1.87);
CardDataValues.Add(116,8.976);
CardDataValues.Add(117,4.488);
CardDataValues.Add(118,1.53);
CardDataValues.Add(119,7.344);
CardDataValues.Add(120,3.672);
CardDataValues.Add(121,0.47);
CardDataValues.Add(122,2.256);
CardDataValues.Add(123,1.128);
CardDataValues.Add(124,1);
CardDataValues.Add(125,4.8);
CardDataValues.Add(126,2.4);
CardDataValues.Add(127,2.9);
CardDataValues.Add(128,0.4);
CardDataValues.Add(129,1.92);
CardDataValues.Add(130,0.96);
CardDataValues.Add(131,0.31);
CardDataValues.Add(132,1.488);
CardDataValues.Add(133,0.744);
CardDataValues.Add(134,0.29);
CardDataValues.Add(135,1.392);
CardDataValues.Add(136,0.696);
CardDataValues.Add(137,0.47);
CardDataValues.Add(138,2.256);
CardDataValues.Add(139,1.128);
CardDataValues.Add(140,0.4);
CardDataValues.Add(141,1.92);
CardDataValues.Add(142,0.96);
CardDataValues.Add(143,0.37);
CardDataValues.Add(144,1.776);
CardDataValues.Add(145,0.888);
CardDataValues.Add(146,0.34);
CardDataValues.Add(147,1.632);
CardDataValues.Add(148,0.816);
CardDataValues.Add(149,0.74);
CardDataValues.Add(150,3.552);
CardDataValues.Add(151,1.776);
CardDataValues.Add(152,0.64);
CardDataValues.Add(153,3.072);
CardDataValues.Add(154,1.536);
CardDataValues.Add(155,0.32);
CardDataValues.Add(156,1.536);
CardDataValues.Add(157,0.768);
CardDataValues.Add(158,0.26);
CardDataValues.Add(159,1.248);
CardDataValues.Add(160,0.624);
CardDataValues.Add(161,0.25);
CardDataValues.Add(162,1.2);
CardDataValues.Add(163,0.6);
CardDataValues.Add(164,0.31);
CardDataValues.Add(165,1.488);
CardDataValues.Add(166,0.744);
CardDataValues.Add(167,1.17);
CardDataValues.Add(168,5.616);
CardDataValues.Add(169,2.808);
CardDataValues.Add(170,4.07);
CardDataValues.Add(171,19.536);
CardDataValues.Add(172,9.768);
CardDataValues.Add(173,0.46);
CardDataValues.Add(174,2.208);
CardDataValues.Add(175,1.104);
CardDataValues.Add(176,0.46);
CardDataValues.Add(177,2.208);
CardDataValues.Add(178,1.104);
CardDataValues.Add(179,0.4);
CardDataValues.Add(180,1.92);
CardDataValues.Add(181,0.96);
CardDataValues.Add(182,0.49);
CardDataValues.Add(183,0.26);
CardDataValues.Add(184,1.248);
CardDataValues.Add(185,0.624);
CardDataValues.Add(186,0.3);
CardDataValues.Add(187,1.44);
CardDataValues.Add(188,0.72);
CardDataValues.Add(189,0.33);
CardDataValues.Add(190,1.584);
CardDataValues.Add(191,0.792);
CardDataValues.Add(192,5.15);
CardDataValues.Add(193,24.72);
CardDataValues.Add(194,12.36);
CardDataValues.Add(195,0.49);
CardDataValues.Add(196,2.352);
CardDataValues.Add(197,1.176);
CardDataValues.Add(198,3.3);
CardDataValues.Add(199,15.84);
CardDataValues.Add(200,7.92);
CardDataValues.Add(201,2.49);
CardDataValues.Add(202,11.952);
CardDataValues.Add(203,5.976);
CardDataValues.Add(204,0.47);
CardDataValues.Add(205,2.256);
CardDataValues.Add(206,1.128);
CardDataValues.Add(207,0.42);
CardDataValues.Add(208,2.016);
CardDataValues.Add(209,1.008);
CardDataValues.Add(210,0.49);
CardDataValues.Add(211,2.352);
CardDataValues.Add(212,1.176);
CardDataValues.Add(213,0.75);
CardDataValues.Add(214,3.6);
CardDataValues.Add(215,1.8);
CardDataValues.Add(216,0.49);
CardDataValues.Add(217,2.352);
CardDataValues.Add(218,1.176);
CardDataValues.Add(219,0.46);
CardDataValues.Add(220,2.208);
CardDataValues.Add(221,1.104);
CardDataValues.Add(222,0.4);
CardDataValues.Add(223,1.92);
CardDataValues.Add(224,0.96);
CardDataValues.Add(225,0.44);
CardDataValues.Add(226,2.112);
CardDataValues.Add(227,1.056);
CardDataValues.Add(228,0.4);
CardDataValues.Add(229,1.92);
CardDataValues.Add(230,0.96);
CardDataValues.Add(231,5.93);
CardDataValues.Add(232,28.464);
CardDataValues.Add(233,14.232);
CardDataValues.Add(234,0.25);
CardDataValues.Add(235,1.2);
CardDataValues.Add(236,0.6);
CardDataValues.Add(237,0.24);
CardDataValues.Add(238,1.152);
CardDataValues.Add(239,0.576);
CardDataValues.Add(240,5.75);
CardDataValues.Add(241,27.6);
CardDataValues.Add(242,13.8);
CardDataValues.Add(243,50.25);
CardDataValues.Add(244,74.25);
CardDataValues.Add(245,33.39);
CardDataValues.Add(246,29.86);
CardDataValues.Add(247,59.22);
CardDataValues.Add(248,83.64);
CardDataValues.Add(249,62.13);
CardDataValues.Add(250,63.31);
CardDataValues.Add(251,32.98);
CardDataValues.Add(252,79.14);
CardDataValues.Add(253,422);
CardDataValues.Add(254,2025.6);
CardDataValues.Add(255,1012.8);
CardDataValues.Add(256,399.99);
CardDataValues.Add(257,1919.952);
CardDataValues.Add(258,959.976);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}