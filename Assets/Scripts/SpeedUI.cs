using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeedUI : MonoBehaviour
{
    public CarController car;
    TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        int sp = (int)(car.speed * 300f);
        text.text = "Speed: " + sp.ToString() + " km/h";
    }
}
