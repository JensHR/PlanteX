using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IKillable, IDamageAble<float>
{
    [Header("Movement Settings")]
    [SerializeField]
    public float MovementSpeed;
    [SerializeField]
    public float MaximumMovementSpeed;
    [SerializeField]
    public float JumpHeight;
    [SerializeField]
    public float JumpMultiplier;
    [SerializeField]
    public bool MovementSpeedCapped;

    [Header("Attributes")]
    [SerializeField]
    public float Health;
    [SerializeField]
    public float AttackDamage;


    void Update()
    {
        if (Health <= 0)
        {
            Kill();
        }
    }

    public virtual void Kill()
    {
        enabled = false;
    }

    public virtual void Damage(float damageTaken)
    {
        Health -= damageTaken;
    }
}
