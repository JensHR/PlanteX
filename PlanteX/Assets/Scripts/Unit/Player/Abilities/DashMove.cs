using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : Ability
{

    [Header("Ability variables")]
    public float DashSpeed;
    public float CooldownTime;
    [SerializeField]
    private AudioClip Lyd;

    private float NextFireTime;

    private void Start()
    {
        NextFireTime = 0;
    }

    public override void Initialize(Rigidbody rb, GameObject player)
    {
        Debug.Log("cooldown: " + CooldownTime);
        if (Time.time > NextFireTime)
        {
            Vector3 movementDirection = DecideDirection();

            //TODO: manage cd, set fire mechanism as separate method?

            AudioSource audio = gameObject.AddComponent<AudioSource>();
            audio.playOnAwake = false;
            audio.clip = Lyd;
            audio.volume = 0.4f;
            audio.Play();
            //Destroy(audio);

            StartCoroutine("UncapMovementSpeed", player);

            rb.AddRelativeForce(movementDirection * DashSpeed * Time.deltaTime, ForceMode.Impulse);
            NextFireTime = Time.time + CooldownTime;
        }
    }

    private IEnumerator UncapMovementSpeed(GameObject value)
    {
        value.GetComponent<Player>().MovementSpeedCapped = false;
        yield return new WaitForSeconds(1);
        value.GetComponent<Player>().MovementSpeedCapped = true;
    }

    private Vector3 DecideDirection()
    {
        //DashMove tilatter å bli kontrollert av tast input men defaulter til fremover.
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            return new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        }
        else
        {
            //Fremover
            return new Vector3(0, 0, 1);
        }
        //Bug pga spillers "movementspeed cap" blir DashMove velocity begrenset hvis en bruker piltastene. 
        //Dette kan løses med et "buff system som gir spiller f.eks. 1 sec med uncapped movement etter DashMove bruk.
    }
}
