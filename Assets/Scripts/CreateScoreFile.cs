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
        if (!File.Exists(filePath))
        {
            File.Create(filePath);
            StreamWriter writer = new StreamWriter(filePath);
            for (int i = 0; i < 10; i++)
            {
                writer.WriteLine("AAA,100");
            }
            writer.Close();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}