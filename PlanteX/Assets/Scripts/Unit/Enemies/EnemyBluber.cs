using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBluber : Enemy
{
    private StateSelector stateSelector;
    private int currentState;

    [Header("Type spesific values")]
    public float AttackWindupTime;
    public float AttackVelocity;

    private bool AttackInProgress;
    private float AttackWindupProgress;

    private float NextAttack;

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
    }

    public override void Attack()
    {
        if (NextAttack < Time.time && NextAttack != default)
        {
            Debug.Log("Trying to attack");
            NextAttack = AttackWindupTime + Time.time;
            Vector3 movementDirection = (transform.position - Target.transform.position).normalized * -1;
            GetComponent<Rigidbody>().AddForce(movementDirection * AttackVelocity * Time.deltaTime, ForceMode.Impulse);
        }
        else if (NextAttack == default)
        {
            NextAttack = AttackWindupTime + Time.time;
        }
    }

    void FixedUpdate() 
    {

        float distance = Vector3.Distance(transform.position, Target.transform.position);

        //Debugging positioning
        //Debug.Log("targetPos(default): " + Target.position);
        //Debug.Log("targetPos(transform): " + Target.transform.position);
        //Debug.Log("myPos: " + transform.position);
        //Debug.Log("distance: " + distance);
        

        //AI logic
        if(distance <= AttackRange)
        {
            if(currentState != StateSelector.ATTACKSTATE)
            {
                Debug.Log("Starting attackState script");
                stateSelector.enableAttackState();
                currentState = StateSelector.ATTACKSTATE;
            }   
        }
        else if(distance <= AggroRange)
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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            Debug.Log("Traff spiller");
            Player player = collision.collider.GetComponent<Player>();
            player.Damage(AttackDamage);
        }
    }
}
