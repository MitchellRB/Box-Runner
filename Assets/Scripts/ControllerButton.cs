using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public enum FaceButtons
{
    A,
    B,
    X,
    Y
}

[RequireComponent(typeof(Button))]
[DisallowMultipleComponent]
public class ControllerButton : MonoBehaviour
{
    public FaceButtons inputButton;

    private Controls controls;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = gameObject.GetComponent<Button>();

        controls = new Controls();

        switch (inputButton)
        {
            case FaceButtons.A:
                controls.Menu.A.performed += OnButtonPress;
                break;
            case FaceButtons.B:
                controls.Menu.B.performed += OnButtonPress;
                break;
            case FaceButtons.X:
                controls.Menu.X.performed += OnButtonPress;
                break;
            case FaceButtons.Y:
                controls.Menu.Y.performed += OnButtonPress;
                break;
            default:
                break;
        }

        controls.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPress(InputAction.CallbackContext context)
    {
        button.onClick.Invoke();
    }
}
