using UnityEngine;

public class StateSelector : MonoBehaviour
{
    public Transform target;

    void Start() {

    }
    void LateUpdate() {

    }

    public void enableChaseState() {
        disableAllStates();
        gameObject.GetComponent<ChaseState>().enabled = true;
    }

    public void enableAttackState()
    {
        disableAllStates();
        gameObject.GetComponent<AttackState>().enabled = true;
    }

    public void enablePatrolState()
    {
        disableAllStates();
        gameObject.GetComponent<PatrolState>().enabled = true;
    }

    public void disableAllStates()
    {
        gameObject.GetComponent<ChaseState>().enabled = false;
        gameObject.GetComponent<AttackState>().enabled = false;
        gameObject.GetComponent<PatrolState>().enabled = false;
    }


}

