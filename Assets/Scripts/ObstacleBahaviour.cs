using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBahaviour : MonoBehaviour
{
    // Start is called before the first frame update

    public float movementSpeed;
    public float destroyPosition;

    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        rb.AddForce(new Vector3(0, 0, -movementSpeed), ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Destroy when moved past player and behind camera
        if (transform.position.z < destroyPosition)
        {
            Destroy(gameObject);
        }
    }
}
