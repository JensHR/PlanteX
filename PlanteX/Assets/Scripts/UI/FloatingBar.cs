using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingBar : MonoBehaviour
{
    [SerializeField]
    private Camera MainCamera;

    private float MaxHealth;

    private void LateUpdate()
    {

        transform.rotation = Quaternion.LookRotation(transform.position - MainCamera.transform.position);
    }
    
    private void Start()
    {
        MainCamera = FindObjectOfType<Camera>();
        MaxHealth = GetComponentInParent<Enemy>().Health;

    }

    public void HandleHealth(float currentHealth)
    {
        float decimalValue = (currentHealth / MaxHealth);
        GetComponentInChildren<Slider>().value = decimalValue;   
    }
}
