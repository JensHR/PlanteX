using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBluber : Enemy
{
    public StateSelector stateSelector;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        setAggroRange(10);
        setAttackRange(1);
        setHealth(100);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() 
    {
        float distance = Vector3.Distance(getTarget, gameObject);

        Debug.Log(distance);

        if(distance <= getAttackRange())
        {
            Debug.Log("Starting attackState script")
            stateSelector.enableAttackState();
        }
        else if(distance <= getAggroRange())
        {
            Debug.Log("Starting chaseState script")
            stateSelector.enableChaseState();
        }
        else 
        {
            Debug.Log("Starting patrolState script")
            stateSelector.enablePatrolState(); 
        }
    }
}
