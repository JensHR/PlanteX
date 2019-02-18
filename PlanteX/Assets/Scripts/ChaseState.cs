using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : MonoBehaviour
{ 
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = gameObject.GetComponent<Enemy>().getMovespeed();
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    public void begin()
    {
        target = gameObject.GetComponent<Enemy>().getTarget();
    }
}
