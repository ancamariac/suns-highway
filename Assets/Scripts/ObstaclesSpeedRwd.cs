using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpeedRwd : MonoBehaviour
{
    const float speed = 0.23f;

    void FixedUpdate()
    {
        Vector3 position;
        position = transform.position;
        position.z -= Random.Range(0.1f, 0.28f);
        transform.position = position;
    }
}
    