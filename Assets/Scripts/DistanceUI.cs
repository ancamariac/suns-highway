using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistanceUI : MonoBehaviour
{
    public CarController car;
    TextMeshProUGUI text;
    float dist;
    float bestDist;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        bestDist = PlayerPrefs.GetFloat("BestScore");
    }

    void Update()
    {
        dist = (float)car.transform.position.z / 1000;
        text.text = "Distance: " + dist.ToString("F2") + " km";

        PlayerPrefs.SetFloat("HighScore", dist);

        if (dist > bestDist)
        {
            PlayerPrefs.SetFloat("BestScore", dist);
            Debug.Log("yeeeeeeeeeeeeeeeee");
        }
    }
}
