using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	//movement speed
	public float speed = 50;
	public float boost = 1.2f;

	void FixedUpdate() {
		//horizontal input
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		//set velocity movement
		if (Input.GetKey(KeyCode.LeftShift)) {
			GetComponent<Rigidbody2D>().velocity = (Vector2.right * h * speed * boost) + (Vector2.up * v * speed * boost);
		}
		else {
			GetComponent<Rigidbody2D>().velocity = (Vector2.right * h * speed) + (Vector2.up * v * speed);
		}

	}
}