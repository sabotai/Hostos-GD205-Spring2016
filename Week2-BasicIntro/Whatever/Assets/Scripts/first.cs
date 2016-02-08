using UnityEngine;
using System.Collections;

public class first : MonoBehaviour {

	public GameObject textThing;

	// Use this for initialization
	void Start () {
		textThing.GetComponent<TextMesh> ().text = "in quotation marks";
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {
			textThing.GetComponent<TextMesh> ().color = new Color (0.5f, 0.2f, 1f, 1f);
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			textThing.GetComponent<TextMesh> ().color = Color.cyan;
		}
		

	}
}
