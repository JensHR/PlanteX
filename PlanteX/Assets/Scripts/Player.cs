using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
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

    public void Kill()
    {
        base.Kill();
        Debug.Log("You died");
    }

    public void Damage(float damageTaken)
    {

    }
}
