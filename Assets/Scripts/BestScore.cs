using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestScore : MonoBehaviour
{
    TextMeshProUGUI bestScore;

    void Start()
    {
        bestScore = GetComponent<TextMeshProUGUI>();
        bestScore.text = "Best score: " + PlayerPrefs.GetFloat("BestScore", 0).ToString("F2") + " km";
        Debug.Log(PlayerPrefs.GetFloat("BestScore", 0));
    }
}
