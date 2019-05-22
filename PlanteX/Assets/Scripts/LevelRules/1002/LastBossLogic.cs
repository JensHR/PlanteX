using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastBossLogic : MonoBehaviour
{
    [SerializeField]
    private GameObject LastBoss;
    [SerializeField]
    private GameObject MagicPot;

    void Update()
    {
        if(LastBoss == null)
        {
            MagicPot.SetActive(true);
        }
    }
}
