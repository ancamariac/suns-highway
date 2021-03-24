using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpeed : MonoBehaviour
{
    const float speed = 0.08f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 position;
        position = transform.position;
        position.z += speed;
        transform.position = position;
    }
}
