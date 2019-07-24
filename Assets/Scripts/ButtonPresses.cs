using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPresses : MonoBehaviour {
	public bool exitButtonPressed;
	public bool unlockButtonPressed;
	public bool playButtonPressed;

	public GameObject ExitButtonObject;
	public GameObject UnlockButtonObject;
	private Vector2 resolution;

	private bool staticMap;
	public IsStatic isStatic;
	// Use this for initialization
	void Start () {
		staticMap = isStatic.staticMap;
		if (Screen.height == 600 && Screen.width == 960) {
			if (!staticMap) {
				ExitButtonObject.GetComponent<RectTransform>().anchoredPosition = new Vector2 (-301f, -79.6f);
				UnlockButtonObject.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (294f, -79.6f);
			}
			if (staticMap) {
				ExitButtonObject.GetComponent<RectTransform>().anchoredPosition = new Vector2 (-301f, -215f);
			}
		} else {
			if (!staticMap) {
				ExitButtonObject.GetComponent<RectTransform>().anchoredPosition = new Vector2 (-365.7f, -79.6f);
				UnlockButtonObject.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (354.8f, -79.6f);
			}
			if (staticMap) {
				ExitButtonObject.GetComponent<RectTransform>().anchoredPosition = new Vector2 (-365.7f, -215f);
			}
		}
		resolution = new Vector2 (Screen.width, Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
		if (resolution.x != Screen.width || resolution.y != Screen.height) {
			
			if (Screen.height == 600 && Screen.width == 960) {
				if (!staticMap) {
					ExitButtonObject.GetComponent<RectTransform>().anchoredPosition = new Vector2 (-301f, -79.6f);
					UnlockButtonObject.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (294f, -79.6f);
				}
				if (staticMap) {
					ExitButtonObject.GetComponent<RectTransform>().anchoredPosition = new Vector2 (-301f, -215f);
				}
			} else {
				if (!staticMap) {
					ExitButtonObject.GetComponent<RectTransform>().anchoredPosition = new Vector2 (-365.7f, -79.6f);
					UnlockButtonObject.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (354.8f, -79.6f);
				}
				if (staticMap) {
					ExitButtonObject.GetComponent<RectTransform>().anchoredPosition = new Vector2 (-365.7f, -215f);
				}
			}
			resolution.x = Screen.width;
			resolution.y = Screen.height;
		}
	}
	public void ExitButton () {
		exitButtonPressed = true;
	}
	public void FalsifyExit () {
		exitButtonPressed = false;
	}

	public void PlayButton() {
		playButtonPressed = true;
	}
	public void FalsifyPlayButton() {
		playButtonPressed = false;
	}

	public void UnlockButton () {
		unlockButtonPressed = true;
	}
	public void FalsifyUnlockButton () {
		unlockButtonPressed = false;
	}
}
