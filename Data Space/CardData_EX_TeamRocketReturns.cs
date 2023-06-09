using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_EX_TeamRocketReturns : MonoBehaviour {
		
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
CardDataNumbers.Add(287,"97");
CardDataNumbers.Add(288,"98");
CardDataNumbers.Add(289,"99");
CardDataNumbers.Add(290,"100");
CardDataNumbers.Add(291,"101");
CardDataNumbers.Add(292,"102");
CardDataNumbers.Add(293,"103");
CardDataNumbers.Add(294,"104");
CardDataNumbers.Add(295,"105");
CardDataNumbers.Add(296,"106");
CardDataNumbers.Add(297,"107");
CardDataNumbers.Add(298,"107H");
CardDataNumbers.Add(299,"107RH");
CardDataNumbers.Add(300,"108");
CardDataNumbers.Add(301,"108H");
CardDataNumbers.Add(302,"108RH");
CardDataNumbers.Add(303,"109");
CardDataNumbers.Add(304,"109H");
CardDataNumbers.Add(305,"109RH");
CardDataNumbers.Add(306,"110");
CardDataNumbers.Add(307,"110H");
CardDataNumbers.Add(308,"110RH");
CardDataNumbers.Add(309,"111");
CardDataNumbers.Add(310,"111H");
CardDataNumbers.Add(311,"111RH");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Azumarill");
CardDataNames.Add(2,"Azumarill Holofoil");
CardDataNames.Add(3,"Azumarill Reverse Holo");
CardDataNames.Add(4,"Dark Ampharos");
CardDataNames.Add(5,"Dark Ampharos Holofoil");
CardDataNames.Add(6,"Dark Ampharos Reverse Holo");
CardDataNames.Add(7,"Dark Crobat");
CardDataNames.Add(8,"Dark Crobat Holofoil");
CardDataNames.Add(9,"Dark Crobat Reverse Holo");
CardDataNames.Add(10,"Dark Electrode");
CardDataNames.Add(11,"Dark Electrode Holofoil");
CardDataNames.Add(12,"Dark Electrode Reverse Holo");
CardDataNames.Add(13,"Dark Houndoom");
CardDataNames.Add(14,"Dark Houndoom Holofoil");
CardDataNames.Add(15,"Dark Houndoom Reverse Holo");
CardDataNames.Add(16,"Dark Hypno");
CardDataNames.Add(17,"Dark Hypno Holofoil");
CardDataNames.Add(18,"Dark Hypno Reverse Holo");
CardDataNames.Add(19,"Dark Marowak");
CardDataNames.Add(20,"Dark Marowak Holofoil");
CardDataNames.Add(21,"Dark Marowak Reverse Holo");
CardDataNames.Add(22,"Dark Octillery");
CardDataNames.Add(23,"Dark Octillery Holofoil");
CardDataNames.Add(24,"Dark Octillery Reverse Holo");
CardDataNames.Add(25,"Dark Slowking");
CardDataNames.Add(26,"Dark Slowking Holofoil");
CardDataNames.Add(27,"Dark Slowking Reverse Holo");
CardDataNames.Add(28,"Dark Steelix");
CardDataNames.Add(29,"Dark Steelix Holofoil");
CardDataNames.Add(30,"Dark Steelix Reverse Holo");
CardDataNames.Add(31,"Jumpluff");
CardDataNames.Add(32,"Jumpluff Holofoil");
CardDataNames.Add(33,"Jumpluff Reverse Holo");
CardDataNames.Add(34,"Kingdra");
CardDataNames.Add(35,"Kingdra Holofoil");
CardDataNames.Add(36,"Kingdra Reverse Holo");
CardDataNames.Add(37,"Piloswine");
CardDataNames.Add(38,"Piloswine Holofoil");
CardDataNames.Add(39,"Piloswine Reverse Holo");
CardDataNames.Add(40,"Togetic");
CardDataNames.Add(41,"Togetic Holofoil");
CardDataNames.Add(42,"Togetic Reverse Holo");
CardDataNames.Add(43,"Dark Dragonite");
CardDataNames.Add(44,"Dark Dragonite Holofoil");
CardDataNames.Add(45,"Dark Dragonite Reverse Holo");
CardDataNames.Add(46,"Dark Muk");
CardDataNames.Add(47,"Dark Muk Holofoil");
CardDataNames.Add(48,"Dark Muk Reverse Holo");
CardDataNames.Add(49,"Dark Raticate");
CardDataNames.Add(50,"Dark Raticate Holofoil");
CardDataNames.Add(51,"Dark Raticate Reverse Holo");
CardDataNames.Add(52,"Dark Sandslash");
CardDataNames.Add(53,"Dark Sandslash Holofoil");
CardDataNames.Add(54,"Dark Sandslash Reverse Holo");
CardDataNames.Add(55,"Dark Tyranitar");
CardDataNames.Add(56,"Dark Tyranitar Holofoil");
CardDataNames.Add(57,"Dark Tyranitar Reverse Holo");
CardDataNames.Add(58,"Dark Tyranitar");
CardDataNames.Add(59,"Dark Tyranitar Holofoil");
CardDataNames.Add(60,"Dark Tyranitar Reverse Holo");
CardDataNames.Add(61,"Delibird");
CardDataNames.Add(62,"Delibird Holofoil");
CardDataNames.Add(63,"Delibird Reverse Holo");
CardDataNames.Add(64,"Furret");
CardDataNames.Add(65,"Furret Holofoil");
CardDataNames.Add(66,"Furret Reverse Holo");
CardDataNames.Add(67,"Ledian");
CardDataNames.Add(68,"Ledian Holofoil");
CardDataNames.Add(69,"Ledian Reverse Holo");
CardDataNames.Add(70,"Magby");
CardDataNames.Add(71,"Magby Holofoil");
CardDataNames.Add(72,"Magby Reverse Holo");
CardDataNames.Add(73,"Misdreavus");
CardDataNames.Add(74,"Misdreavus Holofoil");
CardDataNames.Add(75,"Misdreavus Reverse Holo");
CardDataNames.Add(76,"Quagsire");
CardDataNames.Add(77,"Quagsire Holofoil");
CardDataNames.Add(78,"Quagsire Reverse Holo");
CardDataNames.Add(79,"Qwilfish");
CardDataNames.Add(80,"Qwilfish Holofoil");
CardDataNames.Add(81,"Qwilfish Reverse Holo");
CardDataNames.Add(82,"Yanma");
CardDataNames.Add(83,"Yanma Holofoil");
CardDataNames.Add(84,"Yanma Reverse Holo");
CardDataNames.Add(85,"Dark Arbok");
CardDataNames.Add(86,"Dark Arbok Holofoil");
CardDataNames.Add(87,"Dark Arbok Reverse Holo");
CardDataNames.Add(88,"Dark Ariados");
CardDataNames.Add(89,"Dark Ariados Holofoil");
CardDataNames.Add(90,"Dark Ariados Reverse Holo");
CardDataNames.Add(91,"Dark Dragonair");
CardDataNames.Add(92,"Dark Dragonair Holofoil");
CardDataNames.Add(93,"Dark Dragonair Reverse Holo");
CardDataNames.Add(94,"Dark Dragonair");
CardDataNames.Add(95,"Dark Dragonair Holofoil");
CardDataNames.Add(96,"Dark Dragonair Reverse Holo");
CardDataNames.Add(97,"Dark Flaaffy");
CardDataNames.Add(98,"Dark Flaaffy Holofoil");
CardDataNames.Add(99,"Dark Flaaffy Reverse Holo");
CardDataNames.Add(100,"Dark Golbat");
CardDataNames.Add(101,"Dark Golbat Holofoil");
CardDataNames.Add(102,"Dark Golbat Reverse Holo");
CardDataNames.Add(103,"Dark Golduck");
CardDataNames.Add(104,"Dark Golduck Holofoil");
CardDataNames.Add(105,"Dark Golduck Reverse Holo");
CardDataNames.Add(106,"Dark Gyarados");
CardDataNames.Add(107,"Dark Gyarados Holofoil");
CardDataNames.Add(108,"Dark Gyarados Reverse Holo");
CardDataNames.Add(109,"Dark Houndoom");
CardDataNames.Add(110,"Dark Houndoom Holofoil");
CardDataNames.Add(111,"Dark Houndoom Reverse Holo");
CardDataNames.Add(112,"Dark Magcargo");
CardDataNames.Add(113,"Dark Magcargo Holofoil");
CardDataNames.Add(114,"Dark Magcargo Reverse Holo");
CardDataNames.Add(115,"Dark Magneton");
CardDataNames.Add(116,"Dark Magneton Holofoil");
CardDataNames.Add(117,"Dark Magneton Reverse Holo");
CardDataNames.Add(118,"Dark Pupitar");
CardDataNames.Add(119,"Dark Pupitar Holofoil");
CardDataNames.Add(120,"Dark Pupitar Reverse Holo");
CardDataNames.Add(121,"Dark Pupitar");
CardDataNames.Add(122,"Dark Pupitar Holofoil");
CardDataNames.Add(123,"Dark Pupitar Reverse Holo");
CardDataNames.Add(124,"Dark Weezing");
CardDataNames.Add(125,"Dark Weezing Holofoil");
CardDataNames.Add(126,"Dark Weezing Reverse Holo");
CardDataNames.Add(127,"Heracross");
CardDataNames.Add(128,"Heracross Holofoil");
CardDataNames.Add(129,"Heracross Reverse Holo");
CardDataNames.Add(130,"Magmar");
CardDataNames.Add(131,"Magmar Holofoil");
CardDataNames.Add(132,"Magmar Reverse Holo");
CardDataNames.Add(133,"Mantine");
CardDataNames.Add(134,"Mantine Holofoil");
CardDataNames.Add(135,"Mantine Reverse Holo");
CardDataNames.Add(136,"Rocket's Meowth");
CardDataNames.Add(137,"Rocket's Meowth Holofoil");
CardDataNames.Add(138,"Rocket's Meowth Reverse Holo");
CardDataNames.Add(139,"Rocket's Wobbuffet");
CardDataNames.Add(140,"Rocket's Wobbuffet Holofoil");
CardDataNames.Add(141,"Rocket's Wobbuffet Reverse Holo");
CardDataNames.Add(142,"Seadra");
CardDataNames.Add(143,"Seadra Holofoil");
CardDataNames.Add(144,"Seadra Reverse Holo");
CardDataNames.Add(145,"Skiploom");
CardDataNames.Add(146,"Skiploom Holofoil");
CardDataNames.Add(147,"Skiploom Reverse Holo");
CardDataNames.Add(148,"Togepi");
CardDataNames.Add(149,"Togepi Holofoil");
CardDataNames.Add(150,"Togepi Reverse Holo");
CardDataNames.Add(151,"Cubone");
CardDataNames.Add(152,"Cubone Holofoil");
CardDataNames.Add(153,"Cubone Reverse Holo");
CardDataNames.Add(154,"Dratini");
CardDataNames.Add(155,"Dratini Holofoil");
CardDataNames.Add(156,"Dratini Reverse Holo");
CardDataNames.Add(157,"Dratini");
CardDataNames.Add(158,"Dratini Holofoil");
CardDataNames.Add(159,"Dratini Reverse Holo");
CardDataNames.Add(160,"Drowzee");
CardDataNames.Add(161,"Drowzee Holofoil");
CardDataNames.Add(162,"Drowzee Reverse Holo");
CardDataNames.Add(163,"Ekans");
CardDataNames.Add(164,"Ekans Holofoil");
CardDataNames.Add(165,"Ekans Reverse Holo");
CardDataNames.Add(166,"Grimer");
CardDataNames.Add(167,"Grimer Holofoil");
CardDataNames.Add(168,"Grimer Reverse Holo");
CardDataNames.Add(169,"Hoppip");
CardDataNames.Add(170,"Hoppip Holofoil");
CardDataNames.Add(171,"Hoppip Reverse Holo");
CardDataNames.Add(172,"Horsea");
CardDataNames.Add(173,"Horsea Holofoil");
CardDataNames.Add(174,"Horsea Reverse Holo");
CardDataNames.Add(175,"Houndour");
CardDataNames.Add(176,"Houndour Holofoil");
CardDataNames.Add(177,"Houndour Reverse Holo");
CardDataNames.Add(178,"Houndour");
CardDataNames.Add(179,"Houndour Holofoil");
CardDataNames.Add(180,"Houndour Reverse Holo");
CardDataNames.Add(181,"Koffing");
CardDataNames.Add(182,"Koffing Holofoil");
CardDataNames.Add(183,"Koffing Reverse Holo");
CardDataNames.Add(184,"Larvitar");
CardDataNames.Add(185,"Larvitar Holofoil");
CardDataNames.Add(186,"Larvitar Reverse Holo");
CardDataNames.Add(187,"Larvitar");
CardDataNames.Add(188,"Larvitar Holofoil");
CardDataNames.Add(189,"Larvitar Reverse Holo");
CardDataNames.Add(190,"Ledyba");
CardDataNames.Add(191,"Ledyba Holofoil");
CardDataNames.Add(192,"Ledyba Reverse Holo");
CardDataNames.Add(193,"Magikarp");
CardDataNames.Add(194,"Magikarp Holofoil");
CardDataNames.Add(195,"Magikarp Reverse Holo");
CardDataNames.Add(196,"Magnemite");
CardDataNames.Add(197,"Magnemite Holofoil");
CardDataNames.Add(198,"Magnemite Reverse Holo");
CardDataNames.Add(199,"Mareep");
CardDataNames.Add(200,"Mareep Holofoil");
CardDataNames.Add(201,"Mareep Reverse Holo");
CardDataNames.Add(202,"Marill");
CardDataNames.Add(203,"Marill Holofoil");
CardDataNames.Add(204,"Marill Reverse Holo");
CardDataNames.Add(205,"Onix");
CardDataNames.Add(206,"Onix Holofoil");
CardDataNames.Add(207,"Onix Reverse Holo");
CardDataNames.Add(208,"Psyduck");
CardDataNames.Add(209,"Psyduck Holofoil");
CardDataNames.Add(210,"Psyduck Reverse Holo");
CardDataNames.Add(211,"Rattata");
CardDataNames.Add(212,"Rattata Holofoil");
CardDataNames.Add(213,"Rattata Reverse Holo");
CardDataNames.Add(214,"Rattata");
CardDataNames.Add(215,"Rattata Holofoil");
CardDataNames.Add(216,"Rattata Reverse Holo");
CardDataNames.Add(217,"Remoraid");
CardDataNames.Add(218,"Remoraid Holofoil");
CardDataNames.Add(219,"Remoraid Reverse Holo");
CardDataNames.Add(220,"Sandshrew");
CardDataNames.Add(221,"Sandshrew Holofoil");
CardDataNames.Add(222,"Sandshrew Reverse Holo");
CardDataNames.Add(223,"Sentret");
CardDataNames.Add(224,"Sentret Holofoil");
CardDataNames.Add(225,"Sentret Reverse Holo");
CardDataNames.Add(226,"Slowpoke");
CardDataNames.Add(227,"Slowpoke Holofoil");
CardDataNames.Add(228,"Slowpoke Reverse Holo");
CardDataNames.Add(229,"Slugma");
CardDataNames.Add(230,"Slugma Holofoil");
CardDataNames.Add(231,"Slugma Reverse Holo");
CardDataNames.Add(232,"Spinarak");
CardDataNames.Add(233,"Spinarak Holofoil");
CardDataNames.Add(234,"Spinarak Reverse Holo");
CardDataNames.Add(235,"Swinub");
CardDataNames.Add(236,"Swinub Holofoil");
CardDataNames.Add(237,"Swinub Reverse Holo");
CardDataNames.Add(238,"Voltorb");
CardDataNames.Add(239,"Voltorb Holofoil");
CardDataNames.Add(240,"Voltorb Reverse Holo");
CardDataNames.Add(241,"Wooper");
CardDataNames.Add(242,"Wooper Holofoil");
CardDataNames.Add(243,"Wooper Reverse Holo");
CardDataNames.Add(244,"Zubat");
CardDataNames.Add(245,"Zubat Holofoil");
CardDataNames.Add(246,"Zubat Reverse Holo");
CardDataNames.Add(247,"Copycat");
CardDataNames.Add(248,"Copycat Holofoil");
CardDataNames.Add(249,"Copycat Reverse Holo");
CardDataNames.Add(250,"Pokémon Retriever");
CardDataNames.Add(251,"Pokémon Retriever Holofoil");
CardDataNames.Add(252,"Pokémon Retriever Reverse Holo");
CardDataNames.Add(253,"Pow! Hand Extension");
CardDataNames.Add(254,"Pow! Hand Extension Holofoil");
CardDataNames.Add(255,"Pow! Hand Extension Reverse Holo");
CardDataNames.Add(256,"Rocket's Admin");
CardDataNames.Add(257,"Rocket's Admin Holofoil");
CardDataNames.Add(258,"Rocket's Admin Reverse Holo");
CardDataNames.Add(259,"Rocket's Hideout");
CardDataNames.Add(260,"Rocket's Hideout Holofoil");
CardDataNames.Add(261,"Rocket's Hideout Reverse Holo");
CardDataNames.Add(262,"Rocket's Mission");
CardDataNames.Add(263,"Rocket's Mission Holofoil");
CardDataNames.Add(264,"Rocket's Mission Reverse Holo");
CardDataNames.Add(265,"Rocket's Poké Ball");
CardDataNames.Add(266,"Rocket's Poké Ball Holofoil");
CardDataNames.Add(267,"Rocket's Poké Ball Reverse Holo");
CardDataNames.Add(268,"Rocket's Tricky Gym");
CardDataNames.Add(269,"Rocket's Tricky Gym Holofoil");
CardDataNames.Add(270,"Rocket's Tricky Gym Reverse Holo");
CardDataNames.Add(271,"Suprise! Time Machine");
CardDataNames.Add(272,"Suprise! Time Machine Holofoil");
CardDataNames.Add(273,"Suprise! Time Machine Reverse Holo");
CardDataNames.Add(274,"Swoop! Teleporter");
CardDataNames.Add(275,"Swoop! Teleporter Holofoil");
CardDataNames.Add(276,"Swoop! Teleporter Reverse Holo");
CardDataNames.Add(277,"Venture Bomb");
CardDataNames.Add(278,"Venture Bomb Holofoil");
CardDataNames.Add(279,"Venture Bomb Reverse Holo");
CardDataNames.Add(280,"Dark-Metal Energy");
CardDataNames.Add(281,"Dark-Metal Energy Holofoil");
CardDataNames.Add(282,"Dark-Metal Energy Reverse Holo");
CardDataNames.Add(283,"R Energy");
CardDataNames.Add(284,"R Energy Holofoil");
CardDataNames.Add(285,"R Energy Reverse Holo");
CardDataNames.Add(286,"Rocket's Articuno ex");
CardDataNames.Add(287,"Rocket's Entei ex");
CardDataNames.Add(288,"Rocket's Hitmonchan ex");
CardDataNames.Add(289,"Rocket's Mewtwo ex");
CardDataNames.Add(290,"Rocket's Moltres ex");
CardDataNames.Add(291,"Rocket's Scizor ex");
CardDataNames.Add(292,"Rocket's Scyther ex");
CardDataNames.Add(293,"Rocket's Sneasel ex");
CardDataNames.Add(294,"Rocket's Snorlax ex");
CardDataNames.Add(295,"Rocket's Suicune ex");
CardDataNames.Add(296,"Rocket's Zapdos ex");
CardDataNames.Add(297,"Mudkip");
CardDataNames.Add(298,"Mudkip Holofoil");
CardDataNames.Add(299,"Mudkip Reverse Holo");
CardDataNames.Add(300,"Torchic");
CardDataNames.Add(301,"Torchic Holofoil");
CardDataNames.Add(302,"Torchic Reverse Holo");
CardDataNames.Add(303,"Treecko");
CardDataNames.Add(304,"Treecko Holofoil");
CardDataNames.Add(305,"Treecko Reverse Holo");
CardDataNames.Add(306,"Charmeleon");
CardDataNames.Add(307,"Charmeleon Holofoil");
CardDataNames.Add(308,"Charmeleon Reverse Holo");
CardDataNames.Add(309,"Here Comes Team Rocket");
CardDataNames.Add(310,"Here Comes Team Rocket Holofoil");
CardDataNames.Add(311,"Here Comes Team Rocket Reverse Holo");
	}

	public void SetCardValues() {
CardDataValues.Add(1,17.38);
CardDataValues.Add(2,83.424);
CardDataValues.Add(3,41.712);
CardDataValues.Add(4,45.91);
CardDataValues.Add(5,220.368);
CardDataValues.Add(6,110.184);
CardDataValues.Add(7,18.12);
CardDataValues.Add(8,86.976);
CardDataValues.Add(9,43.488);
CardDataValues.Add(10,24.87);
CardDataValues.Add(11,119.376);
CardDataValues.Add(12,59.688);
CardDataValues.Add(13,37.6);
CardDataValues.Add(14,180.48);
CardDataValues.Add(15,90.24);
CardDataValues.Add(16,19.08);
CardDataValues.Add(17,91.584);
CardDataValues.Add(18,45.792);
CardDataValues.Add(19,25.98);
CardDataValues.Add(20,124.704);
CardDataValues.Add(21,62.352);
CardDataValues.Add(22,13.33);
CardDataValues.Add(23,63.984);
CardDataValues.Add(24,31.992);
CardDataValues.Add(25,49.99);
CardDataValues.Add(26,239.952);
CardDataValues.Add(27,119.976);
CardDataValues.Add(28,27.2);
CardDataValues.Add(29,130.56);
CardDataValues.Add(30,65.28);
CardDataValues.Add(31,6.4);
CardDataValues.Add(32,30.72);
CardDataValues.Add(33,15.36);
CardDataValues.Add(34,18.19);
CardDataValues.Add(35,87.312);
CardDataValues.Add(36,43.656);
CardDataValues.Add(37,15.01);
CardDataValues.Add(38,72.048);
CardDataValues.Add(39,36.024);
CardDataValues.Add(40,31.73);
CardDataValues.Add(41,152.304);
CardDataValues.Add(42,76.152);
CardDataValues.Add(43,17.49);
CardDataValues.Add(44,83.952);
CardDataValues.Add(45,41.976);
CardDataValues.Add(46,2.52);
CardDataValues.Add(47,12.096);
CardDataValues.Add(48,6.048);
CardDataValues.Add(49,2.05);
CardDataValues.Add(50,9.84);
CardDataValues.Add(51,4.92);
CardDataValues.Add(52,5.05);
CardDataValues.Add(53,24.24);
CardDataValues.Add(54,12.12);
CardDataValues.Add(55,11.2);
CardDataValues.Add(56,53.76);
CardDataValues.Add(57,26.88);
CardDataValues.Add(58,10.21);
CardDataValues.Add(59,49.008);
CardDataValues.Add(60,24.504);
CardDataValues.Add(61,2.49);
CardDataValues.Add(62,11.952);
CardDataValues.Add(63,5.976);
CardDataValues.Add(64,3.97);
CardDataValues.Add(65,19.056);
CardDataValues.Add(66,9.528);
CardDataValues.Add(67,1);
CardDataValues.Add(68,4.8);
CardDataValues.Add(69,2.4);
CardDataValues.Add(70,2.25);
CardDataValues.Add(71,10.8);
CardDataValues.Add(72,5.4);
CardDataValues.Add(73,1);
CardDataValues.Add(74,4.8);
CardDataValues.Add(75,2.4);
CardDataValues.Add(76,1.2);
CardDataValues.Add(77,5.76);
CardDataValues.Add(78,2.88);
CardDataValues.Add(79,0.85);
CardDataValues.Add(80,4.08);
CardDataValues.Add(81,2.04);
CardDataValues.Add(82,2.51);
CardDataValues.Add(83,12.048);
CardDataValues.Add(84,6.024);
CardDataValues.Add(85,1.94);
CardDataValues.Add(86,9.312);
CardDataValues.Add(87,4.656);
CardDataValues.Add(88,2.75);
CardDataValues.Add(89,13.2);
CardDataValues.Add(90,6.6);
CardDataValues.Add(91,2.18);
CardDataValues.Add(92,10.464);
CardDataValues.Add(93,5.232);
CardDataValues.Add(94,6.18);
CardDataValues.Add(95,29.664);
CardDataValues.Add(96,14.832);
CardDataValues.Add(97,2.8);
CardDataValues.Add(98,13.44);
CardDataValues.Add(99,6.72);
CardDataValues.Add(100,1.6);
CardDataValues.Add(101,7.68);
CardDataValues.Add(102,3.84);
CardDataValues.Add(103,2.15);
CardDataValues.Add(104,10.32);
CardDataValues.Add(105,5.16);
CardDataValues.Add(106,12.25);
CardDataValues.Add(107,58.8);
CardDataValues.Add(108,29.4);
CardDataValues.Add(109,4.99);
CardDataValues.Add(110,23.952);
CardDataValues.Add(111,11.976);
CardDataValues.Add(112,1.49);
CardDataValues.Add(113,7.152);
CardDataValues.Add(114,3.576);
CardDataValues.Add(115,1.87);
CardDataValues.Add(116,8.976);
CardDataValues.Add(117,4.488);
CardDataValues.Add(118,1.34);
CardDataValues.Add(119,6.432);
CardDataValues.Add(120,3.216);
CardDataValues.Add(121,4.49);
CardDataValues.Add(122,21.552);
CardDataValues.Add(123,10.776);
CardDataValues.Add(124,1.01);
CardDataValues.Add(125,4.848);
CardDataValues.Add(126,2.424);
CardDataValues.Add(127,2.36);
CardDataValues.Add(128,11.328);
CardDataValues.Add(129,5.664);
CardDataValues.Add(130,2.32);
CardDataValues.Add(131,11.136);
CardDataValues.Add(132,5.568);
CardDataValues.Add(133,0.75);
CardDataValues.Add(134,3.6);
CardDataValues.Add(135,1.8);
CardDataValues.Add(136,2.49);
CardDataValues.Add(137,11.952);
CardDataValues.Add(138,5.976);
CardDataValues.Add(139,1.25);
CardDataValues.Add(140,6);
CardDataValues.Add(141,3);
CardDataValues.Add(142,1.73);
CardDataValues.Add(143,8.304);
CardDataValues.Add(144,4.152);
CardDataValues.Add(145,0.56);
CardDataValues.Add(146,2.688);
CardDataValues.Add(147,1.344);
CardDataValues.Add(148,3.71);
CardDataValues.Add(149,17.808);
CardDataValues.Add(150,8.904);
CardDataValues.Add(151,0.56);
CardDataValues.Add(152,2.688);
CardDataValues.Add(153,1.344);
CardDataValues.Add(154,0.5);
CardDataValues.Add(155,2.4);
CardDataValues.Add(156,1.2);
CardDataValues.Add(157,1.95);
CardDataValues.Add(158,9.36);
CardDataValues.Add(159,4.68);
CardDataValues.Add(160,0.5);
CardDataValues.Add(161,2.4);
CardDataValues.Add(162,1.2);
CardDataValues.Add(163,0.33);
CardDataValues.Add(164,1.584);
CardDataValues.Add(165,0.792);
CardDataValues.Add(166,0.49);
CardDataValues.Add(167,2.352);
CardDataValues.Add(168,1.176);
CardDataValues.Add(169,0.35);
CardDataValues.Add(170,1.68);
CardDataValues.Add(171,0.84);
CardDataValues.Add(172,0.63);
CardDataValues.Add(173,3.024);
CardDataValues.Add(174,1.512);
CardDataValues.Add(175,1.09);
CardDataValues.Add(176,5.232);
CardDataValues.Add(177,2.616);
CardDataValues.Add(178,1.49);
CardDataValues.Add(179,7.152);
CardDataValues.Add(180,3.576);
CardDataValues.Add(181,0.46);
CardDataValues.Add(182,2.208);
CardDataValues.Add(183,1.104);
CardDataValues.Add(184,0.47);
CardDataValues.Add(185,2.256);
CardDataValues.Add(186,1.128);
CardDataValues.Add(187,1);
CardDataValues.Add(188,4.8);
CardDataValues.Add(189,2.4);
CardDataValues.Add(190,0.6);
CardDataValues.Add(191,2.88);
CardDataValues.Add(192,1.44);
CardDataValues.Add(193,1.4);
CardDataValues.Add(194,6.72);
CardDataValues.Add(195,3.36);
CardDataValues.Add(196,0.39);
CardDataValues.Add(197,1.872);
CardDataValues.Add(198,0.936);
CardDataValues.Add(199,0.57);
CardDataValues.Add(200,2.736);
CardDataValues.Add(201,1.368);
CardDataValues.Add(202,0.39);
CardDataValues.Add(203,1.872);
CardDataValues.Add(204,0.936);
CardDataValues.Add(205,0.75);
CardDataValues.Add(206,3.6);
CardDataValues.Add(207,1.8);
CardDataValues.Add(208,1.99);
CardDataValues.Add(209,9.552);
CardDataValues.Add(210,4.776);
CardDataValues.Add(211,0.68);
CardDataValues.Add(212,3.264);
CardDataValues.Add(213,1.632);
CardDataValues.Add(214,0.49);
CardDataValues.Add(215,2.352);
CardDataValues.Add(216,1.176);
CardDataValues.Add(217,0.49);
CardDataValues.Add(218,2.352);
CardDataValues.Add(219,1.176);
CardDataValues.Add(220,0.52);
CardDataValues.Add(221,2.496);
CardDataValues.Add(222,1.248);
CardDataValues.Add(223,0.43);
CardDataValues.Add(224,2.064);
CardDataValues.Add(225,1.032);
CardDataValues.Add(226,0.61);
CardDataValues.Add(227,2.928);
CardDataValues.Add(228,1.464);
CardDataValues.Add(229,0.4);
CardDataValues.Add(230,1.92);
CardDataValues.Add(231,0.96);
CardDataValues.Add(232,0.68);
CardDataValues.Add(233,3.264);
CardDataValues.Add(234,1.632);
CardDataValues.Add(235,0.65);
CardDataValues.Add(236,3.12);
CardDataValues.Add(237,1.56);
CardDataValues.Add(238,0.61);
CardDataValues.Add(239,2.928);
CardDataValues.Add(240,1.464);
CardDataValues.Add(241,0.49);
CardDataValues.Add(242,2.352);
CardDataValues.Add(243,1.176);
CardDataValues.Add(244,0.5);
CardDataValues.Add(245,2.4);
CardDataValues.Add(246,1.2);
CardDataValues.Add(247,4.44);
CardDataValues.Add(248,21.312);
CardDataValues.Add(249,10.656);
CardDataValues.Add(250,1.8);
CardDataValues.Add(251,8.64);
CardDataValues.Add(252,4.32);
CardDataValues.Add(253,11.23);
CardDataValues.Add(254,53.904);
CardDataValues.Add(255,26.952);
CardDataValues.Add(256,17.09);
CardDataValues.Add(257,82.032);
CardDataValues.Add(258,41.016);
CardDataValues.Add(259,2.25);
CardDataValues.Add(260,10.8);
CardDataValues.Add(261,5.4);
CardDataValues.Add(262,0.59);
CardDataValues.Add(263,2.832);
CardDataValues.Add(264,1.416);
CardDataValues.Add(265,2.99);
CardDataValues.Add(266,14.352);
CardDataValues.Add(267,7.176);
CardDataValues.Add(268,1.64);
CardDataValues.Add(269,7.872);
CardDataValues.Add(270,3.936);
CardDataValues.Add(271,3.6);
CardDataValues.Add(272,17.28);
CardDataValues.Add(273,8.64);
CardDataValues.Add(274,19.49);
CardDataValues.Add(275,93.552);
CardDataValues.Add(276,46.776);
CardDataValues.Add(277,1);
CardDataValues.Add(278,4.8);
CardDataValues.Add(279,2.4);
CardDataValues.Add(280,3.63);
CardDataValues.Add(281,17.424);
CardDataValues.Add(282,8.712);
CardDataValues.Add(283,4.5);
CardDataValues.Add(284,21.6);
CardDataValues.Add(285,10.8);
CardDataValues.Add(286,87.95);
CardDataValues.Add(287,164.85);
CardDataValues.Add(288,127.48);
CardDataValues.Add(289,400);
CardDataValues.Add(290,124.99);
CardDataValues.Add(291,179.98);
CardDataValues.Add(292,185);
CardDataValues.Add(293,135);
CardDataValues.Add(294,278.66);
CardDataValues.Add(295,220);
CardDataValues.Add(296,69.99);
CardDataValues.Add(297,999.99);
CardDataValues.Add(298,4799.952);
CardDataValues.Add(299,2399.976);
CardDataValues.Add(300,650);
CardDataValues.Add(301,3120);
CardDataValues.Add(302,1560);
CardDataValues.Add(303,450);
CardDataValues.Add(304,2160);
CardDataValues.Add(305,1080);
CardDataValues.Add(306,67.74);
CardDataValues.Add(307,325.152);
CardDataValues.Add(308,162.576);
CardDataValues.Add(309,143.46);
CardDataValues.Add(310,688.608);
CardDataValues.Add(311,344.304);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}