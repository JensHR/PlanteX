using UnityEngine;

public class StateSelector : MonoBehaviour
{
    public Transform target;

    public float chaseStateDistance;
    public float attackStateDistance;
    public float patrolStateDistance;

    void Start() {
        gameObject.GetComponent<PatrolState>().enabled = true;
    }
    void LateUpdate() {

        float distance = Vector3.Distance(gameObject.position, target.position)

        //Bytter StateScript basert på avstand;
        if (distance <= chaseStateDistance) 
        {

            enableChaseState();

        } 

        else if (distance <= attackStateDistance) 
        {    
        
            enableAttackState();
        }
            
        else
        {

            enablePatrolState();
            
        }

    }

    public void enableChaseState() {
        gameObject.GetComponent<PatrolState>().enabled = false;
        gameObject.GetComponent<AttackState>().enabled = false;
        gameObject.GetComponent<ChaseState>().enabled = true;
    }

    public void enableAttackState()
    {
        gameObject.GetComponent<ChaseState>().enabled = false;
        gameObject.GetComponent<PatrolState>().enabled = false;
        gameObject.GetComponent<AttackState>().enabled = true;
    }

    public void enablePatrolState()
    {
        gameObject.GetComponent<ChaseState>().enabled = false;
        gameObject.GetComponent<AttackState>().enabled = false;
        gameObject.GetComponent<PatrolState>().enabled = true;
    }



}

