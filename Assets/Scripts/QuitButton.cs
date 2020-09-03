using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Add removal if on mobile
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        Application.Quit();
    }
}
