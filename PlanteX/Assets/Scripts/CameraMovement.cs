﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Rigidbody parent;

    private Vector3 offset;
    private Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 10f, -2f);
        rotation = Quaternion.Euler(67, 0, 0);
        transform.rotation = rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    private void LateUpdate()
    {
        Vector3 parentPosition = parent.position;
        transform.position = parentPosition + offset;
    }
}