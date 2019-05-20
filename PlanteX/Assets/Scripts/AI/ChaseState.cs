using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : MonoBehaviour
{ 
    private Transform target;
     
    // Start is called before the first frame update
    void Start()
    {
        Begin();
    }

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = GetComponent<Enemy>().MovementSpeed;
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    public void Begin()
    {
        target = GetComponent<Enemy>().Target;
    }
}
