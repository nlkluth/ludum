using UnityEngine;
using System.Collections;

public class Cannons : MonoBehaviour 
{
	public Transform[] spawnPositions;
	public GameObject cannonball;
	
	private int shotCount = 0;
	private Transform parentTransform;

	private void Awake()
	{
		parentTransform = gameObject.GetComponentInParent<Transform>();
	}

	public void CreateCannonball()
	{
		shotCount++;
		if (shotCount > 5)
		{
			shotCount = 0;
		}

		if (Input.mousePosition.y > parentTransform.position.y)
		{
			Debug.Log ("UP!");
		}
		
		Instantiate(cannonball, spawnPositions[shotCount].position, spawnPositions[shotCount].rotation);
	}
}
