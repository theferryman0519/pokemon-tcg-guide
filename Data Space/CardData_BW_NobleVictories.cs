using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_BW_NobleVictories : MonoBehaviour {
		
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
CardDataNumbers.Add(295,"99");
CardDataNumbers.Add(296,"99H");
CardDataNumbers.Add(297,"99RH");
CardDataNumbers.Add(298,"100");
CardDataNumbers.Add(299,"100H");
CardDataNumbers.Add(300,"100RH");
CardDataNumbers.Add(301,"101");
CardDataNumbers.Add(302,"101H");
CardDataNumbers.Add(303,"101RH");
CardDataNumbers.Add(304,"102");
CardDataNumbers.Add(305,"102H");
CardDataNumbers.Add(306,"102RH");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Sewaddle");
CardDataNames.Add(2,"Sewaddle Holofoil");
CardDataNames.Add(3,"Sewaddle Reverse Holo");
CardDataNames.Add(4,"Swadloon");
CardDataNames.Add(5,"Swadloon Holofoil");
CardDataNames.Add(6,"Swadloon Reverse Holo");
CardDataNames.Add(7,"Leavanny");
CardDataNames.Add(8,"Leavanny Holofoil");
CardDataNames.Add(9,"Leavanny Reverse Holo");
CardDataNames.Add(10,"Petilil");
CardDataNames.Add(11,"Petilil Holofoil");
CardDataNames.Add(12,"Petilil Reverse Holo");
CardDataNames.Add(13,"Lilligant");
CardDataNames.Add(14,"Lilligant Holofoil");
CardDataNames.Add(15,"Lilligant Reverse Holo");
CardDataNames.Add(16,"Dwebble");
CardDataNames.Add(17,"Dwebble Holofoil");
CardDataNames.Add(18,"Dwebble Reverse Holo");
CardDataNames.Add(19,"Crustle");
CardDataNames.Add(20,"Crustle Holofoil");
CardDataNames.Add(21,"Crustle Reverse Holo");
CardDataNames.Add(22,"Karrablast");
CardDataNames.Add(23,"Karrablast Holofoil");
CardDataNames.Add(24,"Karrablast Reverse Holo");
CardDataNames.Add(25,"Foongus");
CardDataNames.Add(26,"Foongus Holofoil");
CardDataNames.Add(27,"Foongus Reverse Holo");
CardDataNames.Add(28,"Amoonguss");
CardDataNames.Add(29,"Amoonguss Holofoil");
CardDataNames.Add(30,"Amoonguss Reverse Holo");
CardDataNames.Add(31,"Shelmet");
CardDataNames.Add(32,"Shelmet Holofoil");
CardDataNames.Add(33,"Shelmet Reverse Holo");
CardDataNames.Add(34,"Accelgor");
CardDataNames.Add(35,"Accelgor Holofoil");
CardDataNames.Add(36,"Accelgor Reverse Holo");
CardDataNames.Add(37,"Virizion");
CardDataNames.Add(38,"Virizion Holofoil");
CardDataNames.Add(39,"Virizion Reverse Holo");
CardDataNames.Add(40,"Victini");
CardDataNames.Add(41,"Victini Holofoil");
CardDataNames.Add(42,"Victini Reverse Holo");
CardDataNames.Add(43,"Victini");
CardDataNames.Add(44,"Victini Holofoil");
CardDataNames.Add(45,"Victini Reverse Holo");
CardDataNames.Add(46,"Pansear");
CardDataNames.Add(47,"Pansear Holofoil");
CardDataNames.Add(48,"Pansear Reverse Holo");
CardDataNames.Add(49,"Simisear");
CardDataNames.Add(50,"Simisear Holofoil");
CardDataNames.Add(51,"Simisear Reverse Holo");
CardDataNames.Add(52,"Heatmor");
CardDataNames.Add(53,"Heatmor Holofoil");
CardDataNames.Add(54,"Heatmor Reverse Holo");
CardDataNames.Add(55,"Larvesta");
CardDataNames.Add(56,"Larvesta Holofoil");
CardDataNames.Add(57,"Larvesta Reverse Holo");
CardDataNames.Add(58,"Larvesta");
CardDataNames.Add(59,"Larvesta Holofoil");
CardDataNames.Add(60,"Larvesta Reverse Holo");
CardDataNames.Add(61,"Volcarona");
CardDataNames.Add(62,"Volcarona Holofoil");
CardDataNames.Add(63,"Volcarona Reverse Holo");
CardDataNames.Add(64,"Tympole");
CardDataNames.Add(65,"Tympole Holofoil");
CardDataNames.Add(66,"Tympole Reverse Holo");
CardDataNames.Add(67,"Palpitoad");
CardDataNames.Add(68,"Palpitoad Holofoil");
CardDataNames.Add(69,"Palpitoad Reverse Holo");
CardDataNames.Add(70,"Seismitoad");
CardDataNames.Add(71,"Seismitoad Holofoil");
CardDataNames.Add(72,"Seismitoad Reverse Holo");
CardDataNames.Add(73,"Tirtouga");
CardDataNames.Add(74,"Tirtouga Holofoil");
CardDataNames.Add(75,"Tirtouga Reverse Holo");
CardDataNames.Add(76,"Carracosta");
CardDataNames.Add(77,"Carracosta Holofoil");
CardDataNames.Add(78,"Carracosta Reverse Holo");
CardDataNames.Add(79,"Vanillite");
CardDataNames.Add(80,"Vanillite Holofoil");
CardDataNames.Add(81,"Vanillite Reverse Holo");
CardDataNames.Add(82,"Vanillish");
CardDataNames.Add(83,"Vanillish Holofoil");
CardDataNames.Add(84,"Vanillish Reverse Holo");
CardDataNames.Add(85,"Vanilluxe");
CardDataNames.Add(86,"Vanilluxe Holofoil");
CardDataNames.Add(87,"Vanilluxe Reverse Holo");
CardDataNames.Add(88,"Frillish");
CardDataNames.Add(89,"Frillish Holofoil");
CardDataNames.Add(90,"Frillish Reverse Holo");
CardDataNames.Add(91,"Jellicent");
CardDataNames.Add(92,"Jellicent Holofoil");
CardDataNames.Add(93,"Jellicent Reverse Holo");
CardDataNames.Add(94,"Cryogonal");
CardDataNames.Add(95,"Cryogonal Holofoil");
CardDataNames.Add(96,"Cryogonal Reverse Holo");
CardDataNames.Add(97,"Cryogonal");
CardDataNames.Add(98,"Cryogonal Holofoil");
CardDataNames.Add(99,"Cryogonal Reverse Holo");
CardDataNames.Add(100,"Kyurem");
CardDataNames.Add(101,"Kyurem Holofoil");
CardDataNames.Add(102,"Kyurem Reverse Holo");
CardDataNames.Add(103,"Blitzle");
CardDataNames.Add(104,"Blitzle Holofoil");
CardDataNames.Add(105,"Blitzle Reverse Holo");
CardDataNames.Add(106,"Zebstrika");
CardDataNames.Add(107,"Zebstrika Holofoil");
CardDataNames.Add(108,"Zebstrika Reverse Holo");
CardDataNames.Add(109,"Emolga");
CardDataNames.Add(110,"Emolga Holofoil");
CardDataNames.Add(111,"Emolga Reverse Holo");
CardDataNames.Add(112,"Tynamo");
CardDataNames.Add(113,"Tynamo Holofoil");
CardDataNames.Add(114,"Tynamo Reverse Holo");
CardDataNames.Add(115,"Tynamo");
CardDataNames.Add(116,"Tynamo Holofoil");
CardDataNames.Add(117,"Tynamo Reverse Holo");
CardDataNames.Add(118,"Eelektrik");
CardDataNames.Add(119,"Eelektrik Holofoil");
CardDataNames.Add(120,"Eelektrik Reverse Holo");
CardDataNames.Add(121,"Eelektross");
CardDataNames.Add(122,"Eelektross Holofoil");
CardDataNames.Add(123,"Eelektross Reverse Holo");
CardDataNames.Add(124,"Stunfisk");
CardDataNames.Add(125,"Stunfisk Holofoil");
CardDataNames.Add(126,"Stunfisk Reverse Holo");
CardDataNames.Add(127,"Victini");
CardDataNames.Add(128,"Victini Holofoil");
CardDataNames.Add(129,"Victini Reverse Holo");
CardDataNames.Add(130,"Yamask");
CardDataNames.Add(131,"Yamask Holofoil");
CardDataNames.Add(132,"Yamask Reverse Holo");
CardDataNames.Add(133,"Yamask");
CardDataNames.Add(134,"Yamask Holofoil");
CardDataNames.Add(135,"Yamask Reverse Holo");
CardDataNames.Add(136,"Cofagrigus");
CardDataNames.Add(137,"Cofagrigus Holofoil");
CardDataNames.Add(138,"Cofagrigus Reverse Holo");
CardDataNames.Add(139,"Cofagrigus");
CardDataNames.Add(140,"Cofagrigus Holofoil");
CardDataNames.Add(141,"Cofagrigus Reverse Holo");
CardDataNames.Add(142,"Trubbish");
CardDataNames.Add(143,"Trubbish Holofoil");
CardDataNames.Add(144,"Trubbish Reverse Holo");
CardDataNames.Add(145,"Garbodor");
CardDataNames.Add(146,"Garbodor Holofoil");
CardDataNames.Add(147,"Garbodor Reverse Holo");
CardDataNames.Add(148,"Solosis");
CardDataNames.Add(149,"Solosis Holofoil");
CardDataNames.Add(150,"Solosis Reverse Holo");
CardDataNames.Add(151,"Duosion");
CardDataNames.Add(152,"Duosion Holofoil");
CardDataNames.Add(153,"Duosion Reverse Holo");
CardDataNames.Add(154,"Reuniclus");
CardDataNames.Add(155,"Reuniclus Holofoil");
CardDataNames.Add(156,"Reuniclus Reverse Holo");
CardDataNames.Add(157,"Reuniclus");
CardDataNames.Add(158,"Reuniclus Holofoil");
CardDataNames.Add(159,"Reuniclus Reverse Holo");
CardDataNames.Add(160,"Elgyem");
CardDataNames.Add(161,"Elgyem Holofoil");
CardDataNames.Add(162,"Elgyem Reverse Holo");
CardDataNames.Add(163,"Elgyem");
CardDataNames.Add(164,"Elgyem Holofoil");
CardDataNames.Add(165,"Elgyem Reverse Holo");
CardDataNames.Add(166,"Beheeyem");
CardDataNames.Add(167,"Beheeyem Holofoil");
CardDataNames.Add(168,"Beheeyem Reverse Holo");
CardDataNames.Add(169,"Litwick");
CardDataNames.Add(170,"Litwick Holofoil");
CardDataNames.Add(171,"Litwick Reverse Holo");
CardDataNames.Add(172,"Litwick");
CardDataNames.Add(173,"Litwick Holofoil");
CardDataNames.Add(174,"Litwick Reverse Holo");
CardDataNames.Add(175,"Lampent");
CardDataNames.Add(176,"Lampent Holofoil");
CardDataNames.Add(177,"Lampent Reverse Holo");
CardDataNames.Add(178,"Chandelure");
CardDataNames.Add(179,"Chandelure Holofoil");
CardDataNames.Add(180,"Chandelure Reverse Holo");
CardDataNames.Add(181,"Gigalith");
CardDataNames.Add(182,"Gigalith Holofoil");
CardDataNames.Add(183,"Gigalith Reverse Holo");
CardDataNames.Add(184,"Timburr");
CardDataNames.Add(185,"Timburr Holofoil");
CardDataNames.Add(186,"Timburr Reverse Holo");
CardDataNames.Add(187,"Gurdurr");
CardDataNames.Add(188,"Gurdurr Holofoil");
CardDataNames.Add(189,"Gurdurr Reverse Holo");
CardDataNames.Add(190,"Conkeldurr");
CardDataNames.Add(191,"Conkeldurr Holofoil");
CardDataNames.Add(192,"Conkeldurr Reverse Holo");
CardDataNames.Add(193,"Conkeldurr");
CardDataNames.Add(194,"Conkeldurr Holofoil");
CardDataNames.Add(195,"Conkeldurr Reverse Holo");
CardDataNames.Add(196,"Archen");
CardDataNames.Add(197,"Archen Holofoil");
CardDataNames.Add(198,"Archen Reverse Holo");
CardDataNames.Add(199,"Archeops");
CardDataNames.Add(200,"Archeops Holofoil");
CardDataNames.Add(201,"Archeops Reverse Holo");
CardDataNames.Add(202,"Stunfisk");
CardDataNames.Add(203,"Stunfisk Holofoil");
CardDataNames.Add(204,"Stunfisk Reverse Holo");
CardDataNames.Add(205,"Mienfoo");
CardDataNames.Add(206,"Mienfoo Holofoil");
CardDataNames.Add(207,"Mienfoo Reverse Holo");
CardDataNames.Add(208,"Mienshao");
CardDataNames.Add(209,"Mienshao Holofoil");
CardDataNames.Add(210,"Mienshao Reverse Holo");
CardDataNames.Add(211,"Golett");
CardDataNames.Add(212,"Golett Holofoil");
CardDataNames.Add(213,"Golett Reverse Holo");
CardDataNames.Add(214,"Golurk");
CardDataNames.Add(215,"Golurk Holofoil");
CardDataNames.Add(216,"Golurk Reverse Holo");
CardDataNames.Add(217,"Terrakion");
CardDataNames.Add(218,"Terrakion Holofoil");
CardDataNames.Add(219,"Terrakion Reverse Holo");
CardDataNames.Add(220,"Landorus");
CardDataNames.Add(221,"Landorus Holofoil");
CardDataNames.Add(222,"Landorus Reverse Holo");
CardDataNames.Add(223,"Pawniard");
CardDataNames.Add(224,"Pawniard Holofoil");
CardDataNames.Add(225,"Pawniard Reverse Holo");
CardDataNames.Add(226,"Bisharp");
CardDataNames.Add(227,"Bisharp Holofoil");
CardDataNames.Add(228,"Bisharp Reverse Holo");
CardDataNames.Add(229,"Deino");
CardDataNames.Add(230,"Deino Holofoil");
CardDataNames.Add(231,"Deino Reverse Holo");
CardDataNames.Add(232,"Zweilous");
CardDataNames.Add(233,"Zweilous Holofoil");
CardDataNames.Add(234,"Zweilous Reverse Holo");
CardDataNames.Add(235,"Hydreigon");
CardDataNames.Add(236,"Hydreigon Holofoil");
CardDataNames.Add(237,"Hydreigon Reverse Holo");
CardDataNames.Add(238,"Escavalier");
CardDataNames.Add(239,"Escavalier Holofoil");
CardDataNames.Add(240,"Escavalier Reverse Holo");
CardDataNames.Add(241,"Pawniard");
CardDataNames.Add(242,"Pawniard Holofoil");
CardDataNames.Add(243,"Pawniard Reverse Holo");
CardDataNames.Add(244,"Bisharp");
CardDataNames.Add(245,"Bisharp Holofoil");
CardDataNames.Add(246,"Bisharp Reverse Holo");
CardDataNames.Add(247,"Durant");
CardDataNames.Add(248,"Durant Holofoil");
CardDataNames.Add(249,"Durant Reverse Holo");
CardDataNames.Add(250,"Cobalion");
CardDataNames.Add(251,"Cobalion Holofoil");
CardDataNames.Add(252,"Cobalion Reverse Holo");
CardDataNames.Add(253,"Audino");
CardDataNames.Add(254,"Audino Holofoil");
CardDataNames.Add(255,"Audino Reverse Holo");
CardDataNames.Add(256,"Axew");
CardDataNames.Add(257,"Axew Holofoil");
CardDataNames.Add(258,"Axew Reverse Holo");
CardDataNames.Add(259,"Fraxure");
CardDataNames.Add(260,"Fraxure Holofoil");
CardDataNames.Add(261,"Fraxure Reverse Holo");
CardDataNames.Add(262,"Haxorus");
CardDataNames.Add(263,"Haxorus Holofoil");
CardDataNames.Add(264,"Haxorus Reverse Holo");
CardDataNames.Add(265,"Druddigon");
CardDataNames.Add(266,"Druddigon Holofoil");
CardDataNames.Add(267,"Druddigon Reverse Holo");
CardDataNames.Add(268,"Cover Fossil");
CardDataNames.Add(269,"Cover Fossil Holofoil");
CardDataNames.Add(270,"Cover Fossil Reverse Holo");
CardDataNames.Add(271,"Eviolite");
CardDataNames.Add(272,"Eviolite Holofoil");
CardDataNames.Add(273,"Eviolite Reverse Holo");
CardDataNames.Add(274,"N");
CardDataNames.Add(275,"N Holofoil");
CardDataNames.Add(276,"N Reverse Holo");
CardDataNames.Add(277,"Plume Fossil");
CardDataNames.Add(278,"Plume Fossil Holofoil");
CardDataNames.Add(279,"Plume Fossil Reverse Holo");
CardDataNames.Add(280,"Rocky Helmet");
CardDataNames.Add(281,"Rocky Helmet Holofoil");
CardDataNames.Add(282,"Rocky Helmet Reverse Holo");
CardDataNames.Add(283,"Super Rod");
CardDataNames.Add(284,"Super Rod Holofoil");
CardDataNames.Add(285,"Super Rod Reverse Holo");
CardDataNames.Add(286,"Xtransceiver");
CardDataNames.Add(287,"Xtransceiver Holofoil");
CardDataNames.Add(288,"Xtransceiver Reverse Holo");
CardDataNames.Add(289,"Virizion");
CardDataNames.Add(290,"Virizion Holofoil");
CardDataNames.Add(291,"Virizion Reverse Holo");
CardDataNames.Add(292,"Victini");
CardDataNames.Add(293,"Victini Holofoil");
CardDataNames.Add(294,"Victini Reverse Holo");
CardDataNames.Add(295,"Terrakion");
CardDataNames.Add(296,"Terrakion Holofoil");
CardDataNames.Add(297,"Terrakion Reverse Holo");
CardDataNames.Add(298,"Cobalion");
CardDataNames.Add(299,"Cobalion Holofoil");
CardDataNames.Add(300,"Cobalion Reverse Holo");
CardDataNames.Add(301,"N");
CardDataNames.Add(302,"N Holofoil");
CardDataNames.Add(303,"N Reverse Holo");
CardDataNames.Add(304,"Meowth");
CardDataNames.Add(305,"Meowth Holofoil");
CardDataNames.Add(306,"Meowth Reverse Holo");
	}

	public void SetCardValues() {
CardDataValues.Add(1,0.19);
CardDataValues.Add(2,0.912);
CardDataValues.Add(3,0.456);
CardDataValues.Add(4,0.35);
CardDataValues.Add(5,1.68);
CardDataValues.Add(6,0.84);
CardDataValues.Add(7,0.96);
CardDataValues.Add(8,4.608);
CardDataValues.Add(9,2.304);
CardDataValues.Add(10,0.25);
CardDataValues.Add(11,1.2);
CardDataValues.Add(12,0.6);
CardDataValues.Add(13,0.63);
CardDataValues.Add(14,3.024);
CardDataValues.Add(15,1.512);
CardDataValues.Add(16,0.32);
CardDataValues.Add(17,1.536);
CardDataValues.Add(18,0.768);
CardDataValues.Add(19,0.5);
CardDataValues.Add(20,2.4);
CardDataValues.Add(21,1.2);
CardDataValues.Add(22,0.22);
CardDataValues.Add(23,1.056);
CardDataValues.Add(24,0.528);
CardDataValues.Add(25,0.25);
CardDataValues.Add(26,1.2);
CardDataValues.Add(27,0.6);
CardDataValues.Add(28,0.6);
CardDataValues.Add(29,2.88);
CardDataValues.Add(30,1.44);
CardDataValues.Add(31,0.25);
CardDataValues.Add(32,1.2);
CardDataValues.Add(33,0.6);
CardDataValues.Add(34,0.68);
CardDataValues.Add(35,3.264);
CardDataValues.Add(36,1.632);
CardDataValues.Add(37,1.73);
CardDataValues.Add(38,8.304);
CardDataValues.Add(39,4.152);
CardDataValues.Add(40,2.58);
CardDataValues.Add(41,12.384);
CardDataValues.Add(42,6.192);
CardDataValues.Add(43,3.45);
CardDataValues.Add(44,16.56);
CardDataValues.Add(45,8.28);
CardDataValues.Add(46,0.2);
CardDataValues.Add(47,0.96);
CardDataValues.Add(48,0.48);
CardDataValues.Add(49,0.26);
CardDataValues.Add(50,1.248);
CardDataValues.Add(51,0.624);
CardDataValues.Add(52,0.39);
CardDataValues.Add(53,1.872);
CardDataValues.Add(54,0.936);
CardDataValues.Add(55,0.23);
CardDataValues.Add(56,1.104);
CardDataValues.Add(57,0.552);
CardDataValues.Add(58,0.25);
CardDataValues.Add(59,1.2);
CardDataValues.Add(60,0.6);
CardDataValues.Add(61,0.9);
CardDataValues.Add(62,4.32);
CardDataValues.Add(63,2.16);
CardDataValues.Add(64,0.25);
CardDataValues.Add(65,1.2);
CardDataValues.Add(66,0.6);
CardDataValues.Add(67,0.57);
CardDataValues.Add(68,2.736);
CardDataValues.Add(69,1.368);
CardDataValues.Add(70,0.8);
CardDataValues.Add(71,3.84);
CardDataValues.Add(72,1.92);
CardDataValues.Add(73,2.07);
CardDataValues.Add(74,9.936);
CardDataValues.Add(75,4.968);
CardDataValues.Add(76,3.49);
CardDataValues.Add(77,16.752);
CardDataValues.Add(78,8.376);
CardDataValues.Add(79,0.26);
CardDataValues.Add(80,1.248);
CardDataValues.Add(81,0.624);
CardDataValues.Add(82,0.47);
CardDataValues.Add(83,2.256);
CardDataValues.Add(84,1.128);
CardDataValues.Add(85,1.12);
CardDataValues.Add(86,5.376);
CardDataValues.Add(87,2.688);
CardDataValues.Add(88,0.25);
CardDataValues.Add(89,1.2);
CardDataValues.Add(90,0.6);
CardDataValues.Add(91,1.49);
CardDataValues.Add(92,7.152);
CardDataValues.Add(93,3.576);
CardDataValues.Add(94,0.42);
CardDataValues.Add(95,2.016);
CardDataValues.Add(96,1.008);
CardDataValues.Add(97,1.09);
CardDataValues.Add(98,5.232);
CardDataValues.Add(99,2.616);
CardDataValues.Add(100,4.59);
CardDataValues.Add(101,22.032);
CardDataValues.Add(102,11.016);
CardDataValues.Add(103,16.24);
CardDataValues.Add(104,77.952);
CardDataValues.Add(105,38.976);
CardDataValues.Add(106,0.5);
CardDataValues.Add(107,2.4);
CardDataValues.Add(108,1.2);
CardDataValues.Add(109,0.35);
CardDataValues.Add(110,1.68);
CardDataValues.Add(111,0.84);
CardDataValues.Add(112,0.25);
CardDataValues.Add(113,1.2);
CardDataValues.Add(114,0.6);
CardDataValues.Add(115,0.27);
CardDataValues.Add(116,1.296);
CardDataValues.Add(117,0.648);
CardDataValues.Add(118,0.72);
CardDataValues.Add(119,3.456);
CardDataValues.Add(120,1.728);
CardDataValues.Add(121,1.51);
CardDataValues.Add(122,7.248);
CardDataValues.Add(123,3.624);
CardDataValues.Add(124,0.25);
CardDataValues.Add(125,1.2);
CardDataValues.Add(126,0.6);
CardDataValues.Add(127,2.15);
CardDataValues.Add(128,10.32);
CardDataValues.Add(129,5.16);
CardDataValues.Add(130,0.25);
CardDataValues.Add(131,1.2);
CardDataValues.Add(132,0.6);
CardDataValues.Add(133,0.25);
CardDataValues.Add(134,1.2);
CardDataValues.Add(135,0.6);
CardDataValues.Add(136,1.99);
CardDataValues.Add(137,9.552);
CardDataValues.Add(138,4.776);
CardDataValues.Add(139,4.31);
CardDataValues.Add(140,20.688);
CardDataValues.Add(141,10.344);
CardDataValues.Add(142,2.46);
CardDataValues.Add(143,11.808);
CardDataValues.Add(144,5.904);
CardDataValues.Add(145,0.65);
CardDataValues.Add(146,3.12);
CardDataValues.Add(147,1.56);
CardDataValues.Add(148,0.25);
CardDataValues.Add(149,1.2);
CardDataValues.Add(150,0.6);
CardDataValues.Add(151,0.42);
CardDataValues.Add(152,2.016);
CardDataValues.Add(153,1.008);
CardDataValues.Add(154,0.74);
CardDataValues.Add(155,3.552);
CardDataValues.Add(156,1.776);
CardDataValues.Add(157,0.53);
CardDataValues.Add(158,2.544);
CardDataValues.Add(159,1.272);
CardDataValues.Add(160,0.29);
CardDataValues.Add(161,1.392);
CardDataValues.Add(162,0.696);
CardDataValues.Add(163,0.46);
CardDataValues.Add(164,2.208);
CardDataValues.Add(165,1.104);
CardDataValues.Add(166,2.6);
CardDataValues.Add(167,12.48);
CardDataValues.Add(168,6.24);
CardDataValues.Add(169,0.27);
CardDataValues.Add(170,1.296);
CardDataValues.Add(171,0.648);
CardDataValues.Add(172,0.25);
CardDataValues.Add(173,1.2);
CardDataValues.Add(174,0.6);
CardDataValues.Add(175,1.35);
CardDataValues.Add(176,6.48);
CardDataValues.Add(177,3.24);
CardDataValues.Add(178,11.93);
CardDataValues.Add(179,57.264);
CardDataValues.Add(180,28.632);
CardDataValues.Add(181,0.94);
CardDataValues.Add(182,4.512);
CardDataValues.Add(183,2.256);
CardDataValues.Add(184,0.26);
CardDataValues.Add(185,1.248);
CardDataValues.Add(186,0.624);
CardDataValues.Add(187,0.31);
CardDataValues.Add(188,1.488);
CardDataValues.Add(189,0.744);
CardDataValues.Add(190,2.58);
CardDataValues.Add(191,12.384);
CardDataValues.Add(192,6.192);
CardDataValues.Add(193,0.99);
CardDataValues.Add(194,4.752);
CardDataValues.Add(195,2.376);
CardDataValues.Add(196,0.98);
CardDataValues.Add(197,4.704);
CardDataValues.Add(198,2.352);
CardDataValues.Add(199,4.75);
CardDataValues.Add(200,22.8);
CardDataValues.Add(201,11.4);
CardDataValues.Add(202,0.39);
CardDataValues.Add(203,1.872);
CardDataValues.Add(204,0.936);
CardDataValues.Add(205,0.25);
CardDataValues.Add(206,1.2);
CardDataValues.Add(207,0.6);
CardDataValues.Add(208,0.4);
CardDataValues.Add(209,1.92);
CardDataValues.Add(210,0.96);
CardDataValues.Add(211,0.3);
CardDataValues.Add(212,1.44);
CardDataValues.Add(213,0.72);
CardDataValues.Add(214,0.78);
CardDataValues.Add(215,3.744);
CardDataValues.Add(216,1.872);
CardDataValues.Add(217,2.64);
CardDataValues.Add(218,12.672);
CardDataValues.Add(219,6.336);
CardDataValues.Add(220,3.25);
CardDataValues.Add(221,15.6);
CardDataValues.Add(222,7.8);
CardDataValues.Add(223,0.3);
CardDataValues.Add(224,1.44);
CardDataValues.Add(225,0.72);
CardDataValues.Add(226,0.39);
CardDataValues.Add(227,1.872);
CardDataValues.Add(228,0.936);
CardDataValues.Add(229,0.25);
CardDataValues.Add(230,1.2);
CardDataValues.Add(231,0.6);
CardDataValues.Add(232,0.86);
CardDataValues.Add(233,4.128);
CardDataValues.Add(234,2.064);
CardDataValues.Add(235,6.47);
CardDataValues.Add(236,31.056);
CardDataValues.Add(237,15.528);
CardDataValues.Add(238,0.5);
CardDataValues.Add(239,2.4);
CardDataValues.Add(240,1.2);
CardDataValues.Add(241,0.26);
CardDataValues.Add(242,1.248);
CardDataValues.Add(243,0.624);
CardDataValues.Add(244,1.09);
CardDataValues.Add(245,5.232);
CardDataValues.Add(246,2.616);
CardDataValues.Add(247,1.67);
CardDataValues.Add(248,8.016);
CardDataValues.Add(249,4.008);
CardDataValues.Add(250,1.98);
CardDataValues.Add(251,9.504);
CardDataValues.Add(252,4.752);
CardDataValues.Add(253,0.33);
CardDataValues.Add(254,1.584);
CardDataValues.Add(255,0.792);
CardDataValues.Add(256,0.3);
CardDataValues.Add(257,1.44);
CardDataValues.Add(258,0.72);
CardDataValues.Add(259,0.35);
CardDataValues.Add(260,1.68);
CardDataValues.Add(261,0.84);
CardDataValues.Add(262,3.86);
CardDataValues.Add(263,18.528);
CardDataValues.Add(264,9.264);
CardDataValues.Add(265,0.5);
CardDataValues.Add(266,2.4);
CardDataValues.Add(267,1.2);
CardDataValues.Add(268,0.3);
CardDataValues.Add(269,1.44);
CardDataValues.Add(270,0.72);
CardDataValues.Add(271,0.39);
CardDataValues.Add(272,1.872);
CardDataValues.Add(273,0.936);
CardDataValues.Add(274,1.35);
CardDataValues.Add(275,6.48);
CardDataValues.Add(276,3.24);
CardDataValues.Add(277,0.25);
CardDataValues.Add(278,1.2);
CardDataValues.Add(279,0.6);
CardDataValues.Add(280,0.35);
CardDataValues.Add(281,1.68);
CardDataValues.Add(282,0.84);
CardDataValues.Add(283,0.8);
CardDataValues.Add(284,3.84);
CardDataValues.Add(285,1.92);
CardDataValues.Add(286,0.4);
CardDataValues.Add(287,1.92);
CardDataValues.Add(288,0.96);
CardDataValues.Add(289,15.69);
CardDataValues.Add(290,75.312);
CardDataValues.Add(291,37.656);
CardDataValues.Add(292,27.68);
CardDataValues.Add(293,132.864);
CardDataValues.Add(294,66.432);
CardDataValues.Add(295,14.42);
CardDataValues.Add(296,69.216);
CardDataValues.Add(297,34.608);
CardDataValues.Add(298,18.16);
CardDataValues.Add(299,87.168);
CardDataValues.Add(300,43.584);
CardDataValues.Add(301,62.84);
CardDataValues.Add(302,301.632);
CardDataValues.Add(303,150.816);
CardDataValues.Add(304,48.41);
CardDataValues.Add(305,232.368);
CardDataValues.Add(306,116.184);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}