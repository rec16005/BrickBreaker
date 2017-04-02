using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour {
	
	Vector3 padTras;
    float vel;

	// Use this for initialization
	void Start () {
		padTras = new Vector3(0.0f, 0.0f, 0.0f);
        vel = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
		padTras.x = 0.0f;
        padTras.y = 0.0f;
        padTras.z = 0.0f;
		
		if (Input.GetKey(KeyCode.RightArrow))
		{
			padTras.y = -vel * Time.deltaTime;
			transform.Translate(padTras);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
		{
			padTras.y = vel * Time.deltaTime;
			transform.Translate(padTras);
		}
		
	}
}
