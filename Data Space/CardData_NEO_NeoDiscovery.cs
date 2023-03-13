using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace DataSpace {
public class CardData_NEO_NeoDiscovery : MonoBehaviour {
		
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
	}

	public void SetCardNames() {
CardDataNames.Add(1,"Espeon");
CardDataNames.Add(2,"Forretress");
CardDataNames.Add(3,"Hitmontop");
CardDataNames.Add(4,"Houndoom");
CardDataNames.Add(5,"Houndour");
CardDataNames.Add(6,"Kabutops");
CardDataNames.Add(7,"Magnemite");
CardDataNames.Add(8,"Politoed");
CardDataNames.Add(9,"Poliwrath");
CardDataNames.Add(10,"Scizor");
CardDataNames.Add(11,"Smeargle");
CardDataNames.Add(12,"Tyranitar");
CardDataNames.Add(13,"Umbreon");
CardDataNames.Add(14,"Unown A");
CardDataNames.Add(15,"Ursaring");
CardDataNames.Add(16,"Wobbuffet");
CardDataNames.Add(17,"Yanma");
CardDataNames.Add(18,"Beedrill");
CardDataNames.Add(19,"Butterfree");
CardDataNames.Add(20,"Espeon");
CardDataNames.Add(21,"Forretress");
CardDataNames.Add(22,"Hitmontop");
CardDataNames.Add(23,"Houndoom");
CardDataNames.Add(24,"Houndour");
CardDataNames.Add(25,"Kabutops");
CardDataNames.Add(26,"Magnemite");
CardDataNames.Add(27,"Politoed");
CardDataNames.Add(28,"Poliwrath");
CardDataNames.Add(29,"Scizor");
CardDataNames.Add(30,"Smeargle");
CardDataNames.Add(31,"Tyranitar");
CardDataNames.Add(32,"Umbreon");
CardDataNames.Add(33,"Unown A");
CardDataNames.Add(34,"Ursaring");
CardDataNames.Add(35,"Wobbuffet");
CardDataNames.Add(36,"Yanma");
CardDataNames.Add(37,"Corsola");
CardDataNames.Add(38,"Eevee");
CardDataNames.Add(39,"Houndour");
CardDataNames.Add(40,"Igglybuff");
CardDataNames.Add(41,"Kakuna");
CardDataNames.Add(42,"Metapod");
CardDataNames.Add(43,"Omastar");
CardDataNames.Add(44,"Poliwhirl");
CardDataNames.Add(45,"Pupitar");
CardDataNames.Add(46,"Scyther");
CardDataNames.Add(47,"Unown D");
CardDataNames.Add(48,"Unown F");
CardDataNames.Add(49,"Unown M");
CardDataNames.Add(50,"Unown N");
CardDataNames.Add(51,"Unown U");
CardDataNames.Add(52,"Xatu");
CardDataNames.Add(53,"Caterpie");
CardDataNames.Add(54,"Dunsparce");
CardDataNames.Add(55,"Hoppip");
CardDataNames.Add(56,"Kabuto");
CardDataNames.Add(57,"Larvitar");
CardDataNames.Add(58,"Mareep");
CardDataNames.Add(59,"Natu");
CardDataNames.Add(60,"Omanyte");
CardDataNames.Add(61,"Pineco");
CardDataNames.Add(62,"Poliwag");
CardDataNames.Add(63,"Sentret");
CardDataNames.Add(64,"Spinarak");
CardDataNames.Add(65,"Teddiursa");
CardDataNames.Add(66,"Tyrogue");
CardDataNames.Add(67,"Unown E");
CardDataNames.Add(68,"Unown I");
CardDataNames.Add(69,"Unown O");
CardDataNames.Add(70,"Weedle");
CardDataNames.Add(71,"Wooper");
CardDataNames.Add(72,"Fossil Egg");
CardDataNames.Add(73,"Hyper Devolution Spray");
CardDataNames.Add(74,"Ruin Wall");
CardDataNames.Add(75,"Energy Ark");
	}

	public void SetCardValues() {
CardDataValues.Add(1,409.99);
CardDataValues.Add(2,65.99);
CardDataValues.Add(3,74.4);
CardDataValues.Add(4,98.99);
CardDataValues.Add(5,148);
CardDataValues.Add(6,150);
CardDataValues.Add(7,54.49);
CardDataValues.Add(8,56.3);
CardDataValues.Add(9,69.99);
CardDataValues.Add(10,83);
CardDataValues.Add(11,84.36);
CardDataValues.Add(12,259.98);
CardDataValues.Add(13,699.99);
CardDataValues.Add(14,99.99);
CardDataValues.Add(15,53.12);
CardDataValues.Add(16,60.46);
CardDataValues.Add(17,55.16);
CardDataValues.Add(18,16.95);
CardDataValues.Add(19,15.29);
CardDataValues.Add(20,59.18);
CardDataValues.Add(21,6.13);
CardDataValues.Add(22,13.82);
CardDataValues.Add(23,20.32);
CardDataValues.Add(24,16.97);
CardDataValues.Add(25,25.75);
CardDataValues.Add(26,9.88);
CardDataValues.Add(27,24.99);
CardDataValues.Add(28,13.28);
CardDataValues.Add(29,26);
CardDataValues.Add(30,21.24);
CardDataValues.Add(31,50);
CardDataValues.Add(32,89.81);
CardDataValues.Add(33,18.85);
CardDataValues.Add(34,15.18);
CardDataValues.Add(35,11.64);
CardDataValues.Add(36,29.99);
CardDataValues.Add(37,3.29);
CardDataValues.Add(38,14.89);
CardDataValues.Add(39,3.01);
CardDataValues.Add(40,6.81);
CardDataValues.Add(41,1.45);
CardDataValues.Add(42,1.96);
CardDataValues.Add(43,2.55);
CardDataValues.Add(44,2.8);
CardDataValues.Add(45,3.31);
CardDataValues.Add(46,4.79);
CardDataValues.Add(47,1.54);
CardDataValues.Add(48,2.29);
CardDataValues.Add(49,1.97);
CardDataValues.Add(50,1.64);
CardDataValues.Add(51,1.94);
CardDataValues.Add(52,1.21);
CardDataValues.Add(53,0.93);
CardDataValues.Add(54,1.15);
CardDataValues.Add(55,0.8);
CardDataValues.Add(56,1.17);
CardDataValues.Add(57,1.02);
CardDataValues.Add(58,1.13);
CardDataValues.Add(59,0.79);
CardDataValues.Add(60,0.97);
CardDataValues.Add(61,1.08);
CardDataValues.Add(62,0.86);
CardDataValues.Add(63,0.87);
CardDataValues.Add(64,0.83);
CardDataValues.Add(65,0.91);
CardDataValues.Add(66,1.39);
CardDataValues.Add(67,0.93);
CardDataValues.Add(68,1.08);
CardDataValues.Add(69,0.93);
CardDataValues.Add(70,0.94);
CardDataValues.Add(71,0.95);
CardDataValues.Add(72,1.27);
CardDataValues.Add(73,2.01);
CardDataValues.Add(74,1.68);
CardDataValues.Add(75,0.7);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}