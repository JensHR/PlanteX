using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKey)
        {
            Debug.Log("YouQuit");
            Application.Quit();
        }
    }
}
