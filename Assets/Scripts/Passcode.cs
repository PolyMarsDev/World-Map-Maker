using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Passcode : MonoBehaviour {
	public string enteredCode;
	public int currentDigit;
	public Image Box1;
	public Image Box2;
	public Image Box3;
	public Image Box4;
	public Sprite Item0;
	public Sprite Item1;
	public Sprite Item2;
	public Sprite Item3;
	public Sprite Item4;
	public Sprite Item5;
	public Sprite Item6;
	public Sprite Item7;
	public Sprite Item8;
	public Animator UnlockBox;

	public AudioSource audioSource;
	public AudioClip locked;
	public AudioClip coin;

	// Use this for initialization
	void Start () {
		currentDigit = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (enteredCode.Length < 4) {
			
		}
	}
	public void Clear () {
		currentDigit = 1;
		Box1.sprite = null;
		Box1.color = Color.clear;
		Box2.sprite = null;
		Box2.color = Color.clear;
		Box3.sprite = null;
		Box3.color = Color.clear;
		Box4.sprite = null;
		Box4.color = Color.clear;
		enteredCode = "";
	}
	public void Click0 () {
		if (enteredCode.Length < 4) {
			enteredCode = enteredCode + 0;
			if (currentDigit == 1) {
				Box1.color = Color.white;
				Box1.sprite = Item0;
			}
			if (currentDigit == 2) {
				Box2.color = Color.white;
				Box2.sprite = Item0;
			}
			if (currentDigit == 3) {
				Box3.color = Color.white;
				Box3.sprite = Item0;
			}
			if (currentDigit == 4) {
				Box4.color = Color.white;
				Box4.sprite = Item0;
			}
			currentDigit = currentDigit + 1;
		}
	}
	public void Click1 () {
		if (enteredCode.Length < 4) {
			enteredCode = enteredCode + 1;
			if (currentDigit == 1) {
				Box1.color = Color.white;
				Box1.sprite = Item1;
			}
			if (currentDigit == 2) {
				Box2.color = Color.white;
				Box2.sprite = Item1;
			}
			if (currentDigit == 3) {
				Box3.color = Color.white;
				Box3.sprite = Item1;
			}
			if (currentDigit == 4) {
				Box4.color = Color.white;
				Box4.sprite = Item1;
			}
			currentDigit = currentDigit + 1;
		}
	}
	public void Click2 () {
		if (enteredCode.Length < 4) {
			enteredCode = enteredCode + 2;
			if (currentDigit == 1) {
				Box1.color = Color.white;
				Box1.sprite = Item2;
			}
			if (currentDigit == 2) {
				Box2.color = Color.white;
				Box2.sprite = Item2;
			}
			if (currentDigit == 3) {
				Box3.color = Color.white;
				Box3.sprite = Item2;
			}
			if (currentDigit == 4) {
				Box4.color = Color.white;
				Box4.sprite = Item2;
			}
			currentDigit = currentDigit + 1;
		}
	}
	public void Click3 () {
		if (enteredCode.Length < 4) {
			enteredCode = enteredCode + 3;
			if (currentDigit == 1) {
				Box1.color = Color.white;
				Box1.sprite = Item3;
			}
			if (currentDigit == 2) {
				Box2.color = Color.white;
				Box2.sprite = Item3;
			}
			if (currentDigit == 3) {
				Box3.color = Color.white;
				Box3.sprite = Item3;
			}
			if (currentDigit == 4) {
				Box4.color = Color.white;
				Box4.sprite = Item3;
			}
			currentDigit = currentDigit + 1;
		}
	}
	public void Click4 () {
		if (enteredCode.Length < 4) {
			enteredCode = enteredCode + 4;
			if (currentDigit == 1) {
				Box1.color = Color.white;
				Box1.sprite = Item4;
			}
			if (currentDigit == 2) {
				Box2.color = Color.white;
				Box2.sprite = Item4;
			}
			if (currentDigit == 3) {
				Box3.color = Color.white;
				Box3.sprite = Item4;
			}
			if (currentDigit == 4) {
				Box4.color = Color.white;
				Box4.sprite = Item4;
			}
			currentDigit = currentDigit + 1;
		}
	}
	public void Click5 () {
		if (enteredCode.Length < 4) {
			enteredCode = enteredCode + 5;
			if (currentDigit == 1) {
				Box1.color = Color.white;
				Box1.sprite = Item5;
			}
			if (currentDigit == 2) {
				Box2.color = Color.white;
				Box2.sprite = Item5;
			}
			if (currentDigit == 3) {
				Box3.color = Color.white;
				Box3.sprite = Item5;
			}
			if (currentDigit == 4) {
				Box4.color = Color.white;
				Box4.sprite = Item5;
			}
			currentDigit = currentDigit + 1;
		}
	}
	public void Click6 () {
		if (enteredCode.Length < 4) {
			enteredCode = enteredCode + 6;
			if (currentDigit == 1) {
				Box1.color = Color.white;
				Box1.sprite = Item6;
			}
			if (currentDigit == 2) {
				Box2.color = Color.white;
				Box2.sprite = Item6;
			}
			if (currentDigit == 3) {
				Box3.color = Color.white;
				Box3.sprite = Item6;
			}
			if (currentDigit == 4) {
				Box4.color = Color.white;
				Box4.sprite = Item6;
			}
			currentDigit = currentDigit + 1;
		}
	}
	public void Click7 () {
		if (enteredCode.Length < 4) {
			enteredCode = enteredCode + 7;
			if (currentDigit == 1) {
				Box1.color = Color.white;
				Box1.sprite = Item7;
			}
			if (currentDigit == 2) {
				Box2.color = Color.white;
				Box2.sprite = Item7;
			}
			if (currentDigit == 3) {
				Box3.color = Color.white;
				Box3.sprite = Item7;
			}
			if (currentDigit == 4) {
				Box4.color = Color.white;
				Box4.sprite = Item7;
			}
			currentDigit = currentDigit + 1;
		}
	}
	public void Click8 () {
		if (enteredCode.Length < 4) {
			enteredCode = enteredCode + 8;
			if (currentDigit == 1) {
				Box1.color = Color.white;
				Box1.sprite = Item8;
			}
			if (currentDigit == 2) {
				Box2.color = Color.white;
				Box2.sprite = Item8;
			}
			if (currentDigit == 3) {
				Box3.color = Color.white;
				Box3.sprite = Item8;
			}
			if (currentDigit == 4) {
				Box4.color = Color.white;
				Box4.sprite = Item8;
			}
			currentDigit = currentDigit + 1;
		}
	}
	public void lockSFX () {
		UnlockBox.Play ("Unlock", 0, 0f);
		audioSource.clip = locked;
		audioSource.Play ();
	}
	public void unlockSFX () {
		audioSource.clip = coin;
		audioSource.Play ();
	}
}
