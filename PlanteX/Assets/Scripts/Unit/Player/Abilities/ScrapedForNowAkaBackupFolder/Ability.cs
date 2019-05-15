using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{

    public LayerMask clickMask;

    public void use()
    {
        Debug.Log("Ability used.. :(");
    }

    public Vector3 getClickPosition()
    {
        Vector3 clickPosition = -Vector3.one;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast (ray, out hit, 10f)){
            clickPosition = hit.point;
        }

        return clickPosition;
    }
}
