using UnityEngine;
using System.Collections;

public class Cannons : MonoBehaviour 
{
	public Transform[] spawnPositions;
	public GameObject cannonball;
	
	private int shotCount = 0;

	public void CreateCannonball()
	{
		shotCount++;
		if (shotCount > 5)
		{
			shotCount = 0;
		}
		
		Instantiate(cannonball, spawnPositions[shotCount].position, spawnPositions[shotCount].rotation);
	}
}
