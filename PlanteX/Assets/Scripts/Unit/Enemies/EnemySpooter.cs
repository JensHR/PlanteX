using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpooter : Enemy
{
	private StateSelector stateSelector;
    private int currentState;

    void Start()
    {
        CreateNew();
    }

    public void CreateNew()
    {
        base.CreateNew();
        stateSelector = gameObject.GetComponent<StateSelector>();
        currentState = StateSelector.NOSTATE;

        setMovespeed(0);
        setAggroRange(15);
        setAttackRange(15);
        setHealth(20);
    }

    private void FixedUpdate()
    {
        float distance = Vector3.Distance(getTarget().position, gameObject.transform.position);

        if (distance <= getAggroRange())
        {
            if(currentState != StateSelector.ATTACKSTATE)
            {
                stateSelector.enableAttackState();
                currentState = StateSelector.ATTACKSTATE;
            }
        }
        else
        {
            if(currentState != StateSelector.NOSTATE)
            {
                currentState = StateSelector.NOSTATE;
            }
        }
    }
}