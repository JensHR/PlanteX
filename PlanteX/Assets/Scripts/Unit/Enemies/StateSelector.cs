using UnityEngine;

public class StateSelector : MonoBehaviour
{
    public static readonly int NOSTATE = 0;
    public static readonly int ATTACKSTATE = 1;
    public static readonly int CHASESTATE = 2;
    public static readonly int PATROLSTATE = 3;

    void Start() {
        
    }
    void LateUpdate() {

    }

    public void enableChaseState() {
        disableAllStates();
        gameObject.GetComponent<ChaseState>().Begin();
        gameObject.GetComponent<ChaseState>().enabled = true;
    }

    public void enableAttackState()
    {
        disableAllStates();
        gameObject.GetComponent<AttackState>().Begin();
        gameObject.GetComponent<AttackState>().enabled = true;
    }

    public void enablePatrolState()
    {
        disableAllStates();
        gameObject.GetComponent<PatrolState>().Begin();
        gameObject.GetComponent<PatrolState>().enabled = true;
    }

    public void disableAllStates()
    {
        gameObject.GetComponent<ChaseState>().enabled = false;
        gameObject.GetComponent<AttackState>().enabled = false;
        gameObject.GetComponent<PatrolState>().enabled = false;
    }


}

