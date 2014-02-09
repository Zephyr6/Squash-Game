﻿using UnityEngine;
using System.Collections;

public class SquampCollider : MonoBehaviour {

    public AudioClip clip = new AudioClip();
    public float TimeToSquamp = 5.0f;

    private bool isFalling = false;
    private float timer = 0;
    private Vector3 startPosition;
    private float fallSpeed = 10;


	// Use this for initialization
	void Start () {
        startPosition = transform.position;
        timer = TimeToSquamp;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer <= 0)
        {
            rigidbody2D.velocity = new Vector2(0, -fallSpeed);
            isFalling = true;
            timer = TimeToSquamp;
        }
        else
        {
            timer -= Time.deltaTime;
        }

        if (transform.position.y >= startPosition.y)
        {
            if (!isFalling)
            {
                rigidbody2D.velocity = Vector2.zero;
            }
        }

        if (GetComponentInChildren<SquampGrounded>().IsGrounded)
        {
            isFalling = false;
            rigidbody2D.velocity = new Vector2(0, fallSpeed * 0.3F);
        }

        if (GetComponentInChildren<SquampGrounded>().IsGrounded)
        {
            rigidbody2D.velocity = new Vector2(0, fallSpeed);
        }

        rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);

        if (transform.position == startPosition)
        {
            rigidbody2D.velocity = new Vector2(0, 0);
        }
	}
}
