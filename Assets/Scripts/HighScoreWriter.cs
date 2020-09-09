using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[RequireComponent(typeof(HighScoreReader))]
public class HighScoreWriter : MonoBehaviour
{
    public string filePath;

    public void WriteScores(List<ScoreEntry> scores)
    {
        File.WriteAllText(Application.dataPath + filePath, string.Empty);

        scores.Sort(scores[0].Compare);

        StreamWriter writer = new StreamWriter(Application.dataPath + filePath);

        foreach (var item in scores)
        {
            writer.WriteLine(item.ToString());
        }

        writer.Close();
    }

    public void ResetScores()
    {
        WriteScores(BlankScores());
        gameObject.GetComponent<ShowScores>().ChangeDisplay(BlankScores());
    }

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
}
