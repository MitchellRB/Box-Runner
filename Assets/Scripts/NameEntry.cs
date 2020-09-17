using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class NameEntry : MonoBehaviour
{
    public string nameFilepath;

    private TouchScreenKeyboard keyboard;

    private string playerName;

#if !UNITY_WEBGL

    // Start is called before the first frame update
    void Start()
    {
        StreamReader reader = new StreamReader(Application.persistentDataPath + nameFilepath);
        playerName = reader.ReadToEnd();
        gameObject.GetComponent<InputField>().text = playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        if (keyboard != null && keyboard.status == TouchScreenKeyboard.Status.Done)
        {
            playerName = keyboard.text;
            WriteName(playerName);
            gameObject.GetComponent<InputField>().text = playerName;
        }
    }

    // Open keyboard on mobile devices
    // Not used, since the input field opens a keyboard anyway
    public void OpenKeyboard()
    {
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            keyboard = new TouchScreenKeyboard("", TouchScreenKeyboardType.Default, false, false, false, false, "", 10);
        }
    }

    // Write a name to the name file
    public void WriteName(string _name)
    {
        StreamWriter writer = new StreamWriter(Application.persistentDataPath + nameFilepath);

        // Replace commas with spaces
        var chars = _name.ToCharArray();
        string writtenName = string.Empty;
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == ',')
            {
                chars[i] = ' ';
            }
            writtenName += chars[i];
        }

        writer.Write(writtenName);
        writer.Close();
    }

    public void SetNameFromInputText()
    {
        playerName = gameObject.GetComponent<InputField>().text;
        WriteName(playerName);
    }

#endif
}
