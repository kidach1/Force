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
        if (OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger) != 0.0f)
        {
            if (transform.position.y > 2.65f) {
				rb.AddForce (Vector3.up * 1f);
			} else {
				rb.AddForce (Vector3.up * 3f);
			}
		}
        if (OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick) != Vector2.zero)
        {
            rb.AddForce(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick));
        }
    }
}
