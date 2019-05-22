using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalPortaling : MonoBehaviour
{

    [SerializeField]
    private string ChangeToMap;

    private void OnTriggerEnter(Collider trigger)
    {
        Debug.Log("loooladoawidnioan" + trigger.tag);
        if(trigger.tag == "Player")
        {
            SceneManager.LoadScene(ChangeToMap);
        }
    }
}
