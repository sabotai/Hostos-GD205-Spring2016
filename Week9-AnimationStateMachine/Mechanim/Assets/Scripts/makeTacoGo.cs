using UnityEngine;
using System.Collections;

public class makeTacoGo : MonoBehaviour {

	Animator myAnimator;
	public int animState;

	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator> ();

		if (myAnimator == null) {
			Debug.Log ("where is the animator?");
		} else {
			Debug.Log ("s'all good");
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			animState = 1;
			Debug.Log ("do that thing");
		} 
		if (Input.GetKeyDown (KeyCode.S)) {
			animState = 0;

			Debug.Log ("stop doing that thing");
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			animState = 2;

			Debug.Log ("do that other thing");
		}

		myAnimator.SetInteger ("action", animState);
	}
}
