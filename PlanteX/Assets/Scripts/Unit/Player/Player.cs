using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{

    void LateUpdate()
    {
        checkIfDead();
    }

    private void checkIfDead()
    {
        if (Health <= 0)
        {
            Kill();
        }
    }

    public override void Kill()
    {
        base.Kill();
        Debug.Log("You died");
    }

    public override void Damage(float damageTaken)
    {
        //Her kan en skrive mer ting feks; Notifikasjon om å ha tatt skade til brukeren. 

        base.Damage(damageTaken);
    }
}
