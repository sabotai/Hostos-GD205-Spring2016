using UnityEngine;
using System.Collections;

public class GladEat : MonoBehaviour {

	public GameObject plaque;
	public Vector3 destination;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		destination = plaque.transform.position;

		Vector3 direction = Vector3.Normalize (destination - transform.position);
		//Debug.Log ("direction = " + direction);

		GetComponent<Rigidbody> ().AddForce (direction * 5);
	}

	void OnCollisionEnter(Collision collision){
		Debug.Log ("collision = " + collision.collider);

		if (collision.gameObject == plaque){
			Destroy (collision.gameObject);
		}
	}
}
