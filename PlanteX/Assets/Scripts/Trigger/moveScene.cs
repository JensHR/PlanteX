using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScene : MonoBehaviour
{
    [SerializeField] private int loadLevel;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int loadLevel = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(loadLevel);
        }
    }

}
