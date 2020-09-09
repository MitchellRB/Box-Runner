using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
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
}
