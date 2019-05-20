using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitStats : MonoBehaviour
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
    public float Damage;

    //[Header("Modifiers")]
    //public List<Buff> Buffs;
    //public List<DeBuffs> DeBuffs;
}
