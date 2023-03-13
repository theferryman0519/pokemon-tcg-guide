using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_DP_MajesticDawn : MonoBehaviour {
		
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
CardDataNumbers.Add(13,"5");
CardDataNumbers.Add(14,"5H");
CardDataNumbers.Add(15,"5RH");
CardDataNumbers.Add(16,"6");
CardDataNumbers.Add(17,"6H");
CardDataNumbers.Add(18,"6RH");
CardDataNumbers.Add(19,"7");
CardDataNumbers.Add(20,"7H");
CardDataNumbers.Add(21,"7RH");
CardDataNumbers.Add(22,"8");
CardDataNumbers.Add(23,"8H");
CardDataNumbers.Add(24,"8RH");
CardDataNumbers.Add(25,"9");
CardDataNumbers.Add(26,"9H");
CardDataNumbers.Add(27,"9RH");
CardDataNumbers.Add(28,"10");
CardDataNumbers.Add(29,"10H");
CardDataNumbers.Add(30,"10RH");
CardDataNumbers.Add(31,"11");
CardDataNumbers.Add(32,"11H");
CardDataNumbers.Add(33,"11RH");
CardDataNumbers.Add(34,"12");
CardDataNumbers.Add(35,"12H");
CardDataNumbers.Add(36,"12RH");
CardDataNumbers.Add(37,"13");
CardDataNumbers.Add(38,"13H");
CardDataNumbers.Add(39,"13RH");
CardDataNumbers.Add(40,"14");
CardDataNumbers.Add(41,"14H");
CardDataNumbers.Add(42,"14RH");
CardDataNumbers.Add(43,"15");
CardDataNumbers.Add(44,"15H");
CardDataNumbers.Add(45,"15RH");
CardDataNumbers.Add(46,"16");
CardDataNumbers.Add(47,"16H");
CardDataNumbers.Add(48,"16RH");
CardDataNumbers.Add(49,"17");
CardDataNumbers.Add(50,"17H");
CardDataNumbers.Add(51,"17RH");
CardDataNumbers.Add(52,"18");
CardDataNumbers.Add(53,"18H");
CardDataNumbers.Add(54,"18RH");
CardDataNumbers.Add(55,"19");
CardDataNumbers.Add(56,"19H");
CardDataNumbers.Add(57,"19RH");
CardDataNumbers.Add(58,"20");
CardDataNumbers.Add(59,"20H");
CardDataNumbers.Add(60,"20RH");
CardDataNumbers.Add(61,"21");
CardDataNumbers.Add(62,"21H");
CardDataNumbers.Add(63,"21RH");
CardDataNumbers.Add(64,"22");
CardDataNumbers.Add(65,"22H");
CardDataNumbers.Add(66,"22RH");
CardDataNumbers.Add(67,"23");
CardDataNumbers.Add(68,"23H");
CardDataNumbers.Add(69,"23RH");
CardDataNumbers.Add(70,"24");
CardDataNumbers.Add(71,"24H");
CardDataNumbers.Add(72,"24RH");
CardDataNumbers.Add(73,"25");
CardDataNumbers.Add(74,"25H");
CardDataNumbers.Add(75,"25RH");
CardDataNumbers.Add(76,"26");
CardDataNumbers.Add(77,"26H");
CardDataNumbers.Add(78,"26RH");
CardDataNumbers.Add(79,"27");
CardDataNumbers.Add(80,"27H");
CardDataNumbers.Add(81,"27RH");
CardDataNumbers.Add(82,"28");
CardDataNumbers.Add(83,"28H");
CardDataNumbers.Add(84,"28RH");
CardDataNumbers.Add(85,"29");
CardDataNumbers.Add(86,"29H");
CardDataNumbers.Add(87,"29RH");
CardDataNumbers.Add(88,"30");
CardDataNumbers.Add(89,"30H");
CardDataNumbers.Add(90,"30RH");
CardDataNumbers.Add(91,"31");
CardDataNumbers.Add(92,"31H");
CardDataNumbers.Add(93,"31RH");
CardDataNumbers.Add(94,"32");
CardDataNumbers.Add(95,"32H");
CardDataNumbers.Add(96,"32RH");
CardDataNumbers.Add(97,"33");
CardDataNumbers.Add(98,"33H");
CardDataNumbers.Add(99,"33RH");
CardDataNumbers.Add(100,"34");
CardDataNumbers.Add(101,"34H");
CardDataNumbers.Add(102,"34RH");
CardDataNumbers.Add(103,"35");
CardDataNumbers.Add(104,"35H");
CardDataNumbers.Add(105,"35RH");
CardDataNumbers.Add(106,"36");
CardDataNumbers.Add(107,"36H");
CardDataNumbers.Add(108,"36RH");
CardDataNumbers.Add(109,"37");
CardDataNumbers.Add(110,"37H");
CardDataNumbers.Add(111,"37RH");
CardDataNumbers.Add(112,"38");
CardDataNumbers.Add(113,"38H");
CardDataNumbers.Add(114,"38RH");
CardDataNumbers.Add(115,"39");
CardDataNumbers.Add(116,"39H");
CardDataNumbers.Add(117,"39RH");
CardDataNumbers.Add(118,"40");
CardDataNumbers.Add(119,"40H");
CardDataNumbers.Add(120,"40RH");
CardDataNumbers.Add(121,"41");
CardDataNumbers.Add(122,"41H");
CardDataNumbers.Add(123,"41RH");
CardDataNumbers.Add(124,"42");
CardDataNumbers.Add(125,"42H");
CardDataNumbers.Add(126,"42RH");
CardDataNumbers.Add(127,"43");
CardDataNumbers.Add(128,"43H");
CardDataNumbers.Add(129,"43RH");
CardDataNumbers.Add(130,"44");
CardDataNumbers.Add(131,"44H");
CardDataNumbers.Add(132,"44RH");
CardDataNumbers.Add(133,"45");
CardDataNumbers.Add(134,"45H");
CardDataNumbers.Add(135,"45RH");
CardDataNumbers.Add(136,"46");
CardDataNumbers.Add(137,"46H");
CardDataNumbers.Add(138,"46RH");
CardDataNumbers.Add(139,"47");
CardDataNumbers.Add(140,"47H");
CardDataNumbers.Add(141,"47RH");
CardDataNumbers.Add(142,"48");
CardDataNumbers.Add(143,"48H");
CardDataNumbers.Add(144,"48RH");
CardDataNumbers.Add(145,"49");
CardDataNumbers.Add(146,"49H");
CardDataNumbers.Add(147,"49RH");
CardDataNumbers.Add(148,"50");
CardDataNumbers.Add(149,"50H");
CardDataNumbers.Add(150,"50RH");
CardDataNumbers.Add(151,"51");
CardDataNumbers.Add(152,"51H");
CardDataNumbers.Add(153,"51RH");
CardDataNumbers.Add(154,"52");
CardDataNumbers.Add(155,"52H");
CardDataNumbers.Add(156,"52RH");
CardDataNumbers.Add(157,"53");
CardDataNumbers.Add(158,"53H");
CardDataNumbers.Add(159,"53RH");
CardDataNumbers.Add(160,"54");
CardDataNumbers.Add(161,"54H");
CardDataNumbers.Add(162,"54RH");
CardDataNumbers.Add(163,"55");
CardDataNumbers.Add(164,"55H");
CardDataNumbers.Add(165,"55RH");
CardDataNumbers.Add(166,"56");
CardDataNumbers.Add(167,"56H");
CardDataNumbers.Add(168,"56RH");
CardDataNumbers.Add(169,"57");
CardDataNumbers.Add(170,"57H");
CardDataNumbers.Add(171,"57RH");
CardDataNumbers.Add(172,"58");
CardDataNumbers.Add(173,"58H");
CardDataNumbers.Add(174,"58RH");
CardDataNumbers.Add(175,"59");
CardDataNumbers.Add(176,"59H");
CardDataNumbers.Add(177,"59RH");
CardDataNumbers.Add(178,"60");
CardDataNumbers.Add(179,"60H");
CardDataNumbers.Add(180,"60RH");
CardDataNumbers.Add(181,"61");
CardDataNumbers.Add(182,"61H");
CardDataNumbers.Add(183,"61RH");
CardDataNumbers.Add(184,"62");
CardDataNumbers.Add(185,"62H");
CardDataNumbers.Add(186,"62RH");
CardDataNumbers.Add(187,"63");
CardDataNumbers.Add(188,"63H");
CardDataNumbers.Add(189,"63RH");
CardDataNumbers.Add(190,"64");
CardDataNumbers.Add(191,"64H");
CardDataNumbers.Add(192,"64RH");
CardDataNumbers.Add(193,"65");
CardDataNumbers.Add(194,"65H");
CardDataNumbers.Add(195,"65RH");
CardDataNumbers.Add(196,"66");
CardDataNumbers.Add(197,"66H");
CardDataNumbers.Add(198,"66RH");
CardDataNumbers.Add(199,"67");
CardDataNumbers.Add(200,"67H");
CardDataNumbers.Add(201,"67RH");
CardDataNumbers.Add(202,"68");
CardDataNumbers.Add(203,"68H");
CardDataNumbers.Add(204,"68RH");
CardDataNumbers.Add(205,"69");
CardDataNumbers.Add(206,"69H");
CardDataNumbers.Add(207,"69RH");
CardDataNumbers.Add(208,"70");
CardDataNumbers.Add(209,"70H");
CardDataNumbers.Add(210,"70RH");
CardDataNumbers.Add(211,"71");
CardDataNumbers.Add(212,"71H");
CardDataNumbers.Add(213,"71RH");
CardDataNumbers.Add(214,"72");
CardDataNumbers.Add(215,"72H");
CardDataNumbers.Add(216,"72RH");
CardDataNumbers.Add(217,"73");
CardDataNumbers.Add(218,"73H");
CardDataNumbers.Add(219,"73RH");
CardDataNumbers.Add(220,"74");
CardDataNumbers.Add(221,"74H");
CardDataNumbers.Add(222,"74RH");
CardDataNumbers.Add(223,"75");
CardDataNumbers.Add(224,"75H");
CardDataNumbers.Add(225,"75RH");
CardDataNumbers.Add(226,"76");
CardDataNumbers.Add(227,"76H");
CardDataNumbers.Add(228,"76RH");
CardDataNumbers.Add(229,"77");
CardDataNumbers.Add(230,"77H");
CardDataNumbers.Add(231,"77RH");
CardDataNumbers.Add(232,"78");
CardDataNumbers.Add(233,"78H");
CardDataNumbers.Add(234,"78RH");
CardDataNumbers.Add(235,"79");
CardDataNumbers.Add(236,"79H");
CardDataNumbers.Add(237,"79RH");
CardDataNumbers.Add(238,"80");
CardDataNumbers.Add(239,"80H");
CardDataNumbers.Add(240,"80RH");
CardDataNumbers.Add(241,"81");
CardDataNumbers.Add(242,"81H");
CardDataNumbers.Add(243,"81RH");
CardDataNumbers.Add(244,"82");
CardDataNumbers.Add(245,"82H");
CardDataNumbers.Add(246,"82RH");
CardDataNumbers.Add(247,"83");
CardDataNumbers.Add(248,"83H");
CardDataNumbers.Add(249,"83RH");
CardDataNumbers.Add(250,"84");
CardDataNumbers.Add(251,"84H");
CardDataNumbers.Add(252,"84RH");
CardDataNumbers.Add(253,"85");
CardDataNumbers.Add(254,"85H");
CardDataNumbers.Add(255,"85RH");
CardDataNumbers.Add(256,"86");
CardDataNumbers.Add(257,"86H");
CardDataNumbers.Add(258,"86RH");
CardDataNumbers.Add(259,"87");
CardDataNumbers.Add(260,"87H");
CardDataNumbers.Add(261,"87RH");
CardDataNumbers.Add(262,"88");
CardDataNumbers.Add(263,"88H");
CardDataNumbers.Add(264,"88RH");
CardDataNumbers.Add(265,"89");
CardDataNumbers.Add(266,"89H");
CardDataNumbers.Add(267,"89RH");
CardDataNumbers.Add(268,"90");
CardDataNumbers.Add(269,"90H");
CardDataNumbers.Add(270,"90RH");
CardDataNumbers.Add(271,"91");
CardDataNumbers.Add(272,"91H");
CardDataNumbers.Add(273,"91RH");
CardDataNumbers.Add(274,"92");
CardDataNumbers.Add(275,"92H");
CardDataNumbers.Add(276,"92RH");
CardDataNumbers.Add(277,"93");
CardDataNumbers.Add(278,"93H");
CardDataNumbers.Add(279,"93RH");
CardDataNumbers.Add(280,"94");
CardDataNumbers.Add(281,"94H");
CardDataNumbers.Add(282,"94RH");
CardDataNumbers.Add(283,"95");
CardDataNumbers.Add(284,"95H");
CardDataNumbers.Add(285,"95RH");
CardDataNumbers.Add(286,"96");
CardDataNumbers.Add(287,"96H");
CardDataNumbers.Add(288,"96RH");
CardDataNumbers.Add(289,"97");
CardDataNumbers.Add(290,"98");
CardDataNumbers.Add(291,"99");
CardDataNumbers.Add(292,"100");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Articuno");
CardDataNames.Add(2,"Articuno Holofoil");
CardDataNames.Add(3,"Articuno Reverse Holo");
CardDataNames.Add(4,"Cresselia");
CardDataNames.Add(5,"Cresselia Holofoil");
CardDataNames.Add(6,"Cresselia Reverse Holo");
CardDataNames.Add(7,"Darkrai");
CardDataNames.Add(8,"Darkrai Holofoil");
CardDataNames.Add(9,"Darkrai Reverse Holo");
CardDataNames.Add(10,"Dialga");
CardDataNames.Add(11,"Dialga Holofoil");
CardDataNames.Add(12,"Dialga Reverse Holo");
CardDataNames.Add(13,"Glaceon");
CardDataNames.Add(14,"Glaceon Holofoil");
CardDataNames.Add(15,"Glaceon Reverse Holo");
CardDataNames.Add(16,"Kabutops");
CardDataNames.Add(17,"Kabutops Holofoil");
CardDataNames.Add(18,"Kabutops Reverse Holo");
CardDataNames.Add(19,"Leafeon");
CardDataNames.Add(20,"Leafeon Holofoil");
CardDataNames.Add(21,"Leafeon Reverse Holo");
CardDataNames.Add(22,"Manaphy");
CardDataNames.Add(23,"Manaphy Holofoil");
CardDataNames.Add(24,"Manaphy Reverse Holo");
CardDataNames.Add(25,"Mewtwo");
CardDataNames.Add(26,"Mewtwo Holofoil");
CardDataNames.Add(27,"Mewtwo Reverse Holo");
CardDataNames.Add(28,"Moltres");
CardDataNames.Add(29,"Moltres Holofoil");
CardDataNames.Add(30,"Moltres Reverse Holo");
CardDataNames.Add(31,"Palkia");
CardDataNames.Add(32,"Palkia Holofoil");
CardDataNames.Add(33,"Palkia Reverse Holo");
CardDataNames.Add(34,"Phione");
CardDataNames.Add(35,"Phione Holofoil");
CardDataNames.Add(36,"Phione Reverse Holo");
CardDataNames.Add(37,"Rotom");
CardDataNames.Add(38,"Rotom Holofoil");
CardDataNames.Add(39,"Rotom Reverse Holo");
CardDataNames.Add(40,"Zapdos");
CardDataNames.Add(41,"Zapdos Holofoil");
CardDataNames.Add(42,"Zapdos Reverse Holo");
CardDataNames.Add(43,"Aerodactyl");
CardDataNames.Add(44,"Aerodactyl Holofoil");
CardDataNames.Add(45,"Aerodactyl Reverse Holo");
CardDataNames.Add(46,"Bronzong");
CardDataNames.Add(47,"Bronzong Holofoil");
CardDataNames.Add(48,"Bronzong Reverse Holo");
CardDataNames.Add(49,"Empoleon");
CardDataNames.Add(50,"Empoleon Holofoil");
CardDataNames.Add(51,"Empoleon Reverse Holo");
CardDataNames.Add(52,"Espeon");
CardDataNames.Add(53,"Espeon Holofoil");
CardDataNames.Add(54,"Espeon Reverse Holo");
CardDataNames.Add(55,"Flareon");
CardDataNames.Add(56,"Flareon Holofoil");
CardDataNames.Add(57,"Flareon Reverse Holo");
CardDataNames.Add(58,"Glaceon");
CardDataNames.Add(59,"Glaceon Holofoil");
CardDataNames.Add(60,"Glaceon Reverse Holo");
CardDataNames.Add(61,"Hippowdon");
CardDataNames.Add(62,"Hippowdon Holofoil");
CardDataNames.Add(63,"Hippowdon Reverse Holo");
CardDataNames.Add(64,"Infernape");
CardDataNames.Add(65,"Infernape Holofoil");
CardDataNames.Add(66,"Infernape Reverse Holo");
CardDataNames.Add(67,"Jolteon");
CardDataNames.Add(68,"Jolteon Holofoil");
CardDataNames.Add(69,"Jolteon Reverse Holo");
CardDataNames.Add(70,"Leafeon");
CardDataNames.Add(71,"Leafeon Holofoil");
CardDataNames.Add(72,"Leafeon Reverse Holo");
CardDataNames.Add(73,"Minun");
CardDataNames.Add(74,"Minun Holofoil");
CardDataNames.Add(75,"Minun Reverse Holo");
CardDataNames.Add(76,"Omastar");
CardDataNames.Add(77,"Omastar Holofoil");
CardDataNames.Add(78,"Omastar Reverse Holo");
CardDataNames.Add(79,"Phione");
CardDataNames.Add(80,"Phione Holofoil");
CardDataNames.Add(81,"Phione Reverse Holo");
CardDataNames.Add(82,"Plusle");
CardDataNames.Add(83,"Plusle Holofoil");
CardDataNames.Add(84,"Plusle Reverse Holo");
CardDataNames.Add(85,"Scizor");
CardDataNames.Add(86,"Scizor Holofoil");
CardDataNames.Add(87,"Scizor Reverse Holo");
CardDataNames.Add(88,"Torterra");
CardDataNames.Add(89,"Torterra Holofoil");
CardDataNames.Add(90,"Torterra Reverse Holo");
CardDataNames.Add(91,"Toxicroak");
CardDataNames.Add(92,"Toxicroak Holofoil");
CardDataNames.Add(93,"Toxicroak Reverse Holo");
CardDataNames.Add(94,"Umbreon");
CardDataNames.Add(95,"Umbreon Holofoil");
CardDataNames.Add(96,"Umbreon Reverse Holo");
CardDataNames.Add(97,"Unown P");
CardDataNames.Add(98,"Unown P Holofoil");
CardDataNames.Add(99,"Unown P Reverse Holo");
CardDataNames.Add(100,"Vaporeon");
CardDataNames.Add(101,"Vaporeon Holofoil");
CardDataNames.Add(102,"Vaporeon Reverse Holo");
CardDataNames.Add(103,"Ambipom");
CardDataNames.Add(104,"Ambipom Holofoil");
CardDataNames.Add(105,"Ambipom Reverse Holo");
CardDataNames.Add(106,"Fearow");
CardDataNames.Add(107,"Fearow Holofoil");
CardDataNames.Add(108,"Fearow Reverse Holo");
CardDataNames.Add(109,"Grotle");
CardDataNames.Add(110,"Grotle Holofoil");
CardDataNames.Add(111,"Grotle Reverse Holo");
CardDataNames.Add(112,"Kangaskhan");
CardDataNames.Add(113,"Kangaskhan Holofoil");
CardDataNames.Add(114,"Kangaskhan Reverse Holo");
CardDataNames.Add(115,"Lickitung");
CardDataNames.Add(116,"Lickitung Holofoil");
CardDataNames.Add(117,"Lickitung Reverse Holo");
CardDataNames.Add(118,"Manectric");
CardDataNames.Add(119,"Manectric Holofoil");
CardDataNames.Add(120,"Manectric Reverse Holo");
CardDataNames.Add(121,"Monferno");
CardDataNames.Add(122,"Monferno Holofoil");
CardDataNames.Add(123,"Monferno Reverse Holo");
CardDataNames.Add(124,"Mothim");
CardDataNames.Add(125,"Mothim Holofoil");
CardDataNames.Add(126,"Mothim Reverse Holo");
CardDataNames.Add(127,"Pachirisu");
CardDataNames.Add(128,"Pachirisu Holofoil");
CardDataNames.Add(129,"Pachirisu Reverse Holo");
CardDataNames.Add(130,"Prinplup");
CardDataNames.Add(131,"Prinplup Holofoil");
CardDataNames.Add(132,"Prinplup Reverse Holo");
CardDataNames.Add(133,"Raichu");
CardDataNames.Add(134,"Raichu Holofoil");
CardDataNames.Add(135,"Raichu Reverse Holo");
CardDataNames.Add(136,"Scyther");
CardDataNames.Add(137,"Scyther Holofoil");
CardDataNames.Add(138,"Scyther Reverse Holo");
CardDataNames.Add(139,"Staravia");
CardDataNames.Add(140,"Staravia Holofoil");
CardDataNames.Add(141,"Staravia Reverse Holo");
CardDataNames.Add(142,"Sudowoodo");
CardDataNames.Add(143,"Sudowoodo Holofoil");
CardDataNames.Add(144,"Sudowoodo Reverse Holo");
CardDataNames.Add(145,"Unown Q");
CardDataNames.Add(146,"Unown Q Holofoil");
CardDataNames.Add(147,"Unown Q Reverse Holo");
CardDataNames.Add(148,"Aipom");
CardDataNames.Add(149,"Aipom Holofoil");
CardDataNames.Add(150,"Aipom Reverse Holo");
CardDataNames.Add(151,"Aipom");
CardDataNames.Add(152,"Aipom Holofoil");
CardDataNames.Add(153,"Aipom Reverse Holo");
CardDataNames.Add(154,"Bronzor");
CardDataNames.Add(155,"Bronzor Holofoil");
CardDataNames.Add(156,"Bronzor Reverse Holo");
CardDataNames.Add(157,"Buneary");
CardDataNames.Add(158,"Buneary Holofoil");
CardDataNames.Add(159,"Buneary Reverse Holo");
CardDataNames.Add(160,"Burmy Sandy Cloak");
CardDataNames.Add(161,"Burmy Sandy Cloak Holofoil");
CardDataNames.Add(162,"Burmy Sandy Cloak Reverse Holo");
CardDataNames.Add(163,"Chatot");
CardDataNames.Add(164,"Chatot Holofoil");
CardDataNames.Add(165,"Chatot Reverse Holo");
CardDataNames.Add(166,"Chimchar");
CardDataNames.Add(167,"Chimchar Holofoil");
CardDataNames.Add(168,"Chimchar Reverse Holo");
CardDataNames.Add(169,"Chimchar");
CardDataNames.Add(170,"Chimchar Holofoil");
CardDataNames.Add(171,"Chimchar Reverse Holo");
CardDataNames.Add(172,"Chingling");
CardDataNames.Add(173,"Chingling Holofoil");
CardDataNames.Add(174,"Chingling Reverse Holo");
CardDataNames.Add(175,"Combee");
CardDataNames.Add(176,"Combee Holofoil");
CardDataNames.Add(177,"Combee Reverse Holo");
CardDataNames.Add(178,"Croagunk");
CardDataNames.Add(179,"Croagunk Holofoil");
CardDataNames.Add(180,"Croagunk Reverse Holo");
CardDataNames.Add(181,"Drifloon");
CardDataNames.Add(182,"Drifloon Holofoil");
CardDataNames.Add(183,"Drifloon Reverse Holo");
CardDataNames.Add(184,"Eevee");
CardDataNames.Add(185,"Eevee Holofoil");
CardDataNames.Add(186,"Eevee Reverse Holo");
CardDataNames.Add(187,"Eevee");
CardDataNames.Add(188,"Eevee Holofoil");
CardDataNames.Add(189,"Eevee Reverse Holo");
CardDataNames.Add(190,"Electrike");
CardDataNames.Add(191,"Electrike Holofoil");
CardDataNames.Add(192,"Electrike Reverse Holo");
CardDataNames.Add(193,"Glameow");
CardDataNames.Add(194,"Glameow Holofoil");
CardDataNames.Add(195,"Glameow Reverse Holo");
CardDataNames.Add(196,"Hippopotas");
CardDataNames.Add(197,"Hippopotas Holofoil");
CardDataNames.Add(198,"Hippopotas Reverse Holo");
CardDataNames.Add(199,"Kabuto");
CardDataNames.Add(200,"Kabuto Holofoil");
CardDataNames.Add(201,"Kabuto Reverse Holo");
CardDataNames.Add(202,"Munchlax");
CardDataNames.Add(203,"Munchlax Holofoil");
CardDataNames.Add(204,"Munchlax Reverse Holo");
CardDataNames.Add(205,"Omanyte");
CardDataNames.Add(206,"Omanyte Holofoil");
CardDataNames.Add(207,"Omanyte Reverse Holo");
CardDataNames.Add(208,"Pikachu");
CardDataNames.Add(209,"Pikachu Holofoil");
CardDataNames.Add(210,"Pikachu Reverse Holo");
CardDataNames.Add(211,"Piplup");
CardDataNames.Add(212,"Piplup Holofoil");
CardDataNames.Add(213,"Piplup Reverse Holo");
CardDataNames.Add(214,"Piplup");
CardDataNames.Add(215,"Piplup Holofoil");
CardDataNames.Add(216,"Piplup Reverse Holo");
CardDataNames.Add(217,"Shellos East Sea");
CardDataNames.Add(218,"Shellos East Sea Holofoil");
CardDataNames.Add(219,"Shellos East Sea Reverse Holo");
CardDataNames.Add(220,"Spearow");
CardDataNames.Add(221,"Spearow Holofoil");
CardDataNames.Add(222,"Spearow Reverse Holo");
CardDataNames.Add(223,"Starly");
CardDataNames.Add(224,"Starly Holofoil");
CardDataNames.Add(225,"Starly Reverse Holo");
CardDataNames.Add(226,"Stunky");
CardDataNames.Add(227,"Stunky Holofoil");
CardDataNames.Add(228,"Stunky Reverse Holo");
CardDataNames.Add(229,"Turtwig");
CardDataNames.Add(230,"Turtwig Holofoil");
CardDataNames.Add(231,"Turtwig Reverse Holo");
CardDataNames.Add(232,"Turtwig");
CardDataNames.Add(233,"Turtwig Holofoil");
CardDataNames.Add(234,"Turtwig Reverse Holo");
CardDataNames.Add(235,"Dawn Stadium");
CardDataNames.Add(236,"Dawn Stadium Holofoil");
CardDataNames.Add(237,"Dawn Stadium Reverse Holo");
CardDataNames.Add(238,"Dusk Ball");
CardDataNames.Add(239,"Dusk Ball Holofoil");
CardDataNames.Add(240,"Dusk Ball Reverse Holo");
CardDataNames.Add(241,"Energy Restore");
CardDataNames.Add(242,"Energy Restore Holofoil");
CardDataNames.Add(243,"Energy Restore Reverse Holo");
CardDataNames.Add(244,"Fossil Excavator");
CardDataNames.Add(245,"Fossil Excavator Holofoil");
CardDataNames.Add(246,"Fossil Excavator Reverse Holo");
CardDataNames.Add(247,"Mom's Kindness");
CardDataNames.Add(248,"Mom's Kindness Holofoil");
CardDataNames.Add(249,"Mom's Kindness Reverse Holo");
CardDataNames.Add(250,"Old Amber");
CardDataNames.Add(251,"Old Amber Holofoil");
CardDataNames.Add(252,"Old Amber Reverse Holo");
CardDataNames.Add(253,"Poké Ball");
CardDataNames.Add(254,"Poké Ball Holofoil");
CardDataNames.Add(255,"Poké Ball Reverse Holo");
CardDataNames.Add(256,"Quick Ball");
CardDataNames.Add(257,"Quick Ball Holofoil");
CardDataNames.Add(258,"Quick Ball Reverse Holo");
CardDataNames.Add(259,"Super Scoop Up");
CardDataNames.Add(260,"Super Scoop Up Holofoil");
CardDataNames.Add(261,"Super Scoop Up Reverse Holo");
CardDataNames.Add(262,"Warp Point");
CardDataNames.Add(263,"Warp Point Holofoil");
CardDataNames.Add(264,"Warp Point Reverse Holo");
CardDataNames.Add(265,"Dome Fossil");
CardDataNames.Add(266,"Dome Fossil Holofoil");
CardDataNames.Add(267,"Dome Fossil Reverse Holo");
CardDataNames.Add(268,"Energy Search");
CardDataNames.Add(269,"Energy Search Holofoil");
CardDataNames.Add(270,"Energy Search Reverse Holo");
CardDataNames.Add(271,"Helix Fossil");
CardDataNames.Add(272,"Helix Fossil Holofoil");
CardDataNames.Add(273,"Helix Fossil Reverse Holo");
CardDataNames.Add(274,"Call Energy");
CardDataNames.Add(275,"Call Energy Holofoil");
CardDataNames.Add(276,"Call Energy Reverse Holo");
CardDataNames.Add(277,"Darkness Energy");
CardDataNames.Add(278,"Darkness Energy Holofoil");
CardDataNames.Add(279,"Darkness Energy Reverse Holo");
CardDataNames.Add(280,"Health Energy");
CardDataNames.Add(281,"Health Energy Holofoil");
CardDataNames.Add(282,"Health Energy Reverse Holo");
CardDataNames.Add(283,"Metal Energy");
CardDataNames.Add(284,"Metal Energy Holofoil");
CardDataNames.Add(285,"Metal Energy Reverse Holo");
CardDataNames.Add(286,"Recover Energy");
CardDataNames.Add(287,"Recover Energy Holofoil");
CardDataNames.Add(288,"Recover Energy Reverse Holo");
CardDataNames.Add(289,"Garchomp Lv X");
CardDataNames.Add(290,"Glaceon Lv X");
CardDataNames.Add(291,"Leafeon Lv X");
CardDataNames.Add(292,"Porygon-Z Lv X");
	}

	public void SetCardValues() {
CardDataValues.Add(1,18.79);
CardDataValues.Add(2,90.192);
CardDataValues.Add(3,45.096);
CardDataValues.Add(4,9.1);
CardDataValues.Add(5,43.68);
CardDataValues.Add(6,21.84);
CardDataValues.Add(7,13.79);
CardDataValues.Add(8,66.192);
CardDataValues.Add(9,33.096);
CardDataValues.Add(10,9.44);
CardDataValues.Add(11,45.312);
CardDataValues.Add(12,22.656);
CardDataValues.Add(13,27.18);
CardDataValues.Add(14,130.464);
CardDataValues.Add(15,65.232);
CardDataValues.Add(16,9.12);
CardDataValues.Add(17,43.776);
CardDataValues.Add(18,21.888);
CardDataValues.Add(19,29.48);
CardDataValues.Add(20,141.504);
CardDataValues.Add(21,70.752);
CardDataValues.Add(22,4.2);
CardDataValues.Add(23,20.16);
CardDataValues.Add(24,10.08);
CardDataValues.Add(25,32.7);
CardDataValues.Add(26,156.96);
CardDataValues.Add(27,78.48);
CardDataValues.Add(28,12.63);
CardDataValues.Add(29,60.624);
CardDataValues.Add(30,30.312);
CardDataValues.Add(31,8.99);
CardDataValues.Add(32,43.152);
CardDataValues.Add(33,21.576);
CardDataValues.Add(34,4.32);
CardDataValues.Add(35,20.736);
CardDataValues.Add(36,10.368);
CardDataValues.Add(37,5.01);
CardDataValues.Add(38,24.048);
CardDataValues.Add(39,12.024);
CardDataValues.Add(40,13.32);
CardDataValues.Add(41,63.936);
CardDataValues.Add(42,31.968);
CardDataValues.Add(43,2.25);
CardDataValues.Add(44,10.8);
CardDataValues.Add(45,5.4);
CardDataValues.Add(46,2.81);
CardDataValues.Add(47,13.488);
CardDataValues.Add(48,6.744);
CardDataValues.Add(49,1.75);
CardDataValues.Add(50,8.4);
CardDataValues.Add(51,4.2);
CardDataValues.Add(52,9.8);
CardDataValues.Add(53,47.04);
CardDataValues.Add(54,23.52);
CardDataValues.Add(55,6.84);
CardDataValues.Add(56,32.832);
CardDataValues.Add(57,16.416);
CardDataValues.Add(58,9.99);
CardDataValues.Add(59,47.952);
CardDataValues.Add(60,23.976);
CardDataValues.Add(61,1.02);
CardDataValues.Add(62,4.896);
CardDataValues.Add(63,2.448);
CardDataValues.Add(64,7.96);
CardDataValues.Add(65,38.208);
CardDataValues.Add(66,19.104);
CardDataValues.Add(67,4.76);
CardDataValues.Add(68,22.848);
CardDataValues.Add(69,11.424);
CardDataValues.Add(70,7.33);
CardDataValues.Add(71,35.184);
CardDataValues.Add(72,17.592);
CardDataValues.Add(73,2.25);
CardDataValues.Add(74,10.8);
CardDataValues.Add(75,5.4);
CardDataValues.Add(76,1.98);
CardDataValues.Add(77,9.504);
CardDataValues.Add(78,4.752);
CardDataValues.Add(79,3);
CardDataValues.Add(80,14.4);
CardDataValues.Add(81,7.2);
CardDataValues.Add(82,0.97);
CardDataValues.Add(83,4.656);
CardDataValues.Add(84,2.328);
CardDataValues.Add(85,3.53);
CardDataValues.Add(86,16.944);
CardDataValues.Add(87,8.472);
CardDataValues.Add(88,1.13);
CardDataValues.Add(89,5.424);
CardDataValues.Add(90,2.712);
CardDataValues.Add(91,3.32);
CardDataValues.Add(92,15.936);
CardDataValues.Add(93,7.968);
CardDataValues.Add(94,33.99);
CardDataValues.Add(95,163.152);
CardDataValues.Add(96,81.576);
CardDataValues.Add(97,3.97);
CardDataValues.Add(98,19.056);
CardDataValues.Add(99,9.528);
CardDataValues.Add(100,9.94);
CardDataValues.Add(101,47.712);
CardDataValues.Add(102,23.856);
CardDataValues.Add(103,0.58);
CardDataValues.Add(104,2.784);
CardDataValues.Add(105,1.392);
CardDataValues.Add(106,0.35);
CardDataValues.Add(107,1.68);
CardDataValues.Add(108,0.84);
CardDataValues.Add(109,0.69);
CardDataValues.Add(110,3.312);
CardDataValues.Add(111,1.656);
CardDataValues.Add(112,0.55);
CardDataValues.Add(113,2.64);
CardDataValues.Add(114,1.32);
CardDataValues.Add(115,0.63);
CardDataValues.Add(116,3.024);
CardDataValues.Add(117,1.512);
CardDataValues.Add(118,0.33);
CardDataValues.Add(119,1.584);
CardDataValues.Add(120,0.792);
CardDataValues.Add(121,0.61);
CardDataValues.Add(122,2.928);
CardDataValues.Add(123,1.464);
CardDataValues.Add(124,0.7);
CardDataValues.Add(125,3.36);
CardDataValues.Add(126,1.68);
CardDataValues.Add(127,0.83);
CardDataValues.Add(128,3.984);
CardDataValues.Add(129,1.992);
CardDataValues.Add(130,0.58);
CardDataValues.Add(131,2.784);
CardDataValues.Add(132,1.392);
CardDataValues.Add(133,1.53);
CardDataValues.Add(134,7.344);
CardDataValues.Add(135,3.672);
CardDataValues.Add(136,1.03);
CardDataValues.Add(137,4.944);
CardDataValues.Add(138,2.472);
CardDataValues.Add(139,0.5);
CardDataValues.Add(140,2.4);
CardDataValues.Add(141,1.2);
CardDataValues.Add(142,0.57);
CardDataValues.Add(143,2.736);
CardDataValues.Add(144,1.368);
CardDataValues.Add(145,7.99);
CardDataValues.Add(146,38.352);
CardDataValues.Add(147,19.176);
CardDataValues.Add(148,0.5);
CardDataValues.Add(149,2.4);
CardDataValues.Add(150,1.2);
CardDataValues.Add(151,0.41);
CardDataValues.Add(152,1.968);
CardDataValues.Add(153,0.984);
CardDataValues.Add(154,0.29);
CardDataValues.Add(155,1.392);
CardDataValues.Add(156,0.696);
CardDataValues.Add(157,0.58);
CardDataValues.Add(158,2.784);
CardDataValues.Add(159,1.392);
CardDataValues.Add(160,0.33);
CardDataValues.Add(161,1.584);
CardDataValues.Add(162,0.792);
CardDataValues.Add(163,0.84);
CardDataValues.Add(164,4.032);
CardDataValues.Add(165,2.016);
CardDataValues.Add(166,0.51);
CardDataValues.Add(167,2.448);
CardDataValues.Add(168,1.224);
CardDataValues.Add(169,0.65);
CardDataValues.Add(170,3.12);
CardDataValues.Add(171,1.56);
CardDataValues.Add(172,0.95);
CardDataValues.Add(173,4.56);
CardDataValues.Add(174,2.28);
CardDataValues.Add(175,0.43);
CardDataValues.Add(176,2.064);
CardDataValues.Add(177,1.032);
CardDataValues.Add(178,0.26);
CardDataValues.Add(179,1.248);
CardDataValues.Add(180,0.624);
CardDataValues.Add(181,0.41);
CardDataValues.Add(182,1.968);
CardDataValues.Add(183,0.984);
CardDataValues.Add(184,1.51);
CardDataValues.Add(185,7.248);
CardDataValues.Add(186,3.624);
CardDataValues.Add(187,1.34);
CardDataValues.Add(188,6.432);
CardDataValues.Add(189,3.216);
CardDataValues.Add(190,0.3);
CardDataValues.Add(191,1.44);
CardDataValues.Add(192,0.72);
CardDataValues.Add(193,0.47);
CardDataValues.Add(194,2.256);
CardDataValues.Add(195,1.128);
CardDataValues.Add(196,0.3);
CardDataValues.Add(197,1.44);
CardDataValues.Add(198,0.72);
CardDataValues.Add(199,0.5);
CardDataValues.Add(200,2.4);
CardDataValues.Add(201,1.2);
CardDataValues.Add(202,2.23);
CardDataValues.Add(203,10.704);
CardDataValues.Add(204,5.352);
CardDataValues.Add(205,0.5);
CardDataValues.Add(206,2.4);
CardDataValues.Add(207,1.2);
CardDataValues.Add(208,2.18);
CardDataValues.Add(209,10.464);
CardDataValues.Add(210,5.232);
CardDataValues.Add(211,0.42);
CardDataValues.Add(212,2.016);
CardDataValues.Add(213,1.008);
CardDataValues.Add(214,0.75);
CardDataValues.Add(215,3.6);
CardDataValues.Add(216,1.8);
CardDataValues.Add(217,0.29);
CardDataValues.Add(218,1.392);
CardDataValues.Add(219,0.696);
CardDataValues.Add(220,0.33);
CardDataValues.Add(221,1.584);
CardDataValues.Add(222,0.792);
CardDataValues.Add(223,0.45);
CardDataValues.Add(224,2.16);
CardDataValues.Add(225,1.08);
CardDataValues.Add(226,0.5);
CardDataValues.Add(227,2.4);
CardDataValues.Add(228,1.2);
CardDataValues.Add(229,0.3);
CardDataValues.Add(230,1.44);
CardDataValues.Add(231,0.72);
CardDataValues.Add(232,0.83);
CardDataValues.Add(233,3.984);
CardDataValues.Add(234,1.992);
CardDataValues.Add(235,5.12);
CardDataValues.Add(236,24.576);
CardDataValues.Add(237,12.288);
CardDataValues.Add(238,0.31);
CardDataValues.Add(239,1.488);
CardDataValues.Add(240,0.744);
CardDataValues.Add(241,0.44);
CardDataValues.Add(242,2.112);
CardDataValues.Add(243,1.056);
CardDataValues.Add(244,0.99);
CardDataValues.Add(245,4.752);
CardDataValues.Add(246,2.376);
CardDataValues.Add(247,0.3);
CardDataValues.Add(248,1.44);
CardDataValues.Add(249,0.72);
CardDataValues.Add(250,0.55);
CardDataValues.Add(251,2.64);
CardDataValues.Add(252,1.32);
CardDataValues.Add(253,0.6);
CardDataValues.Add(254,2.88);
CardDataValues.Add(255,1.44);
CardDataValues.Add(256,2);
CardDataValues.Add(257,9.6);
CardDataValues.Add(258,4.8);
CardDataValues.Add(259,1.17);
CardDataValues.Add(260,5.616);
CardDataValues.Add(261,2.808);
CardDataValues.Add(262,0.69);
CardDataValues.Add(263,3.312);
CardDataValues.Add(264,1.656);
CardDataValues.Add(265,0.5);
CardDataValues.Add(266,2.4);
CardDataValues.Add(267,1.2);
CardDataValues.Add(268,0.33);
CardDataValues.Add(269,1.584);
CardDataValues.Add(270,0.792);
CardDataValues.Add(271,0.26);
CardDataValues.Add(272,1.248);
CardDataValues.Add(273,0.624);
CardDataValues.Add(274,17.81);
CardDataValues.Add(275,85.488);
CardDataValues.Add(276,42.744);
CardDataValues.Add(277,0.79);
CardDataValues.Add(278,3.792);
CardDataValues.Add(279,1.896);
CardDataValues.Add(280,0.98);
CardDataValues.Add(281,4.704);
CardDataValues.Add(282,2.352);
CardDataValues.Add(283,0.81);
CardDataValues.Add(284,3.888);
CardDataValues.Add(285,1.944);
CardDataValues.Add(286,1.05);
CardDataValues.Add(287,5.04);
CardDataValues.Add(288,2.52);
CardDataValues.Add(289,133.31);
CardDataValues.Add(290,164.99);
CardDataValues.Add(291,299.99);
CardDataValues.Add(292,105);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}