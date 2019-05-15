using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Rigidbody parent;

    [SerializeField]
    private Vector3 offset;
    [SerializeField]
    private Quaternion rotation;

    private bool ShowCursor;
    [SerializeField]
    private float Sensitivity;
    

    // Start is called before the first frame update
    void Start()
    {
        //offset = new Vector3(0, 20f, -2f);
        //rotation = Quaternion.Euler(75, 0, 0);
        transform.rotation = rotation;

        if (ShowCursor == false)
        {
            //Cursor.visible = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        //float newRotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * SensitivityX;
        //float newRotationX = transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * Sensitivity;

        

        //gameObject.transform.localEulerAngles = new Vector3(newRotationX, 0, 0);
    }
  
    private void LateUpdate()
    {
        Vector3 parentPosition = parent.position;
        transform.position = parent.transform.TransformPoint(offset);  //parentPosition + offset;
        transform.LookAt(parent.transform);
    }
}
