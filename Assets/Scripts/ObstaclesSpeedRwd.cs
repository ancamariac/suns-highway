using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpeedRwd : MonoBehaviour
{
    const float speed = 0.08f;

    void FixedUpdate()
    {
        Vector3 position;
        position = transform.position;
        position.z -= speed;
        transform.position = position;
    }
}
