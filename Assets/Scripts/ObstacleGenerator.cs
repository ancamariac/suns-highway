using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject [] obstacleForward;
    public GameObject[] obstacleRearward;

    public Transform lane1, lane2, lane3, lane4;

    float GetXFromLane( int lane)
    {
        switch (lane)
        {
            case 1:
                return lane1.position.x;
            case 2:
                return lane2.position.x;
            case 3:
                return lane3.position.x;
            case 4:
                return lane4.position.x;
            default:
                return 0;
        }
    }

    GameObject GetRandomPrefabFwd()
    {
        return obstacleForward[Random.Range(0, obstacleForward.Length)];
    }

    GameObject GetRandomPrefabRwd()
    {
        return obstacleRearward[Random.Range(0, obstacleForward.Length)];
    }

    void SpawnObstacleForward( int lane, float z)
    {
        GameObject obstaclePrefabFwd = GetRandomPrefabFwd();
        float x = GetXFromLane(lane);

        Instantiate(obstaclePrefabFwd, new Vector3(x, obstaclePrefabFwd.transform.position.y, z), obstaclePrefabFwd.transform.rotation, transform);
    }

    void SpawnObstaclesRearward(int lane, float z)
    {
        GameObject obstaclePrefabRwd = GetRandomPrefabRwd();
        float x = GetXFromLane(lane);

        Instantiate(obstaclePrefabRwd, new Vector3(x, obstaclePrefabRwd.transform.position.y, z), obstaclePrefabRwd.transform.rotation, transform);
    }

    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            int lane12 = Random.Range(1, 2);
            int lane34 = Random.Range(3, 5);
            float dist = i * 100 + 15;

            SpawnObstacleForward(lane34, dist);
            SpawnObstaclesRearward(lane12, dist);
        }
    }
}
