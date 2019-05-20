using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    public Text HealthField;
    public Image HealthBarColor;
    public RectTransform HealthBar;

    private string HEALTH_STRING = "Health: ";
    private float MaxHealth;

    private float CachedY;
    private float MinXValue;
    private float MaxXValue;

    private void Start()
    {
        MaxHealth = GameObject.FindWithTag("Player").GetComponent<Player>().Health;
        CachedY = HealthBar.position.y;
        MaxXValue = HealthBar.position.x;
        MinXValue = HealthBar.position.x - HealthBar.rect.width;
    }

    public void HandleHealth(float currentHealth)
    {
        HealthField.text = "Health: " + currentHealth;

        float currentXValue = MapValues(currentHealth, 0, MaxHealth, MinXValue, MaxXValue);

        HealthBar.position = new Vector3(currentXValue, CachedY);

        if (currentHealth > MaxHealth / 2) //Har mer enn 50%
        {
            HealthBarColor.color = new Color32((byte)MapValues(currentHealth, MaxHealth / 2, MaxHealth, 255, 0), 255, 0, 255);
        }
        else //mindre enn 50%
        {
            HealthBarColor.color = new Color32(255, (byte)MapValues(currentHealth, 0, MaxHealth / 2, 0, 255), 0, 255);
        }
    }

    private float MapValues(float x, float inMin, float inMax, float outMin, float outMax)
    {
        return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
}
