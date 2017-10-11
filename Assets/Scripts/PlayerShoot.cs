using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	public GameObject bullet;
	public Transform gun;
	public float speed;
	public static int bullets = 30;
	public bool hasBullets = true;

	void Start()
	{
		InvokeRepeating ("reload", 1, 5);
		
	}




	// Update is called once per frame
	void Update ()
	{
		bool thereIsBullet = bulletCheck(bullets);

		if (thereIsBullet) 
		{
			if (Input.GetKeyDown (KeyCode.Mouse0)) 
			{
				GameObject b = (GameObject)(Instantiate (bullet, gun.transform.position + (gun.transform.up * 1), Quaternion.identity));
				b.GetComponent<Rigidbody2D> ().AddForce (gun.transform.up * speed);
				bullets -= 1;
			}
		
		}
				
	}

	bool bulletCheck(int x)
	{
		int bulletLeft = x;
		if (bulletLeft > 0)
		{
			return true;
		}
		else
		{
			return false;
		}

	}

	void reload() 
	{
		bullets += 1;
	}
}
		
