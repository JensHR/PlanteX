using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedShotLogic : MonoBehaviour
{
    public float ProjectileLifetime;
    public float TimeBeforeCollisionOn;

    private bool CurrentlyColliding;
    private bool Fired;
    private float TimeSinceCollision;
    public float ShotForce { get; set; }
    public float YRotation { get; set; }
    public float Damage { get; set; }

    private void Start()
    {
        transform.Rotate(90, YRotation, 0);
        Debug.Log("Start : Fired : " + Fired);
        Fired = false;
    }

    private void Update()
    {
        

        if (!CurrentlyColliding)
        {
            TimeSinceCollision += Time.deltaTime;
        }

        if (TimeSinceCollision >= TimeBeforeCollisionOn && !Fired)
        {
            Fire();
        }

        if(TimeSinceCollision >= ProjectileLifetime)
        {
            Destroy(this);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            Debug.Log("SeedShotHitEnemy");
            collision.collider.GetComponent<Enemy>().Damage(Damage);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag != "Ground")
        {
            CurrentlyColliding = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        CurrentlyColliding = false;
    }

    private void Fire()
    {
        

        Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        GetComponent<CapsuleCollider>().enabled = true;
        rb.mass = 0.1f;
        rb.AddForce(transform.up * ShotForce * Time.deltaTime, ForceMode.VelocityChange);
        Fired = true;
    }
}
