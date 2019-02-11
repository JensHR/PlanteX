using UnityEngine;

public class Enemy : Unit 
{
    private Transform target;

    void Update()
    {

    }

    public void setTarget(Transform newTarget)
    {
        target = newTarget;
    }

    public Transform getTarget()
    {
        return target;
    }



}
