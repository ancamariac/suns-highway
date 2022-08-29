using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeedUI : MonoBehaviour
{
    public CarController car;
    TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();

    }

    void Update()
    {
        int sp = (int)(car.speed * 300f);
        text.text = "Speed: " + sp.ToString() + " km/h";
    }
}
