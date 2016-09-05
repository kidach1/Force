using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public GameObject shot;
	void Start () {
	
	}
	
	void Update () {
		if (Input.GetButton("Fire1")) {
			Fire ();
		}
	}

	void Fire() {
		Instantiate (shot, transform.position, transform.rotation);
	}
}
