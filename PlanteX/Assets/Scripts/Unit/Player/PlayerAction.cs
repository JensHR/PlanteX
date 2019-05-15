using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour  
{
    public Rigidbody rb;

    private bool usingActionOne;
    private bool usingActionTwo;
    private bool usingActionThree;

    private Ability ActionOne;
    private Ability ActionTwo;
    private Ability ActionThree;

    private DashMove dashmove;
    private SeedShot seedshot;

    // Start is called before the first frame update
    void Start()
    {
        usingActionOne = false;
        usingActionTwo = false;
        usingActionThree = false;

        rb = gameObject.GetComponent<Rigidbody>();

        dashmove = new DashMove();

        seedshot = new SeedShot();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            dashmove.Initialize(rb);
        }

        if (Input.GetButton("Fire2"))
        {
            seedshot.Initialize();
        }

        if (Input.GetButton("Fire3"))
        {

        }
    }
}
