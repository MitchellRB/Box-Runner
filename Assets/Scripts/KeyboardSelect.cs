using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

[DisallowMultipleComponent]
public class KeyboardSelect : MonoBehaviour
{
    public GameObject arrow;
    public Vector3 arrowOffset;

    public KeyCode next;
    public KeyCode previous;
    public KeyCode select;

    private List<Button> buttons;
    private int selectedIndex;

    private Controls controls;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        // Limit frame rate
        Application.targetFrameRate = 60;

        buttons = new List<Button>();

        // Controls unavailable on mobile
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            arrow.SetActive(false);
        }
        else
        {
            yield return StartCoroutine("GetButtons");

            // Controls setup
            controls = new Controls();
            controls.Menu.Up.performed += MoveUp;
            controls.Menu.Down.performed += MoveDown;
            controls.Menu.Select.performed += Select;
            controls.Enable();
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (buttons.Count == 0) return;

        if (selectedIndex < 0) selectedIndex = buttons.Count - 1;
        if (selectedIndex >= buttons.Count) selectedIndex = 0;

        if (arrow != null)
        {
            arrow.transform.position = buttons[selectedIndex].transform.position + arrowOffset;
        }
    }

    // Add buttons to list after things can be disabled
    IEnumerator GetButtons()
    {
        yield return new WaitForEndOfFrame();
        buttons.AddRange(gameObject.GetComponentsInChildren<Button>(false));
    }

    void MoveUp(InputAction.CallbackContext context)
    {
        selectedIndex--;
    }

    void MoveDown(InputAction.CallbackContext context)
    {
        selectedIndex++;
    }

    private void Select(InputAction.CallbackContext context)
    {
        buttons[selectedIndex].onClick.Invoke();
    }
}
