using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{

    public bool MovementSpeedCapped;

    void LateUpdate()
    {
        
    }

    public override void Kill()
    {
        //Ekstra logik fordi det er spilleren som dør (restartmeny?)
        Debug.Log("You died");
        base.Kill();
        Debug.Log("You died");
    }

    public override void Damage(float damageTaken)
    {
        //Her kan en skrive mer ting feks; Notifikasjon om å ha tatt skade til brukeren. 

        base.Damage(damageTaken);
        GameObject.FindWithTag("HealthBar").GetComponent<HealthScript>().HandleHealth(Health);
    }
}
