using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int lanes = 5;
    public int startLane = 2;

    public float jumpSpeed;
    public float jumpHeight;

    private int lanePosition;
    private bool canJump;

    private float sinCurvePosition;
    private float startYPos;

    private float startX;
    private float endX;

    // Start is called before the first frame update
    void Start()
    {
        lanePosition = startLane;
        canJump = true;
        startYPos = transform.position.y;
        startX = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Jump input
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            JumpLeft();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            JumpRight();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpUp();
        }

        // Jump movement
        if (sinCurvePosition >= Mathf.PI && canJump == false)
        {
            sinCurvePosition = Mathf.PI;
            canJump = true;
        }
        else if (canJump == false)
        {
            sinCurvePosition += jumpSpeed * Mathf.Deg2Rad;
            Vector3 newPos = new Vector3(Mathf.Lerp(startX, endX, sinCurvePosition / Mathf.PI), startYPos + Mathf.Sin(sinCurvePosition) * jumpHeight, 0);
            transform.position = newPos;
        }

        // Keep from falling through lane floor
        if (transform.position.y < startYPos) transform.position = new Vector3(transform.position.x, startYPos, transform.position.z);
    }

    void StartJump()
    {
        canJump = false;
        sinCurvePosition = 0;
    }

    void SetJumpEndpoints(float xs, float xe)
    {
        startX = transform.position.x + xs;
        endX = transform.position.x + xe;
    }

    // Jump functions

    public void JumpLeft()
    {
        if (lanePosition == 0 || !canJump) return;

        SetJumpEndpoints(0, -4);
        lanePosition--;
        StartJump();
    }

    public void JumpRight()
    {
        if (lanePosition == lanes - 1 || !canJump) return;

        SetJumpEndpoints(0, 4);
        lanePosition++;
        StartJump();
    }

    public void JumpUp()
    {
        if (!canJump) return;

        SetJumpEndpoints(0, 0);
        StartJump();
    }
}
