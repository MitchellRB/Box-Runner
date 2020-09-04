using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneSpawnBehaviour : MonoBehaviour
{
    public GameObject laneController;
    public float segmentLength;
    public float extraDistance = 30;

    // Start is called before the first frame update
    void Start()
    {
        float spawnDistance = 0;

        while (spawnDistance <= transform.position.z + extraDistance)
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
