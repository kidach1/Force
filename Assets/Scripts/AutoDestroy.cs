using UnityEngine;
using System.Collections;

public class AutoDestroy : MonoBehaviour {

	void Start () {
		// パーティクルの自動破棄
		ParticleSystem particleSystem = GetComponent<ParticleSystem>();
		Destroy (gameObject, particleSystem.duration);
	}
	
	void Update () {
	
	}
}
