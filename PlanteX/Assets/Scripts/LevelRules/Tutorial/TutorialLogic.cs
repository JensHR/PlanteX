using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialLogic : MonoBehaviour
{

    public GameObject Enemy;
    public GameObject Sphere;

    private void Update()
    {
        if (Enemy == null)
        {
            Sphere.SetActive(true);
        }
    }

    private void Start()
    {
        Sphere.SetActive(false);
    }
}
