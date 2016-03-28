using UnityEngine;
using System.Collections;

public class BasicRay : MonoBehaviour {

	public Transform obj;

	// Update is called once per frame
	void Update () {
	
		Ray myRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		Camera.main.transform.LookAt (myRay.direction * 5);
		Debug.DrawRay (myRay.origin, myRay.direction * 1000, Color.red);

		RaycastHit rayhit = new RaycastHit ();

		if (Physics.Raycast (myRay, out rayhit, 1000f) && Input.GetMouseButtonDown(0)) {
			Debug.Log ("you done hit..." + rayhit.transform);
			Instantiate (obj, rayhit.point, Random.rotation);
			if (rayhit.transform.tag == "janeDoe") {
				Debug.Log ("poor jane doe :(");
			}
		}	
	}
}
