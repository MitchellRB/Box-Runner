﻿using System.Collections;
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
    private bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        pc = gameObject.GetComponent<PlayerController>();
        rb = gameObject.GetComponent<Rigidbody>();
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
            pc.enabled = false;
            rb.constraints = RigidbodyConstraints.None;
            rb.AddTorque(Vector3.left);
            isDead = true;
        }
    }
}
