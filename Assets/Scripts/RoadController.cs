using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoadController : MonoBehaviour
{
    public Transform car, road1, road2;

    const float margin = 4;

    void Jump(Transform target)
    {
        float jumpDistance = road1.localScale.x * 2;

        Vector3 position;
        position = target.position;
        position.z += jumpDistance;
        target.position = position;
    }

    Transform NearestRoad()
    {
        if ( road2.position.z < road1.position.z )
        {
            return road2;
        } else
        {
            return road1;
        }
    }

    bool CheckDistance()
    {
        Transform road = NearestRoad();
        return (car.position.z > road.position.z + road.localScale.x / 2 + margin);
    }

    void MoveRoad()
    {
        Jump(NearestRoad());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            MoveRoad();
            
        }

        if ( CheckDistance() )
        {
            MoveRoad();
        }

    }
}
