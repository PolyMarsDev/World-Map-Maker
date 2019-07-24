using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {
	[Header("Warp Destination")]
	public GameObject destination;

	[Header("Tick this for all ''_Reverse'' warps")]
	public bool accessible;

	[Header("Dependencies")]
	public GameObject player;

	// Use this for initialization
	void Start () {
		accessible = false;
		if (GetComponent <SpriteRenderer> () != null) {
			GetComponent <SpriteRenderer> ().enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position == player.transform.position) {
				Invoke ("Teleport", 1f * Time.deltaTime);
	
		}
	}
	void Teleport () {
		player.transform.position = destination.transform.position;
	}
}
