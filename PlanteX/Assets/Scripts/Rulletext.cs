using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rulletext : MonoBehaviour
{
    [SerializeField]
    private GameObject ExitText;
    private RectTransform Rektangel;
    private float y;

    private void Start()
    {
        Rektangel = GetComponent<RectTransform>();
        y = Rektangel.anchoredPosition.y;
    }

    private void Update()
    {
        Rektangel.anchoredPosition = new Vector3(0, y, 0);
        if(y < 0)
        {
            y += 0.2f;
        }
        else
        {
            ExitText.SetActive(true);
        }
    }
}
