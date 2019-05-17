using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{


    public virtual void Initialize(Rigidbody rb, Unit us)
    {
        Debug.Log("Error Ability baseclass Initialize() called");
    }
}
