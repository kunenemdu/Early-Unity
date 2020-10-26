using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private CharacterController controller;
    private float gravity = -9.81f;
    private float speed = 15f;
    private Vector3 velocity;
    private float jumpHeight = 1f;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMov = Input.GetAxis("Horizontal");
        float zMov = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(xMov, 0, zMov).normalized;
        controller.Move(movement * Time.deltaTime * speed);

        isGrounded = controller.isGrounded;
        if (velocity.y < 0 && isGrounded)
            velocity.y = 0f;

        if (movement != Vector3.zero)
            gameObject.transform.forward = movement;

        if (Input.GetButtonDown("Jump") && isGrounded)
            velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        
    }
}
