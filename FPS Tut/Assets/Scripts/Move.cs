using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public CharacterController controller;
	public float speed = 10f;
	public float gravity = -9.81f;
	Vector3 velocity;
	public Transform groundCheck;
	public float groundDistance = 0.4f;

	//check what onject collides with
	public LayerMask groundMask;
	bool onGround;
	public float jumpHeight = 3f;
	
	// Update is called once per frame
	void Update () {

		//creates small sphere on the groundcheck object and returns true of false
		onGround = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
		if (onGround && velocity.y < 0)
			velocity.y = -2f;

		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Vector3 move = transform.right * x + transform.forward * z;
		controller.Move(move * speed * Time.deltaTime);

		velocity.y += gravity * Time.deltaTime;
		controller.Move(velocity * Time.deltaTime);

		if (Input.GetButtonDown("Jump") && onGround)
        {
			velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
	}
}
