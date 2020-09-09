using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpwaner : MonoBehaviour
{
    public List<GameObject> obstacleList;

    public List<Vector3> spawnPositions;

    public float spwanTimeMin;
    public float spwanTimeMax;

    private float spwanTime;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        NewSpawnTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > spwanTime)
        {
            Instantiate(obstacleList[Random.Range(0, obstacleList.Count)], spawnPositions[Random.Range(0, spawnPositions.Count)],Quaternion.identity);
            NewSpawnTime();
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    private void NewSpawnTime()
    {
        spwanTime = Random.Range(spwanTimeMin, spwanTimeMax);
    }
}
