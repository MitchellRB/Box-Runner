using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSProfiler : MonoBehaviour
{
    public Text displayText;

    public int maxFrames = 7;
    private int frames;
    private List<float> frameTimes;

    // Start is called before the first frame update
    void Start()
    {
        frames = 0;
        frameTimes = new List<float>();
    }

    // Update is called once per frame
    void Update()
    {
        frameTimes.Add(Time.unscaledDeltaTime);
        if (frames < maxFrames)
        {
            frames++;
        }
        else
        {
            // Remove oldest frame
            frameTimes.RemoveAt(0);
        }

        float total = 0;
        foreach (var t in frameTimes)
        {
            total += t;
        }

        displayText.text = "FPS: " + (1 / (total / frames)).ToString("0.00") + " " + frames.ToString();
    }
}
