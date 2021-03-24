using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewManager : MonoBehaviour
{
    public GameObject car;
    public GameObject[] prefabs;

    int currentCar = 0;

    public void Next()
    {
        Vector3 pos = car.transform.position;
        Quaternion quat = car.transform.rotation;
        Destroy(car);

        currentCar++;
        currentCar = currentCar % prefabs.Length;

        car = Instantiate(prefabs[currentCar], pos, quat);
    }

    public void Previous()
    {
        Vector3 pos = car.transform.position;
        Quaternion quat = car.transform.rotation;
        Destroy(car);

        currentCar--;
        if ( currentCar < 0 )
        {
            currentCar = prefabs.Length - 1;
        }

        car = Instantiate(prefabs[currentCar], pos, quat);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
