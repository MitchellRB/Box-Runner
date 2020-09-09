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
        if (keyboard.status == TouchScreenKeyboard.Status.Done)
        {
            playerName = keyboard.text;
            WriteName();
            gameObject.GetComponent<InputField>().text = playerName;
        }
    }

    public void OpenKeyboard()
    {
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            keyboard = new TouchScreenKeyboard("", TouchScreenKeyboardType.Default, false, false, false, false, "", 10);
        }
    }

    public void WriteName()
    {
        StreamWriter writer = new StreamWriter(Application.persistentDataPath + nameFilepath);

        // Strip commas

        var chars = playerName.ToCharArray();
        playerName = string.Empty;

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == ',')
            {
                chars[i] = ' ';
            }
            playerName += chars[i];
        }

        writer.Write(playerName);
        writer.Close();
    }

    public void SetNameFromInputText()
    {
        playerName = gameObject.GetComponent<InputField>().text;
        WriteName();
    }
}
