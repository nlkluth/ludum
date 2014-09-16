using UnityEngine;
using System.Collections;

public class Cannons : MonoBehaviour 
{
	public Transform[] spawnPositions;
	public GameObject cannonball;
	public int ShotCount { get; set; }

	private Transform parentTransform;
	private Camera camera;

	private void Awake()
	{
		camera = GameObject.FindGameObjectWithTag("MainCamera").camera;
		parentTransform = gameObject.GetComponentInParent<Transform>();
		ShotCount = 0;
	}

	public void CreateCannonball()
	{
		if (ShotCount > 5)
		{
			ShotCount = 0;
		}

		var position = camera.ScreenToWorldPoint(Input.mousePosition);
		Instantiate(cannonball, spawnPositions[ShotCount].position, spawnPositions[ShotCount].rotation);
		ShotCount++;
	}
}
