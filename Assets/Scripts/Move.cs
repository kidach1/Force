using UnityEngine;
using System.Collections;

// CharacterControllerとセットで使う。Rigidbodyは不要。
public class Move : MonoBehaviour {
	CharacterController controller;

	private Vector3 moveDirection = Vector3.zero;
	float jumpSpeed = 0.8f;
	//	public float gravity = 9.8f;
	float gravity = 3.0f;

	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	void Update () {

		if (controller.isGrounded) {
			moveDirection = Vector3.zero;
		}

        //		if (Input.GetButton ("Jump")) {
        if (OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger) != 0.0f)
        {
            if (transform.position.y > 3.65f) {
				moveDirection.y = Random.Range(-0.1f, 0.1f);
			} else {
				moveDirection.y = jumpSpeed;
//				moveDirection.y += gravity * Time.deltaTime;
			}
		} else {
			moveDirection.y -= gravity * Time.deltaTime;
		}

		controller.Move (moveDirection * Time.deltaTime);
	}
}
