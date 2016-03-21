using UnityEngine;
using System.Collections;

public class Arena : MonoBehaviour {

	public Vector3 destination;

	public GameObject victim; //this will be assigned to the first victim, which is in our scene
	public GameObject vicBlueprint; //assign this to the prefab taken from our first victim
	public float seekSpeed = 0.2f;
	Vector3 nearbyPos;
	// Update is called once per frame
	void Update () {

		destination = victim.transform.position; //each frame, set the destination to the current location of the victim.  this way, it will update in realtime
		transform.LookAt (destination); //face the destination, to give our aggressor some personality

		if (Vector3.Distance (destination, transform.position) > 1f) { //if the distance is greater than 1...
			GetComponent<Rigidbody> ().AddForce (Vector3.Normalize (destination - transform.position) *
			seekSpeed); //add force to whatever the script it attached to in the relative direction of the destination at a certain speed
		} else {
			GetComponent<Rigidbody> ().velocity = Vector3.zero; //we want it to completely stop if the distance is <= 1, otherwise momentum will keep pushing onward
			GameObject temp = victim; //make a new temporary gameobject to store our old victim

			MakeVic (); //make a new victim
			Destroy (temp); //destroy the old one
		}


		if (Input.GetMouseButtonDown (0)) {
			MakeVic (); //make a new vic whenever the player clicks the left mouse button
		}
	}

	void MakeVic(){ //we use a separate function for making new victims to keep our code organized
		Debug.Log ("make dat vic");
		nearbyPos = destination + Random.insideUnitSphere * 1.5f; //find a random 3d position of a max radius of 1.5, offset by the initial destination
		GameObject clone = Instantiate (vicBlueprint, nearbyPos, Quaternion.identity) as GameObject; //instatiate a new victim using the prefab, using the nearbyPos and rotation facing forward

		victim = clone; //now assign the clone to be the victim, which will update the destination in the following frame
	}
}
