using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerController))]
public class PlayerCollision : MonoBehaviour
{
    public string obstacleTag;

    public Text deathText;

    private PlayerController pc;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        pc = gameObject.GetComponent<PlayerController>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(obstacleTag))
        {
            deathText.gameObject.SetActive(true);
            pc.enabled = false;
            rb.constraints = RigidbodyConstraints.None;
        }
    }
}
