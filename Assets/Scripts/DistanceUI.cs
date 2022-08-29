using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistanceUI : MonoBehaviour
{
    public CarController car;
    TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        float dist = (float)car.transform.position.z / 1000;
        text.text = "Distance: " + dist.ToString("F2") + " km";
    }
}
