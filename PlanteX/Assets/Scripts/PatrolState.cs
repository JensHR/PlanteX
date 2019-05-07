using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : MonoBehaviour
{
    //https://www.youtube.com/watch?v=8eWbSN2T8TE  Kilde

    private float moveDelay;
    public float defaultMoveDelay;

    public Vector3 moveSpot;
    public float minX;
    public float minZ;
    public float maxX;
    public float maxZ;

    // Start is called before the first frame update
    void Start()
    {
        moveSpot = new Vector3(Random.Range(minX, maxX), 1f, Random.Range(minZ, maxZ));
        moveDelay = defaultMoveDelay;
    }

    // Update is called once per frame
    void Update()
    {
        float speed = gameObject.GetComponent<Enemy>().getMovespeed();
        transform.position = Vector3.MoveTowards(transform.position, moveSpot, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpot) < 0.2f)
        {
            if (moveDelay <= 0)
            {
                moveSpot = new Vector3(Random.Range(minX, maxX), 1f, Random.Range(minZ, maxZ));
                moveDelay = defaultMoveDelay;
            }
            else
            {
                moveDelay -= Time.deltaTime;
            }
        }
    }

    public void begin()
    {
        defaultMoveDelay = 2;
        minX = gameObject.transform.position.x - 10;
        minZ = gameObject.transform.position.z - 10;
        maxX = gameObject.transform.position.x + 10;
        maxZ = gameObject.transform.position.z + 10;
        moveSpot = new Vector3(Random.Range(minX, maxX), 1f, Random.Range(minZ, maxZ));

    }
}
