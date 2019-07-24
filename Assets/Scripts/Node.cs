using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour {
	[Header("Level Info")]
	public string levelName;
	public string levelNumber;
	public string levelCode;
	public string password;


	[Header("Node Destinations")]
	public GameObject upDestination;
	public GameObject downDestination;
	public GameObject leftDestination;
	public GameObject rightDestination;


	[Header("If this is the first level in your map, tick this:")]
	public bool accessible;


	[Header("Dependencies")]
	public GameObject player;
	private bool currentNode;
	private bool canMove;
	private bool idleActivated;
	Animator anim;
	public Text levelNameText;
	public Text levelNumberText;
	public Text levelCodeText;
	public GameObject levelMenu;
	public GameObject playButton;
	private bool menuActive;
	public Passcode passcode;
	public IsStatic isStatic;
	private string enteredCode; 
	private bool locked;
	public ButtonPresses buttonPresses;
	private bool exitButtonPressed;
	private bool playButtonPressed;
	private bool unlockButtonPressed;
	private bool staticMap;
	// Use this for initialization
	void Start () {
		locked = true;
		canMove = true;
		if (GetComponent <SpriteRenderer> () != null) {
			GetComponent <SpriteRenderer> ().enabled = false;
		}
		anim = player.GetComponent<Animator> ();
		staticMap = isStatic.staticMap;
	}
	
	// Update is called once per frame
	void Update () {
		exitButtonPressed = buttonPresses.exitButtonPressed;
		playButtonPressed = buttonPresses.playButtonPressed;
		if (!staticMap) {
			unlockButtonPressed = buttonPresses.unlockButtonPressed;
			enteredCode = passcode.enteredCode;
		}
		if (transform.position == player.transform.position) {
			currentNode = true;
			if (!idleActivated) {
				playButton.SetActive (true);
				anim.ResetTrigger ("moveLeft");
				anim.ResetTrigger ("moveRight");
				anim.SetTrigger ("Idle");
				idleActivated = true;
			}
		} else {
			currentNode = false;
			idleActivated = false;
		}

		if (currentNode) {
			levelNameText.text = levelName;
			levelNumberText.text = levelNumber;
			levelCodeText.text = levelCode;
			if ((Input.GetKeyDown (KeyCode.Return) && !menuActive) || playButtonPressed) {
				buttonPresses.FalsifyPlayButton ();
				canMove = false;
				menuActive = true;
				playButton.GetComponent<Animator> ().Play ("PlayButtonExit", 0, 0f);
				Invoke ("PlayButtonDisable", 1 / 6f);
			} else if (menuActive) {
				levelMenu.SetActive (true);
				if (Input.GetKeyDown (KeyCode.Escape) || exitButtonPressed) {
					buttonPresses.FalsifyExit ();
					if (!staticMap) {
						passcode.Clear ();
					}
					levelMenu.SetActive (false);
					playButton.SetActive (true);
					menuActive = false;
					canMove = true;
				}
				if (Input.GetKeyDown (KeyCode.Return) || unlockButtonPressed) {
					if (!staticMap) {
						buttonPresses.FalsifyUnlockButton ();
						if (enteredCode == password) {
							passcode.unlockSFX ();
							locked = false;
							passcode.Clear ();
							menuActive = false;
							levelMenu.SetActive (false);
							playButton.SetActive (true);
							canMove = true;
						} else {
							passcode.Clear ();
							passcode.lockSFX ();
						}
					}
				}
			}
			if (currentNode) {
				if (locked && !staticMap) {
					if (upDestination != null) {
						if (upDestination.GetComponent<Node>()) {
							if (upDestination.GetComponent<Node> ().accessible == false) {
								upDestination.SetActive (false);
							}
						}
						else if (upDestination.GetComponent<Corner>()) {
							if (upDestination.GetComponent<Corner> ().accessible == false) {
								upDestination.SetActive (false);
							}
						}
						else if (upDestination.GetComponent<Warp>()) {
							if (upDestination.GetComponent<Warp> ().accessible == false) {
								upDestination.SetActive (false);
							}
						}
					}
					if (downDestination != null) {
						if (downDestination.GetComponent<Node>()) {
							if (downDestination.GetComponent<Node> ().accessible == false) {
								downDestination.SetActive (false);
							}
						} else if (downDestination.GetComponent<Corner>()) {
							if (downDestination.GetComponent<Corner> ().accessible == false) {
								downDestination.SetActive (false);
							}
						} else if (downDestination.GetComponent<Warp>()) {
							if (downDestination.GetComponent<Warp> ().accessible == false) {
								downDestination.SetActive (false);
							}

						}
					}
					if (leftDestination != null) {
						if (leftDestination.GetComponent<Node>()) {
							if (leftDestination.GetComponent<Node> ().accessible == false) {
								leftDestination.SetActive (false);
							}
						} else if (leftDestination.GetComponent<Corner>()) {
							if (leftDestination.GetComponent<Corner> ().accessible == false) {
								leftDestination.SetActive (false);
							}
						} else if (leftDestination.GetComponent<Warp>()) {
							if (leftDestination.GetComponent<Warp> ().accessible == false) {
								leftDestination.SetActive (false);
							}
						}
					}
					if (rightDestination != null) {
						
						if (rightDestination.GetComponent<Node>()) {
							if (rightDestination.GetComponent<Node> ().accessible == false) {
								rightDestination.SetActive (false);
							}
						} else if (rightDestination.GetComponent<Corner>()) {
							
							if (rightDestination.GetComponent<Corner> ().accessible == false) {
								rightDestination.SetActive (false);
							}
						} else if (rightDestination.GetComponent<Warp>()) {
							if (rightDestination.GetComponent<Warp> ().accessible == false) {
								rightDestination.SetActive (false);
							}
						}
					}
				} else {
					accessible = true;
					if (upDestination != null) {
						upDestination.SetActive (true);
						if (upDestination.GetComponent<Node> ()) {
							upDestination.GetComponent<Node> ().accessible = true;
						} else if (upDestination.GetComponent<Corner> ()) {
							upDestination.GetComponent<Corner> ().accessible = true;
						} else if (upDestination.GetComponent<Warp> ()) {
							upDestination.GetComponent<Warp> ().accessible = true;
						}
					}
					if (downDestination != null) {
						downDestination.SetActive (true);
						if (downDestination.GetComponent<Node> ()) {
							downDestination.GetComponent<Node> ().accessible = true;
						} else if (downDestination.GetComponent<Corner> ()) {
							downDestination.GetComponent<Corner> ().accessible = true;
						} else if (downDestination.GetComponent<Warp> ()) {
							downDestination.GetComponent<Warp> ().accessible = true;
						}
					}
					if (leftDestination != null) {
						leftDestination.SetActive (true);
						if (leftDestination.GetComponent<Node> ()) {
							leftDestination.GetComponent<Node> ().accessible = true;
						} else if (leftDestination.GetComponent<Corner> ()) {
							leftDestination.GetComponent<Corner> ().accessible = true;
						} else if (leftDestination.GetComponent<Warp> ()) {
							leftDestination.GetComponent<Warp> ().accessible = true;
						}
					}
					if (rightDestination != null) {
						rightDestination.SetActive (true);
						if (rightDestination.GetComponent<Node> ()) {
							rightDestination.GetComponent<Node> ().accessible = true;
						} else if (rightDestination.GetComponent<Corner> ()) {
							rightDestination.GetComponent<Corner> ().accessible = true;
						} else if (rightDestination.GetComponent<Warp> ()) {
							rightDestination.GetComponent<Warp> ().accessible = true;
						}
					}
				}
			}
			if (canMove) {
				if (Input.GetKeyDown (KeyCode.UpArrow)) {
					if (upDestination != null) {
						if (upDestination.activeInHierarchy) {
							currentNode = false;
							playButton.GetComponent<Animator> ().Play ("PlayButtonExit", 0, 0f);
							Invoke ("PlayButtonDisable", 1 / 6f);
							anim.ResetTrigger ("Idle");
							anim.ResetTrigger ("moveLeft");
							anim.SetTrigger ("moveRight");
							StartCoroutine (DoUp ()); 
						}
					}
				} else {
					if (Input.GetKeyDown (KeyCode.DownArrow)) {
						if (downDestination != null) {
							if (downDestination.activeInHierarchy) {
								currentNode = false;
								playButton.GetComponent<Animator> ().Play ("PlayButtonExit", 0, 0f);
								Invoke ("PlayButtonDisable", 1 / 6f);
								anim.ResetTrigger ("Idle");
								anim.ResetTrigger ("moveLeft");
								anim.SetTrigger ("moveRight");
								StartCoroutine (DoDown ()); 
							}
						}
					} else {
						if (Input.GetKeyDown (KeyCode.LeftArrow)) {
							if (leftDestination != null) {
								if (leftDestination.activeInHierarchy) {
									currentNode = false;
									playButton.GetComponent<Animator> ().Play ("PlayButtonExit", 0, 0f);
									Invoke ("PlayButtonDisable", 1 / 6f);
									anim.ResetTrigger ("Idle");
									anim.ResetTrigger ("moveRight");
									anim.SetTrigger ("moveLeft");
									StartCoroutine (DoLeft ()); 
								}
							}
						} else {
							if (Input.GetKeyDown (KeyCode.RightArrow)) {
								if (rightDestination != null) {
									if (rightDestination.activeInHierarchy) {
										currentNode = false;
										playButton.GetComponent<Animator> ().Play ("PlayButtonExit", 0, 0f);
										Invoke ("PlayButtonDisable", 1 / 6f);
										anim.ResetTrigger ("Idle");
										anim.ResetTrigger ("moveLeft");
										anim.SetTrigger ("moveRight");
										StartCoroutine (DoRight ()); 
									}
								}
							}
						}
					}
				}
			}
		}

	}
	IEnumerator DoUp()
	{
		yield return new WaitForSeconds (1/60);
		while (player.transform.position != upDestination.transform.position) {
			player.transform.position = Vector3.MoveTowards (player.transform.position, upDestination.transform.position, 8f * Time.deltaTime);
			yield return null;
		}
	}
	IEnumerator DoDown()
	{
		yield return new WaitForSeconds (1/60);
		while (player.transform.position != downDestination.transform.position) {
			player.transform.position = Vector3.MoveTowards (player.transform.position, downDestination.transform.position, 8f * Time.deltaTime);
			yield return null;
		}
	}
	IEnumerator DoLeft()
	{
		yield return new WaitForSeconds (1/60);
		while (player.transform.position != leftDestination.transform.position) {
			player.transform.position = Vector3.MoveTowards (player.transform.position, leftDestination.transform.position, 8f * Time.deltaTime);
			yield return null;
		}
	}
	IEnumerator DoRight()
	{	
		yield return new WaitForSeconds (1/60);
		while (player.transform.position != rightDestination.transform.position) {
			player.transform.position = Vector3.MoveTowards (player.transform.position, rightDestination.transform.position, 8f * Time.deltaTime);
			yield return null;
		}
	}
	void PlayButtonDisable () {
		playButton.SetActive (false);
	}
}
