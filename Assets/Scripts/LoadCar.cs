using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCar : MonoBehaviour
{
    //public Transform spawnPoint;
    public GameObject[] cars;

    // Start is called before the first frame update
    void Start()
    {
        int selectedCar = PlayerPrefs.GetInt("currentCar");
        GameObject prefab = cars[selectedCar];

        Vector3 pos = cars[selectedCar].transform.position;
        Quaternion quat = cars[selectedCar].transform.rotation;

        cars[selectedCar].SetActive(true);

        GameObject clone = Instantiate(prefab, pos, quat);
    }
}
