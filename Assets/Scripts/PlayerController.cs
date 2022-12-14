using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float sensitivityFactor = 0.5f;
    public float speed = 1f;

    void FixedUpdate()
    {

        Vector3 acc = Input.acceleration;
        float tilt = acc.x * sensitivityFactor * speed;

        {
            Vector3 position;
            position = transform.position;
            position.z += speed;
            position.x += tilt;
            position.x = Mathf.Clamp(position.x, -5, 5);
            transform.position = position;
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (speed < 0.85f)
            {
                speed += 0.0016f;
            }
            else
            {
                speed = 0.85f;
            }

        }
        else
        {
            speed -= 0.0005f;
            if (speed <= 0)
            {
                speed = 0;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position;
            position = transform.position;
            position.x += 0.05f;
            transform.position = position;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 position;
            position = transform.position;
            position.x -= 0.05f;
            transform.position = position;
        }

        if (Input.GetKey(KeyCode.S))
        {
            speed -= 0.01f;
            if (speed <= 0)
            {
                speed = 0;
            }
        }
    }
}
