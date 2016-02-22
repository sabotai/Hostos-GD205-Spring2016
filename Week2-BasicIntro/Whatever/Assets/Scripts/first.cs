using UnityEngine;
using System.Collections;

public class first : MonoBehaviour {

	public GameObject textThing;
	int room;

	bool hasKey;

	// Use this for initialization
	void Start () {
		room = 0;
		hasKey = false;
		textThing.GetComponent<TextMesh> ().text = "You are in room number " + room;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("up")) {
			Debug.Log ("Someone just pressed up.");
			room++;
		}

		if (Input.GetKeyDown ("down")) {
			if (room > 0) {
				room--;
			} else if (hasKey) {
				room--;
			}
		}

		if (room == 2) {
			hasKey = true;
		}
		textThing.GetComponent<TextMesh> ().text = "You are in room " + room;
		//make another textThing (i.e. textThing2) tell you details about the room you are in
		/*
		if (room == 2) {
			textThing2.GetComponent<TextMesh> ().text = "it smells weird in here";
		}
		*/
	}
}
