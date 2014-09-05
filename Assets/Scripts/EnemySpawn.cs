using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour 
{
	public GameObject Enemy;
	public Vector3 sawnValues; 
	
	public float enemyStartWait; 
	public float enemySpawnWait; 
	public float enemyWaveCount; 
	public float enemyWaveWait;
	
	void Start()
	{
		StartCoroutine(SpawnEnemies());
	}
	
	IEnumerator SpawnEnemies()
	{
		yield return new WaitForSeconds(enemyStartWait);
		
		while (true)
		{
			for (int i = 0; i < enemyWaveCount; i++)
			{
				Vector3 spawnPosition = new Vector3(Random.Range());
				Quaternion spawnRotation = Quaternion.identity;
				yield return new WaitForSeconds(enemySpawnWait);
			}
			
			yield return new WaitForSeconds(enemyWaveWait);
		}
	}	
}
