using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    public Player player;
    public Text healthField;

    private string HEALTHSTRING;

    // Start is called before the first frame update
    void Start()
    {
        HEALTHSTRING = "Health: ";
    }

    // Update is called once per frame
    void Update()
    {
        healthField.text = HEALTHSTRING + player.Health.ToString();
    }
}
