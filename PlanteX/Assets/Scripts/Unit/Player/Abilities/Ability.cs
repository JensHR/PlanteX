using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{


    public virtual void Initialize(Rigidbody rb, GameObject player)
    {
        Debug.Log("Error Ability baseclass Initialize() called");
    }
}
