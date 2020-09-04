using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    // Start is called before the first frame update
    IEnumerator Start()
    {
        // Limit frame rate
        Application.targetFrameRate = 60;

        buttons = new List<Button>();
        yield return StartCoroutine("GetButtons");

        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            arrow.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (buttons.Count == 0) return;

        if (Input.GetKeyDown(next))
        {
            selectedIndex++;
        }

        if (Input.GetKeyDown(previous))
        {
            selectedIndex--;
        }

        if (selectedIndex < 0) selectedIndex = buttons.Count - 1;
        if (selectedIndex >= buttons.Count) selectedIndex = 0;

        if (Input.GetKeyDown(select))
        {
            buttons[selectedIndex].onClick.Invoke();
        }

        if (arrow != null)
        {
            arrow.transform.position = buttons[selectedIndex].transform.position + arrowOffset;
        }
    }

    IEnumerator GetButtons()
    {
        yield return new WaitForSecondsRealtime(0.02f);
        buttons.AddRange(gameObject.GetComponentsInChildren<Button>(false));
    }
}
