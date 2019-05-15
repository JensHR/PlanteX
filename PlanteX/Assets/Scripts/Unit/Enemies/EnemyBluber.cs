using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBluber : Enemy
{
    public StateSelector stateSelector;
    public int currentState;



    // Start is called before the first frame update
    void Start()
    {
        CreateNew();
    }

    void Awake()
    {

    }

    public void CreateNew()
    {
        base.CreateNew();
        stateSelector = gameObject.GetComponent<StateSelector>();
        currentState = StateSelector.NOSTATE;

        setMovespeed(3);
        setAggroRange(10);
        setAttackRange(2);
        setHealth(100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() 
    {
        float distance = Vector3.Distance(getTarget().position, gameObject.transform.position);

        /* Debugging positioning
        Debug.Log("targetPos: " + getTarget().position);
        Debug.Log("myPos: " + gameObject.transform.position);
        Debug.Log("distance: " + distance);
        */

        if(distance <= getAttackRange())
        {
            if(currentState != StateSelector.ATTACKSTATE)
            {
                Debug.Log("Starting attackState script");
                stateSelector.enableAttackState();
                currentState = StateSelector.ATTACKSTATE;
            }   
        }
        else if(distance <= getAggroRange())
        {
            if (currentState != StateSelector.CHASESTATE)
            {
                Debug.Log("Starting chaseState script");
                stateSelector.enableChaseState();
                currentState = StateSelector.CHASESTATE;
            }
        }
        else 
        {
            if (currentState != StateSelector.PATROLSTATE)
            {
                Debug.Log("Starting patrolState script");
                stateSelector.enablePatrolState();
                currentState = StateSelector.PATROLSTATE;
            }
        }
    }
}
