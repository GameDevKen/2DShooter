using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	//movement speed
	public float speed = 2f;	

	// Use this for initialization
	void Start () {
		//move the ball upward
		GetComponent<Rigidbody2D> ().velocity = randomVector() * speed;
		//move to random direction
		InvokeRepeating ("ChangeDirection", Timing(), RepeatTiming());
	}

	void ChangeDirection()
	{
		Vector2 change = new Vector2(Random.Range(-5,5), Random.Range(-5,5));
		GetComponent<Rigidbody2D>().velocity = change * speed;
	}

	int Timing()
	{
		return Random.Range (0, 5);	
	}

	int RepeatTiming()
	{
		return Random.Range (0, 3);
	}

	Vector2 randomVector()
	{
		int x = Random.Range (-1, 1);
		int y = Random.Range (-1, 1);

		Vector2 randomVector = new Vector2 (x, y);
		return randomVector;
	}


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "player") 
		{
			Destroy (coll.gameObject);
		}
	}

	/**
	void OnCollisionEnter2D(Collision2D coll)
	{
		enemyTransform = GetComponent<Transform> ();
		int x = gameObject.transform.x;
		int y = gameObject.transform.y;

		Vector2 turn = new Vector2 (-x, -y);
		GetComponent<Rigidbody2D> ().velocity = turn * speed;
	}
		


	**/


}
