using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpeedFwd : MonoBehaviour
{
    const float speed = 0.18f;

    void FixedUpdate()
    {
        Vector3 position;
        position = transform.position;
        position.z += Random.Range(0.1f, 0.18f);
        transform.position = position;
    }
}
