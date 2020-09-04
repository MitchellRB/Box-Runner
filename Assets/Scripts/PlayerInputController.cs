using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class PlayerInputController : MonoBehaviour
{
    public List<KeyCode> leftButtons;
    public List<KeyCode> rightButtons;
    public List<KeyCode> upButtons;

    public bool useScreen;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var key in leftButtons)
        {
            if (Input.GetKeyDown(key))
            {
                SendMessage("JumpLeft");
                return;
            }
        }

        foreach (var key in rightButtons)
        {
            if (Input.GetKeyDown(key))
            {
                SendMessage("JumpRight");
                return;
            }
        }

        foreach (var key in upButtons)
        {
            if (Input.GetKeyDown(key))
            {
                SendMessage("JumpUp");
                return;
            }
        }


        if (useScreen && Input.GetMouseButton(0) && Input.mousePosition.y < Screen.height && Input.mousePosition.y > Screen.height * 3 / 4)
        {
            SendMessage("JumpUp");
            return;
        }

        if (useScreen && Input.GetMouseButtonDown(0) && Input.mousePosition.x > 0 && Input.mousePosition.x < Screen.width / 2)
        {
            SendMessage("JumpLeft");
            return;
        }

        if (useScreen && Input.GetMouseButtonDown(0) && Input.mousePosition.x < Screen.width && Input.mousePosition.x > Screen.width / 2)
        {
            SendMessage("JumpRight");
            return;
        }
    }
}
