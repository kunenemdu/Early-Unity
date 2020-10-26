using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public Rigidbody rb;
	public float force = 10f;


	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0, 0, force * Time.deltaTime);
	}
}
