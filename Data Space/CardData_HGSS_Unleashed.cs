using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_HGSS_Unleashed : MonoBehaviour {
		
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
CardDataNumbers.Add(271,"92");
CardDataNumbers.Add(272,"92H");
CardDataNumbers.Add(273,"92RH");
CardDataNumbers.Add(274,"94");
CardDataNumbers.Add(275,"94H");
CardDataNumbers.Add(276,"94RH");
CardDataNumbers.Add(277,"TWO");
CardDataNumbers.Add(278,"TWORH");
CardDataNumbers.Add(279,"TWOH");
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Jirachi");
CardDataNames.Add(2,"Jirachi Holofoil");
CardDataNames.Add(3,"Jirachi Reverse Holo");
CardDataNames.Add(4,"Magmortar");
CardDataNames.Add(5,"Magmortar Holofoil");
CardDataNames.Add(6,"Magmortar Reverse Holo");
CardDataNames.Add(7,"Manaphy");
CardDataNames.Add(8,"Manaphy Holofoil");
CardDataNames.Add(9,"Manaphy Reverse Holo");
CardDataNames.Add(10,"Metagross");
CardDataNames.Add(11,"Metagross Holofoil");
CardDataNames.Add(12,"Metagross Reverse Holo");
CardDataNames.Add(13,"Mismagius");
CardDataNames.Add(14,"Mismagius Holofoil");
CardDataNames.Add(15,"Mismagius Reverse Holo");
CardDataNames.Add(16,"Octillery");
CardDataNames.Add(17,"Octillery Holofoil");
CardDataNames.Add(18,"Octillery Reverse Holo");
CardDataNames.Add(19,"Politoed");
CardDataNames.Add(20,"Politoed Holofoil");
CardDataNames.Add(21,"Politoed Reverse Holo");
CardDataNames.Add(22,"Shaymin");
CardDataNames.Add(23,"Shaymin Holofoil");
CardDataNames.Add(24,"Shaymin Reverse Holo");
CardDataNames.Add(25,"Sudowoodo");
CardDataNames.Add(26,"Sudowoodo Holofoil");
CardDataNames.Add(27,"Sudowoodo Reverse Holo");
CardDataNames.Add(28,"Torterra");
CardDataNames.Add(29,"Torterra Holofoil");
CardDataNames.Add(30,"Torterra Reverse Holo");
CardDataNames.Add(31,"Xatu");
CardDataNames.Add(32,"Xatu Holofoil");
CardDataNames.Add(33,"Xatu Reverse Holo");
CardDataNames.Add(34,"Beedrill");
CardDataNames.Add(35,"Beedrill Holofoil");
CardDataNames.Add(36,"Beedrill Reverse Holo");
CardDataNames.Add(37,"Blastoise");
CardDataNames.Add(38,"Blastoise Holofoil");
CardDataNames.Add(39,"Blastoise Reverse Holo");
CardDataNames.Add(40,"Crobat");
CardDataNames.Add(41,"Crobat Holofoil");
CardDataNames.Add(42,"Crobat Reverse Holo");
CardDataNames.Add(43,"Fearow");
CardDataNames.Add(44,"Fearow Holofoil");
CardDataNames.Add(45,"Fearow Reverse Holo");
CardDataNames.Add(46,"Floatzel");
CardDataNames.Add(47,"Floatzel Holofoil");
CardDataNames.Add(48,"Floatzel Reverse Holo");
CardDataNames.Add(49,"Kingdra");
CardDataNames.Add(50,"Kingdra Holofoil");
CardDataNames.Add(51,"Kingdra Reverse Holo");
CardDataNames.Add(52,"Lanturn");
CardDataNames.Add(53,"Lanturn Holofoil");
CardDataNames.Add(54,"Lanturn Reverse Holo");
CardDataNames.Add(55,"Lucario");
CardDataNames.Add(56,"Lucario Holofoil");
CardDataNames.Add(57,"Lucario Reverse Holo");
CardDataNames.Add(58,"Ninetales");
CardDataNames.Add(59,"Ninetales Holofoil");
CardDataNames.Add(60,"Ninetales Reverse Holo");
CardDataNames.Add(61,"Poliwrath");
CardDataNames.Add(62,"Poliwrath Holofoil");
CardDataNames.Add(63,"Poliwrath Reverse Holo");
CardDataNames.Add(64,"Primeape");
CardDataNames.Add(65,"Primeape Holofoil");
CardDataNames.Add(66,"Primeape Reverse Holo");
CardDataNames.Add(67,"Roserade");
CardDataNames.Add(68,"Roserade Holofoil");
CardDataNames.Add(69,"Roserade Reverse Holo");
CardDataNames.Add(70,"Steelix");
CardDataNames.Add(71,"Steelix Holofoil");
CardDataNames.Add(72,"Steelix Reverse Holo");
CardDataNames.Add(73,"Torkoal");
CardDataNames.Add(74,"Torkoal Holofoil");
CardDataNames.Add(75,"Torkoal Reverse Holo");
CardDataNames.Add(76,"Tyranitar");
CardDataNames.Add(77,"Tyranitar Holofoil");
CardDataNames.Add(78,"Tyranitar Reverse Holo");
CardDataNames.Add(79,"Ursaring");
CardDataNames.Add(80,"Ursaring Holofoil");
CardDataNames.Add(81,"Ursaring Reverse Holo");
CardDataNames.Add(82,"Cherrim");
CardDataNames.Add(83,"Cherrim Holofoil");
CardDataNames.Add(84,"Cherrim Reverse Holo");
CardDataNames.Add(85,"Dunsparce");
CardDataNames.Add(86,"Dunsparce Holofoil");
CardDataNames.Add(87,"Dunsparce Reverse Holo");
CardDataNames.Add(88,"Golbat");
CardDataNames.Add(89,"Golbat Holofoil");
CardDataNames.Add(90,"Golbat Reverse Holo");
CardDataNames.Add(91,"Grotle");
CardDataNames.Add(92,"Grotle Holofoil");
CardDataNames.Add(93,"Grotle Reverse Holo");
CardDataNames.Add(94,"Kakuna");
CardDataNames.Add(95,"Kakuna Holofoil");
CardDataNames.Add(96,"Kakuna Reverse Holo");
CardDataNames.Add(97,"Metang");
CardDataNames.Add(98,"Metang Holofoil");
CardDataNames.Add(99,"Metang Reverse Holo");
CardDataNames.Add(100,"Minun");
CardDataNames.Add(101,"Minun Holofoil");
CardDataNames.Add(102,"Minun Reverse Holo");
CardDataNames.Add(103,"Numel");
CardDataNames.Add(104,"Numel Holofoil");
CardDataNames.Add(105,"Numel Reverse Holo");
CardDataNames.Add(106,"Plusle");
CardDataNames.Add(107,"Plusle Holofoil");
CardDataNames.Add(108,"Plusle Reverse Holo");
CardDataNames.Add(109,"Poliwhirl");
CardDataNames.Add(110,"Poliwhirl Holofoil");
CardDataNames.Add(111,"Poliwhirl Reverse Holo");
CardDataNames.Add(112,"Pupitar");
CardDataNames.Add(113,"Pupitar Holofoil");
CardDataNames.Add(114,"Pupitar Reverse Holo");
CardDataNames.Add(115,"Pupitar");
CardDataNames.Add(116,"Pupitar Holofoil");
CardDataNames.Add(117,"Pupitar Reverse Holo");
CardDataNames.Add(118,"Seadra");
CardDataNames.Add(119,"Seadra Holofoil");
CardDataNames.Add(120,"Seadra Reverse Holo");
CardDataNames.Add(121,"Tauros");
CardDataNames.Add(122,"Tauros Holofoil");
CardDataNames.Add(123,"Tauros Reverse Holo");
CardDataNames.Add(124,"Wartortle");
CardDataNames.Add(125,"Wartortle Holofoil");
CardDataNames.Add(126,"Wartortle Reverse Holo");
CardDataNames.Add(127,"Aipom");
CardDataNames.Add(128,"Aipom Holofoil");
CardDataNames.Add(129,"Aipom Reverse Holo");
CardDataNames.Add(130,"Beldum");
CardDataNames.Add(131,"Beldum Holofoil");
CardDataNames.Add(132,"Beldum Reverse Holo");
CardDataNames.Add(133,"Buizel");
CardDataNames.Add(134,"Buizel Holofoil");
CardDataNames.Add(135,"Buizel Reverse Holo");
CardDataNames.Add(136,"Carnivine");
CardDataNames.Add(137,"Carnivine Holofoil");
CardDataNames.Add(138,"Carnivine Reverse Holo");
CardDataNames.Add(139,"Cherubi");
CardDataNames.Add(140,"Cherubi Holofoil");
CardDataNames.Add(141,"Cherubi Reverse Holo");
CardDataNames.Add(142,"Chinchou");
CardDataNames.Add(143,"Chinchou Holofoil");
CardDataNames.Add(144,"Chinchou Reverse Holo");
CardDataNames.Add(145,"Horsea");
CardDataNames.Add(146,"Horsea Holofoil");
CardDataNames.Add(147,"Horsea Reverse Holo");
CardDataNames.Add(148,"Larvitar");
CardDataNames.Add(149,"Larvitar Holofoil");
CardDataNames.Add(150,"Larvitar Reverse Holo");
CardDataNames.Add(151,"Larvitar");
CardDataNames.Add(152,"Larvitar Holofoil");
CardDataNames.Add(153,"Larvitar Reverse Holo");
CardDataNames.Add(154,"Magmar");
CardDataNames.Add(155,"Magmar Holofoil");
CardDataNames.Add(156,"Magmar Reverse Holo");
CardDataNames.Add(157,"Mankey");
CardDataNames.Add(158,"Mankey Holofoil");
CardDataNames.Add(159,"Mankey Reverse Holo");
CardDataNames.Add(160,"Misdreavus");
CardDataNames.Add(161,"Misdreavus Holofoil");
CardDataNames.Add(162,"Misdreavus Reverse Holo");
CardDataNames.Add(163,"Natu");
CardDataNames.Add(164,"Natu Holofoil");
CardDataNames.Add(165,"Natu Reverse Holo");
CardDataNames.Add(166,"Onix");
CardDataNames.Add(167,"Onix Holofoil");
CardDataNames.Add(168,"Onix Reverse Holo");
CardDataNames.Add(169,"Onix");
CardDataNames.Add(170,"Onix Holofoil");
CardDataNames.Add(171,"Onix Reverse Holo");
CardDataNames.Add(172,"Poliwag");
CardDataNames.Add(173,"Poliwag Holofoil");
CardDataNames.Add(174,"Poliwag Reverse Holo");
CardDataNames.Add(175,"Remoraid");
CardDataNames.Add(176,"Remoraid Holofoil");
CardDataNames.Add(177,"Remoraid Reverse Holo");
CardDataNames.Add(178,"Riolu");
CardDataNames.Add(179,"Riolu Holofoil");
CardDataNames.Add(180,"Riolu Reverse Holo");
CardDataNames.Add(181,"Roselia");
CardDataNames.Add(182,"Roselia Holofoil");
CardDataNames.Add(183,"Roselia Reverse Holo");
CardDataNames.Add(184,"Spearow");
CardDataNames.Add(185,"Spearow Holofoil");
CardDataNames.Add(186,"Spearow Reverse Holo");
CardDataNames.Add(187,"Squirtle");
CardDataNames.Add(188,"Squirtle Holofoil");
CardDataNames.Add(189,"Squirtle Reverse Holo");
CardDataNames.Add(190,"Stantler");
CardDataNames.Add(191,"Stantler Holofoil");
CardDataNames.Add(192,"Stantler Reverse Holo");
CardDataNames.Add(193,"Teddiursa");
CardDataNames.Add(194,"Teddiursa Holofoil");
CardDataNames.Add(195,"Teddiursa Reverse Holo");
CardDataNames.Add(196,"Tropius");
CardDataNames.Add(197,"Tropius Holofoil");
CardDataNames.Add(198,"Tropius Reverse Holo");
CardDataNames.Add(199,"Turtwig");
CardDataNames.Add(200,"Turtwig Holofoil");
CardDataNames.Add(201,"Turtwig Reverse Holo");
CardDataNames.Add(202,"Vulpix");
CardDataNames.Add(203,"Vulpix Holofoil");
CardDataNames.Add(204,"Vulpix Reverse Holo");
CardDataNames.Add(205,"Weedle");
CardDataNames.Add(206,"Weedle Holofoil");
CardDataNames.Add(207,"Weedle Reverse Holo");
CardDataNames.Add(208,"Zubat");
CardDataNames.Add(209,"Zubat Holofoil");
CardDataNames.Add(210,"Zubat Reverse Holo");
CardDataNames.Add(211,"Cheerleader's Cheer");
CardDataNames.Add(212,"Cheerleader's Cheer Holofoil");
CardDataNames.Add(213,"Cheerleader's Cheer Reverse Holo");
CardDataNames.Add(214,"Dual Ball");
CardDataNames.Add(215,"Dual Ball Holofoil");
CardDataNames.Add(216,"Dual Ball Reverse Holo");
CardDataNames.Add(217,"Emcee's Chatter");
CardDataNames.Add(218,"Emcee's Chatter Holofoil");
CardDataNames.Add(219,"Emcee's Chatter Reverse Holo");
CardDataNames.Add(220,"Energy Returner");
CardDataNames.Add(221,"Energy Returner Holofoil");
CardDataNames.Add(222,"Energy Returner Reverse Holo");
CardDataNames.Add(223,"Engineer's Adjustments");
CardDataNames.Add(224,"Engineer's Adjustments Holofoil");
CardDataNames.Add(225,"Engineer's Adjustments Reverse Holo");
CardDataNames.Add(226,"Good Rod");
CardDataNames.Add(227,"Good Rod Holofoil");
CardDataNames.Add(228,"Good Rod Reverse Holo");
CardDataNames.Add(229,"Interviewer's Questions");
CardDataNames.Add(230,"Interviewer's Questions Holofoil");
CardDataNames.Add(231,"Interviewer's Questions Reverse Holo");
CardDataNames.Add(232,"Judge");
CardDataNames.Add(233,"Judge Holofoil");
CardDataNames.Add(234,"Judge Reverse Holo");
CardDataNames.Add(235,"Life Herb");
CardDataNames.Add(236,"Life Herb Holofoil");
CardDataNames.Add(237,"Life Herb Reverse Holo");
CardDataNames.Add(238,"Plus Power");
CardDataNames.Add(239,"Plus Power Holofoil");
CardDataNames.Add(240,"Plus Power Reverse Holo");
CardDataNames.Add(241,"Pokémon Circulator");
CardDataNames.Add(242,"Pokémon Circulator Holofoil");
CardDataNames.Add(243,"Pokémon Circulator Reverse Holo");
CardDataNames.Add(244,"Rare Candy");
CardDataNames.Add(245,"Rare Candy Holofoil");
CardDataNames.Add(246,"Rare Candy Reverse Holo");
CardDataNames.Add(247,"Super Scoop Up");
CardDataNames.Add(248,"Super Scoop Up Holofoil");
CardDataNames.Add(249,"Super Scoop Up Reverse Holo");
CardDataNames.Add(250,"Crobat");
CardDataNames.Add(251,"Crobat Holofoil");
CardDataNames.Add(252,"Crobat Reverse Holo");
CardDataNames.Add(253,"Kingdra");
CardDataNames.Add(254,"Kingdra Holofoil");
CardDataNames.Add(255,"Kingdra Reverse Holo");
CardDataNames.Add(256,"Lanturn");
CardDataNames.Add(257,"Lanturn Holofoil");
CardDataNames.Add(258,"Lanturn Reverse Holo");
CardDataNames.Add(259,"Steelix");
CardDataNames.Add(260,"Steelix Holofoil");
CardDataNames.Add(261,"Steelix Reverse Holo");
CardDataNames.Add(262,"Tyranitar");
CardDataNames.Add(263,"Tyranitar Holofoil");
CardDataNames.Add(264,"Tyranitar Reverse Holo");
CardDataNames.Add(265,"Ursaring");
CardDataNames.Add(266,"Ursaring Holofoil");
CardDataNames.Add(267,"Ursaring Reverse Holo");
CardDataNames.Add(268,"Entei & Raikou");
CardDataNames.Add(269,"Entei & Raikou Holofoil");
CardDataNames.Add(270,"Entei & Raikou Reverse Holo");
CardDataNames.Add(271,"Raikou & Suicune");
CardDataNames.Add(272,"Raikou & Suicune Holofoil");
CardDataNames.Add(273,"Raikou & Suicune Reverse Holo");
CardDataNames.Add(274,"Suicune & Entei");
CardDataNames.Add(275,"Suicune & Entei Holofoil");
CardDataNames.Add(276,"Suicune & Entei Reverse Holo");
CardDataNames.Add(277,"Alph Litograph");
CardDataNames.Add(278,"Alph Litograph Holofoil");
CardDataNames.Add(279,"Alph Litograph Reverse Holo");
	}

	public void SetCardValues() {
CardDataValues.Add(1,9.25);
CardDataValues.Add(2,44.4);
CardDataValues.Add(3,22.2);
CardDataValues.Add(4,2);
CardDataValues.Add(5,9.6);
CardDataValues.Add(6,4.8);
CardDataValues.Add(7,3.2);
CardDataValues.Add(8,15.36);
CardDataValues.Add(9,7.68);
CardDataValues.Add(10,3.05);
CardDataValues.Add(11,14.64);
CardDataValues.Add(12,7.32);
CardDataValues.Add(13,2.4);
CardDataValues.Add(14,11.52);
CardDataValues.Add(15,5.76);
CardDataValues.Add(16,2.7);
CardDataValues.Add(17,12.96);
CardDataValues.Add(18,6.48);
CardDataValues.Add(19,5.8);
CardDataValues.Add(20,27.84);
CardDataValues.Add(21,13.92);
CardDataValues.Add(22,9.48);
CardDataValues.Add(23,45.504);
CardDataValues.Add(24,22.752);
CardDataValues.Add(25,4.47);
CardDataValues.Add(26,21.456);
CardDataValues.Add(27,10.728);
CardDataValues.Add(28,4.48);
CardDataValues.Add(29,21.504);
CardDataValues.Add(30,10.752);
CardDataValues.Add(31,2.6);
CardDataValues.Add(32,12.48);
CardDataValues.Add(33,6.24);
CardDataValues.Add(34,0.79);
CardDataValues.Add(35,3.792);
CardDataValues.Add(36,1.896);
CardDataValues.Add(37,5.68);
CardDataValues.Add(38,27.264);
CardDataValues.Add(39,13.632);
CardDataValues.Add(40,1);
CardDataValues.Add(41,4.8);
CardDataValues.Add(42,2.4);
CardDataValues.Add(43,0.49);
CardDataValues.Add(44,2.352);
CardDataValues.Add(45,1.176);
CardDataValues.Add(46,0.5);
CardDataValues.Add(47,2.4);
CardDataValues.Add(48,1.2);
CardDataValues.Add(49,0.95);
CardDataValues.Add(50,4.56);
CardDataValues.Add(51,2.28);
CardDataValues.Add(52,0.5);
CardDataValues.Add(53,2.4);
CardDataValues.Add(54,1.2);
CardDataValues.Add(55,1);
CardDataValues.Add(56,4.8);
CardDataValues.Add(57,2.4);
CardDataValues.Add(58,3.11);
CardDataValues.Add(59,14.928);
CardDataValues.Add(60,7.464);
CardDataValues.Add(61,1.02);
CardDataValues.Add(62,4.896);
CardDataValues.Add(63,2.448);
CardDataValues.Add(64,0.53);
CardDataValues.Add(65,2.544);
CardDataValues.Add(66,1.272);
CardDataValues.Add(67,0.63);
CardDataValues.Add(68,3.024);
CardDataValues.Add(69,1.512);
CardDataValues.Add(70,1.83);
CardDataValues.Add(71,8.784);
CardDataValues.Add(72,4.392);
CardDataValues.Add(73,0.5);
CardDataValues.Add(74,2.4);
CardDataValues.Add(75,1.2);
CardDataValues.Add(76,1.93);
CardDataValues.Add(77,9.264);
CardDataValues.Add(78,4.632);
CardDataValues.Add(79,0.75);
CardDataValues.Add(80,3.6);
CardDataValues.Add(81,1.8);
CardDataValues.Add(82,0.29);
CardDataValues.Add(83,1.392);
CardDataValues.Add(84,0.696);
CardDataValues.Add(85,0.35);
CardDataValues.Add(86,1.68);
CardDataValues.Add(87,0.84);
CardDataValues.Add(88,0.4);
CardDataValues.Add(89,1.92);
CardDataValues.Add(90,0.96);
CardDataValues.Add(91,0.58);
CardDataValues.Add(92,2.784);
CardDataValues.Add(93,1.392);
CardDataValues.Add(94,0.41);
CardDataValues.Add(95,1.968);
CardDataValues.Add(96,0.984);
CardDataValues.Add(97,0.33);
CardDataValues.Add(98,1.584);
CardDataValues.Add(99,0.792);
CardDataValues.Add(100,0.48);
CardDataValues.Add(101,2.304);
CardDataValues.Add(102,1.152);
CardDataValues.Add(103,0.31);
CardDataValues.Add(104,1.488);
CardDataValues.Add(105,0.744);
CardDataValues.Add(106,0.45);
CardDataValues.Add(107,2.16);
CardDataValues.Add(108,1.08);
CardDataValues.Add(109,0.7);
CardDataValues.Add(110,3.36);
CardDataValues.Add(111,1.68);
CardDataValues.Add(112,0.45);
CardDataValues.Add(113,2.16);
CardDataValues.Add(114,1.08);
CardDataValues.Add(115,0.5);
CardDataValues.Add(116,2.4);
CardDataValues.Add(117,1.2);
CardDataValues.Add(118,0.53);
CardDataValues.Add(119,2.544);
CardDataValues.Add(120,1.272);
CardDataValues.Add(121,0.47);
CardDataValues.Add(122,2.256);
CardDataValues.Add(123,1.128);
CardDataValues.Add(124,1.92);
CardDataValues.Add(125,9.216);
CardDataValues.Add(126,4.608);
CardDataValues.Add(127,0.25);
CardDataValues.Add(128,1.2);
CardDataValues.Add(129,0.6);
CardDataValues.Add(130,0.25);
CardDataValues.Add(131,1.2);
CardDataValues.Add(132,0.6);
CardDataValues.Add(133,0.29);
CardDataValues.Add(134,1.392);
CardDataValues.Add(135,0.696);
CardDataValues.Add(136,0.32);
CardDataValues.Add(137,1.536);
CardDataValues.Add(138,0.768);
CardDataValues.Add(139,0.35);
CardDataValues.Add(140,1.68);
CardDataValues.Add(141,0.84);
CardDataValues.Add(142,0.32);
CardDataValues.Add(143,1.536);
CardDataValues.Add(144,0.768);
CardDataValues.Add(145,0.31);
CardDataValues.Add(146,1.488);
CardDataValues.Add(147,0.744);
CardDataValues.Add(148,0.47);
CardDataValues.Add(149,2.256);
CardDataValues.Add(150,1.128);
CardDataValues.Add(151,0.34);
CardDataValues.Add(152,1.632);
CardDataValues.Add(153,0.816);
CardDataValues.Add(154,0.27);
CardDataValues.Add(155,1.296);
CardDataValues.Add(156,0.648);
CardDataValues.Add(157,0.29);
CardDataValues.Add(158,1.392);
CardDataValues.Add(159,0.696);
CardDataValues.Add(160,0.4);
CardDataValues.Add(161,1.92);
CardDataValues.Add(162,0.96);
CardDataValues.Add(163,0.25);
CardDataValues.Add(164,1.2);
CardDataValues.Add(165,0.6);
CardDataValues.Add(166,0.36);
CardDataValues.Add(167,1.728);
CardDataValues.Add(168,0.864);
CardDataValues.Add(169,0.28);
CardDataValues.Add(170,1.344);
CardDataValues.Add(171,0.672);
CardDataValues.Add(172,0.44);
CardDataValues.Add(173,2.112);
CardDataValues.Add(174,1.056);
CardDataValues.Add(175,0.3);
CardDataValues.Add(176,1.44);
CardDataValues.Add(177,0.72);
CardDataValues.Add(178,0.3);
CardDataValues.Add(179,1.44);
CardDataValues.Add(180,0.72);
CardDataValues.Add(181,0.28);
CardDataValues.Add(182,1.344);
CardDataValues.Add(183,0.672);
CardDataValues.Add(184,0.31);
CardDataValues.Add(185,1.488);
CardDataValues.Add(186,0.744);
CardDataValues.Add(187,1.5);
CardDataValues.Add(188,7.2);
CardDataValues.Add(189,3.6);
CardDataValues.Add(190,0.42);
CardDataValues.Add(191,2.016);
CardDataValues.Add(192,1.008);
CardDataValues.Add(193,0.35);
CardDataValues.Add(194,1.68);
CardDataValues.Add(195,0.84);
CardDataValues.Add(196,0.25);
CardDataValues.Add(197,1.2);
CardDataValues.Add(198,0.6);
CardDataValues.Add(199,0.5);
CardDataValues.Add(200,2.4);
CardDataValues.Add(201,1.2);
CardDataValues.Add(202,0.75);
CardDataValues.Add(203,3.6);
CardDataValues.Add(204,1.8);
CardDataValues.Add(205,0.4);
CardDataValues.Add(206,1.92);
CardDataValues.Add(207,0.96);
CardDataValues.Add(208,0.29);
CardDataValues.Add(209,1.392);
CardDataValues.Add(210,0.696);
CardDataValues.Add(211,0.34);
CardDataValues.Add(212,1.632);
CardDataValues.Add(213,0.816);
CardDataValues.Add(214,0.52);
CardDataValues.Add(215,2.496);
CardDataValues.Add(216,1.248);
CardDataValues.Add(217,0.28);
CardDataValues.Add(218,1.344);
CardDataValues.Add(219,0.672);
CardDataValues.Add(220,0.35);
CardDataValues.Add(221,1.68);
CardDataValues.Add(222,0.84);
CardDataValues.Add(223,0.38);
CardDataValues.Add(224,1.824);
CardDataValues.Add(225,0.912);
CardDataValues.Add(226,0.35);
CardDataValues.Add(227,1.68);
CardDataValues.Add(228,0.84);
CardDataValues.Add(229,0.31);
CardDataValues.Add(230,1.488);
CardDataValues.Add(231,0.744);
CardDataValues.Add(232,2.2);
CardDataValues.Add(233,10.56);
CardDataValues.Add(234,5.28);
CardDataValues.Add(235,0.26);
CardDataValues.Add(236,1.248);
CardDataValues.Add(237,0.624);
CardDataValues.Add(238,0.58);
CardDataValues.Add(239,2.784);
CardDataValues.Add(240,1.392);
CardDataValues.Add(241,0.32);
CardDataValues.Add(242,1.536);
CardDataValues.Add(243,0.768);
CardDataValues.Add(244,4.02);
CardDataValues.Add(245,19.296);
CardDataValues.Add(246,9.648);
CardDataValues.Add(247,0.75);
CardDataValues.Add(248,3.6);
CardDataValues.Add(249,1.8);
CardDataValues.Add(250,15.03);
CardDataValues.Add(251,72.144);
CardDataValues.Add(252,36.072);
CardDataValues.Add(253,18.41);
CardDataValues.Add(254,88.368);
CardDataValues.Add(255,44.184);
CardDataValues.Add(256,11.34);
CardDataValues.Add(257,54.432);
CardDataValues.Add(258,27.216);
CardDataValues.Add(259,14.59);
CardDataValues.Add(260,70.032);
CardDataValues.Add(261,35.016);
CardDataValues.Add(262,40.37);
CardDataValues.Add(263,193.776);
CardDataValues.Add(264,96.888);
CardDataValues.Add(265,14.8);
CardDataValues.Add(266,71.04);
CardDataValues.Add(267,35.52);
CardDataValues.Add(268,40.05);
CardDataValues.Add(269,192.24);
CardDataValues.Add(270,96.12);
CardDataValues.Add(271,40.07);
CardDataValues.Add(272,192.336);
CardDataValues.Add(273,96.168);
CardDataValues.Add(274,47.89);
CardDataValues.Add(275,229.872);
CardDataValues.Add(276,114.936);
CardDataValues.Add(277,32.54);
CardDataValues.Add(278,156.192);
CardDataValues.Add(279,78.096);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}