using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float speed = 10f;
	Rigidbody r;
	private void Start()
    {
		r = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
		r.transform.Translate(x, 0, z);

        //jump cube
        if (Input.GetButtonDown("Jump"))
        {

        }
	}
}
