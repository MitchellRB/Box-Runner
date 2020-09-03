using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int lanes = 5;
    public int start = 2;
    private int position;
    private bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        position = start;
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && position > 0 && canJump)
        {
            transform.position = new Vector3(transform.position.x - 4, transform.position.y, transform.position.z);
            position--;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && position < lanes - 1 && canJump)
        {
            transform.position = new Vector3(transform.position.x + 4, transform.position.y, transform.position.z);
            position++;
        }
    }
}
