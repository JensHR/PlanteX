using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;

    private int distToGround;

    bool moving;
    bool jumping;
    bool grounded;

    //stats are here for some reason
    [SerializeField]
    public float movementSpeed;
    [SerializeField]
    public float maximumMovespeed;
    [SerializeField]
    public float jumpHeight;
    [SerializeField]
    public float jumpMultiplier;

    private bool ShowCursor; //Brukes ikke
    [SerializeField]
    public float RotationSensitivity;
    // Start is called before the first frame update
    void Start()
    {
        moving = false;
        jumping = false;
        grounded = false;

        
        //distToGround = GetComponents<Collider>().GetLowerBound();

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

        if (Input.GetKeyDown("space") && grounded)
        {
            jumping = true;
            //Debug.Log("jumping: " + jumping + " | grounded: " + grounded);
        }

        float newRotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * RotationSensitivity;

        rb.transform.localEulerAngles = new Vector3(0, newRotationY, 0); ;
    }

    private void FixedUpdate()
    {

        if (moving)
        {
            maximumMovespeed = GetComponent<Player>().maximumMovespeed;
            movementSpeed = GetComponent<Player>().getMovespeed();
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            //Debug.Log(rb.velocity.magnitude);

            /*rb.velocity = (transform.right * movement.x * movementSpeed);
            rb.velocity = (transform.forward * movement.z * movementSpeed);*/
            rb.AddRelativeForce(movement * movementSpeed * Time.deltaTime, ForceMode.VelocityChange);

            if (rb.velocity.magnitude > maximumMovespeed)
            {
                rb.velocity = rb.velocity.normalized * maximumMovespeed;
            }
        }

        if (jumping && grounded)
        {
            Vector3 jump = new Vector3(0, jumpHeight, 0);
            rb.AddForce(jump * jumpMultiplier * Time.deltaTime);
            jumping = false;
            grounded = false;

            if(rb.velocity.magnitude > maximumMovespeed + 7)
            {
                rb.velocity = rb.velocity.normalized * (maximumMovespeed + 7);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided: " + collision);
        if (collision.collider.tag == "Ground")
        {
            grounded = true;
        }
    }
}
