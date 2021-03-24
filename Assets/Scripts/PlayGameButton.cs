using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGameButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {
        SceneManager.LoadScene("ChooseCar", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
