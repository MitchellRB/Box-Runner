﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CreateScoreFile : MonoBehaviour
{
    public string filePath;

    // Start is called before the first frame update
    // Create high score file if it does not exist
    void Start()
    {
#if UNITY_WEBGL
        return;
#else
        if (!File.Exists(Application.persistentDataPath + filePath))
        {
            StreamWriter writer = new StreamWriter(Application.persistentDataPath + filePath);
            for (int i = 0; i < 10; i++)
            {
                writer.WriteLine("AAA,0");
            }
            writer.Close();
        }
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
