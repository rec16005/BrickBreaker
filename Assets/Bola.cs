﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {
	
	public Rigidbody2D rb;
	public float force;

	// Use this for initialization
	void Start () {
		rb.AddForce (new Vector2 (force, force));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
