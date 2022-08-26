using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreviewManager : MonoBehaviour
{
    public GameObject car;
    public GameObject[] prefabs;

    int currentCar = 0;

    private void Start()
    {
        Vector3 pos = car.transform.position;
        Quaternion quat = car.transform.rotation;
        car = Instantiate(prefabs[currentCar], pos, quat);
    }

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
    public void StartGame()
    {
        PlayerPrefs.SetInt("currentCar", currentCar);
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

}
