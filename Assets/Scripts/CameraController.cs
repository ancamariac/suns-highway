using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform cameraTarget;
    float posX;
    float posY;
    float posZ;

    private void Start()
    {
        posX = transform.position.x;
        posY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        posZ = cameraTarget.position.z - 4;

        Vector3 pos = new Vector3(posX, posY, posZ);

        transform.position = pos;
    }
}
