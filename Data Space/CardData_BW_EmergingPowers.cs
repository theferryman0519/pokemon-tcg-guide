using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_BW_EmergingPowers : MonoBehaviour {
		
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
CardDataNumbers.Add(290,"97H");
CardDataNumbers.Add(291,"97RH");
CardDataNumbers.Add(292,"98");
CardDataNumbers.Add(293,"98H");
CardDataNumbers.Add(294,"98RH");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Pansage");
CardDataNames.Add(2,"Pansage Holofoil");
CardDataNames.Add(3,"Pansage Reverse Holo");
CardDataNames.Add(4,"Simisage");
CardDataNames.Add(5,"Simisage Holofoil");
CardDataNames.Add(6,"Simisage Reverse Holo");
CardDataNames.Add(7,"Sewaddle");
CardDataNames.Add(8,"Sewaddle Holofoil");
CardDataNames.Add(9,"Sewaddle Reverse Holo");
CardDataNames.Add(10,"Sewaddle");
CardDataNames.Add(11,"Sewaddle Holofoil");
CardDataNames.Add(12,"Sewaddle Reverse Holo");
CardDataNames.Add(13,"Swadloon");
CardDataNames.Add(14,"Swadloon Holofoil");
CardDataNames.Add(15,"Swadloon Reverse Holo");
CardDataNames.Add(16,"Swadloon");
CardDataNames.Add(17,"Swadloon Holofoil");
CardDataNames.Add(18,"Swadloon Reverse Holo");
CardDataNames.Add(19,"Leavanny");
CardDataNames.Add(20,"Leavanny Holofoil");
CardDataNames.Add(21,"Leavanny Reverse Holo");
CardDataNames.Add(22,"Leavanny");
CardDataNames.Add(23,"Leavanny Holofoil");
CardDataNames.Add(24,"Leavanny Reverse Holo");
CardDataNames.Add(25,"Cottonee");
CardDataNames.Add(26,"Cottonee Holofoil");
CardDataNames.Add(27,"Cottonee Reverse Holo");
CardDataNames.Add(28,"Cottonee");
CardDataNames.Add(29,"Cottonee Holofoil");
CardDataNames.Add(30,"Cottonee Reverse Holo");
CardDataNames.Add(31,"Whimsicott");
CardDataNames.Add(32,"Whimsicott Holofoil");
CardDataNames.Add(33,"Whimsicott Reverse Holo");
CardDataNames.Add(34,"Whimsicott");
CardDataNames.Add(35,"Whimsicott Holofoil");
CardDataNames.Add(36,"Whimsicott Reverse Holo");
CardDataNames.Add(37,"Petilil");
CardDataNames.Add(38,"Petilil Holofoil");
CardDataNames.Add(39,"Petilil Reverse Holo");
CardDataNames.Add(40,"Lilligant");
CardDataNames.Add(41,"Lilligant Holofoil");
CardDataNames.Add(42,"Lilligant Reverse Holo");
CardDataNames.Add(43,"Deerling");
CardDataNames.Add(44,"Deerling Holofoil");
CardDataNames.Add(45,"Deerling Reverse Holo");
CardDataNames.Add(46,"Sawsbuck");
CardDataNames.Add(47,"Sawsbuck Holofoil");
CardDataNames.Add(48,"Sawsbuck Reverse Holo");
CardDataNames.Add(49,"Virizion");
CardDataNames.Add(50,"Virizion Holofoil");
CardDataNames.Add(51,"Virizion Reverse Holo");
CardDataNames.Add(52,"Pansear");
CardDataNames.Add(53,"Pansear Holofoil");
CardDataNames.Add(54,"Pansear Reverse Holo");
CardDataNames.Add(55,"Simisear");
CardDataNames.Add(56,"Simisear Holofoil");
CardDataNames.Add(57,"Simisear Reverse Holo");
CardDataNames.Add(58,"Darumaka");
CardDataNames.Add(59,"Darumaka Holofoil");
CardDataNames.Add(60,"Darumaka Reverse Holo");
CardDataNames.Add(61,"Darmanitan");
CardDataNames.Add(62,"Darmanitan Holofoil");
CardDataNames.Add(63,"Darmanitan Reverse Holo");
CardDataNames.Add(64,"Panpour");
CardDataNames.Add(65,"Panpour Holofoil");
CardDataNames.Add(66,"Panpour Reverse Holo");
CardDataNames.Add(67,"Simipour");
CardDataNames.Add(68,"Simipour Holofoil");
CardDataNames.Add(69,"Simipour Reverse Holo");
CardDataNames.Add(70,"Basculin");
CardDataNames.Add(71,"Basculin Holofoil");
CardDataNames.Add(72,"Basculin Reverse Holo");
CardDataNames.Add(73,"Basculin");
CardDataNames.Add(74,"Basculin Holofoil");
CardDataNames.Add(75,"Basculin Reverse Holo");
CardDataNames.Add(76,"Ducklett");
CardDataNames.Add(77,"Ducklett Holofoil");
CardDataNames.Add(78,"Ducklett Reverse Holo");
CardDataNames.Add(79,"Swanna");
CardDataNames.Add(80,"Swanna Holofoil");
CardDataNames.Add(81,"Swanna Reverse Holo");
CardDataNames.Add(82,"Cubchoo");
CardDataNames.Add(83,"Cubchoo Holofoil");
CardDataNames.Add(84,"Cubchoo Reverse Holo");
CardDataNames.Add(85,"Cubchoo");
CardDataNames.Add(86,"Cubchoo Holofoil");
CardDataNames.Add(87,"Cubchoo Reverse Holo");
CardDataNames.Add(88,"Beartic");
CardDataNames.Add(89,"Beartic Holofoil");
CardDataNames.Add(90,"Beartic Reverse Holo");
CardDataNames.Add(91,"Beartic");
CardDataNames.Add(92,"Beartic Holofoil");
CardDataNames.Add(93,"Beartic Reverse Holo");
CardDataNames.Add(94,"Emolga");
CardDataNames.Add(95,"Emolga Holofoil");
CardDataNames.Add(96,"Emolga Reverse Holo");
CardDataNames.Add(97,"Joltik");
CardDataNames.Add(98,"Joltik Holofoil");
CardDataNames.Add(99,"Joltik Reverse Holo");
CardDataNames.Add(100,"Galvantula");
CardDataNames.Add(101,"Galvantula Holofoil");
CardDataNames.Add(102,"Galvantula Reverse Holo");
CardDataNames.Add(103,"Thundurus");
CardDataNames.Add(104,"Thundurus Holofoil");
CardDataNames.Add(105,"Thundurus Reverse Holo");
CardDataNames.Add(106,"Woobat");
CardDataNames.Add(107,"Woobat Holofoil");
CardDataNames.Add(108,"Woobat Reverse Holo");
CardDataNames.Add(109,"Swoobat");
CardDataNames.Add(110,"Swoobat Holofoil");
CardDataNames.Add(111,"Swoobat Reverse Holo");
CardDataNames.Add(112,"Venipede");
CardDataNames.Add(113,"Venipede Holofoil");
CardDataNames.Add(114,"Venipede Reverse Holo");
CardDataNames.Add(115,"Whirlipede");
CardDataNames.Add(116,"Whirlipede Holofoil");
CardDataNames.Add(117,"Whirlipede Reverse Holo");
CardDataNames.Add(118,"Scolipede");
CardDataNames.Add(119,"Scolipede Holofoil");
CardDataNames.Add(120,"Scolipede Reverse Holo");
CardDataNames.Add(121,"Sigilyph");
CardDataNames.Add(122,"Sigilyph Holofoil");
CardDataNames.Add(123,"Sigilyph Reverse Holo");
CardDataNames.Add(124,"Sigilyph");
CardDataNames.Add(125,"Sigilyph Holofoil");
CardDataNames.Add(126,"Sigilyph Reverse Holo");
CardDataNames.Add(127,"Gothita");
CardDataNames.Add(128,"Gothita Holofoil");
CardDataNames.Add(129,"Gothita Reverse Holo");
CardDataNames.Add(130,"Gothita");
CardDataNames.Add(131,"Gothita Holofoil");
CardDataNames.Add(132,"Gothita Reverse Holo");
CardDataNames.Add(133,"Gothorita");
CardDataNames.Add(134,"Gothorita Holofoil");
CardDataNames.Add(135,"Gothorita Reverse Holo");
CardDataNames.Add(136,"Gothorita");
CardDataNames.Add(137,"Gothorita Holofoil");
CardDataNames.Add(138,"Gothorita Reverse Holo");
CardDataNames.Add(139,"Gothitelle");
CardDataNames.Add(140,"Gothitelle Holofoil");
CardDataNames.Add(141,"Gothitelle Reverse Holo");
CardDataNames.Add(142,"Gothitelle");
CardDataNames.Add(143,"Gothitelle Holofoil");
CardDataNames.Add(144,"Gothitelle Reverse Holo");
CardDataNames.Add(145,"Roggenrola");
CardDataNames.Add(146,"Roggenrola Holofoil");
CardDataNames.Add(147,"Roggenrola Reverse Holo");
CardDataNames.Add(148,"Roggenrola");
CardDataNames.Add(149,"Roggenrola Holofoil");
CardDataNames.Add(150,"Roggenrola Reverse Holo");
CardDataNames.Add(151,"Boldore");
CardDataNames.Add(152,"Boldore Holofoil");
CardDataNames.Add(153,"Boldore Reverse Holo");
CardDataNames.Add(154,"Boldore");
CardDataNames.Add(155,"Boldore Holofoil");
CardDataNames.Add(156,"Boldore Reverse Holo");
CardDataNames.Add(157,"Gigalith");
CardDataNames.Add(158,"Gigalith Holofoil");
CardDataNames.Add(159,"Gigalith Reverse Holo");
CardDataNames.Add(160,"Drilbur");
CardDataNames.Add(161,"Drilbur Holofoil");
CardDataNames.Add(162,"Drilbur Reverse Holo");
CardDataNames.Add(163,"Drilbur");
CardDataNames.Add(164,"Drilbur Holofoil");
CardDataNames.Add(165,"Drilbur Reverse Holo");
CardDataNames.Add(166,"Excadrill");
CardDataNames.Add(167,"Excadrill Holofoil");
CardDataNames.Add(168,"Excadrill Reverse Holo");
CardDataNames.Add(169,"Excadrill");
CardDataNames.Add(170,"Excadrill Holofoil");
CardDataNames.Add(171,"Excadrill Reverse Holo");
CardDataNames.Add(172,"Throh");
CardDataNames.Add(173,"Throh Holofoil");
CardDataNames.Add(174,"Throh Reverse Holo");
CardDataNames.Add(175,"Sawk");
CardDataNames.Add(176,"Sawk Holofoil");
CardDataNames.Add(177,"Sawk Reverse Holo");
CardDataNames.Add(178,"Sandile");
CardDataNames.Add(179,"Sandile Holofoil");
CardDataNames.Add(180,"Sandile Reverse Holo");
CardDataNames.Add(181,"Krokorok");
CardDataNames.Add(182,"Krokorok Holofoil");
CardDataNames.Add(183,"Krokorok Reverse Holo");
CardDataNames.Add(184,"Krookodile");
CardDataNames.Add(185,"Krookodile Holofoil");
CardDataNames.Add(186,"Krookodile Reverse Holo");
CardDataNames.Add(187,"Terrakion");
CardDataNames.Add(188,"Terrakion Holofoil");
CardDataNames.Add(189,"Terrakion Reverse Holo");
CardDataNames.Add(190,"Purrloin");
CardDataNames.Add(191,"Purrloin Holofoil");
CardDataNames.Add(192,"Purrloin Reverse Holo");
CardDataNames.Add(193,"Liepard");
CardDataNames.Add(194,"Liepard Holofoil");
CardDataNames.Add(195,"Liepard Reverse Holo");
CardDataNames.Add(196,"Zorua");
CardDataNames.Add(197,"Zorua Holofoil");
CardDataNames.Add(198,"Zorua Reverse Holo");
CardDataNames.Add(199,"Zoroark");
CardDataNames.Add(200,"Zoroark Holofoil");
CardDataNames.Add(201,"Zoroark Reverse Holo");
CardDataNames.Add(202,"Vullaby");
CardDataNames.Add(203,"Vullaby Holofoil");
CardDataNames.Add(204,"Vullaby Reverse Holo");
CardDataNames.Add(205,"Mandibuzz");
CardDataNames.Add(206,"Mandibuzz Holofoil");
CardDataNames.Add(207,"Mandibuzz Reverse Holo");
CardDataNames.Add(208,"Ferroseed");
CardDataNames.Add(209,"Ferroseed Holofoil");
CardDataNames.Add(210,"Ferroseed Reverse Holo");
CardDataNames.Add(211,"Ferroseed");
CardDataNames.Add(212,"Ferroseed Holofoil");
CardDataNames.Add(213,"Ferroseed Reverse Holo");
CardDataNames.Add(214,"Ferrothorn");
CardDataNames.Add(215,"Ferrothorn Holofoil");
CardDataNames.Add(216,"Ferrothorn Reverse Holo");
CardDataNames.Add(217,"Ferrothorn");
CardDataNames.Add(218,"Ferrothorn Holofoil");
CardDataNames.Add(219,"Ferrothorn Reverse Holo");
CardDataNames.Add(220,"Klink");
CardDataNames.Add(221,"Klink Holofoil");
CardDataNames.Add(222,"Klink Reverse Holo");
CardDataNames.Add(223,"Klang");
CardDataNames.Add(224,"Klang Holofoil");
CardDataNames.Add(225,"Klang Reverse Holo");
CardDataNames.Add(226,"Klinklang");
CardDataNames.Add(227,"Klinklang Holofoil");
CardDataNames.Add(228,"Klinklang Reverse Holo");
CardDataNames.Add(229,"Cobalion");
CardDataNames.Add(230,"Cobalion Holofoil");
CardDataNames.Add(231,"Cobalion Reverse Holo");
CardDataNames.Add(232,"Patrat");
CardDataNames.Add(233,"Patrat Holofoil");
CardDataNames.Add(234,"Patrat Reverse Holo");
CardDataNames.Add(235,"Watchog");
CardDataNames.Add(236,"Watchog Holofoil");
CardDataNames.Add(237,"Watchog Reverse Holo");
CardDataNames.Add(238,"Pidove");
CardDataNames.Add(239,"Pidove Holofoil");
CardDataNames.Add(240,"Pidove Reverse Holo");
CardDataNames.Add(241,"Tranquill");
CardDataNames.Add(242,"Tranquill Holofoil");
CardDataNames.Add(243,"Tranquill Reverse Holo");
CardDataNames.Add(244,"Unfezant");
CardDataNames.Add(245,"Unfezant Holofoil");
CardDataNames.Add(246,"Unfezant Reverse Holo");
CardDataNames.Add(247,"Audino");
CardDataNames.Add(248,"Audino Holofoil");
CardDataNames.Add(249,"Audino Reverse Holo");
CardDataNames.Add(250,"Minccino");
CardDataNames.Add(251,"Minccino Holofoil");
CardDataNames.Add(252,"Minccino Reverse Holo");
CardDataNames.Add(253,"Cinccino");
CardDataNames.Add(254,"Cinccino Holofoil");
CardDataNames.Add(255,"Cinccino Reverse Holo");
CardDataNames.Add(256,"Rufflet");
CardDataNames.Add(257,"Rufflet Holofoil");
CardDataNames.Add(258,"Rufflet Reverse Holo");
CardDataNames.Add(259,"Rufflet");
CardDataNames.Add(260,"Rufflet Holofoil");
CardDataNames.Add(261,"Rufflet Reverse Holo");
CardDataNames.Add(262,"Braviary");
CardDataNames.Add(263,"Braviary Holofoil");
CardDataNames.Add(264,"Braviary Reverse Holo");
CardDataNames.Add(265,"Tornadus");
CardDataNames.Add(266,"Tornadus Holofoil");
CardDataNames.Add(267,"Tornadus Reverse Holo");
CardDataNames.Add(268,"Bianca");
CardDataNames.Add(269,"Bianca Holofoil");
CardDataNames.Add(270,"Bianca Reverse Holo");
CardDataNames.Add(271,"Cheren");
CardDataNames.Add(272,"Cheren Holofoil");
CardDataNames.Add(273,"Cheren Reverse Holo");
CardDataNames.Add(274,"Crush Hammer");
CardDataNames.Add(275,"Crush Hammer Holofoil");
CardDataNames.Add(276,"Crush Hammer Reverse Holo");
CardDataNames.Add(277,"Great Ball");
CardDataNames.Add(278,"Great Ball Holofoil");
CardDataNames.Add(279,"Great Ball Reverse Holo");
CardDataNames.Add(280,"Max Potion");
CardDataNames.Add(281,"Max Potion Holofoil");
CardDataNames.Add(282,"Max Potion Reverse Holo");
CardDataNames.Add(283,"Pokémon Catcher");
CardDataNames.Add(284,"Pokémon Catcher Holofoil");
CardDataNames.Add(285,"Pokémon Catcher Reverse Holo");
CardDataNames.Add(286,"Recycle");
CardDataNames.Add(287,"Recycle Holofoil");
CardDataNames.Add(288,"Recycle Reverse Holo");
CardDataNames.Add(289,"Thundurus");
CardDataNames.Add(290,"Thundurus Holofoil");
CardDataNames.Add(291,"Thundurus Reverse Holo");
CardDataNames.Add(292,"Tornadus");
CardDataNames.Add(293,"Tornadus Holofoil");
CardDataNames.Add(294,"Tornadus Reverse Holo");
	}

	public void SetCardValues() {
CardDataValues.Add(1,0.25);
CardDataValues.Add(2,1.2);
CardDataValues.Add(3,0.6);
CardDataValues.Add(4,0.5);
CardDataValues.Add(5,2.4);
CardDataValues.Add(6,1.2);
CardDataValues.Add(7,0.25);
CardDataValues.Add(8,1.2);
CardDataValues.Add(9,0.6);
CardDataValues.Add(10,0.25);
CardDataValues.Add(11,1.2);
CardDataValues.Add(12,0.6);
CardDataValues.Add(13,0.25);
CardDataValues.Add(14,1.2);
CardDataValues.Add(15,0.6);
CardDataValues.Add(16,0.36);
CardDataValues.Add(17,1.728);
CardDataValues.Add(18,0.864);
CardDataValues.Add(19,0.8);
CardDataValues.Add(20,3.84);
CardDataValues.Add(21,1.92);
CardDataValues.Add(22,0.8);
CardDataValues.Add(23,3.84);
CardDataValues.Add(24,1.92);
CardDataValues.Add(25,0.25);
CardDataValues.Add(26,1.2);
CardDataValues.Add(27,0.6);
CardDataValues.Add(28,0.26);
CardDataValues.Add(29,1.248);
CardDataValues.Add(30,0.624);
CardDataValues.Add(31,0.38);
CardDataValues.Add(32,1.824);
CardDataValues.Add(33,0.912);
CardDataValues.Add(34,0.69);
CardDataValues.Add(35,3.312);
CardDataValues.Add(36,1.656);
CardDataValues.Add(37,0.25);
CardDataValues.Add(38,1.2);
CardDataValues.Add(39,0.6);
CardDataValues.Add(40,0.34);
CardDataValues.Add(41,1.632);
CardDataValues.Add(42,0.816);
CardDataValues.Add(43,0.25);
CardDataValues.Add(44,1.2);
CardDataValues.Add(45,0.6);
CardDataValues.Add(46,2);
CardDataValues.Add(47,9.6);
CardDataValues.Add(48,4.8);
CardDataValues.Add(49,1.36);
CardDataValues.Add(50,6.528);
CardDataValues.Add(51,3.264);
CardDataValues.Add(52,0.25);
CardDataValues.Add(53,1.2);
CardDataValues.Add(54,0.6);
CardDataValues.Add(55,0.49);
CardDataValues.Add(56,2.352);
CardDataValues.Add(57,1.176);
CardDataValues.Add(58,0.25);
CardDataValues.Add(59,1.2);
CardDataValues.Add(60,0.6);
CardDataValues.Add(61,0.75);
CardDataValues.Add(62,3.6);
CardDataValues.Add(63,1.8);
CardDataValues.Add(64,0.25);
CardDataValues.Add(65,1.2);
CardDataValues.Add(66,0.6);
CardDataValues.Add(67,0.5);
CardDataValues.Add(68,2.4);
CardDataValues.Add(69,1.2);
CardDataValues.Add(70,0.25);
CardDataValues.Add(71,1.2);
CardDataValues.Add(72,0.6);
CardDataValues.Add(73,0.26);
CardDataValues.Add(74,1.248);
CardDataValues.Add(75,0.624);
CardDataValues.Add(76,0.25);
CardDataValues.Add(77,1.2);
CardDataValues.Add(78,0.6);
CardDataValues.Add(79,0.49);
CardDataValues.Add(80,2.352);
CardDataValues.Add(81,1.176);
CardDataValues.Add(82,0.25);
CardDataValues.Add(83,1.2);
CardDataValues.Add(84,0.6);
CardDataValues.Add(85,0.3);
CardDataValues.Add(86,1.44);
CardDataValues.Add(87,0.72);
CardDataValues.Add(88,1.08);
CardDataValues.Add(89,5.184);
CardDataValues.Add(90,2.592);
CardDataValues.Add(91,0.73);
CardDataValues.Add(92,3.504);
CardDataValues.Add(93,1.752);
CardDataValues.Add(94,0.27);
CardDataValues.Add(95,1.296);
CardDataValues.Add(96,0.648);
CardDataValues.Add(97,0.25);
CardDataValues.Add(98,1.2);
CardDataValues.Add(99,0.6);
CardDataValues.Add(100,0.32);
CardDataValues.Add(101,1.536);
CardDataValues.Add(102,0.768);
CardDataValues.Add(103,1.25);
CardDataValues.Add(104,6);
CardDataValues.Add(105,3);
CardDataValues.Add(106,0.25);
CardDataValues.Add(107,1.2);
CardDataValues.Add(108,0.6);
CardDataValues.Add(109,0.5);
CardDataValues.Add(110,2.4);
CardDataValues.Add(111,1.2);
CardDataValues.Add(112,0.25);
CardDataValues.Add(113,1.2);
CardDataValues.Add(114,0.6);
CardDataValues.Add(115,0.27);
CardDataValues.Add(116,1.296);
CardDataValues.Add(117,0.648);
CardDataValues.Add(118,0.55);
CardDataValues.Add(119,2.64);
CardDataValues.Add(120,1.32);
CardDataValues.Add(121,0.39);
CardDataValues.Add(122,1.872);
CardDataValues.Add(123,0.936);
CardDataValues.Add(124,0.27);
CardDataValues.Add(125,1.296);
CardDataValues.Add(126,0.648);
CardDataValues.Add(127,0.25);
CardDataValues.Add(128,1.2);
CardDataValues.Add(129,0.6);
CardDataValues.Add(130,0.25);
CardDataValues.Add(131,1.2);
CardDataValues.Add(132,0.6);
CardDataValues.Add(133,0.26);
CardDataValues.Add(134,1.248);
CardDataValues.Add(135,0.624);
CardDataValues.Add(136,0.3);
CardDataValues.Add(137,1.44);
CardDataValues.Add(138,0.72);
CardDataValues.Add(139,1.2);
CardDataValues.Add(140,5.76);
CardDataValues.Add(141,2.88);
CardDataValues.Add(142,0.56);
CardDataValues.Add(143,2.688);
CardDataValues.Add(144,1.344);
CardDataValues.Add(145,0.25);
CardDataValues.Add(146,1.2);
CardDataValues.Add(147,0.6);
CardDataValues.Add(148,0.25);
CardDataValues.Add(149,1.2);
CardDataValues.Add(150,0.6);
CardDataValues.Add(151,0.3);
CardDataValues.Add(152,1.44);
CardDataValues.Add(153,0.72);
CardDataValues.Add(154,0.26);
CardDataValues.Add(155,1.248);
CardDataValues.Add(156,0.624);
CardDataValues.Add(157,0.51);
CardDataValues.Add(158,2.448);
CardDataValues.Add(159,1.224);
CardDataValues.Add(160,0.3);
CardDataValues.Add(161,1.44);
CardDataValues.Add(162,0.72);
CardDataValues.Add(163,0.25);
CardDataValues.Add(164,1.2);
CardDataValues.Add(165,0.6);
CardDataValues.Add(166,0.78);
CardDataValues.Add(167,3.744);
CardDataValues.Add(168,1.872);
CardDataValues.Add(169,0.7);
CardDataValues.Add(170,3.36);
CardDataValues.Add(171,1.68);
CardDataValues.Add(172,0.25);
CardDataValues.Add(173,1.2);
CardDataValues.Add(174,0.6);
CardDataValues.Add(175,0.25);
CardDataValues.Add(176,1.2);
CardDataValues.Add(177,0.6);
CardDataValues.Add(178,0.25);
CardDataValues.Add(179,1.2);
CardDataValues.Add(180,0.6);
CardDataValues.Add(181,0.25);
CardDataValues.Add(182,1.2);
CardDataValues.Add(183,0.6);
CardDataValues.Add(184,0.75);
CardDataValues.Add(185,3.6);
CardDataValues.Add(186,1.8);
CardDataValues.Add(187,1.48);
CardDataValues.Add(188,7.104);
CardDataValues.Add(189,3.552);
CardDataValues.Add(190,0.26);
CardDataValues.Add(191,1.248);
CardDataValues.Add(192,0.624);
CardDataValues.Add(193,0.77);
CardDataValues.Add(194,3.696);
CardDataValues.Add(195,1.848);
CardDataValues.Add(196,0.37);
CardDataValues.Add(197,1.776);
CardDataValues.Add(198,0.888);
CardDataValues.Add(199,1.08);
CardDataValues.Add(200,5.184);
CardDataValues.Add(201,2.592);
CardDataValues.Add(202,0.25);
CardDataValues.Add(203,1.2);
CardDataValues.Add(204,0.6);
CardDataValues.Add(205,0.49);
CardDataValues.Add(206,2.352);
CardDataValues.Add(207,1.176);
CardDataValues.Add(208,0.25);
CardDataValues.Add(209,1.2);
CardDataValues.Add(210,0.6);
CardDataValues.Add(211,0.25);
CardDataValues.Add(212,1.2);
CardDataValues.Add(213,0.6);
CardDataValues.Add(214,0.7);
CardDataValues.Add(215,3.36);
CardDataValues.Add(216,1.68);
CardDataValues.Add(217,0.4);
CardDataValues.Add(218,1.92);
CardDataValues.Add(219,0.96);
CardDataValues.Add(220,0.29);
CardDataValues.Add(221,1.392);
CardDataValues.Add(222,0.696);
CardDataValues.Add(223,0.25);
CardDataValues.Add(224,1.2);
CardDataValues.Add(225,0.6);
CardDataValues.Add(226,0.5);
CardDataValues.Add(227,2.4);
CardDataValues.Add(228,1.2);
CardDataValues.Add(229,1.21);
CardDataValues.Add(230,5.808);
CardDataValues.Add(231,2.904);
CardDataValues.Add(232,0.25);
CardDataValues.Add(233,1.2);
CardDataValues.Add(234,0.6);
CardDataValues.Add(235,0.38);
CardDataValues.Add(236,1.824);
CardDataValues.Add(237,0.912);
CardDataValues.Add(238,0.25);
CardDataValues.Add(239,1.2);
CardDataValues.Add(240,0.6);
CardDataValues.Add(241,0.26);
CardDataValues.Add(242,1.248);
CardDataValues.Add(243,0.624);
CardDataValues.Add(244,1.09);
CardDataValues.Add(245,5.232);
CardDataValues.Add(246,2.616);
CardDataValues.Add(247,0.3);
CardDataValues.Add(248,1.44);
CardDataValues.Add(249,0.72);
CardDataValues.Add(250,0.28);
CardDataValues.Add(251,1.344);
CardDataValues.Add(252,0.672);
CardDataValues.Add(253,0.28);
CardDataValues.Add(254,1.344);
CardDataValues.Add(255,0.672);
CardDataValues.Add(256,0.25);
CardDataValues.Add(257,1.2);
CardDataValues.Add(258,0.6);
CardDataValues.Add(259,0.28);
CardDataValues.Add(260,1.344);
CardDataValues.Add(261,0.672);
CardDataValues.Add(262,1.06);
CardDataValues.Add(263,5.088);
CardDataValues.Add(264,2.544);
CardDataValues.Add(265,1.78);
CardDataValues.Add(266,8.544);
CardDataValues.Add(267,4.272);
CardDataValues.Add(268,0.25);
CardDataValues.Add(269,1.2);
CardDataValues.Add(270,0.6);
CardDataValues.Add(271,0.25);
CardDataValues.Add(272,1.2);
CardDataValues.Add(273,0.6);
CardDataValues.Add(274,1.11);
CardDataValues.Add(275,5.328);
CardDataValues.Add(276,2.664);
CardDataValues.Add(277,0.39);
CardDataValues.Add(278,1.872);
CardDataValues.Add(279,0.936);
CardDataValues.Add(280,0.75);
CardDataValues.Add(281,3.6);
CardDataValues.Add(282,1.8);
CardDataValues.Add(283,3.5);
CardDataValues.Add(284,16.8);
CardDataValues.Add(285,8.4);
CardDataValues.Add(286,0.41);
CardDataValues.Add(287,1.968);
CardDataValues.Add(288,0.984);
CardDataValues.Add(289,7.25);
CardDataValues.Add(290,34.8);
CardDataValues.Add(291,17.4);
CardDataValues.Add(292,5.36);
CardDataValues.Add(293,25.728);
CardDataValues.Add(294,12.864);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}