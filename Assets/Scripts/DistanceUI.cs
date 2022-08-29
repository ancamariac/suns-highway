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
        int dist = (int)car.transform.position.z;
        text.text = "Distance: " + dist.ToString() + " m";
    }
}
