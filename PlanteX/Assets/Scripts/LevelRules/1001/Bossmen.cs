using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossmen : MonoBehaviour
{

    [SerializeField]
    private GameObject MiniBossOne;
    [SerializeField]
    private GameObject MiniBossTwo;

    [SerializeField]
    private GameObject Portal;

    private void Update()
    {
        if(MiniBossOne == null && MiniBossTwo == null)
        {
            Portal.SetActive(true);
        }
    }
}
