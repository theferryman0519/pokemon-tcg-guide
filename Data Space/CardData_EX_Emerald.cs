using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_EX_Emerald : MonoBehaviour {
		
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
CardDataNumbers.Add(269,"91");
CardDataNumbers.Add(270,"92");
CardDataNumbers.Add(271,"93");
CardDataNumbers.Add(272,"94");
CardDataNumbers.Add(273,"95");
CardDataNumbers.Add(274,"96");
CardDataNumbers.Add(275,"97");
CardDataNumbers.Add(276,"98");
CardDataNumbers.Add(277,"99");
CardDataNumbers.Add(278,"100");
CardDataNumbers.Add(279,"101");
CardDataNumbers.Add(280,"101H");
CardDataNumbers.Add(281,"101RH");
CardDataNumbers.Add(282,"102");
CardDataNumbers.Add(283,"102H");
CardDataNumbers.Add(284,"102RH");
CardDataNumbers.Add(285,"103");
CardDataNumbers.Add(286,"103H");
CardDataNumbers.Add(287,"103RH");
CardDataNumbers.Add(288,"104");
CardDataNumbers.Add(289,"104H");
CardDataNumbers.Add(290,"104RH");
CardDataNumbers.Add(291,"105");
CardDataNumbers.Add(292,"105H");
CardDataNumbers.Add(293,"105RH");
CardDataNumbers.Add(294,"106");
CardDataNumbers.Add(295,"106H");
CardDataNumbers.Add(296,"106RH");
CardDataNumbers.Add(297,"107");
CardDataNumbers.Add(298,"107H");
CardDataNumbers.Add(299,"107RH");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Blaziken");
CardDataNames.Add(2,"Blaziken Holofoil");
CardDataNames.Add(3,"Blaziken Reverse Holo");
CardDataNames.Add(4,"Deoxys");
CardDataNames.Add(5,"Deoxys Holofoil");
CardDataNames.Add(6,"Deoxys Reverse Holo");
CardDataNames.Add(7,"Exploud");
CardDataNames.Add(8,"Exploud Holofoil");
CardDataNames.Add(9,"Exploud Reverse Holo");
CardDataNames.Add(10,"Gardevoir");
CardDataNames.Add(11,"Gardevoir Holofoil");
CardDataNames.Add(12,"Gardevoir Reverse Holo");
CardDataNames.Add(13,"Groudon");
CardDataNames.Add(14,"Groudon Holofoil");
CardDataNames.Add(15,"Groudon Reverse Holo");
CardDataNames.Add(16,"Kyogre");
CardDataNames.Add(17,"Kyogre Holofoil");
CardDataNames.Add(18,"Kyogre Reverse Holo");
CardDataNames.Add(19,"Manectric");
CardDataNames.Add(20,"Manectric Holofoil");
CardDataNames.Add(21,"Manectric Reverse Holo");
CardDataNames.Add(22,"Milotic");
CardDataNames.Add(23,"Milotic Holofoil");
CardDataNames.Add(24,"Milotic Reverse Holo");
CardDataNames.Add(25,"Rayquaza");
CardDataNames.Add(26,"Rayquaza Holofoil");
CardDataNames.Add(27,"Rayquaza Reverse Holo");
CardDataNames.Add(28,"Sceptile");
CardDataNames.Add(29,"Sceptile Holofoil");
CardDataNames.Add(30,"Sceptile Reverse Holo");
CardDataNames.Add(31,"Swampert");
CardDataNames.Add(32,"Swampert Holofoil");
CardDataNames.Add(33,"Swampert Reverse Holo");
CardDataNames.Add(34,"Chimecho");
CardDataNames.Add(35,"Chimecho Holofoil");
CardDataNames.Add(36,"Chimecho Reverse Holo");
CardDataNames.Add(37,"Glalie");
CardDataNames.Add(38,"Glalie Holofoil");
CardDataNames.Add(39,"Glalie Reverse Holo");
CardDataNames.Add(40,"Groudon");
CardDataNames.Add(41,"Groudon Holofoil");
CardDataNames.Add(42,"Groudon Reverse Holo");
CardDataNames.Add(43,"Kyogre");
CardDataNames.Add(44,"Kyogre Holofoil");
CardDataNames.Add(45,"Kyogre Reverse Holo");
CardDataNames.Add(46,"Manectric");
CardDataNames.Add(47,"Manectric Holofoil");
CardDataNames.Add(48,"Manectric Reverse Holo");
CardDataNames.Add(49,"Nosepass");
CardDataNames.Add(50,"Nosepass Holofoil");
CardDataNames.Add(51,"Nosepass Reverse Holo");
CardDataNames.Add(52,"Relicanth");
CardDataNames.Add(53,"Relicanth Holofoil");
CardDataNames.Add(54,"Relicanth Reverse Holo");
CardDataNames.Add(55,"Rhydon");
CardDataNames.Add(56,"Rhydon Holofoil");
CardDataNames.Add(57,"Rhydon Reverse Holo");
CardDataNames.Add(58,"Seviper");
CardDataNames.Add(59,"Seviper Holofoil");
CardDataNames.Add(60,"Seviper Reverse Holo");
CardDataNames.Add(61,"Zangoose");
CardDataNames.Add(62,"Zangoose Holofoil");
CardDataNames.Add(63,"Zangoose Reverse Holo");
CardDataNames.Add(64,"Breloom");
CardDataNames.Add(65,"Breloom Holofoil");
CardDataNames.Add(66,"Breloom Reverse Holo");
CardDataNames.Add(67,"Camerupt");
CardDataNames.Add(68,"Camerupt Holofoil");
CardDataNames.Add(69,"Camerupt Reverse Holo");
CardDataNames.Add(70,"Claydol");
CardDataNames.Add(71,"Claydol Holofoil");
CardDataNames.Add(72,"Claydol Reverse Holo");
CardDataNames.Add(73,"Combusken");
CardDataNames.Add(74,"Combusken Holofoil");
CardDataNames.Add(75,"Combusken Reverse Holo");
CardDataNames.Add(76,"Dodrio");
CardDataNames.Add(77,"Dodrio Holofoil");
CardDataNames.Add(78,"Dodrio Reverse Holo");
CardDataNames.Add(79,"Electrode");
CardDataNames.Add(80,"Electrode Holofoil");
CardDataNames.Add(81,"Electrode Reverse Holo");
CardDataNames.Add(82,"Grovyle");
CardDataNames.Add(83,"Grovyle Holofoil");
CardDataNames.Add(84,"Grovyle Reverse Holo");
CardDataNames.Add(85,"Grumpig");
CardDataNames.Add(86,"Grumpig Holofoil");
CardDataNames.Add(87,"Grumpig Reverse Holo");
CardDataNames.Add(88,"Grumpig");
CardDataNames.Add(89,"Grumpig Holofoil");
CardDataNames.Add(90,"Grumpig Reverse Holo");
CardDataNames.Add(91,"Hariyama");
CardDataNames.Add(92,"Hariyama Holofoil");
CardDataNames.Add(93,"Hariyama Reverse Holo");
CardDataNames.Add(94,"Illumise");
CardDataNames.Add(95,"Illumise Holofoil");
CardDataNames.Add(96,"Illumise Reverse Holo");
CardDataNames.Add(97,"Kirlia");
CardDataNames.Add(98,"Kirlia Holofoil");
CardDataNames.Add(99,"Kirlia Reverse Holo");
CardDataNames.Add(100,"Linoone");
CardDataNames.Add(101,"Linoone Holofoil");
CardDataNames.Add(102,"Linoone Reverse Holo");
CardDataNames.Add(103,"Loudred");
CardDataNames.Add(104,"Loudred Holofoil");
CardDataNames.Add(105,"Loudred Reverse Holo");
CardDataNames.Add(106,"Marshtomp");
CardDataNames.Add(107,"Marshtomp Holofoil");
CardDataNames.Add(108,"Marshtomp Reverse Holo");
CardDataNames.Add(109,"Minun");
CardDataNames.Add(110,"Minun Holofoil");
CardDataNames.Add(111,"Minun Reverse Holo");
CardDataNames.Add(112,"Ninetales");
CardDataNames.Add(113,"Ninetales Holofoil");
CardDataNames.Add(114,"Ninetales Reverse Holo");
CardDataNames.Add(115,"Plusle");
CardDataNames.Add(116,"Plusle Holofoil");
CardDataNames.Add(117,"Plusle Reverse Holo");
CardDataNames.Add(118,"Swalot");
CardDataNames.Add(119,"Swalot Holofoil");
CardDataNames.Add(120,"Swalot Reverse Holo");
CardDataNames.Add(121,"Swellow");
CardDataNames.Add(122,"Swellow Holofoil");
CardDataNames.Add(123,"Swellow Reverse Holo");
CardDataNames.Add(124,"Volbeat");
CardDataNames.Add(125,"Volbeat Holofoil");
CardDataNames.Add(126,"Volbeat Reverse Holo");
CardDataNames.Add(127,"Baltoy");
CardDataNames.Add(128,"Baltoy Holofoil");
CardDataNames.Add(129,"Baltoy Reverse Holo");
CardDataNames.Add(130,"Cacnea");
CardDataNames.Add(131,"Cacnea Holofoil");
CardDataNames.Add(132,"Cacnea Reverse Holo");
CardDataNames.Add(133,"Doduo");
CardDataNames.Add(134,"Doduo Holofoil");
CardDataNames.Add(135,"Doduo Reverse Holo");
CardDataNames.Add(136,"Duskull");
CardDataNames.Add(137,"Duskull Holofoil");
CardDataNames.Add(138,"Duskull Reverse Holo");
CardDataNames.Add(139,"Electrike");
CardDataNames.Add(140,"Electrike Holofoil");
CardDataNames.Add(141,"Electrike Reverse Holo");
CardDataNames.Add(142,"Electrike");
CardDataNames.Add(143,"Electrike Holofoil");
CardDataNames.Add(144,"Electrike Reverse Holo");
CardDataNames.Add(145,"Feebas");
CardDataNames.Add(146,"Feebas Holofoil");
CardDataNames.Add(147,"Feebas Reverse Holo");
CardDataNames.Add(148,"Feebas");
CardDataNames.Add(149,"Feebas Holofoil");
CardDataNames.Add(150,"Feebas Reverse Holo");
CardDataNames.Add(151,"Gulpin");
CardDataNames.Add(152,"Gulpin Holofoil");
CardDataNames.Add(153,"Gulpin Reverse Holo");
CardDataNames.Add(154,"Larvitar");
CardDataNames.Add(155,"Larvitar Holofoil");
CardDataNames.Add(156,"Larvitar Reverse Holo");
CardDataNames.Add(157,"Luvdisc");
CardDataNames.Add(158,"Luvdisc Holofoil");
CardDataNames.Add(159,"Luvdisc Reverse Holo");
CardDataNames.Add(160,"Makuhita");
CardDataNames.Add(161,"Makuhita Holofoil");
CardDataNames.Add(162,"Makuhita Reverse Holo");
CardDataNames.Add(163,"Meditite");
CardDataNames.Add(164,"Meditite Holofoil");
CardDataNames.Add(165,"Meditite Reverse Holo");
CardDataNames.Add(166,"Mudkip");
CardDataNames.Add(167,"Mudkip Holofoil");
CardDataNames.Add(168,"Mudkip Reverse Holo");
CardDataNames.Add(169,"Numel");
CardDataNames.Add(170,"Numel Holofoil");
CardDataNames.Add(171,"Numel Reverse Holo");
CardDataNames.Add(172,"Numel");
CardDataNames.Add(173,"Numel Holofoil");
CardDataNames.Add(174,"Numel Reverse Holo");
CardDataNames.Add(175,"Pichu");
CardDataNames.Add(176,"Pichu Holofoil");
CardDataNames.Add(177,"Pichu Reverse Holo");
CardDataNames.Add(178,"Pikachu");
CardDataNames.Add(179,"Pikachu Holofoil");
CardDataNames.Add(180,"Pikachu Reverse Holo");
CardDataNames.Add(181,"Ralts");
CardDataNames.Add(182,"Ralts Holofoil");
CardDataNames.Add(183,"Ralts Reverse Holo");
CardDataNames.Add(184,"Rhyhorn");
CardDataNames.Add(185,"Rhyhorn Holofoil");
CardDataNames.Add(186,"Rhyhorn Reverse Holo");
CardDataNames.Add(187,"Shroomish");
CardDataNames.Add(188,"Shroomish Holofoil");
CardDataNames.Add(189,"Shroomish Reverse Holo");
CardDataNames.Add(190,"Snorunt");
CardDataNames.Add(191,"Snorunt Holofoil");
CardDataNames.Add(192,"Snorunt Reverse Holo");
CardDataNames.Add(193,"Spoink");
CardDataNames.Add(194,"Spoink Holofoil");
CardDataNames.Add(195,"Spoink Reverse Holo");
CardDataNames.Add(196,"Spoink");
CardDataNames.Add(197,"Spoink Holofoil");
CardDataNames.Add(198,"Spoink Reverse Holo");
CardDataNames.Add(199,"Swablu");
CardDataNames.Add(200,"Swablu Holofoil");
CardDataNames.Add(201,"Swablu Reverse Holo");
CardDataNames.Add(202,"Taillow");
CardDataNames.Add(203,"Taillow Holofoil");
CardDataNames.Add(204,"Taillow Reverse Holo");
CardDataNames.Add(205,"Torchic");
CardDataNames.Add(206,"Torchic Holofoil");
CardDataNames.Add(207,"Torchic Reverse Holo");
CardDataNames.Add(208,"Treecko");
CardDataNames.Add(209,"Treecko Holofoil");
CardDataNames.Add(210,"Treecko Reverse Holo");
CardDataNames.Add(211,"Voltorb");
CardDataNames.Add(212,"Voltorb Holofoil");
CardDataNames.Add(213,"Voltorb Reverse Holo");
CardDataNames.Add(214,"Vulpix");
CardDataNames.Add(215,"Vulpix Holofoil");
CardDataNames.Add(216,"Vulpix Reverse Holo");
CardDataNames.Add(217,"Whismur");
CardDataNames.Add(218,"Whismur Holofoil");
CardDataNames.Add(219,"Whismur Reverse Holo");
CardDataNames.Add(220,"Zigzagoon");
CardDataNames.Add(221,"Zigzagoon Holofoil");
CardDataNames.Add(222,"Zigzagoon Reverse Holo");
CardDataNames.Add(223,"Battle Frontier");
CardDataNames.Add(224,"Battle Frontier Holofoil");
CardDataNames.Add(225,"Battle Frontier Reverse Holo");
CardDataNames.Add(226,"Double Full Heal");
CardDataNames.Add(227,"Double Full Heal Holofoil");
CardDataNames.Add(228,"Double Full Heal Reverse Holo");
CardDataNames.Add(229,"Lanette's Net Search");
CardDataNames.Add(230,"Lanette's Net Search Holofoil");
CardDataNames.Add(231,"Lanette's Net Search Reverse Holo");
CardDataNames.Add(232,"Lum Berry");
CardDataNames.Add(233,"Lum Berry Holofoil");
CardDataNames.Add(234,"Lum Berry Reverse Holo");
CardDataNames.Add(235,"Mr Stone's Project");
CardDataNames.Add(236,"Mr Stone's Project Holofoil");
CardDataNames.Add(237,"Mr Stone's Project Reverse Holo");
CardDataNames.Add(238,"Oran Berry");
CardDataNames.Add(239,"Oran Berry Holofoil");
CardDataNames.Add(240,"Oran Berry Reverse Holo");
CardDataNames.Add(241,"PokéNav");
CardDataNames.Add(242,"PokéNav Holofoil");
CardDataNames.Add(243,"PokéNav Reverse Holo");
CardDataNames.Add(244,"Professor Birch");
CardDataNames.Add(245,"Professor Birch Holofoil");
CardDataNames.Add(246,"Professor Birch Reverse Holo");
CardDataNames.Add(247,"Rare Candy");
CardDataNames.Add(248,"Rare Candy Holofoil");
CardDataNames.Add(249,"Rare Candy Reverse Holo");
CardDataNames.Add(250,"Scott");
CardDataNames.Add(251,"Scott Holofoil");
CardDataNames.Add(252,"Scott Reverse Holo");
CardDataNames.Add(253,"Wally's Training");
CardDataNames.Add(254,"Wally's Training Holofoil");
CardDataNames.Add(255,"Wally's Training Reverse Holo");
CardDataNames.Add(256,"Darkness Energy");
CardDataNames.Add(257,"Darkness Energy Holofoil");
CardDataNames.Add(258,"Darkness Energy Reverse Holo");
CardDataNames.Add(259,"Double Rainbow Energy");
CardDataNames.Add(260,"Double Rainbow Energy Holofoil");
CardDataNames.Add(261,"Double Rainbow Energy Reverse Holo");
CardDataNames.Add(262,"Metal Energy");
CardDataNames.Add(263,"Metal Energy Holofoil");
CardDataNames.Add(264,"Metal Energy Reverse Holo");
CardDataNames.Add(265,"Multi Energy");
CardDataNames.Add(266,"Multi Energy Holofoil");
CardDataNames.Add(267,"Multi Energy Reverse Holo");
CardDataNames.Add(268,"Altaria ex");
CardDataNames.Add(269,"Cacturne ex");
CardDataNames.Add(270,"Camerupt ex");
CardDataNames.Add(271,"Deoxys ex");
CardDataNames.Add(272,"Dusclops ex");
CardDataNames.Add(273,"Medicham ex");
CardDataNames.Add(274,"Milotic ex");
CardDataNames.Add(275,"Raichu ex");
CardDataNames.Add(276,"Regice ex");
CardDataNames.Add(277,"Regirock ex");
CardDataNames.Add(278,"Registeel ex");
CardDataNames.Add(279,"Grass");
CardDataNames.Add(280,"Grass Holofoil");
CardDataNames.Add(281,"Grass Reverse Holo");
CardDataNames.Add(282,"Fire");
CardDataNames.Add(283,"Fire Holofoil");
CardDataNames.Add(284,"Fire Reverse Holo");
CardDataNames.Add(285,"Water");
CardDataNames.Add(286,"Water Holofoil");
CardDataNames.Add(287,"Water Reverse Holo");
CardDataNames.Add(288,"Lightning");
CardDataNames.Add(289,"Lightning Holofoil");
CardDataNames.Add(290,"Lightning Reverse Holo");
CardDataNames.Add(291,"Psychic");
CardDataNames.Add(292,"Psychic Holofoil");
CardDataNames.Add(293,"Psychic Reverse Holo");
CardDataNames.Add(294,"Fighting");
CardDataNames.Add(295,"Fighting Holofoil");
CardDataNames.Add(296,"Fighting Reverse Holo");
CardDataNames.Add(297,"Farfetch'd");
CardDataNames.Add(298,"Farfetch'd Holofoil");
CardDataNames.Add(299,"Farfetch'd Reverse Holo");
	}

	public void SetCardValues() {
CardDataValues.Add(1,18.81);
CardDataValues.Add(2,90.288);
CardDataValues.Add(3,45.144);
CardDataValues.Add(4,18.98);
CardDataValues.Add(5,91.104);
CardDataValues.Add(6,45.552);
CardDataValues.Add(7,8);
CardDataValues.Add(8,38.4);
CardDataValues.Add(9,19.2);
CardDataValues.Add(10,12.91);
CardDataValues.Add(11,61.968);
CardDataValues.Add(12,30.984);
CardDataValues.Add(13,19.29);
CardDataValues.Add(14,92.592);
CardDataValues.Add(15,46.296);
CardDataValues.Add(16,34.17);
CardDataValues.Add(17,164.016);
CardDataValues.Add(18,82.008);
CardDataValues.Add(19,3.93);
CardDataValues.Add(20,18.864);
CardDataValues.Add(21,9.432);
CardDataValues.Add(22,7.48);
CardDataValues.Add(23,35.904);
CardDataValues.Add(24,17.952);
CardDataValues.Add(25,42.42);
CardDataValues.Add(26,203.616);
CardDataValues.Add(27,101.808);
CardDataValues.Add(28,9.41);
CardDataValues.Add(29,45.168);
CardDataValues.Add(30,22.584);
CardDataValues.Add(31,17.1);
CardDataValues.Add(32,82.08);
CardDataValues.Add(33,41.04);
CardDataValues.Add(34,1.62);
CardDataValues.Add(35,7.776);
CardDataValues.Add(36,3.888);
CardDataValues.Add(37,0.7);
CardDataValues.Add(38,3.36);
CardDataValues.Add(39,1.68);
CardDataValues.Add(40,3);
CardDataValues.Add(41,14.4);
CardDataValues.Add(42,7.2);
CardDataValues.Add(43,3.38);
CardDataValues.Add(44,16.224);
CardDataValues.Add(45,8.112);
CardDataValues.Add(46,1.29);
CardDataValues.Add(47,6.192);
CardDataValues.Add(48,3.096);
CardDataValues.Add(49,1);
CardDataValues.Add(50,4.8);
CardDataValues.Add(51,2.4);
CardDataValues.Add(52,1.29);
CardDataValues.Add(53,6.192);
CardDataValues.Add(54,3.096);
CardDataValues.Add(55,0.99);
CardDataValues.Add(56,4.752);
CardDataValues.Add(57,2.376);
CardDataValues.Add(58,1.49);
CardDataValues.Add(59,7.152);
CardDataValues.Add(60,3.576);
CardDataValues.Add(61,1.11);
CardDataValues.Add(62,5.328);
CardDataValues.Add(63,2.664);
CardDataValues.Add(64,1.73);
CardDataValues.Add(65,8.304);
CardDataValues.Add(66,4.152);
CardDataValues.Add(67,0.49);
CardDataValues.Add(68,2.352);
CardDataValues.Add(69,1.176);
CardDataValues.Add(70,2.15);
CardDataValues.Add(71,10.32);
CardDataValues.Add(72,5.16);
CardDataValues.Add(73,0.6);
CardDataValues.Add(74,2.88);
CardDataValues.Add(75,1.44);
CardDataValues.Add(76,0.82);
CardDataValues.Add(77,3.936);
CardDataValues.Add(78,1.968);
CardDataValues.Add(79,0.7);
CardDataValues.Add(80,3.36);
CardDataValues.Add(81,1.68);
CardDataValues.Add(82,0.75);
CardDataValues.Add(83,3.6);
CardDataValues.Add(84,1.8);
CardDataValues.Add(85,0.99);
CardDataValues.Add(86,4.752);
CardDataValues.Add(87,2.376);
CardDataValues.Add(88,0.6);
CardDataValues.Add(89,2.88);
CardDataValues.Add(90,1.44);
CardDataValues.Add(91,0.52);
CardDataValues.Add(92,2.496);
CardDataValues.Add(93,1.248);
CardDataValues.Add(94,0.99);
CardDataValues.Add(95,4.752);
CardDataValues.Add(96,2.376);
CardDataValues.Add(97,1.5);
CardDataValues.Add(98,7.2);
CardDataValues.Add(99,3.6);
CardDataValues.Add(100,2.09);
CardDataValues.Add(101,10.032);
CardDataValues.Add(102,5.016);
CardDataValues.Add(103,1.25);
CardDataValues.Add(104,6);
CardDataValues.Add(105,3);
CardDataValues.Add(106,0.99);
CardDataValues.Add(107,4.752);
CardDataValues.Add(108,2.376);
CardDataValues.Add(109,1.49);
CardDataValues.Add(110,7.152);
CardDataValues.Add(111,3.576);
CardDataValues.Add(112,3.75);
CardDataValues.Add(113,18);
CardDataValues.Add(114,9);
CardDataValues.Add(115,2.24);
CardDataValues.Add(116,10.752);
CardDataValues.Add(117,5.376);
CardDataValues.Add(118,1.49);
CardDataValues.Add(119,7.152);
CardDataValues.Add(120,3.576);
CardDataValues.Add(121,0.98);
CardDataValues.Add(122,4.704);
CardDataValues.Add(123,2.352);
CardDataValues.Add(124,0.99);
CardDataValues.Add(125,4.752);
CardDataValues.Add(126,2.376);
CardDataValues.Add(127,0.54);
CardDataValues.Add(128,2.592);
CardDataValues.Add(129,1.296);
CardDataValues.Add(130,0.49);
CardDataValues.Add(131,2.352);
CardDataValues.Add(132,1.176);
CardDataValues.Add(133,0.4);
CardDataValues.Add(134,1.92);
CardDataValues.Add(135,0.96);
CardDataValues.Add(136,0.31);
CardDataValues.Add(137,1.488);
CardDataValues.Add(138,0.744);
CardDataValues.Add(139,0.29);
CardDataValues.Add(140,1.392);
CardDataValues.Add(141,0.696);
CardDataValues.Add(142,0.75);
CardDataValues.Add(143,3.6);
CardDataValues.Add(144,1.8);
CardDataValues.Add(145,0.99);
CardDataValues.Add(146,4.752);
CardDataValues.Add(147,2.376);
CardDataValues.Add(148,0.39);
CardDataValues.Add(149,1.872);
CardDataValues.Add(150,0.936);
CardDataValues.Add(151,0.3);
CardDataValues.Add(152,1.44);
CardDataValues.Add(153,0.72);
CardDataValues.Add(154,0.5);
CardDataValues.Add(155,2.4);
CardDataValues.Add(156,1.2);
CardDataValues.Add(157,0.6);
CardDataValues.Add(158,2.88);
CardDataValues.Add(159,1.44);
CardDataValues.Add(160,0.4);
CardDataValues.Add(161,1.92);
CardDataValues.Add(162,0.96);
CardDataValues.Add(163,0.38);
CardDataValues.Add(164,1.824);
CardDataValues.Add(165,0.912);
CardDataValues.Add(166,0.78);
CardDataValues.Add(167,3.744);
CardDataValues.Add(168,1.872);
CardDataValues.Add(169,0.65);
CardDataValues.Add(170,3.12);
CardDataValues.Add(171,1.56);
CardDataValues.Add(172,0.33);
CardDataValues.Add(173,1.584);
CardDataValues.Add(174,0.792);
CardDataValues.Add(175,3.97);
CardDataValues.Add(176,19.056);
CardDataValues.Add(177,9.528);
CardDataValues.Add(178,5);
CardDataValues.Add(179,24);
CardDataValues.Add(180,12);
CardDataValues.Add(181,0.75);
CardDataValues.Add(182,3.6);
CardDataValues.Add(183,1.8);
CardDataValues.Add(184,0.4);
CardDataValues.Add(185,1.92);
CardDataValues.Add(186,0.96);
CardDataValues.Add(187,0.49);
CardDataValues.Add(188,2.352);
CardDataValues.Add(189,1.176);
CardDataValues.Add(190,0.33);
CardDataValues.Add(191,1.584);
CardDataValues.Add(192,0.792);
CardDataValues.Add(193,0.49);
CardDataValues.Add(194,2.352);
CardDataValues.Add(195,1.176);
CardDataValues.Add(196,0.4);
CardDataValues.Add(197,1.92);
CardDataValues.Add(198,0.96);
CardDataValues.Add(199,0.64);
CardDataValues.Add(200,3.072);
CardDataValues.Add(201,1.536);
CardDataValues.Add(202,0.4);
CardDataValues.Add(203,1.92);
CardDataValues.Add(204,0.96);
CardDataValues.Add(205,0.47);
CardDataValues.Add(206,2.256);
CardDataValues.Add(207,1.128);
CardDataValues.Add(208,0.5);
CardDataValues.Add(209,2.4);
CardDataValues.Add(210,1.2);
CardDataValues.Add(211,0.47);
CardDataValues.Add(212,2.256);
CardDataValues.Add(213,1.128);
CardDataValues.Add(214,0.47);
CardDataValues.Add(215,2.256);
CardDataValues.Add(216,1.128);
CardDataValues.Add(217,0.48);
CardDataValues.Add(218,2.304);
CardDataValues.Add(219,1.152);
CardDataValues.Add(220,0.99);
CardDataValues.Add(221,4.752);
CardDataValues.Add(222,2.376);
CardDataValues.Add(223,4.53);
CardDataValues.Add(224,21.744);
CardDataValues.Add(225,10.872);
CardDataValues.Add(226,0.49);
CardDataValues.Add(227,2.352);
CardDataValues.Add(228,1.176);
CardDataValues.Add(229,3.09);
CardDataValues.Add(230,14.832);
CardDataValues.Add(231,7.416);
CardDataValues.Add(232,0.89);
CardDataValues.Add(233,4.272);
CardDataValues.Add(234,2.136);
CardDataValues.Add(235,1.21);
CardDataValues.Add(236,5.808);
CardDataValues.Add(237,2.904);
CardDataValues.Add(238,0.35);
CardDataValues.Add(239,1.68);
CardDataValues.Add(240,0.84);
CardDataValues.Add(241,0.49);
CardDataValues.Add(242,2.352);
CardDataValues.Add(243,1.176);
CardDataValues.Add(244,0.35);
CardDataValues.Add(245,1.68);
CardDataValues.Add(246,0.84);
CardDataValues.Add(247,4.99);
CardDataValues.Add(248,23.952);
CardDataValues.Add(249,11.976);
CardDataValues.Add(250,7.56);
CardDataValues.Add(251,36.288);
CardDataValues.Add(252,18.144);
CardDataValues.Add(253,0.5);
CardDataValues.Add(254,2.4);
CardDataValues.Add(255,1.2);
CardDataValues.Add(256,1);
CardDataValues.Add(257,4.8);
CardDataValues.Add(258,2.4);
CardDataValues.Add(259,8.77);
CardDataValues.Add(260,42.096);
CardDataValues.Add(261,21.048);
CardDataValues.Add(262,1.09);
CardDataValues.Add(263,5.232);
CardDataValues.Add(264,2.616);
CardDataValues.Add(265,1.79);
CardDataValues.Add(266,8.592);
CardDataValues.Add(267,4.296);
CardDataValues.Add(268,96.24);
CardDataValues.Add(269,48.02);
CardDataValues.Add(270,43.5);
CardDataValues.Add(271,132.47);
CardDataValues.Add(272,74);
CardDataValues.Add(273,59.49);
CardDataValues.Add(274,226.47);
CardDataValues.Add(275,108.99);
CardDataValues.Add(276,124.5);
CardDataValues.Add(277,69.99);
CardDataValues.Add(278,54.99);
CardDataValues.Add(279,8.3);
CardDataValues.Add(280,39.84);
CardDataValues.Add(281,19.92);
CardDataValues.Add(282,8.2);
CardDataValues.Add(283,39.36);
CardDataValues.Add(284,19.68);
CardDataValues.Add(285,13.51);
CardDataValues.Add(286,64.848);
CardDataValues.Add(287,32.424);
CardDataValues.Add(288,13.98);
CardDataValues.Add(289,67.104);
CardDataValues.Add(290,33.552);
CardDataValues.Add(291,11.33);
CardDataValues.Add(292,54.384);
CardDataValues.Add(293,27.192);
CardDataValues.Add(294,5.96);
CardDataValues.Add(295,28.608);
CardDataValues.Add(296,14.304);
CardDataValues.Add(297,25.66);
CardDataValues.Add(298,123.168);
CardDataValues.Add(299,61.584);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}