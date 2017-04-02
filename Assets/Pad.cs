using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal");

		if (x > 0) {
			moveRight ();
		}
		if (x < 0) {
			moveLeft ();
		}
		if (x == 0) {
			stop ();
		}
		
	}
	
	void moveLeft(){
		rb.velocity = new Vector2 (-speed,0);
	}
	void moveRight(){
		rb.velocity = new Vector2 (speed,0);
	}
	void stop(){
		rb.velocity = Vector2.zero;
	}
}
