using UnityEngine;
using System.Collections;

public class MoveMe : MonoBehaviour {

	public Vector3 speed = new Vector3 (0f,0f,0f);
	public GameObject[] moveables; //in the inspector, you must indicate and array size and each assignment

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (GetComponent<Transform> ().position);

		//instead of doing GameObject.GetComponent<Transform>()......
		//you can use transform.* and it will assume you mean whatever GameObject the script is attached to
		//GetComponent<Transform> ().position += speed;


		//for (int i = 0; i < someNumber; i++){ <- another way
		//there is also do...while, while..., etc.
		foreach (GameObject thingToMove in moveables) {
			thingToMove.transform.Translate(speed);
		}
	}
}
