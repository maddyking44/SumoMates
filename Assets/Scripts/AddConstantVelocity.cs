using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour {
	[SerializeField]
	Vector3 v3Rolling;
	
	// FixedUpdate is called 100 times per second
	void FixedUpdate () {
		GetComponent<Rigidbody>().velocity += v3Rolling;
	}
}
