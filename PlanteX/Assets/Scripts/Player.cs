using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    private int level;
    private float experience;
    // Start is called before the first frame update
    void Start()
    {
        //EXAMPLE HEALTH
        setHealth(100);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        checkIfDead();
    }

    private void checkIfDead()
    {
        if (getHealth() <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        base.Kill();
        Debug.Log("You died");
    }

    public void Damage(float damageTaken)
    {
        //Her kan en skrive mer ting feks; Notifikasjon om å ha tatt skade til brukeren. 

        base.Damage(damageTaken);
    }
}
