using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform cameraTarget;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.z = cameraTarget.position.z;
        transform.position = pos;
    }
}
