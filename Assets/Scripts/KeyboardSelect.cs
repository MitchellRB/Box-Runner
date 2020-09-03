using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardSelect : MonoBehaviour
{
    public GameObject arrow;
    public Vector3 arrowOffset;

    public KeyCode next;
    public KeyCode previous;
    public KeyCode select;

    private Button[] buttons;
    private int selectedIndex;

    // Start is called before the first frame update
    void Start()
    {
        buttons = gameObject.GetComponentsInChildren<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(next))
        {
            selectedIndex++;
        }

        if (Input.GetKeyDown(previous))
        {
            selectedIndex--;
        }

        if (selectedIndex < 0) selectedIndex = buttons.Length - 1;
        if (selectedIndex >= buttons.Length) selectedIndex = 0;

        if (Input.GetKeyDown(select))
        {
            buttons[selectedIndex].onClick.Invoke();
        }

        if (arrow != null)
        {
            arrow.transform.position = buttons[selectedIndex].transform.position + arrowOffset;
        }
    }
}
