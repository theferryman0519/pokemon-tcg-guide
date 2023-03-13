using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using CoreSpace;

namespace SceneSpace {
public class MainMenuScene : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image FerrymanLogo;
	public Image MainLogo;
	public Image OverlayImage;

	public Button OverlayButton;
	
// --------------- PRIVATE VARIABLES ---------------
	Color OverlayBlack = new Color(0.0f, 0.0f, 0.0f, 1.0f);
	Color OverlayOriginal = new Color(0.125f, 0.125f, 0.125f, 1.0f);
	Color OverlayAlpha = new Color(0.125f, 0.125f, 0.125f, 0.0f);
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Set Buttons
		OverlayButton.onClick.AddListener(OverlayButtonClicking);

		// Set Image Colors
		OverlayImage.color = OverlayBlack;

		// Set Object Visibilities
		FerrymanLogo.gameObject.SetActive(true);
		MainLogo.gameObject.SetActive(false);

		// Start Coroutine
		StartCoroutine(FadeOverlayOriginal());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	public IEnumerator FadeOverlayOriginal() {
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 2.0f) {
			ElapsedTime += Time.deltaTime;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayBlack, OverlayOriginal, ElapsedTime);
			yield return null;
		}

		yield return new WaitForSeconds(0.5f);
		StartCoroutine(FadeOverlayOutA());
	}

	public IEnumerator FadeOverlayOutA() {
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 2.0f) {
			ElapsedTime += Time.deltaTime;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayOriginal, OverlayAlpha, ElapsedTime);
			yield return null;
		}

		yield return new WaitForSeconds(0.5f);
		StartCoroutine(FadeOverlayInA());
	}

	public IEnumerator FadeOverlayInA() {
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 2.0f) {
			ElapsedTime += Time.deltaTime;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayAlpha, OverlayOriginal, ElapsedTime);
			yield return null;
		}

		yield return new WaitForSeconds(0.5f);
		FerrymanLogo.gameObject.SetActive(false);
		MainLogo.gameObject.SetActive(true);
		StartCoroutine(FadeOverlayOutB());
	}

	public IEnumerator FadeOverlayOutB() {
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 2.0f) {
			ElapsedTime += Time.deltaTime;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayOriginal, OverlayAlpha, ElapsedTime);
			yield return null;
		}

		yield return new WaitForSeconds(0.5f);
		StartCoroutine(FadeOverlayInB());
	}

	public IEnumerator FadeOverlayInB() {
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 2.0f) {
			ElapsedTime += Time.deltaTime;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayAlpha, OverlayOriginal, ElapsedTime);
			yield return null;
		}

		yield return new WaitForSeconds(0.5f);
		SceneManager.LoadScene(SceneChange.Scene01);
	}
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	public void OverlayButtonClicking() {
		SceneManager.LoadScene(SceneChange.Scene01);
	}
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}