using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : MonoBehaviour
{
    //https://www.youtube.com/watch?v=8eWbSN2T8TE  Kilde

    public float moveSpeed;
    private float moveDelay;
    public float defaultMoveDelay;

    public Transform moveSpot;
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        moveSpot.position = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minY, maxY));
        moveDelay = defaultMoveDelay;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpot.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpot.position) < 0.2f)
        {
            if (moveDelay <= 0)
            {
                moveSpot.position = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minY, maxY));
                moveDelay = defaultMoveDelay;
            }
            else
            {
                moveDelay -= Time.deltaTime;
            }
        }
    }
}
