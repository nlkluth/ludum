using UnityEngine;
using System.Collections;

public class Cannonball : MonoBehaviour 
{
	public float Speed { get; set; }
	public Transform[] spawnPositions;
	
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

	public static void CreateCannonball()
	{
		shotCount++;
		if (shotCount > 5)
		{
			shotCount = 0;
		}

		Instantiate(gameObject, spawnPositions[shotCount].position, spawnPositions[shotCount].rotation);
	}
}