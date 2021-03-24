using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPreview : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation;
        rotation = transform.rotation.eulerAngles;
        rotation.y -= 0.08f;
        Quaternion eul;
        eul = transform.rotation;
        eul.eulerAngles = rotation;
        transform.rotation = eul;
    }
}
