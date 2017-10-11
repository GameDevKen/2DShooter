using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour 
{
	public Vector3 mousePos;
	public Transform player;
	public Vector3 objectPos;
	public float angle;

	void FixedUpdate ()
	{
		mousePos = Input.mousePosition;
		mousePos.z = 10;
		objectPos = Camera.main.WorldToScreenPoint (player.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		angle = Mathf.Atan2 (mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler (0, 0, angle - 90);
	}

}
