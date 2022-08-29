using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Untitled", LoadSceneMode.Single);
        Debug.Log("fdfsd");
    }
}
