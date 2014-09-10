using UnityEngine;
using System.Collections;

public class Cannons : MonoBehaviour 
{
	private Transform[] spawnPositions;
	private int shotCount = 0;

	public void CreateCannonball()
	{
		shotCount++;
		if (shotCount > 5)
		{
			shotCount = 0;
		}
		
		Instantiate(gameObject, spawnPositions[shotCount].position, spawnPositions[shotCount].rotation);
	}
}
