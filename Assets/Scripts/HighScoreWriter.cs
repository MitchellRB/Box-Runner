using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[RequireComponent(typeof(HighScoreReader))]
public class HighScoreWriter : MonoBehaviour
{
    public string filePath;

#if !UNITY_WEBGL

    // Write a sorted scores list to file
    public void WriteScores(List<ScoreEntry> scores)
    {
        // Remove text in file
        File.WriteAllText(Application.persistentDataPath + filePath, string.Empty);

        scores.Sort(scores[0].Compare);

        StreamWriter writer = new StreamWriter(Application.persistentDataPath + filePath);

        foreach (var item in scores)
        {
            writer.WriteLine(item.ToString());
        }

        writer.Close();
    }

    // Reset everything to blank scores
    public void ResetScores()
    {
        WriteScores(BlankScores());
        if (gameObject.GetComponent<ShowScores>() != null)
            gameObject.GetComponent<ShowScores>().ChangeDisplay(BlankScores());
    }

    // Generate a set of blank scores
    public List<ScoreEntry> BlankScores()
    {
        List<ScoreEntry> scores = new List<ScoreEntry>();

        for (int i = 0; i < 10; i++)
        {
            ScoreEntry entry;
            entry.name = "AAA";
            entry.score = 0;
            scores.Add(entry);
        }

        return scores;
    }

#endif
}
