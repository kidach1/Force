using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {

	public GameObject explosion;

	void Start () {
		Destroy(gameObject, 3.0f);
	}
	
	void Update () {
		transform.position += transform.forward * Time.deltaTime * 20;
	}

	private void OnCollisionEnter(Collision collider) {
		if (collider.gameObject.name == "Ground") {
			Destroy(gameObject);
			Instantiate (explosion, transform.position, transform.rotation);
		}
        if (collider.gameObject.tag == "Cube")
        {
            Destroy(gameObject);
            Destroy(collider.gameObject);

            Instantiate(explosion, transform.position, transform.rotation);
        }
    }
}
