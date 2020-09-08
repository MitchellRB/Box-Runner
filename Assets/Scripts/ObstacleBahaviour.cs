using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBahaviour : MonoBehaviour
{
    // Start is called before the first frame update

    public float movementSpeed;
    public float destroyPosition;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, 0, movementSpeed * Time.fixedDeltaTime * -1);

        if (transform.position.z < destroyPosition)
        {
            Destroy(gameObject);
        }
    }
}
