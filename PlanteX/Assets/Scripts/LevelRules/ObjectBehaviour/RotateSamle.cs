using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSamle : MonoBehaviour
{
    //Kilde: Tina forelesning 
    private float Speed = 2.0f;
    private float Amount = 0.1f;

    private Vector3 startPos;

    //Start is called before the first frame update
    void start()
    {
        startPos = transform.position;
    }

    //Update is called once per frame
    void Update()
    {
    //den snurrer seg selv rundt
        transform.Rotate(new Vector3 (15, 30, 45) * Time.deltaTime);

        //bevege seg opp og ned
        transform.position = startPos + new Vector3(0, Mathf.Sin(Time.time * Speed) * Amount, 0);
    }
}
