using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
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


    [SerializeField]
    public int MyProperty;
}
