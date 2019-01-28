using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : MonoBehaviour
{
    public float moveSpeed;

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "PlayerObject")
        {
            //collision.collider.
            /*
            gameObject.GetComponent<AttackState>().enabled = true;
            gameObject.GetComponent<ChaseState>().enabled = false;
            */
        }
    }
}
