using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[DisallowMultipleComponent]
public class PlayerInputController : MonoBehaviour
{
    public bool useScreen;

    private Controls controls;

    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();
        controls.Player.JumpLeft.performed += OnLeft;
        controls.Player.JumpRight.performed += OnRight;
        controls.Player.JumpUp.performed += OnUp;
        controls.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        if (useScreen && Input.GetMouseButton(0) && Input.mousePosition.y < Screen.height && Input.mousePosition.y > Screen.height * 2 / 3)
        {
            OnUp();
            return;
        }

        if (useScreen && Input.GetMouseButtonDown(0) && Input.mousePosition.x > 0 && Input.mousePosition.x < Screen.width / 2)
        {
            OnLeft();
            return;
        }

        if (useScreen && Input.GetMouseButtonDown(0) && Input.mousePosition.x < Screen.width && Input.mousePosition.x > Screen.width / 2)
        {
            OnRight();
            return;
        }
    }

    public void StopControls()
    {
        controls.Disable();
        controls.Dispose();
    }

    void OnLeft()
    {
        SendMessage("JumpLeft");
    }
    
    void OnLeft(InputAction.CallbackContext context)
    {
        SendMessage("JumpLeft");
    }

    void OnRight()
    {
        SendMessage("JumpRight");
    }
    void OnRight(InputAction.CallbackContext context)
    {
        SendMessage("JumpRight");
    }

    private void OnUp()
    {
        SendMessage("JumpUp");
    }

    private void OnUp(InputAction.CallbackContext context)
    {
        SendMessage("JumpUp");
    }
}
