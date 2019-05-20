using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : MonoBehaviour
{
    //https://www.youtube.com/watch?v=8eWbSN2T8TE  Kilde

    private float moveDelay;
    private float defaultMoveDelay;

    private Vector3 moveSpot;
    private float minX;
    private float minZ;
    private float maxX;
    private float maxZ;

    // Start is called before the first frame update
    void Start()
    {
        Begin();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = GetComponent<Enemy>().MovementSpeed;
        transform.position = Vector3.MoveTowards(transform.position, moveSpot, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpot) < 0.2f)
        {
            if (moveDelay <= 0)
            {
                moveSpot = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));
                moveDelay = defaultMoveDelay;
            }
            else
            {
                moveDelay -= Time.deltaTime;
            }
        }
    }

    public void Begin()
    {
        defaultMoveDelay = 1.5f;
        moveDelay = defaultMoveDelay;
        minX = transform.position.x - 10;
        minZ = transform.position.z - 10;
        maxX = transform.position.x + 10;
        maxZ = transform.position.z + 10;
        moveSpot = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));

    }
}
