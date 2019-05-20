using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IKillable, IDamageAble<float>
{
    [Header("Movement Settings")]
    public float MovementSpeed;
    public float MaximumMovementSpeed;
    public float JumpHeight;
    public float JumpMultiplier;
    

    [Header("Attributes")]
    public float Health;
    public float AttackDamage;


    void Update()
    {
        
    }

    public void CheckIfDead()
    {
        if (Health <= 0)
        {
            Kill();
        }
    }

    public virtual void Kill()
    {
        Destroy(gameObject);
    }

    public virtual void Damage(float damageTaken)
    {
        Health -= damageTaken;
        CheckIfDead();
    }
}
