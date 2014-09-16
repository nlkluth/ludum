using UnityEngine;
using System.Collections;

public class Cannonball : MonoBehaviour 
{
	public float Speed { get; set; }
	private GameObject player;
	private Cannons cannons;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		cannons = player.GetComponentInChildren<Cannons>();
		Speed = 12f;
	}
	
	void Start()
	{
		Fire();
	}

	private void Fire()
	{
		if (cannons.ShotCount % 2 == 1)
		{
			rigidbody2D.velocity = transform.up * Speed;
			return;
		}

		rigidbody2D.velocity = -(transform.up) * Speed;
	}
}