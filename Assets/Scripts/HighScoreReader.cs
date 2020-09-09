﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public struct ScoreEntry
{
    public string name;
    public int score;

    static public bool operator<(ScoreEntry a, ScoreEntry b) { return a.score < b.score; }
    static public bool operator>(ScoreEntry a, ScoreEntry b) { return a.score > b.score; }
    public override string ToString() { return name + "," + score.ToString(); }
}

public class HighScoreReader : MonoBehaviour
{
    public string filePath;

    public List<ScoreEntry> ReadScores()
    {
        StreamReader reader = new StreamReader(filePath);
        List<ScoreEntry> scores = new List<ScoreEntry>();

        while (!reader.EndOfStream)
        {
            ScoreEntry newEntry;
            newEntry.name = string.Empty;

            while (reader.Peek() != ',')
            {
                newEntry.name += (char)reader.Read();
            }

            reader.Read(); // Skip over the separation comma

            string scoreStr = reader.ReadLine();

            Int32.TryParse(scoreStr,out newEntry.score);

            scores.Add(newEntry);
        }

        reader.Close();

        return scores;
    }
}
