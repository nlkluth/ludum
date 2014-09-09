﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;

}

public class PlayerController : MonoBehaviour 
{
	public Boundary boundary;
	public float fireDelay;
	public float fireRate;
	public GameObject cannonball;
	public Transform shotSpawn;

	private PlayerInventory playerInventory;

	void Awake()
	{
		playerInventory = gameObject.GetComponent<PlayerInventory>();
	}

	void Update()
	{
		if (Input.GetButton("Fire1") && Time.time > fireDelay)
		{
			fireDelay = Time.time + fireRate;
			GameObject shot = Instantiate(cannonball, shotSpawn.position, shotSpawn.rotation) as GameObject;
			shot.transform.Translate(Vector3.up);
		}
	}
	
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);
		rigidbody2D.velocity = movement * playerInventory.Speed;

		rigidbody2D.position = new Vector3
		(
			Mathf.Clamp (rigidbody2D.position.x, boundary.xMin, boundary.xMax),
			Mathf.Clamp (rigidbody2D.position.y, boundary.yMin, boundary.yMax),
			0.0f
		);
	}
}
