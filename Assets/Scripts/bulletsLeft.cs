using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletsLeft : MonoBehaviour {
	Text bullet;

	// Use this for initialization
	void Start () {
		bullet = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		bullet.text = "Bullets = " + PlayerShoot.bullets;
	}
}
