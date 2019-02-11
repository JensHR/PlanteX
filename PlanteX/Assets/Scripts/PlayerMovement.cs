using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;

    bool moving;
    bool jumping;
    bool grounded;

    public float movementSpeed;
    public float jumpHeight;
    public float jumpMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        moving = false;
        jumping = false;
        grounded = false:

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            moving = true;
        }
        else
        {
            moving = false;
        }

        if (Input.GetKeyDown("space"))
        {
            jumping = true;
        }
    }

    private void FixedUpdate()
    {

        if (moving)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            rb.AddForce(movement * movementSpeed * Time.deltaTime, ForceMode.VelocityChange);
                
        }

        if (jumping && grounded)
        {
            Vector3 jump = new Vector3(0, jumpHeight, 0);
            rb.AddForce(jump * jumpMultiplier * Time.deltaTime);
            jumping = false;
        }
    }
    onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}
