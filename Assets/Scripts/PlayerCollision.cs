using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerController))]
public class PlayerCollision : MonoBehaviour
{
    public string obstacleTag;

    public GameObject deathUI;

    private PlayerController pc;
    private Rigidbody rb;
    private ScoreCounter sc;
    private bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        pc = gameObject.GetComponent<PlayerController>();
        rb = gameObject.GetComponent<Rigidbody>();
        sc = gameObject.GetComponent<ScoreCounter>();
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            rb.AddForce(Vector3.back * 10);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(obstacleTag))
        {
            deathUI.SetActive(true);
            // Disable control and unlock rigidbody
            pc.enabled = false;
            rb.constraints = RigidbodyConstraints.None;
            rb.AddTorque(Vector3.right);
            sc.enabled = false;

            if (isDead == false)
            {
                SendMessage("SaveScore");
                SendMessage("StopControls");
                Time.timeScale = 0.5f;
                Time.fixedDeltaTime = 0.01f;
            }
            isDead = true;

#if UNITY_ANDROID || UNITY_IOS

            Handheld.Vibrate();
#endif
        }
    }


}
