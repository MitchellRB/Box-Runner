﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct OffsetObject
{
    public GameObject spawnObject;
    public Vector3 offset;
}

public class ObstacleSpwaner : MonoBehaviour
{
    public List<OffsetObject> obstacleList;

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
            int objectIndex = Random.Range(0, obstacleList.Count);
            Instantiate(obstacleList[objectIndex].spawnObject, spawnPositions[Random.Range(0, spawnPositions.Count)] + obstacleList[objectIndex].offset, obstacleList[objectIndex].spawnObject.transform.rotation);
            NewSpawnTime();
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    // Generate a new delay for the next spawn
    private void NewSpawnTime()
    {
        spwanTime = Random.Range(spwanTimeMin, spwanTimeMax);
    }
}
