﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : MonoBehaviour
{
    public float moveSpeed;

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, target.position) < 0.6f)
        {
            Debug.Log("ATATATACK");
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
    }
}
