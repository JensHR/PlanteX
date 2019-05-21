using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapseRocks : MonoBehaviour
{
    [SerializeField]
    private GameObject Rocks;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Rocks.SetActive(true);
        }
    }
}
