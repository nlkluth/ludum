using UnityEngine;
using System.Collections;

public class Cannons : MonoBehaviour 
{
	public Transform[] spawnPositions;
	public GameObject cannonball;
	
	private int shotCount = 0;
	private Transform parentTransform;
	private Camera camera;

	private void Awake()
	{
		camera = GameObject.FindGameObjectWithTag("MainCamera").camera;
		parentTransform = gameObject.GetComponentInParent<Transform>();
	}

	public void CreateCannonball()
	{
		shotCount++;
		if (shotCount > 5)
		{
			shotCount = 0;
		}

		var position = camera.ScreenToWorldPoint(Input.mousePosition);

		if (position.y > parentTransform.position.y)
		{
			Debug.Log ("UP!");
		}
		
		Instantiate(cannonball, spawnPositions[shotCount].position, spawnPositions[shotCount].rotation);
	}
}
