using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 velocity;
    private bool isGrounded;
    private float speed = 20f;
    private float jumpHeight = 1f;
    private float gravity = -9.81f;
    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //if player not jumping or falling --> velocity = 0
        isGrounded = controller.isGrounded;
        if (isGrounded && velocity.y < 0)
            velocity.y = 0f;

        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(xMove, 0, zMove);
        controller.Move(move * Time.deltaTime * speed);

        //if none of the Vector3 move values are 0 --> move player
        if (move != Vector3.zero)
            gameObject.transform.forward = move;

        if (Input.GetButtonDown("Jump") && isGrounded)
            velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}