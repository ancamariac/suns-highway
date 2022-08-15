using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject [] obstaclePrefabs;
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

    GameObject GetRandomPrefab()
    {
        return obstaclePrefabs[Random.Range(0,obstaclePrefabs.Length)];
    }

    void SpawnObstacle( int lane, float z)
    {
        GameObject obstaclePrefab = GetRandomPrefab();
        float x = GetXFromLane(lane);
        Instantiate(obstaclePrefab, new Vector3(x, obstaclePrefab.transform.position.y, z), obstaclePrefab.transform.rotation, transform);
    }

    // Start is called before the first frame update
    void Start()
    {
        for ( int i = 0; i < 70; i++)
        {
            int lane = Random.Range(1, 5);
            float dist = i * 70 + 15;

            SpawnObstacle(lane, dist);
        }
    }
}
