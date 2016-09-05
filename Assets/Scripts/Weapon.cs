using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

    float shotInterval = 0;
    float shotIntervalMax = 0.1f;

	public GameObject shot;
	void Start () {
	
	}
	
	void Update () {
        shotInterval += Time.deltaTime;
        

//        if (Input.GetButton("Fire1") && shotInterval > shotIntervalMax) {
        if (OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger) != 0.0f && shotInterval > shotIntervalMax) {
            Fire();
            shotInterval = 0;
		}
	}

	void Fire() {
		Instantiate (shot, transform.position, transform.rotation);
	}
}
