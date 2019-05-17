using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;
    private Player Player;

    private bool Moving;
    private bool Jumping;
    private bool Grounded;

    [SerializeField]
    public float RotationSensitivity;
    

    void Start()
    {
        Moving = false;
        Jumping = false;
        Grounded = false;

        rb = GetComponent<Rigidbody>();
        Player = GetComponent<Player>();
    }

   
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            Moving = true;
        }
        else
        {
            Moving = false;
        }

        if (Input.GetKeyDown("space") && Grounded)
        {
            Jumping = true;
        }

        CoordinateCamera();
    }

    void FixedUpdate()
    {

        if(Moving || Jumping && Grounded)
        {
            float maximumMovespeed = Player.MaximumMovementSpeed;
            //Denne tillater oss å gi spiller mer fart en maximum når en feks bruker bevegelses egenskaper.
            bool movespeedCapped = Player.MovementSpeedCapped;

            if (Moving)
            {
                float movementSpeed = Player.MovementSpeed;

                Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

                rb.AddRelativeForce(movement * movementSpeed * Time.deltaTime, ForceMode.VelocityChange);

                if (rb.velocity.magnitude > maximumMovespeed && movespeedCapped)
                {
                    rb.velocity = rb.velocity.normalized * maximumMovespeed;
                }
            }

            if (Jumping && Grounded)
            {
                float jumpHeight = Player.JumpHeight;
                float jumpMultiplier = Player.JumpMultiplier;

                Vector3 jump = new Vector3(0, jumpHeight, 0);
                rb.AddForce(jump * jumpMultiplier * Time.deltaTime);
                Jumping = false;
                Grounded = false;

                if (rb.velocity.magnitude > maximumMovespeed + 7 && movespeedCapped)
                {
                    rb.velocity = rb.velocity.normalized * (maximumMovespeed + 7);
                }
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided: " + collision);
        if (collision.collider.tag == "Ground")
        {
            Grounded = true;
        }
    }

    private void CoordinateCamera()
    {
        float newRotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * RotationSensitivity;
        rb.transform.localEulerAngles = new Vector3(0, newRotationY, 0);
    }
}
