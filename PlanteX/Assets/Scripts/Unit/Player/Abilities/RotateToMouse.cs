using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
    public Camera camera;
    public float maximumLength;

    private Ray mouseRay;
    private Vector3 pos;
    private Vector3 direction;
    private Quaternion rotation;


    
    void Update()
    {
        if(camera != null)
        {
            RaycastHit hit;
            Vector3 mousePos = Input.mousePosition;
            mouseRay = camera.ScreenPointToRay(mousePos);

            if(Physics.Raycast ( mouseRay.origin, mouseRay.direction, out hit, maximumLength))
            {
                RotateToMouseDirection(gameObject, hit.point);
            }
            else
            {
                var pos = mouseRay.GetPoint(maximumLength);
                RotateToMouseDirection(gameObject, pos);
            }
        }
    }

    void RotateToMouseDirection (GameObject obj, Vector3 destination)
    {
        direction = destination - obj.transform.position;
        rotation = Quaternion.LookRotation(direction);
        obj.transform.localRotation = Quaternion.Lerp(obj.transform.rotation, rotation, 1);
    }

    public Quaternion getRotation()
    {
        return rotation;
    }
}
