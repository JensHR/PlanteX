﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IKillable, IDamageAble<float>
{
    private float Health;
    private float Movespeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (getHealth() <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        enabled = false;
    }

    public void Damage(float damageTaken)
    {
        setHealth(getHealth() - damageTaken);
    }

    public float getHealth()
    {
        return Health;
    }
    public void setHealth(float health)
    {
        Health = health;
    }
}