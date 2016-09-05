using UnityEngine;
using System.Collections;

// Rigidbody使う。CharacterController不要。
public class RigidMove : MonoBehaviour {
	Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	void Update () {
		if (Input.GetButton ("Jump")) {
			if (transform.position.y > 1.65f) {
				Debug.Log ("aa");
				rb.AddForce (Vector3.up * 15f);
			} else {
				Debug.Log ("bb");
				rb.AddForce (Vector3.up * 17f);
			}
		}
	}
}
