using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneControlBehaviour : MonoBehaviour
{
    public float scrollSpeed;
    public float destroyThreshold = -30;
    public float respawnDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.z < destroyThreshold)
        {
            Vector3 resPos = new Vector3(0, 0, transform.position.z - destroyThreshold + respawnDistance);
            transform.position = resPos;
        }
        else
        {
            transform.Translate(0, 0, scrollSpeed * Time.fixedDeltaTime * -1);
        }
    }
}
