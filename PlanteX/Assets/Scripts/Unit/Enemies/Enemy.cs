using UnityEngine;

public class Enemy : Unit 
{
    [Header("Enemy properties")]
    public Transform Target;

    public float AggroRange;
    public float AttackRange;

    void Update()
    {

    }

    void Awake() 
    {
        Debug.Log("Awoke Enemy");
    }

    public virtual void Attack()
    {
        Debug.Log("Enemy baseclass attack!");
    }

    public void CreateNew()
    {
        //target = GameObject.FindWithTag("Player").transform;
    }
}
