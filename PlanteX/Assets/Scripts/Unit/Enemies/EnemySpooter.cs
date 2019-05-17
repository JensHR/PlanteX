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

        MovementSpeed = 0;
        AggroRange = 15;
        AttackRange = 15;
        Health = 20;
    }

    private void FixedUpdate()
    {
        float distance = Vector3.Distance(Target.position, transform.position);

        if (distance <= AggroRange)
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