using UnityEngine;
using System.Collections;

// Rigidbody使う。CharacterController不要。
public class RigidMove : MonoBehaviour {
	Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	void Update () {
        //		if (Input.GetButton ("Jump")) {
        if (OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger) != 0.0f)
        {
            if (transform.position.y > 2.65f) {
				Debug.Log ("aa");
				rb.AddForce (Vector3.up * 1f);
			} else {
				Debug.Log ("bb");
				rb.AddForce (Vector3.up * 3f);
			}
		}
	}
}
