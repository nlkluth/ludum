using UnityEngine;
using System.Collections;

public class Cannonball : MonoBehaviour 
{
	public float Speed { get; set; }
	
	private static int shotCount = 0;

	void Awake()
	{
		Speed = 12f;
	}
	
	void Start()
	{
		Fire();
	}

	private void Fire()
	{
		shotCount++;
		rigidbody2D.velocity = transform.up * Speed;
	}
}