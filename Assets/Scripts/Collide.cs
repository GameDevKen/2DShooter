using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		//bullets hitting the wall
		if (coll.gameObject.name == "Bottom")
		{
			Destroy (gameObject);
		}
		if (coll.gameObject.name == "Top")
		{
			Destroy (gameObject);
		}
		if (coll.gameObject.name == "Left")
		{
			Destroy (gameObject);
		}
		if (coll.gameObject.name == "Right")
		{
			Destroy (gameObject);
		}

		//bullet hitting the enemy
		if(coll.gameObject.name.StartsWith("enemy"))
		{
			Destroy (coll.gameObject);
			Destroy (gameObject);
			Score.scoreValue += 1;
			PlayerShoot.bullets += 1;
		}
			
	}


}
