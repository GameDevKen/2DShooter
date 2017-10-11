using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
	//enemy prefab
	public GameObject enemy;

	//playerposition
	public Transform playerPos;

	//borders
	public Transform bTop;
	public Transform bBot;
	public Transform bLeft;
	public Transform bRight;


	// Use this for initialization
	void Start () {
		playerPos = GetComponent<Transform>();
		InvokeRepeating ("SpawnMany", 3, 4);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnMany()
	{
		Spawn ((int)playerPos.position.x, (int)playerPos.position.y);
		Spawn ((int)playerPos.position.x, (int)playerPos.position.y);
		Spawn ((int)playerPos.position.x, (int)playerPos.position.y);
		Spawn ((int)playerPos.position.x, (int)playerPos.position.y);
	}

	void Spawn(int playerPosX, int playerPosY) 
	{


		int x = (int)Random.Range (bLeft.position.x, bRight.position.x);
		if (x == playerPosX) 
		{
			x += 4;
		}

		int y = (int)Random.Range (bBot.position.y, bTop.position.y);

		if (y == playerPosY) 
		{
			y -= 4;
		}

		Instantiate (enemy, new Vector2 (x, y), Quaternion.identity);
	}
}
