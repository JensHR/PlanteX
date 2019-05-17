using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : MonoBehaviour
{

    private Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        Begin();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Enemy>().Attack();
    }

    public void Begin()
    {
        Target = GetComponent<Enemy>().Target;
    }
}
