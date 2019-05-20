using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour  
{
    private Rigidbody rb;
    private GameObject Player;

    private bool UsingActionOne;
    private bool UsingActionTwo;
    private bool UsingActionThree;

    private Ability ActionOne;
    private Ability ActionTwo;
    private Ability ActionThree;

    private DashMove Dashmove;
    private SeedShot Seedshot;

    // Start is called before the first frame update
    void Start()
    {
        UsingActionOne = false;
        UsingActionTwo = false;
        UsingActionThree = false;

        rb = GetComponent<Rigidbody>();
        Player = GameObject.FindGameObjectWithTag("Player");

        //ActionOne = new DashMove();
        ActionOne = GetComponentInChildren<DashMove>();

        ActionTwo = GetComponentInChildren<SeedShot>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            UsingActionOne = true;
        }

        if (Input.GetButton("Fire2"))
        {
            UsingActionTwo = true;
        }

        if (Input.GetButton("Fire3"))
        {
            UsingActionThree = true;
        }
    }

    private void FixedUpdate()
    {
        if (UsingActionOne)
        {
            ActionOne.Initialize(rb, Player);
            UsingActionOne = false;
        }

        if (UsingActionTwo)
        {
            ActionTwo.Initialize(rb, Player);
            UsingActionTwo = false;
        }

        if (UsingActionThree)
        {
            //ActionThree
            UsingActionThree = false;
        }
    }
}
