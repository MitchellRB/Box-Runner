using System.Collections;
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
        if (!File.Exists(Application.dataPath + filePath))
        {
            File.Create(Application.dataPath + filePath);
            StreamWriter writer = new StreamWriter(Application.dataPath + filePath);
            for (int i = 0; i < 10; i++)
            {
                writer.WriteLine("AAA,0");
            }
            writer.Close();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
