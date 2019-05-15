using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : Ability
{

    private float DashSpeed = 1500;
    private float CooldownTime = 2;

    private float nextFireTime = 0;

    public void Initialize(Rigidbody rb)
    {
        if (Time.time > nextFireTime)
        {
            rb.AddForce(rb.transform.forward * DashSpeed * Time.deltaTime, ForceMode.Impulse);
            nextFireTime = Time.time + CooldownTime;
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
