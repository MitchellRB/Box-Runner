using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCounter : MonoBehaviour
{
    public string nameFilePath;

    public Text scoreText;

    public int score;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0.5f)
        {
            score++;
            timer = 0;
            scoreText.text = score.ToString();
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    public void SaveScore()
    {
        // Cannot do file IO on web
#if UNITY_WEBGL
        return;
#else
        // Read name
        StreamReader reader = new StreamReader(Application.persistentDataPath + nameFilePath);
        string playerName = reader.ReadToEnd();
        reader.Close();

        // Get score writer and reader
        HighScoreWriter hsw = gameObject.GetComponent<HighScoreWriter>();
        HighScoreReader hsr = gameObject.GetComponent<HighScoreReader>();

        // Read high score list
        var scores = hsr.ReadScores();

        if (score > scores[9].score)
        {
            ScoreEntry newScore;
            if (playerName != string.Empty)
            {
                newScore.name = playerName;
            }
            else
            {
                newScore.name = string.Empty;
                newScore.name += (char)Random.Range('A', 'Z' + 1);
                newScore.name += (char)Random.Range('A', 'Z' + 1);
                newScore.name += (char)Random.Range('A', 'Z' + 1);
            }

            newScore.score = score;

            // Add new score
            scores.Add(newScore);
            scores.Sort(newScore.Compare);
            if (scores.Count > 10)
            {
                scores.RemoveAt(10);
            }

            // Rewrite scores list
            hsw.WriteScores(scores);

        }

#endif
    }
}
