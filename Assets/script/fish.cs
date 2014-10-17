using UnityEngine;
using System.Collections;

public class fish : MonoBehaviour {
	public Vector3 destination;
	public float speed = 1; //edit in inspector
	public Transform food; //assign in inspector

	// Use this for initialization
	void Start () {
		destination = food.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		//check how close fish is to destination
		//destination - transform.position).magnitude is basically equivolent to Vector3.Distance
		if (Vector3.Distance (destination, transform.position) > 1f) {
						//add force
						//subtract position of destination - current position
			//normalize constrains the vector to a length of 1
			rigidbody.AddForce (Vector3.Normalize(destination - transform.position) * speed);
			}
		else {
			//come to a complete stop
			rigidbody.velocity = Vector3.zero;
				}
	
	}
}
