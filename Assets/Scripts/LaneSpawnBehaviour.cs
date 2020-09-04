using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneSpawnBehaviour : MonoBehaviour
{
    public GameObject laneController;
    public float segmentLength;

    // Start is called before the first frame update
    void Start()
    {
        float spawnDistance = 0;

        while (spawnDistance < transform.position.z + 30)
        {
            Instantiate(laneController, new Vector3(transform.position.x, transform.position.y, transform.position.z - spawnDistance), Quaternion.identity);
            spawnDistance += segmentLength;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
