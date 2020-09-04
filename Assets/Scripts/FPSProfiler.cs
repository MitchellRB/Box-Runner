using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSProfiler : MonoBehaviour
{
    public Text displayText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayText.text = "FPS: " + (1 / Time.unscaledDeltaTime).ToString();
    }
}
