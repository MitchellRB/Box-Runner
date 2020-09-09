using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChangeButton : MonoBehaviour
{
    public string playScene;

    public bool force;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (force || (playScene != string.Empty && SceneManager.GetActiveScene().name != playScene))
        {
            SceneManager.LoadScene(playScene, LoadSceneMode.Single);
        }
    }
}
