using UnityEngine;

public class Enemy : Unit 
{
    public Transform target;

    public float aggroRange;
    public float attackRange;

    void Update()
    {

    }

    void Awake() 
    {
        Debug.Log("Awoke Enemy");
    }

    public void CreateNew()
    {
        //target = GameObject.FindWithTag("Player").transform;
    }

    public void setTarget(Transform newTarget)
    {
        target = newTarget;
    }

    public Transform getTarget()
    {
        return target;
    }

    public void setAttackRange(float range)
    {
        attackRange = range;
    }
    public float getAttackRange()
    {
        return attackRange;
    }

    public void setAggroRange(float agRange)
    {
        aggroRange = agRange;
    }
    public float getAggroRange()
    {
        return aggroRange;
    }

}
