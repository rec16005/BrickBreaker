﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {
	
	private Rigidbody2D rb2d;
    private Vector2 vel;
	
	
	void GoBall()
    {
        float rand = Random.Range(0.0f, 2.0f);
        if (rand < 1.0f)
        {
            rb2d.AddForce(new Vector2(0.0f, -20.0f));
        }
        else
        {
            rb2d.AddForce(new Vector2(0.0f, -20.0f));
        }
    }
	
	void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f);
            rb2d.velocity = vel;
        }
    }
	
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
