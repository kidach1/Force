using UnityEngine;
using System.Collections;

// CharacterControllerとセットで使う。Rigidbodyは不要。
public class Move : MonoBehaviour {
	CharacterController controller;

	private Vector3 moveDirection = Vector3.zero;
	float jumpSpeed = 0.2f;
	//	public float gravity = 9.8f;
	float gravity = 3.0f;

	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	void Update () {

		if (controller.isGrounded) {
			moveDirection = Vector3.zero;
		}

		if (Input.GetButton ("Jump")) {
			if (transform.position.y > 1.65f) {
				moveDirection.y = Random.Range(-0.05f, 0.05f);
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
