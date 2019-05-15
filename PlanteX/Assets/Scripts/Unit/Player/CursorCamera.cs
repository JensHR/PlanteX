using System;
using UnityEngine;

public class CursorCamera : MonoBehaviour
{
    public bool ShowCursor;
    public float Sensitivity;

    void Start()
    {
        Sensitivity = 1;

        if(ShowCursor == false)
        {
            Cursor.visible = false;
        }
    }

    void Update()
    {
        float newRotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * Sensitivity;
        float newRotationX = transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * Sensitivity;

        gameObject.transform.localEulerAngles = new Vector3(newRotationX, newRotationY, 0);
    }

}

