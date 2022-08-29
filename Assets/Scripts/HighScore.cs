using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    TextMeshProUGUI highScore;

    void Start()
    {
        highScore = GetComponent<TextMeshProUGUI>();
        highScore.text = "Distance: " + PlayerPrefs.GetFloat("HighScore", 0).ToString("F2") + " km" + "\n\n" +
                         "Best score: " + PlayerPrefs.GetFloat("BestScore", 0).ToString("F2") + " km";
    }
}
