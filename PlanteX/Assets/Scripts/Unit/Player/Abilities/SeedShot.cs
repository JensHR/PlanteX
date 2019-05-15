using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedShot : MonoBehaviour
{
    public GameObject source;

    public GameObject effectToSpawn;

    public void Initialize()
    {
        GameObject effect;
        if (source != null)
        {
            effect = Instantiate(effectToSpawn, source.transform.position, Quaternion.identity);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
