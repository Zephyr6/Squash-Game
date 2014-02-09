﻿using UnityEngine;
using System.Collections;

public class SquampCollider : MonoBehaviour {

    public float TimeToSquamp = 5.0f;

    private bool isFalling = false;
    private bool isRising = false;
    private float timer = 0;
    private Vector3 startPosition;
    private float fallSpeed = 10;
    private Squamper killer;

	// Use this for initialization
	void Start () {
        startPosition = transform.position;
        timer = TimeToSquamp;
        killer = GetComponentInChildren<Squamper>();
	}
	
	// Update is called once per frame
	void Update () {
        if (timer <= 0)
        {
            rigidbody2D.velocity = new Vector2(0, -fallSpeed);
            isFalling = true;
            killer.IsFalling = isFalling;
            timer = TimeToSquamp;
        }
        else
        {
            if (!isRising && !isFalling)
            {
                rigidbody2D.velocity = Vector2.zero;
            }
            timer -= Time.deltaTime;
        }

        if (transform.position.y >= startPosition.y)
        {
            if (!isFalling)
            {
                isRising = false;
                rigidbody2D.velocity = Vector2.zero;
            }
        }

        if (GetComponentInChildren<SquampGrounded>().IsGrounded)
        {
            isFalling = false;
            killer.IsFalling = isFalling;
            isRising = true;
            rigidbody2D.velocity = new Vector2(0, fallSpeed * 0.3F);
        }

        rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
	}
}
