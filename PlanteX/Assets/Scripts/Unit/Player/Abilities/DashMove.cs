using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : Ability
{

    private float DashSpeed = 1500;

    private float CooldownTime = 2;
    private float NextFireTime = 0;

    public override void Initialize(Rigidbody rb, Unit unit)
    {
        if (Time.time > NextFireTime)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            rb.AddRelativeForce(movement * DashSpeed * Time.deltaTime, ForceMode.Impulse);
            NextFireTime = Time.time + CooldownTime;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
